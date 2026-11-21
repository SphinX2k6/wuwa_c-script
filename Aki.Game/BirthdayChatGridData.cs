using System;
using System.Runtime.CompilerServices;

// Token: 0x02001A1F RID: 6687
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class BirthdayChatGridData : MultiTemplateGridDataBase<PhoneMsgChatData, BirthdayChatItem>
{
	// Token: 0x06010730 RID: 67376 RVA: 0x004CF2DF File Offset: 0x004CD4DF
	public BirthdayChatGridData(PhoneMsgChatData data)
	{
		base.Data = data;
	}

	// Token: 0x06010731 RID: 67377 RVA: 0x004CF2EE File Offset: 0x004CD4EE
	public override int GetTemplateIndex()
	{
		return 4;
	}

	// Token: 0x06010732 RID: 67378 RVA: 0x004CF2F1 File Offset: 0x004CD4F1
	public override BirthdayChatItem CreateProxy()
	{
		return new BirthdayChatItem();
	}
}
