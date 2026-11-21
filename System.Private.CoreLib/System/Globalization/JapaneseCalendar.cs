using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security;
using Internal.Win32;

namespace System.Globalization
{
	// Token: 0x020002FE RID: 766
	[NullableContext(1)]
	[Nullable(0)]
	public class JapaneseCalendar : Calendar
	{
		// Token: 0x17000A6A RID: 2666
		// (get) Token: 0x060037B6 RID: 14262 RVA: 0x000B7CFD File Offset: 0x000B5EFD
		public override DateTime MinSupportedDateTime
		{
			get
			{
				return JapaneseCalendar.s_calendarMinValue;
			}
		}

		// Token: 0x17000A6B RID: 2667
		// (get) Token: 0x060037B7 RID: 14263 RVA: 0x000A4708 File Offset: 0x000A2908
		public override DateTime MaxSupportedDateTime
		{
			get
			{
				return DateTime.MaxValue;
			}
		}

		// Token: 0x17000A6C RID: 2668
		// (get) Token: 0x060037B8 RID: 14264 RVA: 0x000070DD File Offset: 0x000052DD
		public override CalendarAlgorithmType AlgorithmType
		{
			get
			{
				return CalendarAlgorithmType.SolarCalendar;
			}
		}

		// Token: 0x060037B9 RID: 14265 RVA: 0x000B7D04 File Offset: 0x000B5F04
		internal static EraInfo[] GetEraInfo()
		{
			EraInfo[] result;
			if ((result = JapaneseCalendar.s_japaneseEraInfo) == null)
			{
				EraInfo[] array;
				if ((array = (GlobalizationMode.UseNls ? JapaneseCalendar.NlsGetJapaneseEras() : JapaneseCalendar.IcuGetJapaneseEras())) == null)
				{
					EraInfo[] array2 = new EraInfo[5];
					array2[0] = new EraInfo(5, 2019, 5, 1, 2018, 1, 7981, "令和", "令", "R");
					array2[1] = new EraInfo(4, 1989, 1, 8, 1988, 1, 31, "平成", "平", "H");
					array2[2] = new EraInfo(3, 1926, 12, 25, 1925, 1, 64, "昭和", "昭", "S");
					array2[3] = new EraInfo(2, 1912, 7, 30, 1911, 1, 15, "大正", "大", "T");
					array = array2;
					array2[4] = new EraInfo(1, 1868, 1, 1, 1867, 1, 45, "明治", "明", "M");
				}
				result = (JapaneseCalendar.s_japaneseEraInfo = array);
			}
			return result;
		}

		// Token: 0x060037BA RID: 14266 RVA: 0x000B7E0C File Offset: 0x000B600C
		internal static Calendar GetDefaultInstance()
		{
			Calendar result;
			if ((result = JapaneseCalendar.s_defaultInstance) == null)
			{
				result = (JapaneseCalendar.s_defaultInstance = new JapaneseCalendar());
			}
			return result;
		}

		// Token: 0x060037BB RID: 14267 RVA: 0x000B7E24 File Offset: 0x000B6024
		public JapaneseCalendar()
		{
			try
			{
				new CultureInfo("ja-JP");
			}
			catch (ArgumentException innerException)
			{
				throw new TypeInitializationException(base.GetType().ToString(), innerException);
			}
			this._helper = new GregorianCalendarHelper(this, JapaneseCalendar.GetEraInfo());
		}

		// Token: 0x17000A6D RID: 2669
		// (get) Token: 0x060037BC RID: 14268 RVA: 0x0001FC46 File Offset: 0x0001DE46
		internal override CalendarId ID
		{
			get
			{
				return CalendarId.JAPAN;
			}
		}

		// Token: 0x060037BD RID: 14269 RVA: 0x000B7E78 File Offset: 0x000B6078
		public override DateTime AddMonths(DateTime time, int months)
		{
			return this._helper.AddMonths(time, months);
		}

		// Token: 0x060037BE RID: 14270 RVA: 0x000B7E87 File Offset: 0x000B6087
		public override DateTime AddYears(DateTime time, int years)
		{
			return this._helper.AddYears(time, years);
		}

		// Token: 0x060037BF RID: 14271 RVA: 0x000B7E96 File Offset: 0x000B6096
		public override int GetDaysInMonth(int year, int month, int era)
		{
			return this._helper.GetDaysInMonth(year, month, era);
		}

		// Token: 0x060037C0 RID: 14272 RVA: 0x000B7EA6 File Offset: 0x000B60A6
		public override int GetDaysInYear(int year, int era)
		{
			return this._helper.GetDaysInYear(year, era);
		}

