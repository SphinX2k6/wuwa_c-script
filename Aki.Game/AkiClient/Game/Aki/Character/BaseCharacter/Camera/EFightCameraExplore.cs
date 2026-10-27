using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020043AE RID: 17326
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/EFightCameraExplore.EFightCameraExplore")]
	public enum EFightCameraExplore : byte
	{
		// Token: 0x04017BC3 RID: 97219
		None,
		// Token: 0x04017BC4 RID: 97220
		修正角度Min,
		// Token: 0x04017BC5 RID: 97221
		修正角度Max,
		// Token: 0x04017BC6 RID: 97222
		InRangeMin,
		// Token: 0x04017BC7 RID: 97223
		InRangeMax,
		// Token: 0x04017BC8 RID: 97224
		OutRangeMin,
		// Token: 0x04017BC9 RID: 97225
		OutRangeMax,
		// Token: 0x04017BCA RID: 97226
		摄像机合法角度_移动方向_,
		// Token: 0x04017BCB RID: 97227
		移动方向合法角度_看向点方向_,
		// Token: 0x04017BCC RID: 97228
		EFightCameraExplore_MAX
	}
}
