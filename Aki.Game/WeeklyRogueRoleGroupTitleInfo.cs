using System;
using System.Runtime.CompilerServices;

// Token: 0x020022BC RID: 8892
[NullableContext(1)]
[Nullable(0)]
public class WeeklyRogueRoleGroupTitleInfo : IWeeklyRogueRoleGroupTitleInfo
{
	// Token: 0x1700214D RID: 8525
	// (get) Token: 0x06015F82 RID: 89986 RVA: 0x0065E803 File Offset: 0x0065CA03
	// (set) Token: 0x06015F83 RID: 89987 RVA: 0x0065E80B File Offset: 0x0065CA0B
	public string TitleId { get; set; }

	// Token: 0x1700214E RID: 8526
	// (get) Token: 0x06015F84 RID: 89988 RVA: 0x0065E814 File Offset: 0x0065CA14
	// (set) Token: 0x06015F85 RID: 89989 RVA: 0x0065E81C File Offset: 0x0065CA1C
	public bool IsUp { get; set; }

	// Token: 0x1700214F RID: 8527
	// (get) Token: 0x06015F86 RID: 89990 RVA: 0x0065E825 File Offset: 0x0065CA25
	// (set) Token: 0x06015F87 RID: 89991 RVA: 0x0065E82D File Offset: 0x0065CA2D
	public int? ScoreRate { get; set; }

	// Token: 0x17002150 RID: 8528
	// (get) Token: 0x06015F88 RID: 89992 RVA: 0x0065E836 File Offset: 0x0065CA36
	// (set) Token: 0x06015F89 RID: 89993 RVA: 0x0065E83E File Offset: 0x0065CA3E
	public bool IsEmpty { get; set; }
}
