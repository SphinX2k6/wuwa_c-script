using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace System.Globalization
{
	// Token: 0x020002D2 RID: 722
	internal sealed class CultureData
	{
		// Token: 0x17000993 RID: 2451
		// (get) Token: 0x060034F7 RID: 13559 RVA: 0x000AA38C File Offset: 0x000A858C
		private static Dictionary<string, string> RegionNames
		{
			get
			{
				Dictionary<string, string> result;
				if ((result = CultureData.s_regionNames) == null)
				{
					Dictionary<string, string> dictionary = new Dictionary<string, string>(255, StringComparer.OrdinalIgnoreCase);
					dictionary.Add("001", "en-001");
					dictionary.Add("029", "en-029");
					dictionary.Add("150", "en-150");
					dictionary.Add("419", "es-419");
					dictionary.Add("AD", "ca-AD");
					dictionary.Add("AE", "ar-AE");
					dictionary.Add("AF", "prs-AF");
					dictionary.Add("AG", "en-AG");
					dictionary.Add("AI", "en-AI");
					dictionary.Add("AL", "sq-AL");
					dictionary.Add("AM", "hy-AM");
					dictionary.Add("AO", "pt-AO");
					dictionary.Add("AQ", "en-AQ");
					dictionary.Add("AR", "es-AR");
					dictionary.Add("AS", "en-AS");
					dictionary.Add("AT", "de-AT");
					dictionary.Add("AU", "en-AU");
					dictionary.Add("AW", "nl-AW");
					dictionary.Add("AX", "sv-AX");
					dictionary.Add("AZ", "az-Cyrl-AZ");
					dictionary.Add("BA", "bs-Latn-BA");
					dictionary.Add("BB", "en-BB");
					dictionary.Add("BD", "bn-BD");
					dictionary.Add("BE", "nl-BE");
					dictionary.Add("BF", "fr-BF");
					dictionary.Add("BG", "bg-BG");
					dictionary.Add("BH", "ar-BH");
					dictionary.Add("BI", "rn-BI");
					dictionary.Add("BJ", "fr-BJ");
					dictionary.Add("BL", "fr-BL");
					dictionary.Add("BM", "en-BM");
					dictionary.Add("BN", "ms-BN");
					dictionary.Add("BO", "es-BO");
					dictionary.Add("BQ", "nl-BQ");
					dictionary.Add("BR", "pt-BR");
					dictionary.Add("BS", "en-BS");
					dictionary.Add("BT", "dz-BT");
					dictionary.Add("BV", "nb-BV");
					dictionary.Add("BW", "en-BW");
					dictionary.Add("BY", "be-BY");
					dictionary.Add("BZ", "en-BZ");
					dictionary.Add("CA", "en-CA");
					dictionary.Add("CC", "en-CC");
					dictionary.Add("CD", "fr-CD");
					dictionary.Add("CF", "sg-CF");
					dictionary.Add("CG", "fr-CG");
					dictionary.Add("CH", "it-CH");
					dictionary.Add("CI", "fr-CI");
					dictionary.Add("CK", "en-CK");
					dictionary.Add("CL", "es-CL");
					dictionary.Add("CM", "fr-CM");
					dictionary.Add("CN", "zh-CN");
					dictionary.Add("CO", "es-CO");
					dictionary.Add("CR", "es-CR");
					dictionary.Add("CS", "sr-Cyrl-CS");
					dictionary.Add("CU", "es-CU");
					dictionary.Add("CV", "pt-CV");
					dictionary.Add("CW", "nl-CW");
					dictionary.Add("CX", "en-CX");
					dictionary.Add("CY", "el-CY");
					dictionary.Add("CZ", "cs-CZ");
					dictionary.Add("DE", "de-DE");
					dictionary.Add("DJ", "fr-DJ");
					dictionary.Add("DK", "da-DK");
					dictionary.Add("DM", "en-DM");
					dictionary.Add("DO", "es-DO");
					dictionary.Add("DZ", "ar-DZ");
					dictionary.Add("EC", "es-EC");
					dictionary.Add("EE", "et-EE");
					dictionary.Add("EG", "ar-EG");
					dictionary.Add("ER", "tig-ER");
					dictionary.Add("ES", "es-ES");
					dictionary.Add("ET", "am-ET");
					dictionary.Add("FI", "fi-FI");
					dictionary.Add("FJ", "en-FJ");
					dictionary.Add("FK", "en-FK");
					dictionary.Add("FM", "en-FM");
					dictionary.Add("FO", "fo-FO");
					dictionary.Add("FR", "fr-FR");
					dictionary.Add("GA", "fr-GA");
					dictionary.Add("GB", "en-GB");
					dictionary.Add("GD", "en-GD");
					dictionary.Add("GE", "ka-GE");
					dictionary.Add("GF", "fr-GF");
					dictionary.Add("GG", "en-GG");
					dictionary.Add("GH", "en-GH");
					dictionary.Add("GI", "en-GI");
					dictionary.Add("GL", "kl-GL");
					dictionary.Add("GM", "en-GM");
					dictionary.Add("GN", "fr-GN");
					dictionary.Add("GP", "fr-GP");
					dictionary.Add("GQ", "es-GQ");
					dictionary.Add("GR", "el-GR");
					dictionary.Add("GS", "en-GS");
					dictionary.Add("GT", "es-GT");
					dictionary.Add("GU", "en-GU");
					dictionary.Add("GW", "pt-GW");
					dictionary.Add("GY", "en-GY");
					dictionary.Add("HK", "zh-HK");
					dictionary.Add("HM", "en-HM");
					dictionary.Add("HN", "es-HN");
					dictionary.Add("HR", "hr-HR");
					dictionary.Add("HT", "fr-HT");
					dictionary.Add("HU", "hu-HU");
					dictionary.Add("ID", "id-ID");
					dictionary.Add("IE", "en-IE");
					dictionary.Add("IL", "he-IL");
					dictionary.Add("IM", "gv-IM");
					dictionary.Add("IN", "hi-IN");
					dictionary.Add("IO", "en-IO");
					dictionary.Add("IQ", "ar-IQ");
					dictionary.Add("IR", "fa-IR");
					dictionary.Add("IS", "is-IS");
					dictionary.Add("IT", "it-IT");
					dictionary.Add("IV", "");
					dictionary.Add("JE", "en-JE");
					dictionary.Add("JM", "en-JM");
					dictionary.Add("JO", "ar-JO");
					dictionary.Add("JP", "ja-JP");
					dictionary.Add("KE", "sw-KE");
					dictionary.Add("KG", "ky-KG");
					dictionary.Add("KH", "km-KH");
					dictionary.Add("KI", "en-KI");
					dictionary.Add("KM", "ar-KM");
					dictionary.Add("KN", "en-KN");
					dictionary.Add("KP", "ko-KP");
					dictionary.Add("KR", "ko-KR");
					dictionary.Add("KW", "ar-KW");
					dictionary.Add("KY", "en-KY");
					dictionary.Add("KZ", "kk-KZ");
					dictionary.Add("LA", "lo-LA");
					dictionary.Add("LB", "ar-LB");
					dictionary.Add("LC", "en-LC");
					dictionary.Add("LI", "de-LI");
					dictionary.Add("LK", "si-LK");
					dictionary.Add("LR", "en-LR");
					dictionary.Add("LS", "st-LS");
					dictionary.Add("LT", "lt-LT");
					dictionary.Add("LU", "lb-LU");
					dictionary.Add("LV", "lv-LV");
					dictionary.Add("LY", "ar-LY");
					dictionary.Add("MA", "ar-MA");
					dictionary.Add("MC", "fr-MC");
					dictionary.Add("MD", "ro-MD");
					dictionary.Add("ME", "sr-Latn-ME");
					dictionary.Add("MF", "fr-MF");
					dictionary.Add("MG", "mg-MG");
					dictionary.Add("MH", "en-MH");
					dictionary.Add("MK", "mk-MK");
					dictionary.Add("ML", "fr-ML");
					dictionary.Add("MM", "my-MM");
					dictionary.Add("MN", "mn-MN");
					dictionary.Add("MO", "zh-MO");
					dictionary.Add("MP", "en-MP");
					dictionary.Add("MQ", "fr-MQ");
					dictionary.Add("MR", "ar-MR");
					dictionary.Add("MS", "en-MS");
					dictionary.Add("MT", "mt-MT");
					dictionary.Add("MU", "en-MU");
					dictionary.Add("MV", "dv-MV");
					dictionary.Add("MW", "en-MW");
					dictionary.Add("MX", "es-MX");
					dictionary.Add("MY", "ms-MY");
					dictionary.Add("MZ", "pt-MZ");
					dictionary.Add("NA", "en-NA");
					dictionary.Add("NC", "fr-NC");
					dictionary.Add("NE", "fr-NE");
					dictionary.Add("NF", "en-NF");
					dictionary.Add("NG", "ig-NG");
					dictionary.Add("NI", "es-NI");
					dictionary.Add("NL", "nl-NL");
					dictionary.Add("NO", "nn-NO");
					dictionary.Add("NP", "ne-NP");
					dictionary.Add("NR", "en-NR");
					dictionary.Add("NU", "en-NU");
					dictionary.Add("NZ", "en-NZ");
					dictionary.Add("OM", "ar-OM");
					dictionary.Add("PA", "es-PA");
					dictionary.Add("PE", "es-PE");
					dictionary.Add("PF", "fr-PF");
					dictionary.Add("PG", "en-PG");
					dictionary.Add("PH", "en-PH");
					dictionary.Add("PK", "ur-PK");
					dictionary.Add("PL", "pl-PL");
					dictionary.Add("PM", "fr-PM");
					dictionary.Add("PN", "en-PN");
					dictionary.Add("PR", "es-PR");
					dictionary.Add("PS", "ar-PS");
					dictionary.Add("PT", "pt-PT");
					dictionary.Add("PW", "en-PW");
					dictionary.Add("PY", "es-PY");
					dictionary.Add("QA", "ar-QA");
					dictionary.Add("RE", "fr-RE");
					dictionary.Add("RO", "ro-RO");
					dictionary.Add("RS", "sr-Latn-RS");
					dictionary.Add("RU", "ru-RU");
					dictionary.Add("RW", "rw-RW");
					dictionary.Add("SA", "ar-SA");
					dictionary.Add("SB", "en-SB");
					dictionary.Add("SC", "fr-SC");
					dictionary.Add("SD", "ar-SD");
					dictionary.Add("SE", "sv-SE");
					dictionary.Add("SG", "zh-SG");
					dictionary.Add("SH", "en-SH");
					dictionary.Add("SI", "sl-SI");
					dictionary.Add("SJ", "nb-SJ");
					dictionary.Add("SK", "sk-SK");
					dictionary.Add("SL", "en-SL");
					dictionary.Add("SM", "it-SM");
					dictionary.Add("SN", "wo-SN");
					dictionary.Add("SO", "so-SO");
					dictionary.Add("SR", "nl-SR");
					dictionary.Add("SS", "en-SS");
					dictionary.Add("ST", "pt-ST");
					dictionary.Add("SV", "es-SV");
					dictionary.Add("SX", "nl-SX");
					dictionary.Add("SY", "ar-SY");
					dictionary.Add("SZ", "ss-SZ");
					dictionary.Add("TC", "en-TC");
					dictionary.Add("TD", "fr-TD");
					dictionary.Add("TF", "fr-TF");
					dictionary.Add("TG", "fr-TG");
					dictionary.Add("TH", "th-TH");
					dictionary.Add("TJ", "tg-Cyrl-TJ");
					dictionary.Add("TK", "en-TK");
					dictionary.Add("TL", "pt-TL");
					dictionary.Add("TM", "tk-TM");
					dictionary.Add("TN", "ar-TN");
					dictionary.Add("TO", "to-TO");
					dictionary.Add("TR", "tr-TR");
					dictionary.Add("TT", "en-TT");
					dictionary.Add("TV", "en-TV");
					dictionary.Add("TW", "zh-TW");
					dictionary.Add("TZ", "sw-TZ");
					dictionary.Add("UA", "uk-UA");
					dictionary.Add("UG", "sw-UG");
					dictionary.Add("UM", "en-UM");
					dictionary.Add("US", "en-US");
					dictionary.Add("UY", "es-UY");
					dictionary.Add("UZ", "uz-Cyrl-UZ");
					dictionary.Add("VA", "it-VA");
					dictionary.Add("VC", "en-VC");
					dictionary.Add("VE", "es-VE");
					dictionary.Add("VG", "en-VG");
					dictionary.Add("VI", "en-VI");
					dictionary.Add("VN", "vi-VN");
					dictionary.Add("VU", "fr-VU");
					dictionary.Add("WF", "fr-WF");
					dictionary.Add("WS", "en-WS");
					dictionary.Add("XK", "sq-XK");
					dictionary.Add("YE", "ar-YE");
					dictionary.Add("YT", "fr-YT");
					dictionary.Add("ZA", "af-ZA");
					dictionary.Add("ZM", "en-ZM");
					dictionary.Add("ZW", "en-ZW");
					result = dictionary;
					CultureData.s_regionNames = dictionary;
				}
				return result;
			}
		}

		// Token: 0x17000994 RID: 2452
		// (get) Token: 0x060034F8 RID: 13560 RVA: 0x000AB3AA File Offset: 0x000A95AA
		internal string InteropName
		{
			get
			{
				return this._sWindowsName;
			}
		}

		// Token: 0x060034F9 RID: 13561 RVA: 0x000AB3B4 File Offset: 0x000A95B4
		internal static CultureData GetCultureDataForRegion(string cultureName, bool useUserOverride)
		{
			if (string.IsNullOrEmpty(cultureName))
			{
				return CultureData.Invariant;
			}
			CultureData cultureData = CultureData.GetCultureData(cultureName, useUserOverride);
			if (cultureData != null && !cultureData.IsNeutralCulture)
			{
				return cultureData;
			}
			CultureData cultureData2 = cultureData;
			string key = CultureData.AnsiToLower(useUserOverride ? cultureName : (cultureName + "*"));
			Dictionary<string, CultureData> dictionary = CultureData.s_cachedRegions;
			if (dictionary == null)
			{
				dictionary = new Dictionary<string, CultureData>();
			}
			else
			{
				object obj = CultureData.s_lock;
				lock (obj)
				{
					dictionary.TryGetValue(key, out cultureData);
				}
				if (cultureData != null)
				{
					return cultureData;
				}
			}
			string cultureName2;
			if ((cultureData == null || cultureData.IsNeutralCulture) && CultureData.RegionNames.TryGetValue(cultureName, out cultureName2))
			{
				cultureData = CultureData.GetCultureData(cultureName2, useUserOverride);
			}
			if (!GlobalizationMode.Invariant && (cultureData == null || cultureData.IsNeutralCulture))
			{
				cultureData = (GlobalizationMode.UseNls ? CultureData.NlsGetCultureDataFromRegionName(cultureName) : null);
			}
			if (cultureData != null && !cultureData.IsNeutralCulture)
			{
				object obj = CultureData.s_lock;
				lock (obj)
				{
					dictionary[key] = cultureData;
				}
				CultureData.s_cachedRegions = dictionary;
			}
			else
			{
				cultureData = cultureData2;
			}
			return cultureData;
		}

		// Token: 0x060034FA RID: 13562 RVA: 0x000AB4E4 File Offset: 0x000A96E4
		internal static void ClearCachedData()
		{
			CultureData.s_cachedCultures = null;
			CultureData.s_cachedRegions = null;
		}

		// Token: 0x060034FB RID: 13563 RVA: 0x000AB4F8 File Offset: 0x000A96F8
		internal static CultureInfo[] GetCultures(CultureTypes types)
		{
			if (types <= (CultureTypes)0 || (types & ~(CultureTypes.NeutralCultures | CultureTypes.SpecificCultures | CultureTypes.InstalledWin32Cultures | CultureTypes.UserCustomCulture | CultureTypes.ReplacementCultures | CultureTypes.WindowsOnlyCultures | CultureTypes.FrameworkCultures)) != (CultureTypes)0)
			{
				throw new ArgumentOutOfRangeException("types", SR.Format(SR.ArgumentOutOfRange_Range, CultureTypes.NeutralCultures, CultureTypes.FrameworkCultures));
			}
			if ((types & CultureTypes.WindowsOnlyCultures) != (CultureTypes)0)
			{
				types &= ~CultureTypes.WindowsOnlyCultures;
			}
			if (GlobalizationMode.Invariant)
			{
				return new CultureInfo[]
				{
					new CultureInfo("")
				};
			}
			if (!GlobalizationMode.UseNls)
			{
				return CultureData.IcuEnumCultures(types);
			}
			return CultureData.NlsEnumCultures(types);
		}

		// Token: 0x060034FC RID: 13564 RVA: 0x000AB56C File Offset: 0x000A976C
		private static CultureData CreateCultureWithInvariantData()
		{
			CultureData cultureData = new CultureData();
			cultureData._bUseOverrides = false;
			cultureData._bUseOverridesUserSetting = false;
			cultureData._sRealName = "";
			cultureData._sWindowsName = "";
			cultureData._sName = "";
			cultureData._sParent = "";
			cultureData._bNeutral = false;
			cultureData._sEnglishDisplayName = "Invariant Language (Invariant Country)";
			cultureData._sNativeDisplayName = "Invariant Language (Invariant Country)";
			cultureData._sSpecificCulture = "";
			cultureData._sISO639Language = "iv";
			cultureData._sISO639Language2 = "ivl";
			cultureData._sEnglishLanguage = "Invariant Language";
			cultureData._sNativeLanguage = "Invariant Language";
			cultureData._sAbbrevLang = "IVL";
			cultureData._sConsoleFallbackName = "";
			cultureData._iInputLanguageHandle = 127;
			cultureData._sRegionName = "IV";
			cultureData._sEnglishCountry = "Invariant Country";
			cultureData._sNativeCountry = "Invariant Country";
			cultureData._sISO3166CountryName = "IV";
			cultureData._sISO3166CountryName2 = "ivc";
			cultureData._iGeoId = 244;
			cultureData._sPositiveSign = "+";
			cultureData._sNegativeSign = "-";
			cultureData._iDigits = 2;
			cultureData._iNegativeNumber = 1;
			cultureData._waGrouping = new int[]
			{
				3
			};
			cultureData._sDecimalSeparator = ".";
			cultureData._sThousandSeparator = ",";
			cultureData._sNaN = "NaN";
			cultureData._sPositiveInfinity = "Infinity";
			cultureData._sNegativeInfinity = "-Infinity";
			cultureData._iNegativePercent = 0;
			cultureData._iPositivePercent = 0;
			cultureData._sPercent = "%";
			cultureData._sPerMille = "‰";
			cultureData._sCurrency = "¤";
			cultureData._sIntlMonetarySymbol = "XDR";
			cultureData._sEnglishCurrency = "International Monetary Fund";
			cultureData._sNativeCurrency = "International Monetary Fund";
			cultureData._iCurrencyDigits = 2;
			cultureData._iCurrency = 0;
			cultureData._iNegativeCurrency = 0;
			cultureData._waMonetaryGrouping = new int[]
			{
				3
			};
			cultureData._sMonetaryDecimal = ".";
			cultureData._sMonetaryThousand = ",";
			cultureData._iMeasure = 0;
			cultureData._sListSeparator = ",";
			cultureData._sTimeSeparator = ":";
			cultureData._sAM1159 = "AM";
			cultureData._sPM2359 = "PM";
			cultureData._saLongTimes = new string[]
			{
				"HH:mm:ss"
			};
			cultureData._saShortTimes = new string[]
			{
				"HH:mm",
				"hh:mm tt",
				"H:mm",
				"h:mm tt"
			};
			cultureData._iFirstDayOfWeek = 0;
			cultureData._iFirstWeekOfYear = 0;
			cultureData._waCalendars = new CalendarId[]
			{
				CalendarId.GREGORIAN
			};
			if (!GlobalizationMode.InvariantNoLoad)
			{
				cultureData._calendars = new CalendarData[23];
				cultureData._calendars[0] = CalendarData.Invariant;
			}
			cultureData._iReadingLayout = 0;
			cultureData._iLanguage = 127;
			cultureData._iDefaultAnsiCodePage = 1252;
			cultureData._iDefaultOemCodePage = 437;
			cultureData._iDefaultMacCodePage = 10000;
			cultureData._iDefaultEbcdicCodePage = 37;
			if (GlobalizationMode.InvariantNoLoad)
			{
				cultureData._sLocalizedCountry = cultureData._sNativeCountry;
			}
			return cultureData;
		}

		// Token: 0x17000995 RID: 2453
		// (get) Token: 0x060034FD RID: 13565 RVA: 0x000AB861 File Offset: 0x000A9A61
		internal static CultureData Invariant
		{
			get
			{
				CultureData result;
				if ((result = CultureData.s_Invariant) == null)
				{
					result = (CultureData.s_Invariant = CultureData.CreateCultureWithInvariantData());
				}
				return result;
			}
		}

		// Token: 0x060034FE RID: 13566 RVA: 0x000AB878 File Offset: 0x000A9A78
		internal static CultureData GetCultureData(string cultureName, bool useUserOverride)
		{
			if (string.IsNullOrEmpty(cultureName))
			{
				return CultureData.Invariant;
			}
			if (GlobalizationMode.PredefinedCulturesOnly && (GlobalizationMode.Invariant || (GlobalizationMode.UseNls ? (!CultureData.NlsIsEnsurePredefinedLocaleName(cultureName)) : (!CultureData.IcuIsEnsurePredefinedLocaleName(cultureName)))))
			{
				return null;
			}
			string key = CultureData.AnsiToLower(useUserOverride ? cultureName : (cultureName + "*"));
			Dictionary<string, CultureData> dictionary = CultureData.s_cachedCultures;
			object obj;
			if (dictionary == null)
			{
				dictionary = new Dictionary<string, CultureData>();
			}
			else
			{
				obj = CultureData.s_lock;
				CultureData cultureData;
				bool flag2;
				lock (obj)
				{
					flag2 = dictionary.TryGetValue(key, out cultureData);
				}
				if (flag2 && cultureData != null)
				{
					return cultureData;
				}
			}
			CultureData cultureData2 = CultureData.CreateCultureData(cultureName, useUserOverride);
			if (cultureData2 == null)
			{
				return null;
			}
			obj = CultureData.s_lock;
			lock (obj)
			{
				dictionary[key] = cultureData2;
			}
			CultureData.s_cachedCultures = dictionary;
			return cultureData2;
		}

		// Token: 0x060034FF RID: 13567 RVA: 0x000AB97C File Offset: 0x000A9B7C
		private unsafe static string NormalizeCultureName(string name, out bool isNeutralName)
		{
			isNeutralName = true;
			int i = 0;
			if (name.Length > 85)
			{
				throw new ArgumentException(SR.Format(SR.Argument_InvalidId, "name"));
			}
			int length = name.Length;
			Span<char> span = new Span<char>(stackalloc byte[checked(unchecked((UIntPtr)length) * 2)], length);
			bool flag = false;
			while (i < name.Length && name[i] != '-' && name[i] != '_')
			{
				if (char.IsAsciiLetterUpper(name[i]))
				{
					*span[i] = name[i] + ' ';
					flag = true;
				}
				else
				{
					*span[i] = name[i];
				}
				i++;
			}
			if (i < name.Length)
			{
				isNeutralName = false;
			}
			while (i < name.Length)
			{
				if (char.IsAsciiLetterLower(name[i]))
				{
					*span[i] = name[i] - ' ';
					flag = true;
				}
				else
				{
					*span[i] = name[i];
				}
				i++;
			}
			if (flag)
			{
				return new string(span);
			}
			return name;
		}

		// Token: 0x06003500 RID: 13568 RVA: 0x000ABA80 File Offset: 0x000A9C80
		private static CultureData CreateCultureData(string cultureName, bool useUserOverride)
		{
			if (GlobalizationMode.Invariant)
			{
				if (cultureName.Length > 85 || !CultureInfo.VerifyCultureName(cultureName, false))
				{
					return null;
				}
				CultureData cultureData = CultureData.CreateCultureWithInvariantData();
				cultureData._sName = CultureData.NormalizeCultureName(cultureName, out cultureData._bNeutral);
				cultureData._bUseOverridesUserSetting = useUserOverride;
				cultureData._sRealName = cultureData._sName;
				cultureData._sWindowsName = cultureData._sName;
				cultureData._iLanguage = 4096;
				return cultureData;
			}
			else
			{
				if (cultureName.Length == 1 && (cultureName[0] == 'C' || cultureName[0] == 'c'))
				{
					return CultureData.Invariant;
				}
				CultureData cultureData2 = new CultureData();
				cultureData2._sRealName = cultureName;
				cultureData2._bUseOverridesUserSetting = useUserOverride;
				if (!cultureData2.InitCultureDataCore() && !cultureData2.InitCompatibilityCultureData())
				{
					return null;
				}
				cultureData2.InitUserOverride(useUserOverride);
				return cultureData2;
			}
		}

		// Token: 0x06003501 RID: 13569 RVA: 0x000ABB40 File Offset: 0x000A9D40
		private bool InitCompatibilityCultureData()
		{
			string a = CultureData.AnsiToLower(this._sRealName);
			string text;
			string sName;
			if (!(a == "zh-chs"))
			{
				if (!(a == "zh-cht"))
				{
					return false;
				}
				text = "zh-Hant";
				sName = "zh-CHT";
			}
			else
			{
				text = "zh-Hans";
				sName = "zh-CHS";
			}
			this._sRealName = text;
			if (!this.InitCultureDataCore())
			{
				return false;
			}
			this._sName = sName;
			this._sParent = text;
			return true;
		}

		// Token: 0x06003502 RID: 13570 RVA: 0x000ABBB4 File Offset: 0x000A9DB4
		internal static CultureData GetCultureData(int culture, bool bUseUserOverride)
		{
			CultureData cultureData = null;
			if (culture == 127)
			{
				return CultureData.Invariant;
			}
			if (GlobalizationMode.Invariant)
			{
				if (GlobalizationMode.PredefinedCulturesOnly)
				{
					throw new CultureNotFoundException("culture", culture, SR.Argument_CultureNotSupportedInInvariantMode);
				}
				bool flag = culture < 1 || culture > 1048575;
				if (flag)
				{
					throw new CultureNotFoundException("culture", culture, SR.Argument_CultureNotSupported);
				}
				return CultureData.Invariant;
			}
			else
			{
				string text = CultureData.LCIDToLocaleName(culture);
				if (!string.IsNullOrEmpty(text))
				{
					cultureData = CultureData.GetCultureData(text, bUseUserOverride);
				}
				if (cultureData == null)
				{
					throw new CultureNotFoundException("culture", culture, SR.Argument_CultureNotSupported);
				}
				return cultureData;
			}
		}

		// Token: 0x17000996 RID: 2454
		// (get) Token: 0x06003503 RID: 13571 RVA: 0x000ABC48 File Offset: 0x000A9E48
		internal string CultureName
		{
			get
			{
				string sName = this._sName;
				if (!(sName == "zh-CHS") && !(sName == "zh-CHT"))
				{
					return this._sRealName;
				}
				return this._sName;
			}
		}

		// Token: 0x17000997 RID: 2455
		// (get) Token: 0x06003504 RID: 13572 RVA: 0x000ABC8C File Offset: 0x000A9E8C
		internal bool UseUserOverride
		{
			get
			{
				return this._bUseOverridesUserSetting;
			}
		}

		// Token: 0x17000998 RID: 2456
		// (get) Token: 0x06003505 RID: 13573 RVA: 0x000ABC94 File Offset: 0x000A9E94
		internal string Name
		{
			get
			{
				return this._sName ?? string.Empty;
			}
		}

		// Token: 0x17000999 RID: 2457
		// (get) Token: 0x06003506 RID: 13574 RVA: 0x000ABCA8 File Offset: 0x000A9EA8
		internal string ParentName
		{
			get
			{
				string result;
				if ((result = this._sParent) == null)
				{
					result = (this._sParent = this.GetLocaleInfoCore(this._sRealName, CultureData.LocaleStringData.ParentName, null));
				}
				return result;
			}
		}

		// Token: 0x1700099A RID: 2458
		// (get) Token: 0x06003507 RID: 13575 RVA: 0x000ABCD8 File Offset: 0x000A9ED8
		internal string DisplayName
		{
			get
			{
				string text = this.NativeName;
				if (!GlobalizationMode.Invariant && this.Name.Length > 0)
				{
					try
					{
						text = this.GetLanguageDisplayNameCore(this.Name.Equals("zh-CHT", StringComparison.OrdinalIgnoreCase) ? "zh-Hant" : (this.Name.Equals("zh-CHS", StringComparison.OrdinalIgnoreCase) ? "zh-Hans" : this.Name));
					}
					catch
					{
					}
					if (string.IsNullOrEmpty(text) && this.IsNeutralCulture)
					{
						text = this.LocalizedLanguageName;
					}
				}
				return text;
			}
		}

		// Token: 0x06003508 RID: 13576 RVA: 0x000ABD70 File Offset: 0x000A9F70
		private string GetLanguageDisplayNameCore(string cultureName)
		{
			if (!GlobalizationMode.UseNls)
			{
				return this.IcuGetLanguageDisplayName(cultureName);
			}
			return this.NlsGetLanguageDisplayName(cultureName);
		}

		// Token: 0x1700099B RID: 2459
		// (get) Token: 0x06003509 RID: 13577 RVA: 0x000ABD88 File Offset: 0x000A9F88
		internal string EnglishName
		{
			get
			{
				string text = this._sEnglishDisplayName;
				if (text == null && !GlobalizationMode.Invariant)
				{
					if (this.IsNeutralCulture)
					{
						text = this.GetLocaleInfoCore(CultureData.LocaleStringData.EnglishDisplayName, null);
						if (string.IsNullOrEmpty(text))
						{
							text = this.EnglishLanguageName;
						}
						string sName = this._sName;
						if (sName == "zh-CHS" || sName == "zh-CHT")
						{
							text += " Legacy";
						}
					}
					else
					{
						text = this.GetLocaleInfoCore(CultureData.LocaleStringData.EnglishDisplayName, null);
						if (string.IsNullOrEmpty(text))
						{
							if (this.EnglishLanguageName.EndsWith(')'))
							{
								text = this.EnglishLanguageName.AsSpan(0, this._sEnglishLanguage.Length - 1) + ", " + this.EnglishCountryName + ")";
							}
							else
							{
								text = this.EnglishLanguageName + " (" + this.EnglishCountryName + ")";
							}
						}
					}
					this._sEnglishDisplayName = text;
				}
				return text;
			}
		}

		// Token: 0x1700099C RID: 2460
		// (get) Token: 0x0600350A RID: 13578 RVA: 0x000ABE84 File Offset: 0x000AA084
		internal string NativeName
		{
			get
			{
				string text = this._sNativeDisplayName;
				if (text == null && !GlobalizationMode.Invariant)
				{
					if (this.IsNeutralCulture)
					{
						text = this.GetLocaleInfoCore(CultureData.LocaleStringData.NativeDisplayName, null);
						if (string.IsNullOrEmpty(text))
						{
							text = this.NativeLanguageName;
						}
						string sName = this._sName;
						if (!(sName == "zh-CHS"))
						{
							if (sName == "zh-CHT")
							{
								text += " 舊版";
							}
						}
						else
						{
							text += " 旧版";
						}
					}
					else
					{
						text = this.GetLocaleInfoCore(CultureData.LocaleStringData.NativeDisplayName, null);
						if (string.IsNullOrEmpty(text))
						{
							text = this.NativeLanguageName + " (" + this.NativeCountryName + ")";
						}
					}
					this._sNativeDisplayName = text;
				}
				return text;
			}
		}

		// Token: 0x1700099D RID: 2461
		// (get) Token: 0x0600350B RID: 13579 RVA: 0x000ABF3E File Offset: 0x000AA13E
		internal string SpecificCultureName
		{
			get
			{
				return this._sSpecificCulture;
			}
		}

		// Token: 0x1700099E RID: 2462
		// (get) Token: 0x0600350C RID: 13580 RVA: 0x000ABF48 File Offset: 0x000AA148
		internal string TwoLetterISOLanguageName
		{
			get
			{
				string result;
				if ((result = this._sISO639Language) == null)
				{
					result = (this._sISO639Language = this.GetLocaleInfoCore(CultureData.LocaleStringData.Iso639LanguageTwoLetterName, null));
				}
				return result;
			}
		}

		// Token: 0x1700099F RID: 2463
		// (get) Token: 0x0600350D RID: 13581 RVA: 0x000ABF74 File Offset: 0x000AA174
		internal string ThreeLetterISOLanguageName
		{
			get
			{
				string result;
				if ((result = this._sISO639Language2) == null)
				{
					result = (this._sISO639Language2 = this.GetLocaleInfoCore(CultureData.LocaleStringData.Iso639LanguageThreeLetterName, null));
				}
				return result;
			}
		}

		// Token: 0x170009A0 RID: 2464
		// (get) Token: 0x0600350E RID: 13582 RVA: 0x000ABFA0 File Offset: 0x000AA1A0
		internal string ThreeLetterWindowsLanguageName
		{
			get
			{
				string result;
				if ((result = this._sAbbrevLang) == null)
				{
					result = (this._sAbbrevLang = (GlobalizationMode.UseNls ? this.NlsGetThreeLetterWindowsLanguageName(this._sRealName) : CultureData.IcuGetThreeLetterWindowsLanguageName(this._sRealName)));
				}
				return result;
			}
		}

		// Token: 0x170009A1 RID: 2465
		// (get) Token: 0x0600350F RID: 13583 RVA: 0x000ABFE0 File Offset: 0x000AA1E0
		private string LocalizedLanguageName
		{
			get
			{
				string result = this.NativeLanguageName;
				if (!GlobalizationMode.Invariant && this.Name.Length > 0)
				{
					if (GlobalizationMode.UseNls)
					{
						CultureInfo userDefaultUICulture = CultureInfo.UserDefaultUICulture;
						if (!(((userDefaultUICulture != null) ? userDefaultUICulture.Name : null) == CultureInfo.CurrentUICulture.Name))
						{
							return result;
						}
					}
					result = this.GetLocaleInfoCore(CultureData.LocaleStringData.LocalizedLanguageName, CultureInfo.CurrentUICulture.Name);
				}
				return result;
			}
		}

		// Token: 0x170009A2 RID: 2466
		// (get) Token: 0x06003510 RID: 13584 RVA: 0x000AC048 File Offset: 0x000AA248
		private string EnglishLanguageName
		{
			get
			{
				string result;
				if ((result = this._sEnglishLanguage) == null)
				{
					result = (this._sEnglishLanguage = this.GetLocaleInfoCore(CultureData.LocaleStringData.EnglishLanguageName, null));
				}
				return result;
			}
		}

		// Token: 0x170009A3 RID: 2467
		// (get) Token: 0x06003511 RID: 13585 RVA: 0x000AC074 File Offset: 0x000AA274
		private string NativeLanguageName
		{
			get
			{
				string result;
				if ((result = this._sNativeLanguage) == null)
				{
					result = (this._sNativeLanguage = this.GetLocaleInfoCore(CultureData.LocaleStringData.NativeLanguageName, null));
				}
				return result;
			}
		}

		// Token: 0x170009A4 RID: 2468
		// (get) Token: 0x06003512 RID: 13586 RVA: 0x000AC09C File Offset: 0x000AA29C
		internal string RegionName
		{
			get
			{
				string result;
				if ((result = this._sRegionName) == null)
				{
					result = (this._sRegionName = this.GetLocaleInfoCore(CultureData.LocaleStringData.Iso3166CountryName, null));
				}
				return result;
			}
		}

		// Token: 0x170009A5 RID: 2469
		// (get) Token: 0x06003513 RID: 13587 RVA: 0x000AC0C5 File Offset: 0x000AA2C5
		internal int GeoId
		{
			get
			{
				if (this._iGeoId == -1 && !GlobalizationMode.Invariant)
				{
					this._iGeoId = (GlobalizationMode.UseNls ? this.NlsGetLocaleInfo(CultureData.LocaleNumberData.GeoId) : CultureData.IcuGetGeoId(this._sRealName));
				}
				return this._iGeoId;
			}
		}

		// Token: 0x170009A6 RID: 2470
		// (get) Token: 0x06003514 RID: 13588 RVA: 0x000AC100 File Offset: 0x000AA300
		internal string LocalizedCountryName
		{
			get
			{
				string text = this._sLocalizedCountry;
				if (text == null && !GlobalizationMode.Invariant)
				{
					try
					{
						text = (GlobalizationMode.UseNls ? this.NlsGetRegionDisplayName() : null);
					}
					catch
					{
					}
					if (text == null)
					{
						text = this.NativeCountryName;
					}
					this._sLocalizedCountry = text;
				}
				return text;
			}
		}

		// Token: 0x170009A7 RID: 2471
		// (get) Token: 0x06003515 RID: 13589 RVA: 0x000AC158 File Offset: 0x000AA358
		internal string EnglishCountryName
		{
			get
			{
				string result;
				if ((result = this._sEnglishCountry) == null)
				{
					result = (this._sEnglishCountry = this.GetLocaleInfoCore(CultureData.LocaleStringData.EnglishCountryName, null));
				}
				return result;
			}
		}

		// Token: 0x170009A8 RID: 2472
		// (get) Token: 0x06003516 RID: 13590 RVA: 0x000AC184 File Offset: 0x000AA384
		internal string NativeCountryName
		{
			get
			{
				string result;
				if ((result = this._sNativeCountry) == null)
				{
					result = (this._sNativeCountry = this.GetLocaleInfoCore(CultureData.LocaleStringData.NativeCountryName, null));
				}
				return result;
			}
		}

		// Token: 0x170009A9 RID: 2473
		// (get) Token: 0x06003517 RID: 13591 RVA: 0x000AC1AC File Offset: 0x000AA3AC
		internal string TwoLetterISOCountryName
		{
			get
			{
				string result;
				if ((result = this._sISO3166CountryName) == null)
				{
					result = (this._sISO3166CountryName = this.GetLocaleInfoCore(CultureData.LocaleStringData.Iso3166CountryName, null));
				}
				return result;
			}
		}

		// Token: 0x170009AA RID: 2474
		// (get) Token: 0x06003518 RID: 13592 RVA: 0x000AC1D8 File Offset: 0x000AA3D8
		internal string ThreeLetterISOCountryName
		{
			get
			{
				string result;
				if ((result = this._sISO3166CountryName2) == null)
				{
					result = (this._sISO3166CountryName2 = this.GetLocaleInfoCore(CultureData.LocaleStringData.Iso3166CountryName2, null));
				}
				return result;
			}
		}

		// Token: 0x170009AB RID: 2475
		// (get) Token: 0x06003519 RID: 13593 RVA: 0x000AC201 File Offset: 0x000AA401
		internal int KeyboardLayoutId
		{
			get
			{
				if (this._iInputLanguageHandle == -1)
				{
					if (this.IsSupplementalCustomCulture)
					{
						this._iInputLanguageHandle = 1033;
					}
					else
					{
						this._iInputLanguageHandle = this.LCID;
					}
				}
				return this._iInputLanguageHandle;
			}
		}

		// Token: 0x170009AC RID: 2476
		// (get) Token: 0x0600351A RID: 13594 RVA: 0x000AC234 File Offset: 0x000AA434
		internal string SCONSOLEFALLBACKNAME
		{
			get
			{
				string result;
				if ((result = this._sConsoleFallbackName) == null)
				{
					result = (this._sConsoleFallbackName = (GlobalizationMode.UseNls ? this.NlsGetConsoleFallbackName(this._sRealName) : CultureData.IcuGetConsoleFallbackName(this._sRealName)));
				}
				return result;
			}
		}

		// Token: 0x170009AD RID: 2477
		// (get) Token: 0x0600351B RID: 13595 RVA: 0x000AC274 File Offset: 0x000AA474
		internal int[] NumberGroupSizes
		{
			get
			{
				int[] result;
				if ((result = this._waGrouping) == null)
				{
					result = (this._waGrouping = this.GetLocaleInfoCoreUserOverride(CultureData.LocaleGroupingData.Digit));
				}
				return result;
			}
		}

		// Token: 0x170009AE RID: 2478
		// (get) Token: 0x0600351C RID: 13596 RVA: 0x000AC29C File Offset: 0x000AA49C
		private string NaNSymbol
		{
			get
			{
				string result;
				if ((result = this._sNaN) == null)
				{
					result = (this._sNaN = this.GetLocaleInfoCore(CultureData.LocaleStringData.NaNSymbol, null));
				}
				return result;
			}
		}

		// Token: 0x170009AF RID: 2479
		// (get) Token: 0x0600351D RID: 13597 RVA: 0x000AC2C8 File Offset: 0x000AA4C8
		private string PositiveInfinitySymbol
		{
			get
			{
				string result;
				if ((result = this._sPositiveInfinity) == null)
				{
					result = (this._sPositiveInfinity = this.GetLocaleInfoCore(CultureData.LocaleStringData.PositiveInfinitySymbol, null));
				}
				return result;
			}
		}

		// Token: 0x170009B0 RID: 2480
		// (get) Token: 0x0600351E RID: 13598 RVA: 0x000AC2F4 File Offset: 0x000AA4F4
		private string NegativeInfinitySymbol
		{
			get
			{
				string result;
				if ((result = this._sNegativeInfinity) == null)
				{
					result = (this._sNegativeInfinity = this.GetLocaleInfoCore(CultureData.LocaleStringData.NegativeInfinitySymbol, null));
				}
				return result;
			}
		}

		// Token: 0x170009B1 RID: 2481
		// (get) Token: 0x0600351F RID: 13599 RVA: 0x000AC31D File Offset: 0x000AA51D
		private int PercentNegativePattern
		{
			get
			{
				if (this._iNegativePercent == -1)
				{
					this._iNegativePercent = this.GetLocaleInfoCore(CultureData.LocaleNumberData.NegativePercentFormat);
				}
				return this._iNegativePercent;
			}
		}

		// Token: 0x170009B2 RID: 2482
		// (get) Token: 0x06003520 RID: 13600 RVA: 0x000AC33C File Offset: 0x000AA53C
		private int PercentPositivePattern
		{
			get
			{
				if (this._iPositivePercent == -1)
				{
					this._iPositivePercent = this.GetLocaleInfoCore(CultureData.LocaleNumberData.PositivePercentFormat);
				}
				return this._iPositivePercent;
			}
		}

		// Token: 0x170009B3 RID: 2483
		// (get) Token: 0x06003521 RID: 13601 RVA: 0x000AC35C File Offset: 0x000AA55C
		private string PercentSymbol
		{
			get
			{
				string result;
				if ((result = this._sPercent) == null)
				{
					result = (this._sPercent = this.GetLocaleInfoCore(CultureData.LocaleStringData.PercentSymbol, null));
				}
				return result;
			}
		}

		// Token: 0x170009B4 RID: 2484
		// (get) Token: 0x06003522 RID: 13602 RVA: 0x000AC388 File Offset: 0x000AA588
		private string PerMilleSymbol
		{
			get
			{
				string result;
				if ((result = this._sPerMille) == null)
				{
					result = (this._sPerMille = this.GetLocaleInfoCore(CultureData.LocaleStringData.PerMilleSymbol, null));
				}
				return result;
			}
		}

		// Token: 0x170009B5 RID: 2485
		// (get) Token: 0x06003523 RID: 13603 RVA: 0x000AC3B4 File Offset: 0x000AA5B4
		internal string CurrencySymbol
		{
			get
			{
				string result;
				if ((result = this._sCurrency) == null)
				{
					result = (this._sCurrency = this.GetLocaleInfoCoreUserOverride(CultureData.LocaleStringData.MonetarySymbol));
				}
				return result;
			}
		}

		// Token: 0x170009B6 RID: 2486
		// (get) Token: 0x06003524 RID: 13604 RVA: 0x000AC3DC File Offset: 0x000AA5DC
		internal string ISOCurrencySymbol
		{
			get
			{
				string result;
				if ((result = this._sIntlMonetarySymbol) == null)
				{
					result = (this._sIntlMonetarySymbol = this.GetLocaleInfoCore(CultureData.LocaleStringData.Iso4217MonetarySymbol, null));
				}
				return result;
			}
		}

		// Token: 0x170009B7 RID: 2487
		// (get) Token: 0x06003525 RID: 13605 RVA: 0x000AC408 File Offset: 0x000AA608
		internal string CurrencyEnglishName
		{
			get
			{
				string result;
				if ((result = this._sEnglishCurrency) == null)
				{
					result = (this._sEnglishCurrency = this.GetLocaleInfoCore(CultureData.LocaleStringData.CurrencyEnglishName, null));
				}
				return result;
			}
		}

		// Token: 0x170009B8 RID: 2488
		// (get) Token: 0x06003526 RID: 13606 RVA: 0x000AC434 File Offset: 0x000AA634
		internal string CurrencyNativeName
		{
			get
			{
				string result;
				if ((result = this._sNativeCurrency) == null)
				{
					result = (this._sNativeCurrency = this.GetLocaleInfoCore(CultureData.LocaleStringData.CurrencyNativeName, null));
				}
				return result;
			}
		}

		// Token: 0x170009B9 RID: 2489
		// (get) Token: 0x06003527 RID: 13607 RVA: 0x000AC460 File Offset: 0x000AA660
		internal int[] CurrencyGroupSizes
		{
			get
			{
				int[] result;
				if ((result = this._waMonetaryGrouping) == null)
				{
					result = (this._waMonetaryGrouping = this.GetLocaleInfoCoreUserOverride(CultureData.LocaleGroupingData.Monetary));
				}
				return result;
			}
		}

		// Token: 0x170009BA RID: 2490
		// (get) Token: 0x06003528 RID: 13608 RVA: 0x000AC488 File Offset: 0x000AA688
		internal int MeasurementSystem
		{
			get
			{
				if (this._iMeasure == -1)
				{
					this._iMeasure = this.GetLocaleInfoCoreUserOverride(CultureData.LocaleNumberData.MeasurementSystem);
				}
				return this._iMeasure;
			}
		}

		// Token: 0x170009BB RID: 2491
		// (get) Token: 0x06003529 RID: 13609 RVA: 0x000AC4A8 File Offset: 0x000AA6A8
		internal string ListSeparator
		{
			get
			{
				string result;
				if ((result = this._sListSeparator) == null)
				{
					result = (this._sListSeparator = (this.ShouldUseUserOverrideNlsData ? this.NlsGetLocaleInfo(CultureData.LocaleStringData.ListSeparator) : CultureData.IcuGetListSeparator(this._sWindowsName)));
				}
				return result;
			}
		}

		// Token: 0x170009BC RID: 2492
		// (get) Token: 0x0600352A RID: 13610 RVA: 0x000AC4E8 File Offset: 0x000AA6E8
		internal string AMDesignator
		{
			get
			{
				string result;
				if ((result = this._sAM1159) == null)
				{
					result = (this._sAM1159 = this.GetLocaleInfoCoreUserOverride(CultureData.LocaleStringData.AMDesignator));
				}
				return result;
			}
		}

		// Token: 0x170009BD RID: 2493
		// (get) Token: 0x0600352B RID: 13611 RVA: 0x000AC510 File Offset: 0x000AA710
		internal string PMDesignator
		{
			get
			{
				string result;
				if ((result = this._sPM2359) == null)
				{
					result = (this._sPM2359 = this.GetLocaleInfoCoreUserOverride(CultureData.LocaleStringData.PMDesignator));
				}
				return result;
			}
		}

		// Token: 0x170009BE RID: 2494
		// (get) Token: 0x0600352C RID: 13612 RVA: 0x000AC538 File Offset: 0x000AA738
		internal string[] LongTimes
		{
			get
			{
				if (this._saLongTimes == null && !GlobalizationMode.Invariant)
				{
					string[] timeFormatsCore = this.GetTimeFormatsCore(false);
					this._saLongTimes = ((timeFormatsCore != null && timeFormatsCore.Length != 0) ? timeFormatsCore : CultureData.Invariant._saLongTimes);
				}
				return this._saLongTimes;
			}
		}

		// Token: 0x170009BF RID: 2495
		// (get) Token: 0x0600352D RID: 13613 RVA: 0x000AC57C File Offset: 0x000AA77C
		internal string[] ShortTimes
		{
			get
			{
				if (this._saShortTimes == null && !GlobalizationMode.Invariant)
				{
					string[] timeFormatsCore = this.GetTimeFormatsCore(true);
					this._saShortTimes = ((timeFormatsCore != null && timeFormatsCore.Length != 0) ? timeFormatsCore : this.DeriveShortTimesFromLong());
				}
				return this._saShortTimes;
			}
		}

		// Token: 0x0600352E RID: 13614 RVA: 0x000AC5BC File Offset: 0x000AA7BC
		private string[] DeriveShortTimesFromLong()
		{
			string[] longTimes = this.LongTimes;
			string[] array = new string[longTimes.Length];
			for (int i = 0; i < longTimes.Length; i++)
			{
				array[i] = CultureData.StripSecondsFromPattern(longTimes[i]);
			}
			return array;
		}

		// Token: 0x0600352F RID: 13615 RVA: 0x000AC5F4 File Offset: 0x000AA7F4
		private static string StripSecondsFromPattern(string time)
		{
			bool flag = false;
			int num = -1;
			for (int i = 0; i < time.Length; i++)
			{
				if (time[i] == '\'')
				{
					flag = !flag;
				}
				else if (time[i] == '\\')
				{
					i++;
				}
				else if (!flag)
				{
					char c = time[i];
					if (c <= 'h')
					{
						if (c != 'H' && c != 'h')
						{
							goto IL_D4;
						}
					}
					else if (c != 'm')
					{
						if (c == 's')
						{
							if (i - num <= 4 && i - num > 1 && time[num + 1] != '\'' && time[i - 1] != '\'' && num >= 0)
							{
								i = num + 1;
							}
							bool flag2;
							int indexOfNextTokenAfterSeconds = CultureData.GetIndexOfNextTokenAfterSeconds(time, i, out flag2);
							string value;
							if (flag2)
							{
								value = " ";
							}
							else
							{
								value = "";
							}
							time = time.AsSpan(0, i) + value + time.AsSpan(indexOfNextTokenAfterSeconds);
							goto IL_D4;
						}
						goto IL_D4;
					}
					num = i;
				}
				IL_D4:;
			}
			return time;
		}

		// Token: 0x06003530 RID: 13616 RVA: 0x000AC6E8 File Offset: 0x000AA8E8
		private static int GetIndexOfNextTokenAfterSeconds(string time, int index, out bool containsSpace)
		{
			bool flag = false;
			containsSpace = false;
			while (index < time.Length)
			{
				char c = time[index];
				if (c <= 'H')
				{
					if (c != ' ')
					{
						if (c != '\'')
						{
							if (c == 'H')
							{
								goto IL_63;
							}
						}
						else
						{
							flag = !flag;
						}
					}
					else
					{
						containsSpace = true;
					}
				}
				else if (c <= 'h')
				{
					if (c != '\\')
					{
						if (c == 'h')
						{
							goto IL_63;
						}
					}
					else
					{
						index++;
						if (time[index] == ' ')
						{
							containsSpace = true;
						}
					}
				}
				else if (c == 'm' || c == 't')
				{
					goto IL_63;
				}
				IL_68:
				index++;
				continue;
				IL_63:
				if (!flag)
				{
					return index;
				}
				goto IL_68;
			}
			containsSpace = false;
			return index;
		}

		// Token: 0x170009C0 RID: 2496
		// (get) Token: 0x06003531 RID: 13617 RVA: 0x000AC76F File Offset: 0x000AA96F
		internal int FirstDayOfWeek
		{
			get
			{
				if (this._iFirstDayOfWeek == -1 && !GlobalizationMode.Invariant)
				{
					this._iFirstDayOfWeek = (this.ShouldUseUserOverrideNlsData ? this.NlsGetFirstDayOfWeek() : this.IcuGetLocaleInfo(CultureData.LocaleNumberData.FirstDayOfWeek));
				}
				return this._iFirstDayOfWeek;
			}
		}

		// Token: 0x170009C1 RID: 2497
		// (get) Token: 0x06003532 RID: 13618 RVA: 0x000AC7A8 File Offset: 0x000AA9A8
		internal int CalendarWeekRule
		{
			get
			{
				if (this._iFirstWeekOfYear == -1)
				{
					this._iFirstWeekOfYear = this.GetLocaleInfoCoreUserOverride(CultureData.LocaleNumberData.FirstWeekOfYear);
				}
				return this._iFirstWeekOfYear;
			}
		}

		// Token: 0x06003533 RID: 13619 RVA: 0x000AC7CA File Offset: 0x000AA9CA
		internal string[] ShortDates(CalendarId calendarId)
		{
			return this.GetCalendar(calendarId).saShortDates;
		}

		// Token: 0x06003534 RID: 13620 RVA: 0x000AC7D8 File Offset: 0x000AA9D8
		internal string[] LongDates(CalendarId calendarId)
		{
			return this.GetCalendar(calendarId).saLongDates;
		}

		// Token: 0x06003535 RID: 13621 RVA: 0x000AC7E6 File Offset: 0x000AA9E6
		internal string[] YearMonths(CalendarId calendarId)
		{
			return this.GetCalendar(calendarId).saYearMonths;
		}

		// Token: 0x06003536 RID: 13622 RVA: 0x000AC7F4 File Offset: 0x000AA9F4
		internal string[] DayNames(CalendarId calendarId)
		{
			return this.GetCalendar(calendarId).saDayNames;
		}

		// Token: 0x06003537 RID: 13623 RVA: 0x000AC802 File Offset: 0x000AAA02
		internal string[] AbbreviatedDayNames(CalendarId calendarId)
		{
			return this.GetCalendar(calendarId).saAbbrevDayNames;
		}

		// Token: 0x06003538 RID: 13624 RVA: 0x000AC810 File Offset: 0x000AAA10
		internal string[] SuperShortDayNames(CalendarId calendarId)
		{
			return this.GetCalendar(calendarId).saSuperShortDayNames;
		}

		// Token: 0x06003539 RID: 13625 RVA: 0x000AC81E File Offset: 0x000AAA1E
		internal string[] MonthNames(CalendarId calendarId)
		{
			return this.GetCalendar(calendarId).saMonthNames;
		}

		// Token: 0x0600353A RID: 13626 RVA: 0x000AC82C File Offset: 0x000AAA2C
		internal string[] GenitiveMonthNames(CalendarId calendarId)
		{
			return this.GetCalendar(calendarId).saMonthGenitiveNames;
		}

		// Token: 0x0600353B RID: 13627 RVA: 0x000AC83A File Offset: 0x000AAA3A
		internal string[] AbbreviatedMonthNames(CalendarId calendarId)
		{
			return this.GetCalendar(calendarId).saAbbrevMonthNames;
		}

		// Token: 0x0600353C RID: 13628 RVA: 0x000AC848 File Offset: 0x000AAA48
		internal string[] AbbreviatedGenitiveMonthNames(CalendarId calendarId)
		{
			return this.GetCalendar(calendarId).saAbbrevMonthGenitiveNames;
		}

		// Token: 0x0600353D RID: 13629 RVA: 0x000AC856 File Offset: 0x000AAA56
		internal string[] LeapYearMonthNames(CalendarId calendarId)
		{
			return this.GetCalendar(calendarId).saLeapYearMonthNames;
		}

		// Token: 0x0600353E RID: 13630 RVA: 0x000AC864 File Offset: 0x000AAA64
		internal string MonthDay(CalendarId calendarId)
		{
			return this.GetCalendar(calendarId).sMonthDay;
		}

		// Token: 0x170009C2 RID: 2498
		// (get) Token: 0x0600353F RID: 13631 RVA: 0x000AC874 File Offset: 0x000AAA74
		internal CalendarId[] CalendarIds
		{
			get
			{
				if (this._waCalendars == null && !GlobalizationMode.Invariant)
				{
					CalendarId[] array = new CalendarId[23];
					int num = CalendarData.GetCalendarsCore(this._sWindowsName, this._bUseOverrides, array);
					if (num == 0)
					{
						this._waCalendars = CultureData.Invariant._waCalendars;
					}
					else
					{
						if (this._sWindowsName == "zh-TW")
						{
							bool flag = false;
							for (int i = 0; i < num; i++)
							{
								if (array[i] == CalendarId.TAIWAN)
								{
									flag = true;
									break;
								}
							}
							if (!flag)
							{
								num++;
								Array.Copy(array, 1, array, 2, 21);
								array[1] = CalendarId.TAIWAN;
							}
						}
						CalendarId[] array2 = new CalendarId[num];
						Array.Copy(array, array2, num);
						this._waCalendars = array2;
					}
				}
				return this._waCalendars;
			}
		}

		// Token: 0x06003540 RID: 13632 RVA: 0x000AC927 File Offset: 0x000AAB27
		internal string CalendarName(CalendarId calendarId)
		{
			return this.GetCalendar(calendarId).sNativeName;
		}

		// Token: 0x06003541 RID: 13633 RVA: 0x000AC938 File Offset: 0x000AAB38
		internal CalendarData GetCalendar(CalendarId calendarId)
		{
			if (GlobalizationMode.Invariant)
			{
				return CalendarData.Invariant;
			}
			int num = (int)(calendarId - CalendarId.GREGORIAN);
			if (this._calendars == null)
			{
				this._calendars = new CalendarData[23];
			}
			CalendarData calendarData = this._calendars[num];
			if (calendarData == null)
			{
				calendarData = new CalendarData(this._sWindowsName, calendarId, this._bUseOverrides);
				this._calendars[num] = calendarData;
			}
			return calendarData;
		}

		// Token: 0x170009C3 RID: 2499
		// (get) Token: 0x06003542 RID: 13634 RVA: 0x000AC994 File Offset: 0x000AAB94
		internal bool IsRightToLeft
		{
			get
			{
				return this.ReadingLayout == 1;
			}
		}

		// Token: 0x170009C4 RID: 2500
		// (get) Token: 0x06003543 RID: 13635 RVA: 0x000AC99F File Offset: 0x000AAB9F
		private int ReadingLayout
		{
			get
			{
				if (this._iReadingLayout == -1 && !GlobalizationMode.Invariant)
				{
					this._iReadingLayout = this.GetLocaleInfoCore(CultureData.LocaleNumberData.ReadingLayout);
				}
				return this._iReadingLayout;
			}
		}

		// Token: 0x170009C5 RID: 2501
		// (get) Token: 0x06003544 RID: 13636 RVA: 0x000AC9C5 File Offset: 0x000AABC5
		internal string TextInfoName
		{
			get
			{
				return this._sRealName;
			}
		}

		// Token: 0x170009C6 RID: 2502
		// (get) Token: 0x06003545 RID: 13637 RVA: 0x000AC9C5 File Offset: 0x000AABC5
		internal string SortName
		{
			get
			{
				return this._sRealName;
			}
		}

		// Token: 0x170009C7 RID: 2503
		// (get) Token: 0x06003546 RID: 13638 RVA: 0x000AC9CD File Offset: 0x000AABCD
		internal bool IsSupplementalCustomCulture
		{
			get
			{
				return CultureData.IsCustomCultureId(this.LCID);
			}
		}

		// Token: 0x170009C8 RID: 2504
		// (get) Token: 0x06003547 RID: 13639 RVA: 0x000AC9DA File Offset: 0x000AABDA
		internal int ANSICodePage
		{
			get
			{
				if (this._iDefaultAnsiCodePage == -1 && !GlobalizationMode.Invariant)
				{
					this._iDefaultAnsiCodePage = this.GetAnsiCodePage(this._sRealName);
				}
				return this._iDefaultAnsiCodePage;
			}
		}

		// Token: 0x170009C9 RID: 2505
		// (get) Token: 0x06003548 RID: 13640 RVA: 0x000ACA04 File Offset: 0x000AAC04
		internal int OEMCodePage
		{
			get
			{
				if (this._iDefaultOemCodePage == -1 && !GlobalizationMode.Invariant)
				{
					this._iDefaultOemCodePage = this.GetOemCodePage(this._sRealName);
				}
				return this._iDefaultOemCodePage;
			}
		}

		// Token: 0x170009CA RID: 2506
		// (get) Token: 0x06003549 RID: 13641 RVA: 0x000ACA2E File Offset: 0x000AAC2E
		internal int MacCodePage
		{
			get
			{
				if (this._iDefaultMacCodePage == -1 && !GlobalizationMode.Invariant)
				{
					this._iDefaultMacCodePage = this.GetMacCodePage(this._sRealName);
				}
				return this._iDefaultMacCodePage;
			}
		}

		// Token: 0x170009CB RID: 2507
		// (get) Token: 0x0600354A RID: 13642 RVA: 0x000ACA58 File Offset: 0x000AAC58
		internal int EBCDICCodePage
		{
			get
			{
				if (this._iDefaultEbcdicCodePage == -1 && !GlobalizationMode.Invariant)
				{
					this._iDefaultEbcdicCodePage = this.GetEbcdicCodePage(this._sRealName);
				}
				return this._iDefaultEbcdicCodePage;
			}
		}

		// Token: 0x170009CC RID: 2508
		// (get) Token: 0x0600354B RID: 13643 RVA: 0x000ACA82 File Offset: 0x000AAC82
		internal int LCID
		{
			get
			{
				if (this._iLanguage == 0 && !GlobalizationMode.Invariant)
				{
					this._iLanguage = (GlobalizationMode.UseNls ? CultureData.NlsLocaleNameToLCID(this._sRealName) : CultureData.IcuLocaleNameToLCID(this._sRealName));
				}
				return this._iLanguage;
			}
		}

		// Token: 0x170009CD RID: 2509
		// (get) Token: 0x0600354C RID: 13644 RVA: 0x000ACABE File Offset: 0x000AACBE
		internal bool IsNeutralCulture
		{
			get
			{
				return this._bNeutral;
			}
		}

		// Token: 0x170009CE RID: 2510
		// (get) Token: 0x0600354D RID: 13645 RVA: 0x000ACAC6 File Offset: 0x000AACC6
		internal bool IsInvariantCulture
		{
			get
			{
				return string.IsNullOrEmpty(this.Name);
			}
		}

		// Token: 0x170009CF RID: 2511
		// (get) Token: 0x0600354E RID: 13646 RVA: 0x000ACAD3 File Offset: 0x000AACD3
		internal bool IsReplacementCulture
		{
			get
			{
				return GlobalizationMode.UseNls && this.NlsIsReplacementCulture;
			}
		}

		// Token: 0x170009D0 RID: 2512
		// (get) Token: 0x0600354F RID: 13647 RVA: 0x000ACAE4 File Offset: 0x000AACE4
		internal Calendar DefaultCalendar
		{
			get
			{
				if (GlobalizationMode.Invariant)
				{
					return new GregorianCalendar();
				}
				CalendarId calendarId = (CalendarId)this.GetLocaleInfoCore(CultureData.LocaleNumberData.CalendarType);
				if (calendarId == CalendarId.UNINITIALIZED_VALUE)
				{
					calendarId = this.CalendarIds[0];
				}
				return CultureInfo.GetCalendarInstance(calendarId);
			}
		}

		// Token: 0x06003550 RID: 13648 RVA: 0x000ACB1D File Offset: 0x000AAD1D
		internal string[] EraNames(CalendarId calendarId)
		{
			return this.GetCalendar(calendarId).saEraNames;
		}

		// Token: 0x06003551 RID: 13649 RVA: 0x000ACB2B File Offset: 0x000AAD2B
		internal string[] AbbrevEraNames(CalendarId calendarId)
		{
			return this.GetCalendar(calendarId).saAbbrevEraNames;
		}

		// Token: 0x06003552 RID: 13650 RVA: 0x000ACB39 File Offset: 0x000AAD39
		internal string[] AbbreviatedEnglishEraNames(CalendarId calendarId)
		{
			return this.GetCalendar(calendarId).saAbbrevEnglishEraNames;
		}

		// Token: 0x170009D1 RID: 2513
		// (get) Token: 0x06003553 RID: 13651 RVA: 0x000ACB48 File Offset: 0x000AAD48
		internal string TimeSeparator
		{
			get
			{
				if (this._sTimeSeparator == null && !GlobalizationMode.Invariant)
				{
					if (this._sName == "fr-CA")
					{
						this._sTimeSeparator = ":";
					}
					else
					{
						string text = this.ShouldUseUserOverrideNlsData ? this.NlsGetTimeFormatString() : this.IcuGetTimeFormatString();
						if (string.IsNullOrEmpty(text))
						{
							text = this.LongTimes[0];
						}
						this._sTimeSeparator = CultureData.GetTimeSeparator(text);
					}
				}
				return this._sTimeSeparator;
			}
		}

		// Token: 0x06003554 RID: 13652 RVA: 0x000ACBBD File Offset: 0x000AADBD
		internal string DateSeparator(CalendarId calendarId)
		{
			if (GlobalizationMode.Invariant)
			{
				return "/";
			}
			if (calendarId == CalendarId.JAPAN && !LocalAppContextSwitches.EnforceLegacyJapaneseDateParsing)
			{
				return "/";
			}
			return CultureData.GetDateSeparator(this.ShortDates(calendarId)[0]);
		}

		// Token: 0x06003555 RID: 13653 RVA: 0x000ACBEC File Offset: 0x000AADEC
		private static string UnescapeNlsString(string str, int start, int end)
		{
			StringBuilder stringBuilder = null;
			int num = start;
			while (num < str.Length && num <= end)
			{
				char c = str[num];
				if (c != '\'')
				{
					if (c != '\\')
					{
						if (stringBuilder != null)
						{
							stringBuilder.Append(str[num]);
						}
					}
					else
					{
						if (stringBuilder == null)
						{
							stringBuilder = new StringBuilder(str, start, num - start, str.Length);
						}
						num++;
						if (num < str.Length)
						{
							stringBuilder.Append(str[num]);
						}
					}
				}
				else if (stringBuilder == null)
				{
					stringBuilder = new StringBuilder(str, start, num - start, str.Length);
				}
				num++;
			}
			if (stringBuilder == null)
			{
				return str.Substring(start, end - start + 1);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06003556 RID: 13654 RVA: 0x000ACC92 File Offset: 0x000AAE92
		private static string GetTimeSeparator(string format)
		{
			return CultureData.GetSeparator(format, "Hhms");
		}

		// Token: 0x06003557 RID: 13655 RVA: 0x000ACC9F File Offset: 0x000AAE9F
		private static string GetDateSeparator(string format)
		{
			return CultureData.GetSeparator(format, "dyM");
		}

		// Token: 0x06003558 RID: 13656 RVA: 0x000ACCAC File Offset: 0x000AAEAC
		private static string GetSeparator(string format, string timeParts)
		{
			int num = CultureData.IndexOfTimePart(format, 0, timeParts);
			if (num != -1)
			{
				char c = format[num];
				do
				{
					num++;
				}
				while (num < format.Length && format[num] == c);
				int num2 = num;
				if (num2 < format.Length)
				{
					int num3 = CultureData.IndexOfTimePart(format, num2, timeParts);
					if (num3 != -1)
					{
						return CultureData.UnescapeNlsString(format, num2, num3 - 1);
					}
				}
			}
			return string.Empty;
		}

		// Token: 0x06003559 RID: 13657 RVA: 0x000ACD10 File Offset: 0x000AAF10
		private static int IndexOfTimePart(string format, int startIndex, string timeParts)
		{
			bool flag = false;
			for (int i = startIndex; i < format.Length; i++)
			{
				if (!flag && timeParts.Contains(format[i]))
				{
					return i;
				}
				char c = format[i];
				if (c != '\'')
				{
					if (c == '\\' && i + 1 < format.Length)
					{
						i++;
						char c2 = format[i];
						if (c2 != '\'' && c2 != '\\')
						{
							i--;
						}
					}
				}
				else
				{
					flag = !flag;
				}
			}
			return -1;
		}

		// Token: 0x0600355A RID: 13658 RVA: 0x000ACD83 File Offset: 0x000AAF83
		internal static bool IsCustomCultureId(int cultureId)
		{
			return cultureId == 3072 || cultureId == 4096;
		}

		// Token: 0x0600355B RID: 13659 RVA: 0x000ACD98 File Offset: 0x000AAF98
		private string[] GetNativeDigits()
		{
			string[] array = NumberFormatInfo.s_asciiDigits;
			string localeInfoCoreUserOverride = this.GetLocaleInfoCoreUserOverride(CultureData.LocaleStringData.Digits);
			if (localeInfoCoreUserOverride.Length < NumberFormatInfo.s_asciiDigits.Length)
			{
				return array;
			}
			if (localeInfoCoreUserOverride.StartsWith("0￿1￿2￿3￿4￿5￿6￿7￿8￿9￿", StringComparison.Ordinal) || localeInfoCoreUserOverride.StartsWith("0123456789", StringComparison.Ordinal))
			{
				return array;
			}
			int num = localeInfoCoreUserOverride.IndexOf(char.MaxValue);
			array = new string[10];
			if (num < 0)
			{
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = char.ToString(localeInfoCoreUserOverride[i]);
				}
				return array;
			}
			int num2 = 0;
			int num3 = 0;
			do
			{
				array[num3++] = localeInfoCoreUserOverride.Substring(num2, num - num2);
				num = (num2 = num + 1);
				while (num < localeInfoCoreUserOverride.Length && localeInfoCoreUserOverride[num] != '￿')
				{
					num++;
				}
			}
			while (num < localeInfoCoreUserOverride.Length && num3 < 10);
			if (num3 >= 10)
			{
				return array;
			}
			return NumberFormatInfo.s_asciiDigits;
		}

		// Token: 0x0600355C RID: 13660 RVA: 0x000ACE78 File Offset: 0x000AB078
		internal void GetNFIValues(NumberFormatInfo nfi)
		{
			if (GlobalizationMode.InvariantNoLoad || this.IsInvariantCulture)
			{
				nfi._positiveSign = this._sPositiveSign;
				nfi._negativeSign = this._sNegativeSign;
				nfi._numberGroupSeparator = this._sThousandSeparator;
				nfi._numberDecimalSeparator = this._sDecimalSeparator;
				nfi._numberDecimalDigits = this._iDigits;
				nfi._numberNegativePattern = this._iNegativeNumber;
				nfi._currencySymbol = this._sCurrency;
				nfi._currencyGroupSeparator = this._sMonetaryThousand;
				nfi._currencyDecimalSeparator = this._sMonetaryDecimal;
				nfi._currencyDecimalDigits = this._iCurrencyDigits;
				nfi._currencyNegativePattern = this._iNegativeCurrency;
				nfi._currencyPositivePattern = this._iCurrency;
			}
			else
			{
				nfi._positiveSign = this.GetLocaleInfoCoreUserOverride(CultureData.LocaleStringData.PositiveSign);
				nfi._negativeSign = this.GetLocaleInfoCoreUserOverride(CultureData.LocaleStringData.NegativeSign);
				nfi._numberDecimalSeparator = this.GetLocaleInfoCoreUserOverride(CultureData.LocaleStringData.DecimalSeparator);
				nfi._numberGroupSeparator = this.GetLocaleInfoCoreUserOverride(CultureData.LocaleStringData.ThousandSeparator);
				nfi._currencyGroupSeparator = this.GetLocaleInfoCoreUserOverride(CultureData.LocaleStringData.MonetaryThousandSeparator);
				nfi._currencyDecimalSeparator = this.GetLocaleInfoCoreUserOverride(CultureData.LocaleStringData.MonetaryDecimalSeparator);
				nfi._currencySymbol = this.GetLocaleInfoCoreUserOverride(CultureData.LocaleStringData.MonetarySymbol);
				nfi._numberDecimalDigits = this.GetLocaleInfoCoreUserOverride(CultureData.LocaleNumberData.FractionalDigitsCount);
				nfi._currencyDecimalDigits = this.GetLocaleInfoCoreUserOverride(CultureData.LocaleNumberData.MonetaryFractionalDigitsCount);
				nfi._currencyPositivePattern = this.GetLocaleInfoCoreUserOverride(CultureData.LocaleNumberData.PositiveMonetaryNumberFormat);
				nfi._currencyNegativePattern = this.GetLocaleInfoCoreUserOverride(CultureData.LocaleNumberData.NegativeMonetaryNumberFormat);
				nfi._numberNegativePattern = this.GetLocaleInfoCoreUserOverride(CultureData.LocaleNumberData.NegativeNumberFormat);
				nfi._nativeDigits = this.GetNativeDigits();
				nfi._digitSubstitution = (this.ShouldUseUserOverrideNlsData ? this.NlsGetLocaleInfo(CultureData.LocaleNumberData.DigitSubstitution) : CultureData.IcuGetDigitSubstitution(this._sRealName));
			}
			nfi._numberGroupSizes = this.NumberGroupSizes;
			nfi._currencyGroupSizes = this.CurrencyGroupSizes;
			nfi._percentNegativePattern = this.PercentNegativePattern;
			nfi._percentPositivePattern = this.PercentPositivePattern;
			nfi._percentSymbol = this.PercentSymbol;
			nfi._perMilleSymbol = this.PerMilleSymbol;
			nfi._negativeInfinitySymbol = this.NegativeInfinitySymbol;
			nfi._positiveInfinitySymbol = this.PositiveInfinitySymbol;
			nfi._nanSymbol = this.NaNSymbol;
			nfi._percentDecimalDigits = nfi._numberDecimalDigits;
			nfi._percentDecimalSeparator = nfi._numberDecimalSeparator;
			nfi._percentGroupSizes = nfi._numberGroupSizes;
			nfi._percentGroupSeparator = nfi._numberGroupSeparator;
			if (string.IsNullOrEmpty(nfi._positiveSign))
			{
				nfi._positiveSign = "+";
			}
			if (string.IsNullOrEmpty(nfi._currencyDecimalSeparator))
			{
				nfi._currencyDecimalSeparator = nfi._numberDecimalSeparator;
			}
		}

		// Token: 0x0600355D RID: 13661 RVA: 0x000AD0D6 File Offset: 0x000AB2D6
		internal static string AnsiToLower(string testString)
		{
			return TextInfo.ToLowerAsciiInvariant(testString);
		}

		// Token: 0x0600355E RID: 13662 RVA: 0x000AD0DE File Offset: 0x000AB2DE
		private int GetLocaleInfoCore(CultureData.LocaleNumberData type)
		{
			if (GlobalizationMode.Invariant)
			{
				return 0;
			}
			if (!GlobalizationMode.UseNls)
			{
				return this.IcuGetLocaleInfo(type);
			}
			return this.NlsGetLocaleInfo(type);
		}

		// Token: 0x0600355F RID: 13663 RVA: 0x000AD0FF File Offset: 0x000AB2FF
		private int GetLocaleInfoCoreUserOverride(CultureData.LocaleNumberData type)
		{
			if (GlobalizationMode.Invariant)
			{
				return 0;
			}
			if (!this.ShouldUseUserOverrideNlsData)
			{
				return this.IcuGetLocaleInfo(type);
			}
			return this.NlsGetLocaleInfo(type);
		}

		// Token: 0x06003560 RID: 13664 RVA: 0x000AD121 File Offset: 0x000AB321
		private string GetLocaleInfoCoreUserOverride(CultureData.LocaleStringData type)
		{
			if (GlobalizationMode.Invariant)
			{
				return null;
			}
			if (!this.ShouldUseUserOverrideNlsData)
			{
				return this.IcuGetLocaleInfo(type, null);
			}
			return this.NlsGetLocaleInfo(type);
		}

		// Token: 0x06003561 RID: 13665 RVA: 0x000AD144 File Offset: 0x000AB344
		private string GetLocaleInfoCore(CultureData.LocaleStringData type, string uiCultureName = null)
		{
			if (GlobalizationMode.Invariant)
			{
				return null;
			}
			if (!GlobalizationMode.UseNls)
			{
				return this.IcuGetLocaleInfo(type, uiCultureName);
			}
			return this.NlsGetLocaleInfo(type);
		}

		// Token: 0x06003562 RID: 13666 RVA: 0x000AD166 File Offset: 0x000AB366
		private string GetLocaleInfoCore(string localeName, CultureData.LocaleStringData type, string uiCultureName = null)
		{
			if (GlobalizationMode.Invariant)
			{
				return null;
			}
			if (!GlobalizationMode.UseNls)
			{
				return this.IcuGetLocaleInfo(localeName, type, uiCultureName);
			}
			return this.NlsGetLocaleInfo(localeName, type);
		}

		// Token: 0x06003563 RID: 13667 RVA: 0x000AD18A File Offset: 0x000AB38A
		private int[] GetLocaleInfoCoreUserOverride(CultureData.LocaleGroupingData type)
		{
			if (GlobalizationMode.Invariant)
			{
				return null;
			}
			if (!this.ShouldUseUserOverrideNlsData)
			{
				return this.IcuGetLocaleInfo(type);
			}
			return this.NlsGetLocaleInfo(type);
		}

		// Token: 0x06003564 RID: 13668 RVA: 0x000AD1AC File Offset: 0x000AB3AC
		private unsafe static string NormalizeCultureName(string name, ReadOnlySpan<char> extension, out int collationStart)
		{
			collationStart = -1;
			bool flag = false;
			Span<char> span = new Span<char>(stackalloc byte[(UIntPtr)314], 157);
			int num = 0;
			int num2 = 0;
			while (num2 < name.Length && num < 157)
			{
				char c = name[num2];
				if (c == '-' && num2 < name.Length - 1 && name[num2 + 1] == '-')
				{
					flag = true;
					*span[num++] = '-';
					num2++;
				}
				else if (c == '@')
				{
					flag = true;
					if (!extension.IsEmpty && extension.TryCopyTo(span.Slice(num)))
					{
						num += extension.Length;
					}
					int num3 = name.IndexOf("collation=", num2 + 1, StringComparison.Ordinal);
					if (num3 <= 0)
					{
						break;
					}
					num3 += "collation=".Length;
					int num4 = name.IndexOf(';', num3);
					if (num4 < 0)
					{
						num4 = name.Length;
					}
					int num5 = Math.Min(8, num4 - num3);
					if (span.Length - num >= num5 + 1)
					{
						collationStart = num;
						*span[num++] = '_';
						name.AsSpan(num3, num5).CopyTo(span.Slice(num));
						num += num5;
						break;
					}
					break;
				}
				else
				{
					*span[num++] = name[num2];
				}
				num2++;
			}
			if (!flag)
			{
				return name;
			}
			return new string(span.Slice(0, num));
		}

		// Token: 0x06003565 RID: 13669 RVA: 0x000AD320 File Offset: 0x000AB520
		private bool InitIcuCultureDataCore()
		{
			string text = this._sRealName;
			int num;
			int num2;
			if (!CultureData.IsValidCultureName(text, out num, out num2))
			{
				return false;
			}
			if (num > 0)
			{
				ReadOnlySpan<char> str = text.AsSpan(num + 1);
				text = text.AsSpan(0, num) + "@collation=" + str;
			}
			if (!CultureData.GetLocaleName(text, out this._sWindowsName))
			{
				return false;
			}
			int num3;
			this._sRealName = CultureData.NormalizeCultureName(this._sWindowsName, (num2 > 0) ? this._sRealName.AsSpan(num2) : ReadOnlySpan<char>.Empty, out num3);
			this._iLanguage = this.LCID;
			if (this._iLanguage == 0)
			{
				this._iLanguage = 4096;
			}
			this._bNeutral = (this.TwoLetterISOCountryName.Length == 0);
			this._sSpecificCulture = (this._bNeutral ? IcuLocaleData.GetSpecificCultureName(this._sRealName) : this._sRealName);
			this._sName = ((num3 < 0 || this._bNeutral) ? this._sRealName : this._sRealName.Substring(0, num3));
			return true;
		}

		// Token: 0x06003566 RID: 13670 RVA: 0x000AD424 File Offset: 0x000AB624
		internal unsafe static bool GetLocaleName(string localeName, out string windowsName)
		{
			char* value = stackalloc char[(UIntPtr)314];
			if (!Interop.Globalization.GetLocaleName(localeName, value, 157))
			{
				windowsName = null;
				return false;
			}
			windowsName = new string(value);
			return true;
		}

		// Token: 0x06003567 RID: 13671 RVA: 0x000AD456 File Offset: 0x000AB656
		private string IcuGetLocaleInfo(CultureData.LocaleStringData type, string uiCultureName = null)
		{
			return this.IcuGetLocaleInfo(this._sWindowsName, type, uiCultureName);
		}

		// Token: 0x06003568 RID: 13672 RVA: 0x000AD468 File Offset: 0x000AB668
		private unsafe string IcuGetLocaleInfo(string localeName, CultureData.LocaleStringData type, string uiCultureName = null)
		{
			if (type == CultureData.LocaleStringData.NegativeInfinitySymbol)
			{
				return this.IcuGetLocaleInfo(localeName, CultureData.LocaleStringData.NegativeSign, null) + this.IcuGetLocaleInfo(localeName, CultureData.LocaleStringData.PositiveInfinitySymbol, null);
			}
			char* value = stackalloc char[(UIntPtr)200];
			if (!Interop.Globalization.GetLocaleInfoString(localeName, (uint)type, value, 100, uiCultureName))
			{
				return string.Empty;
			}
			return new string(value);
		}

		// Token: 0x06003569 RID: 13673 RVA: 0x000AD4B8 File Offset: 0x000AB6B8
		private int IcuGetLocaleInfo(CultureData.LocaleNumberData type)
		{
			if (type == CultureData.LocaleNumberData.CalendarType)
			{
				return 0;
			}
			int result = 0;
			Interop.Globalization.GetLocaleInfoInt(this._sWindowsName, (uint)type, ref result);
			return result;
		}

		// Token: 0x0600356A RID: 13674 RVA: 0x000AD4E4 File Offset: 0x000AB6E4
		private int[] IcuGetLocaleInfo(CultureData.LocaleGroupingData type)
		{
			int num = 0;
			int num2 = 0;
			Interop.Globalization.GetLocaleInfoGroupingSizes(this._sWindowsName, (uint)type, ref num, ref num2);
			if (num2 == 0)
			{
				return new int[]
				{
					num
				};
			}
			return new int[]
			{
				num,
				num2
			};
		}

		// Token: 0x0600356B RID: 13675 RVA: 0x000AD522 File Offset: 0x000AB722
		private string IcuGetTimeFormatString()
		{
			return this.IcuGetTimeFormatString(false);
		}

		// Token: 0x0600356C RID: 13676 RVA: 0x000AD52C File Offset: 0x000AB72C
		private unsafe string IcuGetTimeFormatString(bool shortFormat)
		{
			char* ptr = stackalloc char[(UIntPtr)200];
			if (!Interop.Globalization.GetLocaleTimeFormat(this._sWindowsName, shortFormat, ptr, 100))
			{
				return string.Empty;
			}
			ReadOnlySpan<char> readOnlySpan = new ReadOnlySpan<char>((void*)ptr, 100);
			readOnlySpan = readOnlySpan.Slice(0, readOnlySpan.IndexOf('\0'));
			return CultureData.ConvertIcuTimeFormatString(readOnlySpan);
		}

		// Token: 0x0600356D RID: 13677 RVA: 0x000AD579 File Offset: 0x000AB779
		private string IcuGetLanguageDisplayName(string cultureName)
		{
			return this.IcuGetLocaleInfo(cultureName, CultureData.LocaleStringData.LocalizedDisplayName, CultureInfo.CurrentUICulture.Name);
		}

		// Token: 0x0600356E RID: 13678 RVA: 0x000AD58D File Offset: 0x000AB78D
		internal static bool IcuIsEnsurePredefinedLocaleName(string name)
		{
			return Interop.Globalization.IsPredefinedLocale(name);
		}

		// Token: 0x0600356F RID: 13679 RVA: 0x000AD598 File Offset: 0x000AB798
		private unsafe static string ConvertIcuTimeFormatString(ReadOnlySpan<char> icuFormatString)
		{
			Span<char> result = new Span<char>(stackalloc byte[(UIntPtr)314], 157);
			bool flag = false;
			int length = 0;
			int i = 0;
			while (i < icuFormatString.Length)
			{
				char c = (char)(*icuFormatString[i]);
				if (c <= '\\')
				{
					if (c <= 'B')
					{
						if (c != '\'')
						{
							if (c != 'B')
							{
								goto IL_163;
							}
							goto IL_13E;
						}
						else if (!CultureData.<ConvertIcuTimeFormatString>g__HandleQuoteLiteral|264_0(icuFormatString, ref i, result, ref length))
						{
							for (i++; i < icuFormatString.Length; i++)
							{
								c = (char)(*icuFormatString[i]);
								if (c == '\'')
								{
									if (!CultureData.<ConvertIcuTimeFormatString>g__HandleQuoteLiteral|264_0(icuFormatString, ref i, result, ref length))
									{
										break;
									}
								}
								else
								{
									if (c == '\\')
									{
										*result[length++] = '\\';
									}
									*result[length++] = c;
								}
							}
						}
					}
					else
					{
						if (c == 'H')
						{
							goto IL_12D;
						}
						if (c != '\\')
						{
							goto IL_163;
						}
						*result[length++] = '\\';
						*result[length++] = '\\';
					}
				}
				else if (c <= 'b')
				{
					if (c != 'a' && c != 'b')
					{
						goto IL_163;
					}
					goto IL_13E;
				}
				else
				{
					if (c != 'h' && c != 'm' && c != 's')
					{
						goto IL_163;
					}
					goto IL_12D;
				}
				IL_17B:
				i++;
				continue;
				IL_12D:
				*result[length++] = c;
				goto IL_17B;
				IL_13E:
				if (!flag)
				{
					flag = true;
					*result[length++] = 't';
					*result[length++] = 't';
					goto IL_17B;
				}
				goto IL_17B;
				IL_163:
				if (!char.IsAsciiLetter(c))
				{
					*result[length++] = c;
					goto IL_17B;
				}
				goto IL_17B;
			}
			return result.Slice(0, length).ToString();
		}

		// Token: 0x06003570 RID: 13680 RVA: 0x000AD74C File Offset: 0x000AB94C
		private static int IcuLocaleNameToLCID(string cultureName)
		{
			int localeDataNumericPart = IcuLocaleData.GetLocaleDataNumericPart(cultureName, IcuLocaleDataParts.Lcid);
			if (localeDataNumericPart != -1)
			{
				return localeDataNumericPart;
			}
			return 4096;
		}

		// Token: 0x06003571 RID: 13681 RVA: 0x000AD76C File Offset: 0x000AB96C
		private static int IcuGetGeoId(string cultureName)
		{
			int localeDataNumericPart = IcuLocaleData.GetLocaleDataNumericPart(cultureName, IcuLocaleDataParts.GeoId);
			if (localeDataNumericPart != -1)
			{
				return localeDataNumericPart;
			}
			return CultureData.Invariant.GeoId;
		}

		// Token: 0x06003572 RID: 13682 RVA: 0x000AD794 File Offset: 0x000AB994
		private static int IcuGetDigitSubstitution(string cultureName)
		{
			int localeDataNumericPart = IcuLocaleData.GetLocaleDataNumericPart(cultureName, IcuLocaleDataParts.DigitSubstitutionOrListSeparator);
			if (localeDataNumericPart != -1)
			{
				return (int)((long)localeDataNumericPart & 65535L);
			}
			return 1;
		}

		// Token: 0x06003573 RID: 13683 RVA: 0x000AD7BC File Offset: 0x000AB9BC
		private static string IcuGetListSeparator(string cultureName)
		{
			int localeDataNumericPart = IcuLocaleData.GetLocaleDataNumericPart(cultureName, IcuLocaleDataParts.DigitSubstitutionOrListSeparator);
			if (localeDataNumericPart != -1)
			{
				long num = (long)localeDataNumericPart & (long)((ulong)-65536);
				if (num <= 65536L)
				{
					if (num == 0L)
					{
						return ",";
					}
					if (num == 65536L)
					{
						return ";";
					}
				}
				else
				{
					if (num == 131072L)
					{
						return "،";
					}
					if (num == 196608L)
					{
						return "؛";
					}
					if (num == 262144L)
					{
						return ",,";
					}
				}
			}
			return ",";
		}

		// Token: 0x06003574 RID: 13684 RVA: 0x000AD836 File Offset: 0x000ABA36
		private static string IcuGetThreeLetterWindowsLanguageName(string cultureName)
		{
			return IcuLocaleData.GetThreeLetterWindowsLanguageName(cultureName) ?? "ZZZ";
		}

		// Token: 0x06003575 RID: 13685 RVA: 0x000AD848 File Offset: 0x000ABA48
		private static CultureInfo[] IcuEnumCultures(CultureTypes types)
		{
			if ((types & (CultureTypes.NeutralCultures | CultureTypes.SpecificCultures)) == (CultureTypes)0)
			{
				return Array.Empty<CultureInfo>();
			}
			int locales = Interop.Globalization.GetLocales(null, 0);
			if (locales <= 0)
			{
				return Array.Empty<CultureInfo>();
			}
			char[] array = new char[locales];
			locales = Interop.Globalization.GetLocales(array, locales);
			if (locales <= 0)
			{
				return Array.Empty<CultureInfo>();
			}
			bool flag = (types & CultureTypes.NeutralCultures) > (CultureTypes)0;
			bool flag2 = (types & CultureTypes.SpecificCultures) > (CultureTypes)0;
			List<CultureInfo> list = new List<CultureInfo>();
			if (flag)
			{
				list.Add(CultureInfo.InvariantCulture);
			}
			int num;
			for (int i = 0; i < locales; i += num)
			{
				num = (int)array[i++];
				if (i + num <= locales)
				{
					CultureInfo cultureInfo = CultureInfo.GetCultureInfo(new string(array, i, num));
					if ((flag && cultureInfo.IsNeutralCulture) || (flag2 && !cultureInfo.IsNeutralCulture))
					{
						list.Add(cultureInfo);
					}
				}
			}
			return list.ToArray();
		}

		// Token: 0x06003576 RID: 13686 RVA: 0x000AD90C File Offset: 0x000ABB0C
		private static string IcuGetConsoleFallbackName(string cultureName)
		{
			return IcuLocaleData.GetConsoleUICulture(cultureName);
		}

		// Token: 0x06003577 RID: 13687 RVA: 0x000AD914 File Offset: 0x000ABB14
		private static bool IsValidCultureName(string subject, out int indexOfUnderscore, out int indexOfExtensions)
		{
			indexOfUnderscore = -1;
			indexOfExtensions = -1;
			if (subject.Length == 0)
			{
				return true;
			}
			if (subject.Length == 1 || subject.Length > 85)
			{
				return false;
			}
			bool flag = false;
			for (int i = 0; i < subject.Length; i++)
			{
				char c = subject[i];
				if (!char.IsAsciiLetterOrDigit(c) && c != '\0')
				{
					if (c != '_' && c != '-')
					{
						return false;
					}
					if (i == 0 || i == subject.Length - 1)
					{
						return false;
					}
					if (subject[i - 1] == '_' || subject[i - 1] == '-')
					{
						return false;
					}
					if (c == '_')
					{
						if (flag)
						{
							return false;
						}
						flag = true;
						indexOfUnderscore = i;
					}
					else
					{
						bool flag2 = indexOfExtensions < 0 && i < subject.Length - 2;
						if (flag2)
						{
							char c2 = subject[i + 1];
							bool flag3 = c2 == 't' || c2 == 'u';
							flag2 = flag3;
						}
						if (flag2 && subject[i + 2] == '-' && (subject[i + 1] == 't' || i >= subject.Length - 6 || subject[i + 3] != 'c' || subject[i + 4] != 'o' || subject[i + 5] != '-'))
						{
							indexOfExtensions = i;
						}
					}
				}
			}
			return true;
		}

		// Token: 0x06003578 RID: 13688 RVA: 0x000ADA58 File Offset: 0x000ABC58
		internal unsafe static string GetLocaleInfoEx(string localeName, uint field)
		{
			char* ptr = stackalloc char[(UIntPtr)1060];
			if (CultureData.GetLocaleInfoEx(localeName, field, ptr, 530) > 0)
			{
				return new string(ptr);
			}
			return null;
		}

		// Token: 0x06003579 RID: 13689 RVA: 0x000ADA88 File Offset: 0x000ABC88
		internal unsafe static int GetLocaleInfoExInt(string localeName, uint field)
		{
			field |= 536870912U;
			int result = 0;
			CultureData.GetLocaleInfoEx(localeName, field, (char*)(&result), 4);
			return result;
		}

		// Token: 0x0600357A RID: 13690 RVA: 0x000ADAAD File Offset: 0x000ABCAD
		internal unsafe static int GetLocaleInfoEx(string lpLocaleName, uint lcType, char* lpLCData, int cchData)
		{
			return Interop.Kernel32.GetLocaleInfoEx(lpLocaleName, lcType, (void*)lpLCData, cchData);
		}

		// Token: 0x0600357B RID: 13691 RVA: 0x000ADAB8 File Offset: 0x000ABCB8
		private string NlsGetLocaleInfo(CultureData.LocaleStringData type)
		{
			return this.NlsGetLocaleInfo(this._sRealName, type);
		}

		// Token: 0x0600357C RID: 13692 RVA: 0x000ADAC8 File Offset: 0x000ABCC8
		private string NlsGetLocaleInfo(string localeName, CultureData.LocaleStringData type)
		{
			return CultureData.GetLocaleInfoFromLCType(localeName, (uint)type, this._bUseOverrides);
		}

		// Token: 0x0600357D RID: 13693 RVA: 0x000ADAE4 File Offset: 0x000ABCE4
		private int NlsGetLocaleInfo(CultureData.LocaleNumberData type)
		{
			uint num = (uint)type;
			if (!this._bUseOverrides)
			{
				num |= 2147483648U;
			}
			return CultureData.GetLocaleInfoExInt(this._sRealName, num);
		}

		// Token: 0x0600357E RID: 13694 RVA: 0x000ADB0F File Offset: 0x000ABD0F
		private int[] NlsGetLocaleInfo(CultureData.LocaleGroupingData type)
		{
			return CultureData.ConvertWin32GroupString(CultureData.GetLocaleInfoFromLCType(this._sRealName, (uint)type, this._bUseOverrides));
		}

		// Token: 0x0600357F RID: 13695 RVA: 0x000ADB28 File Offset: 0x000ABD28
		internal static bool NlsIsEnsurePredefinedLocaleName(string name)
		{
			return CultureData.GetLocaleInfoExInt(name, 125U) != 1;
		}

		// Token: 0x06003580 RID: 13696 RVA: 0x000ADB38 File Offset: 0x000ABD38
		private string NlsGetTimeFormatString()
		{
			return CultureData.ReescapeWin32String(CultureData.GetLocaleInfoFromLCType(this._sRealName, 4099U, this._bUseOverrides));
		}

		// Token: 0x06003581 RID: 13697 RVA: 0x000ADB55 File Offset: 0x000ABD55
		private int NlsGetFirstDayOfWeek()
		{
			return CultureData.ConvertFirstDayOfWeekMonToSun(CultureData.GetLocaleInfoExInt(this._sRealName, 4108U | ((!this._bUseOverrides) ? 2147483648U : 0U)));
		}

		// Token: 0x06003582 RID: 13698 RVA: 0x000ADB80 File Offset: 0x000ABD80
		private unsafe static CultureData NlsGetCultureDataFromRegionName(string regionName)
		{
			CultureData.EnumLocaleData enumLocaleData;
			enumLocaleData.cultureName = null;
			enumLocaleData.regionName = regionName;
			Interop.Kernel32.EnumSystemLocalesEx(ldftn(EnumSystemLocalesProc), '"', &enumLocaleData, IntPtr.Zero);
			if (enumLocaleData.cultureName != null)
			{
				return CultureData.GetCultureData(enumLocaleData.cultureName, true);
			}
			return null;
		}

		// Token: 0x06003583 RID: 13699 RVA: 0x000ADBCC File Offset: 0x000ABDCC
		private string NlsGetLanguageDisplayName(string cultureName)
		{
			CultureInfo userDefaultCulture;
			if (CultureInfo.DefaultThreadCurrentUICulture != null && (userDefaultCulture = CultureInfo.GetUserDefaultCulture()) != null && !CultureInfo.DefaultThreadCurrentUICulture.Name.Equals(userDefaultCulture.Name))
			{
				return this.NativeName;
			}
			return this.NlsGetLocaleInfo(cultureName, CultureData.LocaleStringData.LocalizedDisplayName);
		}

		// Token: 0x06003584 RID: 13700 RVA: 0x000ADC0F File Offset: 0x000ABE0F
		private string NlsGetRegionDisplayName()
		{
			if (CultureInfo.CurrentUICulture.Name.Equals(CultureInfo.UserDefaultUICulture.Name))
			{
				return this.NlsGetLocaleInfo(CultureData.LocaleStringData.LocalizedCountryName);
			}
			return this.NativeCountryName;
		}

		// Token: 0x06003585 RID: 13701 RVA: 0x000ADC3A File Offset: 0x000ABE3A
		private static string GetLocaleInfoFromLCType(string localeName, uint lctype, bool useUserOverride)
		{
			if (!useUserOverride)
			{
				lctype |= 2147483648U;
			}
			return CultureData.GetLocaleInfoEx(localeName, lctype) ?? string.Empty;
		}

		// Token: 0x06003586 RID: 13702 RVA: 0x000ADC58 File Offset: 0x000ABE58
		[return: NotNullIfNotNull("str")]
		internal static string ReescapeWin32String(string str)
		{
			if (str == null)
			{
				return null;
			}
			StringBuilder stringBuilder = null;
			bool flag = false;
			int i = 0;
			while (i < str.Length)
			{
				if (str[i] == '\'')
				{
					if (!flag)
					{
						flag = true;
						goto IL_91;
					}
					if (i + 1 >= str.Length || str[i + 1] != '\'')
					{
						flag = false;
						goto IL_91;
					}
					if (stringBuilder == null)
					{
						stringBuilder = new StringBuilder(str, 0, i, str.Length * 2);
					}
					stringBuilder.Append("\\'");
					i++;
				}
				else
				{
					if (str[i] != '\\')
					{
						goto IL_91;
					}
					if (stringBuilder == null)
					{
						stringBuilder = new StringBuilder(str, 0, i, str.Length * 2);
					}
					stringBuilder.Append("\\\\");
				}
				IL_A2:
				i++;
				continue;
				IL_91:
				if (stringBuilder != null)
				{
					stringBuilder.Append(str[i]);
					goto IL_A2;
				}
				goto IL_A2;
			}
			if (stringBuilder == null)
			{
				return str;
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06003587 RID: 13703 RVA: 0x000ADD24 File Offset: 0x000ABF24
		[return: NotNullIfNotNull("array")]
		internal static string[] ReescapeWin32Strings(string[] array)
		{
			if (array != null)
			{
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = CultureData.ReescapeWin32String(array[i]);
				}
			}
			return array;
		}

		// Token: 0x06003588 RID: 13704 RVA: 0x000ADD50 File Offset: 0x000ABF50
		private static int[] ConvertWin32GroupString(string win32Str)
		{
			if (string.IsNullOrEmpty(win32Str))
			{
				return new int[]
				{
					3
				};
			}
			if (win32Str.StartsWith('0'))
			{
				return new int[1];
			}
			int[] array;
			if (win32Str.EndsWith('0'))
			{
				array = new int[win32Str.Length / 2];
			}
			else
			{
				array = new int[win32Str.Length / 2 + 2];
				int[] array2 = array;
				array2[array2.Length - 1] = 0;
			}
			int num = 0;
			int num2 = 0;
			while (num < win32Str.Length && num2 < array.Length)
			{
				if (!char.IsBetween(win32Str[num], '1', '9'))
				{
					return new int[]
					{
						3
					};
				}
				array[num2] = (int)(win32Str[num] - '0');
				num += 2;
				num2++;
			}
			return array;
		}

		// Token: 0x06003589 RID: 13705 RVA: 0x000ADDFB File Offset: 0x000ABFFB
		private static int ConvertFirstDayOfWeekMonToSun(int iTemp)
		{
			iTemp++;
			if (iTemp > 6)
			{
				iTemp = 0;
			}
			return iTemp;
		}

		// Token: 0x0600358A RID: 13706 RVA: 0x000ADE0C File Offset: 0x000AC00C
		[UnmanagedCallersOnly]
		private unsafe static Interop.BOOL EnumSystemLocalesProc(char* lpLocaleString, uint flags, void* contextHandle)
		{
			Interop.BOOL result;
			try
			{
				string text = new string(lpLocaleString);
				string localeInfoEx = CultureData.GetLocaleInfoEx(text, 90U);
				if (localeInfoEx != null && localeInfoEx.Equals(((CultureData.EnumLocaleData*)contextHandle)->regionName, StringComparison.OrdinalIgnoreCase))
				{
					((CultureData.EnumLocaleData*)contextHandle)->cultureName = text;
					result = Interop.BOOL.FALSE;
				}
				else
				{
					result = Interop.BOOL.TRUE;
				}
			}
			catch (Exception)
			{
				result = Interop.BOOL.FALSE;
			}
			return result;
		}

		// Token: 0x0600358B RID: 13707 RVA: 0x000ADE64 File Offset: 0x000AC064
		[UnmanagedCallersOnly]
		private unsafe static Interop.BOOL EnumAllSystemLocalesProc(char* lpLocaleString, uint flags, void* contextHandle)
		{
			Interop.BOOL result;
			try
			{
				((CultureData.EnumData*)contextHandle)->strings.Add(new string(lpLocaleString));
				result = Interop.BOOL.TRUE;
			}
			catch (Exception)
			{
				result = Interop.BOOL.FALSE;
			}
			return result;
		}

		// Token: 0x0600358C RID: 13708 RVA: 0x000ADE9C File Offset: 0x000AC09C
		[UnmanagedCallersOnly]
		private unsafe static Interop.BOOL EnumTimeCallback(char* lpTimeFormatString, void* lParam)
		{
			Interop.BOOL result;
			try
			{
				((CultureData.EnumData*)lParam)->strings.Add(new string(lpTimeFormatString));
				result = Interop.BOOL.TRUE;
			}
			catch (Exception)
			{
				result = Interop.BOOL.FALSE;
			}
			return result;
		}

		// Token: 0x0600358D RID: 13709 RVA: 0x000ADED4 File Offset: 0x000AC0D4
		private unsafe static string[] nativeEnumTimeFormats(string localeName, uint dwFlags, bool useUserOverride)
		{
			CultureData.EnumData enumData = default(CultureData.EnumData);
			enumData.strings = new List<string>();
			Interop.Kernel32.EnumTimeFormatsEx(ldftn(EnumTimeCallback), localeName != null, (Interop.BOOL)dwFlags, (char*)(&enumData));
			if (enumData.strings.Count > 0)
			{
				string[] array = enumData.strings.ToArray();
				if (!useUserOverride && enumData.strings.Count > 1)
				{
					uint lctype = (dwFlags == 2U) ? 121U : 4099U;
					string localeInfoFromLCType = CultureData.GetLocaleInfoFromLCType(localeName, lctype, useUserOverride);
					if (localeInfoFromLCType != "")
					{
						string text = array[0];
						if (localeInfoFromLCType != text)
						{
							array[0] = array[1];
							array[1] = text;
						}
					}
				}
				return array;
			}
			return null;
		}

		// Token: 0x0600358E RID: 13710 RVA: 0x000ADF72 File Offset: 0x000AC172
		private static int NlsLocaleNameToLCID(string cultureName)
		{
			return Interop.Kernel32.LocaleNameToLCID(cultureName, 134217728U);
		}

		// Token: 0x0600358F RID: 13711 RVA: 0x000ADF7F File Offset: 0x000AC17F
		private string NlsGetThreeLetterWindowsLanguageName(string cultureName)
		{
			return this.NlsGetLocaleInfo(cultureName, CultureData.LocaleStringData.AbbreviatedWindowsLanguageName);
		}

		// Token: 0x06003590 RID: 13712 RVA: 0x000ADF8C File Offset: 0x000AC18C
		private unsafe static CultureInfo[] NlsEnumCultures(CultureTypes types)
		{
			uint num = 0U;
			if ((types & (CultureTypes.InstalledWin32Cultures | CultureTypes.ReplacementCultures | CultureTypes.FrameworkCultures)) != (CultureTypes)0)
			{
				num |= 48U;
			}
			if ((types & CultureTypes.NeutralCultures) != (CultureTypes)0)
			{
				num |= 16U;
			}
			if ((types & CultureTypes.SpecificCultures) != (CultureTypes)0)
			{
				num |= 32U;
			}
			if ((types & CultureTypes.UserCustomCulture) != (CultureTypes)0)
			{
				num |= 2U;
			}
			if ((types & CultureTypes.ReplacementCultures) != (CultureTypes)0)
			{
				num |= 2U;
			}
			CultureData.EnumData enumData = default(CultureData.EnumData);
			enumData.strings = new List<string>();
			Interop.Kernel32.EnumSystemLocalesEx(ldftn(EnumAllSystemLocalesProc), (char)num, &enumData, IntPtr.Zero);
			CultureInfo[] array = new CultureInfo[enumData.strings.Count];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = new CultureInfo(enumData.strings[i]);
			}
			return array;
		}

		// Token: 0x06003591 RID: 13713 RVA: 0x000AE02A File Offset: 0x000AC22A
		private string NlsGetConsoleFallbackName(string cultureName)
		{
			return this.NlsGetLocaleInfo(cultureName, CultureData.LocaleStringData.ConsoleFallbackName);
		}

		// Token: 0x170009D2 RID: 2514
		// (get) Token: 0x06003592 RID: 13714 RVA: 0x000AE038 File Offset: 0x000AC238
		internal unsafe bool NlsIsReplacementCulture
		{
			get
			{
				CultureData.EnumData enumData = default(CultureData.EnumData);
				enumData.strings = new List<string>();
				Interop.Kernel32.EnumSystemLocalesEx(ldftn(EnumAllSystemLocalesProc), '\b', &enumData, IntPtr.Zero);
				for (int i = 0; i < enumData.strings.Count; i++)
				{
					if (string.Equals(enumData.strings[i], this._sRealName, StringComparison.OrdinalIgnoreCase))
					{
						return true;
					}
				}
				return false;
			}
		}

		// Token: 0x06003593 RID: 13715 RVA: 0x000AE0A4 File Offset: 0x000AC2A4
		private unsafe bool InitCultureDataCore()
		{
			char* ptr = stackalloc char[(UIntPtr)170];
			if (!GlobalizationMode.UseNls)
			{
				return this.InitIcuCultureDataCore() && CultureData.GetLocaleInfoEx(this._sRealName, 92U, ptr, 85) != 0;
			}
			string sRealName = this._sRealName;
			int num = CultureData.GetLocaleInfoEx(sRealName, 92U, ptr, 85);
			if (num == 0)
			{
				return false;
			}
			this._sRealName = new string(ptr, 0, num - 1);
			sRealName = this._sRealName;
			if (CultureData.GetLocaleInfoEx(sRealName, 536871025U, ptr, 2) == 0)
			{
				return false;
			}
			this._bNeutral = (*(uint*)ptr > 0U);
			this._sWindowsName = sRealName;
			if (this._bNeutral)
			{
				this._sName = sRealName;
				num = Interop.Kernel32.ResolveLocaleName(sRealName, ptr, 85);
				if (num < 1)
				{
					return false;
				}
				this._sSpecificCulture = new string(ptr, 0, num - 1);
			}
			else
			{
				this._sSpecificCulture = sRealName;
				this._sName = sRealName;
				if (CultureData.GetLocaleInfoEx(sRealName, 536870913U, ptr, 2) == 0)
				{
					return false;
				}
				this._iLanguage = *(int*)ptr;
				if (!CultureData.IsCustomCultureId(this._iLanguage))
				{
					int num2 = sRealName.IndexOf('_');
					if (num2 > 0)
					{
						this._sName = sRealName.Substring(0, num2);
					}
				}
			}
			return true;
		}

		// Token: 0x06003594 RID: 13716 RVA: 0x000AE1B6 File Offset: 0x000AC3B6
		private void InitUserOverride(bool useUserOverride)
		{
			this._bUseOverrides = (useUserOverride && this._sWindowsName == CultureInfo.UserDefaultLocaleName);
		}

		// Token: 0x06003595 RID: 13717 RVA: 0x000AE1D4 File Offset: 0x000AC3D4
		internal unsafe static CultureData GetCurrentRegionData()
		{
			Span<char> span = new Span<char>(stackalloc byte[(UIntPtr)20], 10);
			int userGeoID = Interop.Kernel32.GetUserGeoID(16);
			if (userGeoID != -1)
			{
				int num;
				fixed (char* pinnableReference = span.GetPinnableReference())
				{
					char* lpGeoData = pinnableReference;
					num = Interop.Kernel32.GetGeoInfo(userGeoID, 4, lpGeoData, span.Length, 0);
				}
				if (num != 0)
				{
					num -= ((*span[num - 1] == '\0') ? 1 : 0);
					CultureData cultureDataForRegion = CultureData.GetCultureDataForRegion(span.Slice(0, num).ToString(), true);
					if (cultureDataForRegion != null)
					{
						return cultureDataForRegion;
					}
				}
			}
			return CultureInfo.CurrentCulture._cultureData;
		}

		// Token: 0x06003596 RID: 13718 RVA: 0x000AE264 File Offset: 0x000AC464
		private unsafe static string LCIDToLocaleName(int culture)
		{
			if (culture == 4096)
			{
				return null;
			}
			char* ptr = stackalloc char[(UIntPtr)172];
			if (Interop.Kernel32.LCIDToLocaleName(culture, ptr, 86, 134217728U) > 0)
			{
				return new string(ptr);
			}
			return null;
		}

		// Token: 0x06003597 RID: 13719 RVA: 0x000AE2A0 File Offset: 0x000AC4A0
		private string[] GetTimeFormatsCore(bool shortFormat)
		{
			if (GlobalizationMode.UseNls)
			{
				return CultureData.ReescapeWin32Strings(CultureData.nativeEnumTimeFormats(this._sWindowsName, shortFormat ? 2U : 0U, this._bUseOverrides));
			}
			string text = this.IcuGetTimeFormatString(shortFormat);
			if (!this._bUseOverrides)
			{
				return new string[]
				{
					text
				};
			}
			string localeInfoFromLCType = CultureData.GetLocaleInfoFromLCType(this._sWindowsName, shortFormat ? 121U : 4099U, true);
			if (!(localeInfoFromLCType != text))
			{
				return new string[]
				{
					localeInfoFromLCType
				};
			}
			return new string[]
			{
				localeInfoFromLCType,
				text
			};
		}

		// Token: 0x06003598 RID: 13720 RVA: 0x000AE328 File Offset: 0x000AC528
		private int GetAnsiCodePage(string _)
		{
			return this.NlsGetLocaleInfo(CultureData.LocaleNumberData.AnsiCodePage);
		}

		// Token: 0x06003599 RID: 13721 RVA: 0x000AE335 File Offset: 0x000AC535
		private int GetOemCodePage(string _)
		{
			return this.NlsGetLocaleInfo(CultureData.LocaleNumberData.OemCodePage);
		}

		// Token: 0x0600359A RID: 13722 RVA: 0x000AE33F File Offset: 0x000AC53F
		private int GetMacCodePage(string _)
		{
			return this.NlsGetLocaleInfo(CultureData.LocaleNumberData.MacCodePage);
		}

		// Token: 0x0600359B RID: 13723 RVA: 0x000AE34C File Offset: 0x000AC54C
		private int GetEbcdicCodePage(string _)
		{
			return this.NlsGetLocaleInfo(CultureData.LocaleNumberData.EbcdicCodePage);
		}

		// Token: 0x170009D3 RID: 2515
		// (get) Token: 0x0600359C RID: 13724 RVA: 0x000AE359 File Offset: 0x000AC559
		private bool ShouldUseUserOverrideNlsData
		{
			get
			{
				return GlobalizationMode.UseNls || this._bUseOverrides;
			}
		}

		// Token: 0x0600359F RID: 13727 RVA: 0x000AE3E0 File Offset: 0x000AC5E0
		[CompilerGenerated]
		internal unsafe static bool <ConvertIcuTimeFormatString>g__HandleQuoteLiteral|264_0(ReadOnlySpan<char> icuFormatString, ref int i, Span<char> result, ref int resultPos)
		{
			int num;
			if (i + 1 < icuFormatString.Length && *icuFormatString[i + 1] == 39)
			{
				num = resultPos;
				resultPos = num + 1;
				*result[num] = '\\';
				num = resultPos;
				resultPos = num + 1;
				*result[num] = '\'';
				i++;
				return true;
			}
			num = resultPos;
			resultPos = num + 1;
			*result[num] = '\'';
			return false;
		}

		// Token: 0x0400095D RID: 2397
		private string _sRealName;

		// Token: 0x0400095E RID: 2398
		private string _sWindowsName;

		// Token: 0x0400095F RID: 2399
		private string _sName;

		// Token: 0x04000960 RID: 2400
		private string _sParent;

		// Token: 0x04000961 RID: 2401
		private string _sEnglishDisplayName;

		// Token: 0x04000962 RID: 2402
		private string _sNativeDisplayName;

		// Token: 0x04000963 RID: 2403
		private string _sSpecificCulture;

		// Token: 0x04000964 RID: 2404
		private string _sISO639Language;

		// Token: 0x04000965 RID: 2405
		private string _sISO639Language2;

		// Token: 0x04000966 RID: 2406
		private string _sEnglishLanguage;

		// Token: 0x04000967 RID: 2407
		private string _sNativeLanguage;

		// Token: 0x04000968 RID: 2408
		private string _sAbbrevLang;

		// Token: 0x04000969 RID: 2409
		private string _sConsoleFallbackName;

		// Token: 0x0400096A RID: 2410
		private int _iInputLanguageHandle = -1;

		// Token: 0x0400096B RID: 2411
		private string _sRegionName;

		// Token: 0x0400096C RID: 2412
		private string _sLocalizedCountry;

		// Token: 0x0400096D RID: 2413
		private string _sEnglishCountry;

		// Token: 0x0400096E RID: 2414
		private string _sNativeCountry;

		// Token: 0x0400096F RID: 2415
		private string _sISO3166CountryName;

		// Token: 0x04000970 RID: 2416
		private string _sISO3166CountryName2;

		// Token: 0x04000971 RID: 2417
		private int _iGeoId = -1;

		// Token: 0x04000972 RID: 2418
		private string _sPositiveSign;

		// Token: 0x04000973 RID: 2419
		private string _sNegativeSign;

		// Token: 0x04000974 RID: 2420
		private int _iDigits;

		// Token: 0x04000975 RID: 2421
		private int _iNegativeNumber;

		// Token: 0x04000976 RID: 2422
		private int[] _waGrouping;

		// Token: 0x04000977 RID: 2423
		private string _sDecimalSeparator;

		// Token: 0x04000978 RID: 2424
		private string _sThousandSeparator;

		// Token: 0x04000979 RID: 2425
		private string _sNaN;

		// Token: 0x0400097A RID: 2426
		private string _sPositiveInfinity;

		// Token: 0x0400097B RID: 2427
		private string _sNegativeInfinity;

		// Token: 0x0400097C RID: 2428
		private int _iNegativePercent = -1;

		// Token: 0x0400097D RID: 2429
		private int _iPositivePercent = -1;

		// Token: 0x0400097E RID: 2430
		private string _sPercent;

		// Token: 0x0400097F RID: 2431
		private string _sPerMille;

		// Token: 0x04000980 RID: 2432
		private string _sCurrency;

		// Token: 0x04000981 RID: 2433
		private string _sIntlMonetarySymbol;

		// Token: 0x04000982 RID: 2434
		private string _sEnglishCurrency;

		// Token: 0x04000983 RID: 2435
		private string _sNativeCurrency;

		// Token: 0x04000984 RID: 2436
		private int _iCurrencyDigits;

		// Token: 0x04000985 RID: 2437
		private int _iCurrency;

		// Token: 0x04000986 RID: 2438
		private int _iNegativeCurrency;

		// Token: 0x04000987 RID: 2439
		private int[] _waMonetaryGrouping;

		// Token: 0x04000988 RID: 2440
		private string _sMonetaryDecimal;

		// Token: 0x04000989 RID: 2441
		private string _sMonetaryThousand;

		// Token: 0x0400098A RID: 2442
		private int _iMeasure = -1;

		// Token: 0x0400098B RID: 2443
		private string _sListSeparator;

		// Token: 0x0400098C RID: 2444
		private string _sAM1159;

		// Token: 0x0400098D RID: 2445
		private string _sPM2359;

		// Token: 0x0400098E RID: 2446
		private string _sTimeSeparator;

		// Token: 0x0400098F RID: 2447
		private string[] _saLongTimes;

		// Token: 0x04000990 RID: 2448
		private string[] _saShortTimes;

		// Token: 0x04000991 RID: 2449
		private int _iFirstDayOfWeek = -1;

		// Token: 0x04000992 RID: 2450
		private int _iFirstWeekOfYear = -1;

		// Token: 0x04000993 RID: 2451
		private CalendarId[] _waCalendars;

		// Token: 0x04000994 RID: 2452
		private CalendarData[] _calendars;

		// Token: 0x04000995 RID: 2453
		private int _iReadingLayout = -1;

		// Token: 0x04000996 RID: 2454
		private int _iDefaultAnsiCodePage = -1;

		// Token: 0x04000997 RID: 2455
		private int _iDefaultOemCodePage = -1;

		// Token: 0x04000998 RID: 2456
		private int _iDefaultMacCodePage = -1;

		// Token: 0x04000999 RID: 2457
		private int _iDefaultEbcdicCodePage = -1;

		// Token: 0x0400099A RID: 2458
		private int _iLanguage;

		// Token: 0x0400099B RID: 2459
		private bool _bUseOverrides;

		// Token: 0x0400099C RID: 2460
		private bool _bUseOverridesUserSetting;

		// Token: 0x0400099D RID: 2461
		private bool _bNeutral;

		// Token: 0x0400099E RID: 2462
		private static volatile Dictionary<string, CultureData> s_cachedRegions;

		// Token: 0x0400099F RID: 2463
		private static Dictionary<string, string> s_regionNames;

		// Token: 0x040009A0 RID: 2464
		private static CultureData s_Invariant;

		// Token: 0x040009A1 RID: 2465
		private static volatile Dictionary<string, CultureData> s_cachedCultures;

		// Token: 0x040009A2 RID: 2466
		private static readonly object s_lock = new object();

		// Token: 0x020002D3 RID: 723
		private enum LocaleStringData : uint
		{
			// Token: 0x040009A4 RID: 2468
			LocalizedDisplayName = 2U,
			// Token: 0x040009A5 RID: 2469
			EnglishDisplayName = 114U,
			// Token: 0x040009A6 RID: 2470
			NativeDisplayName,
			// Token: 0x040009A7 RID: 2471
			LocalizedLanguageName = 111U,
			// Token: 0x040009A8 RID: 2472
			EnglishLanguageName = 4097U,
			// Token: 0x040009A9 RID: 2473
			NativeLanguageName = 4U,
			// Token: 0x040009AA RID: 2474
			LocalizedCountryName = 6U,
			// Token: 0x040009AB RID: 2475
			EnglishCountryName = 4098U,
			// Token: 0x040009AC RID: 2476
			NativeCountryName = 8U,
			// Token: 0x040009AD RID: 2477
			AbbreviatedWindowsLanguageName = 3U,
			// Token: 0x040009AE RID: 2478
			ListSeparator = 12U,
			// Token: 0x040009AF RID: 2479
			DecimalSeparator = 14U,
			// Token: 0x040009B0 RID: 2480
			ThousandSeparator,
			// Token: 0x040009B1 RID: 2481
			Digits = 19U,
			// Token: 0x040009B2 RID: 2482
			MonetarySymbol,
			// Token: 0x040009B3 RID: 2483
			CurrencyEnglishName = 4103U,
			// Token: 0x040009B4 RID: 2484
			CurrencyNativeName,
			// Token: 0x040009B5 RID: 2485
			Iso4217MonetarySymbol = 21U,
			// Token: 0x040009B6 RID: 2486
			MonetaryDecimalSeparator,
			// Token: 0x040009B7 RID: 2487
			MonetaryThousandSeparator,
			// Token: 0x040009B8 RID: 2488
			AMDesignator = 40U,
			// Token: 0x040009B9 RID: 2489
			PMDesignator,
			// Token: 0x040009BA RID: 2490
			PositiveSign = 80U,
			// Token: 0x040009BB RID: 2491
			NegativeSign,
			// Token: 0x040009BC RID: 2492
			Iso639LanguageTwoLetterName = 89U,
			// Token: 0x040009BD RID: 2493
			Iso639LanguageThreeLetterName = 103U,
			// Token: 0x040009BE RID: 2494
			Iso639LanguageName = 89U,
			// Token: 0x040009BF RID: 2495
			Iso3166CountryName,
			// Token: 0x040009C0 RID: 2496
			Iso3166CountryName2 = 104U,
			// Token: 0x040009C1 RID: 2497
			NaNSymbol,
			// Token: 0x040009C2 RID: 2498
			PositiveInfinitySymbol,
			// Token: 0x040009C3 RID: 2499
			NegativeInfinitySymbol,
			// Token: 0x040009C4 RID: 2500
			ParentName = 109U,
			// Token: 0x040009C5 RID: 2501
			ConsoleFallbackName,
			// Token: 0x040009C6 RID: 2502
			PercentSymbol = 118U,
			// Token: 0x040009C7 RID: 2503
			PerMilleSymbol
		}

		// Token: 0x020002D4 RID: 724
		private enum LocaleGroupingData : uint
		{
			// Token: 0x040009C9 RID: 2505
			Digit = 16U,
			// Token: 0x040009CA RID: 2506
			Monetary = 24U
		}

		// Token: 0x020002D5 RID: 725
		private enum LocaleNumberData : uint
		{
			// Token: 0x040009CC RID: 2508
			LanguageId = 1U,
			// Token: 0x040009CD RID: 2509
			GeoId = 91U,
			// Token: 0x040009CE RID: 2510
			DigitSubstitution = 4116U,
			// Token: 0x040009CF RID: 2511
			MeasurementSystem = 13U,
			// Token: 0x040009D0 RID: 2512
			FractionalDigitsCount = 17U,
			// Token: 0x040009D1 RID: 2513
			NegativeNumberFormat = 4112U,
			// Token: 0x040009D2 RID: 2514
			MonetaryFractionalDigitsCount = 25U,
			// Token: 0x040009D3 RID: 2515
			PositiveMonetaryNumberFormat = 27U,
			// Token: 0x040009D4 RID: 2516
			NegativeMonetaryNumberFormat,
			// Token: 0x040009D5 RID: 2517
			CalendarType = 4105U,
			// Token: 0x040009D6 RID: 2518
			FirstDayOfWeek = 4108U,
			// Token: 0x040009D7 RID: 2519
			FirstWeekOfYear,
			// Token: 0x040009D8 RID: 2520
			ReadingLayout = 112U,
			// Token: 0x040009D9 RID: 2521
			NegativePercentFormat = 116U,
			// Token: 0x040009DA RID: 2522
			PositivePercentFormat,
			// Token: 0x040009DB RID: 2523
			OemCodePage = 11U,
			// Token: 0x040009DC RID: 2524
			AnsiCodePage = 4100U,
			// Token: 0x040009DD RID: 2525
			MacCodePage = 4113U,
			// Token: 0x040009DE RID: 2526
			EbcdicCodePage
		}

		// Token: 0x020002D6 RID: 726
		private struct EnumLocaleData
		{
			// Token: 0x040009DF RID: 2527
			public string regionName;

			// Token: 0x040009E0 RID: 2528
			public string cultureName;
		}

		// Token: 0x020002D7 RID: 727
		private struct EnumData
		{
			// Token: 0x040009E1 RID: 2529
			public List<string> strings;
		}
	}
}
