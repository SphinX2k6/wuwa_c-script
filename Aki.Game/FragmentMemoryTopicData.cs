using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x020010DB RID: 4315
[NullableContext(1)]
[Nullable(0)]
public class FragmentMemoryTopicData
{
	// Token: 0x0600AC19 RID: 44057 RVA: 0x0032AD53 File Offset: 0x00328F53
	public int GetId()
	{
		return this.Id;
	}

	// Token: 0x0600AC1A RID: 44058 RVA: 0x0032AD5C File Offset: 0x00328F5C
	public void Phrase(PhotoMemoryTopicInfo data)
	{
		this.Id = data.Id;
		this.UnlockState = data.IsUnlock;
		this.FragmentMemoryCollectDataList = new List<FragmentMemoryCollectData>();
		foreach (PhotoMemoryCollectInfo photoMemoryCollectInfo in data.CollectInfos)
		{
			FragmentMemoryCollectData fragmentMemoryCollectData = new FragmentMemoryCollectData();
			fragmentMemoryCollectData.Phrase(photoMemoryCollectInfo);
			fragmentMemoryCollectData.PhraseFromConfig(FragmentMemoryConfig.Instance.GetPhotoMemoryCollectById(photoMemoryCollectInfo.Id).Value);
			fragmentMemoryCollectData.BindSourceTopic(this);
			this.FragmentMemoryCollectDataList.Add(fragmentMemoryCollectData);
		}
		foreach (PhotoMemoryCollect config in FragmentMemoryConfig.Instance.GetPhotoMemoryCollectConfigListByTopicId(this.Id))
		{
			FragmentMemoryCollectData fragmentMemoryCollectData2 = null;
			foreach (FragmentMemoryCollectData fragmentMemoryCollectData3 in this.FragmentMemoryCollectDataList)
			{
				if (fragmentMemoryCollectData3.GetId() == config.Id)
				{
					fragmentMemoryCollectData2 = fragmentMemoryCollectData3;
					break;
				}
			}
			if (fragmentMemoryCollectData2 == null)
			{
				FragmentMemoryCollectData fragmentMemoryCollectData4 = new FragmentMemoryCollectData();
				fragmentMemoryCollectData4.PhraseFromConfig(config);
				fragmentMemoryCollectData4.BindSourceTopic(this);
				this.FragmentMemoryCollectDataList.Add(fragmentMemoryCollectData4);
			}
		}
		this.FragmentMemoryCollectDataList.Sort((FragmentMemoryCollectData a, FragmentMemoryCollectData b) => a.GetRank() - b.GetRank());
		EventSystem.Instance.Emit<int>(EEventName.FragmentRewardTopicRedDot, this.Id);
	}

	// Token: 0x0600AC1B RID: 44059 RVA: 0x0032AF0C File Offset: 0x0032910C
	public bool GetFirstOpen()
	{
		return FragmentMemoryModel.Instance.GetTopicFirstOpenRedDotState(this.Id);
	}

	// Token: 0x0600AC1C RID: 44060 RVA: 0x0032AF20 File Offset: 0x00329120
	public bool GetRedDotState()
	{
		if (!this.UnlockState)
		{
			return false;
		}
		if (this.GetFirstOpen())
		{
			return true;
		}
		using (List<FragmentMemoryCollectData>.Enumerator enumerator = this.FragmentMemoryCollectDataList.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.GetIfCanGetReward())
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x0600AC1D RID: 44061 RVA: 0x0032AF90 File Offset: 0x00329190
	public bool GetCollectRedDotState()
	{
		if (!this.UnlockState)
		{
			return false;
		}
		using (List<FragmentMemoryCollectData>.Enumerator enumerator = this.FragmentMemoryCollectDataList.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.GetIfCanGetReward())
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x0600AC1E RID: 44062 RVA: 0x0032AFF4 File Offset: 0x003291F4
	public ClueEntrance GetClueEntrance()
	{
		PhotoMemoryTopic? photoMemoryTopicById = FragmentMemoryConfig.Instance.GetPhotoMemoryTopicById(this.Id);
		return FragmentMemoryConfig.Instance.GetClueEntrance(photoMemoryTopicById.Value.ClueId).Value;
	}

	// Token: 0x0600AC1F RID: 44063 RVA: 0x0032B034 File Offset: 0x00329234
	public IReadOnlyList<ClueContent> GetClueContent()
	{
		return FragmentMemoryConfig.Instance.GetClueContent(this.GetClueEntrance().ContentGroupId);
	}

	// Token: 0x0600AC20 RID: 44064 RVA: 0x0032B059 File Offset: 0x00329259
	public List<FragmentMemoryCollectData> GetCollectDataList()
	{
		return this.FragmentMemoryCollectDataList;
	}

	// Token: 0x0600AC21 RID: 44065 RVA: 0x0032B061 File Offset: 0x00329261
	public int GetMemoryCollectNum()
	{
		return this.FragmentMemoryCollectDataList.Count;
	}

	// Token: 0x0600AC22 RID: 44066 RVA: 0x0032B070 File Offset: 0x00329270
	public bool GetCollectRewardDoneState()
	{
		if (this.FragmentMemoryCollectDataList.Count == 0)
		{
			return false;
		}
		using (List<FragmentMemoryCollectData>.Enumerator enumerator = this.FragmentMemoryCollectDataList.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (!enumerator.Current.GetIfGetReward())
				{
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x0600AC23 RID: 44067 RVA: 0x0032B0D8 File Offset: 0x003292D8
	public int GetFinishCollectNum()
	{
		int num = 0;
		using (List<FragmentMemoryCollectData>.Enumerator enumerator = this.FragmentMemoryCollectDataList.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.GetIfUnlock())
				{
					num++;
				}
			}
		}
		return num;
	}

	// Token: 0x0600AC24 RID: 44068 RVA: 0x0032B134 File Offset: 0x00329334
	public bool GetAllCollectState()
	{
		using (List<FragmentMemoryCollectData>.Enumerator enumerator = this.FragmentMemoryCollectDataList.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (!enumerator.Current.GetIfUnlock())
				{
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x0600AC25 RID: 44069 RVA: 0x0032B190 File Offset: 0x00329390
	public bool GetUnlockState()
	{
		return this.UnlockState;
	}

	// Token: 0x0600AC26 RID: 44070 RVA: 0x0032B198 File Offset: 0x00329398
	public PhotoMemoryTopic GetConfig()
	{
		return FragmentMemoryConfig.Instance.GetPhotoMemoryTopicById(this.Id).Value;
	}

	// Token: 0x0600AC27 RID: 44071 RVA: 0x0032B1C0 File Offset: 0x003293C0
	public string GetConditionDesc()
	{
		return LevelGeneralCommons.GetConditionGroupHintText(this.GetConfig().ConditionGroupId) ?? "";
	}

	// Token: 0x04006359 RID: 25433
	private int Id;

	// Token: 0x0400635A RID: 25434
	private List<FragmentMemoryCollectData> FragmentMemoryCollectDataList = new List<FragmentMemoryCollectData>();

	// Token: 0x0400635B RID: 25435
	private bool UnlockState = true;
}
