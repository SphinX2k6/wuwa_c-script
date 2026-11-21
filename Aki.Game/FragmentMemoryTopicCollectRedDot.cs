using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02002904 RID: 10500
public class FragmentMemoryTopicCollectRedDot : RedDotBase
{
	// Token: 0x0601A7D8 RID: 108504 RVA: 0x0082D418 File Offset: 0x0082B618
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.FragmentRewardTopicRedDot, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601A7D9 RID: 108505 RVA: 0x0082D436 File Offset: 0x0082B636
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.FragmentRewardTopicRedDot, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601A7DA RID: 108506 RVA: 0x0082D454 File Offset: 0x0082B654
	protected override bool OnCheck(int uId = 0)
	{
		FragmentMemoryTopicData topicDataById = FragmentMemoryModel.Instance.GetTopicDataById(uId);
		return topicDataById != null && topicDataById.GetCollectRedDotState();
	}
}
