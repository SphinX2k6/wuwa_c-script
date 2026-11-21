using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02002980 RID: 10624
public class RedDotRoguelikeAchievementGroup : RedDotBase
{
	// Token: 0x0601AA1D RID: 109085 RVA: 0x00831B49 File Offset: 0x0082FD49
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.OnAchievementGroupDataNotify, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601AA1E RID: 109086 RVA: 0x00831B67 File Offset: 0x0082FD67
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.OnAchievementGroupDataNotify, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601AA1F RID: 109087 RVA: 0x00831B88 File Offset: 0x0082FD88
	protected override bool OnCheck(int uId = 0)
	{
		AchievementGroupData achievementGroupData = AchievementModel.Instance.GetAchievementGroupData(new int?(uId));
		return achievementGroupData != null && achievementGroupData.SmallItemRedPoint();
	}
}
