using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020033D9 RID: 13273
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/EFreeCameraLimit.EFreeCameraLimit")]
	public enum EFreeCameraLimit : byte
	{
		// Token: 0x040127DD RID: 75741
		None,
		// Token: 0x040127DE RID: 75742
		世界X轴偏移上界,
		// Token: 0x040127DF RID: 75743
		世界X轴偏移下界,
		// Token: 0x040127E0 RID: 75744
		世界Y轴偏移上界,
		// Token: 0x040127E1 RID: 75745
		世界Y轴偏移下界,
		// Token: 0x040127E2 RID: 75746
		世界Z轴偏移上界,
		// Token: 0x040127E3 RID: 75747
		世界Z轴偏移下界,
		// Token: 0x040127E4 RID: 75748
		最小FOV,
		// Token: 0x040127E5 RID: 75749
		最大FOV,
		// Token: 0x040127E6 RID: 75750
		Yaw限制Min,
		// Token: 0x040127E7 RID: 75751
		Yaw限制Max,
		// Token: 0x040127E8 RID: 75752
		Pitch限制Min,
		// Token: 0x040127E9 RID: 75753
		Pitch限制Max,
		// Token: 0x040127EA RID: 75754
		EFreeCameraLimit_MAX
	}
}
