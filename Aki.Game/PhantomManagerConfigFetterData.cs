using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x020018E0 RID: 6368
[NullableContext(1)]
[Nullable(0)]
public class PhantomManagerConfigFetterData
{
	// Token: 0x0600FB7B RID: 64379 RVA: 0x0049899E File Offset: 0x00496B9E
	public PhantomManagerConfigFetterData(int fetterId)
	{
		this.FetterId = fetterId;
	}

	// Token: 0x0600FB7C RID: 64380 RVA: 0x004989B8 File Offset: 0x00496BB8
	public void UpdateMainPropMap(IEnumerable<PhBaOneCostPlan> mainPropData)
	{
		HashSet<int> hashSet = new HashSet<int>();
		foreach (PhBaOneCostPlan phBaOneCostPlan in mainPropData)
		{
			hashSet.Add((int)phBaOneCostPlan.CostType);
			this.TryInitCost((int)phBaOneCostPlan.CostType);
			this.CostMap[(int)phBaOneCostPlan.CostType].UpdateMainProp(phBaOneCostPlan.AttrList);
		}
		foreach (KeyValuePair<int, PhantomManagerConfigCostGroupData> keyValuePair in this.CostMap)
		{
			if (!hashSet.Contains(keyValuePair.Key))
			{
				keyValuePair.Value.UpdateMainProp(new List<PhBaPlanAttr>());
			}
		}
	}

	// Token: 0x0600FB7D RID: 64381 RVA: 0x00498A90 File Offset: 0x00496C90
	public void CacheSharePropMap(IEnumerable<PhBaOneCostPlan> propData)
	{
		HashSet<int> hashSet = new HashSet<int>();
		foreach (PhBaOneCostPlan phBaOneCostPlan in propData)
		{
			hashSet.Add((int)phBaOneCostPlan.CostType);
			this.TryInitCost((int)phBaOneCostPlan.CostType);
			this.CostMap[(int)phBaOneCostPlan.CostType].CacheShareProp(phBaOneCostPlan.AttrList);
		}
		foreach (KeyValuePair<int, PhantomManagerConfigCostGroupData> keyValuePair in this.CostMap)
		{
			if (!hashSet.Contains(keyValuePair.Key))
			{
				keyValuePair.Value.CacheShareProp(new List<PhBaPlanAttr>());
			}
		}
	}

	// Token: 0x0600FB7E RID: 64382 RVA: 0x00498B68 File Offset: 0x00496D68
	public void TryInitCost(int cost)
	{
		if (!this.CostMap.ContainsKey(cost))
		{
			this.CostMap[cost] = new PhantomManagerConfigCostGroupData(this.FetterId, cost);
		}
	}

	// Token: 0x0600FB7F RID: 64383 RVA: 0x00498B90 File Offset: 0x00496D90
	public EPhantomManagerConfigState GetPropCurrentState(IPhantomManagerConfigNewSettingDetailInfo data)
	{
		PhantomManagerConfigCostGroupData phantomManagerConfigCostGroupData;
		if (!this.CostMap.TryGetValue(data.Cost, out phantomManagerConfigCostGroupData))
		{
			return EPhantomManagerConfigState.Default;
		}
		return phantomManagerConfigCostGroupData.GetPropCurrentState(data.MainPropId);
	}

	// Token: 0x0600FB80 RID: 64384 RVA: 0x00498BC0 File Offset: 0x00496DC0
	public void SetPropState(IPhantomManagerConfigNewSettingDetailInfo data, EPhantomManagerConfigState state, bool isCache)
	{
		this.TryInitCost(data.Cost);
		this.CostMap[data.Cost].SetPropState(data.MainPropId, state, isCache);
	}

	// Token: 0x0600FB81 RID: 64385 RVA: 0x00498BEC File Offset: 0x00496DEC
	public void DoCacheDataUpdate(bool apply)
	{
		foreach (KeyValuePair<int, PhantomManagerConfigCostGroupData> keyValuePair in this.CostMap)
		{
			keyValuePair.Value.DoCacheDataUpdate(apply);
		}
	}

