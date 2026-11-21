using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020033D3 RID: 13267
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/EFightCameraSidestep.EFightCameraSidestep")]
	public enum EFightCameraSidestep : byte
	{
		// Token: 0x040127B0 RID: 75696
		None,
		// Token: 0x040127B1 RID: 75697
		旋转角速度插值速率,
		// Token: 0x040127B2 RID: 75698
		俯仰角插值速率,
		// Token: 0x040127B3 RID: 75699
		相机俯角偏移,
		// Token: 0x040127B4 RID: 75700
		最大俯角,
		// Token: 0x040127B5 RID: 75701
		最大仰角,
		// Token: 0x040127B6 RID: 75702
		俯仰修正时间阈值,
		// Token: 0x040127B7 RID: 75703
		俯仰角加速度,
		// Token: 0x040127B8 RID: 75704
		自动偏转最大角速度,
		// Token: 0x040127B9 RID: 75705
		移动输入恢复臂长目标值下限,
		// Token: 0x040127BA RID: 75706
		移动输入恢复臂长目标值上限,
		// Token: 0x040127BB RID: 75707
		移动输入恢复臂长最小速度,
		// Token: 0x040127BC RID: 75708
		移动输入恢复臂长最大速度,
		// Token: 0x040127BD RID: 75709
		移动输入恢复臂长与目标臂长最大差值,
		// Token: 0x040127BE RID: 75710
		EFightCameraSidestep_MAX
	}
}
