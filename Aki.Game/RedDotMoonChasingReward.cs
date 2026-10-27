using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020033C4 RID: 13252
public class RedDotMoonChasingReward : RedDotBase
{
	// Token: 0x0601CBC3 RID: 117699 RVA: 0x00808CB8 File Offset: 0x00806EB8
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.MoonChasingRewardAndShop);
	}

	// Token: 0x0601CBC4 RID: 117700 RVA: 0x00808CC4 File Offset: 0x00806EC4
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.TakenRewardTargetData, new Action<int>(this.OnTakenRewardTargetData));
		EventSystem.Instance.Add(EEventName.RefreshRewardTargetData, new Action(base.EventCheck));
	}

	// Token: 0x0601CBC5 RID: 117701 RVA: 0x00808CFE File Offset: 0x00806EFE
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.TakenRewardTargetData, new Action<int>(this.OnTakenRewardTargetData));
		EventSystem.Instance.Remove(EEventName.RefreshRewardTargetData, new Action(base.EventCheck));
	}

	// Token: 0x0601CBC6 RID: 117702 RVA: 0x00808D38 File Offset: 0x00806F38
	protected override bool IsAllEventParamAsUId()
	{
		return false;
	}

	// Token: 0x0601CBC7 RID: 117703 RVA: 0x00808D3B File Offset: 0x00806F3B
	protected override bool OnCheck(int uId = 0)
	{
		ActivityMoonChasingController.Instance.RefreshActivityRedDot();
		return MoonChasingRewardModel.Instance.GetAllTaskDataRedDotState(true);
	}

	// Token: 0x0601CBC8 RID: 117704 RVA: 0x00808D52 File Offset: 0x00806F52
	private void OnTakenRewardTargetData(int _)
	{
		base.EventCheck();
	}
}
