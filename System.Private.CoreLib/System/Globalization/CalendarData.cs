using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace System.Globalization
{
	// Token: 0x020002C3 RID: 707
	internal sealed class CalendarData
	{
		// Token: 0x060033E2 RID: 13282 RVA: 0x000A4CF3 File Offset: 0x000A2EF3
		private CalendarData()
		{
		}

		// Token: 0x060033E3 RID: 13283 RVA: 0x000A4D08 File Offset: 0x000A2F08
		private static CalendarData CreateInvariant()
		{
			CalendarData calendarData = new CalendarData();
			calendarData.sNativeName = "Gregorian Calendar";
			calendarData.iTwoDigitYearMax = 2049;
			calendarData.iCurrentEra = 1;
			calendarData.saShortDates = new string[]
			{
				"MM/dd/yyyy",
				"yyyy-MM-dd"
			};
			calendarData.saLongDates = new string[]
			{
				"dddd, dd MMMM yyyy"
			};
			calendarData.saYearMonths = new string[]
			{
				"yyyy MMMM"
			};
			calendarData.sMonthDay = "MMMM dd";
			calendarData.saEraNames = new string[]
			{
				"A.D."
			};
			calendarData.saAbbrevEraNames = new string[]
			{
				"AD"
			};
			calendarData.saAbbrevEnglishEraNames = new string[]
			{
				"AD"
			};
			calendarData.saDayNames = new string[]
			{
				"Sunday",
				"Monday",
				"Tuesday",
				"Wednesday",
				"Thursday",
				"Friday",
				"Saturday"
			};
			calendarData.saAbbrevDayNames = new string[]
			{
				"Sun",
				"Mon",
				"Tue",
				"Wed",
				"Thu",
				"Fri",
				"Sat"
			};
			calendarData.saSuperShortDayNames = new string[]
			{
				"Su",
				"Mo",
				"Tu",
				"We",
				"Th",
				"Fr",
				"Sa"
			};
			calendarData.saMonthNames = new string[]
			{
				"January",
				"February",
				"March",
				"April",
				"May",
				"June",
				"July",
				"August",
				"September",
				"October",
				"November",
				"December",
				string.Empty
			};
			calendarData.saAbbrevMonthNames = new string[]
			{
				"Jan",
				"Feb",
				"Mar",
				"Apr",
				"May",
				"Jun",
				"Jul",
				"Aug",
				"Sep",
				"Oct",
				"Nov",
				"Dec",
				string.Empty
			};
			calendarData.saMonthGenitiveNames = calendarData.saMonthNames;
			calendarData.saAbbrevMonthGenitiveNames = calendarData.saAbbrevMonthNames;
			calendarData.saLeapYearMonthNames = calendarData.saMonthNames;
			calendarData.bUseUserOverrides = false;
			return calendarData;
		}

		// Token: 0x060033E4 RID: 13284 RVA: 0x000A4FB0 File Offset: 0x000A31B0
		internal CalendarData(string localeName, CalendarId calendarId, bool bUseUserOverrides)
		{
			this.bUseUserOverrides = bUseUserOverrides;
			if (!this.LoadCalendarDataFromSystemCore(localeName, calendarId))
			{
				if (this.sNativeName == null)
				{
					this.sNativeName = string.Empty;
				}
				if (this.saShortDates == null)
				{
					this.saShortDates = CalendarData.Invariant.saShortDates;
				}
				if (this.saYearMonths == null)
				{
					this.saYearMonths = CalendarData.Invariant.saYearMonths;
				}
				if (this.saLongDates == null)
				{
					this.saLongDates = CalendarData.Invariant.saLongDates;
				}
				if (this.sMonthDay == null)
				{
					this.sMonthDay = CalendarData.Invariant.sMonthDay;
				}
				if (this.saEraNames == null)
				{
					this.saEraNames = CalendarData.Invariant.saEraNames;
				}
				if (this.saAbbrevEraNames == null)
				{
					this.saAbbrevEraNames = CalendarData.Invariant.saAbbrevEraNames;
				}
				if (this.saAbbrevEnglishEraNames == null)
				{
					this.saAbbrevEnglishEraNames = CalendarData.Invariant.saAbbrevEnglishEraNames;
				}
				if (this.saDayNames == null)
				{
					this.saDayNames = CalendarData.Invariant.saDayNames;
				}
				if (this.saAbbrevDayNames == null)
				{
					this.saAbbrevDayNames = CalendarData.Invariant.saAbbrevDayNames;
				}
				if (this.saSuperShortDayNames == null)
				{
					this.saSuperShortDayNames = CalendarData.Invariant.saSuperShortDayNames;
				}
				if (this.saMonthNames == null)
				{
					this.saMonthNames = CalendarData.Invariant.saMonthNames;
				}
				if (this.saAbbrevMonthNames == null)
				{
					this.saAbbrevMonthNames = CalendarData.Invariant.saAbbrevMonthNames;
				}
			}
			if (calendarId == CalendarId.TAIWAN)
			{
				if (CalendarData.SystemSupportsTaiwaneseCalendar())
				{
					this.sNativeName = "中華民國曆";
				}
				else
				{
					this.sNativeName = string.Empty;
				}
			}
			if (this.saMonthGenitiveNames == null || this.saMonthGenitiveNames.Length == 0 || string.IsNullOrEmpty(this.saMonthGenitiveNames[0]))
			{
				this.saMonthGenitiveNames = this.saMonthNames;
			}
			if (this.saAbbrevMonthGenitiveNames == null || this.saAbbrevMonthGenitiveNames.Length == 0 || string.IsNullOrEmpty(this.saAbbrevMonthGenitiveNames[0]))
			{
				this.saAbbrevMonthGenitiveNames = this.saAbbrevMonthNames;
			}
			if (this.saLeapYearMonthNames == null || this.saLeapYearMonthNames.Length == 0 || string.IsNullOrEmpty(this.saLeapYearMonthNames[0]))
			{
				this.saLeapYearMonthNames = this.saMonthNames;
			}
			this.InitializeEraNames(localeName, calendarId);
			this.InitializeAbbreviatedEraNames(localeName, calendarId);
			if (calendarId == CalendarId.JAPAN)
			{
				this.saAbbrevEnglishEraNames = JapaneseCalendar.EnglishEraNames();
			}
			else
			{
				this.saAbbrevEnglishEraNames = new string[]
				{
					""
				};
			}
			this.iCurrentEra = this.saEraNames.Length;
		}

		// Token: 0x060033E5 RID: 13285 RVA: 0x000A5200 File Offset: 0x000A3400
		private void InitializeEraNames(string localeName, CalendarId calendarId)
		{
			switch (calendarId)
			{
			case CalendarId.GREGORIAN:
				if (this.<InitializeEraNames>g__AreEraNamesEmpty|24_0())
				{
					this.saEraNames = new string[]
					{
						"A.D."
					};
					return;
				}
				return;
			case CalendarId.GREGORIAN_US:
			case CalendarId.JULIAN:
				this.saEraNames = new string[]
				{
					"A.D."
				};
				return;
			case CalendarId.JAPAN:
			case CalendarId.JAPANESELUNISOLAR:
				this.saEraNames = JapaneseCalendar.EraNames();
				return;
			case CalendarId.TAIWAN:
				if (CalendarData.SystemSupportsTaiwaneseCalendar())
				{
					this.saEraNames = new string[]
					{
						"中華民國"
					};
					return;
				}
				this.saEraNames = new string[]
				{
					string.Empty
				};
				return;
			case CalendarId.KOREA:
				this.saEraNames = new string[]
				{
					"단기"
				};
				return;
			case CalendarId.HIJRI:
			case CalendarId.UMALQURA:
				if (localeName == "dv-MV")
				{
					this.saEraNames = new string[]
					{
						"ހިޖްރީ"
					};
					return;
				}
				this.saEraNames = new string[]
				{
					"بعد الهجرة"
				};
				return;
			case CalendarId.THAI:
				this.saEraNames = new string[]
				{
					"พ.ศ."
				};
				return;
			case CalendarId.HEBREW:
				this.saEraNames = new string[]
				{
					"C.E."
				};
				return;
			case CalendarId.GREGORIAN_ME_FRENCH:
				this.saEraNames = new string[]
				{
					"ap. J.-C."
				};
				return;
			case CalendarId.GREGORIAN_ARABIC:
			case CalendarId.GREGORIAN_XLIT_ENGLISH:
			case CalendarId.GREGORIAN_XLIT_FRENCH:
				this.saEraNames = new string[]
				{
					"م"
				};
				return;
			case CalendarId.PERSIAN:
				if (this.<InitializeEraNames>g__AreEraNamesEmpty|24_0())
				{
					this.saEraNames = new string[]
					{
						"ه.ش"
					};
					return;
				}
				return;
			}
			this.saEraNames = CalendarData.Invariant.saEraNames;
		}

		// Token: 0x060033E6 RID: 13286 RVA: 0x000A53B8 File Offset: 0x000A35B8
		private void InitializeAbbreviatedEraNames(string localeName, CalendarId calendarId)
		{
			if (calendarId <= CalendarId.JULIAN)
			{
				switch (calendarId)
				{
				case CalendarId.GREGORIAN:
					if (this.saAbbrevEraNames == null || this.saAbbrevEraNames.Length == 0 || string.IsNullOrEmpty(this.saAbbrevEraNames[0]))
					{
						this.saAbbrevEraNames = new string[]
						{
							"AD"
						};
						return;
					}
					return;
				case CalendarId.GREGORIAN_US:
					break;
				case CalendarId.JAPAN:
					goto IL_93;
				case CalendarId.TAIWAN:
					this.saAbbrevEraNames = new string[1];
					if (this.saEraNames[0].Length == 4)
					{
						this.saAbbrevEraNames[0] = this.saEraNames[0].Substring(2, 2);
						return;
					}
					this.saAbbrevEraNames[0] = this.saEraNames[0];
					return;
				case CalendarId.KOREA:
					goto IL_148;
				case CalendarId.HIJRI:
					goto IL_9F;
				default:
					if (calendarId != CalendarId.JULIAN)
					{
						goto IL_148;
					}
					break;
				}
				this.saAbbrevEraNames = new string[]
				{
					"AD"
				};
				return;
			}
			if (calendarId != CalendarId.JAPANESELUNISOLAR)
			{
				if (calendarId != CalendarId.PERSIAN)
				{
					if (calendarId != CalendarId.UMALQURA)
					{
						goto IL_148;
					}
					goto IL_9F;
				}
				else
				{
					if (this.saAbbrevEraNames == null || this.saAbbrevEraNames.Length == 0 || string.IsNullOrEmpty(this.saAbbrevEraNames[0]))
					{
						this.saAbbrevEraNames = this.saEraNames;
						return;
					}
					return;
				}
			}
			IL_93:
			this.saAbbrevEraNames = JapaneseCalendar.AbbrevEraNames();
			return;
			IL_9F:
			if (localeName == "dv-MV")
			{
				this.saAbbrevEraNames = new string[]
				{
					"ހ."
				};
				return;
			}
			this.saAbbrevEraNames = new string[]
			{
				"هـ"
			};
			return;
			IL_148:
			this.saAbbrevEraNames = this.saEraNames;
		}

		// Token: 0x060033E7 RID: 13287 RVA: 0x000A551C File Offset: 0x000A371C
		internal static int GetCalendarCurrentEra(Calendar calendar)
		{
			if (GlobalizationMode.Invariant)
			{
				return CalendarData.Invariant.iCurrentEra;
			}
			CalendarId baseCalendarID = calendar.BaseCalendarID;
			return CultureInfo.GetCultureInfo(CalendarData.CalendarIdToCultureName(baseCalendarID))._cultureData.GetCalendar(baseCalendarID).iCurrentEra;
		}

		// Token: 0x060033E8 RID: 13288 RVA: 0x000A5560 File Offset: 0x000A3760
		private static string CalendarIdToCultureName(CalendarId calendarId)
		{
			switch (calendarId)
			{
			case CalendarId.GREGORIAN_US:
				return "fa-IR";
			case CalendarId.JAPAN:
				return "ja-JP";
			case CalendarId.TAIWAN:
				return "zh-TW";
			case CalendarId.KOREA:
				return "ko-KR";
			case CalendarId.HIJRI:
			case CalendarId.GREGORIAN_ARABIC:
			case CalendarId.UMALQURA:
				return "ar-SA";
			case CalendarId.THAI:
				return "th-TH";
			case CalendarId.HEBREW:
				return "he-IL";
			case CalendarId.GREGORIAN_ME_FRENCH:
				return "ar-DZ";
			case CalendarId.GREGORIAN_XLIT_ENGLISH:
			case CalendarId.GREGORIAN_XLIT_FRENCH:
				return "ar-IQ";
			}
			return "en-US";
		}

		// Token: 0x060033E9 RID: 13289 RVA: 0x000A560A File Offset: 0x000A380A
		private static bool SystemSupportsTaiwaneseCalendar()
		{
			return !GlobalizationMode.UseNls || CalendarData.NlsSystemSupportsTaiwaneseCalendar();
		}

		// Token: 0x060033EA RID: 13290 RVA: 0x000A561C File Offset: 0x000A381C
		private bool IcuLoadCalendarDataFromSystem(string localeName, CalendarId calendarId)
		{
			bool flag = true & CalendarData.GetCalendarInfo(localeName, calendarId, CalendarDataType.NativeName, out this.sNativeName) & CalendarData.GetCalendarInfo(localeName, calendarId, CalendarDataType.MonthDay, out this.sMonthDay);
			if (this.sMonthDay != null)
			{
				this.sMonthDay = CalendarData.NormalizeDatePattern(this.sMonthDay);
			}
			bool flag2 = flag & CalendarData.EnumDatePatterns(localeName, calendarId, CalendarDataType.ShortDates, out this.saShortDates) & CalendarData.EnumDatePatterns(localeName, calendarId, CalendarDataType.LongDates, out this.saLongDates) & CalendarData.EnumDatePatterns(localeName, calendarId, CalendarDataType.YearMonths, out this.saYearMonths) & CalendarData.EnumCalendarInfo(localeName, calendarId, CalendarDataType.DayNames, out this.saDayNames) & CalendarData.EnumCalendarInfo(localeName, calendarId, CalendarDataType.AbbrevDayNames, out this.saAbbrevDayNames) & CalendarData.EnumCalendarInfo(localeName, calendarId, CalendarDataType.SuperShortDayNames, out this.saSuperShortDayNames);
			string text = null;
			bool flag3 = flag2 & CalendarData.EnumMonthNames(localeName, calendarId, CalendarDataType.MonthNames, out this.saMonthNames, ref text);
			if (text != null)
			{
				this.saLeapYearMonthNames = (string[])this.saMonthNames.Clone();
				this.saLeapYearMonthNames[6] = text;
				this.saMonthNames[5] = this.saMonthNames[6];
				this.saMonthNames[6] = text;
			}
			return flag3 & CalendarData.EnumMonthNames(localeName, calendarId, CalendarDataType.AbbrevMonthNames, out this.saAbbrevMonthNames, ref text) & CalendarData.EnumMonthNames(localeName, calendarId, CalendarDataType.MonthGenitiveNames, out this.saMonthGenitiveNames, ref text) & CalendarData.EnumMonthNames(localeName, calendarId, CalendarDataType.AbbrevMonthGenitiveNames, out this.saAbbrevMonthGenitiveNames, ref text) & CalendarData.EnumEraNames(localeName, calendarId, CalendarDataType.EraNames, out this.saEraNames) & CalendarData.EnumEraNames(localeName, calendarId, CalendarDataType.AbbrevEraNames, out this.saAbbrevEraNames);
		}

		// Token: 0x060033EB RID: 13291 RVA: 0x000A5760 File Offset: 0x000A3960
		internal static int IcuGetCalendars(string localeName, CalendarId[] calendars)
		{
			int num = Interop.Globalization.GetCalendars(localeName, calendars, calendars.Length);
			if (num == 0 && calendars.Length != 0)
			{
				calendars[0] = CalendarId.GREGORIAN;
				num = 1;
			}
			return num;
		}

		// Token: 0x060033EC RID: 13292 RVA: 0x000A5786 File Offset: 0x000A3986
		private unsafe static bool GetCalendarInfo(string localeName, CalendarId calendarId, CalendarDataType dataType, out string calendarString)
		{
			return Interop.CallStringMethod<string, CalendarId, CalendarDataType>(delegate(Span<char> buffer, string locale, CalendarId id, CalendarDataType type)
			{
				fixed (char* pinnableReference = buffer.GetPinnableReference())
				{
					char* result = pinnableReference;
					return Interop.Globalization.GetCalendarInfo(locale, id, type, result, buffer.Length);
				}
			}, localeName, calendarId, dataType, out calendarString);
		}

		// Token: 0x060033ED RID: 13293 RVA: 0x000A57B0 File Offset: 0x000A39B0
		private unsafe static bool EnumDatePatterns(string localeName, CalendarId calendarId, CalendarDataType dataType, out string[] datePatterns)
		{
			datePatterns = null;
			CalendarData.IcuEnumCalendarsData icuEnumCalendarsData = default(CalendarData.IcuEnumCalendarsData);
			icuEnumCalendarsData.Results = new List<string>();
			icuEnumCalendarsData.DisallowDuplicates = true;
			bool flag = CalendarData.EnumCalendarInfo(localeName, calendarId, dataType, &icuEnumCalendarsData);
			if (flag)
			{
				List<string> results = icuEnumCalendarsData.Results;
				for (int i = 0; i < results.Count; i++)
				{
					results[i] = CalendarData.NormalizeDatePattern(results[i]);
				}
				if (dataType == CalendarDataType.ShortDates)
				{
					CalendarData.FixDefaultShortDatePattern(results);
				}
				datePatterns = results.ToArray();
			}
			return flag;
		}

		// Token: 0x060033EE RID: 13294 RVA: 0x000A582C File Offset: 0x000A3A2C
		private unsafe static void FixDefaultShortDatePattern(List<string> shortDatePatterns)
		{
			if (shortDatePatterns.Count == 0)
			{
				return;
			}
			string text = shortDatePatterns[0];
			if (text.Length > 100)
			{
				return;
			}
			int num = text.Length + 2;
			Span<char> span = new Span<char>(stackalloc byte[checked(unchecked((UIntPtr)num) * 2)], num);
			int i;
			for (i = 0; i < text.Length; i++)
			{
				if (text[i] == '\'')
				{
					do
					{
						*span[i] = text[i];
						i++;
					}
					while (i < text.Length && text[i] != '\'');
					if (i >= text.Length)
					{
						return;
					}
				}
				else if (text[i] == 'y')
				{
					*span[i] = 'y';
					break;
				}
				*span[i] = text[i];
			}
			if (i >= text.Length - 1 || text[i + 1] != 'y')
			{
				return;
			}
			if (i + 2 < text.Length && text[i + 2] == 'y')
			{
				return;
			}
			*span[i + 1] = 'y';
			*span[i + 2] = 'y';
			*span[i + 3] = 'y';
			for (i += 2; i < text.Length; i++)
			{
				*span[i + 2] = text[i];
			}
			shortDatePatterns[0] = span.ToString();
			for (int j = 1; j < shortDatePatterns.Count; j++)
			{
				if (shortDatePatterns[j] == shortDatePatterns[0])
				{
					shortDatePatterns[j] = text;
					return;
				}
			}
			shortDatePatterns.Add(text);
		}

		// Token: 0x060033EF RID: 13295 RVA: 0x000A59B0 File Offset: 0x000A3BB0
		private unsafe static string NormalizeDatePattern(string input)
		{
			ValueStringBuilder valueStringBuilder;
			if (input.Length < 128)
			{
				Span<char> initialBuffer = new Span<char>(stackalloc byte[(UIntPtr)256], 128);
				valueStringBuilder = new ValueStringBuilder(initialBuffer);
			}
			else
			{
				valueStringBuilder = new ValueStringBuilder(input.Length);
			}
			ValueStringBuilder valueStringBuilder2 = valueStringBuilder;
			int i = 0;
			while (i < input.Length)
			{
				char c = input[i];
				int num;
				if (c <= 'L')
				{
					if (c <= 'E')
					{
						if (c == '\'')
						{
							valueStringBuilder2.Append(input[i++]);
							while (i < input.Length)
							{
								char c2 = input[i++];
								valueStringBuilder2.Append(c2);
								if (c2 == '\'')
								{
									break;
								}
							}
							continue;
						}
						if (c != 'E')
						{
							goto IL_14F;
						}
					}
					else
					{
						if (c == 'G')
						{
							CalendarData.CountOccurrences(input, 'G', ref i);
							valueStringBuilder2.Append('g');
							continue;
						}
						if (c != 'L')
						{
							goto IL_14F;
						}
						goto IL_F2;
					}
				}
				else if (c <= 'c')
				{
					if (c == 'M')
					{
						goto IL_F2;
					}
					if (c != 'c')
					{
						goto IL_14F;
					}
				}
				else if (c != 'e')
				{
					if (c != 'y')
					{
						goto IL_14F;
					}
					num = CalendarData.CountOccurrences(input, 'y', ref i);
					if (num == 1)
					{
						num = 4;
					}
					valueStringBuilder2.Append('y', num);
					continue;
				}
				CalendarData.NormalizeDayOfWeek(input, ref valueStringBuilder2, ref i);
				continue;
				IL_F2:
				num = CalendarData.CountOccurrences(input, input[i], ref i);
				if (num > 4)
				{
					num = 3;
				}
				valueStringBuilder2.Append('M', num);
				continue;
				IL_14F:
				valueStringBuilder2.Append(input[i++]);
			}
			return valueStringBuilder2.ToString();
		}

		// Token: 0x060033F0 RID: 13296 RVA: 0x000A5B38 File Offset: 0x000A3D38
		private static void NormalizeDayOfWeek(string input, ref ValueStringBuilder destination, ref int index)
		{
			char value = input[index];
			int num = CalendarData.CountOccurrences(input, value, ref index);
			num = Math.Max(num, 3);
			if (num > 4)
			{
				num = 3;
			}
			destination.Append('d', num);
		}

		// Token: 0x060033F1 RID: 13297 RVA: 0x000A5B70 File Offset: 0x000A3D70
		private static int CountOccurrences(string input, char value, ref int index)
		{
			int num = index;
			while (index < input.Length && input[index] == value)
			{
				index++;
			}
			return index - num;
		}

		// Token: 0x060033F2 RID: 13298 RVA: 0x000A5BA4 File Offset: 0x000A3DA4
		private unsafe static bool EnumMonthNames(string localeName, CalendarId calendarId, CalendarDataType dataType, out string[] monthNames, ref string leapHebrewMonthName)
		{
			monthNames = null;
			CalendarData.IcuEnumCalendarsData icuEnumCalendarsData = default(CalendarData.IcuEnumCalendarsData);
			icuEnumCalendarsData.Results = new List<string>();
			bool flag = CalendarData.EnumCalendarInfo(localeName, calendarId, dataType, &icuEnumCalendarsData);
			if (flag)
			{
				if (icuEnumCalendarsData.Results.Count == 12)
				{
					icuEnumCalendarsData.Results.Add(string.Empty);
				}
				if (icuEnumCalendarsData.Results.Count > 13)
				{
					if (calendarId == CalendarId.HEBREW)
					{
						leapHebrewMonthName = icuEnumCalendarsData.Results[13];
					}
					icuEnumCalendarsData.Results.RemoveRange(13, icuEnumCalendarsData.Results.Count - 13);
				}
				monthNames = icuEnumCalendarsData.Results.ToArray();
			}
			return flag;
		}

		// Token: 0x060033F3 RID: 13299 RVA: 0x000A5C40 File Offset: 0x000A3E40
		private static bool EnumEraNames(string localeName, CalendarId calendarId, CalendarDataType dataType, out string[] eraNames)
		{
			bool result = CalendarData.EnumCalendarInfo(localeName, calendarId, dataType, out eraNames);
			if (calendarId != CalendarId.JAPAN && calendarId != CalendarId.JAPANESELUNISOLAR)
			{
				string[] array = eraNames;
				if (array != null && array.Length != 0)
				{
					string[] array2 = new string[1];
					int num = 0;
					string[] array3 = eraNames;
					array2[num] = array3[array3.Length - 1];
					eraNames = array2;
				}
			}
			return result;
		}

		// Token: 0x060033F4 RID: 13300 RVA: 0x000A5C84 File Offset: 0x000A3E84
		internal unsafe static bool EnumCalendarInfo(string localeName, CalendarId calendarId, CalendarDataType dataType, out string[] calendarData)
		{
			calendarData = null;
			CalendarData.IcuEnumCalendarsData icuEnumCalendarsData = default(CalendarData.IcuEnumCalendarsData);
			icuEnumCalendarsData.Results = new List<string>();
			bool flag = CalendarData.EnumCalendarInfo(localeName, calendarId, dataType, &icuEnumCalendarsData);
			if (flag)
			{
				calendarData = icuEnumCalendarsData.Results.ToArray();
			}
			return flag;
		}

		// Token: 0x060033F5 RID: 13301 RVA: 0x000A5CC3 File Offset: 0x000A3EC3
		private unsafe static bool EnumCalendarInfo(string localeName, CalendarId calendarId, CalendarDataType dataType, CalendarData.IcuEnumCalendarsData* callbackContext)
		{
			return Interop.Globalization.EnumCalendarInfo(ldftn(EnumCalendarInfoCallback), localeName != null, calendarId, dataType, callbackContext);
		}

		// Token: 0x060033F6 RID: 13302 RVA: 0x000A5CD4 File Offset: 0x000A3ED4
		[UnmanagedCallersOnly]
		private unsafe static void EnumCalendarInfoCallback(char* calendarStringPtr, IntPtr context)
		{
			try
			{
				ReadOnlySpan<char> span = MemoryMarshal.CreateReadOnlySpanFromNullTerminated(calendarStringPtr);
				if (context.DisallowDuplicates)
				{
					foreach (string value in context.Results)
					{
						if (span.SequenceEqual(value))
						{
							return;
						}
					}
				}
				context.Results.Add(span.ToString());
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060033F7 RID: 13303 RVA: 0x000A5D6C File Offset: 0x000A3F6C
		private static bool NlsSystemSupportsTaiwaneseCalendar()
		{
			string text;
			return CalendarData.CallGetCalendarInfoEx("zh-TW", CalendarId.TAIWAN, 2U, out text);
		}

		// Token: 0x060033F8 RID: 13304 RVA: 0x000A5D87 File Offset: 0x000A3F87
		private static bool CallGetCalendarInfoEx(string localeName, CalendarId calendar, uint calType, out int data)
		{
			return Interop.Kernel32.GetCalendarInfoEx(localeName, (uint)calendar, IntPtr.Zero, calType | 536870912U, IntPtr.Zero, 0, out data) != 0;
		}

		// Token: 0x060033F9 RID: 13305 RVA: 0x000A5DA8 File Offset: 0x000A3FA8
		private unsafe static bool CallGetCalendarInfoEx(string localeName, CalendarId calendar, uint calType, out string data)
		{
			char* ptr = stackalloc char[(UIntPtr)160];
			int num = Interop.Kernel32.GetCalendarInfoEx(localeName, (uint)calendar, IntPtr.Zero, calType, ptr, 80, IntPtr.Zero);
			if (num > 0)
			{
				if (ptr[num - 1] == '\0')
				{
					num--;
				}
				data = new string(ptr, 0, num);
				return true;
			}
			data = "";
			return false;
		}

		// Token: 0x060033FA RID: 13306 RVA: 0x000A5DFC File Offset: 0x000A3FFC
		[UnmanagedCallersOnly]
		private unsafe static Interop.BOOL EnumCalendarInfoCallback(char* lpCalendarInfoString, uint calendar, IntPtr pReserved, void* lParam)
		{
			Interop.BOOL result;
			try
			{
				string text = new string(lpCalendarInfoString);
				if (((CalendarData.EnumData*)lParam)->userOverride != text)
				{
					((CalendarData.EnumData*)lParam)->strings.Add(text);
				}
				result = Interop.BOOL.TRUE;
			}
			catch (Exception)
			{
				result = Interop.BOOL.FALSE;
			}
			return result;
		}

		// Token: 0x060033FB RID: 13307 RVA: 0x000A5E48 File Offset: 0x000A4048
		[UnmanagedCallersOnly]
		private unsafe static Interop.BOOL EnumCalendarsCallback(char* lpCalendarInfoString, uint calendar, IntPtr reserved, void* lParam)
		{
			Interop.BOOL result;
			try
			{
				if ((long)((CalendarData.NlsEnumCalendarsData*)lParam)->userOverride != (long)((ulong)calendar))
				{
					((CalendarData.NlsEnumCalendarsData*)lParam)->calendars.Add((int)calendar);
				}
				result = Interop.BOOL.TRUE;
			}
			catch (Exception)
			{
				result = Interop.BOOL.FALSE;
			}
			return result;
		}

		// Token: 0x060033FC RID: 13308 RVA: 0x000A5E88 File Offset: 0x000A4088
		private bool LoadCalendarDataFromSystemCore(string localeName, CalendarId calendarId)
		{
			if (GlobalizationMode.UseNls)
			{
				return this.NlsLoadCalendarDataFromSystem(localeName, calendarId);
			}
			bool flag = this.IcuLoadCalendarDataFromSystem(localeName, calendarId);
			if (flag && this.bUseUserOverrides)
			{
				CalendarData.NormalizeCalendarId(ref calendarId, ref localeName);
				flag &= CalendarData.CallGetCalendarInfoEx(localeName, calendarId, 48U, out this.iTwoDigitYearMax);
				if ((CalendarId)CultureData.GetLocaleInfoExInt(localeName, 4105U) == calendarId)
				{
					string value = CultureData.ReescapeWin32String(CultureData.GetLocaleInfoEx(localeName, 31U));
					string value2 = CultureData.ReescapeWin32String(CultureData.GetLocaleInfoEx(localeName, 32U));
					CalendarData.InsertOrSwapOverride(value, ref this.saShortDates);
					CalendarData.InsertOrSwapOverride(value2, ref this.saLongDates);
				}
			}
			return flag;
		}

		// Token: 0x060033FD RID: 13309 RVA: 0x000A5F18 File Offset: 0x000A4118
		private static void InsertOrSwapOverride(string value, ref string[] destination)
		{
			if (value == null)
			{
				return;
			}
			int num = Array.IndexOf<string>(destination, value);
			if (num >= 0)
			{
				if (num > 0)
				{
					string text = destination[0];
					destination[0] = value;
					destination[num] = text;
				}
				return;
			}
			string[] array = new string[destination.Length + 1];
			array[0] = value;
			Array.Copy(destination, 0, array, 1, destination.Length);
			destination = array;
		}

		// Token: 0x060033FE RID: 13310 RVA: 0x000A5F6C File Offset: 0x000A416C
		private bool NlsLoadCalendarDataFromSystem(string localeName, CalendarId calendarId)
		{
			bool flag = true;
			uint num = this.bUseUserOverrides ? 0U : 2147483648U;
			CalendarData.NormalizeCalendarId(ref calendarId, ref localeName);
			bool result = flag & CalendarData.CallGetCalendarInfoEx(localeName, calendarId, 48U | num, out this.iTwoDigitYearMax) & CalendarData.CallGetCalendarInfoEx(localeName, calendarId, 2U, out this.sNativeName) & CalendarData.CallGetCalendarInfoEx(localeName, calendarId, 56U, out this.sMonthDay) & CalendarData.CallEnumCalendarInfo(localeName, calendarId, 5U, 31U | num, out this.saShortDates) & CalendarData.CallEnumCalendarInfo(localeName, calendarId, 6U, 32U | num, out this.saLongDates) & CalendarData.CallEnumCalendarInfo(localeName, calendarId, 47U, 4102U, out this.saYearMonths) & CalendarData.GetCalendarDayInfo(localeName, calendarId, 13U, out this.saDayNames) & CalendarData.GetCalendarDayInfo(localeName, calendarId, 20U, out this.saAbbrevDayNames) & CalendarData.GetCalendarMonthInfo(localeName, calendarId, 21U, out this.saMonthNames) & CalendarData.GetCalendarMonthInfo(localeName, calendarId, 34U, out this.saAbbrevMonthNames);
			CalendarData.GetCalendarDayInfo(localeName, calendarId, 55U, out this.saSuperShortDayNames);
			if (calendarId == CalendarId.GREGORIAN)
			{
				CalendarData.GetCalendarMonthInfo(localeName, calendarId, 268435477U, out this.saMonthGenitiveNames);
				CalendarData.GetCalendarMonthInfo(localeName, calendarId, 268435490U, out this.saAbbrevMonthGenitiveNames);
			}
			CalendarData.CallEnumCalendarInfo(localeName, calendarId, 4U, 0U, out this.saEraNames);
			CalendarData.CallEnumCalendarInfo(localeName, calendarId, 57U, 0U, out this.saAbbrevEraNames);
			this.saShortDates = CultureData.ReescapeWin32Strings(this.saShortDates);
			this.saLongDates = CultureData.ReescapeWin32Strings(this.saLongDates);
			this.saYearMonths = CultureData.ReescapeWin32Strings(this.saYearMonths);
			this.sMonthDay = CultureData.ReescapeWin32String(this.sMonthDay);
			return result;
		}

		// Token: 0x060033FF RID: 13311 RVA: 0x000A60E0 File Offset: 0x000A42E0
		private static void NormalizeCalendarId(ref CalendarId calendarId, ref string localeName)
		{
			switch (calendarId)
			{
			case CalendarId.JULIAN:
			case CalendarId.CHINESELUNISOLAR:
			case CalendarId.SAKA:
			case CalendarId.LUNAR_ETO_CHN:
			case CalendarId.LUNAR_ETO_KOR:
			case CalendarId.LUNAR_ETO_ROKUYOU:
			case CalendarId.KOREANLUNISOLAR:
			case CalendarId.TAIWANLUNISOLAR:
				calendarId = CalendarId.GREGORIAN_US;
				break;
			case CalendarId.JAPANESELUNISOLAR:
				calendarId = CalendarId.JAPAN;
				break;
			}
			CalendarData.CheckSpecialCalendar(ref calendarId, ref localeName);
		}

		// Token: 0x06003400 RID: 13312 RVA: 0x000A6130 File Offset: 0x000A4330
		private static void CheckSpecialCalendar(ref CalendarId calendar, ref string localeName)
		{
			CalendarId calendarId = calendar;
			string text;
			if (calendarId != CalendarId.GREGORIAN_US)
			{
				if (calendarId != CalendarId.TAIWAN)
				{
					return;
				}
				if (!CalendarData.NlsSystemSupportsTaiwaneseCalendar())
				{
					calendar = CalendarId.GREGORIAN;
				}
			}
			else if (!CalendarData.CallGetCalendarInfoEx(localeName, calendar, 2U, out text))
			{
				localeName = "fa-IR";
				if (!CalendarData.CallGetCalendarInfoEx(localeName, calendar, 2U, out text))
				{
					localeName = "en-US";
					calendar = CalendarId.GREGORIAN;
					return;
				}
			}
		}

		// Token: 0x06003401 RID: 13313 RVA: 0x000A6184 File Offset: 0x000A4384
		private unsafe static bool CallEnumCalendarInfo(string localeName, CalendarId calendar, uint calType, uint lcType, out string[] data)
		{
			CalendarData.EnumData enumData = default(CalendarData.EnumData);
			enumData.userOverride = null;
			enumData.strings = new List<string>();
			if (lcType != 0U && (lcType & 2147483648U) == 0U && (CalendarId)CultureData.GetLocaleInfoExInt(localeName, 4105U) == calendar)
			{
				string localeInfoEx = CultureData.GetLocaleInfoEx(localeName, lcType);
				if (localeInfoEx != null)
				{
					enumData.userOverride = localeInfoEx;
					enumData.strings.Add(localeInfoEx);
				}
			}
			Interop.Kernel32.EnumCalendarInfoExEx(ldftn(EnumCalendarInfoCallback), localeName, (Interop.BOOL)calendar, null, calType, &enumData);
			if (enumData.strings.Count == 0)
			{
				data = null;
				return false;
			}
			string[] array = enumData.strings.ToArray();
			if (calType == 57U || calType == 4U)
			{
				Array.Reverse<string>(array, 0, array.Length);
			}
			data = array;
			return true;
		}

		// Token: 0x06003402 RID: 13314 RVA: 0x000A6234 File Offset: 0x000A4434
		private static bool GetCalendarDayInfo(string localeName, CalendarId calendar, uint calType, out string[] outputStrings)
		{
			bool flag = true;
			string[] array = new string[7];
			int i = 0;
			while (i < 7)
			{
				flag &= CalendarData.CallGetCalendarInfoEx(localeName, calendar, calType, out array[i]);
				if (i == 0)
				{
					calType -= 7U;
				}
				i++;
				calType += 1U;
			}
			outputStrings = array;
			return flag;
		}

		// Token: 0x06003403 RID: 13315 RVA: 0x000A627C File Offset: 0x000A447C
		private static bool GetCalendarMonthInfo(string localeName, CalendarId calendar, uint calType, out string[] outputStrings)
		{
			string[] array = new string[13];
			int i = 0;
			while (i < 13)
			{
				if (!CalendarData.CallGetCalendarInfoEx(localeName, calendar, calType, out array[i]))
				{
					array[i] = "";
				}
				i++;
				calType += 1U;
			}
			outputStrings = array;
			return true;
		}

		// Token: 0x06003404 RID: 13316 RVA: 0x000A62C0 File Offset: 0x000A44C0
		internal unsafe static int GetCalendarsCore(string localeName, bool useUserOverride, CalendarId[] calendars)
		{
			if (GlobalizationMode.UseNls)
			{
				return CalendarData.NlsGetCalendars(localeName, useUserOverride, calendars);
			}
			int num = CalendarData.IcuGetCalendars(localeName, calendars);
			if (useUserOverride)
			{
				int localeInfoExInt = CultureData.GetLocaleInfoExInt(localeName, 4105U);
				if (localeInfoExInt != 0 && (CalendarId)localeInfoExInt != calendars[0])
				{
					CalendarId calendarId = (CalendarId)localeInfoExInt;
					for (int i = 1; i < calendars.Length; i++)
					{
						if (calendars[i] == calendarId)
						{
							CalendarId calendarId2 = calendars[0];
							calendars[0] = calendarId;
							calendars[i] = calendarId2;
							return num;
						}
					}
					num = ((num < calendars.Length) ? (num + 1) : num);
					int num2 = num;
					Span<CalendarId> span = new Span<CalendarId>(stackalloc byte[checked(unchecked((UIntPtr)num2) * 2)], num2);
					*span[0] = calendarId;
					calendars.AsSpan(0, num - 1).CopyTo(span.Slice(1));
					span.CopyTo(calendars);
				}
			}
			return num;
		}

		// Token: 0x06003405 RID: 13317 RVA: 0x000A6384 File Offset: 0x000A4584
		private unsafe static int NlsGetCalendars(string localeName, bool useUserOverride, CalendarId[] calendars)
		{
			CalendarData.NlsEnumCalendarsData nlsEnumCalendarsData = default(CalendarData.NlsEnumCalendarsData);
			nlsEnumCalendarsData.userOverride = 0;
			nlsEnumCalendarsData.calendars = new List<int>();
			if (useUserOverride)
			{
				int localeInfoExInt = CultureData.GetLocaleInfoExInt(localeName, 4105U);
				if (localeInfoExInt != 0)
				{
					nlsEnumCalendarsData.userOverride = localeInfoExInt;
					nlsEnumCalendarsData.calendars.Add(localeInfoExInt);
				}
			}
			Interop.Kernel32.EnumCalendarInfoExEx(ldftn(EnumCalendarsCallback), localeName, (Interop.BOOL)(-1), null, 1U, &nlsEnumCalendarsData);
			for (int i = 0; i < Math.Min(calendars.Length, nlsEnumCalendarsData.calendars.Count); i++)
			{
				calendars[i] = (CalendarId)nlsEnumCalendarsData.calendars[i];
			}
			return nlsEnumCalendarsData.calendars.Count;
		}

		// Token: 0x06003406 RID: 13318 RVA: 0x000A6420 File Offset: 0x000A4620
		internal static int GetTwoDigitYearMax(CalendarId calendarId)
		{
			if (GlobalizationMode.Invariant)
			{
				return CalendarData.Invariant.iTwoDigitYearMax;
			}
			int result;
			if (!CalendarData.CallGetCalendarInfoEx(null, calendarId, 48U, out result))
			{
				return -1;
			}
			return result;
		}

		// Token: 0x06003408 RID: 13320 RVA: 0x000A645B File Offset: 0x000A465B
		[CompilerGenerated]
		private bool <InitializeEraNames>g__AreEraNamesEmpty|24_0()
		{
			return this.saEraNames == null || this.saEraNames.Length == 0 || string.IsNullOrEmpty(this.saEraNames[0]);
		}

		// Token: 0x0400090A RID: 2314
		internal string sNativeName;

		// Token: 0x0400090B RID: 2315
		internal string[] saShortDates;

		// Token: 0x0400090C RID: 2316
		internal string[] saYearMonths;

		// Token: 0x0400090D RID: 2317
		internal string[] saLongDates;

		// Token: 0x0400090E RID: 2318
		internal string sMonthDay;

		// Token: 0x0400090F RID: 2319
		internal string[] saEraNames;

		// Token: 0x04000910 RID: 2320
		internal string[] saAbbrevEraNames;

		// Token: 0x04000911 RID: 2321
		internal string[] saAbbrevEnglishEraNames;

		// Token: 0x04000912 RID: 2322
		internal string[] saDayNames;

		// Token: 0x04000913 RID: 2323
		internal string[] saAbbrevDayNames;

		// Token: 0x04000914 RID: 2324
		internal string[] saSuperShortDayNames;

		// Token: 0x04000915 RID: 2325
		internal string[] saMonthNames;

		// Token: 0x04000916 RID: 2326
		internal string[] saAbbrevMonthNames;

		// Token: 0x04000917 RID: 2327
		internal string[] saMonthGenitiveNames;

		// Token: 0x04000918 RID: 2328
		internal string[] saAbbrevMonthGenitiveNames;

		// Token: 0x04000919 RID: 2329
		internal string[] saLeapYearMonthNames;

		// Token: 0x0400091A RID: 2330
		internal int iTwoDigitYearMax = 2049;

		// Token: 0x0400091B RID: 2331
		private int iCurrentEra;

		// Token: 0x0400091C RID: 2332
		internal bool bUseUserOverrides;

		// Token: 0x0400091D RID: 2333
		internal static readonly CalendarData Invariant = CalendarData.CreateInvariant();

		// Token: 0x020002C4 RID: 708
		private struct IcuEnumCalendarsData
		{
			// Token: 0x0400091E RID: 2334
			public List<string> Results;

			// Token: 0x0400091F RID: 2335
			public bool DisallowDuplicates;
		}

		// Token: 0x020002C5 RID: 709
		private struct EnumData
		{
			// Token: 0x04000920 RID: 2336
			public string userOverride;

			// Token: 0x04000921 RID: 2337
			public List<string> strings;
		}

		// Token: 0x020002C6 RID: 710
		public struct NlsEnumCalendarsData
		{
			// Token: 0x04000922 RID: 2338
			public int userOverride;

			// Token: 0x04000923 RID: 2339
			public List<int> calendars;
		}
	}
}
