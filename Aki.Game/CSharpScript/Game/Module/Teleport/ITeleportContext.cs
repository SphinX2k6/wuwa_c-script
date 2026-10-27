using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using UnrealEngine;

namespace CSharpScript.Game.Module.Teleport
{
	// Token: 0x02004B6D RID: 19309
	[NullableContext(2)]
	public interface ITeleportContext
	{
		// Token: 0x17007BDD RID: 31709
		// (get) Token: 0x06031FF8 RID: 204792
		[Nullable(1)]
		string ClientReason { [NullableContext(1)] get; }

		// Token: 0x17007BDE RID: 31710
		// (get) Token: 0x06031FF9 RID: 204793
		FVectorDouble TargetPosition { get; }

		// Token: 0x17007BDF RID: 31711
		// (get) Token: 0x06031FFA RID: 204794
		ETeleportMode? TeleportMode { get; }

		// Token: 0x17007BE0 RID: 31712
		// (get) Token: 0x06031FFB RID: 204795
		IRotator TargetRotation { get; }

		// Token: 0x17007BE1 RID: 31713
		// (get) Token: 0x06031FFC RID: 204796
		IVector TargetGravityDirect { get; }

		// Token: 0x17007BE2 RID: 31714
		// (get) Token: 0x06031FFD RID: 204797
		IVector TargetSpeed { get; }

		// Token: 0x17007BE3 RID: 31715
		// (get) Token: 0x06031FFE RID: 204798
		TeleportReason? ServerReason { get; }

		// Token: 0x17007BE4 RID: 31716
		// (get) Token: 0x06031FFF RID: 204799
		TransitionOptionPb Option { get; }

		// Token: 0x17007BE5 RID: 31717
		// (get) Token: 0x06032000 RID: 204800
		int? TransitionConfigId { get; }

		// Token: 0x17007BE6 RID: 31718
		// (get) Token: 0x06032001 RID: 204801
		bool? NeedRestoreCamera { get; }

		// Token: 0x17007BE7 RID: 31719
		// (get) Token: 0x06032002 RID: 204802
		GameCtxPb GameCtx { get; }

		// Token: 0x17007BE8 RID: 31720
		// (get) Token: 0x06032003 RID: 204803
		Entity ElevatorEntity { get; }

		// Token: 0x17007BE9 RID: 31721
		// (get) Token: 0x06032004 RID: 204804
		bool? DisableAutoFade { get; }

		// Token: 0x17007BEA RID: 31722
		// (get) Token: 0x06032005 RID: 204805
		int? TeleportCfgId { get; }

		// Token: 0x17007BEB RID: 31723
		// (get) Token: 0x06032006 RID: 204806
		bool? NeedRequestToServer { get; }

		// Token: 0x17007BEC RID: 31724
		// (get) Token: 0x06032007 RID: 204807
		bool? NeedWaitStreaming { get; }

		// Token: 0x17007BED RID: 31725
		// (get) Token: 0x06032008 RID: 204808
		bool? KeepCameraRelativeRotation { get; }

		// Token: 0x17007BEE RID: 31726
		// (get) Token: 0x06032009 RID: 204809
		bool? KeepSpeedRelativeRotation { get; }

		// Token: 0x17007BEF RID: 31727
		// (get) Token: 0x0603200A RID: 204810
		bool? UseCameraCutForMotionBlur { get; }
	}
}
