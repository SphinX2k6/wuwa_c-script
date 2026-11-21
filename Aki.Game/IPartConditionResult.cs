using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001A89 RID: 6793
[NullableContext(1)]
public interface IPartConditionResult
{
	// Token: 0x1700194E RID: 6478
	// (get) Token: 0x06010CF5 RID: 68853
	// (set) Token: 0x06010CF6 RID: 68854
	bool Satisfied { get; set; }

	// Token: 0x1700194F RID: 6479
	// (get) Token: 0x06010CF7 RID: 68855
	// (set) Token: 0x06010CF8 RID: 68856
	List<Vector> PartPositions { get; set; }
}
