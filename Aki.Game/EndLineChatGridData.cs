using System;
using System.Runtime.CompilerServices;

// Token: 0x0200253A RID: 9530
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class EndLineChatGridData : MultiTemplateGridDataBase<bool, EndLineChatItem>
{
	// Token: 0x06013275 RID: 78453 RVA: 0x004C1387 File Offset: 0x004BF587
	public EndLineChatGridData(bool data)
	{
		base.Data = data;
	}

	// Token: 0x06013276 RID: 78454 RVA: 0x004C1396 File Offset: 0x004BF596
	public override int GetTemplateIndex()
	{
		return 6;
	}

	// Token: 0x06013277 RID: 78455 RVA: 0x004C1399 File Offset: 0x004BF599
	public override EndLineChatItem CreateProxy()
	{
		return new EndLineChatItem();
	}
}
