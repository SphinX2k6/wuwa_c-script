using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x0200326D RID: 12909
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Core/Fight/ESceneBattleInteractEntityType.ESceneBattleInteractEntityType")]
	public enum ESceneBattleInteractEntityType : byte
	{
		// Token: 0x0401163B RID: 71227
		Player,
		// Token: 0x0401163C RID: 71228
		Summoned,
		// Token: 0x0401163D RID: 71229
		Monster,
		// Token: 0x0401163E RID: 71230
		Weapon,
		// Token: 0x0401163F RID: 71231
		ESceneBattleInteractEntityType_MAX
	}
}
