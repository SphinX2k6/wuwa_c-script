using System;
using System.Runtime.CompilerServices;

namespace System.Globalization
{
	// Token: 0x020002EC RID: 748
	public class GregorianCalendar : Calendar
	{
		// Token: 0x17000A46 RID: 2630
		// (get) Token: 0x060036D9 RID: 14041 RVA: 0x000B3961 File Offset: 0x000B1B61
		internal static ReadOnlySpan<int> DaysToMonth365
		{
			get
			{
				return RuntimeHelpers.CreateSpan<int>(fieldof(<PrivateImplementationDetails>.5857EE4CE98BFABBD62B385C1098507DD0052FF3951043AAD6A1DABD495F18AA4).FieldHandle);
			}
		}

		// Token: 0x17000A47 RID: 2631
		// (get) Token: 0x060036DA RID: 14042 RVA: 0x000B396D File Offset: 0x000B1B6D
		internal static ReadOnlySpan<int> DaysToMonth366
		{
			get
			{
				return RuntimeHelpers.CreateSpan<int>(fieldof(<PrivateImplementationDetails>.FADB218011E7702BB9575D0C32A685DA10B5C72EB809BD9A955DB1C76E4D83154).FieldHandle);
			}
		}

		// Token: 0x17000A48 RID: 2632
		// (get) Token: 0x060036DB RID: 14043 RVA: 0x000A4701 File Offset: 0x000A2901
		public override DateTime MinSupportedDateTime
		{
			get
			{
				return DateTime.MinValue;
			}
		}

		// Token: 0x17000A49 RID: 2633
		// (get) Token: 0x060036DC RID: 14044 RVA: 0x000A4708 File Offset: 0x000A2908
		public override DateTime MaxSupportedDateTime
		{
			get
			{
				return DateTime.MaxValue;
			}
		}

		// Token: 0x17000A4A RID: 2634
		// (get) Token: 0x060036DD RID: 14045 RVA: 0x000070DD File Offset: 0x000052DD
		public override CalendarAlgorithmType AlgorithmType
		{
			get
			{
				return CalendarAlgorithmType.SolarCalendar;
			}
		}

		// Token: 0x060036DE RID: 14046 RVA: 0x000B3979 File Offset: 0x000B1B79
		internal static Calendar GetDefaultInstance()
		{
			Calendar result;
			if ((result = GregorianCalendar.s_defaultInstance) == null)
			{
				result = (GregorianCalendar.s_defaultInstance = new GregorianCalendar());
			}
			return result;
		}

		// Token: 0x060036DF RID: 14047 RVA: 0x000B398F File Offset: 0x000B1B8F
		public GregorianCalendar() : this(GregorianCalendarTypes.Localized)
		{
		}

		// Token: 0x060036E0 RID: 14048 RVA: 0x000B3998 File Offset: 0x000B1B98
		public GregorianCalendar(GregorianCalendarTypes type)
		{
			if (type < GregorianCalendarTypes.Localized || type > GregorianCalendarTypes.TransliteratedFrench)
			{
				throw new ArgumentOutOfRangeException("type", type, SR.Format(SR.ArgumentOutOfRange_Range, GregorianCalendarTypes.Localized, GregorianCalendarTypes.TransliteratedFrench));
			}
			this._type = type;
		}

		// Token: 0x17000A4B RID: 2635
		// (get) Token: 0x060036E1 RID: 14049 RVA: 0x000B39D8 File Offset: 0x000B1BD8
		// (set) Token: 0x060036E2 RID: 14050 RVA: 0x000B39E0 File Offset: 0x000B1BE0
		public virtual GregorianCalendarTypes CalendarType
		{
			get
			{
				return this._type;
			}
			set
			{
				base.VerifyWritable();
				if (value < GregorianCalendarTypes.Localized || value > GregorianCalendarTypes.TransliteratedFrench)
				{
					throw new ArgumentOutOfRangeException("value", value, SR.Format(SR.ArgumentOutOfRange_Range, GregorianCalendarTypes.Localized, GregorianCalendarTypes.TransliteratedFrench));
				}
				this._type = value;
			}
		}

		// Token: 0x17000A4C RID: 2636
		// (get) Token: 0x060036E3 RID: 14051 RVA: 0x000B3A20 File Offset: 0x000B1C20
		internal override CalendarId ID
		{
			get
			{
				return (CalendarId)this._type;
			}
		}

		// Token: 0x060036E4 RID: 14052 RVA: 0x000B3A2C File Offset: 0x000B1C2C
		internal unsafe static long GetAbsoluteDate(int year, int month, int day)
		{
			if (year >= 1 && year <= 9999 && month >= 1 && month <= 12)
			{
				ReadOnlySpan<int> readOnlySpan = (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0)) ? GregorianCalendar.DaysToMonth366 : GregorianCalendar.DaysToMonth365;
				if (day >= 1 && day <= *readOnlySpan[month] - *readOnlySpan[month - 1])
				{
					int num = year - 1;
					return (long)(num * 365 + num / 4 - num / 100 + num / 400 + *readOnlySpan[month - 1] + day - 1);
				}
			}
			throw new ArgumentOutOfRangeException(null, SR.ArgumentOutOfRange_BadYearMonthDay);
		}

