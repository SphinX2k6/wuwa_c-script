using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera.MovieCamera
{
	// Token: 0x020043D9 RID: 17369
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/MovieCamera/EMovieCameraSwitchType.EMovieCameraSwitchType")]
	public enum EMovieCameraSwitchType : byte
	{
		// Token: 0x04017E06 RID: 97798
		随机切换,
		// Token: 0x04017E07 RID: 97799
		顺序切换,
		// Token: 0x04017E08 RID: 97800
		初始随机,
		// Token: 0x04017E09 RID: 97801
		EMovieCameraSwitchType_MAX
	}
}
