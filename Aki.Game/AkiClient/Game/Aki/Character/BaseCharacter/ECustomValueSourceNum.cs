using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042AC RID: 17068
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ECustomValueSourceNum.ECustomValueSourceNum")]
	public enum ECustomValueSourceNum : byte
	{
		// Token: 0x04017365 RID: 95077
		固定值,
		// Token: 0x04017366 RID: 95078
		表达式,
		// Token: 0x04017367 RID: 95079
		ECustomValueSourceNum_MAX
	}
}
