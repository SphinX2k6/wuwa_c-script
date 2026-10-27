using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020043A3 RID: 17315
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/ECameraAnsEffectiveClientType.ECameraAnsEffectiveClientType")]
	public enum ECameraAnsEffectiveClientType : byte
	{
		// Token: 0x04017AC8 RID: 96968
		单客户端_角色为中心_,
		// Token: 0x04017AC9 RID: 96969
		全客户端_角色为中心_,
		// Token: 0x04017ACA RID: 96970
		锁定目标客户端_怪物为中心_,
		// Token: 0x04017ACB RID: 96971
		仇恨目标客户端_怪物为中心_,
		// Token: 0x04017ACC RID: 96972
		技能目标客户端_怪物为中心_,
		// Token: 0x04017ACD RID: 96973
		全客户端_怪物为中心_,
		// Token: 0x04017ACE RID: 96974
		锁定目标客户端_角色为中心_,
		// Token: 0x04017ACF RID: 96975
		单客户端_声骸为中心_,
		// Token: 0x04017AD0 RID: 96976
		全客户端_声骸为中心_,
		// Token: 0x04017AD1 RID: 96977
		单客户端_载具为中心_,
		// Token: 0x04017AD2 RID: 96978
		全客户端_载具为中心_,
		// Token: 0x04017AD3 RID: 96979
		单客户端_伴生物为中心_,
		// Token: 0x04017AD4 RID: 96980
		全客户端_伴生物为中心_,
		// Token: 0x04017AD5 RID: 96981
		仇恨目标客户端_角色为中心_,
		// Token: 0x04017AD6 RID: 96982
		ECameraAnsEffectiveClientType_MAX
	}
}
