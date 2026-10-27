using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.PhantomArena.Battle.Card;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using CSharpScript.Game.Module.PhantomArena.Battle.SkillInteract;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Area.Functional
{
	// Token: 0x020052D3 RID: 21203
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaFunctionalArea : UiPanelBase
	{
		// Token: 0x06036435 RID: 222261 RVA: 0x00CD61F4 File Offset: 0x00CD43F4
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIItem))
			};
		}

		// Token: 0x06036436 RID: 222262 RVA: 0x00CD62A8 File Offset: 0x00CD44A8
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaFunctionalArea.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaFunctionalArea.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06036437 RID: 222263 RVA: 0x00CD62EC File Offset: 0x00CD44EC
		private UniTask InitAreaProxy()
		{
			PhantomArenaFunctionalArea.<InitAreaProxy>d__6 <InitAreaProxy>d__;
			<InitAreaProxy>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitAreaProxy>d__.<>4__this = this;
			<InitAreaProxy>d__.<>1__state = -1;
			<InitAreaProxy>d__.<>t__builder.Start<PhantomArenaFunctionalArea.<InitAreaProxy>d__6>(ref <InitAreaProxy>d__);
			return <InitAreaProxy>d__.<>t__builder.Task;
		}

		// Token: 0x06036438 RID: 222264 RVA: 0x00CD6330 File Offset: 0x00CD4530
		public void SetAllCardProxyUseActiveState(bool value, PhantomArenaCard card)
		{
			foreach (PhantomArenaAreaProxyBase phantomArenaAreaProxyBase in this.CardProxyMap.Values)
			{
				if (value && phantomArenaAreaProxyBase.CheckSettingCardCondition(card))
				{
					phantomArenaAreaProxyBase.SetCanUseStateActive(value);
				}
				else
				{
					phantomArenaAreaProxyBase.SetCanUseStateActive(false);
				}
			}
		}

		// Token: 0x06036439 RID: 222265 RVA: 0x00CD63A0 File Offset: 0x00CD45A0
		public bool CheckSettingCardPosition(PhantomArenaCard card)
		{
			using (Dictionary<int, PhantomArenaAreaProxyBase>.ValueCollection.Enumerator enumerator = this.CardProxyMap.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.CheckSettingCardCondition(card))
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x0603643A RID: 222266 RVA: 0x00CD6400 File Offset: 0x00CD4600
		public void RegisterBattleArea(PhantomArenaOwnArea area)
		{
			this.ParentArea = area;
		}

		// Token: 0x0603643B RID: 222267 RVA: 0x00CD640C File Offset: 0x00CD460C
		public unsafe void RefreshStateByDragCard(PhantomArenaCard card)
		{
			int num = -1;
			double num2 = 99999.0;
			foreach (KeyValuePair<int, PhantomArenaAreaProxyBase> keyValuePair in this.CardProxyMap)
			{
				PhantomArenaAreaProxyBase value = keyValuePair.Value;
				if (value.IsCanSettingCard(card) && value.Distance < num2)
				{
					num2 = value.Distance;
					num = keyValuePair.Key;
				}
			}
			if (this.LastProxyIndex == num)
			{
				return;
			}
			if (this.LastProxyIndex == -1 && num != -1)
			{
				this.SetAllCardProxyUseActiveState(true, card);
			}
			else if (this.LastProxyIndex != -1 && num == -1)
			{
				this.SetAllCardProxyUseActiveState(false, card);
			}
			if (this.LastProxyIndex != -1 && this.CardProxyMap.ContainsKey(this.LastProxyIndex))
			{
				this.CardProxyMap[this.LastProxyIndex].SetHoverStateActive(false);
			}
			if (num != -1 && this.CardProxyMap.ContainsKey(num))
			{
				this.CardProxyMap[num].SetHoverStateActive(true);
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.PhantomArena;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "找到放置区的位置";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("LastProxyIndex", this.LastProxyIndex);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("CurrentProxyIndex", num);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			this.LastProxyIndex = num;
		}

		// Token: 0x0603643C RID: 222268 RVA: 0x00CD658C File Offset: 0x00CD478C
		public unsafe void RefreshStateByGamepad(PhantomArenaCard card, int slotIndex)
		{
			int num = -1;
			if (this.CardProxyMap.ContainsKey(slotIndex) && this.CardProxyMap[slotIndex].CheckSettingCardCondition(card))
			{
				num = slotIndex;
			}
			if (this.LastProxyIndex == num)
			{
				return;
			}
			if (this.LastProxyIndex == -1 && num != -1)
			{
				this.SetAllCardProxyUseActiveState(true, card);
			}
			else if (this.LastProxyIndex != -1 && num == -1)
			{
				this.SetAllCardProxyUseActiveState(false, card);
			}
			if (this.LastProxyIndex != -1 && this.CardProxyMap.ContainsKey(this.LastProxyIndex))
			{
				this.CardProxyMap[this.LastProxyIndex].SetHoverStateActive(false);
			}
			if (num != -1 && this.CardProxyMap.ContainsKey(num))
			{
				this.CardProxyMap[num].SetHoverStateActive(true);
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.PhantomArena;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "找到放置区的位置";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("LastProxyIndex", this.LastProxyIndex);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("CurrentProxyIndex", num);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			this.LastProxyIndex = num;
		}

		// Token: 0x0603643D RID: 222269 RVA: 0x00CD66B8 File Offset: 0x00CD48B8
		public void ResetLastProxyIndexByGamepad()
		{
			this.LastProxyIndex = -1;
		}

		// Token: 0x0603643E RID: 222270 RVA: 0x00CD66C4 File Offset: 0x00CD48C4
		public bool CheckGuideCondition(PhantomArenaCard card)
		{
			if (!this.ParentArea.ViewProxy.GuideManager.InGuiding)
			{
				return true;
			}
			PhantomArenaAreaProxyBase nearlyAreaItemProxyByCard = this.GetNearlyAreaItemProxyByCard(card);
			return nearlyAreaItemProxyByCard == null || nearlyAreaItemProxyByCard.CheckGuideCondition(card);
		}

		// Token: 0x0603643F RID: 222271 RVA: 0x00CD6700 File Offset: 0x00CD4900
		[NullableContext(0)]
		public UniTask<bool> TrySettingCard([Nullable(1)] PhantomArenaCard card, int index, bool needExecLogic)
		{
			PhantomArenaFunctionalArea.<TrySettingCard>d__14 <TrySettingCard>d__;
			<TrySettingCard>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<TrySettingCard>d__.<>4__this = this;
			<TrySettingCard>d__.card = card;
			<TrySettingCard>d__.index = index;
			<TrySettingCard>d__.needExecLogic = needExecLogic;
			<TrySettingCard>d__.<>1__state = -1;
			<TrySettingCard>d__.<>t__builder.Start<PhantomArenaFunctionalArea.<TrySettingCard>d__14>(ref <TrySettingCard>d__);
			return <TrySettingCard>d__.<>t__builder.Task;
		}

		// Token: 0x06036440 RID: 222272 RVA: 0x00CD675C File Offset: 0x00CD495C
		public PhantomArenaAreaProxyBase GetNearlyAreaItemProxyByCard(PhantomArenaCard card)
		{
			double num = 99999.0;
			PhantomArenaAreaProxyBase result = null;
			foreach (PhantomArenaAreaProxyBase phantomArenaAreaProxyBase in this.CardProxyMap.Values)
			{
				if (phantomArenaAreaProxyBase.IsCardNearlyAreaItem(card) && phantomArenaAreaProxyBase.Distance < num)
				{
					num = phantomArenaAreaProxyBase.Distance;
					result = phantomArenaAreaProxyBase;
				}
			}
			return result;
		}

		// Token: 0x06036441 RID: 222273 RVA: 0x00CD67D8 File Offset: 0x00CD49D8
		[NullableContext(0)]
		public UniTask<bool> TryChangeCard([Nullable(1)] PhantomArenaCard card, int index)
		{
			PhantomArenaFunctionalArea.<TryChangeCard>d__16 <TryChangeCard>d__;
			<TryChangeCard>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<TryChangeCard>d__.<>4__this = this;
			<TryChangeCard>d__.card = card;
			<TryChangeCard>d__.index = index;
			<TryChangeCard>d__.<>1__state = -1;
			<TryChangeCard>d__.<>t__builder.Start<PhantomArenaFunctionalArea.<TryChangeCard>d__16>(ref <TryChangeCard>d__);
			return <TryChangeCard>d__.<>t__builder.Task;
		}

		// Token: 0x06036442 RID: 222274 RVA: 0x00CD682B File Offset: 0x00CD4A2B
		public void RemoveCard(int index)
		{
			if (this.CardProxyMap.ContainsKey(index))
			{
				this.CardProxyMap[index].SetCard(null).Forget();
			}
		}

		// Token: 0x06036443 RID: 222275 RVA: 0x00CD6852 File Offset: 0x00CD4A52
		public void ResetCardSelectState(int index)
		{
			if (this.CardProxyMap.ContainsKey(index))
			{
				this.CardProxyMap[index].ResetCardSelectState();
			}
		}

		// Token: 0x06036444 RID: 222276 RVA: 0x00CD6873 File Offset: 0x00CD4A73
		public void FinishBuffEffect(int index)
		{
			if (this.CardProxyMap.ContainsKey(index))
			{
				PhantomArenaAreaFunctionalProxy phantomArenaAreaFunctionalProxy = this.CardProxyMap[index] as PhantomArenaAreaFunctionalProxy;
				if (phantomArenaAreaFunctionalProxy == null)
				{
					return;
				}
				phantomArenaAreaFunctionalProxy.SetCard(null).Forget();
			}
		}

		// Token: 0x06036445 RID: 222277 RVA: 0x00CD68A4 File Offset: 0x00CD4AA4
		public void ShowAddBuffEffect(EBuffShowType buffShowType, List<int> fightIdList)
		{
			foreach (PhantomArenaAreaProxyBase phantomArenaAreaProxyBase in this.CardProxyMap.Values)
			{
				if (phantomArenaAreaProxyBase.Card != null && fightIdList.Contains(phantomArenaAreaProxyBase.Card.Data.FightId))
				{
					PhantomArenaAreaMonsterProxy phantomArenaAreaMonsterProxy = (PhantomArenaAreaMonsterProxy)phantomArenaAreaProxyBase;
					if (buffShowType == EBuffShowType.UpGrade)
					{
						if (phantomArenaAreaMonsterProxy != null)
						{
							phantomArenaAreaMonsterProxy.AreaItem.SetBuffUpActive(true);
						}
					}
					else if (buffShowType == EBuffShowType.DownGrade && phantomArenaAreaMonsterProxy != null)
					{
						phantomArenaAreaMonsterProxy.AreaItem.SetBuffDownActive(true);
					}
				}
			}
		}

		// Token: 0x06036446 RID: 222278 RVA: 0x00CD6948 File Offset: 0x00CD4B48
		public void RefreshBattleCard(int cardId)
		{
			foreach (PhantomArenaAreaProxyBase phantomArenaAreaProxyBase in this.CardProxyMap.Values)
			{
				if (phantomArenaAreaProxyBase.Card != null && phantomArenaAreaProxyBase.Card.Data.CardId == cardId)
				{
					phantomArenaAreaProxyBase.Card.RefreshSelfAsync().Forget();
					break;
				}
			}
		}

		// Token: 0x06036447 RID: 222279 RVA: 0x00CD69C8 File Offset: 0x00CD4BC8
		public void RefreshAllBattleCard()
		{
			foreach (PhantomArenaAreaProxyBase phantomArenaAreaProxyBase in this.CardProxyMap.Values)
			{
				if (phantomArenaAreaProxyBase.Card != null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.PhantomArena;
					ELogAuthor author = ELogAuthor.XXJ;
					string message = "RefreshAllBattleCard";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("CardId", phantomArenaAreaProxyBase.Card.Data.CardId);
					instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					phantomArenaAreaProxyBase.Card.RefreshSelfAsync().Forget();
				}
			}
		}

		// Token: 0x06036448 RID: 222280 RVA: 0x00CD6A70 File Offset: 0x00CD4C70
		public PhantomArenaAreaProxyBase GetCardProxyByCardId(int cardId)
		{
			foreach (PhantomArenaAreaProxyBase phantomArenaAreaProxyBase in this.CardProxyMap.Values)
			{
				if (phantomArenaAreaProxyBase.Card != null && phantomArenaAreaProxyBase.Card.Data.CardId == cardId)
				{
					return phantomArenaAreaProxyBase;
				}
			}
			return null;
		}

		// Token: 0x06036449 RID: 222281 RVA: 0x00CD6AE4 File Offset: 0x00CD4CE4
		public UniTask DestroyCardByLibrary(int index)
		{
			PhantomArenaFunctionalArea.<DestroyCardByLibrary>d__24 <DestroyCardByLibrary>d__;
			<DestroyCardByLibrary>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<DestroyCardByLibrary>d__.<>4__this = this;
			<DestroyCardByLibrary>d__.index = index;
			<DestroyCardByLibrary>d__.<>1__state = -1;
			<DestroyCardByLibrary>d__.<>t__builder.Start<PhantomArenaFunctionalArea.<DestroyCardByLibrary>d__24>(ref <DestroyCardByLibrary>d__);
			return <DestroyCardByLibrary>d__.<>t__builder.Task;
		}

		// Token: 0x0603644A RID: 222282 RVA: 0x00CD6B30 File Offset: 0x00CD4D30
		public UniTask ResetCardPosition(int index)
		{
			PhantomArenaFunctionalArea.<ResetCardPosition>d__25 <ResetCardPosition>d__;
			<ResetCardPosition>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ResetCardPosition>d__.<>4__this = this;
			<ResetCardPosition>d__.index = index;
			<ResetCardPosition>d__.<>1__state = -1;
			<ResetCardPosition>d__.<>t__builder.Start<PhantomArenaFunctionalArea.<ResetCardPosition>d__25>(ref <ResetCardPosition>d__);
			return <ResetCardPosition>d__.<>t__builder.Task;
		}

		// Token: 0x0603644B RID: 222283 RVA: 0x00CD6B7C File Offset: 0x00CD4D7C
		public UniTask RemoveCardToLibrary(int index)
		{
			PhantomArenaFunctionalArea.<RemoveCardToLibrary>d__26 <RemoveCardToLibrary>d__;
			<RemoveCardToLibrary>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RemoveCardToLibrary>d__.<>4__this = this;
			<RemoveCardToLibrary>d__.index = index;
			<RemoveCardToLibrary>d__.<>1__state = -1;
			<RemoveCardToLibrary>d__.<>t__builder.Start<PhantomArenaFunctionalArea.<RemoveCardToLibrary>d__26>(ref <RemoveCardToLibrary>d__);
			return <RemoveCardToLibrary>d__.<>t__builder.Task;
		}

		// Token: 0x0603644C RID: 222284 RVA: 0x00CD6BC8 File Offset: 0x00CD4DC8
		public UniTask ResetFunctionalToMonster(PhantomArenaCard card, int lastCardIndex, int index)
		{
			PhantomArenaFunctionalArea.<ResetFunctionalToMonster>d__27 <ResetFunctionalToMonster>d__;
			<ResetFunctionalToMonster>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ResetFunctionalToMonster>d__.<>4__this = this;
			<ResetFunctionalToMonster>d__.card = card;
			<ResetFunctionalToMonster>d__.lastCardIndex = lastCardIndex;
			<ResetFunctionalToMonster>d__.index = index;
			<ResetFunctionalToMonster>d__.<>1__state = -1;
			<ResetFunctionalToMonster>d__.<>t__builder.Start<PhantomArenaFunctionalArea.<ResetFunctionalToMonster>d__27>(ref <ResetFunctionalToMonster>d__);
			return <ResetFunctionalToMonster>d__.<>t__builder.Task;
		}

		// Token: 0x0603644D RID: 222285 RVA: 0x00CD6C24 File Offset: 0x00CD4E24
		public UniTask FunctionalCardToFunctionalTop(PhantomArenaCard card, int slotIndex, bool needDragUpTween)
		{
			PhantomArenaFunctionalArea.<FunctionalCardToFunctionalTop>d__28 <FunctionalCardToFunctionalTop>d__;
			<FunctionalCardToFunctionalTop>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<FunctionalCardToFunctionalTop>d__.<>4__this = this;
			<FunctionalCardToFunctionalTop>d__.card = card;
			<FunctionalCardToFunctionalTop>d__.slotIndex = slotIndex;
			<FunctionalCardToFunctionalTop>d__.needDragUpTween = needDragUpTween;
			<FunctionalCardToFunctionalTop>d__.<>1__state = -1;
			<FunctionalCardToFunctionalTop>d__.<>t__builder.Start<PhantomArenaFunctionalArea.<FunctionalCardToFunctionalTop>d__28>(ref <FunctionalCardToFunctionalTop>d__);
			return <FunctionalCardToFunctionalTop>d__.<>t__builder.Task;
		}

		// Token: 0x0603644E RID: 222286 RVA: 0x00CD6C80 File Offset: 0x00CD4E80
		public UniTask CopyCardListToFight(PhantomBattleFighterInfo[] cardInfoList)
		{
			PhantomArenaFunctionalArea.<CopyCardListToFight>d__29 <CopyCardListToFight>d__;
			<CopyCardListToFight>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CopyCardListToFight>d__.<>4__this = this;
			<CopyCardListToFight>d__.cardInfoList = cardInfoList;
			<CopyCardListToFight>d__.<>1__state = -1;
			<CopyCardListToFight>d__.<>t__builder.Start<PhantomArenaFunctionalArea.<CopyCardListToFight>d__29>(ref <CopyCardListToFight>d__);
			return <CopyCardListToFight>d__.<>t__builder.Task;
		}

		// Token: 0x0603644F RID: 222287 RVA: 0x00CD6CCC File Offset: 0x00CD4ECC
		public UniTask PlayDamageHitEffect(int fightId, UUIItem toItem)
		{
			PhantomArenaFunctionalArea.<PlayDamageHitEffect>d__30 <PlayDamageHitEffect>d__;
			<PlayDamageHitEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayDamageHitEffect>d__.<>4__this = this;
			<PlayDamageHitEffect>d__.fightId = fightId;
			<PlayDamageHitEffect>d__.toItem = toItem;
			<PlayDamageHitEffect>d__.<>1__state = -1;
			<PlayDamageHitEffect>d__.<>t__builder.Start<PhantomArenaFunctionalArea.<PlayDamageHitEffect>d__30>(ref <PlayDamageHitEffect>d__);
			return <PlayDamageHitEffect>d__.<>t__builder.Task;
		}

		// Token: 0x06036450 RID: 222288 RVA: 0x00CD6D20 File Offset: 0x00CD4F20
		public UniTask FunctionalToRecycle(PhantomArenaCard card)
		{
			PhantomArenaFunctionalArea.<FunctionalToRecycle>d__31 <FunctionalToRecycle>d__;
			<FunctionalToRecycle>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<FunctionalToRecycle>d__.<>4__this = this;
			<FunctionalToRecycle>d__.card = card;
			<FunctionalToRecycle>d__.<>1__state = -1;
			<FunctionalToRecycle>d__.<>t__builder.Start<PhantomArenaFunctionalArea.<FunctionalToRecycle>d__31>(ref <FunctionalToRecycle>d__);
			return <FunctionalToRecycle>d__.<>t__builder.Task;
		}

		// Token: 0x06036451 RID: 222289 RVA: 0x00CD6D6B File Offset: 0x00CD4F6B
		public PhantomArenaAreaProxyBase GetCardProxyByIndex(int index)
		{
			if (!this.CardProxyMap.ContainsKey(index))
			{
				return null;
			}
			return this.CardProxyMap[index];
		}

		// Token: 0x06036452 RID: 222290 RVA: 0x00CD6D8C File Offset: 0x00CD4F8C
		public UniTask RefreshEffect(int cardId, int curEffectCount)
		{
			PhantomArenaFunctionalArea.<RefreshEffect>d__33 <RefreshEffect>d__;
			<RefreshEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshEffect>d__.<>4__this = this;
			<RefreshEffect>d__.cardId = cardId;
			<RefreshEffect>d__.curEffectCount = curEffectCount;
			<RefreshEffect>d__.<>1__state = -1;
			<RefreshEffect>d__.<>t__builder.Start<PhantomArenaFunctionalArea.<RefreshEffect>d__33>(ref <RefreshEffect>d__);
			return <RefreshEffect>d__.<>t__builder.Task;
		}

		// Token: 0x06036453 RID: 222291 RVA: 0x00CD6DE0 File Offset: 0x00CD4FE0
		public UniTask ReconstructFightCardToRecycle(List<int> cardIdList)
		{
			PhantomArenaFunctionalArea.<ReconstructFightCardToRecycle>d__34 <ReconstructFightCardToRecycle>d__;
			<ReconstructFightCardToRecycle>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ReconstructFightCardToRecycle>d__.<>4__this = this;
			<ReconstructFightCardToRecycle>d__.cardIdList = cardIdList;
			<ReconstructFightCardToRecycle>d__.<>1__state = -1;
			<ReconstructFightCardToRecycle>d__.<>t__builder.Start<PhantomArenaFunctionalArea.<ReconstructFightCardToRecycle>d__34>(ref <ReconstructFightCardToRecycle>d__);
			return <ReconstructFightCardToRecycle>d__.<>t__builder.Task;
		}

		// Token: 0x06036454 RID: 222292 RVA: 0x00CD6E2C File Offset: 0x00CD502C
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams == null || configParams.Length < 3)
			{
				return null;
			}
			string a = configParams[0];
			if (!(a == "BattleCard"))
			{
				if (a == "BattleCardById" || a == "BattleCardSkillById")
				{
					int num = int.Parse(configParams[2]);
					foreach (PhantomArenaAreaProxyBase phantomArenaAreaProxyBase in this.CardProxyMap.Values)
					{
						PhantomArenaCard card = phantomArenaAreaProxyBase.Card;
						bool flag;
						if (card == null)
						{
							flag = false;
						}
						else
						{
							PhantomCardData data = card.Data;
							int? num2 = (data != null) ? new int?(data.ConfigId) : null;
							int num3 = num;
							flag = (num2.GetValueOrDefault() == num3 & num2 != null);
						}
						if (flag)
						{
							return phantomArenaAreaProxyBase.Card.GetGuideUiItemAndUiItemForShowEx(configParams);
						}
					}
				}
				return null;
			}
			int key = int.Parse(configParams[2]);
			if (!this.CardProxyMap.ContainsKey(key))
			{
				return null;
			}
			PhantomArenaCard card2 = this.CardProxyMap[key].Card;
			if (card2 == null)
			{
				return null;
			}
			return card2.GetGuideUiItemAndUiItemForShowEx(configParams);
		}

		// Token: 0x0401CAEA RID: 117482
		public PhantomArenaOwnArea ParentArea;

		// Token: 0x0401CAEB RID: 117483
		protected Dictionary<int, PhantomArenaAreaProxyBase> CardProxyMap = new Dictionary<int, PhantomArenaAreaProxyBase>();

		// Token: 0x0401CAEC RID: 117484
		private int LastProxyIndex = -1;

		// Token: 0x0200B571 RID: 46449
		[NullableContext(0)]
		private static class EComponentDefine
		{
			// Token: 0x04036F96 RID: 225174
			public const int MonsterOne = 0;

			// Token: 0x04036F97 RID: 225175
			public const int MonsterTwo = 1;

			// Token: 0x04036F98 RID: 225176
			public const int MonsterThree = 2;

			// Token: 0x04036F99 RID: 225177
			public const int MonsterFour = 3;

			// Token: 0x04036F9A RID: 225178
			public const int MonsterFive = 4;

			// Token: 0x04036F9B RID: 225179
			public const int MonsterSix = 5;

			// Token: 0x04036F9C RID: 225180
			public const int FunctionOne = 6;
		}
	}
}
