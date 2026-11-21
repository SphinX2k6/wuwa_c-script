using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020003CE RID: 974
public class RedDotAchievement : RedDotBase
{
	// Token: 0x0600355E RID: 13662 RVA: 0x0013A005 File Offset: 0x00138205
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RefreshAchievementRedPoint, new Action(base.EventCheck));
	}

	// Token: 0x0600355F RID: 13663 RVA: 0x0013A023 File Offset: 0x00138223
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RefreshAchievementRedPoint, new Action(base.EventCheck));
	}

	// Token: 0x06003560 RID: 13664 RVA: 0x0013A041 File Offset: 0x00138241
	protected override bool OnCheck(int uId = 0)
	{
		return AchievementModel.Instance.GetAchievementRedPointState();
	}
}
