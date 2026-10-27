using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02000F19 RID: 3865
public class RedDotAchievement : RedDotBase
{
	// Token: 0x060061C6 RID: 25030 RVA: 0x001316E1 File Offset: 0x0012F8E1
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RefreshAchievementRedPoint, new Action(base.EventCheck));
	}

	// Token: 0x060061C7 RID: 25031 RVA: 0x001316FF File Offset: 0x0012F8FF
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RefreshAchievementRedPoint, new Action(base.EventCheck));
	}

	// Token: 0x060061C8 RID: 25032 RVA: 0x0013171D File Offset: 0x0012F91D
	protected override bool OnCheck(int uId = 0)
	{
		return AchievementModel.Instance.GetAchievementRedPointState();
	}
}
