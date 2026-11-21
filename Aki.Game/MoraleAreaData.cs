using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Morale;
using CSharpScript.Game.Module.Morale.Data;

// Token: 0x02001700 RID: 5888
[NullableContext(1)]
[Nullable(0)]
public class MoraleAreaData
{
	// Token: 0x0600E4F4 RID: 58612 RVA: 0x004331B0 File Offset: 0x004313B0
	public static MoraleAreaData Create(MoraleArea config)
	{
		MoraleAreaData moraleAreaData = new MoraleAreaData(config);
		moraleAreaData.Init();
		return moraleAreaData;
	}

	// Token: 0x0600E4F5 RID: 58613 RVA: 0x004331C0 File Offset: 0x004313C0
	private MoraleAreaData(MoraleArea config)
	{
		this.Config = config;
		this.Id = config.Id;
		this.ExploreBoxTotalCount = config.ExploreBoxLength;
	}

	// Token: 0x0600E4F6 RID: 58614 RVA: 0x00433220 File Offset: 0x00431420
	private void Init()
	{
		IReadOnlyList<FlagArea> flagConfigListByAreaId = MoraleConfig.Instance.GetFlagConfigListByAreaId(this.Id);
		for (int i = 0; i < flagConfigListByAreaId.Count; i++)
		{
			MoraleAreaFlagData moraleAreaFlagData = MoraleAreaFlagData.Create(flagConfigListByAreaId[i]);
			this.FlagList.Add(moraleAreaFlagData);
			this.FlagMap[moraleAreaFlagData.Id] = moraleAreaFlagData;
			if (moraleAreaFlagData.TypeConfig != null && moraleAreaFlagData.TypeConfig.Value.ShowUiMap != 0)
			{
				this.UiFlagList.Add(moraleAreaFlagData);
				for (int j = 0; j < moraleAreaFlagData.AreaPlotDataList.Count; j++)
				{
					MoraleAreaPlotData moraleAreaPlotData = moraleAreaFlagData.AreaPlotDataList[j];
					this.PlotDataMap[moraleAreaPlotData.Id] = moraleAreaPlotData;
				}
			}
		}
		this.UiFlagList.Sort((MoraleAreaFlagData a, MoraleAreaFlagData b) => a.Id - b.Id);
	}

	// Token: 0x0600E4F7 RID: 58615 RVA: 0x00433318 File Offset: 0x00431518
	[NullableContext(2)]
	public MoraleAreaFlagData GetFlag(int flagId)
	{
		MoraleAreaFlagData result;
		if (!this.FlagMap.TryGetValue(flagId, out result))
		{
			return null;
		}
		return result;
	}

	// Token: 0x0600E4F8 RID: 58616 RVA: 0x00433338 File Offset: 0x00431538
	public IReadOnlyList<MoraleAreaFlagData> GetFlagList()
	{
		return this.FlagList;
	}

	// Token: 0x0600E4F9 RID: 58617 RVA: 0x00433340 File Offset: 0x00431540
	public IReadOnlyList<int> GetAllPlotIdList()
	{
		return this.Config.GetPlotIdListArray();
	}

	// Token: 0x0600E4FA RID: 58618 RVA: 0x0043334D File Offset: 0x0043154D
	[NullableContext(2)]
	public MoraleAreaPlotData GetPlotData(int itemId)
	{
		return this.PlotDataMap.GetValueOrDefault(itemId);
	}

	// Token: 0x0600E4FB RID: 58619 RVA: 0x0043335C File Offset: 0x0043155C
	public int GetActiveFlagNum()
	{
		int num = 0;
		for (int i = 0; i < this.FlagList.Count; i++)
		{
			if (this.FlagList[i].IsActive)
			{
				num++;
			}
		}
		return num;
	}

	// Token: 0x0600E4FC RID: 58620 RVA: 0x00433399 File Offset: 0x00431599
	public int GetTotalFlagNum()
	{
		return this.FlagList.Count;
	}

	// Token: 0x0600E4FD RID: 58621 RVA: 0x004333A6 File Offset: 0x004315A6
	public bool IsAllFlagActive()
	{
		return this.GetActiveFlagNum() == this.GetTotalFlagNum();
	}

