using System;
using System.Runtime.CompilerServices;

// Token: 0x0200150C RID: 5388
[NullableContext(1)]
public interface IKingShipFailViewData
{
	// Token: 0x170013F1 RID: 5105
	// (get) Token: 0x0600D794 RID: 55188
	// (set) Token: 0x0600D795 RID: 55189
	int CardId { get; set; }

	// Token: 0x170013F2 RID: 5106
	// (get) Token: 0x0600D796 RID: 55190
	// (set) Token: 0x0600D797 RID: 55191
	Action OnCloseCallBack { get; set; }
}
