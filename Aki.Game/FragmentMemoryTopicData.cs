using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x02001C1C RID: 7196
[NullableContext(1)]
[Nullable(0)]
public class FragmentMemoryTopicData
{
	// Token: 0x0600D804 RID: 55300 RVA: 0x0031F9BF File Offset: 0x0031DBBF
	public int GetId()
	{
		return this.Id;
	}

	// Token: 0x0600D805 RID: 55301 RVA: 0x0031F9C8 File Offset: 0x0031DBC8
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

	// Token: 0x0600D806 RID: 55302 RVA: 0x0031FB78 File Offset: 0x0031DD78
	public bool GetFirstOpen()
	{
		return FragmentMemoryModel.Instance.GetTopicFirstOpenRedDotState(this.Id);
	}

	// Token: 0x0600D807 RID: 55303 RVA: 0x0031FB8C File Offset: 0x0031DD8C
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

	// Token: 0x0600D808 RID: 55304 RVA: 0x0031FBFC File Offset: 0x0031DDFC
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

	// Token: 0x0600D809 RID: 55305 RVA: 0x0031FC60 File Offset: 0x0031DE60
	public ClueEntrance GetClueEntrance()
	{
		PhotoMemoryTopic? photoMemoryTopicById = FragmentMemoryConfig.Instance.GetPhotoMemoryTopicById(this.Id);
		return FragmentMemoryConfig.Instance.GetClueEntrance(photoMemoryTopicById.Value.ClueId).Value;
	}

	// Token: 0x0600D80A RID: 55306 RVA: 0x0031FCA0 File Offset: 0x0031DEA0
	public IReadOnlyList<ClueContent> GetClueContent()
	{
		return FragmentMemoryConfig.Instance.GetClueContent(this.GetClueEntrance().ContentGroupId);
	}

	// Token: 0x0600D80B RID: 55307 RVA: 0x0031FCC5 File Offset: 0x0031DEC5
	public List<FragmentMemoryCollectData> GetCollectDataList()
	{
		return this.FragmentMemoryCollectDataList;
	}

	// Token: 0x0600D80C RID: 55308 RVA: 0x0031FCCD File Offset: 0x0031DECD
	public int GetMemoryCollectNum()
	{
		return this.FragmentMemoryCollectDataList.Count;
	}

	// Token: 0x0600D80D RID: 55309 RVA: 0x0031FCDC File Offset: 0x0031DEDC
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

	// Token: 0x0600D80E RID: 55310 RVA: 0x0031FD44 File Offset: 0x0031DF44
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

	// Token: 0x0600D80F RID: 55311 RVA: 0x0031FDA0 File Offset: 0x0031DFA0
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

	// Token: 0x0600D810 RID: 55312 RVA: 0x0031FDFC File Offset: 0x0031DFFC
	public bool GetUnlockState()
	{
		return this.UnlockState;
	}

	// Token: 0x0600D811 RID: 55313 RVA: 0x0031FE04 File Offset: 0x0031E004
	public PhotoMemoryTopic GetConfig()
	{
		return FragmentMemoryConfig.Instance.GetPhotoMemoryTopicById(this.Id).Value;
	}

	// Token: 0x0600D812 RID: 55314 RVA: 0x0031FE2C File Offset: 0x0031E02C
	public string GetConditionDesc()
	{
		return LevelGeneralCommons.GetConditionGroupHintText(this.GetConfig().ConditionGroupId) ?? "";
	}

	// Token: 0x04006287 RID: 25223
	private int Id;

	// Token: 0x04006288 RID: 25224
	private List<FragmentMemoryCollectData> FragmentMemoryCollectDataList = new List<FragmentMemoryCollectData>();

	// Token: 0x04006289 RID: 25225
	private bool UnlockState = true;
}
