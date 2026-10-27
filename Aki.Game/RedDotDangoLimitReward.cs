using System;
using CSharpScript.Game.Common.Event;

// Token: 0x0200337C RID: 13180
public class RedDotDangoLimitReward : RedDotBase
{
	// Token: 0x0601CA7C RID: 117372 RVA: 0x008063B8 File Offset: 0x008045B8
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshAbyssRewardRedDot, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CA7D RID: 117373 RVA: 0x008063D6 File Offset: 0x008045D6
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.RefreshAbyssRewardRedDot, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CA7E RID: 117374 RVA: 0x008063F4 File Offset: 0x008045F4
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
