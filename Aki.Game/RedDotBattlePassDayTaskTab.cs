using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02003362 RID: 13154
public class RedDotBattlePassDayTaskTab : RedDotBase
{
	// Token: 0x0601CA06 RID: 117254 RVA: 0x00805624 File Offset: 0x00803824
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.BattlePassTask);
	}

	// Token: 0x0601CA07 RID: 117255 RVA: 0x0080562D File Offset: 0x0080382D
	protected override bool OnCheck(int uId = 0)
	{
		return BattlePassModel.Instance.CheckHasTaskWaitTakeWithType(EBattlePassTaskUpdateState.EveryDay);
	}

	// Token: 0x0601CA08 RID: 117256 RVA: 0x0080563A File Offset: 0x0080383A
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.UpdateBattlePassTaskEvent, new Action(base.EventCheck));
		EventSystem.Instance.Add<bool>(EEventName.ReceiveBattlePassTaskEvent, new Action<bool>(this.OnReceiveBattlePassTaskEvent));
	}

	// Token: 0x0601CA09 RID: 117257 RVA: 0x00805674 File Offset: 0x00803874
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.UpdateBattlePassTaskEvent, new Action(base.EventCheck));
		EventSystem.Instance.Remove<bool>(EEventName.ReceiveBattlePassTaskEvent, new Action<bool>(this.OnReceiveBattlePassTaskEvent));
	}

	// Token: 0x0601CA0A RID: 117258 RVA: 0x008056AE File Offset: 0x008038AE
	protected override bool IsAllEventParamAsUId()
	{
		return false;
	}

	// Token: 0x0601CA0B RID: 117259 RVA: 0x008056B1 File Offset: 0x008038B1
	private void OnReceiveBattlePassTaskEvent(bool isWeekUpdate)
	{
		base.EventCheck();
	}
}
