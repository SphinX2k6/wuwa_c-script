using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020003CF RID: 975
public class RedDotAchievementCategory : RedDotBase
{
	// Token: 0x06003562 RID: 13666 RVA: 0x0013A055 File Offset: 0x00138255
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RefreshAchievementRedPoint, new Action(base.EventCheck));
	}

	// Token: 0x06003563 RID: 13667 RVA: 0x0013A073 File Offset: 0x00138273
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RefreshAchievementRedPoint, new Action(base.EventCheck));
	}

	// Token: 0x06003564 RID: 13668 RVA: 0x0013A091 File Offset: 0x00138291
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x06003565 RID: 13669 RVA: 0x0013A094 File Offset: 0x00138294
	protected override bool OnCheck(int uId = 0)
	{
		return AchievementModel.Instance.GetCategoryRedPointState(uId);
	}
}
