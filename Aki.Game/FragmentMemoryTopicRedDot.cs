using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02003393 RID: 13203
public class FragmentMemoryTopicRedDot : RedDotBase
{
	// Token: 0x0601CAE4 RID: 117476 RVA: 0x00806EBC File Offset: 0x008050BC
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.FragmentRewardTopicRedDot, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CAE5 RID: 117477 RVA: 0x00806EDA File Offset: 0x008050DA
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.FragmentRewardTopicRedDot, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CAE6 RID: 117478 RVA: 0x00806EF8 File Offset: 0x008050F8
	protected override bool OnCheck(int uId = 0)
	{
		FragmentMemoryTopicData topicDataById = FragmentMemoryModel.Instance.GetTopicDataById(uId);
		return topicDataById != null && topicDataById.GetRedDotState();
	}
}
