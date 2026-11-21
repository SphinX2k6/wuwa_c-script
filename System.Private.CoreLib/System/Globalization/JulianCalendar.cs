using System;
using System.Runtime.CompilerServices;

namespace System.Globalization
{
	// Token: 0x02000301 RID: 769
	[NullableContext(1)]
	[Nullable(0)]
	public class JulianCalendar : Calendar
	{
		// Token: 0x17000A7B RID: 2683
		// (get) Token: 0x060037EF RID: 14319 RVA: 0x000A4701 File Offset: 0x000A2901
		public override DateTime MinSupportedDateTime
		{
			get
			{
				return DateTime.MinValue;
			}
		}

		// Token: 0x17000A7C RID: 2684
		// (get) Token: 0x060037F0 RID: 14320 RVA: 0x000A4708 File Offset: 0x000A2908
		public override DateTime MaxSupportedDateTime
		{
			get
			{
				return DateTime.MaxValue;
			}
		}

		// Token: 0x17000A7D RID: 2685
		// (get) Token: 0x060037F1 RID: 14321 RVA: 0x000070DD File Offset: 0x000052DD
		public override CalendarAlgorithmType AlgorithmType
		{
			get
			{
				return CalendarAlgorithmType.SolarCalendar;
			}
		}

		// Token: 0x060037F2 RID: 14322 RVA: 0x000B8870 File Offset: 0x000B6A70
		public JulianCalendar()
		{
			this._twoDigitYearMax = 2049;
		}

		// Token: 0x17000A7E RID: 2686
		// (get) Token: 0x060037F3 RID: 14323 RVA: 0x0005867D File Offset: 0x0005687D
		internal override CalendarId ID
		{
			get
			{
				return CalendarId.JULIAN;
			}
		}

		// Token: 0x060037F4 RID: 14324 RVA: 0x000B888E File Offset: 0x000B6A8E
		internal static void CheckEraRange(int era)
		{
			if (era != 0 && era != JulianCalendar.JulianEra)
			{
				throw new ArgumentOutOfRangeException("era", era, SR.ArgumentOutOfRange_InvalidEraValue);
			}
		}

		// Token: 0x060037F5 RID: 14325 RVA: 0x000B88B4 File Offset: 0x000B6AB4
		internal void CheckYearEraRange(int year, int era)
		{
			JulianCalendar.CheckEraRange(era);
			if (year <= 0 || year > this.MaxYear)
			{
				throw new ArgumentOutOfRangeException("year", year, SR.Format(SR.ArgumentOutOfRange_Range, 1, this.MaxYear));
			}
		}

		// Token: 0x060037F6 RID: 14326 RVA: 0x000B8900 File Offset: 0x000B6B00
		internal static void CheckMonthRange(int month)
		{
			if (month < 1 || month > 12)
			{
				ThrowHelper.ThrowArgumentOutOfRange_Month(month);
			}
		}

		// Token: 0x060037F7 RID: 14327 RVA: 0x000B8914 File Offset: 0x000B6B14
		internal unsafe static void CheckDayRange(int year, int month, int day)
		{
			if (year == 1 && month == 1 && day < 3)
			{
				throw new ArgumentOutOfRangeException(null, SR.ArgumentOutOfRange_BadYearMonthDay);
			}
			ReadOnlySpan<int> readOnlySpan = (year % 4 == 0) ? GregorianCalendar.DaysToMonth366 : GregorianCalendar.DaysToMonth365;
			int num = *readOnlySpan[month] - *readOnlySpan[month - 1];
			if (day < 1 || day > num)
			{
				throw new ArgumentOutOfRangeException("day", day, SR.Format(SR.ArgumentOutOfRange_Range, 1, num));
			}
		}

		// Token: 0x060037F8 RID: 14328 RVA: 0x000B8994 File Offset: 0x000B6B94
		private unsafe static int GetDatePart(long ticks, int part)
		{
			int i = (int)((ticks + 1728000000000L) / 864000000000L);
			int num = i / 1461;
			i -= num * 1461;
			int num2 = i / 365;
			if (num2 == 4)
			{
				num2 = 3;
			}
			if (part == 0)
			{
				return num * 4 + num2 + 1;
			}
			i -= num2 * 365;
			if (part == 1)
			{
				return i + 1;
			}
			ReadOnlySpan<int> readOnlySpan = (num2 == 3) ? GregorianCalendar.DaysToMonth366 : GregorianCalendar.DaysToMonth365;
			int num3 = (i >> 5) + 1;
			while (i >= *readOnlySpan[num3])
			{
				num3++;
			}
			if (part == 2)
			{
				return num3;
			}
			return i - *readOnlySpan[num3 - 1] + 1;
		}

