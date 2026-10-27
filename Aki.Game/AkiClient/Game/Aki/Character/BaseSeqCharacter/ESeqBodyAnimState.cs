using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseSeqCharacter
{
	// Token: 0x0200426F RID: 17007
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseSeqCharacter/ESeqBodyAnimState.ESeqBodyAnimState")]
	public enum ESeqBodyAnimState : byte
	{
		// Token: 0x0401714F RID: 94543
		站立,
		// Token: 0x04017150 RID: 94544
		摊右手,
		// Token: 0x04017151 RID: 94545
		右手思考,
		// Token: 0x04017152 RID: 94546
		右手摸前额,
		// Token: 0x04017153 RID: 94547
		右手放胸前,
		// Token: 0x04017154 RID: 94548
		左手压抱胸,
		// Token: 0x04017155 RID: 94549
		左手压抱胸抬手,
		// Token: 0x04017156 RID: 94550
		左手叉腰,
		// Token: 0x04017157 RID: 94551
		左手叉腰抬手,
		// Token: 0x04017158 RID: 94552
		双叉腰,
		// Token: 0x04017159 RID: 94553
		双叉腰抬右手,
		// Token: 0x0401715A RID: 94554
		ESeqBodyAnimState_MAX
	}
}
