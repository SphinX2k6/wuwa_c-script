using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Qte
{
	// Token: 0x02003EC9 RID: 16073
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Qte/ECommonQteActionType.ECommonQteActionType")]
	public enum ECommonQteActionType : byte
	{
		// Token: 0x04014C15 RID: 85013
		无,
		// Token: 0x04014C16 RID: 85014
		常规,
		// Token: 0x04014C17 RID: 85015
		载具,
		// Token: 0x04014C18 RID: 85016
		ECommonQteActionType_MAX
	}
}
