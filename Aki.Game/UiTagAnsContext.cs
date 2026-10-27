using System;
using System.Runtime.CompilerServices;

// Token: 0x02002C7E RID: 11390
public class UiTagAnsContext : UiAnsContextBase
{
	// Token: 0x17002004 RID: 8196
	// (get) Token: 0x06017CBB RID: 97467 RVA: 0x0060D65B File Offset: 0x0060B85B
	public int TagId { get; }

	// Token: 0x06017CBC RID: 97468 RVA: 0x0060D663 File Offset: 0x0060B863
	public UiTagAnsContext(int tagId)
	{
		this.TagId = tagId;
	}

	// Token: 0x06017CBD RID: 97469 RVA: 0x0060D674 File Offset: 0x0060B874
	[NullableContext(1)]
	public override bool IsEqual(UiAnsContextBase inAnsContext)
	{
		UiTagAnsContext uiTagAnsContext = inAnsContext as UiTagAnsContext;
		return uiTagAnsContext != null && this.TagId == uiTagAnsContext.TagId;
	}
}
