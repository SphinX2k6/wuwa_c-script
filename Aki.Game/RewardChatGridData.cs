using System;
using System.Runtime.CompilerServices;

// Token: 0x02002538 RID: 9528
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class RewardChatGridData : MultiTemplateGridDataBase<PhoneMsgChatData, RewardChatItem>
{
	// Token: 0x0601326A RID: 78442 RVA: 0x004C1123 File Offset: 0x004BF323
	public RewardChatGridData(PhoneMsgChatData data)
	{
		base.Data = data;
	}

	// Token: 0x0601326B RID: 78443 RVA: 0x004C1132 File Offset: 0x004BF332
	public override int GetTemplateIndex()
	{
		return 5;
	}

	// Token: 0x0601326C RID: 78444 RVA: 0x004C1135 File Offset: 0x004BF335
	public override RewardChatItem CreateProxy()
	{
		return new RewardChatItem
		{
			OnRewardClick = this.OnRewardClick
		};
	}

	// Token: 0x04009099 RID: 37017
	[Nullable(2)]
	public Action OnRewardClick;
}
