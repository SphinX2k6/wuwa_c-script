using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02003361 RID: 13153
public class RedDotBattlePassAlwaysTaskTab : RedDotBase
{
	// Token: 0x0601C9FF RID: 117247 RVA: 0x00805587 File Offset: 0x00803787
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.BattlePassTask);
	}

	// Token: 0x0601CA00 RID: 117248 RVA: 0x00805590 File Offset: 0x00803790
	protected override bool OnCheck(int uId = 0)
	{
		return BattlePassModel.Instance.CheckHasTaskWaitTakeWithType(EBattlePassTaskUpdateState.Always);
	}

	// Token: 0x0601CA01 RID: 117249 RVA: 0x0080559D File Offset: 0x0080379D
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.UpdateBattlePassTaskEvent, new Action(base.EventCheck));
		EventSystem.Instance.Add<bool>(EEventName.ReceiveBattlePassTaskEvent, new Action<bool>(this.OnReceiveBattlePassTaskEvent));
	}

	// Token: 0x0601CA02 RID: 117250 RVA: 0x008055D7 File Offset: 0x008037D7
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.UpdateBattlePassTaskEvent, new Action(base.EventCheck));
		EventSystem.Instance.Remove<bool>(EEventName.ReceiveBattlePassTaskEvent, new Action<bool>(this.OnReceiveBattlePassTaskEvent));
	}

	// Token: 0x0601CA03 RID: 117251 RVA: 0x00805611 File Offset: 0x00803811
	protected override bool IsAllEventParamAsUId()
	{
		return false;
	}

	// Token: 0x0601CA04 RID: 117252 RVA: 0x00805614 File Offset: 0x00803814
	private void OnReceiveBattlePassTaskEvent(bool isWeekUpdate)
	{
		base.EventCheck();
	}
}
