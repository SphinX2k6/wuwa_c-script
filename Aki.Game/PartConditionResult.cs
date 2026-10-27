using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200259F RID: 9631
[NullableContext(1)]
[Nullable(0)]
public class PartConditionResult : IPartConditionResult
{
	// Token: 0x17001916 RID: 6422
	// (get) Token: 0x06013817 RID: 79895 RVA: 0x004DEE7B File Offset: 0x004DD07B
	// (set) Token: 0x06013818 RID: 79896 RVA: 0x004DEE83 File Offset: 0x004DD083
	public bool Satisfied { get; set; }

	// Token: 0x17001917 RID: 6423
	// (get) Token: 0x06013819 RID: 79897 RVA: 0x004DEE8C File Offset: 0x004DD08C
	// (set) Token: 0x0601381A RID: 79898 RVA: 0x004DEE94 File Offset: 0x004DD094
	public List<Vector> PartPositions { get; set; } = new List<Vector>();
}
