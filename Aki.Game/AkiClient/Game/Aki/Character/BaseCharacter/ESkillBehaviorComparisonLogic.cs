using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042D1 RID: 17105
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ESkillBehaviorComparisonLogic.ESkillBehaviorComparisonLogic")]
	public enum ESkillBehaviorComparisonLogic : byte
	{
		// Token: 0x04017468 RID: 95336
		Greater,
		// Token: 0x04017469 RID: 95337
		GreaterEqual,
		// Token: 0x0401746A RID: 95338
		Equal,
		// Token: 0x0401746B RID: 95339
		Less,
		// Token: 0x0401746C RID: 95340
		LessEqual,
		// Token: 0x0401746D RID: 95341
		Range,
		// Token: 0x0401746E RID: 95342
		ESkillBehaviorComparisonLogic_MAX
	}
}
