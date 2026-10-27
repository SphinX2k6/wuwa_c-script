using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Aki.Config;
using CSharpScript.Core.Common;
using UnrealEngine;

// Token: 0x02000030 RID: 48
[NullableContext(1)]
[Nullable(0)]
public class LanguageSystem : Singleton, ILanguageSystemProxy
{
	// Token: 0x060000F8 RID: 248 RVA: 0x000077E8 File Offset: 0x000059E8
	protected override bool OnInit()
	{
		foreach (global::LanguageDefine languageDefine in this.languageList)
		{
			this.languageTypeMap[languageDefine.LanguageType] = languageDefine;
			this.languageCodeMap[languageDefine.LanguageCode] = languageDefine;
		}
		return true;
	}

	// Token: 0x17000018 RID: 24
	// (get) Token: 0x060000F9 RID: 249 RVA: 0x0000785C File Offset: 0x00005A5C
	// (set) Token: 0x060000FA RID: 250 RVA: 0x00007864 File Offset: 0x00005A64
	public bool GmShowLanguageKey { get; set; }

	// Token: 0x17000019 RID: 25
	// (get) Token: 0x060000FB RID: 251 RVA: 0x0000786D File Offset: 0x00005A6D
	// (set) Token: 0x060000FC RID: 252 RVA: 0x00007875 File Offset: 0x00005A75
	public string GmReplaceTextContent { get; set; }

	// Token: 0x1700001A RID: 26
	// (get) Token: 0x060000FD RID: 253 RVA: 0x0000787E File Offset: 0x00005A7E
	// (set) Token: 0x060000FE RID: 254 RVA: 0x0000789C File Offset: 0x00005A9C
	public string PackageLanguage
	{
		get
		{
			if (string.IsNullOrEmpty(this.PackageLanguageInternal))
			{
				return "zh-Hans";
			}
			return this.PackageLanguageInternal;
		}
		set
		{
			string packageLanguageInternal = this.PackageLanguageInternal;
			this.PackageLanguageInternal = value;
			UKuroVariableFunctionLibrary.RemoveStringValue("PackageLanguage");
			UKuroVariableFunctionLibrary.SetStringValue("PackageLanguage", value);
			ULGUIFontData.SetAllFontCurrentCulture(this.languageCultureMap.GetValueOrDefault(value, Culture.zh_Hans));
			if (!Info.Instance.IsPlayInEditor)
			{
				UKismetInternationalizationLibrary.SetCurrentCulture(value, true);
			}
			if (value != packageLanguageInternal)
			{
				UUIText.OnTsLanguageChange();
				global::LanguageDefine valueOrDefault = this.languageCodeMap.GetValueOrDefault(value);
				UUILangTexture.NotifyLanguageChange((valueOrDefault != null) ? ((EUILanguageType)valueOrDefault.LanguageType) : EUILanguageType.En);
			}
			Action<string> notifyLauncherLanguageHook = global::LanguageSystem.NotifyLauncherLanguageHook;
			if (notifyLauncherLanguageHook == null)
			{
				return;
			}
			notifyLauncherLanguageHook(value);
		}
	}

	// Token: 0x1700001B RID: 27
	// (get) Token: 0x060000FF RID: 255 RVA: 0x00007934 File Offset: 0x00005B34
	public ELanguageType? PackageLanguageType
	{
		get
		{
			global::LanguageDefine languageDefine;
			if (!this.languageCodeMap.TryGetValue(this.PackageLanguage, out languageDefine))
			{
				return null;
			}
			return new ELanguageType?((ELanguageType)languageDefine.LanguageType);
		}
	}

	// Token: 0x1700001C RID: 28
	// (get) Token: 0x06000100 RID: 256 RVA: 0x0000796B File Offset: 0x00005B6B
	public string PackageAudio
	{
		get
		{
			if (string.IsNullOrEmpty(this.PackageLanguageInternal))
			{
				return "zh";
			}
			return this.PackageAudioInternal;
		}
	}

