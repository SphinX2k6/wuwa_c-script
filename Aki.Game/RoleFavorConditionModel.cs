using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Google.Protobuf.Collections;

// Token: 0x02001DB8 RID: 7608
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class RoleFavorConditionModel : ModelBase
{
	// Token: 0x06012DEB RID: 77291 RVA: 0x00589888 File Offset: 0x00587A88
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

	// Token: 0x06012DEC RID: 77292 RVA: 0x005899C0 File Offset: 0x00587BC0
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

	// Token: 0x17001CA0 RID: 7328
	// (get) Token: 0x06012DED RID: 77293 RVA: 0x00589A1F File Offset: 0x00587C1F
	public static RoleFavorConditionModel Instance
	{
		get
		{
			return RoleFavorConditionModel._Instance;
		}
	}

	// Token: 0x06012DEE RID: 77294 RVA: 0x00589A26 File Offset: 0x00587C26
	public static RoleFavorConditionModel GetOrCreateInstance()
	{
		if (RoleFavorConditionModel._Instance == null)
		{
			RoleFavorConditionModel.CreateInstance();
		}
		return RoleFavorConditionModel._Instance;
	}

	// Token: 0x06012DEF RID: 77295 RVA: 0x00589A3A File Offset: 0x00587C3A
	public static bool CreateInstance()
	{
		if (RoleFavorConditionModel._Instance != null)
		{
			return true;
		}
		RoleFavorConditionModel._Instance = new RoleFavorConditionModel();
		return true;
	}

	// Token: 0x06012DF0 RID: 77296 RVA: 0x00589A50 File Offset: 0x00587C50
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06012DF1 RID: 77297 RVA: 0x00589A52 File Offset: 0x00587C52
	public static void ResetStaticDefaultValue()
	{
		RoleFavorConditionModel._Instance = null;
	}

	// Token: 0x06012DF2 RID: 77298 RVA: 0x00589A5A File Offset: 0x00587C5A
	static RoleFavorConditionModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RoleFavorConditionModel.CreateStaticDefaultValue), new Action(RoleFavorConditionModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400A2A4 RID: 41636
	private readonly Dictionary<int, Dictionary<EFavorContentType, Dictionary<int, List<int>>>> RoleFavorConditionMap = new Dictionary<int, Dictionary<EFavorContentType, Dictionary<int, List<int>>>>();

	// Token: 0x0400A2A5 RID: 41637
	[Nullable(2)]
	private static RoleFavorConditionModel _Instance;
}
