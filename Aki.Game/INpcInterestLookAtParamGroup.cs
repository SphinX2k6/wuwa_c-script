using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020031EF RID: 12783
[NullableContext(1)]
public interface INpcInterestLookAtParamGroup
{
	// Token: 0x17002625 RID: 9765
	// (get) Token: 0x0601B949 RID: 112969
	// (set) Token: 0x0601B94A RID: 112970
	string Key { get; set; }

	// Token: 0x17002626 RID: 9766
	// (get) Token: 0x0601B94B RID: 112971
	// (set) Token: 0x0601B94C RID: 112972
	IList<int> PbDataIds { get; set; }

	// Token: 0x17002627 RID: 9767
	// (get) Token: 0x0601B94D RID: 112973
	// (set) Token: 0x0601B94E RID: 112974
	IList<INpcInterestLookAtParam> Params { get; set; }
}
