using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02003332 RID: 13106
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ETargetPriority.ETargetPriority")]
	public enum ETargetPriority : byte
	{
		// Token: 0x040121AC RID: 74156
		主控优先,
		// Token: 0x040121AD RID: 74157
		距离优先,
		// Token: 0x040121AE RID: 74158
		随机,
		// Token: 0x040121AF RID: 74159
		ETargetPriority_MAX
	}
}
