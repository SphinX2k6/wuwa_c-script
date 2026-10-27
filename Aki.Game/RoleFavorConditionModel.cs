using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Google.Protobuf.Collections;

// Token: 0x0200283D RID: 10301
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class RoleFavorConditionModel : ModelBase
{
	// Token: 0x060153ED RID: 87021 RVA: 0x0055EB2C File Offset: 0x0055CD2C
	public void UpdateRoleFavorCondition(int roleId, ConditionInfo conditionInfo)
	{
		Dictionary<EFavorContentType, Dictionary<int, List<int>>> dictionary;
		if (!this.RoleFavorConditionMap.TryGetValue(roleId, out dictionary))
		{
			dictionary = new Dictionary<EFavorContentType, Dictionary<int, List<int>>>();
		}
		foreach (KeyValuePair<int, ConditionItem> keyValuePair in conditionInfo.FinishConditionMap)
		{
			EFavorContentType key = (EFavorContentType)keyValuePair.Key;
			MapField<int, ItemFinishList> itemFinishMap = keyValuePair.Value.ItemFinishMap;
			Dictionary<int, List<int>> dictionary2;
			if (!dictionary.TryGetValue(key, out dictionary2))
			{
				dictionary2 = new Dictionary<int, List<int>>();
			}
			foreach (KeyValuePair<int, ItemFinishList> keyValuePair2 in itemFinishMap)
			{
				int key2 = keyValuePair2.Key;
				RepeatedField<int> conditionIdList = keyValuePair2.Value.ConditionIdList;
				List<int> list;
				if (!dictionary2.TryGetValue(key2, out list))
				{
					list = new List<int>();
				}
				int count = conditionIdList.Count;
				for (int i = 0; i < count; i++)
				{
					int item = conditionIdList[i];
					list.Add(item);
				}
				dictionary2[key2] = list;
			}
			dictionary[key] = dictionary2;
		}
		this.RoleFavorConditionMap[roleId] = dictionary;
	}

	// Token: 0x060153EE RID: 87022 RVA: 0x0055EC64 File Offset: 0x0055CE64
	public bool IsConditionFinish(int roleId, EFavorContentType type, int id, int conditionId)
	{
		Dictionary<EFavorContentType, Dictionary<int, List<int>>> dictionary;
		if (!this.RoleFavorConditionMap.TryGetValue(roleId, out dictionary))
		{
			return false;
		}
		Dictionary<int, List<int>> dictionary2;
		if (!dictionary.TryGetValue(type, out dictionary2))
		{
			return false;
		}
		List<int> list;
		if (!dictionary2.TryGetValue(id, out list))
		{
			return false;
		}
		int count = list.Count;
		for (int i = 0; i < count; i++)
		{
			if (list[i] == conditionId)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x17001C48 RID: 7240
	// (get) Token: 0x060153EF RID: 87023 RVA: 0x0055ECC3 File Offset: 0x0055CEC3
	public static RoleFavorConditionModel Instance
	{
		get
		{
			return RoleFavorConditionModel._Instance;
		}
	}

	// Token: 0x060153F0 RID: 87024 RVA: 0x0055ECCA File Offset: 0x0055CECA
	public static RoleFavorConditionModel GetOrCreateInstance()
	{
		if (RoleFavorConditionModel._Instance == null)
		{
			RoleFavorConditionModel.CreateInstance();
		}
		return RoleFavorConditionModel._Instance;
	}

	// Token: 0x060153F1 RID: 87025 RVA: 0x0055ECDE File Offset: 0x0055CEDE
	public static bool CreateInstance()
	{
		if (RoleFavorConditionModel._Instance != null)
		{
			return true;
		}
		RoleFavorConditionModel._Instance = new RoleFavorConditionModel();
		return true;
	}

	// Token: 0x060153F2 RID: 87026 RVA: 0x0055ECF4 File Offset: 0x0055CEF4
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060153F3 RID: 87027 RVA: 0x0055ECF6 File Offset: 0x0055CEF6
	public static void ResetStaticDefaultValue()
	{
		RoleFavorConditionModel._Instance = null;
	}

	// Token: 0x060153F4 RID: 87028 RVA: 0x0055ECFE File Offset: 0x0055CEFE
	static RoleFavorConditionModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RoleFavorConditionModel.CreateStaticDefaultValue), new Action(RoleFavorConditionModel.ResetStaticDefaultValue));
	}

	// Token: 0x04009EBB RID: 40635
	private readonly Dictionary<int, Dictionary<EFavorContentType, Dictionary<int, List<int>>>> RoleFavorConditionMap = new Dictionary<int, Dictionary<EFavorContentType, Dictionary<int, List<int>>>>();

	// Token: 0x04009EBC RID: 40636
	[Nullable(2)]
	private static RoleFavorConditionModel _Instance;
}
