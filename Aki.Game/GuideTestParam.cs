using System;
using System.Runtime.CompilerServices;

// Token: 0x02001DBC RID: 7612
[NullableContext(1)]
[Nullable(0)]
public class GuideTestParam
{
	// Token: 0x0600E729 RID: 59177 RVA: 0x003673CC File Offset: 0x003655CC
	public void Clear()
	{
		this.ViewName = "";
		this.HookName = "";
		this.HookNameForShow = "";
		this.MarkName = "";
		this.MarkNameForShow = "";
		this.ExtraParams = Array.Empty<string>();
	}

	// Token: 0x04006AEC RID: 27372
	public string ViewName = "";

	// Token: 0x04006AED RID: 27373
	public string HookName = "";

	// Token: 0x04006AEE RID: 27374
	public string HookNameForShow = "";

	// Token: 0x04006AEF RID: 27375
	public string MarkName = "";

	// Token: 0x04006AF0 RID: 27376
	public string MarkNameForShow = "";

	// Token: 0x04006AF1 RID: 27377
	public string[] ExtraParams = Array.Empty<string>();
}
