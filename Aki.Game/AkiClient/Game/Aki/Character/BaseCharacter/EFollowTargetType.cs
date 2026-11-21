using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02003312 RID: 13074
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EFollowTargetType.EFollowTargetType")]
	public enum EFollowTargetType : byte
	{
		// Token: 0x040120B3 RID: 73907
		玩家当前控制角色,
		// Token: 0x040120B4 RID: 73908
		伴生物召唤者,
		// Token: 0x040120B5 RID: 73909
		指定实体,
		// Token: 0x040120B6 RID: 73910
		玩家当前载具,
		// Token: 0x040120B7 RID: 73911
		EFollowTargetType_MAX
	}
}
