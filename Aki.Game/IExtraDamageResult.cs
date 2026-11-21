using System;

// Token: 0x020023BC RID: 9148
public interface IExtraDamageResult
{
	// Token: 0x1700234C RID: 9036
	// (get) Token: 0x06016EFE RID: 93950
	// (set) Token: 0x06016EFF RID: 93951
	float HardnessResult { get; set; }

	// Token: 0x1700234D RID: 9037
	// (get) Token: 0x06016F00 RID: 93952
	// (set) Token: 0x06016F01 RID: 93953
	float RageResult { get; set; }

	// Token: 0x1700234E RID: 9038
	// (get) Token: 0x06016F02 RID: 93954
	// (set) Token: 0x06016F03 RID: 93955
	bool HitWeakness { get; set; }

	// Token: 0x1700234F RID: 9039
	// (get) Token: 0x06016F04 RID: 93956
	// (set) Token: 0x06016F05 RID: 93957
	bool PartDestroyed { get; set; }

	// Token: 0x17002350 RID: 9040
	// (get) Token: 0x06016F06 RID: 93958
	// (set) Token: 0x06016F07 RID: 93959
	float EnergyResult { get; set; }

	// Token: 0x17002351 RID: 9041
	// (get) Token: 0x06016F08 RID: 93960
	// (set) Token: 0x06016F09 RID: 93961
	long CounterSkillId { get; set; }
}
