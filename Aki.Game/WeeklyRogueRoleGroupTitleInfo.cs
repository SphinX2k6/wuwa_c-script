using System;
using System.Runtime.CompilerServices;

// Token: 0x02002D62 RID: 11618
[NullableContext(1)]
[Nullable(0)]
public class WeeklyRogueRoleGroupTitleInfo : IWeeklyRogueRoleGroupTitleInfo
{
	// Token: 0x170020F2 RID: 8434
	// (get) Token: 0x060186E0 RID: 100064 RVA: 0x006387F3 File Offset: 0x006369F3
	// (set) Token: 0x060186E1 RID: 100065 RVA: 0x006387FB File Offset: 0x006369FB
	public string TitleId { get; set; }

	// Token: 0x170020F3 RID: 8435
	// (get) Token: 0x060186E2 RID: 100066 RVA: 0x00638804 File Offset: 0x00636A04
	// (set) Token: 0x060186E3 RID: 100067 RVA: 0x0063880C File Offset: 0x00636A0C
	public bool IsUp { get; set; }

	// Token: 0x170020F4 RID: 8436
	// (get) Token: 0x060186E4 RID: 100068 RVA: 0x00638815 File Offset: 0x00636A15
	// (set) Token: 0x060186E5 RID: 100069 RVA: 0x0063881D File Offset: 0x00636A1D
	public int? ScoreRate { get; set; }

	// Token: 0x170020F5 RID: 8437
	// (get) Token: 0x060186E6 RID: 100070 RVA: 0x00638826 File Offset: 0x00636A26
	// (set) Token: 0x060186E7 RID: 100071 RVA: 0x0063882E File Offset: 0x00636A2E
	public bool IsEmpty { get; set; }
}
