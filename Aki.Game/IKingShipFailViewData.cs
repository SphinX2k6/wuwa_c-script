using System;
using System.Runtime.CompilerServices;

// Token: 0x02002039 RID: 8249
[NullableContext(1)]
public interface IKingShipFailViewData
{
	// Token: 0x170013C4 RID: 5060
	// (get) Token: 0x0601032C RID: 66348
	// (set) Token: 0x0601032D RID: 66349
	int CardId { get; set; }

	// Token: 0x170013C5 RID: 5061
	// (get) Token: 0x0601032E RID: 66350
	// (set) Token: 0x0601032F RID: 66351
	Action OnCloseCallBack { get; set; }
}