		// Token: 0x060037C1 RID: 14273 RVA: 0x000B7EB5 File Offset: 0x000B60B5
		public override int GetDayOfMonth(DateTime time)
		{
			return this._helper.GetDayOfMonth(time);
		}

		// Token: 0x060037C2 RID: 14274 RVA: 0x000B7EC3 File Offset: 0x000B60C3
		public override DayOfWeek GetDayOfWeek(DateTime time)
		{
			return this._helper.GetDayOfWeek(time);
		}

		// Token: 0x060037C3 RID: 14275 RVA: 0x000B7ED1 File Offset: 0x000B60D1
		public override int GetDayOfYear(DateTime time)
		{
			return this._helper.GetDayOfYear(time);
		}

		// Token: 0x060037C4 RID: 14276 RVA: 0x000B7EDF File Offset: 0x000B60DF
		public override int GetMonthsInYear(int year, int era)
		{
			return this._helper.GetMonthsInYear(year, era);
		}

		// Token: 0x060037C5 RID: 14277 RVA: 0x000B7EEE File Offset: 0x000B60EE
		public override int GetWeekOfYear(DateTime time, CalendarWeekRule rule, DayOfWeek firstDayOfWeek)
		{
			return this._helper.GetWeekOfYear(time, rule, firstDayOfWeek);
		}

		// Token: 0x060037C6 RID: 14278 RVA: 0x000B7EFE File Offset: 0x000B60FE
		public override int GetEra(DateTime time)
		{
			return this._helper.GetEra(time);
		}

		// Token: 0x060037C7 RID: 14279 RVA: 0x000B7F0C File Offset: 0x000B610C
		public override int GetMonth(DateTime time)
		{
			return this._helper.GetMonth(time);
		}

		// Token: 0x060037C8 RID: 14280 RVA: 0x000B7F1A File Offset: 0x000B611A
		public override int GetYear(DateTime time)
		{
			return this._helper.GetYear(time);
		}

		// Token: 0x060037C9 RID: 14281 RVA: 0x000B7F28 File Offset: 0x000B6128
		public override bool IsLeapDay(int year, int month, int day, int era)
		{
			return this._helper.IsLeapDay(year, month, day, era);
		}

		// Token: 0x060037CA RID: 14282 RVA: 0x000B7F3A File Offset: 0x000B613A
		public override bool IsLeapYear(int year, int era)
		{
			return this._helper.IsLeapYear(year, era);
		}

		// Token: 0x060037CB RID: 14283 RVA: 0x000B7F49 File Offset: 0x000B6149
		public override int GetLeapMonth(int year, int era)
		{
			return this._helper.GetLeapMonth(year, era);
		}

		// Token: 0x060037CC RID: 14284 RVA: 0x000B7F58 File Offset: 0x000B6158
		public override bool IsLeapMonth(int year, int month, int era)
		{
			return this._helper.IsLeapMonth(year, month, era);
		}

		// Token: 0x060037CD RID: 14285 RVA: 0x000B7F68 File Offset: 0x000B6168
		public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era)
		{
			return this._helper.ToDateTime(year, month, day, hour, minute, second, millisecond, era);
		}

		// Token: 0x060037CE RID: 14286 RVA: 0x000B7F8D File Offset: 0x000B618D
		public override int ToFourDigitYear(int year)
		{
			ArgumentOutOfRangeException.ThrowIfNegativeOrZero<int>(year, "year");
			ArgumentOutOfRangeException.ThrowIfGreaterThan<int>(year, this._helper.MaxYear, "year");
			return year;
		}

		// Token: 0x17000A6E RID: 2670
		// (get) Token: 0x060037CF RID: 14287 RVA: 0x000B7FB1 File Offset: 0x000B61B1
		public override int[] Eras
		{
			get
			{
				return this._helper.Eras;
			}
		}

		// Token: 0x060037D0 RID: 14288 RVA: 0x000B7FC0 File Offset: 0x000B61C0
		internal static string[] EraNames()
		{
			EraInfo[] eraInfo = JapaneseCalendar.GetEraInfo();
			string[] array = new string[eraInfo.Length];
			for (int i = 0; i < eraInfo.Length; i++)
			{
				array[i] = eraInfo[eraInfo.Length - i - 1].eraName;
			}
			return array;
		}

		// Token: 0x060037D1 RID: 14289 RVA: 0x000B7FFC File Offset: 0x000B61FC
		internal static string[] AbbrevEraNames()
		{
			EraInfo[] eraInfo = JapaneseCalendar.GetEraInfo();
			string[] array = new string[eraInfo.Length];
			for (int i = 0; i < eraInfo.Length; i++)
			{
				array[i] = eraInfo[eraInfo.Length - i - 1].abbrevEraName;
			}
			return array;
		}

