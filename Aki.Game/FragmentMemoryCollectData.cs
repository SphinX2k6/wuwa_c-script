using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Reward;

// Token: 0x02001C1B RID: 7195
[NullableContext(1)]
[Nullable(0)]
public class FragmentMemoryCollectData
{
	// Token: 0x0600D7E6 RID: 55270 RVA: 0x0031F623 File Offset: 0x0031D823
	public int GetId()
	{
		return this.Id;
	}

	// Token: 0x0600D7E7 RID: 55271 RVA: 0x0031F62B File Offset: 0x0031D82B
	public int GetFlag()
	{
		return this.Flag;
	}

	// Token: 0x0600D7E8 RID: 55272 RVA: 0x0031F633 File Offset: 0x0031D833
	public bool GetIfCanGetReward()
	{
		return this.GetIfUnlock() && !this.GetIfGetReward();
	}

	// Token: 0x0600D7E9 RID: 55273 RVA: 0x0031F648 File Offset: 0x0031D848
	public bool GetIfUnlock()
	{
		return (this.Flag & 1) == 1;
	}

	// Token: 0x0600D7EA RID: 55274 RVA: 0x0031F655 File Offset: 0x0031D855
	[NullableContext(2)]
	public FragmentMemoryTopicData GetTopicData()
	{
		return this.TopicData;
	}

	// Token: 0x0600D7EB RID: 55275 RVA: 0x0031F65D File Offset: 0x0031D85D
	public bool GetIfGetReward()
	{
		return (this.Flag >> 1 & 1) == 1;
	}

	// Token: 0x0600D7EC RID: 55276 RVA: 0x0031F66C File Offset: 0x0031D86C
	public int GetTraceEntityId()
	{
		return this.GetConfig().TraceEntityId;
	}

	// Token: 0x0600D7ED RID: 55277 RVA: 0x0031F688 File Offset: 0x0031D888
	public int GetTraceMarkId()
	{
		return this.GetConfig().TraceMarkId;
	}

	// Token: 0x0600D7EE RID: 55278 RVA: 0x0031F6A4 File Offset: 0x0031D8A4
	public int GetTrackMapId()
	{
		return this.GetConfig().TrackMapId;
	}

	// Token: 0x0600D7EF RID: 55279 RVA: 0x0031F6C0 File Offset: 0x0031D8C0
	public List<int> GetQuestList()
	{
		return this.GetConfig().GetQuestIdListArray().ToList<int>();
	}

	// Token: 0x0600D7F0 RID: 55280 RVA: 0x0031F6E0 File Offset: 0x0031D8E0
	public double GetFinishTime()
	{
		return this.FinishTime;
	}

	// Token: 0x0600D7F1 RID: 55281 RVA: 0x0031F6E8 File Offset: 0x0031D8E8
	public void PhraseFromConfig(PhotoMemoryCollect config)
	{
		this.Id = config.Id;
	}

	// Token: 0x0600D7F2 RID: 55282 RVA: 0x0031F6F8 File Offset: 0x0031D8F8
	public int GetRank()
	{
		return this.GetConfig().Rank;
	}

	// Token: 0x0600D7F3 RID: 55283 RVA: 0x0031F714 File Offset: 0x0031D914
	public void Phrase(PhotoMemoryCollectInfo data)
	{
		this.Id = data.Id;
		this.Flag = data.Flag;
		this.FinishTime = (double)MathUtils.Instance.LongToBigInt(data.CollectTime) / 1000.0;
		EventSystem.Instance.Emit<int>(EEventName.FragmentRewardRedDot, this.Id);
	}

	// Token: 0x0600D7F4 RID: 55284 RVA: 0x0031F770 File Offset: 0x0031D970
	public string GetTimeText()
	{
		if (this.FinishTime == 0.0)
		{
			return "";
		}
		return TimeUtil.Instance.DateFormatString(this.FinishTime);
	}

	// Token: 0x0600D7F5 RID: 55285 RVA: 0x0031F799 File Offset: 0x0031D999
	public void BindSourceTopic(FragmentMemoryTopicData topicData)
	{
		this.TopicData = topicData;
	}

	// Token: 0x0600D7F6 RID: 55286 RVA: 0x0031F7A4 File Offset: 0x0031D9A4
	public ClueEntrance GetClueEntrance()
	{
		return FragmentMemoryConfig.Instance.GetClueEntrance(this.GetClueId()).Value;
	}

	// Token: 0x0600D7F7 RID: 55287 RVA: 0x0031F7CC File Offset: 0x0031D9CC
	public IReadOnlyList<ClueContent> GetClueContent()
	{
		return FragmentMemoryConfig.Instance.GetClueContent(this.GetClueEntrance().ContentGroupId);
	}

	// Token: 0x0600D7F8 RID: 55288 RVA: 0x0031F7F4 File Offset: 0x0031D9F4
	public int GetClueId()
	{
		return this.GetConfig().ClueId;
	}

	// Token: 0x0600D7F9 RID: 55289 RVA: 0x0031F810 File Offset: 0x0031DA10
	public PhotoMemoryCollect GetConfig()
	{
		return FragmentMemoryConfig.Instance.GetPhotoMemoryCollectById(this.Id).Value;
	}

	// Token: 0x0600D7FA RID: 55290 RVA: 0x0031F838 File Offset: 0x0031DA38
	public string GetTitle()
	{
		return this.GetConfig().Title;
	}

	// Token: 0x0600D7FB RID: 55291 RVA: 0x0031F854 File Offset: 0x0031DA54
	public string GetTipsDesc()
	{
		return this.GetConfig().TipsDesc;
	}

	// Token: 0x0600D7FC RID: 55292 RVA: 0x0031F870 File Offset: 0x0031DA70
	public string GetDesc()
	{
		return this.GetConfig().Desc;
	}

	// Token: 0x0600D7FD RID: 55293 RVA: 0x0031F88C File Offset: 0x0031DA8C
	public int GetDropId()
	{
		return this.GetConfig().DropId;
	}

	// Token: 0x0600D7FE RID: 55294 RVA: 0x0031F8A8 File Offset: 0x0031DAA8
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

	// Token: 0x0600D7FF RID: 55295 RVA: 0x0031F944 File Offset: 0x0031DB44
	public string GetThemeBg()
	{
		return this.GetBgResource();
	}

	// Token: 0x0600D800 RID: 55296 RVA: 0x0031F94C File Offset: 0x0031DB4C
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

	// Token: 0x0600D801 RID: 55297 RVA: 0x0031F980 File Offset: 0x0031DB80
	private string GetMaleBgResource()
	{
		return this.GetConfig().BgResourceM;
	}

	// Token: 0x0600D802 RID: 55298 RVA: 0x0031F99C File Offset: 0x0031DB9C
	private string GetFemaleBgResource()
	{
		return this.GetConfig().BgResourceF;
	}

	// Token: 0x04006283 RID: 25219
	private int Id;

	// Token: 0x04006284 RID: 25220
	private int Flag;

	// Token: 0x04006285 RID: 25221
	[Nullable(2)]
	private FragmentMemoryTopicData TopicData;

	// Token: 0x04006286 RID: 25222
	private double FinishTime;
}
