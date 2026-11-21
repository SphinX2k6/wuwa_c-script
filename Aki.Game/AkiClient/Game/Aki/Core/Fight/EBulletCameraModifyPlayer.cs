using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x0200325C RID: 12892
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Core/Fight/EBulletCameraModifyPlayer.EBulletCameraModifyPlayer")]
	public enum EBulletCameraModifyPlayer : byte
	{
		// Token: 0x04011598 RID: 71064
		Attacker,
		// Token: 0x04011599 RID: 71065
		Victim,
		// Token: 0x0401159A RID: 71066
		AttackerAndVictim,
		// Token: 0x0401159B RID: 71067
		EBulletCameraModifyPlayer_MAX
	}
}
