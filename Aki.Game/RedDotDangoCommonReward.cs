using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02003378 RID: 13176
public class RedDotDangoCommonReward : RedDotBase
{
	// Token: 0x0601CA67 RID: 117351 RVA: 0x0080613C File Offset: 0x0080433C
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshAbyssRewardRedDot, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CA68 RID: 117352 RVA: 0x0080615A File Offset: 0x0080435A
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.RefreshAbyssRewardRedDot, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CA69 RID: 117353 RVA: 0x00806178 File Offset: 0x00804378
	protected override bool OnCheck(int uId = 0)
	{
		if (uId == 0)
		{
			return false;
		}
		ActivityBaseData activityById = ActivityModel.Instance.GetActivityById(uId);
		return activityById != null && (activityById as DangoAbyssActivityData).GetRewardTypeIfHaveCanTakeReward(EAbyssShopType.Common);
	}
}
