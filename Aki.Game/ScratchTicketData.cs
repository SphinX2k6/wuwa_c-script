using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x020014ED RID: 5357
[NullableContext(1)]
[Nullable(0)]
public class ScratchTicketData : ActivityBaseData
{
	// Token: 0x06009877 RID: 39031 RVA: 0x0020ECAC File Offset: 0x0020CEAC
	protected override void PhraseEx(ActivityData data)
	{
		ScratchCardActivityInfo scratchCardActivityInfo = data.ScratchCardActivityInfo;
		if (scratchCardActivityInfo == null)
		{
			return;
		}
		this.InitData(scratchCardActivityInfo);
	}

	// Token: 0x06009878 RID: 39032 RVA: 0x0020ECCB File Offset: 0x0020CECB
	public override bool NeedSelfControlFirstRedPoint()
	{
		return false;
	}

	// Token: 0x06009879 RID: 39033 RVA: 0x0020ECD0 File Offset: 0x0020CED0
	public void InitData(ScratchCardActivityInfo activityInfo)
	{
		this.Config = ActivityScratchTicketConfig.Instance.GetScratchTicketConfig(base.Id);
		if (this.Config == null)
		{
			return;
		}
		this.InitRoundData(activityInfo.RoundInfos.ToList<ScratchCardRoundInfo>());
		this.InitConditionData(activityInfo.ScratchTimeInfos.ToList<ScratchCardTimeInfo>());
	}

	// Token: 0x0600987A RID: 39034 RVA: 0x0020ED24 File Offset: 0x0020CF24
	private void InitRoundData(List<ScratchCardRoundInfo> roundInfos)
	{
		if (this.RoundDataList.Count > 0)
		{
			return;
		}
		this.RoundDataList = new List<ScratchTicketRoundData>();
		foreach (ScratchCardRoundInfo roundInfo in roundInfos)
		{
			ScratchTicketRoundData scratchTicketRoundData = new ScratchTicketRoundData();
			scratchTicketRoundData.Init(roundInfo);
			this.RoundDataList.Add(scratchTicketRoundData);
		}
		this.RoundDataList.Sort((ScratchTicketRoundData a, ScratchTicketRoundData b) => a.Config.Value.PreRoundId - b.Config.Value.PreRoundId);
		this.UpdateAllRoundState();
	}

	// Token: 0x0600987B RID: 39035 RVA: 0x0020EDD0 File Offset: 0x0020CFD0
	public void UpdateAllRoundState()
	{
		for (int i = 0; i < this.RoundDataList.Count; i++)
		{
			ScratchTicketRoundData scratchTicketRoundData = this.RoundDataList[i];
			if (i == 0)
			{
				scratchTicketRoundData.UpdateRoundState(EScratchTicketRoundState.Finish);
			}
			else
			{
				ScratchTicketRoundData scratchTicketRoundData2 = this.RoundDataList[i - 1];
				scratchTicketRoundData.UpdateRoundState(scratchTicketRoundData2.GetRoundState());
			}
		}
	}

	// Token: 0x0600987C RID: 39036 RVA: 0x0020EE28 File Offset: 0x0020D028
	public void UpdateCellReward(int roundId, ScratchCardRewardResponse message)
	{
		ScratchTicketRoundData roundDataById = this.GetRoundDataById(roundId);
		if (roundDataById == null)
		{
			return;
		}
		roundDataById.UpdateCellDataReward(message.OpenIndex.ToDictionary<int, ScratchCardRewardData>());
		roundDataById.UpdateRemainReward(message.LeftRewardItem.ToDictionary<int, int>());
		this.UpdateAllRoundState();
	}

	// Token: 0x0600987D RID: 39037 RVA: 0x0020EE6C File Offset: 0x0020D06C
	private void InitConditionData(List<ScratchCardTimeInfo> conditionInfos)
	{
		if (this.ConditionDataList.Count > 0)
		{
			return;
		}
		this.ConditionDataList = new List<ScratchTicketConditionData>();
		foreach (ScratchCardTimeInfo condition in conditionInfos)
		{
			ScratchTicketConditionData scratchTicketConditionData = new ScratchTicketConditionData();
			scratchTicketConditionData.Init(condition);
			this.ConditionDataList.Add(scratchTicketConditionData);
		}
	}

	// Token: 0x0600987E RID: 39038 RVA: 0x0020EEE8 File Offset: 0x0020D0E8
	public void RefreshConditionData(List<ScratchCardTimeInfo> conditionInfos)
	{
		foreach (ScratchCardTimeInfo scratchCardTimeInfo in conditionInfos)
		{
			ScratchTicketConditionData conditionData = this.GetConditionData(scratchCardTimeInfo.Id);
			if (conditionData != null)
			{
				conditionData.RefreshCondition(scratchCardTimeInfo);
			}
		}
	}

	// Token: 0x0600987F RID: 39039 RVA: 0x0020EF48 File Offset: 0x0020D148
	public override bool GetExDataRedPointShowState()
	{
		if (!this.ActivityHasClick())
		{
			return true;
		}
		int remainCount = this.GetRemainCount();
		return this.HasRoundInProgress() && remainCount > 0;
	}

	// Token: 0x06009880 RID: 39040 RVA: 0x0020EF74 File Offset: 0x0020D174
	protected override bool GetExDataFinishShowState()
	{
		return base.GetPreGuideQuestFinishState() && this.IsAllRoundFinish();
	}

