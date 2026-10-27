using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Qte
{
	// Token: 0x02003ECE RID: 16078
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Qte/ECommonQteViewType_SelectOption.ECommonQteViewType_SelectOption")]
	public enum ECommonQteViewType_SelectOption : byte
	{
		// Token: 0x04014C5D RID: 85085
		一体式单选界面,
		// Token: 0x04014C5E RID: 85086
		分体式单选界面,
		// Token: 0x04014C5F RID: 85087
		ECommonQteViewType_MAX
	}
}
