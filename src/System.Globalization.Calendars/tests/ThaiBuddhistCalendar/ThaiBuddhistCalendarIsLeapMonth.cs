// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Globalization;
using Xunit;

namespace System.Globalization.CalendarsTests
{
    // System.Globalization.ThaiBuddhistCalendar.IsLeapMonth(Int32,Int32,Int32)
    public class ThaiBuddhistCalendarIsLeapMonth
    {
        #region Positive Tests
        // PosTest1: Verify IsLeapMonth is false
        [Fact]
        public void PosTest1()
        {
            System.Globalization.Calendar tbc = new ThaiBuddhistCalendar();
            Random rand = new Random(-55);
            int year = rand.Next(tbc.MinSupportedDateTime.Year + 543, tbc.MaxSupportedDateTime.Year + 543);
            int month = rand.Next(1, 13);
            int era;
            for (int i = 0; i < tbc.Eras.Length; i++)
            {
                era = tbc.Eras[i];
                Assert.False(tbc.IsLeapMonth(year, month, era));
            }
        }

        // PosTest2: Verify year is 2000 and month is 2
        [Fact]
        public void PosTest2()
        {
            System.Globalization.Calendar tbc = new ThaiBuddhistCalendar();
            Random rand = new Random(-55);
            int year = 2000 + 543;
            int month = 2;
            int era;
            for (int i = 0; i < tbc.Eras.Length; i++)
            {
                era = tbc.Eras[i];
                Assert.False(tbc.IsLeapMonth(year, month, era));
            }
        }

        // PosTest3: Verify the year is ThaiBuddhistCalendar MinSupportedDateTime.Year
        // and month is ThaiBuddhistCalendar MinSupportedDateTime.Month 
        [Fact]
        public void PosTest3()
        {
            System.Globalization.Calendar tbc = new ThaiBuddhistCalendar();
            Random rand = new Random(-55);
            int year = tbc.MinSupportedDateTime.Year + 543;
            int month = tbc.MinSupportedDateTime.Month;
            int era;
            for (int i = 0; i < tbc.Eras.Length; i++)
            {
                era = tbc.Eras[i];
                Assert.False(tbc.IsLeapDay(year, month, era));
            }
        }

        // PosTest4: Verify the year is ThaiBuddhistCalendar MaxSupportedDateTime.Year
        // and month is ThaiBuddhistCalendar MaxSupportedDateTime.Month
        [Fact]
        public void PosTest4()
        {
            System.Globalization.Calendar tbc = new ThaiBuddhistCalendar();
            Random rand = new Random(-55);
            int year = tbc.MaxSupportedDateTime.Year + 543;
            int month = tbc.MaxSupportedDateTime.Month;
            int era;
            for (int i = 0; i < tbc.Eras.Length; i++)
            {
                era = tbc.Eras[i];
                Assert.False(tbc.IsLeapMonth(year, month, era));
            }
        }
        #endregion
    }
}