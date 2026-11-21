using System;
using System.Runtime.CompilerServices;

// Token: 0x02001A26 RID: 6694
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class OtherChatGridData : MultiTemplateGridDataBase<PhoneMsgChatData, PhoneMsgOtherChatItem>
{
	// Token: 0x0601074D RID: 67405 RVA: 0x004CF96E File Offset: 0x004CDB6E
	public OtherChatGridData(PhoneMsgChatData data)
	{
		base.Data = data;
	}

	// Token: 0x0601074E RID: 67406 RVA: 0x004CF97D File Offset: 0x004CDB7D
	public override int GetTemplateIndex()
	{
		return 0;
	}

	// Token: 0x0601074F RID: 67407 RVA: 0x004CF980 File Offset: 0x004CDB80
	public override PhoneMsgOtherChatItem CreateProxy()
	{
		return new PhoneMsgOtherChatItem
		{
			OnItemClickDelegate = this.OnItemClickDelegate
		};
	}

	// Token: 0x0400920B RID: 37387
	[Nullable(2)]
	public Action<int> OnItemClickDelegate;
}
