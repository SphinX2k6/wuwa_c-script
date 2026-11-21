using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder
{
	// Token: 0x02004177 RID: 16759
	[NullableContext(1)]
	[Nullable(0)]
	public class DeckInfo
	{
		// Token: 0x0602A6A0 RID: 173728 RVA: 0x00BF6224 File Offset: 0x00BF4424
		public unsafe DeckInfo DeepCopy()
		{
			DeckInfo deckInfo = new DeckInfo();
			deckInfo.DeckServerId = this.DeckServerId;
			deckInfo.DeckConfigId = this.DeckConfigId;
			deckInfo.DeckName = this.DeckName;
			deckInfo.CanUse = this.CanUse;
			deckInfo.FieldCardSkillUnlockInfo = this.FieldCardSkillUnlockInfo;
			deckInfo.NormalCardCountLimit = this.NormalCardCountLimit;
			deckInfo.CoreCardCountLimit = this.CoreCardCountLimit;
			deckInfo.FieldCardCountLimit = this.FieldCardCountLimit;
			deckInfo.ItemCardCountLimit = this.ItemCardCountLimit;
			deckInfo.ElementCountLimit = this.ElementCountLimit;
			deckInfo.CoreCardSlotLocked = this.CoreCardSlotLocked;
			deckInfo.CoreCost = this.CoreCost;
			foreach (KeyValuePair<int, int> keyValuePair in this.CostToMaxCardLimitMap)
			{
				deckInfo.CostToMaxCardLimitMap[keyValuePair.Key] = keyValuePair.Value;
			}
			foreach (DeckCardSlotInfo deckCardSlotInfo in this.CardSlotList)
			{
				EAddCardResult eaddCardResult = deckInfo.AddCard(new AddCardContext
				{
					CardId = deckCardSlotInfo.CardId,
					Cost = deckCardSlotInfo.Cost,
					Element = deckCardSlotInfo.Element,
					MaxCount = deckCardSlotInfo.Count,
					AddCount = deckCardSlotInfo.Count,
					CardType = deckCardSlotInfo.CardType
				});
				if (eaddCardResult != EAddCardResult.Success)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.PhantomArena;
					ELogAuthor author = ELogAuthor.LZK;
					string message = "卡组信息深拷贝失败";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Result", eaddCardResult);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("CardId", deckCardSlotInfo.CardId);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
			}
			return deckInfo;
		}

		// Token: 0x0602A6A1 RID: 173729 RVA: 0x00BF642C File Offset: 0x00BF462C
		public EAddCardResult CheckCanAddCard(AddCardContext context)
		{
			int addCount = context.AddCount;
			if (addCount == 0)
			{
				return EAddCardResult.AddCountZero;
			}
			bool flag = context.Cost == this.CoreCost;
			if (flag && this.CoreCardSlotLocked)
			{
				return EAddCardResult.CoreSlotLocked;
			}
			if (flag && addCount + this.CoreCardCount > this.CoreCardCountLimit)
			{
				return EAddCardResult.TotalCoreCardCountLimit;
			}
			bool flag2 = context.CardType == ECardType.Field;
			if (flag2 && addCount + this.FieldCardCount > this.FieldCardCountLimit)
			{
				return EAddCardResult.TotalFieldCardCountLimit;
			}
			if (context.CardType == ECardType.Item && addCount + this.ItemCardCount > this.ItemCardCountLimit)
			{
				return EAddCardResult.TotalItemCardCountLimit;
			}
			if (!flag && !flag2 && addCount + this.NormalCardCount > this.NormalCardCountLimit)
			{
				return EAddCardResult.TotalNormalCardCountLimit;
			}
			if (!this.CheckCanAddElement((ECardElement)context.Element))
			{
				return EAddCardResult.ElementLimit;
			}
			DeckCardSlotInfo deckCardSlotInfo;
			this.CardSlotMap.TryGetValue(context.CardId, out deckCardSlotInfo);
			int num = (deckCardSlotInfo != null) ? deckCardSlotInfo.Count : 0;
			int maxCount = context.MaxCount;
			if (num + addCount > maxCount)
			{
				if (!flag)
				{
					return EAddCardResult.NormalCardSlotLimit;
				}
				return EAddCardResult.CoreCardSlotLimit;
			}
			else
			{
				int cardMaxLimitByCost = this.GetCardMaxLimitByCost(context.Cost);
				int cardCountByCost = this.GetCardCountByCost(context.Cost);
				if (cardMaxLimitByCost <= 0 || cardCountByCost + addCount <= cardMaxLimitByCost)
				{
					return EAddCardResult.Success;
				}
				if (context.Cost != 3)
				{
					return EAddCardResult.CardMaxLimitByCost1;
				}
				return EAddCardResult.CardMaxLimitByCost3;
			}
		}

		// Token: 0x0602A6A2 RID: 173730 RVA: 0x00BF654C File Offset: 0x00BF474C
		public EAddCardResult AddCard(AddCardContext context)
		{
			EAddCardResult eaddCardResult = this.CheckCanAddCard(context);
			if (eaddCardResult != EAddCardResult.Success)
			{
				return eaddCardResult;
			}
			int addCount = context.AddCount;
			bool flag = context.Cost == this.CoreCost;
			bool flag2 = context.CardType == ECardType.Field;
			bool flag3 = context.CardType == ECardType.Item;
			DeckCardSlotInfo deckCardSlotInfo;
			this.CardSlotMap.TryGetValue(context.CardId, out deckCardSlotInfo);
			if (deckCardSlotInfo != null)
			{
				deckCardSlotInfo.Count += addCount;
			}
			else
			{
				int cardId = context.CardId;
				deckCardSlotInfo = new DeckCardSlotInfo
				{
					CardId = cardId,
					Cost = context.Cost,
					Count = addCount,
					Element = context.Element,
					CardType = context.CardType
				};
				this.CardSlotMap[cardId] = deckCardSlotInfo;
				this.CardSlotList.Add(deckCardSlotInfo);
				if (flag)
				{
					this.CoreCardSlot = deckCardSlotInfo;
				}
				else if (flag2)
				{
					this.FieldCardSlot = deckCardSlotInfo;
				}
				else
				{
					this.NormalCardSlotList.Add(deckCardSlotInfo);
				}
				if (context.Element != 0)
				{
					List<DeckCardSlotInfo> list;
					if (!this.ElementToSlotsMap.TryGetValue((ECardElement)context.Element, out list))
					{
						list = new List<DeckCardSlotInfo>();
						this.ElementToSlotsMap[(ECardElement)context.Element] = list;
					}
					list.Add(deckCardSlotInfo);
				}
			}
			if (flag)
			{
				this.CoreCardCount += addCount;
			}
			else if (flag2)
			{
				this.FieldCardCount += addCount;
			}
			else if (flag3)
			{
				this.ItemCardCount += addCount;
				this.NormalCardCount += addCount;
			}
			else
			{
				this.NormalCardCount += addCount;
			}
			int num;
			this.CostToCardCountMap.TryGetValue(context.Cost, out num);
			this.CostToCardCountMap[context.Cost] = num + addCount;
			this.TotalCardCount += addCount;
			return eaddCardResult;
		}

		// Token: 0x0602A6A3 RID: 173731 RVA: 0x00BF6710 File Offset: 0x00BF4910
		public bool RemoveCard(RemoveCardContext context)
		{
			int cardId = context.CardId;
			int removeCount = context.RemoveCount;
			DeckCardSlotInfo deckCardSlotInfo;
			this.CardSlotMap.TryGetValue(cardId, out deckCardSlotInfo);
			if (deckCardSlotInfo == null || deckCardSlotInfo.Count < removeCount)
			{
				return false;
			}
			bool flag = deckCardSlotInfo.Cost == this.CoreCost;
			bool flag2 = deckCardSlotInfo.CardType == ECardType.Field;
			bool flag3 = deckCardSlotInfo.CardType == ECardType.Item;
			deckCardSlotInfo.Count -= removeCount;
			if (deckCardSlotInfo.Count == 0)
			{
				this.CardSlotMap.Remove(cardId);
				this.CardSlotList.Remove(deckCardSlotInfo);
				if (flag)
				{
					this.CoreCardSlot = null;
				}
				else if (flag2)
				{
					this.FieldCardSlot = null;
				}
				else
				{
					this.NormalCardSlotList.Remove(deckCardSlotInfo);
				}
				ECardElement element = (ECardElement)deckCardSlotInfo.Element;
				List<DeckCardSlotInfo> list;
				if (this.ElementToSlotsMap.TryGetValue(element, out list))
				{
					list.Remove(deckCardSlotInfo);
					if (list.Count == 0)
					{
						this.ElementToSlotsMap.Remove(element);
					}
				}
			}
			if (flag)
			{
				this.CoreCardCount -= removeCount;
			}
			else if (flag2)
			{
				this.FieldCardCount -= removeCount;
			}
			else if (flag3)
			{
				this.ItemCardCount -= removeCount;
				this.NormalCardCount -= removeCount;
			}
			else
			{
				this.NormalCardCount -= removeCount;
			}
			int num;
			this.CostToCardCountMap.TryGetValue(deckCardSlotInfo.Cost, out num);
			this.CostToCardCountMap[deckCardSlotInfo.Cost] = num - removeCount;
			this.TotalCardCount -= removeCount;
			return true;
		}

		// Token: 0x0602A6A4 RID: 173732 RVA: 0x00BF688C File Offset: 0x00BF4A8C
		public bool RemoveAllCard()
		{
			if (this.TotalCardCount == 0)
			{
				return false;
			}
			this.CardSlotMap.Clear();
			this.CardSlotList.Clear();
			this.ElementToSlotsMap.Clear();
			this.NormalCardSlotList.Clear();
			this.CoreCardSlot = null;
			this.FieldCardSlot = null;
			this.CoreCardCount = 0;
			this.FieldCardCount = 0;
			this.ItemCardCount = 0;
			this.NormalCardCount = 0;
			this.TotalCardCount = 0;
			this.CostToCardCountMap.Clear();
			return true;
		}

		// Token: 0x0602A6A5 RID: 173733 RVA: 0x00BF690C File Offset: 0x00BF4B0C
		public bool RemoveCardByElements(HashSet<ECardElement> elements)
		{
			List<RemoveCardContext> list = new List<RemoveCardContext>();
			foreach (DeckCardSlotInfo deckCardSlotInfo in this.CardSlotList)
			{
				if (elements.Contains((ECardElement)deckCardSlotInfo.Element))
				{
					RemoveCardContext item = new RemoveCardContext
					{
						CardId = deckCardSlotInfo.CardId,
						RemoveCount = deckCardSlotInfo.Count
					};
					list.Add(item);
				}
			}
			bool flag = list.Count > 0;
			foreach (RemoveCardContext context in list)
			{
				flag = (flag && this.RemoveCard(context));
			}
			return flag;
		}

		// Token: 0x0602A6A6 RID: 173734 RVA: 0x00BF69E8 File Offset: 0x00BF4BE8
		public int GetCardCount(int cardId)
		{
			DeckCardSlotInfo deckCardSlotInfo;
			this.CardSlotMap.TryGetValue(cardId, out deckCardSlotInfo);
			if (deckCardSlotInfo == null)
			{
				return 0;
			}
			return deckCardSlotInfo.Count;
		}

		// Token: 0x0602A6A7 RID: 173735 RVA: 0x00BF6A0F File Offset: 0x00BF4C0F
		[NullableContext(2)]
		public DeckCardSlotInfo GetCoreCardSlot()
		{
			return this.CoreCardSlot;
		}

		// Token: 0x0602A6A8 RID: 173736 RVA: 0x00BF6A17 File Offset: 0x00BF4C17
		[NullableContext(2)]
		public DeckCardSlotInfo GetFieldCardSlot()
		{
			return this.FieldCardSlot;
		}

		// Token: 0x0602A6A9 RID: 173737 RVA: 0x00BF6A1F File Offset: 0x00BF4C1F
		public IReadOnlyList<DeckCardSlotInfo> GetNormalCardSlotList()
		{
			return this.NormalCardSlotList;
		}

		// Token: 0x0602A6AA RID: 173738 RVA: 0x00BF6A27 File Offset: 0x00BF4C27
		public void SetName(string newName)
		{
			this.DeckName = newName;
		}

		// Token: 0x0602A6AB RID: 173739 RVA: 0x00BF6A30 File Offset: 0x00BF4C30
		public string GetName()
		{
			return this.DeckName;
		}

		// Token: 0x0602A6AC RID: 173740 RVA: 0x00BF6A38 File Offset: 0x00BF4C38
		public int GetTotalCardCountLimit()
		{
			return this.NormalCardCountLimit + this.CoreCardCountLimit + this.FieldCardCountLimit;
		}

		// Token: 0x0602A6AD RID: 173741 RVA: 0x00BF6A4E File Offset: 0x00BF4C4E
		public void SetNormalCardCountLimit(int newLimit)
		{
			if (newLimit < this.NormalCardCount)
			{
				return;
			}
			this.NormalCardCountLimit = newLimit;
		}

		// Token: 0x0602A6AE RID: 173742 RVA: 0x00BF6A61 File Offset: 0x00BF4C61
		public int GetNormalCardCountLimit()
		{
			return this.NormalCardCountLimit;
		}

		// Token: 0x0602A6AF RID: 173743 RVA: 0x00BF6A69 File Offset: 0x00BF4C69
		public void SetCoreCardCountLimit(int newLimit)
		{
			if (newLimit < this.CoreCardCount)
			{
				return;
			}
			this.CoreCardCountLimit = newLimit;
		}

		// Token: 0x0602A6B0 RID: 173744 RVA: 0x00BF6A7C File Offset: 0x00BF4C7C
		public int GetCoreCardCountLimit()
		{
			return this.CoreCardCountLimit;
		}

		// Token: 0x0602A6B1 RID: 173745 RVA: 0x00BF6A84 File Offset: 0x00BF4C84
		public void SetFieldCardCountLimit(int newLimit)
		{
			if (newLimit < this.FieldCardCount)
			{
				return;
			}
			this.FieldCardCountLimit = newLimit;
		}

		// Token: 0x0602A6B2 RID: 173746 RVA: 0x00BF6A97 File Offset: 0x00BF4C97
		public int GetFieldCardCountLimit()
		{
			return this.FieldCardCountLimit;
		}

		// Token: 0x0602A6B3 RID: 173747 RVA: 0x00BF6A9F File Offset: 0x00BF4C9F
		public void SetItemCardCountLimit(int newLimit)
		{
			if (newLimit < this.ItemCardCount)
			{
				return;
			}
			this.ItemCardCountLimit = newLimit;
		}

		// Token: 0x0602A6B4 RID: 173748 RVA: 0x00BF6AB2 File Offset: 0x00BF4CB2
		public int GetItemCardCountLimit()
		{
			return this.ItemCardCountLimit;
		}

		// Token: 0x0602A6B5 RID: 173749 RVA: 0x00BF6ABA File Offset: 0x00BF4CBA
		public void SetElementCountLimit(int newLimit)
		{
			if (newLimit < this.ElementCountLimit)
			{
				return;
			}
			this.ElementCountLimit = newLimit;
		}

		// Token: 0x0602A6B6 RID: 173750 RVA: 0x00BF6ACD File Offset: 0x00BF4CCD
		public int GetElementCountLimit()
		{
			return this.ElementCountLimit;
		}

		// Token: 0x0602A6B7 RID: 173751 RVA: 0x00BF6AD5 File Offset: 0x00BF4CD5
		public void SetIsCoreCardSlotLocked(bool isLocked)
		{
			this.CoreCardSlotLocked = isLocked;
		}

		// Token: 0x0602A6B8 RID: 173752 RVA: 0x00BF6ADE File Offset: 0x00BF4CDE
		public bool IsCoreCardSlotLocked()
		{
			return this.CoreCardSlotLocked;
		}

		// Token: 0x0602A6B9 RID: 173753 RVA: 0x00BF6AE8 File Offset: 0x00BF4CE8
		public void SetCostToMaxCardLimitMap(Dictionary<int, int> costToMaxCardLimitMap)
		{
			foreach (KeyValuePair<int, int> keyValuePair in costToMaxCardLimitMap)
			{
				this.CostToMaxCardLimitMap[keyValuePair.Key] = keyValuePair.Value;
			}
		}

		// Token: 0x0602A6BA RID: 173754 RVA: 0x00BF6B48 File Offset: 0x00BF4D48
		public Dictionary<int, int> GetCostToMaxCardLimitMap()
		{
			return this.CostToMaxCardLimitMap;
		}

		// Token: 0x0602A6BB RID: 173755 RVA: 0x00BF6B50 File Offset: 0x00BF4D50
		public int GetCardMaxLimitByCost(int cost)
		{
			int result;
			this.CostToMaxCardLimitMap.TryGetValue(cost, out result);
			return result;
		}

		// Token: 0x0602A6BC RID: 173756 RVA: 0x00BF6B6D File Offset: 0x00BF4D6D
		public List<DeckCardSlotInfo> GetCardSlotList()
		{
			return this.CardSlotList;
		}

		// Token: 0x0602A6BD RID: 173757 RVA: 0x00BF6B75 File Offset: 0x00BF4D75
		public int GetTotalCardCount()
		{
			return this.TotalCardCount;
		}

		// Token: 0x0602A6BE RID: 173758 RVA: 0x00BF6B7D File Offset: 0x00BF4D7D
		public int GetCoreCardCount()
		{
			return this.CoreCardCount;
		}

		// Token: 0x0602A6BF RID: 173759 RVA: 0x00BF6B85 File Offset: 0x00BF4D85
		public int GetFieldCardCount()
		{
			return this.FieldCardCount;
		}

		// Token: 0x0602A6C0 RID: 173760 RVA: 0x00BF6B8D File Offset: 0x00BF4D8D
		public int GetNormalCardCount()
		{
			return this.NormalCardCount;
		}

		// Token: 0x0602A6C1 RID: 173761 RVA: 0x00BF6B98 File Offset: 0x00BF4D98
		public List<ECardElement> GetElementList()
		{
			List<ECardElement> list = new List<ECardElement>();
			foreach (KeyValuePair<ECardElement, List<DeckCardSlotInfo>> keyValuePair in this.ElementToSlotsMap)
			{
				if (keyValuePair.Value.Count > 0)
				{
					list.Add(keyValuePair.Key);
				}
			}
			return list;
		}

		// Token: 0x0602A6C2 RID: 173762 RVA: 0x00BF6C08 File Offset: 0x00BF4E08
		public HashSet<ECardElement> GetElementSetWithPhysical()
		{
			HashSet<ECardElement> hashSet = new HashSet<ECardElement>();
			foreach (DeckCardSlotInfo deckCardSlotInfo in this.CardSlotList)
			{
				hashSet.Add((ECardElement)deckCardSlotInfo.Element);
			}
			return hashSet;
		}

		// Token: 0x0602A6C3 RID: 173763 RVA: 0x00BF6C68 File Offset: 0x00BF4E68
		public List<ECardElement> GetCoreElementList()
		{
			List<ECardElement> list = new List<ECardElement>();
			if (this.CoreCardSlot != null && this.CoreCardSlot.Element != 0)
			{
				list.Add((ECardElement)this.CoreCardSlot.Element);
			}
			return list;
		}

		// Token: 0x0602A6C4 RID: 173764 RVA: 0x00BF6CA2 File Offset: 0x00BF4EA2
		public bool CanDeckBeUsed()
		{
			return this.IsDeckFull() && this.CanUse;
		}

		// Token: 0x0602A6C5 RID: 173765 RVA: 0x00BF6CB4 File Offset: 0x00BF4EB4
		public bool IsDeckFull()
		{
			return (this.CoreCardSlotLocked && this.NormalCardCount == this.NormalCardCountLimit) || (!this.CoreCardSlotLocked && this.TotalCardCount == this.GetTotalCardCountLimit());
		}

		// Token: 0x0602A6C6 RID: 173766 RVA: 0x00BF6CE6 File Offset: 0x00BF4EE6
		public string GetDeckName()
		{
			return this.DeckName;
		}

		// Token: 0x0602A6C7 RID: 173767 RVA: 0x00BF6CEE File Offset: 0x00BF4EEE
		public void SetDeckName(string newName)
		{
			this.DeckName = newName;
		}

		// Token: 0x0602A6C8 RID: 173768 RVA: 0x00BF6CF7 File Offset: 0x00BF4EF7
		public bool GetCanUse()
		{
			return this.CanUse;
		}

		// Token: 0x0602A6C9 RID: 173769 RVA: 0x00BF6CFF File Offset: 0x00BF4EFF
		public void SetCanUse(bool canUse)
		{
			this.CanUse = canUse;
		}

		// Token: 0x0602A6CA RID: 173770 RVA: 0x00BF6D08 File Offset: 0x00BF4F08
		public int GetCoreCost()
		{
			return this.CoreCost;
		}

		// Token: 0x0602A6CB RID: 173771 RVA: 0x00BF6D10 File Offset: 0x00BF4F10
		public void SetCoreCost(int coreCost)
		{
			this.CoreCost = coreCost;
		}

		// Token: 0x0602A6CC RID: 173772 RVA: 0x00BF6D19 File Offset: 0x00BF4F19
		public void SetDeckServerId(int newDeckServerId)
		{
			this.DeckServerId = newDeckServerId;
		}

		// Token: 0x0602A6CD RID: 173773 RVA: 0x00BF6D22 File Offset: 0x00BF4F22
		public int GetDeckServerId()
		{
			return this.DeckServerId;
		}

		// Token: 0x0602A6CE RID: 173774 RVA: 0x00BF6D2A File Offset: 0x00BF4F2A
		public void SetDeckConfigId(int newDeckConfigId)
		{
			this.DeckConfigId = newDeckConfigId;
		}

		// Token: 0x0602A6CF RID: 173775 RVA: 0x00BF6D33 File Offset: 0x00BF4F33
		public int GetDeckConfigId()
		{
			return this.DeckConfigId;
		}

		// Token: 0x0602A6D0 RID: 173776 RVA: 0x00BF6D3B File Offset: 0x00BF4F3B
		public void SetFieldCardSkillUnlockInfo(PhantomBattleCardSkillUnlockInfo info)
		{
			this.FieldCardSkillUnlockInfo = info;
		}

		// Token: 0x0602A6D1 RID: 173777 RVA: 0x00BF6D44 File Offset: 0x00BF4F44
		[NullableContext(2)]
		public PhantomBattleCardSkillUnlockInfo GetFieldCardSkillUnlockInfo()
		{
			return this.FieldCardSkillUnlockInfo;
		}

		// Token: 0x0602A6D2 RID: 173778 RVA: 0x00BF6D4C File Offset: 0x00BF4F4C
		public List<int> CoverToCardIdList()
		{
			List<int> list = new List<int>();
			foreach (DeckCardSlotInfo deckCardSlotInfo in this.CardSlotList)
			{
				for (int i = 0; i < deckCardSlotInfo.Count; i++)
				{
					list.Add(deckCardSlotInfo.CardId);
				}
			}
			return list;
		}

		// Token: 0x0602A6D3 RID: 173779 RVA: 0x00BF6DBC File Offset: 0x00BF4FBC
		public int GetDeckFaceCardId()
		{
			if (this.CoreCardSlot != null)
			{
				return this.CoreCardSlot.CardId;
			}
			if (this.NormalCardSlotList.Count > 0)
			{
				List<DeckCardSlotInfo> list = new List<DeckCardSlotInfo>(this.NormalCardSlotList);
				list.Sort((DeckCardSlotInfo a, DeckCardSlotInfo b) => PhantomArenaDefine.deckCardSlotDefaultSortFunc(a, b));
				return list[0].CardId;
			}
			return 0;
		}

		// Token: 0x0602A6D4 RID: 173780 RVA: 0x00BF6E28 File Offset: 0x00BF5028
		public DeckRecordInfo Record()
		{
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			foreach (DeckCardSlotInfo deckCardSlotInfo in this.CardSlotList)
			{
				dictionary[deckCardSlotInfo.CardId] = deckCardSlotInfo.Count;
			}
			return new DeckRecordInfo
			{
				CardMap = dictionary
			};
		}

		// Token: 0x0602A6D5 RID: 173781 RVA: 0x00BF6E98 File Offset: 0x00BF5098
		public bool CheckDeckDifferent(DeckRecordInfo deckInfo)
		{
			if (this.CardSlotList.Count != deckInfo.CardMap.Count)
			{
				return true;
			}
			foreach (DeckCardSlotInfo deckCardSlotInfo in this.CardSlotList)
			{
				int num;
				deckInfo.CardMap.TryGetValue(deckCardSlotInfo.CardId, out num);
				if (num != deckCardSlotInfo.Count)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0602A6D6 RID: 173782 RVA: 0x00BF6F24 File Offset: 0x00BF5124
		public bool CheckCanAddElement(ECardElement element)
		{
			return element == ECardElement.Physical || this.ElementToSlotsMap.ContainsKey(element) || this.ElementToSlotsMap.Count < this.ElementCountLimit;
		}

		// Token: 0x0602A6D7 RID: 173783 RVA: 0x00BF6F51 File Offset: 0x00BF5151
		public bool IsElementFull()
		{
			return this.ElementToSlotsMap.Count >= this.ElementCountLimit;
		}

		// Token: 0x0602A6D8 RID: 173784 RVA: 0x00BF6F6C File Offset: 0x00BF516C
		public int GetCardCountByCost(int cost)
		{
			int result;
			this.CostToCardCountMap.TryGetValue(cost, out result);
			return result;
		}

		// Token: 0x0602A6D9 RID: 173785 RVA: 0x00BF6F8C File Offset: 0x00BF518C
		public List<int> GetCardIdList()
		{
			List<int> list = new List<int>();
			foreach (DeckCardSlotInfo deckCardSlotInfo in this.CardSlotMap.Values)
			{
				for (int i = 0; i < deckCardSlotInfo.Count; i++)
				{
					list.Add(deckCardSlotInfo.CardId);
				}
			}
			return list;
		}

		// Token: 0x0602A6DA RID: 173786 RVA: 0x00BF7004 File Offset: 0x00BF5204
		public void SetFieldCardConditionProgress(int curNum, int targetNum)
		{
			this.FieldCardConditionCurNum = curNum;
			this.FieldCardConditionTargetNum = targetNum;
		}

		// Token: 0x0602A6DB RID: 173787 RVA: 0x00BF7014 File Offset: 0x00BF5214
		public int GetFieldCardConditionCurNum()
		{
			return this.FieldCardConditionCurNum;
		}

		// Token: 0x0602A6DC RID: 173788 RVA: 0x00BF701C File Offset: 0x00BF521C
		public int GetFieldCardConditionTargetNum()
		{
			return this.FieldCardConditionTargetNum;
		}

		// Token: 0x040170AE RID: 94382
		private int DeckServerId = -1;

		// Token: 0x040170AF RID: 94383
		private int DeckConfigId = -1;

		// Token: 0x040170B0 RID: 94384
		private string DeckName = string.Empty;

		// Token: 0x040170B1 RID: 94385
		private bool CanUse;

		// Token: 0x040170B2 RID: 94386
		private int CoreCost;

		// Token: 0x040170B3 RID: 94387
		[Nullable(2)]
		private PhantomBattleCardSkillUnlockInfo FieldCardSkillUnlockInfo;

		// Token: 0x040170B4 RID: 94388
		private readonly List<DeckCardSlotInfo> CardSlotList = new List<DeckCardSlotInfo>();

		// Token: 0x040170B5 RID: 94389
		private readonly Dictionary<int, DeckCardSlotInfo> CardSlotMap = new Dictionary<int, DeckCardSlotInfo>();

		// Token: 0x040170B6 RID: 94390
		private readonly Dictionary<ECardElement, List<DeckCardSlotInfo>> ElementToSlotsMap = new Dictionary<ECardElement, List<DeckCardSlotInfo>>();

		// Token: 0x040170B7 RID: 94391
		private readonly Dictionary<int, int> CostToCardCountMap = new Dictionary<int, int>();

		// Token: 0x040170B8 RID: 94392
		private readonly List<DeckCardSlotInfo> NormalCardSlotList = new List<DeckCardSlotInfo>();

		// Token: 0x040170B9 RID: 94393
		[Nullable(2)]
		private DeckCardSlotInfo CoreCardSlot;

		// Token: 0x040170BA RID: 94394
		[Nullable(2)]
		private DeckCardSlotInfo FieldCardSlot;

		// Token: 0x040170BB RID: 94395
		private readonly Dictionary<int, int> CostToMaxCardLimitMap = new Dictionary<int, int>();

		// Token: 0x040170BC RID: 94396
		private int CoreCardCount;

		// Token: 0x040170BD RID: 94397
		private int FieldCardCount;

		// Token: 0x040170BE RID: 94398
		private int ItemCardCount;

		// Token: 0x040170BF RID: 94399
		private int NormalCardCount;

		// Token: 0x040170C0 RID: 94400
		private int TotalCardCount;

		// Token: 0x040170C1 RID: 94401
		private int NormalCardCountLimit;

		// Token: 0x040170C2 RID: 94402
		private int CoreCardCountLimit;

		// Token: 0x040170C3 RID: 94403
		private int FieldCardCountLimit;

		// Token: 0x040170C4 RID: 94404
		private int ItemCardCountLimit;

		// Token: 0x040170C5 RID: 94405
		private int ElementCountLimit;

		// Token: 0x040170C6 RID: 94406
		private bool CoreCardSlotLocked;

		// Token: 0x040170C7 RID: 94407
		private int FieldCardConditionCurNum;

		// Token: 0x040170C8 RID: 94408
		private int FieldCardConditionTargetNum;
	}
}
