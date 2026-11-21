using System;

// Token: 0x02000508 RID: 1288
public class CardPositionConfig : ICardPositionConfig
{
	// Token: 0x170008C0 RID: 2240
	// (get) Token: 0x06003EAB RID: 16043 RVA: 0x0016186F File Offset: 0x0015FA6F
	// (set) Token: 0x06003EAC RID: 16044 RVA: 0x00161877 File Offset: 0x0015FA77
	public float PositionRate { get; set; }

	// Token: 0x170008C1 RID: 2241
	// (get) Token: 0x06003EAD RID: 16045 RVA: 0x00161880 File Offset: 0x0015FA80
	// (set) Token: 0x06003EAE RID: 16046 RVA: 0x00161888 File Offset: 0x0015FA88
	public float Spacing { get; set; }

	// Token: 0x170008C2 RID: 2242
	// (get) Token: 0x06003EAF RID: 16047 RVA: 0x00161891 File Offset: 0x0015FA91
	// (set) Token: 0x06003EB0 RID: 16048 RVA: 0x00161899 File Offset: 0x0015FA99
	public float? UpOffset { get; set; }

	// Token: 0x170008C3 RID: 2243
	// (get) Token: 0x06003EB1 RID: 16049 RVA: 0x001618A2 File Offset: 0x0015FAA2
	// (set) Token: 0x06003EB2 RID: 16050 RVA: 0x001618AA File Offset: 0x0015FAAA
	public float? Size { get; set; }

	// Token: 0x170008C4 RID: 2244
	// (get) Token: 0x06003EB3 RID: 16051 RVA: 0x001618B3 File Offset: 0x0015FAB3
	// (set) Token: 0x06003EB4 RID: 16052 RVA: 0x001618BB File Offset: 0x0015FABB
	public float? Alpha { get; set; }
}
