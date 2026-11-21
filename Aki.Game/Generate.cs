using System;

// Token: 0x0200034C RID: 844
public class Generate : IGenerate
{
	// Token: 0x170006DB RID: 1755
	// (get) Token: 0x06002F35 RID: 12085 RVA: 0x0011347B File Offset: 0x0011167B
	// (set) Token: 0x06002F36 RID: 12086 RVA: 0x00113483 File Offset: 0x00111683
	public int BornTrack { get; set; }

	// Token: 0x170006DC RID: 1756
	// (get) Token: 0x06002F37 RID: 12087 RVA: 0x0011348C File Offset: 0x0011168C
	// (set) Token: 0x06002F38 RID: 12088 RVA: 0x00113494 File Offset: 0x00111694
	public float BornDistance { get; set; }

	// Token: 0x170006DD RID: 1757
	// (get) Token: 0x06002F39 RID: 12089 RVA: 0x0011349D File Offset: 0x0011169D
	// (set) Token: 0x06002F3A RID: 12090 RVA: 0x001134A5 File Offset: 0x001116A5
	public EGenerateType GenerateType { get; set; }

	// Token: 0x170006DE RID: 1758
	// (get) Token: 0x06002F3B RID: 12091 RVA: 0x001134AE File Offset: 0x001116AE
	// (set) Token: 0x06002F3C RID: 12092 RVA: 0x001134B6 File Offset: 0x001116B6
	public int RefreshId { get; set; }

	// Token: 0x170006DF RID: 1759
	// (get) Token: 0x06002F3D RID: 12093 RVA: 0x001134BF File Offset: 0x001116BF
	// (set) Token: 0x06002F3E RID: 12094 RVA: 0x001134C7 File Offset: 0x001116C7
	public int BuffGateBornGroup { get; set; }
}
