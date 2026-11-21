using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x020018E1 RID: 6369
[NullableContext(1)]
[Nullable(0)]
public class PhantomManagerConfigCostGroupData
{
	// Token: 0x0600FB87 RID: 64391 RVA: 0x00499000 File Offset: 0x00497200
	public PhantomManagerConfigCostGroupData(int fetterId, int cost)
	{
		this.FetterId = fetterId;
		this.Cost = cost;
	}

	// Token: 0x0600FB88 RID: 64392 RVA: 0x0049902C File Offset: 0x0049722C
	public void UpdateMainProp(IEnumerable<PhBaPlanAttr> attrList)
	{
		HashSet<int> hashSet = new HashSet<int>();
		foreach (PhBaPlanAttr phBaPlanAttr in attrList)
		{
			hashSet.Add(phBaPlanAttr.AttrId);
			this.MainPropMap[phBaPlanAttr.AttrId] = (EPhantomManagerConfigState)phBaPlanAttr.Deal;
		}
		foreach (int num in this.MainPropMap.Keys)
		{
			if (!hashSet.Contains(num))
			{
				this.MainPropMap.Remove(num);
			}
		}
	}

	// Token: 0x0600FB89 RID: 64393 RVA: 0x004990F0 File Offset: 0x004972F0
	public void CacheShareProp(IEnumerable<PhBaPlanAttr> attrList)
	{
		HashSet<int> hashSet = new HashSet<int>();
		foreach (PhBaPlanAttr phBaPlanAttr in attrList)
		{
			hashSet.Add(phBaPlanAttr.AttrId);
			this.CachePropMap[phBaPlanAttr.AttrId] = (EPhantomManagerConfigState)phBaPlanAttr.Deal;
		}
		foreach (int num in this.MainPropMap.Keys)
		{
			if (!hashSet.Contains(num))
			{
				this.CachePropMap[num] = EPhantomManagerConfigState.Default;
			}
		}
	}

	// Token: 0x0600FB8A RID: 64394 RVA: 0x004991B4 File Offset: 0x004973B4
	public void SetPropState(int mainProp, EPhantomManagerConfigState state, bool isCache)
	{
		if (isCache)
		{
			this.CachePropMap[mainProp] = state;
			return;
		}
		this.MainPropMap[mainProp] = state;
	}

	// Token: 0x0600FB8B RID: 64395 RVA: 0x004991D4 File Offset: 0x004973D4
	public void DoCacheDataUpdate(bool apply)
	{
		if (apply)
		{
			foreach (KeyValuePair<int, EPhantomManagerConfigState> keyValuePair in this.CachePropMap)
			{
				this.MainPropMap[keyValuePair.Key] = keyValuePair.Value;
			}
		}
		this.CachePropMap.Clear();
	}

