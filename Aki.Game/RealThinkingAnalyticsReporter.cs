using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Typing;
using UnrealEngine;

// Token: 0x02001669 RID: 5737
[NullableContext(1)]
[Nullable(0)]
public class RealThinkingAnalyticsReporter : Singleton
{
	// Token: 0x0600DF57 RID: 57175 RVA: 0x004192F0 File Offset: 0x004174F0
	public void Init()
	{
		EventSystem.Instance.Add(EEventName.OnGetPlayerBasicInfo, new Action(this.OnGetPlayerBasicInfo));
		EventSystem.Instance.Add(EEventName.LogOut, new Action(this.LogOut));
		EventSystem.Instance.Add(EEventName.OnSetLoginServerId, new Action(this.SwitchToLoginServerConfig));
	}

	// Token: 0x0600DF58 RID: 57176 RVA: 0x00419354 File Offset: 0x00417554
	private void OnGetPlayerBasicInfo()
	{
		UThinkingAnalytics.Login(PlayerInfoModel.Instance.GetId().ToString(), 0);
	}

	// Token: 0x0600DF59 RID: 57177 RVA: 0x0041937F File Offset: 0x0041757F
	private void LogOut()
	{
		UThinkingAnalytics.Logout(0);
	}

	// Token: 0x0600DF5A RID: 57178 RVA: 0x00419388 File Offset: 0x00417588
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

	// Token: 0x0600DF5B RID: 57179 RVA: 0x0041953F File Offset: 0x0041773F
	public void Report(string key, string jsonLog)
	{
		FThinkingAnalyticsForCSharp.Track(key, jsonLog, 0);
	}

	// Token: 0x0600DF5C RID: 57180 RVA: 0x0041954C File Offset: 0x0041774C
	private void OnCalibrate(int index)
	{
		if (!UThinkingAnalytics.HasInstanceTimeCalibrated(index))
		{
			Log.Instance.Info(ELogModule.LogReport, ELogAuthor.LW, "数数上报时间校准失败，可以因为以下问题导致：1.CDN数数上报配置错误；2.网络原因连接不上。", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
	}

	// Token: 0x1700155B RID: 5467
	// (get) Token: 0x0600DF5D RID: 57181 RVA: 0x00419580 File Offset: 0x00417780
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

	// Token: 0x0600DF5E RID: 57182 RVA: 0x004195A3 File Offset: 0x004177A3
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600DF5F RID: 57183 RVA: 0x004195A5 File Offset: 0x004177A5
	public static void ResetStaticDefaultValue()
	{
		RealThinkingAnalyticsReporter instance = RealThinkingAnalyticsReporter._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		RealThinkingAnalyticsReporter._instance = null;
	}

	// Token: 0x0600DF60 RID: 57184 RVA: 0x004195BE File Offset: 0x004177BE
	static RealThinkingAnalyticsReporter()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RealThinkingAnalyticsReporter.CreateStaticDefaultValue), new Action(RealThinkingAnalyticsReporter.ResetStaticDefaultValue));
	}

	// Token: 0x0400803E RID: 32830
	private readonly Stat TrackStat = Stat.Create("ThinkingAnalyticsReporter.Track", "", "");

	// Token: 0x0400803F RID: 32831
	[Nullable(2)]
	private FOnTimeCalibrated OnCalibrateDelegate;

	// Token: 0x04008040 RID: 32832
	[Nullable(2)]
	private static RealThinkingAnalyticsReporter _instance;
}
