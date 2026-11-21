using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Qte
{
	// Token: 0x02003192 RID: 12690
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Qte/ECommonQteViewType_Drag.ECommonQteViewType_Drag")]
	public enum ECommonQteViewType_Drag : byte
	{
		// Token: 0x04010C37 RID: 68663
		滑动通用界面,
		// Token: 0x04010C38 RID: 68664
		锚定仪界面,
		// Token: 0x04010C39 RID: 68665
		全屏上拉界面,
		// Token: 0x04010C3A RID: 68666
		全屏下拉界面,
		// Token: 0x04010C3B RID: 68667
		罗盘旋转界面,
		// Token: 0x04010C3C RID: 68668
		右半屏拖动界面,
		// Token: 0x04010C3D RID: 68669
		穗穗左右滑界面,
		// Token: 0x04010C3E RID: 68670
		穗穗右滑界面,
		// Token: 0x04010C3F RID: 68671
		穗穗下滑界面,
		// Token: 0x04010C40 RID: 68672
		沙盘滑动界面,
		// Token: 0x04010C41 RID: 68673
		莉莉左滑界面,
		// Token: 0x04010C42 RID: 68674
		ECommonQteViewType_MAX
	}
}
