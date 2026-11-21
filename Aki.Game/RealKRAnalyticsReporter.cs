using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Typing;
using UnrealEngine;

// Token: 0x0200166A RID: 5738
[NullableContext(1)]
[Nullable(0)]
public class RealKRAnalyticsReporter : Singleton
{
	// Token: 0x0600DF62 RID: 57186 RVA: 0x00419600 File Offset: 0x00417800
	public void Init()
	{
		EventSystem.Instance.Add(EEventName.OnGetPlayerBasicInfo, new Action(RealKRAnalyticsReporter.Instance.OnGetPlayerBasicInfo));
		EventSystem.Instance.Add(EEventName.LogOut, new Action(RealKRAnalyticsReporter.Instance.LogOut));
		EventSystem.Instance.Add(EEventName.OnSetLoginServerId, new Action(RealKRAnalyticsReporter.Instance.SwitchToLoginServerConfig));
	}

	// Token: 0x0600DF63 RID: 57187 RVA: 0x00419670 File Offset: 0x00417870
	private void OnGetPlayerBasicInfo()
	{
		UKuroAnalytics.Login(PlayerInfoModel.Instance.GetId().ToString(), 0);
	}

	// Token: 0x0600DF64 RID: 57188 RVA: 0x0041969B File Offset: 0x0041789B
	private void LogOut()
	{
		UKuroAnalytics.Logout(0);
	}

	// Token: 0x0600DF65 RID: 57189 RVA: 0x004196A4 File Offset: 0x004178A4
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

	// Token: 0x0600DF66 RID: 57190 RVA: 0x0041985B File Offset: 0x00417A5B
	public void Report(string key, string jsonLog)
	{
		FKuroAnalyticsForCSharp.Track(key, jsonLog, 0);
	}

	// Token: 0x0600DF67 RID: 57191 RVA: 0x00419868 File Offset: 0x00417A68
	private void OnCalibrate(int index)
	{
		if (!UKuroAnalytics.HasInstanceTimeCalibrated(index))
		{
			Log.Instance.Info(ELogModule.LogReport, ELogAuthor.LW, "KuroData上报时间校准失败，可以因为以下问题导致：1.CDNKuroData上报配置错误；2.网络原因连接不上。", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
	}

	// Token: 0x1700155C RID: 5468
	// (get) Token: 0x0600DF68 RID: 57192 RVA: 0x0041989C File Offset: 0x00417A9C
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

	// Token: 0x0600DF69 RID: 57193 RVA: 0x004198BF File Offset: 0x00417ABF
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600DF6A RID: 57194 RVA: 0x004198C1 File Offset: 0x00417AC1
	public static void ResetStaticDefaultValue()
	{
		RealKRAnalyticsReporter instance = RealKRAnalyticsReporter._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		RealKRAnalyticsReporter._instance = null;
	}

	// Token: 0x0600DF6B RID: 57195 RVA: 0x004198DA File Offset: 0x00417ADA
	static RealKRAnalyticsReporter()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RealKRAnalyticsReporter.CreateStaticDefaultValue), new Action(RealKRAnalyticsReporter.ResetStaticDefaultValue));
	}

	// Token: 0x04008041 RID: 32833
	private readonly Stat TrackStat = Stat.Create("KRAnalyticsReporter.Track", "", "");

	// Token: 0x04008042 RID: 32834
	[Nullable(2)]
	private FKAOnTimeCalibrated OnCalibrateDelegate;

	// Token: 0x04008043 RID: 32835
	[Nullable(2)]
	private static RealKRAnalyticsReporter _instance;
}
