using System;
using System.Runtime.CompilerServices;

// Token: 0x02001128 RID: 4392
[NullableContext(1)]
[Nullable(0)]
internal class BigRewardSlot
{
	// Token: 0x0600AF41 RID: 44865 RVA: 0x00339F1E File Offset: 0x0033811E
	public static BigRewardSlot MakeBig(GachaAccumulateRewardData reward)
	{
		return new BigRewardSlot
		{
			Kind = EBigRewardSlotKind.Big,
			Reward = reward
		};
	}

	// Token: 0x0600AF42 RID: 44866 RVA: 0x00339F33 File Offset: 0x00338133
	public static BigRewardSlot MakeCyclic()
	{
		return new BigRewardSlot
		{
			Kind = EBigRewardSlotKind.Cyclic
		};
	}

	// Token: 0x0600AF43 RID: 44867 RVA: 0x00339F41 File Offset: 0x00338141
	public static BigRewardSlot MakeNone()
	{
		return new BigRewardSlot();
	}

	// Token: 0x04006536 RID: 25910
	public EBigRewardSlotKind Kind = EBigRewardSlotKind.None;

	// Token: 0x04006537 RID: 25911
	[Nullable(2)]
	public GachaAccumulateRewardData Reward;
}
