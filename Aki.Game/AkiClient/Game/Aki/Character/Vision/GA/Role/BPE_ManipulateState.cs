using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.Vision.GA.Role
{
	// Token: 0x0200402E RID: 16430
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/Vision/GA/Role/BPE_ManipulateState.BPE_ManipulateState")]
	public enum BPE_ManipulateState : byte
	{
		// Token: 0x04015B8F RID: 88975
		无,
		// Token: 0x04015B90 RID: 88976
		选取控物,
		// Token: 0x04015B91 RID: 88977
		吸取读条中,
		// Token: 0x04015B92 RID: 88978
		吸取飞行中,
		// Token: 0x04015B93 RID: 88979
		控物中,
		// Token: 0x04015B94 RID: 88980
		投掷物体,
		// Token: 0x04015B95 RID: 88981
		BPE_MAX
	}
}
