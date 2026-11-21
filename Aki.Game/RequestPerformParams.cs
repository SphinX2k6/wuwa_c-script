using System;
using System.Runtime.CompilerServices;

// Token: 0x020025CC RID: 9676
[NullableContext(1)]
[Nullable(0)]
public class RequestPerformParams : IRequestPerformParams
{
	// Token: 0x170025A6 RID: 9638
	// (get) Token: 0x0601812A RID: 98602 RVA: 0x00737CB1 File Offset: 0x00735EB1
	// (set) Token: 0x0601812B RID: 98603 RVA: 0x00737CB9 File Offset: 0x00735EB9
	public int Signal { get; set; }

	// Token: 0x170025A7 RID: 9639
	// (get) Token: 0x0601812C RID: 98604 RVA: 0x00737CC2 File Offset: 0x00735EC2
	// (set) Token: 0x0601812D RID: 98605 RVA: 0x00737CCA File Offset: 0x00735ECA
	public Entity Source { get; set; }
}
