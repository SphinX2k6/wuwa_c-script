using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002759 RID: 10073
public class DelayRemoveInfo
{
	// Token: 0x06019496 RID: 103574 RVA: 0x007B9632 File Offset: 0x007B7832
	[NullableContext(1)]
	public DelayRemoveInfo(AActor actor)
	{
		this.Actor = actor;
	}

	// Token: 0x0400DD53 RID: 56659
	public double Counter;

	// Token: 0x0400DD54 RID: 56660
	[Nullable(2)]
	public AActor Actor;
}
