using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020032F8 RID: 13048
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ECamp.ECamp")]
	public enum ECamp : byte
	{
		// Token: 0x04011FE3 RID: 73699
		Player,
		// Token: 0x04011FE4 RID: 73700
		Monster,
		// Token: 0x04011FE5 RID: 73701
		Common_friend,
		// Token: 0x04011FE6 RID: 73702
		liufangzhe_e,
		// Token: 0x04011FE7 RID: 73703
		liufangzhe_f,
		// Token: 0x04011FE8 RID: 73704
		Animal_attack,
		// Token: 0x04011FE9 RID: 73705
		Animal_unattack,
		// Token: 0x04011FEA RID: 73706
		Common_enemy,
		// Token: 0x04011FEB RID: 73707
		Camp_hha,
		// Token: 0x04011FEC RID: 73708
		Camp_jn,
		// Token: 0x04011FED RID: 73709
		Camp_wj,
		// Token: 0x04011FEE RID: 73710
		Camp_wtn,
		// Token: 0x04011FEF RID: 73711
		Camp_yfk,
		// Token: 0x04011FF0 RID: 73712
		Camp_None,
		// Token: 0x04011FF1 RID: 73713
		Camp_yegui,
		// Token: 0x04011FF2 RID: 73714
		ECamp_MAX
	}
}
