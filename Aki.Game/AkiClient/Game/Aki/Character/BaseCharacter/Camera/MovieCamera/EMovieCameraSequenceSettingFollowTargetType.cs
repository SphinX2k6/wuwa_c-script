using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera.MovieCamera
{
	// Token: 0x020033EE RID: 13294
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/MovieCamera/EMovieCameraSequenceSettingFollowTargetType.EMovieCameraSequenceSettingFollowTargetType")]
	public enum EMovieCameraSequenceSettingFollowTargetType : byte
	{
		// Token: 0x0401293F RID: 76095
		俯仰跟随,
		// Token: 0x04012940 RID: 76096
		偏航跟随,
		// Token: 0x04012941 RID: 76097
		俯仰_偏航跟随,
		// Token: 0x04012942 RID: 76098
		EMovieCameraSequenceSettingFollowTargetType_MAX
	}
}
