using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02004296 RID: 17046
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EBulletDestoryType.EBulletDestoryType")]
	public enum EBulletDestoryType : byte
	{
		// Token: 0x040172B6 RID: 94902
		子弹时间销毁特效,
		// Token: 0x040172B7 RID: 94903
		子弹碰撞障碍销毁特效,
		// Token: 0x040172B8 RID: 94904
		子弹碰撞单位销毁特效,
		// Token: 0x040172B9 RID: 94905
		子弹打断销毁特效,
		// Token: 0x040172BA RID: 94906
		EBulletDestoryType_MAX
	}
}
