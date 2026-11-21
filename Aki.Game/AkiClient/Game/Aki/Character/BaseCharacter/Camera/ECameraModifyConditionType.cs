using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020033C5 RID: 13253
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/ECameraModifyConditionType.ECameraModifyConditionType")]
	public enum ECameraModifyConditionType : byte
	{
		// Token: 0x04012658 RID: 75352
		角色拥有Tag,
		// Token: 0x04012659 RID: 75353
		锁定目标拥有Tag,
		// Token: 0x0401265A RID: 75354
		臂长范围,
		// Token: 0x0401265B RID: 75355
		锁定目标处于镜头左边,
		// Token: 0x0401265C RID: 75356
		与锁定目标相对高度,
		// Token: 0x0401265D RID: 75357
		与锁定目标的相对Yaw,
		// Token: 0x0401265E RID: 75358
		当前pitch范围,
		// Token: 0x0401265F RID: 75359
		与锁定目标的距离,
		// Token: 0x04012660 RID: 75360
		范围阻挡检测,
		// Token: 0x04012661 RID: 75361
		相机位于锁定目标连线轴的左侧,
		// Token: 0x04012662 RID: 75362
		相机位于锁定目标连线轴的右侧,
		// Token: 0x04012663 RID: 75363
		与角色的相对Yaw,
		// Token: 0x04012664 RID: 75364
		ECameraModifyConditionType_MAX
	}
}
