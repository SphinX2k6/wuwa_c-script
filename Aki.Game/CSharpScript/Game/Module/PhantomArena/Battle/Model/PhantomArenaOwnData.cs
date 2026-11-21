using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Model
{
	// Token: 0x0200426E RID: 17006
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaOwnData
	{
		// Token: 0x0602B0D8 RID: 176344 RVA: 0x00C1B2BD File Offset: 0x00C194BD
		private void SetBattleCardData(PhantomCardData cardData)
		{
			this.BattleCardMap[cardData.CardId] = cardData;
			this.SlotCardMap[cardData.Index] = cardData;
			EventSystem.Instance.Emit(EEventName.RefreshBattleCardNum);
		}

		// Token: 0x0602B0D9 RID: 176345 RVA: 0x00C1B2F4 File Offset: 0x00C194F4
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

		// Token: 0x0602B0DA RID: 176346 RVA: 0x00C1B370 File Offset: 0x00C19570
		private void AddHandCardData(PhantomBattleHandCardInfo dataInfo)
		{
			PhantomCardData phantomCardData = new PhantomCardData(false);
			phantomCardData.InitData(dataInfo);
			this.HandCardMap[phantomCardData.CardId] = phantomCardData;
			this.HandCardIdList.Add(phantomCardData.CardId);
		}

		// Token: 0x0602B0DB RID: 176347 RVA: 0x00C1B3B0 File Offset: 0x00C195B0
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

		// Token: 0x0602B0DC RID: 176348 RVA: 0x00C1B410 File Offset: 0x00C19610
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

		// Token: 0x0602B0DD RID: 176349 RVA: 0x00C1B49C File Offset: 0x00C1969C
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

		// Token: 0x0602B0DE RID: 176350 RVA: 0x00C1B52C File Offset: 0x00C1972C
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

		// Token: 0x0602B0DF RID: 176351 RVA: 0x00C1B5B8 File Offset: 0x00C197B8
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

		// Token: 0x0602B0E0 RID: 176352 RVA: 0x00C1B620 File Offset: 0x00C19820
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

		// Token: 0x0602B0E1 RID: 176353 RVA: 0x00C1B694 File Offset: 0x00C19894
		public void InitPlayerData(PhantomBattleGamerFighterInfoCtx data)
		{
			this.BattleStatusMap.Clear();
			this.BattleAttrMap.Clear();
			this.RoleId = data.CardRoleId;
			this.RefreshCardLibraryNum(data.CardLibraryNum);
			this.RefreshCanEvolveNum(data.CanEvolveNum);
			this.InitBattleStatus(new Dictionary<int, int>(data.BattleStatus));
			this.InitBattleAttr(new Dictionary<int, int>(data.BattleAttr));
		}

		// Token: 0x0602B0E2 RID: 176354 RVA: 0x00C1B700 File Offset: 0x00C19900
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

		// Token: 0x0602B0E3 RID: 176355 RVA: 0x00C1B774 File Offset: 0x00C19974
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

		// Token: 0x0602B0E4 RID: 176356 RVA: 0x00C1B7E8 File Offset: 0x00C199E8
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

		// Token: 0x0602B0E5 RID: 176357 RVA: 0x00C1B86C File Offset: 0x00C19A6C
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

		// Token: 0x0602B0E6 RID: 176358 RVA: 0x00C1B89C File Offset: 0x00C19A9C
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

		// Token: 0x0602B0E7 RID: 176359 RVA: 0x00C1B920 File Offset: 0x00C19B20
		public void RefreshCanEvolveNum(int canEvolveNum)
		{
			this.CanEvolveNum = canEvolveNum;
		}

		// Token: 0x0602B0E8 RID: 176360 RVA: 0x00C1B92C File Offset: 0x00C19B2C
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

		// Token: 0x0602B0E9 RID: 176361 RVA: 0x00C1B9F0 File Offset: 0x00C19BF0
		public int GetBattleStatusValue(PhantomBattleRoleStatus status)
		{
			if (!this.BattleStatusMap.ContainsKey(status))
			{
				return 0;
			}
			return this.BattleStatusMap[status];
		}

		// Token: 0x0602B0EA RID: 176362 RVA: 0x00C1BA0E File Offset: 0x00C19C0E
		public int GetBattleBattleAttr(PhantomBattleCardAttr attr)
		{
			if (!this.BattleAttrMap.ContainsKey(attr))
			{
				return 0;
			}
			return this.BattleAttrMap[attr];
		}

		// Token: 0x0602B0EB RID: 176363 RVA: 0x00C1BA2C File Offset: 0x00C19C2C
		public void HandCardToFightCard(PhantomCardData cardData, PhantomBattleFighterInfo data)
		{
			this.RemoveHandCardByCardId(cardData.CardId);
			cardData.RefreshFightData(data);
			this.SetBattleCardData(cardData);
		}

		// Token: 0x0602B0EC RID: 176364 RVA: 0x00C1BA48 File Offset: 0x00C19C48
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

		// Token: 0x0602B0ED RID: 176365 RVA: 0x00C1BAB0 File Offset: 0x00C19CB0
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

		// Token: 0x0602B0EE RID: 176366 RVA: 0x00C1BAF8 File Offset: 0x00C19CF8
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

		// Token: 0x0602B0EF RID: 176367 RVA: 0x00C1BB2C File Offset: 0x00C19D2C
		public void DestroyFightCard(int cardId)
		{
			if (!this.BattleCardMap.ContainsKey(cardId))
			{
				return;
			}
			PhantomCardData cardData = this.BattleCardMap[cardId];
			this.RemoveBattleCardData(cardData);
		}

		// Token: 0x0602B0F0 RID: 176368 RVA: 0x00C1BB60 File Offset: 0x00C19D60
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

		// Token: 0x0602B0F1 RID: 176369 RVA: 0x00C1BB98 File Offset: 0x00C19D98
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

		// Token: 0x0602B0F2 RID: 176370 RVA: 0x00C1BBFC File Offset: 0x00C19DFC
		public void RemoveHandCardListToRecycle(IEnumerable<int> cardIdList)
		{
			foreach (int cardId in cardIdList)
			{
				this.RemoveHandCardByCardId(cardId);
			}
		}

		// Token: 0x0602B0F3 RID: 176371 RVA: 0x00C1BC44 File Offset: 0x00C19E44
		public List<int> GetHandCardIdList()
		{
			return this.HandCardIdList;
		}

		// Token: 0x0602B0F4 RID: 176372 RVA: 0x00C1BC4C File Offset: 0x00C19E4C
		public PhantomCardData GetHandCardDataByCardId(int cardId)
		{
			if (!this.HandCardMap.ContainsKey(cardId))
			{
				return null;
			}
			return this.HandCardMap[cardId];
		}

		// Token: 0x0602B0F5 RID: 176373 RVA: 0x00C1BC6A File Offset: 0x00C19E6A
		public PhantomCardData GetBattleCardByCardId(int cardId)
		{
			if (!this.BattleCardMap.ContainsKey(cardId))
			{
				return null;
			}
			return this.BattleCardMap[cardId];
		}

		// Token: 0x0602B0F6 RID: 176374 RVA: 0x00C1BC88 File Offset: 0x00C19E88
		public bool HasBattleCardByCardId(int cardId)
		{
			return this.BattleCardMap.ContainsKey(cardId);
		}

		// Token: 0x0602B0F7 RID: 176375 RVA: 0x00C1BC96 File Offset: 0x00C19E96
		public List<PhantomCardData> GetBattleCardDataList()
		{
			return new List<PhantomCardData>(this.BattleCardMap.Values);
		}

		// Token: 0x0602B0F8 RID: 176376 RVA: 0x00C1BCA8 File Offset: 0x00C19EA8
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

		// Token: 0x0602B0F9 RID: 176377 RVA: 0x00C1BD20 File Offset: 0x00C19F20
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

		// Token: 0x0602B0FA RID: 176378 RVA: 0x00C1BECC File Offset: 0x00C1A0CC
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

		// Token: 0x0602B0FB RID: 176379 RVA: 0x00C1BF68 File Offset: 0x00C1A168
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

		// Token: 0x0602B0FC RID: 176380 RVA: 0x00C1BFD6 File Offset: 0x00C1A1D6
		public void HandCardToRecycle(int cardId)
		{
			this.RemoveHandCardByCardId(cardId);
		}

		// Token: 0x0602B0FD RID: 176381 RVA: 0x00C1BFE0 File Offset: 0x00C1A1E0
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

		// Token: 0x0602B0FE RID: 176382 RVA: 0x00C1C01C File Offset: 0x00C1A21C
		public void AddCardListToFight(PhantomBattleFighterInfo[] cardInfoList)
		{
			foreach (PhantomBattleFighterInfo data in cardInfoList)
			{
				PhantomCardData phantomCardData = new PhantomCardData(false);
				phantomCardData.RefreshFightData(data);
				this.SetBattleCardData(phantomCardData);
			}
		}

		// Token: 0x0602B0FF RID: 176383 RVA: 0x00C1C052 File Offset: 0x00C1A252
		public void CallCardListToFight(PhantomBattleFighterInfo[] cardInfoList, PhantomBattleSelectedCardFromType type)
		{
			if (type == PhantomBattleSelectedCardFromType.Heap)
			{
				this.AddCardListToFight(cardInfoList);
				return;
			}
			this.CallHandCardListToFight(cardInfoList);
		}

		// Token: 0x0602B100 RID: 176384 RVA: 0x00C1C068 File Offset: 0x00C1A268
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

		// Token: 0x0602B101 RID: 176385 RVA: 0x00C1C0D1 File Offset: 0x00C1A2D1
		public void RefreshCardLibraryNum(int num)
		{
			this.CardLibraryNum = num;
			EventSystem.Instance.Emit(EEventName.OwnCardLibraryChange);
		}

		// Token: 0x0602B102 RID: 176386 RVA: 0x00C1C0EC File Offset: 0x00C1A2EC
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

		// Token: 0x0602B103 RID: 176387 RVA: 0x00C1C164 File Offset: 0x00C1A364
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

		// Token: 0x1700568F RID: 22159
		// (get) Token: 0x0602B104 RID: 176388 RVA: 0x00C1C1C8 File Offset: 0x00C1A3C8
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

		// Token: 0x0602B105 RID: 176389 RVA: 0x00C1C228 File Offset: 0x00C1A428
		public void ClearHandData()
		{
			this.HandCardMap.Clear();
			this.HandCardIdList.Clear();
		}

		// Token: 0x0602B106 RID: 176390 RVA: 0x00C1C240 File Offset: 0x00C1A440
		public void InitTaskData(PhantomBattleGamerFourCTaskInfo data)
		{
			this.TaskData = new PhantomArenaCardTaskData(true);
			this.TaskData.SetTaskData(data);
		}

		// Token: 0x0602B107 RID: 176391 RVA: 0x00C1C25C File Offset: 0x00C1A45C
		public void RefreshTaskData(PhantomBattleGamerFourCTaskInfo data)
		{
			if (this.TaskData != null)
			{
				this.TaskData.SetTaskData(data);
				return;
			}
			Log.Instance.Error(ELogModule.PhantomArena, ELogAuthor.XXJ, "任务数据为空", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x0602B108 RID: 176392 RVA: 0x00C1C29D File Offset: 0x00C1A49D
		public void InitFieldData()
		{
			this.FieldData = new PhantomArenaFieldData();
		}

		// Token: 0x0602B109 RID: 176393 RVA: 0x00C1C2AA File Offset: 0x00C1A4AA
		public void RefreshFieldLockData(int remainRound)
		{
			if (this.FieldData != null)
			{
				this.FieldData.SetSealRemainRound(remainRound);
			}
		}

		// Token: 0x0602B10A RID: 176394 RVA: 0x00C1C2C0 File Offset: 0x00C1A4C0
		public void InitRecycleData()
		{
			this.RecycleData = new PhantomArenaRecycleData();
		}

		// Token: 0x0602B10B RID: 176395 RVA: 0x00C1C2CD File Offset: 0x00C1A4CD
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

		// Token: 0x17005690 RID: 22160
		// (get) Token: 0x0602B10C RID: 176396 RVA: 0x00C1C2F7 File Offset: 0x00C1A4F7
		public bool RecycleIsInSeal
		{
			get
			{
				PhantomArenaRecycleData recycleData = this.RecycleData;
				return recycleData != null && recycleData.IsSeal;
			}
		}

		// Token: 0x0602B10D RID: 176397 RVA: 0x00C1C30A File Offset: 0x00C1A50A
		public int GetHandIndexByCardId(int cardId)
		{
			return this.HandCardIdList.IndexOf(cardId);
		}

		// Token: 0x0602B10E RID: 176398 RVA: 0x00C1C318 File Offset: 0x00C1A518
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

		// Token: 0x0602B10F RID: 176399 RVA: 0x00C1C378 File Offset: 0x00C1A578
		public void SetPrevShowLife(int value)
		{
			this.PrevShowLifeInternal = value;
		}

		// Token: 0x17005691 RID: 22161
		// (get) Token: 0x0602B110 RID: 176400 RVA: 0x00C1C381 File Offset: 0x00C1A581
		public int PrevShowLife
		{
			get
			{
				return this.PrevShowLifeInternal;
			}
		}

		// Token: 0x0401746E RID: 95342
		public int RoleId;

		// Token: 0x0401746F RID: 95343
		public int FightId;

		// Token: 0x04017470 RID: 95344
		public int CardLibraryNum;

		// Token: 0x04017471 RID: 95345
		private readonly Dictionary<PhantomBattleRoleStatus, int> BattleStatusMap = new Dictionary<PhantomBattleRoleStatus, int>();

		// Token: 0x04017472 RID: 95346
		private readonly Dictionary<PhantomBattleCardAttr, int> BattleAttrMap = new Dictionary<PhantomBattleCardAttr, int>();

		// Token: 0x04017473 RID: 95347
		private readonly Dictionary<int, PhantomCardData> HandCardMap = new Dictionary<int, PhantomCardData>();

		// Token: 0x04017474 RID: 95348
		private readonly List<int> HandCardIdList = new List<int>();

		// Token: 0x04017475 RID: 95349
		private readonly Dictionary<int, PhantomCardData> BattleCardMap = new Dictionary<int, PhantomCardData>();

		// Token: 0x04017476 RID: 95350
		private readonly Dictionary<int, PhantomCardData> SlotCardMap = new Dictionary<int, PhantomCardData>();

		// Token: 0x04017477 RID: 95351
		public PhantomArenaCardTaskData TaskData;

		// Token: 0x04017478 RID: 95352
		public PhantomArenaFieldData FieldData;

		// Token: 0x04017479 RID: 95353
		public PhantomArenaRecycleData RecycleData;

		// Token: 0x0401747A RID: 95354
		public int CanEvolveNum;

		// Token: 0x0401747B RID: 95355
		public bool CanShowFourCostView;

		// Token: 0x0401747C RID: 95356
		public int CoreCardId;

		// Token: 0x0401747D RID: 95357
		public int DiscardCardNum;

		// Token: 0x0401747E RID: 95358
		public int RequestCardId;

		// Token: 0x0401747F RID: 95359
		public bool IsFieldActive;

		// Token: 0x04017480 RID: 95360
		protected int PrevShowLifeInternal;
	}
}
