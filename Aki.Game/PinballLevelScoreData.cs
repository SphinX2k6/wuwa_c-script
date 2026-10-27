using System;

// Token: 0x020013F6 RID: 5110
public class PinballLevelScoreData : IPinballLevelScoreData
{
	// Token: 0x17000C2F RID: 3119
	// (get) Token: 0x0600907D RID: 36989 RVA: 0x001F2AF8 File Offset: 0x001F0CF8
	// (set) Token: 0x0600907E RID: 36990 RVA: 0x001F2B00 File Offset: 0x001F0D00
	public int CurScore { get; set; }

	// Token: 0x17000C30 RID: 3120
	// (get) Token: 0x0600907F RID: 36991 RVA: 0x001F2B09 File Offset: 0x001F0D09
	// (set) Token: 0x06009080 RID: 36992 RVA: 0x001F2B11 File Offset: 0x001F0D11
	public int ConfigScore { get; set; }

	// Token: 0x17000C31 RID: 3121
	// (get) Token: 0x06009081 RID: 36993 RVA: 0x001F2B1A File Offset: 0x001F0D1A
	// (set) Token: 0x06009082 RID: 36994 RVA: 0x001F2B22 File Offset: 0x001F0D22
	public int ConfigDropId { get; set; }
}
