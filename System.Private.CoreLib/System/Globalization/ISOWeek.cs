using System;
using System.Runtime.CompilerServices;

namespace System.Globalization
{
	// Token: 0x020002FD RID: 765
	public static class ISOWeek
	{
		// Token: 0x060037AD RID: 14253 RVA: 0x000B7B60 File Offset: 0x000B5D60
		public static int GetWeekOfYear(DateTime date)
		{
			int weekNumber = ISOWeek.GetWeekNumber(date);
			if (weekNumber < 1)
			{
				return ISOWeek.GetWeeksInYear(date.Year - 1);
			}
			if (weekNumber > ISOWeek.GetWeeksInYear(date.Year))
			{
				return 1;
			}
			return weekNumber;
		}

		// Token: 0x060037AE RID: 14254 RVA: 0x000B7B9C File Offset: 0x000B5D9C
		public static int GetYear(DateTime date)
		{
			int weekNumber = ISOWeek.GetWeekNumber(date);
			if (weekNumber < 1)
			{
				return date.Year - 1;
			}
			if (weekNumber > ISOWeek.GetWeeksInYear(date.Year))
			{
				return date.Year + 1;
			}
			return date.Year;
		}

		// Token: 0x060037AF RID: 14255 RVA: 0x000B7BDE File Offset: 0x000B5DDE
		public static DateTime GetYearStart(int year)
		{
			return ISOWeek.ToDateTime(year, 1, DayOfWeek.Monday);
		}

		// Token: 0x060037B0 RID: 14256 RVA: 0x000B7BE8 File Offset: 0x000B5DE8
		public static DateTime GetYearEnd(int year)
		{
			return ISOWeek.ToDateTime(year, ISOWeek.GetWeeksInYear(year), DayOfWeek.Sunday);
		}

		// Token: 0x060037B1 RID: 14257 RVA: 0x000B7BF7 File Offset: 0x000B5DF7
		public static int GetWeeksInYear(int year)
		{
			if (year < 1 || year > 9999)
			{
				throw new ArgumentOutOfRangeException("year", SR.ArgumentOutOfRange_Year);
			}
			if (ISOWeek.<GetWeeksInYear>g__P|8_0(year) == 4 || ISOWeek.<GetWeeksInYear>g__P|8_0(year - 1) == 3)
			{
				return 53;
			}
			return 52;
		}

		// Token: 0x060037B2 RID: 14258 RVA: 0x000B7C30 File Offset: 0x000B5E30
		public static DateTime ToDateTime(int year, int week, DayOfWeek dayOfWeek)
		{
			if (year < 1 || year > 9999)
			{
				throw new ArgumentOutOfRangeException("year", SR.ArgumentOutOfRange_Year);
			}
			if (week < 1 || week > 53)
			{
				throw new ArgumentOutOfRangeException("week", SR.ArgumentOutOfRange_Week_ISO);
			}
			if (dayOfWeek < DayOfWeek.Sunday || dayOfWeek > (DayOfWeek)7)
			{
				throw new ArgumentOutOfRangeException("dayOfWeek", SR.ArgumentOutOfRange_DayOfWeek);
			}
			DateTime dateTime = new DateTime(year, 1, 4);
			int num = ISOWeek.GetWeekday(dateTime.DayOfWeek) + 3;
			int num2 = week * 7 + ISOWeek.GetWeekday(dayOfWeek) - num;
			return new DateTime(year, 1, 1).AddDays((double)(num2 - 1));
		}

		// Token: 0x060037B3 RID: 14259 RVA: 0x000B7CC4 File Offset: 0x000B5EC4
		private static int GetWeekNumber(DateTime date)
		{
			return (date.DayOfYear - ISOWeek.GetWeekday(date.DayOfWeek) + 10) / 7;
		}

		// Token: 0x060037B4 RID: 14260 RVA: 0x000B7CDF File Offset: 0x000B5EDF
		private static int GetWeekday(DayOfWeek dayOfWeek)
		{
			if (dayOfWeek != DayOfWeek.Sunday)
			{
				return (int)dayOfWeek;
			}
			return 7;
		}

		// Token: 0x060037B5 RID: 14261 RVA: 0x000B7CE7 File Offset: 0x000B5EE7
		[CompilerGenerated]
		internal static int <GetWeeksInYear>g__P|8_0(int y)
		{
			return (y + y / 4 - y / 100 + y / 400) % 7;
		}
	}
}
