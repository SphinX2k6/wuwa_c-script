using System;
using System.Runtime.CompilerServices;

// Token: 0x02001C69 RID: 7273
[NullableContext(1)]
[Nullable(0)]
internal class BigRewardSlot
{
	// Token: 0x0600DB2B RID: 56107 RVA: 0x0032EAD2 File Offset: 0x0032CCD2
	public static BigRewardSlot MakeBig(GachaAccumulateRewardData reward)
	{
		return new BigRewardSlot
		{
			Kind = EBigRewardSlotKind.Big,
			Reward = reward
		};
	}

	// Token: 0x0600DB2C RID: 56108 RVA: 0x0032EAE7 File Offset: 0x0032CCE7
	public static BigRewardSlot MakeCyclic()
	{
		return new BigRewardSlot
		{
			Kind = EBigRewardSlotKind.Cyclic
		};
	}

	// Token: 0x0600DB2D RID: 56109 RVA: 0x0032EAF5 File Offset: 0x0032CCF5
	public static BigRewardSlot MakeNone()
	{
		return new BigRewardSlot();
	}

	// Token: 0x04006464 RID: 25700
	public EBigRewardSlotKind Kind = EBigRewardSlotKind.None;

	// Token: 0x04006465 RID: 25701
	[Nullable(2)]
	public GachaAccumulateRewardData Reward;
}
