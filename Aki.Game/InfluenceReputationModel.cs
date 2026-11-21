using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Reward;

// Token: 0x0200143F RID: 5183
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class InfluenceReputationModel : ModelBase
{
	// Token: 0x0600CE33 RID: 52787 RVA: 0x003D4FA0 File Offset: 0x003D31A0
	public void SetInfluenceInfoList(IReadOnlyList<OneInfluenceInfo> infoList)
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

	// Token: 0x0600CE34 RID: 52788 RVA: 0x003D5050 File Offset: 0x003D3250
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

	// Token: 0x0600CE35 RID: 52789 RVA: 0x003D50A8 File Offset: 0x003D32A8
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

	// Token: 0x0600CE36 RID: 52790 RVA: 0x003D50C8 File Offset: 0x003D32C8
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

	// Token: 0x0600CE37 RID: 52791 RVA: 0x003D515C File Offset: 0x003D335C
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

	// Token: 0x0600CE38 RID: 52792 RVA: 0x003D51E8 File Offset: 0x003D33E8
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

	// Token: 0x0600CE39 RID: 52793 RVA: 0x003D5278 File Offset: 0x003D3478
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

	// Token: 0x0600CE3A RID: 52794 RVA: 0x003D52A4 File Offset: 0x003D34A4
	public int[] GetUnLockCountry()
	{
		int[] array = new int[this.CountrySet.Count];
		this.CountrySet.CopyTo(array);
		return array;
	}

	// Token: 0x0600CE3B RID: 52795 RVA: 0x003D52CF File Offset: 0x003D34CF
	public bool IsCountryUnLock(int countryId)
	{
		return this.CountrySet.Contains(countryId);
	}

	// Token: 0x0600CE3C RID: 52796 RVA: 0x003D52E0 File Offset: 0x003D34E0
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

	// Token: 0x0600CE3D RID: 52797 RVA: 0x003D5344 File Offset: 0x003D3544
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

	// Token: 0x0600CE3E RID: 52798 RVA: 0x003D53EC File Offset: 0x003D35EC
	public bool RedDotInfluenceRewardCondition(int influenceId)
	{
		ValueTuple<bool, IntPair>? canReceiveReward = this.GetCanReceiveReward(influenceId);
		return canReceiveReward != null && !canReceiveReward.Value.Item1 && this.GetReputationProgress(influenceId).Item1 >= canReceiveReward.Value.Item2.Item1;
	}

	// Token: 0x0600CE3F RID: 52799 RVA: 0x003D5444 File Offset: 0x003D3644
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

	// Token: 0x0600CE40 RID: 52800 RVA: 0x003D54A4 File Offset: 0x003D36A4
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

	// Token: 0x1700136E RID: 4974
	// (get) Token: 0x0600CE41 RID: 52801 RVA: 0x003D54F6 File Offset: 0x003D36F6
	public static InfluenceReputationModel Instance
	{
		get
		{
			return InfluenceReputationModel._Instance;
		}
	}

	// Token: 0x0600CE42 RID: 52802 RVA: 0x003D54FD File Offset: 0x003D36FD
	public static InfluenceReputationModel GetOrCreateInstance()
	{
		if (InfluenceReputationModel._Instance == null)
		{
			InfluenceReputationModel.CreateInstance();
		}
		return InfluenceReputationModel._Instance;
	}

	// Token: 0x0600CE43 RID: 52803 RVA: 0x003D5511 File Offset: 0x003D3711
	public static bool CreateInstance()
	{
		if (InfluenceReputationModel._Instance != null)
		{
			return true;
		}
		InfluenceReputationModel._Instance = new InfluenceReputationModel();
		return true;
	}

	// Token: 0x0600CE44 RID: 52804 RVA: 0x003D5527 File Offset: 0x003D3727
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600CE45 RID: 52805 RVA: 0x003D5529 File Offset: 0x003D3729
	public static void ResetStaticDefaultValue()
	{
		InfluenceReputationModel._Instance = null;
	}

	// Token: 0x0600CE46 RID: 52806 RVA: 0x003D5531 File Offset: 0x003D3731
	static InfluenceReputationModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(InfluenceReputationModel.CreateStaticDefaultValue), new Action(InfluenceReputationModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400756C RID: 30060
	private readonly Dictionary<int, InfluenceInstance> InfluenceInstanceMap = new Dictionary<int, InfluenceInstance>();

	// Token: 0x0400756D RID: 30061
	private readonly HashSet<int> CountrySet = new HashSet<int>();

	// Token: 0x0400756E RID: 30062
	[Nullable(2)]
	private static InfluenceReputationModel _Instance;
}
