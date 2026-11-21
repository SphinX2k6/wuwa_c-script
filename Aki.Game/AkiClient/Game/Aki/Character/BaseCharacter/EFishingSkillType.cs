using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200330F RID: 13071
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EFishingSkillType.EFishingSkillType")]
	public enum EFishingSkillType : byte
	{
		// Token: 0x040120A0 RID: 73888
		传送,
		// Token: 0x040120A1 RID: 73889
		炸鱼,
		// Token: 0x040120A2 RID: 73890
		鱼饵,
		// Token: 0x040120A3 RID: 73891
		驱散幽灵,
		// Token: 0x040120A4 RID: 73892
		EFishingSkillType_MAX
	}
}
