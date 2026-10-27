using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020027B5 RID: 10165
[NullableContext(1)]
[Nullable(0)]
public class RoleResonanceData : RoleModuleDataBase
{
	// Token: 0x06014E78 RID: 85624 RVA: 0x0054EE05 File Offset: 0x0054D005
	public RoleResonanceData(int roleId) : base(roleId)
	{
	}

	// Token: 0x06014E79 RID: 85625 RVA: 0x0054EE24 File Offset: 0x0054D024
	public void SetResonance(ResonanceDataInfo resonance)
	{
		this.ResonanceInfoMap[resonance.ResonId] = resonance;
	}

	// Token: 0x06014E7A RID: 85626 RVA: 0x0054EE38 File Offset: 0x0054D038
	[NullableContext(2)]
	public ResonanceDataInfo GetResonance(int id)
	{
		ResonanceDataInfo result;
		if (!this.ResonanceInfoMap.TryGetValue(id, out result))
		{
			return null;
		}
		return result;
	}

	// Token: 0x06014E7B RID: 85627 RVA: 0x0054EE58 File Offset: 0x0054D058
	public void SetResonanceLock(int resonanceId)
	{
		this.ResonanceLockSet.Add(resonanceId);
	}

	// Token: 0x06014E7C RID: 85628 RVA: 0x0054EE67 File Offset: 0x0054D067
	public void SetResonantChainGroupIndex(int index)
	{
		this.ResonantChainGroupIndex = index;
	}

	// Token: 0x06014E7D RID: 85629 RVA: 0x0054EE70 File Offset: 0x0054D070
	public int GetResonantChainGroupIndex()
	{
		return this.ResonantChainGroupIndex;
	}

	// Token: 0x06014E7E RID: 85630 RVA: 0x0054EE78 File Offset: 0x0054D078
	public bool CheckFrontResonanceOpen(int id, int groupId)
	{
		return true;
	}

	// Token: 0x06014E7F RID: 85631 RVA: 0x0054EE7C File Offset: 0x0054D07C
	public bool IsEnoughResonanceActive(int resonanceId)
	{
		ResonantChain? roleResonanceById = RoleResonanceConfig.Instance.GetRoleResonanceById(resonanceId);
		if (roleResonanceById == null)
		{
			return false;
		}
		if (!this.CheckFrontResonanceOpen(roleResonanceById.Value.Id, roleResonanceById.Value.GroupId))
		{
			return false;
		}
		if (!true)
		{
			return false;
		}
		foreach (DicIntInt dicIntInt in roleResonanceById.Value.ActivateConsumeIter())
		{
			if (InventoryModel.Instance.GetItemCountByConfigId(dicIntInt.Key, 0) < dicIntInt.Value)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06014E80 RID: 85632 RVA: 0x0054EF38 File Offset: 0x0054D138
	public int GetResonanceLevel()
	{
		int num = 0;
		using (Dictionary<int, ResonanceDataInfo>.ValueCollection.Enumerator enumerator = this.ResonanceInfoMap.Values.GetEnumerator())
		{
			while (enumerator.MoveNext() && enumerator.Current.IsOpen)
			{
				num++;
			}
		}
		return num;
	}

	// Token: 0x06014E81 RID: 85633 RVA: 0x0054EF98 File Offset: 0x0054D198
	public int GetResonanceIncreaseLevel()
	{
		int num = 0;
		foreach (ResonanceDataInfo resonanceDataInfo in this.ResonanceInfoMap.Values)
		{
			if (!resonanceDataInfo.IsOpen)
			{
				break;
			}
			num += resonanceDataInfo.Increase;
		}
		return num;
	}

	// Token: 0x06014E82 RID: 85634 RVA: 0x0054F000 File Offset: 0x0054D200
	public bool IsResonanceFullyUnLock()
	{
		int resonanceId = base.GetRoleConfig().ResonanceId;
		foreach (ResonantChain resonantChain in RoleResonanceConfig.Instance.GetRoleResonanceList(resonanceId))
		{
			ResonanceDataInfo resonance = this.GetResonance(resonantChain.Id);
			if (resonance == null || !resonance.IsOpen)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06014E83 RID: 85635 RVA: 0x0054F088 File Offset: 0x0054D288
	public void CopyFrom(RoleResonanceData data)
	{
		this.ResonantChainGroupIndex = data.ResonantChainGroupIndex;
		this.ResonanceInfoMap.Clear();
		foreach (KeyValuePair<int, ResonanceDataInfo> keyValuePair in data.ResonanceInfoMap)
		{
			ResonanceDataInfo value = keyValuePair.Value;
			this.ResonanceInfoMap[keyValuePair.Key] = new ResonanceDataInfo(value.ResonId, value.IsOpen, value.Increase);
		}
		this.ResonanceLockSet.Clear();
		foreach (int item in data.ResonanceLockSet)
		{
			this.ResonanceLockSet.Add(item);
		}
	}

	// Token: 0x06014E84 RID: 85636 RVA: 0x0054F174 File Offset: 0x0054D374
	public void Clear()
	{
		this.ResonantChainGroupIndex = 0;
		this.ResonanceInfoMap.Clear();
		this.ResonanceLockSet.Clear();
	}

	// Token: 0x04009D0A RID: 40202
	protected int ResonantChainGroupIndex;

	// Token: 0x04009D0B RID: 40203
	protected Dictionary<int, ResonanceDataInfo> ResonanceInfoMap = new Dictionary<int, ResonanceDataInfo>();

	// Token: 0x04009D0C RID: 40204
	protected HashSet<int> ResonanceLockSet = new HashSet<int>();
}
