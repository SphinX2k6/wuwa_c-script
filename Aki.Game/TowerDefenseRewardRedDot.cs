using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x020029AD RID: 10669
public class TowerDefenseRewardRedDot : RedDotBase
{
	// Token: 0x0601AB00 RID: 109312 RVA: 0x00834012 File Offset: 0x00832212
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<IActivityRewardViewData>(EEventName.RefreshCommonActivityRewardPopUpView, new Action<IActivityRewardViewData>(this.OnRefreshCommonActivityRewardPopUpView));
	}

	// Token: 0x0601AB01 RID: 109313 RVA: 0x00834030 File Offset: 0x00832230
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<IActivityRewardViewData>(EEventName.RefreshCommonActivityRewardPopUpView, new Action<IActivityRewardViewData>(this.OnRefreshCommonActivityRewardPopUpView));
	}

	// Token: 0x0601AB02 RID: 109314 RVA: 0x0083404E File Offset: 0x0083224E
	protected override bool OnCheck(int uId = 0)
	{
		return TowerDefenseController.Instance.CheckHasReward();
	}

	// Token: 0x0601AB03 RID: 109315 RVA: 0x0083405A File Offset: 0x0083225A
	[NullableContext(1)]
	private void OnRefreshCommonActivityRewardPopUpView(IActivityRewardViewData data)
	{
		base.EventCheck();
	}
}
