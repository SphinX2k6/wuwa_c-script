using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Core.World
{
	// Token: 0x02003253 RID: 12883
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Core/World/EHookInteractTypeBp.EHookInteractTypeBp")]
	public enum EHookInteractTypeBp : byte
	{
		// Token: 0x0401152E RID: 70958
		FixedPointHook,
		// Token: 0x0401152F RID: 70959
		SuiGuangHook,
		// Token: 0x04011530 RID: 70960
		KiteHook,
		// Token: 0x04011531 RID: 70961
		RagDollJumpingPoint,
		// Token: 0x04011532 RID: 70962
		RagDollClimbingPoint,
		// Token: 0x04011533 RID: 70963
		MovementPointHook,
		// Token: 0x04011534 RID: 70964
		SlashHook,
		// Token: 0x04011535 RID: 70965
		LightSlashHook,
		// Token: 0x04011536 RID: 70966
		ChargeSlashHook,
		// Token: 0x04011537 RID: 70967
		CableWayHook,
		// Token: 0x04011538 RID: 70968
		FollowerShoot,
		// Token: 0x04011539 RID: 70969
		MotorPullInteract,
		// Token: 0x0401153A RID: 70970
		SpaceStationEnergyCore,
		// Token: 0x0401153B RID: 70971
		MotorEject,
		// Token: 0x0401153C RID: 70972
		EHookInteractTypeBp_MAX
	}
}
