using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController
{
	// Token: 0x02003E11 RID: 15889
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/MaterialController/ECharacterControllerType.ECharacterControllerType")]
	public enum ECharacterControllerType : byte
	{
		// Token: 0x04014291 RID: 82577
		Timeline,
		// Token: 0x04014292 RID: 82578
		Runtime,
		// Token: 0x04014293 RID: 82579
		Manual,
		// Token: 0x04014294 RID: 82580
		ECharacterControllerType_MAX
	}
}
