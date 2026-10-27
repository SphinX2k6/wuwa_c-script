using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.Manager
{
	// Token: 0x02003E28 RID: 15912
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/Manager/ECharacterDitherType.ECharacterDitherType")]
	public enum ECharacterDitherType : byte
	{
		// Token: 0x040143B1 RID: 82865
		UnDefined,
		// Token: 0x040143B2 RID: 82866
		Fight,
		// Token: 0x040143B3 RID: 82867
		Sequence,
		// Token: 0x040143B4 RID: 82868
		Temporary,
		// Token: 0x040143B5 RID: 82869
		CanBePassedThrough,
		// Token: 0x040143B6 RID: 82870
		ECharacterDitherType_MAX
	}
}
