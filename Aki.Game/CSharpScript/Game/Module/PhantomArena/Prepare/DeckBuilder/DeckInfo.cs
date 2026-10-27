using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder
{
	// Token: 0x020051A7 RID: 20903
	[NullableContext(1)]
	[Nullable(0)]
	public class DeckInfo
	{
		// Token: 0x060357A5 RID: 219045 RVA: 0x00CA8BEC File Offset: 0x00CA6DEC
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

		// Token: 0x060357A6 RID: 219046 RVA: 0x00CA8DF4 File Offset: 0x00CA6FF4
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

		// Token: 0x060357A7 RID: 219047 RVA: 0x00CA8F14 File Offset: 0x00CA7114
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

		// Token: 0x060357A8 RID: 219048 RVA: 0x00CA90D8 File Offset: 0x00CA72D8
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

		// Token: 0x060357A9 RID: 219049 RVA: 0x00CA9254 File Offset: 0x00CA7454
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

		// Token: 0x060357AA RID: 219050 RVA: 0x00CA92D4 File Offset: 0x00CA74D4
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

		// Token: 0x060357AB RID: 219051 RVA: 0x00CA93B0 File Offset: 0x00CA75B0
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

		// Token: 0x060357AC RID: 219052 RVA: 0x00CA93D7 File Offset: 0x00CA75D7
		[NullableContext(2)]
		public DeckCardSlotInfo GetCoreCardSlot()
		{
			return this.CoreCardSlot;
		}

		// Token: 0x060357AD RID: 219053 RVA: 0x00CA93DF File Offset: 0x00CA75DF
		[NullableContext(2)]
		public DeckCardSlotInfo GetFieldCardSlot()
		{
			return this.FieldCardSlot;
		}

		// Token: 0x060357AE RID: 219054 RVA: 0x00CA93E7 File Offset: 0x00CA75E7
		public IReadOnlyList<DeckCardSlotInfo> GetNormalCardSlotList()
		{
			return this.NormalCardSlotList;
		}

		// Token: 0x060357AF RID: 219055 RVA: 0x00CA93EF File Offset: 0x00CA75EF
		public void SetName(string newName)
		{
			this.DeckName = newName;
		}

		// Token: 0x060357B0 RID: 219056 RVA: 0x00CA93F8 File Offset: 0x00CA75F8
		public string GetName()
		{
			return this.DeckName;
		}

		// Token: 0x060357B1 RID: 219057 RVA: 0x00CA9400 File Offset: 0x00CA7600
		public int GetTotalCardCountLimit()
		{
			return this.NormalCardCountLimit + this.CoreCardCountLimit + this.FieldCardCountLimit;
		}

		// Token: 0x060357B2 RID: 219058 RVA: 0x00CA9416 File Offset: 0x00CA7616
		public void SetNormalCardCountLimit(int newLimit)
		{
			if (newLimit < this.NormalCardCount)
			{
				return;
			}
			this.NormalCardCountLimit = newLimit;
		}

		// Token: 0x060357B3 RID: 219059 RVA: 0x00CA9429 File Offset: 0x00CA7629
		public int GetNormalCardCountLimit()
		{
			return this.NormalCardCountLimit;
		}

		// Token: 0x060357B4 RID: 219060 RVA: 0x00CA9431 File Offset: 0x00CA7631
		public void SetCoreCardCountLimit(int newLimit)
		{
			if (newLimit < this.CoreCardCount)
			{
				return;
			}
			this.CoreCardCountLimit = newLimit;
		}

		// Token: 0x060357B5 RID: 219061 RVA: 0x00CA9444 File Offset: 0x00CA7644
		public int GetCoreCardCountLimit()
		{
			return this.CoreCardCountLimit;
		}

		// Token: 0x060357B6 RID: 219062 RVA: 0x00CA944C File Offset: 0x00CA764C
		public void SetFieldCardCountLimit(int newLimit)
		{
			if (newLimit < this.FieldCardCount)
			{
				return;
			}
			this.FieldCardCountLimit = newLimit;
		}

		// Token: 0x060357B7 RID: 219063 RVA: 0x00CA945F File Offset: 0x00CA765F
		public int GetFieldCardCountLimit()
		{
			return this.FieldCardCountLimit;
		}

		// Token: 0x060357B8 RID: 219064 RVA: 0x00CA9467 File Offset: 0x00CA7667
		public void SetItemCardCountLimit(int newLimit)
		{
			if (newLimit < this.ItemCardCount)
			{
				return;
			}
			this.ItemCardCountLimit = newLimit;
		}

		// Token: 0x060357B9 RID: 219065 RVA: 0x00CA947A File Offset: 0x00CA767A
		public int GetItemCardCountLimit()
		{
			return this.ItemCardCountLimit;
		}

		// Token: 0x060357BA RID: 219066 RVA: 0x00CA9482 File Offset: 0x00CA7682
		public void SetElementCountLimit(int newLimit)
		{
			if (newLimit < this.ElementCountLimit)
			{
				return;
			}
			this.ElementCountLimit = newLimit;
		}

		// Token: 0x060357BB RID: 219067 RVA: 0x00CA9495 File Offset: 0x00CA7695
		public int GetElementCountLimit()
		{
			return this.ElementCountLimit;
		}

		// Token: 0x060357BC RID: 219068 RVA: 0x00CA949D File Offset: 0x00CA769D
		public void SetIsCoreCardSlotLocked(bool isLocked)
		{
			this.CoreCardSlotLocked = isLocked;
		}

		// Token: 0x060357BD RID: 219069 RVA: 0x00CA94A6 File Offset: 0x00CA76A6
		public bool IsCoreCardSlotLocked()
		{
			return this.CoreCardSlotLocked;
		}

		// Token: 0x060357BE RID: 219070 RVA: 0x00CA94B0 File Offset: 0x00CA76B0
		public void SetCostToMaxCardLimitMap(Dictionary<int, int> costToMaxCardLimitMap)
		{
			foreach (KeyValuePair<int, int> keyValuePair in costToMaxCardLimitMap)
			{
				this.CostToMaxCardLimitMap[keyValuePair.Key] = keyValuePair.Value;
			}
		}

		// Token: 0x060357BF RID: 219071 RVA: 0x00CA9510 File Offset: 0x00CA7710
		public Dictionary<int, int> GetCostToMaxCardLimitMap()
		{
			return this.CostToMaxCardLimitMap;
		}

		// Token: 0x060357C0 RID: 219072 RVA: 0x00CA9518 File Offset: 0x00CA7718
		public int GetCardMaxLimitByCost(int cost)
		{
			int result;
			this.CostToMaxCardLimitMap.TryGetValue(cost, out result);
			return result;
		}

		// Token: 0x060357C1 RID: 219073 RVA: 0x00CA9535 File Offset: 0x00CA7735
		public List<DeckCardSlotInfo> GetCardSlotList()
		{
			return this.CardSlotList;
		}

		// Token: 0x060357C2 RID: 219074 RVA: 0x00CA953D File Offset: 0x00CA773D
		public int GetTotalCardCount()
		{
			return this.TotalCardCount;
		}

		// Token: 0x060357C3 RID: 219075 RVA: 0x00CA9545 File Offset: 0x00CA7745
		public int GetCoreCardCount()
		{
			return this.CoreCardCount;
		}

		// Token: 0x060357C4 RID: 219076 RVA: 0x00CA954D File Offset: 0x00CA774D
		public int GetFieldCardCount()
		{
			return this.FieldCardCount;
		}

		// Token: 0x060357C5 RID: 219077 RVA: 0x00CA9555 File Offset: 0x00CA7755
		public int GetNormalCardCount()
		{
			return this.NormalCardCount;
		}

		// Token: 0x060357C6 RID: 219078 RVA: 0x00CA9560 File Offset: 0x00CA7760
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

		// Token: 0x060357C7 RID: 219079 RVA: 0x00CA95D0 File Offset: 0x00CA77D0
		public HashSet<ECardElement> GetElementSetWithPhysical()
		{
			HashSet<ECardElement> hashSet = new HashSet<ECardElement>();
			foreach (DeckCardSlotInfo deckCardSlotInfo in this.CardSlotList)
			{
				hashSet.Add((ECardElement)deckCardSlotInfo.Element);
			}
			return hashSet;
		}

		// Token: 0x060357C8 RID: 219080 RVA: 0x00CA9630 File Offset: 0x00CA7830
		public List<ECardElement> GetCoreElementList()
		{
			List<ECardElement> list = new List<ECardElement>();
			if (this.CoreCardSlot != null && this.CoreCardSlot.Element != 0)
			{
				list.Add((ECardElement)this.CoreCardSlot.Element);
			}
			return list;
		}

		// Token: 0x060357C9 RID: 219081 RVA: 0x00CA966A File Offset: 0x00CA786A
		public bool CanDeckBeUsed()
		{
			return this.IsDeckFull() && this.CanUse;
		}

		// Token: 0x060357CA RID: 219082 RVA: 0x00CA967C File Offset: 0x00CA787C
		public bool IsDeckFull()
		{
			return (this.CoreCardSlotLocked && this.NormalCardCount == this.NormalCardCountLimit) || (!this.CoreCardSlotLocked && this.TotalCardCount == this.GetTotalCardCountLimit());
		}

		// Token: 0x060357CB RID: 219083 RVA: 0x00CA96AE File Offset: 0x00CA78AE
		public string GetDeckName()
		{
			return this.DeckName;
		}

		// Token: 0x060357CC RID: 219084 RVA: 0x00CA96B6 File Offset: 0x00CA78B6
		public void SetDeckName(string newName)
		{
			this.DeckName = newName;
		}

		// Token: 0x060357CD RID: 219085 RVA: 0x00CA96BF File Offset: 0x00CA78BF
		public bool GetCanUse()
		{
			return this.CanUse;
		}

		// Token: 0x060357CE RID: 219086 RVA: 0x00CA96C7 File Offset: 0x00CA78C7
		public void SetCanUse(bool canUse)
		{
			this.CanUse = canUse;
		}

		// Token: 0x060357CF RID: 219087 RVA: 0x00CA96D0 File Offset: 0x00CA78D0
		public int GetCoreCost()
		{
			return this.CoreCost;
		}

		// Token: 0x060357D0 RID: 219088 RVA: 0x00CA96D8 File Offset: 0x00CA78D8
		public void SetCoreCost(int coreCost)
		{
			this.CoreCost = coreCost;
		}

		// Token: 0x060357D1 RID: 219089 RVA: 0x00CA96E1 File Offset: 0x00CA78E1
		public void SetDeckServerId(int newDeckServerId)
		{
			this.DeckServerId = newDeckServerId;
		}

		// Token: 0x060357D2 RID: 219090 RVA: 0x00CA96EA File Offset: 0x00CA78EA
		public int GetDeckServerId()
		{
			return this.DeckServerId;
		}

		// Token: 0x060357D3 RID: 219091 RVA: 0x00CA96F2 File Offset: 0x00CA78F2
		public void SetDeckConfigId(int newDeckConfigId)
		{
			this.DeckConfigId = newDeckConfigId;
		}

		// Token: 0x060357D4 RID: 219092 RVA: 0x00CA96FB File Offset: 0x00CA78FB
		public int GetDeckConfigId()
		{
			return this.DeckConfigId;
		}

		// Token: 0x060357D5 RID: 219093 RVA: 0x00CA9703 File Offset: 0x00CA7903
		public void SetFieldCardSkillUnlockInfo(PhantomBattleCardSkillUnlockInfo info)
		{
			this.FieldCardSkillUnlockInfo = info;
		}

		// Token: 0x060357D6 RID: 219094 RVA: 0x00CA970C File Offset: 0x00CA790C
		[NullableContext(2)]
		public PhantomBattleCardSkillUnlockInfo GetFieldCardSkillUnlockInfo()
		{
			return this.FieldCardSkillUnlockInfo;
		}

		// Token: 0x060357D7 RID: 219095 RVA: 0x00CA9714 File Offset: 0x00CA7914
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

		// Token: 0x060357D8 RID: 219096 RVA: 0x00CA9784 File Offset: 0x00CA7984
		public int GetDeckFaceCardId()
		{
			if (this.CoreCardSlot != null)
			{
				return this.CoreCardSlot.CardId;
			}
			if (this.NormalCardSlotList.Count > 0)
			{
				List<DeckCardSlotInfo> list = this.NormalCardSlotList.ToList<DeckCardSlotInfo>();
				list.Sort((DeckCardSlotInfo a, DeckCardSlotInfo b) => PhantomArenaDefine.deckCardSlotDefaultSortFunc(a, b));
				return list[0].CardId;
			}
			return 0;
		}

		// Token: 0x060357D9 RID: 219097 RVA: 0x00CA97F0 File Offset: 0x00CA79F0
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

		// Token: 0x060357DA RID: 219098 RVA: 0x00CA9860 File Offset: 0x00CA7A60
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

		// Token: 0x060357DB RID: 219099 RVA: 0x00CA98EC File Offset: 0x00CA7AEC
		public bool CheckCanAddElement(ECardElement element)
		{
			return element == ECardElement.Physical || this.ElementToSlotsMap.ContainsKey(element) || this.ElementToSlotsMap.Count < this.ElementCountLimit;
		}

		// Token: 0x060357DC RID: 219100 RVA: 0x00CA9919 File Offset: 0x00CA7B19
		public bool IsElementFull()
		{
			return this.ElementToSlotsMap.Count >= this.ElementCountLimit;
		}

		// Token: 0x060357DD RID: 219101 RVA: 0x00CA9934 File Offset: 0x00CA7B34
		public int GetCardCountByCost(int cost)
		{
			int result;
			this.CostToCardCountMap.TryGetValue(cost, out result);
			return result;
		}

		// Token: 0x060357DE RID: 219102 RVA: 0x00CA9954 File Offset: 0x00CA7B54
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

		// Token: 0x060357DF RID: 219103 RVA: 0x00CA99CC File Offset: 0x00CA7BCC
		public void SetFieldCardConditionProgress(int curNum, int targetNum)
		{
			this.FieldCardConditionCurNum = curNum;
			this.FieldCardConditionTargetNum = targetNum;
		}

		// Token: 0x060357E0 RID: 219104 RVA: 0x00CA99DC File Offset: 0x00CA7BDC
		public int GetFieldCardConditionCurNum()
		{
			return this.FieldCardConditionCurNum;
		}

		// Token: 0x060357E1 RID: 219105 RVA: 0x00CA99E4 File Offset: 0x00CA7BE4
		public int GetFieldCardConditionTargetNum()
		{
			return this.FieldCardConditionTargetNum;
		}

		// Token: 0x0401C679 RID: 116345
		private int DeckServerId = -1;

		// Token: 0x0401C67A RID: 116346
		private int DeckConfigId = -1;

		// Token: 0x0401C67B RID: 116347
		private string DeckName = string.Empty;

		// Token: 0x0401C67C RID: 116348
		private bool CanUse;

		// Token: 0x0401C67D RID: 116349
		private int CoreCost;

		// Token: 0x0401C67E RID: 116350
		[Nullable(2)]
		private PhantomBattleCardSkillUnlockInfo FieldCardSkillUnlockInfo;

		// Token: 0x0401C67F RID: 116351
		private readonly List<DeckCardSlotInfo> CardSlotList = new List<DeckCardSlotInfo>();

		// Token: 0x0401C680 RID: 116352
		private readonly Dictionary<int, DeckCardSlotInfo> CardSlotMap = new Dictionary<int, DeckCardSlotInfo>();

		// Token: 0x0401C681 RID: 116353
		private readonly Dictionary<ECardElement, List<DeckCardSlotInfo>> ElementToSlotsMap = new Dictionary<ECardElement, List<DeckCardSlotInfo>>();

		// Token: 0x0401C682 RID: 116354
		private readonly Dictionary<int, int> CostToCardCountMap = new Dictionary<int, int>();

		// Token: 0x0401C683 RID: 116355
		private readonly List<DeckCardSlotInfo> NormalCardSlotList = new List<DeckCardSlotInfo>();

		// Token: 0x0401C684 RID: 116356
		[Nullable(2)]
		private DeckCardSlotInfo CoreCardSlot;

		// Token: 0x0401C685 RID: 116357
		[Nullable(2)]
		private DeckCardSlotInfo FieldCardSlot;

		// Token: 0x0401C686 RID: 116358
		private readonly Dictionary<int, int> CostToMaxCardLimitMap = new Dictionary<int, int>();

		// Token: 0x0401C687 RID: 116359
		private int CoreCardCount;

		// Token: 0x0401C688 RID: 116360
		private int FieldCardCount;

		// Token: 0x0401C689 RID: 116361
		private int ItemCardCount;

		// Token: 0x0401C68A RID: 116362
		private int NormalCardCount;

		// Token: 0x0401C68B RID: 116363
		private int TotalCardCount;

		// Token: 0x0401C68C RID: 116364
		private int NormalCardCountLimit;

		// Token: 0x0401C68D RID: 116365
		private int CoreCardCountLimit;

		// Token: 0x0401C68E RID: 116366
		private int FieldCardCountLimit;

		// Token: 0x0401C68F RID: 116367
		private int ItemCardCountLimit;

		// Token: 0x0401C690 RID: 116368
		private int ElementCountLimit;

		// Token: 0x0401C691 RID: 116369
		private bool CoreCardSlotLocked;

		// Token: 0x0401C692 RID: 116370
		private int FieldCardConditionCurNum;

		// Token: 0x0401C693 RID: 116371
		private int FieldCardConditionTargetNum;
	}
}
