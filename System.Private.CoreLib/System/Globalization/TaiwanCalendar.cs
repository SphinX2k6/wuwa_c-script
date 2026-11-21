using System;
using System.Runtime.CompilerServices;

namespace System.Globalization
{
	// Token: 0x02000310 RID: 784
	[NullableContext(1)]
	[Nullable(0)]
	public class TaiwanCalendar : Calendar
	{
		// Token: 0x06003918 RID: 14616 RVA: 0x000BCB8D File Offset: 0x000BAD8D
		internal static Calendar GetDefaultInstance()
		{
			Calendar result;
			if ((result = TaiwanCalendar.s_defaultInstance) == null)
			{
				result = (TaiwanCalendar.s_defaultInstance = new TaiwanCalendar());
			}
			return result;
		}

		// Token: 0x17000AD0 RID: 2768
		// (get) Token: 0x06003919 RID: 14617 RVA: 0x000BCBA3 File Offset: 0x000BADA3
		public override DateTime MinSupportedDateTime
		{
			get
			{
				return TaiwanCalendar.s_calendarMinValue;
			}
		}

		// Token: 0x17000AD1 RID: 2769
		// (get) Token: 0x0600391A RID: 14618 RVA: 0x000A4708 File Offset: 0x000A2908
		public override DateTime MaxSupportedDateTime
		{
			get
			{
				return DateTime.MaxValue;
			}
		}

		// Token: 0x17000AD2 RID: 2770
		// (get) Token: 0x0600391B RID: 14619 RVA: 0x000070DD File Offset: 0x000052DD
		public override CalendarAlgorithmType AlgorithmType
		{
			get
			{
				return CalendarAlgorithmType.SolarCalendar;
			}
		}

		// Token: 0x0600391C RID: 14620 RVA: 0x000BCBAC File Offset: 0x000BADAC
		public TaiwanCalendar()
		{
			try
			{
				new CultureInfo("zh-TW");
			}
			catch (ArgumentException innerException)
			{
				throw new TypeInitializationException(base.GetType().ToString(), innerException);
			}
			this._helper = new GregorianCalendarHelper(this, TaiwanCalendar.s_taiwanEraInfo);
		}

		// Token: 0x17000AD3 RID: 2771
		// (get) Token: 0x0600391D RID: 14621 RVA: 0x000211FB File Offset: 0x0001F3FB
		internal override CalendarId ID
		{
			get
			{
				return CalendarId.TAIWAN;
			}
		}

		// Token: 0x0600391E RID: 14622 RVA: 0x000BCC00 File Offset: 0x000BAE00
		public override DateTime AddMonths(DateTime time, int months)
		{
			return this._helper.AddMonths(time, months);
		}

		// Token: 0x0600391F RID: 14623 RVA: 0x000BCC0F File Offset: 0x000BAE0F
		public override DateTime AddYears(DateTime time, int years)
		{
			return this._helper.AddYears(time, years);
		}

		// Token: 0x06003920 RID: 14624 RVA: 0x000BCC1E File Offset: 0x000BAE1E
		public override int GetDaysInMonth(int year, int month, int era)
		{
			return this._helper.GetDaysInMonth(year, month, era);
		}

		// Token: 0x06003921 RID: 14625 RVA: 0x000BCC2E File Offset: 0x000BAE2E
		public override int GetDaysInYear(int year, int era)
		{
			return this._helper.GetDaysInYear(year, era);
		}

		// Token: 0x06003922 RID: 14626 RVA: 0x000BCC3D File Offset: 0x000BAE3D
		public override int GetDayOfMonth(DateTime time)
		{
			return this._helper.GetDayOfMonth(time);
		}

		// Token: 0x06003923 RID: 14627 RVA: 0x000BCC4B File Offset: 0x000BAE4B
		public override DayOfWeek GetDayOfWeek(DateTime time)
		{
			return this._helper.GetDayOfWeek(time);
		}

		// Token: 0x06003924 RID: 14628 RVA: 0x000BCC59 File Offset: 0x000BAE59
		public override int GetDayOfYear(DateTime time)
		{
			return this._helper.GetDayOfYear(time);
		}

