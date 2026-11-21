using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020022B9 RID: 8889
[NullableContext(2)]
public interface IWeeklyRogueRoleGroupInfo
{
	// Token: 0x17002143 RID: 8515
	// (get) Token: 0x06015F6D RID: 89965
	// (set) Token: 0x06015F6E RID: 89966
	bool IsTitleType { get; set; }

	// Token: 0x17002144 RID: 8516
	// (get) Token: 0x06015F6F RID: 89967
	// (set) Token: 0x06015F70 RID: 89968
	IWeeklyRogueRoleGroupTitleInfo TitleInfo { get; set; }

	// Token: 0x17002145 RID: 8517
	// (get) Token: 0x06015F71 RID: 89969
	// (set) Token: 0x06015F72 RID: 89970
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