		// Token: 0x060036E5 RID: 14053 RVA: 0x000B3AC4 File Offset: 0x000B1CC4
		internal static long DateToTicks(int year, int month, int day)
		{
			return GregorianCalendar.GetAbsoluteDate(year, month, day) * 864000000000L;
		}

		// Token: 0x060036E6 RID: 14054 RVA: 0x000B3AD8 File Offset: 0x000B1CD8
		public unsafe override DateTime AddMonths(DateTime time, int months)
		{
			if (months < -120000 || months > 120000)
			{
				throw new ArgumentOutOfRangeException("months", months, SR.Format(SR.ArgumentOutOfRange_Range, -120000, 120000));
			}
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
			long ticks = GregorianCalendar.DateToTicks(num, num2, num3) + time.Ticks % 864000000000L;
			Calendar.CheckAddResult(ticks, this.MinSupportedDateTime, this.MaxSupportedDateTime);
			return new DateTime(ticks);
		}

		// Token: 0x060036E7 RID: 14055 RVA: 0x000B3BD1 File Offset: 0x000B1DD1
		public override DateTime AddYears(DateTime time, int years)
		{
			return this.AddMonths(time, years * 12);
		}

		// Token: 0x060036E8 RID: 14056 RVA: 0x000B3BDE File Offset: 0x000B1DDE
		public override int GetDayOfMonth(DateTime time)
		{
			return time.Day;
		}

		// Token: 0x060036E9 RID: 14057 RVA: 0x000B3BE7 File Offset: 0x000B1DE7
		public override DayOfWeek GetDayOfWeek(DateTime time)
		{
			return time.DayOfWeek;
		}

		// Token: 0x060036EA RID: 14058 RVA: 0x000B3BF0 File Offset: 0x000B1DF0
		public override int GetDayOfYear(DateTime time)
		{
			return time.DayOfYear;
		}

		// Token: 0x060036EB RID: 14059 RVA: 0x000B3BF9 File Offset: 0x000B1DF9
		public override int GetDaysInMonth(int year, int month, int era)
		{
			if (era != 0 && era != 1)
			{
				throw new ArgumentOutOfRangeException("era", era, SR.ArgumentOutOfRange_InvalidEraValue);
			}
			return DateTime.DaysInMonth(year, month);
		}

		// Token: 0x060036EC RID: 14060 RVA: 0x000B3C1F File Offset: 0x000B1E1F
		public override int GetDaysInYear(int year, int era)
		{
			if (era != 0 && era != 1)
			{
				throw new ArgumentOutOfRangeException("era", era, SR.ArgumentOutOfRange_InvalidEraValue);
			}
			if (!DateTime.IsLeapYear(year))
			{
				return 365;
			}
			return 366;
		}

		// Token: 0x060036ED RID: 14061 RVA: 0x000070DD File Offset: 0x000052DD
		public override int GetEra(DateTime time)
		{
			return 1;
		}

		// Token: 0x17000A4D RID: 2637
		// (get) Token: 0x060036EE RID: 14062 RVA: 0x000A787E File Offset: 0x000A5A7E
		[Nullable(1)]
		public override int[] Eras
		{
			[NullableContext(1)]
			get
			{
				return new int[]
				{
					1
				};
			}
		}

		// Token: 0x060036EF RID: 14063 RVA: 0x000B3C51 File Offset: 0x000B1E51
		public override int GetMonth(DateTime time)
		{
			return time.Month;
		}

		// Token: 0x060036F0 RID: 14064 RVA: 0x000B3C5C File Offset: 0x000B1E5C
		public override int GetMonthsInYear(int year, int era)
		{
			if (era != 0 && era != 1)
			{
				throw new ArgumentOutOfRangeException("era", era, SR.ArgumentOutOfRange_InvalidEraValue);
			}
			if (year < 1 || year > 9999)
			{
				throw new ArgumentOutOfRangeException("year", year, SR.Format(SR.ArgumentOutOfRange_Range, 1, 9999));
			}
			return 12;
		}

		// Token: 0x060036F1 RID: 14065 RVA: 0x000B3CBF File Offset: 0x000B1EBF
		public override int GetYear(DateTime time)
		{
			return time.Year;
		}

		// Token: 0x060036F2 RID: 14066 RVA: 0x000B3CC8 File Offset: 0x000B1EC8
		internal override bool IsValidYear(int year, int era)
		{
			return year >= 1 && year <= 9999;
		}

