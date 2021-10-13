using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class Player : NetworkBehaviour
{
    // Start is called before the first frame update
    void HandleMovement()
    {
        if (isLocalPlayer)
        {
            float moveHorizental = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");
            Vector3 movement = new Vector3(moveHorizental * 0.1f, moveVertical * 0.1f, 0);
            transform.position = transform.position + movement;
        }
    }
    private void Update()
    {
        HandleMovement();
    }
}
