using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042B9 RID: 17081
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EFollowTargetType.EFollowTargetType")]
	public enum EFollowTargetType : byte
	{
		// Token: 0x040173C2 RID: 95170
		玩家当前控制角色,
		// Token: 0x040173C3 RID: 95171
		伴生物召唤者,
		// Token: 0x040173C4 RID: 95172
		指定实体,
		// Token: 0x040173C5 RID: 95173
		玩家当前载具,
		// Token: 0x040173C6 RID: 95174
		EFollowTargetType_MAX
	}
}
