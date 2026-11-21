using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.SceneItem.Common.Component;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.PathDrivenActorSpawner
{
	// Token: 0x02006280 RID: 25216
	[NullableContext(1)]
	public interface IPathDrivenActorRuntimeData
	{
		// Token: 0x17007322 RID: 29474
		// (get) Token: 0x0603CDA4 RID: 249252
		// (set) Token: 0x0603CDA5 RID: 249253
		Entity OwnerEntity { get; set; }

		// Token: 0x17007323 RID: 29475
		// (get) Token: 0x0603CDA6 RID: 249254
		// (set) Token: 0x0603CDA7 RID: 249255
		AActor Actor { get; set; }

		// Token: 0x17007324 RID: 29476
		// (get) Token: 0x0603CDA8 RID: 249256
		// (set) Token: 0x0603CDA9 RID: 249257
		UKuroSceneItemMoveComponent MoveComponent { get; set; }

		// Token: 0x17007325 RID: 29477
		// (get) Token: 0x0603CDAA RID: 249258
		// (set) Token: 0x0603CDAB RID: 249259
		[Nullable(2)]
		IPathDrivenActorBehavior Behavior { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17007326 RID: 29478
		// (get) Token: 0x0603CDAC RID: 249260
		// (set) Token: 0x0603CDAD RID: 249261
		bool Finished { get; set; }

		// Token: 0x17007327 RID: 29479
		// (get) Token: 0x0603CDAE RID: 249262
		// (set) Token: 0x0603CDAF RID: 249263
		bool PendingRecycle { get; set; }

		// Token: 0x17007328 RID: 29480
		// (get) Token: 0x0603CDB0 RID: 249264
		// (set) Token: 0x0603CDB1 RID: 249265
		int CurrentTrackIndex { get; set; }

		// Token: 0x17007329 RID: 29481
		// (get) Token: 0x0603CDB2 RID: 249266
		// (set) Token: 0x0603CDB3 RID: 249267
		bool? PendingTrackSwitch { get; set; }

		// Token: 0x1700732A RID: 29482
		// (get) Token: 0x0603CDB4 RID: 249268
		// (set) Token: 0x0603CDB5 RID: 249269
		Action<EPathDrivenActorFinishReason> RequestFinish { get; set; }

		// Token: 0x1700732B RID: 29483
		// (get) Token: 0x0603CDB6 RID: 249270
		// (set) Token: 0x0603CDB7 RID: 249271
		Action OnMoveStoppedHandler { get; set; }

		// Token: 0x1700732C RID: 29484
		// (get) Token: 0x0603CDB8 RID: 249272
		// (set) Token: 0x0603CDB9 RID: 249273
		bool? HasStartedMove { get; set; }

		// Token: 0x1700732D RID: 29485
		// (get) Token: 0x0603CDBA RID: 249274
		// (set) Token: 0x0603CDBB RID: 249275
		[Nullable(2)]
		SceneItemMoveComponent.SceneItemSplineMoveAtConstantTimeParam LaunchMoveParam { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
