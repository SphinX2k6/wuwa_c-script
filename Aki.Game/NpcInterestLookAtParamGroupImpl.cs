using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020031F0 RID: 12784
[NullableContext(1)]
[Nullable(0)]
public class NpcInterestLookAtParamGroupImpl : INpcInterestLookAtParamGroup
{
	// Token: 0x17002628 RID: 9768
	// (get) Token: 0x0601B94F RID: 112975 RVA: 0x007923B5 File Offset: 0x007905B5
	// (set) Token: 0x0601B950 RID: 112976 RVA: 0x007923BD File Offset: 0x007905BD
	public string Key { get; set; }

	// Token: 0x17002629 RID: 9769
	// (get) Token: 0x0601B951 RID: 112977 RVA: 0x007923C6 File Offset: 0x007905C6
	// (set) Token: 0x0601B952 RID: 112978 RVA: 0x007923CE File Offset: 0x007905CE
	public IList<int> PbDataIds { get; set; }

	// Token: 0x1700262A RID: 9770
	// (get) Token: 0x0601B953 RID: 112979 RVA: 0x007923D7 File Offset: 0x007905D7
	// (set) Token: 0x0601B954 RID: 112980 RVA: 0x007923DF File Offset: 0x007905DF
	public IList<INpcInterestLookAtParam> Params { get; set; }
}
