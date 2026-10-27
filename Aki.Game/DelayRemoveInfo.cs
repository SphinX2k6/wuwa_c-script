using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020031EA RID: 12778
public class DelayRemoveInfo
{
	// Token: 0x0601B911 RID: 112913 RVA: 0x00790F06 File Offset: 0x0078F106
	[NullableContext(1)]
	public DelayRemoveInfo(AActor actor)
	{
		this.Actor = actor;
	}

	// Token: 0x0400D8B5 RID: 55477
	public double Counter;

	// Token: 0x0400D8B6 RID: 55478
	[Nullable(2)]
	public AActor Actor;
}
