using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042AA RID: 17066
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ECustomValueReturn.ECustomValueReturn")]
	public enum ECustomValueReturn : byte
	{
		// Token: 0x04017358 RID: 95064
		数字,
		// Token: 0x04017359 RID: 95065
		向量,
		// Token: 0x0401735A RID: 95066
		旋转,
		// Token: 0x0401735B RID: 95067
		ECustomValueReturn_MAX
	}
}
