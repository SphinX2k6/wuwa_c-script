using System;

// Token: 0x02002B47 RID: 11079
public class SurvivorsRogueDiffAreaInfo : IDiffAreaInfo
{
	// Token: 0x17001EA9 RID: 7849
	// (get) Token: 0x06016FA4 RID: 94116 RVA: 0x005D4F48 File Offset: 0x005D3148
	// (set) Token: 0x06016FA5 RID: 94117 RVA: 0x005D4F50 File Offset: 0x005D3150
	public ESurvivorsLevelDiff Diff { get; set; }

	// Token: 0x17001EAA RID: 7850
	// (get) Token: 0x06016FA6 RID: 94118 RVA: 0x005D4F59 File Offset: 0x005D3159
	// (set) Token: 0x06016FA7 RID: 94119 RVA: 0x005D4F61 File Offset: 0x005D3161
	public int LowerBoundLevelId { get; set; }

	// Token: 0x17001EAB RID: 7851
	// (get) Token: 0x06016FA8 RID: 94120 RVA: 0x005D4F6A File Offset: 0x005D316A
	// (set) Token: 0x06016FA9 RID: 94121 RVA: 0x005D4F72 File Offset: 0x005D3172
	public float LowerBoundPosY { get; set; }
}
