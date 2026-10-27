using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042C7 RID: 17095
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EPawnChannel.EPawnChannel")]
	public enum EPawnChannel : byte
	{
		// Token: 0x0401741B RID: 95259
		All,
		// Token: 0x0401741C RID: 95260
		Pawn,
		// Token: 0x0401741D RID: 95261
		PawnPlayer,
		// Token: 0x0401741E RID: 95262
		PawnMonster,
		// Token: 0x0401741F RID: 95263
		EPawnChannel_MAX
	}
}
