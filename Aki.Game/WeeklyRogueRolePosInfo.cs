using System;
using System.Runtime.CompilerServices;

// Token: 0x02002297 RID: 8855
[NullableContext(2)]
[Nullable(0)]
public class WeeklyRogueRolePosInfo : IWeeklyRogueRolePosInfo
{
	// Token: 0x17002130 RID: 8496
	// (get) Token: 0x06015E1F RID: 89631 RVA: 0x00658465 File Offset: 0x00656665
	// (set) Token: 0x06015E20 RID: 89632 RVA: 0x0065846D File Offset: 0x0065666D
	public RoleDataBase Data { get; set; }

	// Token: 0x17002131 RID: 8497
	// (get) Token: 0x06015E21 RID: 89633 RVA: 0x00658476 File Offset: 0x00656676
	// (set) Token: 0x06015E22 RID: 89634 RVA: 0x0065847E File Offset: 0x0065667E
	public bool? IsRecommend { get; set; }
}
