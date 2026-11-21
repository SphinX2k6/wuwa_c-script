using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020016F4 RID: 5876
[NullableContext(1)]
[Nullable(0)]
public class MeshStreamTaskContext
{
	// Token: 0x040082A3 RID: 33443
	public TArray<USkeletalMesh> SkeletalMeshes = new TArray<USkeletalMesh>();

	// Token: 0x040082A4 RID: 33444
	public TArray<UStaticMesh> StaticMeshes = new TArray<UStaticMesh>();

	// Token: 0x040082A5 RID: 33445
	[Nullable(2)]
	public Action OnTaskFinish;
}
