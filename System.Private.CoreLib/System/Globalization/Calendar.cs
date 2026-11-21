using System;
using System.Runtime.CompilerServices;

namespace System.Globalization
{
	// Token: 0x020002C1 RID: 705
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class Calendar : ICloneable
	{
		// Token: 0x17000964 RID: 2404
		// (get) Token: 0x060033A3 RID: 13219 RVA: 0x000A4701 File Offset: 0x000A2901
		public virtual DateTime MinSupportedDateTime
		{
			get
			{
				return DateTime.MinValue;
			}
		}

		// Token: 0x17000965 RID: 2405
		// (get) Token: 0x060033A4 RID: 13220 RVA: 0x000A4708 File Offset: 0x000A2908
		public virtual DateTime MaxSupportedDateTime
		{
			get
			{
				return DateTime.MaxValue;
			}
		}

		// Token: 0x17000966 RID: 2406
		// (get) Token: 0x060033A5 RID: 13221 RVA: 0x00007B65 File Offset: 0x00005D65
		public virtual CalendarAlgorithmType AlgorithmType
		{
			get
			{
				return CalendarAlgorithmType.Unknown;
			}
		}

		// Token: 0x17000967 RID: 2407
		// (get) Token: 0x060033A7 RID: 13223 RVA: 0x00007B65 File Offset: 0x00005D65
		internal virtual CalendarId ID
		{
			get
			{
				return CalendarId.UNINITIALIZED_VALUE;
			}
		}

		// Token: 0x17000968 RID: 2408
		// (get) Token: 0x060033A8 RID: 13224 RVA: 0x000A4725 File Offset: 0x000A2925
		internal virtual CalendarId BaseCalendarID
		{
			get
			{
				return this.ID;
			}
		}

		// Token: 0x17000969 RID: 2409
		// (get) Token: 0x060033A9 RID: 13225 RVA: 0x000A472D File Offset: 0x000A292D
		public bool IsReadOnly
		{
			get
			{
				return this._isReadOnly;
			}
		}

		// Token: 0x060033AA RID: 13226 RVA: 0x000A4735 File Offset: 0x000A2935
		public virtual object Clone()
		{
			object obj = base.MemberwiseClone();
			((Calendar)obj).SetReadOnlyState(false);
			return obj;
		}

		// Token: 0x060033AB RID: 13227 RVA: 0x000A4749 File Offset: 0x000A2949
		public static Calendar ReadOnly(Calendar calendar)
		{
			ArgumentNullException.ThrowIfNull(calendar, "calendar");
			if (calendar.IsReadOnly)
			{
				return calendar;
			}
			Calendar calendar2 = (Calendar)calendar.MemberwiseClone();
			calendar2.SetReadOnlyState(true);
			return calendar2;
		}

		// Token: 0x060033AC RID: 13228 RVA: 0x000A4772 File Offset: 0x000A2972
		internal void VerifyWritable()
		{
			if (this._isReadOnly)
			{
				throw new InvalidOperationException(SR.InvalidOperation_ReadOnly);
			}
		}

		// Token: 0x060033AD RID: 13229 RVA: 0x000A4787 File Offset: 0x000A2987
		internal void SetReadOnlyState(bool readOnly)
		{
			this._isReadOnly = readOnly;
		}

		// Token: 0x1700096A RID: 2410
		// (get) Token: 0x060033AE RID: 13230 RVA: 0x000A4790 File Offset: 0x000A2990
		internal int CurrentEraValue
		{
			get
			{
				if (this._currentEraValue == -1)
				{
					this._currentEraValue = CalendarData.GetCalendarCurrentEra(this);
				}
				return this._currentEraValue;
			}
		}

		// Token: 0x060033AF RID: 13231 RVA: 0x000A47AD File Offset: 0x000A29AD
		internal static void CheckAddResult(long ticks, DateTime minValue, DateTime maxValue)
		{
			if (ticks < minValue.Ticks || ticks > maxValue.Ticks)
			{
				throw new ArgumentException(SR.Format(SR.Argument_ResultCalendarRange, minValue, maxValue));
			}
		}

		// Token: 0x060033B0 RID: 13232 RVA: 0x000A47E0 File Offset: 0x000A29E0
		internal DateTime Add(DateTime time, double value, int scale)
		{
			double num = value * (double)scale + ((value >= 0.0) ? 0.5 : -0.5);
			if (num <= -315537897600000.0 || num >= 315537897600000.0)
			{
				throw new ArgumentOutOfRangeException("value", value, SR.ArgumentOutOfRange_AddValue);
			}
			long num2 = (long)num;
			long ticks = time.Ticks + num2 * 10000L;
			Calendar.CheckAddResult(ticks, this.MinSupportedDateTime, this.MaxSupportedDateTime);
			return new DateTime(ticks);
		}

		// Token: 0x060033B1 RID: 13233 RVA: 0x000A486B File Offset: 0x000A2A6B
		public virtual DateTime AddMilliseconds(DateTime time, double milliseconds)
		{
			return this.Add(time, milliseconds, 1);
		}

		// Token: 0x060033B2 RID: 13234 RVA: 0x000A4876 File Offset: 0x000A2A76
		public virtual DateTime AddDays(DateTime time, int days)
		{
			return this.Add(time, (double)days, 86400000);
		}

		// Token: 0x060033B3 RID: 13235 RVA: 0x000A4886 File Offset: 0x000A2A86
		public virtual DateTime AddHours(DateTime time, int hours)
		{
			return this.Add(time, (double)hours, 3600000);
		}

		// Token: 0x060033B4 RID: 13236 RVA: 0x000A4896 File Offset: 0x000A2A96
		public virtual DateTime AddMinutes(DateTime time, int minutes)
		{
			return this.Add(time, (double)minutes, 60000);
		}

		// Token: 0x060033B5 RID: 13237
		public abstract DateTime AddMonths(DateTime time, int months);

		// Token: 0x060033B6 RID: 13238 RVA: 0x000A48A6 File Offset: 0x000A2AA6
		public virtual DateTime AddSeconds(DateTime time, int seconds)
		{
			return this.Add(time, (double)seconds, 1000);
		}

		// Token: 0x060033B7 RID: 13239 RVA: 0x000A48B6 File Offset: 0x000A2AB6
		public virtual DateTime AddWeeks(DateTime time, int weeks)
		{
			return this.AddDays(time, weeks * 7);
		}

		// Token: 0x060033B8 RID: 13240
		public abstract DateTime AddYears(DateTime time, int years);

		// Token: 0x060033B9 RID: 13241
		public abstract int GetDayOfMonth(DateTime time);

		// Token: 0x060033BA RID: 13242
		public abstract DayOfWeek GetDayOfWeek(DateTime time);

		// Token: 0x060033BB RID: 13243
		public abstract int GetDayOfYear(DateTime time);

		// Token: 0x060033BC RID: 13244 RVA: 0x000A48C2 File Offset: 0x000A2AC2
		public virtual int GetDaysInMonth(int year, int month)
		{
			return this.GetDaysInMonth(year, month, 0);
		}

		// Token: 0x060033BD RID: 13245
		public abstract int GetDaysInMonth(int year, int month, int era);

		// Token: 0x060033BE RID: 13246 RVA: 0x000A48CD File Offset: 0x000A2ACD
		public virtual int GetDaysInYear(int year)
		{
			return this.GetDaysInYear(year, 0);
		}

		// Token: 0x060033BF RID: 13247
		public abstract int GetDaysInYear(int year, int era);

		// Token: 0x060033C0 RID: 13248
		public abstract int GetEra(DateTime time);

		// Token: 0x1700096B RID: 2411
		// (get) Token: 0x060033C1 RID: 13249
		public abstract int[] Eras { get; }

		// Token: 0x060033C2 RID: 13250 RVA: 0x000A48D7 File Offset: 0x000A2AD7
		public virtual int GetHour(DateTime time)
		{
			return time.Hour;
		}

		// Token: 0x060033C3 RID: 13251 RVA: 0x000A48E0 File Offset: 0x000A2AE0
		public virtual double GetMilliseconds(DateTime time)
		{
			return (double)time.Millisecond;
		}

		// Token: 0x060033C4 RID: 13252 RVA: 0x000A48EA File Offset: 0x000A2AEA
		public virtual int GetMinute(DateTime time)
		{
			return time.Minute;
		}

		// Token: 0x060033C5 RID: 13253
		public abstract int GetMonth(DateTime time);

		// Token: 0x060033C6 RID: 13254 RVA: 0x000A48F3 File Offset: 0x000A2AF3
		public virtual int GetMonthsInYear(int year)
		{
			return this.GetMonthsInYear(year, 0);
		}

		// Token: 0x060033C7 RID: 13255
		public abstract int GetMonthsInYear(int year, int era);

		// Token: 0x060033C8 RID: 13256 RVA: 0x000A48FD File Offset: 0x000A2AFD
		public virtual int GetSecond(DateTime time)
		{
			return time.Second;
		}

		// Token: 0x060033C9 RID: 13257 RVA: 0x000A4908 File Offset: 0x000A2B08
		internal int GetFirstDayWeekOfYear(DateTime time, int firstDayOfWeek)
		{
			int num = this.GetDayOfYear(time) - 1;
			int num2 = (this.GetDayOfWeek(time) - (DayOfWeek)(num % 7) - firstDayOfWeek + 14) % 7;
			return (num + num2) / 7 + 1;
		}

		// Token: 0x060033CA RID: 13258 RVA: 0x000A493C File Offset: 0x000A2B3C
		private int GetWeekOfYearFullDays(DateTime time, int firstDayOfWeek, int fullDays)
		{
			int num = this.GetDayOfYear(time) - 1;
			int num2 = this.GetDayOfWeek(time) - (DayOfWeek)(num % 7);
			int num3 = (firstDayOfWeek - num2 + 14) % 7;
			if (num3 != 0 && num3 >= fullDays)
			{
				num3 -= 7;
			}
			int num4 = num - num3;
			if (num4 >= 0)
			{
				return num4 / 7 + 1;
			}
			if (time <= this.MinSupportedDateTime.AddDays((double)num))
			{
				return this.GetWeekOfYearOfMinSupportedDateTime(firstDayOfWeek, fullDays);
			}
			return this.GetWeekOfYearFullDays(time.AddDays((double)(-(double)(num + 1))), firstDayOfWeek, fullDays);
		}

		// Token: 0x060033CB RID: 13259 RVA: 0x000A49B8 File Offset: 0x000A2BB8
		private int GetWeekOfYearOfMinSupportedDateTime(int firstDayOfWeek, int minimumDaysInFirstWeek)
		{
			int num = this.GetDayOfYear(this.MinSupportedDateTime) - 1;
			int num2 = this.GetDayOfWeek(this.MinSupportedDateTime) - (DayOfWeek)(num % 7);
			int num3 = (firstDayOfWeek + 7 - num2) % 7;
			if (num3 == 0 || num3 >= minimumDaysInFirstWeek)
			{
				return 1;
			}
			int num4 = this.DaysInYearBeforeMinSupportedYear - 1;
			int num5 = num2 - 1 - num4 % 7;
			int num6 = (firstDayOfWeek - num5 + 14) % 7;
			int num7 = num4 - num6;
			if (num6 >= minimumDaysInFirstWeek)
			{
				num7 += 7;
			}
			return num7 / 7 + 1;
		}

		// Token: 0x1700096C RID: 2412
		// (get) Token: 0x060033CC RID: 13260 RVA: 0x000A4A2A File Offset: 0x000A2C2A
		protected virtual int DaysInYearBeforeMinSupportedYear
		{
			get
			{
				return 365;
			}
		}

		// Token: 0x060033CD RID: 13261 RVA: 0x000A4A34 File Offset: 0x000A2C34
		public virtual int GetWeekOfYear(DateTime time, CalendarWeekRule rule, DayOfWeek firstDayOfWeek)
		{
			if (firstDayOfWeek < DayOfWeek.Sunday || firstDayOfWeek > DayOfWeek.Saturday)
			{
				throw new ArgumentOutOfRangeException("firstDayOfWeek", firstDayOfWeek, SR.Format(SR.ArgumentOutOfRange_Range, DayOfWeek.Sunday, DayOfWeek.Saturday));
			}
			int result;
			switch (rule)
			{
			case CalendarWeekRule.FirstDay:
				result = this.GetFirstDayWeekOfYear(time, (int)firstDayOfWeek);
				break;
			case CalendarWeekRule.FirstFullWeek:
				result = this.GetWeekOfYearFullDays(time, (int)firstDayOfWeek, 7);
				break;
			case CalendarWeekRule.FirstFourDayWeek:
				result = this.GetWeekOfYearFullDays(time, (int)firstDayOfWeek, 4);
				break;
			default:
				throw new ArgumentOutOfRangeException("rule", rule, SR.Format(SR.ArgumentOutOfRange_Range, CalendarWeekRule.FirstDay, CalendarWeekRule.FirstFourDayWeek));
			}
			return result;
		}

		// Token: 0x060033CE RID: 13262
		public abstract int GetYear(DateTime time);

		// Token: 0x060033CF RID: 13263 RVA: 0x000A4ACF File Offset: 0x000A2CCF
		public virtual bool IsLeapDay(int year, int month, int day)
		{
			return this.IsLeapDay(year, month, day, 0);
		}

		// Token: 0x060033D0 RID: 13264
		public abstract bool IsLeapDay(int year, int month, int day, int era);

		// Token: 0x060033D1 RID: 13265 RVA: 0x000A4ADB File Offset: 0x000A2CDB
		public virtual bool IsLeapMonth(int year, int month)
		{
			return this.IsLeapMonth(year, month, 0);
		}

		// Token: 0x060033D2 RID: 13266
		public abstract bool IsLeapMonth(int year, int month, int era);

		// Token: 0x060033D3 RID: 13267 RVA: 0x000A4AE6 File Offset: 0x000A2CE6
		public virtual int GetLeapMonth(int year)
		{
			return this.GetLeapMonth(year, 0);
		}

		// Token: 0x060033D4 RID: 13268 RVA: 0x000A4AF0 File Offset: 0x000A2CF0
		public virtual int GetLeapMonth(int year, int era)
		{
			if (!this.IsLeapYear(year, era))
			{
				return 0;
			}
			int monthsInYear = this.GetMonthsInYear(year, era);
			for (int i = 1; i <= monthsInYear; i++)
			{
				if (this.IsLeapMonth(year, i, era))
				{
					return i;
				}
			}
			return 0;
		}

		// Token: 0x060033D5 RID: 13269 RVA: 0x000A4B2C File Offset: 0x000A2D2C
		public virtual bool IsLeapYear(int year)
		{
			return this.IsLeapYear(year, 0);
		}

		// Token: 0x060033D6 RID: 13270
		public abstract bool IsLeapYear(int year, int era);

		// Token: 0x060033D7 RID: 13271 RVA: 0x000A4B38 File Offset: 0x000A2D38
		public virtual DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond)
		{
			return this.ToDateTime(year, month, day, hour, minute, second, millisecond, 0);
		}

