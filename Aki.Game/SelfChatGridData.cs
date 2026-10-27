using System;
using System.Runtime.CompilerServices;

// Token: 0x02002540 RID: 9536
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class SelfChatGridData : MultiTemplateGridDataBase<PhoneMsgChatData, PhoneMsgSelfChatItem>
{
	// Token: 0x060132A1 RID: 78497 RVA: 0x004C21F6 File Offset: 0x004C03F6
	public SelfChatGridData(PhoneMsgChatData data)
	{
		base.Data = data;
	}

	// Token: 0x060132A2 RID: 78498 RVA: 0x004C2205 File Offset: 0x004C0405
	public override int GetTemplateIndex()
	{
		return 1;
	}

	// Token: 0x060132A3 RID: 78499 RVA: 0x004C2208 File Offset: 0x004C0408
	public override PhoneMsgSelfChatItem CreateProxy()
	{
		return new PhoneMsgSelfChatItem
		{
			OnOptionItemClickDelegate = this.OnOptionItemClickDelegate,
			OnItemClickDelegate = this.OnItemClickDelegate
		};
	}

	// Token: 0x040090D8 RID: 37080
	[Nullable(2)]
	public Action<int, int> OnOptionItemClickDelegate;

	// Token: 0x040090D9 RID: 37081
	[Nullable(2)]
	public Action<int> OnItemClickDelegate;
}
