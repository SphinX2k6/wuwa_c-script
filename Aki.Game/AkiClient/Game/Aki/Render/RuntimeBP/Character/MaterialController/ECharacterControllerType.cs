using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController
{
	// Token: 0x02003129 RID: 12585
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/MaterialController/ECharacterControllerType.ECharacterControllerType")]
	public enum ECharacterControllerType : byte
	{
		// Token: 0x0401073C RID: 67388
		Timeline,
		// Token: 0x0401073D RID: 67389
		Runtime,
		// Token: 0x0401073E RID: 67390
		Manual,
		// Token: 0x0401073F RID: 67391
		ECharacterControllerType_MAX
	}
}