		// Token: 0x060033D8 RID: 13272
		public abstract DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era);

		// Token: 0x060033D9 RID: 13273 RVA: 0x000A4B58 File Offset: 0x000A2D58
		internal virtual bool TryToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era, out DateTime result)
		{
			result = DateTime.MinValue;
			bool result2;
			try
			{
				result = this.ToDateTime(year, month, day, hour, minute, second, millisecond, era);
				result2 = true;
			}
			catch (ArgumentException)
			{
				result2 = false;
			}
			return result2;
		}

		// Token: 0x060033DA RID: 13274 RVA: 0x000A4BA8 File Offset: 0x000A2DA8
		internal virtual bool IsValidYear(int year, int era)
		{
			return year >= this.GetYear(this.MinSupportedDateTime) && year <= this.GetYear(this.MaxSupportedDateTime);
		}

		// Token: 0x060033DB RID: 13275 RVA: 0x000A4BCD File Offset: 0x000A2DCD
		internal virtual bool IsValidMonth(int year, int month, int era)
		{
			return this.IsValidYear(year, era) && month >= 1 && month <= this.GetMonthsInYear(year, era);
		}

		// Token: 0x060033DC RID: 13276 RVA: 0x000A4BED File Offset: 0x000A2DED
		internal virtual bool IsValidDay(int year, int month, int day, int era)
		{
			return this.IsValidMonth(year, month, era) && day >= 1 && day <= this.GetDaysInMonth(year, month, era);
		}

		// Token: 0x1700096D RID: 2413
		// (get) Token: 0x060033DD RID: 13277 RVA: 0x000A4C11 File Offset: 0x000A2E11
		// (set) Token: 0x060033DE RID: 13278 RVA: 0x000A4C19 File Offset: 0x000A2E19
		public virtual int TwoDigitYearMax
		{
			get
			{
				return this._twoDigitYearMax;
			}
			set
			{
				this.VerifyWritable();
				this._twoDigitYearMax = value;
			}
		}

		// Token: 0x060033DF RID: 13279 RVA: 0x000A4C28 File Offset: 0x000A2E28
		public virtual int ToFourDigitYear(int year)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(year, "year");
			if (year < 100)
			{
				return (this.TwoDigitYearMax / 100 - ((year > this.TwoDigitYearMax % 100) ? 1 : 0)) * 100 + year;
			}
			return year;
		}

		// Token: 0x060033E0 RID: 13280 RVA: 0x000A4C58 File Offset: 0x000A2E58
		internal static long TimeToTicks(int hour, int minute, int second, int millisecond)
		{
			if (hour >= 24 || minute >= 60 || second >= 60)
			{
				throw new ArgumentOutOfRangeException(null, SR.ArgumentOutOfRange_BadHourMinuteSecond);
			}
			if ((ulong)millisecond >= 1000UL)
			{
				throw new ArgumentOutOfRangeException("millisecond", millisecond, SR.Format(SR.ArgumentOutOfRange_Range, 0, 999L));
			}
			return (long)(hour * 3600 + minute * 60 + second) * 10000000L + (long)millisecond * 10000L;
		}

		// Token: 0x060033E1 RID: 13281 RVA: 0x000A4CD8 File Offset: 0x000A2ED8
		internal static int GetSystemTwoDigitYearSetting(CalendarId CalID, int defaultYearValue)
		{
			int twoDigitYearMax = CalendarData.GetTwoDigitYearMax(CalID);
			if (twoDigitYearMax < 0)
			{
				return defaultYearValue;
			}
			return twoDigitYearMax;
		}

		// Token: 0x04000901 RID: 2305
		private int _currentEraValue = -1;

		// Token: 0x04000902 RID: 2306
		private bool _isReadOnly;

		// Token: 0x04000903 RID: 2307
		public const int CurrentEra = 0;

		// Token: 0x04000904 RID: 2308
		internal int _twoDigitYearMax = -1;
	}
}