		// Token: 0x060037F9 RID: 14329 RVA: 0x000B8A3C File Offset: 0x000B6C3C
		internal unsafe static long DateToTicks(int year, int month, int day)
		{
			ReadOnlySpan<int> readOnlySpan = (year % 4 == 0) ? GregorianCalendar.DaysToMonth366 : GregorianCalendar.DaysToMonth365;
			int num = year - 1;
			return (long)(num * 365 + num / 4 + *readOnlySpan[month - 1] + day - 1 - 2) * 864000000000L;
		}

		// Token: 0x060037FA RID: 14330 RVA: 0x000B8A88 File Offset: 0x000B6C88
		public unsafe override DateTime AddMonths(DateTime time, int months)
		{
			if (months < -120000 || months > 120000)
			{
				throw new ArgumentOutOfRangeException("months", months, SR.Format(SR.ArgumentOutOfRange_Range, -120000, 120000));
			}
			int num = JulianCalendar.GetDatePart(time.Ticks, 0);
			int num2 = JulianCalendar.GetDatePart(time.Ticks, 2);
			int num3 = JulianCalendar.GetDatePart(time.Ticks, 3);
			int num4 = num2 - 1 + months;
			if (num4 >= 0)
			{
				num2 = num4 % 12 + 1;
				num += num4 / 12;
			}
			else
			{
				num2 = 12 + (num4 + 1) % 12;
				num += (num4 - 11) / 12;
			}
			ReadOnlySpan<int> readOnlySpan = (num % 4 == 0 && (num % 100 != 0 || num % 400 == 0)) ? GregorianCalendar.DaysToMonth366 : GregorianCalendar.DaysToMonth365;
			int num5 = *readOnlySpan[num2] - *readOnlySpan[num2 - 1];
			if (num3 > num5)
			{
				num3 = num5;
			}
			long ticks = JulianCalendar.DateToTicks(num, num2, num3) + time.Ticks % 864000000000L;
			Calendar.CheckAddResult(ticks, this.MinSupportedDateTime, this.MaxSupportedDateTime);
			return new DateTime(ticks);
		}

		// Token: 0x060037FB RID: 14331 RVA: 0x000B3BD1 File Offset: 0x000B1DD1
		public override DateTime AddYears(DateTime time, int years)
		{
			return this.AddMonths(time, years * 12);
		}

		// Token: 0x060037FC RID: 14332 RVA: 0x000B8B9E File Offset: 0x000B6D9E
		public override int GetDayOfMonth(DateTime time)
		{
			return JulianCalendar.GetDatePart(time.Ticks, 3);
		}

		// Token: 0x060037FD RID: 14333 RVA: 0x000B3BE7 File Offset: 0x000B1DE7
		public override DayOfWeek GetDayOfWeek(DateTime time)
		{
			return time.DayOfWeek;
		}

		// Token: 0x060037FE RID: 14334 RVA: 0x000B8BAD File Offset: 0x000B6DAD
		public override int GetDayOfYear(DateTime time)
		{
			return JulianCalendar.GetDatePart(time.Ticks, 1);
		}

		// Token: 0x060037FF RID: 14335 RVA: 0x000B8BBC File Offset: 0x000B6DBC
		public unsafe override int GetDaysInMonth(int year, int month, int era)
		{
			this.CheckYearEraRange(year, era);
			JulianCalendar.CheckMonthRange(month);
			ReadOnlySpan<int> readOnlySpan = (year % 4 == 0) ? GregorianCalendar.DaysToMonth366 : GregorianCalendar.DaysToMonth365;
			return *readOnlySpan[month] - *readOnlySpan[month - 1];
		}

		// Token: 0x06003800 RID: 14336 RVA: 0x000B8BFE File Offset: 0x000B6DFE
		public override int GetDaysInYear(int year, int era)
		{
			if (!this.IsLeapYear(year, era))
			{
				return 365;
			}
			return 366;
		}

		// Token: 0x06003801 RID: 14337 RVA: 0x000B8C15 File Offset: 0x000B6E15
		public override int GetEra(DateTime time)
		{
			return JulianCalendar.JulianEra;
		}

		// Token: 0x06003802 RID: 14338 RVA: 0x000B8C1C File Offset: 0x000B6E1C
		public override int GetMonth(DateTime time)
		{
			return JulianCalendar.GetDatePart(time.Ticks, 2);
		}

