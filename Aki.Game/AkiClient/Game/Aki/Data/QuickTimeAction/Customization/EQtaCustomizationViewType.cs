using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.QuickTimeAction.Customization
{
	// Token: 0x02003185 RID: 12677
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/QuickTimeAction/Customization/EQtaCustomizationViewType.EQtaCustomizationViewType")]
	public enum EQtaCustomizationViewType : byte
	{
		// Token: 0x04010BC1 RID: 68545
		无界面,
		// Token: 0x04010BC2 RID: 68546
		限次长按洛瑟菈技能交互指示器界面,
		// Token: 0x04010BC3 RID: 68547
		拍照并收集物品,
		// Token: 0x04010BC4 RID: 68548
		打开指定界面,
		// Token: 0x04010BC5 RID: 68549
		EQtaCustomizationViewType_MAX
	}
}
