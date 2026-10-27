using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02003364 RID: 13156
public class RedDotBattlePassReward : RedDotBase
{
	// Token: 0x0601CA14 RID: 117268 RVA: 0x00805770 File Offset: 0x00803970
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.BattlePass);
	}

	// Token: 0x0601CA15 RID: 117269 RVA: 0x00805779 File Offset: 0x00803979
	protected override bool OnCheck(int uId = 0)
	{
		return BattlePassModel.Instance.CheckHasRewardWaitTake();
	}

	// Token: 0x0601CA16 RID: 117270 RVA: 0x00805788 File Offset: 0x00803988
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int?>(EEventName.GetBattlePassRewardEvent, new Action<int?>(this.OnGetBattlePassRewardEvent));
		EventSystem.Instance.Add(EEventName.ReceiveBattlePassDataEvent, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.OnBattlePassLevelUpEvent, new Action(base.EventCheck));
	}

	// Token: 0x0601CA17 RID: 117271 RVA: 0x008057EC File Offset: 0x008039EC
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int?>(EEventName.GetBattlePassRewardEvent, new Action<int?>(this.OnGetBattlePassRewardEvent));
		EventSystem.Instance.Remove(EEventName.ReceiveBattlePassDataEvent, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.OnBattlePassLevelUpEvent, new Action(base.EventCheck));
	}

	// Token: 0x0601CA18 RID: 117272 RVA: 0x0080584D File Offset: 0x00803A4D
	protected override bool IsAllEventParamAsUId()
	{
		return false;
	}

	// Token: 0x0601CA19 RID: 117273 RVA: 0x00805850 File Offset: 0x00803A50
	private void OnGetBattlePassRewardEvent(int? gridIndex)
	{
		base.EventCheck();
	}
}
