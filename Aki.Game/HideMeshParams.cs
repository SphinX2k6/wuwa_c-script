using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200013B RID: 315
[NullableContext(1)]
[Nullable(0)]
public class HideMeshParams
{
	// Token: 0x06001351 RID: 4945 RVA: 0x0006C883 File Offset: 0x0006AA83
	public HideMeshParams(UMeshComponent meshComp)
	{
		this.MeshComp = meshComp;
	}

	// Token: 0x04000E21 RID: 3617
	public readonly List<AActor> Children = new List<AActor>();

	// Token: 0x04000E22 RID: 3618
	public int HideKey;

	// Token: 0x04000E23 RID: 3619
	public UMeshComponent MeshComp;
}
