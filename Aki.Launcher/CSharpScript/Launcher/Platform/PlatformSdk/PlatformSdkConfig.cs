using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Launcher.Ui.HotFix;
using CSharpScript.Launcher.Util;
using CSharpScript.Typing;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x02000135 RID: 309
	[NullableContext(1)]
	[Nullable(0)]
	public class PlatformSdkConfig : Singleton
	{
		// Token: 0x060009D3 RID: 2515 RVA: 0x000457DC File Offset: 0x000439DC
		public void Initialize()
		{
			string configPath = this.GetConfigPath();
			string text = null;
			if (!UKuroStaticLibrary.LoadFileToString(ref text, configPath))
			{
				LauncherLog instance = LauncherLog.Instance;
				string message = "[PlatformSdkNew]PlatformSdkConfig.Initialize failed";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("path", configPath);
				instance.Error(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.IsGlobal = (BaseConfigController.Instance.GetPublicValue("SdkArea") != "CN");
			this.Json = LauncherJson.Parse<IConfigJson>(text, null);
			LauncherLog instance2 = LauncherLog.Instance;
			string message2 = "[PlatformSdkNew]PlatformSdkConfig.Initialized";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Json", this.Json);
			instance2.Info(message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			this.Initialized = true;
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x0004587C File Offset: 0x00043A7C
		private string GetApplicationReleaseType()
		{
			Dictionary<string, string> sdkEnvironment = BaseConfigController.Instance.GetSdkEnvironment();
			if (sdkEnvironment == null)
			{
				return "Product";
			}
			string key = KuroApplication.IniPlatformName();
			LauncherLog instance = LauncherLog.Instance;
			string message = "GetApplicationReleaseType";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("platformName", sdkEnvironment.GetValueOrDefault(key));
			instance.Debug(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			string text;
			if (sdkEnvironment.TryGetValue(key, out text) && !string.IsNullOrEmpty(text))
			{
				return text;
			}
			return "Product";
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x000458E8 File Offset: 0x00043AE8
		private IPlatformReleaseData GetPlatformReleaseData()
		{
			IPlatformData platformData = this.GetPlatformData();
			string applicationReleaseType = this.GetApplicationReleaseType();
			if (applicationReleaseType == "Development")
			{
				return platformData.Development ?? new IPlatformReleaseData();
			}
			if (applicationReleaseType == "Product")
			{
				return platformData.Release ?? new IPlatformReleaseData();
			}
			if (!(applicationReleaseType == "Prerelease"))
			{
				return platformData.Development ?? new IPlatformReleaseData();
			}
			return platformData.PreRelease ?? new IPlatformReleaseData();
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x0004596C File Offset: 0x00043B6C
		private IPlatformData GetPlatformData()
		{
			if (!this.Initialized)
			{
				this.Initialize();
			}
			if (Platform.Instance.Type == EPlatformType.PS5 && this.Json != null && this.Json.PS5 != null)
			{
				return this.Json.PS5;
			}
			return new IPlatformData();
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x000459BA File Offset: 0x00043BBA
		private string GetConfigPath()
		{
			if (this.ConfigPath == null)
			{
				this.ConfigPath = UBlueprintPathsLibrary.ProjectConfigDir() + "Kuro/KuroPlatformSdkConfig.json";
			}
			return this.ConfigPath;
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x000459DF File Offset: 0x00043BDF
		public string GetProjectId()
		{
			return this.GetPlatformData().projectId ?? "";
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x000459F5 File Offset: 0x00043BF5
		public string GetProductId()
		{
			return this.GetPlatformReleaseData().productId ?? "";
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x00045A0B File Offset: 0x00043C0B
		public string GetChannelId()
		{
			return this.GetPlatformData().channelId ?? "";
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x00045A21 File Offset: 0x00043C21
		public string GetPlatform()
		{
			return this.GetPlatformData().platform ?? "";
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x00045A37 File Offset: 0x00043C37
		public string GetVersion()
		{
			return this.GetPlatformData().version ?? "";
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x00045A4D File Offset: 0x00043C4D
		public string GetSdkVersion()
		{
			return this.GetPlatformData().sdkVersion ?? "";
		}

		// Token: 0x060009DE RID: 2526 RVA: 0x00045A63 File Offset: 0x00043C63
		public string GetSdkServerVersion()
		{
			return this.GetPlatformData().sdkServerVersion ?? "";
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x00045A7C File Offset: 0x00043C7C
		private string ReplaceLanguageString(string inString)
		{
			string str = LauncherLanguageLib.Instance.PackageLanguage ?? "";
			return inString.Replace("language_{0}", "language_" + str);
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x00045AB4 File Offset: 0x00043CB4
		public string GetPrivacyPolicy()
		{
			if (this.SdkServerConfig == null)
			{
				return "";
			}
			string privacyPolicy = this.SdkServerConfig.PrivacyPolicy;
			if (this.IsGlobal && !string.IsNullOrEmpty(this.SdkServerConfig.PrivacyPolicy))
			{
				return this.ReplaceLanguageString(privacyPolicy ?? "");
			}
			return privacyPolicy ?? "";
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x00045B10 File Offset: 0x00043D10
		public string GetTermsOfService()
		{
			if (this.SdkServerConfig == null)
			{
				return "";
			}
			string termsOfService = this.SdkServerConfig.TermsOfService;
			if (this.IsGlobal && !string.IsNullOrEmpty(this.SdkServerConfig.TermsOfService))
			{
				return this.ReplaceLanguageString(termsOfService ?? "");
			}
			return termsOfService ?? "";
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x00045B6C File Offset: 0x00043D6C
		public string GetChildPolicy()
		{
			if (this.SdkServerConfig == null)
			{
				return "";
			}
			string childProtocol = this.SdkServerConfig.ChildProtocol;
			if (this.IsGlobal && !string.IsNullOrEmpty(this.SdkServerConfig.ChildProtocol))
			{
				return this.ReplaceLanguageString(childProtocol ?? "");
			}
			return childProtocol ?? "";
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x00045BC8 File Offset: 0x00043DC8
		public string GetServerUrl(bool spare = false)
		{
			int num = (spare > false) ? 1 : 0;
			if (this.SdkServerConfig != null && this.SdkServerConfig.ServerUrl != null)
			{
				if (this.SdkServerConfig.ServerUrl.Count > num)
				{
					return this.SdkServerConfig.ServerUrl[num];
				}
				if (this.SdkServerConfig.ServerUrl.Count > 0)
				{
					return this.SdkServerConfig.ServerUrl[0];
				}
			}
			LauncherLog.Instance.Error("获取服务器地址失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return "";
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x00045C58 File Offset: 0x00043E58
		public string GetPayUrl(bool spare = false)
		{
			int num = (spare > false) ? 1 : 0;
			if (this.SdkServerConfig != null && this.SdkServerConfig.PayUrl != null)
			{
				if (this.SdkServerConfig.PayUrl.Count > num)
				{
					return this.SdkServerConfig.PayUrl[num];
				}
				if (this.SdkServerConfig.PayUrl.Count > 0)
				{
					return this.SdkServerConfig.PayUrl[0];
				}
			}
			LauncherLog.Instance.Error("获取支付地址失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return "";
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x00045CE6 File Offset: 0x00043EE6
		public string GetClientId()
		{
			if (this.SdkServerConfig != null)
			{
				return this.SdkServerConfig.client_id ?? "";
			}
			return "";
		}

		// Token: 0x060009E6 RID: 2534 RVA: 0x00045D0A File Offset: 0x00043F0A
		public string GetClientSecret()
		{
			if (this.SdkServerConfig != null)
			{
				return this.SdkServerConfig.client_secret ?? "";
			}
			return "";
		}

		// Token: 0x060009E7 RID: 2535 RVA: 0x00045D2E File Offset: 0x00043F2E
		public string GetPlatformPkg()
		{
			if (this.SdkServerConfig != null)
			{
				return this.SdkServerConfig.platform_pkg ?? "";
			}
			return "";
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x00045D52 File Offset: 0x00043F52
		public string GetPlatformClientId()
		{
			if (this.SdkServerConfig != null)
			{
				return this.SdkServerConfig.platform_client_id ?? "";
			}
			return "";
		}

		// Token: 0x060009E9 RID: 2537 RVA: 0x00045D76 File Offset: 0x00043F76
		public string GetPlatformClientSecret()
		{
			if (this.SdkServerConfig != null)
			{
				return this.SdkServerConfig.platform_client_secret ?? "";
			}
			return "";
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x00045D9A File Offset: 0x00043F9A
		public string GetUserCenterUrl()
		{
			if (this.SdkServerConfig != null)
			{
				return this.SdkServerConfig.UserCenterUrl ?? "";
			}
			return "";
		}

		// Token: 0x060009EB RID: 2539 RVA: 0x00045DBE File Offset: 0x00043FBE
		public string GetDataReportUrl()
		{
			if (this.SdkServerConfig != null)
			{
				return this.SdkServerConfig.DataReportUrl ?? "";
			}
			return "";
		}

		// Token: 0x060009EC RID: 2540 RVA: 0x00045DE2 File Offset: 0x00043FE2
		public string GetKuroDataReportUrl()
		{
			if (this.SdkServerConfig != null)
			{
				return this.SdkServerConfig.kuro_DataReportUrl ?? "";
			}
			return "";
		}

		// Token: 0x060009ED RID: 2541 RVA: 0x00045E06 File Offset: 0x00044006
		public string GetDataReportId()
		{
			if (this.SdkServerConfig != null)
			{
				return this.SdkServerConfig.DataReportId ?? "";
			}
			return "";
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x00045E2A File Offset: 0x0004402A
		public string GetCustomServiceUrl()
		{
			if (this.SdkServerConfig != null)
			{
				return this.SdkServerConfig.CustomServiceUrl ?? "";
			}
			return "";
		}

		// Token: 0x060009EF RID: 2543 RVA: 0x00045E50 File Offset: 0x00044050
		public unsafe string GetCustomerServiceUrl(string language)
		{
			CsLinkEntry csLinkEntry;
			this.CsDataMap.TryGetValue(language, out csLinkEntry);
			LauncherLog instance = LauncherLog.Instance;
			string message = "获取客服链接";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("data", this.CsDataMap);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("language", language);
			instance.Debug(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			if (csLinkEntry == null)
			{
				this.CsDataMap.TryGetValue("en", out csLinkEntry);
			}
			LauncherLog instance2 = LauncherLog.Instance;
			string message2 = "获取客服链接";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("jsonLinkData.link", (csLinkEntry != null) ? csLinkEntry.link : null);
			instance2.Debug(message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return ((csLinkEntry != null) ? csLinkEntry.link : null) ?? "";
		}

		// Token: 0x060009F0 RID: 2544 RVA: 0x00045F1C File Offset: 0x0004411C
		private string BuildHttp(string httpPre)
		{
			string applicationReleaseType = this.GetApplicationReleaseType();
			string projectId = this.GetProjectId();
			string channelId = this.GetChannelId();
			string productId = this.GetProductId();
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 5);
			defaultInterpolatedStringHandler.AppendFormatted(httpPre);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted(applicationReleaseType);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted(projectId);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted(channelId);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted(productId);
			defaultInterpolatedStringHandler.AppendLiteral("/config.json");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x060009F1 RID: 2545 RVA: 0x00045FBC File Offset: 0x000441BC
		[NullableContext(0)]
		public UniTask<bool> RequestBaseData([Nullable(2)] HotFixManager view = null)
		{
			PlatformSdkConfig.<RequestBaseData>d__36 <RequestBaseData>d__;
			<RequestBaseData>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestBaseData>d__.<>4__this = this;
			<RequestBaseData>d__.view = view;
			<RequestBaseData>d__.<>1__state = -1;
			<RequestBaseData>d__.<>t__builder.Start<PlatformSdkConfig.<RequestBaseData>d__36>(ref <RequestBaseData>d__);
			return <RequestBaseData>d__.<>t__builder.Task;
		}

		// Token: 0x060009F2 RID: 2546 RVA: 0x00046008 File Offset: 0x00044208
		public List<string> ShuffleList(List<string> list)
		{
			for (int i = list.Count - 1; i > 0; i--)
			{
				int index = this._shuffleRandom.Next(i + 1);
				string value = list[i];
				list[i] = list[index];
				list[index] = value;
			}
			return list;
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060009F3 RID: 2547 RVA: 0x00046058 File Offset: 0x00044258
		public static PlatformSdkConfig Instance
		{
			get
			{
				if (PlatformSdkConfig._instance == null)
				{
					PlatformSdkConfig._instance = new PlatformSdkConfig();
					PlatformSdkConfig._instance.OnInit();
				}
				return PlatformSdkConfig._instance;
			}
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x0004607B File Offset: 0x0004427B
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x0004607D File Offset: 0x0004427D
		public static void ResetStaticDefaultValue()
		{
			PlatformSdkConfig instance = PlatformSdkConfig._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			PlatformSdkConfig._instance = null;
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x00046096 File Offset: 0x00044296
		static PlatformSdkConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PlatformSdkConfig.CreateStaticDefaultValue), new Action(PlatformSdkConfig.ResetStaticDefaultValue));
		}

		// Token: 0x060009F8 RID: 2552 RVA: 0x000460D3 File Offset: 0x000442D3
		[CompilerGenerated]
		private string <RequestBaseData>g__GetHttpFunction|36_0(string httpPre)
		{
			return this.BuildHttp(httpPre);
		}

		// Token: 0x040005EE RID: 1518
		private readonly Dictionary<string, CsLinkEntry> CsDataMap = new Dictionary<string, CsLinkEntry>();

		// Token: 0x040005EF RID: 1519
		[Nullable(2)]
		private IConfigJson Json;

		// Token: 0x040005F0 RID: 1520
		[Nullable(2)]
		private SdkPlatformConfig SdkServerConfig;

		// Token: 0x040005F1 RID: 1521
		public bool IsGlobal;

		// Token: 0x040005F2 RID: 1522
		[Nullable(2)]
		private string ConfigPath;

		// Token: 0x040005F3 RID: 1523
		private bool Initialized;

		// Token: 0x040005F4 RID: 1524
		private readonly Random _shuffleRandom = new Random();

		// Token: 0x040005F5 RID: 1525
		[Nullable(2)]
		private static PlatformSdkConfig _instance;
	}
}
