using System;

// Token: 0x0200214D RID: 8525
public class TowerReward
{
	// Token: 0x06014F08 RID: 85768 RVA: 0x0061949F File Offset: 0x0061769F
	public TowerReward(int target, int rewardId, int index)
	{
		this.Target = target;
		this.RewardId = rewardId;
		this.Index = index;
	}

	// Token: 0x0400B260 RID: 45664
	public bool? IsReceived = new bool?(false);

	// Token: 0x0400B261 RID: 45665
	public int Target;

	// Token: 0x0400B262 RID: 45666
	public int RewardId;

	// Token: 0x0400B263 RID: 45667
	public int Index;
}
