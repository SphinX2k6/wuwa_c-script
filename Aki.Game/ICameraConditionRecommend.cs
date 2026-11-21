using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000729 RID: 1833
[NullableContext(1)]
public interface ICameraConditionRecommend
{
	// Token: 0x17000B33 RID: 2867
	// (get) Token: 0x06005464 RID: 21604
	// (set) Token: 0x06005465 RID: 21605
	HashSet<int> FilterIds { get; set; }

	// Token: 0x17000B34 RID: 2868
	// (get) Token: 0x06005466 RID: 21606
	// (set) Token: 0x06005467 RID: 21607
	HashSet<int> FrameIds { get; set; }
}
