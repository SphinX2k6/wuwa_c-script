using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020032F4 RID: 13044
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EBulletHitDirectionType.EBulletHitDirectionType")]
	public enum EBulletHitDirectionType : byte
	{
		// Token: 0x04011FC5 RID: 73669
		以子弹发射者和被击者位置,
		// Token: 0x04011FC6 RID: 73670
		以子弹中心和被击者位置,
		// Token: 0x04011FC7 RID: 73671
		EBulletHitDirectionType_MAX
	}
}
