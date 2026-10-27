using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042A8 RID: 17064
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ECurveType.ECurveType")]
	public enum ECurveType : byte
	{
		// Token: 0x0401734B RID: 95051
		FootState,
		// Token: 0x0401734C RID: 95052
		EnableFootIK_R,
		// Token: 0x0401734D RID: 95053
		RootPos,
		// Token: 0x0401734E RID: 95054
		ECurveType_MAX
	}
}
