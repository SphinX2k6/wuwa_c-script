using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x02004000 RID: 16384
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Core/Fight/EBulletSyncType.EBulletSyncType")]
	public enum EBulletSyncType : byte
	{
		// Token: 0x04015970 RID: 88432
		本地子弹,
		// Token: 0x04015971 RID: 88433
		网络同步子弹,
		// Token: 0x04015972 RID: 88434
		EBulletSyncType_MAX
	}
}
