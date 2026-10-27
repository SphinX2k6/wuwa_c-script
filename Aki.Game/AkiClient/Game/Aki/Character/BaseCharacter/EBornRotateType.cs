using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02004295 RID: 17045
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EBornRotateType.EBornRotateType")]
	public enum EBornRotateType : byte
	{
		// Token: 0x040172B1 RID: 94897
		保持自身,
		// Token: 0x040172B2 RID: 94898
		同步玩家当前角色,
		// Token: 0x040172B3 RID: 94899
		朝向镜头前一定距离,
		// Token: 0x040172B4 RID: 94900
		EBornRotateType_MAX
	}
}
