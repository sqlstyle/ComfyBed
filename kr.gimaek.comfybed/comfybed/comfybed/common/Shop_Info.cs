﻿using System;
using System.Collections.Generic;
using System.Text;

namespace comfybed.common
{
    class Shop_Info
    {
        public string Shop_Name { get; set; } //모텔이름
        public string Shop_Address { get; set; } //모텔주소
        public string Shop_CallNum { get; set; }
        public double xy { get; set; } //모텔위치
        public string ceo { get; set; } //주인장이름
        public string BsNumber { get; set; } //사업자번호
        public string Rentroom_minprice { get; set; } //대실 최저가
        public string Sleeproom_minprice { get; set; } //숙박 최저가
        public string place { get; set; }


        public string Image_Url
        {
            get
            {
                string url = "https://slimeplanet.cafe24.com/comfybed/image/";

                if (Shop_Name.Equals("리치웰"))
                {
                    return url + "richwell.jpg";
                }
                else if (Shop_Name.Equals("아티스트"))
                {
                    return url + "artist.png";
                }
                return null;
            }
        }


    }


}
