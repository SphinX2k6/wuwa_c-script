using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001275 RID: 4725
[NullableContext(1)]
public interface ICameraConditionRecommend
{
	// Token: 0x17000B13 RID: 2835
	// (get) Token: 0x060080CD RID: 32973
	// (set) Token: 0x060080CE RID: 32974
	HashSet<int> FilterIds { get; set; }

	// Token: 0x17000B14 RID: 2836
	// (get) Token: 0x060080CF RID: 32975
	// (set) Token: 0x060080D0 RID: 32976
	HashSet<int> FrameIds { get; set; }
}
