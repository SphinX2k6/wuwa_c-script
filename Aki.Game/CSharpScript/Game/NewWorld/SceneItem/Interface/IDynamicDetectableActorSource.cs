using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.Interface
{
	// Token: 0x020071F5 RID: 29173
	[NullableContext(1)]
	public interface IDynamicDetectableActorSource
	{
		// Token: 0x060476A3 RID: 292515
		List<AActor> GetDetectableActors();

		// Token: 0x060476A4 RID: 292516
		void OnActorsEnterField(IReadOnlyList<AActor> actors);

		// Token: 0x060476A5 RID: 292517
		void OnActorsLeaveField(IReadOnlyList<AActor> actors);
	}
}
