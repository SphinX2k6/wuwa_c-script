using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02004291 RID: 17041
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EAttributeTarget.EAttributeTarget")]
	public enum EAttributeTarget : byte
	{
		// Token: 0x0401729F RID: 94879
		受击者,
		// Token: 0x040172A0 RID: 94880
		攻击者,
		// Token: 0x040172A1 RID: 94881
		EAttributeTarget_MAX
	}
}
