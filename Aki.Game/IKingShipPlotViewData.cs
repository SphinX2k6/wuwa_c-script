using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002043 RID: 8259
[NullableContext(1)]
public interface IKingShipPlotViewData
{
	// Token: 0x170013D2 RID: 5074
	// (get) Token: 0x060103A4 RID: 66468
	// (set) Token: 0x060103A5 RID: 66469
	string Path { get; set; }

	// Token: 0x170013D3 RID: 5075
	// (get) Token: 0x060103A6 RID: 66470
	// (set) Token: 0x060103A7 RID: 66471
	List<string> FlowId { get; set; }

	// Token: 0x170013D4 RID: 5076
	// (get) Token: 0x060103A8 RID: 66472
	// (set) Token: 0x060103A9 RID: 66473
	Action OnCloseCallBack { get; set; }
}