	// Token: 0x0600FB8C RID: 64396 RVA: 0x00499248 File Offset: 0x00497448
	[return: Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	public ValueTuple<bool, List<PhBaPlanAttr>> GetCacheProtoData()
	{
		List<PhBaPlanAttr> list = new List<PhBaPlanAttr>();
		bool item = false;
		foreach (KeyValuePair<int, EPhantomManagerConfigState> keyValuePair in this.MainPropMap)
		{
			if (!this.CachePropMap.ContainsKey(keyValuePair.Key) && keyValuePair.Value != EPhantomManagerConfigState.Default)
			{
				PhBaPlanAttr phBaPlanAttr = PhBaPlanAttr.Create();
				phBaPlanAttr.AttrId = keyValuePair.Key;
				phBaPlanAttr.Deal = (PhBaPlanAttrDeal)keyValuePair.Value;
				list.Add(phBaPlanAttr);
			}
		}
		foreach (KeyValuePair<int, EPhantomManagerConfigState> keyValuePair2 in this.CachePropMap)
		{
			if ((!this.MainPropMap.ContainsKey(keyValuePair2.Key) && keyValuePair2.Value != EPhantomManagerConfigState.Default) || (this.MainPropMap.ContainsKey(keyValuePair2.Key) && this.MainPropMap[keyValuePair2.Key] != keyValuePair2.Value))
			{
				item = true;
			}
			PhBaPlanAttr phBaPlanAttr2 = PhBaPlanAttr.Create();
			phBaPlanAttr2.AttrId = keyValuePair2.Key;
			phBaPlanAttr2.Deal = (PhBaPlanAttrDeal)keyValuePair2.Value;
			list.Add(phBaPlanAttr2);
		}
		return new ValueTuple<bool, List<PhBaPlanAttr>>(item, list);
	}

	// Token: 0x0600FB8D RID: 64397 RVA: 0x004993A8 File Offset: 0x004975A8
	public void ResetConfig()
	{
		this.CachePropMap.Clear();
		foreach (KeyValuePair<int, EPhantomManagerConfigState> keyValuePair in this.MainPropMap)
		{
			if (keyValuePair.Value != EPhantomManagerConfigState.Default)
			{
				this.CachePropMap[keyValuePair.Key] = EPhantomManagerConfigState.Default;
			}
		}
	}

	// Token: 0x0600FB8E RID: 64398 RVA: 0x0049941C File Offset: 0x0049761C
	public EPhantomManagerConfigState GetPropCurrentState(int id)
	{
		EPhantomManagerConfigState result;
		if (!this.CachePropMap.TryGetValue(id, out result))
		{
			return this.MainPropMap.GetValueOrDefault(id, EPhantomManagerConfigState.Default);
		}
		return result;
	}

	// Token: 0x0600FB8F RID: 64399 RVA: 0x00499448 File Offset: 0x00497648
	public bool GetRecommendDirty(PhantomManagePlanV2 config)
	{
		foreach (int id in config.DiscardGroupIter())
		{
			if (this.GetPropCurrentState(id) != EPhantomManagerConfigState.Discard)
			{
				return true;
			}
		}
		foreach (int id2 in config.LockGroupIter())
		{
			if (this.GetPropCurrentState(id2) != EPhantomManagerConfigState.Lock)
			{
				return true;
			}
		}
		foreach (KeyValuePair<int, EPhantomManagerConfigState> keyValuePair in this.MainPropMap)
		{
			if (!config.GetDiscardGroupBytes().Contains(keyValuePair.Key) && !NoLinq.Contains<int>(config.GetLockGroupBytes(), keyValuePair.Key) && keyValuePair.Value != EPhantomManagerConfigState.Default)
			{
				return true;
			}
		}
		foreach (KeyValuePair<int, EPhantomManagerConfigState> keyValuePair2 in this.CachePropMap)
		{
			if (!config.GetDiscardGroupBytes().Contains(keyValuePair2.Key) && !NoLinq.Contains<int>(config.GetLockGroupBytes(), keyValuePair2.Key) && keyValuePair2.Value != EPhantomManagerConfigState.Default)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600FB90 RID: 64400 RVA: 0x004995D8 File Offset: 0x004977D8
	public bool CacheRecommend(PhantomManagePlanV2 config)
	{
		this.CachePropMap.Clear();
		foreach (KeyValuePair<int, EPhantomManagerConfigState> keyValuePair in this.MainPropMap)
		{
			if (!config.GetDiscardGroupBytes().Contains(keyValuePair.Key) && !NoLinq.Contains<int>(config.GetLockGroupBytes(), keyValuePair.Key) && keyValuePair.Value != EPhantomManagerConfigState.Default)
			{
				this.CachePropMap[keyValuePair.Key] = EPhantomManagerConfigState.Default;
			}
		}
		foreach (int key in config.DiscardGroupIter())
		{
			if (!this.MainPropMap.ContainsKey(key) || this.MainPropMap[key] != EPhantomManagerConfigState.Discard)
			{
				this.CachePropMap[key] = EPhantomManagerConfigState.Discard;
			}
		}
		foreach (int key2 in config.LockGroupIter())
		{
			if (!this.MainPropMap.ContainsKey(key2) || this.MainPropMap[key2] != EPhantomManagerConfigState.Lock)
			{
				this.CachePropMap[key2] = EPhantomManagerConfigState.Lock;
			}
		}
		return this.CachePropMap.Count > 0;
	}

	// Token: 0x0600FB91 RID: 64401 RVA: 0x00499748 File Offset: 0x00497948
	public List<PhantomDiscardPlanPlanLogData> GetLogReport()
	{
		PhantomDiscardPlanPlanLogData phantomDiscardPlanPlanLogData = new PhantomDiscardPlanPlanLogData();
		PhantomDiscardPlanPlanLogData phantomDiscardPlanPlanLogData2 = new PhantomDiscardPlanPlanLogData();
		phantomDiscardPlanPlanLogData.i_cost = this.Cost;
		phantomDiscardPlanPlanLogData.i_type = 1;
		phantomDiscardPlanPlanLogData2.i_cost = this.Cost;
		phantomDiscardPlanPlanLogData2.i_type = 0;
		foreach (KeyValuePair<int, EPhantomManagerConfigState> keyValuePair in this.MainPropMap)
		{
			if (keyValuePair.Value == EPhantomManagerConfigState.Lock)
			{
				phantomDiscardPlanPlanLogData.s_setting.Add(keyValuePair.Key);
			}
			else if (keyValuePair.Value == EPhantomManagerConfigState.Discard)
			{
				phantomDiscardPlanPlanLogData2.s_setting.Add(keyValuePair.Key);
			}
		}
		List<PhantomDiscardPlanPlanLogData> list = new List<PhantomDiscardPlanPlanLogData>();
		if (phantomDiscardPlanPlanLogData.s_setting.Count > 0)
		{
			list.Add(phantomDiscardPlanPlanLogData);
		}
		if (phantomDiscardPlanPlanLogData2.s_setting.Count > 0)
		{
			list.Add(phantomDiscardPlanPlanLogData2);
		}
		return list;
	}

	// Token: 0x04008C9E RID: 35998
	public Dictionary<int, EPhantomManagerConfigState> MainPropMap = new Dictionary<int, EPhantomManagerConfigState>();

	// Token: 0x04008C9F RID: 35999
	public Dictionary<int, EPhantomManagerConfigState> CachePropMap = new Dictionary<int, EPhantomManagerConfigState>();

	// Token: 0x04008CA0 RID: 36000
	public int FetterId;

	// Token: 0x04008CA1 RID: 36001
	public int Cost;
}
