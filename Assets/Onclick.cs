using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Onclick : MonoBehaviour
{
    public void changescene(int sceneid)
    {
        SceneManager.LoadScene(sceneid);
    }
}
