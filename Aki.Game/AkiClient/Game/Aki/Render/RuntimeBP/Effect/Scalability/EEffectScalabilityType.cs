using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Effect.Scalability
{
	// Token: 0x02003DD0 RID: 15824
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Effect/Scalability/EEffectScalabilityType.EEffectScalabilityType")]
	public enum EEffectScalabilityType : byte
	{
		// Token: 0x04013E9E RID: 81566
		None,
		// Token: 0x04013E9F RID: 81567
		Pad,
		// Token: 0x04013EA0 RID: 81568
		Desktop,
		// Token: 0x04013EA1 RID: 81569
		EEffectScalabilityType_MAX
	}
}
