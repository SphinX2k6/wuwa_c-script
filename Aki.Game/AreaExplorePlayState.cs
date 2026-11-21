using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000F6C RID: 3948
[NullableContext(1)]
[Nullable(0)]
public class AreaExplorePlayState : IAreaExplorePlayState
{
	// Token: 0x170010DD RID: 4317
	// (get) Token: 0x06009E56 RID: 40534 RVA: 0x002ECA90 File Offset: 0x002EAC90
	// (set) Token: 0x06009E57 RID: 40535 RVA: 0x002ECA98 File Offset: 0x002EAC98
	public EExploreType ExploreType { get; set; }

	// Token: 0x170010DE RID: 4318
	// (get) Token: 0x06009E58 RID: 40536 RVA: 0x002ECAA1 File Offset: 0x002EACA1
	// (set) Token: 0x06009E59 RID: 40537 RVA: 0x002ECAA9 File Offset: 0x002EACA9
	public List<EPlayPointState> PlayPointStateList { get; set; }
}
