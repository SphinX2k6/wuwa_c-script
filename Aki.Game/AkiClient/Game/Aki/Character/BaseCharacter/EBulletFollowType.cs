using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02004297 RID: 17047
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EBulletFollowType.EBulletFollowType")]
	public enum EBulletFollowType : byte
	{
		// Token: 0x040172BC RID: 94908
		跟随骨骼,
		// Token: 0x040172BD RID: 94909
		固定位置,
		// Token: 0x040172BE RID: 94910
		攻击者锁定拉伸,
		// Token: 0x040172BF RID: 94911
		跟随骨骼位置旋转,
		// Token: 0x040172C0 RID: 94912
		跟随父子弹特效骨骼,
		// Token: 0x040172C1 RID: 94913
		EBulletFollowType_MAX
	}
}
