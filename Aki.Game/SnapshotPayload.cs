using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020023BE RID: 9150
[NullableContext(2)]
[Nullable(0)]
public class SnapshotPayload
{
	// Token: 0x17002355 RID: 9045
	// (get) Token: 0x06016F11 RID: 93969 RVA: 0x006B2FE5 File Offset: 0x006B11E5
	// (set) Token: 0x06016F12 RID: 93970 RVA: 0x006B2FED File Offset: 0x006B11ED
	public BaseDamageComponent Target { get; set; }

	// Token: 0x17002356 RID: 9046
	// (get) Token: 0x06016F13 RID: 93971 RVA: 0x006B2FF6 File Offset: 0x006B11F6
	// (set) Token: 0x06016F14 RID: 93972 RVA: 0x006B2FFE File Offset: 0x006B11FE
	public BaseDamageComponent Attacker { get; set; }

	// Token: 0x17002357 RID: 9047
	// (get) Token: 0x06016F15 RID: 93973 RVA: 0x006B3007 File Offset: 0x006B1207
	// (set) Token: 0x06016F16 RID: 93974 RVA: 0x006B300F File Offset: 0x006B120F
	public AttributeSnapshot TargetSnapshot { get; set; }

	// Token: 0x17002358 RID: 9048
	// (get) Token: 0x06016F17 RID: 93975 RVA: 0x006B3018 File Offset: 0x006B1218
	// (set) Token: 0x06016F18 RID: 93976 RVA: 0x006B3020 File Offset: 0x006B1220
	public AttributeSnapshot AttackerSnapshot { get; set; }

	// Token: 0x17002359 RID: 9049
	// (get) Token: 0x06016F19 RID: 93977 RVA: 0x006B3029 File Offset: 0x006B1229
	// (set) Token: 0x06016F1A RID: 93978 RVA: 0x006B3031 File Offset: 0x006B1231
	public bool HasDamageTransfer { get; set; }

	// Token: 0x1700235A RID: 9050
	// (get) Token: 0x06016F1B RID: 93979 RVA: 0x006B303A File Offset: 0x006B123A
	// (set) Token: 0x06016F1C RID: 93980 RVA: 0x006B3042 File Offset: 0x006B1242
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<DamageTransfer> DamageTransfers { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }
}
