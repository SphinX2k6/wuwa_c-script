using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x02003262 RID: 12898
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Core/Fight/EBulletObject.EBulletObject")]
	public enum EBulletObject : byte
	{
		// Token: 0x040115C5 RID: 71109
		空,
		// Token: 0x040115C6 RID: 71110
		攻击者,
		// Token: 0x040115C7 RID: 71111
		受击者,
		// Token: 0x040115C8 RID: 71112
		执行GB的子弹,
		// Token: 0x040115C9 RID: 71113
		EBulletObject_MAX
	}
}
