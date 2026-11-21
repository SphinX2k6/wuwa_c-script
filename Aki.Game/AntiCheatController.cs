using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;

// Token: 0x02000B9F RID: 2975
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class AntiCheatController : UiControllerBase
{
	// Token: 0x06007C02 RID: 31746 RVA: 0x002674CF File Offset: 0x002656CF
	protected override bool OnInit()
	{
		this.DataUndefinedError = false;
		return true;
	}

	// Token: 0x06007C03 RID: 31747 RVA: 0x002674D9 File Offset: 0x002656D9
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.ChangePlayerInfoId, new Action<int>(this.OnChangePlayerInfoId));
		EventSystem.Instance.Add(EEventName.SendHeartbeat, new Action(this.CheckHeartbeat));
	}

	// Token: 0x06007C04 RID: 31748 RVA: 0x00267510 File Offset: 0x00265710
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.ChangePlayerInfoId, new Action<int>(this.OnChangePlayerInfoId));
		EventSystem.Instance.Remove(EEventName.SendHeartbeat, new Action(this.CheckHeartbeat));
	}

	// Token: 0x06007C05 RID: 31749 RVA: 0x00267548 File Offset: 0x00265748
	private void OnChangePlayerInfoId(int id)
	{
		int value = PlayerInfoModel.Instance.GetId().Value;
		ThirdPartySdkManager.Instance.SetUserInfoForTpSafe(value.ToString(), value);
		this.ReportIOSBundleInfo();
	}

	// Token: 0x06007C06 RID: 31750 RVA: 0x00267580 File Offset: 0x00265780
	private void ReportIOSBundleInfo()
	{
		if (Info.Instance.IsIosPlatform())
		{
			AntiCheatBundleData bundleData = AntiCheatModel.GetBundleData();
			LogReportController.Instance.LogReport(bundleData);
		}
	}

	// Token: 0x06007C07 RID: 31751 RVA: 0x002675AC File Offset: 0x002657AC
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

	// Token: 0x17000E0F RID: 3599
	// (get) Token: 0x06007C08 RID: 31752 RVA: 0x002676E3 File Offset: 0x002658E3
	public static AntiCheatController Instance
	{
		get
		{
			return AntiCheatController._Instance;
		}
	}

	// Token: 0x06007C09 RID: 31753 RVA: 0x002676EA File Offset: 0x002658EA
	public static AntiCheatController GetOrCreateInstance()
	{
		if (AntiCheatController._Instance == null)
		{
			AntiCheatController.CreateInstance();
		}
		return AntiCheatController._Instance;
	}

	// Token: 0x06007C0A RID: 31754 RVA: 0x002676FE File Offset: 0x002658FE
	public static bool CreateInstance()
	{
		if (AntiCheatController._Instance != null)
		{
			return true;
		}
		AntiCheatController._Instance = new AntiCheatController();
		return true;
	}

	// Token: 0x06007C0B RID: 31755 RVA: 0x00267714 File Offset: 0x00265914
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06007C0C RID: 31756 RVA: 0x00267716 File Offset: 0x00265916
	public static void ResetStaticDefaultValue()
	{
		AntiCheatController._Instance = null;
	}

	// Token: 0x06007C0D RID: 31757 RVA: 0x0026771E File Offset: 0x0026591E
	static AntiCheatController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(AntiCheatController.CreateStaticDefaultValue), new Action(AntiCheatController.ResetStaticDefaultValue));
	}

	// Token: 0x04004C60 RID: 19552
	private const float HEARTBEAT_EXCEPTION_FACTOR = 0.5f;

	// Token: 0x04004C61 RID: 19553
	private Number HEARTBEAT_REPORT_INTERVAL = TimeUtil.Instance.Hour;

	// Token: 0x04004C62 RID: 19554
	private Number LastHeartbeatTime = 0;

	// Token: 0x04004C63 RID: 19555
	private Number LastHeartbeatReportTime = 0;

	// Token: 0x04004C64 RID: 19556
	private bool DataUndefinedError;

	// Token: 0x04004C65 RID: 19557
	[Nullable(2)]
	private static AntiCheatController _Instance;
}
