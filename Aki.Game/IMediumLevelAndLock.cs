using System;

// Token: 0x0200191C RID: 6428
public interface IMediumLevelAndLock
{
	// Token: 0x17000FB2 RID: 4018
	// (get) Token: 0x0600BC43 RID: 48195
	// (set) Token: 0x0600BC44 RID: 48196
	int? Level { get; set; }

	// Token: 0x17000FB3 RID: 4019
	// (get) Token: 0x0600BC45 RID: 48197
	// (set) Token: 0x0600BC46 RID: 48198
	bool? IsLevelInfinite { get; set; }

	// Token: 0x17000FB4 RID: 4020
	// (get) Token: 0x0600BC47 RID: 48199
	// (set) Token: 0x0600BC48 RID: 48200
	bool? IsLockVisible { get; set; }

	// Token: 0x17000FB5 RID: 4021
	// (get) Token: 0x0600BC49 RID: 48201
	// (set) Token: 0x0600BC4A RID: 48202
	bool? IsLevelUseChangeColor { get; set; }

	// Token: 0x17000FB6 RID: 4022
	// (get) Token: 0x0600BC4B RID: 48203
	// (set) Token: 0x0600BC4C RID: 48204
	bool? IsUseVision { get; set; }

	// Token: 0x17000FB7 RID: 4023
	// (get) Token: 0x0600BC4D RID: 48205
	// (set) Token: 0x0600BC4E RID: 48206
	bool? IsDeprecate { get; set; }
}
