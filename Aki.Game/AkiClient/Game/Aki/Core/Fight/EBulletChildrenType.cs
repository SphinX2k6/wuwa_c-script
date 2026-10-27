using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x02003FF7 RID: 16375
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Core/Fight/EBulletChildrenType.EBulletChildrenType")]
	public enum EBulletChildrenType : byte
	{
		// Token: 0x04015935 RID: 88373
		无特殊触发,
		// Token: 0x04015936 RID: 88374
		碰撞单位时触发,
		// Token: 0x04015937 RID: 88375
		碰撞障碍物时触发,
		// Token: 0x04015938 RID: 88376
		次数不足时销毁触发,
		// Token: 0x04015939 RID: 88377
		时间销毁时触发,
		// Token: 0x0401593A RID: 88378
		受击对象进入子弹范围触发,
		// Token: 0x0401593B RID: 88379
		EBulletChildrenType_MAX
	}
}
