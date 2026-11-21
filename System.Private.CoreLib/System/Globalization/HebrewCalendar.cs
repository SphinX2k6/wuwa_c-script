using System;
using System.Runtime.CompilerServices;

namespace System.Globalization
{
	// Token: 0x020002F0 RID: 752
	public class HebrewCalendar : Calendar
	{
		// Token: 0x17000A51 RID: 2641
		// (get) Token: 0x0600371A RID: 14106 RVA: 0x000B4795 File Offset: 0x000B2995
		private unsafe static ReadOnlySpan<byte> HebrewTable
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.A72EB4166B1B422391E0F6E483BEF87AE75881E655BCB152E37F3D9688B2AA71), 1316);
			}
		}

		// Token: 0x17000A52 RID: 2642
		// (get) Token: 0x0600371B RID: 14107 RVA: 0x000B47A6 File Offset: 0x000B29A6
		private unsafe static ReadOnlySpan<byte> LunarMonthLen
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.582395A131FD1F6A949789B4B29B6A7E75B48DA700E8EF0842000BD9280CB880), 98);
			}
		}

		// Token: 0x17000A53 RID: 2643
		// (get) Token: 0x0600371C RID: 14108 RVA: 0x000B47B4 File Offset: 0x000B29B4
		public override DateTime MinSupportedDateTime
		{
			get
			{
				return HebrewCalendar.s_calendarMinValue;
			}
		}

		// Token: 0x17000A54 RID: 2644
		// (get) Token: 0x0600371D RID: 14109 RVA: 0x000B47BB File Offset: 0x000B29BB
		public override DateTime MaxSupportedDateTime
		{
			get
			{
				return HebrewCalendar.s_calendarMaxValue;
			}
		}

		// Token: 0x17000A55 RID: 2645
		// (get) Token: 0x0600371E RID: 14110 RVA: 0x0001FC46 File Offset: 0x0001DE46
		public override CalendarAlgorithmType AlgorithmType
		{
			get
			{
				return CalendarAlgorithmType.LunisolarCalendar;
			}
		}

		// Token: 0x17000A56 RID: 2646
		// (get) Token: 0x06003720 RID: 14112 RVA: 0x0002EBDD File Offset: 0x0002CDDD
		internal override CalendarId ID
		{
			get
			{
				return CalendarId.HEBREW;
			}
		}

		// Token: 0x06003721 RID: 14113 RVA: 0x000B47C4 File Offset: 0x000B29C4
		private static void CheckHebrewYearValue(int y, int era, string varName)
		{
			HebrewCalendar.CheckEraRange(era);
			if (y > 5999 || y < 5343)
			{
				throw new ArgumentOutOfRangeException(varName, y, SR.Format(SR.ArgumentOutOfRange_Range, 5343, 5999));
			}
		}

		// Token: 0x06003722 RID: 14114 RVA: 0x000B4814 File Offset: 0x000B2A14
		private void CheckHebrewMonthValue(int year, int month, int era)
		{
			int monthsInYear = this.GetMonthsInYear(year, era);
			if (month < 1 || month > monthsInYear)
			{
				throw new ArgumentOutOfRangeException("month", month, SR.Format(SR.ArgumentOutOfRange_Range, 1, monthsInYear));
			}
		}

		// Token: 0x06003723 RID: 14115 RVA: 0x000B485C File Offset: 0x000B2A5C
		private void CheckHebrewDayValue(int year, int month, int day, int era)
		{
			int daysInMonth = this.GetDaysInMonth(year, month, era);
			if (day < 1 || day > daysInMonth)
			{
				throw new ArgumentOutOfRangeException("day", day, SR.Format(SR.ArgumentOutOfRange_Range, 1, daysInMonth));
			}
		}

		// Token: 0x06003724 RID: 14116 RVA: 0x000B48A3 File Offset: 0x000B2AA3
		private static void CheckEraRange(int era)
		{
			if (era != 0 && era != HebrewCalendar.HebrewEra)
			{
				throw new ArgumentOutOfRangeException("era", era, SR.ArgumentOutOfRange_InvalidEraValue);
			}
		}

		// Token: 0x06003725 RID: 14117 RVA: 0x000B48C8 File Offset: 0x000B2AC8
		private static void CheckTicksRange(long ticks)
		{
			if (ticks < HebrewCalendar.s_calendarMinValue.Ticks || ticks > HebrewCalendar.s_calendarMaxValue.Ticks)
			{
				throw new ArgumentOutOfRangeException("time", ticks, SR.Format(CultureInfo.InvariantCulture, SR.ArgumentOutOfRange_CalendarRange, HebrewCalendar.s_calendarMinValue, HebrewCalendar.s_calendarMaxValue));
			}
		}

		// Token: 0x06003726 RID: 14118 RVA: 0x000B4924 File Offset: 0x000B2B24
		private static int GetResult(HebrewCalendar.DateBuffer result, int part)
		{
			switch (part)
			{
			case 0:
				return result.year;
			case 2:
				return result.month;
			case 3:
				return result.day;
			}
			throw new InvalidOperationException(SR.InvalidOperation_DateTimeParsing);
		}

		// Token: 0x06003727 RID: 14119 RVA: 0x000B4970 File Offset: 0x000B2B70
		internal unsafe static int GetLunarMonthDay(int gregorianYear, HebrewCalendar.DateBuffer lunarDate)
		{
			int num = gregorianYear - 1583;
			ArgumentOutOfRangeException.ThrowIfNegative<int>(num, "gregorianYear");
			ArgumentOutOfRangeException.ThrowIfGreaterThan<int>(num, 656, "gregorianYear");
			num *= 2;
			lunarDate.day = (int)(*HebrewCalendar.HebrewTable[num]);
			int result = (int)(*HebrewCalendar.HebrewTable[num + 1]);
			int day = lunarDate.day;
			if (day != 0)
			{
				switch (day)
				{
				case 30:
					lunarDate.month = 3;
					break;
				case 31:
					lunarDate.month = 5;
					lunarDate.day = 2;
					break;
				case 32:
					lunarDate.month = 5;
					lunarDate.day = 3;
					break;
				case 33:
					lunarDate.month = 3;
					lunarDate.day = 29;
					break;
				default:
					lunarDate.month = 4;
					break;
				}
			}
			else
			{
				lunarDate.month = 5;
				lunarDate.day = 1;
			}
			return result;
		}

		// Token: 0x06003728 RID: 14120 RVA: 0x000B4A44 File Offset: 0x000B2C44
		private unsafe static int GetDatePart(long ticks, int part)
		{
			HebrewCalendar.CheckTicksRange(ticks);
			DateTime dateTime = new DateTime(ticks);
			int num;
			int num2;
			int num3;
			dateTime.GetDate(out num, out num2, out num3);
			HebrewCalendar.DateBuffer dateBuffer = new HebrewCalendar.DateBuffer();
			dateBuffer.year = num + 3760;
			int num4 = HebrewCalendar.GetLunarMonthDay(num, dateBuffer);
			HebrewCalendar.DateBuffer dateBuffer2 = new HebrewCalendar.DateBuffer();
			dateBuffer2.year = dateBuffer.year;
			dateBuffer2.month = dateBuffer.month;
			dateBuffer2.day = dateBuffer.day;
			long absoluteDate = GregorianCalendar.GetAbsoluteDate(num, num2, num3);
			if (num2 == 1 && num3 == 1)
			{
				return HebrewCalendar.GetResult(dateBuffer2, part);
			}
			long num5 = absoluteDate - GregorianCalendar.GetAbsoluteDate(num, 1, 1);
			if (num5 + (long)dateBuffer.day <= (long)((ulong)(*HebrewCalendar.LunarMonthLen[num4 * 14 + dateBuffer.month])))
			{
				dateBuffer2.day += (int)num5;
				return HebrewCalendar.GetResult(dateBuffer2, part);
			}
			dateBuffer2.month++;
			dateBuffer2.day = 1;
			num5 -= (long)((int)(*HebrewCalendar.LunarMonthLen[num4 * 14 + dateBuffer.month]) - dateBuffer.day);
			if (num5 > 1L)
			{
				while (num5 > (long)((ulong)(*HebrewCalendar.LunarMonthLen[num4 * 14 + dateBuffer2.month])))
				{
					long num6 = num5;
					ReadOnlySpan<byte> lunarMonthLen = HebrewCalendar.LunarMonthLen;
					int num7 = num4 * 14;
					HebrewCalendar.DateBuffer dateBuffer3 = dateBuffer2;
					int month = dateBuffer3.month;
					dateBuffer3.month = month + 1;
					num5 = num6 - (long)((ulong)(*lunarMonthLen[num7 + month]));
					if (dateBuffer2.month > 13 || *HebrewCalendar.LunarMonthLen[num4 * 14 + dateBuffer2.month] == 0)
					{
						dateBuffer2.year++;
						num4 = (int)(*HebrewCalendar.HebrewTable[(num + 1 - 1583) * 2 + 1]);
						dateBuffer2.month = 1;
					}
				}
				dateBuffer2.day += (int)(num5 - 1L);
			}
			return HebrewCalendar.GetResult(dateBuffer2, part);
		}

		// Token: 0x06003729 RID: 14121 RVA: 0x000B4C40 File Offset: 0x000B2E40
		public override DateTime AddMonths(DateTime time, int months)
		{
			DateTime result;
			try
			{
				int num = HebrewCalendar.GetDatePart(time.Ticks, 0);
				int datePart = HebrewCalendar.GetDatePart(time.Ticks, 2);
				int num2 = HebrewCalendar.GetDatePart(time.Ticks, 3);
				int i;
				if (months >= 0)
				{
					int monthsInYear;
					for (i = datePart + months; i > (monthsInYear = this.GetMonthsInYear(num, 0)); i -= monthsInYear)
					{
						num++;
					}
				}
				else if ((i = datePart + months) <= 0)
				{
					months = -months;
					months -= datePart;
					num--;
					int monthsInYear;
					while (months > (monthsInYear = this.GetMonthsInYear(num, 0)))
					{
						num--;
						months -= monthsInYear;
					}
					monthsInYear = this.GetMonthsInYear(num, 0);
					i = monthsInYear - months;
				}
				int daysInMonth = this.GetDaysInMonth(num, i);
				if (num2 > daysInMonth)
				{
					num2 = daysInMonth;
				}
				result = this.ToDateTime(num, i, num2, 0, 0, 0, 0);
				result = new DateTime(result.Ticks + time.Ticks % 864000000000L);
			}
			catch (ArgumentException)
			{
				throw new ArgumentOutOfRangeException("months", months, SR.ArgumentOutOfRange_AddValue);
			}
			return result;
		}

		// Token: 0x0600372A RID: 14122 RVA: 0x000B4D48 File Offset: 0x000B2F48
		public override DateTime AddYears(DateTime time, int years)
		{
			int num = HebrewCalendar.GetDatePart(time.Ticks, 0);
			int num2 = HebrewCalendar.GetDatePart(time.Ticks, 2);
			int num3 = HebrewCalendar.GetDatePart(time.Ticks, 3);
			num += years;
			HebrewCalendar.CheckHebrewYearValue(num, 0, "years");
			int monthsInYear = this.GetMonthsInYear(num, 0);
			if (num2 > monthsInYear)
			{
				num2 = monthsInYear;
			}
			int daysInMonth = this.GetDaysInMonth(num, num2);
			if (num3 > daysInMonth)
			{
				num3 = daysInMonth;
			}
			long ticks = this.ToDateTime(num, num2, num3, 0, 0, 0, 0).Ticks + time.Ticks % 864000000000L;
			Calendar.CheckAddResult(ticks, this.MinSupportedDateTime, this.MaxSupportedDateTime);
			return new DateTime(ticks);
		}

		// Token: 0x0600372B RID: 14123 RVA: 0x000B4DEF File Offset: 0x000B2FEF
		public override int GetDayOfMonth(DateTime time)
		{
			return HebrewCalendar.GetDatePart(time.Ticks, 3);
		}

		// Token: 0x0600372C RID: 14124 RVA: 0x000B3BE7 File Offset: 0x000B1DE7
		public override DayOfWeek GetDayOfWeek(DateTime time)
		{
			return time.DayOfWeek;
		}

		// Token: 0x0600372D RID: 14125 RVA: 0x000B4E00 File Offset: 0x000B3000
		internal unsafe static int GetHebrewYearType(int year, int era)
		{
			HebrewCalendar.CheckHebrewYearValue(year, era, "year");
			return (int)(*HebrewCalendar.HebrewTable[(year - 3760 - 1583) * 2 + 1]);
		}

		// Token: 0x0600372E RID: 14126 RVA: 0x000B4E38 File Offset: 0x000B3038
		public override int GetDayOfYear(DateTime time)
		{
			int year = this.GetYear(time);
			DateTime dateTime;
			if (year == 5343)
			{
				dateTime = new DateTime(1582, 9, 27);
			}
			else
			{
				dateTime = this.ToDateTime(year, 1, 1, 0, 0, 0, 0, 0);
			}
			return (int)((time.Ticks - dateTime.Ticks) / 864000000000L) + 1;
		}

		// Token: 0x0600372F RID: 14127 RVA: 0x000B4E94 File Offset: 0x000B3094
		public unsafe override int GetDaysInMonth(int year, int month, int era)
		{
			HebrewCalendar.CheckEraRange(era);
			int hebrewYearType = HebrewCalendar.GetHebrewYearType(year, era);
			this.CheckHebrewMonthValue(year, month, era);
			byte b = *HebrewCalendar.LunarMonthLen[hebrewYearType * 14 + month];
			if (b == 0)
			{
				ThrowHelper.ThrowArgumentOutOfRange_Month(month);
			}
			return (int)b;
		}

		// Token: 0x06003730 RID: 14128 RVA: 0x000B4ED8 File Offset: 0x000B30D8
		public override int GetDaysInYear(int year, int era)
		{
			HebrewCalendar.CheckEraRange(era);
			int hebrewYearType = HebrewCalendar.GetHebrewYearType(year, era);
			if (hebrewYearType < 4)
			{
				return 352 + hebrewYearType;
			}
			return 382 + (hebrewYearType - 3);
		}

		// Token: 0x06003731 RID: 14129 RVA: 0x000B4F08 File Offset: 0x000B3108
		public override int GetEra(DateTime time)
		{
			return HebrewCalendar.HebrewEra;
		}

		// Token: 0x17000A57 RID: 2647
		// (get) Token: 0x06003732 RID: 14130 RVA: 0x000B4F0F File Offset: 0x000B310F
		[Nullable(1)]
		public override int[] Eras
		{
			[NullableContext(1)]
			get
			{
				return new int[]
				{
					HebrewCalendar.HebrewEra
				};
			}
		}

		// Token: 0x06003733 RID: 14131 RVA: 0x000B4F1F File Offset: 0x000B311F
		public override int GetMonth(DateTime time)
		{
			return HebrewCalendar.GetDatePart(time.Ticks, 2);
		}

		// Token: 0x06003734 RID: 14132 RVA: 0x000B4F2E File Offset: 0x000B312E
		public override int GetMonthsInYear(int year, int era)
		{
			if (!this.IsLeapYear(year, era))
			{
				return 12;
			}
			return 13;
		}

		// Token: 0x06003735 RID: 14133 RVA: 0x000B4F3F File Offset: 0x000B313F
		public override int GetYear(DateTime time)
		{
			return HebrewCalendar.GetDatePart(time.Ticks, 0);
		}

		// Token: 0x06003736 RID: 14134 RVA: 0x000B4F4E File Offset: 0x000B314E
		public override bool IsLeapDay(int year, int month, int day, int era)
		{
			if (this.IsLeapMonth(year, month, era))
			{
				this.CheckHebrewDayValue(year, month, day, era);
				return true;
			}
			if (this.IsLeapYear(year, 0) && month == 6 && day == 30)
			{
				return true;
			}
			this.CheckHebrewDayValue(year, month, day, era);
			return false;
		}

		// Token: 0x06003737 RID: 14135 RVA: 0x000B4F8A File Offset: 0x000B318A
		public override int GetLeapMonth(int year, int era)
		{
			if (this.IsLeapYear(year, era))
			{
				return 7;
			}
			return 0;
		}

		// Token: 0x06003738 RID: 14136 RVA: 0x000B4F99 File Offset: 0x000B3199
		public override bool IsLeapMonth(int year, int month, int era)
		{
			bool flag = this.IsLeapYear(year, era);
			this.CheckHebrewMonthValue(year, month, era);
			return flag && month == 7;
		}

		// Token: 0x06003739 RID: 14137 RVA: 0x000B4FB4 File Offset: 0x000B31B4
		public override bool IsLeapYear(int year, int era)
		{
			HebrewCalendar.CheckHebrewYearValue(year, era, "year");
			return (7L * (long)year + 1L) % 19L < 7L;
		}

		// Token: 0x0600373A RID: 14138 RVA: 0x000B4FD4 File Offset: 0x000B31D4
		private unsafe static int GetDayDifference(int lunarYearType, int month1, int day1, int month2, int day2)
		{
			if (month1 == month2)
			{
				return day1 - day2;
			}
			bool flag = month1 > month2;
			if (flag)
			{
				int num = month1;
				int num2 = day1;
				month1 = month2;
				day1 = day2;
				month2 = num;
				day2 = num2;
			}
			int num3 = (int)(*HebrewCalendar.LunarMonthLen[lunarYearType * 14 + month1]) - day1;
			month1++;
			while (month1 < month2)
			{
				num3 += (int)(*HebrewCalendar.LunarMonthLen[lunarYearType * 14 + month1++]);
			}
			num3 += day2;
			if (!flag)
			{
				return -num3;
			}
			return num3;
		}

		// Token: 0x0600373B RID: 14139 RVA: 0x000B504C File Offset: 0x000B324C
		private static DateTime HebrewToGregorian(int hebrewYear, int hebrewMonth, int hebrewDay, int hour, int minute, int second, int millisecond)
		{
			int num = hebrewYear - 3760;
			HebrewCalendar.DateBuffer dateBuffer = new HebrewCalendar.DateBuffer();
			int lunarMonthDay = HebrewCalendar.GetLunarMonthDay(num, dateBuffer);
			if (hebrewMonth == dateBuffer.month && hebrewDay == dateBuffer.day)
			{
				return new DateTime(num, 1, 1, hour, minute, second, millisecond);
			}
			int dayDifference = HebrewCalendar.GetDayDifference(lunarMonthDay, hebrewMonth, hebrewDay, dateBuffer.month, dateBuffer.day);
			DateTime dateTime = new DateTime(num, 1, 1);
			return new DateTime(dateTime.Ticks + (long)dayDifference * 864000000000L + Calendar.TimeToTicks(hour, minute, second, millisecond));
		}

		// Token: 0x0600373C RID: 14140 RVA: 0x000B50D8 File Offset: 0x000B32D8
		public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era)
		{
			HebrewCalendar.CheckHebrewYearValue(year, era, "year");
			this.CheckHebrewMonthValue(year, month, era);
			this.CheckHebrewDayValue(year, month, day, era);
			DateTime result = HebrewCalendar.HebrewToGregorian(year, month, day, hour, minute, second, millisecond);
			HebrewCalendar.CheckTicksRange(result.Ticks);
			return result;
		}

		// Token: 0x17000A58 RID: 2648
		// (get) Token: 0x0600373D RID: 14141 RVA: 0x000B5125 File Offset: 0x000B3325
		// (set) Token: 0x0600373E RID: 14142 RVA: 0x000B514C File Offset: 0x000B334C
		public override int TwoDigitYearMax
		{
			get
			{
				if (this._twoDigitYearMax == -1)
				{
					this._twoDigitYearMax = Calendar.GetSystemTwoDigitYearSetting(this.ID, 5790);
				}
				return this._twoDigitYearMax;
			}
			set
			{
				base.VerifyWritable();
				if (value != 99)
				{
					HebrewCalendar.CheckHebrewYearValue(value, HebrewCalendar.HebrewEra, "value");
				}
				this._twoDigitYearMax = value;
			}
		}

		// Token: 0x0600373F RID: 14143 RVA: 0x000B5170 File Offset: 0x000B3370
		public override int ToFourDigitYear(int year)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(year, "year");
			if (year < 100)
			{
				return base.ToFourDigitYear(year);
			}
			if (year > 5999 || year < 5343)
			{
				throw new ArgumentOutOfRangeException("year", year, SR.Format(SR.ArgumentOutOfRange_Range, 5343, 5999));
			}
			return year;
		}

		// Token: 0x04000AA4 RID: 2724
		public static readonly int HebrewEra = 1;

		// Token: 0x04000AA5 RID: 2725
		private static readonly DateTime s_calendarMinValue = new DateTime(1583, 1, 1);

		// Token: 0x04000AA6 RID: 2726
		private static readonly DateTime s_calendarMaxValue = new DateTime(new DateTime(2239, 9, 29, 23, 59, 59, 999).Ticks + 9999L);

		// Token: 0x020002F1 RID: 753
		internal sealed class DateBuffer
		{
			// Token: 0x04000AA7 RID: 2727
			internal int year;

			// Token: 0x04000AA8 RID: 2728
			internal int month;

			// Token: 0x04000AA9 RID: 2729
			internal int day;
		}
	}
}
