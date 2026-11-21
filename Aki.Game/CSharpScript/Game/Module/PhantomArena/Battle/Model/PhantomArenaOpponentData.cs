using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PhantomArena.Battle.Ai;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Model
{
	// Token: 0x0200426D RID: 17005
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaOpponentData
	{
		// Token: 0x0602B09C RID: 176284 RVA: 0x00C1A46E File Offset: 0x00C1866E
		public void CreateInitPromise()
		{
			this.InitPromise = new CustomPromise();
		}

		// Token: 0x0602B09D RID: 176285 RVA: 0x00C1A47C File Offset: 0x00C1867C
		public void InitPlayerData(PhantomBattleGamerFighterInfoCtx data)
		{
			this.BattleStatusMap.Clear();
			this.BattleAttrMap.Clear();
			this.RoleId = data.CardRoleId;
			this.HandCardNum = data.HandCardNum;
			this.RefreshCardLibraryNum(data.CardLibraryNum);
			this.RefreshCanEvolveNum(data.CanEvolveNum);
			this.InitBattleStatus(new Dictionary<int, int>(data.BattleStatus));
		}

		// Token: 0x0602B09E RID: 176286 RVA: 0x00C1A4E0 File Offset: 0x00C186E0
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

		// Token: 0x0602B09F RID: 176287 RVA: 0x00C1A5F6 File Offset: 0x00C187F6
		public List<NpcAiOperation> GetNpcAiOperationList()
		{
			return this.NpcAiOperationList;
		}

		// Token: 0x0602B0A0 RID: 176288 RVA: 0x00C1A5FE File Offset: 0x00C187FE
		public void RefreshHandCardNum(int num, bool fire = true)
		{
			this.LastHandCardNum = this.HandCardNum;
			this.HandCardNum = num;
			if (fire)
			{
				EventSystem.Instance.Emit(EEventName.OpponentHandCardChange);
			}
		}

		// Token: 0x0602B0A1 RID: 176289 RVA: 0x00C1A626 File Offset: 0x00C18826
		public void RefreshCardLibraryNum(int num)
		{
			this.CardLibraryNum = num;
			EventSystem.Instance.Emit(EEventName.OpponentCardLibraryChange);
		}

		// Token: 0x0602B0A2 RID: 176290 RVA: 0x00C1A63F File Offset: 0x00C1883F
		public void RefreshCanEvolveNum(int canEvolveNum)
		{
			this.CanEvolveNum = canEvolveNum;
		}

		// Token: 0x0602B0A3 RID: 176291 RVA: 0x00C1A648 File Offset: 0x00C18848
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

		// Token: 0x0602B0A4 RID: 176292 RVA: 0x00C1A6BC File Offset: 0x00C188BC
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

		// Token: 0x0602B0A5 RID: 176293 RVA: 0x00C1A740 File Offset: 0x00C18940
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

		// Token: 0x0602B0A6 RID: 176294 RVA: 0x00C1A770 File Offset: 0x00C18970
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

		// Token: 0x0602B0A7 RID: 176295 RVA: 0x00C1A7F4 File Offset: 0x00C189F4
		public int GetBattleStatusValue(PhantomBattleRoleStatus status)
		{
			if (!this.BattleStatusMap.ContainsKey(status))
			{
				return 0;
			}
			return this.BattleStatusMap[status];
		}

		// Token: 0x0602B0A8 RID: 176296 RVA: 0x00C1A812 File Offset: 0x00C18A12
		public int GetBattleBattleAttr(PhantomBattleCardAttr attr)
		{
			if (!this.BattleAttrMap.ContainsKey(attr))
			{
				return 0;
			}
			return this.BattleAttrMap[attr];
		}

		// Token: 0x0602B0A9 RID: 176297 RVA: 0x00C1A830 File Offset: 0x00C18A30
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

		// Token: 0x0602B0AA RID: 176298 RVA: 0x00C1A8F4 File Offset: 0x00C18AF4
		public bool RemoveBattleCardDataByIndex(int index)
		{
			if (!this.SlotCardMap.ContainsKey(index))
			{
				return false;
			}
			PhantomCardData cardData = this.SlotCardMap[index];
			return this.RemoveBattleCardData(cardData);
		}

		// Token: 0x0602B0AB RID: 176299 RVA: 0x00C1A928 File Offset: 0x00C18B28
		private bool RemoveBattleCardData(PhantomCardData cardData)
		{
			bool flag = this.BattleCardMap.Remove(cardData.CardId);
			bool flag2 = this.SlotCardMap.Remove(cardData.Index);
			return flag && flag2;
		}

		// Token: 0x0602B0AC RID: 176300 RVA: 0x00C1A95C File Offset: 0x00C18B5C
		public void SetBattleCardData(PhantomBattleFighterInfo data)
		{
			PhantomCardData phantomCardData = new PhantomCardData(true);
			phantomCardData.RefreshFightData(data);
			this.RemoveBattleCardDataByIndex(phantomCardData.Index);
			this.BattleCardMap[phantomCardData.CardId] = phantomCardData;
			this.SlotCardMap[phantomCardData.Index] = phantomCardData;
		}

		// Token: 0x0602B0AD RID: 176301 RVA: 0x00C1A9A8 File Offset: 0x00C18BA8
		public void SetBattleCardDataList(PhantomBattleFighterInfo[] dataList)
		{
			foreach (PhantomBattleFighterInfo battleCardData in dataList)
			{
				this.SetBattleCardData(battleCardData);
			}
		}

		// Token: 0x0602B0AE RID: 176302 RVA: 0x00C1A9D0 File Offset: 0x00C18BD0
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

		// Token: 0x0602B0AF RID: 176303 RVA: 0x00C1AB7C File Offset: 0x00C18D7C
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

		// Token: 0x0602B0B0 RID: 176304 RVA: 0x00C1AC15 File Offset: 0x00C18E15
		public void BackToLibrary(NpcPhantomBattleBackCardLibrary info)
		{
			this.RefreshCardLibraryNum(info.CurCardLibraryNum);
			this.RefreshHandCardNum(info.HandCardNum, false);
		}

		// Token: 0x0602B0B1 RID: 176305 RVA: 0x00C1AC30 File Offset: 0x00C18E30
		public void BackSlotCardToLibrary(int index, int cardLibraryNum)
		{
			this.RemoveBattleCardDataByIndex(index);
			this.RefreshCardLibraryNum(cardLibraryNum);
		}

		// Token: 0x0602B0B2 RID: 176306 RVA: 0x00C1AC41 File Offset: 0x00C18E41
		public void ReverseCard(NpcPhantomBattleReserveCardInfo info)
		{
			this.RefreshCardLibraryNum(info.CurCardLibraryNum);
			this.RefreshHandCardNum(info.HandCardNum, true);
		}

		// Token: 0x0602B0B3 RID: 176307 RVA: 0x00C1AC5C File Offset: 0x00C18E5C
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

		// Token: 0x0602B0B4 RID: 176308 RVA: 0x00C1AC94 File Offset: 0x00C18E94
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

		// Token: 0x0602B0B5 RID: 176309 RVA: 0x00C1AD08 File Offset: 0x00C18F08
		public PhantomCardData GetBattleCardByCardId(int cardId)
		{
			if (!this.BattleCardMap.ContainsKey(cardId))
			{
				return null;
			}
			return this.BattleCardMap[cardId];
		}

		// Token: 0x0602B0B6 RID: 176310 RVA: 0x00C1AD28 File Offset: 0x00C18F28
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

		// Token: 0x0602B0B7 RID: 176311 RVA: 0x00C1ADA0 File Offset: 0x00C18FA0
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

		// Token: 0x0602B0B8 RID: 176312 RVA: 0x00C1AE04 File Offset: 0x00C19004
		public PhantomCardData GetCardDataByIndex(int index)
		{
			if (!this.SlotCardMap.ContainsKey(index))
			{
				return null;
			}
			return this.SlotCardMap[index];
		}

		// Token: 0x0602B0B9 RID: 176313 RVA: 0x00C1AE22 File Offset: 0x00C19022
		public List<PhantomCardData> GetCardDataList()
		{
			return new List<PhantomCardData>(this.BattleCardMap.Values);
		}

		// Token: 0x0602B0BA RID: 176314 RVA: 0x00C1AE34 File Offset: 0x00C19034
		public void ClearHandData()
		{
			this.HandCardNum = 0;
		}

		// Token: 0x0602B0BB RID: 176315 RVA: 0x00C1AE3D File Offset: 0x00C1903D
		public void InitTaskData(PhantomBattleGamerFourCTaskInfo data)
		{
			this.TaskData = new PhantomArenaCardTaskData(false);
			this.TaskData.SetTaskData(data);
		}

		// Token: 0x0602B0BC RID: 176316 RVA: 0x00C1AE58 File Offset: 0x00C19058
		public void RefreshTaskData(PhantomBattleGamerFourCTaskInfo data)
		{
			if (this.TaskData != null)
			{
				this.TaskData.SetTaskData(data);
				return;
			}
			Log.Instance.Error(ELogModule.PhantomArena, ELogAuthor.XXJ, "任务数据为空", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x0602B0BD RID: 176317 RVA: 0x00C1AE99 File Offset: 0x00C19099
		public void InitFieldData()
		{
			this.FieldData = new PhantomArenaFieldData();
		}

		// Token: 0x0602B0BE RID: 176318 RVA: 0x00C1AEA6 File Offset: 0x00C190A6
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

		// Token: 0x0602B0BF RID: 176319 RVA: 0x00C1AED0 File Offset: 0x00C190D0
		public void InitRecycleData()
		{
			this.RecycleData = new PhantomArenaRecycleData();
		}

		// Token: 0x0602B0C0 RID: 176320 RVA: 0x00C1AEDD File Offset: 0x00C190DD
		public void RefreshRecycleLockData(int remainRound)
		{
			if (this.RecycleData != null)
			{
				this.RecycleData.SealRemainRound = remainRound;
			}
		}

		// Token: 0x0602B0C1 RID: 176321 RVA: 0x00C1AEF3 File Offset: 0x00C190F3
		public PhantomCardData CreatePhantomCardData(int cardId, int configId)
		{
			PhantomCardData phantomCardData = new PhantomCardData(true);
			phantomCardData.InitDataByNpc(cardId, configId);
			return phantomCardData;
		}

		// Token: 0x0602B0C2 RID: 176322 RVA: 0x00C1AF04 File Offset: 0x00C19104
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

		// Token: 0x0602B0C3 RID: 176323 RVA: 0x00C1AF88 File Offset: 0x00C19188
		public void RemoveFightCardListToRecycle(IEnumerable<int> cardIdList)
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

		// Token: 0x0602B0C4 RID: 176324 RVA: 0x00C1AFEC File Offset: 0x00C191EC
		private void NpcBattleEvolve(NpcPhantomBattleEvolveInfo info)
		{
			if (info != null)
			{
				NpcAiOperation aiOperation = PhantomArenaAiOperationFactory.GetAiOperation(EPhantomArenaAiOperationType.EvolveCard, info);
				this.NpcAiOperationList.Add(aiOperation);
			}
		}

		// Token: 0x0602B0C5 RID: 176325 RVA: 0x00C1B010 File Offset: 0x00C19210
		private void NpcBattleSlotInstead(NpcPhantomBattleSlotInsteadInfo info)
		{
			if (info != null)
			{
				NpcAiOperation aiOperation = PhantomArenaAiOperationFactory.GetAiOperation(EPhantomArenaAiOperationType.ChangeCard, info);
				this.NpcAiOperationList.Add(aiOperation);
			}
		}

		// Token: 0x0602B0C6 RID: 176326 RVA: 0x00C1B034 File Offset: 0x00C19234
		private void NpcBattleSkillTrigger(PhantomBattleSkillTriggerInfo info)
		{
			if (info != null)
			{
				NpcAiOperation aiOperation = PhantomArenaAiOperationFactory.GetAiOperation(EPhantomArenaAiOperationType.SkillTrigger, info);
				this.NpcAiOperationList.Add(aiOperation);
			}
		}

		// Token: 0x0602B0C7 RID: 176327 RVA: 0x00C1B058 File Offset: 0x00C19258
		private void NpcBattleBuffTrigger(PhantomBattleBuffTriggerInfo info)
		{
			if (info != null)
			{
				NpcAiOperation aiOperation = PhantomArenaAiOperationFactory.GetAiOperation(EPhantomArenaAiOperationType.AddBuff, info);
				this.NpcAiOperationList.Add(aiOperation);
			}
		}

		// Token: 0x0602B0C8 RID: 176328 RVA: 0x00C1B07C File Offset: 0x00C1927C
		private void NpcBattleCardSkill(NpcPhantomBattleCardSkillInfo info)
		{
			if (info != null)
			{
				NpcAiOperation aiOperation = PhantomArenaAiOperationFactory.GetAiOperation(EPhantomArenaAiOperationType.UseCardSkill, info);
				this.NpcAiOperationList.Add(aiOperation);
			}
		}

		// Token: 0x0602B0C9 RID: 176329 RVA: 0x00C1B0A0 File Offset: 0x00C192A0
		private void NpcBattleCardRoleSkill(NpcPhantomBattleCardRoleSkillInfo info)
		{
			if (info != null)
			{
				NpcAiOperation aiOperation = PhantomArenaAiOperationFactory.GetAiOperation(EPhantomArenaAiOperationType.UseRoleSkill, info);
				this.NpcAiOperationList.Add(aiOperation);
			}
		}

		// Token: 0x0602B0CA RID: 176330 RVA: 0x00C1B0C4 File Offset: 0x00C192C4
		private void NpcBattleGamerStatus(NpcPhantomBattleGamerStatusInfo info)
		{
			if (info != null)
			{
				NpcAiOperation aiOperation = PhantomArenaAiOperationFactory.GetAiOperation(EPhantomArenaAiOperationType.GamerStatus, info);
				this.NpcAiOperationList.Add(aiOperation);
			}
		}

		// Token: 0x0602B0CB RID: 176331 RVA: 0x00C1B0E8 File Offset: 0x00C192E8
		private void NpcBattleCardAttr(NpcPhantomBattleCardAttrInfo info)
		{
			if (info != null)
			{
				NpcAiOperation aiOperation = PhantomArenaAiOperationFactory.GetAiOperation(EPhantomArenaAiOperationType.CardAttr, info);
				this.NpcAiOperationList.Add(aiOperation);
			}
		}

		// Token: 0x0602B0CC RID: 176332 RVA: 0x00C1B110 File Offset: 0x00C19310
		private void NpcBattleEnterSlot(NpcPhantomBattleEnterSlotInfo info)
		{
			if (info != null)
			{
				NpcAiOperation aiOperation = PhantomArenaAiOperationFactory.GetAiOperation(EPhantomArenaAiOperationType.SettingCard, info);
				this.NpcAiOperationList.Add(aiOperation);
			}
		}

		// Token: 0x0602B0CD RID: 176333 RVA: 0x00C1B134 File Offset: 0x00C19334
		private void NpcPhantomBattleBackCardLibrary(NpcPhantomBattleBackCardLibrary info)
		{
			if (info != null)
			{
				NpcAiOperation aiOperation = PhantomArenaAiOperationFactory.GetAiOperation(EPhantomArenaAiOperationType.BackToLibrary, info);
				this.NpcAiOperationList.Add(aiOperation);
			}
		}

		// Token: 0x0602B0CE RID: 176334 RVA: 0x00C1B158 File Offset: 0x00C19358
		private void NpcPhantomBattleDiscardCard(NpcPhantomBattleDiscardInfo info)
		{
			if (info != null)
			{
				NpcAiOperation aiOperation = PhantomArenaAiOperationFactory.GetAiOperation(EPhantomArenaAiOperationType.DiscardCard, info);
				this.NpcAiOperationList.Add(aiOperation);
			}
		}

		// Token: 0x0602B0CF RID: 176335 RVA: 0x00C1B180 File Offset: 0x00C19380
		private void NpcPhantomFourCostTaskDealCard(NpcPhantomFourCTaskDealCardInfo info)
		{
			if (info != null)
			{
				NpcAiOperation aiOperation = PhantomArenaAiOperationFactory.GetAiOperation(EPhantomArenaAiOperationType.FourCostTask, info);
				this.NpcAiOperationList.Add(aiOperation);
			}
		}

		// Token: 0x0602B0D0 RID: 176336 RVA: 0x00C1B1A8 File Offset: 0x00C193A8
		private void NpcPhantomLeaveSlot(NpcPhantomLeaveSlot info)
		{
			if (info != null)
			{
				NpcAiOperation aiOperation = PhantomArenaAiOperationFactory.GetAiOperation(EPhantomArenaAiOperationType.LeaveSlot, info);
				this.NpcAiOperationList.Add(aiOperation);
			}
		}

		// Token: 0x0602B0D1 RID: 176337 RVA: 0x00C1B1D0 File Offset: 0x00C193D0
		private void NpcPhantomBattleBackSlotCardLibrary(NpcPhantomBattleBackSlotCardLibrary info)
		{
			if (info != null)
			{
				NpcAiOperation aiOperation = PhantomArenaAiOperationFactory.GetAiOperation(EPhantomArenaAiOperationType.BackSlotCardLibrary, info);
				this.NpcAiOperationList.Add(aiOperation);
			}
		}

		// Token: 0x0602B0D2 RID: 176338 RVA: 0x00C1B1F8 File Offset: 0x00C193F8
		private void NpcPhantomBattleReserveCardInfo(NpcPhantomBattleReserveCardInfo info)
		{
			if (info != null)
			{
				NpcAiOperation aiOperation = PhantomArenaAiOperationFactory.GetAiOperation(EPhantomArenaAiOperationType.ReserveCard, info);
				this.NpcAiOperationList.Add(aiOperation);
			}
		}

		// Token: 0x0602B0D3 RID: 176339 RVA: 0x00C1B220 File Offset: 0x00C19420
		private void PhantomBattleNpcCardUpdateInfo(PhantomBattleNpcCardUpdateInfo info)
		{
			if (info != null)
			{
				NpcAiOperation aiOperation = PhantomArenaAiOperationFactory.GetAiOperation(EPhantomArenaAiOperationType.NpcCardUpdate, info);
				this.NpcAiOperationList.Add(aiOperation);
			}
		}

		// Token: 0x0602B0D4 RID: 176340 RVA: 0x00C1B248 File Offset: 0x00C19448
		private void PhantomBattleNpcClickCardSkillInfo(NpcPhantomBattleCardDurableSkillInfo info)
		{
			if (info != null)
			{
				NpcAiOperation aiOperation = PhantomArenaAiOperationFactory.GetAiOperation(EPhantomArenaAiOperationType.ClickCardSkill, info);
				this.NpcAiOperationList.Add(aiOperation);
			}
		}

		// Token: 0x0602B0D5 RID: 176341 RVA: 0x00C1B26D File Offset: 0x00C1946D
		public void SetPrevShowLife(int value)
		{
			this.PrevShowLifeInternal = value;
		}

		// Token: 0x1700568E RID: 22158
		// (get) Token: 0x0602B0D6 RID: 176342 RVA: 0x00C1B276 File Offset: 0x00C19476
		public int PrevShowLife
		{
			get
			{
				return this.PrevShowLifeInternal;
			}
		}

		// Token: 0x0401745D RID: 95325
		public int RoleId;

		// Token: 0x0401745E RID: 95326
		public int FightId;

		// Token: 0x0401745F RID: 95327
		public int CardLibraryNum;

		// Token: 0x04017460 RID: 95328
		public int LastHandCardNum;

		// Token: 0x04017461 RID: 95329
		public int HandCardNum;

		// Token: 0x04017462 RID: 95330
		private readonly Dictionary<PhantomBattleRoleStatus, int> BattleStatusMap = new Dictionary<PhantomBattleRoleStatus, int>();

		// Token: 0x04017463 RID: 95331
		private readonly Dictionary<PhantomBattleCardAttr, int> BattleAttrMap = new Dictionary<PhantomBattleCardAttr, int>();

		// Token: 0x04017464 RID: 95332
		public int CanEvolveNum;

		// Token: 0x04017465 RID: 95333
		public PhantomArenaCardTaskData TaskData;

		// Token: 0x04017466 RID: 95334
		public PhantomArenaFieldData FieldData;

		// Token: 0x04017467 RID: 95335
		public PhantomArenaRecycleData RecycleData;

		// Token: 0x04017468 RID: 95336
		[Nullable(2)]
		public CustomPromise InitPromise;

		// Token: 0x04017469 RID: 95337
		private readonly Dictionary<int, PhantomCardData> BattleCardMap = new Dictionary<int, PhantomCardData>();

		// Token: 0x0401746A RID: 95338
		private readonly Dictionary<int, PhantomCardData> SlotCardMap = new Dictionary<int, PhantomCardData>();

		// Token: 0x0401746B RID: 95339
		private List<NpcAiOperation> NpcAiOperationList = new List<NpcAiOperation>();

		// Token: 0x0401746C RID: 95340
		public bool IsFieldActive;

		// Token: 0x0401746D RID: 95341
		protected int PrevShowLifeInternal;
	}
}
