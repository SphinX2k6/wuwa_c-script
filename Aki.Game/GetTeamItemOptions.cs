using System;

// Token: 0x02002959 RID: 10585
public class GetTeamItemOptions : IGetTeamItemOptions
{
	// Token: 0x17001D6D RID: 7533
	// (get) Token: 0x06015DE7 RID: 89575 RVA: 0x00583FFD File Offset: 0x005821FD
	// (set) Token: 0x06015DE8 RID: 89576 RVA: 0x00584005 File Offset: 0x00582205
	public ETeamParamType ParamType { get; set; }

	// Token: 0x17001D6E RID: 7534
	// (get) Token: 0x06015DE9 RID: 89577 RVA: 0x0058400E File Offset: 0x0058220E
	// (set) Token: 0x06015DEA RID: 89578 RVA: 0x00584016 File Offset: 0x00582216
	public bool? OnlyMyRole { get; set; }

	// Token: 0x17001D6F RID: 7535
	// (get) Token: 0x06015DEB RID: 89579 RVA: 0x0058401F File Offset: 0x0058221F
	// (set) Token: 0x06015DEC RID: 89580 RVA: 0x00584027 File Offset: 0x00582227
	public bool? IsControl { get; set; }
}
