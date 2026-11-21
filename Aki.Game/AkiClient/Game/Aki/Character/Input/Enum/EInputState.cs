using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.Input.Enum
{
	// Token: 0x020032D4 RID: 13012
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/Input/Enum/EInputState.EInputState")]
	public enum EInputState : byte
	{
		// Token: 0x04011DD5 RID: 73173
		None,
		// Token: 0x04011DD6 RID: 73174
		Press,
		// Token: 0x04011DD7 RID: 73175
		Release,
		// Token: 0x04011DD8 RID: 73176
		Hold,
		// Token: 0x04011DD9 RID: 73177
		EInputState_MAX
	}
}
