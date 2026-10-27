using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042D8 RID: 17112
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ESkillEffectType.ESkillEffectType")]
	public enum ESkillEffectType : byte
	{
		// Token: 0x040174A2 RID: 95394
		None,
		// Token: 0x040174A3 RID: 95395
		EndEffect,
		// Token: 0x040174A4 RID: 95396
		DestroyEffect,
		// Token: 0x040174A5 RID: 95397
		ESkillEffectType_MAX
	}
}
