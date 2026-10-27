using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042A5 RID: 17061
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ECommonAxis.ECommonAxis")]
	public enum ECommonAxis : byte
	{
		// Token: 0x0401733A RID: 95034
		X,
		// Token: 0x0401733B RID: 95035
		Y,
		// Token: 0x0401733C RID: 95036
		Z,
		// Token: 0x0401733D RID: 95037
		ECommonAxis_MAX
	}
}
