using System;
using System.Runtime.CompilerServices;

// Token: 0x02001BF2 RID: 7154
[NullableContext(2)]
[Nullable(0)]
public class FormationRoleData
{
	// Token: 0x0600D532 RID: 54578 RVA: 0x0031168C File Offset: 0x0030F88C
	public FormationRoleData(int position, int configId, int roleSkinId, int level, int playerId, int multiSkillBranchIndex, FormationRoleEquip equip = null)
	{
		this.Position = position;
		this.ConfigId = configId;
		this.RoleSkinId = roleSkinId;
		this.PlayerId = playerId;
		this.Level = level;
		this.MultiSkillBranchIndex = multiSkillBranchIndex;
		this.Equip = equip;
	}

	// Token: 0x040061A4 RID: 24996
	public readonly int Position;

	// Token: 0x040061A5 RID: 24997
	public readonly int ConfigId;

	// Token: 0x040061A6 RID: 24998
	public readonly int RoleSkinId;

	// Token: 0x040061A7 RID: 24999
	public readonly int PlayerId;

	// Token: 0x040061A8 RID: 25000
	public readonly int Level;

	// Token: 0x040061A9 RID: 25001
	public readonly int MultiSkillBranchIndex;

	// Token: 0x040061AA RID: 25002
	public readonly FormationRoleEquip Equip;
}
