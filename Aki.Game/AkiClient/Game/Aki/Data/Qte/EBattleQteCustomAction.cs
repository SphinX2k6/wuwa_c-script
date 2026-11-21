using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Qte
{
	// Token: 0x0200318D RID: 12685
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Qte/EBattleQteCustomAction.EBattleQteCustomAction")]
	public enum EBattleQteCustomAction : byte
	{
		// Token: 0x04010BF6 RID: 68598
		无,
		// Token: 0x04010BF7 RID: 68599
		切换角色,
		// Token: 0x04010BF8 RID: 68600
		切换到指定角色,
		// Token: 0x04010BF9 RID: 68601
		EBattleQteCustomAction_MAX
	}
}