	// Token: 0x06000101 RID: 257 RVA: 0x00007988 File Offset: 0x00005B88
	public unsafe void SetPackageAudio(string audioCode, UObject worldContext)
	{
		global::Log instance = global::Log.Instance;
		ELogModule module = ELogModule.GameSettings;
		ELogAuthor author = ELogAuthor.WZ;
		string message = "开始设置音频语种，对应【SetCurrentAudioCultureAsync】";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Code", audioCode);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		this.PackageAudioInternal = audioCode;
		Action<bool> callback = null;
		callback = delegate(bool success)
		{
			global::Log instance2 = global::Log.Instance;
			ELogModule module2 = ELogModule.Config;
			ELogAuthor author2 = ELogAuthor.MZJ;
			string message2 = "SetCurrentAudioCultureAsync";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Success", success);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Code", audioCode);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			if (callback != null)
			{
				DelegateUtils.ReleaseManualReleaseDelegate(callback);
			}
			if (success)
			{
				AudioSystem.Instance.SetState("language", audioCode, true);
			}
		};
		string audioCode2 = audioCode;
		FOnSetCurrentAudioCultureCallback fonSetCurrentAudioCultureCallback = DelegateUtils.ToManualReleaseDelegate<FOnSetCurrentAudioCultureCallback>(callback);
		UAkGameplayStatics.SetCurrentAudioCultureAsync(audioCode2, fonSetCurrentAudioCultureCallback);
	}

	// Token: 0x06000102 RID: 258 RVA: 0x00007A0F File Offset: 0x00005C0F
	private string GetDefaultCulture(string currentCulture)
	{
		if (currentCulture.Contains("zh"))
		{
			return "zh-Hans";
		}
		return "en";
	}

	// Token: 0x06000103 RID: 259 RVA: 0x00007A2C File Offset: 0x00005C2C
	public unsafe void FirstTimeSetLanguage(UObject worldContext)
	{
		string defaultLanguage = UKismetSystemLibrary.GetDefaultLanguage();
		TArray<string> tarray = new TArray<string>();
		foreach (string value in CommonDefine.AVAILABLE_LANGUAGES)
		{
			tarray.Add(value);
		}
		string defaultCulture = this.GetDefaultCulture(defaultLanguage);
		string text = UKismetInternationalizationLibrary.GetSuitableCulture(tarray, defaultLanguage, defaultCulture);
		Aki.Config.LanguageDefine? config = ConfigLanguageDefineByLanguageCode.GetConfig(text, true);
		bool flag = config != null && config.GetValueOrDefault().IsShow;
		text = (flag ? text : this.GetDefaultCulture(text));
		if (!flag)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Config;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "当前语种表格配置不允许生效";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("targetLanguage", text);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("currentCulture", defaultLanguage);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
		global::Log instance2 = global::Log.Instance;
		ELogModule module2 = ELogModule.Config;
		ELogAuthor author2 = ELogAuthor.MZJ;
		string message2 = "第一次设置语言";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("设备默认语言", defaultLanguage);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("查找不到时匹配默认语言", defaultCulture);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("最合适语言", text);
		instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
		global::LanguageDefine languageDefine = this.languageCodeMap.ContainsKey(text) ? this.languageCodeMap[text] : null;
		if (languageDefine == null)
		{
			global::Log instance3 = global::Log.Instance;
			ELogModule module3 = ELogModule.Config;
			ELogAuthor author3 = ELogAuthor.MZJ;
			string message3 = "设置系统找不到配置";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("语种识别码", text);
			instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.PackageLanguage = "en";
			return;
		}
		global::Log instance4 = global::Log.Instance;
		ELogModule module4 = ELogModule.Config;
		ELogAuthor author4 = ELogAuthor.MZJ;
		string message4 = "FirstTimeSetLanguage";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("Text", languageDefine.LanguageCode);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("Audio", languageDefine.AudioCode);
		instance4.Info(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 2));
		this.PackageLanguage = languageDefine.LanguageCode;
	}

	// Token: 0x06000104 RID: 260 RVA: 0x00007C35 File Offset: 0x00005E35
	public List<global::LanguageDefine> GetAllLanguageDefines()
	{
		return this.languageList;
	}

	// Token: 0x06000105 RID: 261 RVA: 0x00007C3D File Offset: 0x00005E3D
	public global::LanguageDefine GetLanguageDefineByType(int type)
	{
		return this.languageTypeMap[type];
	}

	// Token: 0x06000106 RID: 262 RVA: 0x00007C4B File Offset: 0x00005E4B
	public global::LanguageDefine GetLanguageDefineByCode(string code)
	{
		return this.languageCodeMap[code];
	}

	// Token: 0x06000107 RID: 263 RVA: 0x00007C59 File Offset: 0x00005E59
	public string GetCultureOrDefault([Nullable(2)] string culture)
	{
		if (!string.IsNullOrEmpty(culture))
		{
			return culture;
		}
		return this.PackageLanguage;
	}

	// Token: 0x06000108 RID: 264 RVA: 0x00007C6B File Offset: 0x00005E6B
	public ESpeechType GetSpeechTypeByLanguageType(ELanguageType languageType)
	{
		return this.languageSpeechMapping[languageType];
	}

	// Token: 0x06000109 RID: 265 RVA: 0x00007C7C File Offset: 0x00005E7C
	public int GetLanguageTypeByAudioCode(string audioCode)
	{
		foreach (global::LanguageDefine languageDefine in this.languageList)
		{
			if (languageDefine.AudioCode == audioCode)
			{
				return languageDefine.LanguageType;
			}
		}
		return 0;
	}

	// Token: 0x1700001D RID: 29
	// (get) Token: 0x0600010A RID: 266 RVA: 0x00007CE4 File Offset: 0x00005EE4
	public static global::LanguageSystem Instance
	{
		get
		{
			if (global::LanguageSystem._instance == null)
			{
				global::LanguageSystem._instance = new global::LanguageSystem();
				global::LanguageSystem._instance.OnInit();
			}
			return global::LanguageSystem._instance;
		}
	}

	// Token: 0x0600010B RID: 267 RVA: 0x00007D07 File Offset: 0x00005F07
	public static void CreateStaticDefaultValue()
	{
		global::LanguageSystem.OnCreateStaticDefaultValue();
	}

	// Token: 0x0600010C RID: 268 RVA: 0x00007D0E File Offset: 0x00005F0E
	public static void ResetStaticDefaultValue()
	{
		global::LanguageSystem instance = global::LanguageSystem._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		global::LanguageSystem._instance = null;
		global::LanguageSystem.OnResetStaticDefaultValue();
	}

	// Token: 0x0600010D RID: 269 RVA: 0x00007D2C File Offset: 0x00005F2C
	private static void OnCreateStaticDefaultValue()
	{
	}

	// Token: 0x0600010E RID: 270 RVA: 0x00007D2E File Offset: 0x00005F2E
	private static void OnResetStaticDefaultValue()
	{
		global::LanguageSystem.NotifyLauncherLanguageHook = null;
	}

	// Token: 0x0600010F RID: 271 RVA: 0x00007D36 File Offset: 0x00005F36
	static LanguageSystem()
	{
		global::StaticVariableRegister.RegisterAndExecute(new Action(global::LanguageSystem.CreateStaticDefaultValue), new Action(global::LanguageSystem.ResetStaticDefaultValue));
	}

	// Token: 0x06000110 RID: 272 RVA: 0x00007D58 File Offset: 0x00005F58
	public LanguageSystem()
	{
		Dictionary<ELanguageType, ESpeechType> dictionary = new Dictionary<ELanguageType, ESpeechType>();
		dictionary[ELanguageType.Zh] = ESpeechType.Zh;
		dictionary[ELanguageType.En] = ESpeechType.En;
		dictionary[ELanguageType.Ja] = ESpeechType.Ja;
		dictionary[ELanguageType.Ko] = ESpeechType.Ko;
		dictionary[ELanguageType.Ru] = ESpeechType.En;
		dictionary[ELanguageType.Zht] = ESpeechType.Zh;
		dictionary[ELanguageType.De] = ESpeechType.En;
		dictionary[ELanguageType.Es] = ESpeechType.En;
		dictionary[ELanguageType.Pt] = ESpeechType.En;
		dictionary[ELanguageType.Id] = ESpeechType.En;
		dictionary[ELanguageType.Fr] = ESpeechType.En;
		dictionary[ELanguageType.Vi] = ESpeechType.En;
		dictionary[ELanguageType.Th] = ESpeechType.En;
		this.languageSpeechMapping = dictionary;
		this.languageList = new List<global::LanguageDefine>
		{
			new global::LanguageDefine(0, "zh-Hans", "zh"),
			new global::LanguageDefine(1, "en", "en"),
			new global::LanguageDefine(2, "ja", "ja"),
			new global::LanguageDefine(3, "ko", "ko"),
			new global::LanguageDefine(4, "ru", "en"),
			new global::LanguageDefine(5, "zh-Hant", "zh"),
			new global::LanguageDefine(6, "de", "en"),
			new global::LanguageDefine(7, "es", "en"),
			new global::LanguageDefine(8, "pt", "en"),
			new global::LanguageDefine(9, "id", "en"),
			new global::LanguageDefine(10, "fr", "en"),
			new global::LanguageDefine(11, "vi", "en"),
			new global::LanguageDefine(12, "th", "en")
		};
		Dictionary<string, Culture> dictionary2 = new Dictionary<string, Culture>();
		dictionary2["zh-Hans"] = Culture.zh_Hans;
		dictionary2["en"] = Culture.en;
		dictionary2["ja"] = Culture.ja;
		dictionary2["ko"] = Culture.ko;
		dictionary2["ru"] = Culture.ru;
		dictionary2["zh-Hant"] = Culture.zh_Hant;
		dictionary2["de"] = Culture.de;
		dictionary2["es"] = Culture.es;
		dictionary2["pt"] = Culture.pt;
		dictionary2["id"] = Culture.id;
		dictionary2["fr"] = Culture.fr;
		dictionary2["vi"] = Culture.vi;
		dictionary2["th"] = Culture.th;
		this.languageCultureMap = dictionary2;
		this.languageTypeMap = new Dictionary<int, global::LanguageDefine>();
		this.languageCodeMap = new Dictionary<string, global::LanguageDefine>();
		this.GmReplaceTextContent = "";
		base..ctor();
	}

	// Token: 0x04000104 RID: 260
	public readonly Dictionary<ELanguageType, ESpeechType> languageSpeechMapping;

	// Token: 0x04000105 RID: 261
	private readonly List<global::LanguageDefine> languageList;

	// Token: 0x04000106 RID: 262
	public readonly Dictionary<string, Culture> languageCultureMap;

	// Token: 0x04000107 RID: 263
	private readonly Dictionary<int, global::LanguageDefine> languageTypeMap;

	// Token: 0x04000108 RID: 264
	private readonly Dictionary<string, global::LanguageDefine> languageCodeMap;

	// Token: 0x0400010B RID: 267
	private string PackageLanguageInternal;

	// Token: 0x0400010C RID: 268
	private string PackageAudioInternal;

	// Token: 0x0400010D RID: 269
	public static Action<string> NotifyLauncherLanguageHook;

	// Token: 0x0400010E RID: 270
	[Nullable(2)]
	private static global::LanguageSystem _instance;
}
