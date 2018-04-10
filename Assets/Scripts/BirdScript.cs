using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour {

    public float jumpForse = 2f;
    public Rigidbody2D rb;
    public float ForwardSpeed = 2f;
    public GameObject cam;
    public bool dead = false;
    public float x; 
    

	// Use this for initialization
	void Start () {
        Debug.Log("Start");
        rb= GetComponent<Rigidbody2D>();
        //x = rb.transform.position.x;
    }
	
	// Update is called once per frame
	void Update () {        
        if (dead == false) { 
            rb.transform.Translate(new Vector3(1, 0, 0) * ForwardSpeed * Time.deltaTime);
            cam.transform.Translate(new Vector3(1, 0, 0) * ForwardSpeed * Time.deltaTime);
            if (Input.GetButtonDown("Jump"))
            {
                rb.velocity = Vector2.zero;
                rb.AddForce(Vector2.up * jumpForse);
            }
        }
        if (rb.transform.position.x > 30)
        {
            dead = true;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        dead = true;
    }
}
