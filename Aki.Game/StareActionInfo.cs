using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02003215 RID: 12821
[NullableContext(2)]
[Nullable(0)]
public class StareActionInfo
{
	// Token: 0x0601BA70 RID: 113264 RVA: 0x00799436 File Offset: 0x00797636
	public void ClearInfo()
	{
		this.TargetLocation.Reset();
		this.TargetItem = null;
		this.TargetActor = null;
	}

	// Token: 0x0601BA71 RID: 113265 RVA: 0x00799454 File Offset: 0x00797654
	public bool IsValid()
	{
		if (!this.TargetLocation.Equals(Vector.ZeroVectorProxy, 9.999999747378752E-05))
		{
			return true;
		}
		if (this.TargetItem != null)
		{
			return this.TargetItem.Valid;
		}
		return this.TargetActor != null && this.TargetActor.IsValid();
	}

	// Token: 0x0400D97E RID: 55678
	public bool IsDirty;

	// Token: 0x0400D97F RID: 55679
	[Nullable(1)]
	public Vector TargetLocation = Vector.Create();

	// Token: 0x0400D980 RID: 55680
	public BaseActorComponent TargetItem;

	// Token: 0x0400D981 RID: 55681
	public AActor TargetActor;
}
