using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x02003FF6 RID: 16374
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Core/Fight/EBulletCameraModifyPlayer.EBulletCameraModifyPlayer")]
	public enum EBulletCameraModifyPlayer : byte
	{
		// Token: 0x04015930 RID: 88368
		Attacker,
		// Token: 0x04015931 RID: 88369
		Victim,
		// Token: 0x04015932 RID: 88370
		AttackerAndVictim,
		// Token: 0x04015933 RID: 88371
		EBulletCameraModifyPlayer_MAX
	}
}
