using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02002066 RID: 8294
[NullableContext(1)]
[Nullable(0)]
internal class SurvivorsShopViewInfo : ISurvivorsShopViewInfo
{
	// Token: 0x17001ECD RID: 7885
	// (get) Token: 0x060147F3 RID: 83955 RVA: 0x005F9D24 File Offset: 0x005F7F24
	// (set) Token: 0x060147F4 RID: 83956 RVA: 0x005F9D2C File Offset: 0x005F7F2C
	public List<GoodsDetail> DataList { get; set; }

	// Token: 0x17001ECE RID: 7886
	// (get) Token: 0x060147F5 RID: 83957 RVA: 0x005F9D35 File Offset: 0x005F7F35
	// (set) Token: 0x060147F6 RID: 83958 RVA: 0x005F9D3D File Offset: 0x005F7F3D
	public int RefreshItemId { get; set; }

	// Token: 0x17001ECF RID: 7887
	// (get) Token: 0x060147F7 RID: 83959 RVA: 0x005F9D46 File Offset: 0x005F7F46
	// (set) Token: 0x060147F8 RID: 83960 RVA: 0x005F9D4E File Offset: 0x005F7F4E
	public int RefreshCost { get; set; }
}