		// Token: 0x060037D2 RID: 14290 RVA: 0x000B8038 File Offset: 0x000B6238
		internal static string[] EnglishEraNames()
		{
			EraInfo[] eraInfo = JapaneseCalendar.GetEraInfo();
			string[] array = new string[eraInfo.Length];
			for (int i = 0; i < eraInfo.Length; i++)
			{
				array[i] = eraInfo[eraInfo.Length - i - 1].englishEraName;
			}
			return array;
		}

		// Token: 0x060037D3 RID: 14291 RVA: 0x000B8074 File Offset: 0x000B6274
		internal override bool IsValidYear(int year, int era)
		{
			return this._helper.IsValidYear(year, era);
		}

		// Token: 0x17000A6F RID: 2671
		// (get) Token: 0x060037D4 RID: 14292 RVA: 0x000B8083 File Offset: 0x000B6283
		// (set) Token: 0x060037D5 RID: 14293 RVA: 0x000B80A8 File Offset: 0x000B62A8
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

		// Token: 0x060037D6 RID: 14294 RVA: 0x000B8108 File Offset: 0x000B6308
		private static EraInfo[] IcuGetJapaneseEras()
		{
			if (GlobalizationMode.Invariant)
			{
				return null;
			}
			string[] array;
			if (!CalendarData.EnumCalendarInfo("ja-JP", CalendarId.JAPAN, CalendarDataType.EraNames, out array))
			{
				return null;
			}
			int latestJapaneseEra = Interop.Globalization.GetLatestJapaneseEra();
			List<EraInfo> list = new List<EraInfo>();
			int num = 9999;
			for (int i = latestJapaneseEra; i >= 0; i--)
			{
				DateTime t;
				if (!JapaneseCalendar.GetJapaneseEraStartDate(i, out t))
				{
					return null;
				}
				if (t < JapaneseCalendar.s_calendarMinValue)
				{
					break;
				}
				list.Add(new EraInfo(i, t.Year, t.Month, t.Day, t.Year - 1, 1, num - t.Year + 1, array[i], JapaneseCalendar.GetAbbreviatedEraName(array, i), ""));
				num = t.Year;
			}
			string[] array2;
			if (!CalendarData.EnumCalendarInfo("ja", CalendarId.JAPAN, CalendarDataType.AbbrevEraNames, out array2))
			{
				array2 = JapaneseCalendar.s_abbreviatedEnglishEraNames;
			}
			string[] array3 = array2;
			string text = array3[array3.Length - 1];
			bool flag = text != null && (text.Length == 0 || text[0] > '\u007f');
			if (flag)
			{
				array2 = JapaneseCalendar.s_abbreviatedEnglishEraNames;
			}
			int num2 = (array2 == JapaneseCalendar.s_abbreviatedEnglishEraNames) ? (list.Count - 1) : (array2.Length - 1);
			for (int j = 0; j < list.Count; j++)
			{
				list[j].era = list.Count - j;
				if (num2 < array2.Length)
				{
					list[j].englishEraName = array2[num2];
				}
				num2--;
			}
			return list.ToArray();
		}

		// Token: 0x060037D7 RID: 14295 RVA: 0x000B826F File Offset: 0x000B646F
		private static string GetAbbreviatedEraName(string[] eraNames, int eraIndex)
		{
			return eraNames[eraIndex].Substring(0, 1);
		}

		// Token: 0x060037D8 RID: 14296 RVA: 0x000B827C File Offset: 0x000B647C
		private static bool GetJapaneseEraStartDate(int era, out DateTime dateTime)
		{
			dateTime = default(DateTime);
			int year;
			int month;
			int day;
			bool japaneseEraStartDate = Interop.Globalization.GetJapaneseEraStartDate(era, out year, out month, out day);
			if (japaneseEraStartDate)
			{
				dateTime = new DateTime(year, month, day);
			}
			return japaneseEraStartDate;
		}

