using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera.MovieCamera
{
	// Token: 0x020043D5 RID: 17365
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/MovieCamera/EMovieCameraItemType.EMovieCameraItemType")]
	public enum EMovieCameraItemType : byte
	{
		// Token: 0x04017DF4 RID: 97780
		None,
		// Token: 0x04017DF5 RID: 97781
		战斗子镜头,
		// Token: 0x04017DF6 RID: 97782
		Sequence镜头,
		// Token: 0x04017DF7 RID: 97783
		EMovieCameraItemType_MAX
	}
}
