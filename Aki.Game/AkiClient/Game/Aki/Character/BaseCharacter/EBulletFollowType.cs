using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020032F3 RID: 13043
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EBulletFollowType.EBulletFollowType")]
	public enum EBulletFollowType : byte
	{
		// Token: 0x04011FBE RID: 73662
		跟随骨骼,
		// Token: 0x04011FBF RID: 73663
		固定位置,
		// Token: 0x04011FC0 RID: 73664
		攻击者锁定拉伸,
		// Token: 0x04011FC1 RID: 73665
		跟随骨骼位置旋转,
		// Token: 0x04011FC2 RID: 73666
		跟随父子弹特效骨骼,
		// Token: 0x04011FC3 RID: 73667
		EBulletFollowType_MAX
	}
}
