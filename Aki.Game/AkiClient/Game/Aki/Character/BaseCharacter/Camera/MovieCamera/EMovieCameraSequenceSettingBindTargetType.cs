using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera.MovieCamera
{
	// Token: 0x020033ED RID: 13293
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/MovieCamera/EMovieCameraSequenceSettingBindTargetType.EMovieCameraSequenceSettingBindTargetType")]
	public enum EMovieCameraSequenceSettingBindTargetType : byte
	{
		// Token: 0x0401293A RID: 76090
		绑定到目标身上,
		// Token: 0x0401293B RID: 76091
		根据目标位置放置到世界,
		// Token: 0x0401293C RID: 76092
		放置到世界,
		// Token: 0x0401293D RID: 76093
		EMovieCameraSequenceSettingBindTargetType_MAX
	}
}
