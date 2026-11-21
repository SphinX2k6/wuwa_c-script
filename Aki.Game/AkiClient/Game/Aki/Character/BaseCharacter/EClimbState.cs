using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020032FF RID: 13055
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EClimbState.EClimbState")]
	public enum EClimbState : byte
	{
		// Token: 0x04012031 RID: 73777
		无,
		// Token: 0x04012032 RID: 73778
		进入攀爬,
		// Token: 0x04012033 RID: 73779
		攀爬中,
		// Token: 0x04012034 RID: 73780
		退出攀爬,
		// Token: 0x04012035 RID: 73781
		跳下退出,
		// Token: 0x04012036 RID: 73782
		EClimbState_MAX
	}
}
