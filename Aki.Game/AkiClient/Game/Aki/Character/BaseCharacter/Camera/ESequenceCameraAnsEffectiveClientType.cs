using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020033DB RID: 13275
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/ESequenceCameraAnsEffectiveClientType.ESequenceCameraAnsEffectiveClientType")]
	public enum ESequenceCameraAnsEffectiveClientType : byte
	{
		// Token: 0x040127FE RID: 75774
		单客户端,
		// Token: 0x040127FF RID: 75775
		全客户端,
		// Token: 0x04012800 RID: 75776
		锁定目标客户端,
		// Token: 0x04012801 RID: 75777
		仇恨目标客户端,
		// Token: 0x04012802 RID: 75778
		技能目标客户端,
		// Token: 0x04012803 RID: 75779
		ESequenceCameraAnsEffectiveClientType_MAX
	}
}
