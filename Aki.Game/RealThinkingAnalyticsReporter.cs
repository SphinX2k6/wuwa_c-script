using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Typing;
using UnrealEngine;

// Token: 0x02002185 RID: 8581
[NullableContext(1)]
[Nullable(0)]
public class RealThinkingAnalyticsReporter : Singleton
{
	// Token: 0x06010AC6 RID: 68294 RVA: 0x0040CA14 File Offset: 0x0040AC14
	public void Init()
	{
		EventSystem.Instance.Add(EEventName.OnGetPlayerBasicInfo, new Action(this.OnGetPlayerBasicInfo));
		EventSystem.Instance.Add(EEventName.LogOut, new Action(this.LogOut));
		EventSystem.Instance.Add(EEventName.OnSetLoginServerId, new Action(this.SwitchToLoginServerConfig));
	}

	// Token: 0x06010AC7 RID: 68295 RVA: 0x0040CA78 File Offset: 0x0040AC78
	private void OnGetPlayerBasicInfo()
	{
		UThinkingAnalytics.Login(PlayerInfoModel.Instance.GetId().ToString(), 0);
	}

	// Token: 0x06010AC8 RID: 68296 RVA: 0x0040CAA3 File Offset: 0x0040ACA3
	private void LogOut()
	{
		UThinkingAnalytics.Logout(0);
	}

	// Token: 0x06010AC9 RID: 68297 RVA: 0x0040CAAC File Offset: 0x0040ACAC
	private unsafe void SwitchToLoginServerConfig()
	{
		if (!KuroSdkController.Instance.GetIfGlobalSdk())
		{
			return;
		}
		if (BaseConfigController.Instance.GetIosAuditFirstDownloadTipWithSkip())
		{
			return;
		}
		LoginModel instance = LoginModel.Instance;
		string text = (instance != null) ? instance.GetServerId() : null;
		ITDConfig itdconfig = null;
		ILoginServersData loginServerById = BaseConfigController.Instance.GetLoginServerById(text);
		if (((loginServerById != null) ? loginServerById.TDCfg : null) != null)
		{
			itdconfig = loginServerById.TDCfg;
			Log instance2 = Log.Instance;
			ELogModule module = ELogModule.Log;
			ELogAuthor author = ELogAuthor.LFJW;
			string message = "使用LoginServer的数数配置";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ServerId", text);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("AppID", itdconfig.AppID);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("URL", itdconfig.URL);
			instance2.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		}
		if (itdconfig != null)
		{
			string url = itdconfig.URL;
			string appID = itdconfig.AppID;
			if (UThinkingAnalytics.HasInstanceInitialized(0))
			{
				bool flag = false;
				if (text != null && UThinkingAnalytics.GetServerUrl(0) != url)
				{
					flag = true;
				}
				if (appID != null && UThinkingAnalytics.GetAppId(0) != appID)
				{
					flag = true;
				}
				if (flag)
				{
					UThinkingAnalytics.DestroyInstance(0, true);
				}
			}
			UThinkingAnalytics.InitializeDefaultInsWithURL_Appid(url, appID, 1f, 1000, 10000f, true, 10f, true);
			if (this.OnCalibrateDelegate == null)
			{
				this.OnCalibrateDelegate = DelegateUtils.ToManualReleaseDelegate<FOnTimeCalibrated>(new Action<int>(this.OnCalibrate));
			}
			UThinkingAnalytics.CalibrateTime(this.OnCalibrateDelegate, 0);
			Log.Instance.Info(ELogModule.Login, ELogAuthor.LW, "数数上报实例已重新创建！", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		Log.Instance.Error(ELogModule.Login, ELogAuthor.LW, "未找到 " + text + " 对应的数数上报配置", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x06010ACA RID: 68298 RVA: 0x0040CC63 File Offset: 0x0040AE63
	public void Report(string key, string jsonLog)
	{
		FThinkingAnalyticsForCSharp.Track(key, jsonLog, 0);
	}

	// Token: 0x06010ACB RID: 68299 RVA: 0x0040CC70 File Offset: 0x0040AE70
	private void OnCalibrate(int index)
	{
		if (!UThinkingAnalytics.HasInstanceTimeCalibrated(index))
		{
			Log.Instance.Info(ELogModule.LogReport, ELogAuthor.LW, "数数上报时间校准失败，可以因为以下问题导致：1.CDN数数上报配置错误；2.网络原因连接不上。", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
	}

	// Token: 0x17001524 RID: 5412
	// (get) Token: 0x06010ACC RID: 68300 RVA: 0x0040CCA4 File Offset: 0x0040AEA4
	public static RealThinkingAnalyticsReporter Instance
	{
		get
		{
			if (RealThinkingAnalyticsReporter._instance == null)
			{
				RealThinkingAnalyticsReporter._instance = new RealThinkingAnalyticsReporter();
				RealThinkingAnalyticsReporter._instance.OnInit();
			}
			return RealThinkingAnalyticsReporter._instance;
		}
	}

	// Token: 0x06010ACD RID: 68301 RVA: 0x0040CCC7 File Offset: 0x0040AEC7
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06010ACE RID: 68302 RVA: 0x0040CCC9 File Offset: 0x0040AEC9
	public static void ResetStaticDefaultValue()
	{
		RealThinkingAnalyticsReporter instance = RealThinkingAnalyticsReporter._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		RealThinkingAnalyticsReporter._instance = null;
	}

	// Token: 0x06010ACF RID: 68303 RVA: 0x0040CCE2 File Offset: 0x0040AEE2
	static RealThinkingAnalyticsReporter()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RealThinkingAnalyticsReporter.CreateStaticDefaultValue), new Action(RealThinkingAnalyticsReporter.ResetStaticDefaultValue));
	}

	// Token: 0x04007EF7 RID: 32503
	private readonly Stat TrackStat = Stat.Create("ThinkingAnalyticsReporter.Track", "", "");

	// Token: 0x04007EF8 RID: 32504
	[Nullable(2)]
	private FOnTimeCalibrated OnCalibrateDelegate;

	// Token: 0x04007EF9 RID: 32505
	[Nullable(2)]
	private static RealThinkingAnalyticsReporter _instance;
}
