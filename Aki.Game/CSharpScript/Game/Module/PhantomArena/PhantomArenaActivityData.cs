using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x02005103 RID: 20739
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaActivityData : ActivityBaseData
	{
		// Token: 0x0603505F RID: 217183 RVA: 0x00C90358 File Offset: 0x00C8E558
		protected override void PhraseEx(ActivityData data)
		{
			this.ProtocolDeckInfoList.Clear();
			this.ClientDeckInfoList.Clear();
			this.ClientDeckInfoMap.Clear();
			this.CardInfoList.Clear();
			this.ChallengeInfoMap.Clear();
			this.CardInfoMap.Clear();
			this.CardRewardMap.Clear();
			this.BadgeInfoMap.Clear();
			this.BadgeRewardMap.Clear();
			this.RoleInfoMap.Clear();
			this.MapToDifficultChallengeIdsMap.Clear();
			this.UnlockMapIds.Clear();
			this.AllChallengeIds.Clear();
			PhantomBattleActivity phantomBattleActivityConfig = PhantomArenaConfig.Instance.GetPhantomBattleActivityConfig(base.Id);
			this.MaxCoreCardCountInDeck = phantomBattleActivityConfig.FourCostCardCount;
			this.MaxFieldCardCountInDeck = phantomBattleActivityConfig.AreaCardCount;
			this.MaxItemCardCountInDeck = phantomBattleActivityConfig.ItemCardMaxCount;
			this.MaxNormalCardCountInDeck = phantomBattleActivityConfig.NormalCardCount;
			this.MaxCardCountInDeck = this.MaxCoreCardCountInDeck + this.MaxNormalCardCountInDeck + this.MaxFieldCardCountInDeck;
			this.MaxDeckCount = phantomBattleActivityConfig.DeckLimit;
			this.MaxDeckElementCount = phantomBattleActivityConfig.ElementMax;
			this.CostToMaxCardLimitMap = phantomBattleActivityConfig.CardMaxLimit();
			this.CurrencyItem = phantomBattleActivityConfig.ShopItemId;
			this.ShopId = phantomBattleActivityConfig.ShopId;
			PhantomBattleActivityInfo phantomBattleActivityInfo;
			if (data.Type == ActivityType.PhantomBattle)
			{
				phantomBattleActivityInfo = data.PhantomBattleActivityInfo;
			}
			else
			{
				phantomBattleActivityInfo = data.PhantomBattleRecordActivityInfo;
			}
			if (phantomBattleActivityInfo == null)
			{
				return;
			}
			if (data.Type == ActivityType.PhantomBattleRecord)
			{
				base.SetIfFirstOpen(false);
			}
			this.ActivityLimitTime = (int)((double)MathUtils.Instance.LongToNumber(phantomBattleActivityInfo.TimeLimitShopEndTime) * TimeUtil.Instance.Millisecond);
			RepeatedField<PhantomBattleChallengeInfo> phantomBattleChallengeInfos = phantomBattleActivityInfo.PhantomBattleChallengeInfos;
			if (phantomBattleChallengeInfos != null)
			{
				this.UpdateChallengeInfoList(phantomBattleChallengeInfos.ToArray<PhantomBattleChallengeInfo>());
			}
			RepeatedField<PhantomBattleCardInfo> phantomBattleCardInfos = phantomBattleActivityInfo.PhantomBattleCardInfos;
			if (phantomBattleCardInfos != null)
			{
				this.UpdateCardList(phantomBattleCardInfos.ToArray<PhantomBattleCardInfo>());
			}
			RepeatedField<PhantomBattleCardRewardInfo> phantomBattleCardRewardInfos = phantomBattleActivityInfo.PhantomBattleCardRewardInfos;
			if (phantomBattleCardInfos != null)
			{
				this.UpdateCardReward(phantomBattleCardRewardInfos.ToArray<PhantomBattleCardRewardInfo>());
			}
			RepeatedField<PhantomBattleBadgeInfo> phantomBattleBadgeInfos = phantomBattleActivityInfo.PhantomBattleBadgeInfos;
			if (phantomBattleBadgeInfos != null)
			{
				this.UpdateBadgeList(phantomBattleBadgeInfos.ToArray<PhantomBattleBadgeInfo>());
			}
			RepeatedField<PhantomBattleBadgeRewardInfo> phantomBattleBadgeRewardInfos = phantomBattleActivityInfo.PhantomBattleBadgeRewardInfos;
			if (phantomBattleCardInfos != null)
			{
				this.UpdateBadgeReward(phantomBattleBadgeRewardInfos.ToArray<PhantomBattleBadgeRewardInfo>());
			}
			RepeatedField<Aki.Protocol.PhantomBattleCardGroupInfo> phantomBattleCardGroupInfos = phantomBattleActivityInfo.PhantomBattleCardGroupInfos;
			if (phantomBattleCardGroupInfos != null)
			{
				this.UpdateProtocolDeckInfoList(phantomBattleCardGroupInfos.ToArray<Aki.Protocol.PhantomBattleCardGroupInfo>());
			}
			PhantomBattleMasterInfo phantomBattleMasterInfo = phantomBattleActivityInfo.PhantomBattleMasterInfo;
			if (phantomBattleMasterInfo != null)
			{
				this.UpdateMasterInfo(phantomBattleMasterInfo);
			}
			RepeatedField<PhantomBattleRoleInfo> phantomBattleRoleInfos = phantomBattleActivityInfo.PhantomBattleRoleInfos;
			if (phantomBattleRoleInfos != null)
			{
				this.UpdateRoleInfo(phantomBattleRoleInfos.ToArray<PhantomBattleRoleInfo>());
			}
			RepeatedField<ActivityTask> activityTasks = phantomBattleActivityInfo.ActivityTasks;
			if (activityTasks != null)
			{
				this.UpdateTaskInfo(activityTasks.ToArray<ActivityTask>());
			}
			this.UpdateShopInfo();
		}

		// Token: 0x06035060 RID: 217184 RVA: 0x00C905C2 File Offset: 0x00C8E7C2
		private void UpdateShopInfo()
		{
			EventSystem.Instance.Emit(EEventName.OnPhantomArenaShopOpen);
		}

		// Token: 0x06035061 RID: 217185 RVA: 0x00C905D4 File Offset: 0x00C8E7D4
		public void UpdateChallengeInfoById(int challengeId, bool isUnLock, bool hasPass, bool isUnCover)
		{
			if (!this.ChallengeInfoMap.ContainsKey(challengeId))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.PhantomArena;
				ELogAuthor author = ELogAuthor.WDX;
				string message = "挑战进度更新失败，此挑战未初始化";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ChallengeId", challengeId);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			PhantomBattleChallengeInfo phantomBattleChallengeInfo = this.ChallengeInfoMap[challengeId];
			if (phantomBattleChallengeInfo.IsUnlock != isUnLock && isUnLock)
			{
				this.CurrentUnlockChallengeIds.Add(challengeId);
				this.UnlockMapIds.Add(PhantomArenaConfig.Instance.GetPhantomBattleChallenge(challengeId).MapId);
			}
			phantomBattleChallengeInfo.IsUnlock = isUnLock;
			phantomBattleChallengeInfo.IsPassRewarded = hasPass;
			phantomBattleChallengeInfo.IsUncover = isUnCover;
			PhantomArenaModel.Instance.SaveChallengeUnlockRedDotById(challengeId, isUnLock);
			PhantomArenaModel.Instance.SaveMapUnlockRedDotById(PhantomArenaConfig.Instance.GetPhantomBattleChallenge(challengeId).MapId, isUnLock);
			EventSystem.Instance.Emit(EEventName.OnPhantomArenaChallengeUpdate);
		}

		// Token: 0x06035062 RID: 217186 RVA: 0x00C906B8 File Offset: 0x00C8E8B8
		public void UpdateChallengeInfoList(PhantomBattleChallengeInfo[] challengeInfoList)
		{
			this.ChallengeInfoMap.Clear();
			this.MapToDifficultChallengeIdsMap.Clear();
			this.AllChallengeIds.Clear();
			foreach (PhantomBattleChallengeInfo phantomBattleChallengeInfo in challengeInfoList)
			{
				int phantomBattleChallengeId = phantomBattleChallengeInfo.PhantomBattleChallengeId;
				this.ChallengeInfoMap[phantomBattleChallengeId] = phantomBattleChallengeInfo;
				PhantomBattleChallenge phantomBattleChallenge = PhantomArenaConfig.Instance.GetPhantomBattleChallenge(phantomBattleChallengeId);
				if (phantomBattleChallenge.IsShowEntrance)
				{
					if (!this.MapToDifficultChallengeIdsMap.ContainsKey(phantomBattleChallenge.MapId))
					{
						this.MapToDifficultChallengeIdsMap[phantomBattleChallenge.MapId] = new Dictionary<int, List<int>>();
					}
					Dictionary<int, List<int>> dictionary = this.MapToDifficultChallengeIdsMap[phantomBattleChallenge.MapId];
					if (!dictionary.ContainsKey(phantomBattleChallenge.Difficult))
					{
						dictionary[phantomBattleChallenge.Difficult] = new List<int>();
					}
					dictionary[phantomBattleChallenge.Difficult].Add(phantomBattleChallengeId);
					this.AllChallengeIds.Add(phantomBattleChallengeId);
					PhantomArenaModel.Instance.SaveChallengeUnlockRedDotById(phantomBattleChallengeId, phantomBattleChallengeInfo.IsUnlock);
					PhantomArenaModel.Instance.SaveMapUnlockRedDotById(phantomBattleChallenge.MapId, phantomBattleChallengeInfo.IsUnlock);
					if (phantomBattleChallengeInfo.IsUnlock)
					{
						this.UnlockMapIds.Add(phantomBattleChallenge.MapId);
					}
				}
			}
			EventSystem.Instance.Emit(EEventName.OnPhantomArenaChallengeUpdate);
		}

		// Token: 0x06035063 RID: 217187 RVA: 0x00C90804 File Offset: 0x00C8EA04
		public void UpdateChallengeFinishConditions(int challengeId, List<int> finishConditions)
		{
			if (!this.ChallengeInfoMap.ContainsKey(challengeId))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.PhantomArena;
				ELogAuthor author = ELogAuthor.CB;
				string message = "挑战进度更新失败，此挑战未初始化";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ChallengeId", challengeId);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.ChallengeInfoMap[challengeId].FinishConditions.Add(finishConditions);
		}

		// Token: 0x06035064 RID: 217188 RVA: 0x00C90868 File Offset: 0x00C8EA68
		public void UpdateProtocolDeckInfoList(Aki.Protocol.PhantomBattleCardGroupInfo[] deckList)
		{
			this.ProtocolDeckInfoList = deckList.ToList<Aki.Protocol.PhantomBattleCardGroupInfo>();
			this.ClientDeckInfoList.Clear();
			this.ClientDeckInfoMap.Clear();
			foreach (Aki.Protocol.PhantomBattleCardGroupInfo phantomBattleCardGroupInfo in deckList)
			{
				DeckInfo deckInfo = this.CovertProtocolDeckInfoToClientDeckInfo(phantomBattleCardGroupInfo);
				this.ClientDeckInfoList.Add(deckInfo);
				this.ClientDeckInfoMap[phantomBattleCardGroupInfo.Index] = deckInfo;
			}
		}

		// Token: 0x06035065 RID: 217189 RVA: 0x00C908D4 File Offset: 0x00C8EAD4
		public void AddProtocolDeckInfo(Aki.Protocol.PhantomBattleCardGroupInfo deckInfo)
		{
			this.ProtocolDeckInfoList.Add(deckInfo);
			DeckInfo deckInfo2 = this.CovertProtocolDeckInfoToClientDeckInfo(deckInfo);
			this.ClientDeckInfoList.Add(deckInfo2);
			this.ClientDeckInfoMap[deckInfo.Index] = deckInfo2;
		}

		// Token: 0x06035066 RID: 217190 RVA: 0x00C90914 File Offset: 0x00C8EB14
		public void DeleteProtocolDeckInfo(int deckServerId)
		{
			int num = this.ProtocolDeckInfoList.FindIndex((Aki.Protocol.PhantomBattleCardGroupInfo info) => info.Index == deckServerId);
			if (num != -1)
			{
				this.ProtocolDeckInfoList.RemoveAt(num);
			}
			num = this.ClientDeckInfoList.FindIndex((DeckInfo info) => info.GetDeckServerId() == deckServerId);
			if (num != -1)
			{
				this.ClientDeckInfoList.RemoveAt(num);
			}
			this.ClientDeckInfoMap.Remove(deckServerId);
		}

		// Token: 0x06035067 RID: 217191 RVA: 0x00C90990 File Offset: 0x00C8EB90
		public void UpdateProtocolDeckInfo(Aki.Protocol.PhantomBattleCardGroupInfo deckInfo)
		{
			int index = deckInfo.Index;
			this.ProtocolDeckInfoList[index] = deckInfo;
			DeckInfo value = this.CovertProtocolDeckInfoToClientDeckInfo(deckInfo);
			this.ClientDeckInfoList[index] = value;
			this.ClientDeckInfoMap[index] = value;
		}

		// Token: 0x06035068 RID: 217192 RVA: 0x00C909D4 File Offset: 0x00C8EBD4
		public void RemoveProtocolDeckInfo(int deckServerId)
		{
			int num = this.ProtocolDeckInfoList.FindIndex((Aki.Protocol.PhantomBattleCardGroupInfo deckInfo) => deckInfo.Index == deckServerId);
			if (num != -1)
			{
				this.ProtocolDeckInfoList.RemoveAt(num);
			}
			int num2 = this.ClientDeckInfoList.FindIndex((DeckInfo deckInfo) => deckInfo.GetDeckServerId() == deckServerId);
			if (num2 != -1)
			{
				this.ClientDeckInfoList.RemoveAt(num2);
			}
			this.ClientDeckInfoMap.Remove(deckServerId);
		}

		// Token: 0x06035069 RID: 217193 RVA: 0x00C90A50 File Offset: 0x00C8EC50
		public PhantomBattleCardSkillUnlockInfo GetFieldCardSkillUnlockInfo(int cardConfigId)
		{
			foreach (DeckInfo deckInfo in this.ClientDeckInfoList)
			{
				PhantomBattleCardSkillUnlockInfo fieldCardSkillUnlockInfo = deckInfo.GetFieldCardSkillUnlockInfo();
				if (fieldCardSkillUnlockInfo != null && fieldCardSkillUnlockInfo.CardId == cardConfigId)
				{
					return deckInfo.GetFieldCardSkillUnlockInfo();
				}
			}
			return null;
		}

		// Token: 0x0603506A RID: 217194 RVA: 0x00C90AC0 File Offset: 0x00C8ECC0
		public DeckInfo CovertProtocolDeckInfoToClientDeckInfo(Aki.Protocol.PhantomBattleCardGroupInfo deckInfo)
		{
			DeckInfo deckInfo2 = this.CreateClientDeckInfo();
			foreach (int num in deckInfo.EquipCardIds)
			{
				PhantomBattleCard phantomBattleCardConfig = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(num);
				AddCardContext context = new AddCardContext
				{
					CardId = num,
					Cost = phantomBattleCardConfig.Cost,
					Element = phantomBattleCardConfig.Element,
					MaxCount = phantomBattleCardConfig.CardGroupNum,
					AddCount = 1,
					CardType = (ECardType)phantomBattleCardConfig.Type
				};
				if (deckInfo2.AddCard(context) != EAddCardResult.Success)
				{
					Log.Instance.Error(ELogModule.PhantomArena, ELogAuthor.LZK, "服务器同步的卡组数据不合规", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
			}
			deckInfo2.SetDeckServerId(deckInfo.Index);
			deckInfo2.SetDeckName(deckInfo.Name);
			deckInfo2.SetCanUse(deckInfo.CanUse);
			foreach (PhantomBattleCardSkillUnlockInfo phantomBattleCardSkillUnlockInfo in deckInfo.SkillUnlockInfos)
			{
				int cardId = phantomBattleCardSkillUnlockInfo.CardId;
				if (PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(cardId).Type == 3)
				{
					deckInfo2.SetFieldCardSkillUnlockInfo(phantomBattleCardSkillUnlockInfo);
					break;
				}
			}
			return deckInfo2;
		}

		// Token: 0x0603506B RID: 217195 RVA: 0x00C90C20 File Offset: 0x00C8EE20
		public DeckInfo CreateClientDeckInfo()
		{
			DeckInfo deckInfo = new DeckInfo();
			deckInfo.SetNormalCardCountLimit(this.MaxNormalCardCountInDeck);
			deckInfo.SetCoreCardCountLimit(this.MaxCoreCardCountInDeck);
			deckInfo.SetFieldCardCountLimit(this.MaxFieldCardCountInDeck);
			deckInfo.SetItemCardCountLimit(this.MaxItemCardCountInDeck);
			deckInfo.SetElementCountLimit(this.MaxDeckElementCount);
			EFunctionType functionId = (base.Type == ActivityType.PhantomBattleRecord) ? EFunctionType.PermanentPhantomArenaCoreCardSlot : EFunctionType.PhantomArenaCoreCardSlot;
			deckInfo.SetIsCoreCardSlotLocked(!FunctionModel.Instance.IsOpen(functionId));
			deckInfo.SetCoreCost(PhantomArenaConfig.Instance.GetPhantomArenaCardCoreCost());
			deckInfo.SetCostToMaxCardLimitMap(this.CostToMaxCardLimitMap);
			return deckInfo;
		}

		// Token: 0x0603506C RID: 217196 RVA: 0x00C90CB5 File Offset: 0x00C8EEB5
		public void ClearClientDeckInfoList()
		{
			this.ClientDeckInfoList.Clear();
		}

		// Token: 0x0603506D RID: 217197 RVA: 0x00C90CC4 File Offset: 0x00C8EEC4
		public void AddDebugClientDeckInfo(List<int> cardIdList)
		{
			DeckInfo deckInfo = this.CreateClientDeckInfo();
			foreach (int num in cardIdList)
			{
				PhantomBattleCard phantomBattleCardConfig = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(num);
				AddCardContext context = new AddCardContext
				{
					CardId = num,
					Cost = phantomBattleCardConfig.Cost,
					Element = phantomBattleCardConfig.Element,
					MaxCount = phantomBattleCardConfig.CardGroupNum,
					AddCount = 1,
					CardType = (ECardType)phantomBattleCardConfig.Type
				};
				deckInfo.AddCard(context);
			}
			this.ClientDeckInfoList.Add(deckInfo);
		}

		// Token: 0x0603506E RID: 217198 RVA: 0x00C90D7C File Offset: 0x00C8EF7C
		public void UpdateCardList(PhantomBattleCardInfo[] cardList)
		{
			this.CardInfoList = cardList.ToList<PhantomBattleCardInfo>();
			this.CardInfoMap.Clear();
			foreach (PhantomBattleCardInfo phantomBattleCardInfo in cardList)
			{
				this.CardInfoMap[phantomBattleCardInfo.PhantomBattleCardId] = phantomBattleCardInfo;
			}
		}

		// Token: 0x0603506F RID: 217199 RVA: 0x00C90DC8 File Offset: 0x00C8EFC8
		public void UpdateBadgeList(PhantomBattleBadgeInfo[] badgeList)
		{
			this.BadgeInfoMap.Clear();
			foreach (PhantomBattleBadgeInfo phantomBattleBadgeInfo in badgeList)
			{
				this.BadgeInfoMap[phantomBattleBadgeInfo.PhantomBattleBadgeId] = phantomBattleBadgeInfo;
			}
		}

		// Token: 0x06035070 RID: 217200 RVA: 0x00C90E08 File Offset: 0x00C8F008
		public void AddCardListByNotify(PhantomBattleCardInfo[] cardList)
		{
			this.CardInfoList.AddRange(cardList);
			foreach (PhantomBattleCardInfo phantomBattleCardInfo in cardList)
			{
				this.CardInfoMap[phantomBattleCardInfo.PhantomBattleCardId] = phantomBattleCardInfo;
			}
			if (cardList.Length == 0)
			{
				return;
			}
			int phantomBattleCardId = cardList[0].PhantomBattleCardId;
			EventSystem.Instance.Emit<int>(EEventName.OnPhantomArenaCardUnlock, phantomBattleCardId);
			EventSystem.Instance.Emit<int>(EEventName.OnPhantomArenaCardRewardUpdate, base.Id);
		}

		// Token: 0x06035071 RID: 217201 RVA: 0x00C90E7C File Offset: 0x00C8F07C
		public void AddBadgeListByNotify(PhantomBattleBadgeInfo[] badgeList)
		{
			foreach (PhantomBattleBadgeInfo phantomBattleBadgeInfo in badgeList)
			{
				this.BadgeInfoMap[phantomBattleBadgeInfo.PhantomBattleBadgeId] = phantomBattleBadgeInfo;
			}
			EventSystem.Instance.Emit(EEventName.OnPhantomArenaBadgeRewardUpdate);
		}

		// Token: 0x06035072 RID: 217202 RVA: 0x00C90EBF File Offset: 0x00C8F0BF
		public List<PhantomBattleCardInfo> GetCardList()
		{
			return this.CardInfoList;
		}

		// Token: 0x06035073 RID: 217203 RVA: 0x00C90EC7 File Offset: 0x00C8F0C7
		public PhantomBattleCardInfo GetCardInfo(int cardId)
		{
			if (!this.CardInfoMap.ContainsKey(cardId))
			{
				return null;
			}
			return this.CardInfoMap[cardId];
		}

		// Token: 0x06035074 RID: 217204 RVA: 0x00C90EE5 File Offset: 0x00C8F0E5
		public PhantomBattleBadgeInfo GetBadgeInfo(int badgeId)
		{
			if (!this.BadgeInfoMap.ContainsKey(badgeId))
			{
				return null;
			}
			return this.BadgeInfoMap[badgeId];
		}

		// Token: 0x06035075 RID: 217205 RVA: 0x00C90F04 File Offset: 0x00C8F104
		public bool IsCardUnlock(int cardId)
		{
			PhantomBattleCardInfo cardInfo = this.GetCardInfo(cardId);
			return cardInfo != null && cardInfo.IsUnlock;
		}

		// Token: 0x06035076 RID: 217206 RVA: 0x00C90F24 File Offset: 0x00C8F124
		public bool IsCardOutlookUnlock(int cardId)
		{
			PhantomBattleCardInfo cardInfo = this.GetCardInfo(cardId);
			return cardInfo != null && cardInfo.IsUnlockOutLook;
		}

		// Token: 0x06035077 RID: 217207 RVA: 0x00C90F44 File Offset: 0x00C8F144
		public bool IsBadgeUnlock(int badgeId)
		{
			PhantomBattleBadgeInfo badgeInfo = this.GetBadgeInfo(badgeId);
			return badgeInfo != null && badgeInfo.IsUnlock;
		}

		// Token: 0x06035078 RID: 217208 RVA: 0x00C90F64 File Offset: 0x00C8F164
		public void OnCardOutlookUnlock(int cardId)
		{
			PhantomBattleCardInfo cardInfo = this.GetCardInfo(cardId);
			if (cardInfo != null)
			{
				cardInfo.IsUnlockOutLook = true;
			}
			EventSystem.Instance.Emit<int>(EEventName.OnPhantomArenaCardOutlookUnlock, cardId);
			EventSystem.Instance.Emit<int>(EEventName.OnPhantomArenaCardRewardUpdate, base.Id);
		}

		// Token: 0x06035079 RID: 217209 RVA: 0x00C90FAC File Offset: 0x00C8F1AC
		public bool IsCardOutLookUnlock(int cardId)
		{
			PhantomBattleCardInfo cardInfo = this.GetCardInfo(cardId);
			return cardInfo != null && cardInfo.IsUnlockOutLook;
		}

		// Token: 0x0603507A RID: 217210 RVA: 0x00C90FCC File Offset: 0x00C8F1CC
		public int GetMaxCardCountInDeck()
		{
			return this.MaxCardCountInDeck;
		}

		// Token: 0x0603507B RID: 217211 RVA: 0x00C90FD4 File Offset: 0x00C8F1D4
		public int GetMaxCoreCardCountInDeck()
		{
			return this.MaxCoreCardCountInDeck;
		}

		// Token: 0x0603507C RID: 217212 RVA: 0x00C90FDC File Offset: 0x00C8F1DC
		public int GetMaxNormalCardCountInDeck()
		{
			return this.MaxNormalCardCountInDeck;
		}

		// Token: 0x0603507D RID: 217213 RVA: 0x00C90FE4 File Offset: 0x00C8F1E4
		public List<DeckInfo> GetClientDeckInfoList()
		{
			return this.ClientDeckInfoList;
		}

		// Token: 0x0603507E RID: 217214 RVA: 0x00C90FEC File Offset: 0x00C8F1EC
		public DeckInfo GetClientDeckInfo(int deckId)
		{
			if (!this.ClientDeckInfoMap.ContainsKey(deckId))
			{
				return null;
			}
			return this.ClientDeckInfoMap[deckId];
		}

		// Token: 0x0603507F RID: 217215 RVA: 0x00C9100C File Offset: 0x00C8F20C
		public List<DeckInfo> CreateDeckInfoListFromProtocol()
		{
			List<DeckInfo> list = new List<DeckInfo>();
			foreach (Aki.Protocol.PhantomBattleCardGroupInfo deckInfo in this.ProtocolDeckInfoList)
			{
				list.Add(this.CovertProtocolDeckInfoToClientDeckInfo(deckInfo));
			}
			return list;
		}

		// Token: 0x06035080 RID: 217216 RVA: 0x00C9106C File Offset: 0x00C8F26C
		public int GetMaxDeckCount()
		{
			return this.MaxDeckCount;
		}

		// Token: 0x06035081 RID: 217217 RVA: 0x00C91074 File Offset: 0x00C8F274
		public PhantomBattleChallengeInfo GetChallengeInfoById(int challengeId)
		{
			if (!this.ChallengeInfoMap.ContainsKey(challengeId))
			{
				return null;
			}
			return this.ChallengeInfoMap[challengeId];
		}

		// Token: 0x06035082 RID: 217218 RVA: 0x00C91092 File Offset: 0x00C8F292
		public Dictionary<int, List<int>> GetDifficultChallengeIdsMap(int mapId)
		{
			if (!this.MapToDifficultChallengeIdsMap.ContainsKey(mapId))
			{
				return null;
			}
			return this.MapToDifficultChallengeIdsMap[mapId];
		}

		// Token: 0x06035083 RID: 217219 RVA: 0x00C910B0 File Offset: 0x00C8F2B0
		public List<int> GetAllChallengeIds()
		{
			return this.AllChallengeIds;
		}

		// Token: 0x06035084 RID: 217220 RVA: 0x00C910B8 File Offset: 0x00C8F2B8
		public int GetFinishedChallengeCount()
		{
			int num = 0;
			using (Dictionary<int, PhantomBattleChallengeInfo>.ValueCollection.Enumerator enumerator = this.ChallengeInfoMap.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.IsPassRewarded)
					{
						num++;
					}
				}
			}
			return num;
		}

		// Token: 0x06035085 RID: 217221 RVA: 0x00C91118 File Offset: 0x00C8F318
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public ValueTuple<bool, string> GetIsInLimitTime(string textId = null)
		{
			int activityLimitTime = this.ActivityLimitTime;
			if (TimeUtil.Instance.GetServerTime() > (double)activityLimitTime)
			{
				return new ValueTuple<bool, string>(false, "");
			}
			string item = ActivityModel.Instance.GetRemainTimeText((long)activityLimitTime, textId ?? "{0}") ?? "";
			return new ValueTuple<bool, string>(true, item);
		}

		// Token: 0x06035086 RID: 217222 RVA: 0x00C9116D File Offset: 0x00C8F36D
		public HashSet<int> GetCurrentUnlockChallengeIds()
		{
			return this.CurrentUnlockChallengeIds;
		}

		// Token: 0x06035087 RID: 217223 RVA: 0x00C91178 File Offset: 0x00C8F378
		public void UpdateRoleInfo(PhantomBattleRoleInfo[] roleInfos)
		{
			foreach (PhantomBattleRoleInfo phantomBattleRoleInfo in roleInfos)
			{
				this.RoleInfoMap[phantomBattleRoleInfo.PhantomBattleRoleId] = phantomBattleRoleInfo;
			}
			EventSystem.Instance.Emit<int>(EEventName.OnPhantomArenaRoleRewardUpdate, base.Id);
		}

		// Token: 0x06035088 RID: 217224 RVA: 0x00C911C1 File Offset: 0x00C8F3C1
		public void AddRoleInfo(PhantomBattleRoleInfo roleInfo)
		{
			this.RoleInfoMap[roleInfo.PhantomBattleRoleId] = roleInfo;
			EventSystem.Instance.Emit<int>(EEventName.OnPhantomArenaRoleRewardUpdate, base.Id);
		}

		// Token: 0x06035089 RID: 217225 RVA: 0x00C911EB File Offset: 0x00C8F3EB
		public void OnRoleReward(int roleId)
		{
			if (this.RoleInfoMap.ContainsKey(roleId))
			{
				this.RoleInfoMap[roleId].IsRewarded = true;
			}
			EventSystem.Instance.Emit<int>(EEventName.OnPhantomArenaRoleRewardUpdate, base.Id);
		}

		// Token: 0x0603508A RID: 217226 RVA: 0x00C91224 File Offset: 0x00C8F424
		public bool IsRoleUnlock(int roleId)
		{
			if (!this.RoleInfoMap.ContainsKey(roleId))
			{
				return false;
			}
			PhantomBattleRoleInfo phantomBattleRoleInfo = this.RoleInfoMap[roleId];
			return phantomBattleRoleInfo != null && phantomBattleRoleInfo.IsUnlock;
		}

		// Token: 0x0603508B RID: 217227 RVA: 0x00C9125C File Offset: 0x00C8F45C
		public bool IsRoleReward(int roleId)
		{
			if (!this.RoleInfoMap.ContainsKey(roleId))
			{
				return false;
			}
			PhantomBattleRoleInfo phantomBattleRoleInfo = this.RoleInfoMap[roleId];
			return phantomBattleRoleInfo != null && phantomBattleRoleInfo.IsRewarded;
		}

		// Token: 0x0603508C RID: 217228 RVA: 0x00C91291 File Offset: 0x00C8F491
		public override bool GetExDataRedPointShowState()
		{
			ActivityType type = base.Type;
			return !PhantomArenaActivityData.hideActivityTypeList.Contains(base.Type) && PhantomArenaModel.Instance.GetPhantomArenaActivityRedDot(base.Id);
		}

		// Token: 0x0603508D RID: 217229 RVA: 0x00C912C0 File Offset: 0x00C8F4C0
		protected override bool GetExDataFinishShowState()
		{
			if (base.Type != ActivityType.PhantomBattle)
			{
				return false;
			}
			int masterLevelMax = PhantomArenaModel.Instance.GetMasterLevelMax(base.Id);
			if (this.GetMasterLevelRewardTakenIds().Count < masterLevelMax - 1)
			{
				return false;
			}
			using (Dictionary<int, PhantomBattleBadgeRewardInfo>.ValueCollection.Enumerator enumerator = this.BadgeRewardMap.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (!enumerator.Current.IsRewarded)
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x0603508E RID: 217230 RVA: 0x00C91350 File Offset: 0x00C8F550
		public void UpdateCardReward(PhantomBattleCardRewardInfo[] rewardList)
		{
			this.CardRewardMap.Clear();
			foreach (PhantomBattleCardRewardInfo phantomBattleCardRewardInfo in rewardList)
			{
				this.CardRewardMap[phantomBattleCardRewardInfo.PhantomBattleCardRewardId] = phantomBattleCardRewardInfo;
			}
			EventSystem.Instance.Emit<int>(EEventName.OnPhantomArenaCardRewardUpdate, base.Id);
		}

		// Token: 0x0603508F RID: 217231 RVA: 0x00C913A4 File Offset: 0x00C8F5A4
		public void UpdateBadgeReward(PhantomBattleBadgeRewardInfo[] rewardList)
		{
			this.BadgeRewardMap.Clear();
			foreach (PhantomBattleBadgeRewardInfo phantomBattleBadgeRewardInfo in rewardList)
			{
				this.BadgeRewardMap[phantomBattleBadgeRewardInfo.PhantomBattleBadgeRewardId] = phantomBattleBadgeRewardInfo;
			}
			EventSystem.Instance.Emit(EEventName.OnPhantomArenaBadgeRewardUpdate);
		}

		// Token: 0x06035090 RID: 217232 RVA: 0x00C913F4 File Offset: 0x00C8F5F4
		public void UpdateBadgeRewardByIds(List<int> rewardIds)
		{
			foreach (int key in rewardIds)
			{
				if (!this.BadgeRewardMap.ContainsKey(key))
				{
					return;
				}
				this.BadgeRewardMap[key].IsRewarded = true;
			}
			EventSystem.Instance.Emit(EEventName.OnPhantomArenaBadgeRewardUpdate);
		}

		// Token: 0x06035091 RID: 217233 RVA: 0x00C91470 File Offset: 0x00C8F670
		public PhantomBattleCardRewardInfo GetCardRewardInfoById(int rewardId)
		{
			if (!this.CardRewardMap.ContainsKey(rewardId))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.PhantomArena;
				ELogAuthor author = ELogAuthor.WDX;
				string message = "获取卡牌奖励失败，奖励信息未初始化";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("奖励ID", rewardId);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			if (!this.CardRewardMap.ContainsKey(rewardId))
			{
				return null;
			}
			return this.CardRewardMap[rewardId];
		}

		// Token: 0x06035092 RID: 217234 RVA: 0x00C914D8 File Offset: 0x00C8F6D8
		public void UpdateCardRewardByIds(List<int> rewardIds)
		{
			foreach (int key in rewardIds)
			{
				if (!this.CardRewardMap.ContainsKey(key))
				{
					return;
				}
				this.CardRewardMap[key].IsRewarded = true;
			}
			EventSystem.Instance.Emit<int>(EEventName.OnPhantomArenaCardRewardUpdate, base.Id);
		}

		// Token: 0x06035093 RID: 217235 RVA: 0x00C91558 File Offset: 0x00C8F758
		public PhantomBattleBadgeRewardInfo GetBadgeRewardInfoById(int rewardId)
		{
			if (!this.BadgeRewardMap.ContainsKey(rewardId))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.PhantomArena;
				ELogAuthor author = ELogAuthor.WDX;
				string message = "获取徽章奖励失败，奖励信息未初始化";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("奖励ID", rewardId);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			if (!this.BadgeRewardMap.ContainsKey(rewardId))
			{
				return null;
			}
			return this.BadgeRewardMap[rewardId];
		}

		// Token: 0x06035094 RID: 217236 RVA: 0x00C915BE File Offset: 0x00C8F7BE
		public void UpdateMasterInfo(PhantomBattleMasterInfo masterInfo)
		{
			this.MasterInfo = masterInfo;
			EventSystem.Instance.Emit(EEventName.OnPhantomArenaMasterInfoUpdate);
		}

		// Token: 0x06035095 RID: 217237 RVA: 0x00C915D7 File Offset: 0x00C8F7D7
		public int GetMasterLevel()
		{
			if (this.MasterInfo == null)
			{
				return 1;
			}
			return this.MasterInfo.PhantomBattleMasterLevelId;
		}

		// Token: 0x06035096 RID: 217238 RVA: 0x00C915F0 File Offset: 0x00C8F7F0
		public int GetMasterTitleId()
		{
			if (this.MasterInfo == null)
			{
				return 1;
			}
			int phantomBattleMasterLevelId = this.MasterInfo.PhantomBattleMasterLevelId;
			return PhantomArenaConfig.Instance.GetPhantomBattleMasterLevelByLevelAndActivityId(phantomBattleMasterLevelId, base.Id).Value.TitleId;
		}

		// Token: 0x06035097 RID: 217239 RVA: 0x00C91634 File Offset: 0x00C8F834
		public int GetMasterExp()
		{
			if (this.MasterInfo == null)
			{
				return 0;
			}
			PhantomBattleMasterInfo masterInfo = this.MasterInfo;
			if (masterInfo == null)
			{
				return 0;
			}
			return masterInfo.Exp;
		}

		// Token: 0x06035098 RID: 217240 RVA: 0x00C91651 File Offset: 0x00C8F851
		public int GetMasterExpWeek()
		{
			PhantomBattleMasterInfo masterInfo = this.MasterInfo;
			if (masterInfo == null)
			{
				return 0;
			}
			return masterInfo.WeekRewardExp;
		}

		// Token: 0x06035099 RID: 217241 RVA: 0x00C91664 File Offset: 0x00C8F864
		public List<int> GetMasterLevelRewardTakenIds()
		{
			if (this.MasterInfo == null)
			{
				return new List<int>();
			}
			return this.MasterInfo.RewardedPhantomBattleMasterLevelIds.ToList<int>();
		}

		// Token: 0x0603509A RID: 217242 RVA: 0x00C91684 File Offset: 0x00C8F884
		public bool GetMasterLevelRewardIfTaken(int levelConfigId)
		{
			return this.GetMasterLevelRewardTakenIds().Contains(levelConfigId);
		}

		// Token: 0x0603509B RID: 217243 RVA: 0x00C91694 File Offset: 0x00C8F894
		public void UpdateMasterLevelByConfigId(int levelConfigId)
		{
			if (this.MasterInfo == null)
			{
				return;
			}
			RepeatedField<int> rewardedPhantomBattleMasterLevelIds = this.MasterInfo.RewardedPhantomBattleMasterLevelIds;
			if (rewardedPhantomBattleMasterLevelIds.Contains(levelConfigId))
			{
				return;
			}
			rewardedPhantomBattleMasterLevelIds.Add(levelConfigId);
			EventSystem.Instance.Emit(EEventName.OnPhantomArenaMasterInfoUpdate);
		}

		// Token: 0x0603509C RID: 217244 RVA: 0x00C916D8 File Offset: 0x00C8F8D8
		public void SetLastUsedDeckServerId(int deckServerId)
		{
			if (this.MasterInfo == null)
			{
				Log.Instance.Info(ELogModule.PhantomArena, ELogAuthor.LZK, "设置召唤师上次使用的卡组失败，召唤师信息未初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.MasterInfo.LastUseCardGroupIndex = deckServerId;
		}

		// Token: 0x0603509D RID: 217245 RVA: 0x00C9171C File Offset: 0x00C8F91C
		public int GetLastUsedDeckServerId()
		{
			if (this.MasterInfo == null)
			{
				Log.Instance.Info(ELogModule.PhantomArena, ELogAuthor.LZK, "获取召唤师上次使用的卡组失败，召唤师信息未初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
				return -1;
			}
			return this.MasterInfo.LastUseCardGroupIndex;
		}

		// Token: 0x0603509E RID: 217246 RVA: 0x00C91760 File Offset: 0x00C8F960
		public int GetLastUsedCardRoleId()
		{
			if (this.MasterInfo == null)
			{
				Log.Instance.Info(ELogModule.PhantomArena, ELogAuthor.LZK, "获取召唤师上次使用的角色失败，召唤师信息未初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
				return -1;
			}
			return this.MasterInfo.LastUseCardRoleId;
		}

		// Token: 0x0603509F RID: 217247 RVA: 0x00C917A4 File Offset: 0x00C8F9A4
		public void UpdateTaskInfo(ActivityTask[] taskInfos)
		{
			foreach (ActivityTask activityTask in taskInfos)
			{
				PhantomBattleTask? taskConfigById = PhantomArenaConfig.Instance.GetTaskConfigById(activityTask.Id);
				if (taskConfigById != null)
				{
					this.TaskMap[activityTask.Id] = activityTask;
					if (!this.TaskTab.ContainsKey(taskConfigById.Value.TaskType))
					{
						if (taskConfigById.Value.TaskType == 0)
						{
							this.SpecialTaskId = activityTask.Id;
						}
						else
						{
							this.TaskTab[taskConfigById.Value.TaskType] = new List<int>();
						}
					}
					if (taskConfigById.Value.TaskType != 0 && !this.TaskTab[taskConfigById.Value.TaskType].Contains(activityTask.Id))
					{
						this.TaskTab[taskConfigById.Value.TaskType].Add(activityTask.Id);
					}
				}
			}
			foreach (KeyValuePair<int, List<int>> keyValuePair in this.TaskTab)
			{
				this.SortTaskList(keyValuePair.Key);
			}
			EventSystem.Instance.Emit<int>(EEventName.OnPhantomArenaTaskAwardUpdate, base.Id);
		}

		// Token: 0x060350A0 RID: 217248 RVA: 0x00C9191C File Offset: 0x00C8FB1C
		private void SortTaskList(int tabId)
		{
			if (!this.TaskTab.ContainsKey(tabId))
			{
				return;
			}
			List<int> list = this.TaskTab[tabId];
			list.Sort(delegate(int a, int b)
			{
				ActivityTask activityTask = this.TaskMap[a];
				ActivityTask activityTask2 = this.TaskMap[b];
				if (activityTask.Status == activityTask2.Status)
				{
					return a - b;
				}
				int num = (activityTask != null && activityTask.Status == ActivityTaskState.ActivityTaskFinish) ? 0 : ((activityTask != null && activityTask.Status == ActivityTaskState.ActivityTaskRunning) ? 1 : 2);
				int num2 = (activityTask2 != null && activityTask2.Status == ActivityTaskState.ActivityTaskFinish) ? 0 : ((activityTask2 != null && activityTask2.Status == ActivityTaskState.ActivityTaskRunning) ? 1 : 2);
				return num - num2;
			});
			this.TaskTab[tabId] = list;
		}

		// Token: 0x060350A1 RID: 217249 RVA: 0x00C91964 File Offset: 0x00C8FB64
		public void UpdateTaskByIdList(List<int> taskIdList)
		{
			foreach (int num in taskIdList)
			{
				PhantomBattleTask? taskConfigById = PhantomArenaConfig.Instance.GetTaskConfigById(num);
				this.TaskMap[num].Status = ActivityTaskState.ActivityTaskTaken;
				this.SortTaskList(taskConfigById.Value.TaskType);
			}
			EventSystem.Instance.Emit<int>(EEventName.OnPhantomArenaTaskAwardUpdate, base.Id);
		}

		// Token: 0x060350A2 RID: 217250 RVA: 0x00C919F4 File Offset: 0x00C8FBF4
		public Dictionary<int, List<int>> GetTaskTabMap()
		{
			return this.TaskTab;
		}

		// Token: 0x060350A3 RID: 217251 RVA: 0x00C919FC File Offset: 0x00C8FBFC
		public Dictionary<int, ActivityTask> GetTaskMap()
		{
			return this.TaskMap;
		}

		// Token: 0x060350A4 RID: 217252 RVA: 0x00C91A04 File Offset: 0x00C8FC04
		public ActivityTask GetSpecialTask()
		{
			if (!this.TaskMap.ContainsKey(this.SpecialTaskId))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.PhantomArena;
				ELogAuthor author = ELogAuthor.CXJ;
				string message = "特殊任务不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("SpecialTaskId", this.SpecialTaskId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			return this.TaskMap[this.SpecialTaskId];
		}

		// Token: 0x060350A5 RID: 217253 RVA: 0x00C91A6C File Offset: 0x00C8FC6C
		public List<int> GetAllCanReceiveTaskIdsByTabId(int tabId)
		{
			if (!this.TaskTab.ContainsKey(tabId))
			{
				return new List<int>();
			}
			List<int> list = this.TaskTab[tabId];
			List<int> list2 = new List<int>();
			foreach (int num in list)
			{
				if (this.TaskMap.ContainsKey(num))
				{
					ActivityTask activityTask = this.TaskMap[num];
					if (activityTask != null && activityTask.Status == ActivityTaskState.ActivityTaskFinish)
					{
						list2.Add(num);
					}
				}
			}
			return list2;
		}

		// Token: 0x060350A6 RID: 217254 RVA: 0x00C91B08 File Offset: 0x00C8FD08
		public int GetCurrencyId()
		{
			return this.CurrencyItem;
		}

		// Token: 0x060350A7 RID: 217255 RVA: 0x00C91B10 File Offset: 0x00C8FD10
		public int GetShopId()
		{
			return this.ShopId;
		}

		// Token: 0x1700809A RID: 32922
		// (get) Token: 0x060350A8 RID: 217256 RVA: 0x00C91B18 File Offset: 0x00C8FD18
		public int RecommendQuestId
		{
			get
			{
				return PhantomArenaConfig.Instance.GetPhantomBattleActivityConfig(base.Id).RecommendQuestId;
			}
		}

		// Token: 0x1700809B RID: 32923
		// (get) Token: 0x060350A9 RID: 217257 RVA: 0x00C91B40 File Offset: 0x00C8FD40
		public string RecommendQuestTips
		{
			get
			{
				return PhantomArenaConfig.Instance.GetPhantomBattleActivityConfig(base.Id).RecommendQuestTips;
			}
		}

		// Token: 0x060350AA RID: 217258 RVA: 0x00C91B65 File Offset: 0x00C8FD65
		public bool GetActivityTipNeedShowState()
		{
			return this.CheckIfInOpenTime() && this.CheckIfInShowTime() && ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 1, 0, 0) == 0;
		}

		// Token: 0x060350AB RID: 217259 RVA: 0x00C91B90 File Offset: 0x00C8FD90
		public void CacheActivityTipShowState()
		{
			ActivityModel.Instance.SaveActivityData(base.Id, 1, 0, 0, 1);
		}

		// Token: 0x060350AC RID: 217260 RVA: 0x00C91BA6 File Offset: 0x00C8FDA6
		public override bool GetExternalButtonRedPointState()
		{
			if (base.Type == ActivityType.PhantomBattleRecord)
			{
				return PhantomArenaModel.Instance.GetPermanentPhantomArenaActivityRedDot(base.Id);
			}
			return PhantomArenaModel.Instance.GetPhantomArenaActivityRedDot(base.Id);
		}

		// Token: 0x060350AD RID: 217261 RVA: 0x00C91BD3 File Offset: 0x00C8FDD3
		public override int GetExternalButtonRedPointId()
		{
			return base.Id;
		}

		// Token: 0x0401C391 RID: 115601
		private const int OPENTIPKEY = 1;

		// Token: 0x0401C392 RID: 115602
		[StaticVariableRuleIgnore]
		private static List<ActivityType> hideActivityTypeList = new List<ActivityType>
		{
			ActivityType.PhantomBattleRecord
		};

		// Token: 0x0401C393 RID: 115603
		private readonly Dictionary<int, PhantomBattleChallengeInfo> ChallengeInfoMap = new Dictionary<int, PhantomBattleChallengeInfo>();

		// Token: 0x0401C394 RID: 115604
		private List<Aki.Protocol.PhantomBattleCardGroupInfo> ProtocolDeckInfoList = new List<Aki.Protocol.PhantomBattleCardGroupInfo>();

		// Token: 0x0401C395 RID: 115605
		private readonly List<DeckInfo> ClientDeckInfoList = new List<DeckInfo>();

		// Token: 0x0401C396 RID: 115606
		private readonly Dictionary<int, DeckInfo> ClientDeckInfoMap = new Dictionary<int, DeckInfo>();

		// Token: 0x0401C397 RID: 115607
		private List<PhantomBattleCardInfo> CardInfoList = new List<PhantomBattleCardInfo>();

		// Token: 0x0401C398 RID: 115608
		private readonly Dictionary<int, PhantomBattleCardRewardInfo> CardRewardMap = new Dictionary<int, PhantomBattleCardRewardInfo>();

		// Token: 0x0401C399 RID: 115609
		private readonly Dictionary<int, PhantomBattleBadgeRewardInfo> BadgeRewardMap = new Dictionary<int, PhantomBattleBadgeRewardInfo>();

		// Token: 0x0401C39A RID: 115610
		private PhantomBattleMasterInfo MasterInfo;

		// Token: 0x0401C39B RID: 115611
		private readonly Dictionary<int, PhantomBattleCardInfo> CardInfoMap = new Dictionary<int, PhantomBattleCardInfo>();

		// Token: 0x0401C39C RID: 115612
		private readonly Dictionary<int, PhantomBattleRoleInfo> RoleInfoMap = new Dictionary<int, PhantomBattleRoleInfo>();

		// Token: 0x0401C39D RID: 115613
		private readonly Dictionary<int, PhantomBattleBadgeInfo> BadgeInfoMap = new Dictionary<int, PhantomBattleBadgeInfo>();

		// Token: 0x0401C39E RID: 115614
		private int MaxCardCountInDeck;

		// Token: 0x0401C39F RID: 115615
		private int MaxCoreCardCountInDeck;

		// Token: 0x0401C3A0 RID: 115616
		private int MaxFieldCardCountInDeck;

		// Token: 0x0401C3A1 RID: 115617
		private int MaxItemCardCountInDeck;

		// Token: 0x0401C3A2 RID: 115618
		private int MaxNormalCardCountInDeck;

		// Token: 0x0401C3A3 RID: 115619
		private int MaxDeckCount;

		// Token: 0x0401C3A4 RID: 115620
		private int MaxDeckElementCount;

		// Token: 0x0401C3A5 RID: 115621
		private Dictionary<int, int> CostToMaxCardLimitMap = new Dictionary<int, int>();

		// Token: 0x0401C3A6 RID: 115622
		private readonly Dictionary<int, ActivityTask> TaskMap = new Dictionary<int, ActivityTask>();

		// Token: 0x0401C3A7 RID: 115623
		private readonly Dictionary<int, List<int>> TaskTab = new Dictionary<int, List<int>>();

		// Token: 0x0401C3A8 RID: 115624
		private int CurrencyItem;

		// Token: 0x0401C3A9 RID: 115625
		private int ShopId;

		// Token: 0x0401C3AA RID: 115626
		private int ActivityLimitTime;

		// Token: 0x0401C3AB RID: 115627
		private readonly Dictionary<int, Dictionary<int, List<int>>> MapToDifficultChallengeIdsMap = new Dictionary<int, Dictionary<int, List<int>>>();

		// Token: 0x0401C3AC RID: 115628
		private readonly List<int> AllChallengeIds = new List<int>();

		// Token: 0x0401C3AD RID: 115629
		private readonly HashSet<int> CurrentUnlockChallengeIds = new HashSet<int>();

		// Token: 0x0401C3AE RID: 115630
		private readonly HashSet<int> UnlockMapIds = new HashSet<int>();

		// Token: 0x0401C3AF RID: 115631
		private int SpecialTaskId;
	}
}
