using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020043A0 RID: 17312
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/EAimAssistMode.EAimAssistMode")]
	public enum EAimAssistMode : byte
	{
		// Token: 0x04017A99 RID: 96921
		Closed,
		// Token: 0x04017A9A RID: 96922
		OpenOnStart,
		// Token: 0x04017A9B RID: 96923
		FullyOpen,
		// Token: 0x04017A9C RID: 96924
		EAimAssistMode_MAX
	}
}
