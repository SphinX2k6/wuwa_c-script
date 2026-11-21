using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Render.RuntimeBP.ScreenEffect.Data
{
	// Token: 0x020030B2 RID: 12466
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/ScreenEffect/Data/E_SE_PlayState.E_SE_PlayState")]
	public enum E_SE_PlayState : byte
	{
		// Token: 0x0400FD15 RID: 64789
		Start,
		// Token: 0x0400FD16 RID: 64790
		Lop,
		// Token: 0x0400FD17 RID: 64791
		End,
		// Token: 0x0400FD18 RID: 64792
		Over,
		// Token: 0x0400FD19 RID: 64793
		E_SE_MAX
	}
}
