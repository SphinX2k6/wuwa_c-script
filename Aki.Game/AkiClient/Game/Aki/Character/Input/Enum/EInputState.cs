using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.Input.Enum
{
	// Token: 0x02004262 RID: 16994
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/Input/Enum/EInputState.EInputState")]
	public enum EInputState : byte
	{
		// Token: 0x0401703D RID: 94269
		None,
		// Token: 0x0401703E RID: 94270
		Press,
		// Token: 0x0401703F RID: 94271
		Release,
		// Token: 0x04017040 RID: 94272
		Hold,
		// Token: 0x04017041 RID: 94273
		EInputState_MAX
	}
}
