using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02003305 RID: 13061
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ECustomValueSourceNum.ECustomValueSourceNum")]
	public enum ECustomValueSourceNum : byte
	{
		// Token: 0x04012056 RID: 73814
		固定值,
		// Token: 0x04012057 RID: 73815
		表达式,
		// Token: 0x04012058 RID: 73816
		ECustomValueSourceNum_MAX
	}
}
