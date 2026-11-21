using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02002954 RID: 10580
public class MowingTowerRewardRedDot : RedDotBase
{
	// Token: 0x0601A94F RID: 108879 RVA: 0x0083034F File Offset: 0x0082E54F
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshMowingTowerRewardRedDot, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601A950 RID: 108880 RVA: 0x0083036D File Offset: 0x0082E56D
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.RefreshMowingTowerRewardRedDot, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601A951 RID: 108881 RVA: 0x0083038C File Offset: 0x0082E58C
	protected override bool OnCheck(int uId = 0)
	{
		ActivityBaseData activityById = ActivityModel.Instance.GetActivityById(uId);
		return activityById != null && (activityById as MowingTowerData).HaveRewardCanTake();
	}
}
