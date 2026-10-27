using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.Monster.Common
{
	// Token: 0x0200424E RID: 16974
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/Monster/Common/EAiLevelVarSource.EAiLevelVarSource")]
	public enum EAiLevelVarSource : byte
	{
		// Token: 0x04016F79 RID: 94073
		Global,
		// Token: 0x04016F7A RID: 94074
		SelfEntity,
		// Token: 0x04016F7B RID: 94075
		OtherEntity,
		// Token: 0x04016F7C RID: 94076
		Quest,
		// Token: 0x04016F7D RID: 94077
		LevelPlay,
		// Token: 0x04016F7E RID: 94078
		EAiLevelVarSource_MAX
	}
}
