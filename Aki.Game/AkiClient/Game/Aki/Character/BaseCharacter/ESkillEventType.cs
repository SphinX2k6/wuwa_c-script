using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042D9 RID: 17113
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ESkillEventType.ESkillEventType")]
	public enum ESkillEventType : byte
	{
		// Token: 0x040174A7 RID: 95399
		攻击事件,
		// Token: 0x040174A8 RID: 95400
		弃置的功能添加GE现在专用为使用子弹,
		// Token: 0x040174A9 RID: 95401
		ESkillEventType_MAX
	}
}
