using System;
using CSharpScript.Game.Common.Event;

// Token: 0x0200340E RID: 13326
public class RedDotRoguelikeAchievementGroup : RedDotBase
{
	// Token: 0x0601CD25 RID: 118053 RVA: 0x0080B585 File Offset: 0x00809785
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.OnAchievementGroupDataNotify, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CD26 RID: 118054 RVA: 0x0080B5A3 File Offset: 0x008097A3
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.OnAchievementGroupDataNotify, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CD27 RID: 118055 RVA: 0x0080B5C4 File Offset: 0x008097C4
	protected override bool OnCheck(int uId = 0)
	{
		AchievementGroupData achievementGroupData = AchievementModel.Instance.GetAchievementGroupData(new int?(uId));
		return achievementGroupData != null && achievementGroupData.SmallItemRedPoint();
	}
}
