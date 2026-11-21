using System;
using System.Runtime.CompilerServices;

namespace System.Globalization
{
	// Token: 0x02000302 RID: 770
	[NullableContext(1)]
	[Nullable(0)]
	public class KoreanCalendar : Calendar
	{
		// Token: 0x17000A81 RID: 2689
		// (get) Token: 0x0600380F RID: 14351 RVA: 0x000A4701 File Offset: 0x000A2901
		public override DateTime MinSupportedDateTime
		{
			get
			{
				return DateTime.MinValue;
			}
		}

		// Token: 0x17000A82 RID: 2690
		// (get) Token: 0x06003810 RID: 14352 RVA: 0x000A4708 File Offset: 0x000A2908
		public override DateTime MaxSupportedDateTime
		{
			get
			{
				return DateTime.MaxValue;
			}
		}

		// Token: 0x17000A83 RID: 2691
		// (get) Token: 0x06003811 RID: 14353 RVA: 0x000070DD File Offset: 0x000052DD
		public override CalendarAlgorithmType AlgorithmType
		{
			get
			{
				return CalendarAlgorithmType.SolarCalendar;
			}
		}

		// Token: 0x06003812 RID: 14354 RVA: 0x000B8E1C File Offset: 0x000B701C
		public KoreanCalendar()
		{
			try
			{
				new CultureInfo("ko-KR");
			}
			catch (ArgumentException innerException)
			{
				throw new TypeInitializationException(base.GetType().ToString(), innerException);
			}
			this._helper = new GregorianCalendarHelper(this, KoreanCalendar.s_koreanEraInfo);
		}

		// Token: 0x17000A84 RID: 2692
		// (get) Token: 0x06003813 RID: 14355 RVA: 0x00022705 File Offset: 0x00020905
		internal override CalendarId ID
		{
			get
			{
				return CalendarId.KOREA;
			}
		}

		// Token: 0x06003814 RID: 14356 RVA: 0x000B8E70 File Offset: 0x000B7070
		public override DateTime AddMonths(DateTime time, int months)
		{
			return this._helper.AddMonths(time, months);
		}

		// Token: 0x06003815 RID: 14357 RVA: 0x000B8E7F File Offset: 0x000B707F
		public override DateTime AddYears(DateTime time, int years)
		{
			return this._helper.AddYears(time, years);
		}

		// Token: 0x06003816 RID: 14358 RVA: 0x000B8E8E File Offset: 0x000B708E
		public override int GetDaysInMonth(int year, int month, int era)
		{
			return this._helper.GetDaysInMonth(year, month, era);
		}

		// Token: 0x06003817 RID: 14359 RVA: 0x000B8E9E File Offset: 0x000B709E
		public override int GetDaysInYear(int year, int era)
		{
			return this._helper.GetDaysInYear(year, era);
		}

		// Token: 0x06003818 RID: 14360 RVA: 0x000B8EAD File Offset: 0x000B70AD
		public override int GetDayOfMonth(DateTime time)
		{
			return this._helper.GetDayOfMonth(time);
		}

		// Token: 0x06003819 RID: 14361 RVA: 0x000B8EBB File Offset: 0x000B70BB
		public override DayOfWeek GetDayOfWeek(DateTime time)
		{
			return this._helper.GetDayOfWeek(time);
		}

		// Token: 0x0600381A RID: 14362 RVA: 0x000B8EC9 File Offset: 0x000B70C9
		public override int GetDayOfYear(DateTime time)
		{
			return this._helper.GetDayOfYear(time);
		}

		// Token: 0x0600381B RID: 14363 RVA: 0x000B8ED7 File Offset: 0x000B70D7
		public override int GetMonthsInYear(int year, int era)
		{
			return this._helper.GetMonthsInYear(year, era);
		}

