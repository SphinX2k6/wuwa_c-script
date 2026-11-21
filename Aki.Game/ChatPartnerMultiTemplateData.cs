using System;
using System.Runtime.CompilerServices;

// Token: 0x02001A2C RID: 6700
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class ChatPartnerMultiTemplateData : MultiTemplateGridDataBase<ChatPartnerTabItemData, TogChatPartner>
{
	// Token: 0x0601080C RID: 67596 RVA: 0x004D4191 File Offset: 0x004D2391
	public override int GetTemplateIndex()
	{
		return 0;
	}

	// Token: 0x0601080D RID: 67597 RVA: 0x004D4194 File Offset: 0x004D2394
	public override TogChatPartner CreateProxy()
	{
		return new TogChatPartner();
	}
}
