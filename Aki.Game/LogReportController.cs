using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Typing;
using UnrealEngine;

// Token: 0x020020AB RID: 8363
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class LogReportController : UiControllerBase
{
	// Token: 0x06010843 RID: 67651 RVA: 0x00409ABC File Offset: 0x00407CBC
	protected override bool OnInit()
	{
		this.ClientVersion = BaseConfigController.Instance.GetVersionString();
		int? intConfig = ConfigCommonParamById.GetIntConfig("LogReportTimeCheckPeriod");
		if (intConfig != null)
		{
			int? num = intConfig;
			int num2 = 0;
			if (!(num.GetValueOrDefault() == num2 & num != null))
			{
				this.LogReportTimer = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.CheckLogReport), (float)(intConfig.Value * TimeUtil.Instance.InverseMillisecond), 1f, null, null, false);
				return true;
			}
		}
		return false;
	}

	// Token: 0x06010844 RID: 67652 RVA: 0x00409B3F File Offset: 0x00407D3F
	protected override bool OnClear()
	{
		if (this.LogReportTimer != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.LogReportTimer);
			this.LogReportTimer = null;
		}
		return true;
	}

	// Token: 0x06010845 RID: 67653 RVA: 0x00409B64 File Offset: 0x00407D64
	public void LogReport(CommonLogData logData)
	{
		if (logData.event_id == "")
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.LogReport;
			ELogAuthor author = ELogAuthor.MZJ;
			string message = "event_id 不能为空";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("logData", logData);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		this.SetLogDataInfo(logData);
		ThinkingAnalyticsReporter.Instance.Report("c" + logData.event_id, Json.Encode(logData, null) ?? "");
	}

	// Token: 0x06010846 RID: 67654 RVA: 0x00409BE0 File Offset: 0x00407DE0
	public void UnitLogReport(IUnitLogData logData)
	{
		AssemblyLogData timerAssemblyLogData = LogReportModel.Instance.GetTimerAssemblyLogData(logData.event_id);
		if (timerAssemblyLogData != null)
		{
			timerAssemblyLogData.SetLogDataToAssembly(logData);
		}
	}

	// Token: 0x06010847 RID: 67655 RVA: 0x00409C08 File Offset: 0x00407E08
	private void SetLogDataInfo(CommonLogData logData)
	{
		logData.client_version = this.ClientVersion;
		logData.platform = LoginModel.Instance.Platform;
		PlayerCommonLogData playerCommonLogData = logData as PlayerCommonLogData;
		if (playerCommonLogData != null)
		{
			PlayerCommonLogData playerCommonLogData2 = playerCommonLogData;
			int? num = PlayerInfoModel.Instance.GetId();
			playerCommonLogData2.player_id = (((num != null) ? num.GetValueOrDefault().ToString() : null) ?? "0");
			playerCommonLogData.client_platform = KuroApplication.IniPlatformName();
			if (KuroSdkController.Instance.CanUseSdk())
			{
				playerCommonLogData.device_id = UKuroSDKManager.GetBasicInfo().DeviceId;
			}
			playerCommonLogData.net_status = PlatformModel.Instance.GetNetStatus().ToString();
			playerCommonLogData.world_level = (WorldLevelModel.Instance.CurWorldLevel.ToString() ?? "0");
			PlayerCommonLogData playerCommonLogData3 = playerCommonLogData;
			num = FunctionModel.Instance.GetPlayerLevel();
			playerCommonLogData3.player_level = (((num != null) ? num.GetValueOrDefault().ToString() : null) ?? "0");
			playerCommonLogData.world_own_id = (GameModeModel.Instance.IsMulti ? CreatureModel.Instance.GetWorldOwner().ToString() : "0");
		}
	}

	// Token: 0x06010848 RID: 67656 RVA: 0x00409D3C File Offset: 0x00407F3C
	private void CheckLogReport(float delta)
	{
		IEnumerable<AssemblyLogData> allTimerAssemblyLogData = LogReportModel.Instance.GetAllTimerAssemblyLogData();
		List<string> list = new List<string>();
		foreach (AssemblyLogData assemblyLogData in allTimerAssemblyLogData)
		{
			if (assemblyLogData.SendTimePeriod != 0)
			{
				assemblyLogData.SendTimeAccumulate += (double)delta;
				if (assemblyLogData.SendTimeAccumulate >= (double)assemblyLogData.SendTimePeriod)
				{
					assemblyLogData.SendTimeAccumulate = 0.0;
					if (assemblyLogData.CheckIsSend())
					{
						list.Add(assemblyLogData.AssemblyId);
						CommonLogData assemblyLogInfo = assemblyLogData.AssemblyLogInfo;
						this.SetLogDataInfo(assemblyLogInfo);
						ThinkingAnalyticsReporter.Instance.Report("c" + assemblyLogInfo.event_id, Json.Encode(assemblyLogInfo, null) ?? "");
						assemblyLogData.AfterSend();
					}
				}
			}
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.LogReport;
		ELogAuthor author = ELogAuthor.YYZ;
		string message = "已发送集合日志Id";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("AssemblyIdList", list);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x1700145C RID: 5212
	// (get) Token: 0x06010849 RID: 67657 RVA: 0x00409E4C File Offset: 0x0040804C
	public static LogReportController Instance
	{
		get
		{
			return LogReportController._Instance;
		}
	}

	// Token: 0x0601084A RID: 67658 RVA: 0x00409E53 File Offset: 0x00408053
	public static LogReportController GetOrCreateInstance()
	{
		if (LogReportController._Instance == null)
		{
			LogReportController.CreateInstance();
		}
		return LogReportController._Instance;
	}

	// Token: 0x0601084B RID: 67659 RVA: 0x00409E67 File Offset: 0x00408067
	public static bool CreateInstance()
	{
		if (LogReportController._Instance != null)
		{
			return true;
		}
		LogReportController._Instance = new LogReportController();
		return true;
	}

	// Token: 0x0601084C RID: 67660 RVA: 0x00409E7D File Offset: 0x0040807D
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601084D RID: 67661 RVA: 0x00409E7F File Offset: 0x0040807F
	public static void ResetStaticDefaultValue()
	{
		LogReportController._Instance = null;
	}

	// Token: 0x0601084E RID: 67662 RVA: 0x00409E87 File Offset: 0x00408087
	static LogReportController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(LogReportController.CreateStaticDefaultValue), new Action(LogReportController.ResetStaticDefaultValue));
	}

	// Token: 0x04007A19 RID: 31257
	private string ClientVersion = "";

	// Token: 0x04007A1A RID: 31258
	[Nullable(2)]
	private TimerHandle LogReportTimer;

	// Token: 0x04007A1B RID: 31259
	[Nullable(2)]
	private static LogReportController _Instance;
}
