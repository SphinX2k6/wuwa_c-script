using System;

// Token: 0x02002E6A RID: 11882
public interface IExtraDamageResult
{
	// Token: 0x170022CD RID: 8909
	// (get) Token: 0x06019637 RID: 103991
	// (set) Token: 0x06019638 RID: 103992
	float HardnessResult { get; set; }

	// Token: 0x170022CE RID: 8910
	// (get) Token: 0x06019639 RID: 103993
	// (set) Token: 0x0601963A RID: 103994
	float RageResult { get; set; }

	// Token: 0x170022CF RID: 8911
	// (get) Token: 0x0601963B RID: 103995
	// (set) Token: 0x0601963C RID: 103996
	bool HitWeakness { get; set; }

	// Token: 0x170022D0 RID: 8912
	// (get) Token: 0x0601963D RID: 103997
	// (set) Token: 0x0601963E RID: 103998
	bool PartDestroyed { get; set; }

	// Token: 0x170022D1 RID: 8913
	// (get) Token: 0x0601963F RID: 103999
	// (set) Token: 0x06019640 RID: 104000
	float EnergyResult { get; set; }

	// Token: 0x170022D2 RID: 8914
	// (get) Token: 0x06019641 RID: 104001
	// (set) Token: 0x06019642 RID: 104002
	long CounterSkillId { get; set; }
}
