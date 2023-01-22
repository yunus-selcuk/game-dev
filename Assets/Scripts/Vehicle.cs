using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    public GameObject mycar;
    public GameObject myyacht;
    public GameObject areacar;
    public GameObject areayacht;
    public GameObject playerStickMan;
    public GameObject player;
    public GameObject playerMounts;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Car"))
        {
            mycar.SetActive(true);
            areacar.SetActive(false);
            playerMounts.SetActive(false);
            playerStickMan.SetActive(false);
            player.GetComponent<PlayerMove>().speed = 35;
        }

        if (other.CompareTag("Yacht"))
        {
            myyacht.SetActive(true);
            areayacht.SetActive(false);
            playerStickMan.SetActive(false);
            playerMounts.SetActive(false);
            player.transform.position = new Vector3(-334.8F, 2F, 146.56F);
            player.GetComponent<PlayerMove>().speed = 39;
        }
    }

    public void ExitCar()
    {
        mycar.SetActive(false);
        areacar.SetActive(true);
        areacar.transform.position = new Vector3(this.transform.position.x + 5, 2.452207F, this.transform.position.z);
        playerStickMan.SetActive(true);
        playerMounts.SetActive(true);
        player.GetComponent<PlayerMove>().speed = 22;
    }

    public void ExitYacth()
    {
        myyacht.SetActive(false);
        areayacht.SetActive(true);
        playerMounts.SetActive(true);
        this.transform.position = new Vector3(-333.9F, 0.03999996F, 121.98F);
        playerStickMan.SetActive(true);
        player.GetComponent<PlayerMove>().speed = 22;
    }
}