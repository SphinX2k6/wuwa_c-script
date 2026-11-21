using System;

namespace System.Globalization
{
	// Token: 0x020002EE RID: 750
	internal sealed class GregorianCalendarHelper
	{
		// Token: 0x17000A4F RID: 2639
		// (get) Token: 0x060036FF RID: 14079 RVA: 0x000B40F9 File Offset: 0x000B22F9
		internal int MaxYear
		{
			get
			{
				return this.m_maxYear;
			}
		}

		// Token: 0x06003700 RID: 14080 RVA: 0x000B4101 File Offset: 0x000B2301
		internal GregorianCalendarHelper(Calendar cal, EraInfo[] eraInfo)
		{
			this.m_Cal = cal;
			this.m_EraInfo = eraInfo;
			this.m_maxYear = eraInfo[0].maxEraYear;
			this.m_minYear = eraInfo[0].minEraYear;
		}

		// Token: 0x06003701 RID: 14081 RVA: 0x000B4134 File Offset: 0x000B2334
		private int GetYearOffset(int year, int era, bool throwOnError)
		{
			if (year < 0)
			{
				if (throwOnError)
				{
					throw new ArgumentOutOfRangeException("year", SR.ArgumentOutOfRange_NeedNonNegNum);
				}
				return -1;
			}
			else
			{
				if (era == 0)
				{
					era = this.m_Cal.CurrentEraValue;
				}
				EraInfo[] eraInfo = this.m_EraInfo;
				int i = 0;
				while (i < eraInfo.Length)
				{
					EraInfo eraInfo2 = eraInfo[i];
					if (era == eraInfo2.era)
					{
						if (year >= eraInfo2.minEraYear)
						{
							if (year <= eraInfo2.maxEraYear)
							{
								return eraInfo2.yearOffset;
							}
							if (!LocalAppContextSwitches.EnforceJapaneseEraYearRanges)
							{
								int num = year - eraInfo2.maxEraYear;
								for (int j = i - 1; j >= 0; j--)
								{
									if (num <= eraInfo[j].maxEraYear)
									{
										return eraInfo2.yearOffset;
									}
									num -= eraInfo[j].maxEraYear;
								}
							}
						}
						if (throwOnError)
						{
							throw new ArgumentOutOfRangeException("year", SR.Format(SR.ArgumentOutOfRange_Range, eraInfo2.minEraYear, eraInfo2.maxEraYear));
						}
						break;
					}
					else
					{
						i++;
					}
				}
				if (throwOnError)
				{
					throw new ArgumentOutOfRangeException("era", SR.ArgumentOutOfRange_InvalidEraValue);
				}
				return -1;
			}
		}

		// Token: 0x06003702 RID: 14082 RVA: 0x000B4231 File Offset: 0x000B2431
		internal int GetGregorianYear(int year, int era)
		{
			return this.GetYearOffset(year, era, true) + year;
		}

		// Token: 0x06003703 RID: 14083 RVA: 0x000B423E File Offset: 0x000B243E
		internal bool IsValidYear(int year, int era)
		{
			return this.GetYearOffset(year, era, false) >= 0;
		}

		// Token: 0x06003704 RID: 14084 RVA: 0x000B4250 File Offset: 0x000B2450
		internal void CheckTicksRange(long ticks)
		{
			if (ticks < this.m_Cal.MinSupportedDateTime.Ticks || ticks > this.m_Cal.MaxSupportedDateTime.Ticks)
			{
				throw new ArgumentOutOfRangeException("time", SR.Format(CultureInfo.InvariantCulture, SR.ArgumentOutOfRange_CalendarRange, this.m_Cal.MinSupportedDateTime, this.m_Cal.MaxSupportedDateTime));
			}
		}

		// Token: 0x06003705 RID: 14085 RVA: 0x000B42C4 File Offset: 0x000B24C4
		public unsafe DateTime AddMonths(DateTime time, int months)
		{
			if (months < -120000 || months > 120000)
			{
				throw new ArgumentOutOfRangeException("months", SR.Format(SR.ArgumentOutOfRange_Range, -120000, 120000));
			}
			this.CheckTicksRange(time.Ticks);
			int num;
			int num2;
			int num3;
			time.GetDate(out num, out num2, out num3);
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
			long ticks = GregorianCalendar.DateToTicks(num, num2, num3) + time.TimeOfDay.Ticks;
			Calendar.CheckAddResult(ticks, this.m_Cal.MinSupportedDateTime, this.m_Cal.MaxSupportedDateTime);
			return new DateTime(ticks);
		}

