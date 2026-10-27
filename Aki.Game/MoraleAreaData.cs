using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Morale;
using CSharpScript.Game.Module.Morale.Data;

// Token: 0x0200221C RID: 8732
[NullableContext(1)]
[Nullable(0)]
public class MoraleAreaData
{
	// Token: 0x0601105E RID: 69726 RVA: 0x00426620 File Offset: 0x00424820
	public static MoraleAreaData Create(MoraleArea config)
	{
		MoraleAreaData moraleAreaData = new MoraleAreaData(config);
		moraleAreaData.Init();
		return moraleAreaData;
	}

	// Token: 0x0601105F RID: 69727 RVA: 0x00426630 File Offset: 0x00424830
	private MoraleAreaData(MoraleArea config)
	{
		this.Config = config;
		this.Id = config.Id;
		this.ExploreBoxTotalCount = config.ExploreBoxLength;
	}

	// Token: 0x06011060 RID: 69728 RVA: 0x00426690 File Offset: 0x00424890
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

	// Token: 0x06011061 RID: 69729 RVA: 0x00426788 File Offset: 0x00424988
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

	// Token: 0x06011062 RID: 69730 RVA: 0x004267A8 File Offset: 0x004249A8
	public IReadOnlyList<MoraleAreaFlagData> GetFlagList()
	{
		return this.FlagList;
	}

	// Token: 0x06011063 RID: 69731 RVA: 0x004267B0 File Offset: 0x004249B0
	public IReadOnlyList<int> GetAllPlotIdList()
	{
		return this.Config.GetPlotIdListArray();
	}

	// Token: 0x06011064 RID: 69732 RVA: 0x004267BD File Offset: 0x004249BD
	[NullableContext(2)]
	public MoraleAreaPlotData GetPlotData(int itemId)
	{
		return this.PlotDataMap.GetValueOrDefault(itemId);
	}

	// Token: 0x06011065 RID: 69733 RVA: 0x004267CC File Offset: 0x004249CC
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

	// Token: 0x06011066 RID: 69734 RVA: 0x00426809 File Offset: 0x00424A09
	public int GetTotalFlagNum()
	{
		return this.FlagList.Count;
	}

	// Token: 0x06011067 RID: 69735 RVA: 0x00426816 File Offset: 0x00424A16
	public bool IsAllFlagActive()
	{
		return this.GetActiveFlagNum() == this.GetTotalFlagNum();
	}

	// Token: 0x06011068 RID: 69736 RVA: 0x00426826 File Offset: 0x00424A26
	public IReadOnlyList<MoraleAreaFlagData> GetUiFlagList()
	{
		return this.UiFlagList;
	}

	// Token: 0x06011069 RID: 69737 RVA: 0x00426830 File Offset: 0x00424A30
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

	// Token: 0x0601106A RID: 69738 RVA: 0x0042686D File Offset: 0x00424A6D
	public int GetUiTotalFlagNum()
	{
		return this.UiFlagList.Count;
	}

	// Token: 0x0601106B RID: 69739 RVA: 0x0042687C File Offset: 0x00424A7C
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

	// Token: 0x0601106C RID: 69740 RVA: 0x004268B8 File Offset: 0x00424AB8
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

	// Token: 0x0601106D RID: 69741 RVA: 0x0042690C File Offset: 0x00424B0C
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

	// Token: 0x0601106E RID: 69742 RVA: 0x0042694C File Offset: 0x00424B4C
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

	// Token: 0x0601106F RID: 69743 RVA: 0x00426988 File Offset: 0x00424B88
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

	// Token: 0x06011070 RID: 69744 RVA: 0x004269CC File Offset: 0x00424BCC
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

	// Token: 0x06011071 RID: 69745 RVA: 0x00426A3C File Offset: 0x00424C3C
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

	// Token: 0x06011072 RID: 69746 RVA: 0x00426AA3 File Offset: 0x00424CA3
	public void UpdateExploreBoxReceived(int receivedCount)
	{
		this.ExploreBoxReceivedCount = receivedCount;
	}

	// Token: 0x06011073 RID: 69747 RVA: 0x00426AAC File Offset: 0x00424CAC
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

