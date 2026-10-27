using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x020023FB RID: 9211
[NullableContext(1)]
[Nullable(0)]
public class PhantomManagerConfigFetterData
{
	// Token: 0x060126C9 RID: 75465 RVA: 0x0048B4AA File Offset: 0x004896AA
	public PhantomManagerConfigFetterData(int fetterId)
	{
		this.FetterId = fetterId;
	}

	// Token: 0x060126CA RID: 75466 RVA: 0x0048B4C4 File Offset: 0x004896C4
	public void UpdateMainPropMap(List<PhBaOneCostPlan> mainPropData)
	{
		HashSet<int> hashSet = new HashSet<int>();
		foreach (PhBaOneCostPlan phBaOneCostPlan in mainPropData)
		{
			hashSet.Add((int)phBaOneCostPlan.CostType);
			this.TryInitCost((int)phBaOneCostPlan.CostType);
			this.CostMap[(int)phBaOneCostPlan.CostType].UpdateMainProp(phBaOneCostPlan.AttrList.ToList<PhBaPlanAttr>());
		}
		foreach (KeyValuePair<int, PhantomManagerConfigCostGroupData> keyValuePair in this.CostMap)
		{
			if (!hashSet.Contains(keyValuePair.Key))
			{
				keyValuePair.Value.UpdateMainProp(new List<PhBaPlanAttr>());
			}
		}
	}

	// Token: 0x060126CB RID: 75467 RVA: 0x0048B5A8 File Offset: 0x004897A8
	public void CacheSharePropMap(List<PhBaOneCostPlan> propData)
	{
		HashSet<int> hashSet = new HashSet<int>();
		foreach (PhBaOneCostPlan phBaOneCostPlan in propData)
		{
			hashSet.Add((int)phBaOneCostPlan.CostType);
			this.TryInitCost((int)phBaOneCostPlan.CostType);
			this.CostMap[(int)phBaOneCostPlan.CostType].CacheShareProp(phBaOneCostPlan.AttrList.ToList<PhBaPlanAttr>());
		}
		foreach (KeyValuePair<int, PhantomManagerConfigCostGroupData> keyValuePair in this.CostMap)
		{
			if (!hashSet.Contains(keyValuePair.Key))
			{
				keyValuePair.Value.CacheShareProp(new List<PhBaPlanAttr>());
			}
		}
	}

	// Token: 0x060126CC RID: 75468 RVA: 0x0048B68C File Offset: 0x0048988C
	public void TryInitCost(int cost)
	{
		if (!this.CostMap.ContainsKey(cost))
		{
			this.CostMap[cost] = new PhantomManagerConfigCostGroupData(this.FetterId, cost);
		}
	}

	// Token: 0x060126CD RID: 75469 RVA: 0x0048B6B4 File Offset: 0x004898B4
	public EPhantomManagerConfigState GetPropCurrentState(IPhantomManagerConfigNewSettingDetailInfo data)
	{
		PhantomManagerConfigCostGroupData phantomManagerConfigCostGroupData;
		if (!this.CostMap.TryGetValue(data.Cost, out phantomManagerConfigCostGroupData))
		{
			return EPhantomManagerConfigState.Default;
		}
		return phantomManagerConfigCostGroupData.GetPropCurrentState(data.MainPropId);
	}

	// Token: 0x060126CE RID: 75470 RVA: 0x0048B6E4 File Offset: 0x004898E4
	public void SetPropState(IPhantomManagerConfigNewSettingDetailInfo data, EPhantomManagerConfigState state, bool isCache)
	{
		this.TryInitCost(data.Cost);
		this.CostMap[data.Cost].SetPropState(data.MainPropId, state, isCache);
	}

	// Token: 0x060126CF RID: 75471 RVA: 0x0048B710 File Offset: 0x00489910
	public void DoCacheDataUpdate(bool apply)
	{
		foreach (KeyValuePair<int, PhantomManagerConfigCostGroupData> keyValuePair in this.CostMap)
		{
			keyValuePair.Value.DoCacheDataUpdate(apply);
		}
	}

	// Token: 0x060126D0 RID: 75472 RVA: 0x0048B76C File Offset: 0x0048996C
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

	// Token: 0x060126D1 RID: 75473 RVA: 0x0048B82C File Offset: 0x00489A2C
	public void ResetFetterConfig()
	{
		foreach (KeyValuePair<int, PhantomManagerConfigCostGroupData> keyValuePair in this.CostMap)
		{
			keyValuePair.Value.ResetConfig();
		}
	}

	// Token: 0x060126D2 RID: 75474 RVA: 0x0048B884 File Offset: 0x00489A84
	public bool GetEditFetterConfigRecommendDirty()
	{
		IReadOnlyList<PhantomManagePlanV2> phantomManagerPlanByFetterId = PhantomBattleConfig.Instance.GetPhantomManagerPlanByFetterId(this.FetterId);
		if (this.CostMap.Count != phantomManagerPlanByFetterId.Count)
		{
			return true;
		}
		HashSet<int> configCostSet = new HashSet<int>();
		foreach (PhantomManagePlanV2 config in phantomManagerPlanByFetterId)
		{
			if (!this.CostMap.ContainsKey(config.Cost))
			{
				return true;
			}
			configCostSet.Add(config.Cost);
			if (this.CostMap[config.Cost].GetRecommendDirty(config))
			{
				return true;
			}
		}
		return this.CostMap.Keys.Any((int cost) => !configCostSet.Contains(cost));
	}

	// Token: 0x060126D3 RID: 75475 RVA: 0x0048B968 File Offset: 0x00489B68
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
		foreach (int num in this.CostMap.Keys.ToList<int>())
		{
			if (!hashSet.Contains(num))
			{
				this.CostMap.Remove(num);
			}
		}
		return flag;
	}

	// Token: 0x060126D4 RID: 75476 RVA: 0x0048BA84 File Offset: 0x00489C84
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

	// Token: 0x04008B55 RID: 35669
	protected readonly Dictionary<int, PhantomManagerConfigCostGroupData> CostMap = new Dictionary<int, PhantomManagerConfigCostGroupData>();

	// Token: 0x04008B56 RID: 35670
	public int FetterId;
}
