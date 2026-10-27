using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Qte
{
	// Token: 0x02003EC8 RID: 16072
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Qte/EBattleQteCustomAction.EBattleQteCustomAction")]
	public enum EBattleQteCustomAction : byte
	{
		// Token: 0x04014C10 RID: 85008
		无,
		// Token: 0x04014C11 RID: 85009
		切换角色,
		// Token: 0x04014C12 RID: 85010
		切换到指定角色,
		// Token: 0x04014C13 RID: 85011
		EBattleQteCustomAction_MAX
	}
}
