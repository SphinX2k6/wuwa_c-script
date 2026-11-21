using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Qte
{
	// Token: 0x02003194 RID: 12692
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Qte/ECommonQteViewType_SingleButton.ECommonQteViewType_SingleButton")]
	public enum ECommonQteViewType_SingleButton : byte
	{
		// Token: 0x04010C48 RID: 68680
		单按钮通用界面,
		// Token: 0x04010C49 RID: 68681
		单按钮点击3D界面,
		// Token: 0x04010C4A RID: 68682
		聚焦点击按钮,
		// Token: 0x04010C4B RID: 68683
		单按钮无图标快启动界面,
		// Token: 0x04010C4C RID: 68684
		圆环单击界面,
		// Token: 0x04010C4D RID: 68685
		缩圈单击界面,
		// Token: 0x04010C4E RID: 68686
		ECommonQteViewType_MAX
	}
}
