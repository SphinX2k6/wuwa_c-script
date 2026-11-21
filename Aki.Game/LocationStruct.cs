using System;
using System.Runtime.CompilerServices;

// Token: 0x02002A4D RID: 10829
[NullableContext(1)]
[Nullable(0)]
public class LocationStruct
{
	// Token: 0x0601B6CB RID: 112331 RVA: 0x008701B3 File Offset: 0x0086E3B3
	public LocationStruct(CharacterActorComponent actorComp)
	{
		this.ActorComp = actorComp;
	}

	// Token: 0x0400ED24 RID: 60708
	public double DistSquared;

	// Token: 0x0400ED25 RID: 60709
	public CharacterActorComponent ActorComp;
}
