using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001176 RID: 4470
[NullableContext(1)]
[Nullable(0)]
public class BabelTowerPresetTeamData
{
	// Token: 0x06007612 RID: 30226 RVA: 0x00187E51 File Offset: 0x00186051
	public BabelTowerPresetTeamData(int teamId, int teamIndex, List<int> roleIdList)
	{
		this.TeamId = teamId;
		this.TeamIndex = teamIndex;
		this.RoleIdList = roleIdList;
	}

	// Token: 0x06007613 RID: 30227 RVA: 0x00187E79 File Offset: 0x00186079
	public int GetTeamId()
	{
		return this.TeamId;
	}

	// Token: 0x06007614 RID: 30228 RVA: 0x00187E81 File Offset: 0x00186081
	public int GetTeamIndex()
	{
		return this.TeamIndex;
	}

	// Token: 0x06007615 RID: 30229 RVA: 0x00187E89 File Offset: 0x00186089
	public List<int> GetRoleIdList()
	{
		return this.RoleIdList;
	}

	// Token: 0x04003626 RID: 13862
	private readonly int TeamId;

	// Token: 0x04003627 RID: 13863
	private readonly int TeamIndex;

	// Token: 0x04003628 RID: 13864
	private readonly List<int> RoleIdList = new List<int>();
}
