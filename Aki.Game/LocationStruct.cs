using System;
using System.Runtime.CompilerServices;

// Token: 0x020034D9 RID: 13529
[NullableContext(1)]
[Nullable(0)]
public class LocationStruct
{
	// Token: 0x0601D9C1 RID: 121281 RVA: 0x00847E9E File Offset: 0x0084609E
	public LocationStruct(CharacterActorComponent actorComp)
	{
		this.ActorComp = actorComp;
	}

	// Token: 0x0400E86D RID: 59501
	public double DistSquared;

	// Token: 0x0400E86E RID: 59502
	public CharacterActorComponent ActorComp;
}
