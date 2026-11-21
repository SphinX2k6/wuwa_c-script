using System;
using System.Runtime.CompilerServices;

// Token: 0x02001A17 RID: 6679
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class TipsChatGridData : MultiTemplateGridDataBase<PhoneMsgChatData, TipsChatItem>
{
	// Token: 0x06010705 RID: 67333 RVA: 0x004CE382 File Offset: 0x004CC582
	public TipsChatGridData(PhoneMsgChatData data)
	{
		base.Data = data;
	}

	// Token: 0x06010706 RID: 67334 RVA: 0x004CE391 File Offset: 0x004CC591
	public override int GetTemplateIndex()
	{
		return 2;
	}

	// Token: 0x06010707 RID: 67335 RVA: 0x004CE394 File Offset: 0x004CC594
	public override TipsChatItem CreateProxy()
	{
		return new TipsChatItem();
	}
}
