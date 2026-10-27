using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042E6 RID: 17126
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EVelocityCurveType.EVelocityCurveType")]
	public enum EVelocityCurveType : byte
	{
		// Token: 0x0401750B RID: 95499
		None,
		// Token: 0x0401750C RID: 95500
		Convex,
		// Token: 0x0401750D RID: 95501
		LinearityDown,
		// Token: 0x0401750E RID: 95502
		Concave,
		// Token: 0x0401750F RID: 95503
		EVelocityCurveType_MAX
	}
}
