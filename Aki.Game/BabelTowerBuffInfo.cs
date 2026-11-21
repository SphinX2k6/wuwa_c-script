using System;

// Token: 0x020005E3 RID: 1507
public class BabelTowerBuffInfo : IBabelTowerBuffInfo
{
	// Token: 0x170009EB RID: 2539
	// (get) Token: 0x060046FF RID: 18175 RVA: 0x001844F4 File Offset: 0x001826F4
	// (set) Token: 0x06004700 RID: 18176 RVA: 0x001844FC File Offset: 0x001826FC
	public int Id { get; set; }

	// Token: 0x170009EC RID: 2540
	// (get) Token: 0x06004701 RID: 18177 RVA: 0x00184505 File Offset: 0x00182705
	// (set) Token: 0x06004702 RID: 18178 RVA: 0x0018450D File Offset: 0x0018270D
	public EBabelTowerBuffState State { get; set; }

	// Token: 0x170009ED RID: 2541
	// (get) Token: 0x06004703 RID: 18179 RVA: 0x00184516 File Offset: 0x00182716
	// (set) Token: 0x06004704 RID: 18180 RVA: 0x0018451E File Offset: 0x0018271E
	public int? LevelId { get; set; }

	// Token: 0x170009EE RID: 2542
	// (get) Token: 0x06004705 RID: 18181 RVA: 0x00184527 File Offset: 0x00182727
	// (set) Token: 0x06004706 RID: 18182 RVA: 0x0018452F File Offset: 0x0018272F
	public bool IsRecommend { get; set; }
}
