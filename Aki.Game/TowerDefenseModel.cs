using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.TowerDefence;
using CSharpScript.Module.InstanceDungeon;

// Token: 0x0200213B RID: 8507
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class TowerDefenseModel : ModelBase
{
	// Token: 0x17001FB7 RID: 8119
	// (get) Token: 0x06014E2F RID: 85551 RVA: 0x00612FB8 File Offset: 0x006111B8
	// (set) Token: 0x06014E30 RID: 85552 RVA: 0x00613018 File Offset: 0x00611218
	public bool IsEnterInActivityClicked
	{
		get
		{
			if (this.IsEnterInActivityClickedCache == null)
			{
				bool? flag = new bool?(LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.TowerDefenseEntered, false));
				if (flag == null)
				{
					LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.TowerDefenseEntered, false);
					flag = new bool?(false);
				}
				this.IsEnterInActivityClickedCache = new bool?(flag.Value);
			}
			return this.IsEnterInActivityClickedCache.Value;
		}
		set
		{
			bool? isEnterInActivityClickedCache = this.IsEnterInActivityClickedCache;
			if (!(isEnterInActivityClickedCache.GetValueOrDefault() == value & isEnterInActivityClickedCache != null))
			{
				this.IsEnterInActivityClickedCache = new bool?(value);
				LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.TowerDefenseEntered, value);
			}
		}
	}

	// Token: 0x17001FB8 RID: 8120
	// (get) Token: 0x06014E31 RID: 85553 RVA: 0x00613057 File Offset: 0x00611257
	public Dictionary<int, ITowerDefensePhantomConfig> PhantomConfigCache { get; } = new Dictionary<int, ITowerDefensePhantomConfig>();

	// Token: 0x17001FB9 RID: 8121
	// (get) Token: 0x06014E32 RID: 85554 RVA: 0x0061305F File Offset: 0x0061125F
	public List<ITowerDefensePhantomConfig> SortedPhantomConfigCache { get; } = new List<ITowerDefensePhantomConfig>();

	// Token: 0x06014E33 RID: 85555 RVA: 0x00613068 File Offset: 0x00611268
	public unsafe int GetCurrentPhantomIdInBattle()
	{
		SceneTeamItem currentSceneTeamItem = TowerDefenseController.Instance.GetCurrentSceneTeamItem();
		int playerId = currentSceneTeamItem.GetPlayerId();
		int getConfigId = currentSceneTeamItem.GetConfigId;
		ITowerDefensePhantomDataOwner ownerData = this.GetOwnerData(playerId, getConfigId);
		if (ownerData == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.TowerDefense;
			ELogAuthor author = ELogAuthor.WZ;
			string message = "塔防战斗中获取声骸ID失败：未获取OwnerData";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("PlayerID", playerId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("RoleCfgID", getConfigId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Owner Data", ownerData);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return 0;
		}
		if (ownerData.PhantomId <= 0)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.TowerDefense;
			ELogAuthor author2 = ELogAuthor.WZ;
			string message2 = "塔防战斗中获取声骸ID失败：未赋值声骸";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("PlayerID", playerId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("RoleCfgID", getConfigId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("Owner Data", ownerData);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
		}
		return ownerData.PhantomId;
	}

	// Token: 0x06014E34 RID: 85556 RVA: 0x0061319C File Offset: 0x0061139C
	private List<ITowerDefensePhantomConfigSkillData> GetCurrentPhantomSkillCfgCore(int phantomId)
	{
		ITowerDefensePhantomConfig towerDefensePhantomConfig;
		if (!this.PhantomConfigCache.TryGetValue(phantomId, out towerDefensePhantomConfig))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.TowerDefense;
			ELogAuthor author = ELogAuthor.WZ;
			string message = "未能获得塔防声骸技能配置";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("TowerDefensePhantomId", phantomId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return new List<ITowerDefensePhantomConfigSkillData>();
		}
		return towerDefensePhantomConfig.SkillDataList;
	}

	// Token: 0x06014E35 RID: 85557 RVA: 0x006131F4 File Offset: 0x006113F4
	public List<ITowerDefensePhantomConfigSkillData> GetCurrentPhantomSkillCfgListInBattle()
	{
		int currentPhantomIdInBattle = this.GetCurrentPhantomIdInBattle();
		return this.GetCurrentPhantomSkillCfgCore(currentPhantomIdInBattle);
	}

	// Token: 0x06014E36 RID: 85558 RVA: 0x00613210 File Offset: 0x00611410
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public List<string> GetCurrentPhantomSkillDescriptionArgsInBattle()
	{
		int currentPhantomIdInBattle = this.GetCurrentPhantomIdInBattle();
		string[] phantomSkillDescriptionArgsByPhantomId = TowerDefenseController.Instance.GetPhantomSkillDescriptionArgsByPhantomId(currentPhantomIdInBattle);
		if (phantomSkillDescriptionArgsByPhantomId != null)
		{
			return new List<string>(phantomSkillDescriptionArgsByPhantomId);
		}
		return null;
	}

	// Token: 0x06014E37 RID: 85559 RVA: 0x0061323C File Offset: 0x0061143C
	public int GetCurrentPhantomLevelInBattle()
	{
		int currentPhantomIdInBattle = this.GetCurrentPhantomIdInBattle();
		TowerDefencePhantomInfo towerDefencePhantomInfo;
		if (this.PhantomMessageCache.OwnPhantomInBattleDataCache.TryGetValue(currentPhantomIdInBattle, out towerDefencePhantomInfo))
		{
			return towerDefencePhantomInfo.Level;
		}
		return 1;
	}

	// Token: 0x06014E38 RID: 85560 RVA: 0x00613270 File Offset: 0x00611470
	public ITowerDefensePhantomExp GetCurrentPhantomExpPairInBattle()
	{
		int currentPhantomIdInBattle = this.GetCurrentPhantomIdInBattle();
		Dictionary<int, TowerDefencePhantomInfo> ownPhantomInBattleDataCache = this.PhantomMessageCache.OwnPhantomInBattleDataCache;
		ITowerDefensePhantomExp towerDefensePhantomExp = new TowerDefensePhantomExp
		{
			Exp = 0.0,
			Threshold = 0.0
		};
		TowerDefencePhantomInfo towerDefencePhantomInfo;
		if (ownPhantomInBattleDataCache.TryGetValue(currentPhantomIdInBattle, out towerDefencePhantomInfo))
		{
			ITowerDefensePhantomConfig towerDefensePhantomConfig;
			if (!this.PhantomConfigCache.TryGetValue(towerDefencePhantomInfo.Id, out towerDefensePhantomConfig))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.TowerDefense;
				ELogAuthor author = ELogAuthor.WZ;
				string message = "战斗中声骸ID，协议与配置不匹配，以协议ID找不到配置数据";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("协议声骸ID", towerDefencePhantomInfo.Id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return towerDefensePhantomExp;
			}
			int level = towerDefencePhantomInfo.Level;
			double num = 0.0;
			if (level >= 1 && towerDefensePhantomConfig.MaxLevel > 1)
			{
				num = ((towerDefensePhantomConfig.MaxLevel == towerDefencePhantomInfo.Level) ? towerDefensePhantomConfig.SkillDataList[level - 2].ExpThreshold : towerDefensePhantomConfig.SkillDataList[level - 1].ExpThreshold).GetValueOrDefault();
			}
			towerDefensePhantomExp.Exp = ((towerDefensePhantomConfig.MaxLevel == towerDefencePhantomInfo.Level) ? num : ((double)towerDefencePhantomInfo.Exp));
			towerDefensePhantomExp.Threshold = num;
		}
		else
		{
			ITowerDefensePhantomConfig towerDefensePhantomConfig2;
			if (!this.PhantomConfigCache.TryGetValue(currentPhantomIdInBattle, out towerDefensePhantomConfig2))
			{
				return towerDefensePhantomExp;
			}
			towerDefensePhantomExp.Exp = 0.0;
			towerDefensePhantomExp.Threshold = towerDefensePhantomConfig2.SkillDataList[0].ExpThreshold.GetValueOrDefault();
		}
		return towerDefensePhantomExp;
	}

	// Token: 0x06014E39 RID: 85561 RVA: 0x006133E0 File Offset: 0x006115E0
	public string GetCurrentPhantomNameTextId()
	{
		TowerDefencePhantom? config = ConfigTowerDefencePhantomById.GetConfig(this.GetCurrentPhantomIdInBattle(), true);
		if (config != null)
		{
			return config.Value.PhantomName;
		}
		return "";
	}

	// Token: 0x06014E3A RID: 85562 RVA: 0x00613418 File Offset: 0x00611618
	public List<ITowerDefensePhantomConfigSkillData> GetCurrentPhantomSkillCfgTemp()
	{
		return this.GetCurrentPhantomSkillCfgCore(this.CurrentSelfPhantomIdInUiTemp);
	}

	// Token: 0x06014E3B RID: 85563 RVA: 0x00613426 File Offset: 0x00611626
	public ParsedTowerDefenseMsg GetOrCreateParsedTowerDefenseMsg()
	{
		if (this.PhantomMessageCache == null)
		{
			this.PhantomMessageCache = new ParsedTowerDefenseMsg();
		}
		return this.PhantomMessageCache;
	}

	// Token: 0x06014E3C RID: 85564 RVA: 0x00613444 File Offset: 0x00611644
	[return: Nullable(2)]
	public List<int> GetProtocolPhantomIdList(List<int> roleCfgIdList)
	{
		if (TowerDefenseController.Instance.CheckInUiFlow() || TowerDefenseController.Instance.CheckInInstanceDungeon())
		{
			List<int> list = new List<int>();
			int value = PlayerInfoModel.Instance.GetId().Value;
			foreach (int roleCfgId in roleCfgIdList)
			{
				ITowerDefensePhantomDataOwner ownerData = this.GetOwnerData(value, roleCfgId);
				list.Add(ownerData.PhantomId);
			}
			return list;
		}
		return null;
	}

	// Token: 0x06014E3D RID: 85565 RVA: 0x006134D8 File Offset: 0x006116D8
	[NullableContext(0)]
	[return: TupleElementNames(new string[]
	{
		"rewardedCount",
		"totalCount"
	})]
	public ValueTuple<int, int> GetPreviewRewardCount()
	{
		int num = 0;
		int num2 = 0;
		IReadOnlyList<TowerDefenceReward> configList = ConfigTowerDefenceRewardAll.GetConfigList(true);
		if (configList == null)
		{
			return new ValueTuple<int, int>(num, num2);
		}
		foreach (TowerDefenceReward towerDefenceReward in configList)
		{
			if (towerDefenceReward.ActivityId == this.PhantomMessageCache.Id)
			{
				if (this.PhantomMessageCache.GetScoreRewardStateById(towerDefenceReward.Id) == EActivityRewardState.Claimed)
				{
					num++;
				}
				num2++;
			}
		}
		foreach (ITowerDefenseParsedStageMessage towerDefenseParsedStageMessage in this.PhantomMessageCache.StageListCache)
		{
			if (this.PhantomMessageCache.GetPassRewardStateById(towerDefenseParsedStageMessage.Id) == EActivityRewardState.Claimed)
			{
				num++;
			}
			num2++;
		}
		return new ValueTuple<int, int>(num, num2);
	}

	// Token: 0x06014E3E RID: 85566 RVA: 0x006135C8 File Offset: 0x006117C8
	public IActivityRewardViewData GetPreviewRewardData()
	{
		IReadOnlyList<TowerDefenceReward> configList = ConfigTowerDefenceRewardAll.GetConfigList(true);
		List<IActivityRewardData> list = new List<IActivityRewardData>();
		if (configList != null)
		{
			foreach (TowerDefenceReward towerDefenceReward in configList)
			{
				if (towerDefenceReward.ActivityId == this.PhantomMessageCache.Id)
				{
					List<TItem> list2 = new List<TItem>();
					foreach (KeyValuePair<int, int> keyValuePair in ConfigDropPackageById.GetConfig(towerDefenceReward.RewardId, true).Value.DropPreview())
					{
						list2.Add(new TItem(new InventoryDefine.GetItemData(keyValuePair.Key, 0), keyValuePair.Value));
					}
					EActivityRewardState scoreRewardStateById = this.PhantomMessageCache.GetScoreRewardStateById(towerDefenceReward.Id);
					ActivityRewardData item = new ActivityRewardData
					{
						Id = new int?(towerDefenceReward.Id),
						NameText = "",
						NameTextId = "ConditionGroup_12100402_HintText",
						NameTextArgs = new string[]
						{
							towerDefenceReward.Score.ToString()
						},
						RewardList = list2.ToArray(),
						RewardState = scoreRewardStateById,
						RewardButtonText = this.GetPreviewButtonTextByState(scoreRewardStateById),
						RewardButtonRedDot = new bool?(scoreRewardStateById == EActivityRewardState.Enable),
						ProgressText = this.BuildScoreProgressText(towerDefenceReward.Score, -1),
						ClickFunction = delegate
						{
							TowerDefenseController.Instance.RequestScoreReward(this.CollectClaimableScoreRewardIds());
						}
					};
					list.Add(item);
				}
			}
		}
		list.Sort(new Comparison<IActivityRewardData>(this.SortRewardHandler));
		List<IActivityRewardData> list3 = new List<IActivityRewardData>();
		List<IActivityRewardData> list4 = new List<IActivityRewardData>();
		foreach (ITowerDefenseParsedStageMessage towerDefenseParsedStageMessage in this.PhantomMessageCache.StageListCache)
		{
			List<TItem> list5 = new List<TItem>();
			TowerDefenceInstance? towerDefenseInstanceCfg = ConfigTowerDefenceInstanceById.GetConfig(towerDefenseParsedStageMessage.Id, true);
			int instanceId = towerDefenseInstanceCfg.Value.InstanceId;
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew(InstanceDungeonConfig.Instance.GetConfig(instanceId).Value.MapName, null);
			foreach (KeyValuePair<int, int> keyValuePair2 in ConfigDropPackageById.GetConfig(towerDefenseInstanceCfg.Value.RewardId, true).Value.DropPreview())
			{
				list5.Add(new TItem(new InventoryDefine.GetItemData(keyValuePair2.Key, 0), keyValuePair2.Value));
			}
			EActivityRewardState passRewardStateById = this.PhantomMessageCache.GetPassRewardStateById(towerDefenseParsedStageMessage.Id);
			string nameTextId = towerDefenseInstanceCfg.Value.IsDifficult ? "TowerDefenceclear" : "ConditionGroup_12100401_HintText";
			List<string> list7;
			if (!towerDefenseInstanceCfg.Value.IsDifficult)
			{
				List<string> list6 = new List<string>();
				list6.Add(localTextNew);
				list7 = list6;
				list6.Add(towerDefenseInstanceCfg.Value.RewardScore.ToString());
			}
			else
			{
				(list7 = new List<string>()).Add(localTextNew);
			}
			List<string> list8 = list7;
			ActivityRewardData item2 = new ActivityRewardData
			{
				Id = new int?(towerDefenseInstanceCfg.Value.Id),
				NameText = "",
				NameTextId = nameTextId,
				NameTextArgs = list8.ToArray(),
				RewardList = list5.ToArray(),
				RewardState = passRewardStateById,
				RewardButtonText = this.GetPreviewButtonTextByState(passRewardStateById),
				RewardButtonRedDot = new bool?(passRewardStateById == EActivityRewardState.Enable),
				ProgressText = (towerDefenseInstanceCfg.Value.IsDifficult ? null : this.BuildScoreProgressText(towerDefenseInstanceCfg.Value.RewardScore, towerDefenseParsedStageMessage.Record)),
				ClickFunction = delegate
				{
					TowerDefenseController.Instance.RequestInstanceReward(this.CollectClaimableInstanceRewardIds(towerDefenseInstanceCfg.Value.IsDifficult));
				}
			};
			if (towerDefenseInstanceCfg.Value.IsDifficult)
			{
				list4.Add(item2);
			}
			else
			{
				list3.Add(item2);
			}
		}
		list3.Sort(new Comparison<IActivityRewardData>(this.SortRewardHandler));
		list4.Sort(new Comparison<IActivityRewardData>(this.SortRewardHandler));
		string localTextNew2 = ConfigMultiTextLang.GetLocalTextNew("TowerDefenceFullPoint", null);
		string tabTips = (localTextNew2 != null) ? StringUtils.Format(localTextNew2, new string[]
		{
			this.PhantomMessageCache.TotalScore.ToString()
		}) : "";
		List<IActivityRewardDataPage> list9 = new List<IActivityRewardDataPage>();
		if (list3.Count > 0)
		{
			list9.Add(new ActivityRewardDataPage
			{
				TabName = ConfigMultiTextLang.GetLocalTextNew("TowerDefenceLevelRewardText", null),
				TabTips = tabTips,
				DataList = list3
			});
		}
		if (list.Count > 0)
		{
			list9.Add(new ActivityRewardDataPage
			{
				TabName = ConfigMultiTextLang.GetLocalTextNew("TowerDefenceScoreRewardText", null),
				TabTips = tabTips,
				DataList = list
			});
		}
		if (list4.Count > 0)
		{
			list9.Add(new ActivityRewardDataPage
			{
				TabName = ConfigMultiTextLang.GetLocalTextNew("PrefabTextItem_1347286118_Text", null),
				TabTips = tabTips,
				DataList = list4
			});
		}
		return new ActivityRewardViewData
		{
			DataPageList = list9,
			Source = EActivityRewardSource.TowerDefence
		};
	}

	// Token: 0x06014E3F RID: 85567 RVA: 0x00613BB4 File Offset: 0x00611DB4
	private List<int> CollectClaimableScoreRewardIds()
	{
		List<int> list = new List<int>();
		IReadOnlyList<TowerDefenceReward> configList = ConfigTowerDefenceRewardAll.GetConfigList(true);
		if (configList != null)
		{
			foreach (TowerDefenceReward towerDefenceReward in configList)
			{
				if (towerDefenceReward.ActivityId == this.PhantomMessageCache.Id && this.PhantomMessageCache.GetScoreRewardStateById(towerDefenceReward.Id) == EActivityRewardState.Enable)
				{
					list.Add(towerDefenceReward.Id);
				}
			}
		}
		return list;
	}

	// Token: 0x06014E40 RID: 85568 RVA: 0x00613C3C File Offset: 0x00611E3C
	private List<int> CollectClaimableInstanceRewardIds(bool isDifficult)
	{
		List<int> list = new List<int>();
		foreach (ITowerDefenseParsedStageMessage towerDefenseParsedStageMessage in this.PhantomMessageCache.StageListCache)
		{
			TowerDefenceInstance? config = ConfigTowerDefenceInstanceById.GetConfig(towerDefenseParsedStageMessage.Id, true);
			if (config != null && config.Value.IsDifficult == isDifficult && this.PhantomMessageCache.GetPassRewardStateById(towerDefenseParsedStageMessage.Id) == EActivityRewardState.Enable)
			{
				list.Add(towerDefenseParsedStageMessage.Id);
			}
		}
		return list;
	}

	// Token: 0x06014E41 RID: 85569 RVA: 0x00613CE0 File Offset: 0x00611EE0
	private string BuildScoreProgressText(int requiredScore, int current = -1)
	{
		int value = Math.Min((current < 0) ? this.PhantomMessageCache.TotalScore : current, requiredScore);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
		defaultInterpolatedStringHandler.AppendFormatted<int>(value);
		defaultInterpolatedStringHandler.AppendLiteral("/");
		defaultInterpolatedStringHandler.AppendFormatted<int>(requiredScore);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06014E42 RID: 85570 RVA: 0x00613D34 File Offset: 0x00611F34
	private int SortRewardHandler(IActivityRewardData a, IActivityRewardData b)
	{
		if (a.RewardState == b.RewardState)
		{
			return a.Id.Value - b.Id.Value;
		}
		if (a.RewardState == EActivityRewardState.Enable)
		{
			return -1;
		}
		if (b.RewardState == EActivityRewardState.Enable)
		{
			return 1;
		}
		if (a.RewardState == EActivityRewardState.Disabled)
		{
			return -1;
		}
		if (b.RewardState == EActivityRewardState.Disabled)
		{
			return 1;
		}
		return 0;
	}

	// Token: 0x06014E43 RID: 85571 RVA: 0x00613D98 File Offset: 0x00611F98
	private string GetPreviewButtonTextByState(EActivityRewardState state)
	{
		switch (state)
		{
		case EActivityRewardState.Disabled:
			return ConfigMultiTextLang.GetLocalTextNew("TowerDefence_Getbt3", null) ?? "";
		case EActivityRewardState.Enable:
			return ConfigMultiTextLang.GetLocalTextNew("TowerDefence_Getbt1", null) ?? "";
		case EActivityRewardState.Claimed:
			return ConfigMultiTextLang.GetLocalTextNew("TowerDefence_Getbt1", null) ?? "";
		default:
			return "";
		}
	}

	// Token: 0x06014E44 RID: 85572 RVA: 0x00613E00 File Offset: 0x00612000
	public void ResetCurrentPhantomIdInUiTempToFirstAvailable()
	{
		foreach (ITowerDefensePhantomConfig towerDefensePhantomConfig in this.SortedPhantomConfigCache)
		{
			if (towerDefensePhantomConfig.ActivityId == this.PhantomMessageCache.Id)
			{
				bool flag = false;
				using (List<ITowerDefensePhantomDataOwner>.Enumerator enumerator2 = this.PhantomOwnerDataList.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						if (enumerator2.Current.PhantomId == towerDefensePhantomConfig.Id)
						{
							flag = true;
							break;
						}
					}
				}
				if (!flag)
				{
					this.CurrentSelfPhantomIdInUiTemp = towerDefensePhantomConfig.Id;
					return;
				}
			}
		}
		this.CurrentSelfPhantomIdInUiTemp = 0;
	}

	// Token: 0x06014E45 RID: 85573 RVA: 0x00613EC4 File Offset: 0x006120C4
	public void ResetPhantomOwnerDataList()
	{
		this.PhantomOwnerDataList.Clear();
		for (int i = 0; i < 3; i++)
		{
			this.PhantomOwnerDataList.Add(new TowerDefensePhantomDataOwner
			{
				PlayerId = (long)PlayerInfoModel.Instance.GetId().GetValueOrDefault(),
				IsSelf = true,
				RoleCfgId = 0,
				RoleSkinId = 0,
				PhantomId = 0
			});
		}
	}

	// Token: 0x06014E46 RID: 85574 RVA: 0x00613F30 File Offset: 0x00612130
	public void ResetPhantomOwnerDataByIndex(int index)
	{
		this.PhantomOwnerDataList[index].PlayerId = (long)PlayerInfoModel.Instance.GetId().Value;
		this.PhantomOwnerDataList[index].IsSelf = true;
		this.PhantomOwnerDataList[index].RoleCfgId = 0;
		this.PhantomOwnerDataList[index].RoleSkinId = 0;
		this.PhantomOwnerDataList[index].PhantomId = 0;
	}

	// Token: 0x06014E47 RID: 85575 RVA: 0x00613FAC File Offset: 0x006121AC
	public void ResetAllCache()
	{
		this.CurrentSelfPhantomIdInUiTemp = 0;
		for (int i = 0; i < this.PhantomOwnerDataList.Count; i++)
		{
			this.ResetPhantomOwnerDataByIndex(i);
		}
		this.RoleCfgId2PhantomIdMapCache.Clear();
	}

	// Token: 0x06014E48 RID: 85576 RVA: 0x00613FE8 File Offset: 0x006121E8
	public void ResetPhantomOwnerDataByConfigId(int configId)
	{
		for (int i = 0; i < this.PhantomOwnerDataList.Count; i++)
		{
			ITowerDefensePhantomDataOwner towerDefensePhantomDataOwner = this.PhantomOwnerDataList[i];
			if (towerDefensePhantomDataOwner.IsSelf && towerDefensePhantomDataOwner.RoleCfgId == configId)
			{
				this.ResetPhantomOwnerDataByIndex(i);
				break;
			}
		}
		this.RoleCfgId2PhantomIdMapCache.Remove(configId);
	}

	// Token: 0x06014E49 RID: 85577 RVA: 0x00614040 File Offset: 0x00612240
	public void ResetTimerCacheInBattle()
	{
		foreach (KeyValuePair<int, Dictionary<int, TimerHandle>> keyValuePair in this.TimerCacheInBattle)
		{
			foreach (KeyValuePair<int, TimerHandle> keyValuePair2 in keyValuePair.Value)
			{
				keyValuePair2.Value.Remove();
			}
			keyValuePair.Value.Clear();
		}
		this.TimerCacheInBattle.Clear();
	}

	// Token: 0x06014E4A RID: 85578 RVA: 0x006140EC File Offset: 0x006122EC
	[NullableContext(2)]
	public unsafe void TryAddTimerInBattle(TimerHandle handle, int playerId, int roleId)
	{
		if (handle == null)
		{
			return;
		}
		if (!this.TimerCacheInBattle.ContainsKey(playerId))
		{
			this.TimerCacheInBattle[playerId] = new Dictionary<int, TimerHandle>();
		}
		Dictionary<int, TimerHandle> dictionary = this.TimerCacheInBattle[playerId];
		if (dictionary.ContainsKey(roleId))
		{
			dictionary[roleId].Remove();
			Log instance = Log.Instance;
			ELogModule module = ELogModule.TowerDefense;
			ELogAuthor author = ELogAuthor.WZ;
			string message = "同一玩家的同一角色已经有timer用于复活倒计时，其将被停止，用新timer取代";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("playerId", playerId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("roleId", roleId);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
		dictionary[roleId] = handle;
	}

	// Token: 0x06014E4B RID: 85579 RVA: 0x006141A8 File Offset: 0x006123A8
	public void TryRemoveTimerInBattle(int playerId, int? roleId = null)
	{
		Dictionary<int, TimerHandle> dictionary;
		if (!this.TimerCacheInBattle.TryGetValue(playerId, out dictionary))
		{
			return;
		}
		if (roleId == null)
		{
			foreach (KeyValuePair<int, TimerHandle> keyValuePair in dictionary)
			{
				keyValuePair.Value.Remove();
			}
			this.TimerCacheInBattle.Remove(playerId);
			return;
		}
		TimerHandle timerHandle;
		if (!dictionary.TryGetValue(roleId.Value, out timerHandle))
		{
			return;
		}
		timerHandle.Remove();
		dictionary.Remove(roleId.Value);
		if (dictionary.Count == 0)
		{
			this.TimerCacheInBattle.Remove(playerId);
		}
	}

	// Token: 0x06014E4C RID: 85580 RVA: 0x00614260 File Offset: 0x00612460
	public bool CheckHasReward()
	{
		return this.CheckHasPassReward() || this.CheckHasScoreReward();
	}

	// Token: 0x06014E4D RID: 85581 RVA: 0x00614274 File Offset: 0x00612474
	public bool CheckHasScoreReward()
	{
		IEnumerable<TowerDefenceReward> configList = ConfigTowerDefenceRewardAll.GetConfigList(true);
		ParsedTowerDefenseMsg phantomMessageCache = this.PhantomMessageCache;
		foreach (TowerDefenceReward towerDefenceReward in configList)
		{
			if (towerDefenceReward.ActivityId == this.PhantomMessageCache.Id && phantomMessageCache.TotalScore >= towerDefenceReward.Score && !phantomMessageCache.ScoreRewardCache.ContainsKey(towerDefenceReward.Id))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06014E4E RID: 85582 RVA: 0x00614300 File Offset: 0x00612500
	public int GetMaxScoreRewardThreshold()
	{
		IReadOnlyList<TowerDefenceReward> configList = ConfigTowerDefenceRewardAll.GetConfigList(true);
		if (configList == null)
		{
			return 0;
		}
		int num = 0;
		foreach (TowerDefenceReward towerDefenceReward in configList)
		{
			if (towerDefenceReward.ActivityId == this.PhantomMessageCache.Id && towerDefenceReward.Score > num)
			{
				num = towerDefenceReward.Score;
			}
		}
		return num;
	}

	// Token: 0x06014E4F RID: 85583 RVA: 0x00614378 File Offset: 0x00612578
	public bool CheckHasPassReward()
	{
		foreach (ITowerDefenseParsedStageMessage towerDefenseParsedStageMessage in this.PhantomMessageCache.StageListCache)
		{
			TowerDefenceInstance? config = ConfigTowerDefenceInstanceById.GetConfig(towerDefenseParsedStageMessage.Id, true);
			if (config == null)
			{
				return false;
			}
			if (config.Value.IsDifficult)
			{
				if (towerDefenseParsedStageMessage.Passed && !towerDefenseParsedStageMessage.Rewarded)
				{
					return true;
				}
			}
			else if (towerDefenseParsedStageMessage.RecordOverThreshold && !towerDefenseParsedStageMessage.Rewarded)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06014E50 RID: 85584 RVA: 0x00614420 File Offset: 0x00612620
	public bool CheckHasNewStage()
	{
		double serverTimeStamp = TimeUtil.Instance.GetServerTimeStamp();
		foreach (ITowerDefenseParsedStageMessage towerDefenseParsedStageMessage in this.PhantomMessageCache.StageListCache)
		{
			if ((double)towerDefenseParsedStageMessage.UnlockTime < serverTimeStamp && !towerDefenseParsedStageMessage.Passed)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06014E51 RID: 85585 RVA: 0x00614498 File Offset: 0x00612698
	private bool CheckLevelHasClickByInstanceId(int instanceId)
	{
		Dictionary<int, bool> dictionary = LocalStorage.GetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.TowerDefenseNewLevel, null);
		if (dictionary == null)
		{
			dictionary = new Dictionary<int, bool>();
			LocalStorage.SetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.TowerDefenseNewLevel, dictionary);
			return false;
		}
		bool flag;
		return dictionary.TryGetValue(instanceId, out flag) && flag;
	}

	// Token: 0x06014E52 RID: 85586 RVA: 0x006144D0 File Offset: 0x006126D0
	public bool CheckTowerDefenseInstanceHasRedDot(int instanceId)
	{
		TowerDefenceInstance? towerDefenceInstance;
		int num = (ConfigTowerDefenceInstanceByInstanceId.GetConfig(instanceId, true) != null) ? towerDefenceInstance.GetValueOrDefault().Id : 0;
		return num > 0 && TowerDefenseController.Instance.CheckStageUnlockById(num) && !this.CheckLevelHasClickByInstanceId(instanceId);
	}

	// Token: 0x06014E53 RID: 85587 RVA: 0x00614520 File Offset: 0x00612720
	public void SetLevelHasClickByInstanceId(int instanceId)
	{
		List<ITowerDefenseParsedStageMessage> stageListCache = this.PhantomMessageCache.StageListCache;
		bool flag = false;
		foreach (ITowerDefenseParsedStageMessage towerDefenseParsedStageMessage in stageListCache)
		{
			TowerDefenceInstance? towerDefenceInstance;
			int num = (ConfigTowerDefenceInstanceById.GetConfig(towerDefenseParsedStageMessage.Id, true) != null) ? towerDefenceInstance.GetValueOrDefault().InstanceId : 0;
			if (num != 0 && num == instanceId)
			{
				if (!InstanceDungeonEntranceModel.Instance.CheckInstanceUnlock(instanceId))
				{
					return;
				}
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			return;
		}
		Dictionary<int, bool> dictionary = LocalStorage.GetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.TowerDefenseNewLevel, null);
		if (dictionary == null)
		{
			dictionary = new Dictionary<int, bool>();
		}
		dictionary[instanceId] = true;
		LocalStorage.SetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.TowerDefenseNewLevel, dictionary);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.PhantomMessageCache.Id);
		EventSystem.Instance.Emit<int>(EEventName.OnChallengeInstanceRedDot, instanceId);
	}

	// Token: 0x06014E54 RID: 85588 RVA: 0x0061460C File Offset: 0x0061280C
	public bool HasNotClickNewLevel()
	{
		if (!this.PhantomMessageCache.GetPreGuideQuestFinishState())
		{
			return false;
		}
		foreach (ITowerDefenseParsedStageMessage towerDefenseParsedStageMessage in this.PhantomMessageCache.StageListCache)
		{
			TowerDefenceInstance? towerDefenceInstance;
			int num = (ConfigTowerDefenceInstanceById.GetConfig(towerDefenseParsedStageMessage.Id, true) != null) ? towerDefenceInstance.GetValueOrDefault().InstanceId : 0;
			if (num != 0 && this.CheckTowerDefenseInstanceHasRedDot(num))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06014E55 RID: 85589 RVA: 0x006146A8 File Offset: 0x006128A8
	public bool CheckPhantomAvailableInActivityByActivityId(int id)
	{
		return id == this.PhantomMessageCache.Id;
	}

	// Token: 0x06014E56 RID: 85590 RVA: 0x006146B8 File Offset: 0x006128B8
	public bool CheckCurrentActivityShowDifferent()
	{
		TowerDefenseConfig? currentActivityConfig = this.GetCurrentActivityConfig();
		if (currentActivityConfig == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.TowerDefense;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "塔防活动配置数据为空";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ActivityId", this.PhantomMessageCache.Id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		return currentActivityConfig.Value.ShowDifferent;
	}

	// Token: 0x06014E57 RID: 85591 RVA: 0x0061471F File Offset: 0x0061291F
	public bool CheckPhantomIsOccupied(int id)
	{
		return false;
	}

	// Token: 0x06014E58 RID: 85592 RVA: 0x00614724 File Offset: 0x00612924
	[NullableContext(2)]
	public ITowerDefensePhantomDataOwner GetOwnerData(int playerId, int roleCfgId)
	{
		foreach (ITowerDefensePhantomDataOwner towerDefensePhantomDataOwner in this.PhantomOwnerDataList)
		{
			if (towerDefensePhantomDataOwner.PlayerId == (long)playerId && towerDefensePhantomDataOwner.RoleCfgId == roleCfgId)
			{
				return towerDefensePhantomDataOwner;
			}
		}
		return null;
	}

	// Token: 0x06014E59 RID: 85593 RVA: 0x0061478C File Offset: 0x0061298C
	public List<ITowerDefensePhantomDataOwner> GetOwnerDataListByPlayerId(int playerId)
	{
		List<ITowerDefensePhantomDataOwner> list = new List<ITowerDefensePhantomDataOwner>();
		foreach (ITowerDefensePhantomDataOwner towerDefensePhantomDataOwner in this.PhantomOwnerDataList)
		{
			if (towerDefensePhantomDataOwner.PlayerId == (long)playerId)
			{
				list.Add(towerDefensePhantomDataOwner);
			}
		}
		return list;
	}

	// Token: 0x06014E5A RID: 85594 RVA: 0x006147F0 File Offset: 0x006129F0
	public bool CheckHasSurvivalPhantom()
	{
		int value = PlayerInfoModel.Instance.GetId().Value;
		foreach (ITowerDefensePhantomDataOwner towerDefensePhantomDataOwner in this.PhantomOwnerDataList)
		{
			if ((long)value == towerDefensePhantomDataOwner.PlayerId && towerDefensePhantomDataOwner.PhantomId > 0)
			{
				TowerDefencePhantom? config = ConfigTowerDefencePhantomById.GetConfig(towerDefensePhantomDataOwner.PhantomId, true);
				if (config != null && config.Value.IsSurvivalType)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06014E5B RID: 85595 RVA: 0x00614894 File Offset: 0x00612A94
	public TowerDefenseConfig? GetCurrentActivityConfig()
	{
		TowerDefenseConfig? towerDefenseConfigByActivityId = InstanceDungeonConfig.Instance.GetTowerDefenseConfigByActivityId(this.PhantomMessageCache.Id);
		if (towerDefenseConfigByActivityId == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.TowerDefense;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "塔防活动配置数据为空";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ActivityId", this.PhantomMessageCache.Id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return towerDefenseConfigByActivityId;
	}

	// Token: 0x06014E5C RID: 85596 RVA: 0x00614904 File Offset: 0x00612B04
	[NullableContext(2)]
	public Dictionary<int, int> GetSortedByTitleEntranceInstanceIdList()
	{
		List<int> entranceInstanceIdList = InstanceDungeonEntranceModel.Instance.EntranceInstanceIdList;
		if (entranceInstanceIdList == null)
		{
			return null;
		}
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		foreach (int num in entranceInstanceIdList)
		{
			dictionary[num] = InstanceDungeonConfig.Instance.GetTowerDefenseInstanceByInstance(num).Value.GroupId;
		}
		return dictionary;
	}

	// Token: 0x06014E5D RID: 85597 RVA: 0x00614988 File Offset: 0x00612B88
	public bool GetInstanceUnlockState(int preConfigId, int configId)
	{
		TowerDefenceInstance? towerDefenseConfigById = InstanceDungeonConfig.Instance.GetTowerDefenseConfigById(configId);
		if (!this.PhantomMessageCache.IsStageUnLocked(towerDefenseConfigById.Value.InstanceId))
		{
			return false;
		}
		if (preConfigId != 0)
		{
			TowerDefenceInstance? towerDefenseConfigById2 = InstanceDungeonConfig.Instance.GetTowerDefenseConfigById(preConfigId);
			if (!TowerDefenseModel.Instance.PhantomMessageCache.IsPassedInstance(towerDefenseConfigById2.Value.InstanceId))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06014E5E RID: 85598 RVA: 0x006149F1 File Offset: 0x00612BF1
	protected override bool OnInit()
	{
		this.ParseTowerDefensePhantomCfg();
		this.ResetCurrentPhantomIdInUiTempToFirstAvailable();
		this.ResetPhantomOwnerDataList();
		return true;
	}

	// Token: 0x06014E5F RID: 85599 RVA: 0x00614A06 File Offset: 0x00612C06
	protected override bool OnLeaveLevel()
	{
		this.PhantomMessageCache.OwnPhantomInBattleDataCache.Clear();
		return true;
	}

	// Token: 0x06014E60 RID: 85600 RVA: 0x00614A1C File Offset: 0x00612C1C
	private void ParseTowerDefensePhantomCfg()
	{
		IReadOnlyList<TowerDefencePhantom> configList = ConfigTowerDefencePhantomAll.GetConfigList(true);
		if (configList == null)
		{
			return;
		}
		foreach (TowerDefencePhantom towerDefencePhantom in configList)
		{
			List<ITowerDefensePhantomConfigSkillData> list = new List<ITowerDefensePhantomConfigSkillData>();
			IReadOnlyList<TowerDefencePhantomLevel> configList2 = ConfigTowerDefencePhantomLevelByGroupId.GetConfigList(towerDefencePhantom.SkillGroup, true);
			if (configList2 != null)
			{
				foreach (TowerDefencePhantomLevel towerDefencePhantomLevel in configList2)
				{
					ITowerDefensePhantomConfigSkillData item = new TowerDefensePhantomConfigSkillData
					{
						Name = towerDefencePhantomLevel.Title,
						Description = towerDefencePhantomLevel.Description,
						UnlockDescription = towerDefencePhantomLevel.UnlockDescription,
						ExpThreshold = new double?((double)towerDefencePhantomLevel.ExpLevel),
						PhantomSkill = towerDefencePhantomLevel.PhantomSkill
					};
					list.Add(item);
				}
				ITowerDefensePhantomConfig towerDefensePhantomConfig = new TowerDefensePhantomConfig
				{
					Id = towerDefencePhantom.Id,
					PhantomItemId = towerDefencePhantom.PhantomItemId,
					ActivityId = towerDefencePhantom.ActivityId,
					PhantomNameTextId = towerDefencePhantom.PhantomName,
					PhantomTypeTextId = towerDefencePhantom.TypeTextId,
					TypeIconPath = (UiResourceConfig.Instance.GetResourcePath(towerDefencePhantom.TypeIcon) ?? ""),
					MarkResourceId = towerDefencePhantom.MarkHex,
					SkillDataList = list,
					MaxLevel = list.Count
				};
				this.PhantomConfigCache[towerDefencePhantom.Id] = towerDefensePhantomConfig;
				this.SortedPhantomConfigCache.Add(towerDefensePhantomConfig);
			}
		}
		this.SortedPhantomConfigCache.Sort(new Comparison<ITowerDefensePhantomConfig>(this.SortCache));
	}

	// Token: 0x06014E61 RID: 85601 RVA: 0x00614BF0 File Offset: 0x00612DF0
	private int SortCache(ITowerDefensePhantomConfig a, ITowerDefensePhantomConfig b)
	{
		return a.Id.CompareTo(b.Id);
	}

	// Token: 0x17001FBA RID: 8122
	// (get) Token: 0x06014E62 RID: 85602 RVA: 0x00614C11 File Offset: 0x00612E11
	public static TowerDefenseModel Instance
	{
		get
		{
			return TowerDefenseModel._Instance;
		}
	}

	// Token: 0x06014E63 RID: 85603 RVA: 0x00614C18 File Offset: 0x00612E18
	public static TowerDefenseModel GetOrCreateInstance()
	{
		if (TowerDefenseModel._Instance == null)
		{
			TowerDefenseModel.CreateInstance();
		}
		return TowerDefenseModel._Instance;
	}

	// Token: 0x06014E64 RID: 85604 RVA: 0x00614C2C File Offset: 0x00612E2C
	public static bool CreateInstance()
	{
		if (TowerDefenseModel._Instance != null)
		{
			return true;
		}
		TowerDefenseModel._Instance = new TowerDefenseModel();
		return true;
	}

	// Token: 0x06014E65 RID: 85605 RVA: 0x00614C42 File Offset: 0x00612E42
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06014E66 RID: 85606 RVA: 0x00614C44 File Offset: 0x00612E44
	public static void ResetStaticDefaultValue()
	{
		TowerDefenseModel._Instance = null;
	}

	// Token: 0x06014E67 RID: 85607 RVA: 0x00614C4C File Offset: 0x00612E4C
	static TowerDefenseModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TowerDefenseModel.CreateStaticDefaultValue), new Action(TowerDefenseModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400B1E8 RID: 45544
	public int CurrentSelfPhantomIdInUiTemp;

	// Token: 0x0400B1E9 RID: 45545
	[Nullable(2)]
	public TowerDefenceEndNotify DelayedEndNotify;

	// Token: 0x0400B1EA RID: 45546
	private bool? IsEnterInActivityClickedCache;

	// Token: 0x0400B1EB RID: 45547
	public bool IsPhantomViewOpened;

	// Token: 0x0400B1EC RID: 45548
	public bool IsNeedShowMainView;

	// Token: 0x0400B1ED RID: 45549
	public bool IsUiFlowOpen;

	// Token: 0x0400B1EE RID: 45550
	public ParsedTowerDefenseMsg PhantomMessageCache = new ParsedTowerDefenseMsg();

	// Token: 0x0400B1EF RID: 45551
	public List<ITowerDefensePhantomDataOwner> PhantomOwnerDataList = new List<ITowerDefensePhantomDataOwner>();

	// Token: 0x0400B1F0 RID: 45552
	public TowerDefenseRankGlobalData RankData = new TowerDefenseRankGlobalData();

	// Token: 0x0400B1F1 RID: 45553
	public Dictionary<int, int> RoleCfgId2PhantomIdMapCache = new Dictionary<int, int>();

	// Token: 0x0400B1F2 RID: 45554
	public long? SelfReviveTargetTimestampForUi;

	// Token: 0x0400B1F3 RID: 45555
	public Dictionary<int, Dictionary<int, TimerHandle>> TimerCacheInBattle = new Dictionary<int, Dictionary<int, TimerHandle>>();

	// Token: 0x0400B1F6 RID: 45558
	[Nullable(2)]
	private static TowerDefenseModel _Instance;
}
