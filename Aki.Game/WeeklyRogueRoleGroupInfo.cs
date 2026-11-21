using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020022BA RID: 8890
[NullableContext(2)]
[Nullable(0)]
public class WeeklyRogueRoleGroupInfo : IWeeklyRogueRoleGroupInfo
{
	// Token: 0x17002146 RID: 8518
	// (get) Token: 0x06015F73 RID: 89971 RVA: 0x0065E7C8 File Offset: 0x0065C9C8
	// (set) Token: 0x06015F74 RID: 89972 RVA: 0x0065E7D0 File Offset: 0x0065C9D0
	public bool IsTitleType { get; set; }

	// Token: 0x17002147 RID: 8519
	// (get) Token: 0x06015F75 RID: 89973 RVA: 0x0065E7D9 File Offset: 0x0065C9D9
	// (set) Token: 0x06015F76 RID: 89974 RVA: 0x0065E7E1 File Offset: 0x0065C9E1
	public IWeeklyRogueRoleGroupTitleInfo TitleInfo { get; set; }

	// Token: 0x17002148 RID: 8520
	// (get) Token: 0x06015F77 RID: 89975 RVA: 0x0065E7EA File Offset: 0x0065C9EA
	// (set) Token: 0x06015F78 RID: 89976 RVA: 0x0065E7F2 File Offset: 0x0065C9F2
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<RoleDataBase> DataList { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }
}
