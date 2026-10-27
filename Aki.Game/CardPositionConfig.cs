using System;

// Token: 0x02001054 RID: 4180
public class CardPositionConfig : ICardPositionConfig
{
	// Token: 0x170008A0 RID: 2208
	// (get) Token: 0x06006B16 RID: 27414 RVA: 0x00158F47 File Offset: 0x00157147
	// (set) Token: 0x06006B17 RID: 27415 RVA: 0x00158F4F File Offset: 0x0015714F
	public float PositionRate { get; set; }

	// Token: 0x170008A1 RID: 2209
	// (get) Token: 0x06006B18 RID: 27416 RVA: 0x00158F58 File Offset: 0x00157158
	// (set) Token: 0x06006B19 RID: 27417 RVA: 0x00158F60 File Offset: 0x00157160
	public float Spacing { get; set; }

	// Token: 0x170008A2 RID: 2210
	// (get) Token: 0x06006B1A RID: 27418 RVA: 0x00158F69 File Offset: 0x00157169
	// (set) Token: 0x06006B1B RID: 27419 RVA: 0x00158F71 File Offset: 0x00157171
	public float? UpOffset { get; set; }

	// Token: 0x170008A3 RID: 2211
	// (get) Token: 0x06006B1C RID: 27420 RVA: 0x00158F7A File Offset: 0x0015717A
	// (set) Token: 0x06006B1D RID: 27421 RVA: 0x00158F82 File Offset: 0x00157182
	public float? Size { get; set; }

	// Token: 0x170008A4 RID: 2212
	// (get) Token: 0x06006B1E RID: 27422 RVA: 0x00158F8B File Offset: 0x0015718B
	// (set) Token: 0x06006B1F RID: 27423 RVA: 0x00158F93 File Offset: 0x00157193
	public float? Alpha { get; set; }
}
