using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController
{
	// Token: 0x02003E0E RID: 15886
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/MaterialController/ECharacterControllerApplyType.ECharacterControllerApplyType")]
	public enum ECharacterControllerApplyType : byte
	{
		// Token: 0x04014273 RID: 82547
		ModifyProperty,
		// Token: 0x04014274 RID: 82548
		ReplaceMaterial,
		// Token: 0x04014275 RID: 82549
		ReplaceBaseMaterial,
		// Token: 0x04014276 RID: 82550
		ECharacterControllerApplyType_MAX
	}
}
