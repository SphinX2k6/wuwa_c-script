using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200428F RID: 17039
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EAttributeEffectType.EAttributeEffectType")]
	public enum EAttributeEffectType : byte
	{
		// Token: 0x04017293 RID: 94867
		伤害,
		// Token: 0x04017294 RID: 94868
		加血,
		// Token: 0x04017295 RID: 94869
		修改属性,
		// Token: 0x04017296 RID: 94870
		EAttributeEffectType_MAX
	}
}
