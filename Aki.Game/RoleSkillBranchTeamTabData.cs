using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001E1B RID: 7707
public class RoleSkillBranchTeamTabData : IRoleSkillBranchTeamTabData
{
	// Token: 0x17001D22 RID: 7458
	// (get) Token: 0x0601316E RID: 78190 RVA: 0x00594E88 File Offset: 0x00593088
	// (set) Token: 0x0601316F RID: 78191 RVA: 0x00594E90 File Offset: 0x00593090
	public int TeamIndex { get; set; }

	// Token: 0x17001D23 RID: 7459
	// (get) Token: 0x06013170 RID: 78192 RVA: 0x00594E99 File Offset: 0x00593099
	// (set) Token: 0x06013171 RID: 78193 RVA: 0x00594EA1 File Offset: 0x005930A1
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
	public List<ValueTuple<int, int>> RoleSkillBranchTeamDataList { [return: TupleElementNames(new string[]
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
	})] set; } = new List<ValueTuple<int, int>>();
}
