using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x02003268 RID: 12904
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Core/Fight/EHitActorType.EHitActorType")]
	public enum EHitActorType : byte
	{
		// Token: 0x04011603 RID: 71171
		全部,
		// Token: 0x04011604 RID: 71172
		Character,
		// Token: 0x04011605 RID: 71173
		子弹,
		// Token: 0x04011606 RID: 71174
		场景物件,
		// Token: 0x04011607 RID: 71175
		障碍物,
		// Token: 0x04011608 RID: 71176
		EHitActorType_MAX
	}
}
