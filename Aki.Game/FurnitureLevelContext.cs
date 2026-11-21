using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02000466 RID: 1126
[NullableContext(1)]
[Nullable(0)]
public class FurnitureLevelContext
{
	// Token: 0x06003A79 RID: 14969 RVA: 0x0014E44E File Offset: 0x0014C64E
	public FurnitureLevelContext(Transform transform, string prefabPath)
	{
		this.Transform = transform;
		this.PrefabPath = prefabPath;
	}

	// Token: 0x04002F3E RID: 12094
	[Nullable(2)]
	public ULevelStreamingDynamic LevelStreamingDynamic;

	// Token: 0x04002F3F RID: 12095
	public readonly Transform Transform;

	// Token: 0x04002F40 RID: 12096
	public readonly string PrefabPath;
}
