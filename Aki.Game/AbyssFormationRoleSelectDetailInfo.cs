using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001A16 RID: 6678
[NullableContext(1)]
[Nullable(0)]
public class AbyssFormationRoleSelectDetailInfo
{
	// Token: 0x0600C3FC RID: 50172 RVA: 0x002C5EEC File Offset: 0x002C40EC
	public int GetRoleId()
	{
		return this.RoleId;
	}

	// Token: 0x0600C3FD RID: 50173 RVA: 0x002C5EF4 File Offset: 0x002C40F4
	public int GetDangoId()
	{
		return this.DangoId;
	}

	// Token: 0x0600C3FE RID: 50174 RVA: 0x002C5EFC File Offset: 0x002C40FC
	public int[] GetPluginItemList()
	{
		return this.PluginItemList;
	}

	// Token: 0x0600C3FF RID: 50175 RVA: 0x002C5F04 File Offset: 0x002C4104
	public void Phrase(AbyssOneRoleSelectInfo data)
	{
		this.RoleId = data.RoleId;
		this.DangoId = data.LittleRoleId;
		this.PluginItemList = data.PluginItemId.ToArray<int>();
	}

	// Token: 0x04005A65 RID: 23141
	private int RoleId;

	// Token: 0x04005A66 RID: 23142
	private int DangoId;

	// Token: 0x04005A67 RID: 23143
	private int[] PluginItemList = Array.Empty<int>();
}
