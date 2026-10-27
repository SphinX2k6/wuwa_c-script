using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController
{
	// Token: 0x02003E12 RID: 15890
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/MaterialController/ECharacterControllerUVSwitch.ECharacterControllerUVSwitch")]
	public enum ECharacterControllerUVSwitch : byte
	{
		// Token: 0x04014296 RID: 82582
		UV1,
		// Token: 0x04014297 RID: 82583
		UV2,
		// Token: 0x04014298 RID: 82584
		UV3,
		// Token: 0x04014299 RID: 82585
		UV4,
		// Token: 0x0401429A RID: 82586
		ScreenUV,
		// Token: 0x0401429B RID: 82587
		ECharacterControllerUVSwitch_0_MAX
	}
}
