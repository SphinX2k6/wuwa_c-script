using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02003366 RID: 13158
public class RedDotBattlePassWeekTaskTab : RedDotBase
{
	// Token: 0x0601CA1D RID: 117277 RVA: 0x00805871 File Offset: 0x00803A71
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.BattlePassTask);
	}

	// Token: 0x0601CA1E RID: 117278 RVA: 0x0080587A File Offset: 0x00803A7A
	protected override bool OnCheck(int uId = 0)
	{
		return BattlePassModel.Instance.CheckHasTaskWaitTakeWithType(EBattlePassTaskUpdateState.EveryWeek);
	}

	// Token: 0x0601CA1F RID: 117279 RVA: 0x00805887 File Offset: 0x00803A87
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.UpdateBattlePassTaskEvent, new Action(base.EventCheck));
		EventSystem.Instance.Add<bool>(EEventName.ReceiveBattlePassTaskEvent, new Action<bool>(this.OnReceiveBattlePassTaskEvent));
	}

	// Token: 0x0601CA20 RID: 117280 RVA: 0x008058C1 File Offset: 0x00803AC1
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.UpdateBattlePassTaskEvent, new Action(base.EventCheck));
		EventSystem.Instance.Remove<bool>(EEventName.ReceiveBattlePassTaskEvent, new Action<bool>(this.OnReceiveBattlePassTaskEvent));
	}

	// Token: 0x0601CA21 RID: 117281 RVA: 0x008058FB File Offset: 0x00803AFB
	protected override bool IsAllEventParamAsUId()
	{
		return false;
	}

	// Token: 0x0601CA22 RID: 117282 RVA: 0x008058FE File Offset: 0x00803AFE
	private void OnReceiveBattlePassTaskEvent(bool isWeekUpdate)
	{
		base.EventCheck();
	}
}
