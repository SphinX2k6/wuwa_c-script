using System;
using System.Runtime.CompilerServices;

// Token: 0x02002A86 RID: 10886
[NullableContext(1)]
[Nullable(0)]
public class RawTimeScheduleConfigData
{
	// Token: 0x17002C9E RID: 11422
	// (get) Token: 0x0601B982 RID: 113026 RVA: 0x008802AD File Offset: 0x0087E4AD
	// (set) Token: 0x0601B983 RID: 113027 RVA: 0x008802B5 File Offset: 0x0087E4B5
	public int Id { get; set; }

	// Token: 0x17002C9F RID: 11423
	// (get) Token: 0x0601B984 RID: 113028 RVA: 0x008802BE File Offset: 0x0087E4BE
	// (set) Token: 0x0601B985 RID: 113029 RVA: 0x008802C6 File Offset: 0x0087E4C6
	public string TimeScheduleTag { get; set; } = "";

	// Token: 0x17002CA0 RID: 11424
	// (get) Token: 0x0601B986 RID: 113030 RVA: 0x008802CF File Offset: 0x0087E4CF
	// (set) Token: 0x0601B987 RID: 113031 RVA: 0x008802D7 File Offset: 0x0087E4D7
	public string StartTime { get; set; } = "";

	// Token: 0x17002CA1 RID: 11425
	// (get) Token: 0x0601B988 RID: 113032 RVA: 0x008802E0 File Offset: 0x0087E4E0
	// (set) Token: 0x0601B989 RID: 113033 RVA: 0x008802E8 File Offset: 0x0087E4E8
	public float[] Position { get; set; }

	// Token: 0x17002CA2 RID: 11426
	// (get) Token: 0x0601B98A RID: 113034 RVA: 0x008802F1 File Offset: 0x0087E4F1
	// (set) Token: 0x0601B98B RID: 113035 RVA: 0x008802F9 File Offset: 0x0087E4F9
	public float[] Rotation { get; set; }

	// Token: 0x17002CA3 RID: 11427
	// (get) Token: 0x0601B98C RID: 113036 RVA: 0x00880302 File Offset: 0x0087E502
	// (set) Token: 0x0601B98D RID: 113037 RVA: 0x0088030A File Offset: 0x0087E50A
	public int BehaviorTree { get; set; }

	// Token: 0x17002CA4 RID: 11428
	// (get) Token: 0x0601B98E RID: 113038 RVA: 0x00880313 File Offset: 0x0087E513
	// (set) Token: 0x0601B98F RID: 113039 RVA: 0x0088031B File Offset: 0x0087E51B
	public string SplineEntityUid { get; set; } = "";

	// Token: 0x17002CA5 RID: 11429
	// (get) Token: 0x0601B990 RID: 113040 RVA: 0x00880324 File Offset: 0x0087E524
	// (set) Token: 0x0601B991 RID: 113041 RVA: 0x0088032C File Offset: 0x0087E52C
	public string CommonBtOverride { get; set; } = "";
}
