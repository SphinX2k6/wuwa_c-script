using System;
using System.Runtime.CompilerServices;

// Token: 0x02001744 RID: 5956
[NullableContext(1)]
public interface IMotorTechNodeListData
{
	// Token: 0x17001620 RID: 5664
	// (get) Token: 0x0600E725 RID: 59173
	// (set) Token: 0x0600E726 RID: 59174
	int[] TopIds { get; set; }

	// Token: 0x17001621 RID: 5665
	// (get) Token: 0x0600E727 RID: 59175
	// (set) Token: 0x0600E728 RID: 59176
	int[] BottomIds { get; set; }

	// Token: 0x17001622 RID: 5666
	// (get) Token: 0x0600E729 RID: 59177
	// (set) Token: 0x0600E72A RID: 59178
	int MiddleId { get; set; }
}
