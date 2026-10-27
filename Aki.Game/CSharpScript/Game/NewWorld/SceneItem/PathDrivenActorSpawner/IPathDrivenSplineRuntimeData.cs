using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.SceneItem.Common.Component;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.PathDrivenActorSpawner
{
	// Token: 0x020071C7 RID: 29127
	[NullableContext(1)]
	public interface IPathDrivenSplineRuntimeData
	{
		// Token: 0x17009DC5 RID: 40389
		// (get) Token: 0x0604748B RID: 291979
		// (set) Token: 0x0604748C RID: 291980
		int SplineEntityId { get; set; }

		// Token: 0x17009DC6 RID: 40390
		// (get) Token: 0x0604748D RID: 291981
		// (set) Token: 0x0604748E RID: 291982
		USplineComponent SplineComponent { get; set; }

		// Token: 0x17009DC7 RID: 40391
		// (get) Token: 0x0604748F RID: 291983
		// (set) Token: 0x06047490 RID: 291984
		SceneItemMoveComponent.SceneItemSplineMoveAtConstantTimeParam MoveParamTemplate { get; set; }
	}
}
