using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02004290 RID: 17040
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EAttributeOperation.EAttributeOperation")]
	public enum EAttributeOperation : byte
	{
		// Token: 0x04017298 RID: 94872
		加,
		// Token: 0x04017299 RID: 94873
		减,
		// Token: 0x0401729A RID: 94874
		乘,
		// Token: 0x0401729B RID: 94875
		除,
		// Token: 0x0401729C RID: 94876
		赋值,
		// Token: 0x0401729D RID: 94877
		EAttributeOperation_MAX
	}
}
