using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Gameplay.Vision
{
	// Token: 0x020031DA RID: 12762
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Gameplay/Vision/EVisionMarkType.EVisionMarkType")]
	public enum EVisionMarkType : byte
	{
		// Token: 0x04010FE4 RID: 69604
		机械麋鹿_普通矿石,
		// Token: 0x04010FE5 RID: 69605
		机械麋鹿_日灵矿石,
		// Token: 0x04010FE6 RID: 69606
		岩蛛,
		// Token: 0x04010FE7 RID: 69607
		噼啪啪,
		// Token: 0x04010FE8 RID: 69608
		猛犸象冲撞,
		// Token: 0x04010FE9 RID: 69609
		猛犸象滑梯,
		// Token: 0x04010FEA RID: 69610
		猛犸象下砸,
		// Token: 0x04010FEB RID: 69611
		飞蛾,
		// Token: 0x04010FEC RID: 69612
		EVisionMarkType_MAX
	}
}
