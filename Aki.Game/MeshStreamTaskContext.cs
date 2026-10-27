using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002210 RID: 8720
[NullableContext(1)]
[Nullable(0)]
public class MeshStreamTaskContext
{
	// Token: 0x04008165 RID: 33125
	public TArray<USkeletalMesh> SkeletalMeshes = new TArray<USkeletalMesh>();

	// Token: 0x04008166 RID: 33126
	public TArray<UStaticMesh> StaticMeshes = new TArray<UStaticMesh>();

	// Token: 0x04008167 RID: 33127
	[Nullable(2)]
	public Action OnTaskFinish;
}
