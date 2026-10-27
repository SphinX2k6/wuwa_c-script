using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200429B RID: 17051
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EBulletType.EBulletType")]
	public enum EBulletType : byte
	{
		// Token: 0x040172DA RID: 94938
		远程子弹,
		// Token: 0x040172DB RID: 94939
		瞄准射击子弹,
		// Token: 0x040172DC RID: 94940
		近战攻击子弹,
		// Token: 0x040172DD RID: 94941
		大范围子弹,
		// Token: 0x040172DE RID: 94942
		地刺型子弹,
		// Token: 0x040172DF RID: 94943
		EBulletType_MAX
	}
}
