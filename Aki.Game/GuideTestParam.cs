using System;
using System.Runtime.CompilerServices;

// Token: 0x0200127E RID: 4734
[NullableContext(1)]
[Nullable(0)]
public class GuideTestParam
{
	// Token: 0x0600BB47 RID: 47943 RVA: 0x0037302C File Offset: 0x0037122C
	public void Clear()
	{
		this.ViewName = "";
		this.HookName = "";
		this.HookNameForShow = "";
		this.MarkName = "";
		this.MarkNameForShow = "";
		this.ExtraParams = Array.Empty<string>();
	}

	// Token: 0x04006BCD RID: 27597
	public string ViewName = "";

	// Token: 0x04006BCE RID: 27598
	public string HookName = "";

	// Token: 0x04006BCF RID: 27599
	public string HookNameForShow = "";

	// Token: 0x04006BD0 RID: 27600
	public string MarkName = "";

	// Token: 0x04006BD1 RID: 27601
	public string MarkNameForShow = "";

	// Token: 0x04006BD2 RID: 27602
	public string[] ExtraParams = Array.Empty<string>();
}
