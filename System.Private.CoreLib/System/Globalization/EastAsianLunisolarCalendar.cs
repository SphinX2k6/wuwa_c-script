using System;
using System.Runtime.CompilerServices;

namespace System.Globalization
{
	// Token: 0x020002E8 RID: 744
	public abstract class EastAsianLunisolarCalendar : Calendar
	{
		// Token: 0x17000A37 RID: 2615
		// (get) Token: 0x0600369B RID: 13979 RVA: 0x000B2BC9 File Offset: 0x000B0DC9
		private static ReadOnlySpan<int> DaysToMonth365
		{
			get
			{
				return RuntimeHelpers.CreateSpan<int>(fieldof(<PrivateImplementationDetails>.3F1431B31172B4BE5418BDA2F4063F512F2F7A7CFDCE81A60B131792B5F7F6944).FieldHandle);
			}
		}

		// Token: 0x17000A38 RID: 2616
		// (get) Token: 0x0600369C RID: 13980 RVA: 0x000B2BD5 File Offset: 0x000B0DD5
		private static ReadOnlySpan<int> DaysToMonth366
		{
			get
			{
				return RuntimeHelpers.CreateSpan<int>(fieldof(<PrivateImplementationDetails>.FC405235E052D3DED17776A6B4C52CF9EFAE85050127AA6C45B5BA95F87ACCFD4).FieldHandle);
			}
		}

		// Token: 0x17000A39 RID: 2617
		// (get) Token: 0x0600369D RID: 13981 RVA: 0x0001FC46 File Offset: 0x0001DE46
		public override CalendarAlgorithmType AlgorithmType
		{
			get
			{
				return CalendarAlgorithmType.LunisolarCalendar;
			}
		}

		// Token: 0x0600369E RID: 13982 RVA: 0x000B2BE4 File Offset: 0x000B0DE4
		public virtual int GetSexagenaryYear(DateTime time)
		{
			this.CheckTicksRange(time.Ticks);
			int num;
			int num2;
			int num3;
			this.TimeToLunar(time, out num, out num2, out num3);
			return (num - 4) % 60 + 1;
		}

		// Token: 0x0600369F RID: 13983 RVA: 0x000B2C13 File Offset: 0x000B0E13
		public int GetCelestialStem(int sexagenaryYear)
		{
			if (sexagenaryYear < 1 || sexagenaryYear > 60)
			{
				throw new ArgumentOutOfRangeException("sexagenaryYear", sexagenaryYear, SR.Format(SR.ArgumentOutOfRange_Range, 1, 60));
			}
			return (sexagenaryYear - 1) % 10 + 1;
		}

		// Token: 0x060036A0 RID: 13984 RVA: 0x000B2C4E File Offset: 0x000B0E4E
		public int GetTerrestrialBranch(int sexagenaryYear)
		{
			if (sexagenaryYear < 1 || sexagenaryYear > 60)
			{
				throw new ArgumentOutOfRangeException("sexagenaryYear", sexagenaryYear, SR.Format(SR.ArgumentOutOfRange_Range, 1, 60));
			}
			return (sexagenaryYear - 1) % 12 + 1;
		}

		// Token: 0x060036A1 RID: 13985
		internal abstract int GetYearInfo(int LunarYear, int Index);

		// Token: 0x060036A2 RID: 13986
		internal abstract int GetYear(int year, DateTime time);

		// Token: 0x060036A3 RID: 13987
		internal abstract int GetGregorianYear(int year, int era);

		// Token: 0x17000A3A RID: 2618
		// (get) Token: 0x060036A4 RID: 13988
		internal abstract int MinCalendarYear { get; }

		// Token: 0x17000A3B RID: 2619
		// (get) Token: 0x060036A5 RID: 13989
		internal abstract int MaxCalendarYear { get; }

		// Token: 0x17000A3C RID: 2620
		// (get) Token: 0x060036A6 RID: 13990
		[Nullable(new byte[]
		{
			2,
			1
		})]
		internal abstract EraInfo[] CalEraInfo { get; }

		// Token: 0x17000A3D RID: 2621
		// (get) Token: 0x060036A7 RID: 13991
		internal abstract DateTime MinDate { get; }

		// Token: 0x17000A3E RID: 2622
		// (get) Token: 0x060036A8 RID: 13992
		internal abstract DateTime MaxDate { get; }

