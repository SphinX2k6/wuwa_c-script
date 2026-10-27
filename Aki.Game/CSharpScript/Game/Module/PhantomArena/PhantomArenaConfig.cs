using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x02005104 RID: 20740
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class PhantomArenaConfig : ConfigBase
	{
		// Token: 0x060350B1 RID: 217265 RVA: 0x00C91D38 File Offset: 0x00C8FF38
		public PhantomBattleCard GetPhantomBattleCardConfig(int configId)
		{
			return ConfigPhantomBattleCardById.GetConfig(configId, true).Value;
		}

		// Token: 0x060350B2 RID: 217266 RVA: 0x00C91D54 File Offset: 0x00C8FF54
		public IReadOnlyList<PhantomBattleCard> GetPhantomBattleCardByActivityId(int activityId)
		{
			return ConfigPhantomBattleCardByActivityId.GetConfigList(activityId, true);
		}

		// Token: 0x060350B3 RID: 217267 RVA: 0x00C91D5D File Offset: 0x00C8FF5D
		public IReadOnlyList<PhantomBattleCard> GetAllPhantomBattleCard()
		{
			return ConfigPhantomBattleCardAll.GetConfigList(true);
		}

		// Token: 0x060350B4 RID: 217268 RVA: 0x00C91D68 File Offset: 0x00C8FF68
		public PhantomBattleSkill GetPhantomBattleSkillConfig(int skillConfigId)
		{
			return ConfigPhantomBattleSkillById.GetConfig(skillConfigId, true).Value;
		}

		// Token: 0x060350B5 RID: 217269 RVA: 0x00C91D84 File Offset: 0x00C8FF84
		public PhantomBattleBuff GetPhantomBattleBuffConfig(int buffConfigId)
		{
			return ConfigPhantomBattleBuffById.GetConfig(buffConfigId, true).Value;
		}

		// Token: 0x060350B6 RID: 217270 RVA: 0x00C91DA0 File Offset: 0x00C8FFA0
		public PhantomBattleFactor GetPhantomBattleFactorConfig(int factorConfigId)
		{
			return ConfigPhantomBattleFactorById.GetConfig(factorConfigId, true).Value;
		}

		// Token: 0x060350B7 RID: 217271 RVA: 0x00C91DBC File Offset: 0x00C8FFBC
		public IReadOnlyList<PhantomBattleFactor> GetPhantomBattleAllFactor()
		{
			return ConfigPhantomBattleFactorAll.GetConfigList(true);
		}

		// Token: 0x060350B8 RID: 217272 RVA: 0x00C91DC4 File Offset: 0x00C8FFC4
		public PhantomBattleEntry GetPhantomBattleEntryConfig(int entryId)
		{
			return ConfigPhantomBattleEntryById.GetConfig(entryId, true).Value;
		}

		// Token: 0x060350B9 RID: 217273 RVA: 0x00C91DE0 File Offset: 0x00C8FFE0
		public PhantomBattleCardElement GetPhantomBattleElementConfig(int elementId)
		{
			return ConfigPhantomBattleCardElementById.GetConfig(elementId, true).Value;
		}

		// Token: 0x060350BA RID: 217274 RVA: 0x00C91DFC File Offset: 0x00C8FFFC
		public PhantomBattleCardEffect GetPhantomBattleEffectConfig(int id)
		{
			return ConfigPhantomBattleCardEffectById.GetConfig(id, true).Value;
		}

		// Token: 0x060350BB RID: 217275 RVA: 0x00C91E18 File Offset: 0x00C90018
		public IReadOnlyList<PhantomBattleCardFilter> GetAllPhantomBattleCardFilter()
		{
			return ConfigPhantomBattleCardFilterAll.GetConfigList(true);
		}

		// Token: 0x060350BC RID: 217276 RVA: 0x00C91E20 File Offset: 0x00C90020
		public PhantomBattleCardFilter GetPhantomBattleCardFilter(int filterId)
		{
			return ConfigPhantomBattleCardFilterById.GetConfig(filterId, true).Value;
		}

		// Token: 0x060350BD RID: 217277 RVA: 0x00C91E3C File Offset: 0x00C9003C
		public IReadOnlyList<PhantomBattleCardSlotSort> GetAllPhantomBattleCardSlotSort()
		{
			return ConfigPhantomBattleCardSlotSortAll.GetConfigList(true);
		}

		// Token: 0x060350BE RID: 217278 RVA: 0x00C91E44 File Offset: 0x00C90044
		public PhantomBattleCardSlotSort GetPhantomBattleCardSlotSort(int sortId)
		{
			return ConfigPhantomBattleCardSlotSortById.GetConfig(sortId, true).Value;
		}

		// Token: 0x060350BF RID: 217279 RVA: 0x00C91E60 File Offset: 0x00C90060
		public PhantomBattleActivity GetPhantomBattleActivityConfig(int activityId)
		{
			return ConfigPhantomBattleActivityByActivityId.GetConfig(activityId, true).Value;
		}

		// Token: 0x060350C0 RID: 217280 RVA: 0x00C91E7C File Offset: 0x00C9007C
		public PhantomBattleChallenge GetPhantomBattleChallenge(int challengeId)
		{
			return ConfigPhantomBattleChallengeById.GetConfig(challengeId, true).Value;
		}

		// Token: 0x060350C1 RID: 217281 RVA: 0x00C91E98 File Offset: 0x00C90098
		public IReadOnlyList<PhantomBattleBadge> GetAllPhantomBattleBadge()
		{
			return ConfigPhantomBattleBadgeAll.GetConfigList(true);
		}

		// Token: 0x060350C2 RID: 217282 RVA: 0x00C91EA0 File Offset: 0x00C900A0
		public PhantomBattleBadge GetPhantomBattleBadgeById(int badgeId)
		{
			return ConfigPhantomBattleBadgeById.GetConfig(badgeId, true).Value;
		}

		// Token: 0x060350C3 RID: 217283 RVA: 0x00C91EBC File Offset: 0x00C900BC
		public int GetPhantomBattleBadgeGroupIdById(int badgeId)
		{
			return this.GetPhantomBattleBadgeById(badgeId).GroupId;
		}

		// Token: 0x060350C4 RID: 217284 RVA: 0x00C91ED8 File Offset: 0x00C900D8
		public PhantomBattleBadgeGroup GetPhantomBattleBadgeGroupById(int groupId)
		{
			return ConfigPhantomBattleBadgeGroupByGroupId.GetConfig(groupId, true).Value;
		}

		// Token: 0x060350C5 RID: 217285 RVA: 0x00C91EF4 File Offset: 0x00C900F4
		public PhantomBattleMasterTitle GetPhantomBattleMasterTitleById(int titleId)
		{
			return ConfigPhantomBattleMasterTitleById.GetConfig(titleId, true).Value;
		}

		// Token: 0x060350C6 RID: 217286 RVA: 0x00C91F10 File Offset: 0x00C90110
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

		// Token: 0x060350C7 RID: 217287 RVA: 0x00C91F50 File Offset: 0x00C90150
		public PhantomBattleCardRole GetPhantomBattleCardRole(int id)
		{
			return ConfigPhantomBattleCardRoleById.GetConfig(id, true).Value;
		}

		// Token: 0x060350C8 RID: 217288 RVA: 0x00C91F6C File Offset: 0x00C9016C
		public IReadOnlyList<PhantomBattleCardRole> GetPhantomBattleCardRoleByActivityId(int activityId)
		{
			return ConfigPhantomBattleCardRoleByActivityId.GetConfigList(activityId, true);
		}

		// Token: 0x060350C9 RID: 217289 RVA: 0x00C91F75 File Offset: 0x00C90175
		public string GetDeckDefaultName()
		{
			return ConfigMultiTextLang.GetLocalTextNew("PhantomBattle_1038", null);
		}

		// Token: 0x060350CA RID: 217290 RVA: 0x00C91F84 File Offset: 0x00C90184
		public PhantomBattleNPC GetPhantomBattleNpc(int id)
		{
			return ConfigPhantomBattleNPCById.GetConfig(id, true).Value;
		}

		// Token: 0x060350CB RID: 217291 RVA: 0x00C91FA0 File Offset: 0x00C901A0
		public IReadOnlyList<PhantomBattleNPC> GetPhantomBattleNpcList(int npcGroupId)
		{
			return ConfigPhantomBattleNPCByGroupId.GetConfigList(npcGroupId, true);
		}

		// Token: 0x060350CC RID: 217292 RVA: 0x00C91FA9 File Offset: 0x00C901A9
		public IReadOnlyList<PhantomBattleCardGroup> GetCardListByDeckConfigId(int deckConfigId)
		{
			return ConfigPhantomBattleCardGroupByGroupId.GetConfigList(deckConfigId, true);
		}

		// Token: 0x060350CD RID: 217293 RVA: 0x00C91FB4 File Offset: 0x00C901B4
		public PhantomBattleCardGroupInfo GetDeckConfigInfo(int deckConfigId)
		{
			return ConfigPhantomBattleCardGroupInfoById.GetConfig(deckConfigId, true).Value;
		}

		// Token: 0x060350CE RID: 217294 RVA: 0x00C91FD0 File Offset: 0x00C901D0
		public PhantomBattleChallenge GetPhantomBattleChallengeConfig(int challengeId)
		{
			return ConfigPhantomBattleChallengeById.GetConfig(challengeId, true).Value;
		}

		// Token: 0x060350CF RID: 217295 RVA: 0x00C91FEC File Offset: 0x00C901EC
		public IReadOnlyList<PhantomBattleGym> GetPhantomBattleGymConfig(int activityId)
		{
			return ConfigPhantomBattleGymByActivityId.GetConfigList(activityId, true);
		}

		// Token: 0x060350D0 RID: 217296 RVA: 0x00C91FF8 File Offset: 0x00C901F8
		public int GetRepeatGymExpWeekLimitByLevel(int level)
		{
			if (ConfigPhantomBattleWeekExpById.GetConfig(level, true) == null)
			{
				return 0;
			}
			PhantomBattleWeekExp? phantomBattleWeekExp;
			return phantomBattleWeekExp.GetValueOrDefault().MaxWeekExp;
		}

		// Token: 0x060350D1 RID: 217297 RVA: 0x00C92028 File Offset: 0x00C90228
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

		// Token: 0x060350D2 RID: 217298 RVA: 0x00C92090 File Offset: 0x00C90290
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

		// Token: 0x060350D3 RID: 217299 RVA: 0x00C920E0 File Offset: 0x00C902E0
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

		// Token: 0x060350D4 RID: 217300 RVA: 0x00C921B0 File Offset: 0x00C903B0
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

		// Token: 0x060350D5 RID: 217301 RVA: 0x00C92210 File Offset: 0x00C90410
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

		// Token: 0x060350D6 RID: 217302 RVA: 0x00C922E0 File Offset: 0x00C904E0
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

		// Token: 0x060350D7 RID: 217303 RVA: 0x00C923B4 File Offset: 0x00C905B4
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

		// Token: 0x060350D8 RID: 217304 RVA: 0x00C92408 File Offset: 0x00C90608
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

		// Token: 0x060350D9 RID: 217305 RVA: 0x00C9245C File Offset: 0x00C9065C
		private int RewardSortByFlagId(PhantomBattleBadgeReward configA, PhantomBattleBadgeReward configB)
		{
			int bitFlagId = configA.BitFlagId;
			int bitFlagId2 = configB.BitFlagId;
			return bitFlagId - bitFlagId2;
		}

		// Token: 0x060350DA RID: 217306 RVA: 0x00C9247C File Offset: 0x00C9067C
		private int RewardSortByFlagId(PhantomBattleCardReward configA, PhantomBattleCardReward configB)
		{
			int bitFlagId = configA.BitFlagId;
			int bitFlagId2 = configB.BitFlagId;
			return bitFlagId - bitFlagId2;
		}

		// Token: 0x060350DB RID: 217307 RVA: 0x00C9249C File Offset: 0x00C9069C
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

		// Token: 0x060350DC RID: 217308 RVA: 0x00C92558 File Offset: 0x00C90758
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

		// Token: 0x060350DD RID: 217309 RVA: 0x00C92614 File Offset: 0x00C90814
		public List<int> GetQuicklyBuildDeckList(int activityId)
		{
			return this.GetPhantomBattleActivityConfig(activityId).GetQuicklyBuildBytes().ToArray().ToList<int>();
		}

		// Token: 0x060350DE RID: 217310 RVA: 0x00C92640 File Offset: 0x00C90840
		public int GetSlotLongPressTime(int activityId)
		{
			return this.GetPhantomBattleActivityConfig(activityId).SlotLongPressTime;
		}

		// Token: 0x060350DF RID: 217311 RVA: 0x00C9265C File Offset: 0x00C9085C
		public int GetSlotLongPressStartTime(int activityId)
		{
			return this.GetPhantomBattleActivityConfig(activityId).SlotLongPressStartTime;
		}

		// Token: 0x060350E0 RID: 217312 RVA: 0x00C92678 File Offset: 0x00C90878
		public int GetSlotLongPressEndTime(int activityId)
		{
			return this.GetPhantomBattleActivityConfig(activityId).SlotLongPressEndTime;
		}

		// Token: 0x060350E1 RID: 217313 RVA: 0x00C92694 File Offset: 0x00C90894
		public PhantomBattleDialog GetPhantomBattleDialog(int id)
		{
			return ConfigPhantomBattleDialogById.GetConfig(id, true).Value;
		}

		// Token: 0x060350E2 RID: 217314 RVA: 0x00C926B0 File Offset: 0x00C908B0
		public int GetPhantomArenaOwnSpeakerId()
		{
			return ConfigCommonParamById.GetIntConfig("PhantomArenaOwnSpeakerId").Value;
		}

		// Token: 0x060350E3 RID: 217315 RVA: 0x00C926D0 File Offset: 0x00C908D0
		public int GetPhantomArenaOpponentSpeakerId()
		{
			return ConfigCommonParamById.GetIntConfig("PhantomArenaOpponentSpeakerId").Value;
		}

		// Token: 0x060350E4 RID: 217316 RVA: 0x00C926F0 File Offset: 0x00C908F0
		public int GetPhantomArenaCardCoreCost()
		{
			return ConfigCommonParamById.GetIntConfig("PhantomBattleKeyCost").Value;
		}

		// Token: 0x060350E5 RID: 217317 RVA: 0x00C92710 File Offset: 0x00C90910
		public int GetPhantomArenaRoundOverCheck()
		{
			return ConfigCommonParamById.GetIntConfig("PhantomArenaRoundOverCheck").Value;
		}

		// Token: 0x060350E6 RID: 217318 RVA: 0x00C92730 File Offset: 0x00C90930
		public PhantomBattleFourCTask GetPhantomArenaFourTask(int cardId)
		{
			return ConfigPhantomBattleFourCTaskByCardId.GetConfig(cardId, true).Value;
		}

		// Token: 0x060350E7 RID: 217319 RVA: 0x00C9274C File Offset: 0x00C9094C
		public PhantomBattleTask? GetTaskConfigById(int taskId)
		{
			return ConfigPhantomBattleTaskByTaskId.GetConfig(taskId, true);
		}

		// Token: 0x060350E8 RID: 217320 RVA: 0x00C92755 File Offset: 0x00C90955
		public PhantomBattleWinSeq? GetSeqConfig(int instId)
		{
			return ConfigPhantomBattleWinSeqById.GetConfig(instId, true);
		}

		// Token: 0x060350E9 RID: 217321 RVA: 0x00C9275E File Offset: 0x00C9095E
		public PhantomBattleTaskTab? GetTaskTabConfigById(int tabId)
		{
			return ConfigPhantomBattleTaskTabById.GetConfig(tabId, true);
		}

		// Token: 0x060350EA RID: 217322 RVA: 0x00C92768 File Offset: 0x00C90968
		public float GetCardSlotItemLongPressOffsetX()
		{
			if (!Info.Instance.IsInTouch())
			{
				return 0f;
			}
			return ConfigCommonParamById.GetFloatConfig("BvbVisionScrollerOffsetX").Value;
		}

		// Token: 0x060350EB RID: 217323 RVA: 0x00C9279C File Offset: 0x00C9099C
		public float GetCardSlotItemLongPressOffsetY()
		{
			if (!Info.Instance.IsInTouch())
			{
				return 0f;
			}
			return ConfigCommonParamById.GetFloatConfig("BvbVisionScrollerOffsetY").Value;
		}

		// Token: 0x060350EC RID: 217324 RVA: 0x00C927CD File Offset: 0x00C909CD
		public PhantomBattleChallenge? GetPhantomBattleChallengeByMarkId(int markId)
		{
			return ConfigPhantomBattleChallengeByMarkId.GetConfig(markId, true);
		}

		// Token: 0x060350ED RID: 217325 RVA: 0x00C927D6 File Offset: 0x00C909D6
		public PhantomBattleMapParam? GetPhantomBattleMapParamById(int id)
		{
			return ConfigPhantomBattleMapParamById.GetConfig(id, true);
		}

		// Token: 0x060350EE RID: 217326 RVA: 0x00C927DF File Offset: 0x00C909DF
		[NullableContext(2)]
		public IReadOnlyList<PhantomBattleMapParam> GetAllPhantomBattleMapParams()
		{
			return ConfigPhantomBattleMapParamAll.GetConfigList(true);
		}

		// Token: 0x060350EF RID: 217327 RVA: 0x00C927E7 File Offset: 0x00C909E7
		[NullableContext(2)]
		public IReadOnlyList<PhantomBattleMapParam> GetPhantomBattleMapParamByMapId(int mapId)
		{
			return ConfigPhantomBattleMapParamByMapIdNew.GetConfigList(mapId, true);
		}

		// Token: 0x060350F0 RID: 217328 RVA: 0x00C927F0 File Offset: 0x00C909F0
		[NullableContext(2)]
		public IReadOnlyList<PhantomBattleChallenge> GetPhantomBattleChallengeByMapId(int mapId)
		{
			return ConfigPhantomBattleChallengeByMapId.GetConfigList(mapId, true);
		}

		// Token: 0x1700809C RID: 32924
		// (get) Token: 0x060350F1 RID: 217329 RVA: 0x00C927F9 File Offset: 0x00C909F9
		public static PhantomArenaConfig Instance
		{
			get
			{
				return PhantomArenaConfig._Instance;
			}
		}

		// Token: 0x060350F2 RID: 217330 RVA: 0x00C92800 File Offset: 0x00C90A00
		public static PhantomArenaConfig GetOrCreateInstance()
		{
			if (PhantomArenaConfig._Instance == null)
			{
				PhantomArenaConfig.CreateInstance();
			}
			return PhantomArenaConfig._Instance;
		}

		// Token: 0x060350F3 RID: 217331 RVA: 0x00C92814 File Offset: 0x00C90A14
		public static bool CreateInstance()
		{
			if (PhantomArenaConfig._Instance != null)
			{
				return true;
			}
			PhantomArenaConfig._Instance = new PhantomArenaConfig();
			return true;
		}

		// Token: 0x060350F4 RID: 217332 RVA: 0x00C9282A File Offset: 0x00C90A2A
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060350F5 RID: 217333 RVA: 0x00C9282C File Offset: 0x00C90A2C
		public static void ResetStaticDefaultValue()
		{
			PhantomArenaConfig._Instance = null;
		}

		// Token: 0x060350F6 RID: 217334 RVA: 0x00C92834 File Offset: 0x00C90A34
		static PhantomArenaConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PhantomArenaConfig.CreateStaticDefaultValue), new Action(PhantomArenaConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401C3B0 RID: 115632
		[Nullable(2)]
		private static PhantomArenaConfig _Instance;
	}
}
