using System;

// Token: 0x02001053 RID: 4179
public interface ICardPositionConfig
{
	// Token: 0x1700089B RID: 2203
	// (get) Token: 0x06006B0C RID: 27404
	// (set) Token: 0x06006B0D RID: 27405
	float PositionRate { get; set; }

	// Token: 0x1700089C RID: 2204
	// (get) Token: 0x06006B0E RID: 27406
	// (set) Token: 0x06006B0F RID: 27407
	float Spacing { get; set; }

	// Token: 0x1700089D RID: 2205
	// (get) Token: 0x06006B10 RID: 27408
	// (set) Token: 0x06006B11 RID: 27409
	float? UpOffset { get; set; }

	// Token: 0x1700089E RID: 2206
	// (get) Token: 0x06006B12 RID: 27410
	// (set) Token: 0x06006B13 RID: 27411
	float? Size { get; set; }

	// Token: 0x1700089F RID: 2207
	// (get) Token: 0x06006B14 RID: 27412
	// (set) Token: 0x06006B15 RID: 27413
	float? Alpha { get; set; }
}
