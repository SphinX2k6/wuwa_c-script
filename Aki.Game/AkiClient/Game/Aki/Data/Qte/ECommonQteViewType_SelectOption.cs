using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Qte
{
	// Token: 0x02003193 RID: 12691
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Qte/ECommonQteViewType_SelectOption.ECommonQteViewType_SelectOption")]
	public enum ECommonQteViewType_SelectOption : byte
	{
		// Token: 0x04010C44 RID: 68676
		一体式单选界面,
		// Token: 0x04010C45 RID: 68677
		分体式单选界面,
		// Token: 0x04010C46 RID: 68678
		ECommonQteViewType_MAX
	}
}
