using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.RougeActivity;

// Token: 0x0200340D RID: 13325
public class RedDotRoguelikeAchievement : RedDotBase
{
	// Token: 0x0601CD21 RID: 118049 RVA: 0x0080B52B File Offset: 0x0080972B
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RefreshAchievementRedPoint, new Action(base.EventCheck));
	}

	// Token: 0x0601CD22 RID: 118050 RVA: 0x0080B549 File Offset: 0x00809749
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RefreshAchievementRedPoint, new Action(base.EventCheck));
	}

	// Token: 0x0601CD23 RID: 118051 RVA: 0x0080B567 File Offset: 0x00809767
	protected override bool OnCheck(int uId = 0)
	{
		ActivityRogueController.Instance.RefreshActivityRedDot();
		return RoguelikeModel.Instance.GetRoguelikeAchievementRedDot();
	}
}
