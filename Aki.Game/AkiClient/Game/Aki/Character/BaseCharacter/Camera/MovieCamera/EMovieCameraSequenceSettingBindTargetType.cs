using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera.MovieCamera
{
	// Token: 0x020043D7 RID: 17367
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/MovieCamera/EMovieCameraSequenceSettingBindTargetType.EMovieCameraSequenceSettingBindTargetType")]
	public enum EMovieCameraSequenceSettingBindTargetType : byte
	{
		// Token: 0x04017DFC RID: 97788
		绑定到目标身上,
		// Token: 0x04017DFD RID: 97789
		根据目标位置放置到世界,
		// Token: 0x04017DFE RID: 97790
		放置到世界,
		// Token: 0x04017DFF RID: 97791
		EMovieCameraSequenceSettingBindTargetType_MAX
	}
}
