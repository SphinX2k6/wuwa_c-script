using System;

// Token: 0x020010D7 RID: 4311
public class FragmentMemoryActivityData : ActivityBaseData
{
	// Token: 0x0600ABCD RID: 43981 RVA: 0x0032A398 File Offset: 0x00328598
	public override bool GetExDataRedPointShowState()
	{
		return this.EntranceRedDot();
	}

	// Token: 0x0600ABCE RID: 43982 RVA: 0x0032A3A0 File Offset: 0x003285A0
	protected override bool GetExDataFinishShowState()
	{
		int topicId = FragmentMemoryConfig.Instance.GetPhotoMemoryActivityById(base.Id).Value.TopicId;
		FragmentMemoryTopicData topicDataById = FragmentMemoryModel.Instance.GetTopicDataById(topicId);
		return topicDataById != null && topicDataById.GetCollectRewardDoneState();
	}

	// Token: 0x0600ABCF RID: 43983 RVA: 0x0032A3E8 File Offset: 0x003285E8
	public bool EntranceRedDot()
	{
		return FragmentMemoryModel.Instance.GetRedDotState();
	}

	// Token: 0x0600ABD0 RID: 43984 RVA: 0x0032A3F4 File Offset: 0x003285F4
	public int GetCurrentTopicId()
	{
		return FragmentMemoryConfig.Instance.GetPhotoMemoryActivityById(base.Id).Value.TopicId;
	}
}
