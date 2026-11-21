using System;
using System.Runtime.CompilerServices;

// Token: 0x020023BD RID: 9149
[NullableContext(2)]
[Nullable(0)]
public class DamageTransfer
{
	// Token: 0x17002352 RID: 9042
	// (get) Token: 0x06016F0A RID: 93962 RVA: 0x006B2FAA File Offset: 0x006B11AA
	// (set) Token: 0x06016F0B RID: 93963 RVA: 0x006B2FB2 File Offset: 0x006B11B2
	public BaseDamageComponent TransferTarget { get; set; }

	// Token: 0x17002353 RID: 9043
	// (get) Token: 0x06016F0C RID: 93964 RVA: 0x006B2FBB File Offset: 0x006B11BB
	// (set) Token: 0x06016F0D RID: 93965 RVA: 0x006B2FC3 File Offset: 0x006B11C3
	public float ToughRecoverDelayTime { get; set; }

	// Token: 0x17002354 RID: 9044
	// (get) Token: 0x06016F0E RID: 93966 RVA: 0x006B2FCC File Offset: 0x006B11CC
	// (set) Token: 0x06016F0F RID: 93967 RVA: 0x006B2FD4 File Offset: 0x006B11D4
	public float WeakTime { get; set; }
}
