using System;
using System.Runtime.CompilerServices;

// Token: 0x02000EDA RID: 3802
public class AbyssDangoOwnerData
{
	// Token: 0x04005B56 RID: 23382
	public int PlayerId;

	// Token: 0x04005B57 RID: 23383
	public int RoleCfgId;

	// Token: 0x04005B58 RID: 23384
	public int DangoId;

	// Token: 0x04005B59 RID: 23385
	public int DangoLevel;

	// Token: 0x04005B5A RID: 23386
	[Nullable(1)]
	public int[] DangoEquipIds = Array.Empty<int>();
}
