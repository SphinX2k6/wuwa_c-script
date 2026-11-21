using System;

// Token: 0x020003F4 RID: 1012
public interface IDrinksRequireInfo
{
	// Token: 0x170007C1 RID: 1985
	// (get) Token: 0x06003724 RID: 14116
	// (set) Token: 0x06003725 RID: 14117
	int RequireId { get; set; }

	// Token: 0x170007C2 RID: 1986
	// (get) Token: 0x06003726 RID: 14118
	// (set) Token: 0x06003727 RID: 14119
	EDrinksRequireType Type { get; set; }

	// Token: 0x170007C3 RID: 1987
	// (get) Token: 0x06003728 RID: 14120
	// (set) Token: 0x06003729 RID: 14121
	int? FlavorRangeId { get; set; }

	// Token: 0x170007C4 RID: 1988
	// (get) Token: 0x0600372A RID: 14122
	// (set) Token: 0x0600372B RID: 14123
	bool Completed { get; set; }
}
