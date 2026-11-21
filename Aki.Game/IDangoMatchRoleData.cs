using System;

// Token: 0x02001BE8 RID: 7144
public interface IDangoMatchRoleData
{
	// Token: 0x17001B0A RID: 6922
	// (get) Token: 0x06011C62 RID: 72802
	// (set) Token: 0x06011C63 RID: 72803
	int GroupMatchId { get; set; }

	// Token: 0x17001B0B RID: 6923
	// (get) Token: 0x06011C64 RID: 72804
	// (set) Token: 0x06011C65 RID: 72805
	int DangoId { get; set; }

	// Token: 0x17001B0C RID: 6924
	// (get) Token: 0x06011C66 RID: 72806
	// (set) Token: 0x06011C67 RID: 72807
	bool IsMatchFinished { get; set; }

	// Token: 0x17001B0D RID: 6925
	// (get) Token: 0x06011C68 RID: 72808
	// (set) Token: 0x06011C69 RID: 72809
	bool IsPromote { get; set; }

	// Token: 0x17001B0E RID: 6926
	// (get) Token: 0x06011C6A RID: 72810
	// (set) Token: 0x06011C6B RID: 72811
	bool IsBasicGroupMatch { get; set; }
}
