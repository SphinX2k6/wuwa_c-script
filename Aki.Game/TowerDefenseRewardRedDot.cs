using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x02003439 RID: 13369
public class TowerDefenseRewardRedDot : RedDotBase
{
	// Token: 0x0601CE00 RID: 118272 RVA: 0x0080D92A File Offset: 0x0080BB2A
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<IActivityRewardViewData>(EEventName.RefreshCommonActivityRewardPopUpView, new Action<IActivityRewardViewData>(this.OnRefreshCommonActivityRewardPopUpView));
	}

	// Token: 0x0601CE01 RID: 118273 RVA: 0x0080D948 File Offset: 0x0080BB48
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<IActivityRewardViewData>(EEventName.RefreshCommonActivityRewardPopUpView, new Action<IActivityRewardViewData>(this.OnRefreshCommonActivityRewardPopUpView));
	}

	// Token: 0x0601CE02 RID: 118274 RVA: 0x0080D966 File Offset: 0x0080BB66
	protected override bool OnCheck(int uId = 0)
	{
		return TowerDefenseController.Instance.CheckHasReward();
	}

	// Token: 0x0601CE03 RID: 118275 RVA: 0x0080D972 File Offset: 0x0080BB72
	[NullableContext(1)]
	private void OnRefreshCommonActivityRewardPopUpView(IActivityRewardViewData data)
	{
		base.EventCheck();
	}
}
