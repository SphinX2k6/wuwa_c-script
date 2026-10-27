using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using CSharpScript.Game.Module.PhantomArena.Common.CardDetail;
using CSharpScript.Game.Module.PhantomArena.Common.CardItem.Item;
using CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.WorldMap;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x0200513E RID: 20798
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class PhantomArenaModel : ModelBase
	{
		// Token: 0x06035188 RID: 217480 RVA: 0x00C94510 File Offset: 0x00C92710
		[NullableContext(2)]
		public PhantomArenaActivityData GetPermanentPhantomArenaActivityData()
		{
			if (this.PermanentPhantomArenaActivityDataInner == null)
			{
				foreach (ActivityBaseData activityBaseData in ActivityModel.Instance.GetAllActivityMap().Values)
				{
					if (activityBaseData.Type == ActivityType.PhantomBattleRecord)
					{
						this.PermanentPhantomArenaActivityDataInner = PhantomArenaModel.Instance.GetPhantomArenaActivityData(activityBaseData.Id);
						break;
					}
				}
			}
			return this.PermanentPhantomArenaActivityDataInner;
		}

		// Token: 0x06035189 RID: 217481 RVA: 0x00C94598 File Offset: 0x00C92798
		public PhantomArenaActivityData GetPhantomArenaActivityData(int activityId)
		{
			return ActivityModel.Instance.GetActivityById(activityId) as PhantomArenaActivityData;
		}

		// Token: 0x0603518A RID: 217482 RVA: 0x00C945AA File Offset: 0x00C927AA
		public bool GetActivityUnlock(int activityId)
		{
			return activityId > 0 && this.GetPhantomArenaActivityData(activityId).IsUnLock();
		}

		// Token: 0x0603518B RID: 217483 RVA: 0x00C945BE File Offset: 0x00C927BE
		public bool IsNewPhantomArenaActivity(int activityId)
		{
			return this.GetPhantomArenaActivityData(activityId).Type == ActivityType.PhantomBattleRecord;
		}

		// Token: 0x0603518C RID: 217484 RVA: 0x00C945D0 File Offset: 0x00C927D0
		public bool CanCardUnlock(int cardId)
		{
			PhantomBattleCard phantomBattleCardConfig = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(cardId);
			if (!phantomBattleCardConfig.EnableBuy)
			{
				return false;
			}
			foreach (OneItemConfig oneItemConfig in phantomBattleCardConfig.UnlockConsumeItems())
			{
				if (InventoryModel.Instance.GetItemCountByConfigId(oneItemConfig.ItemId, 0) < oneItemConfig.Count)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0603518D RID: 217485 RVA: 0x00C94630 File Offset: 0x00C92830
		public bool IsCardUnlock(int cardId)
		{
			int activityId = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(cardId).ActivityId;
			return this.GetPhantomArenaActivityData(activityId).IsCardUnlock(cardId);
		}

		// Token: 0x0603518E RID: 217486 RVA: 0x00C94660 File Offset: 0x00C92860
		public bool IsCardOutlookUnlock(int cardId)
		{
			int activityId = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(cardId).ActivityId;
			return this.GetPhantomArenaActivityData(activityId).IsCardOutlookUnlock(cardId);
		}

		// Token: 0x0603518F RID: 217487 RVA: 0x00C94690 File Offset: 0x00C92890
		public bool IsBadgeUnlock(int badgeId)
		{
			int activityId = PhantomArenaConfig.Instance.GetPhantomBattleBadgeById(badgeId).ActivityId;
			return this.GetPhantomArenaActivityData(activityId).IsBadgeUnlock(badgeId);
		}

		// Token: 0x06035190 RID: 217488 RVA: 0x00C946C0 File Offset: 0x00C928C0
		public void OnCardOutlookUnlock(int cardId)
		{
			int activityId = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(cardId).ActivityId;
			this.GetPhantomArenaActivityData(activityId).OnCardOutlookUnlock(cardId);
		}

		// Token: 0x06035191 RID: 217489 RVA: 0x00C946F0 File Offset: 0x00C928F0
		public void AddCardListByNotify(PhantomBattleCardInfoUpdateNotify notify)
		{
			IReadOnlyList<PhantomBattleCardInfo> phantomBattleCardInfos = notify.PhantomBattleCardInfos;
			int phantomBattleCardId = phantomBattleCardInfos[0].PhantomBattleCardId;
			int activityId = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(phantomBattleCardId).ActivityId;
			this.GetPhantomArenaActivityData(activityId).AddCardListByNotify(phantomBattleCardInfos.ToArray<PhantomBattleCardInfo>());
		}

		// Token: 0x06035192 RID: 217490 RVA: 0x00C94738 File Offset: 0x00C92938
		public int GetActivityIdByRoleId(int roleId)
		{
			return PhantomArenaConfig.Instance.GetPhantomBattleCardRole(roleId).ActivityId;
		}

		// Token: 0x06035193 RID: 217491 RVA: 0x00C94758 File Offset: 0x00C92958
		public void AddRoleByNotify(PhantomBattleRoleInfoUpdateNotify notify)
		{
			IReadOnlyList<PhantomBattleRoleInfo> phantomBattleRoleInfos = notify.PhantomBattleRoleInfos;
			int activityIdByRoleId = this.GetActivityIdByRoleId(phantomBattleRoleInfos[0].PhantomBattleRoleId);
			PhantomArenaActivityData phantomArenaActivityData = this.GetPhantomArenaActivityData(activityIdByRoleId);
			foreach (PhantomBattleRoleInfo roleInfo in phantomBattleRoleInfos)
			{
				phantomArenaActivityData.AddRoleInfo(roleInfo);
			}
		}

		// Token: 0x06035194 RID: 217492 RVA: 0x00C947C4 File Offset: 0x00C929C4
		public void OnRoleReward(int roleId)
		{
			int activityIdByRoleId = this.GetActivityIdByRoleId(roleId);
			this.GetPhantomArenaActivityData(activityIdByRoleId).OnRoleReward(roleId);
		}

		// Token: 0x06035195 RID: 217493 RVA: 0x00C947E6 File Offset: 0x00C929E6
		public void UpdateDeckList(IReadOnlyList<Aki.Protocol.PhantomBattleCardGroupInfo> cardGroupInfo, int activityId)
		{
			this.GetPhantomArenaActivityData(activityId).UpdateProtocolDeckInfoList(cardGroupInfo.ToArray<Aki.Protocol.PhantomBattleCardGroupInfo>());
		}

		// Token: 0x06035196 RID: 217494 RVA: 0x00C947FA File Offset: 0x00C929FA
		public void AddProtocolDeckInfo(Aki.Protocol.PhantomBattleCardGroupInfo cardGroupInfo, int activityId)
		{
			this.GetPhantomArenaActivityData(activityId).AddProtocolDeckInfo(cardGroupInfo);
		}

		// Token: 0x06035197 RID: 217495 RVA: 0x00C94809 File Offset: 0x00C92A09
		public void UpdateProtocolDeckInfo(Aki.Protocol.PhantomBattleCardGroupInfo cardGroupInfo, int activityId)
		{
			this.GetPhantomArenaActivityData(activityId).UpdateProtocolDeckInfo(cardGroupInfo);
		}

		// Token: 0x06035198 RID: 217496 RVA: 0x00C94818 File Offset: 0x00C92A18
		public int GetDustItemId(int activityId)
		{
			return PhantomArenaConfig.Instance.GetPhantomBattleActivityConfig(activityId).DustItemId;
		}

		// Token: 0x06035199 RID: 217497 RVA: 0x00C94838 File Offset: 0x00C92A38
		public int GetExpItemId(int activityId)
		{
			return PhantomArenaConfig.Instance.GetPhantomBattleActivityConfig(activityId).ExpItemId;
		}

		// Token: 0x0603519A RID: 217498 RVA: 0x00C94858 File Offset: 0x00C92A58
		public int GetPointsItemId(int activityId)
		{
			return PhantomArenaConfig.Instance.GetPhantomBattleActivityConfig(activityId).Integration;
		}

		// Token: 0x0603519B RID: 217499 RVA: 0x00C94878 File Offset: 0x00C92A78
		public int GetRewardItemId(int activityId)
		{
			return PhantomArenaConfig.Instance.GetPhantomBattleActivityConfig(activityId).RewardItemId;
		}

		// Token: 0x0603519C RID: 217500 RVA: 0x00C94898 File Offset: 0x00C92A98
		public List<T> FilterCardList<[Nullable(0)] T>(List<T> cardInfoList, CardFilterContext filterContext) where T : CardFilterInfo
		{
			List<T> list = new List<T>();
			int costFilter = (int)filterContext.CostFilter;
			IReadOnlyList<int> source = PhantomArenaConfig.Instance.GetPhantomBattleCardFilter(costFilter).CostList();
			foreach (T t in cardInfoList)
			{
				if (filterContext.IncludeLocked || !t.IsLocked)
				{
					ECardTabType elementFilter = filterContext.ElementFilter;
					if ((elementFilter == ECardTabType.All || PhantomArenaDefine.cardTabTypeToFilterElementList[elementFilter].Contains((ECardElement)t.Element)) && source.Contains(t.Cost))
					{
						list.Add(t);
					}
				}
			}
			return list;
		}

		// Token: 0x0603519D RID: 217501 RVA: 0x00C94960 File Offset: 0x00C92B60
		public void SortCardSlotList<[Nullable(0)] T>(List<T> cardSlotInfoList, CardSlotSortContext sortContext) where T : CardSlotSortInfo
		{
			TCardSlotSortFunc sortFunc = PhantomArenaDefine.cardSlotSortTypeToSortFunc[sortContext.SortType];
			cardSlotInfoList.Sort((T a, T b) => this.CompareCardSlot(a, b, sortFunc, sortContext.IsAscending));
		}

		// Token: 0x0603519E RID: 217502 RVA: 0x00C949B0 File Offset: 0x00C92BB0
		public int CompareCardSlot(CardSlotSortInfo a, CardSlotSortInfo b, TCardSlotSortFunc sortFunc, bool isAscending)
		{
			int num = sortFunc(a, b);
			if (num == 0)
			{
				num = PhantomArenaDefine.cardSlotDefaultSortFunc(a, b);
			}
			int num2 = isAscending ? 1 : -1;
			return num * num2;
		}

		// Token: 0x0603519F RID: 217503 RVA: 0x00C949E2 File Offset: 0x00C92BE2
		public ECardFaceType GetCardFaceType(int cardId)
		{
			if (this.IsCardOutlookUnlock(cardId) && this.CheckCardSpineConfigValid(cardId))
			{
				return ECardFaceType.Spine;
			}
			return ECardFaceType.Texture;
		}

		// Token: 0x060351A0 RID: 217504 RVA: 0x00C949FC File Offset: 0x00C92BFC
		public bool CheckCardSpineConfigValid(int cardId)
		{
			PhantomBattleCard phantomBattleCardConfig = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(cardId);
			return !StringUtils.IsEmpty(phantomBattleCardConfig.SpineAtlas) && !StringUtils.IsEmpty(phantomBattleCardConfig.SpineSkeleton);
		}

		// Token: 0x060351A1 RID: 217505 RVA: 0x00C94A34 File Offset: 0x00C92C34
		public CardSpineData CreateCardSpineData(int cardId)
		{
			PhantomBattleCard phantomBattleCardConfig = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(cardId);
			return new CardSpineData
			{
				CardSpineAtlasPath = phantomBattleCardConfig.SpineAtlas,
				CardSpineSkeletonPath = phantomBattleCardConfig.SpineSkeleton,
				AnimationName = ECardSpineAnimation.Idle,
				IsLoop = true
			};
		}

		// Token: 0x060351A2 RID: 217506 RVA: 0x00C94A80 File Offset: 0x00C92C80
		[NullableContext(2)]
		public PhantomBattleChallengeInfo GetChallengeData(int challengeId)
		{
			int activityId = PhantomArenaConfig.Instance.GetPhantomBattleChallenge(challengeId).ActivityId;
			return this.GetPhantomArenaActivityData(activityId).GetChallengeInfoById(challengeId);
		}

		// Token: 0x060351A3 RID: 217507 RVA: 0x00C94AAE File Offset: 0x00C92CAE
		[NullableContext(2)]
		public PhantomBattleChallengeInfo GetPermanentChallengeData(int challengeId)
		{
			PhantomArenaActivityData permanentPhantomArenaActivityData = this.GetPermanentPhantomArenaActivityData();
			if (permanentPhantomArenaActivityData == null)
			{
				return null;
			}
			return permanentPhantomArenaActivityData.GetChallengeInfoById(challengeId);
		}

		// Token: 0x060351A4 RID: 217508 RVA: 0x00C94AC2 File Offset: 0x00C92CC2
		public int GetLastUsedCardRoleId(int activityId)
		{
			return this.GetPhantomArenaActivityData(activityId).GetLastUsedCardRoleId();
		}

		// Token: 0x060351A5 RID: 217509 RVA: 0x00C94AD0 File Offset: 0x00C92CD0
		public void SetLastUsedCardDeckServerId(int deckServerId, int activityId)
		{
			this.GetPhantomArenaActivityData(activityId).SetLastUsedDeckServerId(deckServerId);
		}

		// Token: 0x060351A6 RID: 217510 RVA: 0x00C94ADF File Offset: 0x00C92CDF
		public int GetLastUsedCardDeckServerId(int activityId)
		{
			return this.GetPhantomArenaActivityData(activityId).GetLastUsedDeckServerId();
		}

		// Token: 0x060351A7 RID: 217511 RVA: 0x00C94AED File Offset: 0x00C92CED
		[NullableContext(2)]
		public DeckInfo GetDeckByDeckId(int deckId, int activityId)
		{
			return this.GetPhantomArenaActivityData(activityId).GetClientDeckInfo(deckId);
		}

		// Token: 0x060351A8 RID: 217512 RVA: 0x00C94AFC File Offset: 0x00C92CFC
		public List<DeckInfo> CreateEditableDeckListFromProtocolData(int activityId)
		{
			return this.GetPhantomArenaActivityData(activityId).CreateDeckInfoListFromProtocol();
		}

		// Token: 0x060351A9 RID: 217513 RVA: 0x00C94B0C File Offset: 0x00C92D0C
		public unsafe DeckInfo CreateDeckInfoFromDeckConfigId(int deckConfigId)
		{
			IEnumerable<PhantomBattleCardGroup> cardListByDeckConfigId = PhantomArenaConfig.Instance.GetCardListByDeckConfigId(deckConfigId);
			Aki.Config.PhantomBattleCardGroupInfo deckConfigInfo = PhantomArenaConfig.Instance.GetDeckConfigInfo(deckConfigId);
			DeckInfo deckInfo = new DeckInfo();
			string deckName = ConfigMultiTextLang.GetLocalTextNew(deckConfigInfo.Name, null) ?? "";
			deckInfo.SetDeckName(deckName);
			deckInfo.SetDeckConfigId(deckConfigId);
			deckInfo.SetElementCountLimit(deckConfigInfo.ElementCountLimit);
			deckInfo.SetCoreCardCountLimit(deckConfigInfo.CoreCardCountLimit);
			deckInfo.SetFieldCardCountLimit(deckConfigInfo.FieldCardCountLimit);
			deckInfo.SetItemCardCountLimit(deckConfigInfo.ItemCardCountLimit);
			deckInfo.SetNormalCardCountLimit(deckConfigInfo.NormalCardCountLimit);
			deckInfo.SetCoreCost(PhantomArenaConfig.Instance.GetPhantomArenaCardCoreCost());
			foreach (PhantomBattleCardGroup phantomBattleCardGroup in cardListByDeckConfigId)
			{
				int cardId = phantomBattleCardGroup.CardId;
				PhantomBattleCard phantomBattleCardConfig = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(cardId);
				AddCardContext context = new AddCardContext
				{
					CardId = cardId,
					Cost = phantomBattleCardConfig.Cost,
					Element = phantomBattleCardConfig.Element,
					MaxCount = phantomBattleCardConfig.CardGroupNum,
					AddCount = phantomBattleCardGroup.Num,
					CardType = (ECardType)phantomBattleCardConfig.Type
				};
				EAddCardResult eaddCardResult = deckInfo.AddCard(context);
				if (eaddCardResult != EAddCardResult.Success)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.PhantomArena;
					ELogAuthor author = ELogAuthor.LZK;
					string message = "从配置表中创建卡组时，添加卡牌失败";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("deckConfigId", deckConfigId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("cardId", cardId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("result", eaddCardResult);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				}
			}
			return deckInfo;
		}

		// Token: 0x060351AA RID: 217514 RVA: 0x00C94CEC File Offset: 0x00C92EEC
		public DeckInfo CreateEmptyTempDeckInfo(int activityId)
		{
			DeckInfo deckInfo = this.GetPhantomArenaActivityData(activityId).CreateClientDeckInfo();
			deckInfo.SetDeckServerId(-100);
			string deckName = ConfigMultiTextLang.GetLocalTextNew("PhantomBattle_1038", null) ?? "";
			deckInfo.SetDeckName(deckName);
			return deckInfo;
		}

		// Token: 0x060351AB RID: 217515 RVA: 0x00C94D2C File Offset: 0x00C92F2C
		public int GetUnlockCardCountInDeck(DeckInfo deck)
		{
			int num = 0;
			foreach (DeckCardSlotInfo deckCardSlotInfo in deck.GetCardSlotList())
			{
				int cardId = deckCardSlotInfo.CardId;
				if (this.IsCardUnlock(cardId))
				{
					num += deckCardSlotInfo.Count;
				}
			}
			return num;
		}

		// Token: 0x060351AC RID: 217516 RVA: 0x00C94D94 File Offset: 0x00C92F94
		public List<int> GetPhantomBattleGymLevelList(int activityId, bool? noRepeat = null)
		{
			IEnumerable<PhantomBattleGym> phantomBattleGymConfig = PhantomArenaConfig.Instance.GetPhantomBattleGymConfig(activityId);
			List<int> list = new List<int>();
			foreach (PhantomBattleGym phantomBattleGym in phantomBattleGymConfig)
			{
				if (!noRepeat.GetValueOrDefault() || !phantomBattleGym.IfRepeat)
				{
					list.Add(phantomBattleGym.Level);
				}
			}
			return list;
		}

		// Token: 0x060351AD RID: 217517 RVA: 0x00C94E08 File Offset: 0x00C93008
		public PhantomBattleGym? GetPhantomBattleGymConfigByLevel(int gymLevel, int activityId)
		{
			return PhantomArenaConfig.Instance.GetPhantomBattleGymConfigByLevel(activityId, gymLevel);
		}

		// Token: 0x060351AE RID: 217518 RVA: 0x00C94E18 File Offset: 0x00C93018
		public EChallengeState GetChallengeStateById(int challengeId)
		{
			int activityId = PhantomArenaConfig.Instance.GetPhantomBattleChallenge(challengeId).ActivityId;
			PhantomBattleChallengeInfo challengeInfoById = this.GetPhantomArenaActivityData(activityId).GetChallengeInfoById(challengeId);
			if (challengeInfoById == null || !challengeInfoById.IsUnlock)
			{
				return EChallengeState.Lock;
			}
			if (PhantomArenaConfig.Instance.GetPhantomBattleChallengeConfig(challengeId).IsReChallenge && !this.GetRepeatChallengeOpen(challengeId))
			{
				return EChallengeState.Lock;
			}
			if (!challengeInfoById.IsPassRewarded)
			{
				return EChallengeState.Pending;
			}
			return EChallengeState.Finish;
		}

		// Token: 0x060351AF RID: 217519 RVA: 0x00C94E80 File Offset: 0x00C93080
		public EChallengeState GetPermanentChallengeStateById(int challengeId)
		{
			PhantomArenaActivityData permanentPhantomArenaActivityData = this.GetPermanentPhantomArenaActivityData();
			PhantomBattleChallengeInfo phantomBattleChallengeInfo = (permanentPhantomArenaActivityData != null) ? permanentPhantomArenaActivityData.GetChallengeInfoById(challengeId) : null;
			if (phantomBattleChallengeInfo == null || !phantomBattleChallengeInfo.IsUnlock)
			{
				return EChallengeState.Lock;
			}
			if (!phantomBattleChallengeInfo.IsPassRewarded)
			{
				return EChallengeState.Pending;
			}
			return EChallengeState.Finish;
		}

		// Token: 0x060351B0 RID: 217520 RVA: 0x00C94EBC File Offset: 0x00C930BC
		public void UpdateChallengeInfoByNotify(PhantomBattleChallengeInfoUpdateNotify notify)
		{
			int phantomBattleChallengeId = notify.PhantomBattleChallengeInfos[0].PhantomBattleChallengeId;
			int activityId = PhantomArenaConfig.Instance.GetPhantomBattleChallenge(phantomBattleChallengeId).ActivityId;
			this.GetPhantomArenaActivityData(activityId).UpdateChallengeInfoList(notify.PhantomBattleChallengeInfos.ToArray<PhantomBattleChallengeInfo>());
		}

		// Token: 0x060351B1 RID: 217521 RVA: 0x00C94F08 File Offset: 0x00C93108
		public void UpdateChallengeInfoBySettleResult(int challengeId, bool isUnLock, bool hasPass, bool isUnCover)
		{
			int activityId = PhantomArenaConfig.Instance.GetPhantomBattleChallenge(challengeId).ActivityId;
			this.GetPhantomArenaActivityData(activityId).UpdateChallengeInfoById(challengeId, isUnLock, hasPass, isUnCover);
		}

		// Token: 0x060351B2 RID: 217522 RVA: 0x00C94F3A File Offset: 0x00C9313A
		public bool IsChallengeLock(int challengeId)
		{
			return this.GetChallengeStateById(challengeId) == EChallengeState.Lock;
		}

		// Token: 0x060351B3 RID: 217523 RVA: 0x00C94F48 File Offset: 0x00C93148
		public bool IsGymLock(int gymLevel, int activityId)
		{
			List<GymChallengeData> challengeStateListByGymLevel = this.GetChallengeStateListByGymLevel(gymLevel, activityId);
			return ((challengeStateListByGymLevel.Count > 0) ? challengeStateListByGymLevel[0].State : EChallengeState.Lock) == EChallengeState.Lock;
		}

		// Token: 0x060351B4 RID: 217524 RVA: 0x00C94F7C File Offset: 0x00C9317C
		public bool IsGymUnlockChecked(int gymLevel, int activityId)
		{
			Dictionary<int, List<int>> player = LocalStorage.GetPlayer<Dictionary<int, List<int>>>(ELocalStoragePlayerKey.PhantomArenaEntranceGymCheck, null);
			if (player == null || !player.ContainsKey(activityId))
			{
				Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();
				dictionary[activityId] = new List<int>();
				LocalStorage.SetPlayer<Dictionary<int, List<int>>>(ELocalStoragePlayerKey.PhantomArenaEntranceGymCheck, dictionary);
				return false;
			}
			return player[activityId].Contains(gymLevel);
		}

		// Token: 0x060351B5 RID: 217525 RVA: 0x00C94FD0 File Offset: 0x00C931D0
		public void SetGymUnlockChecked(int gymLevel, int activityId)
		{
			Dictionary<int, List<int>> player = LocalStorage.GetPlayer<Dictionary<int, List<int>>>(ELocalStoragePlayerKey.PhantomArenaEntranceGymCheck, null);
			if (player == null || !player.ContainsKey(activityId))
			{
				Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();
				dictionary[activityId] = new List<int>
				{
					gymLevel
				};
				LocalStorage.SetPlayer<Dictionary<int, List<int>>>(ELocalStoragePlayerKey.PhantomArenaEntranceGymCheck, dictionary);
				return;
			}
			List<int> list = player[activityId];
			if (!list.Contains(gymLevel))
			{
				list.Add(gymLevel);
				player[activityId] = list;
				LocalStorage.SetPlayer<Dictionary<int, List<int>>>(ELocalStoragePlayerKey.PhantomArenaEntranceGymCheck, player);
			}
		}

		// Token: 0x060351B6 RID: 217526 RVA: 0x00C95048 File Offset: 0x00C93248
		public void UpdateMasterInfoByNotify(PhantomBattleMasterInfoNotify notify)
		{
			PhantomBattleMasterInfo phantomBattleMasterInfo = notify.PhantomBattleMasterInfo;
			if (phantomBattleMasterInfo == null)
			{
				return;
			}
			this.GetPhantomArenaActivityData(notify.ActivityId).UpdateMasterInfo(phantomBattleMasterInfo);
		}

		// Token: 0x060351B7 RID: 217527 RVA: 0x00C95072 File Offset: 0x00C93272
		public int GetMasterLevel(int activityId)
		{
			return this.GetPhantomArenaActivityData(activityId).GetMasterLevel();
		}

		// Token: 0x060351B8 RID: 217528 RVA: 0x00C95080 File Offset: 0x00C93280
		public int GetMasterTitleId(int activityId)
		{
			return this.GetPhantomArenaActivityData(activityId).GetMasterTitleId();
		}

		// Token: 0x060351B9 RID: 217529 RVA: 0x00C95090 File Offset: 0x00C93290
		public int GetMasterTitleIdByLevel(int level, int activityId)
		{
			return this.GetMasterLevelConfig(level, activityId).Value.TitleId;
		}

		// Token: 0x060351BA RID: 217530 RVA: 0x00C950B5 File Offset: 0x00C932B5
		public PhantomBattleMasterLevel? GetMasterLevelConfig(int level, int activityId)
		{
			return PhantomArenaConfig.Instance.GetPhantomBattleMasterLevelConfigByLevel(activityId, level);
		}

		// Token: 0x060351BB RID: 217531 RVA: 0x00C950C4 File Offset: 0x00C932C4
		public bool GetMasterLevelRewardIfTaken(int level, int activityId)
		{
			if (activityId <= 0)
			{
				return false;
			}
			PhantomBattleMasterLevel? masterLevelConfig = this.GetMasterLevelConfig(level, activityId);
			return this.GetPhantomArenaActivityData(activityId).GetMasterLevelRewardIfTaken(masterLevelConfig.Value.Id);
		}

		// Token: 0x060351BC RID: 217532 RVA: 0x00C950FC File Offset: 0x00C932FC
		public bool GetMasterLevelRewardCanTake(int level, int activityId)
		{
			int expNeed = this.GetMasterLevelConfig(level, activityId).Value.ExpNeed;
			int masterExpNow = this.GetMasterExpNow(activityId, null);
			return this.GetMasterLevelRewardList(level, activityId).Count != 0 && masterExpNow >= expNeed && !this.GetMasterLevelRewardIfTaken(level, activityId);
		}

		// Token: 0x060351BD RID: 217533 RVA: 0x00C95158 File Offset: 0x00C93358
		public List<TItem> GetMasterLevelRewardList(int level, int activityId)
		{
			int normalDropId = this.GetMasterLevelConfig(level, activityId).Value.NormalDropId;
			if (normalDropId <= 0)
			{
				return new List<TItem>();
			}
			return CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(normalDropId);
		}

		// Token: 0x060351BE RID: 217534 RVA: 0x00C95193 File Offset: 0x00C93393
		public List<PhantomBattleMasterLevel> GetPhantomBattleMasterLevelConfigList(int activityId)
		{
			return PhantomArenaConfig.Instance.GetPhantomBattleMasterLevelConfigByActivityId(activityId).ToList<PhantomBattleMasterLevel>();
		}

		// Token: 0x060351BF RID: 217535 RVA: 0x00C951A8 File Offset: 0x00C933A8
		public int GetMasterExpNextNeed(int activityId)
		{
			int masterLevel = this.GetMasterLevel(activityId);
			PhantomBattleMasterLevel? phantomBattleMasterLevelConfigByLevel = PhantomArenaConfig.Instance.GetPhantomBattleMasterLevelConfigByLevel(activityId, masterLevel);
			return phantomBattleMasterLevelConfigByLevel.Value.ExpNeed + phantomBattleMasterLevelConfigByLevel.Value.ExpNext;
		}

		// Token: 0x060351C0 RID: 217536 RVA: 0x00C951EC File Offset: 0x00C933EC
		public int GetMasterExpNow(int activityId, bool? canOverflow = null)
		{
			int masterExp = this.GetPhantomArenaActivityData(activityId).GetMasterExp();
			if (canOverflow.GetValueOrDefault())
			{
				return masterExp;
			}
			int masterLevelMax = this.GetMasterLevelMax(activityId);
			int expNeed = this.GetMasterLevelConfig(masterLevelMax, activityId).Value.ExpNeed;
			if (masterExp < expNeed)
			{
				return masterExp;
			}
			return expNeed;
		}

		// Token: 0x060351C1 RID: 217537 RVA: 0x00C9523A File Offset: 0x00C9343A
		public int GetMasterExpWeek(int activityId)
		{
			return this.GetPhantomArenaActivityData(activityId).GetMasterExpWeek();
		}

		// Token: 0x060351C2 RID: 217538 RVA: 0x00C95248 File Offset: 0x00C93448
		private List<int> GetChallengeIdListByGymLevel(int gymLevel, int activityId)
		{
			return PhantomArenaConfig.Instance.GetPhantomBattleChallengeIdListByGymId(activityId, gymLevel).ToList<int>();
		}

		// Token: 0x060351C3 RID: 217539 RVA: 0x00C9525C File Offset: 0x00C9345C
		public List<GymChallengeData> GetChallengeStateListByGymLevel(int gymLevel, int activityId)
		{
			List<int> challengeIdListByGymLevel = this.GetChallengeIdListByGymLevel(gymLevel, activityId);
			PhantomBattleGym? phantomBattleGymConfigByLevel = this.GetPhantomBattleGymConfigByLevel(gymLevel, activityId);
			if (phantomBattleGymConfigByLevel != null && phantomBattleGymConfigByLevel.Value.IfRepeat && challengeIdListByGymLevel.Count != 2)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.PhantomArena;
				ELogAuthor author = ELogAuthor.WDX;
				string message = "错误的复刷道馆难度数量";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("配置数量", challengeIdListByGymLevel.Count);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			List<GymChallengeData> list = new List<GymChallengeData>();
			for (int i = 0; i < challengeIdListByGymLevel.Count; i++)
			{
				int num = challengeIdListByGymLevel[i];
				EChallengeState challengeStateById = this.GetChallengeStateById(num);
				GymChallengeData item = new GymChallengeData
				{
					Id = num,
					State = challengeStateById,
					IsLast = (i == challengeIdListByGymLevel.Count - 1)
				};
				list.Add(item);
			}
			return list;
		}

		// Token: 0x060351C4 RID: 217540 RVA: 0x00C95334 File Offset: 0x00C93534
		public int GetFinishedChallengeCount(int activityId)
		{
			return this.GetPhantomArenaActivityData(activityId).GetFinishedChallengeCount();
		}

		// Token: 0x060351C5 RID: 217541 RVA: 0x00C95344 File Offset: 0x00C93544
		public int GetPermanentFinishedChallengeCount(int mapId)
		{
			PhantomArenaActivityData permanentPhantomArenaActivityData = this.GetPermanentPhantomArenaActivityData();
			Dictionary<int, List<int>> dictionary = (permanentPhantomArenaActivityData != null) ? permanentPhantomArenaActivityData.GetDifficultChallengeIdsMap(mapId) : null;
			if (dictionary == null)
			{
				return 0;
			}
			int num = 0;
			foreach (List<int> list in dictionary.Values)
			{
				foreach (int challengeId in list)
				{
					if (this.GetPermanentChallengeStateById(challengeId) == EChallengeState.Finish)
					{
						num++;
					}
				}
			}
			return num;
		}

		// Token: 0x060351C6 RID: 217542 RVA: 0x00C953F0 File Offset: 0x00C935F0
		public int GetPermanentAllChallengeCount(int mapId)
		{
			PhantomArenaActivityData permanentPhantomArenaActivityData = this.GetPermanentPhantomArenaActivityData();
			Dictionary<int, List<int>> dictionary = (permanentPhantomArenaActivityData != null) ? permanentPhantomArenaActivityData.GetDifficultChallengeIdsMap(mapId) : null;
			if (dictionary == null)
			{
				return 0;
			}
			int num = 0;
			foreach (List<int> list in dictionary.Values)
			{
				num += list.Count;
			}
			return num;
		}

		// Token: 0x060351C7 RID: 217543 RVA: 0x00C95464 File Offset: 0x00C93664
		public bool GetMapUnlock(int mapId)
		{
			PhantomArenaActivityData permanentPhantomArenaActivityData = this.GetPermanentPhantomArenaActivityData();
			Dictionary<int, List<int>> dictionary = (permanentPhantomArenaActivityData != null) ? permanentPhantomArenaActivityData.GetDifficultChallengeIdsMap(mapId) : null;
			if (dictionary == null)
			{
				return false;
			}
			bool result = false;
			foreach (List<int> list in dictionary.Values)
			{
				foreach (int challengeId in list)
				{
					if (this.GetPermanentChallengeStateById(challengeId) != EChallengeState.Lock)
					{
						result = true;
						break;
					}
				}
			}
			return result;
		}

		// Token: 0x060351C8 RID: 217544 RVA: 0x00C95510 File Offset: 0x00C93710
		public bool GetRepeatChallengeOpen(int challengeId)
		{
			PhantomBattleChallenge phantomBattleChallenge = PhantomArenaConfig.Instance.GetPhantomBattleChallenge(challengeId);
			if (!phantomBattleChallenge.IsReChallenge)
			{
				return false;
			}
			if (!phantomBattleChallenge.EnableCheckReChallengeFunc)
			{
				return true;
			}
			PhantomBattleActivity? phantomBattleActivity = new PhantomBattleActivity?(PhantomArenaConfig.Instance.GetPhantomBattleActivityConfig(phantomBattleChallenge.ActivityId));
			int functionId;
			if (!phantomBattleActivity.Value.FuncOpenChallenge().TryGetValue(challengeId, out functionId))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.PhantomArena;
				ELogAuthor author = ELogAuthor.CB;
				string message = "复刷挑战未配置功能开关";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ChallengeId", challengeId);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			return FunctionModel.Instance.IsOpen(functionId);
		}

		// Token: 0x060351C9 RID: 217545 RVA: 0x00C955B0 File Offset: 0x00C937B0
		public List<TItem> GetFirstRewardListByChallengeId(int challengeId)
		{
			List<TItem> list = new List<TItem>();
			foreach (KeyValuePair<int, int> keyValuePair in ConfigDropPackageById.GetConfig(PhantomArenaConfig.Instance.GetPhantomBattleChallenge(challengeId).FirstPassDropId, true).Value.DropPreview())
			{
				TItem item = new TItem(new InventoryDefine.GetItemData(keyValuePair.Key, 0), keyValuePair.Value);
				list.Add(item);
			}
			return list;
		}

		// Token: 0x060351CA RID: 217546 RVA: 0x00C9564C File Offset: 0x00C9384C
		public List<TItem> GetRewardListByChallengeId(int challengeId)
		{
			List<TItem> list = new List<TItem>();
			PhantomBattleChallenge phantomBattleChallenge = PhantomArenaConfig.Instance.GetPhantomBattleChallenge(challengeId);
			EChallengeState challengeStateById = this.GetChallengeStateById(challengeId);
			if (phantomBattleChallenge.IsReChallenge || challengeStateById == EChallengeState.Finish)
			{
				using (Dictionary<int, int>.Enumerator enumerator = phantomBattleChallenge.PassDropId().GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						KeyValuePair<int, int> keyValuePair = enumerator.Current;
						TItem item = new TItem(new InventoryDefine.GetItemData(keyValuePair.Key, 0), keyValuePair.Value);
						list.Add(item);
					}
					return list;
				}
			}
			DropPackage? config = ConfigDropPackageById.GetConfig(phantomBattleChallenge.FirstPassDropId, true);
			foreach (KeyValuePair<int, int> keyValuePair2 in (((config != null) ? config.GetValueOrDefault().DropPreview() : null) ?? new Dictionary<int, int>()))
			{
				TItem item2 = new TItem(new InventoryDefine.GetItemData(keyValuePair2.Key, 0), keyValuePair2.Value);
				list.Add(item2);
			}
			return list;
		}

		// Token: 0x060351CB RID: 217547 RVA: 0x00C95778 File Offset: 0x00C93978
		public List<TItem> GetPermanentRewardListByChallengeId(int challengeId)
		{
			List<TItem> list = new List<TItem>();
			PhantomBattleChallenge phantomBattleChallenge = PhantomArenaConfig.Instance.GetPhantomBattleChallenge(challengeId);
			EChallengeState permanentChallengeStateById = this.GetPermanentChallengeStateById(challengeId);
			if (phantomBattleChallenge.IsReChallenge && permanentChallengeStateById == EChallengeState.Finish)
			{
				using (Dictionary<int, int>.Enumerator enumerator = phantomBattleChallenge.PassDropId().GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						KeyValuePair<int, int> keyValuePair = enumerator.Current;
						TItem item = new TItem(new InventoryDefine.GetItemData(keyValuePair.Key, 0), keyValuePair.Value);
						list.Add(item);
					}
					return list;
				}
			}
			DropPackage? config = ConfigDropPackageById.GetConfig(phantomBattleChallenge.FirstPassDropId, true);
			foreach (KeyValuePair<int, int> keyValuePair2 in (((config != null) ? config.GetValueOrDefault().DropPreview() : null) ?? new Dictionary<int, int>()))
			{
				TItem item2 = new TItem(new InventoryDefine.GetItemData(keyValuePair2.Key, 0), keyValuePair2.Value);
				list.Add(item2);
			}
			return list;
		}

		// Token: 0x060351CC RID: 217548 RVA: 0x00C958A4 File Offset: 0x00C93AA4
		public List<MasterLevelData> GetMasterLevelData(int activityId)
		{
			int masterLevelMax = this.GetMasterLevelMax(activityId);
			List<PhantomBattleMasterLevel> phantomBattleMasterLevelConfigList = this.GetPhantomBattleMasterLevelConfigList(activityId);
			List<MasterLevelData> list = new List<MasterLevelData>();
			foreach (PhantomBattleMasterLevel phantomBattleMasterLevel in phantomBattleMasterLevelConfigList)
			{
				MasterLevelData item = new MasterLevelData
				{
					Level = phantomBattleMasterLevel.Level,
					ExpLevel = phantomBattleMasterLevel.ExpNeed,
					ExpNext = phantomBattleMasterLevel.ExpNext,
					IsMax = (phantomBattleMasterLevel.Level >= masterLevelMax)
				};
				list.Add(item);
			}
			return list;
		}

		// Token: 0x060351CD RID: 217549 RVA: 0x00C9594C File Offset: 0x00C93B4C
		public List<MasterLevelDescData> GetMasterLevelDescData(int level, int activityId)
		{
			IEnumerable<string> enumerable = this.GetMasterLevelConfig(level, activityId).Value.Desc();
			int masterLevel = this.GetMasterLevel(activityId);
			List<MasterLevelDescData> list = new List<MasterLevelDescData>();
			foreach (string stringId in enumerable)
			{
				MasterLevelDescData item = new MasterLevelDescData
				{
					Level = level,
					StringId = stringId,
					IsDone = (masterLevel >= level)
				};
				list.Add(item);
			}
			return list;
		}

		// Token: 0x060351CE RID: 217550 RVA: 0x00C959E4 File Offset: 0x00C93BE4
		public int GetMasterLevelMax(int activityId)
		{
			return ((IReadOnlyCollection<PhantomBattleMasterLevel>)PhantomArenaConfig.Instance.GetPhantomBattleMasterLevelConfigByActivityId(activityId)).Count;
		}

		// Token: 0x060351CF RID: 217551 RVA: 0x00C959F8 File Offset: 0x00C93BF8
		public void UpdateMasterLevelByConfigIds(List<int> levelConfigIds, int activityId)
		{
			PhantomArenaActivityData phantomArenaActivityData = this.GetPhantomArenaActivityData(activityId);
			foreach (int levelConfigId in levelConfigIds)
			{
				phantomArenaActivityData.UpdateMasterLevelByConfigId(levelConfigId);
			}
		}

		// Token: 0x060351D0 RID: 217552 RVA: 0x00C95A50 File Offset: 0x00C93C50
		public List<int> GetCardItemIdInBattleResult(PhantomBattleSettleReward reward)
		{
			IEnumerable<PhantomBattleReward> reward2 = reward.Reward;
			List<int> list = new List<int>();
			foreach (PhantomBattleReward phantomBattleReward in reward2)
			{
				ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(phantomBattleReward.ItemId);
				if (itemConfigData != null && itemConfigData.ItemType.GetValueOrDefault() == InventoryDefine.EItemType.PhantomArenaCard)
				{
					list.Add(phantomBattleReward.ItemId);
				}
			}
			return list;
		}

		// Token: 0x060351D1 RID: 217553 RVA: 0x00C95AD0 File Offset: 0x00C93CD0
		public List<RewardItemData> GetRewardItemDataInBattleResult([Nullable(2)] PhantomBattleSettleReward reward, int activityId)
		{
			List<RewardItemData> list = new List<RewardItemData>();
			if (reward == null)
			{
				return list;
			}
			foreach (PhantomBattleReward phantomBattleReward in ((IEnumerable<PhantomBattleReward>)reward.Reward))
			{
				if (!this.CheckNotShowInResult(phantomBattleReward.ItemId, activityId))
				{
					RewardItemData item = new RewardItemData(phantomBattleReward.ItemId, phantomBattleReward.Count, null, EDropItemType.Normal);
					list.Add(item);
				}
			}
			return list;
		}

		// Token: 0x060351D2 RID: 217554 RVA: 0x00C95B58 File Offset: 0x00C93D58
		private bool CheckNotShowInResult(int itemId, int activityId)
		{
			int expItemId = this.GetExpItemId(activityId);
			int pointsItemId = this.GetPointsItemId(activityId);
			return itemId == expItemId || itemId == pointsItemId;
		}

		// Token: 0x060351D3 RID: 217555 RVA: 0x00C95B80 File Offset: 0x00C93D80
		public bool GetPermanentIsDifficultCompleted(int mapId, int difficult)
		{
			PhantomArenaActivityData permanentPhantomArenaActivityData = this.GetPermanentPhantomArenaActivityData();
			Dictionary<int, List<int>> dictionary = (permanentPhantomArenaActivityData != null) ? permanentPhantomArenaActivityData.GetDifficultChallengeIdsMap(mapId) : null;
			List<int> list;
			if (dictionary == null || !dictionary.TryGetValue(difficult, out list))
			{
				return false;
			}
			foreach (int challengeId in list)
			{
				if (this.GetPermanentChallengeStateById(challengeId) != EChallengeState.Finish)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060351D4 RID: 217556 RVA: 0x00C95C00 File Offset: 0x00C93E00
		[NullableContext(0)]
		[return: TupleElementNames(new string[]
		{
			"ChallengeId",
			"MarkId"
		})]
		public ValueTuple<int, int>? GetPermanentDefaultChallengeIdAndMarkId(int? mapId = null)
		{
			if (mapId != null)
			{
				return this.GetDefaultChallengeIdAndMarkIdByMapId(mapId.Value);
			}
			WorldMapModel instance = WorldMapModel.Instance;
			int? num = (instance != null) ? instance.WorldMapId : null;
			if (num != null)
			{
				PhantomArenaConfig instance2 = PhantomArenaConfig.Instance;
				IReadOnlyList<PhantomBattleMapParam> readOnlyList = (instance2 != null) ? instance2.GetPhantomBattleMapParamByMapId(num.Value) : null;
				if (readOnlyList != null)
				{
					foreach (PhantomBattleMapParam phantomBattleMapParam in readOnlyList)
					{
						ValueTuple<int, int>? defaultChallengeIdAndMarkIdByMapId = this.GetDefaultChallengeIdAndMarkIdByMapId(phantomBattleMapParam.Id);
						if (defaultChallengeIdAndMarkIdByMapId != null)
						{
							return defaultChallengeIdAndMarkIdByMapId;
						}
					}
				}
			}
			PhantomArenaActivityData permanentPhantomArenaActivityData = this.GetPermanentPhantomArenaActivityData();
			List<int> list = (permanentPhantomArenaActivityData != null) ? permanentPhantomArenaActivityData.GetAllChallengeIds() : null;
			if (list == null)
			{
				return null;
			}
			ValueTuple<int, int>? result = null;
			foreach (int num2 in list)
			{
				result = new ValueTuple<int, int>?(new ValueTuple<int, int>(num2, PhantomArenaConfig.Instance.GetPhantomBattleChallenge(num2).MarkId));
				EChallengeState permanentChallengeStateById = this.GetPermanentChallengeStateById(num2);
				if (permanentChallengeStateById == EChallengeState.Pending || permanentChallengeStateById == EChallengeState.Lock)
				{
					return result;
				}
			}
			return result;
		}

		// Token: 0x060351D5 RID: 217557 RVA: 0x00C95D60 File Offset: 0x00C93F60
		[NullableContext(0)]
		[return: TupleElementNames(new string[]
		{
			"ChallengeId",
			"MarkId"
		})]
		private ValueTuple<int, int>? GetDefaultChallengeIdAndMarkIdByMapId(int mapId)
		{
			ValueTuple<int, int>? result = null;
			PhantomArenaConfig instance = PhantomArenaConfig.Instance;
			IReadOnlyList<PhantomBattleChallenge> readOnlyList = (instance != null) ? instance.GetPhantomBattleChallengeByMapId(mapId) : null;
			if (readOnlyList == null)
			{
				return null;
			}
			foreach (PhantomBattleChallenge phantomBattleChallenge in readOnlyList)
			{
				int markId = phantomBattleChallenge.MarkId;
				result = new ValueTuple<int, int>?(new ValueTuple<int, int>(phantomBattleChallenge.Id, markId));
				EChallengeState permanentChallengeStateById = this.GetPermanentChallengeStateById(phantomBattleChallenge.Id);
				if (permanentChallengeStateById == EChallengeState.Lock)
				{
					break;
				}
				if (permanentChallengeStateById == EChallengeState.Pending)
				{
					break;
				}
			}
			return result;
		}

		// Token: 0x060351D6 RID: 217558 RVA: 0x00C95E04 File Offset: 0x00C94004
		[NullableContext(2)]
		public List<int> GetPermanentSortedDifficultList(int mapId)
		{
			PhantomArenaActivityData permanentPhantomArenaActivityData = this.GetPermanentPhantomArenaActivityData();
			Dictionary<int, List<int>> dictionary = (permanentPhantomArenaActivityData != null) ? permanentPhantomArenaActivityData.GetDifficultChallengeIdsMap(mapId) : null;
			if (dictionary == null)
			{
				return null;
			}
			List<int> list = new List<int>(dictionary.Keys);
			list.Sort((int a, int b) => a - b);
			return list;
		}

		// Token: 0x060351D7 RID: 217559 RVA: 0x00C95E5C File Offset: 0x00C9405C
		public List<UiDynamicTab> GetCollectTabDataList(EUiViewName viewName)
		{
			IEnumerable<UiDynamicTab> viewTabList = DynamicTabConfig.Instance.GetViewTabList(viewName);
			List<UiDynamicTab> list = new List<UiDynamicTab>();
			foreach (UiDynamicTab item in viewTabList)
			{
				if (FunctionModel.Instance.IsOpen(item.FunctionId))
				{
					list.Add(item);
				}
			}
			return list;
		}

		// Token: 0x060351D8 RID: 217560 RVA: 0x00C95ED0 File Offset: 0x00C940D0
		public DetailViewCardItemData GetDetailViewCardData(int cardId)
		{
			PhantomBattleCard phantomBattleCardConfig = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(cardId);
			bool flag = this.IsCardUnlock(cardId);
			bool outlookUnlocked = this.IsCardOutlookUnlock(cardId);
			Dictionary<int, int> dictionary = phantomBattleCardConfig.InitAttack();
			int num;
			int num2;
			return new DetailViewCardItemData
			{
				IsLock = !flag,
				CardId = cardId,
				Cost = phantomBattleCardConfig.Cost,
				Attack = (dictionary.TryGetValue(0, out num) ? num : 0),
				Life = (dictionary.TryGetValue(1, out num2) ? num2 : 0),
				Element = phantomBattleCardConfig.Element,
				CardFaceType = this.GetCardFaceType(cardId),
				CardFaceTexturePath = phantomBattleCardConfig.CardFaceTexture,
				CardSpineData = this.CreateCardSpineData(cardId),
				OutlookUnlocked = outlookUnlocked,
				CardType = (ECardType)phantomBattleCardConfig.Type
			};
		}

		// Token: 0x060351D9 RID: 217561 RVA: 0x00C95F98 File Offset: 0x00C94198
		public List<CollectGridCardData> GetCollectCardDataListByIdList(List<int> cardIdList)
		{
			List<CollectGridCardData> list = new List<CollectGridCardData>();
			foreach (int num in cardIdList)
			{
				PhantomBattleCard phantomBattleCardConfig = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(num);
				Dictionary<int, int> dictionary = phantomBattleCardConfig.InitAttack();
				bool outlookUnlocked = this.IsCardOutlookUnlock(num);
				int num2;
				int num3;
				CollectGridCardData item = new CollectGridCardData
				{
					CardId = num,
					CardFaceTexturePath = phantomBattleCardConfig.CardFaceTexture,
					Cost = phantomBattleCardConfig.Cost,
					Element = phantomBattleCardConfig.Element,
					Attack = (dictionary.TryGetValue(0, out num2) ? num2 : 0),
					Life = (dictionary.TryGetValue(1, out num3) ? num3 : 0),
					IsLocked = !this.IsCardUnlock(num),
					OutlookUnlocked = outlookUnlocked,
					CardFaceType = this.GetCardFaceType(num),
					CardSpineData = this.CreateCardSpineData(num),
					CardType = (ECardType)phantomBattleCardConfig.Type
				};
				list.Add(item);
			}
			return list;
		}

		// Token: 0x060351DA RID: 217562 RVA: 0x00C960B4 File Offset: 0x00C942B4
		public List<CollectGridCardData> GetCollectCardDataList(int activityId, int elementId = -1, bool includeNpcCard = false)
		{
			IEnumerable<PhantomBattleCard> phantomBattleCardByActivityId = PhantomArenaConfig.Instance.GetPhantomBattleCardByActivityId(activityId);
			List<CollectGridCardData> list = new List<CollectGridCardData>();
			foreach (PhantomBattleCard phantomBattleCard in phantomBattleCardByActivityId)
			{
				if (phantomBattleCard.ActivityId == activityId && (!phantomBattleCard.IsNpcCard || includeNpcCard) && (elementId == -1 || phantomBattleCard.Element == elementId))
				{
					int id = phantomBattleCard.Id;
					Dictionary<int, int> dictionary = phantomBattleCard.InitAttack();
					bool outlookUnlocked = this.IsCardOutlookUnlock(id);
					int num;
					int num2;
					CollectGridCardData item = new CollectGridCardData
					{
						CardId = id,
						CardFaceTexturePath = phantomBattleCard.CardFaceTexture,
						Cost = phantomBattleCard.Cost,
						Element = phantomBattleCard.Element,
						Attack = (dictionary.TryGetValue(0, out num) ? num : 0),
						Life = (dictionary.TryGetValue(1, out num2) ? num2 : 0),
						IsLocked = !this.IsCardUnlock(id),
						CardSpineData = this.CreateCardSpineData(id),
						CardFaceType = this.GetCardFaceType(id),
						OutlookUnlocked = outlookUnlocked,
						CardType = (ECardType)phantomBattleCard.Type
					};
					list.Add(item);
				}
			}
			list.Sort(new Comparison<CollectGridCardData>(this.CardDataSort));
			return list;
		}

		// Token: 0x060351DB RID: 217563 RVA: 0x00C9621C File Offset: 0x00C9441C
		private int ElementCountSortById(CardElementCount configA, CardElementCount configB)
		{
			int elementId = configA.ElementId;
			int elementId2 = configB.ElementId;
			if (elementId == 0 && elementId2 != 0)
			{
				return 1;
			}
			if (elementId2 == 0 && elementId != 0)
			{
				return -1;
			}
			return elementId - elementId2;
		}

		// Token: 0x060351DC RID: 217564 RVA: 0x00C9624C File Offset: 0x00C9444C
		private int CardDataSort(CollectGridCardData dataA, CollectGridCardData dataB)
		{
			int element = dataA.Element;
			int element2 = dataB.Element;
			if (element == 0 && element2 != 0)
			{
				return 1;
			}
			if (element2 == 0 && element != 0)
			{
				return -1;
			}
			if (element == element2)
			{
				return dataB.Cost - dataA.Cost;
			}
			return element - element2;
		}

		// Token: 0x060351DD RID: 217565 RVA: 0x00C9628C File Offset: 0x00C9448C
		public Dictionary<int, int[]> GetCollectCardElementCount(int activityId)
		{
			List<CollectGridCardData> collectCardDataList = this.GetCollectCardDataList(activityId, -1, false);
			Dictionary<int, int[]> dictionary = new Dictionary<int, int[]>();
			foreach (CollectGridCardData collectGridCardData in collectCardDataList)
			{
				int[] array;
				if (!dictionary.TryGetValue(collectGridCardData.Element, out array))
				{
					array = new int[2];
				}
				int num = (this.IsCardUnlock(collectGridCardData.CardId) > false) ? 1 : 0;
				dictionary[collectGridCardData.Element] = new int[]
				{
					array[0] + num,
					array[1] + 1
				};
			}
			return dictionary;
		}

		// Token: 0x060351DE RID: 217566 RVA: 0x00C96330 File Offset: 0x00C94530
		public List<CardElementCount> GetCollectCardElementDataList(int activityId)
		{
			Dictionary<int, int[]> collectCardElementCount = this.GetCollectCardElementCount(activityId);
			List<CardElementCount> list = new List<CardElementCount>();
			bool flag = this.IsNewPhantomArenaActivity(activityId);
			CardElementCount cardElementCount = null;
			if (flag)
			{
				cardElementCount = new CardElementCount
				{
					ElementId = -1,
					Count = 0,
					All = 0
				};
			}
			foreach (KeyValuePair<int, int[]> keyValuePair in collectCardElementCount)
			{
				if (keyValuePair.Key != 0 || flag)
				{
					CardElementCount item = new CardElementCount
					{
						ElementId = keyValuePair.Key,
						Count = keyValuePair.Value[0],
						All = keyValuePair.Value[1]
					};
					list.Add(item);
					if (cardElementCount != null)
					{
						cardElementCount.Count += keyValuePair.Value[0];
						cardElementCount.All += keyValuePair.Value[1];
					}
				}
			}
			list.Sort(new Comparison<CardElementCount>(this.ElementCountSortById));
			if (cardElementCount != null)
			{
				list.Insert(0, cardElementCount);
			}
			return list;
		}

		// Token: 0x060351DF RID: 217567 RVA: 0x00C96444 File Offset: 0x00C94644
		private int BadgeSortById(int badgeIdA, int badgeIdB)
		{
			PhantomBattleBadge phantomBattleBadgeById = PhantomArenaConfig.Instance.GetPhantomBattleBadgeById(badgeIdA);
			PhantomBattleBadge phantomBattleBadgeById2 = PhantomArenaConfig.Instance.GetPhantomBattleBadgeById(badgeIdB);
			return phantomBattleBadgeById.SortIndex - phantomBattleBadgeById2.SortIndex;
		}

		// Token: 0x060351E0 RID: 217568 RVA: 0x00C96478 File Offset: 0x00C94678
		public List<int> GetCollectBadgeIdList(int activityId)
		{
			IEnumerable<PhantomBattleBadge> allPhantomBattleBadge = PhantomArenaConfig.Instance.GetAllPhantomBattleBadge();
			List<int> list = new List<int>();
			foreach (PhantomBattleBadge phantomBattleBadge in allPhantomBattleBadge)
			{
				if (phantomBattleBadge.ActivityId == activityId)
				{
					int id = phantomBattleBadge.Id;
					list.Add(id);
				}
			}
			return list;
		}

		// Token: 0x060351E1 RID: 217569 RVA: 0x00C964E4 File Offset: 0x00C946E4
		public Dictionary<int, List<int>> GetCollectBadgeGroupMap(int activityId)
		{
			List<int> collectBadgeIdList = this.GetCollectBadgeIdList(activityId);
			Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();
			foreach (int num in collectBadgeIdList)
			{
				int groupId = PhantomArenaConfig.Instance.GetPhantomBattleBadgeById(num).GroupId;
				List<int> list;
				if (!dictionary.TryGetValue(groupId, out list))
				{
					list = new List<int>();
					dictionary[groupId] = list;
				}
				list.Add(num);
			}
			foreach (List<int> list2 in dictionary.Values)
			{
				list2.Sort(new Comparison<int>(this.BadgeSortById));
			}
			return dictionary;
		}

		// Token: 0x060351E2 RID: 217570 RVA: 0x00C965C0 File Offset: 0x00C947C0
		public List<CollectBadgeGroupData> GetCollectBadgeGroupDataList(int activityId)
		{
			Dictionary<int, List<int>> collectBadgeGroupMap = this.GetCollectBadgeGroupMap(activityId);
			List<CollectBadgeGroupData> list = new List<CollectBadgeGroupData>();
			foreach (KeyValuePair<int, List<int>> keyValuePair in collectBadgeGroupMap)
			{
				CollectBadgeGroupData item = new CollectBadgeGroupData
				{
					GroupId = keyValuePair.Key,
					BadgeIdList = keyValuePair.Value
				};
				list.Add(item);
			}
			return list;
		}

		// Token: 0x060351E3 RID: 217571 RVA: 0x00C9663C File Offset: 0x00C9483C
		public int GetCardUnlockCount(int activityId)
		{
			IEnumerable<PhantomBattleCard> phantomBattleCardByActivityId = PhantomArenaConfig.Instance.GetPhantomBattleCardByActivityId(activityId);
			int num = 0;
			foreach (PhantomBattleCard phantomBattleCard in phantomBattleCardByActivityId)
			{
				if (phantomBattleCard.ActivityId == activityId && !phantomBattleCard.IsNpcCard && this.IsCardUnlock(phantomBattleCard.Id))
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x060351E4 RID: 217572 RVA: 0x00C966B0 File Offset: 0x00C948B0
		public int GetCardAllCount(int activityId)
		{
			IEnumerable<PhantomBattleCard> phantomBattleCardByActivityId = PhantomArenaConfig.Instance.GetPhantomBattleCardByActivityId(activityId);
			int num = 0;
			foreach (PhantomBattleCard phantomBattleCard in phantomBattleCardByActivityId)
			{
				if (phantomBattleCard.ActivityId == activityId && !phantomBattleCard.IsNpcCard)
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x060351E5 RID: 217573 RVA: 0x00C96718 File Offset: 0x00C94918
		public int GetBadgeUnlockCount(int activityId)
		{
			IEnumerable<PhantomBattleBadge> allPhantomBattleBadge = PhantomArenaConfig.Instance.GetAllPhantomBattleBadge();
			int num = 0;
			foreach (PhantomBattleBadge phantomBattleBadge in allPhantomBattleBadge)
			{
				if (this.IsBadgeUnlock(phantomBattleBadge.Id) && phantomBattleBadge.ActivityId == activityId)
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x060351E6 RID: 217574 RVA: 0x00C96784 File Offset: 0x00C94984
		public int GetBadgeAllCount(int activityId)
		{
			IEnumerable<PhantomBattleBadge> allPhantomBattleBadge = PhantomArenaConfig.Instance.GetAllPhantomBattleBadge();
			int num = 0;
			foreach (PhantomBattleBadge phantomBattleBadge in allPhantomBattleBadge)
			{
				if (phantomBattleBadge.ActivityId == activityId)
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x060351E7 RID: 217575 RVA: 0x00C967E0 File Offset: 0x00C949E0
		public ECollectRewardState GetCardRewardStateById(int rewardId)
		{
			PhantomBattleCardRewardInfo cardRewardInfoById = this.GetCardRewardInfoById(rewardId);
			int activityId = PhantomArenaConfig.Instance.GetPhantomBattleCardRewardById(rewardId).ActivityId;
			if (cardRewardInfoById == null || this.GetCardUnlockCount(activityId) < cardRewardInfoById.UnlockNum)
			{
				return ECollectRewardState.Pending;
			}
			if (!cardRewardInfoById.IsRewarded)
			{
				return ECollectRewardState.Finish;
			}
			return ECollectRewardState.Taken;
		}

		// Token: 0x060351E8 RID: 217576 RVA: 0x00C96828 File Offset: 0x00C94A28
		public int GetCardRewardNeedCountById(int rewardId)
		{
			return this.GetCardRewardInfoById(rewardId).UnlockNum;
		}

		// Token: 0x060351E9 RID: 217577 RVA: 0x00C96838 File Offset: 0x00C94A38
		public float GetCardRewardProgress(int activityId)
		{
			List<int> cardRewardConfigList = this.GetCardRewardConfigList(activityId);
			List<int> list = new List<int>();
			foreach (int rewardId in cardRewardConfigList)
			{
				int cardRewardNeedCountById = this.GetCardRewardNeedCountById(rewardId);
				list.Add(cardRewardNeedCountById);
			}
			int cardUnlockCount = this.GetCardUnlockCount(activityId);
			return this.CalculateProgressByNumberList(list, cardUnlockCount);
		}

		// Token: 0x060351EA RID: 217578 RVA: 0x00C968AC File Offset: 0x00C94AAC
		public List<RewardTuple> GetCardRewardPopupTupleData(int rewardId)
		{
			List<RewardTuple> list = new List<RewardTuple>();
			int dropId = PhantomArenaConfig.Instance.GetPhantomBattleCardRewardById(rewardId).DropId;
			Dictionary<int, int> dictionary = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackage(dropId).Value.DropPreview();
			bool isRewarded = this.GetCardRewardInfoById(rewardId).IsRewarded;
			foreach (KeyValuePair<int, int> keyValuePair in dictionary)
			{
				RewardTuple item = new RewardTuple
				{
					Id = keyValuePair.Key,
					Num = keyValuePair.Value,
					Taken = isRewarded
				};
				list.Add(item);
			}
			return list;
		}

		// Token: 0x060351EB RID: 217579 RVA: 0x00C9696C File Offset: 0x00C94B6C
		public int GetBadgeRewardNeedCountById(int rewardId)
		{
			return this.GetBadgeRewardInfoById(rewardId).UnlockNum;
		}

		// Token: 0x060351EC RID: 217580 RVA: 0x00C9697C File Offset: 0x00C94B7C
		public ECollectRewardState GetBadgeRewardStateById(int rewardId)
		{
			PhantomBattleBadgeRewardInfo badgeRewardInfoById = this.GetBadgeRewardInfoById(rewardId);
			int activityId = PhantomArenaConfig.Instance.GetPhantomBattleBadgeRewardById(rewardId).ActivityId;
			if (badgeRewardInfoById == null || this.GetBadgeUnlockCount(activityId) < badgeRewardInfoById.UnlockNum)
			{
				return ECollectRewardState.Pending;
			}
			if (!badgeRewardInfoById.IsRewarded)
			{
				return ECollectRewardState.Finish;
			}
			return ECollectRewardState.Taken;
		}

		// Token: 0x060351ED RID: 217581 RVA: 0x00C969C4 File Offset: 0x00C94BC4
		private float CalculateProgressByNumberList(List<int> numberList, int progress)
		{
			float result = 0f;
			if (numberList.Count <= 0 || progress == 0)
			{
				return result;
			}
			int num = 0;
			for (int i = 0; i < numberList.Count; i++)
			{
				int num2 = numberList[i];
				if (progress < num2)
				{
					break;
				}
				num = i + 1;
			}
			if (num >= numberList.Count)
			{
				return 1f;
			}
			int num3 = numberList[num];
			int num4 = (num > 0) ? numberList[num - 1] : 0;
			return 1f / (float)numberList.Count * ((float)num + (float)(progress - num4) / (float)(num3 - num4));
		}

		// Token: 0x060351EE RID: 217582 RVA: 0x00C96A54 File Offset: 0x00C94C54
		public float GetBadgeRewardProgress(int activityId)
		{
			List<int> badgeRewardConfigList = this.GetBadgeRewardConfigList(activityId);
			List<int> list = new List<int>();
			foreach (int rewardId in badgeRewardConfigList)
			{
				int badgeRewardNeedCountById = this.GetBadgeRewardNeedCountById(rewardId);
				list.Add(badgeRewardNeedCountById);
			}
			int badgeUnlockCount = this.GetBadgeUnlockCount(activityId);
			return this.CalculateProgressByNumberList(list, badgeUnlockCount);
		}

		// Token: 0x060351EF RID: 217583 RVA: 0x00C96AC8 File Offset: 0x00C94CC8
		public List<RewardTuple> GetBadgeRewardPopupTupleData(int rewardId)
		{
			List<RewardTuple> list = new List<RewardTuple>();
			int dropId = PhantomArenaConfig.Instance.GetPhantomBattleBadgeRewardById(rewardId).DropId;
			Dictionary<int, int> dictionary = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackage(dropId).Value.DropPreview();
			bool isRewarded = this.GetBadgeRewardInfoById(rewardId).IsRewarded;
			foreach (KeyValuePair<int, int> keyValuePair in dictionary)
			{
				RewardTuple item = new RewardTuple
				{
					Id = keyValuePair.Key,
					Num = keyValuePair.Value,
					Taken = isRewarded
				};
				list.Add(item);
			}
			return list;
		}

		// Token: 0x060351F0 RID: 217584 RVA: 0x00C96B88 File Offset: 0x00C94D88
		public List<CollectCardDetailViewTabData> GetDetailViewTabDataList()
		{
			CollectCardDetailViewTabData item = new CollectCardDetailViewTabData
			{
				Index = ECollectCardDetailViewTab.Detail,
				NameId = "PhantomBattle_1013"
			};
			CollectCardDetailViewTabData item2 = new CollectCardDetailViewTabData
			{
				Index = ECollectCardDetailViewTab.Outlook,
				NameId = "PhantomBattle_1014"
			};
			return new List<CollectCardDetailViewTabData>
			{
				item,
				item2
			};
		}

		// Token: 0x060351F1 RID: 217585 RVA: 0x00C96BD8 File Offset: 0x00C94DD8
		public CardDetailItemData GetDetailViewDetailItemData(int cardId, [Nullable(2)] DeckInfo deckInfo = null)
		{
			PhantomBattleCard phantomBattleCardConfig = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(cardId);
			if (phantomBattleCardConfig.Type == 3)
			{
				return this.GetFieldCardDetailItemData(phantomBattleCardConfig, deckInfo);
			}
			return this.GetNormalCardDetailItemData(phantomBattleCardConfig);
		}

		// Token: 0x060351F2 RID: 217586 RVA: 0x00C96C0B File Offset: 0x00C94E0B
		[NullableContext(2)]
		private ICardDetailActiveSkillData GetActiveSkillData(PhantomBattleCard config)
		{
			if (config.DurableSkillId > 0)
			{
				return new CardDetailActiveSkillData
				{
					Desc = config.DurableSkillDescription,
					Params = config.DurableSkillDescriptionParams().ToList<string>()
				};
			}
			return null;
		}

		// Token: 0x060351F3 RID: 217587 RVA: 0x00C96C40 File Offset: 0x00C94E40
		public CardDetailItemData GetFieldCardDetailItemData(PhantomBattleCard config, [Nullable(2)] DeckInfo deckInfo = null)
		{
			int? num;
			if (deckInfo == null)
			{
				num = null;
			}
			else
			{
				DeckCardSlotInfo fieldCardSlot = deckInfo.GetFieldCardSlot();
				num = ((fieldCardSlot != null) ? new int?(fieldCardSlot.CardId) : null);
			}
			int? num2 = num;
			int id = config.Id;
			bool flag = num2.GetValueOrDefault() == id & num2 != null;
			int num3 = flag ? ((deckInfo != null) ? deckInfo.GetFieldCardConditionCurNum() : 0) : 0;
			int num4 = flag ? ((deckInfo != null) ? deckInfo.GetFieldCardConditionTargetNum() : 0) : 0;
			string conditionDesc = (num3 >= num4 && num4 != 0) ? config.FieldConditionDesc : config.FieldUnlockConditionDesc;
			ICardDetailConditionOutData outData = new CardDetailConditionOutData
			{
				CurrentProgress = num3,
				MaxProgress = num4,
				Icon = config.FieldConditionIcon,
				ConditionDesc = conditionDesc
			};
			int num5;
			int totalEffectCount = config.InitAttack().TryGetValue(14, out num5) ? num5 : 0;
			ICardDetailEffectCountData cardDetailEffectCountData;
			if (config.CountSkill <= 0)
			{
				cardDetailEffectCountData = null;
			}
			else
			{
				CardDetailEffectCountData cardDetailEffectCountData2 = new CardDetailEffectCountData();
				cardDetailEffectCountData2.CurrentEffectCount = 0;
				cardDetailEffectCountData = cardDetailEffectCountData2;
				cardDetailEffectCountData2.TotalEffectCount = totalEffectCount;
			}
			ICardDetailEffectCountData effectCountData = cardDetailEffectCountData;
			ICardDetailPassiveSkillData passiveSkillData = new CardDetailPassiveSkillData
			{
				Desc = ((config.CountSkill > 0) ? config.CountSkillDescription : config.CardEffectDescription),
				Params = ((config.CountSkill > 0) ? config.CountSkillDescriptionParams() : config.CardEffectDescriptionParams()).ToList<string>(),
				FieldData = new CardDetailPassiveSkillFieldData
				{
					OutData = outData
				},
				EffectCountData = effectCountData
			};
			ICardDetailActiveSkillData activeSkillData = this.GetActiveSkillData(config);
			return new CardDetailItemData
			{
				Name = config.Name,
				ActiveSkillData = ((config.DurableSkillId > 0) ? activeSkillData : null),
				PassiveSkillData = passiveSkillData
			};
		}

		// Token: 0x060351F4 RID: 217588 RVA: 0x00C96DE0 File Offset: 0x00C94FE0
		[NullableContext(2)]
		private ICardDetailPassiveSkillData GetCountSkillData(PhantomBattleCard config)
		{
			if (config.CountSkill > 0)
			{
				int num;
				int totalEffectCount = config.InitAttack().TryGetValue(14, out num) ? num : 0;
				ICardDetailEffectCountData effectCountData = new CardDetailEffectCountData
				{
					CurrentEffectCount = 0,
					TotalEffectCount = totalEffectCount
				};
				return new CardDetailPassiveSkillData
				{
					Desc = config.CountSkillDescription,
					Params = config.CountSkillDescriptionParams().ToList<string>(),
					EffectCountData = effectCountData
				};
			}
			return null;
		}

		// Token: 0x060351F5 RID: 217589 RVA: 0x00C96E50 File Offset: 0x00C95050
		[NullableContext(2)]
		private ICardDetailDurationData GetDurationData(PhantomBattleCard config)
		{
			int num2;
			int num = config.InitAttack().TryGetValue(12, out num2) ? num2 : 0;
			if (num > 0)
			{
				CardDetailDurationData cardDetailDurationData = new CardDetailDurationData();
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(num);
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted<int>(num);
				cardDetailDurationData.DurationDesc = defaultInterpolatedStringHandler.ToStringAndClear();
				return cardDetailDurationData;
			}
			return null;
		}

		// Token: 0x060351F6 RID: 217590 RVA: 0x00C96EB4 File Offset: 0x00C950B4
		public CardDetailItemData GetNormalCardDetailItemData(PhantomBattleCard config)
		{
			Dictionary<int, int> dictionary = config.InitAttack();
			IEnumerable<int> enumerable = config.CardFactorId();
			List<CardDetailFactorDescItemData> list = new List<CardDetailFactorDescItemData>();
			foreach (int factorConfigId in enumerable)
			{
				list.Add(new CardDetailFactorDescItemData
				{
					FactorConfigId = factorConfigId,
					IsActive = false
				});
			}
			int num;
			int num2;
			ICardAttributeData cardAttributeData = new CardAttributeData
			{
				Cost = config.Cost,
				Attack = (dictionary.TryGetValue(0, out num) ? num : 0),
				Life = (dictionary.TryGetValue(1, out num2) ? num2 : 0)
			};
			ICardDescriptionData cardDescriptionData = new CardDescriptionData
			{
				Description = config.CardEffectDescription,
				DescriptionParams = config.CardEffectDescriptionParams().ToList<string>()
			};
			ICardDetailDurationData durationData = this.GetDurationData(config);
			ICardDetailActiveSkillData activeSkillData = this.GetActiveSkillData(config);
			ICardDetailPassiveSkillData countSkillData = this.GetCountSkillData(config);
			bool flag = config.Type == 2;
			return new CardDetailItemData
			{
				Name = config.Name,
				AttributeData = (flag ? null : cardAttributeData),
				CardDescriptionData = (flag ? null : cardDescriptionData),
				FactorDataList = list,
				DurationData = durationData,
				ActiveSkillData = activeSkillData,
				PassiveSkillData = countSkillData
			};
		}

		// Token: 0x060351F7 RID: 217591 RVA: 0x00C97008 File Offset: 0x00C95208
		public List<int> GetDetailViewEntryData(int cardId)
		{
			List<int> list = new List<int>();
			PhantomBattleCard phantomBattleCardConfig = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(cardId);
			list.AddRange(phantomBattleCardConfig.GetEntryIdListBytes());
			foreach (int factorConfigId in ((IEnumerable<int>)phantomBattleCardConfig.CardFactorId()))
			{
				int entryId = PhantomArenaConfig.Instance.GetPhantomBattleFactorConfig(factorConfigId).EntryId;
				if (entryId > 0 && !list.Contains(entryId))
				{
					list.Add(entryId);
				}
			}
			return list;
		}

		// Token: 0x060351F8 RID: 217592 RVA: 0x00C970A4 File Offset: 0x00C952A4
		public void UpdateCardRewardByNotify(PhantomBattleCardRewardInfoUpdateNotify notify)
		{
			IReadOnlyList<PhantomBattleCardRewardInfo> phantomBattleCardRewardInfos = notify.PhantomBattleCardRewardInfos;
			int activityId = PhantomArenaConfig.Instance.GetPhantomBattleCardRewardById(phantomBattleCardRewardInfos[0].PhantomBattleCardRewardId).ActivityId;
			this.GetPhantomArenaActivityData(activityId).UpdateCardReward(phantomBattleCardRewardInfos.ToArray<PhantomBattleCardRewardInfo>());
		}

		// Token: 0x060351F9 RID: 217593 RVA: 0x00C970EC File Offset: 0x00C952EC
		public void UpdateCardRewardByIds(List<int> rewardIds)
		{
			int activityId = PhantomArenaConfig.Instance.GetPhantomBattleCardRewardById(rewardIds[0]).ActivityId;
			this.GetPhantomArenaActivityData(activityId).UpdateCardRewardByIds(rewardIds);
		}

		// Token: 0x060351FA RID: 217594 RVA: 0x00C97120 File Offset: 0x00C95320
		public void AddBadgeListByNotify(PhantomBattleBadgeInfoUpdateNotify notify)
		{
			IReadOnlyList<PhantomBattleBadgeInfo> phantomBattleBadgeInfos = notify.PhantomBattleBadgeInfos;
			int activityId = PhantomArenaConfig.Instance.GetPhantomBattleBadgeById(phantomBattleBadgeInfos[0].PhantomBattleBadgeId).ActivityId;
			this.GetPhantomArenaActivityData(activityId).AddBadgeListByNotify(phantomBattleBadgeInfos.ToArray<PhantomBattleBadgeInfo>());
		}

		// Token: 0x060351FB RID: 217595 RVA: 0x00C97168 File Offset: 0x00C95368
		public void UpdateBadgeRewardByNotify(PhantomBattleBadgeRewardInfoUpdateNotify notify)
		{
			IReadOnlyList<PhantomBattleBadgeRewardInfo> phantomBattleBadgeRewardInfos = notify.PhantomBattleBadgeRewardInfos;
			int activityId = PhantomArenaConfig.Instance.GetPhantomBattleBadgeRewardById(phantomBattleBadgeRewardInfos[0].PhantomBattleBadgeRewardId).ActivityId;
			this.GetPhantomArenaActivityData(activityId).UpdateBadgeReward(phantomBattleBadgeRewardInfos.ToArray<PhantomBattleBadgeRewardInfo>());
		}

		// Token: 0x060351FC RID: 217596 RVA: 0x00C971B0 File Offset: 0x00C953B0
		public void UpdateBadgeRewardByIds(List<int> rewardIds)
		{
			int activityId = PhantomArenaConfig.Instance.GetPhantomBattleBadgeRewardById(rewardIds[0]).ActivityId;
			this.GetPhantomArenaActivityData(activityId).UpdateBadgeRewardByIds(rewardIds);
		}

		// Token: 0x060351FD RID: 217597 RVA: 0x00C971E4 File Offset: 0x00C953E4
		public List<int> GetCardRewardConfigList(int activityId)
		{
			return PhantomArenaConfig.Instance.GetPhantomBattleCardRewardIdList(activityId).ToList<int>();
		}

		// Token: 0x060351FE RID: 217598 RVA: 0x00C971F6 File Offset: 0x00C953F6
		public List<int> GetBadgeRewardConfigList(int activityId)
		{
			return PhantomArenaConfig.Instance.GetPhantomBattleBadgeRewardIdList(activityId).ToList<int>();
		}

		// Token: 0x060351FF RID: 217599 RVA: 0x00C97208 File Offset: 0x00C95408
		public PhantomBattleCardRewardInfo GetCardRewardInfoById(int rewardId)
		{
			int activityId = PhantomArenaConfig.Instance.GetPhantomBattleCardRewardById(rewardId).ActivityId;
			return this.GetPhantomArenaActivityData(activityId).GetCardRewardInfoById(rewardId);
		}

		// Token: 0x06035200 RID: 217600 RVA: 0x00C97238 File Offset: 0x00C95438
		public PhantomBattleBadgeRewardInfo GetBadgeRewardInfoById(int rewardId)
		{
			int activityId = PhantomArenaConfig.Instance.GetPhantomBattleBadgeRewardById(rewardId).ActivityId;
			return this.GetPhantomArenaActivityData(activityId).GetBadgeRewardInfoById(rewardId);
		}

		// Token: 0x06035201 RID: 217601 RVA: 0x00C97268 File Offset: 0x00C95468
		public unsafe List<BadgeGroupSkillData> GetBadgeSkillByGroupId(int groupId)
		{
			Span<int> phantomBattleSkillIdBytes = PhantomArenaConfig.Instance.GetPhantomBattleBadgeGroupById(groupId).GetPhantomBattleSkillIdBytes();
			List<BadgeGroupSkillData> list = new List<BadgeGroupSkillData>();
			Span<int> span = phantomBattleSkillIdBytes;
			for (int i = 0; i < span.Length; i++)
			{
				int skillId = *span[i];
				BadgeGroupSkillData item = new BadgeGroupSkillData
				{
					GroupId = groupId,
					SkillId = skillId
				};
				list.Add(item);
			}
			return list;
		}

		// Token: 0x06035202 RID: 217602 RVA: 0x00C972CC File Offset: 0x00C954CC
		public BadgeGroupCollectCountData GetBadgeCollectCountByGroupId(int groupId)
		{
			int activityId = PhantomArenaConfig.Instance.GetPhantomBattleBadgeGroupById(groupId).ActivityId;
			List<int> list;
			if (!this.GetCollectBadgeGroupMap(activityId).TryGetValue(groupId, out list))
			{
				list = new List<int>();
			}
			PhantomBattleBadgeGroup phantomBattleBadgeGroupById = PhantomArenaConfig.Instance.GetPhantomBattleBadgeGroupById(groupId);
			int num = 0;
			foreach (int badgeId in list)
			{
				if (this.IsBadgeUnlock(badgeId))
				{
					num++;
				}
			}
			return new BadgeGroupCollectCountData
			{
				Now = num,
				Need = phantomBattleBadgeGroupById.Num,
				All = list.Count
			};
		}

		// Token: 0x06035203 RID: 217603 RVA: 0x00C97384 File Offset: 0x00C95584
		public void UpdateTaskInfo(PhantomBattleTaskInfoNotify notify)
		{
			IReadOnlyList<ActivityTask> activityTasks = notify.ActivityTasks;
			int activityId = PhantomArenaConfig.Instance.GetTaskConfigById(activityTasks[0].Id).Value.ActivityId;
			this.GetPhantomArenaActivityData(activityId).UpdateTaskInfo(activityTasks.ToArray<ActivityTask>());
		}

		// Token: 0x06035204 RID: 217604 RVA: 0x00C973D4 File Offset: 0x00C955D4
		public void UpdateTaskByIds(List<int> taskIds)
		{
			int activityId = PhantomArenaConfig.Instance.GetTaskConfigById(taskIds[0]).Value.ActivityId;
			this.GetPhantomArenaActivityData(activityId).UpdateTaskByIdList(taskIds);
		}

		// Token: 0x06035205 RID: 217605 RVA: 0x00C97410 File Offset: 0x00C95610
		public List<int> GetTaskTabList(int activityId)
		{
			Dictionary<int, List<int>> taskTabMap = this.GetPhantomArenaActivityData(activityId).GetTaskTabMap();
			List<int> list = new List<int>();
			foreach (KeyValuePair<int, List<int>> keyValuePair in taskTabMap)
			{
				if (keyValuePair.Value.Count > 0)
				{
					list.Add(keyValuePair.Key);
				}
			}
			list.Sort(delegate(int a, int b)
			{
				PhantomBattleTaskTab value = PhantomArenaConfig.Instance.GetTaskTabConfigById(a).Value;
				return PhantomArenaConfig.Instance.GetTaskTabConfigById(b).Value.Order - value.Order;
			});
			return list;
		}

		// Token: 0x06035206 RID: 217606 RVA: 0x00C974AC File Offset: 0x00C956AC
		public List<PhantomArenaTaskData> GetTaskDataByTabId(int tabId, int activityId)
		{
			Dictionary<int, List<int>> taskTabMap = this.GetPhantomArenaActivityData(activityId).GetTaskTabMap();
			Dictionary<int, ActivityTask> taskMap = this.GetPhantomArenaActivityData(activityId).GetTaskMap();
			List<int> list;
			if (!taskTabMap.TryGetValue(tabId, out list))
			{
				return new List<PhantomArenaTaskData>();
			}
			List<PhantomArenaTaskData> list2 = new List<PhantomArenaTaskData>();
			int shopItemId = PhantomArenaConfig.Instance.GetPhantomBattleActivityConfig(activityId).ShopItemId;
			foreach (int num in list)
			{
				PhantomBattleTask? taskConfigById = PhantomArenaConfig.Instance.GetTaskConfigById(num);
				int normalDropId = taskConfigById.Value.NormalDropId;
				List<TItem> previewReward = this.GetPhantomArenaActivityData(activityId).GetPreviewReward(new int?(normalDropId));
				if (this.IsInLimitTime(activityId, null).Item1)
				{
					bool flag = false;
					for (int i = 0; i <= previewReward.Count; i++)
					{
						TItem titem = previewReward[i];
						if (titem.ItemData.ItemId == shopItemId)
						{
							flag = true;
							titem.Count += taskConfigById.Value.LimitShopItemNum;
						}
					}
					if (!flag)
					{
						TItem item = new TItem(new InventoryDefine.GetItemData(shopItemId, 0), taskConfigById.Value.LimitShopItemNum);
						previewReward.Insert(0, item);
					}
				}
				PhantomArenaTaskData item2 = new PhantomArenaTaskData
				{
					TaskConfig = taskMap[num],
					Reward = previewReward
				};
				list2.Add(item2);
			}
			return list2;
		}

		// Token: 0x06035207 RID: 217607 RVA: 0x00C97634 File Offset: 0x00C95834
		[NullableContext(2)]
		public ActivityTask GetSpecialTask(int activityId)
		{
			return this.GetPhantomArenaActivityData(activityId).GetSpecialTask();
		}

		// Token: 0x06035208 RID: 217608 RVA: 0x00C97642 File Offset: 0x00C95842
		public List<int> GetAllCanReceiveTaskIdsByTabId(int activityId, int tabId)
		{
			return this.GetPhantomArenaActivityData(activityId).GetAllCanReceiveTaskIdsByTabId(tabId);
		}

		// Token: 0x06035209 RID: 217609 RVA: 0x00C97654 File Offset: 0x00C95854
		[NullableContext(0)]
		[return: TupleElementNames(new string[]
		{
			"Current",
			"Target"
		})]
		public ValueTuple<int, int> GetAllTaskProgress(int activityId)
		{
			Dictionary<int, ActivityTask> taskMap = this.GetPhantomArenaActivityData(activityId).GetTaskMap();
			ValueTuple<int, int> result = new ValueTuple<int, int>(0, taskMap.Count);
			using (Dictionary<int, ActivityTask>.ValueCollection.Enumerator enumerator = taskMap.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.Status >= ActivityTaskState.ActivityTaskFinish)
					{
						result.Item1++;
					}
				}
			}
			return result;
		}

		// Token: 0x0603520A RID: 217610 RVA: 0x00C976D0 File Offset: 0x00C958D0
		public int GetAllTaskSecondCurrencyNum(int activityId)
		{
			Dictionary<int, ActivityTask> taskMap = this.GetPhantomArenaActivityData(activityId).GetTaskMap();
			GachaConfig instance = GachaConfig.Instance;
			int? num = (instance != null) ? instance.SecondCurrency() : null;
			int num2 = 0;
			foreach (int taskId in taskMap.Keys)
			{
				PhantomArenaConfig instance2 = PhantomArenaConfig.Instance;
				PhantomBattleTask? phantomBattleTask = (instance2 != null) ? instance2.GetTaskConfigById(taskId) : null;
				int? num3 = (phantomBattleTask != null) ? new int?(phantomBattleTask.GetValueOrDefault().NormalDropId) : null;
				if (num3 != null)
				{
					CSharpScript.Game.Module.Reward.RewardConfig instance3 = CSharpScript.Game.Module.Reward.RewardConfig.Instance;
					DropPackage? dropPackage;
					Dictionary<int, int> dictionary = (instance3 != null) ? ((instance3.GetDropPackage(num3.Value) != null) ? dropPackage.GetValueOrDefault().DropPreview() : null) : null;
					if (dictionary != null)
					{
						foreach (KeyValuePair<int, int> keyValuePair in dictionary)
						{
							int key = keyValuePair.Key;
							int? num4 = num;
							if (key == num4.GetValueOrDefault() & num4 != null)
							{
								num2 += keyValuePair.Value;
								break;
							}
						}
					}
				}
			}
			return num2;
		}

		// Token: 0x0603520B RID: 217611 RVA: 0x00C97858 File Offset: 0x00C95A58
		public bool GetCacheShopOpen(string shopData)
		{
			string text = LocalStorage.GetPlayer<string>(ELocalStoragePlayerKey.PhantomArenaEntranceShopRefresh, null) ?? "";
			if (shopData.Length < text.Length)
			{
				this.SetCacheShopOpen(shopData);
				return true;
			}
			return text == shopData;
		}

		// Token: 0x0603520C RID: 217612 RVA: 0x00C97898 File Offset: 0x00C95A98
		public void SetCacheShopOpen(string shopData)
		{
			LocalStorage.SetPlayer<string>(ELocalStoragePlayerKey.PhantomArenaEntranceShopRefresh, shopData);
		}

		// Token: 0x0603520D RID: 217613 RVA: 0x00C978A6 File Offset: 0x00C95AA6
		public int GetCurrencyId(int activityId)
		{
			return this.GetPhantomArenaActivityData(activityId).GetCurrencyId();
		}

		// Token: 0x0603520E RID: 217614 RVA: 0x00C978B4 File Offset: 0x00C95AB4
		public List<object> GetShopList(int activityId)
		{
			int shopId = this.GetPhantomArenaActivityData(activityId).GetShopId();
			if (shopId == 0)
			{
				return new List<object>();
			}
			return PayShopModel.Instance.GetPayShopTabData((PayShopDefine.EPayShopTabType)shopId, 1, true).Cast<object>().ToList<object>();
		}

		// Token: 0x0603520F RID: 217615 RVA: 0x00C978F0 File Offset: 0x00C95AF0
		public void OnShopViewOpen(int activityId)
		{
			int shopId = this.GetPhantomArenaActivityData(activityId).GetShopId();
			if (shopId == 0)
			{
				return;
			}
			List<PayShopGoods> payShopTabData = PayShopModel.Instance.GetPayShopTabData((PayShopDefine.EPayShopTabType)shopId, 1, true);
			List<int> curUnlockShopData = this.GetCurUnlockShopData(payShopTabData);
			this.SetCacheShopOpen(string.Join<int>(",", curUnlockShopData));
			EventSystem.Instance.Emit(EEventName.OnPhantomArenaShopOpen);
		}

		// Token: 0x06035210 RID: 217616 RVA: 0x00C97945 File Offset: 0x00C95B45
		[NullableContext(2)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public ValueTuple<bool, string> IsInLimitTime(int activityId, string textId = null)
		{
			return this.GetPhantomArenaActivityData(activityId).GetIsInLimitTime(textId);
		}

		// Token: 0x06035211 RID: 217617 RVA: 0x00C97954 File Offset: 0x00C95B54
		public bool IsRoleUnlock(int roleId)
		{
			int activityId = PhantomArenaConfig.Instance.GetPhantomBattleCardRole(roleId).ActivityId;
			return this.GetPhantomArenaActivityData(activityId).IsRoleUnlock(roleId);
		}

		// Token: 0x06035212 RID: 217618 RVA: 0x00C97984 File Offset: 0x00C95B84
		public unsafe bool IsRoleReward(int roleId)
		{
			int activityId = PhantomArenaConfig.Instance.GetPhantomBattleCardRole(roleId).ActivityId;
			Span<int> mainRoleListBytes = PhantomArenaConfig.Instance.GetPhantomBattleActivityConfig(activityId).GetMainRoleListBytes();
			if (mainRoleListBytes.Contains(roleId))
			{
				Span<int> span = mainRoleListBytes;
				for (int i = 0; i < span.Length; i++)
				{
					int roleId2 = *span[i];
					if (this.GetPhantomArenaActivityData(activityId).IsRoleReward(roleId2))
					{
						return true;
					}
				}
			}
			return this.GetPhantomArenaActivityData(activityId).IsRoleReward(roleId);
		}

		// Token: 0x06035213 RID: 217619 RVA: 0x00C97A08 File Offset: 0x00C95C08
		public bool IsMainRole(int roleId)
		{
			int activityId = PhantomArenaConfig.Instance.GetPhantomBattleCardRole(roleId).ActivityId;
			return PhantomArenaConfig.Instance.GetPhantomBattleActivityConfig(activityId).GetMainRoleListBytes().Contains(roleId);
		}

		// Token: 0x06035214 RID: 217620 RVA: 0x00C97A44 File Offset: 0x00C95C44
		public List<int> GetCardRoleList(int activityId)
		{
			List<int> list = new List<int>();
			IEnumerable<PhantomBattleCardRole> phantomBattleCardRoleByActivityId = PhantomArenaConfig.Instance.GetPhantomBattleCardRoleByActivityId(activityId);
			EPlayerGender playerGender = PlayerInfoModel.Instance.GetPlayerGender();
			foreach (PhantomBattleCardRole phantomBattleCardRole in phantomBattleCardRoleByActivityId)
			{
				if (!phantomBattleCardRole.IsTrail && (phantomBattleCardRole.Type == 0 || (phantomBattleCardRole.Type == 2 && playerGender == EPlayerGender.Female) || (phantomBattleCardRole.Type == 1 && playerGender == EPlayerGender.Male)))
				{
					list.Add(phantomBattleCardRole.Id);
				}
			}
			return list;
		}

		// Token: 0x06035215 RID: 217621 RVA: 0x00C97ADC File Offset: 0x00C95CDC
		public List<PhantomCardData> CreateCardDataList(IReadOnlyList<PhantomBattleHandCardInfo> dataInfoList)
		{
			List<PhantomCardData> list = new List<PhantomCardData>();
			foreach (PhantomBattleHandCardInfo dataInfo in dataInfoList)
			{
				PhantomCardData phantomCardData = new PhantomCardData(false);
				phantomCardData.InitData(dataInfo);
				list.Add(phantomCardData);
			}
			return list;
		}

		// Token: 0x06035216 RID: 217622 RVA: 0x00C97B3C File Offset: 0x00C95D3C
		public bool GetPhantomArenaActivityRedDot(int activityId)
		{
			return this.GetMasterLevelRewardRedDot(activityId) || this.CheckTaskRedDot(activityId) || this.CheckShopRedDot(activityId) || this.GetRoleRewardRedDot(activityId) || this.GetCardRewardRedDot(activityId) || this.GetBadgeRewardRedDot(activityId) || this.GetGymRedDot(activityId);
		}

		// Token: 0x06035217 RID: 217623 RVA: 0x00C97B88 File Offset: 0x00C95D88
		public bool GetPermanentPhantomArenaActivityRedDot(int activityId)
		{
			return this.CheckTaskRedDot(activityId) || this.GetRoleRewardRedDot(activityId) || this.GetCardRewardRedDot(activityId);
		}

		// Token: 0x06035218 RID: 217624 RVA: 0x00C97BA8 File Offset: 0x00C95DA8
		public bool GetChallengeUnlockRedDot(int activityId)
		{
			if (!this.GetActivityUnlock(activityId))
			{
				return false;
			}
			PhantomArenaActivityData permanentPhantomArenaActivityData = this.GetPermanentPhantomArenaActivityData();
			List<int> list = (permanentPhantomArenaActivityData != null) ? permanentPhantomArenaActivityData.GetAllChallengeIds() : null;
			if (list == null)
			{
				return false;
			}
			foreach (int challengeId in list)
			{
				if (this.GetChallengeUnlockRedDotById(challengeId))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06035219 RID: 217625 RVA: 0x00C97C24 File Offset: 0x00C95E24
		public bool GetChallengeUnlockRedDotById(int challengeId)
		{
			if (this.GetPermanentChallengeStateById(challengeId) == EChallengeState.Lock)
			{
				return false;
			}
			Dictionary<int, bool> player = LocalStorage.GetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.PhantomArenaChallengeUnlockRedDotCheck, null);
			return player != null && player.ContainsKey(challengeId) && !player[challengeId];
		}

		// Token: 0x0603521A RID: 217626 RVA: 0x00C97C60 File Offset: 0x00C95E60
		public bool GetMapUnlockRedDot()
		{
			Dictionary<int, bool> player = LocalStorage.GetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.PhantomArenaMapUnlockRedDotCheck, null);
			if (player == null)
			{
				return false;
			}
			using (Dictionary<int, bool>.ValueCollection.Enumerator enumerator = player.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x0603521B RID: 217627 RVA: 0x00C97CC8 File Offset: 0x00C95EC8
		public bool GetMapUnlockRedDotById(int mapId)
		{
			Dictionary<int, bool> player = LocalStorage.GetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.PhantomArenaMapUnlockRedDotCheck, null);
			bool flag;
			return player != null && player.TryGetValue(mapId, out flag) && flag;
		}

		// Token: 0x0603521C RID: 217628 RVA: 0x00C97CF4 File Offset: 0x00C95EF4
		public void SaveChallengeUnlockRedDotById(int challengeId, bool isUnlock)
		{
			Dictionary<int, bool> dictionary = LocalStorage.GetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.PhantomArenaChallengeUnlockRedDotCheck, null);
			if (dictionary == null)
			{
				dictionary = new Dictionary<int, bool>();
			}
			dictionary[challengeId] = isUnlock;
			LocalStorage.SetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.PhantomArenaChallengeUnlockRedDotCheck, dictionary);
		}

		// Token: 0x0603521D RID: 217629 RVA: 0x00C97D2C File Offset: 0x00C95F2C
		public void SaveMapUnlockRedDotById(int mapId, bool isUnlock)
		{
			if (mapId == 1)
			{
				return;
			}
			Dictionary<int, bool> dictionary = LocalStorage.GetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.PhantomArenaMapUnlockRedDotCheck, null) ?? new Dictionary<int, bool>();
			if (isUnlock)
			{
				if (!dictionary.ContainsKey(mapId))
				{
					dictionary[mapId] = true;
					EventSystem.Instance.Emit<int>(EEventName.OnPhantomArenaMapUnlockUpdate, mapId);
				}
			}
			else if (dictionary.ContainsKey(mapId))
			{
				dictionary[mapId] = false;
				EventSystem.Instance.Emit<int>(EEventName.OnPhantomArenaMapUnlockUpdate, mapId);
			}
			LocalStorage.SetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.PhantomArenaMapUnlockRedDotCheck, dictionary);
		}

		// Token: 0x0603521E RID: 217630 RVA: 0x00C97DA8 File Offset: 0x00C95FA8
		private void RefreshPhantomArenaActivityRedDot(int activityId)
		{
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, activityId);
		}

		// Token: 0x0603521F RID: 217631 RVA: 0x00C97DBB File Offset: 0x00C95FBB
		public bool GetPhantomArenaButtonRedDot(int activityId)
		{
			this.RefreshPhantomArenaActivityRedDot(activityId);
			return this.GetRoleRewardRedDot(activityId) || this.GetCardRewardRedDot(activityId) || this.GetBadgeRewardRedDot(activityId) || this.GetGymRedDot(activityId);
		}

		// Token: 0x06035220 RID: 217632 RVA: 0x00C97DE8 File Offset: 0x00C95FE8
		public bool GetGymRedDot(int activityId)
		{
			if (!this.GetActivityUnlock(activityId))
			{
				return false;
			}
			foreach (int gymLevel in this.GetPhantomBattleGymLevelList(activityId, null))
			{
				if (this.GetGymRedDotById(gymLevel, activityId))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06035221 RID: 217633 RVA: 0x00C97E5C File Offset: 0x00C9605C
		public bool GetGymRedDotById(int gymLevel, int activityId)
		{
			if (this.IsGymLock(gymLevel, activityId))
			{
				return false;
			}
			Dictionary<int, List<int>> player = LocalStorage.GetPlayer<Dictionary<int, List<int>>>(ELocalStoragePlayerKey.PhantomArenaEntranceGymRedDotCheck, null);
			if (player == null || !player.ContainsKey(activityId))
			{
				Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();
				dictionary[activityId] = new List<int>();
				LocalStorage.SetPlayer<Dictionary<int, List<int>>>(ELocalStoragePlayerKey.PhantomArenaEntranceGymRedDotCheck, dictionary);
				return false;
			}
			return !player[activityId].Contains(gymLevel);
		}

		// Token: 0x06035222 RID: 217634 RVA: 0x00C97EC0 File Offset: 0x00C960C0
		public void SetGymRedDotChecked(int gymLevel, int activityId)
		{
			Dictionary<int, List<int>> player = LocalStorage.GetPlayer<Dictionary<int, List<int>>>(ELocalStoragePlayerKey.PhantomArenaEntranceGymRedDotCheck, null);
			if (player == null || !player.ContainsKey(activityId))
			{
				Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();
				dictionary[activityId] = new List<int>
				{
					gymLevel
				};
				LocalStorage.SetPlayer<Dictionary<int, List<int>>>(ELocalStoragePlayerKey.PhantomArenaEntranceGymRedDotCheck, dictionary);
			}
			else
			{
				List<int> list = player[activityId];
				if (!list.Contains(gymLevel))
				{
					list.Add(gymLevel);
					player[activityId] = list;
					LocalStorage.SetPlayer<Dictionary<int, List<int>>>(ELocalStoragePlayerKey.PhantomArenaEntranceGymRedDotCheck, player);
				}
			}
			EventSystem.Instance.Emit(EEventName.OnPhantomArenaChallengeUpdate);
		}

		// Token: 0x06035223 RID: 217635 RVA: 0x00C97F48 File Offset: 0x00C96148
		public bool GetRoleRewardRedDot(int activityId)
		{
			if (!this.GetActivityUnlock(activityId))
			{
				return false;
			}
			foreach (int roleId in PhantomArenaModel.Instance.GetCardRoleList(activityId))
			{
				bool flag = this.GetPhantomArenaActivityData(activityId).IsRoleUnlock(roleId);
				bool flag2 = this.GetPhantomArenaActivityData(activityId).IsRoleReward(roleId);
				if (flag && !flag2)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06035224 RID: 217636 RVA: 0x00C97FCC File Offset: 0x00C961CC
		public bool GetMasterLevelRewardRedDot(int activityId)
		{
			if (!this.GetActivityUnlock(activityId) || this.GetMasterExpNow(activityId, null) == 0)
			{
				return false;
			}
			foreach (PhantomBattleMasterLevel phantomBattleMasterLevel in this.GetPhantomBattleMasterLevelConfigList(activityId))
			{
				int level = phantomBattleMasterLevel.Level;
				if (this.GetMasterLevelRewardCanTake(level, activityId))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06035225 RID: 217637 RVA: 0x00C98054 File Offset: 0x00C96254
		public bool CheckTaskRedDot(int activityId)
		{
			PhantomArenaActivityData phantomArenaActivityData = this.GetPhantomArenaActivityData(activityId);
			if (phantomArenaActivityData == null)
			{
				return false;
			}
			if (!this.IsInLimitTime(activityId, null).Item1 && phantomArenaActivityData.TimeType != EActivityTimeType.Permanent)
			{
				return false;
			}
			Dictionary<int, ActivityTask> taskMap = this.GetPhantomArenaActivityData(activityId).GetTaskMap();
			foreach (KeyValuePair<int, List<int>> keyValuePair in this.GetPhantomArenaActivityData(activityId).GetTaskTabMap())
			{
				foreach (int key in keyValuePair.Value)
				{
					ActivityTask activityTask2;
					ActivityTask activityTask = taskMap.TryGetValue(key, out activityTask2) ? activityTask2 : null;
					if (activityTask != null && activityTask.Status == ActivityTaskState.ActivityTaskFinish)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06035226 RID: 217638 RVA: 0x00C98144 File Offset: 0x00C96344
		public bool CheckTaskRedDotByTab(int tabId, int activityId)
		{
			Dictionary<int, ActivityTask> taskMap = this.GetPhantomArenaActivityData(activityId).GetTaskMap();
			List<int> list;
			if (!this.GetPhantomArenaActivityData(activityId).GetTaskTabMap().TryGetValue(tabId, out list))
			{
				return false;
			}
			foreach (int key in list)
			{
				ActivityTask activityTask2;
				ActivityTask activityTask = taskMap.TryGetValue(key, out activityTask2) ? activityTask2 : null;
				if (activityTask != null && activityTask.Status == ActivityTaskState.ActivityTaskFinish)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06035227 RID: 217639 RVA: 0x00C981DC File Offset: 0x00C963DC
		public bool CheckShopRedDot(int activityId)
		{
			if (!this.GetActivityUnlock(activityId))
			{
				return false;
			}
			if (!this.IsInLimitTime(activityId, null).Item1)
			{
				return false;
			}
			PhantomArenaActivityData phantomArenaActivityData = this.GetPhantomArenaActivityData(activityId);
			int? num = (phantomArenaActivityData != null) ? new int?(phantomArenaActivityData.GetShopId()) : null;
			if (num != null)
			{
				int? num2 = num;
				int num3 = 0;
				if (!(num2.GetValueOrDefault() == num3 & num2 != null))
				{
					if (phantomArenaActivityData == null || !phantomArenaActivityData.IsUnLock())
					{
						return false;
					}
					List<PayShopGoods> payShopTabData = PayShopModel.Instance.GetPayShopTabData((PayShopDefine.EPayShopTabType)num.Value, 1, true);
					List<int> curUnlockShopData = this.GetCurUnlockShopData(payShopTabData);
					return !this.GetCacheShopOpen(string.Join<int>(",", curUnlockShopData));
				}
			}
			return false;
		}

		// Token: 0x06035228 RID: 217640 RVA: 0x00C98294 File Offset: 0x00C96494
		protected List<int> GetCurUnlockShopData(List<PayShopGoods> shopData)
		{
			List<int> list = new List<int>();
			foreach (PayShopGoods payShopGoods in shopData)
			{
				PayShopGoodsData goodsData = payShopGoods.GetGoodsData();
				if (goodsData != null && goodsData.GetIfCanBuy() && (goodsData.BuyLimit == 0 || goodsData.BoughtCount < goodsData.BuyLimit))
				{
					list.Add(goodsData.Id);
				}
			}
			return list;
		}

		// Token: 0x06035229 RID: 217641 RVA: 0x00C98314 File Offset: 0x00C96514
		public bool GetCardRewardRedDot(int activityId)
		{
			if (!this.GetActivityUnlock(activityId))
			{
				return false;
			}
			List<int> cardRewardConfigList = this.GetCardRewardConfigList(activityId);
			int cardUnlockCount = this.GetCardUnlockCount(activityId);
			foreach (int rewardId in cardRewardConfigList)
			{
				PhantomBattleCardRewardInfo cardRewardInfoById = this.GetPhantomArenaActivityData(activityId).GetCardRewardInfoById(rewardId);
				if (cardRewardInfoById != null && cardUnlockCount >= cardRewardInfoById.UnlockNum && !cardRewardInfoById.IsRewarded)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0603522A RID: 217642 RVA: 0x00C983A0 File Offset: 0x00C965A0
		public bool GetBadgeRewardRedDot(int activityId)
		{
			if (!this.GetActivityUnlock(activityId))
			{
				return false;
			}
			List<int> badgeRewardConfigList = this.GetBadgeRewardConfigList(activityId);
			int badgeUnlockCount = this.GetBadgeUnlockCount(activityId);
			foreach (int rewardId in badgeRewardConfigList)
			{
				PhantomBattleBadgeRewardInfo badgeRewardInfoById = this.GetPhantomArenaActivityData(activityId).GetBadgeRewardInfoById(rewardId);
				if (badgeRewardInfoById != null && badgeUnlockCount >= badgeRewardInfoById.UnlockNum && !badgeRewardInfoById.IsRewarded)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x1700809F RID: 32927
		// (get) Token: 0x0603522B RID: 217643 RVA: 0x00C9842C File Offset: 0x00C9662C
		public static PhantomArenaModel Instance
		{
			get
			{
				return PhantomArenaModel._Instance;
			}
		}

		// Token: 0x0603522C RID: 217644 RVA: 0x00C98433 File Offset: 0x00C96633
		public static PhantomArenaModel GetOrCreateInstance()
		{
			if (PhantomArenaModel._Instance == null)
			{
				PhantomArenaModel.CreateInstance();
			}
			return PhantomArenaModel._Instance;
		}

		// Token: 0x0603522D RID: 217645 RVA: 0x00C98447 File Offset: 0x00C96647
		public static bool CreateInstance()
		{
			if (PhantomArenaModel._Instance != null)
			{
				return true;
			}
			PhantomArenaModel._Instance = new PhantomArenaModel();
			return true;
		}

		// Token: 0x0603522E RID: 217646 RVA: 0x00C9845D File Offset: 0x00C9665D
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603522F RID: 217647 RVA: 0x00C9845F File Offset: 0x00C9665F
		public static void ResetStaticDefaultValue()
		{
			PhantomArenaModel._Instance = null;
		}

		// Token: 0x06035230 RID: 217648 RVA: 0x00C98467 File Offset: 0x00C96667
		static PhantomArenaModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PhantomArenaModel.CreateStaticDefaultValue), new Action(PhantomArenaModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401C4DE RID: 115934
		public List<int> RoleUnlockQueue = new List<int>();

		// Token: 0x0401C4DF RID: 115935
		public List<int> BadgeUnlockQueue = new List<int>();

		// Token: 0x0401C4E0 RID: 115936
		public List<int> CardUnlockQueue = new List<int>();

		// Token: 0x0401C4E1 RID: 115937
		public List<int> CardOutlookUnlockQueue = new List<int>();

		// Token: 0x0401C4E2 RID: 115938
		public bool EntranceOpenQueue;

		// Token: 0x0401C4E3 RID: 115939
		[Nullable(2)]
		private PhantomArenaActivityData PermanentPhantomArenaActivityDataInner;

		// Token: 0x0401C4E4 RID: 115940
		[Nullable(2)]
		private static PhantomArenaModel _Instance;
	}
}
