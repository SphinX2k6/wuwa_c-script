using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002031 RID: 8241
[NullableContext(2)]
[Nullable(0)]
public class TipsSplineActorData
{
	// Token: 0x06014664 RID: 83556 RVA: 0x005F3FC2 File Offset: 0x005F21C2
	public TipsSplineActorData(int id, int pbDataId)
	{
	}

	// Token: 0x0400AD0D RID: 44301
	public int Id = id;

	// Token: 0x0400AD0E RID: 44302
	public int PbDataId = pbDataId;

	// Token: 0x0400AD0F RID: 44303
	public TsGameSplineActor Actor;

	// Token: 0x0400AD10 RID: 44304
	public USplineComponent SplineComp;
}
