using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042DD RID: 17117
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ESkillOverrideType.ESkillOverrideType")]
	public enum ESkillOverrideType : byte
	{
		// Token: 0x040174D1 RID: 95441
		默认,
		// Token: 0x040174D2 RID: 95442
		覆盖受击,
		// Token: 0x040174D3 RID: 95443
		覆盖弹反,
		// Token: 0x040174D4 RID: 95444
		覆盖破弱,
		// Token: 0x040174D5 RID: 95445
		顶级,
		// Token: 0x040174D6 RID: 95446
		ESkillOverrideType_MAX
	}
}
