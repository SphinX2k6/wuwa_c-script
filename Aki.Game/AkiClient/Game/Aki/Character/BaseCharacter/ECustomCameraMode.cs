using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042A9 RID: 17065
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ECustomCameraMode.ECustomCameraMode")]
	public enum ECustomCameraMode : byte
	{
		// Token: 0x04017350 RID: 95056
		LockOn,
		// Token: 0x04017351 RID: 95057
		Sequence,
		// Token: 0x04017352 RID: 95058
		Widget,
		// Token: 0x04017353 RID: 95059
		Scene,
		// Token: 0x04017354 RID: 95060
		Orbital,
		// Token: 0x04017355 RID: 95061
		Free,
		// Token: 0x04017356 RID: 95062
		ECustomCameraMode_MAX
	}
}
