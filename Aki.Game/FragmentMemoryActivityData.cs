using System;

// Token: 0x02001C18 RID: 7192
public class FragmentMemoryActivityData : ActivityBaseData
{
	// Token: 0x0600D7B9 RID: 55225 RVA: 0x0031F048 File Offset: 0x0031D248
	public override bool GetExDataRedPointShowState()
	{
		return this.EntranceRedDot();
	}

	// Token: 0x0600D7BA RID: 55226 RVA: 0x0031F050 File Offset: 0x0031D250
	protected override bool GetExDataFinishShowState()
	{
		int topicId = FragmentMemoryConfig.Instance.GetPhotoMemoryActivityById(base.Id).Value.TopicId;
		FragmentMemoryTopicData topicDataById = FragmentMemoryModel.Instance.GetTopicDataById(topicId);
		return topicDataById != null && topicDataById.GetCollectRewardDoneState();
	}

	// Token: 0x0600D7BB RID: 55227 RVA: 0x0031F098 File Offset: 0x0031D298
	public bool EntranceRedDot()
	{
		return FragmentMemoryModel.Instance.GetRedDotState();
	}

	// Token: 0x0600D7BC RID: 55228 RVA: 0x0031F0A4 File Offset: 0x0031D2A4
	public int GetCurrentTopicId()
	{
		return FragmentMemoryConfig.Instance.GetPhotoMemoryActivityById(base.Id).Value.TopicId;
	}
}
