using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042CB RID: 17099
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ERelation.ERelation")]
	public enum ERelation : byte
	{
		// Token: 0x04017439 RID: 95289
		None,
		// Token: 0x0401743A RID: 95290
		Friend,
		// Token: 0x0401743B RID: 95291
		Enemy,
		// Token: 0x0401743C RID: 95292
		ERelation_MAX
	}
}
