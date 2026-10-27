using System;

// Token: 0x02002B46 RID: 11078
internal interface IDiffAreaInfo
{
	// Token: 0x17001EA6 RID: 7846
	// (get) Token: 0x06016F9E RID: 94110
	// (set) Token: 0x06016F9F RID: 94111
	ESurvivorsLevelDiff Diff { get; set; }

	// Token: 0x17001EA7 RID: 7847
	// (get) Token: 0x06016FA0 RID: 94112
	// (set) Token: 0x06016FA1 RID: 94113
	int LowerBoundLevelId { get; set; }

	// Token: 0x17001EA8 RID: 7848
	// (get) Token: 0x06016FA2 RID: 94114
	// (set) Token: 0x06016FA3 RID: 94115
	float LowerBoundPosY { get; set; }
}