	// Token: 0x06011074 RID: 69748 RVA: 0x00426AF0 File Offset: 0x00424CF0
	public int GetAllFlagBoxReceivedCount()
	{
		int num = 0;
		for (int i = 0; i < this.UiFlagList.Count; i++)
		{
			num += this.UiFlagList[i].BoxReceivedCount;
		}
		return num;
	}

	// Token: 0x06011075 RID: 69749 RVA: 0x00426B2C File Offset: 0x00424D2C
	public int GetAllFlagBoxTotalCount()
	{
		int num = 0;
		for (int i = 0; i < this.UiFlagList.Count; i++)
		{
			num += this.UiFlagList[i].BoxTotalCount;
		}
		return num;
	}

	// Token: 0x06011076 RID: 69750 RVA: 0x00426B66 File Offset: 0x00424D66
	public int GetAllBoxReceivedCount()
	{
		return this.GetAllFlagBoxReceivedCount() + this.ExploreBoxReceivedCount;
	}

	// Token: 0x06011077 RID: 69751 RVA: 0x00426B75 File Offset: 0x00424D75
	public int GetAllBoxTotalCount()
	{
		return this.GetAllFlagBoxTotalCount() + this.ExploreBoxTotalCount;
	}

	// Token: 0x06011078 RID: 69752 RVA: 0x00426B84 File Offset: 0x00424D84
	public bool IsPlayerInArea()
	{
		MoraleModel instance = MoraleModel.Instance;
		int num = (instance != null) ? instance.PlayerMoraleAreaId : 0;
		return this.Id == num;
	}

	// Token: 0x06011079 RID: 69753 RVA: 0x00426BAC File Offset: 0x00424DAC
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

	// Token: 0x0601107A RID: 69754 RVA: 0x00426C58 File Offset: 0x00424E58
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

	// Token: 0x0601107B RID: 69755 RVA: 0x00426CE3 File Offset: 0x00424EE3
	public void SetNewActiveAreaBuff(bool isNewActive)
	{
		this.IsNewActiveAreaBuff = isNewActive;
	}

	// Token: 0x0601107C RID: 69756 RVA: 0x00426CEC File Offset: 0x00424EEC
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

	// Token: 0x0601107D RID: 69757 RVA: 0x00426D38 File Offset: 0x00424F38
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

	// Token: 0x0601107E RID: 69758 RVA: 0x00426D84 File Offset: 0x00424F84
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

	// Token: 0x0601107F RID: 69759 RVA: 0x00426DD0 File Offset: 0x00424FD0
	public bool ExploreBoxIsAllGet()
	{
		return this.ExploreBoxReceivedCount >= this.ExploreBoxTotalCount;
	}

	// Token: 0x06011080 RID: 69760 RVA: 0x00426DE4 File Offset: 0x00424FE4
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

	// Token: 0x06011081 RID: 69761 RVA: 0x00426E34 File Offset: 0x00425034
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

	// Token: 0x06011082 RID: 69762 RVA: 0x00426E84 File Offset: 0x00425084
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

	// Token: 0x06011083 RID: 69763 RVA: 0x00426EC1 File Offset: 0x004250C1
	[Conditional("DEBUG")]
	public void LogInfo()
	{
	}

	// Token: 0x04008190 RID: 33168
	public int Id;

	// Token: 0x04008191 RID: 33169
	private readonly List<MoraleAreaFlagData> FlagList = new List<MoraleAreaFlagData>();

	// Token: 0x04008192 RID: 33170
	private readonly List<MoraleAreaFlagData> UiFlagList = new List<MoraleAreaFlagData>();

	// Token: 0x04008193 RID: 33171
	private readonly Dictionary<int, MoraleAreaFlagData> FlagMap = new Dictionary<int, MoraleAreaFlagData>();

	// Token: 0x04008194 RID: 33172
	private readonly Dictionary<int, MoraleAreaPlotData> PlotDataMap = new Dictionary<int, MoraleAreaPlotData>();

	// Token: 0x04008195 RID: 33173
	public MoraleArea Config;

	// Token: 0x04008196 RID: 33174
	public int ExploreBoxReceivedCount;

	// Token: 0x04008197 RID: 33175
	public int ExploreBoxTotalCount;

	// Token: 0x04008198 RID: 33176
	public bool IsNewActiveAreaBuff;
}
