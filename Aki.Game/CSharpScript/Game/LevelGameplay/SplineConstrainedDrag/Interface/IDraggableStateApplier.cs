using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay.SplineConstrainedDrag.Define;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.SplineConstrainedDrag.Interface
{
	// Token: 0x02006A35 RID: 27189
	[NullableContext(1)]
	public interface IDraggableStateApplier
	{
		// Token: 0x06043A25 RID: 277029
		void Initialize(AActor actor);

		// Token: 0x06043A26 RID: 277030
		void ApplyState(AActor actor, EDraggableState state);

		// Token: 0x06043A27 RID: 277031
		void Dispose(AActor actor);
	}
}
