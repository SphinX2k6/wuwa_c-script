using System;

// Token: 0x02001990 RID: 6544
public interface IMainPhantomFilterChangedInfo
{
	// Token: 0x170018D7 RID: 6359
	// (get) Token: 0x0601021C RID: 66076
	// (set) Token: 0x0601021D RID: 66077
	int MonsterId { get; set; }

	// Token: 0x170018D8 RID: 6360
	// (get) Token: 0x0601021E RID: 66078
	// (set) Token: 0x0601021F RID: 66079
	int FetterGroupId { get; set; }

	// Token: 0x170018D9 RID: 6361
	// (get) Token: 0x06010220 RID: 66080
	// (set) Token: 0x06010221 RID: 66081
	int Cost { get; set; }

	// Token: 0x170018DA RID: 6362
	// (get) Token: 0x06010222 RID: 66082
	// (set) Token: 0x06010223 RID: 66083
	bool IsDeselect { get; set; }
}