		// Token: 0x06003925 RID: 14629 RVA: 0x000BCC67 File Offset: 0x000BAE67
		public override int GetMonthsInYear(int year, int era)
		{
			return this._helper.GetMonthsInYear(year, era);
		}

		// Token: 0x06003926 RID: 14630 RVA: 0x000BCC76 File Offset: 0x000BAE76
		public override int GetWeekOfYear(DateTime time, CalendarWeekRule rule, DayOfWeek firstDayOfWeek)
		{
			return this._helper.GetWeekOfYear(time, rule, firstDayOfWeek);
		}

		// Token: 0x06003927 RID: 14631 RVA: 0x000BCC86 File Offset: 0x000BAE86
		public override int GetEra(DateTime time)
		{
			return this._helper.GetEra(time);
		}

		// Token: 0x06003928 RID: 14632 RVA: 0x000BCC94 File Offset: 0x000BAE94
		public override int GetMonth(DateTime time)
		{
			return this._helper.GetMonth(time);
		}

		// Token: 0x06003929 RID: 14633 RVA: 0x000BCCA2 File Offset: 0x000BAEA2
		public override int GetYear(DateTime time)
		{
			return this._helper.GetYear(time);
		}

		// Token: 0x0600392A RID: 14634 RVA: 0x000BCCB0 File Offset: 0x000BAEB0
		public override bool IsLeapDay(int year, int month, int day, int era)
		{
			return this._helper.IsLeapDay(year, month, day, era);
		}

		// Token: 0x0600392B RID: 14635 RVA: 0x000BCCC2 File Offset: 0x000BAEC2
		public override bool IsLeapYear(int year, int era)
		{
			return this._helper.IsLeapYear(year, era);
		}

		// Token: 0x0600392C RID: 14636 RVA: 0x000BCCD1 File Offset: 0x000BAED1
		public override int GetLeapMonth(int year, int era)
		{
			return this._helper.GetLeapMonth(year, era);
		}

		// Token: 0x0600392D RID: 14637 RVA: 0x000BCCE0 File Offset: 0x000BAEE0
		public override bool IsLeapMonth(int year, int month, int era)
		{
			return this._helper.IsLeapMonth(year, month, era);
		}

		// Token: 0x0600392E RID: 14638 RVA: 0x000BCCF0 File Offset: 0x000BAEF0
		public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era)
		{
			return this._helper.ToDateTime(year, month, day, hour, minute, second, millisecond, era);
		}

		// Token: 0x17000AD4 RID: 2772
		// (get) Token: 0x0600392F RID: 14639 RVA: 0x000BCD15 File Offset: 0x000BAF15
		public override int[] Eras
		{
			get
			{
				return this._helper.Eras;
			}
		}

		// Token: 0x17000AD5 RID: 2773
		// (get) Token: 0x06003930 RID: 14640 RVA: 0x000B8083 File Offset: 0x000B6283
		// (set) Token: 0x06003931 RID: 14641 RVA: 0x000BCD24 File Offset: 0x000BAF24
		public override int TwoDigitYearMax
		{
			get
			{
				if (this._twoDigitYearMax == -1)
				{
					this._twoDigitYearMax = Calendar.GetSystemTwoDigitYearSetting(this.ID, 99);
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

		// Token: 0x06003932 RID: 14642 RVA: 0x000BCD83 File Offset: 0x000BAF83
		public override int ToFourDigitYear(int year)
		{
			ArgumentOutOfRangeException.ThrowIfNegativeOrZero<int>(year, "year");
			ArgumentOutOfRangeException.ThrowIfGreaterThan<int>(year, this._helper.MaxYear, "year");
			return year;
		}

		// Token: 0x04000B52 RID: 2898
		private static readonly EraInfo[] s_taiwanEraInfo = new EraInfo[]
		{
			new EraInfo(1, 1912, 1, 1, 1911, 1, 8088)
		};

		// Token: 0x04000B53 RID: 2899
		private static Calendar s_defaultInstance;

		// Token: 0x04000B54 RID: 2900
		private readonly GregorianCalendarHelper _helper;

		// Token: 0x04000B55 RID: 2901
		private static readonly DateTime s_calendarMinValue = new DateTime(1912, 1, 1);
	}
}
