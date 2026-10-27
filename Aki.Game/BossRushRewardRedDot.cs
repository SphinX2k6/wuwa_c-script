using System;
using CSharpScript.Game.Common.Event;

// Token: 0x0200336C RID: 13164
public class BossRushRewardRedDot : RedDotBase
{
	// Token: 0x0601CA38 RID: 117304 RVA: 0x00805BFF File Offset: 0x00803DFF
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.BossRefreshBossRushRewardRedDot, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CA39 RID: 117305 RVA: 0x00805C1D File Offset: 0x00803E1D
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.BossRefreshBossRushRewardRedDot, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CA3A RID: 117306 RVA: 0x00805C3C File Offset: 0x00803E3C
	protected override bool OnCheck(int uId = 0)
	{
		ActivityBaseData activityById = ActivityModel.Instance.GetActivityById(uId);
		return activityById != null && (activityById as BossRushData).HaveRewardCanTake();
	}
}
