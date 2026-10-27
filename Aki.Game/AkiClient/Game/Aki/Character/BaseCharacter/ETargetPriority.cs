using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042E5 RID: 17125
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ETargetPriority.ETargetPriority")]
	public enum ETargetPriority : byte
	{
		// Token: 0x04017506 RID: 95494
		主控优先,
		// Token: 0x04017507 RID: 95495
		距离优先,
		// Token: 0x04017508 RID: 95496
		随机,
		// Token: 0x04017509 RID: 95497
		ETargetPriority_MAX
	}
}
