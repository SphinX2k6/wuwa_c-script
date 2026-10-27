using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002E0F RID: 11791
public class BulletHitTempResult
{
	// Token: 0x0400B977 RID: 47479
	public int Index;

	// Token: 0x0400B978 RID: 47480
	public double DistSquared;

	// Token: 0x0400B979 RID: 47481
	[Nullable(1)]
	public Vector ImpactPoint = Vector.Create();

	// Token: 0x0400B97A RID: 47482
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public TWeakObjectPtr<UPrimitiveComponent>? Component;

	// Token: 0x0400B97B RID: 47483
	[Nullable(2)]
	public AActor Actor;

	// Token: 0x0400B97C RID: 47484
	public int HitItem;
}