		// Token: 0x060036A9 RID: 13993 RVA: 0x000B2C8C File Offset: 0x000B0E8C
		internal int MinEraCalendarYear(int era)
		{
			EraInfo[] calEraInfo = this.CalEraInfo;
			if (calEraInfo == null)
			{
				return this.MinCalendarYear;
			}
			if (era == 0)
			{
				era = base.CurrentEraValue;
			}
			if (era == this.GetEra(this.MinDate))
			{
				return this.GetYear(this.MinCalendarYear, this.MinDate);
			}
			for (int i = 0; i < calEraInfo.Length; i++)
			{
				if (era == calEraInfo[i].era)
				{
					return calEraInfo[i].minEraYear;
				}
			}
			throw new ArgumentOutOfRangeException("era", era, SR.ArgumentOutOfRange_InvalidEraValue);
		}

		// Token: 0x060036AA RID: 13994 RVA: 0x000B2D10 File Offset: 0x000B0F10
		internal int MaxEraCalendarYear(int era)
		{
			EraInfo[] calEraInfo = this.CalEraInfo;
			if (calEraInfo == null)
			{
				return this.MaxCalendarYear;
			}
			if (era == 0)
			{
				era = base.CurrentEraValue;
			}
			if (era == this.GetEra(this.MaxDate))
			{
				return this.GetYear(this.MaxCalendarYear, this.MaxDate);
			}
			for (int i = 0; i < calEraInfo.Length; i++)
			{
				if (era == calEraInfo[i].era)
				{
					return calEraInfo[i].maxEraYear;
				}
			}
			throw new ArgumentOutOfRangeException("era", era, SR.ArgumentOutOfRange_InvalidEraValue);
		}

		// Token: 0x060036AB RID: 13995 RVA: 0x000B2D92 File Offset: 0x000B0F92
		internal EastAsianLunisolarCalendar()
		{
		}

		// Token: 0x060036AC RID: 13996 RVA: 0x000B2D9C File Offset: 0x000B0F9C
		internal void CheckTicksRange(long ticks)
		{
			if (ticks < this.MinSupportedDateTime.Ticks || ticks > this.MaxSupportedDateTime.Ticks)
			{
				throw new ArgumentOutOfRangeException("time", ticks, SR.Format(CultureInfo.InvariantCulture, SR.ArgumentOutOfRange_CalendarRange, this.MinSupportedDateTime, this.MaxSupportedDateTime));
			}
		}

		// Token: 0x060036AD RID: 13997 RVA: 0x000B2E04 File Offset: 0x000B1004
		internal void CheckEraRange(int era)
		{
			if (era == 0)
			{
				era = base.CurrentEraValue;
			}
			if (era < this.GetEra(this.MinDate) || era > this.GetEra(this.MaxDate))
			{
				throw new ArgumentOutOfRangeException("era", era, SR.ArgumentOutOfRange_InvalidEraValue);
			}
		}

		// Token: 0x060036AE RID: 13998 RVA: 0x000B2E50 File Offset: 0x000B1050
		internal int CheckYearRange(int year, int era)
		{
			this.CheckEraRange(era);
			year = this.GetGregorianYear(year, era);
			if (year < this.MinCalendarYear || year > this.MaxCalendarYear)
			{
				throw new ArgumentOutOfRangeException("year", year, SR.Format(SR.ArgumentOutOfRange_Range, this.MinEraCalendarYear(era), this.MaxEraCalendarYear(era)));
			}
			return year;
		}

		// Token: 0x060036AF RID: 13999 RVA: 0x000B2EB4 File Offset: 0x000B10B4
		internal int CheckYearMonthRange(int year, int month, int era)
		{
			year = this.CheckYearRange(year, era);
			if (month == 13 && this.GetYearInfo(year, 0) == 0)
			{
				ThrowHelper.ThrowArgumentOutOfRange_Month(month);
			}
			if (month < 1 || month > 13)
			{
				ThrowHelper.ThrowArgumentOutOfRange_Month(month);
			}
			return year;
		}

		// Token: 0x060036B0 RID: 14000 RVA: 0x000B2EE8 File Offset: 0x000B10E8
		internal int InternalGetDaysInMonth(int year, int month)
		{
			int num = 32768;
			num >>= month - 1;
			if ((this.GetYearInfo(year, 3) & num) == 0)
			{
				return 29;
			}
			return 30;
		}

		// Token: 0x060036B1 RID: 14001 RVA: 0x000B2F15 File Offset: 0x000B1115
		public override int GetDaysInMonth(int year, int month, int era)
		{
			year = this.CheckYearMonthRange(year, month, era);
			return this.InternalGetDaysInMonth(year, month);
		}

		// Token: 0x060036B2 RID: 14002 RVA: 0x000B2F2A File Offset: 0x000B112A
		private static bool GregorianIsLeapYear(int y)
		{
			return y % 4 == 0 && (y % 100 != 0 || y % 400 == 0);
		}

