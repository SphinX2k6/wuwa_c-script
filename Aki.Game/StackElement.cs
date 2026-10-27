using System;
using System.Runtime.CompilerServices;

// Token: 0x02003548 RID: 13640
[NullableContext(1)]
[Nullable(0)]
public class StackElement : IStackElement
{
	// Token: 0x17002989 RID: 10633
	// (get) Token: 0x0601DF50 RID: 122704 RVA: 0x0086551F File Offset: 0x0086371F
	// (set) Token: 0x0601DF51 RID: 122705 RVA: 0x00865527 File Offset: 0x00863727
	public string Node { get; set; } = "";

	// Token: 0x1700298A RID: 10634
	// (get) Token: 0x0601DF52 RID: 122706 RVA: 0x00865530 File Offset: 0x00863730
	// (set) Token: 0x0601DF53 RID: 122707 RVA: 0x00865538 File Offset: 0x00863738
	public bool Traversing { get; set; }
}
