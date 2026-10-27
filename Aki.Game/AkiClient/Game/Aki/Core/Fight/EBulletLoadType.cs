using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x02003FFD RID: 16381
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Core/Fight/EBulletLoadType.EBulletLoadType")]
	public enum EBulletLoadType : byte
	{
		// Token: 0x04015961 RID: 88417
		通用,
		// Token: 0x04015962 RID: 88418
		肉鸽,
		// Token: 0x04015963 RID: 88419
		EBulletLoadType_MAX
	}
}
