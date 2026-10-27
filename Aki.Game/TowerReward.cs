using System;

// Token: 0x02002BD2 RID: 11218
public class TowerReward
{
	// Token: 0x060174D7 RID: 95447 RVA: 0x005EC963 File Offset: 0x005EAB63
	public TowerReward(int target, int rewardId, int index)
	{
		this.Target = target;
		this.RewardId = rewardId;
		this.Index = index;
	}

	// Token: 0x0400AE5B RID: 44635
	public bool? IsReceived = new bool?(false);

	// Token: 0x0400AE5C RID: 44636
	public int Target;

	// Token: 0x0400AE5D RID: 44637
	public int RewardId;

	// Token: 0x0400AE5E RID: 44638
	public int Index;
}
