using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020028EE RID: 10478
public class RedDotDangoLimitReward : RedDotBase
{
	// Token: 0x0601A774 RID: 108404 RVA: 0x0082C97C File Offset: 0x0082AB7C
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshAbyssRewardRedDot, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601A775 RID: 108405 RVA: 0x0082C99A File Offset: 0x0082AB9A
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.RefreshAbyssRewardRedDot, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601A776 RID: 108406 RVA: 0x0082C9B8 File Offset: 0x0082ABB8
	protected override bool OnCheck(int uId = 0)
	{
		if (uId == 0)
		{
			return false;
		}
		ActivityBaseData activityById = ActivityModel.Instance.GetActivityById(uId);
		return activityById != null && (activityById as DangoAbyssActivityData).GetRewardTypeIfHaveCanTakeReward(EAbyssShopType.Limit);
	}
}
