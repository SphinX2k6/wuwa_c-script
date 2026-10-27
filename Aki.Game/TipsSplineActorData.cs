using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002AB5 RID: 10933
[NullableContext(2)]
[Nullable(0)]
public class TipsSplineActorData
{
	// Token: 0x06016C33 RID: 93235 RVA: 0x005C746E File Offset: 0x005C566E
	public TipsSplineActorData(int id, int pbDataId)
	{
	}

	// Token: 0x0400A907 RID: 43271
	public int Id = id;

	// Token: 0x0400A908 RID: 43272
	public int PbDataId = pbDataId;

	// Token: 0x0400A909 RID: 43273
	public TsGameSplineActor Actor;

	// Token: 0x0400A90A RID: 43274
	public USplineComponent SplineComp;
}