		// Token: 0x060036B3 RID: 14003 RVA: 0x000B2F48 File Offset: 0x000B1148
		public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era)
		{
			year = this.CheckYearMonthRange(year, month, era);
			int num = this.InternalGetDaysInMonth(year, month);
			if (day < 1 || day > num)
			{
				throw new ArgumentOutOfRangeException("day", day, SR.Format(SR.ArgumentOutOfRange_Day, num, month));
			}
			int year2;
			int month2;
			int day2;
			if (!this.LunarToGregorian(year, month, day, out year2, out month2, out day2))
			{
				throw new ArgumentOutOfRangeException(null, SR.ArgumentOutOfRange_BadYearMonthDay);
			}
			return new DateTime(year2, month2, day2, hour, minute, second, millisecond);
		}

		// Token: 0x060036B4 RID: 14004 RVA: 0x000B2FC8 File Offset: 0x000B11C8
		private unsafe void GregorianToLunar(int solarYear, int solarMonth, int solarDate, out int lunarYear, out int lunarMonth, out int lunarDate)
		{
			int i = (EastAsianLunisolarCalendar.GregorianIsLeapYear(solarYear) ? (*EastAsianLunisolarCalendar.DaysToMonth366[solarMonth - 1]) : (*EastAsianLunisolarCalendar.DaysToMonth365[solarMonth - 1])) + solarDate;
			lunarYear = solarYear;
			int yearInfo;
			int yearInfo2;
			if (lunarYear == this.MaxCalendarYear + 1)
			{
				lunarYear--;
				i += (EastAsianLunisolarCalendar.GregorianIsLeapYear(lunarYear) ? 366 : 365);
				yearInfo = this.GetYearInfo(lunarYear, 1);
				yearInfo2 = this.GetYearInfo(lunarYear, 2);
			}
			else
			{
				yearInfo = this.GetYearInfo(lunarYear, 1);
				yearInfo2 = this.GetYearInfo(lunarYear, 2);
				if (solarMonth < yearInfo || (solarMonth == yearInfo && solarDate < yearInfo2))
				{
					lunarYear--;
					i += (EastAsianLunisolarCalendar.GregorianIsLeapYear(lunarYear) ? 366 : 365);
					yearInfo = this.GetYearInfo(lunarYear, 1);
					yearInfo2 = this.GetYearInfo(lunarYear, 2);
				}
			}
			i -= *EastAsianLunisolarCalendar.DaysToMonth365[yearInfo - 1];
			i -= yearInfo2 - 1;
			int num = 32768;
			int yearInfo3 = this.GetYearInfo(lunarYear, 3);
			int num2 = ((yearInfo3 & num) != 0) ? 30 : 29;
			lunarMonth = 1;
			while (i > num2)
			{
				i -= num2;
				lunarMonth++;
				num >>= 1;
				num2 = (((yearInfo3 & num) != 0) ? 30 : 29);
			}
			lunarDate = i;
		}

		// Token: 0x060036B5 RID: 14005 RVA: 0x000B3114 File Offset: 0x000B1314
		private unsafe bool LunarToGregorian(int lunarYear, int lunarMonth, int lunarDate, out int solarYear, out int solarMonth, out int solarDay)
		{
			if (lunarDate < 1 || lunarDate > 30)
			{
				solarYear = 0;
				solarMonth = 0;
				solarDay = 0;
				return false;
			}
			int num = lunarDate - 1;
			for (int i = 1; i < lunarMonth; i++)
			{
				num += this.InternalGetDaysInMonth(lunarYear, i);
			}
			int yearInfo = this.GetYearInfo(lunarYear, 1);
			int yearInfo2 = this.GetYearInfo(lunarYear, 2);
			bool flag = EastAsianLunisolarCalendar.GregorianIsLeapYear(lunarYear);
			ReadOnlySpan<int> readOnlySpan = flag ? EastAsianLunisolarCalendar.DaysToMonth366 : EastAsianLunisolarCalendar.DaysToMonth365;
			solarDay = yearInfo2;
			if (yearInfo > 1)
			{
				solarDay += *readOnlySpan[yearInfo - 1];
			}
			solarDay += num;
			if (solarDay > 365 + ((flag > false) ? 1 : 0))
			{
				solarYear = lunarYear + 1;
				solarDay -= 365 + ((flag > false) ? 1 : 0);
			}
			else
			{
				solarYear = lunarYear;
			}
			solarMonth = 1;
			while (solarMonth < 12 && *readOnlySpan[solarMonth] < solarDay)
			{
				solarMonth++;
			}
			solarDay -= *readOnlySpan[solarMonth - 1];
			return true;
		}

