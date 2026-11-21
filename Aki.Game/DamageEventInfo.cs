using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020023C2 RID: 9154
[NullableContext(2)]
[Nullable(0)]
public class DamageEventInfo
{
	// Token: 0x1700236D RID: 9069
	// (get) Token: 0x06016F45 RID: 94021 RVA: 0x006B319D File Offset: 0x006B139D
	// (set) Token: 0x06016F46 RID: 94022 RVA: 0x006B31A5 File Offset: 0x006B13A5
	public BaseDamageComponent Attacker { get; set; }

	// Token: 0x1700236E RID: 9070
	// (get) Token: 0x06016F47 RID: 94023 RVA: 0x006B31AE File Offset: 0x006B13AE
	// (set) Token: 0x06016F48 RID: 94024 RVA: 0x006B31B6 File Offset: 0x006B13B6
	public FVectorDouble HitPosition { get; set; }
}
