using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common;

// Token: 0x020018A4 RID: 6308
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class SortModel : ModelBase
{
	// Token: 0x0600B89C RID: 47260 RVA: 0x0029E6F1 File Offset: 0x0029C8F1
	public SortModel()
	{
		this.SortResultDataMap = new Dictionary<int, SortResultData>();
		this.SortLogic = new SortLogic();
	}

	// Token: 0x0600B89D RID: 47261 RVA: 0x0029E710 File Offset: 0x0029C910
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

	// Token: 0x0600B89E RID: 47262 RVA: 0x0029E757 File Offset: 0x0029C957
	public void DeleteSortResultData(int uniqueId)
	{
		if (uniqueId == -1)
		{
			return;
		}
		this.SortResultDataMap.Remove(uniqueId);
	}

	// Token: 0x0600B89F RID: 47263 RVA: 0x0029E76C File Offset: 0x0029C96C
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

	// Token: 0x0600B8A0 RID: 47264 RVA: 0x0029E792 File Offset: 0x0029C992
	public void SortDataList<[Nullable(2)] T>(List<T> dataList, int config, SortResultData resultData, params object[] parameters)
	{
		this.SortLogic.SortDataList<T>(dataList, config, resultData, parameters);
	}

	// Token: 0x0600B8A1 RID: 47265 RVA: 0x0029E7A4 File Offset: 0x0029C9A4
	public void SortDataByData<[Nullable(2)] T>(List<T> dataList, ESortDataType dataType, HashSet<int> ruleIdSet, bool isAscending)
	{
		this.SortLogic.SortDataByData<T>(dataList, dataType, ruleIdSet, isAscending, Array.Empty<object>());
	}

	// Token: 0x0600B8A2 RID: 47266 RVA: 0x0029E7BC File Offset: 0x0029C9BC
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

	// Token: 0x0600B8A3 RID: 47267 RVA: 0x0029E804 File Offset: 0x0029CA04
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

	// Token: 0x0600B8A4 RID: 47268 RVA: 0x0029E868 File Offset: 0x0029CA68
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

	// Token: 0x17000F4E RID: 3918
	// (get) Token: 0x0600B8A5 RID: 47269 RVA: 0x0029E8AF File Offset: 0x0029CAAF
	public static SortModel Instance
	{
		get
		{
			return SortModel._Instance;
		}
	}

	// Token: 0x0600B8A6 RID: 47270 RVA: 0x0029E8B6 File Offset: 0x0029CAB6
	public static SortModel GetOrCreateInstance()
	{
		if (SortModel._Instance == null)
		{
			SortModel.CreateInstance();
		}
		return SortModel._Instance;
	}

	// Token: 0x0600B8A7 RID: 47271 RVA: 0x0029E8CA File Offset: 0x0029CACA
	public static bool CreateInstance()
	{
		if (SortModel._Instance != null)
		{
			return true;
		}
		SortModel._Instance = new SortModel();
		return true;
	}

	// Token: 0x0600B8A8 RID: 47272 RVA: 0x0029E8E0 File Offset: 0x0029CAE0
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600B8A9 RID: 47273 RVA: 0x0029E8E2 File Offset: 0x0029CAE2
	public static void ResetStaticDefaultValue()
	{
		SortModel._Instance = null;
	}

	// Token: 0x0600B8AA RID: 47274 RVA: 0x0029E8EA File Offset: 0x0029CAEA
	static SortModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SortModel.CreateStaticDefaultValue), new Action(SortModel.ResetStaticDefaultValue));
	}

	// Token: 0x040053AA RID: 21418
	private readonly Dictionary<int, SortResultData> SortResultDataMap;

	// Token: 0x040053AB RID: 21419
	private readonly SortLogic SortLogic;

	// Token: 0x040053AC RID: 21420
	[Nullable(2)]
	private static SortModel _Instance;
}
