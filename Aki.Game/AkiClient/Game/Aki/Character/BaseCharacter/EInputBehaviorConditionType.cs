using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02003317 RID: 13079
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EInputBehaviorConditionType.EInputBehaviorConditionType")]
	public enum EInputBehaviorConditionType : byte
	{
		// Token: 0x040120D5 RID: 73941
		按键未按下,
		// Token: 0x040120D6 RID: 73942
		按键按下,
		// Token: 0x040120D7 RID: 73943
		按键抬起,
		// Token: 0x040120D8 RID: 73944
		按键持续按住,
		// Token: 0x040120D9 RID: 73945
		施法者Tag检测,
		// Token: 0x040120DA RID: 73946
		施法者属性检测,
		// Token: 0x040120DB RID: 73947
		是否有技能目标,
		// Token: 0x040120DC RID: 73948
		EInputBehaviorConditionType_MAX
	}
}
