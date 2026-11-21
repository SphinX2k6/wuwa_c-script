using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Qte
{
	// Token: 0x02003191 RID: 12689
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Qte/ECommonQteType.ECommonQteType")]
	public enum ECommonQteType : byte
	{
		// Token: 0x04010C30 RID: 68656
		单按钮点击型,
		// Token: 0x04010C31 RID: 68657
		单按钮连击型,
		// Token: 0x04010C32 RID: 68658
		单按钮滑动型,
		// Token: 0x04010C33 RID: 68659
		单按钮长按型,
		// Token: 0x04010C34 RID: 68660
		多按钮选项型,
		// Token: 0x04010C35 RID: 68661
		ECommonQteType_MAX
	}
}