	// Token: 0x0600FB82 RID: 64386 RVA: 0x00498C48 File Offset: 0x00496E48
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	public ValueTuple<bool, PhBaOneSuitPlan> GetCacheProtoData()
	{
		PhBaOneSuitPlan phBaOneSuitPlan = PhBaOneSuitPlan.Create();
		phBaOneSuitPlan.SuitId = this.FetterId;
		bool flag = false;
		foreach (KeyValuePair<int, PhantomManagerConfigCostGroupData> keyValuePair in this.CostMap)
		{
			PhBaOneCostPlan phBaOneCostPlan = PhBaOneCostPlan.Create();
			phBaOneCostPlan.CostType = (PhBaCostType)keyValuePair.Key;
			ValueTuple<bool, List<PhBaPlanAttr>> cacheProtoData = keyValuePair.Value.GetCacheProtoData();
			bool item = cacheProtoData.Item1;
			List<PhBaPlanAttr> item2 = cacheProtoData.Item2;
			flag = (flag || item);
			if (item2.Count != 0)
			{
				phBaOneCostPlan.AttrList.Add(item2);
				phBaOneSuitPlan.OneCostList.Add(phBaOneCostPlan);
			}
		}
		return new ValueTuple<bool, PhBaOneSuitPlan>(flag, phBaOneSuitPlan);
	}

	// Token: 0x0600FB83 RID: 64387 RVA: 0x00498D08 File Offset: 0x00496F08
	public void ResetFetterConfig()
	{
		foreach (KeyValuePair<int, PhantomManagerConfigCostGroupData> keyValuePair in this.CostMap)
		{
			keyValuePair.Value.ResetConfig();
		}
	}

	// Token: 0x0600FB84 RID: 64388 RVA: 0x00498D60 File Offset: 0x00496F60
	public bool GetEditFetterConfigRecommendDirty()
	{
		IReadOnlyList<PhantomManagePlanV2> phantomManagerPlanByFetterId = PhantomBattleConfig.Instance.GetPhantomManagerPlanByFetterId(this.FetterId);
		if (this.CostMap.Count != phantomManagerPlanByFetterId.Count)
		{
			return true;
		}
		HashSet<int> hashSet = new HashSet<int>();
		foreach (PhantomManagePlanV2 config in phantomManagerPlanByFetterId)
		{
			if (!this.CostMap.ContainsKey(config.Cost))
			{
				return true;
			}
			hashSet.Add(config.Cost);
			if (this.CostMap[config.Cost].GetRecommendDirty(config))
			{
				return true;
			}
		}
		foreach (int item in this.CostMap.Keys)
		{
			if (!hashSet.Contains(item))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600FB85 RID: 64389 RVA: 0x00498E6C File Offset: 0x0049706C
	public bool SetFetterConfigRecommend()
	{
		IEnumerable<PhantomManagePlanV2> phantomManagerPlanByFetterId = PhantomBattleConfig.Instance.GetPhantomManagerPlanByFetterId(this.FetterId);
		bool flag = false;
		HashSet<int> hashSet = new HashSet<int>();
		foreach (PhantomManagePlanV2 config in phantomManagerPlanByFetterId)
		{
			if (!this.CostMap.ContainsKey(config.Cost))
			{
				this.CostMap[config.Cost] = new PhantomManagerConfigCostGroupData(this.FetterId, config.Cost);
			}
			hashSet.Add(config.Cost);
			flag = (this.CostMap[config.Cost].CacheRecommend(config) || flag);
		}
		foreach (int num in this.CostMap.Keys)
		{
			if (!hashSet.Contains(num))
			{
				this.CostMap.Remove(num);
			}
		}
		return flag;
	}

	// Token: 0x0600FB86 RID: 64390 RVA: 0x00498F80 File Offset: 0x00497180
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public List<PhantomDiscardPlanPlanLogData> GetLogReport()
	{
		if (this.CostMap.Count == 0)
		{
			return null;
		}
		List<PhantomDiscardPlanPlanLogData> list = new List<PhantomDiscardPlanPlanLogData>();
		foreach (KeyValuePair<int, PhantomManagerConfigCostGroupData> keyValuePair in this.CostMap)
		{
			list.AddRange(keyValuePair.Value.GetLogReport());
		}
		if (list.Count <= 0)
		{
			return null;
		}
		return list;
	}

	// Token: 0x04008C9C RID: 35996
	protected readonly Dictionary<int, PhantomManagerConfigCostGroupData> CostMap = new Dictionary<int, PhantomManagerConfigCostGroupData>();

	// Token: 0x04008C9D RID: 35997
	public int FetterId;
}
