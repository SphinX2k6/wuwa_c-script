using System;
using System.Collections.Generic;
using System.Linq;
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

// Token: 0x02001372 RID: 4978
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class MowingRiskModel : ModelBase
{
	// Token: 0x17000BC5 RID: 3013
	// (get) Token: 0x06008AE9 RID: 35561 RVA: 0x001DAAC8 File Offset: 0x001D8CC8
	// (set) Token: 0x06008AEA RID: 35562 RVA: 0x001DAAD0 File Offset: 0x001D8CD0
	private MowingRiskConfigContext ConfigContext { get; set; }

	// Token: 0x17000BC6 RID: 3014
	// (get) Token: 0x06008AEB RID: 35563 RVA: 0x001DAAD9 File Offset: 0x001D8CD9
	// (set) Token: 0x06008AEC RID: 35564 RVA: 0x001DAAE1 File Offset: 0x001D8CE1
	private MowingRiskProtocolContext ProtocolContext { get; set; }

	// Token: 0x17000BC7 RID: 3015
	// (get) Token: 0x06008AED RID: 35565 RVA: 0x001DAAEA File Offset: 0x001D8CEA
	// (set) Token: 0x06008AEE RID: 35566 RVA: 0x001DAAF2 File Offset: 0x001D8CF2
	private MowingRiskUiContext UiContext { get; set; }

	// Token: 0x17000BC8 RID: 3016
	// (get) Token: 0x06008AEF RID: 35567 RVA: 0x001DAAFB File Offset: 0x001D8CFB
	// (set) Token: 0x06008AF0 RID: 35568 RVA: 0x001DAB03 File Offset: 0x001D8D03
	private bool IsContextInit { get; set; }

	// Token: 0x06008AF1 RID: 35569 RVA: 0x001DAB0C File Offset: 0x001D8D0C
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

	// Token: 0x06008AF2 RID: 35570 RVA: 0x001DAB40 File Offset: 0x001D8D40
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

	// Token: 0x06008AF3 RID: 35571 RVA: 0x001DAB76 File Offset: 0x001D8D76
	public void SyncProtocolRiskHarvestEndNotify(RiskHarvestEndNotify message)
	{
		MowingRiskProtocolContext protocolContext = this.ProtocolContext;
		if (protocolContext == null)
		{
			return;
		}
		protocolContext.ParseRiskHarvestEndNotify(message);
	}

	// Token: 0x06008AF4 RID: 35572 RVA: 0x001DAB89 File Offset: 0x001D8D89
	public void SyncProtocolRiskHarvestInstUpdateNotify(RiskHarvestInstUpdateNotify message)
	{
		MowingRiskProtocolContext protocolContext = this.ProtocolContext;
		if (protocolContext == null)
		{
			return;
		}
		protocolContext.ParseRiskHarvestInstUpdateNotify(message);
	}

	// Token: 0x06008AF5 RID: 35573 RVA: 0x001DAB9C File Offset: 0x001D8D9C
	public void SyncProtocolRiskHarvestArtifactNotify(RiskHarvestArtifactNotify message)
	{
		MowingRiskProtocolContext protocolContext = this.ProtocolContext;
		if (protocolContext == null)
		{
			return;
		}
		protocolContext.ParseRiskHarvestArtifactNotify(message);
	}

	// Token: 0x06008AF6 RID: 35574 RVA: 0x001DABAF File Offset: 0x001D8DAF
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
		uiContext.SyncNewBuff(message.AddBuffGroups.ToList<int>());
	}

	// Token: 0x06008AF7 RID: 35575 RVA: 0x001DABDE File Offset: 0x001D8DDE
	public void SyncProtocolRiskHarvestBuffUnlockNotify(RiskHarvestBuffUnlockNotify message)
	{
		MowingRiskProtocolContext protocolContext = this.ProtocolContext;
		if (protocolContext == null)
		{
			return;
		}
		protocolContext.ParseRiskHarvestBuffUnlockNotify(message);
	}

	// Token: 0x06008AF8 RID: 35576 RVA: 0x001DABF1 File Offset: 0x001D8DF1
	public void SyncProtocolRiskHarvestActivityUpdateNotify(RiskHarvestActivityUpdateNotify message)
	{
		MowingRiskProtocolContext protocolContext = this.ProtocolContext;
		if (protocolContext == null)
		{
			return;
		}
		protocolContext.ParseRiskHarvestActivityUpdateNotify(message);
	}

	// Token: 0x06008AF9 RID: 35577 RVA: 0x001DAC04 File Offset: 0x001D8E04
	public void ResetBuffViewCache()
	{
		this.CurrentBuffViewType = EMowingBuffTabViewType.Overview;
		this.CurrentChosenOverviewBuffId = null;
		this.CurrentChosenProgressIndex = null;
	}

	// Token: 0x06008AFA RID: 35578 RVA: 0x001DAC36 File Offset: 0x001D8E36
	public void ResetCacheInBattle()
	{
		this.ProtocolContext.ResetCacheInBattle();
		this.UiContext.ResetCacheInBattle();
	}

	// Token: 0x06008AFB RID: 35579 RVA: 0x001DAC4E File Offset: 0x001D8E4E
	public EMowingBuffType? GetBuffTypeByBuffId(int id)
	{
		return this.ConfigContext.GetBuffTypeById(id);
	}

	// Token: 0x06008AFC RID: 35580 RVA: 0x001DAC5C File Offset: 0x001D8E5C
	public RiskHarvestInst GetRiskHarvestInstConfigByInstanceId(int instanceId)
	{
		return ConfigRiskHarvestInstById.GetConfig(this.ConfigContext.GetIdByInstanceId(instanceId).Value, true).Value;
	}

	// Token: 0x06008AFD RID: 35581 RVA: 0x001DAC8C File Offset: 0x001D8E8C
	public RiskHarvestDifficulty GetDifficultyConfigByInstanceId(int instanceId)
	{
		return ConfigRiskHarvestDifficultyById.GetConfig(ConfigRiskHarvestInstById.GetConfig(this.ConfigContext.GetIdByInstanceId(instanceId).Value, true).Value.Difficulty, true).Value;
	}

	// Token: 0x06008AFE RID: 35582 RVA: 0x001DACD4 File Offset: 0x001D8ED4
	public int GetMonsterRatioByInstanceId(int instanceId)
	{
		return this.GetDifficultyConfigByInstanceId(instanceId).MonsterRatio;
	}

	// Token: 0x06008AFF RID: 35583 RVA: 0x001DACF0 File Offset: 0x001D8EF0
	public int GetRecordScoreById(int id)
	{
		return this.ProtocolContext.GetScoreById(id);
	}

	// Token: 0x06008B00 RID: 35584 RVA: 0x001DAD00 File Offset: 0x001D8F00
	public int GetMaxScoreByInstanceId(int instanceId)
	{
		int value = this.ConfigContext.GetIdByInstanceId(instanceId).Value;
		return this.GetMaxScoreById(value);
	}

	// Token: 0x06008B01 RID: 35585 RVA: 0x001DAD2C File Offset: 0x001D8F2C
	public int GetMaxScoreById(int id)
	{
		RiskHarvestInst? config = ConfigRiskHarvestInstById.GetConfig(id, true);
		if (config != null)
		{
			return config.Value.MaxScore;
		}
		return 0;
	}

	// Token: 0x06008B02 RID: 35586 RVA: 0x001DAD5B File Offset: 0x001D8F5B
	public float GetProgressOverallPercentage(int artifactId, int count)
	{
		return this.ConfigContext.GetProgressOverallPercentage(artifactId, count);
	}

	// Token: 0x06008B03 RID: 35587 RVA: 0x001DAD6C File Offset: 0x001D8F6C
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

	// Token: 0x06008B04 RID: 35588 RVA: 0x001DAE74 File Offset: 0x001D9074
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

	// Token: 0x06008B05 RID: 35589 RVA: 0x001DAF0C File Offset: 0x001D910C
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

	// Token: 0x06008B06 RID: 35590 RVA: 0x001DAFAC File Offset: 0x001D91AC
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

	// Token: 0x06008B07 RID: 35591 RVA: 0x001DB084 File Offset: 0x001D9284
	private IMowingBuffGridItemData[] BuildBuffItemListData(List<RiskHarvestBuffGroup> configList)
	{
		List<IMowingBuffGridItemData> list = new List<IMowingBuffGridItemData>();
		foreach (RiskHarvestBuffGroup riskHarvestBuffGroup in configList)
		{
			list.Add(this.BuildBuffItemDataById(riskHarvestBuffGroup.Id));
		}
		return list.ToArray();
	}

	// Token: 0x06008B08 RID: 35592 RVA: 0x001DB0EC File Offset: 0x001D92EC
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
				BuffItemList = this.BuildBuffItemListData(superBuffConfigsAfterSort.ToList<RiskHarvestBuffGroup>()),
				ShowUnlockText = showUnlockText
			});
		}
		RiskHarvestBuffGroup[] basicBuffConfigsAfterSort = this.GetBasicBuffConfigsAfterSort();
		if (basicBuffConfigsAfterSort.Length != 0)
		{
			list.Add(new MowingBuffGridGroupData
			{
				GroupNameTextId = "riskharvest_normalbuff",
				BuffItemList = this.BuildBuffItemListData(basicBuffConfigsAfterSort.ToList<RiskHarvestBuffGroup>()),
				ShowUnlockText = showUnlockText
			});
		}
		return new MowingBuffOverviewData
		{
			IntroduceData = this.BuildBuffIntroduceDataInOverviewById(this.CurrentChosenOverviewBuffId.Value),
			BuffGroupData = list.ToArray()
		};
	}

	// Token: 0x06008B09 RID: 35593 RVA: 0x001DB1BC File Offset: 0x001D93BC
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

	// Token: 0x06008B0A RID: 35594 RVA: 0x001DB280 File Offset: 0x001D9480
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

	// Token: 0x06008B0B RID: 35595 RVA: 0x001DB308 File Offset: 0x001D9508
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

	// Token: 0x06008B0C RID: 35596 RVA: 0x001DB404 File Offset: 0x001D9604
	public IMowingRiskInstanceDetailLockItemData BuildInstanceDetailLockDataByInstanceId(int id)
	{
		int? idByInstanceId = this.ConfigContext.GetIdByInstanceId(id);
		if (idByInstanceId == null || !this.ProtocolContext.IsInstanceUnlockedById(idByInstanceId.Value))
		{
			return this.BuildInstanceLockDataByInstanceId(id);
		}
		return null;
	}

	// Token: 0x06008B0D RID: 35597 RVA: 0x001DB444 File Offset: 0x001D9644
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

	// Token: 0x06008B0E RID: 35598 RVA: 0x001DB4A0 File Offset: 0x001D96A0
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

	// Token: 0x06008B0F RID: 35599 RVA: 0x001DB4FC File Offset: 0x001D96FC
	public string BuildInstanceTotalScore()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.ProtocolContext.TotalScore);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06008B10 RID: 35600 RVA: 0x001DB52C File Offset: 0x001D972C
	public IMowingRiskInBattleBuffData BuildInBattleBuffDataById(int id)
	{
		MowingRiskConfigContext configContext = this.ConfigContext;
		return new MowingRiskInBattleBuffData
		{
			IconPath = configContext.GetBuffIconPathById(id),
			TitleTextId = configContext.GetBuffNameTextIdById(id)
		};
	}

	// Token: 0x06008B11 RID: 35601 RVA: 0x001DB560 File Offset: 0x001D9760
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

	// Token: 0x06008B12 RID: 35602 RVA: 0x001DB5B0 File Offset: 0x001D97B0
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
			DataPageList = list.ToList<IActivityRewardDataPage>(),
			Source = EActivityRewardSource.MowingRisk
		};
	}

	// Token: 0x06008B13 RID: 35603 RVA: 0x001DB618 File Offset: 0x001D9818
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

	// Token: 0x06008B14 RID: 35604 RVA: 0x001DB69C File Offset: 0x001D989C
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

	// Token: 0x06008B15 RID: 35605 RVA: 0x001DB6D0 File Offset: 0x001D98D0
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

	// Token: 0x06008B16 RID: 35606 RVA: 0x001DB704 File Offset: 0x001D9904
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

	// Token: 0x06008B17 RID: 35607 RVA: 0x001DB765 File Offset: 0x001D9965
	public bool IsSuperBuffById(int id)
	{
		return this.ConfigContext.IsSuperBuffByBuffId(id);
	}

	// Token: 0x06008B18 RID: 35608 RVA: 0x001DB774 File Offset: 0x001D9974
	public bool IsBuffGottenInBattleById(int id)
	{
		MowingRiskProtocolContext protocolContext = this.ProtocolContext;
		MowingRiskConfigContext configContext = this.ConfigContext;
		return protocolContext.BasicBuffInfoInBattle.ContainsKey(id) || (configContext.IsSuperBuffByBuffId(id) && this.ConfigContext.IsSuperBuffAvailable(protocolContext.ArtifactId, id, protocolContext.ArtifactBasicBuffTotalCount));
	}

	// Token: 0x06008B19 RID: 35609 RVA: 0x001DB7C4 File Offset: 0x001D99C4
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

	// Token: 0x06008B1A RID: 35610 RVA: 0x001DB848 File Offset: 0x001D9A48
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

	// Token: 0x06008B1B RID: 35611 RVA: 0x001DB8D1 File Offset: 0x001D9AD1
	public IReadOnlyList<RiskHarvestBuffGroup> GetBuffConfigList()
	{
		return this.ConfigContext.GetBuffConfigListByActivityId(this.ProtocolContext.Id);
	}

	// Token: 0x06008B1C RID: 35612 RVA: 0x001DB8EC File Offset: 0x001D9AEC
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

	// Token: 0x06008B1D RID: 35613 RVA: 0x001DB94C File Offset: 0x001D9B4C
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

	// Token: 0x06008B1E RID: 35614 RVA: 0x001DB9AC File Offset: 0x001D9BAC
	public bool IsBuffAvailableInActivity(RiskHarvestBuffGroup buffCfg)
	{
		return this.ProtocolContext.Id == buffCfg.ActivityId;
	}

	// Token: 0x06008B1F RID: 35615 RVA: 0x001DB9C4 File Offset: 0x001D9BC4
	public bool IsInstanceUnlockedByInstanceId(int instanceId)
	{
		int? idByInstanceId = this.ConfigContext.GetIdByInstanceId(instanceId);
		return idByInstanceId != null && this.ProtocolContext.IsInstanceUnlockedById(idByInstanceId.Value);
	}

	// Token: 0x06008B20 RID: 35616 RVA: 0x001DB9FC File Offset: 0x001D9BFC
	public bool IsInstanceNewById(int id)
	{
		bool flag;
		return this.ConfigContext.IsInstanceNewCache.TryGetValue(id, out flag) && flag;
	}

	// Token: 0x06008B21 RID: 35617 RVA: 0x001DBA20 File Offset: 0x001D9C20
	public void SetInstanceOldById(int id)
	{
		Dictionary<int, bool> isInstanceNewCache = this.ConfigContext.IsInstanceNewCache;
		isInstanceNewCache[id] = false;
		this.ConfigContext.IsInstanceNewCache = isInstanceNewCache;
	}

	// Token: 0x06008B22 RID: 35618 RVA: 0x001DBA50 File Offset: 0x001D9C50
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

	// Token: 0x06008B23 RID: 35619 RVA: 0x001DBAD4 File Offset: 0x001D9CD4
	public void RecordBuffId(int buffId)
	{
		this.ProtocolContext.RecordBuffId(buffId);
	}

	// Token: 0x06008B24 RID: 35620 RVA: 0x001DBAE2 File Offset: 0x001D9CE2
	public HashSet<int> GetRecordBuffIdSet()
	{
		return this.ProtocolContext.GetRecordBuffIdSet();
	}

	// Token: 0x06008B25 RID: 35621 RVA: 0x001DBAEF File Offset: 0x001D9CEF
	public bool HasBuffIdRecord(int buffId)
	{
		return this.GetRecordBuffIdSet().Contains(buffId);
	}

	// Token: 0x06008B26 RID: 35622 RVA: 0x001DBAFD File Offset: 0x001D9CFD
	public void RecordProgressPanelBasicBuffCount(int superBuffCount)
	{
		this.ProtocolContext.RecordProgressPanelBasicBuffCount(superBuffCount);
	}

	// Token: 0x06008B27 RID: 35623 RVA: 0x001DBB0B File Offset: 0x001D9D0B
	public int GetProgressPanelBasicBuffCountRecord()
	{
		return this.ProtocolContext.GetProgressPanelBasicBuffCountRecord();
	}

	// Token: 0x06008B28 RID: 35624 RVA: 0x001DBB18 File Offset: 0x001D9D18
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
			DataList = array.ToList<IActivityRewardData>()
		};
	}

	// Token: 0x06008B29 RID: 35625 RVA: 0x001DBB67 File Offset: 0x001D9D67
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

	// Token: 0x06008B2A RID: 35626 RVA: 0x001DBB98 File Offset: 0x001D9D98
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

	// Token: 0x06008B2B RID: 35627 RVA: 0x001DBCA8 File Offset: 0x001D9EA8
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

	// Token: 0x06008B2C RID: 35628 RVA: 0x001DBDB8 File Offset: 0x001D9FB8
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

	// Token: 0x06008B2D RID: 35629 RVA: 0x001DBFC4 File Offset: 0x001DA1C4
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

	// Token: 0x06008B2E RID: 35630 RVA: 0x001DC0C8 File Offset: 0x001DA2C8
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

	// Token: 0x06008B2F RID: 35631 RVA: 0x001DC118 File Offset: 0x001DA318
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

	// Token: 0x06008B30 RID: 35632 RVA: 0x001DC18C File Offset: 0x001DA38C
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

	// Token: 0x06008B31 RID: 35633 RVA: 0x001DC1C4 File Offset: 0x001DA3C4
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

	// Token: 0x06008B32 RID: 35634 RVA: 0x001DC214 File Offset: 0x001DA414
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

	// Token: 0x06008B33 RID: 35635 RVA: 0x001DC27C File Offset: 0x001DA47C
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

	// Token: 0x06008B34 RID: 35636 RVA: 0x001DC2EC File Offset: 0x001DA4EC
	private string GetRewardTabTipsByType()
	{
		return StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("RiskHarvest_InstanceToppoint", null), new string[]
		{
			this.ProtocolContext.TotalScore.ToString()
		});
	}

	// Token: 0x06008B35 RID: 35637 RVA: 0x001DC328 File Offset: 0x001DA528
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

	// Token: 0x06008B36 RID: 35638 RVA: 0x001DC379 File Offset: 0x001DA579
	private string BuildInstanceSubtitleTextIdById(int id)
	{
		if (this.ProtocolContext.IsInstanceUnlockedById(id))
		{
			return this.GetInstanceUnlockTextIdById(id);
		}
		return this.GetInstanceLockTextIdById(id);
	}

	// Token: 0x06008B37 RID: 35639 RVA: 0x001DC398 File Offset: 0x001DA598
	public string GetInstanceUnlockTextIdById(int id)
	{
		if (!ConfigRiskHarvestInstById.GetConfig(id, true).Value.Accumulate)
		{
			return "RiskHarvest_InstanceToppoint";
		}
		return "RiskHarvest_TotleScore";
	}

	// Token: 0x06008B38 RID: 35640 RVA: 0x001DC3CC File Offset: 0x001DA5CC
	public string GetInstanceLockTextIdByInstanceId(int instanceId)
	{
		int? idByInstanceId = this.ConfigContext.GetIdByInstanceId(instanceId);
		if (idByInstanceId == null)
		{
			return string.Empty;
		}
		return this.GetInstanceLockTextIdById(idByInstanceId.Value);
	}

	// Token: 0x06008B39 RID: 35641 RVA: 0x001DC402 File Offset: 0x001DA602
	public string GetInstanceLockTextIdById(int id)
	{
		if (!this.ProtocolContext.IsInstancePassUnlockTimeById(id))
		{
			return "Text_ActiveToOpenTime_Text";
		}
		return "RiskHarvest_Unlock";
	}

	// Token: 0x06008B3A RID: 35642 RVA: 0x001DC420 File Offset: 0x001DA620
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

	// Token: 0x06008B3B RID: 35643 RVA: 0x001DC460 File Offset: 0x001DA660
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

	// Token: 0x06008B3C RID: 35644 RVA: 0x001DC4EC File Offset: 0x001DA6EC
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

	// Token: 0x06008B3D RID: 35645 RVA: 0x001DC51E File Offset: 0x001DA71E
	private void HandleRewardResponseFulfill()
	{
		EventSystem.Instance.Emit<IActivityRewardViewData>(EEventName.RefreshCommonActivityRewardPopUpView, this.BuildActivityRewardViewData());
	}

	// Token: 0x17000BC9 RID: 3017
	// (get) Token: 0x06008B3E RID: 35646 RVA: 0x001DC536 File Offset: 0x001DA736
	public ActivityBaseData ActivityData
	{
		get
		{
			return this.ProtocolContext;
		}
	}

	// Token: 0x17000BCA RID: 3018
	// (get) Token: 0x06008B3F RID: 35647 RVA: 0x001DC53E File Offset: 0x001DA73E
	// (set) Token: 0x06008B40 RID: 35648 RVA: 0x001DC54B File Offset: 0x001DA74B
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

	// Token: 0x17000BCB RID: 3019
	// (get) Token: 0x06008B41 RID: 35649 RVA: 0x001DC559 File Offset: 0x001DA759
	// (set) Token: 0x06008B42 RID: 35650 RVA: 0x001DC566 File Offset: 0x001DA766
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

	// Token: 0x17000BCC RID: 3020
	// (get) Token: 0x06008B43 RID: 35651 RVA: 0x001DC574 File Offset: 0x001DA774
	// (set) Token: 0x06008B44 RID: 35652 RVA: 0x001DC5AA File Offset: 0x001DA7AA
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

	// Token: 0x06008B45 RID: 35653 RVA: 0x001DC5B8 File Offset: 0x001DA7B8
	public int? GetDefaultChosenOverviewBuffId()
	{
		List<RiskHarvestBuffGroup> basicBuffConfigListBeforeBattle = this.GetBasicBuffConfigListBeforeBattle();
		if (basicBuffConfigListBeforeBattle != null && basicBuffConfigListBeforeBattle.Count > 0)
		{
			return new int?(this.FindBuffConfigsFirstId(basicBuffConfigListBeforeBattle));
		}
		RiskHarvestBuffGroup[] superBuffConfigsAfterSort = this.GetSuperBuffConfigsAfterSort();
		return new int?(this.FindBuffConfigsFirstId(superBuffConfigsAfterSort.ToList<RiskHarvestBuffGroup>()));
	}

	// Token: 0x06008B46 RID: 35654 RVA: 0x001DC5FD File Offset: 0x001DA7FD
	public RiskHarvestBuffGroup[] GetBasicBuffConfigsAfterSort()
	{
		List<RiskHarvestBuffGroup> list = (this.CurrentBuffViewUsage == EMowingBuffViewUsage.InBattle) ? this.GetBasicBuffConfigListInBattle() : this.GetBasicBuffConfigListBeforeBattle();
		list.Sort(new Comparison<RiskHarvestBuffGroup>(this.HandleCompareBuff));
		return list.ToArray();
	}

	// Token: 0x06008B47 RID: 35655 RVA: 0x001DC62F File Offset: 0x001DA82F
	public RiskHarvestBuffGroup[] GetSuperBuffConfigsAfterSort()
	{
		List<RiskHarvestBuffGroup> list = (this.CurrentBuffViewUsage == EMowingBuffViewUsage.InBattle) ? this.GetSuperBuffConfigListInBattle() : this.GetSuperBuffConfigListBeforeBattle();
		list.Sort(new Comparison<RiskHarvestBuffGroup>(this.HandleCompareBuff));
		return list.ToArray();
	}

	// Token: 0x06008B48 RID: 35656 RVA: 0x001DC661 File Offset: 0x001DA861
	private int HandleCompareBuff(RiskHarvestBuffGroup a, RiskHarvestBuffGroup b)
	{
		if (a.BuffType == b.BuffType)
		{
			return a.Id - b.Id;
		}
		return b.BuffType - a.BuffType;
	}

	// Token: 0x06008B49 RID: 35657 RVA: 0x001DC694 File Offset: 0x001DA894
	private int FindBuffConfigsFirstId(List<RiskHarvestBuffGroup> configList)
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

	// Token: 0x17000BCD RID: 3021
	// (get) Token: 0x06008B4A RID: 35658 RVA: 0x001DC72C File Offset: 0x001DA92C
	// (set) Token: 0x06008B4B RID: 35659 RVA: 0x001DC763 File Offset: 0x001DA963
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

	// Token: 0x17000BCE RID: 3022
	// (get) Token: 0x06008B4C RID: 35660 RVA: 0x001DC771 File Offset: 0x001DA971
	public int CurrentHelpButtonId
	{
		get
		{
			return this.ProtocolContext.GetHelpId();
		}
	}

	// Token: 0x17000BCF RID: 3023
	// (get) Token: 0x06008B4D RID: 35661 RVA: 0x001DC77E File Offset: 0x001DA97E
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

	// Token: 0x17000BD0 RID: 3024
	// (get) Token: 0x06008B4E RID: 35662 RVA: 0x001DC790 File Offset: 0x001DA990
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

	// Token: 0x17000BD1 RID: 3025
	// (get) Token: 0x06008B4F RID: 35663 RVA: 0x001DC890 File Offset: 0x001DAA90
	public bool IsPreQuestFinished
	{
		get
		{
			return this.ProtocolContext.GetPreGuideQuestFinishState();
		}
	}

	// Token: 0x17000BD2 RID: 3026
	// (get) Token: 0x06008B50 RID: 35664 RVA: 0x001DC89D File Offset: 0x001DAA9D
	public int UnFinishPreGuideQuestId
	{
		get
		{
			return this.ProtocolContext.GetUnFinishPreGuideQuestId();
		}
	}

	// Token: 0x17000BD3 RID: 3027
	// (get) Token: 0x06008B51 RID: 35665 RVA: 0x001DC8AA File Offset: 0x001DAAAA
	public string InstanceSubViewResourceId
	{
		get
		{
			return "UiItem_CheckpointsMowing";
		}
	}

	// Token: 0x17000BD4 RID: 3028
	// (get) Token: 0x06008B52 RID: 35666 RVA: 0x001DC8B4 File Offset: 0x001DAAB4
	public string ActivityTitleTextId
	{
		get
		{
			MowingRiskProtocolContext protocolContext = this.ProtocolContext;
			return ((protocolContext.LocalConfig != null) ? protocolContext.LocalConfig.GetValueOrDefault().Title : null) ?? string.Empty;
		}
	}

	// Token: 0x17000BD5 RID: 3029
	// (get) Token: 0x06008B53 RID: 35667 RVA: 0x001DC8F0 File Offset: 0x001DAAF0
	public string ActivityDescriptionTextId
	{
		get
		{
			MowingRiskProtocolContext protocolContext = this.ProtocolContext;
			return ((protocolContext.LocalConfig != null) ? protocolContext.LocalConfig.GetValueOrDefault().Desc : null) ?? string.Empty;
		}
	}

	// Token: 0x17000BD6 RID: 3030
	// (get) Token: 0x06008B54 RID: 35668 RVA: 0x001DC92A File Offset: 0x001DAB2A
	public bool HasAnyReward
	{
		get
		{
			return this.HasAnyInstanceReward || this.HasAnyScoreReward || this.HasAnyStarReward;
		}
	}

	// Token: 0x17000BD7 RID: 3031
	// (get) Token: 0x06008B55 RID: 35669 RVA: 0x001DC944 File Offset: 0x001DAB44
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

	// Token: 0x17000BD8 RID: 3032
	// (get) Token: 0x06008B56 RID: 35670 RVA: 0x001DC9AC File Offset: 0x001DABAC
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

	// Token: 0x17000BD9 RID: 3033
	// (get) Token: 0x06008B57 RID: 35671 RVA: 0x001DCA14 File Offset: 0x001DAC14
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

	// Token: 0x17000BDA RID: 3034
	// (get) Token: 0x06008B58 RID: 35672 RVA: 0x001DCA94 File Offset: 0x001DAC94
	public int MapMarkId
	{
		get
		{
			return 380034;
		}
	}

	// Token: 0x17000BDB RID: 3035
	// (get) Token: 0x06008B59 RID: 35673 RVA: 0x001DCA9B File Offset: 0x001DAC9B
	public int MapMarkType
	{
		get
		{
			return 6;
		}
	}

	// Token: 0x17000BDC RID: 3036
	// (get) Token: 0x06008B5A RID: 35674 RVA: 0x001DCAA0 File Offset: 0x001DACA0
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

	// Token: 0x17000BDD RID: 3037
	// (get) Token: 0x06008B5B RID: 35675 RVA: 0x001DCAF1 File Offset: 0x001DACF1
	public static MowingRiskModel Instance
	{
		get
		{
			return MowingRiskModel._Instance;
		}
	}

	// Token: 0x06008B5C RID: 35676 RVA: 0x001DCAF8 File Offset: 0x001DACF8
	public static MowingRiskModel GetOrCreateInstance()
	{
		if (MowingRiskModel._Instance == null)
		{
			MowingRiskModel.CreateInstance();
		}
		return MowingRiskModel._Instance;
	}

	// Token: 0x06008B5D RID: 35677 RVA: 0x001DCB0C File Offset: 0x001DAD0C
	public static bool CreateInstance()
	{
		if (MowingRiskModel._Instance != null)
		{
			return true;
		}
		MowingRiskModel._Instance = new MowingRiskModel();
		return true;
	}

	// Token: 0x06008B5E RID: 35678 RVA: 0x001DCB22 File Offset: 0x001DAD22
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06008B5F RID: 35679 RVA: 0x001DCB24 File Offset: 0x001DAD24
	public static void ResetStaticDefaultValue()
	{
		MowingRiskModel._Instance = null;
	}

	// Token: 0x06008B60 RID: 35680 RVA: 0x001DCB2C File Offset: 0x001DAD2C
	static MowingRiskModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MowingRiskModel.CreateStaticDefaultValue), new Action(MowingRiskModel.ResetStaticDefaultValue));
	}

	// Token: 0x04003DCC RID: 15820
	[Nullable(2)]
	private static MowingRiskModel _Instance;
}
