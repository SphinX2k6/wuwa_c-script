using System;
using System.Runtime.CompilerServices;

// Token: 0x02001AA1 RID: 6817
[NullableContext(2)]
public interface IPlayPointInfo
{
	// Token: 0x17001084 RID: 4228
	// (get) Token: 0x0600C9D4 RID: 51668
	// (set) Token: 0x0600C9D5 RID: 51669
	int PlayId { get; set; }

	// Token: 0x17001085 RID: 4229
	// (get) Token: 0x0600C9D6 RID: 51670
	// (set) Token: 0x0600C9D7 RID: 51671
	int EntityId { get; set; }

	// Token: 0x17001086 RID: 4230
	// (get) Token: 0x0600C9D8 RID: 51672
	// (set) Token: 0x0600C9D9 RID: 51673
	EPlayPointState PlayState { get; set; }

	// Token: 0x17001087 RID: 4231
	// (get) Token: 0x0600C9DA RID: 51674
	// (set) Token: 0x0600C9DB RID: 51675
	bool? IsClear { get; set; }

	// Token: 0x17001088 RID: 4232
	// (get) Token: 0x0600C9DC RID: 51676
	// (set) Token: 0x0600C9DD RID: 51677
	string ClearInfo { get; set; }

	// Token: 0x17001089 RID: 4233
	// (get) Token: 0x0600C9DE RID: 51678
	// (set) Token: 0x0600C9DF RID: 51679
	bool? LevelPlayMarkUnlock { get; set; }

	// Token: 0x1700108A RID: 4234
	// (get) Token: 0x0600C9E0 RID: 51680
	// (set) Token: 0x0600C9E1 RID: 51681
	bool IsUnlock { get; set; }
}
