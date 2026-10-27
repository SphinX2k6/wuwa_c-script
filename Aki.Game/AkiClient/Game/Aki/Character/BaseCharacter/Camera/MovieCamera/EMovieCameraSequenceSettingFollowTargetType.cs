using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera.MovieCamera
{
	// Token: 0x020043D8 RID: 17368
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/MovieCamera/EMovieCameraSequenceSettingFollowTargetType.EMovieCameraSequenceSettingFollowTargetType")]
	public enum EMovieCameraSequenceSettingFollowTargetType : byte
	{
		// Token: 0x04017E01 RID: 97793
		俯仰跟随,
		// Token: 0x04017E02 RID: 97794
		偏航跟随,
		// Token: 0x04017E03 RID: 97795
		俯仰_偏航跟随,
		// Token: 0x04017E04 RID: 97796
		EMovieCameraSequenceSettingFollowTargetType_MAX
	}
}
