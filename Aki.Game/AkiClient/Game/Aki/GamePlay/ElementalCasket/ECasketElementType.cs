using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.GamePlay.ElementalCasket
{
	// Token: 0x02003E67 RID: 15975
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/GamePlay/ElementalCasket/ECasketElementType.ECasketElementType")]
	public enum ECasketElementType : byte
	{
		// Token: 0x0401475A RID: 83802
		火,
		// Token: 0x0401475B RID: 83803
		水,
		// Token: 0x0401475C RID: 83804
		木,
		// Token: 0x0401475D RID: 83805
		ECasketElementType_MAX
	}
}
