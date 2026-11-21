using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020033CC RID: 13260
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/EFightCameraExplore.EFightCameraExplore")]
	public enum EFightCameraExplore : byte
	{
		// Token: 0x04012736 RID: 75574
		None,
		// Token: 0x04012737 RID: 75575
		修正角度Min,
		// Token: 0x04012738 RID: 75576
		修正角度Max,
		// Token: 0x04012739 RID: 75577
		InRangeMin,
		// Token: 0x0401273A RID: 75578
		InRangeMax,
		// Token: 0x0401273B RID: 75579
		OutRangeMin,
		// Token: 0x0401273C RID: 75580
		OutRangeMax,
		// Token: 0x0401273D RID: 75581
		摄像机合法角度_移动方向_,
		// Token: 0x0401273E RID: 75582
		移动方向合法角度_看向点方向_,
		// Token: 0x0401273F RID: 75583
		EFightCameraExplore_MAX
	}
}
