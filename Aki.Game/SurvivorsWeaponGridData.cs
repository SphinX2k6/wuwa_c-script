using System;
using System.Runtime.CompilerServices;

// Token: 0x02002AF4 RID: 10996
[NullableContext(2)]
[Nullable(0)]
public class SurvivorsWeaponGridData : ISurvivorsWeaponGridData
{
	// Token: 0x17001E84 RID: 7812
	// (get) Token: 0x06016DFD RID: 93693 RVA: 0x005CD9A7 File Offset: 0x005CBBA7
	// (set) Token: 0x06016DFE RID: 93694 RVA: 0x005CD9AF File Offset: 0x005CBBAF
	public SurvivorsWeaponGainData WeaponData { get; set; }

	// Token: 0x17001E85 RID: 7813
	// (get) Token: 0x06016DFF RID: 93695 RVA: 0x005CD9B8 File Offset: 0x005CBBB8
	// (set) Token: 0x06016E00 RID: 93696 RVA: 0x005CD9C0 File Offset: 0x005CBBC0
	public int? BondPosition { get; set; }

	// Token: 0x17001E86 RID: 7814
	// (get) Token: 0x06016E01 RID: 93697 RVA: 0x005CD9C9 File Offset: 0x005CBBC9
	// (set) Token: 0x06016E02 RID: 93698 RVA: 0x005CD9D1 File Offset: 0x005CBBD1
	public bool IsLock { get; set; }

	// Token: 0x17001E87 RID: 7815
	// (get) Token: 0x06016E03 RID: 93699 RVA: 0x005CD9DA File Offset: 0x005CBBDA
	// (set) Token: 0x06016E04 RID: 93700 RVA: 0x005CD9E2 File Offset: 0x005CBBE2
	public int? UnlockBatch { get; set; }

	// Token: 0x17001E88 RID: 7816
	// (get) Token: 0x06016E05 RID: 93701 RVA: 0x005CD9EB File Offset: 0x005CBBEB
	// (set) Token: 0x06016E06 RID: 93702 RVA: 0x005CD9F3 File Offset: 0x005CBBF3
	public bool IsDisable { get; set; }
}
