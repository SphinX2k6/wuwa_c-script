using System;
using System.Runtime.CompilerServices;

// Token: 0x02003511 RID: 13585
[NullableContext(1)]
[Nullable(0)]
public class RawTimeScheduleConfigData
{
	// Token: 0x17002905 RID: 10501
	// (get) Token: 0x0601DC68 RID: 121960 RVA: 0x00857CE1 File Offset: 0x00855EE1
	// (set) Token: 0x0601DC69 RID: 121961 RVA: 0x00857CE9 File Offset: 0x00855EE9
	public int Id { get; set; }

	// Token: 0x17002906 RID: 10502
	// (get) Token: 0x0601DC6A RID: 121962 RVA: 0x00857CF2 File Offset: 0x00855EF2
	// (set) Token: 0x0601DC6B RID: 121963 RVA: 0x00857CFA File Offset: 0x00855EFA
	public string TimeScheduleTag { get; set; } = "";

	// Token: 0x17002907 RID: 10503
	// (get) Token: 0x0601DC6C RID: 121964 RVA: 0x00857D03 File Offset: 0x00855F03
	// (set) Token: 0x0601DC6D RID: 121965 RVA: 0x00857D0B File Offset: 0x00855F0B
	public string StartTime { get; set; } = "";

	// Token: 0x17002908 RID: 10504
	// (get) Token: 0x0601DC6E RID: 121966 RVA: 0x00857D14 File Offset: 0x00855F14
	// (set) Token: 0x0601DC6F RID: 121967 RVA: 0x00857D1C File Offset: 0x00855F1C
	public float[] Position { get; set; }

	// Token: 0x17002909 RID: 10505
	// (get) Token: 0x0601DC70 RID: 121968 RVA: 0x00857D25 File Offset: 0x00855F25
	// (set) Token: 0x0601DC71 RID: 121969 RVA: 0x00857D2D File Offset: 0x00855F2D
	public float[] Rotation { get; set; }

	// Token: 0x1700290A RID: 10506
	// (get) Token: 0x0601DC72 RID: 121970 RVA: 0x00857D36 File Offset: 0x00855F36
	// (set) Token: 0x0601DC73 RID: 121971 RVA: 0x00857D3E File Offset: 0x00855F3E
	public int BehaviorTree { get; set; }

	// Token: 0x1700290B RID: 10507
	// (get) Token: 0x0601DC74 RID: 121972 RVA: 0x00857D47 File Offset: 0x00855F47
	// (set) Token: 0x0601DC75 RID: 121973 RVA: 0x00857D4F File Offset: 0x00855F4F
	public string SplineEntityUid { get; set; } = "";

	// Token: 0x1700290C RID: 10508
	// (get) Token: 0x0601DC76 RID: 121974 RVA: 0x00857D58 File Offset: 0x00855F58
	// (set) Token: 0x0601DC77 RID: 121975 RVA: 0x00857D60 File Offset: 0x00855F60
	public string CommonBtOverride { get; set; } = "";
}
