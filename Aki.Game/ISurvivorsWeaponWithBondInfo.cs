using System;
using System.Runtime.CompilerServices;

// Token: 0x02002AF5 RID: 10997
[NullableContext(1)]
public interface ISurvivorsWeaponWithBondInfo
{
	// Token: 0x17001E89 RID: 7817
	// (get) Token: 0x06016E08 RID: 93704
	SurvivorsWeaponGainData WeaponData { get; }

	// Token: 0x17001E8A RID: 7818
	// (get) Token: 0x06016E09 RID: 93705
	int BondPosition { get; }
}
