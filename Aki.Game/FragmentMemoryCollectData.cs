using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Reward;

// Token: 0x020010DA RID: 4314
[NullableContext(1)]
[Nullable(0)]
public class FragmentMemoryCollectData
{
	// Token: 0x0600ABFB RID: 44027 RVA: 0x0032A9B7 File Offset: 0x00328BB7
	public int GetId()
	{
		return this.Id;
	}

	// Token: 0x0600ABFC RID: 44028 RVA: 0x0032A9BF File Offset: 0x00328BBF
	public int GetFlag()
	{
		return this.Flag;
	}

	// Token: 0x0600ABFD RID: 44029 RVA: 0x0032A9C7 File Offset: 0x00328BC7
	public bool GetIfCanGetReward()
	{
		return this.GetIfUnlock() && !this.GetIfGetReward();
	}

	// Token: 0x0600ABFE RID: 44030 RVA: 0x0032A9DC File Offset: 0x00328BDC
	public bool GetIfUnlock()
	{
		return (this.Flag & 1) == 1;
	}

	// Token: 0x0600ABFF RID: 44031 RVA: 0x0032A9E9 File Offset: 0x00328BE9
	[NullableContext(2)]
	public FragmentMemoryTopicData GetTopicData()
	{
		return this.TopicData;
	}

	// Token: 0x0600AC00 RID: 44032 RVA: 0x0032A9F1 File Offset: 0x00328BF1
	public bool GetIfGetReward()
	{
		return (this.Flag >> 1 & 1) == 1;
	}

	// Token: 0x0600AC01 RID: 44033 RVA: 0x0032AA00 File Offset: 0x00328C00
	public int GetTraceEntityId()
	{
		return this.GetConfig().TraceEntityId;
	}

	// Token: 0x0600AC02 RID: 44034 RVA: 0x0032AA1C File Offset: 0x00328C1C
	public int GetTraceMarkId()
	{
		return this.GetConfig().TraceMarkId;
	}

	// Token: 0x0600AC03 RID: 44035 RVA: 0x0032AA38 File Offset: 0x00328C38
	public int GetTrackMapId()
	{
		return this.GetConfig().TrackMapId;
	}

	// Token: 0x0600AC04 RID: 44036 RVA: 0x0032AA54 File Offset: 0x00328C54
	public List<int> GetQuestList()
	{
		return new List<int>(this.GetConfig().GetQuestIdListArray());
	}

	// Token: 0x0600AC05 RID: 44037 RVA: 0x0032AA74 File Offset: 0x00328C74
	public double GetFinishTime()
	{
		return this.FinishTime;
	}

	// Token: 0x0600AC06 RID: 44038 RVA: 0x0032AA7C File Offset: 0x00328C7C
	public void PhraseFromConfig(PhotoMemoryCollect config)
	{
		this.Id = config.Id;
	}

	// Token: 0x0600AC07 RID: 44039 RVA: 0x0032AA8C File Offset: 0x00328C8C
	public int GetRank()
	{
		return this.GetConfig().Rank;
	}

	// Token: 0x0600AC08 RID: 44040 RVA: 0x0032AAA8 File Offset: 0x00328CA8
	public void Phrase(PhotoMemoryCollectInfo data)
	{
		this.Id = data.Id;
		this.Flag = data.Flag;
		this.FinishTime = (double)MathUtils.Instance.LongToBigInt(data.CollectTime) / 1000.0;
		EventSystem.Instance.Emit<int>(EEventName.FragmentRewardRedDot, this.Id);
	}

	// Token: 0x0600AC09 RID: 44041 RVA: 0x0032AB04 File Offset: 0x00328D04
	public string GetTimeText()
	{
		if (this.FinishTime == 0.0)
		{
			return "";
		}
		return TimeUtil.Instance.DateFormatString(this.FinishTime);
	}

	// Token: 0x0600AC0A RID: 44042 RVA: 0x0032AB2D File Offset: 0x00328D2D
	public void BindSourceTopic(FragmentMemoryTopicData topicData)
	{
		this.TopicData = topicData;
	}

