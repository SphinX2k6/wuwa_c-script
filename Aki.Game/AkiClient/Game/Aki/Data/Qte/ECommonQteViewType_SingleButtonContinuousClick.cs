using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Qte
{
	// Token: 0x02003ED0 RID: 16080
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Qte/ECommonQteViewType_SingleButtonContinuousClick.ECommonQteViewType_SingleButtonContinuousClick")]
	public enum ECommonQteViewType_SingleButtonContinuousClick : byte
	{
		// Token: 0x04014C69 RID: 85097
		单按钮连击通用界面,
		// Token: 0x04014C6A RID: 85098
		单按钮连击3D界面,
		// Token: 0x04014C6B RID: 85099
		单按钮连击快启动界面,
		// Token: 0x04014C6C RID: 85100
		ECommonQteViewType_MAX
	}
}
