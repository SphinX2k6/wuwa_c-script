using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020016DC RID: 5852
	public enum TeleportReason
	{
		// Token: 0x0400C676 RID: 50806
		[OriginalName("Transfer")]
		Transfer,
		// Token: 0x0400C677 RID: 50807
		[OriginalName("ApiTeleport")]
		ApiTeleport,
		// Token: 0x0400C678 RID: 50808
		[OriginalName("BtRollbackFailed")]
		BtRollbackFailed,
		// Token: 0x0400C679 RID: 50809
		[OriginalName("ParkourTrans")]
		ParkourTrans,
		// Token: 0x0400C67A RID: 50810
		[OriginalName("Gm")]
		Gm,
		// Token: 0x0400C67B RID: 50811
		[OriginalName("Rouge")]
		Rouge,
		// Token: 0x0400C67C RID: 50812
		[OriginalName("Fall")]
		Fall,
		// Token: 0x0400C67D RID: 50813
		[OriginalName("Action")]
		Action,
		// Token: 0x0400C67E RID: 50814
		[OriginalName("UnOpenedAreaPullback")]
		UnOpenedAreaPullback,
		// Token: 0x0400C67F RID: 50815
		[OriginalName("TemporaryTransfer")]
		TemporaryTransfer,
		// Token: 0x0400C680 RID: 50816
		[OriginalName("FlowAction")]
		FlowAction,
		// Token: 0x0400C681 RID: 50817
		[OriginalName("Drown")]
		Drown,
		// Token: 0x0400C682 RID: 50818
		[OriginalName("FlowStart")]
		FlowStart,
		// Token: 0x0400C683 RID: 50819
		[OriginalName("CorniceTrans")]
		CorniceTrans,
		// Token: 0x0400C684 RID: 50820
		[OriginalName("TeleportVehicle")]
		TeleportVehicle,
		// Token: 0x0400C685 RID: 50821
		[OriginalName("GetOff")]
		GetOff,
		// Token: 0x0400C686 RID: 50822
		[OriginalName("LeaveGravityRegion")]
		LeaveGravityRegion,
		// Token: 0x0400C687 RID: 50823
		[OriginalName("TeleportToBoat")]
		TeleportToBoat,
		// Token: 0x0400C688 RID: 50824
		[OriginalName("GravityFlip")]
		GravityFlip,
		// Token: 0x0400C689 RID: 50825
		[OriginalName("RogueRes")]
		RogueRes,
		// Token: 0x0400C68A RID: 50826
		[OriginalName("AbyssTeleport")]
		AbyssTeleport,
		// Token: 0x0400C68B RID: 50827
		[OriginalName("GmForce")]
		GmForce,
		// Token: 0x0400C68C RID: 50828
		[OriginalName("CharacterMoveToPoint")]
		CharacterMoveToPoint,
		// Token: 0x0400C68D RID: 50829
		[OriginalName("InstEntity")]
		InstEntity,
		// Token: 0x0400C68E RID: 50830
		[OriginalName("InstRequestTeleportResetPoint")]
		InstRequestTeleportResetPoint,
		// Token: 0x0400C68F RID: 50831
		[OriginalName("StrongWindField")]
		StrongWindField,
		// Token: 0x0400C690 RID: 50832
		[OriginalName("FastReturn")]
		FastReturn,
		// Token: 0x0400C691 RID: 50833
		[OriginalName("RoverRogueRoomInChaos")]
		RoverRogueRoomInChaos,
		// Token: 0x0400C692 RID: 50834
		[OriginalName("RecallInstMark")]
		RecallInstMark
	}
}
