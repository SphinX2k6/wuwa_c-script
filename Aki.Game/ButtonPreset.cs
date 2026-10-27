using System;
using System.Runtime.CompilerServices;

// Token: 0x02002194 RID: 8596
[NullableContext(1)]
[Nullable(0)]
public class ButtonPreset : IButtonPreset
{
	// Token: 0x1700152E RID: 5422
	// (get) Token: 0x06010B5E RID: 68446 RVA: 0x0040F61B File Offset: 0x0040D81B
	// (set) Token: 0x06010B5F RID: 68447 RVA: 0x0040F623 File Offset: 0x0040D823
	public string Title { get; set; }

	// Token: 0x1700152F RID: 5423
	// (get) Token: 0x06010B60 RID: 68448 RVA: 0x0040F62C File Offset: 0x0040D82C
	// (set) Token: 0x06010B61 RID: 68449 RVA: 0x0040F634 File Offset: 0x0040D834
	public Action ClickFunc { get; set; }
}
