using System;
using System.Runtime.CompilerServices;

// Token: 0x02002E6D RID: 11885
[NullableContext(2)]
[Nullable(0)]
public class DamageCompPayload
{
	// Token: 0x170022DC RID: 8924
	// (get) Token: 0x06019657 RID: 104023 RVA: 0x0068CC5F File Offset: 0x0068AE5F
	// (set) Token: 0x06019658 RID: 104024 RVA: 0x0068CC67 File Offset: 0x0068AE67
	public BaseDamageComponent Target { get; set; }

	// Token: 0x170022DD RID: 8925
	// (get) Token: 0x06019659 RID: 104025 RVA: 0x0068CC70 File Offset: 0x0068AE70
	// (set) Token: 0x0601965A RID: 104026 RVA: 0x0068CC78 File Offset: 0x0068AE78
	public BaseDamageComponent Attacker { get; set; }
}
