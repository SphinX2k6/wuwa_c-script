using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001A1A RID: 6682
[NullableContext(1)]
[Nullable(0)]
public class AbyssChallengePassRoleInfo
{
	// Token: 0x0600C42C RID: 50220 RVA: 0x002C6BE3 File Offset: 0x002C4DE3
	public int GetRoleSkinId()
	{
		return this.RoleSkinId;
	}

	// Token: 0x0600C42D RID: 50221 RVA: 0x002C6BEB File Offset: 0x002C4DEB
	public int GetRoleLevel()
	{
		return this.RoleLevel;
	}

	// Token: 0x0600C42E RID: 50222 RVA: 0x002C6BF3 File Offset: 0x002C4DF3
	public int GetDangoId()
	{
		return this.DangoId;
	}

	// Token: 0x0600C42F RID: 50223 RVA: 0x002C6BFB File Offset: 0x002C4DFB
	public int[] GetEquipmentList()
	{
		return this.EquipmentList;
	}

	// Token: 0x0600C430 RID: 50224 RVA: 0x002C6C03 File Offset: 0x002C4E03
	public void Phrase(AbyssPassRoleInfo data)
	{
		this.RoleSkinId = data.RoleSkinId;
		this.RoleLevel = data.RoleLevel;
		this.DangoId = data.LittleRoleId;
		this.EquipmentList = data.PluginItemIds.ToArray<int>();
	}

	// Token: 0x04005A83 RID: 23171
	private int RoleSkinId;

	// Token: 0x04005A84 RID: 23172
	private int RoleLevel;

	// Token: 0x04005A85 RID: 23173
	private int DangoId;

	// Token: 0x04005A86 RID: 23174
	private int[] EquipmentList = Array.Empty<int>();
}
