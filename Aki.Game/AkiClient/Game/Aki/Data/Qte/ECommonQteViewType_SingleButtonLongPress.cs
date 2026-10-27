using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Qte
{
	// Token: 0x02003ED1 RID: 16081
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Qte/ECommonQteViewType_SingleButtonLongPress.ECommonQteViewType_SingleButtonLongPress")]
	public enum ECommonQteViewType_SingleButtonLongPress : byte
	{
		// Token: 0x04014C6E RID: 85102
		单按钮长按通用界面,
		// Token: 0x04014C6F RID: 85103
		单按钮长按3D界面,
		// Token: 0x04014C70 RID: 85104
		单按钮全屏长按界面,
		// Token: 0x04014C71 RID: 85105
		单按钮长按无图标快启动界面,
		// Token: 0x04014C72 RID: 85106
		沙盘圆盘长按按钮,
		// Token: 0x04014C73 RID: 85107
		ECommonQteViewType_MAX
	}
}
