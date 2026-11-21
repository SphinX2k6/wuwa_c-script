using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02003321 RID: 13089
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ERelation.ERelation")]
	public enum ERelation : byte
	{
		// Token: 0x0401211B RID: 74011
		None,
		// Token: 0x0401211C RID: 74012
		Friend,
		// Token: 0x0401211D RID: 74013
		Enemy,
		// Token: 0x0401211E RID: 74014
		ERelation_MAX
	}
}
