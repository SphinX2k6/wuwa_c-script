using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000F6B RID: 3947
[NullableContext(1)]
public interface IAreaExplorePlayState
{
	// Token: 0x170010DB RID: 4315
	// (get) Token: 0x06009E52 RID: 40530
	// (set) Token: 0x06009E53 RID: 40531
	EExploreType ExploreType { get; set; }

	// Token: 0x170010DC RID: 4316
	// (get) Token: 0x06009E54 RID: 40532
	// (set) Token: 0x06009E55 RID: 40533
	List<EPlayPointState> PlayPointStateList { get; set; }
}
