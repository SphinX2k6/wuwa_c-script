using System;

// Token: 0x0200034B RID: 843
public interface IGenerate
{
	// Token: 0x170006D6 RID: 1750
	// (get) Token: 0x06002F2B RID: 12075
	// (set) Token: 0x06002F2C RID: 12076
	int BornTrack { get; set; }

	// Token: 0x170006D7 RID: 1751
	// (get) Token: 0x06002F2D RID: 12077
	// (set) Token: 0x06002F2E RID: 12078
	float BornDistance { get; set; }

	// Token: 0x170006D8 RID: 1752
	// (get) Token: 0x06002F2F RID: 12079
	// (set) Token: 0x06002F30 RID: 12080
	EGenerateType GenerateType { get; set; }

	// Token: 0x170006D9 RID: 1753
	// (get) Token: 0x06002F31 RID: 12081
	// (set) Token: 0x06002F32 RID: 12082
	int RefreshId { get; set; }

	// Token: 0x170006DA RID: 1754
	// (get) Token: 0x06002F33 RID: 12083
	// (set) Token: 0x06002F34 RID: 12084
	int BuffGateBornGroup { get; set; }
}
