using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Battle
{
	// Token: 0x02003E38 RID: 15928
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Battle/EWuYinQuState.EWuYinQuState")]
	public enum EWuYinQuState : byte
	{
		// Token: 0x0401451C RID: 83228
		StateIdle,
		// Token: 0x0401451D RID: 83229
		StateFighting1,
		// Token: 0x0401451E RID: 83230
		StateFighting2,
		// Token: 0x0401451F RID: 83231
		StateFighting3,
		// Token: 0x04014520 RID: 83232
		Nothing,
		// Token: 0x04014521 RID: 83233
		EWuYinQuState_MAX
	}
}
