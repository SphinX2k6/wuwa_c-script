using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x02003267 RID: 12903
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Core/Fight/ECharacterLoadType.ECharacterLoadType")]
	public enum ECharacterLoadType : byte
	{
		// Token: 0x040115EC RID: 71148
		通用,
		// Token: 0x040115ED RID: 71149
		肉鸽,
		// Token: 0x040115EE RID: 71150
		Ai角色,
		// Token: 0x040115EF RID: 71151
		坎特蕾拉特殊玩法,
		// Token: 0x040115F0 RID: 71152
		主线书页副本2_4,
		// Token: 0x040115F1 RID: 71153
		塔防道具2_6,
		// Token: 0x040115F2 RID: 71154
		拍照活动2_7,
		// Token: 0x040115F3 RID: 71155
		幸存者2_7,
		// Token: 0x040115F4 RID: 71156
		仇远主线副本2_7,
		// Token: 0x040115F5 RID: 71157
		主线黑潮副本2_7,
		// Token: 0x040115F6 RID: 71158
		主线辛吉勒姆副本3_1,
		// Token: 0x040115F7 RID: 71159
		巴别塔3_5,
		// Token: 0x040115F8 RID: 71160
		神肉鸽3_6,
		// Token: 0x040115F9 RID: 71161
		黑梦3_4,
		// Token: 0x040115FA RID: 71162
		主线重楼副本3_5,
		// Token: 0x040115FB RID: 71163
		御剑流程3_6,
		// Token: 0x040115FC RID: 71164
		无冠者战斗3_6,
		// Token: 0x040115FD RID: 71165
		占位1,
		// Token: 0x040115FE RID: 71166
		占位2,
		// Token: 0x040115FF RID: 71167
		主线溯心副本3_7,
		// Token: 0x04011600 RID: 71168
		角色爬塔3_8,
		// Token: 0x04011601 RID: 71169
		ECharacterLoadType_MAX
	}
}
