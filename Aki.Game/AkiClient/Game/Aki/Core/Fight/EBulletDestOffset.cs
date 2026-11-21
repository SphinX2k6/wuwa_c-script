using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x0200325E RID: 12894
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Core/Fight/EBulletDestOffset.EBulletDestOffset")]
	public enum EBulletDestOffset : byte
	{
		// Token: 0x040115A5 RID: 71077
		发射者朝向,
		// Token: 0x040115A6 RID: 71078
		目标朝向,
		// Token: 0x040115A7 RID: 71079
		发射者向目标点,
		// Token: 0x040115A8 RID: 71080
		EBulletDestOffset_MAX
	}
}
