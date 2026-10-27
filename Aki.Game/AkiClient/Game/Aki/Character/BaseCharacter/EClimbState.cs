using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042A4 RID: 17060
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EClimbState.EClimbState")]
	public enum EClimbState : byte
	{
		// Token: 0x04017333 RID: 95027
		无,
		// Token: 0x04017334 RID: 95028
		进入攀爬,
		// Token: 0x04017335 RID: 95029
		攀爬中,
		// Token: 0x04017336 RID: 95030
		退出攀爬,
		// Token: 0x04017337 RID: 95031
		跳下退出,
		// Token: 0x04017338 RID: 95032
		EClimbState_MAX
	}
}
