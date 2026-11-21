using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200062A RID: 1578
[NullableContext(1)]
[Nullable(0)]
public class BabelTowerPresetTeamData
{
	// Token: 0x060049A9 RID: 18857 RVA: 0x00190A01 File Offset: 0x0018EC01
	public BabelTowerPresetTeamData(int teamId, int teamIndex, List<int> roleIdList)
	{
		this.TeamId = teamId;
		this.TeamIndex = teamIndex;
		this.RoleIdList = roleIdList;
	}

	// Token: 0x060049AA RID: 18858 RVA: 0x00190A29 File Offset: 0x0018EC29
	public int GetTeamId()
	{
		return this.TeamId;
	}

	// Token: 0x060049AB RID: 18859 RVA: 0x00190A31 File Offset: 0x0018EC31
	public int GetTeamIndex()
	{
		return this.TeamIndex;
	}

	// Token: 0x060049AC RID: 18860 RVA: 0x00190A39 File Offset: 0x0018EC39
	public List<int> GetRoleIdList()
	{
		return this.RoleIdList;
	}

	// Token: 0x040036BF RID: 14015
	private readonly int TeamId;

	// Token: 0x040036C0 RID: 14016
	private readonly int TeamIndex;

	// Token: 0x040036C1 RID: 14017
	private readonly List<int> RoleIdList = new List<int>();
}
