using System;
using System.Runtime.CompilerServices;

// Token: 0x02000D8E RID: 3470
[NullableContext(1)]
public interface ITipsAttributeItemData
{
	// Token: 0x17000F99 RID: 3993
	// (get) Token: 0x06008E68 RID: 36456
	// (set) Token: 0x06008E69 RID: 36457
	int Id { get; set; }

	// Token: 0x17000F9A RID: 3994
	// (get) Token: 0x06008E6A RID: 36458
	// (set) Token: 0x06008E6B RID: 36459
	bool IsMainAttribute { get; set; }

	// Token: 0x17000F9B RID: 3995
	// (get) Token: 0x06008E6C RID: 36460
	// (set) Token: 0x06008E6D RID: 36461
	string Name { get; set; }

	// Token: 0x17000F9C RID: 3996
	// (get) Token: 0x06008E6E RID: 36462
	// (set) Token: 0x06008E6F RID: 36463
	string IconPath { get; set; }

	// Token: 0x17000F9D RID: 3997
	// (get) Token: 0x06008E70 RID: 36464
	// (set) Token: 0x06008E71 RID: 36465
	double Value { get; set; }

	// Token: 0x17000F9E RID: 3998
	// (get) Token: 0x06008E72 RID: 36466
	// (set) Token: 0x06008E73 RID: 36467
	bool IsRatio { get; set; }
}
