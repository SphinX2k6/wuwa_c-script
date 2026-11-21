using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x020040D3 RID: 16595
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaActivityData : ActivityBaseData
	{
		// Token: 0x06029F58 RID: 171864 RVA: 0x00BDD6CC File Offset: 0x00BDB8CC
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
				PhantomBattleChallengeInfo[] array = new PhantomBattleChallengeInfo[phantomBattleChallengeInfos.Count];
				phantomBattleChallengeInfos.CopyTo(array, 0);
				this.UpdateChallengeInfoList(array);
			}
			RepeatedField<PhantomBattleCardInfo> phantomBattleCardInfos = phantomBattleActivityInfo.PhantomBattleCardInfos;
			if (phantomBattleCardInfos != null)
			{
				PhantomBattleCardInfo[] array2 = new PhantomBattleCardInfo[phantomBattleCardInfos.Count];
				phantomBattleCardInfos.CopyTo(array2, 0);
				this.UpdateCardList(array2);
			}
			RepeatedField<PhantomBattleCardRewardInfo> phantomBattleCardRewardInfos = phantomBattleActivityInfo.PhantomBattleCardRewardInfos;
			if (phantomBattleCardInfos != null)
			{
				PhantomBattleCardRewardInfo[] array3 = new PhantomBattleCardRewardInfo[phantomBattleCardRewardInfos.Count];
				phantomBattleCardRewardInfos.CopyTo(array3, 0);
				this.UpdateCardReward(array3);
			}
			RepeatedField<PhantomBattleBadgeInfo> phantomBattleBadgeInfos = phantomBattleActivityInfo.PhantomBattleBadgeInfos;
			if (phantomBattleBadgeInfos != null)
			{
				PhantomBattleBadgeInfo[] array4 = new PhantomBattleBadgeInfo[phantomBattleBadgeInfos.Count];
				phantomBattleBadgeInfos.CopyTo(array4, 0);
				this.UpdateBadgeList(array4);
			}
			RepeatedField<PhantomBattleBadgeRewardInfo> phantomBattleBadgeRewardInfos = phantomBattleActivityInfo.PhantomBattleBadgeRewardInfos;
			if (phantomBattleCardInfos != null)
			{
				PhantomBattleBadgeRewardInfo[] array5 = new PhantomBattleBadgeRewardInfo[phantomBattleBadgeRewardInfos.Count];
				phantomBattleBadgeRewardInfos.CopyTo(array5, 0);
				this.UpdateBadgeReward(array5);
			}
			RepeatedField<Aki.Protocol.PhantomBattleCardGroupInfo> phantomBattleCardGroupInfos = phantomBattleActivityInfo.PhantomBattleCardGroupInfos;
			if (phantomBattleCardGroupInfos != null)
			{
				Aki.Protocol.PhantomBattleCardGroupInfo[] array6 = new Aki.Protocol.PhantomBattleCardGroupInfo[phantomBattleCardGroupInfos.Count];
				phantomBattleCardGroupInfos.CopyTo(array6, 0);
				this.UpdateProtocolDeckInfoList(array6);
			}
			PhantomBattleMasterInfo phantomBattleMasterInfo = phantomBattleActivityInfo.PhantomBattleMasterInfo;
			if (phantomBattleMasterInfo != null)
			{
				this.UpdateMasterInfo(phantomBattleMasterInfo);
			}
			RepeatedField<PhantomBattleRoleInfo> phantomBattleRoleInfos = phantomBattleActivityInfo.PhantomBattleRoleInfos;
			if (phantomBattleRoleInfos != null)
			{
				PhantomBattleRoleInfo[] array7 = new PhantomBattleRoleInfo[phantomBattleRoleInfos.Count];
				phantomBattleRoleInfos.CopyTo(array7, 0);
				this.UpdateRoleInfo(array7);
			}
			RepeatedField<ActivityTask> activityTasks = phantomBattleActivityInfo.ActivityTasks;
			if (activityTasks != null)
			{
				ActivityTask[] array8 = new ActivityTask[activityTasks.Count];
				activityTasks.CopyTo(array8, 0);
				this.UpdateTaskInfo(array8);
			}
			this.UpdateShopInfo();
		}

		// Token: 0x06029F59 RID: 171865 RVA: 0x00BDD9CC File Offset: 0x00BDBBCC
		private void UpdateShopInfo()
		{
			EventSystem.Instance.Emit(EEventName.OnPhantomArenaShopOpen);
		}

		// Token: 0x06029F5A RID: 171866 RVA: 0x00BDD9E0 File Offset: 0x00BDBBE0
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

		// Token: 0x06029F5B RID: 171867 RVA: 0x00BDDAC4 File Offset: 0x00BDBCC4
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

		// Token: 0x06029F5C RID: 171868 RVA: 0x00BDDC10 File Offset: 0x00BDBE10
		public void UpdateChallengeFinishConditions(int challengeId, IEnumerable<int> finishConditions)
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

		// Token: 0x06029F5D RID: 171869 RVA: 0x00BDDC74 File Offset: 0x00BDBE74
		public void UpdateProtocolDeckInfoList(Aki.Protocol.PhantomBattleCardGroupInfo[] deckList)
		{
			this.ProtocolDeckInfoList = new List<Aki.Protocol.PhantomBattleCardGroupInfo>(deckList);
			this.ClientDeckInfoList.Clear();
			this.ClientDeckInfoMap.Clear();
			foreach (Aki.Protocol.PhantomBattleCardGroupInfo phantomBattleCardGroupInfo in deckList)
			{
				DeckInfo deckInfo = this.CovertProtocolDeckInfoToClientDeckInfo(phantomBattleCardGroupInfo);
				this.ClientDeckInfoList.Add(deckInfo);
				this.ClientDeckInfoMap[phantomBattleCardGroupInfo.Index] = deckInfo;
			}
		}

		// Token: 0x06029F5E RID: 171870 RVA: 0x00BDDCE0 File Offset: 0x00BDBEE0
		public void AddProtocolDeckInfo(Aki.Protocol.PhantomBattleCardGroupInfo deckInfo)
		{
			this.ProtocolDeckInfoList.Add(deckInfo);
			DeckInfo deckInfo2 = this.CovertProtocolDeckInfoToClientDeckInfo(deckInfo);
			this.ClientDeckInfoList.Add(deckInfo2);
			this.ClientDeckInfoMap[deckInfo.Index] = deckInfo2;
		}

		// Token: 0x06029F5F RID: 171871 RVA: 0x00BDDD20 File Offset: 0x00BDBF20
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

		// Token: 0x06029F60 RID: 171872 RVA: 0x00BDDD9C File Offset: 0x00BDBF9C
		public void UpdateProtocolDeckInfo(Aki.Protocol.PhantomBattleCardGroupInfo deckInfo)
		{
			int index = deckInfo.Index;
			this.ProtocolDeckInfoList[index] = deckInfo;
			DeckInfo value = this.CovertProtocolDeckInfoToClientDeckInfo(deckInfo);
			this.ClientDeckInfoList[index] = value;
			this.ClientDeckInfoMap[index] = value;
		}

		// Token: 0x06029F61 RID: 171873 RVA: 0x00BDDDE0 File Offset: 0x00BDBFE0
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

		// Token: 0x06029F62 RID: 171874 RVA: 0x00BDDE5C File Offset: 0x00BDC05C
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

		// Token: 0x06029F63 RID: 171875 RVA: 0x00BDDECC File Offset: 0x00BDC0CC
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

		// Token: 0x06029F64 RID: 171876 RVA: 0x00BDE02C File Offset: 0x00BDC22C
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

		// Token: 0x06029F65 RID: 171877 RVA: 0x00BDE0C1 File Offset: 0x00BDC2C1
		public void ClearClientDeckInfoList()
		{
			this.ClientDeckInfoList.Clear();
		}

		// Token: 0x06029F66 RID: 171878 RVA: 0x00BDE0D0 File Offset: 0x00BDC2D0
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

		// Token: 0x06029F67 RID: 171879 RVA: 0x00BDE188 File Offset: 0x00BDC388
		public void UpdateCardList(PhantomBattleCardInfo[] cardList)
		{
			this.CardInfoList = new List<PhantomBattleCardInfo>(cardList);
			this.CardInfoMap.Clear();
			foreach (PhantomBattleCardInfo phantomBattleCardInfo in cardList)
			{
				this.CardInfoMap[phantomBattleCardInfo.PhantomBattleCardId] = phantomBattleCardInfo;
			}
		}

		// Token: 0x06029F68 RID: 171880 RVA: 0x00BDE1D4 File Offset: 0x00BDC3D4
		public void UpdateBadgeList(PhantomBattleBadgeInfo[] badgeList)
		{
			this.BadgeInfoMap.Clear();
			foreach (PhantomBattleBadgeInfo phantomBattleBadgeInfo in badgeList)
			{
				this.BadgeInfoMap[phantomBattleBadgeInfo.PhantomBattleBadgeId] = phantomBattleBadgeInfo;
			}
		}

		// Token: 0x06029F69 RID: 171881 RVA: 0x00BDE214 File Offset: 0x00BDC414
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

		// Token: 0x06029F6A RID: 171882 RVA: 0x00BDE288 File Offset: 0x00BDC488
		public void AddBadgeListByNotify(PhantomBattleBadgeInfo[] badgeList)
		{
			foreach (PhantomBattleBadgeInfo phantomBattleBadgeInfo in badgeList)
			{
				this.BadgeInfoMap[phantomBattleBadgeInfo.PhantomBattleBadgeId] = phantomBattleBadgeInfo;
			}
			EventSystem.Instance.Emit(EEventName.OnPhantomArenaBadgeRewardUpdate);
		}

		// Token: 0x06029F6B RID: 171883 RVA: 0x00BDE2CB File Offset: 0x00BDC4CB
		public List<PhantomBattleCardInfo> GetCardList()
		{
			return this.CardInfoList;
		}

		// Token: 0x06029F6C RID: 171884 RVA: 0x00BDE2D3 File Offset: 0x00BDC4D3
		public PhantomBattleCardInfo GetCardInfo(int cardId)
		{
			if (!this.CardInfoMap.ContainsKey(cardId))
			{
				return null;
			}
			return this.CardInfoMap[cardId];
		}

		// Token: 0x06029F6D RID: 171885 RVA: 0x00BDE2F1 File Offset: 0x00BDC4F1
		public PhantomBattleBadgeInfo GetBadgeInfo(int badgeId)
		{
			if (!this.BadgeInfoMap.ContainsKey(badgeId))
			{
				return null;
			}
			return this.BadgeInfoMap[badgeId];
		}

		// Token: 0x06029F6E RID: 171886 RVA: 0x00BDE310 File Offset: 0x00BDC510
		public bool IsCardUnlock(int cardId)
		{
			PhantomBattleCardInfo cardInfo = this.GetCardInfo(cardId);
			return cardInfo != null && cardInfo.IsUnlock;
		}

		// Token: 0x06029F6F RID: 171887 RVA: 0x00BDE330 File Offset: 0x00BDC530
		public bool IsCardOutlookUnlock(int cardId)
		{
			PhantomBattleCardInfo cardInfo = this.GetCardInfo(cardId);
			return cardInfo != null && cardInfo.IsUnlockOutLook;
		}

		// Token: 0x06029F70 RID: 171888 RVA: 0x00BDE350 File Offset: 0x00BDC550
		public bool IsBadgeUnlock(int badgeId)
		{
			PhantomBattleBadgeInfo badgeInfo = this.GetBadgeInfo(badgeId);
			return badgeInfo != null && badgeInfo.IsUnlock;
		}

		// Token: 0x06029F71 RID: 171889 RVA: 0x00BDE370 File Offset: 0x00BDC570
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

		// Token: 0x06029F72 RID: 171890 RVA: 0x00BDE3B8 File Offset: 0x00BDC5B8
		public bool IsCardOutLookUnlock(int cardId)
		{
			PhantomBattleCardInfo cardInfo = this.GetCardInfo(cardId);
			return cardInfo != null && cardInfo.IsUnlockOutLook;
		}

		// Token: 0x06029F73 RID: 171891 RVA: 0x00BDE3D8 File Offset: 0x00BDC5D8
		public int GetMaxCardCountInDeck()
		{
			return this.MaxCardCountInDeck;
		}

		// Token: 0x06029F74 RID: 171892 RVA: 0x00BDE3E0 File Offset: 0x00BDC5E0
		public int GetMaxCoreCardCountInDeck()
		{
			return this.MaxCoreCardCountInDeck;
		}

		// Token: 0x06029F75 RID: 171893 RVA: 0x00BDE3E8 File Offset: 0x00BDC5E8
		public int GetMaxNormalCardCountInDeck()
		{
			return this.MaxNormalCardCountInDeck;
		}

		// Token: 0x06029F76 RID: 171894 RVA: 0x00BDE3F0 File Offset: 0x00BDC5F0
		public List<DeckInfo> GetClientDeckInfoList()
		{
			return this.ClientDeckInfoList;
		}

		// Token: 0x06029F77 RID: 171895 RVA: 0x00BDE3F8 File Offset: 0x00BDC5F8
		public DeckInfo GetClientDeckInfo(int deckId)
		{
			if (!this.ClientDeckInfoMap.ContainsKey(deckId))
			{
				return null;
			}
			return this.ClientDeckInfoMap[deckId];
		}

		// Token: 0x06029F78 RID: 171896 RVA: 0x00BDE418 File Offset: 0x00BDC618
		public List<DeckInfo> CreateDeckInfoListFromProtocol()
		{
			List<DeckInfo> list = new List<DeckInfo>();
			foreach (Aki.Protocol.PhantomBattleCardGroupInfo deckInfo in this.ProtocolDeckInfoList)
			{
				list.Add(this.CovertProtocolDeckInfoToClientDeckInfo(deckInfo));
			}
			return list;
		}

		// Token: 0x06029F79 RID: 171897 RVA: 0x00BDE478 File Offset: 0x00BDC678
		public int GetMaxDeckCount()
		{
			return this.MaxDeckCount;
		}

		// Token: 0x06029F7A RID: 171898 RVA: 0x00BDE480 File Offset: 0x00BDC680
		public PhantomBattleChallengeInfo GetChallengeInfoById(int challengeId)
		{
			if (!this.ChallengeInfoMap.ContainsKey(challengeId))
			{
				return null;
			}
			return this.ChallengeInfoMap[challengeId];
		}

		// Token: 0x06029F7B RID: 171899 RVA: 0x00BDE49E File Offset: 0x00BDC69E
		public Dictionary<int, List<int>> GetDifficultChallengeIdsMap(int mapId)
		{
			if (!this.MapToDifficultChallengeIdsMap.ContainsKey(mapId))
			{
				return null;
			}
			return this.MapToDifficultChallengeIdsMap[mapId];
		}

		// Token: 0x06029F7C RID: 171900 RVA: 0x00BDE4BC File Offset: 0x00BDC6BC
		public List<int> GetAllChallengeIds()
		{
			return this.AllChallengeIds;
		}

		// Token: 0x06029F7D RID: 171901 RVA: 0x00BDE4C4 File Offset: 0x00BDC6C4
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

		// Token: 0x06029F7E RID: 171902 RVA: 0x00BDE524 File Offset: 0x00BDC724
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

		// Token: 0x06029F7F RID: 171903 RVA: 0x00BDE579 File Offset: 0x00BDC779
		public HashSet<int> GetCurrentUnlockChallengeIds()
		{
			return this.CurrentUnlockChallengeIds;
		}

		// Token: 0x06029F80 RID: 171904 RVA: 0x00BDE584 File Offset: 0x00BDC784
		public void UpdateRoleInfo(PhantomBattleRoleInfo[] roleInfos)
		{
			foreach (PhantomBattleRoleInfo phantomBattleRoleInfo in roleInfos)
			{
				this.RoleInfoMap[phantomBattleRoleInfo.PhantomBattleRoleId] = phantomBattleRoleInfo;
			}
			EventSystem.Instance.Emit<int>(EEventName.OnPhantomArenaRoleRewardUpdate, base.Id);
		}

		// Token: 0x06029F81 RID: 171905 RVA: 0x00BDE5CD File Offset: 0x00BDC7CD
		public void AddRoleInfo(PhantomBattleRoleInfo roleInfo)
		{
			this.RoleInfoMap[roleInfo.PhantomBattleRoleId] = roleInfo;
			EventSystem.Instance.Emit<int>(EEventName.OnPhantomArenaRoleRewardUpdate, base.Id);
		}

		// Token: 0x06029F82 RID: 171906 RVA: 0x00BDE5F7 File Offset: 0x00BDC7F7
		public void OnRoleReward(int roleId)
		{
			if (this.RoleInfoMap.ContainsKey(roleId))
			{
				this.RoleInfoMap[roleId].IsRewarded = true;
			}
			EventSystem.Instance.Emit<int>(EEventName.OnPhantomArenaRoleRewardUpdate, base.Id);
		}

		// Token: 0x06029F83 RID: 171907 RVA: 0x00BDE630 File Offset: 0x00BDC830
		public bool IsRoleUnlock(int roleId)
		{
			if (!this.RoleInfoMap.ContainsKey(roleId))
			{
				return false;
			}
			PhantomBattleRoleInfo phantomBattleRoleInfo = this.RoleInfoMap[roleId];
			return phantomBattleRoleInfo != null && phantomBattleRoleInfo.IsUnlock;
		}

		// Token: 0x06029F84 RID: 171908 RVA: 0x00BDE668 File Offset: 0x00BDC868
		public bool IsRoleReward(int roleId)
		{
			if (!this.RoleInfoMap.ContainsKey(roleId))
			{
				return false;
			}
			PhantomBattleRoleInfo phantomBattleRoleInfo = this.RoleInfoMap[roleId];
			return phantomBattleRoleInfo != null && phantomBattleRoleInfo.IsRewarded;
		}

		// Token: 0x06029F85 RID: 171909 RVA: 0x00BDE69D File Offset: 0x00BDC89D
		public override bool GetExDataRedPointShowState()
		{
			ActivityType type = base.Type;
			return !PhantomArenaActivityData.hideActivityTypeList.Contains(base.Type) && PhantomArenaModel.Instance.GetPhantomArenaActivityRedDot(base.Id);
		}

		// Token: 0x06029F86 RID: 171910 RVA: 0x00BDE6CC File Offset: 0x00BDC8CC
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

		// Token: 0x06029F87 RID: 171911 RVA: 0x00BDE75C File Offset: 0x00BDC95C
		public void UpdateCardReward(PhantomBattleCardRewardInfo[] rewardList)
		{
			this.CardRewardMap.Clear();
			foreach (PhantomBattleCardRewardInfo phantomBattleCardRewardInfo in rewardList)
			{
				this.CardRewardMap[phantomBattleCardRewardInfo.PhantomBattleCardRewardId] = phantomBattleCardRewardInfo;
			}
			EventSystem.Instance.Emit<int>(EEventName.OnPhantomArenaCardRewardUpdate, base.Id);
		}

		// Token: 0x06029F88 RID: 171912 RVA: 0x00BDE7B0 File Offset: 0x00BDC9B0
		public void UpdateBadgeReward(PhantomBattleBadgeRewardInfo[] rewardList)
		{
			this.BadgeRewardMap.Clear();
			foreach (PhantomBattleBadgeRewardInfo phantomBattleBadgeRewardInfo in rewardList)
			{
				this.BadgeRewardMap[phantomBattleBadgeRewardInfo.PhantomBattleBadgeRewardId] = phantomBattleBadgeRewardInfo;
			}
			EventSystem.Instance.Emit(EEventName.OnPhantomArenaBadgeRewardUpdate);
		}

		// Token: 0x06029F89 RID: 171913 RVA: 0x00BDE800 File Offset: 0x00BDCA00
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

		// Token: 0x06029F8A RID: 171914 RVA: 0x00BDE87C File Offset: 0x00BDCA7C
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

		// Token: 0x06029F8B RID: 171915 RVA: 0x00BDE8E4 File Offset: 0x00BDCAE4
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

		// Token: 0x06029F8C RID: 171916 RVA: 0x00BDE964 File Offset: 0x00BDCB64
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

		// Token: 0x06029F8D RID: 171917 RVA: 0x00BDE9CA File Offset: 0x00BDCBCA
		public void UpdateMasterInfo(PhantomBattleMasterInfo masterInfo)
		{
			this.MasterInfo = masterInfo;
			EventSystem.Instance.Emit(EEventName.OnPhantomArenaMasterInfoUpdate);
		}

		// Token: 0x06029F8E RID: 171918 RVA: 0x00BDE9E3 File Offset: 0x00BDCBE3
		public int GetMasterLevel()
		{
			if (this.MasterInfo == null)
			{
				return 1;
			}
			return this.MasterInfo.PhantomBattleMasterLevelId;
		}

		// Token: 0x06029F8F RID: 171919 RVA: 0x00BDE9FC File Offset: 0x00BDCBFC
		public int GetMasterTitleId()
		{
			if (this.MasterInfo == null)
			{
				return 1;
			}
			int phantomBattleMasterLevelId = this.MasterInfo.PhantomBattleMasterLevelId;
			return PhantomArenaConfig.Instance.GetPhantomBattleMasterLevelByLevelAndActivityId(phantomBattleMasterLevelId, base.Id).Value.TitleId;
		}

		// Token: 0x06029F90 RID: 171920 RVA: 0x00BDEA40 File Offset: 0x00BDCC40
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

		// Token: 0x06029F91 RID: 171921 RVA: 0x00BDEA5D File Offset: 0x00BDCC5D
		public int GetMasterExpWeek()
		{
			PhantomBattleMasterInfo masterInfo = this.MasterInfo;
			if (masterInfo == null)
			{
				return 0;
			}
			return masterInfo.WeekRewardExp;
		}

		// Token: 0x06029F92 RID: 171922 RVA: 0x00BDEA70 File Offset: 0x00BDCC70
		public List<int> GetMasterLevelRewardTakenIds()
		{
			if (this.MasterInfo == null)
			{
				return new List<int>();
			}
			return new List<int>(this.MasterInfo.RewardedPhantomBattleMasterLevelIds);
		}

		// Token: 0x06029F93 RID: 171923 RVA: 0x00BDEA90 File Offset: 0x00BDCC90
		public bool GetMasterLevelRewardIfTaken(int levelConfigId)
		{
			return this.GetMasterLevelRewardTakenIds().Contains(levelConfigId);
		}

		// Token: 0x06029F94 RID: 171924 RVA: 0x00BDEAA0 File Offset: 0x00BDCCA0
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

		// Token: 0x06029F95 RID: 171925 RVA: 0x00BDEAE4 File Offset: 0x00BDCCE4
		public void SetLastUsedDeckServerId(int deckServerId)
		{
			if (this.MasterInfo == null)
			{
				Log.Instance.Info(ELogModule.PhantomArena, ELogAuthor.LZK, "设置召唤师上次使用的卡组失败，召唤师信息未初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.MasterInfo.LastUseCardGroupIndex = deckServerId;
		}

		// Token: 0x06029F96 RID: 171926 RVA: 0x00BDEB28 File Offset: 0x00BDCD28
		public int GetLastUsedDeckServerId()
		{
			if (this.MasterInfo == null)
			{
				Log.Instance.Info(ELogModule.PhantomArena, ELogAuthor.LZK, "获取召唤师上次使用的卡组失败，召唤师信息未初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
				return -1;
			}
			return this.MasterInfo.LastUseCardGroupIndex;
		}

		// Token: 0x06029F97 RID: 171927 RVA: 0x00BDEB6C File Offset: 0x00BDCD6C
		public int GetLastUsedCardRoleId()
		{
			if (this.MasterInfo == null)
			{
				Log.Instance.Info(ELogModule.PhantomArena, ELogAuthor.LZK, "获取召唤师上次使用的角色失败，召唤师信息未初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
				return -1;
			}
			return this.MasterInfo.LastUseCardRoleId;
		}

		// Token: 0x06029F98 RID: 171928 RVA: 0x00BDEBB0 File Offset: 0x00BDCDB0
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

		// Token: 0x06029F99 RID: 171929 RVA: 0x00BDED28 File Offset: 0x00BDCF28
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

		// Token: 0x06029F9A RID: 171930 RVA: 0x00BDED70 File Offset: 0x00BDCF70
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

		// Token: 0x06029F9B RID: 171931 RVA: 0x00BDEE00 File Offset: 0x00BDD000
		public Dictionary<int, List<int>> GetTaskTabMap()
		{
			return this.TaskTab;
		}

		// Token: 0x06029F9C RID: 171932 RVA: 0x00BDEE08 File Offset: 0x00BDD008
		public Dictionary<int, ActivityTask> GetTaskMap()
		{
			return this.TaskMap;
		}

		// Token: 0x06029F9D RID: 171933 RVA: 0x00BDEE10 File Offset: 0x00BDD010
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

		// Token: 0x06029F9E RID: 171934 RVA: 0x00BDEE78 File Offset: 0x00BDD078
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

		// Token: 0x06029F9F RID: 171935 RVA: 0x00BDEF14 File Offset: 0x00BDD114
		public int GetCurrencyId()
		{
			return this.CurrencyItem;
		}

		// Token: 0x06029FA0 RID: 171936 RVA: 0x00BDEF1C File Offset: 0x00BDD11C
		public int GetShopId()
		{
			return this.ShopId;
		}

		// Token: 0x1700545A RID: 21594
		// (get) Token: 0x06029FA1 RID: 171937 RVA: 0x00BDEF24 File Offset: 0x00BDD124
		public int RecommendQuestId
		{
			get
			{
				return PhantomArenaConfig.Instance.GetPhantomBattleActivityConfig(base.Id).RecommendQuestId;
			}
		}

		// Token: 0x1700545B RID: 21595
		// (get) Token: 0x06029FA2 RID: 171938 RVA: 0x00BDEF4C File Offset: 0x00BDD14C
		public string RecommendQuestTips
		{
			get
			{
				return PhantomArenaConfig.Instance.GetPhantomBattleActivityConfig(base.Id).RecommendQuestTips;
			}
		}

		// Token: 0x06029FA3 RID: 171939 RVA: 0x00BDEF71 File Offset: 0x00BDD171
		public bool GetActivityTipNeedShowState()
		{
			return this.CheckIfInOpenTime() && this.CheckIfInShowTime() && ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 1, 0, 0) == 0;
		}

		// Token: 0x06029FA4 RID: 171940 RVA: 0x00BDEF9C File Offset: 0x00BDD19C
		public void CacheActivityTipShowState()
		{
			ActivityModel.Instance.SaveActivityData(base.Id, 1, 0, 0, 1);
		}

		// Token: 0x06029FA5 RID: 171941 RVA: 0x00BDEFB2 File Offset: 0x00BDD1B2
		public override bool GetExternalButtonRedPointState()
		{
			if (base.Type == ActivityType.PhantomBattleRecord)
			{
				return PhantomArenaModel.Instance.GetPermanentPhantomArenaActivityRedDot(base.Id);
			}
			return PhantomArenaModel.Instance.GetPhantomArenaActivityRedDot(base.Id);
		}

		// Token: 0x06029FA6 RID: 171942 RVA: 0x00BDEFDF File Offset: 0x00BDD1DF
		public override int GetExternalButtonRedPointId()
		{
			return base.Id;
		}

		// Token: 0x04016DC4 RID: 93636
		private const int OPENTIPKEY = 1;

		// Token: 0x04016DC5 RID: 93637
		[StaticVariableRuleIgnore]
		private static List<ActivityType> hideActivityTypeList = new List<ActivityType>
		{
			ActivityType.PhantomBattleRecord
		};

		// Token: 0x04016DC6 RID: 93638
		private readonly Dictionary<int, PhantomBattleChallengeInfo> ChallengeInfoMap = new Dictionary<int, PhantomBattleChallengeInfo>();

		// Token: 0x04016DC7 RID: 93639
		private List<Aki.Protocol.PhantomBattleCardGroupInfo> ProtocolDeckInfoList = new List<Aki.Protocol.PhantomBattleCardGroupInfo>();

		// Token: 0x04016DC8 RID: 93640
		private readonly List<DeckInfo> ClientDeckInfoList = new List<DeckInfo>();

		// Token: 0x04016DC9 RID: 93641
		private readonly Dictionary<int, DeckInfo> ClientDeckInfoMap = new Dictionary<int, DeckInfo>();

		// Token: 0x04016DCA RID: 93642
		private List<PhantomBattleCardInfo> CardInfoList = new List<PhantomBattleCardInfo>();

		// Token: 0x04016DCB RID: 93643
		private readonly Dictionary<int, PhantomBattleCardRewardInfo> CardRewardMap = new Dictionary<int, PhantomBattleCardRewardInfo>();

		// Token: 0x04016DCC RID: 93644
		private readonly Dictionary<int, PhantomBattleBadgeRewardInfo> BadgeRewardMap = new Dictionary<int, PhantomBattleBadgeRewardInfo>();

		// Token: 0x04016DCD RID: 93645
		private PhantomBattleMasterInfo MasterInfo;

		// Token: 0x04016DCE RID: 93646
		private readonly Dictionary<int, PhantomBattleCardInfo> CardInfoMap = new Dictionary<int, PhantomBattleCardInfo>();

		// Token: 0x04016DCF RID: 93647
		private readonly Dictionary<int, PhantomBattleRoleInfo> RoleInfoMap = new Dictionary<int, PhantomBattleRoleInfo>();

		// Token: 0x04016DD0 RID: 93648
		private readonly Dictionary<int, PhantomBattleBadgeInfo> BadgeInfoMap = new Dictionary<int, PhantomBattleBadgeInfo>();

		// Token: 0x04016DD1 RID: 93649
		private int MaxCardCountInDeck;

		// Token: 0x04016DD2 RID: 93650
		private int MaxCoreCardCountInDeck;

		// Token: 0x04016DD3 RID: 93651
		private int MaxFieldCardCountInDeck;

		// Token: 0x04016DD4 RID: 93652
		private int MaxItemCardCountInDeck;

		// Token: 0x04016DD5 RID: 93653
		private int MaxNormalCardCountInDeck;

		// Token: 0x04016DD6 RID: 93654
		private int MaxDeckCount;

		// Token: 0x04016DD7 RID: 93655
		private int MaxDeckElementCount;

		// Token: 0x04016DD8 RID: 93656
		private Dictionary<int, int> CostToMaxCardLimitMap = new Dictionary<int, int>();

		// Token: 0x04016DD9 RID: 93657
		private readonly Dictionary<int, ActivityTask> TaskMap = new Dictionary<int, ActivityTask>();

		// Token: 0x04016DDA RID: 93658
		private readonly Dictionary<int, List<int>> TaskTab = new Dictionary<int, List<int>>();

		// Token: 0x04016DDB RID: 93659
		private int CurrencyItem;

		// Token: 0x04016DDC RID: 93660
		private int ShopId;

		// Token: 0x04016DDD RID: 93661
		private int ActivityLimitTime;

		// Token: 0x04016DDE RID: 93662
		private readonly Dictionary<int, Dictionary<int, List<int>>> MapToDifficultChallengeIdsMap = new Dictionary<int, Dictionary<int, List<int>>>();

		// Token: 0x04016DDF RID: 93663
		private readonly List<int> AllChallengeIds = new List<int>();

		// Token: 0x04016DE0 RID: 93664
		private readonly HashSet<int> CurrentUnlockChallengeIds = new HashSet<int>();

		// Token: 0x04016DE1 RID: 93665
		private readonly HashSet<int> UnlockMapIds = new HashSet<int>();

		// Token: 0x04016DE2 RID: 93666
		private int SpecialTaskId;
	}
}
