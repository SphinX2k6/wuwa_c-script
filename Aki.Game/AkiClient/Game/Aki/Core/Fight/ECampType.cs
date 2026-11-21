using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x02003266 RID: 12902
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Core/Fight/ECampType.ECampType")]
	public enum ECampType : byte
	{
		// Token: 0x040115E3 RID: 71139
		不生效,
		// Token: 0x040115E4 RID: 71140
		对自己,
		// Token: 0x040115E5 RID: 71141
		对敌方,
		// Token: 0x040115E6 RID: 71142
		对友方,
		// Token: 0x040115E7 RID: 71143
		对自己和友方,
		// Token: 0x040115E8 RID: 71144
		对自己和敌方,
		// Token: 0x040115E9 RID: 71145
		全部,
		// Token: 0x040115EA RID: 71146
		ECampType_MAX
	}
}
