using System;
using System.Runtime.CompilerServices;

// Token: 0x02001DFF RID: 7679
[NullableContext(2)]
public interface ILevelInfo
{
	// Token: 0x17001CD9 RID: 7385
	// (get) Token: 0x06012F80 RID: 77696
	// (set) Token: 0x06012F81 RID: 77697
	int PreUpgradeLv { get; set; }

	// Token: 0x17001CDA RID: 7386
	// (get) Token: 0x06012F82 RID: 77698
	// (set) Token: 0x06012F83 RID: 77699
	int UpgradeLv { get; set; }

	// Token: 0x17001CDB RID: 7387
	// (get) Token: 0x06012F84 RID: 77700
	// (set) Token: 0x06012F85 RID: 77701
	string FormatStringId { get; set; }

	// Token: 0x17001CDC RID: 7388
	// (get) Token: 0x06012F86 RID: 77702
	// (set) Token: 0x06012F87 RID: 77703
	bool? IsMaxLevel { get; set; }
}
