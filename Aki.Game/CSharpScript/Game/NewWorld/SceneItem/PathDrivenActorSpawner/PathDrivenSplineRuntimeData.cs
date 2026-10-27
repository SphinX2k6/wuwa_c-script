using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.SceneItem.Common.Component;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.PathDrivenActorSpawner
{
	// Token: 0x020071C8 RID: 29128
	[NullableContext(1)]
	[Nullable(0)]
	public class PathDrivenSplineRuntimeData : IPathDrivenSplineRuntimeData
	{
		// Token: 0x17009DC8 RID: 40392
		// (get) Token: 0x06047491 RID: 291985 RVA: 0x01221BAF File Offset: 0x0121FDAF
		// (set) Token: 0x06047492 RID: 291986 RVA: 0x01221BB7 File Offset: 0x0121FDB7
		public int SplineEntityId { get; set; }

		// Token: 0x17009DC9 RID: 40393
		// (get) Token: 0x06047493 RID: 291987 RVA: 0x01221BC0 File Offset: 0x0121FDC0
		// (set) Token: 0x06047494 RID: 291988 RVA: 0x01221BC8 File Offset: 0x0121FDC8
		public USplineComponent SplineComponent { get; set; }

		// Token: 0x17009DCA RID: 40394
		// (get) Token: 0x06047495 RID: 291989 RVA: 0x01221BD1 File Offset: 0x0121FDD1
		// (set) Token: 0x06047496 RID: 291990 RVA: 0x01221BD9 File Offset: 0x0121FDD9
		public SceneItemMoveComponent.SceneItemSplineMoveAtConstantTimeParam MoveParamTemplate { get; set; }
	}
}
