using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Effect.Scalability
{
	// Token: 0x0200310B RID: 12555
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Effect/Scalability/EEffectScalabilityType.EEffectScalabilityType")]
	public enum EEffectScalabilityType : byte
	{
		// Token: 0x04010510 RID: 66832
		None,
		// Token: 0x04010511 RID: 66833
		Pad,
		// Token: 0x04010512 RID: 66834
		Desktop,
		// Token: 0x04010513 RID: 66835
		EEffectScalabilityType_MAX
	}
}
