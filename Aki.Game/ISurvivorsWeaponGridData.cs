using System;
using System.Runtime.CompilerServices;

// Token: 0x02002AF3 RID: 10995
[NullableContext(2)]
public interface ISurvivorsWeaponGridData
{
	// Token: 0x17001E7F RID: 7807
	// (get) Token: 0x06016DF8 RID: 93688
	SurvivorsWeaponGainData WeaponData { get; }

	// Token: 0x17001E80 RID: 7808
	// (get) Token: 0x06016DF9 RID: 93689
	int? BondPosition { get; }

	// Token: 0x17001E81 RID: 7809
	// (get) Token: 0x06016DFA RID: 93690
	bool IsLock { get; }

	// Token: 0x17001E82 RID: 7810
	// (get) Token: 0x06016DFB RID: 93691
	int? UnlockBatch { get; }

	// Token: 0x17001E83 RID: 7811
	// (get) Token: 0x06016DFC RID: 93692
	bool IsDisable { get; }
}
