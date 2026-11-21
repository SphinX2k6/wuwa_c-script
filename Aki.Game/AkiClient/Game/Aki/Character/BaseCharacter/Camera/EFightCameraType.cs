using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020033D5 RID: 13269
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/EFightCameraType.EFightCameraType")]
	public enum EFightCameraType : byte
	{
		// Token: 0x040127C4 RID: 75716
		基础镜头,
		// Token: 0x040127C5 RID: 75717
		战斗镜头,
		// Token: 0x040127C6 RID: 75718
		子镜头,
		// Token: 0x040127C7 RID: 75719
		锁定目标镜头,
		// Token: 0x040127C8 RID: 75720
		伴随目标镜头,
		// Token: 0x040127C9 RID: 75721
		EFightCameraType_MAX
	}
}
