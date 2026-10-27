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
	// Token: 0x02000131 RID: 305
	[NullableContext(1)]
	[Nullable(0)]
	public class PlatformSdkConfig : Singleton
	{
		// Token: 0x0600099F RID: 2463 RVA: 0x000433C8 File Offset: 0x000415C8
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

		// Token: 0x060009A0 RID: 2464 RVA: 0x00043468 File Offset: 0x00041668
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

		// Token: 0x060009A1 RID: 2465 RVA: 0x000434D4 File Offset: 0x000416D4
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

		// Token: 0x060009A2 RID: 2466 RVA: 0x00043558 File Offset: 0x00041758
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

		// Token: 0x060009A3 RID: 2467 RVA: 0x000435A6 File Offset: 0x000417A6
		private string GetConfigPath()
		{
			if (this.ConfigPath == null)
			{
				this.ConfigPath = UBlueprintPathsLibrary.ProjectConfigDir() + "Kuro/KuroPlatformSdkConfig.json";
			}
			return this.ConfigPath;
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x000435CB File Offset: 0x000417CB
		public string GetProjectId()
		{
			return this.GetPlatformData().projectId ?? "";
		}

		// Token: 0x060009A5 RID: 2469 RVA: 0x000435E1 File Offset: 0x000417E1
		public string GetProductId()
		{
			return this.GetPlatformReleaseData().productId ?? "";
		}

		// Token: 0x060009A6 RID: 2470 RVA: 0x000435F7 File Offset: 0x000417F7
		public string GetChannelId()
		{
			return this.GetPlatformData().channelId ?? "";
		}

		// Token: 0x060009A7 RID: 2471 RVA: 0x0004360D File Offset: 0x0004180D
		public string GetPlatform()
		{
			return this.GetPlatformData().platform ?? "";
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x00043623 File Offset: 0x00041823
		public string GetVersion()
		{
			return this.GetPlatformData().version ?? "";
		}

		// Token: 0x060009A9 RID: 2473 RVA: 0x00043639 File Offset: 0x00041839
		public string GetSdkVersion()
		{
			return this.GetPlatformData().sdkVersion ?? "";
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x0004364F File Offset: 0x0004184F
		public string GetSdkServerVersion()
		{
			return this.GetPlatformData().sdkServerVersion ?? "";
		}

		// Token: 0x060009AB RID: 2475 RVA: 0x00043668 File Offset: 0x00041868
		private string ReplaceLanguageString(string inString)
		{
			string str = LauncherLanguageLib.Instance.PackageLanguage ?? "";
			return inString.Replace("language_{0}", "language_" + str);
		}

		// Token: 0x060009AC RID: 2476 RVA: 0x000436A0 File Offset: 0x000418A0
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

		// Token: 0x060009AD RID: 2477 RVA: 0x000436FC File Offset: 0x000418FC
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

		// Token: 0x060009AE RID: 2478 RVA: 0x00043758 File Offset: 0x00041958
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

		// Token: 0x060009AF RID: 2479 RVA: 0x000437B4 File Offset: 0x000419B4
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

		// Token: 0x060009B0 RID: 2480 RVA: 0x00043844 File Offset: 0x00041A44
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

		// Token: 0x060009B1 RID: 2481 RVA: 0x000438D2 File Offset: 0x00041AD2
		public string GetClientId()
		{
			if (this.SdkServerConfig != null)
			{
				return this.SdkServerConfig.client_id ?? "";
			}
			return "";
		}

		// Token: 0x060009B2 RID: 2482 RVA: 0x000438F6 File Offset: 0x00041AF6
		public string GetClientSecret()
		{
			if (this.SdkServerConfig != null)
			{
				return this.SdkServerConfig.client_secret ?? "";
			}
			return "";
		}

		// Token: 0x060009B3 RID: 2483 RVA: 0x0004391A File Offset: 0x00041B1A
		public string GetPlatformPkg()
		{
			if (this.SdkServerConfig != null)
			{
				return this.SdkServerConfig.platform_pkg ?? "";
			}
			return "";
		}

		// Token: 0x060009B4 RID: 2484 RVA: 0x0004393E File Offset: 0x00041B3E
		public string GetPlatformClientId()
		{
			if (this.SdkServerConfig != null)
			{
				return this.SdkServerConfig.platform_client_id ?? "";
			}
			return "";
		}

		// Token: 0x060009B5 RID: 2485 RVA: 0x00043962 File Offset: 0x00041B62
		public string GetPlatformClientSecret()
		{
			if (this.SdkServerConfig != null)
			{
				return this.SdkServerConfig.platform_client_secret ?? "";
			}
			return "";
		}

		// Token: 0x060009B6 RID: 2486 RVA: 0x00043986 File Offset: 0x00041B86
		public string GetUserCenterUrl()
		{
			if (this.SdkServerConfig != null)
			{
				return this.SdkServerConfig.UserCenterUrl ?? "";
			}
			return "";
		}

		// Token: 0x060009B7 RID: 2487 RVA: 0x000439AA File Offset: 0x00041BAA
		public string GetDataReportUrl()
		{
			if (this.SdkServerConfig != null)
			{
				return this.SdkServerConfig.DataReportUrl ?? "";
			}
			return "";
		}

		// Token: 0x060009B8 RID: 2488 RVA: 0x000439CE File Offset: 0x00041BCE
		public string GetKuroDataReportUrl()
		{
			if (this.SdkServerConfig != null)
			{
				return this.SdkServerConfig.kuro_DataReportUrl ?? "";
			}
			return "";
		}

		// Token: 0x060009B9 RID: 2489 RVA: 0x000439F2 File Offset: 0x00041BF2
		public string GetDataReportId()
		{
			if (this.SdkServerConfig != null)
			{
				return this.SdkServerConfig.DataReportId ?? "";
			}
			return "";
		}

		// Token: 0x060009BA RID: 2490 RVA: 0x00043A16 File Offset: 0x00041C16
		public string GetCustomServiceUrl()
		{
			if (this.SdkServerConfig != null)
			{
				return this.SdkServerConfig.CustomServiceUrl ?? "";
			}
			return "";
		}

		// Token: 0x060009BB RID: 2491 RVA: 0x00043A3C File Offset: 0x00041C3C
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

		// Token: 0x060009BC RID: 2492 RVA: 0x00043B08 File Offset: 0x00041D08
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

		// Token: 0x060009BD RID: 2493 RVA: 0x00043BA8 File Offset: 0x00041DA8
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

		// Token: 0x060009BE RID: 2494 RVA: 0x00043BF4 File Offset: 0x00041DF4
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

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060009BF RID: 2495 RVA: 0x00043C44 File Offset: 0x00041E44
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

		// Token: 0x060009C0 RID: 2496 RVA: 0x00043C67 File Offset: 0x00041E67
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x00043C69 File Offset: 0x00041E69
		public static void ResetStaticDefaultValue()
		{
			PlatformSdkConfig instance = PlatformSdkConfig._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			PlatformSdkConfig._instance = null;
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x00043C82 File Offset: 0x00041E82
		static PlatformSdkConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PlatformSdkConfig.CreateStaticDefaultValue), new Action(PlatformSdkConfig.ResetStaticDefaultValue));
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x00043CBF File Offset: 0x00041EBF
		[CompilerGenerated]
		private string <RequestBaseData>g__GetHttpFunction|36_0(string httpPre)
		{
			return this.BuildHttp(httpPre);
		}

		// Token: 0x040005B3 RID: 1459
		private readonly Dictionary<string, CsLinkEntry> CsDataMap = new Dictionary<string, CsLinkEntry>();

		// Token: 0x040005B4 RID: 1460
		[Nullable(2)]
		private IConfigJson Json;

		// Token: 0x040005B5 RID: 1461
		[Nullable(2)]
		private SdkPlatformConfig SdkServerConfig;

		// Token: 0x040005B6 RID: 1462
		public bool IsGlobal;

		// Token: 0x040005B7 RID: 1463
		[Nullable(2)]
		private string ConfigPath;

		// Token: 0x040005B8 RID: 1464
		private bool Initialized;

		// Token: 0x040005B9 RID: 1465
		private readonly Random _shuffleRandom = new Random();

		// Token: 0x040005BA RID: 1466
		[Nullable(2)]
		private static PlatformSdkConfig _instance;
	}
}
