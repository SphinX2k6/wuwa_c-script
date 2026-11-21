using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02002936 RID: 10550
public class RedDotMoonChasingReward : RedDotBase
{
	// Token: 0x0601A8BB RID: 108731 RVA: 0x0082F27C File Offset: 0x0082D47C
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.MoonChasingRewardAndShop);
	}

	// Token: 0x0601A8BC RID: 108732 RVA: 0x0082F288 File Offset: 0x0082D488
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.TakenRewardTargetData, new Action<int>(this.OnTakenRewardTargetData));
		EventSystem.Instance.Add(EEventName.RefreshRewardTargetData, new Action(base.EventCheck));
	}

	// Token: 0x0601A8BD RID: 108733 RVA: 0x0082F2C2 File Offset: 0x0082D4C2
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.TakenRewardTargetData, new Action<int>(this.OnTakenRewardTargetData));
		EventSystem.Instance.Remove(EEventName.RefreshRewardTargetData, new Action(base.EventCheck));
	}

	// Token: 0x0601A8BE RID: 108734 RVA: 0x0082F2FC File Offset: 0x0082D4FC
	protected override bool IsAllEventParamAsUId()
	{
		return false;
	}

	// Token: 0x0601A8BF RID: 108735 RVA: 0x0082F2FF File Offset: 0x0082D4FF
	protected override bool OnCheck(int uId = 0)
	{
		ActivityMoonChasingController.Instance.RefreshActivityRedDot();
		return MoonChasingRewardModel.Instance.GetAllTaskDataRedDotState(true);
	}

	// Token: 0x0601A8C0 RID: 108736 RVA: 0x0082F316 File Offset: 0x0082D516
	private void OnTakenRewardTargetData(int _)
	{
		base.EventCheck();
	}
}
