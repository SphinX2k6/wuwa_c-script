using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.SceneItem.Common.Component;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.PathDrivenActorSpawner
{
	// Token: 0x020071CC RID: 29132
	[NullableContext(1)]
	[Nullable(0)]
	public class PathDrivenActorRuntimeData : IPathDrivenActorRuntimeData
	{
		// Token: 0x17009DD7 RID: 40407
		// (get) Token: 0x060474BA RID: 292026 RVA: 0x01221BEA File Offset: 0x0121FDEA
		// (set) Token: 0x060474BB RID: 292027 RVA: 0x01221BF2 File Offset: 0x0121FDF2
		public Entity OwnerEntity { get; set; }

		// Token: 0x17009DD8 RID: 40408
		// (get) Token: 0x060474BC RID: 292028 RVA: 0x01221BFB File Offset: 0x0121FDFB
		// (set) Token: 0x060474BD RID: 292029 RVA: 0x01221C03 File Offset: 0x0121FE03
		public AActor Actor { get; set; }

		// Token: 0x17009DD9 RID: 40409
		// (get) Token: 0x060474BE RID: 292030 RVA: 0x01221C0C File Offset: 0x0121FE0C
		// (set) Token: 0x060474BF RID: 292031 RVA: 0x01221C14 File Offset: 0x0121FE14
		public UKuroSceneItemMoveComponent MoveComponent { get; set; }

		// Token: 0x17009DDA RID: 40410
		// (get) Token: 0x060474C0 RID: 292032 RVA: 0x01221C1D File Offset: 0x0121FE1D
		// (set) Token: 0x060474C1 RID: 292033 RVA: 0x01221C25 File Offset: 0x0121FE25
		[Nullable(2)]
		public IPathDrivenActorBehavior Behavior { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17009DDB RID: 40411
		// (get) Token: 0x060474C2 RID: 292034 RVA: 0x01221C2E File Offset: 0x0121FE2E
		// (set) Token: 0x060474C3 RID: 292035 RVA: 0x01221C36 File Offset: 0x0121FE36
		public bool Finished { get; set; }

		// Token: 0x17009DDC RID: 40412
		// (get) Token: 0x060474C4 RID: 292036 RVA: 0x01221C3F File Offset: 0x0121FE3F
		// (set) Token: 0x060474C5 RID: 292037 RVA: 0x01221C47 File Offset: 0x0121FE47
		public bool PendingRecycle { get; set; }

		// Token: 0x17009DDD RID: 40413
		// (get) Token: 0x060474C6 RID: 292038 RVA: 0x01221C50 File Offset: 0x0121FE50
		// (set) Token: 0x060474C7 RID: 292039 RVA: 0x01221C58 File Offset: 0x0121FE58
		public int CurrentTrackIndex { get; set; }

		// Token: 0x17009DDE RID: 40414
		// (get) Token: 0x060474C8 RID: 292040 RVA: 0x01221C61 File Offset: 0x0121FE61
		// (set) Token: 0x060474C9 RID: 292041 RVA: 0x01221C69 File Offset: 0x0121FE69
		public bool? PendingTrackSwitch { get; set; }

		// Token: 0x17009DDF RID: 40415
		// (get) Token: 0x060474CA RID: 292042 RVA: 0x01221C72 File Offset: 0x0121FE72
		// (set) Token: 0x060474CB RID: 292043 RVA: 0x01221C7A File Offset: 0x0121FE7A
		public Action<EPathDrivenActorFinishReason> RequestFinish { get; set; }

		// Token: 0x17009DE0 RID: 40416
		// (get) Token: 0x060474CC RID: 292044 RVA: 0x01221C83 File Offset: 0x0121FE83
		// (set) Token: 0x060474CD RID: 292045 RVA: 0x01221C8B File Offset: 0x0121FE8B
		public Action OnMoveStoppedHandler { get; set; }

		// Token: 0x17009DE1 RID: 40417
		// (get) Token: 0x060474CE RID: 292046 RVA: 0x01221C94 File Offset: 0x0121FE94
		// (set) Token: 0x060474CF RID: 292047 RVA: 0x01221C9C File Offset: 0x0121FE9C
		public bool? HasStartedMove { get; set; }

		// Token: 0x17009DE2 RID: 40418
		// (get) Token: 0x060474D0 RID: 292048 RVA: 0x01221CA5 File Offset: 0x0121FEA5
		// (set) Token: 0x060474D1 RID: 292049 RVA: 0x01221CAD File Offset: 0x0121FEAD
		[Nullable(2)]
		public SceneItemMoveComponent.SceneItemSplineMoveAtConstantTimeParam LaunchMoveParam { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
