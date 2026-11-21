using System;
using System.Runtime.CompilerServices;

// Token: 0x0200206F RID: 8303
[NullableContext(2)]
public interface ISurvivorsWeaponGridData
{
	// Token: 0x17001ED7 RID: 7895
	// (get) Token: 0x06014829 RID: 84009
	SurvivorsWeaponGainData WeaponData { get; }

	// Token: 0x17001ED8 RID: 7896
	// (get) Token: 0x0601482A RID: 84010
	int? BondPosition { get; }

	// Token: 0x17001ED9 RID: 7897
	// (get) Token: 0x0601482B RID: 84011
	bool IsLock { get; }

	// Token: 0x17001EDA RID: 7898
	// (get) Token: 0x0601482C RID: 84012
	int? UnlockBatch { get; }

	// Token: 0x17001EDB RID: 7899
	// (get) Token: 0x0601482D RID: 84013
	bool IsDisable { get; }
}
