using System;
using System.Runtime.CompilerServices;

// Token: 0x020010B1 RID: 4273
[NullableContext(2)]
[Nullable(0)]
public class FormationRoleData
{
	// Token: 0x0600A945 RID: 43333 RVA: 0x0031C8D0 File Offset: 0x0031AAD0
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

	// Token: 0x04006273 RID: 25203
	public readonly int Position;

	// Token: 0x04006274 RID: 25204
	public readonly int ConfigId;

	// Token: 0x04006275 RID: 25205
	public readonly int RoleSkinId;

	// Token: 0x04006276 RID: 25206
	public readonly int PlayerId;

	// Token: 0x04006277 RID: 25207
	public readonly int Level;

	// Token: 0x04006278 RID: 25208
	public readonly int MultiSkillBranchIndex;

	// Token: 0x04006279 RID: 25209
	public readonly FormationRoleEquip Equip;

	// Token: 0x0400627A RID: 25210
	public string PlayerName;

	// Token: 0x0400627B RID: 25211
	public string ThirdPartyOnlineId;

	// Token: 0x0400627C RID: 25212
	public int? OnlineIndex;
}
