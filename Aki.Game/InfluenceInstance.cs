using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001F7B RID: 8059
public class InfluenceInstance
{
	// Token: 0x17001341 RID: 4929
	// (get) Token: 0x0600FA04 RID: 64004 RVA: 0x003C926F File Offset: 0x003C746F
	public EInfluenceRelation Relation
	{
		get
		{
			return this.RelationInternal;
		}
	}

	// Token: 0x0600FA05 RID: 64005 RVA: 0x003C9277 File Offset: 0x003C7477
	public void SetRelation(EInfluenceRelation relation)
	{
		this.RelationInternal = relation;
	}

	// Token: 0x0600FA06 RID: 64006 RVA: 0x003C9280 File Offset: 0x003C7480
	public InfluenceInstance(int id, int rewardIndex, int relation)
	{
		this.Id = id;
		this.RewardIndexInternal = rewardIndex;
		this.RelationInternal = (EInfluenceRelation)relation;
	}

	// Token: 0x17001342 RID: 4930
	// (get) Token: 0x0600FA07 RID: 64007 RVA: 0x003C929D File Offset: 0x003C749D
	public int RewardIndex
	{
		get
		{
			return this.RewardIndexInternal;
		}
	}

	// Token: 0x0600FA08 RID: 64008 RVA: 0x003C92A5 File Offset: 0x003C74A5
	public void SetReceiveReward(int rewardIndex)
	{
		this.RewardIndexInternal = rewardIndex;
	}

	// Token: 0x0600FA09 RID: 64009 RVA: 0x003C92B0 File Offset: 0x003C74B0
	[return: TupleElementNames(new string[]
	{
		"IsReceived",
		"Reward"
	})]
	public ValueTuple<bool, IntPair> GetCanReceiveReward()
	{
		Influence? influenceConfig = InfluenceConfig.Instance.GetInfluenceConfig(this.Id);
		if (influenceConfig == null)
		{
			return new ValueTuple<bool, IntPair>(false, default(IntPair));
		}
		IntPair[] array = influenceConfig.Value.ReputationReward();
		if (array.Length == this.RewardIndex + 1)
		{
			return new ValueTuple<bool, IntPair>(true, array[this.RewardIndex]);
		}
		return new ValueTuple<bool, IntPair>(false, array[this.RewardIndex + 1]);
	}

	// Token: 0x0600FA0A RID: 64010 RVA: 0x003C932C File Offset: 0x003C752C
	[NullableContext(1)]
	public IReadOnlyList<IntPair> GetReward()
	{
		Influence? influenceConfig = InfluenceConfig.Instance.GetInfluenceConfig(this.Id);
		if (influenceConfig != null)
		{
			List<IntPair> list = new List<IntPair>();
			foreach (IntPair item in influenceConfig.Value.ReputationReward())
			{
				list.Add(item);
			}
			return list;
		}
		return new List<IntPair>();
	}

	// Token: 0x04007483 RID: 29827
	public readonly int Id;

	// Token: 0x04007484 RID: 29828
	private int RewardIndexInternal;

	// Token: 0x04007485 RID: 29829
	private EInfluenceRelation RelationInternal;
}
