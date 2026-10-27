using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002E6C RID: 11884
[NullableContext(2)]
[Nullable(0)]
public class SnapshotPayload
{
	// Token: 0x170022D6 RID: 8918
	// (get) Token: 0x0601964A RID: 104010 RVA: 0x0068CBF1 File Offset: 0x0068ADF1
	// (set) Token: 0x0601964B RID: 104011 RVA: 0x0068CBF9 File Offset: 0x0068ADF9
	public BaseDamageComponent Target { get; set; }

	// Token: 0x170022D7 RID: 8919
	// (get) Token: 0x0601964C RID: 104012 RVA: 0x0068CC02 File Offset: 0x0068AE02
	// (set) Token: 0x0601964D RID: 104013 RVA: 0x0068CC0A File Offset: 0x0068AE0A
	public BaseDamageComponent Attacker { get; set; }

	// Token: 0x170022D8 RID: 8920
	// (get) Token: 0x0601964E RID: 104014 RVA: 0x0068CC13 File Offset: 0x0068AE13
	// (set) Token: 0x0601964F RID: 104015 RVA: 0x0068CC1B File Offset: 0x0068AE1B
	public AttributeSnapshot TargetSnapshot { get; set; }

	// Token: 0x170022D9 RID: 8921
	// (get) Token: 0x06019650 RID: 104016 RVA: 0x0068CC24 File Offset: 0x0068AE24
	// (set) Token: 0x06019651 RID: 104017 RVA: 0x0068CC2C File Offset: 0x0068AE2C
	public AttributeSnapshot AttackerSnapshot { get; set; }

	// Token: 0x170022DA RID: 8922
	// (get) Token: 0x06019652 RID: 104018 RVA: 0x0068CC35 File Offset: 0x0068AE35
	// (set) Token: 0x06019653 RID: 104019 RVA: 0x0068CC3D File Offset: 0x0068AE3D
	public bool HasDamageTransfer { get; set; }

	// Token: 0x170022DB RID: 8923
	// (get) Token: 0x06019654 RID: 104020 RVA: 0x0068CC46 File Offset: 0x0068AE46
	// (set) Token: 0x06019655 RID: 104021 RVA: 0x0068CC4E File Offset: 0x0068AE4E
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
