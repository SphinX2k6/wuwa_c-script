using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02003333 RID: 13107
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EVelocityCurveType.EVelocityCurveType")]
	public enum EVelocityCurveType : byte
	{
		// Token: 0x040121B1 RID: 74161
		None,
		// Token: 0x040121B2 RID: 74162
		Convex,
		// Token: 0x040121B3 RID: 74163
		LinearityDown,
		// Token: 0x040121B4 RID: 74164
		Concave,
		// Token: 0x040121B5 RID: 74165
		EVelocityCurveType_MAX
	}
}
