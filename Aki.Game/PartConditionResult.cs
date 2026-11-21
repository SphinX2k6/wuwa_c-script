using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001A8A RID: 6794
[NullableContext(1)]
[Nullable(0)]
public class PartConditionResult : IPartConditionResult
{
	// Token: 0x17001950 RID: 6480
	// (get) Token: 0x06010CF9 RID: 68857 RVA: 0x004ED9AF File Offset: 0x004EBBAF
	// (set) Token: 0x06010CFA RID: 68858 RVA: 0x004ED9B7 File Offset: 0x004EBBB7
	public bool Satisfied { get; set; }

	// Token: 0x17001951 RID: 6481
	// (get) Token: 0x06010CFB RID: 68859 RVA: 0x004ED9C0 File Offset: 0x004EBBC0
	// (set) Token: 0x06010CFC RID: 68860 RVA: 0x004ED9C8 File Offset: 0x004EBBC8
	public List<Vector> PartPositions { get; set; } = new List<Vector>();
}
