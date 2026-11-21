using System;
using System.Runtime.CompilerServices;

// Token: 0x020021D7 RID: 8663
public class UiTagAnsContext : UiAnsContextBase
{
	// Token: 0x17002055 RID: 8277
	// (get) Token: 0x0601552E RID: 87342 RVA: 0x0063313F File Offset: 0x0063133F
	public int TagId { get; }

	// Token: 0x0601552F RID: 87343 RVA: 0x00633147 File Offset: 0x00631347
	public UiTagAnsContext(int tagId)
	{
		this.TagId = tagId;
	}

	// Token: 0x06015530 RID: 87344 RVA: 0x00633158 File Offset: 0x00631358
	[NullableContext(1)]
	public override bool IsEqual(UiAnsContextBase inAnsContext)
	{
		UiTagAnsContext uiTagAnsContext = inAnsContext as UiTagAnsContext;
		return uiTagAnsContext != null && this.TagId == uiTagAnsContext.TagId;
	}
}
