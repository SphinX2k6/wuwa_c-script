using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PhantomArena.Battle.Ai;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Model
{
	// Token: 0x0200529D RID: 21149
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaOpponentData
	{
		// Token: 0x060361A1 RID: 221601 RVA: 0x00CCCD3A File Offset: 0x00CCAF3A
		public void CreateInitPromise()
		{
			this.InitPromise = new CustomPromise();
		}

		// Token: 0x060361A2 RID: 221602 RVA: 0x00CCCD48 File Offset: 0x00CCAF48
		public void InitPlayerData(PhantomBattleGamerFighterInfoCtx data)
		{
			this.BattleStatusMap.Clear();
			this.BattleAttrMap.Clear();
			this.RoleId = data.CardRoleId;
			this.HandCardNum = data.HandCardNum;
			this.RefreshCardLibraryNum(data.CardLibraryNum);
			this.RefreshCanEvolveNum(data.CanEvolveNum);
			this.InitBattleStatus(data.BattleStatus.ToDictionary<int, int>());
		}

		// Token: 0x060361A3 RID: 221603 RVA: 0x00CCCDAC File Offset: 0x00CCAFAC
		public void InitNpcAiOperationData(NpcPhantomBattleFightInfo[] fightInfoList)
		{
			this.NpcAiOperationList = new List<NpcAiOperation>();
			foreach (NpcPhantomBattleFightInfo npcPhantomBattleFightInfo in fightInfoList)
			{
				this.NpcBattleEvolve(npcPhantomBattleFightInfo.PhantomBattleEvolveInfo);
				this.NpcBattleSlotInstead(npcPhantomBattleFightInfo.PhantomBattleSlotInsteadInfo);
				this.NpcBattleSkillTrigger(npcPhantomBattleFightInfo.PhantomBattleSkillTriggerInfo);
				this.NpcBattleBuffTrigger(npcPhantomBattleFightInfo.PhantomBattleBuffTriggerInfo);
				this.NpcBattleCardSkill(npcPhantomBattleFightInfo.NpcPhantomBattleCardSkillInfo);
				this.NpcBattleCardRoleSkill(npcPhantomBattleFightInfo.NpcPhantomBattleCardRoleSkillInfo);
				this.NpcBattleGamerStatus(npcPhantomBattleFightInfo.NpcPhantomBattleGamerStatusInfo);
				this.NpcBattleCardAttr(npcPhantomBattleFightInfo.NpcPhantomBattleCardAttrInfo);
				this.NpcBattleEnterSlot(npcPhantomBattleFightInfo.NpcPhantomBattleEnterSlotInfo);
				this.NpcPhantomBattleBackCardLibrary(npcPhantomBattleFightInfo.NpcPhantomBattleBackCardLibrary);
				this.NpcPhantomBattleDiscardCard(npcPhantomBattleFightInfo.NpcPhantomBattleDiscardInfo);
				this.NpcPhantomFourCostTaskDealCard(npcPhantomBattleFightInfo.NpcPhantomFourCTaskDealCardInfo);
				this.NpcPhantomLeaveSlot(npcPhantomBattleFightInfo.NpcPhantomLeaveSlot);
				this.NpcPhantomBattleBackSlotCardLibrary(npcPhantomBattleFightInfo.NpcPhantomBattleBackSlotCardLibrary);
				this.NpcPhantomBattleReserveCardInfo(npcPhantomBattleFightInfo.NpcPhantomBattleReserveCardInfo);
				this.PhantomBattleNpcCardUpdateInfo(npcPhantomBattleFightInfo.PhantomBattleNpcCardUpdateInfo);
				this.PhantomBattleNpcClickCardSkillInfo(npcPhantomBattleFightInfo.NpcPhantomBattleCardDurableSkillInfo);
			}
			CustomPromise initPromise = this.InitPromise;
			if (initPromise != null)
			{
				initPromise.SetResult();
			}
			this.InitPromise = null;
		}

		// Token: 0x060361A4 RID: 221604 RVA: 0x00CCCEC2 File Offset: 0x00CCB0C2
		public List<NpcAiOperation> GetNpcAiOperationList()
		{
			return this.NpcAiOperationList;
		}

		// Token: 0x060361A5 RID: 221605 RVA: 0x00CCCECA File Offset: 0x00CCB0CA
		public void RefreshHandCardNum(int num, bool fire = true)
		{
			this.LastHandCardNum = this.HandCardNum;
			this.HandCardNum = num;
			if (fire)
			{
				EventSystem.Instance.Emit(EEventName.OpponentHandCardChange);
			}
		}

		// Token: 0x060361A6 RID: 221606 RVA: 0x00CCCEF2 File Offset: 0x00CCB0F2
		public void RefreshCardLibraryNum(int num)
		{
			this.CardLibraryNum = num;
			EventSystem.Instance.Emit(EEventName.OpponentCardLibraryChange);
		}

		// Token: 0x060361A7 RID: 221607 RVA: 0x00CCCF0B File Offset: 0x00CCB10B
		public void RefreshCanEvolveNum(int canEvolveNum)
		{
			this.CanEvolveNum = canEvolveNum;
		}

		// Token: 0x060361A8 RID: 221608 RVA: 0x00CCCF14 File Offset: 0x00CCB114
		private void InitBattleStatus(Dictionary<int, int> battleStatusMap)
		{
			List<PhantomBattleRoleStatus> list = new List<PhantomBattleRoleStatus>();
			if (battleStatusMap != null)
			{
				foreach (KeyValuePair<int, int> keyValuePair in battleStatusMap)
				{
					PhantomBattleRoleStatus key = (PhantomBattleRoleStatus)keyValuePair.Key;
					this.BattleStatusMap[key] = keyValuePair.Value;
					list.Add(key);
				}
			}
		}

		// Token: 0x060361A9 RID: 221609 RVA: 0x00CCCF88 File Offset: 0x00CCB188
		public void RefreshBattleStatus(Dictionary<int, int> battleStatusMap)
		{
			List<PhantomBattleRoleStatus> list = new List<PhantomBattleRoleStatus>();
			if (battleStatusMap != null)
			{
				foreach (KeyValuePair<int, int> keyValuePair in battleStatusMap)
				{
					PhantomBattleRoleStatus key = (PhantomBattleRoleStatus)keyValuePair.Key;
					this.BattleStatusMap[key] = keyValuePair.Value;
					list.Add(key);
				}
			}
			EventSystem.Instance.Emit<IReadOnlyList<PhantomBattleRoleStatus>>(EEventName.OpponentBattleStatusChange, list);
		}

		// Token: 0x060361AA RID: 221610 RVA: 0x00CCD00C File Offset: 0x00CCB20C
		public void RefreshBattleHpStatus(int hpNum, bool fire)
		{
			this.BattleStatusMap[PhantomBattleRoleStatus.PhantomBattleLife] = hpNum;
			if (fire)
			{
				EventSystem.Instance.Emit<IReadOnlyList<PhantomBattleRoleStatus>>(EEventName.OpponentBattleStatusChange, new List<PhantomBattleRoleStatus>
				{
					PhantomBattleRoleStatus.PhantomBattleLife
				});
			}
		}

		// Token: 0x060361AB RID: 221611 RVA: 0x00CCD03C File Offset: 0x00CCB23C
		public void RefreshBattleAttr(Dictionary<int, int> battleAttrMap)
		{
			List<PhantomBattleCardAttr> list = new List<PhantomBattleCardAttr>();
			if (battleAttrMap != null)
			{
				foreach (KeyValuePair<int, int> keyValuePair in battleAttrMap)
				{
					PhantomBattleCardAttr key = (PhantomBattleCardAttr)keyValuePair.Key;
					this.BattleAttrMap[key] = keyValuePair.Value;
					list.Add(key);
				}
			}
			EventSystem.Instance.Emit<IReadOnlyList<PhantomBattleCardAttr>>(EEventName.OpponentBattleAttrChange, list);
		}

		// Token: 0x060361AC RID: 221612 RVA: 0x00CCD0C0 File Offset: 0x00CCB2C0
		public int GetBattleStatusValue(PhantomBattleRoleStatus status)
		{
			if (!this.BattleStatusMap.ContainsKey(status))
			{
				return 0;
			}
			return this.BattleStatusMap[status];
		}

		// Token: 0x060361AD RID: 221613 RVA: 0x00CCD0DE File Offset: 0x00CCB2DE
		public int GetBattleBattleAttr(PhantomBattleCardAttr attr)
		{
			if (!this.BattleAttrMap.ContainsKey(attr))
			{
				return 0;
			}
			return this.BattleAttrMap[attr];
		}

		// Token: 0x060361AE RID: 221614 RVA: 0x00CCD0FC File Offset: 0x00CCB2FC
		public void RefreshCardAttr(int fightId, Dictionary<int, int> battleStatusMap)
		{
			foreach (PhantomCardData phantomCardData in this.BattleCardMap.Values)
			{
				if (phantomCardData.FightId == fightId)
				{
					phantomCardData.RefreshFightAttr(battleStatusMap);
				}
			}
			PhantomArenaFieldData fieldData = this.FieldData;
			int? num;
			if (fieldData == null)
			{
				num = null;
			}
			else
			{
				PhantomCardData cardData = fieldData.CardData;
				num = ((cardData != null) ? new int?(cardData.FightId) : null);
			}
			int? num2 = num;
			if (fightId == num2.GetValueOrDefault() & num2 != null)
			{
				PhantomArenaFieldData fieldData2 = this.FieldData;
				if (fieldData2 == null)
				{
					return;
				}
				PhantomCardData cardData2 = fieldData2.CardData;
				if (cardData2 == null)
				{
					return;
				}
				cardData2.RefreshFightAttr(battleStatusMap);
			}
		}

		// Token: 0x060361AF RID: 221615 RVA: 0x00CCD1C0 File Offset: 0x00CCB3C0
		public bool RemoveBattleCardDataByIndex(int index)
		{
			if (!this.SlotCardMap.ContainsKey(index))
			{
				return false;
			}
			PhantomCardData cardData = this.SlotCardMap[index];
			return this.RemoveBattleCardData(cardData);
		}

		// Token: 0x060361B0 RID: 221616 RVA: 0x00CCD1F4 File Offset: 0x00CCB3F4
		private bool RemoveBattleCardData(PhantomCardData cardData)
		{
			bool flag = this.BattleCardMap.Remove(cardData.CardId);
			bool flag2 = this.SlotCardMap.Remove(cardData.Index);
			return flag && flag2;
		}

		// Token: 0x060361B1 RID: 221617 RVA: 0x00CCD228 File Offset: 0x00CCB428
		public void SetBattleCardData(PhantomBattleFighterInfo data)
		{
			PhantomCardData phantomCardData = new PhantomCardData(true);
			phantomCardData.RefreshFightData(data);
			this.RemoveBattleCardDataByIndex(phantomCardData.Index);
			this.BattleCardMap[phantomCardData.CardId] = phantomCardData;
			this.SlotCardMap[phantomCardData.Index] = phantomCardData;
		}

		// Token: 0x060361B2 RID: 221618 RVA: 0x00CCD274 File Offset: 0x00CCB474
		public void SetBattleCardDataList(PhantomBattleFighterInfo[] dataList)
		{
			foreach (PhantomBattleFighterInfo battleCardData in dataList)
			{
				this.SetBattleCardData(battleCardData);
			}
		}

		// Token: 0x060361B3 RID: 221619 RVA: 0x00CCD29C File Offset: 0x00CCB49C
		public unsafe void NotifyExchangeBattleCard(PhantomBattleCardPosChangeInfo[] changeInfos)
		{
			PhantomCardData cardDataByFightId = this.GetCardDataByFightId(changeInfos[0].FighterUid);
			if (cardDataByFightId == null)
			{
				return;
			}
			if (cardDataByFightId != null && changeInfos.Length > 1 && changeInfos[1] != null && cardDataByFightId.Index != changeInfos[1].AfterPos)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.PhantomArena;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "卡牌A位置不正确,不满足交换条件";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("AfterPos", changeInfos[0].AfterPos);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Index", cardDataByFightId.Index);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			if (this.SlotCardMap.ContainsKey(changeInfos[0].AfterPos))
			{
				PhantomCardData phantomCardData = this.SlotCardMap[changeInfos[0].AfterPos];
				if (phantomCardData != null && changeInfos.Length > 1 && changeInfos[1] != null && phantomCardData.FightId != changeInfos[1].FighterUid)
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.PhantomArena;
					ELogAuthor author2 = ELogAuthor.XXJ;
					string message2 = "卡牌B位置不正确,不满足交换条件";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("AfterPos", changeInfos[1].AfterPos);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("Index", phantomCardData.Index);
					instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
					return;
				}
			}
			this.ExchangeBattleCard(cardDataByFightId.Index, changeInfos[0].AfterPos);
			if (changeInfos.Length > 1 && changeInfos[1] != null)
			{
				EventSystem.Instance.Emit<bool, int, int>(EEventName.NotifyBattleCardChange, false, cardDataByFightId.Index, changeInfos[1].AfterPos);
			}
		}

		// Token: 0x060361B4 RID: 221620 RVA: 0x00CCD448 File Offset: 0x00CCB648
		public void ExchangeBattleCard(int slotIndexA, int slotIndexB)
		{
			PhantomCardData phantomCardData = null;
			PhantomCardData phantomCardData2 = null;
			if (this.SlotCardMap.ContainsKey(slotIndexA))
			{
				phantomCardData = this.SlotCardMap[slotIndexA];
			}
			if (this.SlotCardMap.ContainsKey(slotIndexB))
			{
				phantomCardData2 = this.SlotCardMap[slotIndexB];
			}
			this.SlotCardMap.Remove(slotIndexA);
			this.SlotCardMap.Remove(slotIndexB);
			if (phantomCardData != null)
			{
				phantomCardData.Index = slotIndexB;
				this.SlotCardMap[phantomCardData.Index] = phantomCardData;
			}
			if (phantomCardData2 != null)
			{
				phantomCardData2.Index = slotIndexA;
				this.SlotCardMap[phantomCardData2.Index] = phantomCardData2;
			}
		}

		// Token: 0x060361B5 RID: 221621 RVA: 0x00CCD4E1 File Offset: 0x00CCB6E1
		public void BackToLibrary(NpcPhantomBattleBackCardLibrary info)
		{
			this.RefreshCardLibraryNum(info.CurCardLibraryNum);
			this.RefreshHandCardNum(info.HandCardNum, false);
		}

		// Token: 0x060361B6 RID: 221622 RVA: 0x00CCD4FC File Offset: 0x00CCB6FC
		public void BackSlotCardToLibrary(int index, int cardLibraryNum)
		{
			this.RemoveBattleCardDataByIndex(index);
			this.RefreshCardLibraryNum(cardLibraryNum);
		}

		// Token: 0x060361B7 RID: 221623 RVA: 0x00CCD50D File Offset: 0x00CCB70D
		public void ReverseCard(NpcPhantomBattleReserveCardInfo info)
		{
			this.RefreshCardLibraryNum(info.CurCardLibraryNum);
			this.RefreshHandCardNum(info.HandCardNum, true);
		}

		// Token: 0x060361B8 RID: 221624 RVA: 0x00CCD528 File Offset: 0x00CCB728
		public int GetBattleCardIndexByCardId(int cardId)
		{
			if (!this.BattleCardMap.ContainsKey(cardId))
			{
				return -1;
			}
			PhantomCardData phantomCardData = this.BattleCardMap[cardId];
			if (phantomCardData == null)
			{
				return -1;
			}
			return phantomCardData.Index;
		}

		// Token: 0x060361B9 RID: 221625 RVA: 0x00CCD560 File Offset: 0x00CCB760
		public List<int> GetBattleCardIndexList(List<int> fightIdList)
		{
			List<int> list = new List<int>();
			foreach (PhantomCardData phantomCardData in this.BattleCardMap.Values)
			{
				if (fightIdList.Contains(phantomCardData.FightId))
				{
					list.Add(phantomCardData.Index);
				}
			}
			return list;
		}

		// Token: 0x060361BA RID: 221626 RVA: 0x00CCD5D4 File Offset: 0x00CCB7D4
		public PhantomCardData GetBattleCardByCardId(int cardId)
		{
			if (!this.BattleCardMap.ContainsKey(cardId))
			{
				return null;
			}
			return this.BattleCardMap[cardId];
		}

		// Token: 0x060361BB RID: 221627 RVA: 0x00CCD5F4 File Offset: 0x00CCB7F4
		public List<int> GetFightIdList(List<int> cardIdList)
		{
			List<int> list = new List<int>();
			foreach (int key in cardIdList)
			{
				if (this.BattleCardMap.ContainsKey(key))
				{
					PhantomCardData phantomCardData = this.BattleCardMap[key];
					if (phantomCardData != null)
					{
						list.Add(phantomCardData.FightId);
					}
				}
			}
			return list;
		}

		// Token: 0x060361BC RID: 221628 RVA: 0x00CCD66C File Offset: 0x00CCB86C
		public PhantomCardData GetCardDataByFightId(int fightId)
		{
			foreach (PhantomCardData phantomCardData in this.BattleCardMap.Values)
			{
				if (phantomCardData.FightId == fightId)
				{
					return phantomCardData;
				}
			}
			return null;
		}

		// Token: 0x060361BD RID: 221629 RVA: 0x00CCD6D0 File Offset: 0x00CCB8D0
		public PhantomCardData GetCardDataByIndex(int index)
		{
			if (!this.SlotCardMap.ContainsKey(index))
			{
				return null;
			}
			return this.SlotCardMap[index];
		}

		// Token: 0x060361BE RID: 221630 RVA: 0x00CCD6EE File Offset: 0x00CCB8EE
		public List<PhantomCardData> GetCardDataList()
		{
			return this.BattleCardMap.Values.ToList<PhantomCardData>();
		}

		// Token: 0x060361BF RID: 221631 RVA: 0x00CCD700 File Offset: 0x00CCB900
		public void ClearHandData()
		{
			this.HandCardNum = 0;
		}

		// Token: 0x060361C0 RID: 221632 RVA: 0x00CCD709 File Offset: 0x00CCB909
		public void InitTaskData(PhantomBattleGamerFourCTaskInfo data)
		{
			this.TaskData = new PhantomArenaCardTaskData(false);
			this.TaskData.SetTaskData(data);
		}

		// Token: 0x060361C1 RID: 221633 RVA: 0x00CCD724 File Offset: 0x00CCB924
		public void RefreshTaskData(PhantomBattleGamerFourCTaskInfo data)
		{
			if (this.TaskData != null)
			{
				this.TaskData.SetTaskData(data);
				return;
			}
			Log.Instance.Error(ELogModule.PhantomArena, ELogAuthor.XXJ, "任务数据为空", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x060361C2 RID: 221634 RVA: 0x00CCD765 File Offset: 0x00CCB965
		public void InitFieldData()
		{
			this.FieldData = new PhantomArenaFieldData();
		}

		// Token: 0x060361C3 RID: 221635 RVA: 0x00CCD772 File Offset: 0x00CCB972
		public void RefreshFieldLockData(int remainRound, bool fire = true)
		{
			if (this.FieldData != null)
			{
				this.FieldData.SetSealRemainRound(remainRound);
				if (fire)
				{
					EventSystem.Instance.Emit<int>(EEventName.OpponentSealFieldChange, remainRound);
				}
			}
		}

		// Token: 0x060361C4 RID: 221636 RVA: 0x00CCD79C File Offset: 0x00CCB99C
		public void InitRecycleData()
		{
			this.RecycleData = new PhantomArenaRecycleData();
		}

		// Token: 0x060361C5 RID: 221637 RVA: 0x00CCD7A9 File Offset: 0x00CCB9A9
		public void RefreshRecycleLockData(int remainRound)
		{
			if (this.RecycleData != null)
			{
				this.RecycleData.SealRemainRound = remainRound;
			}
		}

		// Token: 0x060361C6 RID: 221638 RVA: 0x00CCD7BF File Offset: 0x00CCB9BF
		public PhantomCardData CreatePhantomCardData(int cardId, int configId)
		{
			PhantomCardData phantomCardData = new PhantomCardData(true);
			phantomCardData.InitDataByNpc(cardId, configId);
			return phantomCardData;
		}

		// Token: 0x060361C7 RID: 221639 RVA: 0x00CCD7D0 File Offset: 0x00CCB9D0
		public bool HasFourCostInHand()
		{
			if (this.TaskData == null || !this.TaskData.IsAllFinish || !this.TaskData.IsExecuteFourCostLogic)
			{
				return false;
			}
			using (Dictionary<int, PhantomCardData>.ValueCollection.Enumerator enumerator = this.BattleCardMap.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.IsFourCost)
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x060361C8 RID: 221640 RVA: 0x00CCD854 File Offset: 0x00CCBA54
		public void RemoveFightCardListToRecycle(List<int> cardIdList)
		{
			foreach (int key in cardIdList)
			{
				if (this.BattleCardMap.ContainsKey(key))
				{
					PhantomCardData cardData = this.BattleCardMap[key];
					this.RemoveBattleCardData(cardData);
				}
			}
		}

		// Token: 0x060361C9 RID: 221641 RVA: 0x00CCD8C0 File Offset: 0x00CCBAC0
		private void NpcBattleEvolve(NpcPhantomBattleEvolveInfo info)
		{
			if (info != null)
			{
				NpcAiOperation aiOperation = PhantomArenaAiOperationFactory.GetAiOperation(EPhantomArenaAiOperationType.EvolveCard, info);
				this.NpcAiOperationList.Add(aiOperation);
			}
		}

		// Token: 0x060361CA RID: 221642 RVA: 0x00CCD8E4 File Offset: 0x00CCBAE4
		private void NpcBattleSlotInstead(NpcPhantomBattleSlotInsteadInfo info)
		{
			if (info != null)
			{
				NpcAiOperation aiOperation = PhantomArenaAiOperationFactory.GetAiOperation(EPhantomArenaAiOperationType.ChangeCard, info);
				this.NpcAiOperationList.Add(aiOperation);
			}
		}

		// Token: 0x060361CB RID: 221643 RVA: 0x00CCD908 File Offset: 0x00CCBB08
		private void NpcBattleSkillTrigger(PhantomBattleSkillTriggerInfo info)
		{
			if (info != null)
			{
				NpcAiOperation aiOperation = PhantomArenaAiOperationFactory.GetAiOperation(EPhantomArenaAiOperationType.SkillTrigger, info);
				this.NpcAiOperationList.Add(aiOperation);
			}
		}

		// Token: 0x060361CC RID: 221644 RVA: 0x00CCD92C File Offset: 0x00CCBB2C
		private void NpcBattleBuffTrigger(PhantomBattleBuffTriggerInfo info)
		{
			if (info != null)
			{
				NpcAiOperation aiOperation = PhantomArenaAiOperationFactory.GetAiOperation(EPhantomArenaAiOperationType.AddBuff, info);
				this.NpcAiOperationList.Add(aiOperation);
			}
		}

		// Token: 0x060361CD RID: 221645 RVA: 0x00CCD950 File Offset: 0x00CCBB50
		private void NpcBattleCardSkill(NpcPhantomBattleCardSkillInfo info)
		{
			if (info != null)
			{
				NpcAiOperation aiOperation = PhantomArenaAiOperationFactory.GetAiOperation(EPhantomArenaAiOperationType.UseCardSkill, info);
				this.NpcAiOperationList.Add(aiOperation);
			}
		}

		// Token: 0x060361CE RID: 221646 RVA: 0x00CCD974 File Offset: 0x00CCBB74
		private void NpcBattleCardRoleSkill(NpcPhantomBattleCardRoleSkillInfo info)
		{
			if (info != null)
			{
				NpcAiOperation aiOperation = PhantomArenaAiOperationFactory.GetAiOperation(EPhantomArenaAiOperationType.UseRoleSkill, info);
				this.NpcAiOperationList.Add(aiOperation);
			}
		}

		// Token: 0x060361CF RID: 221647 RVA: 0x00CCD998 File Offset: 0x00CCBB98
		private void NpcBattleGamerStatus(NpcPhantomBattleGamerStatusInfo info)
		{
			if (info != null)
			{
				NpcAiOperation aiOperation = PhantomArenaAiOperationFactory.GetAiOperation(EPhantomArenaAiOperationType.GamerStatus, info);
				this.NpcAiOperationList.Add(aiOperation);
			}
		}

		// Token: 0x060361D0 RID: 221648 RVA: 0x00CCD9BC File Offset: 0x00CCBBBC
		private void NpcBattleCardAttr(NpcPhantomBattleCardAttrInfo info)
		{
			if (info != null)
			{
				NpcAiOperation aiOperation = PhantomArenaAiOperationFactory.GetAiOperation(EPhantomArenaAiOperationType.CardAttr, info);
				this.NpcAiOperationList.Add(aiOperation);
			}
		}

		// Token: 0x060361D1 RID: 221649 RVA: 0x00CCD9E4 File Offset: 0x00CCBBE4
		private void NpcBattleEnterSlot(NpcPhantomBattleEnterSlotInfo info)
		{
			if (info != null)
			{
				NpcAiOperation aiOperation = PhantomArenaAiOperationFactory.GetAiOperation(EPhantomArenaAiOperationType.SettingCard, info);
				this.NpcAiOperationList.Add(aiOperation);
			}
		}

		// Token: 0x060361D2 RID: 221650 RVA: 0x00CCDA08 File Offset: 0x00CCBC08
		private void NpcPhantomBattleBackCardLibrary(NpcPhantomBattleBackCardLibrary info)
		{
			if (info != null)
			{
				NpcAiOperation aiOperation = PhantomArenaAiOperationFactory.GetAiOperation(EPhantomArenaAiOperationType.BackToLibrary, info);
				this.NpcAiOperationList.Add(aiOperation);
			}
		}

		// Token: 0x060361D3 RID: 221651 RVA: 0x00CCDA2C File Offset: 0x00CCBC2C
		private void NpcPhantomBattleDiscardCard(NpcPhantomBattleDiscardInfo info)
		{
			if (info != null)
			{
				NpcAiOperation aiOperation = PhantomArenaAiOperationFactory.GetAiOperation(EPhantomArenaAiOperationType.DiscardCard, info);
				this.NpcAiOperationList.Add(aiOperation);
			}
		}

		// Token: 0x060361D4 RID: 221652 RVA: 0x00CCDA54 File Offset: 0x00CCBC54
		private void NpcPhantomFourCostTaskDealCard(NpcPhantomFourCTaskDealCardInfo info)
		{
			if (info != null)
			{
				NpcAiOperation aiOperation = PhantomArenaAiOperationFactory.GetAiOperation(EPhantomArenaAiOperationType.FourCostTask, info);
				this.NpcAiOperationList.Add(aiOperation);
			}
		}

		// Token: 0x060361D5 RID: 221653 RVA: 0x00CCDA7C File Offset: 0x00CCBC7C
		private void NpcPhantomLeaveSlot(NpcPhantomLeaveSlot info)
		{
			if (info != null)
			{
				NpcAiOperation aiOperation = PhantomArenaAiOperationFactory.GetAiOperation(EPhantomArenaAiOperationType.LeaveSlot, info);
				this.NpcAiOperationList.Add(aiOperation);
			}
		}

		// Token: 0x060361D6 RID: 221654 RVA: 0x00CCDAA4 File Offset: 0x00CCBCA4
		private void NpcPhantomBattleBackSlotCardLibrary(NpcPhantomBattleBackSlotCardLibrary info)
		{
			if (info != null)
			{
				NpcAiOperation aiOperation = PhantomArenaAiOperationFactory.GetAiOperation(EPhantomArenaAiOperationType.BackSlotCardLibrary, info);
				this.NpcAiOperationList.Add(aiOperation);
			}
		}

		// Token: 0x060361D7 RID: 221655 RVA: 0x00CCDACC File Offset: 0x00CCBCCC
		private void NpcPhantomBattleReserveCardInfo(NpcPhantomBattleReserveCardInfo info)
		{
			if (info != null)
			{
				NpcAiOperation aiOperation = PhantomArenaAiOperationFactory.GetAiOperation(EPhantomArenaAiOperationType.ReserveCard, info);
				this.NpcAiOperationList.Add(aiOperation);
			}
		}

		// Token: 0x060361D8 RID: 221656 RVA: 0x00CCDAF4 File Offset: 0x00CCBCF4
		private void PhantomBattleNpcCardUpdateInfo(PhantomBattleNpcCardUpdateInfo info)
		{
			if (info != null)
			{
				NpcAiOperation aiOperation = PhantomArenaAiOperationFactory.GetAiOperation(EPhantomArenaAiOperationType.NpcCardUpdate, info);
				this.NpcAiOperationList.Add(aiOperation);
			}
		}

		// Token: 0x060361D9 RID: 221657 RVA: 0x00CCDB1C File Offset: 0x00CCBD1C
		private void PhantomBattleNpcClickCardSkillInfo(NpcPhantomBattleCardDurableSkillInfo info)
		{
			if (info != null)
			{
				NpcAiOperation aiOperation = PhantomArenaAiOperationFactory.GetAiOperation(EPhantomArenaAiOperationType.ClickCardSkill, info);
				this.NpcAiOperationList.Add(aiOperation);
			}
		}

		// Token: 0x060361DA RID: 221658 RVA: 0x00CCDB41 File Offset: 0x00CCBD41
		public void SetPrevShowLife(int value)
		{
			this.PrevShowLifeInternal = value;
		}

		// Token: 0x170082CE RID: 33486
		// (get) Token: 0x060361DB RID: 221659 RVA: 0x00CCDB4A File Offset: 0x00CCBD4A
		public int PrevShowLife
		{
			get
			{
				return this.PrevShowLifeInternal;
			}
		}

		// Token: 0x0401CA28 RID: 117288
		public int RoleId;

		// Token: 0x0401CA29 RID: 117289
		public int FightId;

		// Token: 0x0401CA2A RID: 117290
		public int CardLibraryNum;

		// Token: 0x0401CA2B RID: 117291
		public int LastHandCardNum;

		// Token: 0x0401CA2C RID: 117292
		public int HandCardNum;

		// Token: 0x0401CA2D RID: 117293
		private readonly Dictionary<PhantomBattleRoleStatus, int> BattleStatusMap = new Dictionary<PhantomBattleRoleStatus, int>();

		// Token: 0x0401CA2E RID: 117294
		private readonly Dictionary<PhantomBattleCardAttr, int> BattleAttrMap = new Dictionary<PhantomBattleCardAttr, int>();

		// Token: 0x0401CA2F RID: 117295
		public int CanEvolveNum;

		// Token: 0x0401CA30 RID: 117296
		public PhantomArenaCardTaskData TaskData;

		// Token: 0x0401CA31 RID: 117297
		public PhantomArenaFieldData FieldData;

		// Token: 0x0401CA32 RID: 117298
		public PhantomArenaRecycleData RecycleData;

		// Token: 0x0401CA33 RID: 117299
		[Nullable(2)]
		public CustomPromise InitPromise;

		// Token: 0x0401CA34 RID: 117300
		private readonly Dictionary<int, PhantomCardData> BattleCardMap = new Dictionary<int, PhantomCardData>();

		// Token: 0x0401CA35 RID: 117301
		private readonly Dictionary<int, PhantomCardData> SlotCardMap = new Dictionary<int, PhantomCardData>();

		// Token: 0x0401CA36 RID: 117302
		private List<NpcAiOperation> NpcAiOperationList = new List<NpcAiOperation>();

		// Token: 0x0401CA37 RID: 117303
		public bool IsFieldActive;

		// Token: 0x0401CA38 RID: 117304
		protected int PrevShowLifeInternal;
	}
}
