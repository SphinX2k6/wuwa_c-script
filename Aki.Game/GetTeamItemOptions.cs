using System;

// Token: 0x02001ED4 RID: 7892
public class GetTeamItemOptions : IGetTeamItemOptions
{
	// Token: 0x17001DC6 RID: 7622
	// (get) Token: 0x060137EB RID: 79851 RVA: 0x005AEFFD File Offset: 0x005AD1FD
	// (set) Token: 0x060137EC RID: 79852 RVA: 0x005AF005 File Offset: 0x005AD205
	public ETeamParamType ParamType { get; set; }

	// Token: 0x17001DC7 RID: 7623
	// (get) Token: 0x060137ED RID: 79853 RVA: 0x005AF00E File Offset: 0x005AD20E
	// (set) Token: 0x060137EE RID: 79854 RVA: 0x005AF016 File Offset: 0x005AD216
	public bool? OnlyMyRole { get; set; }

	// Token: 0x17001DC8 RID: 7624
	// (get) Token: 0x060137EF RID: 79855 RVA: 0x005AF01F File Offset: 0x005AD21F
	// (set) Token: 0x060137F0 RID: 79856 RVA: 0x005AF027 File Offset: 0x005AD227
	public bool? IsControl { get; set; }
}
