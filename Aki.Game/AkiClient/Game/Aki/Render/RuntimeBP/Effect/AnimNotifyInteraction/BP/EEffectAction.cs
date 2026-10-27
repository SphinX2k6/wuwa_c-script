using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Effect.AnimNotifyInteraction.BP
{
	// Token: 0x02003DE5 RID: 15845
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Effect/AnimNotifyInteraction/BP/EEffectAction.EEffectAction")]
	public enum EEffectAction : byte
	{
		// Token: 0x04013FB9 RID: 81849
		GroundPound,
		// Token: 0x04013FBA RID: 81850
		Shockwave,
		// Token: 0x04013FBB RID: 81851
		Diagonal,
		// Token: 0x04013FBC RID: 81852
		EEffectAction_MAX
	}
}
