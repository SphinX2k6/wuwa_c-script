using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002784 RID: 10116
[NullableContext(2)]
[Nullable(0)]
public class StareActionInfo
{
	// Token: 0x060195F5 RID: 103925 RVA: 0x007C1BD2 File Offset: 0x007BFDD2
	public void ClearInfo()
	{
		this.TargetLocation.Reset();
		this.TargetItem = null;
		this.TargetActor = null;
	}

	// Token: 0x060195F6 RID: 103926 RVA: 0x007C1BF0 File Offset: 0x007BFDF0
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

	// Token: 0x0400DE1D RID: 56861
	public bool IsDirty;

	// Token: 0x0400DE1E RID: 56862
	[Nullable(1)]
	public Vector TargetLocation = Vector.Create();

	// Token: 0x0400DE1F RID: 56863
	public BaseActorComponent TargetItem;

	// Token: 0x0400DE20 RID: 56864
	public AActor TargetActor;
}
