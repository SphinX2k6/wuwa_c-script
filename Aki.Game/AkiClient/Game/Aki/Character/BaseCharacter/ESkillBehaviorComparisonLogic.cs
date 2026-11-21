using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02003326 RID: 13094
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ESkillBehaviorComparisonLogic.ESkillBehaviorComparisonLogic")]
	public enum ESkillBehaviorComparisonLogic : byte
	{
		// Token: 0x04012145 RID: 74053
		Greater,
		// Token: 0x04012146 RID: 74054
		GreaterEqual,
		// Token: 0x04012147 RID: 74055
		Equal,
		// Token: 0x04012148 RID: 74056
		Less,
		// Token: 0x04012149 RID: 74057
		LessEqual,
		// Token: 0x0401214A RID: 74058
		Range,
		// Token: 0x0401214B RID: 74059
		ESkillBehaviorComparisonLogic_MAX
	}
}
