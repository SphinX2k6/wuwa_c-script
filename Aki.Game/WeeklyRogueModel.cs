using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Roguelike;

// Token: 0x02002D66 RID: 11622
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class WeeklyRogueModel : ModelBase
{
	// Token: 0x17002102 RID: 8450
	// (get) Token: 0x06018702 RID: 100098 RVA: 0x006388AD File Offset: 0x00636AAD
	public Dictionary<int, int> CurrencyDictMap
	{
		get
		{
			return this.CurrencyDict;
		}
	}

	// Token: 0x06018703 RID: 100099 RVA: 0x006388B5 File Offset: 0x00636AB5
	public void SetCurrency(int id, int count)
	{
		this.CurrencyDict[id] = count;
	}

	// Token: 0x06018704 RID: 100100 RVA: 0x006388C4 File Offset: 0x00636AC4
	public int GetCurrency(int currencyId)
	{
		int result;
		if (!this.CurrencyDict.TryGetValue(currencyId, out result))
		{
			return 0;
		}
		return result;
	}

	// Token: 0x17002103 RID: 8451
	// (get) Token: 0x06018705 RID: 100101 RVA: 0x006388E4 File Offset: 0x00636AE4
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

	// Token: 0x17002104 RID: 8452
	// (get) Token: 0x06018706 RID: 100102 RVA: 0x006388F7 File Offset: 0x00636AF7
	// (set) Token: 0x06018707 RID: 100103 RVA: 0x00638904 File Offset: 0x00636B04
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

	// Token: 0x17002105 RID: 8453
	// (get) Token: 0x06018708 RID: 100104 RVA: 0x0063891C File Offset: 0x00636B1C
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

	// Token: 0x17002106 RID: 8454
	// (get) Token: 0x06018709 RID: 100105 RVA: 0x00638958 File Offset: 0x00636B58
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

	// Token: 0x0601870A RID: 100106 RVA: 0x006389BC File Offset: 0x00636BBC
	public bool HasLastInfo()
	{
		WeeklyRogueData activityDataNew = this.ActivityDataNew;
		RogueWeeklyLastInfo rogueWeeklyLastInfo = (activityDataNew != null) ? activityDataNew.LastInstInfo : null;
		return rogueWeeklyLastInfo != null && rogueWeeklyLastInfo.InstId != 0;
	}

	// Token: 0x0601870B RID: 100107 RVA: 0x006389EA File Offset: 0x00636BEA
	public void ChangeDescMode()
	{
		this.DescMode = ((this.DescMode == EDescModel.SIMPLE) ? EDescModel.DETAIL : EDescModel.SIMPLE);
		EventSystem.Instance.Emit(EEventName.WeeklyRogueDescModeChange);
	}

	// Token: 0x0601870C RID: 100108 RVA: 0x00638A0E File Offset: 0x00636C0E
	[NullableContext(2)]
	public RogueWeeklyOption GetCurrentOption()
	{
		return this.GetOptionByBindId(this.CurrentBindId);
	}

	// Token: 0x0601870D RID: 100109 RVA: 0x00638A1C File Offset: 0x00636C1C
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

	// Token: 0x0601870E RID: 100110 RVA: 0x00638A3C File Offset: 0x00636C3C
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

	// Token: 0x0601870F RID: 100111 RVA: 0x00638B74 File Offset: 0x00636D74
	public List<int> GetBuffIdListByType(EWeeklyRogueBuffType type)
	{
		List<int> collection;
		if (!this.BuffTypeMap.TryGetValue(type, out collection))
		{
			return new List<int>();
		}
		return new List<int>(collection);
	}

	// Token: 0x06018710 RID: 100112 RVA: 0x00638BA0 File Offset: 0x00636DA0
	public int GetArtifactBuffId()
	{
		List<int> list;
		if (!this.BuffTypeMap.TryGetValue(EWeeklyRogueBuffType.Artifact, out list))
		{
			return 0;
		}
		return list[0];
	}

	// Token: 0x06018711 RID: 100113 RVA: 0x00638BC8 File Offset: 0x00636DC8
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

	// Token: 0x06018712 RID: 100114 RVA: 0x00638C2C File Offset: 0x00636E2C
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

	// Token: 0x06018713 RID: 100115 RVA: 0x00638CF0 File Offset: 0x00636EF0
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

	// Token: 0x06018714 RID: 100116 RVA: 0x00638DAC File Offset: 0x00636FAC
	public bool CheckIsInWeeklyRogue()
	{
		InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(CreatureModel.Instance.GetInstanceId());
		return config != null && config.GetValueOrDefault().InstSubType == 29 && GameModeController.Instance.IsInInstance();
	}

	// Token: 0x06018715 RID: 100117 RVA: 0x00638DFC File Offset: 0x00636FFC
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

	// Token: 0x06018716 RID: 100118 RVA: 0x00638E54 File Offset: 0x00637054
	public bool CheckIsRecommendRole(int roleId)
	{
		WeeklyRogueData activityDataNew = this.ActivityDataNew;
		RogueWeeklyCycle? rogueWeeklyCycle = (activityDataNew != null) ? activityDataNew.GetCycleConfig() : null;
		return rogueWeeklyCycle != null && rogueWeeklyCycle.Value.RecommendedRole().Contains(roleId);
	}

	// Token: 0x06018717 RID: 100119 RVA: 0x00638E9C File Offset: 0x0063709C
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

	// Token: 0x06018718 RID: 100120 RVA: 0x00638EE4 File Offset: 0x006370E4
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

	// Token: 0x06018719 RID: 100121 RVA: 0x00638F78 File Offset: 0x00637178
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

	// Token: 0x0601871A RID: 100122 RVA: 0x00638FE0 File Offset: 0x006371E0
	public bool GetMapNoteShowState()
	{
		WeeklyRogueData activityDataNew = this.ActivityDataNew;
		return activityDataNew != null && activityDataNew.IsUnLock() && !activityDataNew.IsScoreRewardAllDone();
	}

	// Token: 0x0601871B RID: 100123 RVA: 0x00639010 File Offset: 0x00637210
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

	// Token: 0x17002107 RID: 8455
	// (get) Token: 0x0601871C RID: 100124 RVA: 0x0063909C File Offset: 0x0063729C
	public static WeeklyRogueModel Instance
	{
		get
		{
			return WeeklyRogueModel._Instance;
		}
	}

	// Token: 0x0601871D RID: 100125 RVA: 0x006390A3 File Offset: 0x006372A3
	public static WeeklyRogueModel GetOrCreateInstance()
	{
		if (WeeklyRogueModel._Instance == null)
		{
			WeeklyRogueModel.CreateInstance();
		}
		return WeeklyRogueModel._Instance;
	}

	// Token: 0x0601871E RID: 100126 RVA: 0x006390B7 File Offset: 0x006372B7
	public static bool CreateInstance()
	{
		if (WeeklyRogueModel._Instance != null)
		{
			return true;
		}
		WeeklyRogueModel._Instance = new WeeklyRogueModel();
		return true;
	}

	// Token: 0x0601871F RID: 100127 RVA: 0x006390CD File Offset: 0x006372CD
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06018720 RID: 100128 RVA: 0x006390CF File Offset: 0x006372CF
	public static void ResetStaticDefaultValue()
	{
		WeeklyRogueModel._Instance = null;
	}

	// Token: 0x06018721 RID: 100129 RVA: 0x006390D7 File Offset: 0x006372D7
	static WeeklyRogueModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(WeeklyRogueModel.CreateStaticDefaultValue), new Action(WeeklyRogueModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400B526 RID: 46374
	public List<int> BuffList = new List<int>();

	// Token: 0x0400B527 RID: 46375
	private readonly Dictionary<EWeeklyRogueBuffType, List<int>> BuffTypeMap = new Dictionary<EWeeklyRogueBuffType, List<int>>();

	// Token: 0x0400B528 RID: 46376
	public int ModifierIdInForce;

	// Token: 0x0400B529 RID: 46377
	public Dictionary<int, RogueWeeklyOption> OptionMap = new Dictionary<int, RogueWeeklyOption>();

	// Token: 0x0400B52A RID: 46378
	private readonly Dictionary<int, int> CurrencyDict = new Dictionary<int, int>();

	// Token: 0x0400B52B RID: 46379
	public int CurrentLayer;

	// Token: 0x0400B52C RID: 46380
	public int MaxLayer;

	// Token: 0x0400B52D RID: 46381
	public int CurrentBindId;

	// Token: 0x0400B52E RID: 46382
	public string CurrentRoomTypeId = "";

	// Token: 0x0400B52F RID: 46383
	public int CurrentRoomId;

	// Token: 0x0400B530 RID: 46384
	public int CurrentRoomType;

	// Token: 0x0400B531 RID: 46385
	public int CurrentScore;

	// Token: 0x0400B532 RID: 46386
	public EDescModel DescMode;

	// Token: 0x0400B533 RID: 46387
	public List<int> SelectRoleIdList = new List<int>();

	// Token: 0x0400B534 RID: 46388
	[Nullable(2)]
	public RogueWeeklyEntry SelectEntry;

	// Token: 0x0400B535 RID: 46389
	public int CurrentActivityId;

	// Token: 0x0400B536 RID: 46390
	public bool IsOpenedViewByWorld;

	// Token: 0x0400B537 RID: 46391
	private readonly StateRef CurrentRoomMusicStateInternal = new StateRef("game_rogue_room_type", "none");

	// Token: 0x0400B538 RID: 46392
	[Nullable(2)]
	private static WeeklyRogueModel _Instance;
}
