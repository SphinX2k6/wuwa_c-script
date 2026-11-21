using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.Vehicle.Motor.Data
{
	// Token: 0x02003291 RID: 12945
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Data/EMotorPropertyName.EMotorPropertyName")]
	public enum EMotorPropertyName : byte
	{
		// Token: 0x0401183D RID: 71741
		冲刺相关配置_全部_,
		// Token: 0x0401183E RID: 71742
		加减速配置_全部_,
		// Token: 0x0401183F RID: 71743
		重力标量,
		// Token: 0x04011840 RID: 71744
		平衡配置_全部_,
		// Token: 0x04011841 RID: 71745
		速度相关,
		// Token: 0x04011842 RID: 71746
		动力相关,
		// Token: 0x04011843 RID: 71747
		转向性能相关,
		// Token: 0x04011844 RID: 71748
		倒车性能相关,
		// Token: 0x04011845 RID: 71749
		前后轮刹车摩擦力,
		// Token: 0x04011846 RID: 71750
		翱翔配置_全部_,
		// Token: 0x04011847 RID: 71751
		新版漂移配置_全部_,
		// Token: 0x04011848 RID: 71752
		EMotorPropertyName_MAX
	}
}
