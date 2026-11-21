using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x020033B8 RID: 13240
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/EMonsterDeathType.EMonsterDeathType")]
	public enum EMonsterDeathType : byte
	{
		// Token: 0x040125D5 RID: 75221
		地面死亡,
		// Token: 0x040125D6 RID: 75222
		水中死亡,
		// Token: 0x040125D7 RID: 75223
		空中死亡,
		// Token: 0x040125D8 RID: 75224
		EMonsterDeathType_MAX
	}
}
