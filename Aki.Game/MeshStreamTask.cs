using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200220F RID: 8719
[NullableContext(2)]
[Nullable(0)]
public class MeshStreamTask
{
	// Token: 0x04008160 RID: 33120
	public int Id;

	// Token: 0x04008161 RID: 33121
	public MeshStreamTaskContext Context;

	// Token: 0x04008162 RID: 33122
	public int SteamingHandleId = -1;

	// Token: 0x04008163 RID: 33123
	public EMeshStreamTaskState TaskState;

	// Token: 0x04008164 RID: 33124
	public FOnStreamedMeshesCompBundleAllMips.FOnStreamedMeshesCompBundleAllMips_ScriptDelegate MeshStreamFinishDelegate;
}
