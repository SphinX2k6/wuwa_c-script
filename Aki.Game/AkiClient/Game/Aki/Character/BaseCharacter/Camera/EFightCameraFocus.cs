using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020033CD RID: 13261
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/EFightCameraFocus.EFightCameraFocus")]
	public enum EFightCameraFocus : byte
	{
		// Token: 0x04012741 RID: 75585
		None,
		// Token: 0x04012742 RID: 75586
		臂旋转Yaw过渡最小速度,
		// Token: 0x04012743 RID: 75587
		臂旋转Yaw过渡最大速度,
		// Token: 0x04012744 RID: 75588
		臂旋转Yaw过渡与目标Yaw角度最大差值,
		// Token: 0x04012745 RID: 75589
		强锁定_启动左右对峙,
		// Token: 0x04012746 RID: 75590
		强锁定_左右对峙_交换角度,
		// Token: 0x04012747 RID: 75591
		强锁定_左右对峙_交换冷却,
		// Token: 0x04012748 RID: 75592
		软锁定_镜头偏角最小值,
		// Token: 0x04012749 RID: 75593
		软锁定_镜头偏角最大值,
		// Token: 0x0401274A RID: 75594
		软锁定_锁定时相机臂偏移Y,
		// Token: 0x0401274B RID: 75595
		强锁定_锁定时相机臂偏移Y,
		// Token: 0x0401274C RID: 75596
		强锁定_输入灵敏度Yaw,
		// Token: 0x0401274D RID: 75597
		强锁定_输入灵敏度Pitch,
		// Token: 0x0401274E RID: 75598
		强锁定_输入灵敏度Yaw_手柄,
		// Token: 0x0401274F RID: 75599
		强锁定_输入灵敏度Pitch_手柄,
		// Token: 0x04012750 RID: 75600
		强锁定_切换目标_输入衰减律,
		// Token: 0x04012751 RID: 75601
		强锁定_切换目标_角度系数,
		// Token: 0x04012752 RID: 75602
		强锁定_切换目标_距离系数,
		// Token: 0x04012753 RID: 75603
		强锁定_镜头偏角最小值,
		// Token: 0x04012754 RID: 75604
		强锁定_镜头偏角最大值,
		// Token: 0x04012755 RID: 75605
		强锁定_镜头俯仰角最小值,
		// Token: 0x04012756 RID: 75606
		强锁定_镜头俯仰角最大值,
		// Token: 0x04012757 RID: 75607
		软锁定_镜头Yaw输入解锁速度,
		// Token: 0x04012758 RID: 75608
		软锁定_镜头Pitch输入解锁速度,
		// Token: 0x04012759 RID: 75609
		软锁定_输入灵敏度Yaw,
		// Token: 0x0401275A RID: 75610
		软锁定_输入灵敏度Pitch,
		// Token: 0x0401275B RID: 75611
		软锁定_输入灵敏度Yaw_手柄,
		// Token: 0x0401275C RID: 75612
		软锁定_输入灵敏度Pitch_手柄,
		// Token: 0x0401275D RID: 75613
		臂旋转过渡速度最小系数_目标距离_,
		// Token: 0x0401275E RID: 75614
		臂旋转过渡速度最大系数_目标距离_,
		// Token: 0x0401275F RID: 75615
		臂旋转过渡速度最大距离_目标距离_,
		// Token: 0x04012760 RID: 75616
		臂旋转过渡速度最小距离_目标距离_,
		// Token: 0x04012761 RID: 75617
		强锁定_切换目标_启动速度,
		// Token: 0x04012762 RID: 75618
		强锁定_切换目标_启动速度_手柄,
		// Token: 0x04012763 RID: 75619
		臂旋转Pitch过渡最小速度,
		// Token: 0x04012764 RID: 75620
		臂旋转Pitch过渡最大速度,
		// Token: 0x04012765 RID: 75621
		臂旋转Pitch过渡与目标Pitch角度最大差值,
		// Token: 0x04012766 RID: 75622
		软锁定_镜头输入缓冲时间,
		// Token: 0x04012767 RID: 75623
		软锁定_镜头Yaw输入启动速度,
		// Token: 0x04012768 RID: 75624
		软锁定_镜头Pitch输入启动速度,
		// Token: 0x04012769 RID: 75625
		强锁定_左右对峙_启动距离阈值,
		// Token: 0x0401276A RID: 75626
		强锁定_左右对峙_锁定方向,
		// Token: 0x0401276B RID: 75627
		EFightCameraFocus_MAX
	}
}
