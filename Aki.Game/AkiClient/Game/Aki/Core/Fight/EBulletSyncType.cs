using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x02003264 RID: 12900
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Core/Fight/EBulletSyncType.EBulletSyncType")]
	public enum EBulletSyncType : byte
	{
		// Token: 0x040115D0 RID: 71120
		本地子弹,
		// Token: 0x040115D1 RID: 71121
		网络同步子弹,
		// Token: 0x040115D2 RID: 71122
		EBulletSyncType_MAX
	}
}
