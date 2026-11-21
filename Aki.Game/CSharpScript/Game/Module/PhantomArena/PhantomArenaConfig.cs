using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x020040D4 RID: 16596
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class PhantomArenaConfig : ConfigBase
	{
		// Token: 0x06029FAA RID: 171946 RVA: 0x00BDF144 File Offset: 0x00BDD344
		public PhantomBattleCard GetPhantomBattleCardConfig(int configId)
		{
			return ConfigPhantomBattleCardById.GetConfig(configId, true).Value;
		}

		// Token: 0x06029FAB RID: 171947 RVA: 0x00BDF160 File Offset: 0x00BDD360
		public IReadOnlyList<PhantomBattleCard> GetPhantomBattleCardByActivityId(int activityId)
		{
			return ConfigPhantomBattleCardByActivityId.GetConfigList(activityId, true);
		}

		// Token: 0x06029FAC RID: 171948 RVA: 0x00BDF169 File Offset: 0x00BDD369
		public IReadOnlyList<PhantomBattleCard> GetAllPhantomBattleCard()
		{
			return ConfigPhantomBattleCardAll.GetConfigList(true);
		}

		// Token: 0x06029FAD RID: 171949 RVA: 0x00BDF174 File Offset: 0x00BDD374
		public PhantomBattleSkill GetPhantomBattleSkillConfig(int skillConfigId)
		{
			return ConfigPhantomBattleSkillById.GetConfig(skillConfigId, true).Value;
		}

		// Token: 0x06029FAE RID: 171950 RVA: 0x00BDF190 File Offset: 0x00BDD390
		public PhantomBattleBuff GetPhantomBattleBuffConfig(int buffConfigId)
		{
			return ConfigPhantomBattleBuffById.GetConfig(buffConfigId, true).Value;
		}

		// Token: 0x06029FAF RID: 171951 RVA: 0x00BDF1AC File Offset: 0x00BDD3AC
		public PhantomBattleFactor GetPhantomBattleFactorConfig(int factorConfigId)
		{
			return ConfigPhantomBattleFactorById.GetConfig(factorConfigId, true).Value;
		}

		// Token: 0x06029FB0 RID: 171952 RVA: 0x00BDF1C8 File Offset: 0x00BDD3C8
		public IReadOnlyList<PhantomBattleFactor> GetPhantomBattleAllFactor()
		{
			return ConfigPhantomBattleFactorAll.GetConfigList(true);
		}

		// Token: 0x06029FB1 RID: 171953 RVA: 0x00BDF1D0 File Offset: 0x00BDD3D0
		public PhantomBattleEntry GetPhantomBattleEntryConfig(int entryId)
		{
			return ConfigPhantomBattleEntryById.GetConfig(entryId, true).Value;
		}

		// Token: 0x06029FB2 RID: 171954 RVA: 0x00BDF1EC File Offset: 0x00BDD3EC
		public PhantomBattleCardElement GetPhantomBattleElementConfig(int elementId)
		{
			return ConfigPhantomBattleCardElementById.GetConfig(elementId, true).Value;
		}

		// Token: 0x06029FB3 RID: 171955 RVA: 0x00BDF208 File Offset: 0x00BDD408
		public PhantomBattleCardEffect GetPhantomBattleEffectConfig(int id)
		{
			return ConfigPhantomBattleCardEffectById.GetConfig(id, true).Value;
		}

		// Token: 0x06029FB4 RID: 171956 RVA: 0x00BDF224 File Offset: 0x00BDD424
		public IReadOnlyList<PhantomBattleCardFilter> GetAllPhantomBattleCardFilter()
		{
			return ConfigPhantomBattleCardFilterAll.GetConfigList(true);
		}

		// Token: 0x06029FB5 RID: 171957 RVA: 0x00BDF22C File Offset: 0x00BDD42C
		public PhantomBattleCardFilter GetPhantomBattleCardFilter(int filterId)
		{
			return ConfigPhantomBattleCardFilterById.GetConfig(filterId, true).Value;
		}

		// Token: 0x06029FB6 RID: 171958 RVA: 0x00BDF248 File Offset: 0x00BDD448
		public IReadOnlyList<PhantomBattleCardSlotSort> GetAllPhantomBattleCardSlotSort()
		{
			return ConfigPhantomBattleCardSlotSortAll.GetConfigList(true);
		}

		// Token: 0x06029FB7 RID: 171959 RVA: 0x00BDF250 File Offset: 0x00BDD450
		public PhantomBattleCardSlotSort GetPhantomBattleCardSlotSort(int sortId)
		{
			return ConfigPhantomBattleCardSlotSortById.GetConfig(sortId, true).Value;
		}

		// Token: 0x06029FB8 RID: 171960 RVA: 0x00BDF26C File Offset: 0x00BDD46C
		public PhantomBattleActivity GetPhantomBattleActivityConfig(int activityId)
		{
			return ConfigPhantomBattleActivityByActivityId.GetConfig(activityId, true).Value;
		}

		// Token: 0x06029FB9 RID: 171961 RVA: 0x00BDF288 File Offset: 0x00BDD488
		public PhantomBattleChallenge GetPhantomBattleChallenge(int challengeId)
		{
			return ConfigPhantomBattleChallengeById.GetConfig(challengeId, true).Value;
		}

		// Token: 0x06029FBA RID: 171962 RVA: 0x00BDF2A4 File Offset: 0x00BDD4A4
		public IReadOnlyList<PhantomBattleBadge> GetAllPhantomBattleBadge()
		{
			return ConfigPhantomBattleBadgeAll.GetConfigList(true);
		}

		// Token: 0x06029FBB RID: 171963 RVA: 0x00BDF2AC File Offset: 0x00BDD4AC
		public PhantomBattleBadge GetPhantomBattleBadgeById(int badgeId)
		{
			return ConfigPhantomBattleBadgeById.GetConfig(badgeId, true).Value;
		}

		// Token: 0x06029FBC RID: 171964 RVA: 0x00BDF2C8 File Offset: 0x00BDD4C8
		public int GetPhantomBattleBadgeGroupIdById(int badgeId)
		{
			return this.GetPhantomBattleBadgeById(badgeId).GroupId;
		}

		// Token: 0x06029FBD RID: 171965 RVA: 0x00BDF2E4 File Offset: 0x00BDD4E4
		public PhantomBattleBadgeGroup GetPhantomBattleBadgeGroupById(int groupId)
		{
			return ConfigPhantomBattleBadgeGroupByGroupId.GetConfig(groupId, true).Value;
		}

		// Token: 0x06029FBE RID: 171966 RVA: 0x00BDF300 File Offset: 0x00BDD500
		public PhantomBattleMasterTitle GetPhantomBattleMasterTitleById(int titleId)
		{
			return ConfigPhantomBattleMasterTitleById.GetConfig(titleId, true).Value;
		}

		// Token: 0x06029FBF RID: 171967 RVA: 0x00BDF31C File Offset: 0x00BDD51C
		public List<int> GetCardSkillList(PhantomBattleCard cardConfig, bool withActive, bool withPassive)
		{
			List<int> list = new List<int>();
			if (withActive)
			{
				int activeSkillId = cardConfig.ActiveSkillId;
				if (activeSkillId > 0)
				{
					list.Add(activeSkillId);
				}
			}
			if (withPassive)
			{
				list.AddRange(cardConfig.GetPassiveSkillIdBytes());
			}
			return list;
		}

		// Token: 0x06029FC0 RID: 171968 RVA: 0x00BDF35C File Offset: 0x00BDD55C
		public PhantomBattleCardRole GetPhantomBattleCardRole(int id)
		{
			return ConfigPhantomBattleCardRoleById.GetConfig(id, true).Value;
		}

		// Token: 0x06029FC1 RID: 171969 RVA: 0x00BDF378 File Offset: 0x00BDD578
		public IReadOnlyList<PhantomBattleCardRole> GetPhantomBattleCardRoleByActivityId(int activityId)
		{
			return ConfigPhantomBattleCardRoleByActivityId.GetConfigList(activityId, true);
		}

		// Token: 0x06029FC2 RID: 171970 RVA: 0x00BDF381 File Offset: 0x00BDD581
		public string GetDeckDefaultName()
		{
			return ConfigMultiTextLang.GetLocalTextNew("PhantomBattle_1038", null);
		}

		// Token: 0x06029FC3 RID: 171971 RVA: 0x00BDF390 File Offset: 0x00BDD590
		public PhantomBattleNPC GetPhantomBattleNpc(int id)
		{
			return ConfigPhantomBattleNPCById.GetConfig(id, true).Value;
		}

		// Token: 0x06029FC4 RID: 171972 RVA: 0x00BDF3AC File Offset: 0x00BDD5AC
		public IReadOnlyList<PhantomBattleNPC> GetPhantomBattleNpcList(int npcGroupId)
		{
			return ConfigPhantomBattleNPCByGroupId.GetConfigList(npcGroupId, true);
		}

		// Token: 0x06029FC5 RID: 171973 RVA: 0x00BDF3B5 File Offset: 0x00BDD5B5
		public IReadOnlyList<PhantomBattleCardGroup> GetCardListByDeckConfigId(int deckConfigId)
		{
			return ConfigPhantomBattleCardGroupByGroupId.GetConfigList(deckConfigId, true);
		}

		// Token: 0x06029FC6 RID: 171974 RVA: 0x00BDF3C0 File Offset: 0x00BDD5C0
		public PhantomBattleCardGroupInfo GetDeckConfigInfo(int deckConfigId)
		{
			return ConfigPhantomBattleCardGroupInfoById.GetConfig(deckConfigId, true).Value;
		}

		// Token: 0x06029FC7 RID: 171975 RVA: 0x00BDF3DC File Offset: 0x00BDD5DC
		public PhantomBattleChallenge GetPhantomBattleChallengeConfig(int challengeId)
		{
			return ConfigPhantomBattleChallengeById.GetConfig(challengeId, true).Value;
		}

		// Token: 0x06029FC8 RID: 171976 RVA: 0x00BDF3F8 File Offset: 0x00BDD5F8
		public IReadOnlyList<PhantomBattleGym> GetPhantomBattleGymConfig(int activityId)
		{
			return ConfigPhantomBattleGymByActivityId.GetConfigList(activityId, true);
		}

		// Token: 0x06029FC9 RID: 171977 RVA: 0x00BDF404 File Offset: 0x00BDD604
		public int GetRepeatGymExpWeekLimitByLevel(int level)
		{
			if (ConfigPhantomBattleWeekExpById.GetConfig(level, true) == null)
			{
				return 0;
			}
			PhantomBattleWeekExp? phantomBattleWeekExp;
			return phantomBattleWeekExp.GetValueOrDefault().MaxWeekExp;
		}

		// Token: 0x06029FCA RID: 171978 RVA: 0x00BDF434 File Offset: 0x00BDD634
		public PhantomBattleGym? GetPhantomBattleGymConfigByLevel(int activityId, int gymLevel)
		{
			foreach (PhantomBattleGym value in this.GetPhantomBattleGymConfig(activityId))
			{
				if (value.Level == gymLevel)
				{
					return new PhantomBattleGym?(value);
				}
			}
			return null;
		}

		// Token: 0x06029FCB RID: 171979 RVA: 0x00BDF49C File Offset: 0x00BDD69C
		public PhantomBattleMasterLevel? GetPhantomBattleMasterLevelConfigById(int configId)
		{
			PhantomBattleMasterLevel? config = ConfigPhantomBattleMasterLevelById.GetConfig(configId, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.PhantomArena;
				ELogAuthor author = ELogAuthor.WDX;
				string message = "获取召唤师等级配置失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ConfigId", configId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return config;
		}

		// Token: 0x06029FCC RID: 171980 RVA: 0x00BDF4EC File Offset: 0x00BDD6EC
		public unsafe PhantomBattleMasterLevel? GetPhantomBattleMasterLevelByLevelAndActivityId(int level, int activityId)
		{
			foreach (PhantomBattleMasterLevel value in ConfigPhantomBattleMasterLevelAll.GetConfigList(true))
			{
				if (value.Level == level && value.ActivityId == activityId)
				{
					return new PhantomBattleMasterLevel?(value);
				}
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.PhantomArena;
			ELogAuthor author = ELogAuthor.CXJ;
			string message = "获取召唤师等级配置失败";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("level", level);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("activityId", activityId);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return null;
		}

		// Token: 0x06029FCD RID: 171981 RVA: 0x00BDF5BC File Offset: 0x00BDD7BC
		public List<PhantomBattleMasterLevel> GetPhantomBattleMasterLevelConfigByActivityId(int activityId)
		{
			IEnumerable<PhantomBattleMasterLevel> configList = ConfigPhantomBattleMasterLevelAll.GetConfigList(true);
			List<PhantomBattleMasterLevel> list = new List<PhantomBattleMasterLevel>();
			foreach (PhantomBattleMasterLevel item in configList)
			{
				if (item.ActivityId == activityId)
				{
					list.Add(item);
				}
			}
			return list;
		}

		// Token: 0x06029FCE RID: 171982 RVA: 0x00BDF61C File Offset: 0x00BDD81C
		public unsafe PhantomBattleMasterLevel? GetPhantomBattleMasterLevelConfigByLevel(int activityId, int level)
		{
			foreach (PhantomBattleMasterLevel value in ConfigPhantomBattleMasterLevelAll.GetConfigList(true))
			{
				if (value.ActivityId == activityId && value.Level == level)
				{
					return new PhantomBattleMasterLevel?(value);
				}
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.PhantomArena;
			ELogAuthor author = ELogAuthor.WDX;
			string message = "获取召唤师等级配置失败";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ActivityId", activityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Level", level);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return null;
		}

		// Token: 0x06029FCF RID: 171983 RVA: 0x00BDF6EC File Offset: 0x00BDD8EC
		public unsafe List<int> GetPhantomBattleChallengeIdListByGymId(int activityId, int gymId)
		{
			IReadOnlyList<PhantomBattleChallenge> configList = ConfigPhantomBattleChallengeByActivityGymId.GetConfigList(activityId, gymId, true);
			if (configList == null || configList.Count <= 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.PhantomArena;
				ELogAuthor author = ELogAuthor.WDX;
				string message = "获取道馆的挑战列表失败，请检查PhantomBattleChallenge表";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ActivityId", activityId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("GymId", gymId);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return new List<int>();
			}
			List<int> list = new List<int>();
			foreach (PhantomBattleChallenge phantomBattleChallenge in configList)
			{
				list.Add(phantomBattleChallenge.Id);
			}
			return list;
		}

		// Token: 0x06029FD0 RID: 171984 RVA: 0x00BDF7C0 File Offset: 0x00BDD9C0
		public PhantomBattleCardReward GetPhantomBattleCardRewardById(int configId)
		{
			PhantomBattleCardReward? config = ConfigPhantomBattleCardRewardById.GetConfig(configId, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.PhantomArena;
				ELogAuthor author = ELogAuthor.WDX;
				string message = "获取卡牌奖励列表失败，请检查PhantomBattleCardReward表";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ConfigId", config);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return config.Value;
		}

		// Token: 0x06029FD1 RID: 171985 RVA: 0x00BDF814 File Offset: 0x00BDDA14
		public PhantomBattleBadgeReward GetPhantomBattleBadgeRewardById(int configId)
		{
			PhantomBattleBadgeReward? config = ConfigPhantomBattleBadgeRewardById.GetConfig(configId, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.PhantomArena;
				ELogAuthor author = ELogAuthor.WDX;
				string message = "获取卡牌奖励列表失败，请检查PhantomBattleBadgeReward表";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ConfigId", config);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return config.Value;
		}

		// Token: 0x06029FD2 RID: 171986 RVA: 0x00BDF868 File Offset: 0x00BDDA68
		private int RewardSortByFlagId(PhantomBattleBadgeReward configA, PhantomBattleBadgeReward configB)
		{
			int bitFlagId = configA.BitFlagId;
			int bitFlagId2 = configB.BitFlagId;
			return bitFlagId - bitFlagId2;
		}

		// Token: 0x06029FD3 RID: 171987 RVA: 0x00BDF888 File Offset: 0x00BDDA88
		private int RewardSortByFlagId(PhantomBattleCardReward configA, PhantomBattleCardReward configB)
		{
			int bitFlagId = configA.BitFlagId;
			int bitFlagId2 = configB.BitFlagId;
			return bitFlagId - bitFlagId2;
		}

		// Token: 0x06029FD4 RID: 171988 RVA: 0x00BDF8A8 File Offset: 0x00BDDAA8
		public List<int> GetPhantomBattleCardRewardIdList(int activityId)
		{
			IReadOnlyList<PhantomBattleCardReward> configList = ConfigPhantomBattleCardRewardByActivityId.GetConfigList(activityId, true);
			if (configList == null || configList.Count <= 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.PhantomArena;
				ELogAuthor author = ELogAuthor.WDX;
				string message = "获取卡牌奖励列表失败，请检查PhantomBattleCardReward表";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ActivityId", activityId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return new List<int>();
			}
			List<PhantomBattleCardReward> list = new List<PhantomBattleCardReward>(configList);
			list.Sort(new Comparison<PhantomBattleCardReward>(this.RewardSortByFlagId));
			List<int> list2 = new List<int>();
			foreach (PhantomBattleCardReward phantomBattleCardReward in list)
			{
				list2.Add(phantomBattleCardReward.Id);
			}
			return list2;
		}

		// Token: 0x06029FD5 RID: 171989 RVA: 0x00BDF964 File Offset: 0x00BDDB64
		public List<int> GetPhantomBattleBadgeRewardIdList(int activityId)
		{
			IReadOnlyList<PhantomBattleBadgeReward> configList = ConfigPhantomBattleBadgeRewardByActivityId.GetConfigList(activityId, true);
			if (configList == null || configList.Count <= 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.PhantomArena;
				ELogAuthor author = ELogAuthor.WDX;
				string message = "获取卡牌奖励列表失败，请检查PhantomBattleBadgeReward表";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ActivityId", activityId);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return new List<int>();
			}
			List<PhantomBattleBadgeReward> list = new List<PhantomBattleBadgeReward>(configList);
			list.Sort(new Comparison<PhantomBattleBadgeReward>(this.RewardSortByFlagId));
			List<int> list2 = new List<int>();
			foreach (PhantomBattleBadgeReward phantomBattleBadgeReward in list)
			{
				list2.Add(phantomBattleBadgeReward.Id);
			}
			return list2;
		}

		// Token: 0x06029FD6 RID: 171990 RVA: 0x00BDFA20 File Offset: 0x00BDDC20
		public List<int> GetQuicklyBuildDeckList(int activityId)
		{
			return new List<int>(this.GetPhantomBattleActivityConfig(activityId).GetQuicklyBuildArray());
		}

		// Token: 0x06029FD7 RID: 171991 RVA: 0x00BDFA44 File Offset: 0x00BDDC44
		public int GetSlotLongPressTime(int activityId)
		{
			return this.GetPhantomBattleActivityConfig(activityId).SlotLongPressTime;
		}

		// Token: 0x06029FD8 RID: 171992 RVA: 0x00BDFA60 File Offset: 0x00BDDC60
		public int GetSlotLongPressStartTime(int activityId)
		{
			return this.GetPhantomBattleActivityConfig(activityId).SlotLongPressStartTime;
		}

		// Token: 0x06029FD9 RID: 171993 RVA: 0x00BDFA7C File Offset: 0x00BDDC7C
		public int GetSlotLongPressEndTime(int activityId)
		{
			return this.GetPhantomBattleActivityConfig(activityId).SlotLongPressEndTime;
		}

		// Token: 0x06029FDA RID: 171994 RVA: 0x00BDFA98 File Offset: 0x00BDDC98
		public PhantomBattleDialog GetPhantomBattleDialog(int id)
		{
			return ConfigPhantomBattleDialogById.GetConfig(id, true).Value;
		}

		// Token: 0x06029FDB RID: 171995 RVA: 0x00BDFAB4 File Offset: 0x00BDDCB4
		public int GetPhantomArenaOwnSpeakerId()
		{
			return ConfigCommonParamById.GetIntConfig("PhantomArenaOwnSpeakerId").Value;
		}

		// Token: 0x06029FDC RID: 171996 RVA: 0x00BDFAD4 File Offset: 0x00BDDCD4
		public int GetPhantomArenaOpponentSpeakerId()
		{
			return ConfigCommonParamById.GetIntConfig("PhantomArenaOpponentSpeakerId").Value;
		}

		// Token: 0x06029FDD RID: 171997 RVA: 0x00BDFAF4 File Offset: 0x00BDDCF4
		public int GetPhantomArenaCardCoreCost()
		{
			return ConfigCommonParamById.GetIntConfig("PhantomBattleKeyCost").Value;
		}

		// Token: 0x06029FDE RID: 171998 RVA: 0x00BDFB14 File Offset: 0x00BDDD14
		public int GetPhantomArenaRoundOverCheck()
		{
			return ConfigCommonParamById.GetIntConfig("PhantomArenaRoundOverCheck").Value;
		}

		// Token: 0x06029FDF RID: 171999 RVA: 0x00BDFB34 File Offset: 0x00BDDD34
		public PhantomBattleFourCTask GetPhantomArenaFourTask(int cardId)
		{
			return ConfigPhantomBattleFourCTaskByCardId.GetConfig(cardId, true).Value;
		}

		// Token: 0x06029FE0 RID: 172000 RVA: 0x00BDFB50 File Offset: 0x00BDDD50
		public PhantomBattleTask? GetTaskConfigById(int taskId)
		{
			return ConfigPhantomBattleTaskByTaskId.GetConfig(taskId, true);
		}

		// Token: 0x06029FE1 RID: 172001 RVA: 0x00BDFB59 File Offset: 0x00BDDD59
		public PhantomBattleWinSeq? GetSeqConfig(int instId)
		{
			return ConfigPhantomBattleWinSeqById.GetConfig(instId, true);
		}

		// Token: 0x06029FE2 RID: 172002 RVA: 0x00BDFB62 File Offset: 0x00BDDD62
		public PhantomBattleTaskTab? GetTaskTabConfigById(int tabId)
		{
			return ConfigPhantomBattleTaskTabById.GetConfig(tabId, true);
		}

		// Token: 0x06029FE3 RID: 172003 RVA: 0x00BDFB6C File Offset: 0x00BDDD6C
		public float GetCardSlotItemLongPressOffsetX()
		{
			if (!Info.Instance.IsInTouch())
			{
				return 0f;
			}
			return ConfigCommonParamById.GetFloatConfig("BvbVisionScrollerOffsetX").Value;
		}

		// Token: 0x06029FE4 RID: 172004 RVA: 0x00BDFBA0 File Offset: 0x00BDDDA0
		public float GetCardSlotItemLongPressOffsetY()
		{
			if (!Info.Instance.IsInTouch())
			{
				return 0f;
			}
			return ConfigCommonParamById.GetFloatConfig("BvbVisionScrollerOffsetY").Value;
		}

		// Token: 0x06029FE5 RID: 172005 RVA: 0x00BDFBD1 File Offset: 0x00BDDDD1
		public PhantomBattleChallenge? GetPhantomBattleChallengeByMarkId(int markId)
		{
			return ConfigPhantomBattleChallengeByMarkId.GetConfig(markId, true);
		}

		// Token: 0x06029FE6 RID: 172006 RVA: 0x00BDFBDA File Offset: 0x00BDDDDA
		public PhantomBattleMapParam? GetPhantomBattleMapParamById(int id)
		{
			return ConfigPhantomBattleMapParamById.GetConfig(id, true);
		}

		// Token: 0x06029FE7 RID: 172007 RVA: 0x00BDFBE3 File Offset: 0x00BDDDE3
		[NullableContext(2)]
		public IReadOnlyList<PhantomBattleMapParam> GetAllPhantomBattleMapParams()
		{
			return ConfigPhantomBattleMapParamAll.GetConfigList(true);
		}

		// Token: 0x06029FE8 RID: 172008 RVA: 0x00BDFBEB File Offset: 0x00BDDDEB
		[NullableContext(2)]
		public IReadOnlyList<PhantomBattleMapParam> GetPhantomBattleMapParamByMapId(int mapId)
		{
			return ConfigPhantomBattleMapParamByMapIdNew.GetConfigList(mapId, true);
		}

		// Token: 0x06029FE9 RID: 172009 RVA: 0x00BDFBF4 File Offset: 0x00BDDDF4
		[NullableContext(2)]
		public IReadOnlyList<PhantomBattleChallenge> GetPhantomBattleChallengeByMapId(int mapId)
		{
			return ConfigPhantomBattleChallengeByMapId.GetConfigList(mapId, true);
		}

		// Token: 0x1700545C RID: 21596
		// (get) Token: 0x06029FEA RID: 172010 RVA: 0x00BDFBFD File Offset: 0x00BDDDFD
		public static PhantomArenaConfig Instance
		{
			get
			{
				return PhantomArenaConfig._Instance;
			}
		}

		// Token: 0x06029FEB RID: 172011 RVA: 0x00BDFC04 File Offset: 0x00BDDE04
		public static PhantomArenaConfig GetOrCreateInstance()
		{
			if (PhantomArenaConfig._Instance == null)
			{
				PhantomArenaConfig.CreateInstance();
			}
			return PhantomArenaConfig._Instance;
		}

		// Token: 0x06029FEC RID: 172012 RVA: 0x00BDFC18 File Offset: 0x00BDDE18
		public static bool CreateInstance()
		{
			if (PhantomArenaConfig._Instance != null)
			{
				return true;
			}
			PhantomArenaConfig._Instance = new PhantomArenaConfig();
			return true;
		}

		// Token: 0x06029FED RID: 172013 RVA: 0x00BDFC2E File Offset: 0x00BDDE2E
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06029FEE RID: 172014 RVA: 0x00BDFC30 File Offset: 0x00BDDE30
		public static void ResetStaticDefaultValue()
		{
			PhantomArenaConfig._Instance = null;
		}

		// Token: 0x06029FEF RID: 172015 RVA: 0x00BDFC38 File Offset: 0x00BDDE38
		static PhantomArenaConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PhantomArenaConfig.CreateStaticDefaultValue), new Action(PhantomArenaConfig.ResetStaticDefaultValue));
		}

		// Token: 0x04016DE3 RID: 93667
		[Nullable(2)]
		private static PhantomArenaConfig _Instance;
	}
}
