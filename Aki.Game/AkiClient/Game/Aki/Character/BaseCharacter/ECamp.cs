using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200429C RID: 17052
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ECamp.ECamp")]
	public enum ECamp : byte
	{
		// Token: 0x040172E1 RID: 94945
		Player,
		// Token: 0x040172E2 RID: 94946
		Monster,
		// Token: 0x040172E3 RID: 94947
		Common_friend,
		// Token: 0x040172E4 RID: 94948
		liufangzhe_e,
		// Token: 0x040172E5 RID: 94949
		liufangzhe_f,
		// Token: 0x040172E6 RID: 94950
		Animal_attack,
		// Token: 0x040172E7 RID: 94951
		Animal_unattack,
		// Token: 0x040172E8 RID: 94952
		Common_enemy,
		// Token: 0x040172E9 RID: 94953
		Camp_hha,
		// Token: 0x040172EA RID: 94954
		Camp_jn,
		// Token: 0x040172EB RID: 94955
		Camp_wj,
		// Token: 0x040172EC RID: 94956
		Camp_wtn,
		// Token: 0x040172ED RID: 94957
		Camp_yfk,
		// Token: 0x040172EE RID: 94958
		Camp_None,
		// Token: 0x040172EF RID: 94959
		Camp_yegui,
		// Token: 0x040172F0 RID: 94960
		ECamp_MAX
	}
}