		// Token: 0x17000A7F RID: 2687
		// (get) Token: 0x06003803 RID: 14339 RVA: 0x000B8C2B File Offset: 0x000B6E2B
		public override int[] Eras
		{
			get
			{
				return new int[]
				{
					JulianCalendar.JulianEra
				};
			}
		}

		// Token: 0x06003804 RID: 14340 RVA: 0x000B8C3B File Offset: 0x000B6E3B
		public override int GetMonthsInYear(int year, int era)
		{
			this.CheckYearEraRange(year, era);
			return 12;
		}

		// Token: 0x06003805 RID: 14341 RVA: 0x000B8C47 File Offset: 0x000B6E47
		public override int GetYear(DateTime time)
		{
			return JulianCalendar.GetDatePart(time.Ticks, 0);
		}

		// Token: 0x06003806 RID: 14342 RVA: 0x000B8C56 File Offset: 0x000B6E56
		public override bool IsLeapDay(int year, int month, int day, int era)
		{
			JulianCalendar.CheckMonthRange(month);
			if (this.IsLeapYear(year, era))
			{
				JulianCalendar.CheckDayRange(year, month, day);
				return month == 2 && day == 29;
			}
			JulianCalendar.CheckDayRange(year, month, day);
			return false;
		}

		// Token: 0x06003807 RID: 14343 RVA: 0x000B8C86 File Offset: 0x000B6E86
		public override int GetLeapMonth(int year, int era)
		{
			this.CheckYearEraRange(year, era);
			return 0;
		}

		// Token: 0x06003808 RID: 14344 RVA: 0x000B8C91 File Offset: 0x000B6E91
		public override bool IsLeapMonth(int year, int month, int era)
		{
			this.CheckYearEraRange(year, era);
			JulianCalendar.CheckMonthRange(month);
			return false;
		}

		// Token: 0x06003809 RID: 14345 RVA: 0x000B8CA2 File Offset: 0x000B6EA2
		public override bool IsLeapYear(int year, int era)
		{
			this.CheckYearEraRange(year, era);
			return year % 4 == 0;
		}

		// Token: 0x0600380A RID: 14346 RVA: 0x000B8CB4 File Offset: 0x000B6EB4
		public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era)
		{
			this.CheckYearEraRange(year, era);
			JulianCalendar.CheckMonthRange(month);
			JulianCalendar.CheckDayRange(year, month, day);
			if (millisecond < 0 || (long)millisecond >= 1000L)
			{
				throw new ArgumentOutOfRangeException("millisecond", millisecond, SR.Format(SR.ArgumentOutOfRange_Range, 0, 999L));
			}
			if (hour < 0 || hour >= 24 || minute < 0 || minute >= 60 || second < 0 || second >= 60)
			{
				throw new ArgumentOutOfRangeException(null, SR.ArgumentOutOfRange_BadHourMinuteSecond);
			}
			return new DateTime(JulianCalendar.DateToTicks(year, month, day) + new TimeSpan(0, hour, minute, second, millisecond).Ticks);
		}

		// Token: 0x17000A80 RID: 2688
		// (get) Token: 0x0600380B RID: 14347 RVA: 0x000A4C11 File Offset: 0x000A2E11
		// (set) Token: 0x0600380C RID: 14348 RVA: 0x000B8D68 File Offset: 0x000B6F68
		public override int TwoDigitYearMax
		{
			get
			{
				return this._twoDigitYearMax;
			}
			set
			{
				base.VerifyWritable();
				if (value < 99 || value > this.MaxYear)
				{
					throw new ArgumentOutOfRangeException("value", value, SR.Format(SR.ArgumentOutOfRange_Range, 99, this.MaxYear));
				}
				this._twoDigitYearMax = value;
			}
		}

		// Token: 0x0600380D RID: 14349 RVA: 0x000B8DC0 File Offset: 0x000B6FC0
		public override int ToFourDigitYear(int year)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(year, "year");
			if (year > this.MaxYear)
			{
				throw new ArgumentOutOfRangeException("year", year, SR.Format(SR.ArgumentOutOfRange_Bounds_Lower_Upper, 1, this.MaxYear));
			}
			return base.ToFourDigitYear(year);
		}

		// Token: 0x04000AF1 RID: 2801
		public static readonly int JulianEra = 1;

		// Token: 0x04000AF2 RID: 2802
		internal int MaxYear = 9999;
	}
}
