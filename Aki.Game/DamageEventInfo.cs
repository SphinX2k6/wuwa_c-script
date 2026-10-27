using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002E70 RID: 11888
[NullableContext(2)]
[Nullable(0)]
public class DamageEventInfo
{
	// Token: 0x170022EE RID: 8942
	// (get) Token: 0x0601967E RID: 104062 RVA: 0x0068CDA9 File Offset: 0x0068AFA9
	// (set) Token: 0x0601967F RID: 104063 RVA: 0x0068CDB1 File Offset: 0x0068AFB1
	public BaseDamageComponent Attacker { get; set; }

	// Token: 0x170022EF RID: 8943
	// (get) Token: 0x06019680 RID: 104064 RVA: 0x0068CDBA File Offset: 0x0068AFBA
	// (set) Token: 0x06019681 RID: 104065 RVA: 0x0068CDC2 File Offset: 0x0068AFC2
	public FVectorDouble HitPosition { get; set; }
}
