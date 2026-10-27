using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02000FB1 RID: 4017
[NullableContext(1)]
[Nullable(0)]
public class FurnitureLevelContext
{
	// Token: 0x060066E1 RID: 26337 RVA: 0x00145B8A File Offset: 0x00143D8A
	public FurnitureLevelContext(Transform transform, string prefabPath)
	{
		this.Transform = transform;
		this.PrefabPath = prefabPath;
	}

	// Token: 0x04002EA5 RID: 11941
	[Nullable(2)]
	public ULevelStreamingDynamic LevelStreamingDynamic;

	// Token: 0x04002EA6 RID: 11942
	public readonly Transform Transform;

	// Token: 0x04002EA7 RID: 11943
	public readonly string PrefabPath;
}