		// Token: 0x06003706 RID: 14086 RVA: 0x000B43CD File Offset: 0x000B25CD
		public DateTime AddYears(DateTime time, int years)
		{
			return this.AddMonths(time, years * 12);
		}

		// Token: 0x06003707 RID: 14087 RVA: 0x000B43DA File Offset: 0x000B25DA
		public int GetDayOfMonth(DateTime time)
		{
			this.CheckTicksRange(time.Ticks);
			return time.Day;
		}

		// Token: 0x06003708 RID: 14088 RVA: 0x000B43F0 File Offset: 0x000B25F0
		public DayOfWeek GetDayOfWeek(DateTime time)
		{
			this.CheckTicksRange(time.Ticks);
			return time.DayOfWeek;
		}

		// Token: 0x06003709 RID: 14089 RVA: 0x000B4406 File Offset: 0x000B2606
		public int GetDayOfYear(DateTime time)
		{
			this.CheckTicksRange(time.Ticks);
			return time.DayOfYear;
		}

		// Token: 0x0600370A RID: 14090 RVA: 0x000B441C File Offset: 0x000B261C
		public unsafe int GetDaysInMonth(int year, int month, int era)
		{
			year = this.GetGregorianYear(year, era);
			if (month < 1 || month > 12)
			{
				ThrowHelper.ThrowArgumentOutOfRange_Month(month);
			}
			ReadOnlySpan<int> readOnlySpan = (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0)) ? GregorianCalendar.DaysToMonth366 : GregorianCalendar.DaysToMonth365;
			return *readOnlySpan[month] - *readOnlySpan[month - 1];
		}

		// Token: 0x0600370B RID: 14091 RVA: 0x000B4478 File Offset: 0x000B2678
		public int GetDaysInYear(int year, int era)
		{
			year = this.GetGregorianYear(year, era);
			if (year % 4 != 0 || (year % 100 == 0 && year % 400 != 0))
			{
				return 365;
			}
			return 366;
		}

		// Token: 0x0600370C RID: 14092 RVA: 0x000B44A4 File Offset: 0x000B26A4
		public int GetEra(DateTime time)
		{
			long ticks = time.Ticks;
			foreach (EraInfo eraInfo2 in this.m_EraInfo)
			{
				if (ticks >= eraInfo2.ticks)
				{
					return eraInfo2.era;
				}
			}
			throw new ArgumentOutOfRangeException("time", SR.ArgumentOutOfRange_Era);
		}

		// Token: 0x17000A50 RID: 2640
		// (get) Token: 0x0600370D RID: 14093 RVA: 0x000B44F4 File Offset: 0x000B26F4
		public int[] Eras
		{
			get
			{
				EraInfo[] eraInfo = this.m_EraInfo;
				int[] array = new int[eraInfo.Length];
				for (int i = 0; i < eraInfo.Length; i++)
				{
					array[i] = eraInfo[i].era;
				}
				return array;
			}
		}

		// Token: 0x0600370E RID: 14094 RVA: 0x000B452B File Offset: 0x000B272B
		public int GetMonth(DateTime time)
		{
			this.CheckTicksRange(time.Ticks);
			return time.Month;
		}

		// Token: 0x0600370F RID: 14095 RVA: 0x000B4541 File Offset: 0x000B2741
		public int GetMonthsInYear(int year, int era)
		{
			this.ValidateYearInEra(year, era);
			return 12;
		}

		// Token: 0x06003710 RID: 14096 RVA: 0x000B4550 File Offset: 0x000B2750
		public int GetYear(DateTime time)
		{
			long ticks = time.Ticks;
			this.CheckTicksRange(ticks);
			foreach (EraInfo eraInfo2 in this.m_EraInfo)
			{
				if (ticks >= eraInfo2.ticks)
				{
					return time.Year - eraInfo2.yearOffset;
				}
			}
			throw new ArgumentException(SR.Argument_NoEra);
		}

