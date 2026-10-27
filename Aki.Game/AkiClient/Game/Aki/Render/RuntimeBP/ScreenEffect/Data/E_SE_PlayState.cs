using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Render.RuntimeBP.ScreenEffect.Data
{
	// Token: 0x02003AE9 RID: 15081
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/ScreenEffect/Data/E_SE_PlayState.E_SE_PlayState")]
	public enum E_SE_PlayState : byte
	{
		// Token: 0x0400FD88 RID: 64904
		Start,
		// Token: 0x0400FD89 RID: 64905
		Lop,
		// Token: 0x0400FD8A RID: 64906
		End,
		// Token: 0x0400FD8B RID: 64907
		Over,
		// Token: 0x0400FD8C RID: 64908
		E_SE_MAX
	}
}
