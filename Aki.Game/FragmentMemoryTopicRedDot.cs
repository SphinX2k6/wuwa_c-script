using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02002905 RID: 10501
public class FragmentMemoryTopicRedDot : RedDotBase
{
	// Token: 0x0601A7DC RID: 108508 RVA: 0x0082D480 File Offset: 0x0082B680
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.FragmentRewardTopicRedDot, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601A7DD RID: 108509 RVA: 0x0082D49E File Offset: 0x0082B69E
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.FragmentRewardTopicRedDot, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601A7DE RID: 108510 RVA: 0x0082D4BC File Offset: 0x0082B6BC
	protected override bool OnCheck(int uId = 0)
	{
		FragmentMemoryTopicData topicDataById = FragmentMemoryModel.Instance.GetTopicDataById(uId);
		return topicDataById != null && topicDataById.GetRedDotState();
	}
}
