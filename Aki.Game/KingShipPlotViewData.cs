using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002044 RID: 8260
[NullableContext(1)]
[Nullable(0)]
public class KingShipPlotViewData : IKingShipPlotViewData
{
	// Token: 0x170013D5 RID: 5077
	// (get) Token: 0x060103AA RID: 66474 RVA: 0x003F5C01 File Offset: 0x003F3E01
	// (set) Token: 0x060103AB RID: 66475 RVA: 0x003F5C09 File Offset: 0x003F3E09
	public string Path { get; set; }

	// Token: 0x170013D6 RID: 5078
	// (get) Token: 0x060103AC RID: 66476 RVA: 0x003F5C12 File Offset: 0x003F3E12
	// (set) Token: 0x060103AD RID: 66477 RVA: 0x003F5C1A File Offset: 0x003F3E1A
	public List<string> FlowId { get; set; }

	// Token: 0x170013D7 RID: 5079
	// (get) Token: 0x060103AE RID: 66478 RVA: 0x003F5C23 File Offset: 0x003F3E23
	// (set) Token: 0x060103AF RID: 66479 RVA: 0x003F5C2B File Offset: 0x003F3E2B
	public Action OnCloseCallBack { get; set; }
}
