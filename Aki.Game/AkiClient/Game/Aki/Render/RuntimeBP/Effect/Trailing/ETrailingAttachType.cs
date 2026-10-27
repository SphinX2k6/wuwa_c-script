using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Effect.Trailing
{
	// Token: 0x02003DBE RID: 15806
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Effect/Trailing/ETrailingAttachType.ETrailingAttachType")]
	public enum ETrailingAttachType : byte
	{
		// Token: 0x04013D46 RID: 81222
		Actors,
		// Token: 0x04013D47 RID: 81223
		Bones,
		// Token: 0x04013D48 RID: 81224
		Transforms,
		// Token: 0x04013D49 RID: 81225
		ETrailingAttachType_MAX
	}
}