		// Token: 0x060036B6 RID: 14006 RVA: 0x000B320C File Offset: 0x000B140C
		private DateTime LunarToTime(DateTime time, int year, int month, int day)
		{
			int year2;
			int month2;
			int day2;
			this.LunarToGregorian(year, month, day, out year2, out month2, out day2);
			int hour;
			int minute;
			int second;
			int millisecond;
			time.GetTime(out hour, out minute, out second, out millisecond);
			return GregorianCalendar.GetDefaultInstance().ToDateTime(year2, month2, day2, hour, minute, second, millisecond);
		}

		// Token: 0x060036B7 RID: 14007 RVA: 0x000B3250 File Offset: 0x000B1450
		private void TimeToLunar(DateTime time, out int year, out int month, out int day)
		{
			Calendar defaultInstance = GregorianCalendar.GetDefaultInstance();
			int year2 = defaultInstance.GetYear(time);
			int month2 = defaultInstance.GetMonth(time);
			int dayOfMonth = defaultInstance.GetDayOfMonth(time);
			this.GregorianToLunar(year2, month2, dayOfMonth, out year, out month, out day);
		}

		// Token: 0x060036B8 RID: 14008 RVA: 0x000B3288 File Offset: 0x000B1488
		public override DateTime AddMonths(DateTime time, int months)
		{
			if (months < -120000 || months > 120000)
			{
				throw new ArgumentOutOfRangeException("months", months, SR.Format(SR.ArgumentOutOfRange_Range, -120000, 120000));
			}
			this.CheckTicksRange(time.Ticks);
			int num;
			int num2;
			int num3;
			this.TimeToLunar(time, out num, out num2, out num3);
			int i = num2 + months;
			if (i > 0)
			{
				int num4 = this.InternalIsLeapYear(num) ? 13 : 12;
				while (i - num4 > 0)
				{
					i -= num4;
					num++;
					num4 = (this.InternalIsLeapYear(num) ? 13 : 12);
				}
				num2 = i;
			}
			else
			{
				while (i <= 0)
				{
					int num5 = this.InternalIsLeapYear(num - 1) ? 13 : 12;
					i += num5;
					num--;
				}
				num2 = i;
			}
			int num6 = this.InternalGetDaysInMonth(num, num2);
			if (num3 > num6)
			{
				num3 = num6;
			}
			DateTime result = this.LunarToTime(time, num, num2, num3);
			Calendar.CheckAddResult(result.Ticks, this.MinSupportedDateTime, this.MaxSupportedDateTime);
			return result;
		}

		// Token: 0x060036B9 RID: 14009 RVA: 0x000B3388 File Offset: 0x000B1588
		public override DateTime AddYears(DateTime time, int years)
		{
			this.CheckTicksRange(time.Ticks);
			int num;
			int num2;
			int num3;
			this.TimeToLunar(time, out num, out num2, out num3);
			num += years;
			if (num2 == 13 && !this.InternalIsLeapYear(num))
			{
				num2 = 12;
				num3 = this.InternalGetDaysInMonth(num, num2);
			}
			int num4 = this.InternalGetDaysInMonth(num, num2);
			if (num3 > num4)
			{
				num3 = num4;
			}
			DateTime result = this.LunarToTime(time, num, num2, num3);
			Calendar.CheckAddResult(result.Ticks, this.MinSupportedDateTime, this.MaxSupportedDateTime);
			return result;
		}

		// Token: 0x060036BA RID: 14010 RVA: 0x000B3404 File Offset: 0x000B1604
		public override int GetDayOfYear(DateTime time)
		{
			this.CheckTicksRange(time.Ticks);
			int year;
			int num;
			int num2;
			this.TimeToLunar(time, out year, out num, out num2);
			for (int i = 1; i < num; i++)
			{
				num2 += this.InternalGetDaysInMonth(year, i);
			}
			return num2;
		}

		// Token: 0x060036BB RID: 14011 RVA: 0x000B3444 File Offset: 0x000B1644
		public override int GetDayOfMonth(DateTime time)
		{
			this.CheckTicksRange(time.Ticks);
			int num;
			int num2;
			int result;
			this.TimeToLunar(time, out num, out num2, out result);
			return result;
		}

		// Token: 0x060036BC RID: 14012 RVA: 0x000B346C File Offset: 0x000B166C
		public override int GetDaysInYear(int year, int era)
		{
			year = this.CheckYearRange(year, era);
			int num = 0;
			int num2 = this.InternalIsLeapYear(year) ? 13 : 12;
			while (num2 != 0)
			{
				num += this.InternalGetDaysInMonth(year, num2--);
			}
			return num;
		}

