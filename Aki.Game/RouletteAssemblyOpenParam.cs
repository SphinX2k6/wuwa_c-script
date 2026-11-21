using System;

// Token: 0x02001E88 RID: 7816
public class RouletteAssemblyOpenParam : IRouletteAssemblyOpenParam
{
	// Token: 0x17001D6F RID: 7535
	// (get) Token: 0x060134CA RID: 79050 RVA: 0x005A3411 File Offset: 0x005A1611
	// (set) Token: 0x060134CB RID: 79051 RVA: 0x005A3419 File Offset: 0x005A1619
	public ERouletteType? RouletteType { get; set; }

	// Token: 0x17001D70 RID: 7536
	// (get) Token: 0x060134CC RID: 79052 RVA: 0x005A3422 File Offset: 0x005A1622
	// (set) Token: 0x060134CD RID: 79053 RVA: 0x005A342A File Offset: 0x005A162A
	public int? SelectGridId { get; set; }

	// Token: 0x17001D71 RID: 7537
	// (get) Token: 0x060134CE RID: 79054 RVA: 0x005A3433 File Offset: 0x005A1633
	// (set) Token: 0x060134CF RID: 79055 RVA: 0x005A343B File Offset: 0x005A163B
	public int? SelectGridIndex { get; set; }

	// Token: 0x17001D72 RID: 7538
	// (get) Token: 0x060134D0 RID: 79056 RVA: 0x005A3444 File Offset: 0x005A1644
	// (set) Token: 0x060134D1 RID: 79057 RVA: 0x005A344C File Offset: 0x005A164C
	public ERouletteExploreId? EndSwitchSkillId { get; set; }

	// Token: 0x17001D73 RID: 7539
	// (get) Token: 0x060134D2 RID: 79058 RVA: 0x005A3455 File Offset: 0x005A1655
	// (set) Token: 0x060134D3 RID: 79059 RVA: 0x005A345D File Offset: 0x005A165D
	public bool? LocateEquippableSpecialItem { get; set; }
}
