using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Typing;
using UnrealEngine;

// Token: 0x02001582 RID: 5506
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class LogReportController : UiControllerBase
{
	// Token: 0x0600DCB3 RID: 56499 RVA: 0x004161C4 File Offset: 0x004143C4
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

	// Token: 0x0600DCB4 RID: 56500 RVA: 0x00416247 File Offset: 0x00414447
	protected override bool OnClear()
	{
		if (this.LogReportTimer != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.LogReportTimer);
			this.LogReportTimer = null;
		}
		return true;
	}

	// Token: 0x0600DCB5 RID: 56501 RVA: 0x0041626C File Offset: 0x0041446C
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

	// Token: 0x0600DCB6 RID: 56502 RVA: 0x004162E8 File Offset: 0x004144E8
	public void UnitLogReport(IUnitLogData logData)
	{
		AssemblyLogData timerAssemblyLogData = LogReportModel.Instance.GetTimerAssemblyLogData(logData.event_id);
		if (timerAssemblyLogData != null)
		{
			timerAssemblyLogData.SetLogDataToAssembly(logData);
		}
	}

	// Token: 0x0600DCB7 RID: 56503 RVA: 0x00416310 File Offset: 0x00414510
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

	// Token: 0x0600DCB8 RID: 56504 RVA: 0x00416444 File Offset: 0x00414644
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

	// Token: 0x17001489 RID: 5257
	// (get) Token: 0x0600DCB9 RID: 56505 RVA: 0x00416554 File Offset: 0x00414754
	public static LogReportController Instance
	{
		get
		{
			return LogReportController._Instance;
		}
	}

	// Token: 0x0600DCBA RID: 56506 RVA: 0x0041655B File Offset: 0x0041475B
	public static LogReportController GetOrCreateInstance()
	{
		if (LogReportController._Instance == null)
		{
			LogReportController.CreateInstance();
		}
		return LogReportController._Instance;
	}

	// Token: 0x0600DCBB RID: 56507 RVA: 0x0041656F File Offset: 0x0041476F
	public static bool CreateInstance()
	{
		if (LogReportController._Instance != null)
		{
			return true;
		}
		LogReportController._Instance = new LogReportController();
		return true;
	}

	// Token: 0x0600DCBC RID: 56508 RVA: 0x00416585 File Offset: 0x00414785
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600DCBD RID: 56509 RVA: 0x00416587 File Offset: 0x00414787
	public static void ResetStaticDefaultValue()
	{
		LogReportController._Instance = null;
	}

	// Token: 0x0600DCBE RID: 56510 RVA: 0x0041658F File Offset: 0x0041478F
	static LogReportController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(LogReportController.CreateStaticDefaultValue), new Action(LogReportController.ResetStaticDefaultValue));
	}

	// Token: 0x04007B17 RID: 31511
	private string ClientVersion = "";

	// Token: 0x04007B18 RID: 31512
	[Nullable(2)]
	private TimerHandle LogReportTimer;

	// Token: 0x04007B19 RID: 31513
	[Nullable(2)]
	private static LogReportController _Instance;
}
