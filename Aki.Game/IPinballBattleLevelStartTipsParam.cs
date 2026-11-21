using System;

// Token: 0x020011BF RID: 4543
public interface IPinballBattleLevelStartTipsParam : IPinballBattleTipsBaseParam
{
	// Token: 0x17001236 RID: 4662
	// (get) Token: 0x0600B4C5 RID: 46277
	int CurWave { get; }

	// Token: 0x17001237 RID: 4663
	// (get) Token: 0x0600B4C6 RID: 46278
	int MaxWave { get; }
}
