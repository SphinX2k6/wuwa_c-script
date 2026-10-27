using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define;
using CSharpScript.Launcher.Ui;
using UnrealEngine;

namespace CSharpScript.Launcher.Util
{
	// Token: 0x0200006E RID: 110
	[NullableContext(1)]
	[Nullable(0)]
	public class LauncherLanguageLib : Singleton
	{
		// Token: 0x060002E3 RID: 739 RVA: 0x0000EFA8 File Offset: 0x0000D1A8
		protected override bool OnInit()
		{
			foreach (LaunchLangDefine launchLangDefine in this.LanguageList)
			{
				this.LanguageTypeMap[launchLangDefine.LanguageType] = launchLangDefine;
				this.LanguageCodeMap[launchLangDefine.LanguageCode] = launchLangDefine;
			}
			return true;
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060002E4 RID: 740 RVA: 0x0000F01C File Offset: 0x0000D21C
		// (set) Token: 0x060002E5 RID: 741 RVA: 0x0000F024 File Offset: 0x0000D224
		[Nullable(2)]
		public string PackageLanguage
		{
			[NullableContext(2)]
			get
			{
				return this.PackageLanguageInternal;
			}
			[NullableContext(2)]
			private set
			{
				this.PackageLanguageInternal = value;
				ULGUIFontData.SetAllFontCurrentCulture(this.LanguageCultureMap[value]);
			}
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x0000F03E File Offset: 0x0000D23E
		public string GetDefaultCulture(string currentCulture)
		{
			if (currentCulture.Contains("zh"))
			{
				return "zh-Hans";
			}
			return "en";
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x0000F058 File Offset: 0x0000D258
		[NullableContext(2)]
		private Dictionary<int, double> LoadPlayMenuInfo()
		{
			int? global = LauncherStorageLib.Instance.GetGlobal<int?>(ELauncherStorageGlobalKey.TextLanguage, null);
			int? global2 = LauncherStorageLib.Instance.GetGlobal<int?>(ELauncherStorageGlobalKey.VoiceLanguage, null);
			if (global != null && global2 != null)
			{
				Dictionary<int, double> dictionary = new Dictionary<int, double>();
				dictionary[51] = (double)global.Value;
				dictionary[52] = (double)global2.Value;
				return dictionary;
			}
			Dictionary<int, double> global3 = LauncherStorageLib.Instance.GetGlobal<Dictionary<int, double>>(ELauncherStorageGlobalKey.MenuData, null);
			if (global3 == null)
			{
				string global4 = LauncherStorageLib.Instance.GetGlobal<string>(ELauncherStorageGlobalKey.PlayMenuInfo, string.Empty);
				if (!string.IsNullOrEmpty(global4))
				{
					Dictionary<string, double> dictionary2 = LauncherJson.Parse<Dictionary<string, double>>(global4, null);
					if (dictionary2 != null)
					{
						return LaunchUtil.ObjToMap<string, double>(dictionary2);
					}
				}
			}
			return global3;
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x0000F110 File Offset: 0x0000D310
		public unsafe void Initialize(bool bIsPlayerInEditor)
		{
			if (this.IsInit)
			{
				return;
			}
			this.IsInit = true;
			Dictionary<int, double> dictionary = this.LoadPlayMenuInfo();
			bool flag = dictionary != null;
			if (flag || bIsPlayerInEditor || UKuroLauncherLibrary.GetAppInternalUseType() == "Publication")
			{
				Dictionary<int, double> dictionary2;
				if (flag)
				{
					dictionary2 = dictionary;
				}
				else
				{
					dictionary2 = new Dictionary<int, double>();
					LauncherMenuConfig menuConfigByFunctionId = LauncherConfigLib.Instance.GetMenuConfigByFunctionId(51);
					dictionary2[51] = (double)((menuConfigByFunctionId != null) ? menuConfigByFunctionId.OptionsDefault : 0);
					LauncherMenuConfig menuConfigByFunctionId2 = LauncherConfigLib.Instance.GetMenuConfigByFunctionId(52);
					dictionary2[52] = (double)((menuConfigByFunctionId2 != null) ? menuConfigByFunctionId2.OptionsDefault : 0);
				}
				double num;
				LaunchLangDefine launchLangDefine = dictionary2.TryGetValue(51, out num) ? this.GetLanguageDefineByType((int)num) : null;
				this.PackageLanguage = ((launchLangDefine != null) ? launchLangDefine.LanguageCode : "en");
				double num2;
				LaunchLangDefine launchLangDefine2 = dictionary2.TryGetValue(52, out num2) ? this.GetLanguageDefineByType((int)num2) : null;
				this.PackageAudioLanguage = ((launchLangDefine2 != null) ? launchLangDefine2.AudioCode : "en");
				return;
			}
			string text = UKismetSystemLibrary.GetDefaultLanguage().ToString();
			string defaultCulture = this.GetDefaultCulture(text);
			TArray<string> tarray = new TArray<string>();
			for (int i = 0; i < this.AVAILABLE_LANGUAGES.Length; i++)
			{
				tarray.Add(this.AVAILABLE_LANGUAGES[i]);
			}
			string text2 = UKismetInternationalizationLibrary.GetSuitableCulture(tarray, text, defaultCulture).ToString();
			bool flag2 = LauncherConfigLib.Instance.IsLanguageValid(text2);
			text2 = (flag2 ? text2 : this.GetDefaultCulture(text2));
			if (!flag2)
			{
				LauncherLog instance = LauncherLog.Instance;
				string message = "当前语种表格配置不允许生效";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("targetLanguage", text2);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("currentCulture", text);
				instance.Info(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			LauncherLog instance2 = LauncherLog.Instance;
			string message2 = "从本地获取语言配置失败，使用平台的配置";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("targetLanguage", text2);
			instance2.Warn(message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			LaunchLangDefine languageDefineByCode = this.GetLanguageDefineByCode(text2);
			if (languageDefineByCode == null)
			{
				this.PackageLanguage = "en";
				this.PackageAudioLanguage = "zh";
				return;
			}
			this.PackageLanguage = languageDefineByCode.LanguageCode;
			this.PackageAudioLanguage = languageDefineByCode.AudioCode;
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x0000F340 File Offset: 0x0000D540
		[NullableContext(2)]
		public string GetPackageLanguage()
		{
			return this.PackageLanguageInternal;
		}

		// Token: 0x060002EA RID: 746 RVA: 0x0000F348 File Offset: 0x0000D548
		public void SetPackageLanguage(string language)
		{
			this.PackageLanguageInternal = language;
		}

		// Token: 0x060002EB RID: 747 RVA: 0x0000F351 File Offset: 0x0000D551
		[NullableContext(2)]
		public string GetPackageAudioLanguage()
		{
			return this.PackageAudioLanguage;
		}

		// Token: 0x060002EC RID: 748 RVA: 0x0000F359 File Offset: 0x0000D559
		public IReadOnlyList<LaunchLangDefine> GetAllLanguageDefines()
		{
			return this.LanguageList;
		}

		// Token: 0x060002ED RID: 749 RVA: 0x0000F364 File Offset: 0x0000D564
		[NullableContext(2)]
		public LaunchLangDefine GetLanguageDefineByType(int type)
		{
			LaunchLangDefine result;
			if (!this.LanguageTypeMap.TryGetValue(type, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x060002EE RID: 750 RVA: 0x0000F384 File Offset: 0x0000D584
		[return: Nullable(2)]
		public LaunchLangDefine GetLanguageDefineByCode(string code)
		{
			LaunchLangDefine result;
			if (!this.LanguageCodeMap.TryGetValue(code, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x060002EF RID: 751 RVA: 0x0000F3A4 File Offset: 0x0000D5A4
		public List<string> GetUsedAudioCodes()
		{
			HashSet<string> hashSet = new HashSet<string>();
			string packageAudioLanguage = this.GetPackageAudioLanguage();
			if (packageAudioLanguage != null)
			{
				hashSet.Add(packageAudioLanguage);
			}
			HashSet<string> hashSet2 = new HashSet<string>();
			foreach (LaunchLangDefine launchLangDefine in this.LanguageList)
			{
				if (!hashSet2.Contains(launchLangDefine.AudioCode))
				{
					hashSet2.Add(launchLangDefine.AudioCode);
					string key = "UseLanguage_" + launchLangDefine.AudioCode;
					string deviceSavedString = LauncherStorageLib.Instance.GetDeviceSavedString(key, "");
					if (!string.IsNullOrEmpty(deviceSavedString) && deviceSavedString.Trim().Length > 0)
					{
						hashSet.Add(launchLangDefine.AudioCode);
					}
				}
			}
			List<string> list = new List<string>(hashSet);
			LauncherLog instance = LauncherLog.Instance;
			string message = "GetUsedAudioCodes";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("usedAudioCodes", string.Join(",", list));
			instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return list;
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060002F0 RID: 752 RVA: 0x0000F4B0 File Offset: 0x0000D6B0
		public static LauncherLanguageLib Instance
		{
			get
			{
				if (LauncherLanguageLib._instance == null)
				{
					LauncherLanguageLib._instance = new LauncherLanguageLib();
					LauncherLanguageLib._instance.OnInit();
				}
				return LauncherLanguageLib._instance;
			}
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x0000F4D3 File Offset: 0x0000D6D3
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x0000F4D5 File Offset: 0x0000D6D5
		public static void ResetStaticDefaultValue()
		{
			LauncherLanguageLib instance = LauncherLanguageLib._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			LauncherLanguageLib._instance = null;
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x0000F4EE File Offset: 0x0000D6EE
		static LauncherLanguageLib()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LauncherLanguageLib.CreateStaticDefaultValue), new Action(LauncherLanguageLib.ResetStaticDefaultValue));
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x0000F510 File Offset: 0x0000D710
		public LauncherLanguageLib()
		{
			Dictionary<string, Culture> dictionary = new Dictionary<string, Culture>();
			dictionary["zh-Hans"] = Culture.zh_Hans;
			dictionary["en"] = Culture.en;
			dictionary["ja"] = Culture.ja;
			dictionary["ko"] = Culture.ko;
			dictionary["ru"] = Culture.ru;
			dictionary["zh-Hant"] = Culture.zh_Hant;
			dictionary["de"] = Culture.de;
			dictionary["es"] = Culture.es;
			dictionary["pt"] = Culture.pt;
			dictionary["id"] = Culture.id;
			dictionary["fr"] = Culture.fr;
			dictionary["vi"] = Culture.vi;
			dictionary["th"] = Culture.th;
			this.LanguageCultureMap = dictionary;
			this.LanguageTypeMap = new Dictionary<int, LaunchLangDefine>();
			this.LanguageCodeMap = new Dictionary<string, LaunchLangDefine>();
			base..ctor();
		}

		// Token: 0x040001D2 RID: 466
		private const int TEXTLANGUAGE = 51;

		// Token: 0x040001D3 RID: 467
		private const int VOICELANGUAGE = 52;

		// Token: 0x040001D4 RID: 468
		private const string CHS = "zh-Hans";

		// Token: 0x040001D5 RID: 469
		private const string CHT = "zh-Hant";

		// Token: 0x040001D6 RID: 470
		private const string CHINESE_ISO639_1 = "zh";

		// Token: 0x040001D7 RID: 471
		public const string ENGLISH_ISO639_1 = "en";

		// Token: 0x040001D8 RID: 472
		private const string JAPANESE_ISO639_1 = "ja";

		// Token: 0x040001D9 RID: 473
		public const string KOREAN_ISO639_1 = "ko";

		// Token: 0x040001DA RID: 474
		private const string RUSSIA_ISO639_1 = "ru";

		// Token: 0x040001DB RID: 475
		private const string GERMANY_ISO639_1 = "de";

		// Token: 0x040001DC RID: 476
		private const string SPAIN_ISO639_1 = "es";

		// Token: 0x040001DD RID: 477
		private const string PORTUGAL_ISO639_1 = "pt";

		// Token: 0x040001DE RID: 478
		private const string INDONESIA_ISO639_1 = "id";

		// Token: 0x040001DF RID: 479
		private const string FRANCE_ISO639_1 = "fr";

		// Token: 0x040001E0 RID: 480
		private const string VIETNAM_ISO639_1 = "vi";

		// Token: 0x040001E1 RID: 481
		private const string THAILAND_ISO639_1 = "th";

		// Token: 0x040001E2 RID: 482
		private readonly string[] AVAILABLE_LANGUAGES = new string[]
		{
			"zh-Hans",
			"en",
			"ja",
			"ko",
			"ru",
			"zh-Hant",
			"de",
			"es",
			"pt",
			"id",
			"fr",
			"vi",
			"th"
		};

		// Token: 0x040001E3 RID: 483
		private const string CHS_AUDIO = "zh";

		// Token: 0x040001E4 RID: 484
		private const string PUBLICATION_TYPE = "Publication";

		// Token: 0x040001E5 RID: 485
		private readonly List<LaunchLangDefine> LanguageList = new List<LaunchLangDefine>
		{
			new LaunchLangDefine(0, "zh-Hans", "zh"),
			new LaunchLangDefine(1, "en", "en"),
			new LaunchLangDefine(2, "ja", "ja"),
			new LaunchLangDefine(3, "ko", "ko"),
			new LaunchLangDefine(4, "ru", "en"),
			new LaunchLangDefine(5, "zh-Hant", "zh"),
			new LaunchLangDefine(6, "de", "en"),
			new LaunchLangDefine(7, "es", "en"),
			new LaunchLangDefine(8, "pt", "en"),
			new LaunchLangDefine(9, "id", "en"),
			new LaunchLangDefine(10, "fr", "en"),
			new LaunchLangDefine(11, "vi", "en"),
			new LaunchLangDefine(12, "th", "en")
		};

		// Token: 0x040001E6 RID: 486
		public readonly Dictionary<string, Culture> LanguageCultureMap;

		// Token: 0x040001E7 RID: 487
		private readonly Dictionary<int, LaunchLangDefine> LanguageTypeMap;

		// Token: 0x040001E8 RID: 488
		private readonly Dictionary<string, LaunchLangDefine> LanguageCodeMap;

		// Token: 0x040001E9 RID: 489
		[Nullable(2)]
		private string PackageLanguageInternal;

		// Token: 0x040001EA RID: 490
		[Nullable(2)]
		private string PackageAudioLanguage;

		// Token: 0x040001EB RID: 491
		private bool IsInit;

		// Token: 0x040001EC RID: 492
		[Nullable(2)]
		private static LauncherLanguageLib _instance;
	}
}
