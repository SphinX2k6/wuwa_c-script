using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020027B4 RID: 10164
[NullableContext(1)]
[Nullable(0)]
public class RolePhantomData : RoleModuleDataBase
{
	// Token: 0x06014E6C RID: 85612 RVA: 0x0054EB45 File Offset: 0x0054CD45
	public RolePhantomData(int roleId) : base(roleId)
	{
	}

	// Token: 0x06014E6D RID: 85613 RVA: 0x0054EB6F File Offset: 0x0054CD6F
	public void RefreshPhantom(int key, int value)
	{
		this.PhantomMap[key] = value;
	}

	// Token: 0x06014E6E RID: 85614 RVA: 0x0054EB7E File Offset: 0x0054CD7E
	public void SetIsTrial(bool isTrial)
	{
		this.IsTrial = isTrial;
	}

	// Token: 0x06014E6F RID: 85615 RVA: 0x0054EB87 File Offset: 0x0054CD87
	public void SetDataMap(int position, PhantomDataBase data)
	{
		this.DataMap[position] = data;
	}

	// Token: 0x06014E70 RID: 85616 RVA: 0x0054EB98 File Offset: 0x0054CD98
	public Dictionary<int, PhantomDataBase> GetDataMap()
	{
		if (this.IsTrial)
		{
			return this.DataMap;
		}
		List<int> incrIdList = PhantomBattleModel.Instance.GetBattleDataById(this.RoleId).GetIncrIdList();
		if (incrIdList == null)
		{
			return this.DataMap;
		}
		int i = 0;
		int count = incrIdList.Count;
		while (i < count)
		{
			int uniqueId = incrIdList[i];
			PhantomBattleData phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleData(uniqueId);
			this.DataMap[i] = phantomBattleData;
			i++;
		}
		return this.DataMap;
	}

	// Token: 0x06014E71 RID: 85617 RVA: 0x0054EC10 File Offset: 0x0054CE10
	public List<int> GetIncrIdList()
	{
		return PhantomBattleModel.Instance.GetBattleDataById(this.RoleId).GetIncrIdList();
	}

	// Token: 0x06014E72 RID: 85618 RVA: 0x0054EC28 File Offset: 0x0054CE28
	[NullableContext(2)]
	public PhantomDataBase GetDataByIndex(int index)
	{
		PhantomDataBase result;
		if (!this.GetDataMap().TryGetValue(index, out result))
		{
			return null;
		}
		return result;
	}

	// Token: 0x06014E73 RID: 85619 RVA: 0x0054EC48 File Offset: 0x0054CE48
	public VisionFetterData[] GetPhantomFettersData()
	{
		List<VisionFetterData> list = new List<VisionFetterData>();
		foreach (KeyValuePair<int, Dictionary<int, int>> keyValuePair in this.GetPhantomFetterMap())
		{
			int key = keyValuePair.Key;
			foreach (KeyValuePair<int, int> keyValuePair2 in keyValuePair.Value)
			{
				int key2 = keyValuePair2.Key;
				int value = keyValuePair2.Value;
				list.Add(new VisionFetterData
				{
					FetterGroupId = key,
					FetterId = key2,
					NeedActiveNum = value,
					ActiveFetterGroupNum = value,
					ActiveState = true
				});
			}
		}
		return list.ToArray();
	}

	// Token: 0x06014E74 RID: 85620 RVA: 0x0054ED38 File Offset: 0x0054CF38
	public Dictionary<int, Dictionary<int, int>> GetPhantomFetterMap()
	{
		Dictionary<int, int> fetterGroupSuitMap = this.GetFetterGroupSuitMap();
		return PhantomBattleConfig.Instance.GetFetterMapResultBySuitMap(fetterGroupSuitMap);
	}

	// Token: 0x06014E75 RID: 85621 RVA: 0x0054ED58 File Offset: 0x0054CF58
	public List<int> GetPhantomFettersList()
	{
		Dictionary<int, int> fetterGroupSuitMap = this.GetFetterGroupSuitMap();
		this.FettersList = PhantomBattleConfig.Instance.GetFetterResultBySuitMap(fetterGroupSuitMap);
		return this.FettersList;
	}

	// Token: 0x06014E76 RID: 85622 RVA: 0x0054ED84 File Offset: 0x0054CF84
	private Dictionary<int, int> GetFetterGroupSuitMap()
	{
		Dictionary<int, PhantomDataBase> dataMap = this.GetDataMap();
		List<PhantomDataBase> list = new List<PhantomDataBase>();
		foreach (KeyValuePair<int, PhantomDataBase> keyValuePair in dataMap)
		{
			int key = keyValuePair.Key;
			PhantomDataBase value = keyValuePair.Value;
			if (value != null)
			{
				list.Add(value);
			}
		}
		return PhantomDataBase.CalculateFetterByPhantomBattleData(list);
	}

	// Token: 0x06014E77 RID: 85623 RVA: 0x0054EDF8 File Offset: 0x0054CFF8
	public void ClearPhantomFettersList()
	{
		this.FettersList.Clear();
	}

	// Token: 0x04009D06 RID: 40198
	protected Dictionary<int, int> PhantomMap = new Dictionary<int, int>();

	// Token: 0x04009D07 RID: 40199
	private bool IsTrial;

	// Token: 0x04009D08 RID: 40200
	private readonly Dictionary<int, PhantomDataBase> DataMap = new Dictionary<int, PhantomDataBase>();

	// Token: 0x04009D09 RID: 40201
	private List<int> FettersList = new List<int>();
}
