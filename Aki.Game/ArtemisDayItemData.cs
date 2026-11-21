using System;

// Token: 0x020005A3 RID: 1443
public class ArtemisDayItemData : IArtemisDayItemData
{
	// Token: 0x170009AC RID: 2476
	// (get) Token: 0x06004497 RID: 17559 RVA: 0x00179CC1 File Offset: 0x00177EC1
	// (set) Token: 0x06004498 RID: 17560 RVA: 0x00179CC9 File Offset: 0x00177EC9
	public int Index { get; set; }

	// Token: 0x170009AD RID: 2477
	// (get) Token: 0x06004499 RID: 17561 RVA: 0x00179CD2 File Offset: 0x00177ED2
	// (set) Token: 0x0600449A RID: 17562 RVA: 0x00179CDA File Offset: 0x00177EDA
	public EArtemisState? State { get; set; }
}
