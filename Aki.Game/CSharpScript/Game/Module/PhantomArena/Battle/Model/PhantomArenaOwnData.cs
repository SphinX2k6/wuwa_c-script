using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Model
{
	// Token: 0x0200529E RID: 21150
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaOwnData
	{
		// Token: 0x060361DD RID: 221661 RVA: 0x00CCDB91 File Offset: 0x00CCBD91
		private void SetBattleCardData(PhantomCardData cardData)
		{
			this.BattleCardMap[cardData.CardId] = cardData;
			this.SlotCardMap[cardData.Index] = cardData;
			EventSystem.Instance.Emit(EEventName.RefreshBattleCardNum);
		}

		// Token: 0x060361DE RID: 221662 RVA: 0x00CCDBC8 File Offset: 0x00CCBDC8
		private bool RemoveBattleCardData(PhantomCardData cardData)
		{
			bool flag = this.BattleCardMap.Remove(cardData.CardId);
			bool flag2 = false;
			if (this.SlotCardMap.ContainsKey(cardData.Index))
			{
				PhantomCardData phantomCardData = this.SlotCardMap[cardData.Index];
				if (phantomCardData != null && phantomCardData.CardId == cardData.CardId)
				{
					this.SlotCardMap.Remove(cardData.Index);
				}
				flag2 = true;
			}
			EventSystem.Instance.Emit(EEventName.RefreshBattleCardNum);
			return flag && flag2;
		}

		// Token: 0x060361DF RID: 221663 RVA: 0x00CCDC44 File Offset: 0x00CCBE44
		private void AddHandCardData(PhantomBattleHandCardInfo dataInfo)
		{
			PhantomCardData phantomCardData = new PhantomCardData(false);
			phantomCardData.InitData(dataInfo);
			this.HandCardMap[phantomCardData.CardId] = phantomCardData;
			this.HandCardIdList.Add(phantomCardData.CardId);
		}

		// Token: 0x060361E0 RID: 221664 RVA: 0x00CCDC84 File Offset: 0x00CCBE84
		public void InitHandData(PhantomBattleHandCardInfo[] dataInfoList)
		{
			this.ClearHandData();
			foreach (PhantomBattleHandCardInfo dataInfo in dataInfoList)
			{
				this.AddHandCardData(dataInfo);
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.PhantomArena;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "初始化手牌数据";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", this.HandCardIdList);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x060361E1 RID: 221665 RVA: 0x00CCDCE4 File Offset: 0x00CCBEE4
		public void RefreshHandData(PhantomBattleHandCardInfo[] dataInfoList)
		{
			int i = 0;
			while (i < dataInfoList.Length)
			{
				PhantomBattleHandCardInfo phantomBattleHandCardInfo = dataInfoList[i];
				if (!this.HandCardMap.ContainsKey(phantomBattleHandCardInfo.CardUid))
				{
					goto IL_3E;
				}
				PhantomCardData phantomCardData = this.HandCardMap[phantomBattleHandCardInfo.CardUid];
				if (phantomCardData == null)
				{
					goto IL_3E;
				}
				phantomCardData.InitData(phantomBattleHandCardInfo);
				IL_45:
				i++;
				continue;
				IL_3E:
				this.AddHandCardData(phantomBattleHandCardInfo);
				goto IL_45;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.PhantomArena;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "刷新手牌数据";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", this.HandCardIdList);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x060361E2 RID: 221666 RVA: 0x00CCDD70 File Offset: 0x00CCBF70
		public void AddHandDataList(PhantomBattleHandCardInfo[] dataInfoList, bool fire = true)
		{
			List<int> list = new List<int>();
			foreach (PhantomBattleHandCardInfo phantomBattleHandCardInfo in dataInfoList)
			{
				if (!this.HandCardMap.ContainsKey(phantomBattleHandCardInfo.CardUid))
				{
					this.AddHandCardData(phantomBattleHandCardInfo);
				}
				list.Add(phantomBattleHandCardInfo.CardUid);
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.PhantomArena;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "新增手牌数据";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("数据", list);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			if (fire)
			{
				EventSystem.Instance.Emit<IReadOnlyList<int>>(EEventName.OwnHandCardAdd, list);
			}
		}

		// Token: 0x060361E3 RID: 221667 RVA: 0x00CCDE00 File Offset: 0x00CCC000
		public void RemoveHandDataList(List<int> discardIdList)
		{
			foreach (int cardId in discardIdList)
			{
				this.RemoveHandCardByCardId(cardId);
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.PhantomArena;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "移除手牌数据";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("数据", discardIdList);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			EventSystem.Instance.Emit<IReadOnlyList<int>>(EEventName.OwnHandCardRemove, discardIdList);
		}

		// Token: 0x060361E4 RID: 221668 RVA: 0x00CCDE8C File Offset: 0x00CCC08C
		public void RemoveHandCardByCardId(int cardId)
		{
			this.HandCardMap.Remove(cardId);
			int num = this.HandCardIdList.IndexOf(cardId);
			if (num >= 0)
			{
				this.HandCardIdList.RemoveAt(num);
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.PhantomArena;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "移除手牌数据";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("CardId", cardId);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x060361E5 RID: 221669 RVA: 0x00CCDEF4 File Offset: 0x00CCC0F4
		public void AddFourCostCard(PhantomBattleHandCardInfo dataInfo)
		{
			this.AddHandCardData(dataInfo);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.PhantomArena;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "新增4Cost手牌";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("CardId", dataInfo.CardUid);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.CanShowFourCostView = true;
			this.CoreCardId = dataInfo.CardUid;
			EventSystem.Instance.Emit<int>(EEventName.OwnHandCardAddFourCost, dataInfo.CardUid);
		}

		// Token: 0x060361E6 RID: 221670 RVA: 0x00CCDF68 File Offset: 0x00CCC168
		public void InitPlayerData(PhantomBattleGamerFighterInfoCtx data)
		{
			this.BattleStatusMap.Clear();
			this.BattleAttrMap.Clear();
			this.RoleId = data.CardRoleId;
			this.RefreshCardLibraryNum(data.CardLibraryNum);
			this.RefreshCanEvolveNum(data.CanEvolveNum);
			this.InitBattleStatus(data.BattleStatus.ToDictionary<int, int>());
			this.InitBattleAttr(data.BattleAttr.ToDictionary<int, int>());
		}

		// Token: 0x060361E7 RID: 221671 RVA: 0x00CCDFD4 File Offset: 0x00CCC1D4
		private void InitBattleAttr(Dictionary<int, int> battleAttrMap)
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
		}

		// Token: 0x060361E8 RID: 221672 RVA: 0x00CCE048 File Offset: 0x00CCC248
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

		// Token: 0x060361E9 RID: 221673 RVA: 0x00CCE0BC File Offset: 0x00CCC2BC
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
			EventSystem.Instance.Emit<IReadOnlyList<PhantomBattleRoleStatus>>(EEventName.OwnBattleStatusChange, list);
		}

		// Token: 0x060361EA RID: 221674 RVA: 0x00CCE140 File Offset: 0x00CCC340
		public void RefreshBattleHpStatus(int hpNum, bool fire)
		{
			this.BattleStatusMap[PhantomBattleRoleStatus.PhantomBattleLife] = hpNum;
			if (fire)
			{
				EventSystem.Instance.Emit<IReadOnlyList<PhantomBattleRoleStatus>>(EEventName.OwnBattleStatusChange, new List<PhantomBattleRoleStatus>
				{
					PhantomBattleRoleStatus.PhantomBattleLife
				});
			}
		}

		// Token: 0x060361EB RID: 221675 RVA: 0x00CCE170 File Offset: 0x00CCC370
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
			EventSystem.Instance.Emit<IReadOnlyList<PhantomBattleCardAttr>>(EEventName.OwnBattleAttrChange, list);
		}

		// Token: 0x060361EC RID: 221676 RVA: 0x00CCE1F4 File Offset: 0x00CCC3F4
		public void RefreshCanEvolveNum(int canEvolveNum)
		{
			this.CanEvolveNum = canEvolveNum;
		}

		// Token: 0x060361ED RID: 221677 RVA: 0x00CCE200 File Offset: 0x00CCC400
		public void RefreshCardAttr(int fightId, Dictionary<int, int> battleAttrMap)
		{
			foreach (PhantomCardData phantomCardData in this.BattleCardMap.Values)
			{
				if (phantomCardData.FightId == fightId)
				{
					phantomCardData.RefreshFightAttr(battleAttrMap);
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
				cardData2.RefreshFightAttr(battleAttrMap);
			}
		}

		// Token: 0x060361EE RID: 221678 RVA: 0x00CCE2C4 File Offset: 0x00CCC4C4
		public int GetBattleStatusValue(PhantomBattleRoleStatus status)
		{
			if (!this.BattleStatusMap.ContainsKey(status))
			{
				return 0;
			}
			return this.BattleStatusMap[status];
		}

		// Token: 0x060361EF RID: 221679 RVA: 0x00CCE2E2 File Offset: 0x00CCC4E2
		public int GetBattleBattleAttr(PhantomBattleCardAttr attr)
		{
			if (!this.BattleAttrMap.ContainsKey(attr))
			{
				return 0;
			}
			return this.BattleAttrMap[attr];
		}

		// Token: 0x060361F0 RID: 221680 RVA: 0x00CCE300 File Offset: 0x00CCC500
		public void HandCardToFightCard(PhantomCardData cardData, PhantomBattleFighterInfo data)
		{
			this.RemoveHandCardByCardId(cardData.CardId);
			cardData.RefreshFightData(data);
			this.SetBattleCardData(cardData);
		}

		// Token: 0x060361F1 RID: 221681 RVA: 0x00CCE31C File Offset: 0x00CCC51C
		public void FightCardToHandCard(PhantomBattleHandCardInfo data)
		{
			if (!this.BattleCardMap.ContainsKey(data.CardUid))
			{
				return;
			}
			PhantomCardData phantomCardData = this.BattleCardMap[data.CardUid];
			this.RemoveBattleCardData(phantomCardData);
			phantomCardData.InitData(data);
			this.HandCardMap[phantomCardData.CardId] = phantomCardData;
			this.HandCardIdList.Add(phantomCardData.CardId);
		}

		// Token: 0x060361F2 RID: 221682 RVA: 0x00CCE384 File Offset: 0x00CCC584
		public void FightCardToRecycle(PhantomBattleBackSlotCardLibraryResponse data)
		{
			if (!this.BattleCardMap.ContainsKey(data.CardUid))
			{
				return;
			}
			PhantomCardData cardData = this.BattleCardMap[data.CardUid];
			this.RemoveBattleCardData(cardData);
			this.RefreshCardLibraryNum(data.CurCardLibraryNum);
		}

		// Token: 0x060361F3 RID: 221683 RVA: 0x00CCE3CC File Offset: 0x00CCC5CC
		public void FightCardToFunctional(int cardId)
		{
			if (this.BattleCardMap.ContainsKey(cardId))
			{
				PhantomCardData phantomCardData = this.BattleCardMap[cardId];
				if (phantomCardData != null)
				{
					this.RemoveBattleCardData(phantomCardData);
				}
			}
		}

		// Token: 0x060361F4 RID: 221684 RVA: 0x00CCE400 File Offset: 0x00CCC600
		public void DestroyFightCard(int cardId)
		{
			if (!this.BattleCardMap.ContainsKey(cardId))
			{
				return;
			}
			PhantomCardData cardData = this.BattleCardMap[cardId];
			this.RemoveBattleCardData(cardData);
		}

		// Token: 0x060361F5 RID: 221685 RVA: 0x00CCE434 File Offset: 0x00CCC634
		public void RemoveCardToLibrary(int cardId, int cardHeapSize)
		{
			if (!this.BattleCardMap.ContainsKey(cardId))
			{
				return;
			}
			PhantomCardData cardData = this.BattleCardMap[cardId];
			this.RemoveBattleCardData(cardData);
			this.RefreshCardLibraryNum(cardHeapSize);
		}

		// Token: 0x060361F6 RID: 221686 RVA: 0x00CCE46C File Offset: 0x00CCC66C
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

		// Token: 0x060361F7 RID: 221687 RVA: 0x00CCE4D8 File Offset: 0x00CCC6D8
		public void RemoveHandCardListToRecycle(List<int> cardIdList)
		{
			foreach (int cardId in cardIdList)
			{
				this.RemoveHandCardByCardId(cardId);
			}
		}

		// Token: 0x060361F8 RID: 221688 RVA: 0x00CCE528 File Offset: 0x00CCC728
		public List<int> GetHandCardIdList()
		{
			return this.HandCardIdList;
		}

		// Token: 0x060361F9 RID: 221689 RVA: 0x00CCE530 File Offset: 0x00CCC730
		public PhantomCardData GetHandCardDataByCardId(int cardId)
		{
			if (!this.HandCardMap.ContainsKey(cardId))
			{
				return null;
			}
			return this.HandCardMap[cardId];
		}

		// Token: 0x060361FA RID: 221690 RVA: 0x00CCE54E File Offset: 0x00CCC74E
		public PhantomCardData GetBattleCardByCardId(int cardId)
		{
			if (!this.BattleCardMap.ContainsKey(cardId))
			{
				return null;
			}
			return this.BattleCardMap[cardId];
		}

		// Token: 0x060361FB RID: 221691 RVA: 0x00CCE56C File Offset: 0x00CCC76C
		public bool HasBattleCardByCardId(int cardId)
		{
			return this.BattleCardMap.ContainsKey(cardId);
		}

		// Token: 0x060361FC RID: 221692 RVA: 0x00CCE57A File Offset: 0x00CCC77A
		public List<PhantomCardData> GetBattleCardDataList()
		{
			return this.BattleCardMap.Values.ToList<PhantomCardData>();
		}

		// Token: 0x060361FD RID: 221693 RVA: 0x00CCE58C File Offset: 0x00CCC78C
		public List<PhantomCardData> GetHandCardDataList()
		{
			List<PhantomCardData> list = new List<PhantomCardData>();
			foreach (int key in this.HandCardIdList)
			{
				if (this.HandCardMap.ContainsKey(key))
				{
					PhantomCardData phantomCardData = this.HandCardMap[key];
					if (phantomCardData != null)
					{
						list.Add(phantomCardData);
					}
				}
			}
			return list;
		}

		// Token: 0x060361FE RID: 221694 RVA: 0x00CCE604 File Offset: 0x00CCC804
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
			this.ExchangeBattleCardData(changeInfos[0].AfterPos, cardDataByFightId.Index);
			if (changeInfos.Length > 1 && changeInfos[1] != null)
			{
				EventSystem.Instance.Emit<bool, int, int>(EEventName.NotifyBattleCardChange, false, cardDataByFightId.Index, changeInfos[1].AfterPos);
			}
		}

		// Token: 0x060361FF RID: 221695 RVA: 0x00CCE7B0 File Offset: 0x00CCC9B0
		public void ExchangeBattleCardData(int targetIndex, int startIndex)
		{
			PhantomCardData phantomCardData = null;
			PhantomCardData phantomCardData2 = null;
			if (this.SlotCardMap.ContainsKey(startIndex))
			{
				phantomCardData = this.SlotCardMap[startIndex];
			}
			if (this.SlotCardMap.ContainsKey(targetIndex))
			{
				phantomCardData2 = this.SlotCardMap[targetIndex];
			}
			this.SlotCardMap.Remove(startIndex);
			this.SlotCardMap.Remove(targetIndex);
			if (phantomCardData != null)
			{
				phantomCardData.Index = targetIndex;
				this.SlotCardMap[phantomCardData.Index] = phantomCardData;
			}
			if (phantomCardData2 != null)
			{
				phantomCardData2.Index = startIndex;
				this.SlotCardMap[phantomCardData2.Index] = phantomCardData2;
			}
		}

		// Token: 0x06036200 RID: 221696 RVA: 0x00CCE84C File Offset: 0x00CCCA4C
		public void EvolveBattleCardData(PhantomCardData cardData, PhantomBattleEvolveResponse response)
		{
			this.RefreshCanEvolveNum(response.CanEvolveNum);
			this.RefreshCardLibraryNum(response.CardLibraryNum);
			PhantomBattleFighterInfo phantomBattleFighterInfo = response.PhantomBattleFighterInfo;
			if (phantomBattleFighterInfo == null)
			{
				return;
			}
			PhantomBattleCardFighterInfoCtx phantomBattleCardFighterInfoCtx = phantomBattleFighterInfo.PhantomBattleCardFighterInfoCtx;
			if (phantomBattleCardFighterInfoCtx == null)
			{
				return;
			}
			int slotIndex = phantomBattleCardFighterInfoCtx.SlotIndex;
			if (!this.SlotCardMap.ContainsKey(slotIndex))
			{
				return;
			}
			PhantomCardData cardData2 = this.SlotCardMap[slotIndex];
			this.RemoveBattleCardData(cardData2);
			this.HandCardToFightCard(cardData, phantomBattleFighterInfo);
		}

		// Token: 0x06036201 RID: 221697 RVA: 0x00CCE8BA File Offset: 0x00CCCABA
		public void HandCardToRecycle(int cardId)
		{
			this.RemoveHandCardByCardId(cardId);
		}

		// Token: 0x06036202 RID: 221698 RVA: 0x00CCE8C4 File Offset: 0x00CCCAC4
		private void CallHandCardListToFight(PhantomBattleFighterInfo[] cardInfoList)
		{
			foreach (PhantomBattleFighterInfo phantomBattleFighterInfo in cardInfoList)
			{
				PhantomCardData handCardDataByCardId = this.GetHandCardDataByCardId(phantomBattleFighterInfo.UId);
				if (handCardDataByCardId != null)
				{
					this.HandCardToFightCard(handCardDataByCardId, phantomBattleFighterInfo);
				}
			}
		}

		// Token: 0x06036203 RID: 221699 RVA: 0x00CCE900 File Offset: 0x00CCCB00
		public void AddCardListToFight(PhantomBattleFighterInfo[] cardInfoList)
		{
			foreach (PhantomBattleFighterInfo data in cardInfoList)
			{
				PhantomCardData phantomCardData = new PhantomCardData(false);
				phantomCardData.RefreshFightData(data);
				this.SetBattleCardData(phantomCardData);
			}
		}

		// Token: 0x06036204 RID: 221700 RVA: 0x00CCE936 File Offset: 0x00CCCB36
		public void CallCardListToFight(PhantomBattleFighterInfo[] cardInfoList, PhantomBattleSelectedCardFromType type)
		{
			if (type == PhantomBattleSelectedCardFromType.Heap)
			{
				this.AddCardListToFight(cardInfoList);
				return;
			}
			this.CallHandCardListToFight(cardInfoList);
		}

		// Token: 0x06036205 RID: 221701 RVA: 0x00CCE94C File Offset: 0x00CCCB4C
		public void HandleFunctionalAreaCard(PhantomBattleCardSkillResponse response)
		{
			if (this.HandCardMap.ContainsKey(response.CardUId))
			{
				PhantomCardData phantomCardData = this.HandCardMap[response.CardUId];
				if (phantomCardData != null)
				{
					this.RemoveHandCardByCardId(response.CardUId);
					if (phantomCardData.IsField && this.FieldData != null)
					{
						this.FieldData.SetCardData(phantomCardData);
					}
				}
			}
			this.RefreshCardLibraryNum(response.LibraryCount);
		}

		// Token: 0x06036206 RID: 221702 RVA: 0x00CCE9B5 File Offset: 0x00CCCBB5
		public void RefreshCardLibraryNum(int num)
		{
			this.CardLibraryNum = num;
			EventSystem.Instance.Emit(EEventName.OwnCardLibraryChange);
		}

		// Token: 0x06036207 RID: 221703 RVA: 0x00CCE9D0 File Offset: 0x00CCCBD0
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

		// Token: 0x06036208 RID: 221704 RVA: 0x00CCEA48 File Offset: 0x00CCCC48
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

		// Token: 0x170082CF RID: 33487
		// (get) Token: 0x06036209 RID: 221705 RVA: 0x00CCEAAC File Offset: 0x00CCCCAC
		public int MonsterCardLength
		{
			get
			{
				int num = 0;
				using (Dictionary<int, PhantomCardData>.ValueCollection.Enumerator enumerator = this.BattleCardMap.Values.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current.IsNormal)
						{
							num++;
						}
					}
				}
				return num;
			}
		}

		// Token: 0x0603620A RID: 221706 RVA: 0x00CCEB0C File Offset: 0x00CCCD0C
		public void ClearHandData()
		{
			this.HandCardMap.Clear();
			this.HandCardIdList.Clear();
		}

		// Token: 0x0603620B RID: 221707 RVA: 0x00CCEB24 File Offset: 0x00CCCD24
		public void InitTaskData(PhantomBattleGamerFourCTaskInfo data)
		{
			this.TaskData = new PhantomArenaCardTaskData(true);
			this.TaskData.SetTaskData(data);
		}

		// Token: 0x0603620C RID: 221708 RVA: 0x00CCEB40 File Offset: 0x00CCCD40
		public void RefreshTaskData(PhantomBattleGamerFourCTaskInfo data)
		{
			if (this.TaskData != null)
			{
				this.TaskData.SetTaskData(data);
				return;
			}
			Log.Instance.Error(ELogModule.PhantomArena, ELogAuthor.XXJ, "任务数据为空", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x0603620D RID: 221709 RVA: 0x00CCEB81 File Offset: 0x00CCCD81
		public void InitFieldData()
		{
			this.FieldData = new PhantomArenaFieldData();
		}

		// Token: 0x0603620E RID: 221710 RVA: 0x00CCEB8E File Offset: 0x00CCCD8E
		public void RefreshFieldLockData(int remainRound)
		{
			if (this.FieldData != null)
			{
				this.FieldData.SetSealRemainRound(remainRound);
			}
		}

		// Token: 0x0603620F RID: 221711 RVA: 0x00CCEBA4 File Offset: 0x00CCCDA4
		public void InitRecycleData()
		{
			this.RecycleData = new PhantomArenaRecycleData();
		}

		// Token: 0x06036210 RID: 221712 RVA: 0x00CCEBB1 File Offset: 0x00CCCDB1
		public void RefreshRecycleLockData(int remainRound, bool fire = true)
		{
			if (this.RecycleData != null)
			{
				this.RecycleData.SealRemainRound = remainRound;
				if (fire)
				{
					EventSystem.Instance.Emit<int>(EEventName.OwnSealRecycleChange, remainRound);
				}
			}
		}

		// Token: 0x170082D0 RID: 33488
		// (get) Token: 0x06036211 RID: 221713 RVA: 0x00CCEBDB File Offset: 0x00CCCDDB
		public bool RecycleIsInSeal
		{
			get
			{
				PhantomArenaRecycleData recycleData = this.RecycleData;
				return recycleData != null && recycleData.IsSeal;
			}
		}

		// Token: 0x06036212 RID: 221714 RVA: 0x00CCEBEE File Offset: 0x00CCCDEE
		public int GetHandIndexByCardId(int cardId)
		{
			return this.HandCardIdList.IndexOf(cardId);
		}

		// Token: 0x06036213 RID: 221715 RVA: 0x00CCEBFC File Offset: 0x00CCCDFC
		public bool HasFourCostInHand()
		{
			using (Dictionary<int, PhantomCardData>.ValueCollection.Enumerator enumerator = this.HandCardMap.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.IsFourCost)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06036214 RID: 221716 RVA: 0x00CCEC5C File Offset: 0x00CCCE5C
		public void SetPrevShowLife(int value)
		{
			this.PrevShowLifeInternal = value;
		}

		// Token: 0x170082D1 RID: 33489
		// (get) Token: 0x06036215 RID: 221717 RVA: 0x00CCEC65 File Offset: 0x00CCCE65
		public int PrevShowLife
		{
			get
			{
				return this.PrevShowLifeInternal;
			}
		}

		// Token: 0x0401CA39 RID: 117305
		public int RoleId;

		// Token: 0x0401CA3A RID: 117306
		public int FightId;

		// Token: 0x0401CA3B RID: 117307
		public int CardLibraryNum;

		// Token: 0x0401CA3C RID: 117308
		private readonly Dictionary<PhantomBattleRoleStatus, int> BattleStatusMap = new Dictionary<PhantomBattleRoleStatus, int>();

		// Token: 0x0401CA3D RID: 117309
		private readonly Dictionary<PhantomBattleCardAttr, int> BattleAttrMap = new Dictionary<PhantomBattleCardAttr, int>();

		// Token: 0x0401CA3E RID: 117310
		private readonly Dictionary<int, PhantomCardData> HandCardMap = new Dictionary<int, PhantomCardData>();

		// Token: 0x0401CA3F RID: 117311
		private readonly List<int> HandCardIdList = new List<int>();

		// Token: 0x0401CA40 RID: 117312
		private readonly Dictionary<int, PhantomCardData> BattleCardMap = new Dictionary<int, PhantomCardData>();

		// Token: 0x0401CA41 RID: 117313
		private readonly Dictionary<int, PhantomCardData> SlotCardMap = new Dictionary<int, PhantomCardData>();

		// Token: 0x0401CA42 RID: 117314
		public PhantomArenaCardTaskData TaskData;

		// Token: 0x0401CA43 RID: 117315
		public PhantomArenaFieldData FieldData;

		// Token: 0x0401CA44 RID: 117316
		public PhantomArenaRecycleData RecycleData;

		// Token: 0x0401CA45 RID: 117317
		public int CanEvolveNum;

		// Token: 0x0401CA46 RID: 117318
		public bool CanShowFourCostView;

		// Token: 0x0401CA47 RID: 117319
		public int CoreCardId;

		// Token: 0x0401CA48 RID: 117320
		public int DiscardCardNum;

		// Token: 0x0401CA49 RID: 117321
		public int RequestCardId;

		// Token: 0x0401CA4A RID: 117322
		public bool IsFieldActive;

		// Token: 0x0401CA4B RID: 117323
		protected int PrevShowLifeInternal;
	}
}
