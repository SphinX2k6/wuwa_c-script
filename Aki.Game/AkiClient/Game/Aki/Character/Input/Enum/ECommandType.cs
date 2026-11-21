using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.Input.Enum
{
	// Token: 0x020032D1 RID: 13009
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/Input/Enum/ECommandType.ECommandType")]
	public enum ECommandType : byte
	{
		// Token: 0x04011DAD RID: 73133
		None,
		// Token: 0x04011DAE RID: 73134
		Skill,
		// Token: 0x04011DAF RID: 73135
		Jump,
		// Token: 0x04011DB0 RID: 73136
		Climb,
		// Token: 0x04011DB1 RID: 73137
		Sprint,
		// Token: 0x04011DB2 RID: 73138
		FastSwim,
		// Token: 0x04011DB3 RID: 73139
		FastClimb,
		// Token: 0x04011DB4 RID: 73140
		SwitchCharacter,
		// Token: 0x04011DB5 RID: 73141
		SwitchWalk,
		// Token: 0x04011DB6 RID: 73142
		SendGameplayEvent,
		// Token: 0x04011DB7 RID: 73143
		XaBoost,
		// Token: 0x04011DB8 RID: 73144
		Swallow,
		// Token: 0x04011DB9 RID: 73145
		Drop,
		// Token: 0x04011DBA RID: 73146
		ECommandType_MAX
	}
}
