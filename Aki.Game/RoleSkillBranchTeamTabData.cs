using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020028A0 RID: 10400
public class RoleSkillBranchTeamTabData : IRoleSkillBranchTeamTabData
{
	// Token: 0x17001CCA RID: 7370
	// (get) Token: 0x0601576E RID: 87918 RVA: 0x0056A040 File Offset: 0x00568240
	// (set) Token: 0x0601576F RID: 87919 RVA: 0x0056A048 File Offset: 0x00568248
	public int TeamIndex { get; set; }

	// Token: 0x17001CCB RID: 7371
	// (get) Token: 0x06015770 RID: 87920 RVA: 0x0056A051 File Offset: 0x00568251
	// (set) Token: 0x06015771 RID: 87921 RVA: 0x0056A059 File Offset: 0x00568259
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
