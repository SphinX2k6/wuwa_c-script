using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Google.Protobuf.Collections;

// Token: 0x02000ED5 RID: 3797
[NullableContext(1)]
[Nullable(0)]
public class AbyssFormationRoleSelectDetailInfo
{
	// Token: 0x0600980C RID: 38924 RVA: 0x002D0F44 File Offset: 0x002CF144
	public int GetRoleId()
	{
		return this.RoleId;
	}

	// Token: 0x0600980D RID: 38925 RVA: 0x002D0F4C File Offset: 0x002CF14C
	public int GetDangoId()
	{
		return this.DangoId;
	}

	// Token: 0x0600980E RID: 38926 RVA: 0x002D0F54 File Offset: 0x002CF154
	public int[] GetPluginItemList()
	{
		return this.PluginItemList;
	}

	// Token: 0x0600980F RID: 38927 RVA: 0x002D0F5C File Offset: 0x002CF15C
	public void Phrase(AbyssOneRoleSelectInfo data)
	{
		this.RoleId = data.RoleId;
		this.DangoId = data.LittleRoleId;
		RepeatedField<int> pluginItemId = data.PluginItemId;
		int[] array = new int[pluginItemId.Count];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = pluginItemId[i];
		}
		this.PluginItemList = array;
	}

	// Token: 0x04005B34 RID: 23348
	private int RoleId;

	// Token: 0x04005B35 RID: 23349
	private int DangoId;

	// Token: 0x04005B36 RID: 23350
	private int[] PluginItemList = Array.Empty<int>();
}