	// Token: 0x0600AC0B RID: 44043 RVA: 0x0032AB38 File Offset: 0x00328D38
	public ClueEntrance GetClueEntrance()
	{
		return FragmentMemoryConfig.Instance.GetClueEntrance(this.GetClueId()).Value;
	}

	// Token: 0x0600AC0C RID: 44044 RVA: 0x0032AB60 File Offset: 0x00328D60
	public IReadOnlyList<ClueContent> GetClueContent()
	{
		return FragmentMemoryConfig.Instance.GetClueContent(this.GetClueEntrance().ContentGroupId);
	}

	// Token: 0x0600AC0D RID: 44045 RVA: 0x0032AB88 File Offset: 0x00328D88
	public int GetClueId()
	{
		return this.GetConfig().ClueId;
	}

	// Token: 0x0600AC0E RID: 44046 RVA: 0x0032ABA4 File Offset: 0x00328DA4
	public PhotoMemoryCollect GetConfig()
	{
		return FragmentMemoryConfig.Instance.GetPhotoMemoryCollectById(this.Id).Value;
	}

	// Token: 0x0600AC0F RID: 44047 RVA: 0x0032ABCC File Offset: 0x00328DCC
	public string GetTitle()
	{
		return this.GetConfig().Title;
	}

	// Token: 0x0600AC10 RID: 44048 RVA: 0x0032ABE8 File Offset: 0x00328DE8
	public string GetTipsDesc()
	{
		return this.GetConfig().TipsDesc;
	}

	// Token: 0x0600AC11 RID: 44049 RVA: 0x0032AC04 File Offset: 0x00328E04
	public string GetDesc()
	{
		return this.GetConfig().Desc;
	}

	// Token: 0x0600AC12 RID: 44050 RVA: 0x0032AC20 File Offset: 0x00328E20
	public int GetDropId()
	{
		return this.GetConfig().DropId;
	}

	// Token: 0x0600AC13 RID: 44051 RVA: 0x0032AC3C File Offset: 0x00328E3C
	public List<TItem> GetPreviewReward()
	{
		Dictionary<int, int> dictionary = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackage(this.GetDropId()).Value.DropPreview();
		List<TItem> list = new List<TItem>();
		foreach (KeyValuePair<int, int> keyValuePair in dictionary)
		{
			int key = keyValuePair.Key;
			int value = keyValuePair.Value;
			TItem item = new TItem(new InventoryDefine.GetItemData(key, 0), value);
			list.Add(item);
		}
		return list;
	}

	// Token: 0x0600AC14 RID: 44052 RVA: 0x0032ACD8 File Offset: 0x00328ED8
	public string GetThemeBg()
	{
		return this.GetBgResource();
	}

	// Token: 0x0600AC15 RID: 44053 RVA: 0x0032ACE0 File Offset: 0x00328EE0
	public string GetBgResource()
	{
		EPlayerGender playerGender = PlayerInfoModel.Instance.GetPlayerGender();
		if (playerGender == EPlayerGender.Male)
		{
			return this.GetMaleBgResource();
		}
		if (playerGender == EPlayerGender.Female)
		{
			return this.GetFemaleBgResource();
		}
		return "";
	}

	// Token: 0x0600AC16 RID: 44054 RVA: 0x0032AD14 File Offset: 0x00328F14
	private string GetMaleBgResource()
	{
		return this.GetConfig().BgResourceM;
	}

	// Token: 0x0600AC17 RID: 44055 RVA: 0x0032AD30 File Offset: 0x00328F30
	private string GetFemaleBgResource()
	{
		return this.GetConfig().BgResourceF;
	}

	// Token: 0x04006355 RID: 25429
	private int Id;

	// Token: 0x04006356 RID: 25430
	private int Flag;

	// Token: 0x04006357 RID: 25431
	[Nullable(2)]
	private FragmentMemoryTopicData TopicData;

	// Token: 0x04006358 RID: 25432
	private double FinishTime;
}
