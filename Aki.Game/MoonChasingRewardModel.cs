using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PayShop;

// Token: 0x0200080D RID: 2061
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class MoonChasingRewardModel : ModelBase
{
	// Token: 0x06005D8B RID: 23947 RVA: 0x001E07A4 File Offset: 0x001DE9A4
	private void AddDataType(RewardTargetData rewardTargetData)
	{
		Aki.Config.TrackMoonTarget rewardTargetById = MoonChasingRewardConfig.Instance.GetRewardTargetById(rewardTargetData.Id);
		List<RewardTargetData> list;
		if (!this.DataTypeMap.TryGetValue(rewardTargetById.Type, out list))
		{
			list = new List<RewardTargetData>();
			this.DataTypeMap[rewardTargetById.Type] = list;
		}
		list.Add(rewardTargetData);
	}

	// Token: 0x06005D8C RID: 23948 RVA: 0x001E07F8 File Offset: 0x001DE9F8
	public void SetAllRewardTargetData(IEnumerable<Aki.Protocol.TrackMoonTarget> dataList)
	{
		foreach (Aki.Protocol.TrackMoonTarget rewardTargetData in dataList)
		{
			this.SetRewardTargetData(rewardTargetData);
		}
		EventSystem.Instance.Emit(EEventName.RefreshRewardTargetData);
	}

	// Token: 0x06005D8D RID: 23949 RVA: 0x001E0850 File Offset: 0x001DEA50
	public void SetRewardTargetData(Aki.Protocol.TrackMoonTarget data)
	{
		RewardTargetData rewardTargetData;
		if (!this.DataMap.TryGetValue(data.Id, out rewardTargetData))
		{
			rewardTargetData = new RewardTargetData(data.Id);
			this.AddDataType(rewardTargetData);
			this.ProcessTargetInfo(rewardTargetData);
			this.DataMap[data.Id] = rewardTargetData;
		}
		rewardTargetData.Current = data.Current;
		rewardTargetData.Target = data.Target;
		rewardTargetData.Status = data.Status;
	}

	// Token: 0x06005D8E RID: 23950 RVA: 0x001E08C4 File Offset: 0x001DEAC4
	private void ProcessTargetInfo(RewardTargetData data)
	{
		List<TItem> rewardList = data.GetRewardList();
		int tokenItemId = BusinessConfig.Instance.GetTokenItemId();
		foreach (TItem titem in rewardList)
		{
			if (titem.ItemData.ItemId == tokenItemId)
			{
				this.TargetTotalCount += titem.Count;
			}
		}
	}

	// Token: 0x06005D8F RID: 23951 RVA: 0x001E093C File Offset: 0x001DEB3C
	public void TakenRewardTargetData(int id)
	{
		RewardTargetData rewardTargetData;
		if (!this.DataMap.TryGetValue(id, out rewardTargetData))
		{
			return;
		}
		rewardTargetData.Current = rewardTargetData.Target;
		rewardTargetData.Status = TrackMoonTargetState.TrackMoonTargetTaken;
		EventSystem.Instance.Emit<int>(EEventName.TakenRewardTargetData, id);
	}

	// Token: 0x06005D90 RID: 23952 RVA: 0x001E0980 File Offset: 0x001DEB80
	public TaskData GetTaskDataById(int id)
	{
		RewardTargetData rewardTargetData;
		if (!this.DataMap.TryGetValue(id, out rewardTargetData))
		{
			return null;
		}
		return rewardTargetData.ConvertToTaskData();
	}

	// Token: 0x06005D91 RID: 23953 RVA: 0x001E09A8 File Offset: 0x001DEBA8
	public List<TaskData> GetTaskDataByTabId(int tabId)
	{
		List<RewardTargetData> list;
		if (!this.DataTypeMap.TryGetValue(tabId, out list))
		{
			return new List<TaskData>();
		}
		List<TaskData> list2 = new List<TaskData>();
		foreach (RewardTargetData rewardTargetData in list)
		{
			list2.Add(rewardTargetData.ConvertToTaskData());
		}
		return list2;
	}

	// Token: 0x06005D92 RID: 23954 RVA: 0x001E0A18 File Offset: 0x001DEC18
	public int SortTaskData(TaskData a, TaskData b)
	{
		if (a.Status == b.Status)
		{
			return a.TaskId - b.TaskId;
		}
		return a.Status - b.Status;
	}

	// Token: 0x06005D93 RID: 23955 RVA: 0x001E0A44 File Offset: 0x001DEC44
	public bool GetTaskDataRedDotStateByTabId(int tabId)
	{
		using (List<TaskData>.Enumerator enumerator = this.GetTaskDataByTabId(tabId).GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.IsFinished)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06005D94 RID: 23956 RVA: 0x001E0AA0 File Offset: 0x001DECA0
	public bool GetAllTaskDataRedDotState(bool withSpecialReward)
	{
		foreach (TrackMoonTargetType trackMoonTargetType in this.GetRewardTargetTabList())
		{
			if (this.GetTaskDataRedDotStateByTabId(trackMoonTargetType.Id))
			{
				return true;
			}
		}
		if (withSpecialReward)
		{
			TaskData specialTaskData = this.GetSpecialTaskData();
			return specialTaskData != null && specialTaskData.IsFinished;
		}
		return false;
	}

	// Token: 0x06005D95 RID: 23957 RVA: 0x001E0B18 File Offset: 0x001DED18
	public TaskData GetSpecialTaskData()
	{
		return this.GetTaskDataByTabId(5)[0];
	}

	// Token: 0x06005D96 RID: 23958 RVA: 0x001E0B28 File Offset: 0x001DED28
	public List<TrackMoonTargetType> GetRewardTargetTabList()
	{
		IEnumerable<TrackMoonTargetType> allRewardTargetTypeList = MoonChasingRewardConfig.Instance.GetAllRewardTargetTypeList();
		List<TrackMoonTargetType> list = new List<TrackMoonTargetType>();
		foreach (TrackMoonTargetType item in allRewardTargetTypeList)
		{
			if (item.Id != 5)
			{
				list.Add(item);
			}
		}
		return list;
	}

	// Token: 0x06005D97 RID: 23959 RVA: 0x001E0B8C File Offset: 0x001DED8C
	public List<PayShopGoods> GetShopDataList()
	{
		return PayShopModel.Instance.GetPayShopTabData(PayShopDefine.EPayShopTabType.MoonChasing, 1, true);
	}

	// Token: 0x06005D98 RID: 23960 RVA: 0x001E0BA0 File Offset: 0x001DEDA0
	public int GetTokenItemCount()
	{
		int tokenItemId = BusinessConfig.Instance.GetTokenItemId();
		return InventoryModel.Instance.GetItemCountByConfigId(tokenItemId, 0);
	}

	// Token: 0x06005D99 RID: 23961 RVA: 0x001E0BC4 File Offset: 0x001DEDC4
	public bool GetShopRedDotState()
	{
		bool flag = true;
		foreach (PayShopGoods payShopGoods in this.GetShopDataList())
		{
			if (flag && !payShopGoods.IsSoldOut())
			{
				flag = false;
			}
			if (this.CheckShopItemCheckFlag(payShopGoods))
			{
				return true;
			}
		}
		int value = ConfigCommonParamById.GetIntConfig("MoonChasingShopTipsValue").Value;
		return value != 0 && !flag && this.GetTokenItemCount() >= value;
	}

	// Token: 0x06005D9A RID: 23962 RVA: 0x001E0C58 File Offset: 0x001DEE58
	public bool CheckShopItemRedDotState(PayShopGoods shopData)
	{
		return !shopData.IsSoldOut() && !shopData.IsLocked() && shopData.IfCanBuy() && !NewFlagModel.Instance.HasNewFlag(ELocalStoragePlayerKey.MoonChasingShopItemUnlock, shopData.GetGoodsId());
	}

	// Token: 0x06005D9B RID: 23963 RVA: 0x001E0C89 File Offset: 0x001DEE89
	public bool ReadShopItemUnlockFlag(PayShopGoods shopData)
	{
		if (!this.CheckShopItemRedDotState(shopData))
		{
			return false;
		}
		NewFlagModel.Instance.AddNewFlag(ELocalStoragePlayerKey.MoonChasingShopItemUnlock, shopData.GetGoodsId());
		this.SaveShopRedDot();
		return true;
	}

	// Token: 0x06005D9C RID: 23964 RVA: 0x001E0CB0 File Offset: 0x001DEEB0
	public void SaveShopRedDot()
	{
		NewFlagModel.Instance.SaveNewFlagConfig(ELocalStoragePlayerKey.MoonChasingShopItemUnlock);
		EventSystem.Instance.Emit(EEventName.MoonChasingRefreshRewardRedDot);
	}

	// Token: 0x06005D9D RID: 23965 RVA: 0x001E0CCF File Offset: 0x001DEECF
	public bool CheckShopItemCheckFlag(PayShopGoods shopData)
	{
		return !shopData.IsSoldOut() && !shopData.IsLocked() && shopData.IfCanBuy() && !NewFlagModel.Instance.HasNewFlag(ELocalStoragePlayerKey.MoonChasingShopItemChecked, shopData.GetGoodsId());
	}

	// Token: 0x06005D9E RID: 23966 RVA: 0x001E0D00 File Offset: 0x001DEF00
	public bool ReadShopItemCheckFlag(List<PayShopGoods> shopDataList)
	{
		foreach (PayShopGoods payShopGoods in shopDataList)
		{
			if (this.CheckShopItemCheckFlag(payShopGoods))
			{
				NewFlagModel.Instance.AddNewFlag(ELocalStoragePlayerKey.MoonChasingShopItemChecked, payShopGoods.GetGoodsId());
			}
		}
		NewFlagModel.Instance.SaveNewFlagConfig(ELocalStoragePlayerKey.MoonChasingShopItemChecked);
		EventSystem.Instance.Emit(EEventName.MoonChasingRefreshRewardRedDot);
		return true;
	}

	// Token: 0x17000BDE RID: 3038
	// (get) Token: 0x06005D9F RID: 23967 RVA: 0x001E0D84 File Offset: 0x001DEF84
	public static MoonChasingRewardModel Instance
	{
		get
		{
			return MoonChasingRewardModel._Instance;
		}
	}

	// Token: 0x06005DA0 RID: 23968 RVA: 0x001E0D8B File Offset: 0x001DEF8B
	public static MoonChasingRewardModel GetOrCreateInstance()
	{
		if (MoonChasingRewardModel._Instance == null)
		{
			MoonChasingRewardModel.CreateInstance();
		}
		return MoonChasingRewardModel._Instance;
	}

	// Token: 0x06005DA1 RID: 23969 RVA: 0x001E0D9F File Offset: 0x001DEF9F
	public static bool CreateInstance()
	{
		if (MoonChasingRewardModel._Instance != null)
		{
			return true;
		}
		MoonChasingRewardModel._Instance = new MoonChasingRewardModel();
		return true;
	}

	// Token: 0x06005DA2 RID: 23970 RVA: 0x001E0DB5 File Offset: 0x001DEFB5
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06005DA3 RID: 23971 RVA: 0x001E0DB7 File Offset: 0x001DEFB7
	public static void ResetStaticDefaultValue()
	{
		MoonChasingRewardModel._Instance = null;
	}

	// Token: 0x06005DA4 RID: 23972 RVA: 0x001E0DBF File Offset: 0x001DEFBF
	static MoonChasingRewardModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MoonChasingRewardModel.CreateStaticDefaultValue), new Action(MoonChasingRewardModel.ResetStaticDefaultValue));
	}

	// Token: 0x04003E1F RID: 15903
	private readonly Dictionary<int, List<RewardTargetData>> DataTypeMap = new Dictionary<int, List<RewardTargetData>>();

	// Token: 0x04003E20 RID: 15904
	private readonly Dictionary<int, RewardTargetData> DataMap = new Dictionary<int, RewardTargetData>();

	// Token: 0x04003E21 RID: 15905
	public int TargetTotalCount;

	// Token: 0x04003E22 RID: 15906
	public int TargetGetCount;

	// Token: 0x04003E23 RID: 15907
	[Nullable(2)]
	private static MoonChasingRewardModel _Instance;
}
