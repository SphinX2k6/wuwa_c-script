using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x02003FFF RID: 16383
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Core/Fight/EBulletSpecificEffect.EBulletSpecificEffect")]
	public enum EBulletSpecificEffect : byte
	{
		// Token: 0x0401596B RID: 88427
		无,
		// Token: 0x0401596C RID: 88428
		激光末端,
		// Token: 0x0401596D RID: 88429
		激光阻碍,
		// Token: 0x0401596E RID: 88430
		EBulletSpecificEffect_MAX
	}
}
