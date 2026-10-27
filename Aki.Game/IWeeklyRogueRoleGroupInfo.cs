using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002D5F RID: 11615
[NullableContext(2)]
public interface IWeeklyRogueRoleGroupInfo
{
	// Token: 0x170020E8 RID: 8424
	// (get) Token: 0x060186CB RID: 100043
	// (set) Token: 0x060186CC RID: 100044
	bool IsTitleType { get; set; }

	// Token: 0x170020E9 RID: 8425
	// (get) Token: 0x060186CD RID: 100045
	// (set) Token: 0x060186CE RID: 100046
	IWeeklyRogueRoleGroupTitleInfo TitleInfo { get; set; }

	// Token: 0x170020EA RID: 8426
	// (get) Token: 0x060186CF RID: 100047
	// (set) Token: 0x060186D0 RID: 100048
	[Nullable(new byte[]
	{
		2,
		1
	})]
	List<RoleDataBase> DataList { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }
}
