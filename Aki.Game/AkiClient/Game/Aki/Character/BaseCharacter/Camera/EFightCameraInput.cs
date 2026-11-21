using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020033D1 RID: 13265
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/EFightCameraInput.EFightCameraInput")]
	public enum EFightCameraInput : byte
	{
		// Token: 0x04012789 RID: 75657
		None,
		// Token: 0x0401278A RID: 75658
		滚轮轴影响臂长系数,
		// Token: 0x0401278B RID: 75659
		镜头输入缓冲系数最小值,
		// Token: 0x0401278C RID: 75660
		镜头输入缓冲系数最大值,
		// Token: 0x0401278D RID: 75661
		镜头输入缓冲系数输入极值,
		// Token: 0x0401278E RID: 75662
		镜头输入速率Min,
		// Token: 0x0401278F RID: 75663
		镜头输入速率Max,
		// Token: 0x04012790 RID: 75664
		镜头Yaw灵敏度系数最小值,
		// Token: 0x04012791 RID: 75665
		镜头Yaw灵敏度系数最大值,
		// Token: 0x04012792 RID: 75666
		镜头Yaw灵敏度系数输入极值,
		// Token: 0x04012793 RID: 75667
		镜头Pitch灵敏度系数最小值,
		// Token: 0x04012794 RID: 75668
		镜头Pitch灵敏度系数最大值,
		// Token: 0x04012795 RID: 75669
		镜头Pitch灵敏度系数输入极值,
		// Token: 0x04012796 RID: 75670
		倍化手柄输入倍率,
		// Token: 0x04012797 RID: 75671
		辅助瞄准中心速度,
		// Token: 0x04012798 RID: 75672
		辅助瞄准边缘速度,
		// Token: 0x04012799 RID: 75673
		辅助瞄准最远距离,
		// Token: 0x0401279A RID: 75674
		辅助瞄准阻尼系数,
		// Token: 0x0401279B RID: 75675
		进入瞄准模式时长,
		// Token: 0x0401279C RID: 75676
		进入瞄准模式速度初始值,
		// Token: 0x0401279D RID: 75677
		进入瞄准模式速度结束值,
		// Token: 0x0401279E RID: 75678
		镜头输入缓冲系数最小值_手柄_,
		// Token: 0x0401279F RID: 75679
		镜头输入缓冲系数最大值_手柄_,
		// Token: 0x040127A0 RID: 75680
		镜头输入缓冲系数输入极值_手柄_,
		// Token: 0x040127A1 RID: 75681
		滚轮轴影响臂长系数_手柄,
		// Token: 0x040127A2 RID: 75682
		特定镜头Yaw灵敏度,
		// Token: 0x040127A3 RID: 75683
		特定镜头Pitch灵敏度,
		// Token: 0x040127A4 RID: 75684
		特定瞄准镜头Yaw灵敏度,
		// Token: 0x040127A5 RID: 75685
		特定瞄准镜头Pitch灵敏度,
		// Token: 0x040127A6 RID: 75686
		EFightCameraInput_MAX
	}
}
