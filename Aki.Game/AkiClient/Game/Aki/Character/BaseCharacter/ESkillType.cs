using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042E1 RID: 17121
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ESkillType.ESkillType")]
	public enum ESkillType : byte
	{
		// Token: 0x040174EF RID: 95471
		限定次数技能,
		// Token: 0x040174F0 RID: 95472
		多段技能,
		// Token: 0x040174F1 RID: 95473
		共享次数技能,
		// Token: 0x040174F2 RID: 95474
		ESkillType_MAX
	}
}
