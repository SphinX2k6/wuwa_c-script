using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x02003263 RID: 12899
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Core/Fight/EBulletSpecificEffect.EBulletSpecificEffect")]
	public enum EBulletSpecificEffect : byte
	{
		// Token: 0x040115CB RID: 71115
		无,
		// Token: 0x040115CC RID: 71116
		激光末端,
		// Token: 0x040115CD RID: 71117
		激光阻碍,
		// Token: 0x040115CE RID: 71118
		EBulletSpecificEffect_MAX
	}
}
