using System;
using Aki.Config;

// Token: 0x02000F84 RID: 3972
public interface IFurnitureScrollItemData
{
	// Token: 0x170007D6 RID: 2006
	// (get) Token: 0x060065E6 RID: 26086
	Furniture FurnitureConfig { get; }

	// Token: 0x170007D7 RID: 2007
	// (get) Token: 0x060065E7 RID: 26087
	bool RedDotShowState { get; }

	// Token: 0x170007D8 RID: 2008
	// (get) Token: 0x060065E8 RID: 26088
	bool IsSelected { get; }

	// Token: 0x170007D9 RID: 2009
	// (get) Token: 0x060065E9 RID: 26089
	int LeftCount { get; }

	// Token: 0x170007DA RID: 2010
	// (get) Token: 0x060065EA RID: 26090
	bool IsLock { get; }

	// Token: 0x170007DB RID: 2011
	// (get) Token: 0x060065EB RID: 26091
	bool IsCheck { get; }
}
