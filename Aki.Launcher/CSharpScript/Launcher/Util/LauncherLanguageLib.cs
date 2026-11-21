using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define;
using CSharpScript.Launcher.Ui;
using UnrealEngine;

namespace CSharpScript.Launcher.Util
{
	// Token: 0x02000070 RID: 112
	[NullableContext(1)]
	[Nullable(0)]
	public class LauncherLanguageLib : Singleton
	{
		// Token: 0x060002E7 RID: 743 RVA: 0x0000F4D0 File Offset: 0x0000D6D0
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
		// (get) Token: 0x060002E8 RID: 744 RVA: 0x0000F544 File Offset: 0x0000D744
		// (set) Token: 0x060002E9 RID: 745 RVA: 0x0000F54C File Offset: 0x0000D74C
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

		// Token: 0x060002EA RID: 746 RVA: 0x0000F566 File Offset: 0x0000D766
		public string GetDefaultCulture(string currentCulture)
		{
			if (currentCulture.Contains("zh"))
			{
				return "zh-Hans";
			}
			return "en";
		}

		// Token: 0x060002EB RID: 747 RVA: 0x0000F580 File Offset: 0x0000D780
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

		// Token: 0x060002EC RID: 748 RVA: 0x0000F638 File Offset: 0x0000D838
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

		// Token: 0x060002ED RID: 749 RVA: 0x0000F868 File Offset: 0x0000DA68
		[NullableContext(2)]
		public string GetPackageLanguage()
		{
			return this.PackageLanguageInternal;
		}

		// Token: 0x060002EE RID: 750 RVA: 0x0000F870 File Offset: 0x0000DA70
		public void SetPackageLanguage(string language)
		{
			this.PackageLanguageInternal = language;
		}

		// Token: 0x060002EF RID: 751 RVA: 0x0000F879 File Offset: 0x0000DA79
		[NullableContext(2)]
		public string GetPackageAudioLanguage()
		{
			return this.PackageAudioLanguage;
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x0000F881 File Offset: 0x0000DA81
		public IReadOnlyList<LaunchLangDefine> GetAllLanguageDefines()
		{
			return this.LanguageList;
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x0000F88C File Offset: 0x0000DA8C
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

		// Token: 0x060002F2 RID: 754 RVA: 0x0000F8AC File Offset: 0x0000DAAC
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

		// Token: 0x060002F3 RID: 755 RVA: 0x0000F8CC File Offset: 0x0000DACC
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
		// (get) Token: 0x060002F4 RID: 756 RVA: 0x0000F9D8 File Offset: 0x0000DBD8
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

		// Token: 0x060002F5 RID: 757 RVA: 0x0000F9FB File Offset: 0x0000DBFB
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x0000F9FD File Offset: 0x0000DBFD
		public static void ResetStaticDefaultValue()
		{
			LauncherLanguageLib instance = LauncherLanguageLib._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			LauncherLanguageLib._instance = null;
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x0000FA16 File Offset: 0x0000DC16
		static LauncherLanguageLib()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LauncherLanguageLib.CreateStaticDefaultValue), new Action(LauncherLanguageLib.ResetStaticDefaultValue));
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x0000FA38 File Offset: 0x0000DC38
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

		// Token: 0x040001FA RID: 506
		private const int TEXTLANGUAGE = 51;

		// Token: 0x040001FB RID: 507
		private const int VOICELANGUAGE = 52;

		// Token: 0x040001FC RID: 508
		private const string CHS = "zh-Hans";

		// Token: 0x040001FD RID: 509
		private const string CHT = "zh-Hant";

		// Token: 0x040001FE RID: 510
		private const string CHINESE_ISO639_1 = "zh";

		// Token: 0x040001FF RID: 511
		public const string ENGLISH_ISO639_1 = "en";

		// Token: 0x04000200 RID: 512
		private const string JAPANESE_ISO639_1 = "ja";

		// Token: 0x04000201 RID: 513
		public const string KOREAN_ISO639_1 = "ko";

		// Token: 0x04000202 RID: 514
		private const string RUSSIA_ISO639_1 = "ru";

		// Token: 0x04000203 RID: 515
		private const string GERMANY_ISO639_1 = "de";

		// Token: 0x04000204 RID: 516
		private const string SPAIN_ISO639_1 = "es";

		// Token: 0x04000205 RID: 517
		private const string PORTUGAL_ISO639_1 = "pt";

		// Token: 0x04000206 RID: 518
		private const string INDONESIA_ISO639_1 = "id";

		// Token: 0x04000207 RID: 519
		private const string FRANCE_ISO639_1 = "fr";

		// Token: 0x04000208 RID: 520
		private const string VIETNAM_ISO639_1 = "vi";

		// Token: 0x04000209 RID: 521
		private const string THAILAND_ISO639_1 = "th";

		// Token: 0x0400020A RID: 522
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

		// Token: 0x0400020B RID: 523
		private const string CHS_AUDIO = "zh";

		// Token: 0x0400020C RID: 524
		private const string PUBLICATION_TYPE = "Publication";

		// Token: 0x0400020D RID: 525
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

		// Token: 0x0400020E RID: 526
		public readonly Dictionary<string, Culture> LanguageCultureMap;

		// Token: 0x0400020F RID: 527
		private readonly Dictionary<int, LaunchLangDefine> LanguageTypeMap;

		// Token: 0x04000210 RID: 528
		private readonly Dictionary<string, LaunchLangDefine> LanguageCodeMap;

		// Token: 0x04000211 RID: 529
		[Nullable(2)]
		private string PackageLanguageInternal;

		// Token: 0x04000212 RID: 530
		[Nullable(2)]
		private string PackageAudioLanguage;

		// Token: 0x04000213 RID: 531
		private bool IsInit;

		// Token: 0x04000214 RID: 532
		[Nullable(2)]
		private static LauncherLanguageLib _instance;
	}
}