	// Token: 0x06009881 RID: 39041 RVA: 0x0020EF86 File Offset: 0x0020D186
	public bool IsInit()
	{
		return this.RoundDataList.Count > 0;
	}

	// Token: 0x06009882 RID: 39042 RVA: 0x0020EF96 File Offset: 0x0020D196
	public bool ActivityHasClick()
	{
		return ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 100, 0, 0) == 1;
	}

	// Token: 0x06009883 RID: 39043 RVA: 0x0020EFB0 File Offset: 0x0020D1B0
	public void ClickRedDot()
	{
		ActivityModel.Instance.SaveActivityData(base.Id, 100, 0, 0, 1);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
	}

	// Token: 0x06009884 RID: 39044 RVA: 0x0020EFE0 File Offset: 0x0020D1E0
	[NullableContext(2)]
	private ScratchTicketConditionData GetConditionData(int id)
	{
		foreach (ScratchTicketConditionData scratchTicketConditionData in this.ConditionDataList)
		{
			if (scratchTicketConditionData.Id == id)
			{
				return scratchTicketConditionData;
			}
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.ScratchTicket;
		ELogAuthor author = ELogAuthor.BB;
		string message = "ScratchTicketData无法获取条件id";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
		instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		return null;
	}

	// Token: 0x06009885 RID: 39045 RVA: 0x0020F06C File Offset: 0x0020D26C
	public ScratchCardActivityRe? GetScratchCardActivityConfig()
	{
		return this.Config;
	}

	// Token: 0x06009886 RID: 39046 RVA: 0x0020F074 File Offset: 0x0020D274
	[NullableContext(2)]
	public ScratchTicketRoundData GetRoundDataById(int id)
	{
		foreach (ScratchTicketRoundData scratchTicketRoundData in this.RoundDataList)
		{
			if (scratchTicketRoundData.Id == id)
			{
				return scratchTicketRoundData;
			}
		}
		return null;
	}

	// Token: 0x06009887 RID: 39047 RVA: 0x0020F0D0 File Offset: 0x0020D2D0
	public int GetFirstProgressRoundDataIndex()
	{
		int count = this.RoundDataList.Count;
		if (count <= 0)
		{
			return -1;
		}
		for (int i = 0; i < count; i++)
		{
			if (this.RoundDataList[i].GetRoundState() != EScratchTicketRoundState.Finish)
			{
				return i;
			}
		}
		return count - 1;
	}

	// Token: 0x06009888 RID: 39048 RVA: 0x0020F114 File Offset: 0x0020D314
	public int GetRoundDataIndex(ScratchTicketRoundData roundData)
	{
		for (int i = 0; i < this.RoundDataList.Count; i++)
		{
			if (this.RoundDataList[i] == roundData)
			{
				return i;
			}
		}
		return -1;
	}

	// Token: 0x06009889 RID: 39049 RVA: 0x0020F14C File Offset: 0x0020D34C
	[NullableContext(2)]
	public ScratchTicketRoundData GetFirstProgressRoundData()
	{
		int firstProgressRoundDataIndex = this.GetFirstProgressRoundDataIndex();
		if (firstProgressRoundDataIndex < 0)
		{
			return null;
		}
		return this.RoundDataList[firstProgressRoundDataIndex];
	}

	// Token: 0x0600988A RID: 39050 RVA: 0x0020F172 File Offset: 0x0020D372
	public List<ScratchTicketRoundData> GetRoundDataList()
	{
		return this.RoundDataList;
	}

	// Token: 0x0600988B RID: 39051 RVA: 0x0020F17A File Offset: 0x0020D37A
	public List<ScratchTicketConditionData> GetConditionDataList()
	{
		return this.ConditionDataList;
	}

	// Token: 0x0600988C RID: 39052 RVA: 0x0020F184 File Offset: 0x0020D384
	public bool IsAllRoundFinish()
	{
		using (List<ScratchTicketRoundData>.Enumerator enumerator = this.RoundDataList.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.GetRoundState() != EScratchTicketRoundState.Finish)
				{
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x0600988D RID: 39053 RVA: 0x0020F1E0 File Offset: 0x0020D3E0
	public bool HasRoundInProgress()
	{
		using (List<ScratchTicketRoundData>.Enumerator enumerator = this.RoundDataList.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.GetRoundState() == EScratchTicketRoundState.InProgress)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x0600988E RID: 39054 RVA: 0x0020F23C File Offset: 0x0020D43C
	public int GetRemainCount()
	{
		int itemId = this.Config.Value.ItemId;
		return InventoryModel.Instance.GetCommonItemCount(itemId, 0);
	}

	// Token: 0x0600988F RID: 39055 RVA: 0x0020F26C File Offset: 0x0020D46C
	public int GetCostItemId()
	{
		return this.Config.Value.ItemId;
	}

	// Token: 0x04004327 RID: 17191
	private const int SCRATCH_TICKET_RED_DOT_CACHE_KEY = 100;

	// Token: 0x04004328 RID: 17192
	private List<ScratchTicketRoundData> RoundDataList = new List<ScratchTicketRoundData>();

	// Token: 0x04004329 RID: 17193
	private List<ScratchTicketConditionData> ConditionDataList = new List<ScratchTicketConditionData>();

	// Token: 0x0400432A RID: 17194
	private ScratchCardActivityRe? Config;
}
