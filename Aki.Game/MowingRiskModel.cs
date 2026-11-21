using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Module.InstanceDungeon;
using Cysharp.Threading.Tasks;
using Google.Protobuf.Collections;

// Token: 0x02000826 RID: 2086
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class MowingRiskModel : ModelBase
{
	// Token: 0x17000BE5 RID: 3045
	// (get) Token: 0x06005E84 RID: 24196 RVA: 0x001E3924 File Offset: 0x001E1B24
	// (set) Token: 0x06005E85 RID: 24197 RVA: 0x001E392C File Offset: 0x001E1B2C
	private MowingRiskConfigContext ConfigContext { get; set; }

	// Token: 0x17000BE6 RID: 3046
	// (get) Token: 0x06005E86 RID: 24198 RVA: 0x001E3935 File Offset: 0x001E1B35
	// (set) Token: 0x06005E87 RID: 24199 RVA: 0x001E393D File Offset: 0x001E1B3D
	private MowingRiskProtocolContext ProtocolContext { get; set; }

	// Token: 0x17000BE7 RID: 3047
	// (get) Token: 0x06005E88 RID: 24200 RVA: 0x001E3946 File Offset: 0x001E1B46
	// (set) Token: 0x06005E89 RID: 24201 RVA: 0x001E394E File Offset: 0x001E1B4E
	private MowingRiskUiContext UiContext { get; set; }

	// Token: 0x17000BE8 RID: 3048
	// (get) Token: 0x06005E8A RID: 24202 RVA: 0x001E3957 File Offset: 0x001E1B57
	// (set) Token: 0x06005E8B RID: 24203 RVA: 0x001E395F File Offset: 0x001E1B5F
	private bool IsContextInit { get; set; }

	// Token: 0x06005E8C RID: 24204 RVA: 0x001E3968 File Offset: 0x001E1B68
	public void InitContext()
	{
		if (this.IsContextInit)
		{
			return;
		}
		this.IsContextInit = true;
		this.ConfigContext = new MowingRiskConfigContext();
		this.ProtocolContext = new MowingRiskProtocolContext();
		this.UiContext = new MowingRiskUiContext(this);
	}

	// Token: 0x06005E8D RID: 24205 RVA: 0x001E399C File Offset: 0x001E1B9C
	protected override bool OnClear()
	{
		MowingRiskConfigContext configContext = this.ConfigContext;
		if (configContext != null)
		{
			configContext.Dispose();
		}
		MowingRiskProtocolContext protocolContext = this.ProtocolContext;
		if (protocolContext != null)
		{
			protocolContext.Dispose();
		}
		MowingRiskUiContext uiContext = this.UiContext;
		if (uiContext != null)
		{
			uiContext.Dispose();
		}
		return true;
	}

	// Token: 0x06005E8E RID: 24206 RVA: 0x001E39D2 File Offset: 0x001E1BD2
	public void SyncProtocolRiskHarvestEndNotify(RiskHarvestEndNotify message)
	{
		MowingRiskProtocolContext protocolContext = this.ProtocolContext;
		if (protocolContext == null)
		{
			return;
		}
		protocolContext.ParseRiskHarvestEndNotify(message);
	}

	// Token: 0x06005E8F RID: 24207 RVA: 0x001E39E5 File Offset: 0x001E1BE5
	public void SyncProtocolRiskHarvestInstUpdateNotify(RiskHarvestInstUpdateNotify message)
	{
		MowingRiskProtocolContext protocolContext = this.ProtocolContext;
		if (protocolContext == null)
		{
			return;
		}
		protocolContext.ParseRiskHarvestInstUpdateNotify(message);
	}

	// Token: 0x06005E90 RID: 24208 RVA: 0x001E39F8 File Offset: 0x001E1BF8
	public void SyncProtocolRiskHarvestArtifactNotify(RiskHarvestArtifactNotify message)
	{
		MowingRiskProtocolContext protocolContext = this.ProtocolContext;
		if (protocolContext == null)
		{
			return;
		}
		protocolContext.ParseRiskHarvestArtifactNotify(message);
	}

	// Token: 0x06005E91 RID: 24209 RVA: 0x001E3A0B File Offset: 0x001E1C0B
	public void SyncProtocolRiskHarvestBuffUpdateNotify(RiskHarvestBuffUpdateNotify message)
	{
		MowingRiskProtocolContext protocolContext = this.ProtocolContext;
		if (protocolContext != null)
		{
			protocolContext.ParseRiskHarvestBuffUpdateNotify(message);
		}
		MowingRiskUiContext uiContext = this.UiContext;
		if (uiContext == null)
		{
			return;
		}
		uiContext.SyncNewBuff(message.AddBuffGroups);
	}

	// Token: 0x06005E92 RID: 24210 RVA: 0x001E3A35 File Offset: 0x001E1C35
	public void SyncProtocolRiskHarvestBuffUnlockNotify(RiskHarvestBuffUnlockNotify message)
	{
		MowingRiskProtocolContext protocolContext = this.ProtocolContext;
		if (protocolContext == null)
		{
			return;
		}
		protocolContext.ParseRiskHarvestBuffUnlockNotify(message);
	}

	// Token: 0x06005E93 RID: 24211 RVA: 0x001E3A48 File Offset: 0x001E1C48
	public void SyncProtocolRiskHarvestActivityUpdateNotify(RiskHarvestActivityUpdateNotify message)
	{
		MowingRiskProtocolContext protocolContext = this.ProtocolContext;
		if (protocolContext == null)
		{
			return;
		}
		protocolContext.ParseRiskHarvestActivityUpdateNotify(message);
	}

	// Token: 0x06005E94 RID: 24212 RVA: 0x001E3A5C File Offset: 0x001E1C5C
	public void ResetBuffViewCache()
	{
		this.CurrentBuffViewType = EMowingBuffTabViewType.Overview;
		this.CurrentChosenOverviewBuffId = null;
		this.CurrentChosenProgressIndex = null;
	}

	// Token: 0x06005E95 RID: 24213 RVA: 0x001E3A8E File Offset: 0x001E1C8E
	public void ResetCacheInBattle()
	{
		this.ProtocolContext.ResetCacheInBattle();
		this.UiContext.ResetCacheInBattle();
	}

	// Token: 0x06005E96 RID: 24214 RVA: 0x001E3AA6 File Offset: 0x001E1CA6
	public EMowingBuffType? GetBuffTypeByBuffId(int id)
	{
		return this.ConfigContext.GetBuffTypeById(id);
	}

	// Token: 0x06005E97 RID: 24215 RVA: 0x001E3AB4 File Offset: 0x001E1CB4
	public RiskHarvestInst GetRiskHarvestInstConfigByInstanceId(int instanceId)
	{
		return ConfigRiskHarvestInstById.GetConfig(this.ConfigContext.GetIdByInstanceId(instanceId).Value, true).Value;
	}

	// Token: 0x06005E98 RID: 24216 RVA: 0x001E3AE4 File Offset: 0x001E1CE4
	public RiskHarvestDifficulty GetDifficultyConfigByInstanceId(int instanceId)
	{
		return ConfigRiskHarvestDifficultyById.GetConfig(ConfigRiskHarvestInstById.GetConfig(this.ConfigContext.GetIdByInstanceId(instanceId).Value, true).Value.Difficulty, true).Value;
	}

	// Token: 0x06005E99 RID: 24217 RVA: 0x001E3B2C File Offset: 0x001E1D2C
	public int GetMonsterRatioByInstanceId(int instanceId)
	{
		return this.GetDifficultyConfigByInstanceId(instanceId).MonsterRatio;
	}

	// Token: 0x06005E9A RID: 24218 RVA: 0x001E3B48 File Offset: 0x001E1D48
	public int GetRecordScoreById(int id)
	{
		return this.ProtocolContext.GetScoreById(id);
	}

	// Token: 0x06005E9B RID: 24219 RVA: 0x001E3B58 File Offset: 0x001E1D58
	public int GetMaxScoreByInstanceId(int instanceId)
	{
		int value = this.ConfigContext.GetIdByInstanceId(instanceId).Value;
		return this.GetMaxScoreById(value);
	}

	// Token: 0x06005E9C RID: 24220 RVA: 0x001E3B84 File Offset: 0x001E1D84
	public int GetMaxScoreById(int id)
	{
		RiskHarvestInst? config = ConfigRiskHarvestInstById.GetConfig(id, true);
		if (config != null)
		{
			return config.Value.MaxScore;
		}
		return 0;
	}

	// Token: 0x06005E9D RID: 24221 RVA: 0x001E3BB3 File Offset: 0x001E1DB3
	public float GetProgressOverallPercentage(int artifactId, int count)
	{
		return this.ConfigContext.GetProgressOverallPercentage(artifactId, count);
	}

	// Token: 0x06005E9E RID: 24222 RVA: 0x001E3BC4 File Offset: 0x001E1DC4
	public IMowingBuffIntroduceData BuildBuffIntroduceDataInOverviewById(int id)
	{
		MowingRiskConfigContext configContext = this.ConfigContext;
		bool flag = this.ProtocolContext.IsBuffUnlocked(id);
		int? buffCountInBattleById = this.ProtocolContext.GetBuffCountInBattleById(id);
		MowingBuffIntroduceData mowingBuffIntroduceData = new MowingBuffIntroduceData();
		mowingBuffIntroduceData.BackgroundPath = configContext.GetBuffIntroduceBackgroundPath(id);
		mowingBuffIntroduceData.LevelTextId = ((flag && buffCountInBattleById != null) ? "RiskHarvest_LV" : null);
		MowingBuffIntroduceData mowingBuffIntroduceData2 = mowingBuffIntroduceData;
		object levelTextArgs;
		if (!flag || buffCountInBattleById == null)
		{
			levelTextArgs = null;
		}
		else
		{
			(levelTextArgs = new string[1])[0] = buffCountInBattleById.Value.ToString();
		}
		mowingBuffIntroduceData2.LevelTextArgs = levelTextArgs;
		mowingBuffIntroduceData.NameTextId = (flag ? configContext.GetBuffNameTextIdById(id) : "RiskHarvest_TitleUnlock");
		mowingBuffIntroduceData.TipsTextId = (flag ? configContext.GetBuffDescriptionTextIdById(id) : "riskharvest_BuffunlockDesc");
		mowingBuffIntroduceData.TipsArgs = (flag ? configContext.GetBuffDescriptionArgsById(id) : new string[0]);
		mowingBuffIntroduceData.IconPath = (flag ? configContext.GetBuffIconPathById(id) : null);
		mowingBuffIntroduceData.HexColor = configContext.GetBuffHexColorById(id).ToString();
		mowingBuffIntroduceData.IsUnlock = flag;
		return mowingBuffIntroduceData;
	}

	// Token: 0x06005E9F RID: 24223 RVA: 0x001E3CCC File Offset: 0x001E1ECC
	public IMowingBuffIntroduceData BuildBuffIntroduceDataInProgressById(int id)
	{
		MowingRiskConfigContext configContext = this.ConfigContext;
		return new MowingBuffIntroduceData
		{
			BackgroundPath = configContext.GetBuffIntroduceBackgroundPath(id),
			LevelTextId = null,
			LevelTextArgs = null,
			NameTextId = configContext.GetBuffNameTextIdById(id),
			TipsTextId = configContext.GetBuffDescriptionTextIdById(id),
			TipsArgs = configContext.GetBuffDescriptionArgsById(id),
			IconPath = configContext.GetBuffIconPathById(id),
			HexColor = configContext.GetBuffHexColorById(id).ToString(),
			IsUnlock = this.ProtocolContext.IsBuffUnlocked(id)
		};
	}

	// Token: 0x06005EA0 RID: 24224 RVA: 0x001E3D64 File Offset: 0x001E1F64
	public IMowingBuffGridItemData BuildBuffItemDataById(int id)
	{
		MowingRiskConfigContext configContext = this.ConfigContext;
		bool flag = this.ProtocolContext.IsBuffUnlocked(id);
		MowingBuffGridItemData mowingBuffGridItemData = new MowingBuffGridItemData();
		mowingBuffGridItemData.BuffId = id;
		mowingBuffGridItemData.QualityPath = configContext.GetBuffQualityPathById(id);
		mowingBuffGridItemData.IconPath = (flag ? configContext.GetBuffIconPathById(id) : null);
		mowingBuffGridItemData.NameTextId = (flag ? configContext.GetBuffNameTextIdById(id) : "RiskHarvest_TitleUnlock");
		mowingBuffGridItemData.IsShowBackground = true;
		int? currentChosenOverviewBuffId = this.CurrentChosenOverviewBuffId;
		mowingBuffGridItemData.IsChosen = (id == currentChosenOverviewBuffId.GetValueOrDefault() & currentChosenOverviewBuffId != null);
		mowingBuffGridItemData.IsUnlock = flag;
		mowingBuffGridItemData.LevelContent = this.GetBuffLevelContentById(id);
		return mowingBuffGridItemData;
	}

	// Token: 0x06005EA1 RID: 24225 RVA: 0x001E3E04 File Offset: 0x001E2004
	public IMowingBuffUnitData[] BuildSuperBuffUnitDataListById(int id)
	{
		int artifactBasicBuffTotalCount = this.ProtocolContext.ArtifactBasicBuffTotalCount;
		MowingRiskConfigContext configContext = this.ConfigContext;
		RiskHarvestArtifact artifactConfig = configContext.GetArtifactConfig(id);
		List<IMowingBuffUnitData> list = new List<IMowingBuffUnitData>();
		for (int i = 0; i < artifactConfig.BuffGroupLength; i++)
		{
			int num = artifactConfig.BuffGroup(i);
			int buffThresholdByArtifactIdAndIndex = configContext.GetBuffThresholdByArtifactIdAndIndex(id, i);
			MowingBuffUnitData mowingBuffUnitData = new MowingBuffUnitData();
			mowingBuffUnitData.Index = i;
			mowingBuffUnitData.BuffId = num;
			int num2 = i;
			int? currentChosenProgressIndex = this.CurrentChosenProgressIndex;
			mowingBuffUnitData.IsChosen = (num2 == currentChosenProgressIndex.GetValueOrDefault() & currentChosenProgressIndex != null);
			mowingBuffUnitData.IsActive = (artifactBasicBuffTotalCount >= buffThresholdByArtifactIdAndIndex);
			mowingBuffUnitData.IconPath = configContext.GetBuffIconPathById(i);
			mowingBuffUnitData.NameTextId = configContext.GetBuffNameTextIdById(num);
			mowingBuffUnitData.ThresholdCount = buffThresholdByArtifactIdAndIndex;
			MowingBuffUnitData item = mowingBuffUnitData;
			list.Add(item);
		}
		return list.ToArray();
	}

	// Token: 0x06005EA2 RID: 24226 RVA: 0x001E3EDC File Offset: 0x001E20DC
	private IMowingBuffGridItemData[] BuildBuffItemListData(IEnumerable<RiskHarvestBuffGroup> configList)
	{
		List<IMowingBuffGridItemData> list = new List<IMowingBuffGridItemData>();
		foreach (RiskHarvestBuffGroup riskHarvestBuffGroup in configList)
		{
			list.Add(this.BuildBuffItemDataById(riskHarvestBuffGroup.Id));
		}
		return list.ToArray();
	}

	// Token: 0x06005EA3 RID: 24227 RVA: 0x001E3F3C File Offset: 0x001E213C
	public IMowingBuffOverviewData BuildOverviewViewData()
	{
		if (this.CurrentChosenOverviewBuffId == null)
		{
			return null;
		}
		List<IMowingBuffGridGroupData> list = new List<IMowingBuffGridGroupData>();
		bool showUnlockText = this.CurrentBuffViewUsage == EMowingBuffViewUsage.BeforeBattle;
		RiskHarvestBuffGroup[] superBuffConfigsAfterSort = this.GetSuperBuffConfigsAfterSort();
		if (superBuffConfigsAfterSort.Length != 0)
		{
			list.Add(new MowingBuffGridGroupData
			{
				GroupNameTextId = "riskharvest_superbuff",
				BuffItemList = this.BuildBuffItemListData(superBuffConfigsAfterSort),
				ShowUnlockText = showUnlockText
			});
		}
		RiskHarvestBuffGroup[] basicBuffConfigsAfterSort = this.GetBasicBuffConfigsAfterSort();
		if (basicBuffConfigsAfterSort.Length != 0)
		{
			list.Add(new MowingBuffGridGroupData
			{
				GroupNameTextId = "riskharvest_normalbuff",
				BuffItemList = this.BuildBuffItemListData(basicBuffConfigsAfterSort),
				ShowUnlockText = showUnlockText
			});
		}
		return new MowingBuffOverviewData
		{
			IntroduceData = this.BuildBuffIntroduceDataInOverviewById(this.CurrentChosenOverviewBuffId.Value),
			BuffGroupData = list.ToArray()
		};
	}

	// Token: 0x06005EA4 RID: 24228 RVA: 0x001E4004 File Offset: 0x001E2204
	public IMowingBuffProgressData BuildProgressViewData()
	{
		MowingRiskProtocolContext protocolContext = this.ProtocolContext;
		MowingRiskConfigContext configContext = this.ConfigContext;
		int artifactId = protocolContext.ArtifactId;
		int artifactBasicBuffTotalCount = protocolContext.ArtifactBasicBuffTotalCount;
		int buffMaxCountByArtifactId = configContext.GetBuffMaxCountByArtifactId(artifactId);
		int buffIdByArtifactIdAndIndex = configContext.GetBuffIdByArtifactIdAndIndex(artifactId, this.CurrentChosenProgressIndex.Value);
		return new MowingBuffProgressData
		{
			ArtifactId = artifactId,
			CurBasicBuffCount = artifactBasicBuffTotalCount,
			MaxBasicBuffCount = buffMaxCountByArtifactId,
			CountTextId = "PrefabTextItem_1333511122_Text",
			CountTextArgs = new string[]
			{
				artifactBasicBuffTotalCount.ToString(),
				buffMaxCountByArtifactId.ToString()
			},
			ProgressPercentage = configContext.GetProgressOverallPercentage(artifactId, artifactBasicBuffTotalCount),
			SuperBuffList = this.BuildSuperBuffUnitDataListById(artifactId),
			IntroduceData = this.BuildBuffIntroduceDataInProgressById(buffIdByArtifactIdAndIndex)
		};
	}

	// Token: 0x06005EA5 RID: 24229 RVA: 0x001E40C8 File Offset: 0x001E22C8
	public IMowingBuffCaptionData BuildCaptionViewData()
	{
		InstanceDungeonEntranceConfig instance = InstanceDungeonEntranceConfig.Instance;
		InstanceDungeonEntrance? instanceDungeonEntrance = (instance != null) ? instance.GetConfig(8500) : null;
		return new MowingBuffCaptionData
		{
			TitleTextId = (((instanceDungeonEntrance != null) ? instanceDungeonEntrance.GetValueOrDefault().Name : null) ?? string.Empty),
			IconPath = (((instanceDungeonEntrance != null) ? instanceDungeonEntrance.GetValueOrDefault().TitleSprite : null) ?? string.Empty)
		};
	}

	// Token: 0x06005EA6 RID: 24230 RVA: 0x001E4150 File Offset: 0x001E2350
	public IMowingRiskInstanceDetailData BuildInstanceDetailDataByInstanceId(int id)
	{
		InstanceDungeonConfig instance = InstanceDungeonConfig.Instance;
		InstanceDungeon? instanceDungeon = (instance != null) ? instance.GetConfig(id) : null;
		int? idByInstanceId = this.ConfigContext.GetIdByInstanceId(id);
		MowingRiskInstanceDetailData mowingRiskInstanceDetailData = new MowingRiskInstanceDetailData();
		mowingRiskInstanceDetailData.TitleTextId = (((instanceDungeon != null) ? instanceDungeon.GetValueOrDefault().MapName : null) ?? string.Empty);
		mowingRiskInstanceDetailData.ContentTextId = (((instanceDungeon != null) ? instanceDungeon.GetValueOrDefault().DungeonDesc : null) ?? string.Empty);
		MowingRiskInstanceDetailData mowingRiskInstanceDetailData2 = mowingRiskInstanceDetailData;
		IMowingRiskInstanceDetailAttributeItemData[] attributeList = new MowingRiskInstanceDetailAttributeItemData[]
		{
			new MowingRiskInstanceDetailAttributeItemData
			{
				AttributeTextId = ((instanceDungeon != null) ? instanceDungeon.GetValueOrDefault().MonsterTips : null)
			}
		};
		mowingRiskInstanceDetailData2.AttributeList = attributeList;
		mowingRiskInstanceDetailData.LockData = ((idByInstanceId != null && this.ProtocolContext.IsInstanceUnlockedById(idByInstanceId.Value)) ? null : this.BuildInstanceLockDataByInstanceId(id));
		return mowingRiskInstanceDetailData;
	}

	// Token: 0x06005EA7 RID: 24231 RVA: 0x001E424C File Offset: 0x001E244C
	public IMowingRiskInstanceDetailLockItemData BuildInstanceDetailLockDataByInstanceId(int id)
	{
		int? idByInstanceId = this.ConfigContext.GetIdByInstanceId(id);
		if (idByInstanceId == null || !this.ProtocolContext.IsInstanceUnlockedById(idByInstanceId.Value))
		{
			return this.BuildInstanceLockDataByInstanceId(id);
		}
		return null;
	}

	// Token: 0x06005EA8 RID: 24232 RVA: 0x001E428C File Offset: 0x001E248C
	public IMowingRiskInstanceDetailLockItemData BuildInstanceLockDataByInstanceId(int id)
	{
		int? idByInstanceId = this.ConfigContext.GetIdByInstanceId(id);
		MowingRiskInstanceDetailLockItemData mowingRiskInstanceDetailLockItemData = new MowingRiskInstanceDetailLockItemData
		{
			IsUnlock = false
		};
		if (idByInstanceId == null)
		{
			return mowingRiskInstanceDetailLockItemData;
		}
		mowingRiskInstanceDetailLockItemData.LockDescriptionTextId = this.BuildInstanceSubtitleTextIdById(idByInstanceId.Value);
		mowingRiskInstanceDetailLockItemData.LockDescriptionTextArgs = this.BuildInstanceSubtitleTextArgsById(idByInstanceId.Value);
		return mowingRiskInstanceDetailLockItemData;
	}

	// Token: 0x06005EA9 RID: 24233 RVA: 0x001E42E8 File Offset: 0x001E24E8
	public IMowingRiskInstanceRecommendData BuildInstanceRecommendDataByInstanceId(int id)
	{
		InstanceDungeonConfig instance = InstanceDungeonConfig.Instance;
		int recommendLevel = (instance != null) ? instance.GetRecommendLevel(id, WorldLevelModel.Instance.CurWorldLevel) : 0;
		return new MowingRiskInstanceRecommendData
		{
			TextId = "RecommendLevel",
			TextArgs = new string[]
			{
				recommendLevel.ToString()
			},
			RecommendLevel = recommendLevel
		};
	}

	// Token: 0x06005EAA RID: 24234 RVA: 0x001E4344 File Offset: 0x001E2544
	public string BuildInstanceTotalScore()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.ProtocolContext.TotalScore);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06005EAB RID: 24235 RVA: 0x001E4374 File Offset: 0x001E2574
	public IMowingRiskInBattleBuffData BuildInBattleBuffDataById(int id)
	{
		MowingRiskConfigContext configContext = this.ConfigContext;
		return new MowingRiskInBattleBuffData
		{
			IconPath = configContext.GetBuffIconPathById(id),
			TitleTextId = configContext.GetBuffNameTextIdById(id)
		};
	}

	// Token: 0x06005EAC RID: 24236 RVA: 0x001E43A8 File Offset: 0x001E25A8
	public IMowingRiskInBattleRootData BuildInBattleRootData()
	{
		MowingRiskProtocolContext protocolContext = this.ProtocolContext;
		MowingRiskConfigContext configContext = this.ConfigContext;
		int artifactId = protocolContext.ArtifactId;
		int artifactBasicBuffTotalCount = protocolContext.ArtifactBasicBuffTotalCount;
		return new MowingRiskInBattleRootData
		{
			LevelText = configContext.GetProgressLevel(artifactId, artifactBasicBuffTotalCount).ToString(),
			ProgressPercentage = configContext.GetProgressPartialPercentage(artifactId, artifactBasicBuffTotalCount)
		};
	}

	// Token: 0x06005EAD RID: 24237 RVA: 0x001E43F8 File Offset: 0x001E25F8
	public IActivityRewardViewData BuildActivityRewardViewData()
	{
		List<IActivityRewardDataPage> list = new List<IActivityRewardDataPage>();
		IActivityRewardDataPage activityRewardDataPage = this.BuildRewardPageByType(EMowingRiskRewardType.InstanceClear);
		if (activityRewardDataPage != null)
		{
			list.Add(activityRewardDataPage);
		}
		IActivityRewardDataPage activityRewardDataPage2 = this.BuildRewardPageByType(EMowingRiskRewardType.ScoreRecord);
		if (activityRewardDataPage2 != null)
		{
			list.Add(activityRewardDataPage2);
		}
		IActivityRewardDataPage activityRewardDataPage3 = this.BuildRewardPageByType(EMowingRiskRewardType.Star);
		if (activityRewardDataPage3 != null)
		{
			list.Add(activityRewardDataPage3);
		}
		return new ActivityRewardViewData
		{
			DataPageList = new List<IActivityRewardDataPage>(list),
			Source = EActivityRewardSource.MowingRisk
		};
	}

	// Token: 0x06005EAE RID: 24238 RVA: 0x001E4460 File Offset: 0x001E2660
	public IMowingRiskNewBasicBuffTipsData BuildNewBuffTipsDataById(int id)
	{
		MowingRiskConfigContext configContext = this.ConfigContext;
		return new MowingRiskNewBasicBuffTipsData
		{
			IsGolden = configContext.IsNewBuffGoldenById(id),
			NameTextId = configContext.GetBuffNameTextIdById(id),
			NameHexColor = configContext.GetNewBuffNameHexColorById(id),
			IconPath = configContext.GetBuffIconPathById(id),
			DescriptionTextId = configContext.GetBuffDescriptionTextIdById(id),
			DescriptionArgs = configContext.GetBuffDescriptionArgsById(id),
			QualityTexPath = configContext.GetNewBuffQualityTexPathById(id),
			QualityFlowPath = configContext.GetNewBuffQualityFlowTexPathById(id)
		};
	}

	// Token: 0x06005EAF RID: 24239 RVA: 0x001E44E4 File Offset: 0x001E26E4
	[NullableContext(2)]
	public string BuildInstanceSubtitleTextIdByInstanceId(int id)
	{
		int? idByInstanceId = this.ConfigContext.GetIdByInstanceId(id);
		if (idByInstanceId == null)
		{
			return null;
		}
		return this.BuildInstanceSubtitleTextIdById(idByInstanceId.Value);
	}

	// Token: 0x06005EB0 RID: 24240 RVA: 0x001E4518 File Offset: 0x001E2718
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public string[] BuildInstanceSubtitleTextArgsByInstanceId(int id)
	{
		int? idByInstanceId = this.ConfigContext.GetIdByInstanceId(id);
		if (idByInstanceId == null)
		{
			return null;
		}
		return this.BuildInstanceSubtitleTextArgsById(idByInstanceId.Value);
	}

	// Token: 0x06005EB1 RID: 24241 RVA: 0x001E454C File Offset: 0x001E274C
	public bool CheckInstanceFinishedByInstanceId(int instanceId)
	{
		int? idByInstanceId = this.ConfigContext.GetIdByInstanceId(instanceId);
		if (idByInstanceId == null)
		{
			return false;
		}
		if (this.ProtocolContext.IsInstanceUnlockedById(idByInstanceId.Value))
		{
			int scoreById = this.ProtocolContext.GetScoreById(idByInstanceId.Value);
			int maxScoreById = this.GetMaxScoreById(idByInstanceId.Value);
			return scoreById >= maxScoreById;
		}
		return false;
	}

	// Token: 0x06005EB2 RID: 24242 RVA: 0x001E45AD File Offset: 0x001E27AD
	public bool IsSuperBuffById(int id)
	{
		return this.ConfigContext.IsSuperBuffByBuffId(id);
	}

	// Token: 0x06005EB3 RID: 24243 RVA: 0x001E45BC File Offset: 0x001E27BC
	public bool IsBuffGottenInBattleById(int id)
	{
		MowingRiskProtocolContext protocolContext = this.ProtocolContext;
		MowingRiskConfigContext configContext = this.ConfigContext;
		return protocolContext.BasicBuffInfoInBattle.ContainsKey(id) || (configContext.IsSuperBuffByBuffId(id) && this.ConfigContext.IsSuperBuffAvailable(protocolContext.ArtifactId, id, protocolContext.ArtifactBasicBuffTotalCount));
	}

	// Token: 0x06005EB4 RID: 24244 RVA: 0x001E460C File Offset: 0x001E280C
	public List<RiskHarvestBuffGroup> GetBasicBuffConfigListInBattle()
	{
		MowingRiskProtocolContext protocolContext = this.ProtocolContext;
		MowingRiskConfigContext configContext = this.ConfigContext;
		List<RiskHarvestBuffGroup> list = new List<RiskHarvestBuffGroup>();
		foreach (int id in protocolContext.BasicBuffInfoInBattle.Keys)
		{
			RiskHarvestBuffGroup? buffConfigById = configContext.GetBuffConfigById(id);
			if (buffConfigById != null)
			{
				list.Add(buffConfigById.Value);
			}
		}
		return list;
	}

	// Token: 0x06005EB5 RID: 24245 RVA: 0x001E4690 File Offset: 0x001E2890
	public List<RiskHarvestBuffGroup> GetSuperBuffConfigListInBattle()
	{
		MowingRiskProtocolContext protocolContext = this.ProtocolContext;
		MowingRiskConfigContext configContext = this.ConfigContext;
		List<RiskHarvestBuffGroup> list = new List<RiskHarvestBuffGroup>();
		RiskHarvestArtifact artifactConfig = configContext.GetArtifactConfig(protocolContext.ArtifactId);
		int artifactBasicBuffTotalCount = protocolContext.ArtifactBasicBuffTotalCount;
		for (int i = 0; i < artifactConfig.BuffGroupLength; i++)
		{
			int id = artifactConfig.BuffGroup(i);
			int num = artifactConfig.BasicBuffGroup(i);
			if (artifactBasicBuffTotalCount >= num)
			{
				RiskHarvestBuffGroup? buffConfigById = configContext.GetBuffConfigById(id);
				if (buffConfigById != null)
				{
					list.Add(buffConfigById.Value);
				}
			}
		}
		return list;
	}

	// Token: 0x06005EB6 RID: 24246 RVA: 0x001E4719 File Offset: 0x001E2919
	public IReadOnlyList<RiskHarvestBuffGroup> GetBuffConfigList()
	{
		return this.ConfigContext.GetBuffConfigListByActivityId(this.ProtocolContext.Id);
	}

	// Token: 0x06005EB7 RID: 24247 RVA: 0x001E4734 File Offset: 0x001E2934
	public List<RiskHarvestBuffGroup> GetBasicBuffConfigListBeforeBattle()
	{
		IEnumerable<RiskHarvestBuffGroup> buffConfigList = this.GetBuffConfigList();
		List<RiskHarvestBuffGroup> list = new List<RiskHarvestBuffGroup>();
		foreach (RiskHarvestBuffGroup item in buffConfigList)
		{
			if (item.BuffProgress > 0)
			{
				list.Add(item);
			}
		}
		return list;
	}

	// Token: 0x06005EB8 RID: 24248 RVA: 0x001E4794 File Offset: 0x001E2994
	public List<RiskHarvestBuffGroup> GetSuperBuffConfigListBeforeBattle()
	{
		IEnumerable<RiskHarvestBuffGroup> buffConfigList = this.GetBuffConfigList();
		List<RiskHarvestBuffGroup> list = new List<RiskHarvestBuffGroup>();
		foreach (RiskHarvestBuffGroup item in buffConfigList)
		{
			if (item.BuffProgress == 0)
			{
				list.Add(item);
			}
		}
		return list;
	}

	// Token: 0x06005EB9 RID: 24249 RVA: 0x001E47F4 File Offset: 0x001E29F4
	public bool IsBuffAvailableInActivity(RiskHarvestBuffGroup buffCfg)
	{
		return this.ProtocolContext.Id == buffCfg.ActivityId;
	}

	// Token: 0x06005EBA RID: 24250 RVA: 0x001E480C File Offset: 0x001E2A0C
	public bool IsInstanceUnlockedByInstanceId(int instanceId)
	{
		int? idByInstanceId = this.ConfigContext.GetIdByInstanceId(instanceId);
		return idByInstanceId != null && this.ProtocolContext.IsInstanceUnlockedById(idByInstanceId.Value);
	}

	// Token: 0x06005EBB RID: 24251 RVA: 0x001E4844 File Offset: 0x001E2A44
	public bool IsInstanceNewById(int id)
	{
		bool flag;
		return this.ConfigContext.IsInstanceNewCache.TryGetValue(id, out flag) && flag;
	}

	// Token: 0x06005EBC RID: 24252 RVA: 0x001E4868 File Offset: 0x001E2A68
	public void SetInstanceOldById(int id)
	{
		Dictionary<int, bool> isInstanceNewCache = this.ConfigContext.IsInstanceNewCache;
		isInstanceNewCache[id] = false;
		this.ConfigContext.IsInstanceNewCache = isInstanceNewCache;
	}

	// Token: 0x06005EBD RID: 24253 RVA: 0x001E4898 File Offset: 0x001E2A98
	public void SetCurrentInstancesOld()
	{
		Dictionary<int, RiskHarvestInstInfo> instanceInfo = this.ProtocolContext.InstanceInfo;
		Dictionary<int, bool> isInstanceNewCache = this.ConfigContext.IsInstanceNewCache;
		foreach (int num in instanceInfo.Keys)
		{
			if (this.ProtocolContext.IsInstancePassUnlockTimeById(num))
			{
				isInstanceNewCache[num] = false;
			}
		}
		this.ConfigContext.IsInstanceNewCache = isInstanceNewCache;
	}

	// Token: 0x06005EBE RID: 24254 RVA: 0x001E491C File Offset: 0x001E2B1C
	public void RecordBuffId(int buffId)
	{
		this.ProtocolContext.RecordBuffId(buffId);
	}

	// Token: 0x06005EBF RID: 24255 RVA: 0x001E492A File Offset: 0x001E2B2A
	public HashSet<int> GetRecordBuffIdSet()
	{
		return this.ProtocolContext.GetRecordBuffIdSet();
	}

	// Token: 0x06005EC0 RID: 24256 RVA: 0x001E4937 File Offset: 0x001E2B37
	public bool HasBuffIdRecord(int buffId)
	{
		return this.GetRecordBuffIdSet().Contains(buffId);
	}

	// Token: 0x06005EC1 RID: 24257 RVA: 0x001E4945 File Offset: 0x001E2B45
	public void RecordProgressPanelBasicBuffCount(int superBuffCount)
	{
		this.ProtocolContext.RecordProgressPanelBasicBuffCount(superBuffCount);
	}

	// Token: 0x06005EC2 RID: 24258 RVA: 0x001E4953 File Offset: 0x001E2B53
	public int GetProgressPanelBasicBuffCountRecord()
	{
		return this.ProtocolContext.GetProgressPanelBasicBuffCountRecord();
	}

	// Token: 0x06005EC3 RID: 24259 RVA: 0x001E4960 File Offset: 0x001E2B60
	private IActivityRewardDataPage BuildRewardPageByType(EMowingRiskRewardType type)
	{
		IActivityRewardData[] array = this.BuildRewardDataListByType(type);
		if (array == null || array.Length == 0)
		{
			return null;
		}
		return new ActivityRewardDataPage
		{
			TabName = this.GetRewardTabNameByType(type),
			TabTips = ((type == EMowingRiskRewardType.ScoreRecord) ? this.GetRewardTabTipsByType() : null),
			DataList = new List<IActivityRewardData>(array)
		};
	}

	// Token: 0x06005EC4 RID: 24260 RVA: 0x001E49AF File Offset: 0x001E2BAF
	private IActivityRewardData[] BuildRewardDataListByType(EMowingRiskRewardType type)
	{
		switch (type)
		{
		case EMowingRiskRewardType.InstanceClear:
			return this.BuildRewardDataListOfInstanceClear();
		case EMowingRiskRewardType.ScoreRecord:
			return this.BuildRewardDataListOfScoreRecord();
		case EMowingRiskRewardType.Star:
			return this.BuildRewardDataListOfStar();
		default:
			return new IActivityRewardData[0];
		}
	}

	// Token: 0x06005EC5 RID: 24261 RVA: 0x001E49E0 File Offset: 0x001E2BE0
	private IActivityRewardData[] BuildRewardDataListOfInstanceClear()
	{
		List<IActivityRewardData> list = new List<IActivityRewardData>();
		using (IEnumerator<RiskHarvestInst> enumerator = this.ConfigContext.GetRiskHarvestInstByActivityId(this.ProtocolContext.Id).GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				RiskHarvestInst instCfg = enumerator.Current;
				EActivityRewardState rewardStateByRiskHarvestInst = this.GetRewardStateByRiskHarvestInst(instCfg);
				ActivityRewardData activityRewardData = new ActivityRewardData();
				activityRewardData.NameText = string.Empty;
				activityRewardData.NameTextId = instCfg.Desc;
				CSharpScript.Game.Module.Reward.RewardConfig instance = CSharpScript.Game.Module.Reward.RewardConfig.Instance;
				activityRewardData.RewardList = ((instance != null) ? instance.GetDropPackagePreviewItemList(instCfg.Reward).ToArray() : null);
				activityRewardData.RewardState = rewardStateByRiskHarvestInst;
				activityRewardData.RewardButtonText = this.GetPreviewButtonTextByState(rewardStateByRiskHarvestInst);
				activityRewardData.RewardButtonRedDot = new bool?(rewardStateByRiskHarvestInst == EActivityRewardState.Enable);
				activityRewardData.ClickFunction = delegate()
				{
					ActivityMowingRiskController.Instance.RequestRiskHarvestInstRewardRequest(instCfg.Id).ContinueWith(new Action(this.HandleRewardResponseFulfill));
				};
				ActivityRewardData item = activityRewardData;
				list.Add(item);
			}
		}
		return list.ToArray();
	}

	// Token: 0x06005EC6 RID: 24262 RVA: 0x001E4AF0 File Offset: 0x001E2CF0
	private IActivityRewardData[] BuildRewardDataListOfScoreRecord()
	{
		List<IActivityRewardData> list = new List<IActivityRewardData>();
		using (IEnumerator<RiskHarvestScoreReward> enumerator = this.ConfigContext.GetRiskHarvestScoreRewardByActivityId(this.ProtocolContext.Id).GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				RiskHarvestScoreReward scoreCfg = enumerator.Current;
				EActivityRewardState rewardStateByRiskHarvestScoreReward = this.GetRewardStateByRiskHarvestScoreReward(scoreCfg);
				ActivityRewardData activityRewardData = new ActivityRewardData();
				activityRewardData.NameText = string.Empty;
				activityRewardData.NameTextId = scoreCfg.Desc;
				CSharpScript.Game.Module.Reward.RewardConfig instance = CSharpScript.Game.Module.Reward.RewardConfig.Instance;
				activityRewardData.RewardList = ((instance != null) ? instance.GetDropPackagePreviewItemList(scoreCfg.Reward).ToArray() : null);
				activityRewardData.RewardState = rewardStateByRiskHarvestScoreReward;
				activityRewardData.RewardButtonText = this.GetPreviewButtonTextByState(rewardStateByRiskHarvestScoreReward);
				activityRewardData.RewardButtonRedDot = new bool?(rewardStateByRiskHarvestScoreReward == EActivityRewardState.Enable);
				activityRewardData.ClickFunction = delegate()
				{
					ActivityMowingRiskController.Instance.RequestRiskHarvestScoreRewardRequest(scoreCfg.Id).ContinueWith(new Action(this.HandleRewardResponseFulfill));
				};
				ActivityRewardData item = activityRewardData;
				list.Add(item);
			}
		}
		return list.ToArray();
	}

	// Token: 0x06005EC7 RID: 24263 RVA: 0x001E4C00 File Offset: 0x001E2E00
	private IActivityRewardData[] BuildRewardDataListOfStar()
	{
		List<IActivityRewardData> list = new List<IActivityRewardData>();
		using (IEnumerator<RiskHarvestInst> enumerator = this.ConfigContext.GetRiskHarvestInstByActivityId(this.ProtocolContext.Id).GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				RiskHarvestInst instCfg = enumerator.Current;
				IntPair[] array = instCfg.StarRewardList();
				int num = array.Length;
				int index2;
				int index;
				Action <>9__0;
				for (index = 0; index < num; index = index2 + 1)
				{
					IntPair intPair = array[index];
					InstanceDungeonConfig instance = InstanceDungeonConfig.Instance;
					InstanceDungeon? instanceDungeon = (instance != null) ? instance.GetConfig(instCfg.InstanceID) : null;
					EActivityRewardState rewardStateByRiskHarvestStarReward = this.GetRewardStateByRiskHarvestStarReward(instCfg, index);
					ActivityRewardData activityRewardData = new ActivityRewardData();
					activityRewardData.NameText = string.Empty;
					activityRewardData.NameTextId = instCfg.StarRewardDesc;
					activityRewardData.NameTextArgs = new string[]
					{
						ConfigMultiTextLang.GetLocalTextNew((instanceDungeon != null) ? instanceDungeon.GetValueOrDefault().MapName : null, null) ?? string.Empty,
						this.GetStarRewardTargetScore(instCfg, index).ToString()
					};
					ActivityRewardData activityRewardData2 = activityRewardData;
					CSharpScript.Game.Module.Reward.RewardConfig instance2 = CSharpScript.Game.Module.Reward.RewardConfig.Instance;
					activityRewardData2.RewardList = ((instance2 != null) ? instance2.GetDropPackagePreviewItemList(intPair.Item2).ToArray() : null);
					activityRewardData.RewardState = rewardStateByRiskHarvestStarReward;
					activityRewardData.RewardButtonText = this.GetPreviewButtonTextByState(rewardStateByRiskHarvestStarReward);
					activityRewardData.RewardButtonRedDot = new bool?(rewardStateByRiskHarvestStarReward == EActivityRewardState.Enable);
					ActivityRewardData activityRewardData3 = activityRewardData;
					Action clickFunction;
					if ((clickFunction = <>9__0) == null)
					{
						clickFunction = (<>9__0 = delegate()
						{
							ActivityMowingRiskController.Instance.RequestRiskHarvestStarRewardRequest(instCfg.Id, index).ContinueWith(new Action(this.HandleRewardResponseFulfill));
						});
					}
					activityRewardData3.ClickFunction = clickFunction;
					ActivityRewardData item = activityRewardData;
					list.Add(item);
					index2 = index;
				}
			}
		}
		return list.ToArray();
	}

	// Token: 0x06005EC8 RID: 24264 RVA: 0x001E4E0C File Offset: 0x001E300C
	[NullableContext(0)]
	public ValueTuple<int, int> GetRewardCount()
	{
		int num = 0;
		int num2 = 0;
		foreach (RiskHarvestInst cfg in this.ConfigContext.GetRiskHarvestInstByActivityId(this.ProtocolContext.Id))
		{
			if (this.GetRewardStateByRiskHarvestInst(cfg) == EActivityRewardState.Claimed)
			{
				num++;
			}
			num2++;
			int num3 = cfg.StarRewardList().Length;
			for (int i = 0; i < num3; i++)
			{
				if (this.GetRewardStateByRiskHarvestStarReward(cfg, i) == EActivityRewardState.Claimed)
				{
					num++;
				}
			}
			num2 += num3;
		}
		foreach (RiskHarvestScoreReward cfg2 in this.ConfigContext.GetRiskHarvestScoreRewardByActivityId(this.ProtocolContext.Id))
		{
			if (this.GetRewardStateByRiskHarvestScoreReward(cfg2) == EActivityRewardState.Claimed)
			{
				num++;
			}
			num2++;
		}
		return new ValueTuple<int, int>(num, num2);
	}

	// Token: 0x06005EC9 RID: 24265 RVA: 0x001E4F10 File Offset: 0x001E3110
	private EActivityRewardState GetRewardStateByRiskHarvestInst(RiskHarvestInst cfg)
	{
		RiskHarvestInstInfo riskHarvestInstInfo;
		if (!this.ProtocolContext.InstanceInfo.TryGetValue(cfg.Id, out riskHarvestInstInfo))
		{
			return EActivityRewardState.Disabled;
		}
		if (!riskHarvestInstInfo.IsUnlock || riskHarvestInstInfo.Score < cfg.RewardScore)
		{
			return EActivityRewardState.Disabled;
		}
		if (riskHarvestInstInfo.Rewarded)
		{
			return EActivityRewardState.Claimed;
		}
		return EActivityRewardState.Enable;
	}

	// Token: 0x06005ECA RID: 24266 RVA: 0x001E4F60 File Offset: 0x001E3160
	private EActivityRewardState GetRewardStateByRiskHarvestStarReward(RiskHarvestInst cfg, int index)
	{
		RiskHarvestInstInfo riskHarvestInstInfo;
		if (!this.ProtocolContext.InstanceInfo.TryGetValue(cfg.Id, out riskHarvestInstInfo))
		{
			return EActivityRewardState.Disabled;
		}
		if (!riskHarvestInstInfo.IsUnlock)
		{
			return EActivityRewardState.Disabled;
		}
		RepeatedField<RiskHarvestStarRewardInfo> starRewardInfos = riskHarvestInstInfo.StarRewardInfos;
		if (starRewardInfos == null || index < 0 || index >= starRewardInfos.Count)
		{
			return EActivityRewardState.Disabled;
		}
		RiskHarvestStarRewardInfo riskHarvestStarRewardInfo = starRewardInfos[index];
		int targetScore = riskHarvestStarRewardInfo.TargetScore;
		if (riskHarvestInstInfo.Score < targetScore)
		{
			return EActivityRewardState.Disabled;
		}
		if (riskHarvestStarRewardInfo.StarRewardStates == StarRewardState.RiskHarvestRewarded)
		{
			return EActivityRewardState.Claimed;
		}
		return EActivityRewardState.Enable;
	}

	// Token: 0x06005ECB RID: 24267 RVA: 0x001E4FD4 File Offset: 0x001E31D4
	private EActivityRewardState GetRewardStateByRiskHarvestScoreReward(RiskHarvestScoreReward cfg)
	{
		MowingRiskProtocolContext protocolContext = this.ProtocolContext;
		if (protocolContext.TotalScore < cfg.Score)
		{
			return EActivityRewardState.Disabled;
		}
		if (protocolContext.HasScoreRewarded(cfg.Id))
		{
			return EActivityRewardState.Claimed;
		}
		return EActivityRewardState.Enable;
	}

	// Token: 0x06005ECC RID: 24268 RVA: 0x001E500C File Offset: 0x001E320C
	private int GetStarRewardTargetScore(RiskHarvestInst cfg, int index)
	{
		RiskHarvestInstInfo riskHarvestInstInfo;
		if (!this.ProtocolContext.InstanceInfo.TryGetValue(cfg.Id, out riskHarvestInstInfo))
		{
			return 0;
		}
		RepeatedField<RiskHarvestStarRewardInfo> starRewardInfos = riskHarvestInstInfo.StarRewardInfos;
		if (starRewardInfos == null || index < 0 || index >= starRewardInfos.Count)
		{
			return 0;
		}
		return starRewardInfos[index].TargetScore;
	}

	// Token: 0x06005ECD RID: 24269 RVA: 0x001E505C File Offset: 0x001E325C
	private string GetPreviewButtonTextByState(EActivityRewardState state)
	{
		switch (state)
		{
		case EActivityRewardState.Disabled:
			return ConfigMultiTextLang.GetLocalTextNew("TowerDefence_Getbt3", null) ?? string.Empty;
		case EActivityRewardState.Enable:
			return ConfigMultiTextLang.GetLocalTextNew("TowerDefence_Getbt1", null) ?? string.Empty;
		case EActivityRewardState.Claimed:
			return ConfigMultiTextLang.GetLocalTextNew("TowerDefence_Getbt1", null) ?? string.Empty;
		default:
			return string.Empty;
		}
	}

	// Token: 0x06005ECE RID: 24270 RVA: 0x001E50C4 File Offset: 0x001E32C4
	private string GetRewardTabNameByType(EMowingRiskRewardType type)
	{
		switch (type)
		{
		case EMowingRiskRewardType.InstanceClear:
			return TextConfig.Instance.GetTextById("BossRushLevelRewardText") ?? string.Empty;
		case EMowingRiskRewardType.ScoreRecord:
			return TextConfig.Instance.GetTextById("RiskHarvest_PointTap") ?? string.Empty;
		case EMowingRiskRewardType.Star:
			return ConfigMultiTextLang.GetLocalTextNew("RiskHarvest_StarRewardTap", null) ?? string.Empty;
		default:
			return string.Empty;
		}
	}

	// Token: 0x06005ECF RID: 24271 RVA: 0x001E5134 File Offset: 0x001E3334
	private string GetRewardTabTipsByType()
	{
		return StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("RiskHarvest_InstanceToppoint", null), new string[]
		{
			this.ProtocolContext.TotalScore.ToString()
		});
	}

	// Token: 0x06005ED0 RID: 24272 RVA: 0x001E5170 File Offset: 0x001E3370
	private string GetBuffLevelContentById(int id)
	{
		int? buffCountInBattleById = this.ProtocolContext.GetBuffCountInBattleById(id);
		if (buffCountInBattleById == null)
		{
			return null;
		}
		return StringUtils.Format(TextConfig.Instance.GetTextById("OverSeaServerLv"), new string[]
		{
			buffCountInBattleById.Value.ToString()
		});
	}

	// Token: 0x06005ED1 RID: 24273 RVA: 0x001E51C1 File Offset: 0x001E33C1
	private string BuildInstanceSubtitleTextIdById(int id)
	{
		if (this.ProtocolContext.IsInstanceUnlockedById(id))
		{
			return this.GetInstanceUnlockTextIdById(id);
		}
		return this.GetInstanceLockTextIdById(id);
	}

	// Token: 0x06005ED2 RID: 24274 RVA: 0x001E51E0 File Offset: 0x001E33E0
	public string GetInstanceUnlockTextIdById(int id)
	{
		if (!ConfigRiskHarvestInstById.GetConfig(id, true).Value.Accumulate)
		{
			return "RiskHarvest_InstanceToppoint";
		}
		return "RiskHarvest_TotleScore";
	}

	// Token: 0x06005ED3 RID: 24275 RVA: 0x001E5214 File Offset: 0x001E3414
	public string GetInstanceLockTextIdByInstanceId(int instanceId)
	{
		int? idByInstanceId = this.ConfigContext.GetIdByInstanceId(instanceId);
		if (idByInstanceId == null)
		{
			return string.Empty;
		}
		return this.GetInstanceLockTextIdById(idByInstanceId.Value);
	}

	// Token: 0x06005ED4 RID: 24276 RVA: 0x001E524A File Offset: 0x001E344A
	public string GetInstanceLockTextIdById(int id)
	{
		if (!this.ProtocolContext.IsInstancePassUnlockTimeById(id))
		{
			return "Text_ActiveToOpenTime_Text";
		}
		return "RiskHarvest_Unlock";
	}

	// Token: 0x06005ED5 RID: 24277 RVA: 0x001E5268 File Offset: 0x001E3468
	private string[] BuildInstanceSubtitleTextArgsById(int id)
	{
		if (this.ProtocolContext.IsInstanceUnlockedById(id))
		{
			return new string[]
			{
				this.ProtocolContext.GetScoreById(id).ToString()
			};
		}
		return this.GetLockTextArgsById(id);
	}

	// Token: 0x06005ED6 RID: 24278 RVA: 0x001E52A8 File Offset: 0x001E34A8
	public string[] GetLockTextArgsById(int id)
	{
		List<string> list = new List<string>();
		double instanceUnlockTimestampById = this.ProtocolContext.GetInstanceUnlockTimestampById(id);
		double serverTimeStamp = TimeUtil.Instance.GetServerTimeStamp();
		if (instanceUnlockTimestampById > serverTimeStamp)
		{
			double num = instanceUnlockTimestampById - serverTimeStamp;
			CommonDefine.ICountDown remainTimeDataFormat = TimeUtil.Instance.GetRemainTimeDataFormat(num * TimeUtil.Instance.Millisecond);
			list.Add(remainTimeDataFormat.CountDownText ?? string.Empty);
			return list.ToArray();
		}
		list.Add(this.ConfigContext.GetScoreToUnlockById(id).ToString());
		return list.ToArray();
	}

	// Token: 0x06005ED7 RID: 24279 RVA: 0x001E5334 File Offset: 0x001E3534
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public string[] GetLockTextArgsByInstanceId(int instanceId)
	{
		int? idByInstanceId = this.ConfigContext.GetIdByInstanceId(instanceId);
		if (idByInstanceId == null)
		{
			return null;
		}
		return this.GetLockTextArgsById(idByInstanceId.Value);
	}

	// Token: 0x06005ED8 RID: 24280 RVA: 0x001E5366 File Offset: 0x001E3566
	private void HandleRewardResponseFulfill()
	{
		EventSystem.Instance.Emit<IActivityRewardViewData>(EEventName.RefreshCommonActivityRewardPopUpView, this.BuildActivityRewardViewData());
	}

	// Token: 0x17000BE9 RID: 3049
	// (get) Token: 0x06005ED9 RID: 24281 RVA: 0x001E537E File Offset: 0x001E357E
	public ActivityBaseData ActivityData
	{
		get
		{
			return this.ProtocolContext;
		}
	}

	// Token: 0x17000BEA RID: 3050
	// (get) Token: 0x06005EDA RID: 24282 RVA: 0x001E5386 File Offset: 0x001E3586
	// (set) Token: 0x06005EDB RID: 24283 RVA: 0x001E5393 File Offset: 0x001E3593
	public EMowingBuffViewUsage CurrentBuffViewUsage
	{
		get
		{
			return this.UiContext.CurrentBuffViewUsage;
		}
		set
		{
			this.UiContext.CurrentBuffViewUsage = value;
		}
	}

	// Token: 0x17000BEB RID: 3051
	// (get) Token: 0x06005EDC RID: 24284 RVA: 0x001E53A1 File Offset: 0x001E35A1
	// (set) Token: 0x06005EDD RID: 24285 RVA: 0x001E53AE File Offset: 0x001E35AE
	public EMowingBuffTabViewType CurrentBuffViewType
	{
		get
		{
			return this.UiContext.CurrentBuffViewType;
		}
		set
		{
			this.UiContext.CurrentBuffViewType = value;
		}
	}

	// Token: 0x17000BEC RID: 3052
	// (get) Token: 0x06005EDE RID: 24286 RVA: 0x001E53BC File Offset: 0x001E35BC
	// (set) Token: 0x06005EDF RID: 24287 RVA: 0x001E53F2 File Offset: 0x001E35F2
	public int? CurrentChosenOverviewBuffId
	{
		get
		{
			int? num = this.UiContext.CurrentChosenOverviewBuffId;
			if (num == null)
			{
				num = this.GetDefaultChosenOverviewBuffId();
				this.UiContext.CurrentChosenOverviewBuffId = num;
			}
			return num;
		}
		set
		{
			this.UiContext.CurrentChosenOverviewBuffId = value;
		}
	}

	// Token: 0x06005EE0 RID: 24288 RVA: 0x001E5400 File Offset: 0x001E3600
	public int? GetDefaultChosenOverviewBuffId()
	{
		List<RiskHarvestBuffGroup> basicBuffConfigListBeforeBattle = this.GetBasicBuffConfigListBeforeBattle();
		if (basicBuffConfigListBeforeBattle != null && basicBuffConfigListBeforeBattle.Count > 0)
		{
			return new int?(this.FindBuffConfigsFirstId(basicBuffConfigListBeforeBattle));
		}
		RiskHarvestBuffGroup[] superBuffConfigsAfterSort = this.GetSuperBuffConfigsAfterSort();
		return new int?(this.FindBuffConfigsFirstId(superBuffConfigsAfterSort));
	}

	// Token: 0x06005EE1 RID: 24289 RVA: 0x001E5440 File Offset: 0x001E3640
	public RiskHarvestBuffGroup[] GetBasicBuffConfigsAfterSort()
	{
		List<RiskHarvestBuffGroup> list = (this.CurrentBuffViewUsage == EMowingBuffViewUsage.InBattle) ? this.GetBasicBuffConfigListInBattle() : this.GetBasicBuffConfigListBeforeBattle();
		list.Sort(new Comparison<RiskHarvestBuffGroup>(this.HandleCompareBuff));
		return list.ToArray();
	}

	// Token: 0x06005EE2 RID: 24290 RVA: 0x001E5472 File Offset: 0x001E3672
	public RiskHarvestBuffGroup[] GetSuperBuffConfigsAfterSort()
	{
		List<RiskHarvestBuffGroup> list = (this.CurrentBuffViewUsage == EMowingBuffViewUsage.InBattle) ? this.GetSuperBuffConfigListInBattle() : this.GetSuperBuffConfigListBeforeBattle();
		list.Sort(new Comparison<RiskHarvestBuffGroup>(this.HandleCompareBuff));
		return list.ToArray();
	}

	// Token: 0x06005EE3 RID: 24291 RVA: 0x001E54A4 File Offset: 0x001E36A4
	private int HandleCompareBuff(RiskHarvestBuffGroup a, RiskHarvestBuffGroup b)
	{
		if (a.BuffType == b.BuffType)
		{
			return a.Id - b.Id;
		}
		return b.BuffType - a.BuffType;
	}

	// Token: 0x06005EE4 RID: 24292 RVA: 0x001E54D8 File Offset: 0x001E36D8
	private int FindBuffConfigsFirstId(IReadOnlyList<RiskHarvestBuffGroup> configList)
	{
		if (configList.Count == 0)
		{
			return 0;
		}
		RiskHarvestBuffGroup riskHarvestBuffGroup = configList[0];
		foreach (RiskHarvestBuffGroup riskHarvestBuffGroup2 in configList)
		{
			if (riskHarvestBuffGroup2.BuffType > riskHarvestBuffGroup.BuffType)
			{
				riskHarvestBuffGroup = riskHarvestBuffGroup2;
			}
			else if (riskHarvestBuffGroup2.BuffType == riskHarvestBuffGroup.BuffType && riskHarvestBuffGroup2.Id < riskHarvestBuffGroup.Id)
			{
				riskHarvestBuffGroup = riskHarvestBuffGroup2;
			}
		}
		return riskHarvestBuffGroup.Id;
	}

	// Token: 0x17000BED RID: 3053
	// (get) Token: 0x06005EE5 RID: 24293 RVA: 0x001E5568 File Offset: 0x001E3768
	// (set) Token: 0x06005EE6 RID: 24294 RVA: 0x001E559F File Offset: 0x001E379F
	public int? CurrentChosenProgressIndex
	{
		get
		{
			int? currentChosenProgressIndex = this.UiContext.CurrentChosenProgressIndex;
			if (currentChosenProgressIndex == null)
			{
				currentChosenProgressIndex = new int?(0);
				this.UiContext.CurrentChosenProgressIndex = currentChosenProgressIndex;
			}
			return currentChosenProgressIndex;
		}
		set
		{
			this.UiContext.CurrentChosenProgressIndex = value;
		}
	}

	// Token: 0x17000BEE RID: 3054
	// (get) Token: 0x06005EE7 RID: 24295 RVA: 0x001E55AD File Offset: 0x001E37AD
	public int CurrentHelpButtonId
	{
		get
		{
			return this.ProtocolContext.GetHelpId();
		}
	}

	// Token: 0x17000BEF RID: 3055
	// (get) Token: 0x06005EE8 RID: 24296 RVA: 0x001E55BA File Offset: 0x001E37BA
	public int CurrentInstanceId
	{
		get
		{
			InstanceDungeonEntranceModel instance = InstanceDungeonEntranceModel.Instance;
			if (instance == null)
			{
				return 0;
			}
			return instance.SelectInstanceId;
		}
	}

	// Token: 0x17000BF0 RID: 3056
	// (get) Token: 0x06005EE9 RID: 24297 RVA: 0x001E55CC File Offset: 0x001E37CC
	public bool IsNewInstanceOpen
	{
		get
		{
			Dictionary<int, bool> isInstanceNewCache = this.ConfigContext.IsInstanceNewCache;
			Dictionary<double, bool> dictionary = new Dictionary<double, bool>();
			foreach (KeyValuePair<int, bool> keyValuePair in isInstanceNewCache)
			{
				int num;
				bool flag;
				keyValuePair.Deconstruct(out num, out flag);
				int id = num;
				bool flag2 = flag;
				double instanceUnlockTimestampById = this.ProtocolContext.GetInstanceUnlockTimestampById(id);
				bool flag3;
				if (!dictionary.TryGetValue(instanceUnlockTimestampById, out flag3))
				{
					flag3 = true;
				}
				bool flag4 = this.ProtocolContext.IsInstancePassUnlockTimeById(id);
				dictionary[instanceUnlockTimestampById] = (flag3 && !this.ProtocolContext.IsInstancePlayedById(id) && flag2 && flag4);
			}
			using (Dictionary<double, bool>.ValueCollection.Enumerator enumerator2 = dictionary.Values.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					if (enumerator2.Current)
					{
						return true;
					}
				}
			}
			return false;
		}
	}

	// Token: 0x17000BF1 RID: 3057
	// (get) Token: 0x06005EEA RID: 24298 RVA: 0x001E56CC File Offset: 0x001E38CC
	public bool IsPreQuestFinished
	{
		get
		{
			return this.ProtocolContext.GetPreGuideQuestFinishState();
		}
	}

	// Token: 0x17000BF2 RID: 3058
	// (get) Token: 0x06005EEB RID: 24299 RVA: 0x001E56D9 File Offset: 0x001E38D9
	public int UnFinishPreGuideQuestId
	{
		get
		{
			return this.ProtocolContext.GetUnFinishPreGuideQuestId();
		}
	}

	// Token: 0x17000BF3 RID: 3059
	// (get) Token: 0x06005EEC RID: 24300 RVA: 0x001E56E6 File Offset: 0x001E38E6
	public string InstanceSubViewResourceId
	{
		get
		{
			return "UiItem_CheckpointsMowing";
		}
	}

	// Token: 0x17000BF4 RID: 3060
	// (get) Token: 0x06005EED RID: 24301 RVA: 0x001E56F0 File Offset: 0x001E38F0
	public string ActivityTitleTextId
	{
		get
		{
			MowingRiskProtocolContext protocolContext = this.ProtocolContext;
			return ((protocolContext.LocalConfig != null) ? protocolContext.LocalConfig.GetValueOrDefault().Title : null) ?? string.Empty;
		}
	}

	// Token: 0x17000BF5 RID: 3061
	// (get) Token: 0x06005EEE RID: 24302 RVA: 0x001E572C File Offset: 0x001E392C
	public string ActivityDescriptionTextId
	{
		get
		{
			MowingRiskProtocolContext protocolContext = this.ProtocolContext;
			return ((protocolContext.LocalConfig != null) ? protocolContext.LocalConfig.GetValueOrDefault().Desc : null) ?? string.Empty;
		}
	}

	// Token: 0x17000BF6 RID: 3062
	// (get) Token: 0x06005EEF RID: 24303 RVA: 0x001E5766 File Offset: 0x001E3966
	public bool HasAnyReward
	{
		get
		{
			return this.HasAnyInstanceReward || this.HasAnyScoreReward || this.HasAnyStarReward;
		}
	}

	// Token: 0x17000BF7 RID: 3063
	// (get) Token: 0x06005EF0 RID: 24304 RVA: 0x001E5780 File Offset: 0x001E3980
	public bool HasAnyInstanceReward
	{
		get
		{
			foreach (RiskHarvestInst cfg in this.ConfigContext.GetRiskHarvestInstByActivityId(this.ProtocolContext.Id))
			{
				if (this.GetRewardStateByRiskHarvestInst(cfg) == EActivityRewardState.Enable)
				{
					return true;
				}
			}
			return false;
		}
	}

	// Token: 0x17000BF8 RID: 3064
	// (get) Token: 0x06005EF1 RID: 24305 RVA: 0x001E57E8 File Offset: 0x001E39E8
	public bool HasAnyScoreReward
	{
		get
		{
			foreach (RiskHarvestScoreReward cfg in this.ConfigContext.GetRiskHarvestScoreRewardByActivityId(this.ProtocolContext.Id))
			{
				if (this.GetRewardStateByRiskHarvestScoreReward(cfg) == EActivityRewardState.Enable)
				{
					return true;
				}
			}
			return false;
		}
	}

	// Token: 0x17000BF9 RID: 3065
	// (get) Token: 0x06005EF2 RID: 24306 RVA: 0x001E5850 File Offset: 0x001E3A50
	public bool HasAnyStarReward
	{
		get
		{
			foreach (RiskHarvestInst cfg in this.ConfigContext.GetRiskHarvestInstByActivityId(this.ProtocolContext.Id))
			{
				int num = cfg.StarRewardList().Length;
				for (int i = 0; i < num; i++)
				{
					if (this.GetRewardStateByRiskHarvestStarReward(cfg, i) == EActivityRewardState.Enable)
					{
						return true;
					}
				}
			}
			return false;
		}
	}

	// Token: 0x17000BFA RID: 3066
	// (get) Token: 0x06005EF3 RID: 24307 RVA: 0x001E58D0 File Offset: 0x001E3AD0
	public int MapMarkId
	{
		get
		{
			return 380034;
		}
	}

	// Token: 0x17000BFB RID: 3067
	// (get) Token: 0x06005EF4 RID: 24308 RVA: 0x001E58D7 File Offset: 0x001E3AD7
	public int MapMarkType
	{
		get
		{
			return 6;
		}
	}

	// Token: 0x17000BFC RID: 3068
	// (get) Token: 0x06005EF5 RID: 24309 RVA: 0x001E58DC File Offset: 0x001E3ADC
	public int? NextNewBuffId
	{
		get
		{
			if (this.UiContext.NewBuffToShowCache.Count > 0)
			{
				int value = this.UiContext.NewBuffToShowCache[0];
				this.UiContext.NewBuffToShowCache.RemoveAt(0);
				return new int?(value);
			}
			return null;
		}
	}

	// Token: 0x17000BFD RID: 3069
	// (get) Token: 0x06005EF6 RID: 24310 RVA: 0x001E592D File Offset: 0x001E3B2D
	public static MowingRiskModel Instance
	{
		get
		{
			return MowingRiskModel._Instance;
		}
	}

	// Token: 0x06005EF7 RID: 24311 RVA: 0x001E5934 File Offset: 0x001E3B34
	public static MowingRiskModel GetOrCreateInstance()
	{
		if (MowingRiskModel._Instance == null)
		{
			MowingRiskModel.CreateInstance();
		}
		return MowingRiskModel._Instance;
	}

	// Token: 0x06005EF8 RID: 24312 RVA: 0x001E5948 File Offset: 0x001E3B48
	public static bool CreateInstance()
	{
		if (MowingRiskModel._Instance != null)
		{
			return true;
		}
		MowingRiskModel._Instance = new MowingRiskModel();
		return true;
	}

	// Token: 0x06005EF9 RID: 24313 RVA: 0x001E595E File Offset: 0x001E3B5E
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06005EFA RID: 24314 RVA: 0x001E5960 File Offset: 0x001E3B60
	public static void ResetStaticDefaultValue()
	{
		MowingRiskModel._Instance = null;
	}

	// Token: 0x06005EFB RID: 24315 RVA: 0x001E5968 File Offset: 0x001E3B68
	static MowingRiskModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MowingRiskModel.CreateStaticDefaultValue), new Action(MowingRiskModel.ResetStaticDefaultValue));
	}

	// Token: 0x04003E64 RID: 15972
	[Nullable(2)]
	private static MowingRiskModel _Instance;
}
