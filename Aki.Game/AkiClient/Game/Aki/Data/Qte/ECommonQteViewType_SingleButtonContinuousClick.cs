using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Qte
{
	// Token: 0x02003195 RID: 12693
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Qte/ECommonQteViewType_SingleButtonContinuousClick.ECommonQteViewType_SingleButtonContinuousClick")]
	public enum ECommonQteViewType_SingleButtonContinuousClick : byte
	{
		// Token: 0x04010C50 RID: 68688
		单按钮连击通用界面,
		// Token: 0x04010C51 RID: 68689
		单按钮连击3D界面,
		// Token: 0x04010C52 RID: 68690
		单按钮连击快启动界面,
		// Token: 0x04010C53 RID: 68691
		ECommonQteViewType_MAX
	}
}
