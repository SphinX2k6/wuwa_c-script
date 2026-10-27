using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Qte
{
	// Token: 0x02003ECF RID: 16079
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Qte/ECommonQteViewType_SingleButton.ECommonQteViewType_SingleButton")]
	public enum ECommonQteViewType_SingleButton : byte
	{
		// Token: 0x04014C61 RID: 85089
		单按钮通用界面,
		// Token: 0x04014C62 RID: 85090
		单按钮点击3D界面,
		// Token: 0x04014C63 RID: 85091
		聚焦点击按钮,
		// Token: 0x04014C64 RID: 85092
		单按钮无图标快启动界面,
		// Token: 0x04014C65 RID: 85093
		圆环单击界面,
		// Token: 0x04014C66 RID: 85094
		缩圈单击界面,
		// Token: 0x04014C67 RID: 85095
		ECommonQteViewType_MAX
	}
}
