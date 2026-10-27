using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Qte
{
	// Token: 0x02003ECD RID: 16077
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Qte/ECommonQteViewType_Drag.ECommonQteViewType_Drag")]
	public enum ECommonQteViewType_Drag : byte
	{
		// Token: 0x04014C51 RID: 85073
		滑动通用界面,
		// Token: 0x04014C52 RID: 85074
		锚定仪界面,
		// Token: 0x04014C53 RID: 85075
		全屏上拉界面,
		// Token: 0x04014C54 RID: 85076
		全屏下拉界面,
		// Token: 0x04014C55 RID: 85077
		罗盘旋转界面,
		// Token: 0x04014C56 RID: 85078
		右半屏拖动界面,
		// Token: 0x04014C57 RID: 85079
		穗穗左右滑界面,
		// Token: 0x04014C58 RID: 85080
		穗穗右滑界面,
		// Token: 0x04014C59 RID: 85081
		穗穗下滑界面,
		// Token: 0x04014C5A RID: 85082
		沙盘滑动界面,
		// Token: 0x04014C5B RID: 85083
		ECommonQteViewType_MAX
	}
}
