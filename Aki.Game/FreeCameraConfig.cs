using System;
using UnrealEngine;

// Token: 0x02000530 RID: 1328
internal class FreeCameraConfig : IFreeCameraConfig
{
	// Token: 0x170008F2 RID: 2290
	// (get) Token: 0x06004097 RID: 16535 RVA: 0x00169C39 File Offset: 0x00167E39
	// (set) Token: 0x06004098 RID: 16536 RVA: 0x00169C41 File Offset: 0x00167E41
	public FVectorDouble Pos { get; set; }

	// Token: 0x170008F3 RID: 2291
	// (get) Token: 0x06004099 RID: 16537 RVA: 0x00169C4A File Offset: 0x00167E4A
	// (set) Token: 0x0600409A RID: 16538 RVA: 0x00169C52 File Offset: 0x00167E52
	public FRotator Rot { get; set; }

	// Token: 0x170008F4 RID: 2292
	// (get) Token: 0x0600409B RID: 16539 RVA: 0x00169C5B File Offset: 0x00167E5B
	// (set) Token: 0x0600409C RID: 16540 RVA: 0x00169C63 File Offset: 0x00167E63
	public float Fov { get; set; }

	// Token: 0x170008F5 RID: 2293
	// (get) Token: 0x0600409D RID: 16541 RVA: 0x00169C6C File Offset: 0x00167E6C
	// (set) Token: 0x0600409E RID: 16542 RVA: 0x00169C74 File Offset: 0x00167E74
	public float Radius { get; set; }

	// Token: 0x170008F6 RID: 2294
	// (get) Token: 0x0600409F RID: 16543 RVA: 0x00169C7D File Offset: 0x00167E7D
	// (set) Token: 0x060040A0 RID: 16544 RVA: 0x00169C85 File Offset: 0x00167E85
	public float Interval { get; set; }

	// Token: 0x170008F7 RID: 2295
	// (get) Token: 0x060040A1 RID: 16545 RVA: 0x00169C8E File Offset: 0x00167E8E
	// (set) Token: 0x060040A2 RID: 16546 RVA: 0x00169C96 File Offset: 0x00167E96
	public float InterpDuration { get; set; }
}
