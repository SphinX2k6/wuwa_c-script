using System;
using System.Runtime.CompilerServices;

// Token: 0x02001A87 RID: 6791
[NullableContext(1)]
public interface ISatisfiedTrackingPoint
{
	// Token: 0x17001948 RID: 6472
	// (get) Token: 0x06010CE8 RID: 68840
	// (set) Token: 0x06010CE9 RID: 68841
	Vector Position { get; set; }

	// Token: 0x17001949 RID: 6473
	// (get) Token: 0x06010CEA RID: 68842
	// (set) Token: 0x06010CEB RID: 68843
	bool IsOptional { get; set; }

	// Token: 0x1700194A RID: 6474
	// (get) Token: 0x06010CEC RID: 68844
	// (set) Token: 0x06010CED RID: 68845
	string Id { get; set; }
}
