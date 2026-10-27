using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x02004007 RID: 16391
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Core/Fight/EMoveTrajectory.EMoveTrajectory")]
	public enum EMoveTrajectory : byte
	{
		// Token: 0x040159C2 RID: 88514
		默认,
		// Token: 0x040159C3 RID: 88515
		追踪子弹,
		// Token: 0x040159C4 RID: 88516
		限时命中子弹,
		// Token: 0x040159C5 RID: 88517
		围绕中心旋转,
		// Token: 0x040159C6 RID: 88518
		时间限制抛物线子弹,
		// Token: 0x040159C7 RID: 88519
		角度限制抛物线子弹,
		// Token: 0x040159C8 RID: 88520
		跟随目标,
		// Token: 0x040159C9 RID: 88521
		EMoveTrajectory_MAX
	}
}
