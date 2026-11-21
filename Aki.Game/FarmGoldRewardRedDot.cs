using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.FarmGold;

// Token: 0x020028F5 RID: 10485
public class FarmGoldRewardRedDot : RedDotBase
{
	// Token: 0x0601A79E RID: 108446 RVA: 0x0082CED2 File Offset: 0x0082B0D2
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.FarmGoldRefreshRewardRedDot, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601A79F RID: 108447 RVA: 0x0082CEF0 File Offset: 0x0082B0F0
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.FarmGoldRefreshRewardRedDot, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601A7A0 RID: 108448 RVA: 0x0082CF10 File Offset: 0x0082B110
	protected override bool OnCheck(int uId = 0)
	{
		ActivityBaseData activityById = ActivityModel.Instance.GetActivityById(uId);
		return activityById != null && (activityById as FarmGoldData).HaveRewardCanTake();
	}
}
