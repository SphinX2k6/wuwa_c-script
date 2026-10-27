using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Reward;

// Token: 0x02001F7D RID: 8061
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class InfluenceReputationModel : ModelBase
{
	// Token: 0x0600FA14 RID: 64020 RVA: 0x003C9484 File Offset: 0x003C7684
	public void SetInfluenceInfoList(OneInfluenceInfo[] infoList)
	{
		foreach (OneInfluenceInfo oneInfluenceInfo in infoList)
		{
			InfluenceInstance influenceInstance;
			if (this.InfluenceInstanceMap.TryGetValue(oneInfluenceInfo.InfluenceId, out influenceInstance))
			{
				influenceInstance.SetRelation((EInfluenceRelation)oneInfluenceInfo.Relation);
				influenceInstance.SetReceiveReward(oneInfluenceInfo.RewardIndex);
			}
			else
			{
				this.InfluenceInstanceMap.Add(oneInfluenceInfo.InfluenceId, new InfluenceInstance(oneInfluenceInfo.InfluenceId, oneInfluenceInfo.RewardIndex, oneInfluenceInfo.Relation));
			}
			EventSystem.Instance.Emit<int>(EEventName.RedDotInfluence, oneInfluenceInfo.InfluenceId);
		}
	}

	// Token: 0x0600FA15 RID: 64021 RVA: 0x003C9514 File Offset: 0x003C7714
	public bool UpdateInfluenceRewardIndex(int id, int rewardIndex)
	{
		InfluenceInstance influenceInstance;
		if (!this.InfluenceInstanceMap.TryGetValue(id, out influenceInstance))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.InfluenceReputation;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "奖励获取有问题,当前客户端没有该势力数据";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		influenceInstance.SetReceiveReward(rewardIndex);
		return true;
	}

	// Token: 0x0600FA16 RID: 64022 RVA: 0x003C956C File Offset: 0x003C776C
	[NullableContext(2)]
	public InfluenceInstance GetInfluenceInstance(int id)
	{
		InfluenceInstance result;
		if (this.InfluenceInstanceMap.TryGetValue(id, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x0600FA17 RID: 64023 RVA: 0x003C958C File Offset: 0x003C778C
	[NullableContext(0)]
	[return: TupleElementNames(new string[]
	{
		"IsAllReceived",
		"Reward"
	})]
	public ValueTuple<bool, IntPair>? GetCanReceiveReward(int influenceId)
	{
		if (influenceId == 0)
		{
			return null;
		}
		Influence? influenceConfig = InfluenceConfig.Instance.GetInfluenceConfig(influenceId);
		InfluenceInstance influenceInstance = this.GetInfluenceInstance(influenceId);
		if (influenceInstance == null || influenceConfig == null)
		{
			return null;
		}
		IntPair[] array = influenceConfig.Value.ReputationReward();
		if (array.Length == influenceInstance.RewardIndex + 1)
		{
			return new ValueTuple<bool, IntPair>?(new ValueTuple<bool, IntPair>(true, array[influenceInstance.RewardIndex]));
		}
		return new ValueTuple<bool, IntPair>?(new ValueTuple<bool, IntPair>(false, array[influenceInstance.RewardIndex + 1]));
	}

	// Token: 0x0600FA18 RID: 64024 RVA: 0x003C9620 File Offset: 0x003C7820
	[return: Nullable(new byte[]
	{
		1,
		0
	})]
	public List<ValueTuple<int, int>> GetRewardList(int dropId)
	{
		DropPackage? dropPackage = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackage(dropId);
		List<ValueTuple<int, int>> list = new List<ValueTuple<int, int>>();
		if (dropPackage != null)
		{
			foreach (KeyValuePair<int, int> keyValuePair in dropPackage.Value.DropPreview())
			{
				list.Add(new ValueTuple<int, int>(keyValuePair.Key, keyValuePair.Value));
			}
		}
		return list;
	}

	// Token: 0x0600FA19 RID: 64025 RVA: 0x003C96AC File Offset: 0x003C78AC
	[NullableContext(0)]
	[return: TupleElementNames(new string[]
	{
		"Current",
		"Max"
	})]
	public ValueTuple<int, int> GetReputationProgress(int influenceId)
	{
		int num = 0;
		int num2 = 0;
		Influence? influenceConfig = InfluenceConfig.Instance.GetInfluenceConfig(influenceId);
		if (influenceConfig != null)
		{
			foreach (IntPair intPair in influenceConfig.Value.ReputationItem())
			{
				num += intPair.Item2;
				int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(intPair.Item1, 0);
				num2 += MathUtils.Instance.Clamp(itemCountByConfigId, 0, intPair.Item2);
			}
		}
		return new ValueTuple<int, int>(num2, num);
	}

	// Token: 0x0600FA1A RID: 64026 RVA: 0x003C973C File Offset: 0x003C793C
	public void SetUnLockCountry(int[] unlockCountryList)
	{
		int i = 0;
		int num = unlockCountryList.Length;
		while (i < num)
		{
			this.CountrySet.Add(unlockCountryList[i]);
			i++;
		}
	}

	// Token: 0x0600FA1B RID: 64027 RVA: 0x003C9768 File Offset: 0x003C7968
	public int[] GetUnLockCountry()
	{
		int[] array = new int[this.CountrySet.Count];
		this.CountrySet.CopyTo(array);
		return array;
	}

	// Token: 0x0600FA1C RID: 64028 RVA: 0x003C9793 File Offset: 0x003C7993
	public bool IsCountryUnLock(int countryId)
	{
		return this.CountrySet.Contains(countryId);
	}

	// Token: 0x0600FA1D RID: 64029 RVA: 0x003C97A4 File Offset: 0x003C79A4
	public List<int> FilterUnLockInfluence(int[] influenceList, string filterText)
	{
		List<int> list = new List<int>();
		int i = 0;
		int num = influenceList.Length;
		while (i < num)
		{
			int num2 = influenceList[i];
			if (num2 != 0 && this.InfluenceInstanceMap.ContainsKey(num2))
			{
				string influenceTitle = InfluenceConfig.Instance.GetInfluenceTitle(num2);
				if (new Regex(filterText, RegexOptions.IgnoreCase).Match(influenceTitle).Index >= 0)
				{
					list.Add(num2);
				}
			}
			i++;
		}
		return list;
	}

	// Token: 0x0600FA1E RID: 64030 RVA: 0x003C9808 File Offset: 0x003C7A08
	public InfluenceSearchData FilterUnLockInfluenceList(int[] countryIdList, string filterText)
	{
		InfluenceSearchData influenceSearchData = new InfluenceSearchData
		{
			HasResult = false,
			InfluenceList = new List<ValueTuple<int, List<int>>>()
		};
		foreach (int num in countryIdList)
		{
			if (num != 0)
			{
				Country? countryConfig = InfluenceConfig.Instance.GetCountryConfig(num);
				if (countryConfig != null)
				{
					List<int> list = this.FilterUnLockInfluence(countryConfig.Value.Influences(), filterText);
					influenceSearchData.InfluenceList.Add(new ValueTuple<int, List<int>>(num, list));
					influenceSearchData.HasResult = (influenceSearchData.HasResult || list.Count > 0);
				}
			}
		}
		return influenceSearchData;
	}

	// Token: 0x0600FA1F RID: 64031 RVA: 0x003C98B0 File Offset: 0x003C7AB0
	public bool RedDotInfluenceRewardCondition(int influenceId)
	{
		ValueTuple<bool, IntPair>? canReceiveReward = this.GetCanReceiveReward(influenceId);
		return canReceiveReward != null && !canReceiveReward.Value.Item1 && this.GetReputationProgress(influenceId).Item1 >= canReceiveReward.Value.Item2.Item1;
	}

	// Token: 0x0600FA20 RID: 64032 RVA: 0x003C9908 File Offset: 0x003C7B08
	public bool HasRedDotExcludeCurrentCountry(int currentCountryId)
	{
		foreach (int num in this.CountrySet)
		{
			if (num != currentCountryId && this.HasRedDotInCurrentCountry(num))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600FA21 RID: 64033 RVA: 0x003C9968 File Offset: 0x003C7B68
	public bool HasRedDotInCurrentCountry(int countryId)
	{
		Country? countryConfig = InfluenceConfig.Instance.GetCountryConfig(countryId);
		if (countryConfig != null)
		{
			foreach (int influenceId in countryConfig.Value.Influences())
			{
				if (this.RedDotInfluenceRewardCondition(influenceId))
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x17001344 RID: 4932
	// (get) Token: 0x0600FA22 RID: 64034 RVA: 0x003C99BA File Offset: 0x003C7BBA
	public static InfluenceReputationModel Instance
	{
		get
		{
			return InfluenceReputationModel._Instance;
		}
	}

	// Token: 0x0600FA23 RID: 64035 RVA: 0x003C99C1 File Offset: 0x003C7BC1
	public static InfluenceReputationModel GetOrCreateInstance()
	{
		if (InfluenceReputationModel._Instance == null)
		{
			InfluenceReputationModel.CreateInstance();
		}
		return InfluenceReputationModel._Instance;
	}

	// Token: 0x0600FA24 RID: 64036 RVA: 0x003C99D5 File Offset: 0x003C7BD5
	public static bool CreateInstance()
	{
		if (InfluenceReputationModel._Instance != null)
		{
			return true;
		}
		InfluenceReputationModel._Instance = new InfluenceReputationModel();
		return true;
	}

	// Token: 0x0600FA25 RID: 64037 RVA: 0x003C99EB File Offset: 0x003C7BEB
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600FA26 RID: 64038 RVA: 0x003C99ED File Offset: 0x003C7BED
	public static void ResetStaticDefaultValue()
	{
		InfluenceReputationModel._Instance = null;
	}

	// Token: 0x0600FA27 RID: 64039 RVA: 0x003C99F5 File Offset: 0x003C7BF5
	static InfluenceReputationModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(InfluenceReputationModel.CreateStaticDefaultValue), new Action(InfluenceReputationModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400748B RID: 29835
	private readonly Dictionary<int, InfluenceInstance> InfluenceInstanceMap = new Dictionary<int, InfluenceInstance>();

	// Token: 0x0400748C RID: 29836
	private readonly HashSet<int> CountrySet = new HashSet<int>();

	// Token: 0x0400748D RID: 29837
	[Nullable(2)]
	private static InfluenceReputationModel _Instance;
}
