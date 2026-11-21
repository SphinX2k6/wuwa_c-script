using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020028EA RID: 10474
public class RedDotDangoCommonReward : RedDotBase
{
	// Token: 0x0601A75F RID: 108383 RVA: 0x0082C700 File Offset: 0x0082A900
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshAbyssRewardRedDot, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601A760 RID: 108384 RVA: 0x0082C71E File Offset: 0x0082A91E
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.RefreshAbyssRewardRedDot, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601A761 RID: 108385 RVA: 0x0082C73C File Offset: 0x0082A93C
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
