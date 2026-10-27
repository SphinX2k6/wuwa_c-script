using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.QuickTimeAction.Customization
{
	// Token: 0x02003EB9 RID: 16057
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/QuickTimeAction/Customization/EQtaCustomizationViewType.EQtaCustomizationViewType")]
	public enum EQtaCustomizationViewType : byte
	{
		// Token: 0x04014B9C RID: 84892
		无界面,
		// Token: 0x04014B9D RID: 84893
		限次长按洛瑟菈技能交互指示器界面,
		// Token: 0x04014B9E RID: 84894
		拍照并收集物品,
		// Token: 0x04014B9F RID: 84895
		打开指定界面,
		// Token: 0x04014BA0 RID: 84896
		EQtaCustomizationViewType_MAX
	}
}
