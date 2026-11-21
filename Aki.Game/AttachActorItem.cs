using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002A67 RID: 10855
[NullableContext(2)]
[Nullable(0)]
public class AttachActorItem
{
	// Token: 0x0400EDF1 RID: 60913
	public int Id;

	// Token: 0x0400EDF2 RID: 60914
	public int EntityId;

	// Token: 0x0400EDF3 RID: 60915
	public string Reason;

	// Token: 0x0400EDF4 RID: 60916
	public AActor Actor;

	// Token: 0x0400EDF5 RID: 60917
	public string Name;

	// Token: 0x0400EDF6 RID: 60918
	public string ParentActorName;

	// Token: 0x0400EDF7 RID: 60919
	public EDetachType? DetachType;
}
