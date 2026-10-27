using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02003392 RID: 13202
public class FragmentMemoryTopicCollectRedDot : RedDotBase
{
	// Token: 0x0601CAE0 RID: 117472 RVA: 0x00806E54 File Offset: 0x00805054
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.FragmentRewardTopicRedDot, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CAE1 RID: 117473 RVA: 0x00806E72 File Offset: 0x00805072
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.FragmentRewardTopicRedDot, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CAE2 RID: 117474 RVA: 0x00806E90 File Offset: 0x00805090
	protected override bool OnCheck(int uId = 0)
	{
		FragmentMemoryTopicData topicDataById = FragmentMemoryModel.Instance.GetTopicDataById(uId);
		return topicDataById != null && topicDataById.GetCollectRedDotState();
	}
}
