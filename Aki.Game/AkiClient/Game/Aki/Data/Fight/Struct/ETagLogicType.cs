using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Fight.Struct
{
	// Token: 0x02003200 RID: 12800
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Fight/Struct/ETagLogicType.ETagLogicType")]
	public enum ETagLogicType : byte
	{
		// Token: 0x040111CA RID: 70090
		All,
		// Token: 0x040111CB RID: 70091
		Any,
		// Token: 0x040111CC RID: 70092
		ETagLogicType_MAX
	}
}
