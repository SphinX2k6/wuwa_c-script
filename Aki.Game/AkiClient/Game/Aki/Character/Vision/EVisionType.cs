using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.Vision
{
	// Token: 0x02003287 RID: 12935
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/Vision/EVisionType.EVisionType")]
	public enum EVisionType : byte
	{
		// Token: 0x04011789 RID: 71561
		召唤,
		// Token: 0x0401178A RID: 71562
		变身,
		// Token: 0x0401178B RID: 71563
		探索,
		// Token: 0x0401178C RID: 71564
		操控,
		// Token: 0x0401178D RID: 71565
		驻场,
		// Token: 0x0401178E RID: 71566
		BossRush,
		// Token: 0x0401178F RID: 71567
		新探索,
		// Token: 0x04011790 RID: 71568
		EVisionType_MAX
	}
}
