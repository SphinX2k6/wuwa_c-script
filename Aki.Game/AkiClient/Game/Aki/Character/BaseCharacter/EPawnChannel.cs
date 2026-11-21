using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200331D RID: 13085
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EPawnChannel.EPawnChannel")]
	public enum EPawnChannel : byte
	{
		// Token: 0x040120FD RID: 73981
		All,
		// Token: 0x040120FE RID: 73982
		Pawn,
		// Token: 0x040120FF RID: 73983
		PawnPlayer,
		// Token: 0x04012100 RID: 73984
		PawnMonster,
		// Token: 0x04012101 RID: 73985
		EPawnChannel_MAX
	}
}
