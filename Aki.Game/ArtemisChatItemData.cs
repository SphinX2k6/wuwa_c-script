using System;
using System.Runtime.CompilerServices;

// Token: 0x020005A7 RID: 1447
[NullableContext(1)]
[Nullable(0)]
public class ArtemisChatItemData : IArtemisChatItemData
{
	// Token: 0x170009B2 RID: 2482
	// (get) Token: 0x060044B8 RID: 17592 RVA: 0x0017A36D File Offset: 0x0017856D
	// (set) Token: 0x060044B9 RID: 17593 RVA: 0x0017A375 File Offset: 0x00178575
	public string Content { get; set; } = "";

	// Token: 0x170009B3 RID: 2483
	// (get) Token: 0x060044BA RID: 17594 RVA: 0x0017A37E File Offset: 0x0017857E
	// (set) Token: 0x060044BB RID: 17595 RVA: 0x0017A386 File Offset: 0x00178586
	public string PicturePath { get; set; } = "";

	// Token: 0x170009B4 RID: 2484
	// (get) Token: 0x060044BC RID: 17596 RVA: 0x0017A38F File Offset: 0x0017858F
	// (set) Token: 0x060044BD RID: 17597 RVA: 0x0017A397 File Offset: 0x00178597
	public bool IsLock { get; set; }

	// Token: 0x170009B5 RID: 2485
	// (get) Token: 0x060044BE RID: 17598 RVA: 0x0017A3A0 File Offset: 0x001785A0
	// (set) Token: 0x060044BF RID: 17599 RVA: 0x0017A3A8 File Offset: 0x001785A8
	public bool IsShowEffect { get; set; }
}
