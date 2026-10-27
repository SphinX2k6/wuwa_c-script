using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.Input.Enum
{
	// Token: 0x0200425F RID: 16991
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/Input/Enum/ECommandType.ECommandType")]
	public enum ECommandType : byte
	{
		// Token: 0x0401700F RID: 94223
		None,
		// Token: 0x04017010 RID: 94224
		Skill,
		// Token: 0x04017011 RID: 94225
		Jump,
		// Token: 0x04017012 RID: 94226
		Climb,
		// Token: 0x04017013 RID: 94227
		Sprint,
		// Token: 0x04017014 RID: 94228
		FastSwim,
		// Token: 0x04017015 RID: 94229
		FastClimb,
		// Token: 0x04017016 RID: 94230
		SwitchCharacter,
		// Token: 0x04017017 RID: 94231
		SwitchWalk,
		// Token: 0x04017018 RID: 94232
		SendGameplayEvent,
		// Token: 0x04017019 RID: 94233
		XaBoost,
		// Token: 0x0401701A RID: 94234
		Swallow,
		// Token: 0x0401701B RID: 94235
		Drop,
		// Token: 0x0401701C RID: 94236
		ECommandType_MAX
	}
}
