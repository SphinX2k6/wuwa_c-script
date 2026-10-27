using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042B8 RID: 17080
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EFollowRotateType.EFollowRotateType")]
	public enum EFollowRotateType : byte
	{
		// Token: 0x040173BC RID: 95164
		朝向镜头前一定距离,
		// Token: 0x040173BD RID: 95165
		朝向指定实体,
		// Token: 0x040173BE RID: 95166
		同步指定实体,
		// Token: 0x040173BF RID: 95167
		朝向自身技能目标,
		// Token: 0x040173C0 RID: 95168
		EFollowRotateType_MAX
	}
}
