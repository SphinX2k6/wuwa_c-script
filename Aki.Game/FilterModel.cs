using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common;
using FilterDefine;

// Token: 0x0200184F RID: 6223
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class FilterModel : ModelBase
{
	// Token: 0x0600B644 RID: 46660 RVA: 0x00293565 File Offset: 0x00291765
	public void SetFilterResultData(FilterResultData viewData)
	{
		this.FilterResultDataMap[viewData.UniqueId] = viewData;
	}

	// Token: 0x0600B645 RID: 46661 RVA: 0x00293579 File Offset: 0x00291779
	public void DeleteFilterResultData(int uniqueId)
	{
		if (uniqueId == -1)
		{
			return;
		}
		this.FilterResultDataMap.Remove(uniqueId);
	}

	// Token: 0x0600B646 RID: 46662 RVA: 0x00293590 File Offset: 0x00291790
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

	// Token: 0x0600B647 RID: 46663 RVA: 0x002935B4 File Offset: 0x002917B4
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

	// Token: 0x0600B648 RID: 46664 RVA: 0x002935E0 File Offset: 0x002917E0
	public List<T> GetFilterList<[Nullable(2)] T>(List<T> dataList, int filterId, Dictionary<FilterDefine.EFilterType, Dictionary<int, string>> ruleData)
	{
		Filter? filterConfig = FilterConfig.Instance.GetFilterConfig(filterId);
		EFilterDataType dataType = (EFilterDataType)filterConfig.Value.DataType;
		bool isSupportSelectAll = filterConfig.Value.IsSupportSelectAll;
		bool isSelectAllUnion = filterConfig.Value.IsSelectAllUnion;
		return this.FilterLogic.GetFilterList<T>(dataList, dataType, isSupportSelectAll, isSelectAllUnion, ruleData);
	}

	// Token: 0x0600B649 RID: 46665 RVA: 0x0029363C File Offset: 0x0029183C
	public Func<int[], FilterItemData[]> GetFilterDataFuncByFilterType(FilterDefine.EFilterType filterType)
	{
		return this.FilterLogic.GetDataFuncByType(filterType);
	}

	// Token: 0x0600B64A RID: 46666 RVA: 0x0029364A File Offset: 0x0029184A
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public List<FilterItemData> GetFilterItemDataList(int ruleId, int configId)
	{
		return this.FilterLogic.GetFilterItemDataList(ruleId, configId);
	}

	// Token: 0x0600B64B RID: 46667 RVA: 0x0029365C File Offset: 0x0029185C
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

	// Token: 0x0600B64C RID: 46668 RVA: 0x002936A4 File Offset: 0x002918A4
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

	// Token: 0x0600B64D RID: 46669 RVA: 0x002936F4 File Offset: 0x002918F4
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

	// Token: 0x17000F2D RID: 3885
	// (get) Token: 0x0600B64E RID: 46670 RVA: 0x0029373B File Offset: 0x0029193B
	public static FilterModel Instance
	{
		get
		{
			return FilterModel._Instance;
		}
	}

	// Token: 0x0600B64F RID: 46671 RVA: 0x00293742 File Offset: 0x00291942
	public static FilterModel GetOrCreateInstance()
	{
		if (FilterModel._Instance == null)
		{
			FilterModel.CreateInstance();
		}
		return FilterModel._Instance;
	}

	// Token: 0x0600B650 RID: 46672 RVA: 0x00293756 File Offset: 0x00291956
	public static bool CreateInstance()
	{
		if (FilterModel._Instance != null)
		{
			return true;
		}
		FilterModel._Instance = new FilterModel();
		return true;
	}

	// Token: 0x0600B651 RID: 46673 RVA: 0x0029376C File Offset: 0x0029196C
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600B652 RID: 46674 RVA: 0x0029376E File Offset: 0x0029196E
	public static void ResetStaticDefaultValue()
	{
		FilterModel._Instance = null;
	}

	// Token: 0x0600B653 RID: 46675 RVA: 0x00293776 File Offset: 0x00291976
	static FilterModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FilterModel.CreateStaticDefaultValue), new Action(FilterModel.ResetStaticDefaultValue));
	}

	// Token: 0x04005267 RID: 21095
	private readonly Dictionary<int, FilterResultData> FilterResultDataMap = new Dictionary<int, FilterResultData>();

	// Token: 0x04005268 RID: 21096
	private readonly FilterLogic FilterLogic = new FilterLogic();

	// Token: 0x04005269 RID: 21097
	[Nullable(2)]
	private static FilterModel _Instance;
}
