using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001516 RID: 5398
[NullableContext(1)]
public interface IKingShipPlotViewData
{
	// Token: 0x170013FF RID: 5119
	// (get) Token: 0x0600D80C RID: 55308
	// (set) Token: 0x0600D80D RID: 55309
	string Path { get; set; }

	// Token: 0x17001400 RID: 5120
	// (get) Token: 0x0600D80E RID: 55310
	// (set) Token: 0x0600D80F RID: 55311
	List<string> FlowId { get; set; }

	// Token: 0x17001401 RID: 5121
	// (get) Token: 0x0600D810 RID: 55312
	// (set) Token: 0x0600D811 RID: 55313
	Action OnCloseCallBack { get; set; }
}
