using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x02003FF8 RID: 16376
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Core/Fight/EBUlletChose.EBulletChose")]
	public enum EBulletChose : byte
	{
		// Token: 0x0401593D RID: 88381
		受重力加速度影响,
		// Token: 0x0401593E RID: 88382
		反弹和滑落,
		// Token: 0x0401593F RID: 88383
		遇到障碍物停止运动,
		// Token: 0x04015940 RID: 88384
		EBulletChose_MAX
	}
}
