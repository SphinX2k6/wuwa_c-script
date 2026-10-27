using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020043A7 RID: 17319
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/ECameraModifyConditionType.ECameraModifyConditionType")]
	public enum ECameraModifyConditionType : byte
	{
		// Token: 0x04017AE6 RID: 96998
		角色拥有Tag,
		// Token: 0x04017AE7 RID: 96999
		锁定目标拥有Tag,
		// Token: 0x04017AE8 RID: 97000
		臂长范围,
		// Token: 0x04017AE9 RID: 97001
		锁定目标处于镜头左边,
		// Token: 0x04017AEA RID: 97002
		与锁定目标相对高度,
		// Token: 0x04017AEB RID: 97003
		与锁定目标的相对Yaw,
		// Token: 0x04017AEC RID: 97004
		当前pitch范围,
		// Token: 0x04017AED RID: 97005
		与锁定目标的距离,
		// Token: 0x04017AEE RID: 97006
		范围阻挡检测,
		// Token: 0x04017AEF RID: 97007
		相机位于锁定目标连线轴的左侧,
		// Token: 0x04017AF0 RID: 97008
		相机位于锁定目标连线轴的右侧,
		// Token: 0x04017AF1 RID: 97009
		与角色的相对Yaw,
		// Token: 0x04017AF2 RID: 97010
		ECameraModifyConditionType_MAX
	}
}