		// Token: 0x060036BD RID: 14013 RVA: 0x000B34AC File Offset: 0x000B16AC
		public override int GetMonth(DateTime time)
		{
			this.CheckTicksRange(time.Ticks);
			int num;
			int result;
			int num2;
			this.TimeToLunar(time, out num, out result, out num2);
			return result;
		}

		// Token: 0x060036BE RID: 14014 RVA: 0x000B34D4 File Offset: 0x000B16D4
		public override int GetYear(DateTime time)
		{
			this.CheckTicksRange(time.Ticks);
			int year;
			int num;
			int num2;
			this.TimeToLunar(time, out year, out num, out num2);
			return this.GetYear(year, time);
		}

		// Token: 0x060036BF RID: 14015 RVA: 0x000B3503 File Offset: 0x000B1703
		public override DayOfWeek GetDayOfWeek(DateTime time)
		{
			this.CheckTicksRange(time.Ticks);
			return time.DayOfWeek;
		}

		// Token: 0x060036C0 RID: 14016 RVA: 0x000B3519 File Offset: 0x000B1719
		public override int GetMonthsInYear(int year, int era)
		{
			year = this.CheckYearRange(year, era);
			if (!this.InternalIsLeapYear(year))
			{
				return 12;
			}
			return 13;
		}

		// Token: 0x060036C1 RID: 14017 RVA: 0x000B3534 File Offset: 0x000B1734
		public override bool IsLeapDay(int year, int month, int day, int era)
		{
			year = this.CheckYearMonthRange(year, month, era);
			int num = this.InternalGetDaysInMonth(year, month);
			if (day < 1 || day > num)
			{
				throw new ArgumentOutOfRangeException("day", day, SR.Format(SR.ArgumentOutOfRange_Day, num, month));
			}
			int yearInfo = this.GetYearInfo(year, 0);
			return yearInfo != 0 && month == yearInfo + 1;
		}

		// Token: 0x060036C2 RID: 14018 RVA: 0x000B359C File Offset: 0x000B179C
		public override bool IsLeapMonth(int year, int month, int era)
		{
			year = this.CheckYearMonthRange(year, month, era);
			int yearInfo = this.GetYearInfo(year, 0);
			return yearInfo != 0 && month == yearInfo + 1;
		}

		// Token: 0x060036C3 RID: 14019 RVA: 0x000B35C8 File Offset: 0x000B17C8
		public override int GetLeapMonth(int year, int era)
		{
			year = this.CheckYearRange(year, era);
			int yearInfo = this.GetYearInfo(year, 0);
			if (yearInfo <= 0)
			{
				return 0;
			}
			return yearInfo + 1;
		}

		// Token: 0x060036C4 RID: 14020 RVA: 0x000B35F1 File Offset: 0x000B17F1
		internal bool InternalIsLeapYear(int year)
		{
			return this.GetYearInfo(year, 0) != 0;
		}

		// Token: 0x060036C5 RID: 14021 RVA: 0x000B35FE File Offset: 0x000B17FE
		public override bool IsLeapYear(int year, int era)
		{
			year = this.CheckYearRange(year, era);
			return this.InternalIsLeapYear(year);
		}

		// Token: 0x17000A3F RID: 2623
		// (get) Token: 0x060036C6 RID: 14022 RVA: 0x000B3611 File Offset: 0x000B1811
		// (set) Token: 0x060036C7 RID: 14023 RVA: 0x000B3648 File Offset: 0x000B1848
		public override int TwoDigitYearMax
		{
			get
			{
				if (this._twoDigitYearMax == -1)
				{
					this._twoDigitYearMax = Calendar.GetSystemTwoDigitYearSetting(this.BaseCalendarID, this.GetYear(new DateTime(2049, 1, 1)));
				}
				return this._twoDigitYearMax;
			}
			set
			{
				base.VerifyWritable();
				if (value < 99 || value > this.MaxCalendarYear)
				{
					throw new ArgumentOutOfRangeException("value", value, SR.Format(SR.ArgumentOutOfRange_Range, 99, this.MaxCalendarYear));
				}
				this._twoDigitYearMax = value;
			}
		}

		// Token: 0x060036C8 RID: 14024 RVA: 0x000B369D File Offset: 0x000B189D
		public override int ToFourDigitYear(int year)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(year, "year");
			year = base.ToFourDigitYear(year);
			this.CheckYearRange(year, 0);
			return year;
		}
	}
}
