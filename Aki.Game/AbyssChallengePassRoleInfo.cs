using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Google.Protobuf.Collections;

// Token: 0x02000ED9 RID: 3801
[NullableContext(1)]
[Nullable(0)]
public class AbyssChallengePassRoleInfo
{
	// Token: 0x0600983C RID: 38972 RVA: 0x002D1C67 File Offset: 0x002CFE67
	public int GetRoleSkinId()
	{
		return this.RoleSkinId;
	}

	// Token: 0x0600983D RID: 38973 RVA: 0x002D1C6F File Offset: 0x002CFE6F
	public int GetRoleLevel()
	{
		return this.RoleLevel;
	}

	// Token: 0x0600983E RID: 38974 RVA: 0x002D1C77 File Offset: 0x002CFE77
	public int GetDangoId()
	{
		return this.DangoId;
	}

	// Token: 0x0600983F RID: 38975 RVA: 0x002D1C7F File Offset: 0x002CFE7F
	public int[] GetEquipmentList()
	{
		return this.EquipmentList;
	}

	// Token: 0x06009840 RID: 38976 RVA: 0x002D1C88 File Offset: 0x002CFE88
	public void Phrase(AbyssPassRoleInfo data)
	{
		this.RoleSkinId = data.RoleSkinId;
		this.RoleLevel = data.RoleLevel;
		this.DangoId = data.LittleRoleId;
		RepeatedField<int> pluginItemIds = data.PluginItemIds;
		int[] array = new int[pluginItemIds.Count];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = pluginItemIds[i];
		}
		this.EquipmentList = array;
	}

	// Token: 0x04005B52 RID: 23378
	private int RoleSkinId;

	// Token: 0x04005B53 RID: 23379
	private int RoleLevel;

	// Token: 0x04005B54 RID: 23380
	private int DangoId;

	// Token: 0x04005B55 RID: 23381
	private int[] EquipmentList = Array.Empty<int>();
}
