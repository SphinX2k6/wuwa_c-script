using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x0200326B RID: 12907
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Core/Fight/EMoveTrajectory.EMoveTrajectory")]
	public enum EMoveTrajectory : byte
	{
		// Token: 0x04011623 RID: 71203
		默认,
		// Token: 0x04011624 RID: 71204
		追踪子弹,
		// Token: 0x04011625 RID: 71205
		限时命中子弹,
		// Token: 0x04011626 RID: 71206
		围绕中心旋转,
		// Token: 0x04011627 RID: 71207
		时间限制抛物线子弹,
		// Token: 0x04011628 RID: 71208
		角度限制抛物线子弹,
		// Token: 0x04011629 RID: 71209
		跟随目标,
		// Token: 0x0401162A RID: 71210
		EMoveTrajectory_MAX
	}
}
