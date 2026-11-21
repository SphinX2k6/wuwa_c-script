using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02003319 RID: 13081
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EMorphType.EMorphType")]
	public enum EMorphType : byte
	{
		// Token: 0x040120EA RID: 73962
		默认形态,
		// Token: 0x040120EB RID: 73963
		变身形态,
		// Token: 0x040120EC RID: 73964
		变身形态2,
		// Token: 0x040120ED RID: 73965
		EMorphType_MAX
	}
}
