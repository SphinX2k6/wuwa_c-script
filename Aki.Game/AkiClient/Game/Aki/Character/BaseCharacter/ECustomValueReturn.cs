using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02003304 RID: 13060
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ECustomValueReturn.ECustomValueReturn")]
	public enum ECustomValueReturn : byte
	{
		// Token: 0x04012051 RID: 73809
		数字,
		// Token: 0x04012052 RID: 73810
		向量,
		// Token: 0x04012053 RID: 73811
		旋转,
		// Token: 0x04012054 RID: 73812
		ECustomValueReturn_MAX
	}
}
