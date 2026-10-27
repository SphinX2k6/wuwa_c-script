using System;
using System.Runtime.CompilerServices;

// Token: 0x02002536 RID: 9526
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class BirthdayChatGridData : MultiTemplateGridDataBase<PhoneMsgChatData, BirthdayChatItem>
{
	// Token: 0x0601325D RID: 78429 RVA: 0x004C0D1B File Offset: 0x004BEF1B
	public BirthdayChatGridData(PhoneMsgChatData data)
	{
		base.Data = data;
	}

	// Token: 0x0601325E RID: 78430 RVA: 0x004C0D2A File Offset: 0x004BEF2A
	public override int GetTemplateIndex()
	{
		return 4;
	}

	// Token: 0x0601325F RID: 78431 RVA: 0x004C0D2D File Offset: 0x004BEF2D
	public override BirthdayChatItem CreateProxy()
	{
		return new BirthdayChatItem();
	}
}
