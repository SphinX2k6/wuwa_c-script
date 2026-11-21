using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Effect.AnimNotifyInteraction.BP
{
	// Token: 0x02003116 RID: 12566
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Effect/AnimNotifyInteraction/BP/EEffectAction.EEffectAction")]
	public enum EEffectAction : byte
	{
		// Token: 0x040105AC RID: 66988
		GroundPound,
		// Token: 0x040105AD RID: 66989
		Shockwave,
		// Token: 0x040105AE RID: 66990
		Diagonal,
		// Token: 0x040105AF RID: 66991
		EEffectAction_MAX
	}
}
