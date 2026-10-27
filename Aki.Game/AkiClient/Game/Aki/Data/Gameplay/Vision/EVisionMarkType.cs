using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Gameplay.Vision
{
	// Token: 0x02003F2E RID: 16174
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Gameplay/Vision/EVisionMarkType.EVisionMarkType")]
	public enum EVisionMarkType : byte
	{
		// Token: 0x040150B4 RID: 86196
		机械麋鹿_普通矿石,
		// Token: 0x040150B5 RID: 86197
		机械麋鹿_日灵矿石,
		// Token: 0x040150B6 RID: 86198
		岩蛛,
		// Token: 0x040150B7 RID: 86199
		噼啪啪,
		// Token: 0x040150B8 RID: 86200
		猛犸象冲撞,
		// Token: 0x040150B9 RID: 86201
		猛犸象滑梯,
		// Token: 0x040150BA RID: 86202
		猛犸象下砸,
		// Token: 0x040150BB RID: 86203
		飞蛾,
		// Token: 0x040150BC RID: 86204
		EVisionMarkType_MAX
	}
}
