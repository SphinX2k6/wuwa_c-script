using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020033BE RID: 13246
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/EAimAssistMode.EAimAssistMode")]
	public enum EAimAssistMode : byte
	{
		// Token: 0x0401260B RID: 75275
		Closed,
		// Token: 0x0401260C RID: 75276
		OpenOnStart,
		// Token: 0x0401260D RID: 75277
		FullyOpen,
		// Token: 0x0401260E RID: 75278
		EAimAssistMode_MAX
	}
}
