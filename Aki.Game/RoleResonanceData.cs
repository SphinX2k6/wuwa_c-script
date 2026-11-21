using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001D30 RID: 7472
[NullableContext(1)]
[Nullable(0)]
public class RoleResonanceData : RoleModuleDataBase
{
	// Token: 0x06012877 RID: 75895 RVA: 0x00579B2D File Offset: 0x00577D2D
	public RoleResonanceData(int roleId) : base(roleId)
	{
	}

	// Token: 0x06012878 RID: 75896 RVA: 0x00579B4C File Offset: 0x00577D4C
	public void SetResonance(ResonanceDataInfo resonance)
	{
		this.ResonanceInfoMap[resonance.ResonId] = resonance;
	}

	// Token: 0x06012879 RID: 75897 RVA: 0x00579B60 File Offset: 0x00577D60
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

	// Token: 0x0601287A RID: 75898 RVA: 0x00579B80 File Offset: 0x00577D80
	public void SetResonanceLock(int resonanceId)
	{
		this.ResonanceLockSet.Add(resonanceId);
	}

	// Token: 0x0601287B RID: 75899 RVA: 0x00579B8F File Offset: 0x00577D8F
	public void SetResonantChainGroupIndex(int index)
	{
		this.ResonantChainGroupIndex = index;
	}

	// Token: 0x0601287C RID: 75900 RVA: 0x00579B98 File Offset: 0x00577D98
	public int GetResonantChainGroupIndex()
	{
		return this.ResonantChainGroupIndex;
	}

	// Token: 0x0601287D RID: 75901 RVA: 0x00579BA0 File Offset: 0x00577DA0
	public bool CheckFrontResonanceOpen(int id, int groupId)
	{
		return true;
	}

	// Token: 0x0601287E RID: 75902 RVA: 0x00579BA4 File Offset: 0x00577DA4
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

	// Token: 0x0601287F RID: 75903 RVA: 0x00579C60 File Offset: 0x00577E60
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

	// Token: 0x06012880 RID: 75904 RVA: 0x00579CC0 File Offset: 0x00577EC0
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

	// Token: 0x06012881 RID: 75905 RVA: 0x00579D28 File Offset: 0x00577F28
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

	// Token: 0x06012882 RID: 75906 RVA: 0x00579DB0 File Offset: 0x00577FB0
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

	// Token: 0x06012883 RID: 75907 RVA: 0x00579E9C File Offset: 0x0057809C
	public void Clear()
	{
		this.ResonantChainGroupIndex = 0;
		this.ResonanceInfoMap.Clear();
		this.ResonanceLockSet.Clear();
	}

	// Token: 0x0400A0ED RID: 41197
	protected int ResonantChainGroupIndex;

	// Token: 0x0400A0EE RID: 41198
	protected Dictionary<int, ResonanceDataInfo> ResonanceInfoMap = new Dictionary<int, ResonanceDataInfo>();

	// Token: 0x0400A0EF RID: 41199
	protected HashSet<int> ResonanceLockSet = new HashSet<int>();
}
