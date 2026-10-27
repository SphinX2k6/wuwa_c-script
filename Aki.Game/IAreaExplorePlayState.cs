using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001AAC RID: 6828
[NullableContext(1)]
public interface IAreaExplorePlayState
{
	// Token: 0x170010B6 RID: 4278
	// (get) Token: 0x0600CA41 RID: 51777
	// (set) Token: 0x0600CA42 RID: 51778
	EExploreType ExploreType { get; set; }

	// Token: 0x170010B7 RID: 4279
	// (get) Token: 0x0600CA43 RID: 51779
	// (set) Token: 0x0600CA44 RID: 51780
	List<EPlayPointState> PlayPointStateList { get; set; }
}
