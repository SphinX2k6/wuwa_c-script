using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200143D RID: 5181
public class InfluenceInstance
{
	// Token: 0x1700136B RID: 4971
	// (get) Token: 0x0600CE23 RID: 52771 RVA: 0x003D4D8B File Offset: 0x003D2F8B
	public EInfluenceRelation Relation
	{
		get
		{
			return this.RelationInternal;
		}
	}

	// Token: 0x0600CE24 RID: 52772 RVA: 0x003D4D93 File Offset: 0x003D2F93
	public void SetRelation(EInfluenceRelation relation)
	{
		this.RelationInternal = relation;
	}

	// Token: 0x0600CE25 RID: 52773 RVA: 0x003D4D9C File Offset: 0x003D2F9C
	public InfluenceInstance(int id, int rewardIndex, int relation)
	{
		this.Id = id;
		this.RewardIndexInternal = rewardIndex;
		this.RelationInternal = (EInfluenceRelation)relation;
	}

	// Token: 0x1700136C RID: 4972
	// (get) Token: 0x0600CE26 RID: 52774 RVA: 0x003D4DB9 File Offset: 0x003D2FB9
	public int RewardIndex
	{
		get
		{
			return this.RewardIndexInternal;
		}
	}

	// Token: 0x0600CE27 RID: 52775 RVA: 0x003D4DC1 File Offset: 0x003D2FC1
	public void SetReceiveReward(int rewardIndex)
	{
		this.RewardIndexInternal = rewardIndex;
	}

	// Token: 0x0600CE28 RID: 52776 RVA: 0x003D4DCC File Offset: 0x003D2FCC
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

	// Token: 0x0600CE29 RID: 52777 RVA: 0x003D4E48 File Offset: 0x003D3048
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

	// Token: 0x04007564 RID: 30052
	public readonly int Id;

	// Token: 0x04007565 RID: 30053
	private int RewardIndexInternal;

	// Token: 0x04007566 RID: 30054
	private EInfluenceRelation RelationInternal;
}
