using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x020009A5 RID: 2469
[NullableContext(1)]
[Nullable(0)]
public class ScratchTicketData : ActivityBaseData
{
	// Token: 0x06006C51 RID: 27729 RVA: 0x002189E8 File Offset: 0x00216BE8
	protected override void PhraseEx(ActivityData data)
	{
		ScratchCardActivityInfo scratchCardActivityInfo = data.ScratchCardActivityInfo;
		if (scratchCardActivityInfo == null)
		{
			return;
		}
		this.InitData(scratchCardActivityInfo);
	}

	// Token: 0x06006C52 RID: 27730 RVA: 0x00218A07 File Offset: 0x00216C07
	public override bool NeedSelfControlFirstRedPoint()
	{
		return false;
	}

	// Token: 0x06006C53 RID: 27731 RVA: 0x00218A0A File Offset: 0x00216C0A
	public void InitData(ScratchCardActivityInfo activityInfo)
	{
		this.Config = ActivityScratchTicketConfig.Instance.GetScratchTicketConfig(base.Id);
		if (this.Config == null)
		{
			return;
		}
		this.InitRoundData(activityInfo.RoundInfos);
		this.InitConditionData(activityInfo.ScratchTimeInfos);
	}

	// Token: 0x06006C54 RID: 27732 RVA: 0x00218A48 File Offset: 0x00216C48
	private void InitRoundData(IEnumerable<ScratchCardRoundInfo> roundInfos)
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

	// Token: 0x06006C55 RID: 27733 RVA: 0x00218AEC File Offset: 0x00216CEC
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

	// Token: 0x06006C56 RID: 27734 RVA: 0x00218B44 File Offset: 0x00216D44
	public void UpdateCellReward(int roundId, ScratchCardRewardResponse message)
	{
		ScratchTicketRoundData roundDataById = this.GetRoundDataById(roundId);
		if (roundDataById == null)
		{
			return;
		}
		roundDataById.UpdateCellDataReward(message.OpenIndex);
		roundDataById.UpdateRemainReward(message.LeftRewardItem);
		this.UpdateAllRoundState();
	}

	// Token: 0x06006C57 RID: 27735 RVA: 0x00218B7C File Offset: 0x00216D7C
	private void InitConditionData(IEnumerable<ScratchCardTimeInfo> conditionInfos)
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

	// Token: 0x06006C58 RID: 27736 RVA: 0x00218BF0 File Offset: 0x00216DF0
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

	// Token: 0x06006C59 RID: 27737 RVA: 0x00218C50 File Offset: 0x00216E50
	public override bool GetExDataRedPointShowState()
	{
		if (!this.ActivityHasClick())
		{
			return true;
		}
		int remainCount = this.GetRemainCount();
		return this.HasRoundInProgress() && remainCount > 0;
	}

	// Token: 0x06006C5A RID: 27738 RVA: 0x00218C7C File Offset: 0x00216E7C
	protected override bool GetExDataFinishShowState()
	{
		return base.GetPreGuideQuestFinishState() && this.IsAllRoundFinish();
	}

	// Token: 0x06006C5B RID: 27739 RVA: 0x00218C8E File Offset: 0x00216E8E
	public bool IsInit()
	{
		return this.RoundDataList.Count > 0;
	}

	// Token: 0x06006C5C RID: 27740 RVA: 0x00218C9E File Offset: 0x00216E9E
	public bool ActivityHasClick()
	{
		return ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 100, 0, 0) == 1;
	}

	// Token: 0x06006C5D RID: 27741 RVA: 0x00218CB8 File Offset: 0x00216EB8
	public void ClickRedDot()
	{
		ActivityModel.Instance.SaveActivityData(base.Id, 100, 0, 0, 1);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
	}

	// Token: 0x06006C5E RID: 27742 RVA: 0x00218CE8 File Offset: 0x00216EE8
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

	// Token: 0x06006C5F RID: 27743 RVA: 0x00218D74 File Offset: 0x00216F74
	public ScratchCardActivityRe? GetScratchCardActivityConfig()
	{
		return this.Config;
	}

	// Token: 0x06006C60 RID: 27744 RVA: 0x00218D7C File Offset: 0x00216F7C
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

	// Token: 0x06006C61 RID: 27745 RVA: 0x00218DD8 File Offset: 0x00216FD8
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

	// Token: 0x06006C62 RID: 27746 RVA: 0x00218E1C File Offset: 0x0021701C
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

	// Token: 0x06006C63 RID: 27747 RVA: 0x00218E54 File Offset: 0x00217054
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

	// Token: 0x06006C64 RID: 27748 RVA: 0x00218E7A File Offset: 0x0021707A
	public List<ScratchTicketRoundData> GetRoundDataList()
	{
		return this.RoundDataList;
	}

	// Token: 0x06006C65 RID: 27749 RVA: 0x00218E82 File Offset: 0x00217082
	public List<ScratchTicketConditionData> GetConditionDataList()
	{
		return this.ConditionDataList;
	}

	// Token: 0x06006C66 RID: 27750 RVA: 0x00218E8C File Offset: 0x0021708C
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

	// Token: 0x06006C67 RID: 27751 RVA: 0x00218EE8 File Offset: 0x002170E8
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

	// Token: 0x06006C68 RID: 27752 RVA: 0x00218F44 File Offset: 0x00217144
	public int GetRemainCount()
	{
		int itemId = this.Config.Value.ItemId;
		return InventoryModel.Instance.GetCommonItemCount(itemId, 0);
	}

	// Token: 0x06006C69 RID: 27753 RVA: 0x00218F74 File Offset: 0x00217174
	public int GetCostItemId()
	{
		return this.Config.Value.ItemId;
	}

	// Token: 0x040043CC RID: 17356
	private const int SCRATCH_TICKET_RED_DOT_CACHE_KEY = 100;

	// Token: 0x040043CD RID: 17357
	private List<ScratchTicketRoundData> RoundDataList = new List<ScratchTicketRoundData>();

	// Token: 0x040043CE RID: 17358
	private List<ScratchTicketConditionData> ConditionDataList = new List<ScratchTicketConditionData>();

	// Token: 0x040043CF RID: 17359
	private ScratchCardActivityRe? Config;
}
