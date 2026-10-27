using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.QuickTimeAction
{
	// Token: 0x02003EAC RID: 16044
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/QuickTimeAction/EQtaTagMatchType.EQtaTagMatchType")]
	public enum EQtaTagMatchType : byte
	{
		// Token: 0x04014B3B RID: 84795
		All,
		// Token: 0x04014B3C RID: 84796
		Any,
		// Token: 0x04014B3D RID: 84797
		EQtaTagMatchType_MAX
	}
}
