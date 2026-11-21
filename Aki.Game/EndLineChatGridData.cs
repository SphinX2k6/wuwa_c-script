using System;
using System.Runtime.CompilerServices;

// Token: 0x02001A23 RID: 6691
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class EndLineChatGridData : MultiTemplateGridDataBase<bool, EndLineChatItem>
{
	// Token: 0x06010748 RID: 67400 RVA: 0x004CF94B File Offset: 0x004CDB4B
	public EndLineChatGridData(bool data)
	{
		base.Data = data;
	}

	// Token: 0x06010749 RID: 67401 RVA: 0x004CF95A File Offset: 0x004CDB5A
	public override int GetTemplateIndex()
	{
		return 6;
	}

	// Token: 0x0601074A RID: 67402 RVA: 0x004CF95D File Offset: 0x004CDB5D
	public override EndLineChatItem CreateProxy()
	{
		return new EndLineChatItem();
	}
}
