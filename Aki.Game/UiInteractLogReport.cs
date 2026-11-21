using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Ui;

// Token: 0x02002A19 RID: 10777
public class UiInteractLogReport : IStaticVariableResetter
{
	// Token: 0x0601B270 RID: 111216 RVA: 0x00854CB1 File Offset: 0x00852EB1
	static UiInteractLogReport()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(UiInteractLogReport.CreateStaticDefaultValue), new Action(UiInteractLogReport.ResetStaticDefaultValue));
	}

	// Token: 0x0601B271 RID: 111217 RVA: 0x00854CD0 File Offset: 0x00852ED0
	public static void CreateStaticDefaultValue()
	{
		UiInteractLogReport.RouletteData = new UiInteractRouletteData();
		UiInteractLogReport.ChatData = new UiInteractChatData();
	}

	// Token: 0x0601B272 RID: 111218 RVA: 0x00854CE6 File Offset: 0x00852EE6
	public static void ResetStaticDefaultValue()
	{
		UiInteractLogReport.RouletteData = null;
		UiInteractLogReport.ChatData = null;
	}

	// Token: 0x0601B273 RID: 111219 RVA: 0x00854CF4 File Offset: 0x00852EF4
	private static bool IsGamepadInteract()
	{
		return Info.Instance.IsInGamepad();
	}

	// Token: 0x0601B274 RID: 111220 RVA: 0x00854D00 File Offset: 0x00852F00
	private static bool IsKeyboardInteract()
	{
		return Info.Instance.IsInKeyBoard() && LguiEventSystemManager.Instance.LguiEventSystemActor.IsInNavigationInputType();
	}

	// Token: 0x0601B275 RID: 111221 RVA: 0x00854D1F File Offset: 0x00852F1F
	private static bool IsMouseInteract()
	{
		return Info.Instance.IsInKeyBoard() && LguiEventSystemManager.Instance.LguiEventSystemActor.IsInPointerInputType();
	}

	// Token: 0x0601B276 RID: 111222 RVA: 0x00854D40 File Offset: 0x00852F40
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

	// Token: 0x0601B277 RID: 111223 RVA: 0x00854DAE File Offset: 0x00852FAE
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

	// Token: 0x0601B278 RID: 111224 RVA: 0x00854DE0 File Offset: 0x00852FE0
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

	// Token: 0x0601B279 RID: 111225 RVA: 0x00854E65 File Offset: 0x00853065
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

	// Token: 0x0601B27A RID: 111226 RVA: 0x00854E98 File Offset: 0x00853098
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

	// Token: 0x0400EBE4 RID: 60388
	[Nullable(2)]
	private static UiInteractRouletteData RouletteData;

	// Token: 0x0400EBE5 RID: 60389
	[Nullable(2)]
	private static UiInteractChatData ChatData;
}
