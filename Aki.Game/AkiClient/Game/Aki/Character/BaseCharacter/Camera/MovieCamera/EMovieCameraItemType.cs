using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera.MovieCamera
{
	// Token: 0x020033EC RID: 13292
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/MovieCamera/EMovieCameraItemType.EMovieCameraItemType")]
	public enum EMovieCameraItemType : byte
	{
		// Token: 0x04012935 RID: 76085
		None,
		// Token: 0x04012936 RID: 76086
		战斗子镜头,
		// Token: 0x04012937 RID: 76087
		Sequence镜头,
		// Token: 0x04012938 RID: 76088
		EMovieCameraItemType_MAX
	}
}
