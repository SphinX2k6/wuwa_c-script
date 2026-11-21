using System;

// Token: 0x02002A70 RID: 10864
public enum ELoadingPhase
{
	// Token: 0x0400EE15 RID: 60949
	None,
	// Token: 0x0400EE16 RID: 60950
	Finished,
	// Token: 0x0400EE17 RID: 60951
	Start,
	// Token: 0x0400EE18 RID: 60952
	OpenLoadingStart,
	// Token: 0x0400EE19 RID: 60953
	OpenLoadingEnd,
	// Token: 0x0400EE1A RID: 60954
	OpenLevelStart,
	// Token: 0x0400EE1B RID: 60955
	OpenLevelEnd,
	// Token: 0x0400EE1C RID: 60956
	PreloadStart,
	// Token: 0x0400EE1D RID: 60957
	PreloadEnd,
	// Token: 0x0400EE1E RID: 60958
	SetDataLayerAndLoadSubLevelStart,
	// Token: 0x0400EE1F RID: 60959
	SetDataLayerAndLoadSubLevelEnd,
	// Token: 0x0400EE20 RID: 60960
	CheckVoxelStreamingStart,
	// Token: 0x0400EE21 RID: 60961
	CheckVoxelStreamingEnd,
	// Token: 0x0400EE22 RID: 60962
	CheckStreamingStart,
	// Token: 0x0400EE23 RID: 60963
	CheckStreamingEnd,
	// Token: 0x0400EE24 RID: 60964
	CreateEntityStart,
	// Token: 0x0400EE25 RID: 60965
	CreateEntityEnd,
	// Token: 0x0400EE26 RID: 60966
	WorldDoneStart,
	// Token: 0x0400EE27 RID: 60967
	WorldDoneEnd,
	// Token: 0x0400EE28 RID: 60968
	CloseLoadingStart,
	// Token: 0x0400EE29 RID: 60969
	CloseLoadingEnd
}