		// Token: 0x060037D9 RID: 14297 RVA: 0x000B82B0 File Offset: 0x000B64B0
		private static EraInfo[] NlsGetJapaneseEras()
		{
			int num = 0;
			EraInfo[] array = null;
			try
			{
				using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("System\\CurrentControlSet\\Control\\Nls\\Calendars\\Japanese\\Eras"))
				{
					if (registryKey == null)
					{
						return null;
					}
					string[] valueNames = registryKey.GetValueNames();
					if (valueNames != null && valueNames.Length != 0)
					{
						array = new EraInfo[valueNames.Length];
						for (int i = 0; i < valueNames.Length; i++)
						{
							string value = valueNames[i];
							object value2 = registryKey.GetValue(valueNames[i]);
							EraInfo eraFromValue = JapaneseCalendar.GetEraFromValue(value, (value2 != null) ? value2.ToString() : null);
							if (eraFromValue != null)
							{
								array[num] = eraFromValue;
								num++;
							}
						}
					}
				}
			}
			catch (SecurityException)
			{
				return null;
			}
			catch (IOException)
			{
				return null;
			}
			catch (UnauthorizedAccessException)
			{
				return null;
			}
			if (num < 4)
			{
				return null;
			}
			Array.Resize<EraInfo>(ref array, num);
			EraInfo[] array2 = array;
			Comparison<EraInfo> comparison;
			if ((comparison = JapaneseCalendar.<>O.<0>__CompareEraRanges) == null)
			{
				comparison = (JapaneseCalendar.<>O.<0>__CompareEraRanges = new Comparison<EraInfo>(JapaneseCalendar.CompareEraRanges));
			}
			Array.Sort<EraInfo>(array2, comparison);
			for (int j = 0; j < array.Length; j++)
			{
				array[j].era = array.Length - j;
				if (j == 0)
				{
					array[0].maxEraYear = 9999 - array[0].yearOffset;
				}
				else
				{
					array[j].maxEraYear = array[j - 1].yearOffset + 1 - array[j].yearOffset;
				}
			}
			return array;
		}

		// Token: 0x060037DA RID: 14298 RVA: 0x000B8420 File Offset: 0x000B6620
		private static int CompareEraRanges(EraInfo a, EraInfo b)
		{
			return b.ticks.CompareTo(a.ticks);
		}

		// Token: 0x060037DB RID: 14299 RVA: 0x000B8434 File Offset: 0x000B6634
		private unsafe static EraInfo GetEraFromValue(string value, string data)
		{
			if (value == null || data == null)
			{
				return null;
			}
			if (value.Length != 10)
			{
				return null;
			}
			ReadOnlySpan<char> readOnlySpan = value.AsSpan();
			int num;
			int startMonth;
			int startDay;
			if (!int.TryParse(readOnlySpan.Slice(0, 4), NumberStyles.None, NumberFormatInfo.InvariantInfo, out num) || !int.TryParse(readOnlySpan.Slice(5, 2), NumberStyles.None, NumberFormatInfo.InvariantInfo, out startMonth) || !int.TryParse(readOnlySpan.Slice(8, 2), NumberStyles.None, NumberFormatInfo.InvariantInfo, out startDay))
			{
				return null;
			}
			Span<Range> destination = new Span<Range>(stackalloc byte[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(Range))], 5);
			ReadOnlySpan<char> source = data;
			if (source.Split(destination, '_', StringSplitOptions.None) == 4)
			{
				Range range = *destination[0];
				int length = source.Length;
				int offset = range.Start.GetOffset(length);
				int length2 = range.End.GetOffset(length) - offset;
				ReadOnlySpan<char> readOnlySpan2 = source.Slice(offset, length2);
				range = *destination[1];
				length2 = source.Length;
				offset = range.Start.GetOffset(length2);
				length = range.End.GetOffset(length2) - offset;
				ReadOnlySpan<char> readOnlySpan3 = source.Slice(offset, length);
				range = *destination[2];
				length = source.Length;
				offset = range.Start.GetOffset(length);
				length2 = range.End.GetOffset(length) - offset;
				ReadOnlySpan<char> readOnlySpan4 = source.Slice(offset, length2);
				range = *destination[3];
				length2 = source.Length;
				offset = range.Start.GetOffset(length2);
				length = range.End.GetOffset(length2) - offset;
				ReadOnlySpan<char> readOnlySpan5 = source.Slice(offset, length);
				if (!readOnlySpan2.IsEmpty && !readOnlySpan3.IsEmpty && !readOnlySpan4.IsEmpty && !readOnlySpan5.IsEmpty)
				{
					return new EraInfo(0, num, startMonth, startDay, num - 1, 1, 0, readOnlySpan2.ToString(), readOnlySpan3.ToString(), readOnlySpan5.ToString());
				}
			}
			return null;
		}

		// Token: 0x04000AE6 RID: 2790
		private static readonly DateTime s_calendarMinValue = new DateTime(1868, 9, 8);

		// Token: 0x04000AE7 RID: 2791
		private static EraInfo[] s_japaneseEraInfo;

		// Token: 0x04000AE8 RID: 2792
		internal static Calendar s_defaultInstance;

		// Token: 0x04000AE9 RID: 2793
		internal GregorianCalendarHelper _helper;

		// Token: 0x04000AEA RID: 2794
		private static readonly string[] s_abbreviatedEnglishEraNames = new string[]
		{
			"M",
			"T",
			"S",
			"H",
			"R"
		};

		// Token: 0x020002FF RID: 767
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04000AEB RID: 2795
			public static Comparison<EraInfo> <0>__CompareEraRanges;
		}
	}
}
