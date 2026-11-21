using System;
using Aki.Config;

// Token: 0x02000439 RID: 1081
public interface IFurnitureScrollItemData
{
	// Token: 0x170007F8 RID: 2040
	// (get) Token: 0x0600397E RID: 14718
	Furniture FurnitureConfig { get; }

	// Token: 0x170007F9 RID: 2041
	// (get) Token: 0x0600397F RID: 14719
	bool RedDotShowState { get; }

	// Token: 0x170007FA RID: 2042
	// (get) Token: 0x06003980 RID: 14720
	bool IsSelected { get; }

	// Token: 0x170007FB RID: 2043
	// (get) Token: 0x06003981 RID: 14721
	int LeftCount { get; }

	// Token: 0x170007FC RID: 2044
	// (get) Token: 0x06003982 RID: 14722
	bool IsLock { get; }

	// Token: 0x170007FD RID: 2045
	// (get) Token: 0x06003983 RID: 14723
	bool IsCheck { get; }
}
