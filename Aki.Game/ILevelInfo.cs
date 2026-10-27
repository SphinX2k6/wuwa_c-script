using System;
using System.Runtime.CompilerServices;

// Token: 0x02002884 RID: 10372
[NullableContext(2)]
public interface ILevelInfo
{
	// Token: 0x17001C81 RID: 7297
	// (get) Token: 0x06015582 RID: 87426
	// (set) Token: 0x06015583 RID: 87427
	int PreUpgradeLv { get; set; }

	// Token: 0x17001C82 RID: 7298
	// (get) Token: 0x06015584 RID: 87428
	// (set) Token: 0x06015585 RID: 87429
	int UpgradeLv { get; set; }

	// Token: 0x17001C83 RID: 7299
	// (get) Token: 0x06015586 RID: 87430
	// (set) Token: 0x06015587 RID: 87431
	string FormatStringId { get; set; }

	// Token: 0x17001C84 RID: 7300
	// (get) Token: 0x06015588 RID: 87432
	// (set) Token: 0x06015589 RID: 87433
	bool? IsMaxLevel { get; set; }
}
