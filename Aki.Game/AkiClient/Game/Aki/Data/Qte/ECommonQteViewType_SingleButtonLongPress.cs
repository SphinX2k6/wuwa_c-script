using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Qte
{
	// Token: 0x02003196 RID: 12694
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Qte/ECommonQteViewType_SingleButtonLongPress.ECommonQteViewType_SingleButtonLongPress")]
	public enum ECommonQteViewType_SingleButtonLongPress : byte
	{
		// Token: 0x04010C55 RID: 68693
		单按钮长按通用界面,
		// Token: 0x04010C56 RID: 68694
		单按钮长按3D界面,
		// Token: 0x04010C57 RID: 68695
		单按钮全屏长按界面,
		// Token: 0x04010C58 RID: 68696
		单按钮长按无图标快启动界面,
		// Token: 0x04010C59 RID: 68697
		沙盘圆盘长按按钮,
		// Token: 0x04010C5A RID: 68698
		ECommonQteViewType_MAX
	}
}
