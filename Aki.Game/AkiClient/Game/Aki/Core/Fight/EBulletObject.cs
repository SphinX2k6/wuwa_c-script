using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x02003FFE RID: 16382
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Core/Fight/EBulletObject.EBulletObject")]
	public enum EBulletObject : byte
	{
		// Token: 0x04015965 RID: 88421
		空,
		// Token: 0x04015966 RID: 88422
		攻击者,
		// Token: 0x04015967 RID: 88423
		受击者,
		// Token: 0x04015968 RID: 88424
		执行GB的子弹,
		// Token: 0x04015969 RID: 88425
		EBulletObject_MAX
	}
}
