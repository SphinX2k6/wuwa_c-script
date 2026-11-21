using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200013C RID: 316
[NullableContext(1)]
[Nullable(0)]
public class HideMeshParams
{
	// Token: 0x060013CF RID: 5071 RVA: 0x00070E3B File Offset: 0x0006F03B
	public HideMeshParams(UMeshComponent meshComp)
	{
		this.MeshComp = meshComp;
	}

	// Token: 0x04000E53 RID: 3667
	public readonly List<AActor> Children = new List<AActor>();

	// Token: 0x04000E54 RID: 3668
	public int HideKey;

	// Token: 0x04000E55 RID: 3669
	public UMeshComponent MeshComp;
}
