using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Fight.Struct
{
	// Token: 0x02003F5E RID: 16222
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Fight/Struct/ETagLogicType.ETagLogicType")]
	public enum ETagLogicType : byte
	{
		// Token: 0x040152CB RID: 86731
		All,
		// Token: 0x040152CC RID: 86732
		Any,
		// Token: 0x040152CD RID: 86733
		ETagLogicType_MAX
	}
}
