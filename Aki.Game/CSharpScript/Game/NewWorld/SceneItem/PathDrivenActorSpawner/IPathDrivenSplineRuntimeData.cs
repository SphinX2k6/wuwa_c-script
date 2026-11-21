using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.SceneItem.Common.Component;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.PathDrivenActorSpawner
{
	// Token: 0x0200627C RID: 25212
	[NullableContext(1)]
	public interface IPathDrivenSplineRuntimeData
	{
		// Token: 0x1700731C RID: 29468
		// (get) Token: 0x0603CD8D RID: 249229
		// (set) Token: 0x0603CD8E RID: 249230
		int SplineEntityId { get; set; }

		// Token: 0x1700731D RID: 29469
		// (get) Token: 0x0603CD8F RID: 249231
		// (set) Token: 0x0603CD90 RID: 249232
		USplineComponent SplineComponent { get; set; }

		// Token: 0x1700731E RID: 29470
		// (get) Token: 0x0603CD91 RID: 249233
		// (set) Token: 0x0603CD92 RID: 249234
		SceneItemMoveComponent.SceneItemSplineMoveAtConstantTimeParam MoveParamTemplate { get; set; }
	}
}
