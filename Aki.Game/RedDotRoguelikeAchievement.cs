using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.RougeActivity;

// Token: 0x0200297F RID: 10623
public class RedDotRoguelikeAchievement : RedDotBase
{
	// Token: 0x0601AA19 RID: 109081 RVA: 0x00831AEF File Offset: 0x0082FCEF
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RefreshAchievementRedPoint, new Action(base.EventCheck));
	}

	// Token: 0x0601AA1A RID: 109082 RVA: 0x00831B0D File Offset: 0x0082FD0D
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RefreshAchievementRedPoint, new Action(base.EventCheck));
	}

	// Token: 0x0601AA1B RID: 109083 RVA: 0x00831B2B File Offset: 0x0082FD2B
	protected override bool OnCheck(int uId = 0)
	{
		ActivityRogueController.Instance.RefreshActivityRedDot();
		return RoguelikeModel.Instance.GetRoguelikeAchievementRedDot();
	}
}
