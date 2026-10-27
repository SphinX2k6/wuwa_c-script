using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PayShop;

// Token: 0x02001359 RID: 4953
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class MoonChasingRewardModel : ModelBase
{
	// Token: 0x060089F0 RID: 35312 RVA: 0x001D7940 File Offset: 0x001D5B40
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

	// Token: 0x060089F1 RID: 35313 RVA: 0x001D7994 File Offset: 0x001D5B94
	public void SetAllRewardTargetData(List<Aki.Protocol.TrackMoonTarget> dataList)
	{
		foreach (Aki.Protocol.TrackMoonTarget rewardTargetData in dataList)
		{
			this.SetRewardTargetData(rewardTargetData);
		}
		EventSystem.Instance.Emit(EEventName.RefreshRewardTargetData);
	}

	// Token: 0x060089F2 RID: 35314 RVA: 0x001D79F4 File Offset: 0x001D5BF4
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

	// Token: 0x060089F3 RID: 35315 RVA: 0x001D7A68 File Offset: 0x001D5C68
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

	// Token: 0x060089F4 RID: 35316 RVA: 0x001D7AE0 File Offset: 0x001D5CE0
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

	// Token: 0x060089F5 RID: 35317 RVA: 0x001D7B24 File Offset: 0x001D5D24
	public TaskData GetTaskDataById(int id)
	{
		RewardTargetData rewardTargetData;
		if (!this.DataMap.TryGetValue(id, out rewardTargetData))
		{
			return null;
		}
		return rewardTargetData.ConvertToTaskData();
	}

	// Token: 0x060089F6 RID: 35318 RVA: 0x001D7B4C File Offset: 0x001D5D4C
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

	// Token: 0x060089F7 RID: 35319 RVA: 0x001D7BBC File Offset: 0x001D5DBC
	public int SortTaskData(TaskData a, TaskData b)
	{
		if (a.Status == b.Status)
		{
			return a.TaskId - b.TaskId;
		}
		return a.Status - b.Status;
	}

	// Token: 0x060089F8 RID: 35320 RVA: 0x001D7BE8 File Offset: 0x001D5DE8
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

	// Token: 0x060089F9 RID: 35321 RVA: 0x001D7C44 File Offset: 0x001D5E44
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

	// Token: 0x060089FA RID: 35322 RVA: 0x001D7CBC File Offset: 0x001D5EBC
	public TaskData GetSpecialTaskData()
	{
		return this.GetTaskDataByTabId(5)[0];
	}

	// Token: 0x060089FB RID: 35323 RVA: 0x001D7CCC File Offset: 0x001D5ECC
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

	// Token: 0x060089FC RID: 35324 RVA: 0x001D7D30 File Offset: 0x001D5F30
	public List<PayShopGoods> GetShopDataList()
	{
		return PayShopModel.Instance.GetPayShopTabData(PayShopDefine.EPayShopTabType.MoonChasing, 1, true);
	}

	// Token: 0x060089FD RID: 35325 RVA: 0x001D7D44 File Offset: 0x001D5F44
	public int GetTokenItemCount()
	{
		int tokenItemId = BusinessConfig.Instance.GetTokenItemId();
		return InventoryModel.Instance.GetItemCountByConfigId(tokenItemId, 0);
	}

	// Token: 0x060089FE RID: 35326 RVA: 0x001D7D68 File Offset: 0x001D5F68
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

	// Token: 0x060089FF RID: 35327 RVA: 0x001D7DFC File Offset: 0x001D5FFC
	public bool CheckShopItemRedDotState(PayShopGoods shopData)
	{
		return !shopData.IsSoldOut() && !shopData.IsLocked() && shopData.IfCanBuy() && !NewFlagModel.Instance.HasNewFlag(ELocalStoragePlayerKey.MoonChasingShopItemUnlock, shopData.GetGoodsId());
	}

	// Token: 0x06008A00 RID: 35328 RVA: 0x001D7E2D File Offset: 0x001D602D
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

	// Token: 0x06008A01 RID: 35329 RVA: 0x001D7E54 File Offset: 0x001D6054
	public void SaveShopRedDot()
	{
		NewFlagModel.Instance.SaveNewFlagConfig(ELocalStoragePlayerKey.MoonChasingShopItemUnlock);
		EventSystem.Instance.Emit(EEventName.MoonChasingRefreshRewardRedDot);
	}

	// Token: 0x06008A02 RID: 35330 RVA: 0x001D7E73 File Offset: 0x001D6073
	public bool CheckShopItemCheckFlag(PayShopGoods shopData)
	{
		return !shopData.IsSoldOut() && !shopData.IsLocked() && shopData.IfCanBuy() && !NewFlagModel.Instance.HasNewFlag(ELocalStoragePlayerKey.MoonChasingShopItemChecked, shopData.GetGoodsId());
	}

	// Token: 0x06008A03 RID: 35331 RVA: 0x001D7EA4 File Offset: 0x001D60A4
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

	// Token: 0x17000BBE RID: 3006
	// (get) Token: 0x06008A04 RID: 35332 RVA: 0x001D7F28 File Offset: 0x001D6128
	public static MoonChasingRewardModel Instance
	{
		get
		{
			return MoonChasingRewardModel._Instance;
		}
	}

	// Token: 0x06008A05 RID: 35333 RVA: 0x001D7F2F File Offset: 0x001D612F
	public static MoonChasingRewardModel GetOrCreateInstance()
	{
		if (MoonChasingRewardModel._Instance == null)
		{
			MoonChasingRewardModel.CreateInstance();
		}
		return MoonChasingRewardModel._Instance;
	}

	// Token: 0x06008A06 RID: 35334 RVA: 0x001D7F43 File Offset: 0x001D6143
	public static bool CreateInstance()
	{
		if (MoonChasingRewardModel._Instance != null)
		{
			return true;
		}
		MoonChasingRewardModel._Instance = new MoonChasingRewardModel();
		return true;
	}

	// Token: 0x06008A07 RID: 35335 RVA: 0x001D7F59 File Offset: 0x001D6159
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06008A08 RID: 35336 RVA: 0x001D7F5B File Offset: 0x001D615B
	public static void ResetStaticDefaultValue()
	{
		MoonChasingRewardModel._Instance = null;
	}

	// Token: 0x06008A09 RID: 35337 RVA: 0x001D7F63 File Offset: 0x001D6163
	static MoonChasingRewardModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MoonChasingRewardModel.CreateStaticDefaultValue), new Action(MoonChasingRewardModel.ResetStaticDefaultValue));
	}

	// Token: 0x04003D87 RID: 15751
	private readonly Dictionary<int, List<RewardTargetData>> DataTypeMap = new Dictionary<int, List<RewardTargetData>>();

	// Token: 0x04003D88 RID: 15752
	private readonly Dictionary<int, RewardTargetData> DataMap = new Dictionary<int, RewardTargetData>();

	// Token: 0x04003D89 RID: 15753
	public int TargetTotalCount;

	// Token: 0x04003D8A RID: 15754
	public int TargetGetCount;

	// Token: 0x04003D8B RID: 15755
	[Nullable(2)]
	private static MoonChasingRewardModel _Instance;
}
