using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042DB RID: 17115
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ESkillLoadType.ESkillLoadType")]
	public enum ESkillLoadType : byte
	{
		// Token: 0x040174C6 RID: 95430
		AlwaysLoad,
		// Token: 0x040174C7 RID: 95431
		Ignore,
		// Token: 0x040174C8 RID: 95432
		OnlySummonVision,
		// Token: 0x040174C9 RID: 95433
		OnlyShiftVision,
		// Token: 0x040174CA RID: 95434
		ESkillLoadType_MAX
	}
}
