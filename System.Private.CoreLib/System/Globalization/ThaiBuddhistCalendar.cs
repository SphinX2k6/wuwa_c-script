using System;
using System.Runtime.CompilerServices;

namespace System.Globalization
{
	// Token: 0x02000317 RID: 791
	[NullableContext(1)]
	[Nullable(0)]
	public class ThaiBuddhistCalendar : Calendar
	{
		// Token: 0x17000AEE RID: 2798
		// (get) Token: 0x0600397C RID: 14716 RVA: 0x000A4701 File Offset: 0x000A2901
		public override DateTime MinSupportedDateTime
		{
			get
			{
				return DateTime.MinValue;
			}
		}

		// Token: 0x17000AEF RID: 2799
		// (get) Token: 0x0600397D RID: 14717 RVA: 0x000A4708 File Offset: 0x000A2908
		public override DateTime MaxSupportedDateTime
		{
			get
			{
				return DateTime.MaxValue;
			}
		}

		// Token: 0x17000AF0 RID: 2800
		// (get) Token: 0x0600397E RID: 14718 RVA: 0x000070DD File Offset: 0x000052DD
		public override CalendarAlgorithmType AlgorithmType
		{
			get
			{
				return CalendarAlgorithmType.SolarCalendar;
			}
		}

		// Token: 0x0600397F RID: 14719 RVA: 0x000BDBC9 File Offset: 0x000BBDC9
		public ThaiBuddhistCalendar()
		{
			this._helper = new GregorianCalendarHelper(this, ThaiBuddhistCalendar.s_thaiBuddhistEraInfo);
		}

		// Token: 0x17000AF1 RID: 2801
		// (get) Token: 0x06003980 RID: 14720 RVA: 0x0003EE4B File Offset: 0x0003D04B
		internal override CalendarId ID
		{
			get
			{
				return CalendarId.THAI;
			}
		}

		// Token: 0x06003981 RID: 14721 RVA: 0x000BDBE2 File Offset: 0x000BBDE2
		public override DateTime AddMonths(DateTime time, int months)
		{
			return this._helper.AddMonths(time, months);
		}

		// Token: 0x06003982 RID: 14722 RVA: 0x000BDBF1 File Offset: 0x000BBDF1
		public override DateTime AddYears(DateTime time, int years)
		{
			return this._helper.AddYears(time, years);
		}

		// Token: 0x06003983 RID: 14723 RVA: 0x000BDC00 File Offset: 0x000BBE00
		public override int GetDaysInMonth(int year, int month, int era)
		{
			return this._helper.GetDaysInMonth(year, month, era);
		}

		// Token: 0x06003984 RID: 14724 RVA: 0x000BDC10 File Offset: 0x000BBE10
		public override int GetDaysInYear(int year, int era)
		{
			return this._helper.GetDaysInYear(year, era);
		}

		// Token: 0x06003985 RID: 14725 RVA: 0x000BDC1F File Offset: 0x000BBE1F
		public override int GetDayOfMonth(DateTime time)
		{
			return this._helper.GetDayOfMonth(time);
		}

		// Token: 0x06003986 RID: 14726 RVA: 0x000BDC2D File Offset: 0x000BBE2D
		public override DayOfWeek GetDayOfWeek(DateTime time)
		{
			return this._helper.GetDayOfWeek(time);
		}

		// Token: 0x06003987 RID: 14727 RVA: 0x000BDC3B File Offset: 0x000BBE3B
		public override int GetDayOfYear(DateTime time)
		{
			return this._helper.GetDayOfYear(time);
		}

		// Token: 0x06003988 RID: 14728 RVA: 0x000BDC49 File Offset: 0x000BBE49
		public override int GetMonthsInYear(int year, int era)
		{
			return this._helper.GetMonthsInYear(year, era);
		}

		// Token: 0x06003989 RID: 14729 RVA: 0x000BDC58 File Offset: 0x000BBE58
		public override int GetWeekOfYear(DateTime time, CalendarWeekRule rule, DayOfWeek firstDayOfWeek)
		{
			return this._helper.GetWeekOfYear(time, rule, firstDayOfWeek);
		}

		// Token: 0x0600398A RID: 14730 RVA: 0x000BDC68 File Offset: 0x000BBE68
		public override int GetEra(DateTime time)
		{
			return this._helper.GetEra(time);
		}

		// Token: 0x0600398B RID: 14731 RVA: 0x000BDC76 File Offset: 0x000BBE76
		public override int GetMonth(DateTime time)
		{
			return this._helper.GetMonth(time);
		}

		// Token: 0x0600398C RID: 14732 RVA: 0x000BDC84 File Offset: 0x000BBE84
		public override int GetYear(DateTime time)
		{
			return this._helper.GetYear(time);
		}

		// Token: 0x0600398D RID: 14733 RVA: 0x000BDC92 File Offset: 0x000BBE92
		public override bool IsLeapDay(int year, int month, int day, int era)
		{
			return this._helper.IsLeapDay(year, month, day, era);
		}

		// Token: 0x0600398E RID: 14734 RVA: 0x000BDCA4 File Offset: 0x000BBEA4
		public override bool IsLeapYear(int year, int era)
		{
			return this._helper.IsLeapYear(year, era);
		}

		// Token: 0x0600398F RID: 14735 RVA: 0x000BDCB3 File Offset: 0x000BBEB3
		public override int GetLeapMonth(int year, int era)
		{
			return this._helper.GetLeapMonth(year, era);
		}

		// Token: 0x06003990 RID: 14736 RVA: 0x000BDCC2 File Offset: 0x000BBEC2
		public override bool IsLeapMonth(int year, int month, int era)
		{
			return this._helper.IsLeapMonth(year, month, era);
		}

		// Token: 0x06003991 RID: 14737 RVA: 0x000BDCD4 File Offset: 0x000BBED4
		public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era)
		{
			return this._helper.ToDateTime(year, month, day, hour, minute, second, millisecond, era);
		}

		// Token: 0x17000AF2 RID: 2802
		// (get) Token: 0x06003992 RID: 14738 RVA: 0x000BDCF9 File Offset: 0x000BBEF9
		public override int[] Eras
		{
			get
			{
				return this._helper.Eras;
			}
		}

		// Token: 0x17000AF3 RID: 2803
		// (get) Token: 0x06003993 RID: 14739 RVA: 0x000BDD06 File Offset: 0x000BBF06
		// (set) Token: 0x06003994 RID: 14740 RVA: 0x000BDD30 File Offset: 0x000BBF30
		public override int TwoDigitYearMax
		{
			get
			{
				if (this._twoDigitYearMax == -1)
				{
					this._twoDigitYearMax = Calendar.GetSystemTwoDigitYearSetting(this.ID, 2572);
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

		// Token: 0x06003995 RID: 14741 RVA: 0x000BDD8F File Offset: 0x000BBF8F
		public override int ToFourDigitYear(int year)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(year, "year");
			return this._helper.ToFourDigitYear(year, this.TwoDigitYearMax);
		}

		// Token: 0x04000B6D RID: 2925
		private static readonly EraInfo[] s_thaiBuddhistEraInfo = new EraInfo[]
		{
			new EraInfo(1, 1, 1, 1, -543, 544, 10542)
		};

		// Token: 0x04000B6E RID: 2926
		public const int ThaiBuddhistEra = 1;

		// Token: 0x04000B6F RID: 2927
		private readonly GregorianCalendarHelper _helper;
	}
}
