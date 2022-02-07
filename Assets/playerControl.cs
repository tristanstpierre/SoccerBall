using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 10f;

    private float xInput;
    private float zInput;


    // Start is called before the first frame update
    void awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInputs();
    }

    private void FixedUpdate() 
    {
        Move();
    }

    private void ProcessInputs()
    {
	xInput = Input.GetAxis("Horizontal");
	zInput = Input.GetAxis("Vertical");

    }

    private void Move()
    {
        rb.AddForce(new Vector3(xInput, 0f, zInput) * speed);
    }
}
