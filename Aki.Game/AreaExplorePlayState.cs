using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001AAD RID: 6829
[NullableContext(1)]
[Nullable(0)]
public class AreaExplorePlayState : IAreaExplorePlayState
{
	// Token: 0x170010B8 RID: 4280
	// (get) Token: 0x0600CA45 RID: 51781 RVA: 0x002E1940 File Offset: 0x002DFB40
	// (set) Token: 0x0600CA46 RID: 51782 RVA: 0x002E1948 File Offset: 0x002DFB48
	public EExploreType ExploreType { get; set; }

	// Token: 0x170010B9 RID: 4281
	// (get) Token: 0x0600CA47 RID: 51783 RVA: 0x002E1951 File Offset: 0x002DFB51
	// (set) Token: 0x0600CA48 RID: 51784 RVA: 0x002E1959 File Offset: 0x002DFB59
	public List<EPlayPointState> PlayPointStateList { get; set; }
}
