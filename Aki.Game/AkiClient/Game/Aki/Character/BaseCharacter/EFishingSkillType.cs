using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042B6 RID: 17078
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EFishingSkillType.EFishingSkillType")]
	public enum EFishingSkillType : byte
	{
		// Token: 0x040173AF RID: 95151
		传送,
		// Token: 0x040173B0 RID: 95152
		炸鱼,
		// Token: 0x040173B1 RID: 95153
		鱼饵,
		// Token: 0x040173B2 RID: 95154
		驱散幽灵,
		// Token: 0x040173B3 RID: 95155
		EFishingSkillType_MAX
	}
}
