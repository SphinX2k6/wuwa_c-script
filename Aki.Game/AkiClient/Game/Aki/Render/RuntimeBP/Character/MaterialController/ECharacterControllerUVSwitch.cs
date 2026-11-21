using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController
{
	// Token: 0x0200312A RID: 12586
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/MaterialController/ECharacterControllerUVSwitch.ECharacterControllerUVSwitch")]
	public enum ECharacterControllerUVSwitch : byte
	{
		// Token: 0x04010741 RID: 67393
		UV1,
		// Token: 0x04010742 RID: 67394
		UV2,
		// Token: 0x04010743 RID: 67395
		UV3,
		// Token: 0x04010744 RID: 67396
		UV4,
		// Token: 0x04010745 RID: 67397
		ScreenUV,
		// Token: 0x04010746 RID: 67398
		ECharacterControllerUVSwitch_0_MAX
	}
}
