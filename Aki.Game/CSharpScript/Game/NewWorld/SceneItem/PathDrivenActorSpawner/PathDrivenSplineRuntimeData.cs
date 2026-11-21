using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.SceneItem.Common.Component;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.PathDrivenActorSpawner
{
	// Token: 0x0200627D RID: 25213
	[NullableContext(1)]
	[Nullable(0)]
	public class PathDrivenSplineRuntimeData : IPathDrivenSplineRuntimeData
	{
		// Token: 0x1700731F RID: 29471
		// (get) Token: 0x0603CD93 RID: 249235 RVA: 0x0117B9E6 File Offset: 0x01179BE6
		// (set) Token: 0x0603CD94 RID: 249236 RVA: 0x0117B9EE File Offset: 0x01179BEE
		public int SplineEntityId { get; set; }

		// Token: 0x17007320 RID: 29472
		// (get) Token: 0x0603CD95 RID: 249237 RVA: 0x0117B9F7 File Offset: 0x01179BF7
		// (set) Token: 0x0603CD96 RID: 249238 RVA: 0x0117B9FF File Offset: 0x01179BFF
		public USplineComponent SplineComponent { get; set; }

		// Token: 0x17007321 RID: 29473
		// (get) Token: 0x0603CD97 RID: 249239 RVA: 0x0117BA08 File Offset: 0x01179C08
		// (set) Token: 0x0603CD98 RID: 249240 RVA: 0x0117BA10 File Offset: 0x01179C10
		public SceneItemMoveComponent.SceneItemSplineMoveAtConstantTimeParam MoveParamTemplate { get; set; }
	}
}
