using System;
using System.Runtime.CompilerServices;

// Token: 0x02002ABD RID: 10941
[NullableContext(1)]
[Nullable(0)]
public class StackElement : IStackElement
{
	// Token: 0x17002D22 RID: 11554
	// (get) Token: 0x0601BC78 RID: 113784 RVA: 0x0088D157 File Offset: 0x0088B357
	// (set) Token: 0x0601BC79 RID: 113785 RVA: 0x0088D15F File Offset: 0x0088B35F
	public string Node { get; set; } = "";

	// Token: 0x17002D23 RID: 11555
	// (get) Token: 0x0601BC7A RID: 113786 RVA: 0x0088D168 File Offset: 0x0088B368
	// (set) Token: 0x0601BC7B RID: 113787 RVA: 0x0088D170 File Offset: 0x0088B370
	public bool Traversing { get; set; }
}
