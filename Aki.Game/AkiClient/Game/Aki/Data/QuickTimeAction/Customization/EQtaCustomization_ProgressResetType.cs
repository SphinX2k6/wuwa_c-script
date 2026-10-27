using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.QuickTimeAction.Customization
{
	// Token: 0x02003EBA RID: 16058
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/QuickTimeAction/Customization/EQtaCustomization_ProgressResetType.EQtaCustomization_ProgressResetType")]
	public enum EQtaCustomization_ProgressResetType : byte
	{
		// Token: 0x04014BA2 RID: 84898
		停止,
		// Token: 0x04014BA3 RID: 84899
		重置,
		// Token: 0x04014BA4 RID: 84900
		倒转,
		// Token: 0x04014BA5 RID: 84901
		结束,
		// Token: 0x04014BA6 RID: 84902
		EQtaCustomization_MAX
	}
}
