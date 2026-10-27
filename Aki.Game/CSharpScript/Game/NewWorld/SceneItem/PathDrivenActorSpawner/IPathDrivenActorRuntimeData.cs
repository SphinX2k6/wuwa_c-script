using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.SceneItem.Common.Component;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.PathDrivenActorSpawner
{
	// Token: 0x020071CB RID: 29131
	[NullableContext(1)]
	public interface IPathDrivenActorRuntimeData
	{
		// Token: 0x17009DCB RID: 40395
		// (get) Token: 0x060474A2 RID: 292002
		// (set) Token: 0x060474A3 RID: 292003
		Entity OwnerEntity { get; set; }

		// Token: 0x17009DCC RID: 40396
		// (get) Token: 0x060474A4 RID: 292004
		// (set) Token: 0x060474A5 RID: 292005
		AActor Actor { get; set; }

		// Token: 0x17009DCD RID: 40397
		// (get) Token: 0x060474A6 RID: 292006
		// (set) Token: 0x060474A7 RID: 292007
		UKuroSceneItemMoveComponent MoveComponent { get; set; }

		// Token: 0x17009DCE RID: 40398
		// (get) Token: 0x060474A8 RID: 292008
		// (set) Token: 0x060474A9 RID: 292009
		[Nullable(2)]
		IPathDrivenActorBehavior Behavior { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17009DCF RID: 40399
		// (get) Token: 0x060474AA RID: 292010
		// (set) Token: 0x060474AB RID: 292011
		bool Finished { get; set; }

		// Token: 0x17009DD0 RID: 40400
		// (get) Token: 0x060474AC RID: 292012
		// (set) Token: 0x060474AD RID: 292013
		bool PendingRecycle { get; set; }

		// Token: 0x17009DD1 RID: 40401
		// (get) Token: 0x060474AE RID: 292014
		// (set) Token: 0x060474AF RID: 292015
		int CurrentTrackIndex { get; set; }

		// Token: 0x17009DD2 RID: 40402
		// (get) Token: 0x060474B0 RID: 292016
		// (set) Token: 0x060474B1 RID: 292017
		bool? PendingTrackSwitch { get; set; }

		// Token: 0x17009DD3 RID: 40403
		// (get) Token: 0x060474B2 RID: 292018
		// (set) Token: 0x060474B3 RID: 292019
		Action<EPathDrivenActorFinishReason> RequestFinish { get; set; }

		// Token: 0x17009DD4 RID: 40404
		// (get) Token: 0x060474B4 RID: 292020
		// (set) Token: 0x060474B5 RID: 292021
		Action OnMoveStoppedHandler { get; set; }

		// Token: 0x17009DD5 RID: 40405
		// (get) Token: 0x060474B6 RID: 292022
		// (set) Token: 0x060474B7 RID: 292023
		bool? HasStartedMove { get; set; }

		// Token: 0x17009DD6 RID: 40406
		// (get) Token: 0x060474B8 RID: 292024
		// (set) Token: 0x060474B9 RID: 292025
		[Nullable(2)]
		SceneItemMoveComponent.SceneItemSplineMoveAtConstantTimeParam LaunchMoveParam { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
