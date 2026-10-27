using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042BF RID: 17087
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EMorphType.EMorphType")]
	public enum EMorphType : byte
	{
		// Token: 0x040173EC RID: 95212
		默认形态,
		// Token: 0x040173ED RID: 95213
		变身形态,
		// Token: 0x040173EE RID: 95214
		变身形态2,
		// Token: 0x040173EF RID: 95215
		EMorphType_MAX
	}
}
