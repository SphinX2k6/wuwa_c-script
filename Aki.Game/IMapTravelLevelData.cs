using System;

// Token: 0x020012D0 RID: 4816
public interface IMapTravelLevelData
{
	// Token: 0x17000B4D RID: 2893
	// (get) Token: 0x060084BB RID: 33979
	// (set) Token: 0x060084BC RID: 33980
	int Id { get; set; }

	// Token: 0x17000B4E RID: 2894
	// (get) Token: 0x060084BD RID: 33981
	// (set) Token: 0x060084BE RID: 33982
	int Level { get; set; }

	// Token: 0x17000B4F RID: 2895
	// (get) Token: 0x060084BF RID: 33983
	// (set) Token: 0x060084C0 RID: 33984
	int AccumulateExp { get; set; }

	// Token: 0x17000B50 RID: 2896
	// (get) Token: 0x060084C1 RID: 33985
	// (set) Token: 0x060084C2 RID: 33986
	int TargetExp { get; set; }
}
