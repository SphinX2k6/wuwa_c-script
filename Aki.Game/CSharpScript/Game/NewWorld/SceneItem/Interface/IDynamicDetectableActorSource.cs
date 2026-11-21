using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.Interface
{
	// Token: 0x020062AA RID: 25258
	[NullableContext(1)]
	public interface IDynamicDetectableActorSource
	{
		// Token: 0x0603CFAB RID: 249771
		List<AActor> GetDetectableActors();

		// Token: 0x0603CFAC RID: 249772
		void OnActorsEnterField(IReadOnlyList<AActor> actors);

		// Token: 0x0603CFAD RID: 249773
		void OnActorsLeaveField(IReadOnlyList<AActor> actors);
	}
}
