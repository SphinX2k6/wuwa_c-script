using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera.MovieCamera
{
	// Token: 0x020033EF RID: 13295
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/MovieCamera/EMovieCameraSwitchType.EMovieCameraSwitchType")]
	public enum EMovieCameraSwitchType : byte
	{
		// Token: 0x04012944 RID: 76100
		随机切换,
		// Token: 0x04012945 RID: 76101
		顺序切换,
		// Token: 0x04012946 RID: 76102
		初始随机,
		// Token: 0x04012947 RID: 76103
		EMovieCameraSwitchType_MAX
	}
}
