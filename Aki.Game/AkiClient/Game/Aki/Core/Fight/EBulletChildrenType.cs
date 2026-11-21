using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x0200325D RID: 12893
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Core/Fight/EBulletChildrenType.EBulletChildrenType")]
	public enum EBulletChildrenType : byte
	{
		// Token: 0x0401159D RID: 71069
		无特殊触发,
		// Token: 0x0401159E RID: 71070
		碰撞单位时触发,
		// Token: 0x0401159F RID: 71071
		碰撞障碍物时触发,
		// Token: 0x040115A0 RID: 71072
		次数不足时销毁触发,
		// Token: 0x040115A1 RID: 71073
		时间销毁时触发,
		// Token: 0x040115A2 RID: 71074
		受击对象进入子弹范围触发,
		// Token: 0x040115A3 RID: 71075
		EBulletChildrenType_MAX
	}
}
