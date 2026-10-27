using System;
using System.Runtime.CompilerServices;

// Token: 0x02002D3D RID: 11581
[NullableContext(2)]
[Nullable(0)]
public class WeeklyRogueRolePosInfo : IWeeklyRogueRolePosInfo
{
	// Token: 0x170020D5 RID: 8405
	// (get) Token: 0x0601857D RID: 99709 RVA: 0x00632455 File Offset: 0x00630655
	// (set) Token: 0x0601857E RID: 99710 RVA: 0x0063245D File Offset: 0x0063065D
	public RoleDataBase Data { get; set; }

	// Token: 0x170020D6 RID: 8406
	// (get) Token: 0x0601857F RID: 99711 RVA: 0x00632466 File Offset: 0x00630666
	// (set) Token: 0x06018580 RID: 99712 RVA: 0x0063246E File Offset: 0x0063066E
	public bool? IsRecommend { get; set; }
}
