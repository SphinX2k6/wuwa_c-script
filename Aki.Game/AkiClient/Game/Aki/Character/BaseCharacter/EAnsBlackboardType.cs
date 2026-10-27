using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200428A RID: 17034
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EAnsBlackboardType.EAnsBlackboardType")]
	public enum EAnsBlackboardType : byte
	{
		// Token: 0x04017278 RID: 94840
		Direct,
		// Token: 0x04017279 RID: 94841
		Location,
		// Token: 0x0401727A RID: 94842
		EntityId,
		// Token: 0x0401727B RID: 94843
		Int,
		// Token: 0x0401727C RID: 94844
		EAnsBlackboardType_MAX
	}
}
