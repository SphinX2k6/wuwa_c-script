using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Qte
{
	// Token: 0x0200318E RID: 12686
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Qte/ECommonQteActionType.ECommonQteActionType")]
	public enum ECommonQteActionType : byte
	{
		// Token: 0x04010BFB RID: 68603
		无,
		// Token: 0x04010BFC RID: 68604
		常规,
		// Token: 0x04010BFD RID: 68605
		载具,
		// Token: 0x04010BFE RID: 68606
		ECommonQteActionType_MAX
	}
}
