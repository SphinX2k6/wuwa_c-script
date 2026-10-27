using System;

// Token: 0x020034FB RID: 13563
public enum ELoadingPhase
{
	// Token: 0x0400E95A RID: 59738
	None,
	// Token: 0x0400E95B RID: 59739
	Finished,
	// Token: 0x0400E95C RID: 59740
	Start,
	// Token: 0x0400E95D RID: 59741
	OpenLoadingStart,
	// Token: 0x0400E95E RID: 59742
	OpenLoadingEnd,
	// Token: 0x0400E95F RID: 59743
	OpenLevelStart,
	// Token: 0x0400E960 RID: 59744
	OpenLevelEnd,
	// Token: 0x0400E961 RID: 59745
	PreloadStart,
	// Token: 0x0400E962 RID: 59746
	PreloadEnd,
	// Token: 0x0400E963 RID: 59747
	SetDataLayerAndLoadSubLevelStart,
	// Token: 0x0400E964 RID: 59748
	SetDataLayerAndLoadSubLevelEnd,
	// Token: 0x0400E965 RID: 59749
	CheckVoxelStreamingStart,
	// Token: 0x0400E966 RID: 59750
	CheckVoxelStreamingEnd,
	// Token: 0x0400E967 RID: 59751
	CheckStreamingStart,
	// Token: 0x0400E968 RID: 59752
	CheckStreamingEnd,
	// Token: 0x0400E969 RID: 59753
	CreateEntityStart,
	// Token: 0x0400E96A RID: 59754
	CreateEntityEnd,
	// Token: 0x0400E96B RID: 59755
	WorldDoneStart,
	// Token: 0x0400E96C RID: 59756
	WorldDoneEnd,
	// Token: 0x0400E96D RID: 59757
	CloseLoadingStart,
	// Token: 0x0400E96E RID: 59758
	CloseLoadingEnd
}
