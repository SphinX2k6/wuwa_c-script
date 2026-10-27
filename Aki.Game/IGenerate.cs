using System;

// Token: 0x02000E96 RID: 3734
public interface IGenerate
{
	// Token: 0x170006B2 RID: 1714
	// (get) Token: 0x06005B94 RID: 23444
	// (set) Token: 0x06005B95 RID: 23445
	int BornTrack { get; set; }

	// Token: 0x170006B3 RID: 1715
	// (get) Token: 0x06005B96 RID: 23446
	// (set) Token: 0x06005B97 RID: 23447
	float BornDistance { get; set; }

	// Token: 0x170006B4 RID: 1716
	// (get) Token: 0x06005B98 RID: 23448
	// (set) Token: 0x06005B99 RID: 23449
	EGenerateType GenerateType { get; set; }

	// Token: 0x170006B5 RID: 1717
	// (get) Token: 0x06005B9A RID: 23450
	// (set) Token: 0x06005B9B RID: 23451
	int RefreshId { get; set; }

	// Token: 0x170006B6 RID: 1718
	// (get) Token: 0x06005B9C RID: 23452
	// (set) Token: 0x06005B9D RID: 23453
	int BuffGateBornGroup { get; set; }
}
