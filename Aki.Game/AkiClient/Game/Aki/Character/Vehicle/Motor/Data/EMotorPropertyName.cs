using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.Vehicle.Motor.Data
{
	// Token: 0x0200404C RID: 16460
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Data/EMotorPropertyName.EMotorPropertyName")]
	public enum EMotorPropertyName : byte
	{
		// Token: 0x04015D08 RID: 89352
		冲刺相关配置_全部_,
		// Token: 0x04015D09 RID: 89353
		加减速配置_全部_,
		// Token: 0x04015D0A RID: 89354
		重力标量,
		// Token: 0x04015D0B RID: 89355
		平衡配置_全部_,
		// Token: 0x04015D0C RID: 89356
		速度相关,
		// Token: 0x04015D0D RID: 89357
		动力相关,
		// Token: 0x04015D0E RID: 89358
		转向性能相关,
		// Token: 0x04015D0F RID: 89359
		倒车性能相关,
		// Token: 0x04015D10 RID: 89360
		前后轮刹车摩擦力,
		// Token: 0x04015D11 RID: 89361
		翱翔配置_全部_,
		// Token: 0x04015D12 RID: 89362
		新版漂移配置_全部_,
		// Token: 0x04015D13 RID: 89363
		EMotorPropertyName_MAX
	}
}
