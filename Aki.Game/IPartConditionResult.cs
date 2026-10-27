using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200259E RID: 9630
[NullableContext(1)]
public interface IPartConditionResult
{
	// Token: 0x17001914 RID: 6420
	// (get) Token: 0x06013813 RID: 79891
	// (set) Token: 0x06013814 RID: 79892
	bool Satisfied { get; set; }

	// Token: 0x17001915 RID: 6421
	// (get) Token: 0x06013815 RID: 79893
	// (set) Token: 0x06013816 RID: 79894
	List<Vector> PartPositions { get; set; }
}
