using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020032F7 RID: 13047
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EBulletType.EBulletType")]
	public enum EBulletType : byte
	{
		// Token: 0x04011FDC RID: 73692
		远程子弹,
		// Token: 0x04011FDD RID: 73693
		瞄准射击子弹,
		// Token: 0x04011FDE RID: 73694
		近战攻击子弹,
		// Token: 0x04011FDF RID: 73695
		大范围子弹,
		// Token: 0x04011FE0 RID: 73696
		地刺型子弹,
		// Token: 0x04011FE1 RID: 73697
		EBulletType_MAX
	}
}
