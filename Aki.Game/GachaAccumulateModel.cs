using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;
using Google.Protobuf.Collections;

// Token: 0x02001C59 RID: 7257
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class GachaAccumulateModel : ModelBase
{
	// Token: 0x0600DAD6 RID: 56022 RVA: 0x0032D4CA File Offset: 0x0032B6CA
	protected override bool OnInit()
	{
		this.AccumulateDataMap.Clear();
		this.GroupIdDataMap.Clear();
		return true;
	}

	// Token: 0x0600DAD7 RID: 56023 RVA: 0x0032D4E3 File Offset: 0x0032B6E3
	protected override bool OnClear()
	{
		this.AccumulateDataMap.Clear();
		this.GroupIdDataMap.Clear();
		return true;
	}

	// Token: 0x0600DAD8 RID: 56024 RVA: 0x0032D4FC File Offset: 0x0032B6FC
	public bool CheckAccumulateIfNeedRequest(int accumulateId)
	{
		return !this.AccumulateDataMap.ContainsKey(accumulateId);
	}

	// Token: 0x0600DAD9 RID: 56025 RVA: 0x0032D510 File Offset: 0x0032B710
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

	// Token: 0x0600DADA RID: 56026 RVA: 0x0032D530 File Offset: 0x0032B730
	public GachaAccumulateData[] GetAccumulateDataByGroupId(int groupId)
	{
		List<GachaAccumulateData> list;
		if (!this.GroupIdDataMap.TryGetValue(groupId, out list))
		{
			return Array.Empty<GachaAccumulateData>();
		}
		return list.ToArray();
	}

	// Token: 0x0600DADB RID: 56027 RVA: 0x0032D559 File Offset: 0x0032B759
	public GachaAccumulateData[] GetAllAccumulateData()
	{
		return this.AccumulateDataMap.Values.ToArray<GachaAccumulateData>();
	}

	// Token: 0x0600DADC RID: 56028 RVA: 0x0032D56C File Offset: 0x0032B76C
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

	// Token: 0x0600DADD RID: 56029 RVA: 0x0032D5CC File Offset: 0x0032B7CC
	public void NotifyDataUpdate(int accumulateId)
	{
		EventSystem.Instance.Emit<int>(EEventName.GachaAccumulateDataUpdate, accumulateId);
	}

	// Token: 0x0600DADE RID: 56030 RVA: 0x0032D5E0 File Offset: 0x0032B7E0
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

	// Token: 0x0600DADF RID: 56031 RVA: 0x0032D694 File Offset: 0x0032B894
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

	// Token: 0x0600DAE0 RID: 56032 RVA: 0x0032D700 File Offset: 0x0032B900
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

	// Token: 0x0600DAE1 RID: 56033 RVA: 0x0032D7A4 File Offset: 0x0032B9A4
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

	// Token: 0x0600DAE2 RID: 56034 RVA: 0x0032D870 File Offset: 0x0032BA70
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

	// Token: 0x0600DAE3 RID: 56035 RVA: 0x0032D8CC File Offset: 0x0032BACC
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

	// Token: 0x170011DF RID: 4575
	// (get) Token: 0x0600DAE4 RID: 56036 RVA: 0x0032D92B File Offset: 0x0032BB2B
	public static GachaAccumulateModel Instance
	{
		get
		{
			return GachaAccumulateModel._Instance;
		}
	}

	// Token: 0x0600DAE5 RID: 56037 RVA: 0x0032D932 File Offset: 0x0032BB32
	public static GachaAccumulateModel GetOrCreateInstance()
	{
		if (GachaAccumulateModel._Instance == null)
		{
			GachaAccumulateModel.CreateInstance();
		}
		return GachaAccumulateModel._Instance;
	}

	// Token: 0x0600DAE6 RID: 56038 RVA: 0x0032D946 File Offset: 0x0032BB46
	public static bool CreateInstance()
	{
		if (GachaAccumulateModel._Instance != null)
		{
			return true;
		}
		GachaAccumulateModel._Instance = new GachaAccumulateModel();
		return true;
	}

	// Token: 0x0600DAE7 RID: 56039 RVA: 0x0032D95C File Offset: 0x0032BB5C
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600DAE8 RID: 56040 RVA: 0x0032D95E File Offset: 0x0032BB5E
	public static void ResetStaticDefaultValue()
	{
		GachaAccumulateModel._Instance = null;
	}

	// Token: 0x0600DAE9 RID: 56041 RVA: 0x0032D966 File Offset: 0x0032BB66
	static GachaAccumulateModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GachaAccumulateModel.CreateStaticDefaultValue), new Action(GachaAccumulateModel.ResetStaticDefaultValue));
	}

	// Token: 0x04006420 RID: 25632
	private readonly Dictionary<int, GachaAccumulateData> AccumulateDataMap = new Dictionary<int, GachaAccumulateData>();

	// Token: 0x04006421 RID: 25633
	private readonly Dictionary<int, List<GachaAccumulateData>> GroupIdDataMap = new Dictionary<int, List<GachaAccumulateData>>();

	// Token: 0x04006422 RID: 25634
	[Nullable(2)]
	private static GachaAccumulateModel _Instance;
}
