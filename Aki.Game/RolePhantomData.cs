using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001D2F RID: 7471
[NullableContext(1)]
[Nullable(0)]
public class RolePhantomData : RoleModuleDataBase
{
	// Token: 0x0601286B RID: 75883 RVA: 0x0057986D File Offset: 0x00577A6D
	public RolePhantomData(int roleId) : base(roleId)
	{
	}

	// Token: 0x0601286C RID: 75884 RVA: 0x00579897 File Offset: 0x00577A97
	public void RefreshPhantom(int key, int value)
	{
		this.PhantomMap[key] = value;
	}

	// Token: 0x0601286D RID: 75885 RVA: 0x005798A6 File Offset: 0x00577AA6
	public void SetIsTrial(bool isTrial)
	{
		this.IsTrial = isTrial;
	}

	// Token: 0x0601286E RID: 75886 RVA: 0x005798AF File Offset: 0x00577AAF
	public void SetDataMap(int position, PhantomDataBase data)
	{
		this.DataMap[position] = data;
	}

	// Token: 0x0601286F RID: 75887 RVA: 0x005798C0 File Offset: 0x00577AC0
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

	// Token: 0x06012870 RID: 75888 RVA: 0x00579938 File Offset: 0x00577B38
	public List<int> GetIncrIdList()
	{
		return PhantomBattleModel.Instance.GetBattleDataById(this.RoleId).GetIncrIdList();
	}

	// Token: 0x06012871 RID: 75889 RVA: 0x00579950 File Offset: 0x00577B50
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

	// Token: 0x06012872 RID: 75890 RVA: 0x00579970 File Offset: 0x00577B70
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

	// Token: 0x06012873 RID: 75891 RVA: 0x00579A60 File Offset: 0x00577C60
	public Dictionary<int, Dictionary<int, int>> GetPhantomFetterMap()
	{
		Dictionary<int, int> fetterGroupSuitMap = this.GetFetterGroupSuitMap();
		return PhantomBattleConfig.Instance.GetFetterMapResultBySuitMap(fetterGroupSuitMap);
	}

	// Token: 0x06012874 RID: 75892 RVA: 0x00579A80 File Offset: 0x00577C80
	public List<int> GetPhantomFettersList()
	{
		Dictionary<int, int> fetterGroupSuitMap = this.GetFetterGroupSuitMap();
		this.FettersList = PhantomBattleConfig.Instance.GetFetterResultBySuitMap(fetterGroupSuitMap);
		return this.FettersList;
	}

	// Token: 0x06012875 RID: 75893 RVA: 0x00579AAC File Offset: 0x00577CAC
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

	// Token: 0x06012876 RID: 75894 RVA: 0x00579B20 File Offset: 0x00577D20
	public void ClearPhantomFettersList()
	{
		this.FettersList.Clear();
	}

	// Token: 0x0400A0E9 RID: 41193
	protected Dictionary<int, int> PhantomMap = new Dictionary<int, int>();

	// Token: 0x0400A0EA RID: 41194
	private bool IsTrial;

	// Token: 0x0400A0EB RID: 41195
	private readonly Dictionary<int, PhantomDataBase> DataMap = new Dictionary<int, PhantomDataBase>();

	// Token: 0x0400A0EC RID: 41196
	private List<int> FettersList = new List<int>();
}
