using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002D60 RID: 11616
[NullableContext(2)]
[Nullable(0)]
public class WeeklyRogueRoleGroupInfo : IWeeklyRogueRoleGroupInfo
{
	// Token: 0x170020EB RID: 8427
	// (get) Token: 0x060186D1 RID: 100049 RVA: 0x006387B8 File Offset: 0x006369B8
	// (set) Token: 0x060186D2 RID: 100050 RVA: 0x006387C0 File Offset: 0x006369C0
	public bool IsTitleType { get; set; }

	// Token: 0x170020EC RID: 8428
	// (get) Token: 0x060186D3 RID: 100051 RVA: 0x006387C9 File Offset: 0x006369C9
	// (set) Token: 0x060186D4 RID: 100052 RVA: 0x006387D1 File Offset: 0x006369D1
	public IWeeklyRogueRoleGroupTitleInfo TitleInfo { get; set; }

	// Token: 0x170020ED RID: 8429
	// (get) Token: 0x060186D5 RID: 100053 RVA: 0x006387DA File Offset: 0x006369DA
	// (set) Token: 0x060186D6 RID: 100054 RVA: 0x006387E2 File Offset: 0x006369E2
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
