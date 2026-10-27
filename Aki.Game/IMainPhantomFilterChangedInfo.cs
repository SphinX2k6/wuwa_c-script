using System;

// Token: 0x020024A9 RID: 9385
public interface IMainPhantomFilterChangedInfo
{
	// Token: 0x1700189D RID: 6301
	// (get) Token: 0x06012D5B RID: 77147
	// (set) Token: 0x06012D5C RID: 77148
	int MonsterId { get; set; }

	// Token: 0x1700189E RID: 6302
	// (get) Token: 0x06012D5D RID: 77149
	// (set) Token: 0x06012D5E RID: 77150
	int FetterGroupId { get; set; }

	// Token: 0x1700189F RID: 6303
	// (get) Token: 0x06012D5F RID: 77151
	// (set) Token: 0x06012D60 RID: 77152
	int Cost { get; set; }

	// Token: 0x170018A0 RID: 6304
	// (get) Token: 0x06012D61 RID: 77153
	// (set) Token: 0x06012D62 RID: 77154
	bool IsDeselect { get; set; }
}
