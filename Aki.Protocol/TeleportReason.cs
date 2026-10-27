using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001660 RID: 5728
	public enum TeleportReason
	{
		// Token: 0x0400C14D RID: 49485
		[OriginalName("Transfer")]
		Transfer,
		// Token: 0x0400C14E RID: 49486
		[OriginalName("ApiTeleport")]
		ApiTeleport,
		// Token: 0x0400C14F RID: 49487
		[OriginalName("BtRollbackFailed")]
		BtRollbackFailed,
		// Token: 0x0400C150 RID: 49488
		[OriginalName("ParkourTrans")]
		ParkourTrans,
		// Token: 0x0400C151 RID: 49489
		[OriginalName("Gm")]
		Gm,
		// Token: 0x0400C152 RID: 49490
		[OriginalName("Rouge")]
		Rouge,
		// Token: 0x0400C153 RID: 49491
		[OriginalName("Fall")]
		Fall,
		// Token: 0x0400C154 RID: 49492
		[OriginalName("Action")]
		Action,
		// Token: 0x0400C155 RID: 49493
		[OriginalName("UnOpenedAreaPullback")]
		UnOpenedAreaPullback,
		// Token: 0x0400C156 RID: 49494
		[OriginalName("TemporaryTransfer")]
		TemporaryTransfer,
		// Token: 0x0400C157 RID: 49495
		[OriginalName("FlowAction")]
		FlowAction,
		// Token: 0x0400C158 RID: 49496
		[OriginalName("Drown")]
		Drown,
		// Token: 0x0400C159 RID: 49497
		[OriginalName("FlowStart")]
		FlowStart,
		// Token: 0x0400C15A RID: 49498
		[OriginalName("CorniceTrans")]
		CorniceTrans,
		// Token: 0x0400C15B RID: 49499
		[OriginalName("TeleportVehicle")]
		TeleportVehicle,
		// Token: 0x0400C15C RID: 49500
		[OriginalName("GetOff")]
		GetOff,
		// Token: 0x0400C15D RID: 49501
		[OriginalName("LeaveGravityRegion")]
		LeaveGravityRegion,
		// Token: 0x0400C15E RID: 49502
		[OriginalName("TeleportToBoat")]
		TeleportToBoat,
		// Token: 0x0400C15F RID: 49503
		[OriginalName("GravityFlip")]
		GravityFlip,
		// Token: 0x0400C160 RID: 49504
		[OriginalName("RogueRes")]
		RogueRes,
		// Token: 0x0400C161 RID: 49505
		[OriginalName("AbyssTeleport")]
		AbyssTeleport,
		// Token: 0x0400C162 RID: 49506
		[OriginalName("GmForce")]
		GmForce,
		// Token: 0x0400C163 RID: 49507
		[OriginalName("CharacterMoveToPoint")]
		CharacterMoveToPoint,
		// Token: 0x0400C164 RID: 49508
		[OriginalName("InstEntity")]
		InstEntity,
		// Token: 0x0400C165 RID: 49509
		[OriginalName("InstRequestTeleportResetPoint")]
		InstRequestTeleportResetPoint,
		// Token: 0x0400C166 RID: 49510
		[OriginalName("StrongWindField")]
		StrongWindField,
		// Token: 0x0400C167 RID: 49511
		[OriginalName("FastReturn")]
		FastReturn,
		// Token: 0x0400C168 RID: 49512
		[OriginalName("RoverRogueRoomInChaos")]
		RoverRogueRoomInChaos,
		// Token: 0x0400C169 RID: 49513
		[OriginalName("RecallInstMark")]
		RecallInstMark
	}
}
