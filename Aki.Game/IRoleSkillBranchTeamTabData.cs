using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001E1A RID: 7706
public interface IRoleSkillBranchTeamTabData
{
	// Token: 0x17001D20 RID: 7456
	// (get) Token: 0x0601316A RID: 78186
	// (set) Token: 0x0601316B RID: 78187
	int TeamIndex { get; set; }

	// Token: 0x17001D21 RID: 7457
	// (get) Token: 0x0601316C RID: 78188
	// (set) Token: 0x0601316D RID: 78189
	[TupleElementNames(new string[]
	{
		"RoleId",
		"SkillBranchIndex"
	})]
	[Nullable(new byte[]
	{
		1,
		0
	})]
	List<ValueTuple<int, int>> RoleSkillBranchTeamDataList { [return: TupleElementNames(new string[]
	{
		"RoleId",
		"SkillBranchIndex"
	})] [return: Nullable(new byte[]
	{
		1,
		0
	})] get; [param: TupleElementNames(new string[]
	{
		"RoleId",
		"SkillBranchIndex"
	})] [param: Nullable(new byte[]
	{
		1,
		0
	})] set; }
}
