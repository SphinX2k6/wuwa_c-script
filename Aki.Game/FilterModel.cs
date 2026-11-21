using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common;
using FilterDefine;

// Token: 0x02000D08 RID: 3336
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class FilterModel : ModelBase
{
	// Token: 0x06008A2D RID: 35373 RVA: 0x0029DC75 File Offset: 0x0029BE75
	public void SetFilterResultData(FilterResultData viewData)
	{
		this.FilterResultDataMap[viewData.UniqueId] = viewData;
	}

	// Token: 0x06008A2E RID: 35374 RVA: 0x0029DC89 File Offset: 0x0029BE89
	public void DeleteFilterResultData(int uniqueId)
	{
		if (uniqueId == -1)
		{
			return;
		}
		this.FilterResultDataMap.Remove(uniqueId);
	}

	// Token: 0x06008A2F RID: 35375 RVA: 0x0029DCA0 File Offset: 0x0029BEA0
	[NullableContext(2)]
	public FilterResultData GetFilterResultData(int uniqueId)
	{
		if (uniqueId == -1)
		{
			return null;
		}
		FilterResultData result;
		this.FilterResultDataMap.TryGetValue(uniqueId, out result);
		return result;
	}

	// Token: 0x06008A30 RID: 35376 RVA: 0x0029DCC4 File Offset: 0x0029BEC4
	public void ClearData(int uniqueId)
	{
		if (uniqueId == -1)
		{
			return;
		}
		FilterResultData filterResultData;
		if (this.FilterResultDataMap.TryGetValue(uniqueId, out filterResultData) && filterResultData != null)
		{
			filterResultData.ClearSelectRuleData();
		}
	}

	// Token: 0x06008A31 RID: 35377 RVA: 0x0029DCF0 File Offset: 0x0029BEF0
	public List<T> GetFilterList<[Nullable(2)] T>(List<T> dataList, int filterId, Dictionary<FilterDefine.EFilterType, Dictionary<int, string>> ruleData)
	{
		Filter? filterConfig = FilterConfig.Instance.GetFilterConfig(filterId);
		EFilterDataType dataType = (EFilterDataType)filterConfig.Value.DataType;
		bool isSupportSelectAll = filterConfig.Value.IsSupportSelectAll;
		bool isSelectAllUnion = filterConfig.Value.IsSelectAllUnion;
		return this.FilterLogic.GetFilterList<T>(dataList, dataType, isSupportSelectAll, isSelectAllUnion, ruleData);
	}

	// Token: 0x06008A32 RID: 35378 RVA: 0x0029DD4C File Offset: 0x0029BF4C
	public Func<int[], FilterItemData[]> GetFilterDataFuncByFilterType(FilterDefine.EFilterType filterType)
	{
		return this.FilterLogic.GetDataFuncByType(filterType);
	}

	// Token: 0x06008A33 RID: 35379 RVA: 0x0029DD5A File Offset: 0x0029BF5A
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public List<FilterItemData> GetFilterItemDataList(int ruleId, int configId)
	{
		return this.FilterLogic.GetFilterItemDataList(ruleId, configId);
	}

	// Token: 0x06008A34 RID: 35380 RVA: 0x0029DD6C File Offset: 0x0029BF6C
	[return: Nullable(2)]
	public FilterStorageData GetFilterConfigData(EFilterSortConfigId saveConfigId, int groupId, string extraParam)
	{
		if (!SortConfig.Instance.IsConfigSortSave(saveConfigId, groupId))
		{
			return null;
		}
		string configSortFormatId = SortConfig.Instance.GetConfigSortFormatId(saveConfigId, groupId, extraParam);
		Dictionary<string, FilterStorageData> player = LocalStorage.GetPlayer<Dictionary<string, FilterStorageData>>(ELocalStoragePlayerKey.FilterConfig, null);
		FilterStorageData result;
		if (player != null && player.TryGetValue(configSortFormatId, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x06008A35 RID: 35381 RVA: 0x0029DDB4 File Offset: 0x0029BFB4
	public void SetFilterConfigData(EFilterSortConfigId saveConfigId, int groupId, FilterStorageData data, string extraParam)
	{
		if (!SortConfig.Instance.IsConfigSortSave(saveConfigId, groupId))
		{
			return;
		}
		string configSortFormatId = SortConfig.Instance.GetConfigSortFormatId(saveConfigId, groupId, extraParam);
		Dictionary<string, FilterStorageData> dictionary = LocalStorage.GetPlayer<Dictionary<string, FilterStorageData>>(ELocalStoragePlayerKey.FilterConfig, null);
		if (dictionary == null)
		{
			dictionary = new Dictionary<string, FilterStorageData>();
		}
		dictionary[configSortFormatId] = data;
		LocalStorage.SetPlayer<Dictionary<string, FilterStorageData>>(ELocalStoragePlayerKey.FilterConfig, dictionary);
	}

	// Token: 0x06008A36 RID: 35382 RVA: 0x0029DE04 File Offset: 0x0029C004
	public void ClearFilterConfigData(EFilterSortConfigId saveConfigId, int groupId, string extraParam)
	{
		if (!SortConfig.Instance.IsConfigSortSave(saveConfigId, groupId))
		{
			return;
		}
		string configSortFormatId = SortConfig.Instance.GetConfigSortFormatId(saveConfigId, groupId, extraParam);
		Dictionary<string, FilterStorageData> player = LocalStorage.GetPlayer<Dictionary<string, FilterStorageData>>(ELocalStoragePlayerKey.FilterConfig, null);
		if (player != null)
		{
			player.Remove(configSortFormatId);
			LocalStorage.SetPlayer<Dictionary<string, FilterStorageData>>(ELocalStoragePlayerKey.FilterConfig, player);
		}
	}

	// Token: 0x17000F50 RID: 3920
	// (get) Token: 0x06008A37 RID: 35383 RVA: 0x0029DE4B File Offset: 0x0029C04B
	public static FilterModel Instance
	{
		get
		{
			return FilterModel._Instance;
		}
	}

	// Token: 0x06008A38 RID: 35384 RVA: 0x0029DE52 File Offset: 0x0029C052
	public static FilterModel GetOrCreateInstance()
	{
		if (FilterModel._Instance == null)
		{
			FilterModel.CreateInstance();
		}
		return FilterModel._Instance;
	}

	// Token: 0x06008A39 RID: 35385 RVA: 0x0029DE66 File Offset: 0x0029C066
	public static bool CreateInstance()
	{
		if (FilterModel._Instance != null)
		{
			return true;
		}
		FilterModel._Instance = new FilterModel();
		return true;
	}

	// Token: 0x06008A3A RID: 35386 RVA: 0x0029DE7C File Offset: 0x0029C07C
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06008A3B RID: 35387 RVA: 0x0029DE7E File Offset: 0x0029C07E
	public static void ResetStaticDefaultValue()
	{
		FilterModel._Instance = null;
	}

	// Token: 0x06008A3C RID: 35388 RVA: 0x0029DE86 File Offset: 0x0029C086
	static FilterModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FilterModel.CreateStaticDefaultValue), new Action(FilterModel.ResetStaticDefaultValue));
	}

	// Token: 0x04005312 RID: 21266
	private readonly Dictionary<int, FilterResultData> FilterResultDataMap = new Dictionary<int, FilterResultData>();

	// Token: 0x04005313 RID: 21267
	private readonly FilterLogic FilterLogic = new FilterLogic();

	// Token: 0x04005314 RID: 21268
	[Nullable(2)]
	private static FilterModel _Instance;
}