		// Token: 0x06003711 RID: 14097 RVA: 0x000B45A8 File Offset: 0x000B27A8
		public int GetYear(int year, DateTime time)
		{
			long ticks = time.Ticks;
			foreach (EraInfo eraInfo2 in this.m_EraInfo)
			{
				if (ticks >= eraInfo2.ticks && year > eraInfo2.yearOffset)
				{
					return year - eraInfo2.yearOffset;
				}
			}
			throw new ArgumentException(SR.Argument_NoEra);
		}

		// Token: 0x06003712 RID: 14098 RVA: 0x000B45FC File Offset: 0x000B27FC
		public bool IsLeapDay(int year, int month, int day, int era)
		{
			if (day < 1 || day > this.GetDaysInMonth(year, month, era))
			{
				throw new ArgumentOutOfRangeException("day", SR.Format(SR.ArgumentOutOfRange_Range, 1, this.GetDaysInMonth(year, month, era)));
			}
			return this.IsLeapYear(year, era) && (month == 2 && day == 29);
		}

		// Token: 0x06003713 RID: 14099 RVA: 0x000B465D File Offset: 0x000B285D
		public void ValidateYearInEra(int year, int era)
		{
			this.GetYearOffset(year, era, true);
		}

		// Token: 0x06003714 RID: 14100 RVA: 0x000B4669 File Offset: 0x000B2869
		public int GetLeapMonth(int year, int era)
		{
			this.ValidateYearInEra(year, era);
			return 0;
		}

		// Token: 0x06003715 RID: 14101 RVA: 0x000B4674 File Offset: 0x000B2874
		public bool IsLeapMonth(int year, int month, int era)
		{
			this.ValidateYearInEra(year, era);
			if (month < 1 || month > 12)
			{
				throw new ArgumentOutOfRangeException("month", SR.Format(SR.ArgumentOutOfRange_Range, 1, 12));
			}
			return false;
		}

		// Token: 0x06003716 RID: 14102 RVA: 0x000B46AA File Offset: 0x000B28AA
		public bool IsLeapYear(int year, int era)
		{
			year = this.GetGregorianYear(year, era);
			return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
		}

		// Token: 0x06003717 RID: 14103 RVA: 0x000B46D0 File Offset: 0x000B28D0
		public DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era)
		{
			year = this.GetGregorianYear(year, era);
			long ticks = GregorianCalendar.DateToTicks(year, month, day) + Calendar.TimeToTicks(hour, minute, second, millisecond);
			this.CheckTicksRange(ticks);
			return new DateTime(ticks);
		}

		// Token: 0x06003718 RID: 14104 RVA: 0x000B470C File Offset: 0x000B290C
		public int GetWeekOfYear(DateTime time, CalendarWeekRule rule, DayOfWeek firstDayOfWeek)
		{
			this.CheckTicksRange(time.Ticks);
			return GregorianCalendar.GetDefaultInstance().GetWeekOfYear(time, rule, firstDayOfWeek);
		}

		// Token: 0x06003719 RID: 14105 RVA: 0x000B4728 File Offset: 0x000B2928
		public int ToFourDigitYear(int year, int twoDigitYearMax)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(year, "year");
			if (year < 100)
			{
				return (twoDigitYearMax / 100 - ((year > twoDigitYearMax % 100) ? 1 : 0)) * 100 + year;
			}
			if (year < this.m_minYear || year > this.m_maxYear)
			{
				throw new ArgumentOutOfRangeException("year", SR.Format(SR.ArgumentOutOfRange_Range, this.m_minYear, this.m_maxYear));
			}
			return year;
		}

		// Token: 0x04000A99 RID: 2713
		private readonly int m_maxYear;

		// Token: 0x04000A9A RID: 2714
		private readonly int m_minYear;

		// Token: 0x04000A9B RID: 2715
		private readonly Calendar m_Cal;

		// Token: 0x04000A9C RID: 2716
		private readonly EraInfo[] m_EraInfo;
	}
}
