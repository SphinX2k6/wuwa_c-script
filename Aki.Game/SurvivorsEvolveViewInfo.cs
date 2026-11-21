using System;
using System.Runtime.CompilerServices;

// Token: 0x0200205D RID: 8285
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsEvolveViewInfo : ISurvivorsEvolveViewInfo
{
	// Token: 0x17001EC1 RID: 7873
	// (get) Token: 0x060147B0 RID: 83888 RVA: 0x005F909C File Offset: 0x005F729C
	// (set) Token: 0x060147B1 RID: 83889 RVA: 0x005F90A4 File Offset: 0x005F72A4
	public ESurvivorsRogueItemType SourceType { get; set; }

	// Token: 0x17001EC2 RID: 7874
	// (get) Token: 0x060147B2 RID: 83890 RVA: 0x005F90AD File Offset: 0x005F72AD
	// (set) Token: 0x060147B3 RID: 83891 RVA: 0x005F90B5 File Offset: 0x005F72B5
	public int SourceId { get; set; }

	// Token: 0x17001EC3 RID: 7875
	// (get) Token: 0x060147B4 RID: 83892 RVA: 0x005F90BE File Offset: 0x005F72BE
	// (set) Token: 0x060147B5 RID: 83893 RVA: 0x005F90C6 File Offset: 0x005F72C6
	public string TitleId { get; set; } = "";

	// Token: 0x17001EC4 RID: 7876
	// (get) Token: 0x060147B6 RID: 83894 RVA: 0x005F90CF File Offset: 0x005F72CF
	// (set) Token: 0x060147B7 RID: 83895 RVA: 0x005F90D7 File Offset: 0x005F72D7
	public int EvolveId { get; set; }

	// Token: 0x17001EC5 RID: 7877
	// (get) Token: 0x060147B8 RID: 83896 RVA: 0x005F90E0 File Offset: 0x005F72E0
	// (set) Token: 0x060147B9 RID: 83897 RVA: 0x005F90E8 File Offset: 0x005F72E8
	public ESurvivorsRogueItemType? BondType { get; set; }

	// Token: 0x17001EC6 RID: 7878
	// (get) Token: 0x060147BA RID: 83898 RVA: 0x005F90F1 File Offset: 0x005F72F1
	// (set) Token: 0x060147BB RID: 83899 RVA: 0x005F90F9 File Offset: 0x005F72F9
	public int? BondId { get; set; }

	// Token: 0x17001EC7 RID: 7879
	// (get) Token: 0x060147BC RID: 83900 RVA: 0x005F9102 File Offset: 0x005F7302
	// (set) Token: 0x060147BD RID: 83901 RVA: 0x005F910A File Offset: 0x005F730A
	public bool? PlayTween { get; set; }

	// Token: 0x17001EC8 RID: 7880
	// (get) Token: 0x060147BE RID: 83902 RVA: 0x005F9113 File Offset: 0x005F7313
	// (set) Token: 0x060147BF RID: 83903 RVA: 0x005F911B File Offset: 0x005F731B
	[Nullable(2)]
	public int[] WeaponEvolveIds { [NullableContext(2)] get; [NullableContext(2)] set; }
}
