using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Roguelike;

// Token: 0x020022C0 RID: 8896
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class WeeklyRogueModel : ModelBase
{
	// Token: 0x1700215D RID: 8541
	// (get) Token: 0x06015FA4 RID: 90020 RVA: 0x0065E8BD File Offset: 0x0065CABD
	public Dictionary<int, int> CurrencyDictMap
	{
		get
		{
			return this.CurrencyDict;
		}
	}

	// Token: 0x06015FA5 RID: 90021 RVA: 0x0065E8C5 File Offset: 0x0065CAC5
	public void SetCurrency(int id, int count)
	{
		this.CurrencyDict[id] = count;
	}

	// Token: 0x06015FA6 RID: 90022 RVA: 0x0065E8D4 File Offset: 0x0065CAD4
	public int GetCurrency(int currencyId)
	{
		int result;
		if (!this.CurrencyDict.TryGetValue(currencyId, out result))
		{
			return 0;
		}
		return result;
	}

	// Token: 0x1700215E RID: 8542
	// (get) Token: 0x06015FA7 RID: 90023 RVA: 0x0065E8F4 File Offset: 0x0065CAF4
	public int CycleId
	{
		get
		{
			WeeklyRogueData activityDataNew = this.ActivityDataNew;
			if (activityDataNew == null)
			{
				return 0;
			}
			return activityDataNew.CycleId;
		}
	}

	// Token: 0x1700215F RID: 8543
	// (get) Token: 0x06015FA8 RID: 90024 RVA: 0x0065E907 File Offset: 0x0065CB07
	// (set) Token: 0x06015FA9 RID: 90025 RVA: 0x0065E914 File Offset: 0x0065CB14
	public string CurrentRoomMusicState
	{
		get
		{
			return this.CurrentRoomMusicStateInternal.State;
		}
		set
		{
			this.CurrentRoomMusicStateInternal.State = (value ?? "none");
		}
	}

	// Token: 0x17002160 RID: 8544
	// (get) Token: 0x06015FAA RID: 90026 RVA: 0x0065E92C File Offset: 0x0065CB2C
	[Nullable(2)]
	public WeeklyRogueData ActivityDataNew
	{
		[NullableContext(2)]
		get
		{
			if (this.CurrentActivityId == 0)
			{
				return null;
			}
			WeeklyRogueData weeklyRogueData = ActivityModel.Instance.GetActivityById(this.CurrentActivityId) as WeeklyRogueData;
			if (weeklyRogueData != null && !weeklyRogueData.CheckIfInShowTime())
			{
				return null;
			}
			return weeklyRogueData;
		}
	}

	// Token: 0x17002161 RID: 8545
	// (get) Token: 0x06015FAB RID: 90027 RVA: 0x0065E968 File Offset: 0x0065CB68
	public WeeklyRogueData ActivityData
	{
		get
		{
			WeeklyRogueData weeklyRogueData = ActivityModel.Instance.GetActivityById(this.CurrentActivityId) as WeeklyRogueData;
			if (weeklyRogueData == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.WeeklyRogue;
				ELogAuthor author = ELogAuthor.YYZ;
				string message = "周常肉鸽数据未创建,请检查调用时机";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", this.CurrentActivityId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return new WeeklyRogueData();
			}
			return weeklyRogueData;
		}
	}

	// Token: 0x06015FAC RID: 90028 RVA: 0x0065E9CC File Offset: 0x0065CBCC
	public bool HasLastInfo()
	{
		WeeklyRogueData activityDataNew = this.ActivityDataNew;
		RogueWeeklyLastInfo rogueWeeklyLastInfo = (activityDataNew != null) ? activityDataNew.LastInstInfo : null;
		return rogueWeeklyLastInfo != null && rogueWeeklyLastInfo.InstId != 0;
	}

	// Token: 0x06015FAD RID: 90029 RVA: 0x0065E9FA File Offset: 0x0065CBFA
	public void ChangeDescMode()
	{
		this.DescMode = ((this.DescMode == EDescModel.SIMPLE) ? EDescModel.DETAIL : EDescModel.SIMPLE);
		EventSystem.Instance.Emit(EEventName.WeeklyRogueDescModeChange);
	}

	// Token: 0x06015FAE RID: 90030 RVA: 0x0065EA1E File Offset: 0x0065CC1E
	[NullableContext(2)]
	public RogueWeeklyOption GetCurrentOption()
	{
		return this.GetOptionByBindId(this.CurrentBindId);
	}

	// Token: 0x06015FAF RID: 90031 RVA: 0x0065EA2C File Offset: 0x0065CC2C
	[NullableContext(2)]
	public RogueWeeklyOption GetOptionByBindId(int bindId)
	{
		RogueWeeklyOption result;
		if (this.OptionMap.TryGetValue(bindId, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x06015FB0 RID: 90032 RVA: 0x0065EA4C File Offset: 0x0065CC4C
	public void UpdateInstInfo(RogueWeeklyInstInfoNotify data)
	{
		this.BuffTypeMap.Clear();
		this.BuffList.Clear();
		this.BuffList.AddRange(data.RogueWeeklyBuffs);
		this.ModifierIdInForce = data.ConfigId;
		foreach (int num in data.RogueWeeklyBuffs)
		{
			RogueWeeklyBuffPool? rogueWeeklyBuffPool = WeeklyRogueConfig.Instance.GetRogueWeeklyBuffPool(num);
			if (rogueWeeklyBuffPool != null)
			{
				List<int> list;
				if (!this.BuffTypeMap.TryGetValue((EWeeklyRogueBuffType)rogueWeeklyBuffPool.Value.BuffType, out list))
				{
					list = new List<int>();
					this.BuffTypeMap.Add((EWeeklyRogueBuffType)rogueWeeklyBuffPool.Value.BuffType, list);
				}
				list.Add(num);
			}
		}
		this.OptionMap.Clear();
		foreach (KeyValuePair<int, RogueWeeklyOption> keyValuePair in data.RogueWeeklyOptions)
		{
			this.OptionMap.Add(keyValuePair.Key, keyValuePair.Value);
		}
	}

	// Token: 0x06015FB1 RID: 90033 RVA: 0x0065EB84 File Offset: 0x0065CD84
	public List<int> GetBuffIdListByType(EWeeklyRogueBuffType type)
	{
		List<int> collection;
		if (!this.BuffTypeMap.TryGetValue(type, out collection))
		{
			return new List<int>();
		}
		return new List<int>(collection);
	}

	// Token: 0x06015FB2 RID: 90034 RVA: 0x0065EBB0 File Offset: 0x0065CDB0
	public int GetArtifactBuffId()
	{
		List<int> list;
		if (!this.BuffTypeMap.TryGetValue(EWeeklyRogueBuffType.Artifact, out list))
		{
			return 0;
		}
		return list[0];
	}

	// Token: 0x06015FB3 RID: 90035 RVA: 0x0065EBD8 File Offset: 0x0065CDD8
	public List<int> GetCoreTokenIdListByArtifactId(int artifactId)
	{
		IReadOnlyList<RogueWeeklyBuffPool> rogueWeeklyBuffPoolByRelatedArtifactId = WeeklyRogueConfig.Instance.GetRogueWeeklyBuffPoolByRelatedArtifactId(artifactId);
		List<int> list = new List<int>();
		if (rogueWeeklyBuffPoolByRelatedArtifactId != null)
		{
			foreach (RogueWeeklyBuffPool rogueWeeklyBuffPool in rogueWeeklyBuffPoolByRelatedArtifactId)
			{
				list.Add(rogueWeeklyBuffPool.Id);
			}
		}
		return list;
	}

	// Token: 0x06015FB4 RID: 90036 RVA: 0x0065EC3C File Offset: 0x0065CE3C
	public List<int> GetRogueWeeklyBuffTagIdList(int id)
	{
		List<int> list = new List<int>();
		RogueWeeklyBuffPool? rogueWeeklyBuffPool = WeeklyRogueConfig.Instance.GetRogueWeeklyBuffPool(id);
		if (rogueWeeklyBuffPool == null)
		{
			return list;
		}
		if (rogueWeeklyBuffPool.Value.BuffType == 1 && this.ModifierIdInForce != 0)
		{
			RogueWeeklyBuffPool? rogueWeeklyBuffPool2 = WeeklyRogueConfig.Instance.GetRogueWeeklyBuffPool(this.ModifierIdInForce);
			if (rogueWeeklyBuffPool2 != null && rogueWeeklyBuffPool2.Value.BuffTriggerTagId != 0)
			{
				list.Add(rogueWeeklyBuffPool2.Value.BuffTriggerTagId);
			}
		}
		else if (rogueWeeklyBuffPool.Value.BuffTriggerTagId != 0)
		{
			list.Add(rogueWeeklyBuffPool.Value.BuffTriggerTagId);
		}
		list.AddRange(rogueWeeklyBuffPool.Value.BuffTagId());
		return list;
	}

	// Token: 0x06015FB5 RID: 90037 RVA: 0x0065ED00 File Offset: 0x0065CF00
	public List<string> GetRogueWeeklyBuffDescParam(int id)
	{
		List<string> list = new List<string>();
		RogueWeeklyBuffPool? rogueWeeklyBuffPool = WeeklyRogueConfig.Instance.GetRogueWeeklyBuffPool(id);
		if (rogueWeeklyBuffPool == null)
		{
			return list;
		}
		if (id == this.GetArtifactBuffId())
		{
			int buffTriggerTagId = rogueWeeklyBuffPool.Value.BuffTriggerTagId;
			if (this.ModifierIdInForce != 0)
			{
				RogueWeeklyBuffPool? rogueWeeklyBuffPool2 = WeeklyRogueConfig.Instance.GetRogueWeeklyBuffPool(this.ModifierIdInForce);
				if (rogueWeeklyBuffPool2 != null)
				{
					buffTriggerTagId = rogueWeeklyBuffPool2.Value.BuffTriggerTagId;
				}
			}
			RogueWeekTag? rogueWeekTagConfig = WeeklyRogueConfig.Instance.GetRogueWeekTagConfig(buffTriggerTagId);
			if (rogueWeekTagConfig != null)
			{
				list.Add(rogueWeekTagConfig.Value.Name);
			}
		}
		else
		{
			list.AddRange(rogueWeeklyBuffPool.Value.BuffDescParam());
		}
		return list;
	}

	// Token: 0x06015FB6 RID: 90038 RVA: 0x0065EDBC File Offset: 0x0065CFBC
	public bool CheckIsInWeeklyRogue()
	{
		InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(CreatureModel.Instance.GetInstanceId());
		return config != null && config.GetValueOrDefault().InstSubType == 29 && GameModeController.Instance.IsInInstance();
	}

	// Token: 0x06015FB7 RID: 90039 RVA: 0x0065EE0C File Offset: 0x0065D00C
	public bool IsWeeklyRogueOpen()
	{
		int? instanceDungeonId = BattleTeamModel.Instance.Context.InstanceDungeonId;
		if (instanceDungeonId == null)
		{
			return false;
		}
		InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceDungeonId.Value);
		return config != null && config.Value.InstSubType == 29;
	}

	// Token: 0x06015FB8 RID: 90040 RVA: 0x0065EE64 File Offset: 0x0065D064
	public bool CheckIsRecommendRole(int roleId)
	{
		WeeklyRogueData activityDataNew = this.ActivityDataNew;
		RogueWeeklyCycle? rogueWeeklyCycle = (activityDataNew != null) ? activityDataNew.GetCycleConfig() : null;
		return rogueWeeklyCycle != null && Array.IndexOf<int>(rogueWeeklyCycle.Value.RecommendedRole(), roleId) >= 0;
	}

	// Token: 0x06015FB9 RID: 90041 RVA: 0x0065EEB4 File Offset: 0x0065D0B4
	public IReadOnlyList<int> GetAllRecommendRole()
	{
		WeeklyRogueData activityDataNew = this.ActivityDataNew;
		RogueWeeklyCycle? rogueWeeklyCycle = (activityDataNew != null) ? activityDataNew.GetCycleConfig() : null;
		if (rogueWeeklyCycle == null)
		{
			return new List<int>();
		}
		return rogueWeeklyCycle.Value.RecommendedRole();
	}

	// Token: 0x06015FBA RID: 90042 RVA: 0x0065EEFC File Offset: 0x0065D0FC
	public IActivityRewardViewData GetScoreRewardData()
	{
		List<IActivityRewardData> scoreDataList = new List<IActivityRewardData>();
		ActivityRewardDataPage item = new ActivityRewardDataPage
		{
			TabName = ConfigMultiTextLang.GetLocalTextNew("Text_WeeklyRogue_ScoreReward_Title", null),
			DataList = scoreDataList
		};
		WeeklyRogueData activityDataNew = this.ActivityDataNew;
		if (activityDataNew != null)
		{
			List<RogueWeeklyAward> awardsInfoList = activityDataNew.AwardsInfoList;
			if (awardsInfoList != null)
			{
				awardsInfoList.ForEach(delegate(RogueWeeklyAward awardInfo)
				{
					RogueWeeklyReward? rogueWeeklyRewardConfig = WeeklyRogueConfig.Instance.GetRogueWeeklyRewardConfig(awardInfo.ConfigId);
					if (rogueWeeklyRewardConfig == null)
					{
						return;
					}
					List<TItem> exchangeRewardPreviewRewardList = ExchangeRewardConfig.Instance.GetExchangeRewardPreviewRewardList(rogueWeeklyRewardConfig.Value.TargetReward, new int?(this.ActivityData.WorldLevel));
					EActivityRewardState scoreRewardStateById = this.ActivityData.GetScoreRewardStateById(awardInfo.ConfigId);
					int configId = awardInfo.ConfigId;
					ActivityRewardData activityRewardData = new ActivityRewardData();
					activityRewardData.Id = new int?(configId);
					activityRewardData.NameText = "";
					activityRewardData.NameTextId = "Text_WeeklyRogue_ScoreReward_ItemName";
					activityRewardData.NameTextArgs = new string[]
					{
						rogueWeeklyRewardConfig.Value.Score.ToString()
					};
					activityRewardData.RewardList = exchangeRewardPreviewRewardList.ToArray();
					activityRewardData.RewardState = this.ActivityData.GetScoreRewardStateById(configId);
					activityRewardData.RewardButtonText = this.GetPreviewButtonTextByState(scoreRewardStateById);
					activityRewardData.RewardButtonRedDot = new bool?(scoreRewardStateById == EActivityRewardState.Enable);
					activityRewardData.ClickFunction = delegate()
					{
						WeeklyRogueController instance = WeeklyRogueController.Instance;
						if (instance == null)
						{
							return;
						}
						instance.MultiRogueWeeklyRewardRequest();
					};
					ActivityRewardData item2 = activityRewardData;
					scoreDataList.Add(item2);
				});
			}
		}
		return new ActivityRewardViewData
		{
			DataPageList = new List<IActivityRewardDataPage>
			{
				item
			},
			Source = EActivityRewardSource.WeeklyRogue
		};
	}

	// Token: 0x06015FBB RID: 90043 RVA: 0x0065EF90 File Offset: 0x0065D190
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

	// Token: 0x06015FBC RID: 90044 RVA: 0x0065EFF8 File Offset: 0x0065D1F8
	public bool GetMapNoteShowState()
	{
		WeeklyRogueData activityDataNew = this.ActivityDataNew;
		return activityDataNew != null && activityDataNew.IsUnLock() && !activityDataNew.IsScoreRewardAllDone();
	}

	// Token: 0x06015FBD RID: 90045 RVA: 0x0065F028 File Offset: 0x0065D228
	[NullableContext(2)]
	public List<int> GetRewardIdsByDifficulties(bool isCanReceive)
	{
		WeeklyRogueData activityDataNew = this.ActivityDataNew;
		if (((activityDataNew != null) ? activityDataNew.AwardsInfoList : null) == null)
		{
			return null;
		}
		List<int> list = new List<int>();
		foreach (RogueWeeklyAward rogueWeeklyAward in this.ActivityDataNew.AwardsInfoList)
		{
			if (rogueWeeklyAward.SignState == (isCanReceive ? SignState.Unlock : SignState.IsReceive))
			{
				list.Add(rogueWeeklyAward.ConfigId);
			}
		}
		return list;
	}

	// Token: 0x17002162 RID: 8546
	// (get) Token: 0x06015FBE RID: 90046 RVA: 0x0065F0B4 File Offset: 0x0065D2B4
	public static WeeklyRogueModel Instance
	{
		get
		{
			return WeeklyRogueModel._Instance;
		}
	}

	// Token: 0x06015FBF RID: 90047 RVA: 0x0065F0BB File Offset: 0x0065D2BB
	public static WeeklyRogueModel GetOrCreateInstance()
	{
		if (WeeklyRogueModel._Instance == null)
		{
			WeeklyRogueModel.CreateInstance();
		}
		return WeeklyRogueModel._Instance;
	}

	// Token: 0x06015FC0 RID: 90048 RVA: 0x0065F0CF File Offset: 0x0065D2CF
	public static bool CreateInstance()
	{
		if (WeeklyRogueModel._Instance != null)
		{
			return true;
		}
		WeeklyRogueModel._Instance = new WeeklyRogueModel();
		return true;
	}

	// Token: 0x06015FC1 RID: 90049 RVA: 0x0065F0E5 File Offset: 0x0065D2E5
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06015FC2 RID: 90050 RVA: 0x0065F0E7 File Offset: 0x0065D2E7
	public static void ResetStaticDefaultValue()
	{
		WeeklyRogueModel._Instance = null;
	}

	// Token: 0x06015FC3 RID: 90051 RVA: 0x0065F0EF File Offset: 0x0065D2EF
	static WeeklyRogueModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(WeeklyRogueModel.CreateStaticDefaultValue), new Action(WeeklyRogueModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400B89B RID: 47259
	public List<int> BuffList = new List<int>();

	// Token: 0x0400B89C RID: 47260
	private readonly Dictionary<EWeeklyRogueBuffType, List<int>> BuffTypeMap = new Dictionary<EWeeklyRogueBuffType, List<int>>();

	// Token: 0x0400B89D RID: 47261
	public int ModifierIdInForce;

	// Token: 0x0400B89E RID: 47262
	public Dictionary<int, RogueWeeklyOption> OptionMap = new Dictionary<int, RogueWeeklyOption>();

	// Token: 0x0400B89F RID: 47263
	private readonly Dictionary<int, int> CurrencyDict = new Dictionary<int, int>();

	// Token: 0x0400B8A0 RID: 47264
	public int CurrentLayer;

	// Token: 0x0400B8A1 RID: 47265
	public int MaxLayer;

	// Token: 0x0400B8A2 RID: 47266
	public int CurrentBindId;

	// Token: 0x0400B8A3 RID: 47267
	public string CurrentRoomTypeId = "";

	// Token: 0x0400B8A4 RID: 47268
	public int CurrentRoomId;

	// Token: 0x0400B8A5 RID: 47269
	public int CurrentRoomType;

	// Token: 0x0400B8A6 RID: 47270
	public int CurrentScore;

	// Token: 0x0400B8A7 RID: 47271
	public EDescModel DescMode;

	// Token: 0x0400B8A8 RID: 47272
	public List<int> SelectRoleIdList = new List<int>();

	// Token: 0x0400B8A9 RID: 47273
	[Nullable(2)]
	public RogueWeeklyEntry SelectEntry;

	// Token: 0x0400B8AA RID: 47274
	public int CurrentActivityId;

	// Token: 0x0400B8AB RID: 47275
	public bool IsOpenedViewByWorld;

	// Token: 0x0400B8AC RID: 47276
	private readonly StateRef CurrentRoomMusicStateInternal = new StateRef("game_rogue_room_type", "none");

	// Token: 0x0400B8AD RID: 47277
	[Nullable(2)]
	private static WeeklyRogueModel _Instance;
}
