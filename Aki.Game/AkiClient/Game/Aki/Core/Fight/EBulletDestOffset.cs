using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x02003FF9 RID: 16377
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Core/Fight/EBulletDestOffset.EBulletDestOffset")]
	public enum EBulletDestOffset : byte
	{
		// Token: 0x04015942 RID: 88386
		发射者朝向,
		// Token: 0x04015943 RID: 88387
		目标朝向,
		// Token: 0x04015944 RID: 88388
		发射者向目标点,
		// Token: 0x04015945 RID: 88389
		EBulletDestOffset_MAX
	}
}
