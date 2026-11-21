using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using UnrealEngine;

namespace CSharpScript.Game.Module.Teleport
{
	// Token: 0x02003B17 RID: 15127
	[NullableContext(2)]
	public interface ITeleportContext
	{
		// Token: 0x17004F8A RID: 20362
		// (get) Token: 0x06026D8E RID: 159118
		[Nullable(1)]
		string ClientReason { [NullableContext(1)] get; }

		// Token: 0x17004F8B RID: 20363
		// (get) Token: 0x06026D8F RID: 159119
		FVectorDouble TargetPosition { get; }

		// Token: 0x17004F8C RID: 20364
		// (get) Token: 0x06026D90 RID: 159120
		ETeleportMode? TeleportMode { get; }

		// Token: 0x17004F8D RID: 20365
		// (get) Token: 0x06026D91 RID: 159121
		IRotator TargetRotation { get; }

		// Token: 0x17004F8E RID: 20366
		// (get) Token: 0x06026D92 RID: 159122
		IVector TargetGravityDirect { get; }

		// Token: 0x17004F8F RID: 20367
		// (get) Token: 0x06026D93 RID: 159123
		IVector TargetSpeed { get; }

		// Token: 0x17004F90 RID: 20368
		// (get) Token: 0x06026D94 RID: 159124
		TeleportReason? ServerReason { get; }

		// Token: 0x17004F91 RID: 20369
		// (get) Token: 0x06026D95 RID: 159125
		TransitionOptionPb Option { get; }

		// Token: 0x17004F92 RID: 20370
		// (get) Token: 0x06026D96 RID: 159126
		int? TransitionConfigId { get; }

		// Token: 0x17004F93 RID: 20371
		// (get) Token: 0x06026D97 RID: 159127
		bool? NeedRestoreCamera { get; }

		// Token: 0x17004F94 RID: 20372
		// (get) Token: 0x06026D98 RID: 159128
		GameCtxPb GameCtx { get; }

		// Token: 0x17004F95 RID: 20373
		// (get) Token: 0x06026D99 RID: 159129
		Entity ElevatorEntity { get; }

		// Token: 0x17004F96 RID: 20374
		// (get) Token: 0x06026D9A RID: 159130
		bool? DisableAutoFade { get; }

		// Token: 0x17004F97 RID: 20375
		// (get) Token: 0x06026D9B RID: 159131
		int? TeleportCfgId { get; }

		// Token: 0x17004F98 RID: 20376
		// (get) Token: 0x06026D9C RID: 159132
		bool? NeedRequestToServer { get; }

		// Token: 0x17004F99 RID: 20377
		// (get) Token: 0x06026D9D RID: 159133
		bool? NeedWaitStreaming { get; }

		// Token: 0x17004F9A RID: 20378
		// (get) Token: 0x06026D9E RID: 159134
		bool? KeepCameraRelativeRotation { get; }

		// Token: 0x17004F9B RID: 20379
		// (get) Token: 0x06026D9F RID: 159135
		bool? KeepSpeedRelativeRotation { get; }
	}
}
