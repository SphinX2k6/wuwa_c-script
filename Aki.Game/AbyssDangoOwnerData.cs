using System;
using System.Runtime.CompilerServices;

// Token: 0x02001A1B RID: 6683
public class AbyssDangoOwnerData
{
	// Token: 0x04005A87 RID: 23175
	public int PlayerId;

	// Token: 0x04005A88 RID: 23176
	public int RoleCfgId;

	// Token: 0x04005A89 RID: 23177
	public int DangoId;

	// Token: 0x04005A8A RID: 23178
	public int DangoLevel;

	// Token: 0x04005A8B RID: 23179
	[Nullable(1)]
	public int[] DangoEquipIds = Array.Empty<int>();
}
