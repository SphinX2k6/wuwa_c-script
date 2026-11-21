using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000EDB RID: 3803
[NullableContext(1)]
[Nullable(0)]
public class DangoAbyssRankRoleData
{
	// Token: 0x06009843 RID: 38979 RVA: 0x002D1D14 File Offset: 0x002CFF14
	public Dictionary<int, int> GetEquipPluginMap()
	{
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		for (int i = 0; i < 9; i++)
		{
			dictionary[i] = 0;
		}
		for (int j = 0; j < this.DangoEquipIds.Length; j++)
		{
			dictionary[j] = this.DangoEquipIds[j];
		}
		return dictionary;
	}

	// Token: 0x04005B5B RID: 23387
	public bool IsEmpty = true;

	// Token: 0x04005B5C RID: 23388
	public int RoleSkinId;

	// Token: 0x04005B5D RID: 23389
	public int RoleLevel;

	// Token: 0x04005B5E RID: 23390
	public int DangoId;

	// Token: 0x04005B5F RID: 23391
	public bool IsOnline;

	// Token: 0x04005B60 RID: 23392
	public int Pos;

	// Token: 0x04005B61 RID: 23393
	public int[] DangoEquipIds = Array.Empty<int>();
}
