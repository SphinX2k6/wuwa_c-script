using System;
using System.Runtime.CompilerServices;

// Token: 0x02001A21 RID: 6689
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class RewardChatGridData : MultiTemplateGridDataBase<PhoneMsgChatData, RewardChatItem>
{
	// Token: 0x0601073D RID: 67389 RVA: 0x004CF6E7 File Offset: 0x004CD8E7
	public RewardChatGridData(PhoneMsgChatData data)
	{
		base.Data = data;
	}

	// Token: 0x0601073E RID: 67390 RVA: 0x004CF6F6 File Offset: 0x004CD8F6
	public override int GetTemplateIndex()
	{
		return 5;
	}

	// Token: 0x0601073F RID: 67391 RVA: 0x004CF6F9 File Offset: 0x004CD8F9
	public override RewardChatItem CreateProxy()
	{
		return new RewardChatItem
		{
			OnRewardClick = this.OnRewardClick
		};
	}

	// Token: 0x040091F3 RID: 37363
	[Nullable(2)]
	public Action OnRewardClick;
}
