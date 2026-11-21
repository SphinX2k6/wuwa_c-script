using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200236B RID: 9067
public class BulletHitTempResult
{
	// Token: 0x0400BD05 RID: 48389
	public int Index;

	// Token: 0x0400BD06 RID: 48390
	public double DistSquared;

	// Token: 0x0400BD07 RID: 48391
	[Nullable(1)]
	public Vector ImpactPoint = Vector.Create();

	// Token: 0x0400BD08 RID: 48392
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public TWeakObjectPtr<UPrimitiveComponent>? Component;

	// Token: 0x0400BD09 RID: 48393
	[Nullable(2)]
	public AActor Actor;

	// Token: 0x0400BD0A RID: 48394
	public int HitItem;
}
