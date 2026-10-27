using System;

// Token: 0x02001CFD RID: 7421
public interface IPinballBattleLevelStartTipsParam : IPinballBattleTipsBaseParam
{
	// Token: 0x1700120C RID: 4620
	// (get) Token: 0x0600E0A8 RID: 57512
	int CurWave { get; }

	// Token: 0x1700120D RID: 4621
	// (get) Token: 0x0600E0A9 RID: 57513
	int MaxWave { get; }
}
