using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001A1C RID: 6684
[NullableContext(1)]
[Nullable(0)]
public class DangoAbyssRankRoleData
{
	// Token: 0x0600C433 RID: 50227 RVA: 0x002C6C60 File Offset: 0x002C4E60
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

	// Token: 0x04005A8C RID: 23180
	public bool IsEmpty = true;

	// Token: 0x04005A8D RID: 23181
	public int RoleSkinId;

	// Token: 0x04005A8E RID: 23182
	public int RoleLevel;

	// Token: 0x04005A8F RID: 23183
	public int DangoId;

	// Token: 0x04005A90 RID: 23184
	public bool IsOnline;

	// Token: 0x04005A91 RID: 23185
	public int Pos;

	// Token: 0x04005A92 RID: 23186
	public int[] DangoEquipIds = Array.Empty<int>();
}
