using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common;

// Token: 0x02000D5D RID: 3421
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class SortModel : ModelBase
{
	// Token: 0x06008C85 RID: 35973 RVA: 0x002A8E11 File Offset: 0x002A7011
	public SortModel()
	{
		this.SortResultDataMap = new Dictionary<int, SortResultData>();
		this.SortLogic = new SortLogic();
	}

	// Token: 0x06008C86 RID: 35974 RVA: 0x002A8E30 File Offset: 0x002A7030
	public void SetSortResultData(SortResultData viewData)
	{
		SortResultData sortResultData;
		if (this.SortResultDataMap.TryGetValue(viewData.UniqueId, out sortResultData))
		{
			this.SortResultDataMap[viewData.UniqueId] = viewData;
			return;
		}
		this.SortResultDataMap.Add(viewData.UniqueId, viewData);
	}

	// Token: 0x06008C87 RID: 35975 RVA: 0x002A8E77 File Offset: 0x002A7077
	public void DeleteSortResultData(int uniqueId)
	{
		if (uniqueId == -1)
		{
			return;
		}
		this.SortResultDataMap.Remove(uniqueId);
	}

	// Token: 0x06008C88 RID: 35976 RVA: 0x002A8E8C File Offset: 0x002A708C
	[NullableContext(2)]
	public SortResultData GetSortResultData(int uniqueId)
	{
		if (uniqueId == -1)
		{
			return null;
		}
		SortResultData result;
		if (this.SortResultDataMap.TryGetValue(uniqueId, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x06008C89 RID: 35977 RVA: 0x002A8EB2 File Offset: 0x002A70B2
	public void SortDataList<[Nullable(2)] T>(List<T> dataList, int config, SortResultData resultData, params object[] parameters)
	{
		this.SortLogic.SortDataList<T>(dataList, config, resultData, parameters);
	}

	// Token: 0x06008C8A RID: 35978 RVA: 0x002A8EC4 File Offset: 0x002A70C4
	public void SortDataByData<[Nullable(2)] T>(List<T> dataList, ESortDataType dataType, HashSet<int> ruleIdSet, bool isAscending)
	{
		this.SortLogic.SortDataByData<T>(dataList, dataType, ruleIdSet, isAscending, Array.Empty<object>());
	}

	// Token: 0x06008C8B RID: 35979 RVA: 0x002A8EDC File Offset: 0x002A70DC
	[return: Nullable(2)]
	public SortStorageData GetSortConfigData(EFilterSortConfigId saveConfigId, int groupId, string extraParam)
	{
		if (!SortConfig.Instance.IsConfigSortSave(saveConfigId, groupId))
		{
			return null;
		}
		string configSortFormatId = SortConfig.Instance.GetConfigSortFormatId(saveConfigId, groupId, extraParam);
		Dictionary<string, SortStorageData> player = LocalStorage.GetPlayer<Dictionary<string, SortStorageData>>(ELocalStoragePlayerKey.SortConfig, null);
		SortStorageData result;
		if (player != null && player.TryGetValue(configSortFormatId, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x06008C8C RID: 35980 RVA: 0x002A8F24 File Offset: 0x002A7124
	public void SetSortConfigData(EFilterSortConfigId saveConfigId, int groupId, SortStorageData data, string extraParam)
	{
		if (!SortConfig.Instance.IsConfigSortSave(saveConfigId, groupId))
		{
			return;
		}
		string configSortFormatId = SortConfig.Instance.GetConfigSortFormatId(saveConfigId, groupId, extraParam);
		Dictionary<string, SortStorageData> dictionary = LocalStorage.GetPlayer<Dictionary<string, SortStorageData>>(ELocalStoragePlayerKey.SortConfig, null);
		if (dictionary == null)
		{
			dictionary = new Dictionary<string, SortStorageData>();
		}
		SortStorageData sortStorageData;
		if (dictionary.TryGetValue(configSortFormatId, out sortStorageData))
		{
			dictionary[configSortFormatId] = data;
		}
		else
		{
			dictionary.Add(configSortFormatId, data);
		}
		LocalStorage.SetPlayer<Dictionary<string, SortStorageData>>(ELocalStoragePlayerKey.SortConfig, dictionary);
	}

	// Token: 0x06008C8D RID: 35981 RVA: 0x002A8F88 File Offset: 0x002A7188
	public void ClearSortConfigData(EFilterSortConfigId saveConfigId, int groupId, string extraParam)
	{
		if (!SortConfig.Instance.IsConfigSortSave(saveConfigId, groupId))
		{
			return;
		}
		string configSortFormatId = SortConfig.Instance.GetConfigSortFormatId(saveConfigId, groupId, extraParam);
		Dictionary<string, SortStorageData> player = LocalStorage.GetPlayer<Dictionary<string, SortStorageData>>(ELocalStoragePlayerKey.SortConfig, null);
		if (player != null)
		{
			player.Remove(configSortFormatId);
			LocalStorage.SetPlayer<Dictionary<string, SortStorageData>>(ELocalStoragePlayerKey.SortConfig, player);
		}
	}

	// Token: 0x17000F71 RID: 3953
	// (get) Token: 0x06008C8E RID: 35982 RVA: 0x002A8FCF File Offset: 0x002A71CF
	public static SortModel Instance
	{
		get
		{
			return SortModel._Instance;
		}
	}

	// Token: 0x06008C8F RID: 35983 RVA: 0x002A8FD6 File Offset: 0x002A71D6
	public static SortModel GetOrCreateInstance()
	{
		if (SortModel._Instance == null)
		{
			SortModel.CreateInstance();
		}
		return SortModel._Instance;
	}

	// Token: 0x06008C90 RID: 35984 RVA: 0x002A8FEA File Offset: 0x002A71EA
	public static bool CreateInstance()
	{
		if (SortModel._Instance != null)
		{
			return true;
		}
		SortModel._Instance = new SortModel();
		return true;
	}

	// Token: 0x06008C91 RID: 35985 RVA: 0x002A9000 File Offset: 0x002A7200
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06008C92 RID: 35986 RVA: 0x002A9002 File Offset: 0x002A7202
	public static void ResetStaticDefaultValue()
	{
		SortModel._Instance = null;
	}

	// Token: 0x06008C93 RID: 35987 RVA: 0x002A900A File Offset: 0x002A720A
	static SortModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SortModel.CreateStaticDefaultValue), new Action(SortModel.ResetStaticDefaultValue));
	}

	// Token: 0x04005455 RID: 21589
	private readonly Dictionary<int, SortResultData> SortResultDataMap;

	// Token: 0x04005456 RID: 21590
	private readonly SortLogic SortLogic;

	// Token: 0x04005457 RID: 21591
	[Nullable(2)]
	private static SortModel _Instance;
}
