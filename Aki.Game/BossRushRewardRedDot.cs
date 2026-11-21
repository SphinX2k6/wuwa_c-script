using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020028DE RID: 10462
public class BossRushRewardRedDot : RedDotBase
{
	// Token: 0x0601A730 RID: 108336 RVA: 0x0082C1C3 File Offset: 0x0082A3C3
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.BossRefreshBossRushRewardRedDot, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601A731 RID: 108337 RVA: 0x0082C1E1 File Offset: 0x0082A3E1
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.BossRefreshBossRushRewardRedDot, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601A732 RID: 108338 RVA: 0x0082C200 File Offset: 0x0082A400
	protected override bool OnCheck(int uId = 0)
	{
		ActivityBaseData activityById = ActivityModel.Instance.GetActivityById(uId);
		return activityById != null && (activityById as BossRushData).HaveRewardCanTake();
	}
}
