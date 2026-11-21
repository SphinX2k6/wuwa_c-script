using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02003316 RID: 13078
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EInputBehaviorActionType.EInputBehaviorActionType")]
	public enum EInputBehaviorActionType : byte
	{
		// Token: 0x040120D0 RID: 73936
		播放蒙太奇,
		// Token: 0x040120D1 RID: 73937
		Tag增删,
		// Token: 0x040120D2 RID: 73938
		结束技能,
		// Token: 0x040120D3 RID: 73939
		EInputBehaviorActionType_MAX
	}
}
