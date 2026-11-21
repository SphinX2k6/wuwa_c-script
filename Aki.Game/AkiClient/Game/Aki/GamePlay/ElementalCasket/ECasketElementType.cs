using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.GamePlay.ElementalCasket
{
	// Token: 0x02003156 RID: 12630
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/GamePlay/ElementalCasket/ECasketElementType.ECasketElementType")]
	public enum ECasketElementType : byte
	{
		// Token: 0x040109BB RID: 68027
		火,
		// Token: 0x040109BC RID: 68028
		水,
		// Token: 0x040109BD RID: 68029
		木,
		// Token: 0x040109BE RID: 68030
		ECasketElementType_MAX
	}
}
