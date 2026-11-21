using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200222C RID: 8748
[NullableContext(1)]
public interface ISyncGridProxy
{
	// Token: 0x170020C8 RID: 8392
	// (get) Token: 0x060159B1 RID: 88497
	// (set) Token: 0x060159B2 RID: 88498
	int GridIndex { get; set; }

	// Token: 0x060159B3 RID: 88499
	void Refresh(object data);

	// Token: 0x060159B4 RID: 88500
	void Clear();

	// Token: 0x060159B5 RID: 88501
	void CreateByActor(AActor actor);

	// Token: 0x060159B6 RID: 88502
	void CreateThenShowByActor(AActor actor);
}
