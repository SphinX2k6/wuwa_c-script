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
	// Token: 0x020042A3 RID: 17059
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaFunctionalArea : UiPanelBase
	{
		// Token: 0x0602B330 RID: 176944 RVA: 0x00C2391C File Offset: 0x00C21B1C
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

		// Token: 0x0602B331 RID: 176945 RVA: 0x00C239D0 File Offset: 0x00C21BD0
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaFunctionalArea.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaFunctionalArea.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602B332 RID: 176946 RVA: 0x00C23A14 File Offset: 0x00C21C14
		private UniTask InitAreaProxy()
		{
			PhantomArenaFunctionalArea.<InitAreaProxy>d__6 <InitAreaProxy>d__;
			<InitAreaProxy>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitAreaProxy>d__.<>4__this = this;
			<InitAreaProxy>d__.<>1__state = -1;
			<InitAreaProxy>d__.<>t__builder.Start<PhantomArenaFunctionalArea.<InitAreaProxy>d__6>(ref <InitAreaProxy>d__);
			return <InitAreaProxy>d__.<>t__builder.Task;
		}

		// Token: 0x0602B333 RID: 176947 RVA: 0x00C23A58 File Offset: 0x00C21C58
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

		// Token: 0x0602B334 RID: 176948 RVA: 0x00C23AC8 File Offset: 0x00C21CC8
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

		// Token: 0x0602B335 RID: 176949 RVA: 0x00C23B28 File Offset: 0x00C21D28
		public void RegisterBattleArea(PhantomArenaOwnArea area)
		{
			this.ParentArea = area;
		}

		// Token: 0x0602B336 RID: 176950 RVA: 0x00C23B34 File Offset: 0x00C21D34
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

		// Token: 0x0602B337 RID: 176951 RVA: 0x00C23CB4 File Offset: 0x00C21EB4
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

		// Token: 0x0602B338 RID: 176952 RVA: 0x00C23DE0 File Offset: 0x00C21FE0
		public void ResetLastProxyIndexByGamepad()
		{
			this.LastProxyIndex = -1;
		}

		// Token: 0x0602B339 RID: 176953 RVA: 0x00C23DEC File Offset: 0x00C21FEC
		public bool CheckGuideCondition(PhantomArenaCard card)
		{
			if (!this.ParentArea.ViewProxy.GuideManager.InGuiding)
			{
				return true;
			}
			PhantomArenaAreaProxyBase nearlyAreaItemProxyByCard = this.GetNearlyAreaItemProxyByCard(card);
			return nearlyAreaItemProxyByCard == null || nearlyAreaItemProxyByCard.CheckGuideCondition(card);
		}

		// Token: 0x0602B33A RID: 176954 RVA: 0x00C23E28 File Offset: 0x00C22028
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

		// Token: 0x0602B33B RID: 176955 RVA: 0x00C23E84 File Offset: 0x00C22084
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

		// Token: 0x0602B33C RID: 176956 RVA: 0x00C23F00 File Offset: 0x00C22100
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

		// Token: 0x0602B33D RID: 176957 RVA: 0x00C23F53 File Offset: 0x00C22153
		public void RemoveCard(int index)
		{
			if (this.CardProxyMap.ContainsKey(index))
			{
				this.CardProxyMap[index].SetCard(null).Forget();
			}
		}

		// Token: 0x0602B33E RID: 176958 RVA: 0x00C23F7A File Offset: 0x00C2217A
		public void ResetCardSelectState(int index)
		{
			if (this.CardProxyMap.ContainsKey(index))
			{
				this.CardProxyMap[index].ResetCardSelectState();
			}
		}

		// Token: 0x0602B33F RID: 176959 RVA: 0x00C23F9B File Offset: 0x00C2219B
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

		// Token: 0x0602B340 RID: 176960 RVA: 0x00C23FCC File Offset: 0x00C221CC
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

		// Token: 0x0602B341 RID: 176961 RVA: 0x00C24070 File Offset: 0x00C22270
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

		// Token: 0x0602B342 RID: 176962 RVA: 0x00C240F0 File Offset: 0x00C222F0
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

		// Token: 0x0602B343 RID: 176963 RVA: 0x00C24198 File Offset: 0x00C22398
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

		// Token: 0x0602B344 RID: 176964 RVA: 0x00C2420C File Offset: 0x00C2240C
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

		// Token: 0x0602B345 RID: 176965 RVA: 0x00C24258 File Offset: 0x00C22458
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

		// Token: 0x0602B346 RID: 176966 RVA: 0x00C242A4 File Offset: 0x00C224A4
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

		// Token: 0x0602B347 RID: 176967 RVA: 0x00C242F0 File Offset: 0x00C224F0
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

		// Token: 0x0602B348 RID: 176968 RVA: 0x00C2434C File Offset: 0x00C2254C
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

		// Token: 0x0602B349 RID: 176969 RVA: 0x00C243A8 File Offset: 0x00C225A8
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

		// Token: 0x0602B34A RID: 176970 RVA: 0x00C243F4 File Offset: 0x00C225F4
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

		// Token: 0x0602B34B RID: 176971 RVA: 0x00C24448 File Offset: 0x00C22648
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

		// Token: 0x0602B34C RID: 176972 RVA: 0x00C24493 File Offset: 0x00C22693
		public PhantomArenaAreaProxyBase GetCardProxyByIndex(int index)
		{
			if (!this.CardProxyMap.ContainsKey(index))
			{
				return null;
			}
			return this.CardProxyMap[index];
		}

		// Token: 0x0602B34D RID: 176973 RVA: 0x00C244B4 File Offset: 0x00C226B4
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

		// Token: 0x0602B34E RID: 176974 RVA: 0x00C24508 File Offset: 0x00C22708
		public UniTask ReconstructFightCardToRecycle(IEnumerable<int> cardIdList)
		{
			PhantomArenaFunctionalArea.<ReconstructFightCardToRecycle>d__34 <ReconstructFightCardToRecycle>d__;
			<ReconstructFightCardToRecycle>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ReconstructFightCardToRecycle>d__.<>4__this = this;
			<ReconstructFightCardToRecycle>d__.cardIdList = cardIdList;
			<ReconstructFightCardToRecycle>d__.<>1__state = -1;
			<ReconstructFightCardToRecycle>d__.<>t__builder.Start<PhantomArenaFunctionalArea.<ReconstructFightCardToRecycle>d__34>(ref <ReconstructFightCardToRecycle>d__);
			return <ReconstructFightCardToRecycle>d__.<>t__builder.Task;
		}

		// Token: 0x0602B34F RID: 176975 RVA: 0x00C24554 File Offset: 0x00C22754
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

		// Token: 0x0401751F RID: 95519
		public PhantomArenaOwnArea ParentArea;

		// Token: 0x04017520 RID: 95520
		protected Dictionary<int, PhantomArenaAreaProxyBase> CardProxyMap = new Dictionary<int, PhantomArenaAreaProxyBase>();

		// Token: 0x04017521 RID: 95521
		private int LastProxyIndex = -1;

		// Token: 0x02009FA9 RID: 40873
		[NullableContext(0)]
		private static class EComponentDefine
		{
			// Token: 0x040319E9 RID: 203241
			public const int MonsterOne = 0;

			// Token: 0x040319EA RID: 203242
			public const int MonsterTwo = 1;

			// Token: 0x040319EB RID: 203243
			public const int MonsterThree = 2;

			// Token: 0x040319EC RID: 203244
			public const int MonsterFour = 3;

			// Token: 0x040319ED RID: 203245
			public const int MonsterFive = 4;

			// Token: 0x040319EE RID: 203246
			public const int MonsterSix = 5;

			// Token: 0x040319EF RID: 203247
			public const int FunctionOne = 6;
		}
	}
}
