using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020033C1 RID: 13249
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/ECameraAnsEffectiveClientType.ECameraAnsEffectiveClientType")]
	public enum ECameraAnsEffectiveClientType : byte
	{
		// Token: 0x0401263A RID: 75322
		单客户端_角色为中心_,
		// Token: 0x0401263B RID: 75323
		全客户端_角色为中心_,
		// Token: 0x0401263C RID: 75324
		锁定目标客户端_怪物为中心_,
		// Token: 0x0401263D RID: 75325
		仇恨目标客户端_怪物为中心_,
		// Token: 0x0401263E RID: 75326
		技能目标客户端_怪物为中心_,
		// Token: 0x0401263F RID: 75327
		全客户端_怪物为中心_,
		// Token: 0x04012640 RID: 75328
		锁定目标客户端_角色为中心_,
		// Token: 0x04012641 RID: 75329
		单客户端_声骸为中心_,
		// Token: 0x04012642 RID: 75330
		全客户端_声骸为中心_,
		// Token: 0x04012643 RID: 75331
		单客户端_载具为中心_,
		// Token: 0x04012644 RID: 75332
		全客户端_载具为中心_,
		// Token: 0x04012645 RID: 75333
		单客户端_伴生物为中心_,
		// Token: 0x04012646 RID: 75334
		全客户端_伴生物为中心_,
		// Token: 0x04012647 RID: 75335
		仇恨目标客户端_角色为中心_,
		// Token: 0x04012648 RID: 75336
		ECameraAnsEffectiveClientType_MAX
	}
}
