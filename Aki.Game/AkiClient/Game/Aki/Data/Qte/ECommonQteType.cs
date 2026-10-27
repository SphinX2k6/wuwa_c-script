using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Qte
{
	// Token: 0x02003ECC RID: 16076
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Qte/ECommonQteType.ECommonQteType")]
	public enum ECommonQteType : byte
	{
		// Token: 0x04014C4A RID: 85066
		单按钮点击型,
		// Token: 0x04014C4B RID: 85067
		单按钮连击型,
		// Token: 0x04014C4C RID: 85068
		单按钮滑动型,
		// Token: 0x04014C4D RID: 85069
		单按钮长按型,
		// Token: 0x04014C4E RID: 85070
		多按钮选项型,
		// Token: 0x04014C4F RID: 85071
		ECommonQteType_MAX
	}
}
