using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200332F RID: 13103
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ESkillOverrideType.ESkillOverrideType")]
	public enum ESkillOverrideType : byte
	{
		// Token: 0x04012193 RID: 74131
		默认,
		// Token: 0x04012194 RID: 74132
		覆盖受击,
		// Token: 0x04012195 RID: 74133
		覆盖弹反,
		// Token: 0x04012196 RID: 74134
		覆盖破弱,
		// Token: 0x04012197 RID: 74135
		顶级,
		// Token: 0x04012198 RID: 74136
		ESkillOverrideType_MAX
	}
}
