using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x02004009 RID: 16393
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Core/Fight/ESceneBattleInteractEntityType.ESceneBattleInteractEntityType")]
	public enum ESceneBattleInteractEntityType : byte
	{
		// Token: 0x040159DA RID: 88538
		Player,
		// Token: 0x040159DB RID: 88539
		Summoned,
		// Token: 0x040159DC RID: 88540
		Monster,
		// Token: 0x040159DD RID: 88541
		Weapon,
		// Token: 0x040159DE RID: 88542
		ESceneBattleInteractEntityType_MAX
	}
}
