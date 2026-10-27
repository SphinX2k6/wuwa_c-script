using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020020A9 RID: 8361
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class GamepadLogReportController : UiControllerBase
{
	// Token: 0x06010823 RID: 67619 RVA: 0x00409514 File Offset: 0x00407714
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.LocalStorageInitPlayerId, new Action(this.StartGamepadReportLog));
		EventSystem.Instance.Add<EInputControllerMainType, EInputControllerMainType>(EEventName.InputControllerMainTypeChange, new Action<EInputControllerMainType, EInputControllerMainType>(this.OnInputControllerMainTypeChange));
		EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerTypeChange));
	}

	// Token: 0x06010824 RID: 67620 RVA: 0x00409578 File Offset: 0x00407778
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.LocalStorageInitPlayerId, new Action(this.StartGamepadReportLog));
		EventSystem.Instance.Remove(EEventName.InputControllerMainTypeChange, new Action<EInputControllerMainType, EInputControllerMainType>(this.OnInputControllerMainTypeChange));
		EventSystem.Instance.Remove(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerTypeChange));
	}

	// Token: 0x06010825 RID: 67621 RVA: 0x004095DC File Offset: 0x004077DC
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

	// Token: 0x06010826 RID: 67622 RVA: 0x00409636 File Offset: 0x00407836
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

	// Token: 0x06010827 RID: 67623 RVA: 0x00409660 File Offset: 0x00407860
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

	// Token: 0x06010828 RID: 67624 RVA: 0x004096A9 File Offset: 0x004078A9
	private void StartGamepadReportLog()
	{
		this.TryReportLog();
		this.InitGamepadLogReport();
	}

	// Token: 0x06010829 RID: 67625 RVA: 0x004096B8 File Offset: 0x004078B8
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

	// Token: 0x0601082A RID: 67626 RVA: 0x00409784 File Offset: 0x00407984
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

	// Token: 0x0601082B RID: 67627 RVA: 0x004097BC File Offset: 0x004079BC
	private void EnterGamepadModeLog()
	{
		string currentSuitName = this.GetCurrentSuitName();
		this.ActiveSuitName = currentSuitName;
		this.LastOperateTime = TimeUtil.Instance.GetServerTimeStamp();
		this.GetOrCreateUsage(currentSuitName).Count++;
		this.SaveUsage();
		this.StartHeartbeat();
	}

	// Token: 0x0601082C RID: 67628 RVA: 0x00409807 File Offset: 0x00407A07
	private void ExitGamepadModeLog()
	{
		this.SettleActiveTime();
		this.ActiveSuitName = "";
		this.StopHeartbeat();
	}

	// Token: 0x0601082D RID: 67629 RVA: 0x00409820 File Offset: 0x00407A20
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

	// Token: 0x0601082E RID: 67630 RVA: 0x0040987F File Offset: 0x00407A7F
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

	// Token: 0x0601082F RID: 67631 RVA: 0x004098B7 File Offset: 0x00407AB7
	private void StopHeartbeat()
	{
		if (this.HeartbeatHandle == null)
		{
			return;
		}
		TimerSystem.RealTimeInstance.Remove(this.HeartbeatHandle);
		this.HeartbeatHandle = null;
	}

	// Token: 0x06010830 RID: 67632 RVA: 0x004098DC File Offset: 0x00407ADC
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

	// Token: 0x06010831 RID: 67633 RVA: 0x00409910 File Offset: 0x00407B10
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

	// Token: 0x06010832 RID: 67634 RVA: 0x0040995C File Offset: 0x00407B5C
	private string GetCurrentSuitName()
	{
		string currentActiveGamepadName = UKismetSystemLibrary.GetCurrentActiveGamepadName();
		if (string.IsNullOrEmpty(currentActiveGamepadName) || !(currentActiveGamepadName != "None"))
		{
			return "Unknown";
		}
		return currentActiveGamepadName;
	}

	// Token: 0x1700145A RID: 5210
	// (get) Token: 0x06010833 RID: 67635 RVA: 0x0040998B File Offset: 0x00407B8B
	public static GamepadLogReportController Instance
	{
		get
		{
			return GamepadLogReportController._Instance;
		}
	}

	// Token: 0x06010834 RID: 67636 RVA: 0x00409992 File Offset: 0x00407B92
	public static GamepadLogReportController GetOrCreateInstance()
	{
		if (GamepadLogReportController._Instance == null)
		{
			GamepadLogReportController.CreateInstance();
		}
		return GamepadLogReportController._Instance;
	}

	// Token: 0x06010835 RID: 67637 RVA: 0x004099A6 File Offset: 0x00407BA6
	public static bool CreateInstance()
	{
		if (GamepadLogReportController._Instance != null)
		{
			return true;
		}
		GamepadLogReportController._Instance = new GamepadLogReportController();
		return true;
	}

	// Token: 0x06010836 RID: 67638 RVA: 0x004099BC File Offset: 0x00407BBC
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06010837 RID: 67639 RVA: 0x004099BE File Offset: 0x00407BBE
	public static void ResetStaticDefaultValue()
	{
		GamepadLogReportController._Instance = null;
	}

	// Token: 0x06010838 RID: 67640 RVA: 0x004099C6 File Offset: 0x00407BC6
	static GamepadLogReportController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GamepadLogReportController.CreateStaticDefaultValue), new Action(GamepadLogReportController.ResetStaticDefaultValue));
	}

	// Token: 0x04007A11 RID: 31249
	private const float HEARTBEAT_INTERVAL = 60000f;

	// Token: 0x04007A12 RID: 31250
	private bool IsStart;

	// Token: 0x04007A13 RID: 31251
	private string ActiveSuitName = "";

	// Token: 0x04007A14 RID: 31252
	private double LastOperateTime;

	// Token: 0x04007A15 RID: 31253
	private Dictionary<string, GamepadTypeUsage> UsageMap = new Dictionary<string, GamepadTypeUsage>();

	// Token: 0x04007A16 RID: 31254
	[Nullable(2)]
	private TimerHandle HeartbeatHandle;

	// Token: 0x04007A17 RID: 31255
	[Nullable(2)]
	private static GamepadLogReportController _Instance;
}
