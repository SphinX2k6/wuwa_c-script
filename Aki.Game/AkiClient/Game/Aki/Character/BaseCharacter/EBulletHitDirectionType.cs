using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02004298 RID: 17048
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EBulletHitDirectionType.EBulletHitDirectionType")]
	public enum EBulletHitDirectionType : byte
	{
		// Token: 0x040172C3 RID: 94915
		以子弹发射者和被击者位置,
		// Token: 0x040172C4 RID: 94916
		以子弹中心和被击者位置,
		// Token: 0x040172C5 RID: 94917
		EBulletHitDirectionType_MAX
	}
}