		// Token: 0x0600381C RID: 14364 RVA: 0x000B8EE6 File Offset: 0x000B70E6
		public override int GetWeekOfYear(DateTime time, CalendarWeekRule rule, DayOfWeek firstDayOfWeek)
		{
			return this._helper.GetWeekOfYear(time, rule, firstDayOfWeek);
		}

		// Token: 0x0600381D RID: 14365 RVA: 0x000B8EF6 File Offset: 0x000B70F6
		public override int GetEra(DateTime time)
		{
			return this._helper.GetEra(time);
		}

		// Token: 0x0600381E RID: 14366 RVA: 0x000B8F04 File Offset: 0x000B7104
		public override int GetMonth(DateTime time)
		{
			return this._helper.GetMonth(time);
		}

		// Token: 0x0600381F RID: 14367 RVA: 0x000B8F12 File Offset: 0x000B7112
		public override int GetYear(DateTime time)
		{
			return this._helper.GetYear(time);
		}

		// Token: 0x06003820 RID: 14368 RVA: 0x000B8F20 File Offset: 0x000B7120
		public override bool IsLeapDay(int year, int month, int day, int era)
		{
			return this._helper.IsLeapDay(year, month, day, era);
		}

		// Token: 0x06003821 RID: 14369 RVA: 0x000B8F32 File Offset: 0x000B7132
		public override bool IsLeapYear(int year, int era)
		{
			return this._helper.IsLeapYear(year, era);
		}

		// Token: 0x06003822 RID: 14370 RVA: 0x000B8F41 File Offset: 0x000B7141
		public override int GetLeapMonth(int year, int era)
		{
			return this._helper.GetLeapMonth(year, era);
		}

		// Token: 0x06003823 RID: 14371 RVA: 0x000B8F50 File Offset: 0x000B7150
		public override bool IsLeapMonth(int year, int month, int era)
		{
			return this._helper.IsLeapMonth(year, month, era);
		}

		// Token: 0x06003824 RID: 14372 RVA: 0x000B8F60 File Offset: 0x000B7160
		public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era)
		{
			return this._helper.ToDateTime(year, month, day, hour, minute, second, millisecond, era);
		}

		// Token: 0x17000A85 RID: 2693
		// (get) Token: 0x06003825 RID: 14373 RVA: 0x000B8F85 File Offset: 0x000B7185
		public override int[] Eras
		{
			get
			{
				return this._helper.Eras;
			}
		}

		// Token: 0x17000A86 RID: 2694
		// (get) Token: 0x06003826 RID: 14374 RVA: 0x000B8F92 File Offset: 0x000B7192
		// (set) Token: 0x06003827 RID: 14375 RVA: 0x000B8FBC File Offset: 0x000B71BC
		public override int TwoDigitYearMax
		{
			get
			{
				if (this._twoDigitYearMax == -1)
				{
					this._twoDigitYearMax = Calendar.GetSystemTwoDigitYearSetting(this.ID, 4362);
				}
				return this._twoDigitYearMax;
			}
			set
			{
				base.VerifyWritable();
				if (value < 99 || value > this._helper.MaxYear)
				{
					throw new ArgumentOutOfRangeException("value", value, SR.Format(SR.ArgumentOutOfRange_Range, 99, this._helper.MaxYear));
				}
				this._twoDigitYearMax = value;
			}
		}

		// Token: 0x06003828 RID: 14376 RVA: 0x000B901B File Offset: 0x000B721B
		public override int ToFourDigitYear(int year)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(year, "year");
			return this._helper.ToFourDigitYear(year, this.TwoDigitYearMax);
		}

		// Token: 0x04000AF3 RID: 2803
		public const int KoreanEra = 1;

		// Token: 0x04000AF4 RID: 2804
		private static readonly EraInfo[] s_koreanEraInfo = new EraInfo[]
		{
			new EraInfo(1, 1, 1, 1, -2333, 2334, 12332)
		};

		// Token: 0x04000AF5 RID: 2805
		private readonly GregorianCalendarHelper _helper;
	}
}
