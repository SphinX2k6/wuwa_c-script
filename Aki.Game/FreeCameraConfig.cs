using System;
using UnrealEngine;

// Token: 0x0200107C RID: 4220
internal class FreeCameraConfig : IFreeCameraConfig
{
	// Token: 0x170008D2 RID: 2258
	// (get) Token: 0x06006D02 RID: 27906 RVA: 0x00161305 File Offset: 0x0015F505
	// (set) Token: 0x06006D03 RID: 27907 RVA: 0x0016130D File Offset: 0x0015F50D
	public FVectorDouble Pos { get; set; }

	// Token: 0x170008D3 RID: 2259
	// (get) Token: 0x06006D04 RID: 27908 RVA: 0x00161316 File Offset: 0x0015F516
	// (set) Token: 0x06006D05 RID: 27909 RVA: 0x0016131E File Offset: 0x0015F51E
	public FRotator Rot { get; set; }

	// Token: 0x170008D4 RID: 2260
	// (get) Token: 0x06006D06 RID: 27910 RVA: 0x00161327 File Offset: 0x0015F527
	// (set) Token: 0x06006D07 RID: 27911 RVA: 0x0016132F File Offset: 0x0015F52F
	public float Fov { get; set; }

	// Token: 0x170008D5 RID: 2261
	// (get) Token: 0x06006D08 RID: 27912 RVA: 0x00161338 File Offset: 0x0015F538
	// (set) Token: 0x06006D09 RID: 27913 RVA: 0x00161340 File Offset: 0x0015F540
	public float Radius { get; set; }

	// Token: 0x170008D6 RID: 2262
	// (get) Token: 0x06006D0A RID: 27914 RVA: 0x00161349 File Offset: 0x0015F549
	// (set) Token: 0x06006D0B RID: 27915 RVA: 0x00161351 File Offset: 0x0015F551
	public float Interval { get; set; }

	// Token: 0x170008D7 RID: 2263
	// (get) Token: 0x06006D0C RID: 27916 RVA: 0x0016135A File Offset: 0x0015F55A
	// (set) Token: 0x06006D0D RID: 27917 RVA: 0x00161362 File Offset: 0x0015F562
	public float InterpDuration { get; set; }
}
