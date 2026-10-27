using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002CD3 RID: 11475
[NullableContext(1)]
public interface ISyncGridProxy
{
	// Token: 0x17002075 RID: 8309
	// (get) Token: 0x06018134 RID: 98612
	// (set) Token: 0x06018135 RID: 98613
	int GridIndex { get; set; }

	// Token: 0x06018136 RID: 98614
	void Refresh(object data);

	// Token: 0x06018137 RID: 98615
	void Clear();

	// Token: 0x06018138 RID: 98616
	void CreateByActor(AActor actor);

	// Token: 0x06018139 RID: 98617
	void CreateThenShowByActor(AActor actor);
}
