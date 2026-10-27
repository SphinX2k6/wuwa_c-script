using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Effect.Billboard
{
	// Token: 0x02003DE4 RID: 15844
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Effect/Billboard/E_BillboardMode.E_BillboardMode")]
	public enum E_BillboardMode : byte
	{
		// Token: 0x04013FB4 RID: 81844
		自由,
		// Token: 0x04013FB5 RID: 81845
		上方向轴,
		// Token: 0x04013FB6 RID: 81846
		右方向轴,
		// Token: 0x04013FB7 RID: 81847
		E_MAX
	}
}
