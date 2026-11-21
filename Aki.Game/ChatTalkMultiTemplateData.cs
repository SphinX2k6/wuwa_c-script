using System;
using System.Runtime.CompilerServices;

// Token: 0x02001A2D RID: 6701
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class ChatTalkMultiTemplateData : MultiTemplateGridDataBase<ChatTalkTabItemData, TogChatTalkItem>
{
	// Token: 0x0601080F RID: 67599 RVA: 0x004D41A3 File Offset: 0x004D23A3
	public override int GetTemplateIndex()
	{
		return 1;
	}

	// Token: 0x06010810 RID: 67600 RVA: 0x004D41A6 File Offset: 0x004D23A6
	public override TogChatTalkItem CreateProxy()
	{
		return new TogChatTalkItem();
	}
}
