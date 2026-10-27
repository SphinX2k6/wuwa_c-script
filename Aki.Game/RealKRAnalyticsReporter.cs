using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Typing;
using UnrealEngine;

// Token: 0x02002186 RID: 8582
[NullableContext(1)]
[Nullable(0)]
public class RealKRAnalyticsReporter : Singleton
{
	// Token: 0x06010AD1 RID: 68305 RVA: 0x0040CD24 File Offset: 0x0040AF24
	public void Init()
	{
		EventSystem.Instance.Add(EEventName.OnGetPlayerBasicInfo, new Action(RealKRAnalyticsReporter.Instance.OnGetPlayerBasicInfo));
		EventSystem.Instance.Add(EEventName.LogOut, new Action(RealKRAnalyticsReporter.Instance.LogOut));
		EventSystem.Instance.Add(EEventName.OnSetLoginServerId, new Action(RealKRAnalyticsReporter.Instance.SwitchToLoginServerConfig));
	}

	// Token: 0x06010AD2 RID: 68306 RVA: 0x0040CD94 File Offset: 0x0040AF94
	private void OnGetPlayerBasicInfo()
	{
		UKuroAnalytics.Login(PlayerInfoModel.Instance.GetId().ToString(), 0);
	}

	// Token: 0x06010AD3 RID: 68307 RVA: 0x0040CDBF File Offset: 0x0040AFBF
	private void LogOut()
	{
		UKuroAnalytics.Logout(0);
	}

	// Token: 0x06010AD4 RID: 68308 RVA: 0x0040CDC8 File Offset: 0x0040AFC8
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
		if (((loginServerById != null) ? loginServerById.KDCfg : null) != null)
		{
			itdconfig = loginServerById.KDCfg;
			Log instance2 = Log.Instance;
			ELogModule module = ELogModule.Log;
			ELogAuthor author = ELogAuthor.LFJW;
			string message = "使用LoginServer的KuroData配置";
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
			if (UKuroAnalytics.HasInstanceInitialized(0))
			{
				bool flag = false;
				if (text != null && UKuroAnalytics.GetServerUrl(0) != url)
				{
					flag = true;
				}
				if (appID != null && UKuroAnalytics.GetAppId(0) != appID)
				{
					flag = true;
				}
				if (flag)
				{
					UKuroAnalytics.DestroyInstance(0, true);
				}
			}
			UKuroAnalytics.InitializeDefaultInsWithURL_Appid(url, appID, 1f, 1000, 10000f, true, 10f, true);
			if (this.OnCalibrateDelegate == null)
			{
				this.OnCalibrateDelegate = DelegateUtils.ToManualReleaseDelegate<FKAOnTimeCalibrated>(new Action<int>(this.OnCalibrate));
			}
			UKuroAnalytics.CalibrateTime(this.OnCalibrateDelegate, 0);
			Log.Instance.Info(ELogModule.Login, ELogAuthor.LW, "KuroData上报实例已重新创建！", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		Log.Instance.Error(ELogModule.Login, ELogAuthor.LW, "未找到 " + text + " 对应的KuroData上报配置", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x06010AD5 RID: 68309 RVA: 0x0040CF7F File Offset: 0x0040B17F
	public void Report(string key, string jsonLog)
	{
		FKuroAnalyticsForCSharp.Track(key, jsonLog, 0);
	}

	// Token: 0x06010AD6 RID: 68310 RVA: 0x0040CF8C File Offset: 0x0040B18C
	private void OnCalibrate(int index)
	{
		if (!UKuroAnalytics.HasInstanceTimeCalibrated(index))
		{
			Log.Instance.Info(ELogModule.LogReport, ELogAuthor.LW, "KuroData上报时间校准失败，可以因为以下问题导致：1.CDNKuroData上报配置错误；2.网络原因连接不上。", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
	}

	// Token: 0x17001525 RID: 5413
	// (get) Token: 0x06010AD7 RID: 68311 RVA: 0x0040CFC0 File Offset: 0x0040B1C0
	public static RealKRAnalyticsReporter Instance
	{
		get
		{
			if (RealKRAnalyticsReporter._instance == null)
			{
				RealKRAnalyticsReporter._instance = new RealKRAnalyticsReporter();
				RealKRAnalyticsReporter._instance.OnInit();
			}
			return RealKRAnalyticsReporter._instance;
		}
	}

	// Token: 0x06010AD8 RID: 68312 RVA: 0x0040CFE3 File Offset: 0x0040B1E3
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06010AD9 RID: 68313 RVA: 0x0040CFE5 File Offset: 0x0040B1E5
	public static void ResetStaticDefaultValue()
	{
		RealKRAnalyticsReporter instance = RealKRAnalyticsReporter._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		RealKRAnalyticsReporter._instance = null;
	}

	// Token: 0x06010ADA RID: 68314 RVA: 0x0040CFFE File Offset: 0x0040B1FE
	static RealKRAnalyticsReporter()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RealKRAnalyticsReporter.CreateStaticDefaultValue), new Action(RealKRAnalyticsReporter.ResetStaticDefaultValue));
	}

	// Token: 0x04007EFA RID: 32506
	private readonly Stat TrackStat = Stat.Create("KRAnalyticsReporter.Track", "", "");

	// Token: 0x04007EFB RID: 32507
	[Nullable(2)]
	private FKAOnTimeCalibrated OnCalibrateDelegate;

	// Token: 0x04007EFC RID: 32508
	[Nullable(2)]
	private static RealKRAnalyticsReporter _instance;
}
