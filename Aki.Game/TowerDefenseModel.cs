using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.TowerDefence;
using CSharpScript.Module.InstanceDungeon;

// Token: 0x02002BC0 RID: 11200
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class TowerDefenseModel : ModelBase
{
	// Token: 0x17001F5F RID: 8031
	// (get) Token: 0x060173FE RID: 95230 RVA: 0x005E63EC File Offset: 0x005E45EC
	// (set) Token: 0x060173FF RID: 95231 RVA: 0x005E644C File Offset: 0x005E464C
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

	// Token: 0x17001F60 RID: 8032
	// (get) Token: 0x06017400 RID: 95232 RVA: 0x005E648B File Offset: 0x005E468B
	public Dictionary<int, ITowerDefensePhantomConfig> PhantomConfigCache { get; } = new Dictionary<int, ITowerDefensePhantomConfig>();

	// Token: 0x17001F61 RID: 8033
	// (get) Token: 0x06017401 RID: 95233 RVA: 0x005E6493 File Offset: 0x005E4693
	public List<ITowerDefensePhantomConfig> SortedPhantomConfigCache { get; } = new List<ITowerDefensePhantomConfig>();

	// Token: 0x06017402 RID: 95234 RVA: 0x005E649C File Offset: 0x005E469C
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

	// Token: 0x06017403 RID: 95235 RVA: 0x005E65D0 File Offset: 0x005E47D0
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

	// Token: 0x06017404 RID: 95236 RVA: 0x005E6628 File Offset: 0x005E4828
	public List<ITowerDefensePhantomConfigSkillData> GetCurrentPhantomSkillCfgListInBattle()
	{
		int currentPhantomIdInBattle = this.GetCurrentPhantomIdInBattle();
		return this.GetCurrentPhantomSkillCfgCore(currentPhantomIdInBattle);
	}

	// Token: 0x06017405 RID: 95237 RVA: 0x005E6644 File Offset: 0x005E4844
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public List<string> GetCurrentPhantomSkillDescriptionArgsInBattle()
	{
		int currentPhantomIdInBattle = this.GetCurrentPhantomIdInBattle();
		string[] phantomSkillDescriptionArgsByPhantomId = TowerDefenseController.Instance.GetPhantomSkillDescriptionArgsByPhantomId(currentPhantomIdInBattle);
		if (phantomSkillDescriptionArgsByPhantomId == null)
		{
			return null;
		}
		return phantomSkillDescriptionArgsByPhantomId.ToList<string>();
	}

	// Token: 0x06017406 RID: 95238 RVA: 0x005E6670 File Offset: 0x005E4870
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

	// Token: 0x06017407 RID: 95239 RVA: 0x005E66A4 File Offset: 0x005E48A4
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

	// Token: 0x06017408 RID: 95240 RVA: 0x005E6814 File Offset: 0x005E4A14
	public string GetCurrentPhantomNameTextId()
	{
		TowerDefencePhantom? config = ConfigTowerDefencePhantomById.GetConfig(this.GetCurrentPhantomIdInBattle(), true);
		if (config != null)
		{
			return config.Value.PhantomName;
		}
		return "";
	}

	// Token: 0x06017409 RID: 95241 RVA: 0x005E684C File Offset: 0x005E4A4C
	public List<ITowerDefensePhantomConfigSkillData> GetCurrentPhantomSkillCfgTemp()
	{
		return this.GetCurrentPhantomSkillCfgCore(this.CurrentSelfPhantomIdInUiTemp);
	}

	// Token: 0x0601740A RID: 95242 RVA: 0x005E685A File Offset: 0x005E4A5A
	public ParsedTowerDefenseMsg GetOrCreateParsedTowerDefenseMsg()
	{
		if (this.PhantomMessageCache == null)
		{
			this.PhantomMessageCache = new ParsedTowerDefenseMsg();
		}
		return this.PhantomMessageCache;
	}

	// Token: 0x0601740B RID: 95243 RVA: 0x005E6878 File Offset: 0x005E4A78
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

	// Token: 0x0601740C RID: 95244 RVA: 0x005E690C File Offset: 0x005E4B0C
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

	// Token: 0x0601740D RID: 95245 RVA: 0x005E69FC File Offset: 0x005E4BFC
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

	// Token: 0x0601740E RID: 95246 RVA: 0x005E6FE8 File Offset: 0x005E51E8
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

	// Token: 0x0601740F RID: 95247 RVA: 0x005E7070 File Offset: 0x005E5270
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

	// Token: 0x06017410 RID: 95248 RVA: 0x005E7114 File Offset: 0x005E5314
	private string BuildScoreProgressText(int requiredScore, int current = -1)
	{
		int value = Math.Min((current < 0) ? this.PhantomMessageCache.TotalScore : current, requiredScore);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
		defaultInterpolatedStringHandler.AppendFormatted<int>(value);
		defaultInterpolatedStringHandler.AppendLiteral("/");
		defaultInterpolatedStringHandler.AppendFormatted<int>(requiredScore);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06017411 RID: 95249 RVA: 0x005E7168 File Offset: 0x005E5368
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

	// Token: 0x06017412 RID: 95250 RVA: 0x005E71CC File Offset: 0x005E53CC
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

	// Token: 0x06017413 RID: 95251 RVA: 0x005E7234 File Offset: 0x005E5434
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

	// Token: 0x06017414 RID: 95252 RVA: 0x005E72F8 File Offset: 0x005E54F8
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

	// Token: 0x06017415 RID: 95253 RVA: 0x005E7364 File Offset: 0x005E5564
	public void ResetPhantomOwnerDataByIndex(int index)
	{
		this.PhantomOwnerDataList[index].PlayerId = (long)PlayerInfoModel.Instance.GetId().Value;
		this.PhantomOwnerDataList[index].IsSelf = true;
		this.PhantomOwnerDataList[index].RoleCfgId = 0;
		this.PhantomOwnerDataList[index].RoleSkinId = 0;
		this.PhantomOwnerDataList[index].PhantomId = 0;
	}

	// Token: 0x06017416 RID: 95254 RVA: 0x005E73E0 File Offset: 0x005E55E0
	public void ResetAllCache()
	{
		this.CurrentSelfPhantomIdInUiTemp = 0;
		for (int i = 0; i < this.PhantomOwnerDataList.Count; i++)
		{
			this.ResetPhantomOwnerDataByIndex(i);
		}
		this.RoleCfgId2PhantomIdMapCache.Clear();
	}

	// Token: 0x06017417 RID: 95255 RVA: 0x005E741C File Offset: 0x005E561C
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

	// Token: 0x06017418 RID: 95256 RVA: 0x005E7474 File Offset: 0x005E5674
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

	// Token: 0x06017419 RID: 95257 RVA: 0x005E7520 File Offset: 0x005E5720
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

	// Token: 0x0601741A RID: 95258 RVA: 0x005E75DC File Offset: 0x005E57DC
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

	// Token: 0x0601741B RID: 95259 RVA: 0x005E7694 File Offset: 0x005E5894
	public bool CheckHasReward()
	{
		return this.CheckHasPassReward() || this.CheckHasScoreReward();
	}

	// Token: 0x0601741C RID: 95260 RVA: 0x005E76A8 File Offset: 0x005E58A8
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

	// Token: 0x0601741D RID: 95261 RVA: 0x005E7734 File Offset: 0x005E5934
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

	// Token: 0x0601741E RID: 95262 RVA: 0x005E77AC File Offset: 0x005E59AC
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

	// Token: 0x0601741F RID: 95263 RVA: 0x005E7854 File Offset: 0x005E5A54
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

	// Token: 0x06017420 RID: 95264 RVA: 0x005E78CC File Offset: 0x005E5ACC
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

	// Token: 0x06017421 RID: 95265 RVA: 0x005E7904 File Offset: 0x005E5B04
	public bool CheckTowerDefenseInstanceHasRedDot(int instanceId)
	{
		TowerDefenceInstance? towerDefenceInstance;
		int num = (ConfigTowerDefenceInstanceByInstanceId.GetConfig(instanceId, true) != null) ? towerDefenceInstance.GetValueOrDefault().Id : 0;
		return num > 0 && TowerDefenseController.Instance.CheckStageUnlockById(num) && !this.CheckLevelHasClickByInstanceId(instanceId);
	}

	// Token: 0x06017422 RID: 95266 RVA: 0x005E7954 File Offset: 0x005E5B54
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

	// Token: 0x06017423 RID: 95267 RVA: 0x005E7A40 File Offset: 0x005E5C40
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

	// Token: 0x06017424 RID: 95268 RVA: 0x005E7ADC File Offset: 0x005E5CDC
	public bool CheckPhantomAvailableInActivityByActivityId(int id)
	{
		return id == this.PhantomMessageCache.Id;
	}

	// Token: 0x06017425 RID: 95269 RVA: 0x005E7AEC File Offset: 0x005E5CEC
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

	// Token: 0x06017426 RID: 95270 RVA: 0x005E7B53 File Offset: 0x005E5D53
	public bool CheckPhantomIsOccupied(int id)
	{
		return false;
	}

	// Token: 0x06017427 RID: 95271 RVA: 0x005E7B58 File Offset: 0x005E5D58
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

	// Token: 0x06017428 RID: 95272 RVA: 0x005E7BC0 File Offset: 0x005E5DC0
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

	// Token: 0x06017429 RID: 95273 RVA: 0x005E7C24 File Offset: 0x005E5E24
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

	// Token: 0x0601742A RID: 95274 RVA: 0x005E7CC8 File Offset: 0x005E5EC8
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

	// Token: 0x0601742B RID: 95275 RVA: 0x005E7D38 File Offset: 0x005E5F38
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

	// Token: 0x0601742C RID: 95276 RVA: 0x005E7DBC File Offset: 0x005E5FBC
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

	// Token: 0x0601742D RID: 95277 RVA: 0x005E7E25 File Offset: 0x005E6025
	protected override bool OnInit()
	{
		this.ParseTowerDefensePhantomCfg();
		this.ResetCurrentPhantomIdInUiTempToFirstAvailable();
		this.ResetPhantomOwnerDataList();
		return true;
	}

	// Token: 0x0601742E RID: 95278 RVA: 0x005E7E3A File Offset: 0x005E603A
	protected override bool OnLeaveLevel()
	{
		this.PhantomMessageCache.OwnPhantomInBattleDataCache.Clear();
		return true;
	}

	// Token: 0x0601742F RID: 95279 RVA: 0x005E7E50 File Offset: 0x005E6050
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

	// Token: 0x06017430 RID: 95280 RVA: 0x005E8024 File Offset: 0x005E6224
	private int SortCache(ITowerDefensePhantomConfig a, ITowerDefensePhantomConfig b)
	{
		return a.Id.CompareTo(b.Id);
	}

	// Token: 0x17001F62 RID: 8034
	// (get) Token: 0x06017431 RID: 95281 RVA: 0x005E8045 File Offset: 0x005E6245
	public static TowerDefenseModel Instance
	{
		get
		{
			return TowerDefenseModel._Instance;
		}
	}

	// Token: 0x06017432 RID: 95282 RVA: 0x005E804C File Offset: 0x005E624C
	public static TowerDefenseModel GetOrCreateInstance()
	{
		if (TowerDefenseModel._Instance == null)
		{
			TowerDefenseModel.CreateInstance();
		}
		return TowerDefenseModel._Instance;
	}

	// Token: 0x06017433 RID: 95283 RVA: 0x005E8060 File Offset: 0x005E6260
	public static bool CreateInstance()
	{
		if (TowerDefenseModel._Instance != null)
		{
			return true;
		}
		TowerDefenseModel._Instance = new TowerDefenseModel();
		return true;
	}

	// Token: 0x06017434 RID: 95284 RVA: 0x005E8076 File Offset: 0x005E6276
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06017435 RID: 95285 RVA: 0x005E8078 File Offset: 0x005E6278
	public static void ResetStaticDefaultValue()
	{
		TowerDefenseModel._Instance = null;
	}

	// Token: 0x06017436 RID: 95286 RVA: 0x005E8080 File Offset: 0x005E6280
	static TowerDefenseModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TowerDefenseModel.CreateStaticDefaultValue), new Action(TowerDefenseModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400ADE3 RID: 44515
	public int CurrentSelfPhantomIdInUiTemp;

	// Token: 0x0400ADE4 RID: 44516
	[Nullable(2)]
	public TowerDefenceEndNotify DelayedEndNotify;

	// Token: 0x0400ADE5 RID: 44517
	private bool? IsEnterInActivityClickedCache;

	// Token: 0x0400ADE6 RID: 44518
	public bool IsPhantomViewOpened;

	// Token: 0x0400ADE7 RID: 44519
	public bool IsNeedShowMainView;

	// Token: 0x0400ADE8 RID: 44520
	public bool IsUiFlowOpen;

	// Token: 0x0400ADE9 RID: 44521
	public ParsedTowerDefenseMsg PhantomMessageCache = new ParsedTowerDefenseMsg();

	// Token: 0x0400ADEA RID: 44522
	public List<ITowerDefensePhantomDataOwner> PhantomOwnerDataList = new List<ITowerDefensePhantomDataOwner>();

	// Token: 0x0400ADEB RID: 44523
	public TowerDefenseRankGlobalData RankData = new TowerDefenseRankGlobalData();

	// Token: 0x0400ADEC RID: 44524
	public Dictionary<int, int> RoleCfgId2PhantomIdMapCache = new Dictionary<int, int>();

	// Token: 0x0400ADED RID: 44525
	public long? SelfReviveTargetTimestampForUi;

	// Token: 0x0400ADEE RID: 44526
	public Dictionary<int, Dictionary<int, TimerHandle>> TimerCacheInBattle = new Dictionary<int, Dictionary<int, TimerHandle>>();

	// Token: 0x0400ADF1 RID: 44529
	[Nullable(2)]
	private static TowerDefenseModel _Instance;
}
