using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020043C0 RID: 17344
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/ESequenceCameraAnsEffectiveClientType.ESequenceCameraAnsEffectiveClientType")]
	public enum ESequenceCameraAnsEffectiveClientType : byte
	{
		// Token: 0x04017C96 RID: 97430
		单客户端,
		// Token: 0x04017C97 RID: 97431
		全客户端,
		// Token: 0x04017C98 RID: 97432
		锁定目标客户端,
		// Token: 0x04017C99 RID: 97433
		仇恨目标客户端,
		// Token: 0x04017C9A RID: 97434
		技能目标客户端,
		// Token: 0x04017C9B RID: 97435
		ESequenceCameraAnsEffectiveClientType_MAX
	}
}
