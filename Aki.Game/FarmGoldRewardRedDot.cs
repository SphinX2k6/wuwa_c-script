using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.FarmGold;

// Token: 0x02003383 RID: 13187
public class FarmGoldRewardRedDot : RedDotBase
{
	// Token: 0x0601CAA6 RID: 117414 RVA: 0x0080690E File Offset: 0x00804B0E
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.FarmGoldRefreshRewardRedDot, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CAA7 RID: 117415 RVA: 0x0080692C File Offset: 0x00804B2C
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.FarmGoldRefreshRewardRedDot, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CAA8 RID: 117416 RVA: 0x0080694C File Offset: 0x00804B4C
	protected override bool OnCheck(int uId = 0)
	{
		ActivityBaseData activityById = ActivityModel.Instance.GetActivityById(uId);
		return activityById != null && (activityById as FarmGoldData).HaveRewardCanTake();
	}
}
