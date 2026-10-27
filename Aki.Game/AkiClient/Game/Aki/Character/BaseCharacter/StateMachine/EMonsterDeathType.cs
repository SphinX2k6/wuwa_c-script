using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x02004398 RID: 17304
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/EMonsterDeathType.EMonsterDeathType")]
	public enum EMonsterDeathType : byte
	{
		// Token: 0x04017A5A RID: 96858
		地面死亡,
		// Token: 0x04017A5B RID: 96859
		水中死亡,
		// Token: 0x04017A5C RID: 96860
		空中死亡,
		// Token: 0x04017A5D RID: 96861
		EMonsterDeathType_MAX
	}
}
