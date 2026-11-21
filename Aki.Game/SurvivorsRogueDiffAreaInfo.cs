using System;

// Token: 0x020020C3 RID: 8387
public class SurvivorsRogueDiffAreaInfo : IDiffAreaInfo
{
	// Token: 0x17001F01 RID: 7937
	// (get) Token: 0x060149D5 RID: 84437 RVA: 0x00601AB4 File Offset: 0x005FFCB4
	// (set) Token: 0x060149D6 RID: 84438 RVA: 0x00601ABC File Offset: 0x005FFCBC
	public ESurvivorsLevelDiff Diff { get; set; }

	// Token: 0x17001F02 RID: 7938
	// (get) Token: 0x060149D7 RID: 84439 RVA: 0x00601AC5 File Offset: 0x005FFCC5
	// (set) Token: 0x060149D8 RID: 84440 RVA: 0x00601ACD File Offset: 0x005FFCCD
	public int LowerBoundLevelId { get; set; }

	// Token: 0x17001F03 RID: 7939
	// (get) Token: 0x060149D9 RID: 84441 RVA: 0x00601AD6 File Offset: 0x005FFCD6
	// (set) Token: 0x060149DA RID: 84442 RVA: 0x00601ADE File Offset: 0x005FFCDE
	public float LowerBoundPosY { get; set; }
}
