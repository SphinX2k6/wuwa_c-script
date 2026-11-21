using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.SceneItem.Common.Component;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.PathDrivenActorSpawner
{
	// Token: 0x02006281 RID: 25217
	[NullableContext(1)]
	[Nullable(0)]
	public class PathDrivenActorRuntimeData : IPathDrivenActorRuntimeData
	{
		// Token: 0x1700732E RID: 29486
		// (get) Token: 0x0603CDBC RID: 249276 RVA: 0x0117BA21 File Offset: 0x01179C21
		// (set) Token: 0x0603CDBD RID: 249277 RVA: 0x0117BA29 File Offset: 0x01179C29
		public Entity OwnerEntity { get; set; }

		// Token: 0x1700732F RID: 29487
		// (get) Token: 0x0603CDBE RID: 249278 RVA: 0x0117BA32 File Offset: 0x01179C32
		// (set) Token: 0x0603CDBF RID: 249279 RVA: 0x0117BA3A File Offset: 0x01179C3A
		public AActor Actor { get; set; }

		// Token: 0x17007330 RID: 29488
		// (get) Token: 0x0603CDC0 RID: 249280 RVA: 0x0117BA43 File Offset: 0x01179C43
		// (set) Token: 0x0603CDC1 RID: 249281 RVA: 0x0117BA4B File Offset: 0x01179C4B
		public UKuroSceneItemMoveComponent MoveComponent { get; set; }

		// Token: 0x17007331 RID: 29489
		// (get) Token: 0x0603CDC2 RID: 249282 RVA: 0x0117BA54 File Offset: 0x01179C54
		// (set) Token: 0x0603CDC3 RID: 249283 RVA: 0x0117BA5C File Offset: 0x01179C5C
		[Nullable(2)]
		public IPathDrivenActorBehavior Behavior { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17007332 RID: 29490
		// (get) Token: 0x0603CDC4 RID: 249284 RVA: 0x0117BA65 File Offset: 0x01179C65
		// (set) Token: 0x0603CDC5 RID: 249285 RVA: 0x0117BA6D File Offset: 0x01179C6D
		public bool Finished { get; set; }

		// Token: 0x17007333 RID: 29491
		// (get) Token: 0x0603CDC6 RID: 249286 RVA: 0x0117BA76 File Offset: 0x01179C76
		// (set) Token: 0x0603CDC7 RID: 249287 RVA: 0x0117BA7E File Offset: 0x01179C7E
		public bool PendingRecycle { get; set; }

		// Token: 0x17007334 RID: 29492
		// (get) Token: 0x0603CDC8 RID: 249288 RVA: 0x0117BA87 File Offset: 0x01179C87
		// (set) Token: 0x0603CDC9 RID: 249289 RVA: 0x0117BA8F File Offset: 0x01179C8F
		public int CurrentTrackIndex { get; set; }

		// Token: 0x17007335 RID: 29493
		// (get) Token: 0x0603CDCA RID: 249290 RVA: 0x0117BA98 File Offset: 0x01179C98
		// (set) Token: 0x0603CDCB RID: 249291 RVA: 0x0117BAA0 File Offset: 0x01179CA0
		public bool? PendingTrackSwitch { get; set; }

		// Token: 0x17007336 RID: 29494
		// (get) Token: 0x0603CDCC RID: 249292 RVA: 0x0117BAA9 File Offset: 0x01179CA9
		// (set) Token: 0x0603CDCD RID: 249293 RVA: 0x0117BAB1 File Offset: 0x01179CB1
		public Action<EPathDrivenActorFinishReason> RequestFinish { get; set; }

		// Token: 0x17007337 RID: 29495
		// (get) Token: 0x0603CDCE RID: 249294 RVA: 0x0117BABA File Offset: 0x01179CBA
		// (set) Token: 0x0603CDCF RID: 249295 RVA: 0x0117BAC2 File Offset: 0x01179CC2
		public Action OnMoveStoppedHandler { get; set; }

		// Token: 0x17007338 RID: 29496
		// (get) Token: 0x0603CDD0 RID: 249296 RVA: 0x0117BACB File Offset: 0x01179CCB
		// (set) Token: 0x0603CDD1 RID: 249297 RVA: 0x0117BAD3 File Offset: 0x01179CD3
		public bool? HasStartedMove { get; set; }

		// Token: 0x17007339 RID: 29497
		// (get) Token: 0x0603CDD2 RID: 249298 RVA: 0x0117BADC File Offset: 0x01179CDC
		// (set) Token: 0x0603CDD3 RID: 249299 RVA: 0x0117BAE4 File Offset: 0x01179CE4
		[Nullable(2)]
		public SceneItemMoveComponent.SceneItemSplineMoveAtConstantTimeParam LaunchMoveParam { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
