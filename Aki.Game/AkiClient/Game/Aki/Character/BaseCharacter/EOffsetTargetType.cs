using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200331C RID: 13084
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EOffsetTargetType.EOffsetTargetType")]
	public enum EOffsetTargetType : byte
	{
		// Token: 0x040120F9 RID: 73977
		自身,
		// Token: 0x040120FA RID: 73978
		玩家当前角色,
		// Token: 0x040120FB RID: 73979
		EOffsetTargetType_MAX
	}
}