	// Token: 0x0600E4FE RID: 58622 RVA: 0x004333B6 File Offset: 0x004315B6
	public IReadOnlyList<MoraleAreaFlagData> GetUiFlagList()
	{
		return this.UiFlagList;
	}

	// Token: 0x0600E4FF RID: 58623 RVA: 0x004333C0 File Offset: 0x004315C0
	public int GetUiActiveFlagNum()
	{
		int num = 0;
		for (int i = 0; i < this.UiFlagList.Count; i++)
		{
			if (this.UiFlagList[i].IsActive)
			{
				num++;
			}
		}
		return num;
	}

	// Token: 0x0600E500 RID: 58624 RVA: 0x004333FD File Offset: 0x004315FD
	public int GetUiTotalFlagNum()
	{
		return this.UiFlagList.Count;
	}

	// Token: 0x0600E501 RID: 58625 RVA: 0x0043340C File Offset: 0x0043160C
	public bool IsAllUiFlagActive()
	{
		for (int i = 0; i < this.UiFlagList.Count; i++)
		{
			if (!this.UiFlagList[i].IsActive)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600E502 RID: 58626 RVA: 0x00433448 File Offset: 0x00431648
	public int GetAreaFlagActiveNum(EMoraleFlagType flagType)
	{
		int num = 0;
		for (int i = 0; i < this.FlagList.Count; i++)
		{
			if (this.FlagList[i].IsFlagType(flagType) && this.FlagList[i].IsActive)
			{
				num++;
			}
		}
		return num;
	}

	// Token: 0x0600E503 RID: 58627 RVA: 0x0043349C File Offset: 0x0043169C
	public int GetAreaFlagTotalNum(EMoraleFlagType flagType)
	{
		int num = 0;
		for (int i = 0; i < this.FlagList.Count; i++)
		{
			if (this.FlagList[i].IsFlagType(flagType))
			{
				num++;
			}
		}
		return num;
	}

	// Token: 0x0600E504 RID: 58628 RVA: 0x004334DC File Offset: 0x004316DC
	public bool IsExistFlagRewardCanGet()
	{
		for (int i = 0; i < this.UiFlagList.Count; i++)
		{
			if (this.UiFlagList[i].HasBoxCanGet())
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600E505 RID: 58629 RVA: 0x00433518 File Offset: 0x00431718
	public bool IsAllFlagRewardReceived()
	{
		for (int i = 0; i < this.UiFlagList.Count; i++)
		{
			MoraleAreaFlagData moraleAreaFlagData = this.UiFlagList[i];
			if (moraleAreaFlagData.HasBox && !moraleAreaFlagData.IsGetBox)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600E506 RID: 58630 RVA: 0x0043355C File Offset: 0x0043175C
	public List<MoraleAreaPlotData> GetUnlockPlotList()
	{
		List<MoraleAreaPlotData> list = new List<MoraleAreaPlotData>();
		for (int i = 0; i < this.UiFlagList.Count; i++)
		{
			MoraleAreaFlagData moraleAreaFlagData = this.UiFlagList[i];
			if (moraleAreaFlagData.IsActive && !moraleAreaFlagData.IsNewUnlock)
			{
				for (int j = 0; j < moraleAreaFlagData.AreaPlotDataList.Count; j++)
				{
					list.Add(moraleAreaFlagData.AreaPlotDataList[j]);
				}
			}
		}
		return list;
	}

	// Token: 0x0600E507 RID: 58631 RVA: 0x004335CC File Offset: 0x004317CC
	public List<MoraleAreaPlotData> GetNewUnlockPlotList()
	{
		List<MoraleAreaPlotData> list = new List<MoraleAreaPlotData>();
		for (int i = 0; i < this.UiFlagList.Count; i++)
		{
			MoraleAreaFlagData moraleAreaFlagData = this.UiFlagList[i];
			if (moraleAreaFlagData.IsNewUnlock)
			{
				for (int j = 0; j < moraleAreaFlagData.AreaPlotDataList.Count; j++)
				{
					list.Add(moraleAreaFlagData.AreaPlotDataList[j]);
				}
			}
		}
		return list;
	}

	// Token: 0x0600E508 RID: 58632 RVA: 0x00433633 File Offset: 0x00431833
	public void UpdateExploreBoxReceived(int receivedCount)
	{
		this.ExploreBoxReceivedCount = receivedCount;
	}

	// Token: 0x0600E509 RID: 58633 RVA: 0x0043363C File Offset: 0x0043183C
	public bool IsExistBox()
	{
		if (this.ExploreBoxTotalCount > 0)
		{
			return true;
		}
		for (int i = 0; i < this.UiFlagList.Count; i++)
		{
			if (this.UiFlagList[i].HasBox)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600E50A RID: 58634 RVA: 0x00433680 File Offset: 0x00431880
	public int GetAllFlagBoxReceivedCount()
	{
		int num = 0;
		for (int i = 0; i < this.UiFlagList.Count; i++)
		{
			num += this.UiFlagList[i].BoxReceivedCount;
		}
		return num;
	}

	// Token: 0x0600E50B RID: 58635 RVA: 0x004336BC File Offset: 0x004318BC
	public int GetAllFlagBoxTotalCount()
	{
		int num = 0;
		for (int i = 0; i < this.UiFlagList.Count; i++)
		{
			num += this.UiFlagList[i].BoxTotalCount;
		}
		return num;
	}

	// Token: 0x0600E50C RID: 58636 RVA: 0x004336F6 File Offset: 0x004318F6
	public int GetAllBoxReceivedCount()
	{
		return this.GetAllFlagBoxReceivedCount() + this.ExploreBoxReceivedCount;
	}

	// Token: 0x0600E50D RID: 58637 RVA: 0x00433705 File Offset: 0x00431905
	public int GetAllBoxTotalCount()
	{
		return this.GetAllFlagBoxTotalCount() + this.ExploreBoxTotalCount;
	}

	// Token: 0x0600E50E RID: 58638 RVA: 0x00433714 File Offset: 0x00431914
	public bool IsPlayerInArea()
	{
		MoraleModel instance = MoraleModel.Instance;
		int num = (instance != null) ? instance.PlayerMoraleAreaId : 0;
		return this.Id == num;
	}

	// Token: 0x0600E50F RID: 58639 RVA: 0x0043373C File Offset: 0x0043193C
	public int GetDefaultSelectFlagId()
	{
		if (MoraleConfig.Instance.GetMoraleSelectHighLevelFlag())
		{
			for (int i = 0; i < this.UiFlagList.Count; i++)
			{
				if (this.UiFlagList[i].IsHighDifficultyChallenge())
				{
					return this.UiFlagList[i].Id;
				}
			}
		}
		for (int j = 0; j < this.UiFlagList.Count; j++)
		{
			if (!this.UiFlagList[j].IsActive)
			{
				return this.UiFlagList[j].Id;
			}
		}
		return this.UiFlagList[this.UiFlagList.Count - 1].Id;
	}

	// Token: 0x0600E510 RID: 58640 RVA: 0x004337E8 File Offset: 0x004319E8
	public bool IsAreaBuffActive()
	{
		SceneTeamModel instance = SceneTeamModel.Instance;
		object obj;
		if (instance == null)
		{
			obj = null;
		}
		else
		{
			EntityHandle getCurrentEntity = instance.GetCurrentEntity;
			if (getCurrentEntity == null)
			{
				obj = null;
			}
			else
			{
				WorldEntity entity = getCurrentEntity.Entity;
				obj = ((entity != null) ? entity.GetComponent<BaseBuffComponent>() : null);
			}
		}
		object obj2 = obj;
		if (obj2 != null && obj2.HasBuff((long)this.Config.BuffId, false))
		{
			return true;
		}
		WorldEntity playerEntity = FormationDataController.Instance.GetPlayerEntity(CreatureModel.Instance.GetPlayerId());
		PlayerBuffComponent playerBuffComponent = (playerEntity != null) ? playerEntity.GetComponent<PlayerBuffComponent>() : null;
		return playerBuffComponent != null && playerBuffComponent.HasBuff((long)this.Config.BuffId, false);
	}

	// Token: 0x0600E511 RID: 58641 RVA: 0x00433873 File Offset: 0x00431A73
	public void SetNewActiveAreaBuff(bool isNewActive)
	{
		this.IsNewActiveAreaBuff = isNewActive;
	}

	// Token: 0x0600E512 RID: 58642 RVA: 0x0043387C File Offset: 0x00431A7C
	public bool HighDifficultyFlagSomeActive()
	{
		for (int i = 0; i < this.UiFlagList.Count; i++)
		{
			if (this.UiFlagList[i].IsActive && this.UiFlagList[i].IsHighDifficultyChallenge())
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600E513 RID: 58643 RVA: 0x004338C8 File Offset: 0x00431AC8
	public bool HighDifficultyFlagSomeUnActive()
	{
		for (int i = 0; i < this.UiFlagList.Count; i++)
		{
			if (!this.UiFlagList[i].IsActive && this.UiFlagList[i].IsHighDifficultyChallenge())
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600E514 RID: 58644 RVA: 0x00433914 File Offset: 0x00431B14
	public bool HighDifficultyFlagSomeNewActive()
	{
		for (int i = 0; i < this.UiFlagList.Count; i++)
		{
			if (this.UiFlagList[i].IsNewUnlock && this.UiFlagList[i].IsHighDifficultyChallenge())
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600E515 RID: 58645 RVA: 0x00433960 File Offset: 0x00431B60
	public bool ExploreBoxIsAllGet()
	{
		return this.ExploreBoxReceivedCount >= this.ExploreBoxTotalCount;
	}

	// Token: 0x0600E516 RID: 58646 RVA: 0x00433974 File Offset: 0x00431B74
	public int GetHighMonsterProgress()
	{
		int num = 0;
		for (int i = 0; i < this.UiFlagList.Count; i++)
		{
			if (this.UiFlagList[i].IsActive && this.UiFlagList[i].IsHighDifficultyChallenge())
			{
				num++;
			}
		}
		return num;
	}

	// Token: 0x0600E517 RID: 58647 RVA: 0x004339C4 File Offset: 0x00431BC4
	public int GetHighMonsterProgressExcludeNew()
	{
		int num = 0;
		for (int i = 0; i < this.UiFlagList.Count; i++)
		{
			MoraleAreaFlagData moraleAreaFlagData = this.UiFlagList[i];
			if (moraleAreaFlagData.IsActive && !moraleAreaFlagData.IsNewUnlock && moraleAreaFlagData.IsHighDifficultyChallenge())
			{
				num++;
			}
		}
		return num;
	}

	// Token: 0x0600E518 RID: 58648 RVA: 0x00433A14 File Offset: 0x00431C14
	public int GetHighMonsterTotal()
	{
		int num = 0;
		for (int i = 0; i < this.UiFlagList.Count; i++)
		{
			if (this.UiFlagList[i].IsHighDifficultyChallenge())
			{
				num++;
			}
		}
		return num;
	}

	// Token: 0x0600E519 RID: 58649 RVA: 0x00433A51 File Offset: 0x00431C51
	[Conditional("DEBUG")]
	public void LogInfo()
	{
	}

	// Token: 0x040082CE RID: 33486
	public int Id;

	// Token: 0x040082CF RID: 33487
	private readonly List<MoraleAreaFlagData> FlagList = new List<MoraleAreaFlagData>();

	// Token: 0x040082D0 RID: 33488
	private readonly List<MoraleAreaFlagData> UiFlagList = new List<MoraleAreaFlagData>();

	// Token: 0x040082D1 RID: 33489
	private readonly Dictionary<int, MoraleAreaFlagData> FlagMap = new Dictionary<int, MoraleAreaFlagData>();

	// Token: 0x040082D2 RID: 33490
	private readonly Dictionary<int, MoraleAreaPlotData> PlotDataMap = new Dictionary<int, MoraleAreaPlotData>();

	// Token: 0x040082D3 RID: 33491
	public MoraleArea Config;

	// Token: 0x040082D4 RID: 33492
	public int ExploreBoxReceivedCount;

	// Token: 0x040082D5 RID: 33493
	public int ExploreBoxTotalCount;

	// Token: 0x040082D6 RID: 33494
	public bool IsNewActiveAreaBuff;
}
