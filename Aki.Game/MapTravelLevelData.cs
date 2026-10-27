using System;

// Token: 0x020012D1 RID: 4817
public class MapTravelLevelData : IMapTravelLevelData
{
	// Token: 0x17000B51 RID: 2897
	// (get) Token: 0x060084C3 RID: 33987 RVA: 0x001C4667 File Offset: 0x001C2867
	// (set) Token: 0x060084C4 RID: 33988 RVA: 0x001C466F File Offset: 0x001C286F
	public int Id { get; set; }

	// Token: 0x17000B52 RID: 2898
	// (get) Token: 0x060084C5 RID: 33989 RVA: 0x001C4678 File Offset: 0x001C2878
	// (set) Token: 0x060084C6 RID: 33990 RVA: 0x001C4680 File Offset: 0x001C2880
	public int Level { get; set; }

	// Token: 0x17000B53 RID: 2899
	// (get) Token: 0x060084C7 RID: 33991 RVA: 0x001C4689 File Offset: 0x001C2889
	// (set) Token: 0x060084C8 RID: 33992 RVA: 0x001C4691 File Offset: 0x001C2891
	public int AccumulateExp { get; set; }

	// Token: 0x17000B54 RID: 2900
	// (get) Token: 0x060084C9 RID: 33993 RVA: 0x001C469A File Offset: 0x001C289A
	// (set) Token: 0x060084CA RID: 33994 RVA: 0x001C46A2 File Offset: 0x001C28A2
	public int TargetExp { get; set; }
}
