using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay.SplineConstrainedDrag.Define;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.SplineConstrainedDrag.Interface
{
	// Token: 0x02005B92 RID: 23442
	[NullableContext(1)]
	public interface IDraggableStateApplier
	{
		// Token: 0x06039A73 RID: 236147
		void Initialize(AActor actor);

		// Token: 0x06039A74 RID: 236148
		void ApplyState(AActor actor, EDraggableState state);

		// Token: 0x06039A75 RID: 236149
		void Dispose(AActor actor);
	}
}
