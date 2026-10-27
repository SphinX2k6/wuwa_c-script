using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02000F1A RID: 3866
public class RedDotAchievementCategory : RedDotBase
{
	// Token: 0x060061CA RID: 25034 RVA: 0x00131731 File Offset: 0x0012F931
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RefreshAchievementRedPoint, new Action(base.EventCheck));
	}

	// Token: 0x060061CB RID: 25035 RVA: 0x0013174F File Offset: 0x0012F94F
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RefreshAchievementRedPoint, new Action(base.EventCheck));
	}

	// Token: 0x060061CC RID: 25036 RVA: 0x0013176D File Offset: 0x0012F96D
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x060061CD RID: 25037 RVA: 0x00131770 File Offset: 0x0012F970
	protected override bool OnCheck(int uId = 0)
	{
		return AchievementModel.Instance.GetCategoryRedPointState(uId);
	}
}
