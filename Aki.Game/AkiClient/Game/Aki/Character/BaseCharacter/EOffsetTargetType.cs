using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042C6 RID: 17094
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EOffsetTargetType.EOffsetTargetType")]
	public enum EOffsetTargetType : byte
	{
		// Token: 0x04017417 RID: 95255
		自身,
		// Token: 0x04017418 RID: 95256
		玩家当前角色,
		// Token: 0x04017419 RID: 95257
		EOffsetTargetType_MAX
	}
}
