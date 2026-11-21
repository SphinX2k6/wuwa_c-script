using System;
using System.Collections.Generic;
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
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x0200410E RID: 16654
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class PhantomArenaModel : ModelBase
	{
		// Token: 0x0602A081 RID: 172161 RVA: 0x00BE1924 File Offset: 0x00BDFB24
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

		// Token: 0x0602A082 RID: 172162 RVA: 0x00BE19AC File Offset: 0x00BDFBAC
		public PhantomArenaActivityData GetPhantomArenaActivityData(int activityId)
		{
			return ActivityModel.Instance.GetActivityById(activityId) as PhantomArenaActivityData;
		}

		// Token: 0x0602A083 RID: 172163 RVA: 0x00BE19BE File Offset: 0x00BDFBBE
		public bool GetActivityUnlock(int activityId)
		{
			return activityId > 0 && this.GetPhantomArenaActivityData(activityId).IsUnLock();
		}

		// Token: 0x0602A084 RID: 172164 RVA: 0x00BE19D2 File Offset: 0x00BDFBD2
		public bool IsNewPhantomArenaActivity(int activityId)
		{
			return this.GetPhantomArenaActivityData(activityId).Type == ActivityType.PhantomBattleRecord;
		}

		// Token: 0x0602A085 RID: 172165 RVA: 0x00BE19E4 File Offset: 0x00BDFBE4
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

		// Token: 0x0602A086 RID: 172166 RVA: 0x00BE1A44 File Offset: 0x00BDFC44
		public bool IsCardUnlock(int cardId)
		{
			int activityId = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(cardId).ActivityId;
			return this.GetPhantomArenaActivityData(activityId).IsCardUnlock(cardId);
		}

		// Token: 0x0602A087 RID: 172167 RVA: 0x00BE1A74 File Offset: 0x00BDFC74
		public bool IsCardOutlookUnlock(int cardId)
		{
			int activityId = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(cardId).ActivityId;
			return this.GetPhantomArenaActivityData(activityId).IsCardOutlookUnlock(cardId);
		}

		// Token: 0x0602A088 RID: 172168 RVA: 0x00BE1AA4 File Offset: 0x00BDFCA4
		public bool IsBadgeUnlock(int badgeId)
		{
			int activityId = PhantomArenaConfig.Instance.GetPhantomBattleBadgeById(badgeId).ActivityId;
			return this.GetPhantomArenaActivityData(activityId).IsBadgeUnlock(badgeId);
		}

		// Token: 0x0602A089 RID: 172169 RVA: 0x00BE1AD4 File Offset: 0x00BDFCD4
		public void OnCardOutlookUnlock(int cardId)
		{
			int activityId = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(cardId).ActivityId;
			this.GetPhantomArenaActivityData(activityId).OnCardOutlookUnlock(cardId);
		}

		// Token: 0x0602A08A RID: 172170 RVA: 0x00BE1B04 File Offset: 0x00BDFD04
		public void AddCardListByNotify(PhantomBattleCardInfoUpdateNotify notify)
		{
			IReadOnlyList<PhantomBattleCardInfo> phantomBattleCardInfos = notify.PhantomBattleCardInfos;
			int phantomBattleCardId = phantomBattleCardInfos[0].PhantomBattleCardId;
			int activityId = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(phantomBattleCardId).ActivityId;
			PhantomBattleCardInfo[] array = new PhantomBattleCardInfo[phantomBattleCardInfos.Count];
			for (int i = 0; i < phantomBattleCardInfos.Count; i++)
			{
				array[i] = phantomBattleCardInfos[i];
			}
			this.GetPhantomArenaActivityData(activityId).AddCardListByNotify(array);
		}

		// Token: 0x0602A08B RID: 172171 RVA: 0x00BE1B74 File Offset: 0x00BDFD74
		public int GetActivityIdByRoleId(int roleId)
		{
			return PhantomArenaConfig.Instance.GetPhantomBattleCardRole(roleId).ActivityId;
		}

		// Token: 0x0602A08C RID: 172172 RVA: 0x00BE1B94 File Offset: 0x00BDFD94
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

		// Token: 0x0602A08D RID: 172173 RVA: 0x00BE1C00 File Offset: 0x00BDFE00
		public void OnRoleReward(int roleId)
		{
			int activityIdByRoleId = this.GetActivityIdByRoleId(roleId);
			this.GetPhantomArenaActivityData(activityIdByRoleId).OnRoleReward(roleId);
		}

		// Token: 0x0602A08E RID: 172174 RVA: 0x00BE1C24 File Offset: 0x00BDFE24
		public void UpdateDeckList(IReadOnlyList<Aki.Protocol.PhantomBattleCardGroupInfo> cardGroupInfo, int activityId)
		{
			PhantomArenaActivityData phantomArenaActivityData = this.GetPhantomArenaActivityData(activityId);
			Aki.Protocol.PhantomBattleCardGroupInfo[] array = new Aki.Protocol.PhantomBattleCardGroupInfo[cardGroupInfo.Count];
			for (int i = 0; i < cardGroupInfo.Count; i++)
			{
				array[i] = cardGroupInfo[i];
			}
			phantomArenaActivityData.UpdateProtocolDeckInfoList(array);
		}

		// Token: 0x0602A08F RID: 172175 RVA: 0x00BE1C67 File Offset: 0x00BDFE67
		public void AddProtocolDeckInfo(Aki.Protocol.PhantomBattleCardGroupInfo cardGroupInfo, int activityId)
		{
			this.GetPhantomArenaActivityData(activityId).AddProtocolDeckInfo(cardGroupInfo);
		}

		// Token: 0x0602A090 RID: 172176 RVA: 0x00BE1C76 File Offset: 0x00BDFE76
		public void UpdateProtocolDeckInfo(Aki.Protocol.PhantomBattleCardGroupInfo cardGroupInfo, int activityId)
		{
			this.GetPhantomArenaActivityData(activityId).UpdateProtocolDeckInfo(cardGroupInfo);
		}

		// Token: 0x0602A091 RID: 172177 RVA: 0x00BE1C88 File Offset: 0x00BDFE88
		public int GetDustItemId(int activityId)
		{
			return PhantomArenaConfig.Instance.GetPhantomBattleActivityConfig(activityId).DustItemId;
		}

		// Token: 0x0602A092 RID: 172178 RVA: 0x00BE1CA8 File Offset: 0x00BDFEA8
		public int GetExpItemId(int activityId)
		{
			return PhantomArenaConfig.Instance.GetPhantomBattleActivityConfig(activityId).ExpItemId;
		}

		// Token: 0x0602A093 RID: 172179 RVA: 0x00BE1CC8 File Offset: 0x00BDFEC8
		public int GetPointsItemId(int activityId)
		{
			return PhantomArenaConfig.Instance.GetPhantomBattleActivityConfig(activityId).Integration;
		}

		// Token: 0x0602A094 RID: 172180 RVA: 0x00BE1CE8 File Offset: 0x00BDFEE8
		public int GetRewardItemId(int activityId)
		{
			return PhantomArenaConfig.Instance.GetPhantomBattleActivityConfig(activityId).RewardItemId;
		}

		// Token: 0x0602A095 RID: 172181 RVA: 0x00BE1D08 File Offset: 0x00BDFF08
		public List<T> FilterCardList<[Nullable(0)] T>(List<T> cardInfoList, CardFilterContext filterContext) where T : CardFilterInfo
		{
			List<T> list = new List<T>();
			int costFilter = (int)filterContext.CostFilter;
			IReadOnlyList<int> readOnlyList = PhantomArenaConfig.Instance.GetPhantomBattleCardFilter(costFilter).CostList();
			foreach (T t in cardInfoList)
			{
				if (filterContext.IncludeLocked || !t.IsLocked)
				{
					ECardTabType elementFilter = filterContext.ElementFilter;
					if (elementFilter == ECardTabType.All || Array.IndexOf<ECardElement>(PhantomArenaDefine.cardTabTypeToFilterElementList[elementFilter], (ECardElement)t.Element) >= 0)
					{
						bool flag = false;
						for (int i = 0; i < readOnlyList.Count; i++)
						{
							if (readOnlyList[i] == t.Cost)
							{
								flag = true;
								break;
							}
						}
						if (flag)
						{
							list.Add(t);
						}
					}
				}
			}
			return list;
		}

		// Token: 0x0602A096 RID: 172182 RVA: 0x00BE1DFC File Offset: 0x00BDFFFC
		public void SortCardSlotList<[Nullable(0)] T>(List<T> cardSlotInfoList, CardSlotSortContext sortContext) where T : CardSlotSortInfo
		{
			TCardSlotSortFunc sortFunc = PhantomArenaDefine.cardSlotSortTypeToSortFunc[sortContext.SortType];
			cardSlotInfoList.Sort((T a, T b) => this.CompareCardSlot(a, b, sortFunc, sortContext.IsAscending));
		}

		// Token: 0x0602A097 RID: 172183 RVA: 0x00BE1E4C File Offset: 0x00BE004C
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

		// Token: 0x0602A098 RID: 172184 RVA: 0x00BE1E7E File Offset: 0x00BE007E
		public ECardFaceType GetCardFaceType(int cardId)
		{
			if (this.IsCardOutlookUnlock(cardId) && this.CheckCardSpineConfigValid(cardId))
			{
				return ECardFaceType.Spine;
			}
			return ECardFaceType.Texture;
		}

		// Token: 0x0602A099 RID: 172185 RVA: 0x00BE1E98 File Offset: 0x00BE0098
		public bool CheckCardSpineConfigValid(int cardId)
		{
			PhantomBattleCard phantomBattleCardConfig = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(cardId);
			return !StringUtils.IsEmpty(phantomBattleCardConfig.SpineAtlas) && !StringUtils.IsEmpty(phantomBattleCardConfig.SpineSkeleton);
		}

		// Token: 0x0602A09A RID: 172186 RVA: 0x00BE1ED0 File Offset: 0x00BE00D0
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

		// Token: 0x0602A09B RID: 172187 RVA: 0x00BE1F1C File Offset: 0x00BE011C
		[NullableContext(2)]
		public PhantomBattleChallengeInfo GetChallengeData(int challengeId)
		{
			int activityId = PhantomArenaConfig.Instance.GetPhantomBattleChallenge(challengeId).ActivityId;
			return this.GetPhantomArenaActivityData(activityId).GetChallengeInfoById(challengeId);
		}

		// Token: 0x0602A09C RID: 172188 RVA: 0x00BE1F4A File Offset: 0x00BE014A
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

		// Token: 0x0602A09D RID: 172189 RVA: 0x00BE1F5E File Offset: 0x00BE015E
		public int GetLastUsedCardRoleId(int activityId)
		{
			return this.GetPhantomArenaActivityData(activityId).GetLastUsedCardRoleId();
		}

		// Token: 0x0602A09E RID: 172190 RVA: 0x00BE1F6C File Offset: 0x00BE016C
		public void SetLastUsedCardDeckServerId(int deckServerId, int activityId)
		{
			this.GetPhantomArenaActivityData(activityId).SetLastUsedDeckServerId(deckServerId);
		}

		// Token: 0x0602A09F RID: 172191 RVA: 0x00BE1F7B File Offset: 0x00BE017B
		public int GetLastUsedCardDeckServerId(int activityId)
		{
			return this.GetPhantomArenaActivityData(activityId).GetLastUsedDeckServerId();
		}

		// Token: 0x0602A0A0 RID: 172192 RVA: 0x00BE1F89 File Offset: 0x00BE0189
		[NullableContext(2)]
		public DeckInfo GetDeckByDeckId(int deckId, int activityId)
		{
			return this.GetPhantomArenaActivityData(activityId).GetClientDeckInfo(deckId);
		}

		// Token: 0x0602A0A1 RID: 172193 RVA: 0x00BE1F98 File Offset: 0x00BE0198
		public List<DeckInfo> CreateEditableDeckListFromProtocolData(int activityId)
		{
			return this.GetPhantomArenaActivityData(activityId).CreateDeckInfoListFromProtocol();
		}

		// Token: 0x0602A0A2 RID: 172194 RVA: 0x00BE1FA8 File Offset: 0x00BE01A8
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

		// Token: 0x0602A0A3 RID: 172195 RVA: 0x00BE2188 File Offset: 0x00BE0388
		public DeckInfo CreateEmptyTempDeckInfo(int activityId)
		{
			DeckInfo deckInfo = this.GetPhantomArenaActivityData(activityId).CreateClientDeckInfo();
			deckInfo.SetDeckServerId(-100);
			string deckName = ConfigMultiTextLang.GetLocalTextNew("PhantomBattle_1038", null) ?? "";
			deckInfo.SetDeckName(deckName);
			return deckInfo;
		}

		// Token: 0x0602A0A4 RID: 172196 RVA: 0x00BE21C8 File Offset: 0x00BE03C8
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

		// Token: 0x0602A0A5 RID: 172197 RVA: 0x00BE2230 File Offset: 0x00BE0430
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

		// Token: 0x0602A0A6 RID: 172198 RVA: 0x00BE22A4 File Offset: 0x00BE04A4
		public PhantomBattleGym? GetPhantomBattleGymConfigByLevel(int gymLevel, int activityId)
		{
			return PhantomArenaConfig.Instance.GetPhantomBattleGymConfigByLevel(activityId, gymLevel);
		}

		// Token: 0x0602A0A7 RID: 172199 RVA: 0x00BE22B4 File Offset: 0x00BE04B4
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

		// Token: 0x0602A0A8 RID: 172200 RVA: 0x00BE231C File Offset: 0x00BE051C
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

		// Token: 0x0602A0A9 RID: 172201 RVA: 0x00BE2358 File Offset: 0x00BE0558
		public void UpdateChallengeInfoByNotify(PhantomBattleChallengeInfoUpdateNotify notify)
		{
			int phantomBattleChallengeId = notify.PhantomBattleChallengeInfos[0].PhantomBattleChallengeId;
			int activityId = PhantomArenaConfig.Instance.GetPhantomBattleChallenge(phantomBattleChallengeId).ActivityId;
			PhantomArenaActivityData phantomArenaActivityData = this.GetPhantomArenaActivityData(activityId);
			PhantomBattleChallengeInfo[] array = new PhantomBattleChallengeInfo[notify.PhantomBattleChallengeInfos.Count];
			notify.PhantomBattleChallengeInfos.CopyTo(array, 0);
			phantomArenaActivityData.UpdateChallengeInfoList(array);
		}

		// Token: 0x0602A0AA RID: 172202 RVA: 0x00BE23B8 File Offset: 0x00BE05B8
		public void UpdateChallengeInfoBySettleResult(int challengeId, bool isUnLock, bool hasPass, bool isUnCover)
		{
			int activityId = PhantomArenaConfig.Instance.GetPhantomBattleChallenge(challengeId).ActivityId;
			this.GetPhantomArenaActivityData(activityId).UpdateChallengeInfoById(challengeId, isUnLock, hasPass, isUnCover);
		}

		// Token: 0x0602A0AB RID: 172203 RVA: 0x00BE23EA File Offset: 0x00BE05EA
		public bool IsChallengeLock(int challengeId)
		{
			return this.GetChallengeStateById(challengeId) == EChallengeState.Lock;
		}

		// Token: 0x0602A0AC RID: 172204 RVA: 0x00BE23F8 File Offset: 0x00BE05F8
		public bool IsGymLock(int gymLevel, int activityId)
		{
			List<GymChallengeData> challengeStateListByGymLevel = this.GetChallengeStateListByGymLevel(gymLevel, activityId);
			return ((challengeStateListByGymLevel.Count > 0) ? challengeStateListByGymLevel[0].State : EChallengeState.Lock) == EChallengeState.Lock;
		}

		// Token: 0x0602A0AD RID: 172205 RVA: 0x00BE242C File Offset: 0x00BE062C
		private static void MigrateLocalGymState(ELocalStoragePlayerKey localKey, int cacheKey)
		{
			Dictionary<int, List<int>> player = LocalStorage.GetPlayer<Dictionary<int, List<int>>>(localKey, null);
			if (player == null)
			{
				return;
			}
			bool flag = true;
			foreach (KeyValuePair<int, List<int>> keyValuePair in player)
			{
				int num;
				List<int> list;
				keyValuePair.Deconstruct(out num, out list);
				int num2 = num;
				List<int> list2 = list;
				if (ActivityModel.Instance.GetActivityById(num2) == null)
				{
					flag = false;
				}
				else
				{
					foreach (int num3 in list2)
					{
						ActivityModel.Instance.SaveActivityData(num2, cacheKey, num3 % 100, num3 / 100, 1);
					}
				}
			}
			if (flag)
			{
				ServerStorageModel.Instance.RegisterPendingLocalDelete(EClientStorageSystemIdType.Activity, localKey);
			}
		}

		// Token: 0x0602A0AE RID: 172206 RVA: 0x00BE2504 File Offset: 0x00BE0704
		private static bool IsGymCheckedInActivityCache(int gymLevel, int activityId, int cacheKey)
		{
			return ActivityModel.Instance.GetActivityById(activityId) != null && ActivityModel.Instance.GetActivityCacheData(activityId, 0, cacheKey, gymLevel % 100, gymLevel / 100) == 1;
		}

		// Token: 0x0602A0AF RID: 172207 RVA: 0x00BE252D File Offset: 0x00BE072D
		private static void SetGymCheckedInActivityCache(int gymLevel, int activityId, int cacheKey)
		{
			if (ActivityModel.Instance.GetActivityById(activityId) == null)
			{
				return;
			}
			ActivityModel.Instance.SaveActivityData(activityId, cacheKey, gymLevel % 100, gymLevel / 100, 1);
		}

		// Token: 0x0602A0B0 RID: 172208 RVA: 0x00BE2552 File Offset: 0x00BE0752
		public bool IsGymUnlockChecked(int gymLevel, int activityId)
		{
			PhantomArenaModel.MigrateLocalGymState(ELocalStoragePlayerKey.PhantomArenaEntranceGymCheck, 2);
			return PhantomArenaModel.IsGymCheckedInActivityCache(gymLevel, activityId, 2);
		}

		// Token: 0x0602A0B1 RID: 172209 RVA: 0x00BE2567 File Offset: 0x00BE0767
		public void SetGymUnlockChecked(int gymLevel, int activityId)
		{
			PhantomArenaModel.MigrateLocalGymState(ELocalStoragePlayerKey.PhantomArenaEntranceGymCheck, 2);
			PhantomArenaModel.SetGymCheckedInActivityCache(gymLevel, activityId, 2);
		}

		// Token: 0x0602A0B2 RID: 172210 RVA: 0x00BE257C File Offset: 0x00BE077C
		public void UpdateMasterInfoByNotify(PhantomBattleMasterInfoNotify notify)
		{
			PhantomBattleMasterInfo phantomBattleMasterInfo = notify.PhantomBattleMasterInfo;
			if (phantomBattleMasterInfo == null)
			{
				return;
			}
			this.GetPhantomArenaActivityData(notify.ActivityId).UpdateMasterInfo(phantomBattleMasterInfo);
		}

		// Token: 0x0602A0B3 RID: 172211 RVA: 0x00BE25A6 File Offset: 0x00BE07A6
		public int GetMasterLevel(int activityId)
		{
			return this.GetPhantomArenaActivityData(activityId).GetMasterLevel();
		}

		// Token: 0x0602A0B4 RID: 172212 RVA: 0x00BE25B4 File Offset: 0x00BE07B4
		public int GetMasterTitleId(int activityId)
		{
			return this.GetPhantomArenaActivityData(activityId).GetMasterTitleId();
		}

		// Token: 0x0602A0B5 RID: 172213 RVA: 0x00BE25C4 File Offset: 0x00BE07C4
		public int GetMasterTitleIdByLevel(int level, int activityId)
		{
			return this.GetMasterLevelConfig(level, activityId).Value.TitleId;
		}

		// Token: 0x0602A0B6 RID: 172214 RVA: 0x00BE25E9 File Offset: 0x00BE07E9
		public PhantomBattleMasterLevel? GetMasterLevelConfig(int level, int activityId)
		{
			return PhantomArenaConfig.Instance.GetPhantomBattleMasterLevelConfigByLevel(activityId, level);
		}

		// Token: 0x0602A0B7 RID: 172215 RVA: 0x00BE25F8 File Offset: 0x00BE07F8
		public bool GetMasterLevelRewardIfTaken(int level, int activityId)
		{
			if (activityId <= 0)
			{
				return false;
			}
			PhantomBattleMasterLevel? masterLevelConfig = this.GetMasterLevelConfig(level, activityId);
			return this.GetPhantomArenaActivityData(activityId).GetMasterLevelRewardIfTaken(masterLevelConfig.Value.Id);
		}

		// Token: 0x0602A0B8 RID: 172216 RVA: 0x00BE2630 File Offset: 0x00BE0830
		public bool GetMasterLevelRewardCanTake(int level, int activityId)
		{
			int expNeed = this.GetMasterLevelConfig(level, activityId).Value.ExpNeed;
			int masterExpNow = this.GetMasterExpNow(activityId, null);
			return this.GetMasterLevelRewardList(level, activityId).Count != 0 && masterExpNow >= expNeed && !this.GetMasterLevelRewardIfTaken(level, activityId);
		}

		// Token: 0x0602A0B9 RID: 172217 RVA: 0x00BE268C File Offset: 0x00BE088C
		public List<TItem> GetMasterLevelRewardList(int level, int activityId)
		{
			int normalDropId = this.GetMasterLevelConfig(level, activityId).Value.NormalDropId;
			if (normalDropId <= 0)
			{
				return new List<TItem>();
			}
			return CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(normalDropId);
		}

		// Token: 0x0602A0BA RID: 172218 RVA: 0x00BE26C7 File Offset: 0x00BE08C7
		public List<PhantomBattleMasterLevel> GetPhantomBattleMasterLevelConfigList(int activityId)
		{
			return new List<PhantomBattleMasterLevel>(PhantomArenaConfig.Instance.GetPhantomBattleMasterLevelConfigByActivityId(activityId));
		}

		// Token: 0x0602A0BB RID: 172219 RVA: 0x00BE26DC File Offset: 0x00BE08DC
		public int GetMasterExpNextNeed(int activityId)
		{
			int masterLevel = this.GetMasterLevel(activityId);
			PhantomBattleMasterLevel? phantomBattleMasterLevelConfigByLevel = PhantomArenaConfig.Instance.GetPhantomBattleMasterLevelConfigByLevel(activityId, masterLevel);
			return phantomBattleMasterLevelConfigByLevel.Value.ExpNeed + phantomBattleMasterLevelConfigByLevel.Value.ExpNext;
		}

		// Token: 0x0602A0BC RID: 172220 RVA: 0x00BE2720 File Offset: 0x00BE0920
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

		// Token: 0x0602A0BD RID: 172221 RVA: 0x00BE276E File Offset: 0x00BE096E
		public int GetMasterExpWeek(int activityId)
		{
			return this.GetPhantomArenaActivityData(activityId).GetMasterExpWeek();
		}

		// Token: 0x0602A0BE RID: 172222 RVA: 0x00BE277C File Offset: 0x00BE097C
		private List<int> GetChallengeIdListByGymLevel(int gymLevel, int activityId)
		{
			return new List<int>(PhantomArenaConfig.Instance.GetPhantomBattleChallengeIdListByGymId(activityId, gymLevel));
		}

		// Token: 0x0602A0BF RID: 172223 RVA: 0x00BE2790 File Offset: 0x00BE0990
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

		// Token: 0x0602A0C0 RID: 172224 RVA: 0x00BE2868 File Offset: 0x00BE0A68
		public int GetFinishedChallengeCount(int activityId)
		{
			return this.GetPhantomArenaActivityData(activityId).GetFinishedChallengeCount();
		}

		// Token: 0x0602A0C1 RID: 172225 RVA: 0x00BE2878 File Offset: 0x00BE0A78
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

		// Token: 0x0602A0C2 RID: 172226 RVA: 0x00BE2924 File Offset: 0x00BE0B24
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

		// Token: 0x0602A0C3 RID: 172227 RVA: 0x00BE2998 File Offset: 0x00BE0B98
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

		// Token: 0x0602A0C4 RID: 172228 RVA: 0x00BE2A44 File Offset: 0x00BE0C44
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

		// Token: 0x0602A0C5 RID: 172229 RVA: 0x00BE2AE4 File Offset: 0x00BE0CE4
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

		// Token: 0x0602A0C6 RID: 172230 RVA: 0x00BE2B80 File Offset: 0x00BE0D80
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

		// Token: 0x0602A0C7 RID: 172231 RVA: 0x00BE2CAC File Offset: 0x00BE0EAC
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

		// Token: 0x0602A0C8 RID: 172232 RVA: 0x00BE2DD8 File Offset: 0x00BE0FD8
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

		// Token: 0x0602A0C9 RID: 172233 RVA: 0x00BE2E80 File Offset: 0x00BE1080
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

		// Token: 0x0602A0CA RID: 172234 RVA: 0x00BE2F18 File Offset: 0x00BE1118
		public int GetMasterLevelMax(int activityId)
		{
			return ((IReadOnlyCollection<PhantomBattleMasterLevel>)PhantomArenaConfig.Instance.GetPhantomBattleMasterLevelConfigByActivityId(activityId)).Count;
		}

		// Token: 0x0602A0CB RID: 172235 RVA: 0x00BE2F2C File Offset: 0x00BE112C
		public void UpdateMasterLevelByConfigIds(IEnumerable<int> levelConfigIds, int activityId)
		{
			PhantomArenaActivityData phantomArenaActivityData = this.GetPhantomArenaActivityData(activityId);
			foreach (int levelConfigId in levelConfigIds)
			{
				phantomArenaActivityData.UpdateMasterLevelByConfigId(levelConfigId);
			}
		}

		// Token: 0x0602A0CC RID: 172236 RVA: 0x00BE2F7C File Offset: 0x00BE117C
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

		// Token: 0x0602A0CD RID: 172237 RVA: 0x00BE2FFC File Offset: 0x00BE11FC
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

		// Token: 0x0602A0CE RID: 172238 RVA: 0x00BE3084 File Offset: 0x00BE1284
		private bool CheckNotShowInResult(int itemId, int activityId)
		{
			int expItemId = this.GetExpItemId(activityId);
			int pointsItemId = this.GetPointsItemId(activityId);
			return itemId == expItemId || itemId == pointsItemId;
		}

		// Token: 0x0602A0CF RID: 172239 RVA: 0x00BE30AC File Offset: 0x00BE12AC
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

		// Token: 0x0602A0D0 RID: 172240 RVA: 0x00BE312C File Offset: 0x00BE132C
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

		// Token: 0x0602A0D1 RID: 172241 RVA: 0x00BE328C File Offset: 0x00BE148C
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

		// Token: 0x0602A0D2 RID: 172242 RVA: 0x00BE3330 File Offset: 0x00BE1530
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

		// Token: 0x0602A0D3 RID: 172243 RVA: 0x00BE3388 File Offset: 0x00BE1588
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

		// Token: 0x0602A0D4 RID: 172244 RVA: 0x00BE33FC File Offset: 0x00BE15FC
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

		// Token: 0x0602A0D5 RID: 172245 RVA: 0x00BE34C4 File Offset: 0x00BE16C4
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

		// Token: 0x0602A0D6 RID: 172246 RVA: 0x00BE35E0 File Offset: 0x00BE17E0
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

		// Token: 0x0602A0D7 RID: 172247 RVA: 0x00BE3748 File Offset: 0x00BE1948
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

		// Token: 0x0602A0D8 RID: 172248 RVA: 0x00BE3778 File Offset: 0x00BE1978
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

		// Token: 0x0602A0D9 RID: 172249 RVA: 0x00BE37B8 File Offset: 0x00BE19B8
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

		// Token: 0x0602A0DA RID: 172250 RVA: 0x00BE385C File Offset: 0x00BE1A5C
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

		// Token: 0x0602A0DB RID: 172251 RVA: 0x00BE3970 File Offset: 0x00BE1B70
		private int BadgeSortById(int badgeIdA, int badgeIdB)
		{
			PhantomBattleBadge phantomBattleBadgeById = PhantomArenaConfig.Instance.GetPhantomBattleBadgeById(badgeIdA);
			PhantomBattleBadge phantomBattleBadgeById2 = PhantomArenaConfig.Instance.GetPhantomBattleBadgeById(badgeIdB);
			return phantomBattleBadgeById.SortIndex - phantomBattleBadgeById2.SortIndex;
		}

		// Token: 0x0602A0DC RID: 172252 RVA: 0x00BE39A4 File Offset: 0x00BE1BA4
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

		// Token: 0x0602A0DD RID: 172253 RVA: 0x00BE3A10 File Offset: 0x00BE1C10
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

		// Token: 0x0602A0DE RID: 172254 RVA: 0x00BE3AEC File Offset: 0x00BE1CEC
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

		// Token: 0x0602A0DF RID: 172255 RVA: 0x00BE3B68 File Offset: 0x00BE1D68
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

		// Token: 0x0602A0E0 RID: 172256 RVA: 0x00BE3BDC File Offset: 0x00BE1DDC
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

		// Token: 0x0602A0E1 RID: 172257 RVA: 0x00BE3C44 File Offset: 0x00BE1E44
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

		// Token: 0x0602A0E2 RID: 172258 RVA: 0x00BE3CB0 File Offset: 0x00BE1EB0
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

		// Token: 0x0602A0E3 RID: 172259 RVA: 0x00BE3D0C File Offset: 0x00BE1F0C
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

		// Token: 0x0602A0E4 RID: 172260 RVA: 0x00BE3D54 File Offset: 0x00BE1F54
		public int GetCardRewardNeedCountById(int rewardId)
		{
			return this.GetCardRewardInfoById(rewardId).UnlockNum;
		}

		// Token: 0x0602A0E5 RID: 172261 RVA: 0x00BE3D64 File Offset: 0x00BE1F64
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

		// Token: 0x0602A0E6 RID: 172262 RVA: 0x00BE3DD8 File Offset: 0x00BE1FD8
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

		// Token: 0x0602A0E7 RID: 172263 RVA: 0x00BE3E98 File Offset: 0x00BE2098
		public int GetBadgeRewardNeedCountById(int rewardId)
		{
			return this.GetBadgeRewardInfoById(rewardId).UnlockNum;
		}

		// Token: 0x0602A0E8 RID: 172264 RVA: 0x00BE3EA8 File Offset: 0x00BE20A8
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

		// Token: 0x0602A0E9 RID: 172265 RVA: 0x00BE3EF0 File Offset: 0x00BE20F0
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

		// Token: 0x0602A0EA RID: 172266 RVA: 0x00BE3F80 File Offset: 0x00BE2180
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

		// Token: 0x0602A0EB RID: 172267 RVA: 0x00BE3FF4 File Offset: 0x00BE21F4
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

		// Token: 0x0602A0EC RID: 172268 RVA: 0x00BE40B4 File Offset: 0x00BE22B4
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

		// Token: 0x0602A0ED RID: 172269 RVA: 0x00BE4104 File Offset: 0x00BE2304
		public CardDetailItemData GetDetailViewDetailItemData(int cardId, [Nullable(2)] DeckInfo deckInfo = null)
		{
			PhantomBattleCard phantomBattleCardConfig = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(cardId);
			if (phantomBattleCardConfig.Type == 3)
			{
				return this.GetFieldCardDetailItemData(phantomBattleCardConfig, deckInfo);
			}
			return this.GetNormalCardDetailItemData(phantomBattleCardConfig);
		}

		// Token: 0x0602A0EE RID: 172270 RVA: 0x00BE4137 File Offset: 0x00BE2337
		[NullableContext(2)]
		private ICardDetailActiveSkillData GetActiveSkillData(PhantomBattleCard config)
		{
			if (config.DurableSkillId > 0)
			{
				return new CardDetailActiveSkillData
				{
					Desc = config.DurableSkillDescription,
					Params = new List<string>(config.DurableSkillDescriptionParams())
				};
			}
			return null;
		}

		// Token: 0x0602A0EF RID: 172271 RVA: 0x00BE416C File Offset: 0x00BE236C
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
				Params = new List<string>((config.CountSkill > 0) ? config.CountSkillDescriptionParams() : config.CardEffectDescriptionParams()),
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

		// Token: 0x0602A0F0 RID: 172272 RVA: 0x00BE430C File Offset: 0x00BE250C
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
					Params = new List<string>(config.CountSkillDescriptionParams()),
					EffectCountData = effectCountData
				};
			}
			return null;
		}

		// Token: 0x0602A0F1 RID: 172273 RVA: 0x00BE437C File Offset: 0x00BE257C
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

		// Token: 0x0602A0F2 RID: 172274 RVA: 0x00BE43E0 File Offset: 0x00BE25E0
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
				DescriptionParams = new List<string>(config.CardEffectDescriptionParams())
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

		// Token: 0x0602A0F3 RID: 172275 RVA: 0x00BE4534 File Offset: 0x00BE2734
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

		// Token: 0x0602A0F4 RID: 172276 RVA: 0x00BE45D0 File Offset: 0x00BE27D0
		public void UpdateCardRewardByNotify(PhantomBattleCardRewardInfoUpdateNotify notify)
		{
			IReadOnlyList<PhantomBattleCardRewardInfo> phantomBattleCardRewardInfos = notify.PhantomBattleCardRewardInfos;
			int activityId = PhantomArenaConfig.Instance.GetPhantomBattleCardRewardById(phantomBattleCardRewardInfos[0].PhantomBattleCardRewardId).ActivityId;
			PhantomArenaActivityData phantomArenaActivityData = this.GetPhantomArenaActivityData(activityId);
			PhantomBattleCardRewardInfo[] array = new PhantomBattleCardRewardInfo[phantomBattleCardRewardInfos.Count];
			for (int i = 0; i < phantomBattleCardRewardInfos.Count; i++)
			{
				array[i] = phantomBattleCardRewardInfos[i];
			}
			phantomArenaActivityData.UpdateCardReward(array);
		}

		// Token: 0x0602A0F5 RID: 172277 RVA: 0x00BE4640 File Offset: 0x00BE2840
		public void UpdateCardRewardByIds(List<int> rewardIds)
		{
			int activityId = PhantomArenaConfig.Instance.GetPhantomBattleCardRewardById(rewardIds[0]).ActivityId;
			this.GetPhantomArenaActivityData(activityId).UpdateCardRewardByIds(rewardIds);
		}

		// Token: 0x0602A0F6 RID: 172278 RVA: 0x00BE4674 File Offset: 0x00BE2874
		public void AddBadgeListByNotify(PhantomBattleBadgeInfoUpdateNotify notify)
		{
			IReadOnlyList<PhantomBattleBadgeInfo> phantomBattleBadgeInfos = notify.PhantomBattleBadgeInfos;
			int activityId = PhantomArenaConfig.Instance.GetPhantomBattleBadgeById(phantomBattleBadgeInfos[0].PhantomBattleBadgeId).ActivityId;
			PhantomBattleBadgeInfo[] array = new PhantomBattleBadgeInfo[phantomBattleBadgeInfos.Count];
			for (int i = 0; i < phantomBattleBadgeInfos.Count; i++)
			{
				array[i] = phantomBattleBadgeInfos[i];
			}
			this.GetPhantomArenaActivityData(activityId).AddBadgeListByNotify(array);
		}

		// Token: 0x0602A0F7 RID: 172279 RVA: 0x00BE46E4 File Offset: 0x00BE28E4
		public void UpdateBadgeRewardByNotify(PhantomBattleBadgeRewardInfoUpdateNotify notify)
		{
			IReadOnlyList<PhantomBattleBadgeRewardInfo> phantomBattleBadgeRewardInfos = notify.PhantomBattleBadgeRewardInfos;
			int activityId = PhantomArenaConfig.Instance.GetPhantomBattleBadgeRewardById(phantomBattleBadgeRewardInfos[0].PhantomBattleBadgeRewardId).ActivityId;
			PhantomArenaActivityData phantomArenaActivityData = this.GetPhantomArenaActivityData(activityId);
			PhantomBattleBadgeRewardInfo[] array = new PhantomBattleBadgeRewardInfo[phantomBattleBadgeRewardInfos.Count];
			for (int i = 0; i < phantomBattleBadgeRewardInfos.Count; i++)
			{
				array[i] = phantomBattleBadgeRewardInfos[i];
			}
			phantomArenaActivityData.UpdateBadgeReward(array);
		}

		// Token: 0x0602A0F8 RID: 172280 RVA: 0x00BE4754 File Offset: 0x00BE2954
		public void UpdateBadgeRewardByIds(List<int> rewardIds)
		{
			int activityId = PhantomArenaConfig.Instance.GetPhantomBattleBadgeRewardById(rewardIds[0]).ActivityId;
			this.GetPhantomArenaActivityData(activityId).UpdateBadgeRewardByIds(rewardIds);
		}

		// Token: 0x0602A0F9 RID: 172281 RVA: 0x00BE4788 File Offset: 0x00BE2988
		public List<int> GetCardRewardConfigList(int activityId)
		{
			return PhantomArenaConfig.Instance.GetPhantomBattleCardRewardIdList(activityId);
		}

		// Token: 0x0602A0FA RID: 172282 RVA: 0x00BE4795 File Offset: 0x00BE2995
		public List<int> GetBadgeRewardConfigList(int activityId)
		{
			return PhantomArenaConfig.Instance.GetPhantomBattleBadgeRewardIdList(activityId);
		}

		// Token: 0x0602A0FB RID: 172283 RVA: 0x00BE47A4 File Offset: 0x00BE29A4
		public PhantomBattleCardRewardInfo GetCardRewardInfoById(int rewardId)
		{
			int activityId = PhantomArenaConfig.Instance.GetPhantomBattleCardRewardById(rewardId).ActivityId;
			return this.GetPhantomArenaActivityData(activityId).GetCardRewardInfoById(rewardId);
		}

		// Token: 0x0602A0FC RID: 172284 RVA: 0x00BE47D4 File Offset: 0x00BE29D4
		public PhantomBattleBadgeRewardInfo GetBadgeRewardInfoById(int rewardId)
		{
			int activityId = PhantomArenaConfig.Instance.GetPhantomBattleBadgeRewardById(rewardId).ActivityId;
			return this.GetPhantomArenaActivityData(activityId).GetBadgeRewardInfoById(rewardId);
		}

		// Token: 0x0602A0FD RID: 172285 RVA: 0x00BE4804 File Offset: 0x00BE2A04
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

		// Token: 0x0602A0FE RID: 172286 RVA: 0x00BE4868 File Offset: 0x00BE2A68
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

		// Token: 0x0602A0FF RID: 172287 RVA: 0x00BE4920 File Offset: 0x00BE2B20
		public void UpdateTaskInfo(PhantomBattleTaskInfoNotify notify)
		{
			IReadOnlyList<ActivityTask> activityTasks = notify.ActivityTasks;
			int activityId = PhantomArenaConfig.Instance.GetTaskConfigById(activityTasks[0].Id).Value.ActivityId;
			ActivityTask[] array = new ActivityTask[activityTasks.Count];
			for (int i = 0; i < activityTasks.Count; i++)
			{
				array[i] = activityTasks[i];
			}
			this.GetPhantomArenaActivityData(activityId).UpdateTaskInfo(array);
		}

		// Token: 0x0602A100 RID: 172288 RVA: 0x00BE4998 File Offset: 0x00BE2B98
		public void UpdateTaskByIds(List<int> taskIds)
		{
			int activityId = PhantomArenaConfig.Instance.GetTaskConfigById(taskIds[0]).Value.ActivityId;
			this.GetPhantomArenaActivityData(activityId).UpdateTaskByIdList(taskIds);
		}

		// Token: 0x0602A101 RID: 172289 RVA: 0x00BE49D4 File Offset: 0x00BE2BD4
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

		// Token: 0x0602A102 RID: 172290 RVA: 0x00BE4A70 File Offset: 0x00BE2C70
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

		// Token: 0x0602A103 RID: 172291 RVA: 0x00BE4BF8 File Offset: 0x00BE2DF8
		[NullableContext(2)]
		public ActivityTask GetSpecialTask(int activityId)
		{
			return this.GetPhantomArenaActivityData(activityId).GetSpecialTask();
		}

		// Token: 0x0602A104 RID: 172292 RVA: 0x00BE4C06 File Offset: 0x00BE2E06
		public List<int> GetAllCanReceiveTaskIdsByTabId(int activityId, int tabId)
		{
			return this.GetPhantomArenaActivityData(activityId).GetAllCanReceiveTaskIdsByTabId(tabId);
		}

		// Token: 0x0602A105 RID: 172293 RVA: 0x00BE4C18 File Offset: 0x00BE2E18
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

		// Token: 0x0602A106 RID: 172294 RVA: 0x00BE4C94 File Offset: 0x00BE2E94
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

		// Token: 0x0602A107 RID: 172295 RVA: 0x00BE4E1C File Offset: 0x00BE301C
		public bool GetCacheShopOpen(string shopData)
		{
			ServerStorageUtil.OverrideLocalStringToServerString(ELocalStoragePlayerKey.PhantomArenaEntranceShopRefresh, EClientStorageSystemIdType.PhantomArenaEntranceShopRefresh, true);
			string text = (ServerStorageModel.Instance.Get(EClientStorageSystemIdType.PhantomArenaEntranceShopRefresh) as ServerStorageString).Get() ?? "";
			if (shopData.Length < text.Length)
			{
				this.SetCacheShopOpen(shopData);
				return true;
			}
			return text == shopData;
		}

		// Token: 0x0602A108 RID: 172296 RVA: 0x00BE4E75 File Offset: 0x00BE3075
		public void SetCacheShopOpen(string shopData)
		{
			(ServerStorageModel.Instance.Get(EClientStorageSystemIdType.PhantomArenaEntranceShopRefresh) as ServerStorageString).Set(shopData);
		}

		// Token: 0x0602A109 RID: 172297 RVA: 0x00BE4E8E File Offset: 0x00BE308E
		public int GetCurrencyId(int activityId)
		{
			return this.GetPhantomArenaActivityData(activityId).GetCurrencyId();
		}

		// Token: 0x0602A10A RID: 172298 RVA: 0x00BE4E9C File Offset: 0x00BE309C
		public List<object> GetShopList(int activityId)
		{
			int shopId = this.GetPhantomArenaActivityData(activityId).GetShopId();
			if (shopId == 0)
			{
				return new List<object>();
			}
			return new List<object>(PayShopModel.Instance.GetPayShopTabData((PayShopDefine.EPayShopTabType)shopId, 1, true));
		}

		// Token: 0x0602A10B RID: 172299 RVA: 0x00BE4ED4 File Offset: 0x00BE30D4
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

		// Token: 0x0602A10C RID: 172300 RVA: 0x00BE4F29 File Offset: 0x00BE3129
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

		// Token: 0x0602A10D RID: 172301 RVA: 0x00BE4F38 File Offset: 0x00BE3138
		public bool IsRoleUnlock(int roleId)
		{
			int activityId = PhantomArenaConfig.Instance.GetPhantomBattleCardRole(roleId).ActivityId;
			return this.GetPhantomArenaActivityData(activityId).IsRoleUnlock(roleId);
		}

		// Token: 0x0602A10E RID: 172302 RVA: 0x00BE4F68 File Offset: 0x00BE3168
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

		// Token: 0x0602A10F RID: 172303 RVA: 0x00BE4FEC File Offset: 0x00BE31EC
		public bool IsMainRole(int roleId)
		{
			int activityId = PhantomArenaConfig.Instance.GetPhantomBattleCardRole(roleId).ActivityId;
			return PhantomArenaConfig.Instance.GetPhantomBattleActivityConfig(activityId).GetMainRoleListBytes().Contains(roleId);
		}

		// Token: 0x0602A110 RID: 172304 RVA: 0x00BE5028 File Offset: 0x00BE3228
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

		// Token: 0x0602A111 RID: 172305 RVA: 0x00BE50C0 File Offset: 0x00BE32C0
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

		// Token: 0x0602A112 RID: 172306 RVA: 0x00BE5120 File Offset: 0x00BE3320
		public bool GetPhantomArenaActivityRedDot(int activityId)
		{
			return this.GetMasterLevelRewardRedDot(activityId) || this.CheckTaskRedDot(activityId) || this.CheckShopRedDot(activityId) || this.GetRoleRewardRedDot(activityId) || this.GetCardRewardRedDot(activityId) || this.GetBadgeRewardRedDot(activityId) || this.GetGymRedDot(activityId);
		}

		// Token: 0x0602A113 RID: 172307 RVA: 0x00BE516C File Offset: 0x00BE336C
		public bool GetPermanentPhantomArenaActivityRedDot(int activityId)
		{
			return this.CheckTaskRedDot(activityId) || this.GetRoleRewardRedDot(activityId) || this.GetCardRewardRedDot(activityId);
		}

		// Token: 0x0602A114 RID: 172308 RVA: 0x00BE518C File Offset: 0x00BE338C
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

		// Token: 0x0602A115 RID: 172309 RVA: 0x00BE5208 File Offset: 0x00BE3408
		public bool GetChallengeUnlockRedDotById(int challengeId)
		{
			if (this.GetPermanentChallengeStateById(challengeId) == EChallengeState.Lock)
			{
				return false;
			}
			ServerStorageUtil.OverrideLocalBoolMapToServerSet(ELocalStoragePlayerKey.PhantomArenaChallengeUnlockRedDotCheck, EClientStorageSystemIdType.PhantomArenaChallengeUnlockRedDotCheck, true);
			return !(ServerStorageModel.Instance.Get(EClientStorageSystemIdType.PhantomArenaChallengeUnlockRedDotCheck) as ServerStorageSet).Has(challengeId);
		}

		// Token: 0x0602A116 RID: 172310 RVA: 0x00BE523D File Offset: 0x00BE343D
		public bool GetMapUnlockRedDot()
		{
			ServerStorageUtil.OverrideLocalBoolMapToServerSet(ELocalStoragePlayerKey.PhantomArenaMapUnlockRedDotCheck, EClientStorageSystemIdType.PhantomArenaMapUnlockRedDotCheck, true);
			return (ServerStorageModel.Instance.Get(EClientStorageSystemIdType.PhantomArenaMapUnlockRedDotCheck) as ServerStorageSet).Size() > 0;
		}

		// Token: 0x0602A117 RID: 172311 RVA: 0x00BE5266 File Offset: 0x00BE3466
		public bool GetMapUnlockRedDotById(int mapId)
		{
			ServerStorageUtil.OverrideLocalBoolMapToServerSet(ELocalStoragePlayerKey.PhantomArenaMapUnlockRedDotCheck, EClientStorageSystemIdType.PhantomArenaMapUnlockRedDotCheck, true);
			return (ServerStorageModel.Instance.Get(EClientStorageSystemIdType.PhantomArenaMapUnlockRedDotCheck) as ServerStorageSet).Has(mapId);
		}

		// Token: 0x0602A118 RID: 172312 RVA: 0x00BE5290 File Offset: 0x00BE3490
		public void SaveChallengeUnlockRedDotById(int challengeId, bool isUnlock)
		{
			ServerStorageUtil.OverrideLocalBoolMapToServerSet(ELocalStoragePlayerKey.PhantomArenaChallengeUnlockRedDotCheck, EClientStorageSystemIdType.PhantomArenaChallengeUnlockRedDotCheck, true);
			ServerStorageSet serverStorageSet = ServerStorageModel.Instance.Get(EClientStorageSystemIdType.PhantomArenaChallengeUnlockRedDotCheck) as ServerStorageSet;
			if (isUnlock)
			{
				serverStorageSet.Add(challengeId);
				return;
			}
			serverStorageSet.Remove(challengeId);
		}

		// Token: 0x0602A119 RID: 172313 RVA: 0x00BE52D0 File Offset: 0x00BE34D0
		public void SaveMapUnlockRedDotById(int mapId, bool isUnlock)
		{
			if (mapId == 1)
			{
				return;
			}
			ServerStorageUtil.OverrideLocalBoolMapToServerSet(ELocalStoragePlayerKey.PhantomArenaMapUnlockRedDotCheck, EClientStorageSystemIdType.PhantomArenaMapUnlockRedDotCheck, true);
			ServerStorageSet serverStorageSet = ServerStorageModel.Instance.Get(EClientStorageSystemIdType.PhantomArenaMapUnlockRedDotCheck) as ServerStorageSet;
			if (isUnlock)
			{
				if (!serverStorageSet.Has(mapId))
				{
					serverStorageSet.Add(mapId);
					EventSystem.Instance.Emit<int>(EEventName.OnPhantomArenaMapUnlockUpdate, mapId);
					return;
				}
			}
			else if (serverStorageSet.Has(mapId))
			{
				serverStorageSet.Remove(mapId);
				EventSystem.Instance.Emit<int>(EEventName.OnPhantomArenaMapUnlockUpdate, mapId);
			}
		}

		// Token: 0x0602A11A RID: 172314 RVA: 0x00BE5348 File Offset: 0x00BE3548
		private void RefreshPhantomArenaActivityRedDot(int activityId)
		{
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, activityId);
		}

		// Token: 0x0602A11B RID: 172315 RVA: 0x00BE535B File Offset: 0x00BE355B
		public bool GetPhantomArenaButtonRedDot(int activityId)
		{
			this.RefreshPhantomArenaActivityRedDot(activityId);
			return this.GetRoleRewardRedDot(activityId) || this.GetCardRewardRedDot(activityId) || this.GetBadgeRewardRedDot(activityId) || this.GetGymRedDot(activityId);
		}

		// Token: 0x0602A11C RID: 172316 RVA: 0x00BE5388 File Offset: 0x00BE3588
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

		// Token: 0x0602A11D RID: 172317 RVA: 0x00BE53FC File Offset: 0x00BE35FC
		public bool GetGymRedDotById(int gymLevel, int activityId)
		{
			if (this.IsGymLock(gymLevel, activityId))
			{
				return false;
			}
			PhantomArenaModel.MigrateLocalGymState(ELocalStoragePlayerKey.PhantomArenaEntranceGymRedDotCheck, 3);
			return !PhantomArenaModel.IsGymCheckedInActivityCache(gymLevel, activityId, 3);
		}

		// Token: 0x0602A11E RID: 172318 RVA: 0x00BE5420 File Offset: 0x00BE3620
		public void SetGymRedDotChecked(int gymLevel, int activityId)
		{
			PhantomArenaModel.MigrateLocalGymState(ELocalStoragePlayerKey.PhantomArenaEntranceGymRedDotCheck, 3);
			PhantomArenaModel.SetGymCheckedInActivityCache(gymLevel, activityId, 3);
			EventSystem.Instance.Emit(EEventName.OnPhantomArenaChallengeUpdate);
		}

		// Token: 0x0602A11F RID: 172319 RVA: 0x00BE5448 File Offset: 0x00BE3648
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

		// Token: 0x0602A120 RID: 172320 RVA: 0x00BE54CC File Offset: 0x00BE36CC
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

		// Token: 0x0602A121 RID: 172321 RVA: 0x00BE5554 File Offset: 0x00BE3754
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

		// Token: 0x0602A122 RID: 172322 RVA: 0x00BE5644 File Offset: 0x00BE3844
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

		// Token: 0x0602A123 RID: 172323 RVA: 0x00BE56DC File Offset: 0x00BE38DC
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

		// Token: 0x0602A124 RID: 172324 RVA: 0x00BE5794 File Offset: 0x00BE3994
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

		// Token: 0x0602A125 RID: 172325 RVA: 0x00BE5814 File Offset: 0x00BE3A14
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

		// Token: 0x0602A126 RID: 172326 RVA: 0x00BE58A0 File Offset: 0x00BE3AA0
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

		// Token: 0x1700545F RID: 21599
		// (get) Token: 0x0602A127 RID: 172327 RVA: 0x00BE592C File Offset: 0x00BE3B2C
		public static PhantomArenaModel Instance
		{
			get
			{
				return PhantomArenaModel._Instance;
			}
		}

		// Token: 0x0602A128 RID: 172328 RVA: 0x00BE5933 File Offset: 0x00BE3B33
		public static PhantomArenaModel GetOrCreateInstance()
		{
			if (PhantomArenaModel._Instance == null)
			{
				PhantomArenaModel.CreateInstance();
			}
			return PhantomArenaModel._Instance;
		}

		// Token: 0x0602A129 RID: 172329 RVA: 0x00BE5947 File Offset: 0x00BE3B47
		public static bool CreateInstance()
		{
			if (PhantomArenaModel._Instance != null)
			{
				return true;
			}
			PhantomArenaModel._Instance = new PhantomArenaModel();
			return true;
		}

		// Token: 0x0602A12A RID: 172330 RVA: 0x00BE595D File Offset: 0x00BE3B5D
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602A12B RID: 172331 RVA: 0x00BE595F File Offset: 0x00BE3B5F
		public static void ResetStaticDefaultValue()
		{
			PhantomArenaModel._Instance = null;
		}

		// Token: 0x0602A12C RID: 172332 RVA: 0x00BE5967 File Offset: 0x00BE3B67
		static PhantomArenaModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PhantomArenaModel.CreateStaticDefaultValue), new Action(PhantomArenaModel.ResetStaticDefaultValue));
		}

		// Token: 0x04016F13 RID: 93971
		public List<int> RoleUnlockQueue = new List<int>();

		// Token: 0x04016F14 RID: 93972
		public List<int> BadgeUnlockQueue = new List<int>();

		// Token: 0x04016F15 RID: 93973
		public List<int> CardUnlockQueue = new List<int>();

		// Token: 0x04016F16 RID: 93974
		public List<int> CardOutlookUnlockQueue = new List<int>();

		// Token: 0x04016F17 RID: 93975
		public bool EntranceOpenQueue;

		// Token: 0x04016F18 RID: 93976
		[Nullable(2)]
		private PhantomArenaActivityData PermanentPhantomArenaActivityDataInner;

		// Token: 0x04016F19 RID: 93977
		[Nullable(2)]
		private static PhantomArenaModel _Instance;
	}
}
