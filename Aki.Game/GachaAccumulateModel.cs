using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;
using Google.Protobuf.Collections;

// Token: 0x02001118 RID: 4376
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class GachaAccumulateModel : ModelBase
{
	// Token: 0x0600AEEC RID: 44780 RVA: 0x003388F6 File Offset: 0x00336AF6
	protected override bool OnInit()
	{
		this.AccumulateDataMap.Clear();
		this.GroupIdDataMap.Clear();
		return true;
	}

	// Token: 0x0600AEED RID: 44781 RVA: 0x0033890F File Offset: 0x00336B0F
	protected override bool OnClear()
	{
		this.AccumulateDataMap.Clear();
		this.GroupIdDataMap.Clear();
		return true;
	}

	// Token: 0x0600AEEE RID: 44782 RVA: 0x00338928 File Offset: 0x00336B28
	public bool CheckAccumulateIfNeedRequest(int accumulateId)
	{
		return !this.AccumulateDataMap.ContainsKey(accumulateId);
	}

	// Token: 0x0600AEEF RID: 44783 RVA: 0x0033893C File Offset: 0x00336B3C
	[NullableContext(2)]
	public GachaAccumulateData GetAccumulateData(int accumulateId)
	{
		GachaAccumulateData result;
		if (!this.AccumulateDataMap.TryGetValue(accumulateId, out result))
		{
			return null;
		}
		return result;
	}

	// Token: 0x0600AEF0 RID: 44784 RVA: 0x0033895C File Offset: 0x00336B5C
	public GachaAccumulateData[] GetAccumulateDataByGroupId(int groupId)
	{
		List<GachaAccumulateData> list;
		if (!this.GroupIdDataMap.TryGetValue(groupId, out list))
		{
			return Array.Empty<GachaAccumulateData>();
		}
		return list.ToArray();
	}

	// Token: 0x0600AEF1 RID: 44785 RVA: 0x00338988 File Offset: 0x00336B88
	public GachaAccumulateData[] GetAllAccumulateData()
	{
		Dictionary<int, GachaAccumulateData>.ValueCollection values = this.AccumulateDataMap.Values;
		GachaAccumulateData[] array = new GachaAccumulateData[values.Count];
		values.CopyTo(array, 0);
		return array;
	}

	// Token: 0x0600AEF2 RID: 44786 RVA: 0x003389B4 File Offset: 0x00336BB4
	public bool HasAnyClaimable()
	{
		using (Dictionary<int, GachaAccumulateData>.ValueCollection.Enumerator enumerator = this.AccumulateDataMap.Values.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.HasClaimable)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x0600AEF3 RID: 44787 RVA: 0x00338A14 File Offset: 0x00336C14
	public void NotifyDataUpdate(int accumulateId)
	{
		EventSystem.Instance.Emit<int>(EEventName.GachaAccumulateDataUpdate, accumulateId);
	}

	// Token: 0x0600AEF4 RID: 44788 RVA: 0x00338A28 File Offset: 0x00336C28
	public void UpdateAccumulateInfo(GachaAccumulateInfo protoInfo)
	{
		int gachaAccumulateId = protoInfo.GachaAccumulateId;
		if (gachaAccumulateId == 0)
		{
			Log.Instance.Error(ELogModule.Gacha, ELogAuthor.YZY, "[GachaAccumulateModel] AccumulateId 为 0，数据异常", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		GachaAccumulateData gachaAccumulateData = new GachaAccumulateData
		{
			AccumulateId = gachaAccumulateId
		};
		GachaAccumulateGroupInfo gachaAccumulateGroupInfo = protoInfo.GachaAccumulateGroupInfo;
		if (gachaAccumulateGroupInfo != null)
		{
			gachaAccumulateData.GroupData = this.ConvertGroupInfo(gachaAccumulateGroupInfo);
		}
		this.AccumulateDataMap[gachaAccumulateId] = gachaAccumulateData;
		this.RemoveFromGroupIdMap(gachaAccumulateId);
		GachaAccumulateGroupData groupData = gachaAccumulateData.GroupData;
		int num = (groupData != null) ? groupData.GroupId : 0;
		if (num != 0)
		{
			List<GachaAccumulateData> list;
			if (!this.GroupIdDataMap.TryGetValue(num, out list))
			{
				list = new List<GachaAccumulateData>();
				this.GroupIdDataMap[num] = list;
			}
			list.Add(gachaAccumulateData);
		}
	}

	// Token: 0x0600AEF5 RID: 44789 RVA: 0x00338ADC File Offset: 0x00336CDC
	private void RemoveFromGroupIdMap(int accumulateId)
	{
		GachaAccumulateData gachaAccumulateData;
		if (!this.AccumulateDataMap.TryGetValue(accumulateId, out gachaAccumulateData) || gachaAccumulateData.GroupData == null)
		{
			return;
		}
		int groupId = gachaAccumulateData.GroupData.GroupId;
		List<GachaAccumulateData> list;
		if (!this.GroupIdDataMap.TryGetValue(groupId, out list))
		{
			return;
		}
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].AccumulateId == accumulateId)
			{
				list.RemoveAt(i);
				return;
			}
		}
	}

	// Token: 0x0600AEF6 RID: 44790 RVA: 0x00338B48 File Offset: 0x00336D48
	private GachaAccumulateGroupData ConvertGroupInfo(GachaAccumulateGroupInfo protoGroup)
	{
		GachaAccumulateGroupData gachaAccumulateGroupData = new GachaAccumulateGroupData
		{
			GroupId = protoGroup.GroupId,
			CurGachaNum = protoGroup.CurGachaNum
		};
		foreach (GachaAccumulateRewardInfo protoReward in protoGroup.GachaAccumulateRewardInfos)
		{
			gachaAccumulateGroupData.RewardInfos.Add(this.ConvertRewardInfo(protoReward));
		}
		gachaAccumulateGroupData.RewardInfos.Sort((GachaAccumulateRewardData a, GachaAccumulateRewardData b) => a.GachaNum.CompareTo(b.GachaNum));
		return gachaAccumulateGroupData;
	}

	// Token: 0x0600AEF7 RID: 44791 RVA: 0x00338BEC File Offset: 0x00336DEC
	private GachaAccumulateRewardData ConvertRewardInfo(GachaAccumulateRewardInfo protoReward)
	{
		GachaAccumulateRewardData gachaAccumulateRewardData = new GachaAccumulateRewardData
		{
			Id = protoReward.Id,
			GroupId = protoReward.GroupId,
			GachaNum = protoReward.GachaNum,
			Status = (EGachaAccumulateRewardStatus)protoReward.Status,
			IsBigReward = protoReward.IsBigReward,
			CycleCount = protoReward.CycleCount,
			CycleRewardedTimes = protoReward.CycleRewardedTimes,
			IsPreView = protoReward.IsPreView
		};
		MapField<int, int> rewardContent = protoReward.RewardContent;
		if (rewardContent != null)
		{
			foreach (KeyValuePair<int, int> keyValuePair in rewardContent)
			{
				gachaAccumulateRewardData.RewardContent[keyValuePair.Key] = keyValuePair.Value;
			}
		}
		return gachaAccumulateRewardData;
	}

	// Token: 0x0600AEF8 RID: 44792 RVA: 0x00338CB8 File Offset: 0x00336EB8
	public bool IfGachaAccumulateNeedAutoOpenTips(int accumulateId)
	{
		if (accumulateId == 0)
		{
			return false;
		}
		ServerStorageSet serverStorageSet = ServerStorageModel.Instance.Get(EClientStorageSystemIdType.GachaAccumulateFirstOpen) as ServerStorageSet;
		foreach (ProtoGachaInfo protoGachaInfo in GachaModel.Instance.GachaInfoArray)
		{
			if (protoGachaInfo.GachaAccumulateId == accumulateId && !serverStorageSet.Has(protoGachaInfo.Id))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600AEF9 RID: 44793 RVA: 0x00338D14 File Offset: 0x00336F14
	public void SaveGachaAccumulateAutoOpenTips(int accumulateId)
	{
		ServerStorageSet serverStorageSet = ServerStorageModel.Instance.Get(EClientStorageSystemIdType.GachaAccumulateFirstOpen) as ServerStorageSet;
		foreach (ProtoGachaInfo protoGachaInfo in GachaModel.Instance.GachaInfoArray)
		{
			if (protoGachaInfo.GachaAccumulateId == accumulateId && !serverStorageSet.Has(protoGachaInfo.Id))
			{
				serverStorageSet.Add(protoGachaInfo.Id);
			}
		}
	}

	// Token: 0x17001205 RID: 4613
	// (get) Token: 0x0600AEFA RID: 44794 RVA: 0x00338D73 File Offset: 0x00336F73
	public static GachaAccumulateModel Instance
	{
		get
		{
			return GachaAccumulateModel._Instance;
		}
	}

	// Token: 0x0600AEFB RID: 44795 RVA: 0x00338D7A File Offset: 0x00336F7A
	public static GachaAccumulateModel GetOrCreateInstance()
	{
		if (GachaAccumulateModel._Instance == null)
		{
			GachaAccumulateModel.CreateInstance();
		}
		return GachaAccumulateModel._Instance;
	}

	// Token: 0x0600AEFC RID: 44796 RVA: 0x00338D8E File Offset: 0x00336F8E
	public static bool CreateInstance()
	{
		if (GachaAccumulateModel._Instance != null)
		{
			return true;
		}
		GachaAccumulateModel._Instance = new GachaAccumulateModel();
		return true;
	}

	// Token: 0x0600AEFD RID: 44797 RVA: 0x00338DA4 File Offset: 0x00336FA4
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600AEFE RID: 44798 RVA: 0x00338DA6 File Offset: 0x00336FA6
	public static void ResetStaticDefaultValue()
	{
		GachaAccumulateModel._Instance = null;
	}

	// Token: 0x0600AEFF RID: 44799 RVA: 0x00338DAE File Offset: 0x00336FAE
	static GachaAccumulateModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GachaAccumulateModel.CreateStaticDefaultValue), new Action(GachaAccumulateModel.ResetStaticDefaultValue));
	}

	// Token: 0x040064F2 RID: 25842
	private readonly Dictionary<int, GachaAccumulateData> AccumulateDataMap = new Dictionary<int, GachaAccumulateData>();

	// Token: 0x040064F3 RID: 25843
	private readonly Dictionary<int, List<GachaAccumulateData>> GroupIdDataMap = new Dictionary<int, List<GachaAccumulateData>>();

	// Token: 0x040064F4 RID: 25844
	[Nullable(2)]
	private static GachaAccumulateModel _Instance;
}
