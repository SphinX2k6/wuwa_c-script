using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x02004003 RID: 16387
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Core/Fight/ECharacterLoadType.ECharacterLoadType")]
	public enum ECharacterLoadType : byte
	{
		// Token: 0x0401598C RID: 88460
		通用,
		// Token: 0x0401598D RID: 88461
		肉鸽,
		// Token: 0x0401598E RID: 88462
		Ai角色,
		// Token: 0x0401598F RID: 88463
		坎特蕾拉特殊玩法,
		// Token: 0x04015990 RID: 88464
		主线书页副本2_4,
		// Token: 0x04015991 RID: 88465
		塔防道具2_6,
		// Token: 0x04015992 RID: 88466
		拍照活动2_7,
		// Token: 0x04015993 RID: 88467
		幸存者2_7,
		// Token: 0x04015994 RID: 88468
		仇远主线副本2_7,
		// Token: 0x04015995 RID: 88469
		主线黑潮副本2_7,
		// Token: 0x04015996 RID: 88470
		主线辛吉勒姆副本3_1,
		// Token: 0x04015997 RID: 88471
		巴别塔3_5,
		// Token: 0x04015998 RID: 88472
		神肉鸽3_6,
		// Token: 0x04015999 RID: 88473
		黑梦3_4,
		// Token: 0x0401599A RID: 88474
		主线重楼副本3_5,
		// Token: 0x0401599B RID: 88475
		御剑流程3_6,
		// Token: 0x0401599C RID: 88476
		无冠者战斗3_6,
		// Token: 0x0401599D RID: 88477
		占位1_后续功能开发后替换,
		// Token: 0x0401599E RID: 88478
		占位2_后续功能开发后替换,
		// Token: 0x0401599F RID: 88479
		主线溯心副本3_7,
		// Token: 0x040159A0 RID: 88480
		ECharacterLoadType_MAX
	}
}
