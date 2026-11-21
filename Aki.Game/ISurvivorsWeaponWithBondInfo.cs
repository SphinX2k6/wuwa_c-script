using System;
using System.Runtime.CompilerServices;

// Token: 0x02002071 RID: 8305
[NullableContext(1)]
public interface ISurvivorsWeaponWithBondInfo
{
	// Token: 0x17001EE1 RID: 7905
	// (get) Token: 0x06014839 RID: 84025
	SurvivorsWeaponGainData WeaponData { get; }

	// Token: 0x17001EE2 RID: 7906
	// (get) Token: 0x0601483A RID: 84026
	int BondPosition { get; }
}
