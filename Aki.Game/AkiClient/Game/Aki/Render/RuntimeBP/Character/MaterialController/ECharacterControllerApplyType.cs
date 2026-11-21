using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController
{
	// Token: 0x02003126 RID: 12582
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/MaterialController/ECharacterControllerApplyType.ECharacterControllerApplyType")]
	public enum ECharacterControllerApplyType : byte
	{
		// Token: 0x0401071E RID: 67358
		ModifyProperty,
		// Token: 0x0401071F RID: 67359
		ReplaceMaterial,
		// Token: 0x04010720 RID: 67360
		ReplaceBaseMaterial,
		// Token: 0x04010721 RID: 67361
		ECharacterControllerApplyType_MAX
	}
}