		// Token: 0x060036F3 RID: 14067 RVA: 0x000B3CDC File Offset: 0x000B1EDC
		internal unsafe override bool IsValidDay(int year, int month, int day, int era)
		{
			if ((era != 0 && era != 1) || year < 1 || year > 9999 || month < 1 || month > 12 || day < 1)
			{
				return false;
			}
			ReadOnlySpan<int> readOnlySpan = (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0)) ? GregorianCalendar.DaysToMonth366 : GregorianCalendar.DaysToMonth365;
			return day <= *readOnlySpan[month] - *readOnlySpan[month - 1];
		}

		// Token: 0x060036F4 RID: 14068 RVA: 0x000B3D4C File Offset: 0x000B1F4C
		public override bool IsLeapDay(int year, int month, int day, int era)
		{
			if (month < 1 || month > 12)
			{
				throw new ArgumentOutOfRangeException("month", month, SR.Format(SR.ArgumentOutOfRange_Range, 1, 12));
			}
			if (era != 0 && era != 1)
			{
				throw new ArgumentOutOfRangeException("era", era, SR.ArgumentOutOfRange_InvalidEraValue);
			}
			if (year < 1 || year > 9999)
			{
				throw new ArgumentOutOfRangeException("year", year, SR.Format(SR.ArgumentOutOfRange_Range, 1, 9999));
			}
			if (day < 1 || day > this.GetDaysInMonth(year, month))
			{
				throw new ArgumentOutOfRangeException("day", day, SR.Format(SR.ArgumentOutOfRange_Range, 1, this.GetDaysInMonth(year, month)));
			}
			return this.IsLeapYear(year) && month == 2 && day == 29;
		}

		// Token: 0x060036F5 RID: 14069 RVA: 0x000B3E34 File Offset: 0x000B2034
		public override int GetLeapMonth(int year, int era)
		{
			if (era != 0 && era != 1)
			{
				throw new ArgumentOutOfRangeException("era", era, SR.ArgumentOutOfRange_InvalidEraValue);
			}
			if (year < 1 || year > 9999)
			{
				throw new ArgumentOutOfRangeException("year", year, SR.Format(SR.ArgumentOutOfRange_Range, 1, 9999));
			}
			return 0;
		}

		// Token: 0x060036F6 RID: 14070 RVA: 0x000B3E98 File Offset: 0x000B2098
		public override bool IsLeapMonth(int year, int month, int era)
		{
			if (era != 0 && era != 1)
			{
				throw new ArgumentOutOfRangeException("era", era, SR.ArgumentOutOfRange_InvalidEraValue);
			}
			if (year < 1 || year > 9999)
			{
				throw new ArgumentOutOfRangeException("year", year, SR.Format(SR.ArgumentOutOfRange_Range, 1, 9999));
			}
			if (month < 1 || month > 12)
			{
				throw new ArgumentOutOfRangeException("month", month, SR.Format(SR.ArgumentOutOfRange_Range, 1, 12));
			}
			return false;
		}

		// Token: 0x060036F7 RID: 14071 RVA: 0x000B3F2B File Offset: 0x000B212B
		public override bool IsLeapYear(int year, int era)
		{
			if (era != 0 && era != 1)
			{
				throw new ArgumentOutOfRangeException("era", era, SR.ArgumentOutOfRange_InvalidEraValue);
			}
			return DateTime.IsLeapYear(year);
		}

		// Token: 0x060036F8 RID: 14072 RVA: 0x000B3F50 File Offset: 0x000B2150
		public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era)
		{
			if (era != 0 && era != 1)
			{
				throw new ArgumentOutOfRangeException("era", era, SR.ArgumentOutOfRange_InvalidEraValue);
			}
			return new DateTime(year, month, day, hour, minute, second, millisecond);
		}

		// Token: 0x060036F9 RID: 14073 RVA: 0x000B3F82 File Offset: 0x000B2182
		internal override bool TryToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era, out DateTime result)
		{
			if (era != 0 && era != 1)
			{
				result = DateTime.MinValue;
				return false;
			}
			return DateTime.TryCreate(year, month, day, hour, minute, second, millisecond, out result);
		}

		// Token: 0x17000A4E RID: 2638
		// (get) Token: 0x060036FA RID: 14074 RVA: 0x000B3FAD File Offset: 0x000B21AD
		// (set) Token: 0x060036FB RID: 14075 RVA: 0x000B3FD4 File Offset: 0x000B21D4
		public override int TwoDigitYearMax
		{
			get
			{
				if (this._twoDigitYearMax == -1)
				{
					this._twoDigitYearMax = Calendar.GetSystemTwoDigitYearSetting(this.ID, 2049);
				}
				return this._twoDigitYearMax;
			}
			set
			{
				base.VerifyWritable();
				if (value < 99 || value > 9999)
				{
					throw new ArgumentOutOfRangeException("value", value, SR.Format(SR.ArgumentOutOfRange_Range, 99, 9999));
				}
				this._twoDigitYearMax = value;
			}
		}

		// Token: 0x060036FC RID: 14076 RVA: 0x000B4027 File Offset: 0x000B2227
		public override int ToFourDigitYear(int year)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(year, "year");
			ArgumentOutOfRangeException.ThrowIfGreaterThan<int>(year, 9999, "year");
			return base.ToFourDigitYear(year);
		}

		// Token: 0x04000A8E RID: 2702
		public const int ADEra = 1;

		// Token: 0x04000A8F RID: 2703
		private GregorianCalendarTypes _type;

		// Token: 0x04000A90 RID: 2704
		private static Calendar s_defaultInstance;
	}
}
