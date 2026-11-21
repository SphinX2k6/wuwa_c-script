using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02003303 RID: 13059
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ECustomCameraMode.ECustomCameraMode")]
	public enum ECustomCameraMode : byte
	{
		// Token: 0x04012049 RID: 73801
		LockOn,
		// Token: 0x0401204A RID: 73802
		Sequence,
		// Token: 0x0401204B RID: 73803
		Widget,
		// Token: 0x0401204C RID: 73804
		Scene,
		// Token: 0x0401204D RID: 73805
		Orbital,
		// Token: 0x0401204E RID: 73806
		Free,
		// Token: 0x0401204F RID: 73807
		ECustomCameraMode_MAX
	}
}
