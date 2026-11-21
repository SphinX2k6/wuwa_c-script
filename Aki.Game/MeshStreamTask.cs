using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020016F3 RID: 5875
[NullableContext(2)]
[Nullable(0)]
public class MeshStreamTask
{
	// Token: 0x0400829E RID: 33438
	public int Id;

	// Token: 0x0400829F RID: 33439
	public MeshStreamTaskContext Context;

	// Token: 0x040082A0 RID: 33440
	public int SteamingHandleId = -1;

	// Token: 0x040082A1 RID: 33441
	public EMeshStreamTaskState TaskState;

	// Token: 0x040082A2 RID: 33442
	public FOnStreamedMeshesCompBundleAllMips.FOnStreamedMeshesCompBundleAllMips_ScriptDelegate MeshStreamFinishDelegate;
}
