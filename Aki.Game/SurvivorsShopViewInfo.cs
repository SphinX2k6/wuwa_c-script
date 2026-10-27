using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02002AEA RID: 10986
[NullableContext(1)]
[Nullable(0)]
internal class SurvivorsShopViewInfo : ISurvivorsShopViewInfo
{
	// Token: 0x17001E75 RID: 7797
	// (get) Token: 0x06016DC2 RID: 93634 RVA: 0x005CD1D4 File Offset: 0x005CB3D4
	// (set) Token: 0x06016DC3 RID: 93635 RVA: 0x005CD1DC File Offset: 0x005CB3DC
	public List<GoodsDetail> DataList { get; set; }

	// Token: 0x17001E76 RID: 7798
	// (get) Token: 0x06016DC4 RID: 93636 RVA: 0x005CD1E5 File Offset: 0x005CB3E5
	// (set) Token: 0x06016DC5 RID: 93637 RVA: 0x005CD1ED File Offset: 0x005CB3ED
	public int RefreshItemId { get; set; }

	// Token: 0x17001E77 RID: 7799
	// (get) Token: 0x06016DC6 RID: 93638 RVA: 0x005CD1F6 File Offset: 0x005CB3F6
	// (set) Token: 0x06016DC7 RID: 93639 RVA: 0x005CD1FE File Offset: 0x005CB3FE
	public int RefreshCost { get; set; }
}
