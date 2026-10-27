using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Render.RuntimeBP.ScreenEffect.Data
{
	// Token: 0x02003AE8 RID: 15080
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/ScreenEffect/Data/E_SE_PlayOrder.E_SE_PlayOrder")]
	public enum E_SE_PlayOrder : byte
	{
		// Token: 0x0400FD84 RID: 64900
		ByOrder,
		// Token: 0x0400FD85 RID: 64901
		Independent,
		// Token: 0x0400FD86 RID: 64902
		E_SE_MAX
	}
}
