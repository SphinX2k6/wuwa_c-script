using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02003311 RID: 13073
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EFollowRotateType.EFollowRotateType")]
	public enum EFollowRotateType : byte
	{
		// Token: 0x040120AD RID: 73901
		朝向镜头前一定距离,
		// Token: 0x040120AE RID: 73902
		朝向指定实体,
		// Token: 0x040120AF RID: 73903
		同步指定实体,
		// Token: 0x040120B0 RID: 73904
		朝向自身技能目标,
		// Token: 0x040120B1 RID: 73905
		EFollowRotateType_MAX
	}
}
