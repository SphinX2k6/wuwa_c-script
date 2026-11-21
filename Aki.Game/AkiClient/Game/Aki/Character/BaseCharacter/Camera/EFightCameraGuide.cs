using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020033CF RID: 13263
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/EFightCameraGuide.EFightCameraGuide")]
	public enum EFightCameraGuide : byte
	{
		// Token: 0x04012772 RID: 75634
		None,
		// Token: 0x04012773 RID: 75635
		修正角度Min,
		// Token: 0x04012774 RID: 75636
		修正角度Max,
		// Token: 0x04012775 RID: 75637
		额外臂长系数_目标水平距离_,
		// Token: 0x04012776 RID: 75638
		额外臂长系数_目标高度差_,
		// Token: 0x04012777 RID: 75639
		额外臂长限制,
		// Token: 0x04012778 RID: 75640
		额外臂水平偏移系数_目标水平距离_,
		// Token: 0x04012779 RID: 75641
		额外臂水平偏移上限,
		// Token: 0x0401277A RID: 75642
		额外臂垂直偏移系数_目标高度差_,
		// Token: 0x0401277B RID: 75643
		额外臂垂直偏移上限,
		// Token: 0x0401277C RID: 75644
		InRangeMin,
		// Token: 0x0401277D RID: 75645
		InRangeMax,
		// Token: 0x0401277E RID: 75646
		OutRangeMin,
		// Token: 0x0401277F RID: 75647
		OutRangeMax,
		// Token: 0x04012780 RID: 75648
		CameraPitchMin,
		// Token: 0x04012781 RID: 75649
		CameraPitchMax,
		// Token: 0x04012782 RID: 75650
		CameraPitchOffset,
		// Token: 0x04012783 RID: 75651
		NearerRange,
		// Token: 0x04012784 RID: 75652
		EFightCameraGuide_MAX
	}
}
