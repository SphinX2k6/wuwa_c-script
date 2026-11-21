using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.Monster.Common
{
	// Token: 0x020032C6 RID: 12998
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/Monster/Common/EAiLevelVarSource.EAiLevelVarSource")]
	public enum EAiLevelVarSource : byte
	{
		// Token: 0x04011D57 RID: 73047
		Global,
		// Token: 0x04011D58 RID: 73048
		SelfEntity,
		// Token: 0x04011D59 RID: 73049
		OtherEntity,
		// Token: 0x04011D5A RID: 73050
		Quest,
		// Token: 0x04011D5B RID: 73051
		LevelPlay,
		// Token: 0x04011D5C RID: 73052
		EAiLevelVarSource_MAX
	}
}
