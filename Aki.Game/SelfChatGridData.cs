using System;
using System.Runtime.CompilerServices;

// Token: 0x02001A29 RID: 6697
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class SelfChatGridData : MultiTemplateGridDataBase<PhoneMsgChatData, PhoneMsgSelfChatItem>
{
	// Token: 0x06010774 RID: 67444 RVA: 0x004D07FA File Offset: 0x004CE9FA
	public SelfChatGridData(PhoneMsgChatData data)
	{
		base.Data = data;
	}

	// Token: 0x06010775 RID: 67445 RVA: 0x004D0809 File Offset: 0x004CEA09
	public override int GetTemplateIndex()
	{
		return 1;
	}

	// Token: 0x06010776 RID: 67446 RVA: 0x004D080C File Offset: 0x004CEA0C
	public override PhoneMsgSelfChatItem CreateProxy()
	{
		return new PhoneMsgSelfChatItem
		{
			OnOptionItemClickDelegate = this.OnOptionItemClickDelegate,
			OnItemClickDelegate = this.OnItemClickDelegate
		};
	}

	// Token: 0x04009232 RID: 37426
	[Nullable(2)]
	public Action<int, int> OnOptionItemClickDelegate;

	// Token: 0x04009233 RID: 37427
	[Nullable(2)]
	public Action<int> OnItemClickDelegate;
}
