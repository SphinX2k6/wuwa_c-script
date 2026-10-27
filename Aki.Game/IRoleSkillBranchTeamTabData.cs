using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200289F RID: 10399
public interface IRoleSkillBranchTeamTabData
{
	// Token: 0x17001CC8 RID: 7368
	// (get) Token: 0x0601576A RID: 87914
	// (set) Token: 0x0601576B RID: 87915
	int TeamIndex { get; set; }

	// Token: 0x17001CC9 RID: 7369
	// (get) Token: 0x0601576C RID: 87916
	// (set) Token: 0x0601576D RID: 87917
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
