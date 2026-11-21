using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020028D4 RID: 10452
public class RedDotBattlePassDayTaskTab : RedDotBase
{
	// Token: 0x0601A6FE RID: 108286 RVA: 0x0082BBE8 File Offset: 0x00829DE8
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.BattlePassTask);
	}

	// Token: 0x0601A6FF RID: 108287 RVA: 0x0082BBF1 File Offset: 0x00829DF1
	protected override bool OnCheck(int uId = 0)
	{
		return BattlePassModel.Instance.CheckHasTaskWaitTakeWithType(EBattlePassTaskUpdateState.EveryDay);
	}

	// Token: 0x0601A700 RID: 108288 RVA: 0x0082BBFE File Offset: 0x00829DFE
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.UpdateBattlePassTaskEvent, new Action(base.EventCheck));
		EventSystem.Instance.Add<bool>(EEventName.ReceiveBattlePassTaskEvent, new Action<bool>(this.OnReceiveBattlePassTaskEvent));
	}

	// Token: 0x0601A701 RID: 108289 RVA: 0x0082BC38 File Offset: 0x00829E38
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.UpdateBattlePassTaskEvent, new Action(base.EventCheck));
		EventSystem.Instance.Remove<bool>(EEventName.ReceiveBattlePassTaskEvent, new Action<bool>(this.OnReceiveBattlePassTaskEvent));
	}

	// Token: 0x0601A702 RID: 108290 RVA: 0x0082BC72 File Offset: 0x00829E72
	protected override bool IsAllEventParamAsUId()
	{
		return false;
	}

	// Token: 0x0601A703 RID: 108291 RVA: 0x0082BC75 File Offset: 0x00829E75
	private void OnReceiveBattlePassTaskEvent(bool isWeekUpdate)
	{
		base.EventCheck();
	}
}
