﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireCube : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "cube")
        {

            other.gameObject.transform.parent.gameObject.GetComponent<PlayerController>().pos.transform.position += new Vector3(0, 0.6f, 0);
            other.gameObject.transform.parent.gameObject.GetComponent<PlayerController>().RemoveCube();
            other.gameObject.transform.parent = null;
            Destroy(other.gameObject);

        }


    }
}
