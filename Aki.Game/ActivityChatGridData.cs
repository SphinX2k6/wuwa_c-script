using System;
using System.Runtime.CompilerServices;

// Token: 0x02001A1D RID: 6685
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class ActivityChatGridData : MultiTemplateGridDataBase<PhoneMsgChatData, ActivityChatItem>
{
	// Token: 0x06010721 RID: 67361 RVA: 0x004CECC7 File Offset: 0x004CCEC7
	public ActivityChatGridData(PhoneMsgChatData data)
	{
		base.Data = data;
	}

	// Token: 0x06010722 RID: 67362 RVA: 0x004CECD6 File Offset: 0x004CCED6
	public override int GetTemplateIndex()
	{
		return 7;
	}

	// Token: 0x06010723 RID: 67363 RVA: 0x004CECD9 File Offset: 0x004CCED9
	public override ActivityChatItem CreateProxy()
	{
		return new ActivityChatItem();
	}
}
