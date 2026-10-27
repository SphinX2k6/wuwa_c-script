using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Role.Enum
{
	// Token: 0x02003EA3 RID: 16035
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Role/Enum/EKeyBehaviorType.EKeyBehaviorType")]
	public enum EKeyBehaviorType : byte
	{
		// Token: 0x04014B01 RID: 84737
		None,
		// Token: 0x04014B02 RID: 84738
		按下,
		// Token: 0x04014B03 RID: 84739
		抬起,
		// Token: 0x04014B04 RID: 84740
		长按,
		// Token: 0x04014B05 RID: 84741
		EKeyBehaviorType_MAX
	}
}
