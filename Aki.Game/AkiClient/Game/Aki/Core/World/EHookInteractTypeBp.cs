using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Core.World
{
	// Token: 0x02003FE5 RID: 16357
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Core/World/EHookInteractTypeBp.EHookInteractTypeBp")]
	public enum EHookInteractTypeBp : byte
	{
		// Token: 0x0401584A RID: 88138
		FixedPointHook,
		// Token: 0x0401584B RID: 88139
		SuiGuangHook,
		// Token: 0x0401584C RID: 88140
		KiteHook,
		// Token: 0x0401584D RID: 88141
		RagDollJumpingPoint,
		// Token: 0x0401584E RID: 88142
		RagDollClimbingPoint,
		// Token: 0x0401584F RID: 88143
		MovementPointHook,
		// Token: 0x04015850 RID: 88144
		SlashHook,
		// Token: 0x04015851 RID: 88145
		LightSlashHook,
		// Token: 0x04015852 RID: 88146
		ChargeSlashHook,
		// Token: 0x04015853 RID: 88147
		CableWayHook,
		// Token: 0x04015854 RID: 88148
		FollowerShoot,
		// Token: 0x04015855 RID: 88149
		MotorPullInteract,
		// Token: 0x04015856 RID: 88150
		SpaceStationEnergyCore,
		// Token: 0x04015857 RID: 88151
		MotorEject,
		// Token: 0x04015858 RID: 88152
		EHookInteractTypeBp_MAX
	}
}
