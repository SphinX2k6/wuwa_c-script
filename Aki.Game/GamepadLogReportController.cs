using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001580 RID: 5504
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class GamepadLogReportController : UiControllerBase
{
	// Token: 0x0600DC93 RID: 56467 RVA: 0x00415C1C File Offset: 0x00413E1C
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.LocalStorageInitPlayerId, new Action(this.StartGamepadReportLog));
		EventSystem.Instance.Add<EInputControllerMainType, EInputControllerMainType>(EEventName.InputControllerMainTypeChange, new Action<EInputControllerMainType, EInputControllerMainType>(this.OnInputControllerMainTypeChange));
		EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerTypeChange));
	}

	// Token: 0x0600DC94 RID: 56468 RVA: 0x00415C80 File Offset: 0x00413E80
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.LocalStorageInitPlayerId, new Action(this.StartGamepadReportLog));
		EventSystem.Instance.Remove(EEventName.InputControllerMainTypeChange, new Action<EInputControllerMainType, EInputControllerMainType>(this.OnInputControllerMainTypeChange));
		EventSystem.Instance.Remove(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerTypeChange));
	}

	// Token: 0x0600DC95 RID: 56469 RVA: 0x00415CE4 File Offset: 0x00413EE4
	protected override bool OnClear()
	{
		if (Info.Instance.IsInGamepad() && this.IsStart)
		{
			this.SettleActiveTime();
		}
		this.StopHeartbeat();
		this.IsStart = false;
		this.ActiveSuitName = "";
		this.LastOperateTime = 0.0;
		this.UsageMap = new Dictionary<string, GamepadTypeUsage>();
		return true;
	}

	// Token: 0x0600DC96 RID: 56470 RVA: 0x00415D3E File Offset: 0x00413F3E
	private void OnInputControllerMainTypeChange(EInputControllerMainType last, EInputControllerMainType now)
	{
		if (!this.IsStart)
		{
			return;
		}
		if (last != EInputControllerMainType.Gamepad && now != EInputControllerMainType.Gamepad)
		{
			return;
		}
		if (now == EInputControllerMainType.Gamepad)
		{
			this.EnterGamepadModeLog();
			return;
		}
		if (last == EInputControllerMainType.Gamepad)
		{
			this.ExitGamepadModeLog();
		}
	}

	// Token: 0x0600DC97 RID: 56471 RVA: 0x00415D68 File Offset: 0x00413F68
	private void OnInputControllerTypeChange(EInputControllerType last, EInputControllerType now)
	{
		if (!this.IsStart)
		{
			return;
		}
		EInputControllerMainType einputControllerMainType;
		EInputControllerMainType einputControllerMainType2;
		if (!InfoDefine.InputControllerMainTypeMap.TryGetValue(last, out einputControllerMainType) || !InfoDefine.InputControllerMainTypeMap.TryGetValue(now, out einputControllerMainType2) || einputControllerMainType != EInputControllerMainType.Gamepad || einputControllerMainType2 != EInputControllerMainType.Gamepad)
		{
			return;
		}
		this.SettleActiveTime();
		this.EnterGamepadModeLog();
	}

	// Token: 0x0600DC98 RID: 56472 RVA: 0x00415DB1 File Offset: 0x00413FB1
	private void StartGamepadReportLog()
	{
		this.TryReportLog();
		this.InitGamepadLogReport();
	}

	// Token: 0x0600DC99 RID: 56473 RVA: 0x00415DC0 File Offset: 0x00413FC0
	private void TryReportLog()
	{
		Dictionary<string, GamepadTypeUsage> player = LocalStorage.GetPlayer<Dictionary<string, GamepadTypeUsage>>(ELocalStoragePlayerKey.GamepadUsageRecord, null);
		if (player == null)
		{
			return;
		}
		foreach (KeyValuePair<string, GamepadTypeUsage> keyValuePair in player)
		{
			string key = keyValuePair.Key;
			GamepadTypeUsage value = keyValuePair.Value;
			if (value.Count > 0 || value.Time > 0.0)
			{
				GamepadActiveEvent logData = new GamepadActiveEvent
				{
					i_gamepad_count = value.Count,
					i_gamepad_time = (float)Math.Floor(value.Time * TimeUtil.Instance.Millisecond),
					s_suit_name = key
				};
				LogReportController.Instance.LogReport(logData);
			}
		}
	}

	// Token: 0x0600DC9A RID: 56474 RVA: 0x00415E8C File Offset: 0x0041408C
	private void InitGamepadLogReport()
	{
		this.IsStart = true;
		this.ActiveSuitName = "";
		this.UsageMap = new Dictionary<string, GamepadTypeUsage>();
		this.SaveUsage();
		if (Info.Instance.IsInGamepad())
		{
			this.EnterGamepadModeLog();
		}
	}

	// Token: 0x0600DC9B RID: 56475 RVA: 0x00415EC4 File Offset: 0x004140C4
	private void EnterGamepadModeLog()
	{
		string currentSuitName = this.GetCurrentSuitName();
		this.ActiveSuitName = currentSuitName;
		this.LastOperateTime = TimeUtil.Instance.GetServerTimeStamp();
		this.GetOrCreateUsage(currentSuitName).Count++;
		this.SaveUsage();
		this.StartHeartbeat();
	}

	// Token: 0x0600DC9C RID: 56476 RVA: 0x00415F0F File Offset: 0x0041410F
	private void ExitGamepadModeLog()
	{
		this.SettleActiveTime();
		this.ActiveSuitName = "";
		this.StopHeartbeat();
	}

	// Token: 0x0600DC9D RID: 56477 RVA: 0x00415F28 File Offset: 0x00414128
	private void SettleActiveTime()
	{
		if (string.IsNullOrEmpty(this.ActiveSuitName))
		{
			return;
		}
		double serverTimeStamp = TimeUtil.Instance.GetServerTimeStamp();
		this.GetOrCreateUsage(this.ActiveSuitName).Time += (serverTimeStamp - this.LastOperateTime) * (double)TimeUtil.Instance.InverseMillisecond;
		this.LastOperateTime = serverTimeStamp;
		this.SaveUsage();
	}

	// Token: 0x0600DC9E RID: 56478 RVA: 0x00415F87 File Offset: 0x00414187
	private void StartHeartbeat()
	{
		if (this.HeartbeatHandle != null)
		{
			return;
		}
		this.HeartbeatHandle = TimerSystem.RealTimeInstance.Forever(delegate(float _)
		{
			this.SettleActiveTime();
		}, 60000f, 1f, null, "GamepadUsageHeartbeat", true);
	}

	// Token: 0x0600DC9F RID: 56479 RVA: 0x00415FBF File Offset: 0x004141BF
	private void StopHeartbeat()
	{
		if (this.HeartbeatHandle == null)
		{
			return;
		}
		TimerSystem.RealTimeInstance.Remove(this.HeartbeatHandle);
		this.HeartbeatHandle = null;
	}

	// Token: 0x0600DCA0 RID: 56480 RVA: 0x00415FE4 File Offset: 0x004141E4
	private GamepadTypeUsage GetOrCreateUsage(string suitName)
	{
		GamepadTypeUsage gamepadTypeUsage;
		if (!this.UsageMap.TryGetValue(suitName, out gamepadTypeUsage))
		{
			gamepadTypeUsage = new GamepadTypeUsage();
			this.UsageMap[suitName] = gamepadTypeUsage;
		}
		return gamepadTypeUsage;
	}

	// Token: 0x0600DCA1 RID: 56481 RVA: 0x00416018 File Offset: 0x00414218
	private void SaveUsage()
	{
		LocalStorage.SetPlayer<Dictionary<string, GamepadTypeUsage>>(ELocalStoragePlayerKey.GamepadUsageRecord, this.UsageMap);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.LogReport;
		ELogAuthor author = ELogAuthor.SYB;
		string message = "手柄埋点记录";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("UsageMap", this.UsageMap);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x0600DCA2 RID: 56482 RVA: 0x00416064 File Offset: 0x00414264
	private string GetCurrentSuitName()
	{
		string currentActiveGamepadName = UKismetSystemLibrary.GetCurrentActiveGamepadName();
		if (string.IsNullOrEmpty(currentActiveGamepadName) || !(currentActiveGamepadName != "None"))
		{
			return "Unknown";
		}
		return currentActiveGamepadName;
	}

	// Token: 0x17001487 RID: 5255
	// (get) Token: 0x0600DCA3 RID: 56483 RVA: 0x00416093 File Offset: 0x00414293
	public static GamepadLogReportController Instance
	{
		get
		{
			return GamepadLogReportController._Instance;
		}
	}

	// Token: 0x0600DCA4 RID: 56484 RVA: 0x0041609A File Offset: 0x0041429A
	public static GamepadLogReportController GetOrCreateInstance()
	{
		if (GamepadLogReportController._Instance == null)
		{
			GamepadLogReportController.CreateInstance();
		}
		return GamepadLogReportController._Instance;
	}

	// Token: 0x0600DCA5 RID: 56485 RVA: 0x004160AE File Offset: 0x004142AE
	public static bool CreateInstance()
	{
		if (GamepadLogReportController._Instance != null)
		{
			return true;
		}
		GamepadLogReportController._Instance = new GamepadLogReportController();
		return true;
	}

	// Token: 0x0600DCA6 RID: 56486 RVA: 0x004160C4 File Offset: 0x004142C4
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600DCA7 RID: 56487 RVA: 0x004160C6 File Offset: 0x004142C6
	public static void ResetStaticDefaultValue()
	{
		GamepadLogReportController._Instance = null;
	}

	// Token: 0x0600DCA8 RID: 56488 RVA: 0x004160CE File Offset: 0x004142CE
	static GamepadLogReportController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GamepadLogReportController.CreateStaticDefaultValue), new Action(GamepadLogReportController.ResetStaticDefaultValue));
	}

	// Token: 0x04007B0F RID: 31503
	private const float HEARTBEAT_INTERVAL = 60000f;

	// Token: 0x04007B10 RID: 31504
	private bool IsStart;

	// Token: 0x04007B11 RID: 31505
	private string ActiveSuitName = "";

	// Token: 0x04007B12 RID: 31506
	private double LastOperateTime;

	// Token: 0x04007B13 RID: 31507
	private Dictionary<string, GamepadTypeUsage> UsageMap = new Dictionary<string, GamepadTypeUsage>();

	// Token: 0x04007B14 RID: 31508
	[Nullable(2)]
	private TimerHandle HeartbeatHandle;

	// Token: 0x04007B15 RID: 31509
	[Nullable(2)]
	private static GamepadLogReportController _Instance;
}
