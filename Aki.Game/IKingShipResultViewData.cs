using System;

// Token: 0x02002048 RID: 8264
public interface IKingShipResultViewData
{
	// Token: 0x170013D8 RID: 5080
	// (get) Token: 0x060103BF RID: 66495
	// (set) Token: 0x060103C0 RID: 66496
	int CardId { get; set; }

	// Token: 0x170013D9 RID: 5081
	// (get) Token: 0x060103C1 RID: 66497
	// (set) Token: 0x060103C2 RID: 66498
	int ReignsId { get; set; }

	// Token: 0x170013DA RID: 5082
	// (get) Token: 0x060103C3 RID: 66499
	// (set) Token: 0x060103C4 RID: 66500
	bool IsSuccess { get; set; }

	// Token: 0x170013DB RID: 5083
	// (get) Token: 0x060103C5 RID: 66501
	// (set) Token: 0x060103C6 RID: 66502
	int NextReignsId { get; set; }
}
