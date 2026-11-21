using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.QuickTimeAction.Customization
{
	// Token: 0x02003186 RID: 12678
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/QuickTimeAction/Customization/EQtaCustomization_ProgressResetType.EQtaCustomization_ProgressResetType")]
	public enum EQtaCustomization_ProgressResetType : byte
	{
		// Token: 0x04010BC7 RID: 68551
		停止,
		// Token: 0x04010BC8 RID: 68552
		重置,
		// Token: 0x04010BC9 RID: 68553
		倒转,
		// Token: 0x04010BCA RID: 68554
		结束,
		// Token: 0x04010BCB RID: 68555
		EQtaCustomization_MAX
	}
}
