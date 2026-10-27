using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Ui;

// Token: 0x020034A5 RID: 13477
public class UiInteractLogReport : IStaticVariableResetter
{
	// Token: 0x0601D573 RID: 120179 RVA: 0x0082DB05 File Offset: 0x0082BD05
	static UiInteractLogReport()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(UiInteractLogReport.CreateStaticDefaultValue), new Action(UiInteractLogReport.ResetStaticDefaultValue));
	}

	// Token: 0x0601D574 RID: 120180 RVA: 0x0082DB24 File Offset: 0x0082BD24
	public static void CreateStaticDefaultValue()
	{
		UiInteractLogReport.RouletteData = new UiInteractRouletteData();
		UiInteractLogReport.ChatData = new UiInteractChatData();
	}

	// Token: 0x0601D575 RID: 120181 RVA: 0x0082DB3A File Offset: 0x0082BD3A
	public static void ResetStaticDefaultValue()
	{
		UiInteractLogReport.RouletteData = null;
		UiInteractLogReport.ChatData = null;
	}

	// Token: 0x0601D576 RID: 120182 RVA: 0x0082DB48 File Offset: 0x0082BD48
	private static bool IsGamepadInteract()
	{
		return Info.Instance.IsInGamepad();
	}

	// Token: 0x0601D577 RID: 120183 RVA: 0x0082DB54 File Offset: 0x0082BD54
	private static bool IsKeyboardInteract()
	{
		return Info.Instance.IsInKeyBoard() && LguiEventSystemManager.Instance.LguiEventSystemActor.IsInNavigationInputType();
	}

	// Token: 0x0601D578 RID: 120184 RVA: 0x0082DB73 File Offset: 0x0082BD73
	private static bool IsMouseInteract()
	{
		return Info.Instance.IsInKeyBoard() && LguiEventSystemManager.Instance.LguiEventSystemActor.IsInPointerInputType();
	}

	// Token: 0x0601D579 RID: 120185 RVA: 0x0082DB94 File Offset: 0x0082BD94
	public static void ReportSpaceKeyInteract(EUiInteractSpaceKeyType type)
	{
		if (Info.Instance.IsInTouch())
		{
			return;
		}
		if (UiInteractLogReport.IsGamepadInteract() || UiInteractLogReport.IsMouseInteract())
		{
			UiInteractSpaceKeyLogEvent uiInteractSpaceKeyLogEvent = new UiInteractSpaceKeyLogEvent();
			uiInteractSpaceKeyLogEvent.i_type = (int)type;
			uiInteractSpaceKeyLogEvent.i_status = 1;
			LogReportController.Instance.LogReport(uiInteractSpaceKeyLogEvent);
			return;
		}
		if (UiInteractLogReport.IsKeyboardInteract())
		{
			UiInteractSpaceKeyLogEvent uiInteractSpaceKeyLogEvent2 = new UiInteractSpaceKeyLogEvent();
			uiInteractSpaceKeyLogEvent2.i_type = (int)type;
			uiInteractSpaceKeyLogEvent2.i_status = 2;
			LogReportController.Instance.LogReport(uiInteractSpaceKeyLogEvent2);
		}
	}

	// Token: 0x0601D57A RID: 120186 RVA: 0x0082DC02 File Offset: 0x0082BE02
	public static void RecordRouletteOpen()
	{
		if (UiInteractLogReport.RouletteData.IsStart)
		{
			return;
		}
		ShipTowerModel instance = ShipTowerModel.Instance;
		if (instance == null || !instance.CheckInBattleShipTower())
		{
			return;
		}
		UiInteractLogReport.RouletteData.TriggerOpen();
	}

	// Token: 0x0601D57B RID: 120187 RVA: 0x0082DC34 File Offset: 0x0082BE34
	public static void RecordRouletteClose()
	{
		if (!UiInteractLogReport.RouletteData.IsStart)
		{
			return;
		}
		UiInteractLogReport.RouletteData.TriggerClose();
		UiInteractRouletteLogEvent uiInteractRouletteLogEvent = new UiInteractRouletteLogEvent();
		uiInteractRouletteLogEvent.i_old_count = UiInteractLogReport.RouletteData.OldRound;
		uiInteractRouletteLogEvent.i_new_count = UiInteractLogReport.RouletteData.NewRound;
		uiInteractRouletteLogEvent.i_inst_id = CreatureModel.Instance.GetInstanceId();
		uiInteractRouletteLogEvent.i_cost_time = UiInteractLogReport.RouletteData.DurationTime;
		uiInteractRouletteLogEvent.i_skill_id = UiInteractLogReport.RouletteData.UseSkillId;
		LogReportController.Instance.LogReport(uiInteractRouletteLogEvent);
	}

	// Token: 0x0601D57C RID: 120188 RVA: 0x0082DCB9 File Offset: 0x0082BEB9
	public static void RecordChatOpen()
	{
		if (UiInteractLogReport.ChatData.IsStart)
		{
			return;
		}
		ShipTowerModel instance = ShipTowerModel.Instance;
		if (instance == null || !instance.CheckInBattleShipTower())
		{
			return;
		}
		UiInteractLogReport.ChatData.TriggerOpen();
	}

	// Token: 0x0601D57D RID: 120189 RVA: 0x0082DCEC File Offset: 0x0082BEEC
	public static void RecordChatClose()
	{
		if (!UiInteractLogReport.ChatData.IsStart)
		{
			return;
		}
		UiInteractLogReport.ChatData.TriggerClose();
		UiInteractChatLogEvent uiInteractChatLogEvent = new UiInteractChatLogEvent();
		uiInteractChatLogEvent.i_old_count = UiInteractLogReport.ChatData.OldRound;
		uiInteractChatLogEvent.i_new_count = UiInteractLogReport.ChatData.NewRound;
		uiInteractChatLogEvent.i_inst_id = CreatureModel.Instance.GetInstanceId();
		uiInteractChatLogEvent.i_cost_time = UiInteractLogReport.ChatData.DurationTime;
		uiInteractChatLogEvent.i_skill_id = UiInteractLogReport.ChatData.UseSkillId;
		LogReportController.Instance.LogReport(uiInteractChatLogEvent);
	}

	// Token: 0x0400E730 RID: 59184
	[Nullable(2)]
	private static UiInteractRouletteData RouletteData;

	// Token: 0x0400E731 RID: 59185
	[Nullable(2)]
	private static UiInteractChatData ChatData;
}
