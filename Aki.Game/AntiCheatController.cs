using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;

// Token: 0x020016E7 RID: 5863
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class AntiCheatController : UiControllerBase
{
	// Token: 0x0600A822 RID: 43042 RVA: 0x0025D0AF File Offset: 0x0025B2AF
	protected override bool OnInit()
	{
		this.DataUndefinedError = false;
		return true;
	}

	// Token: 0x0600A823 RID: 43043 RVA: 0x0025D0B9 File Offset: 0x0025B2B9
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.ChangePlayerInfoId, new Action<int>(this.OnChangePlayerInfoId));
		EventSystem.Instance.Add(EEventName.SendHeartbeat, new Action(this.CheckHeartbeat));
	}

	// Token: 0x0600A824 RID: 43044 RVA: 0x0025D0F0 File Offset: 0x0025B2F0
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.ChangePlayerInfoId, new Action<int>(this.OnChangePlayerInfoId));
		EventSystem.Instance.Remove(EEventName.SendHeartbeat, new Action(this.CheckHeartbeat));
	}

	// Token: 0x0600A825 RID: 43045 RVA: 0x0025D128 File Offset: 0x0025B328
	private void OnChangePlayerInfoId(int id)
	{
		int value = PlayerInfoModel.Instance.GetId().Value;
		ThirdPartySdkManager.Instance.SetUserInfoForTpSafe(value.ToString(), value);
		this.ReportIOSBundleInfo();
	}

	// Token: 0x0600A826 RID: 43046 RVA: 0x0025D160 File Offset: 0x0025B360
	private void ReportIOSBundleInfo()
	{
		if (Info.Instance.IsIosPlatform())
		{
			AntiCheatBundleData bundleData = AntiCheatModel.GetBundleData();
			LogReportController.Instance.LogReport(bundleData);
		}
	}

	// Token: 0x0600A827 RID: 43047 RVA: 0x0025D18C File Offset: 0x0025B38C
	private void CheckHeartbeat()
	{
		Number number = TimeUtil.Instance.GetServerTimeStamp();
		if ((number - this.LastHeartbeatReportTime) * 0.001f >= this.HEARTBEAT_REPORT_INTERVAL)
		{
			if (AntiCheatModel.Instance.HasHeartbeatException())
			{
				AntiCheatHeartbeatData heartbeatData = AntiCheatModel.Instance.GetHeartbeatData();
				if (heartbeatData != null)
				{
					LogReportController.Instance.LogReport(heartbeatData);
				}
				else if (!this.DataUndefinedError && KuroSdkController.Instance.CanUseSdk())
				{
					SdkLoginConfig sdkLoginConfig = LoginModel.Instance.GetSdkLoginConfig();
					string text = (sdkLoginConfig != null) ? sdkLoginConfig.Uid : null;
					if (text != null)
					{
						Log instance = Log.Instance;
						ELogModule module = ELogModule.Temp;
						ELogAuthor author = ELogAuthor.LRA;
						string message = "Data undefined";
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", text);
						instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
						this.DataUndefinedError = true;
					}
				}
				AntiCheatModel.Instance.ResetHeartbeatException();
			}
			this.LastHeartbeatReportTime = number;
		}
		Number a = number - this.LastHeartbeatTime;
		int heartbeatInterval = Heartbeat.Instance.GetHeartbeatInterval();
		Number b = 0.5f * (float)heartbeatInterval;
		if (this.LastHeartbeatTime > 0 && a <= b)
		{
			AntiCheatModel.Instance.HitHeartbeatException();
		}
		this.LastHeartbeatTime = number;
	}

	// Token: 0x17000DEE RID: 3566
	// (get) Token: 0x0600A828 RID: 43048 RVA: 0x0025D2C3 File Offset: 0x0025B4C3
	public static AntiCheatController Instance
	{
		get
		{
			return AntiCheatController._Instance;
		}
	}

	// Token: 0x0600A829 RID: 43049 RVA: 0x0025D2CA File Offset: 0x0025B4CA
	public static AntiCheatController GetOrCreateInstance()
	{
		if (AntiCheatController._Instance == null)
		{
			AntiCheatController.CreateInstance();
		}
		return AntiCheatController._Instance;
	}

	// Token: 0x0600A82A RID: 43050 RVA: 0x0025D2DE File Offset: 0x0025B4DE
	public static bool CreateInstance()
	{
		if (AntiCheatController._Instance != null)
		{
			return true;
		}
		AntiCheatController._Instance = new AntiCheatController();
		return true;
	}

	// Token: 0x0600A82B RID: 43051 RVA: 0x0025D2F4 File Offset: 0x0025B4F4
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600A82C RID: 43052 RVA: 0x0025D2F6 File Offset: 0x0025B4F6
	public static void ResetStaticDefaultValue()
	{
		AntiCheatController._Instance = null;
	}

	// Token: 0x0600A82D RID: 43053 RVA: 0x0025D2FE File Offset: 0x0025B4FE
	static AntiCheatController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(AntiCheatController.CreateStaticDefaultValue), new Action(AntiCheatController.ResetStaticDefaultValue));
	}

	// Token: 0x04004BB9 RID: 19385
	private const float HEARTBEAT_EXCEPTION_FACTOR = 0.5f;

	// Token: 0x04004BBA RID: 19386
	private Number HEARTBEAT_REPORT_INTERVAL = TimeUtil.Instance.Hour;

	// Token: 0x04004BBB RID: 19387
	private Number LastHeartbeatTime = 0;

	// Token: 0x04004BBC RID: 19388
	private Number LastHeartbeatReportTime = 0;

	// Token: 0x04004BBD RID: 19389
	private bool DataUndefinedError;

	// Token: 0x04004BBE RID: 19390
	[Nullable(2)]
	private static AntiCheatController _Instance;
}
