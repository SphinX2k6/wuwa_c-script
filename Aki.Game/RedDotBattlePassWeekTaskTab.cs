using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020028D8 RID: 10456
public class RedDotBattlePassWeekTaskTab : RedDotBase
{
	// Token: 0x0601A715 RID: 108309 RVA: 0x0082BE35 File Offset: 0x0082A035
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.BattlePassTask);
	}

	// Token: 0x0601A716 RID: 108310 RVA: 0x0082BE3E File Offset: 0x0082A03E
	protected override bool OnCheck(int uId = 0)
	{
		return BattlePassModel.Instance.CheckHasTaskWaitTakeWithType(EBattlePassTaskUpdateState.EveryWeek);
	}

	// Token: 0x0601A717 RID: 108311 RVA: 0x0082BE4B File Offset: 0x0082A04B
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.UpdateBattlePassTaskEvent, new Action(base.EventCheck));
		EventSystem.Instance.Add<bool>(EEventName.ReceiveBattlePassTaskEvent, new Action<bool>(this.OnReceiveBattlePassTaskEvent));
	}

	// Token: 0x0601A718 RID: 108312 RVA: 0x0082BE85 File Offset: 0x0082A085
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.UpdateBattlePassTaskEvent, new Action(base.EventCheck));
		EventSystem.Instance.Remove<bool>(EEventName.ReceiveBattlePassTaskEvent, new Action<bool>(this.OnReceiveBattlePassTaskEvent));
	}

	// Token: 0x0601A719 RID: 108313 RVA: 0x0082BEBF File Offset: 0x0082A0BF
	protected override bool IsAllEventParamAsUId()
	{
		return false;
	}

	// Token: 0x0601A71A RID: 108314 RVA: 0x0082BEC2 File Offset: 0x0082A0C2
	private void OnReceiveBattlePassTaskEvent(bool isWeekUpdate)
	{
		base.EventCheck();
	}
}
