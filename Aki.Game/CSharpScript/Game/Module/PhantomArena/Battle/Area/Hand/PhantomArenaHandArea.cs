using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PhantomArena.Battle.Card;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Area.Hand
{
	// Token: 0x02004299 RID: 17049
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaHandArea : UiPanelBase
	{
		// Token: 0x0602B26F RID: 176751 RVA: 0x00C20F56 File Offset: 0x00C1F156
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout))
			};
		}

		// Token: 0x0602B270 RID: 176752 RVA: 0x00C20F7C File Offset: 0x00C1F17C
		protected override void OnStart()
		{
			this.Sequence = new UiSequencePlayer(this.RootItem);
			this.Layout = base.GetHorizontalLayout(0);
			this.Layout.bUseOriginalChildrenOrder = true;
			this.OriginalSpace = this.Layout.GetSpacing();
			Transform itemWorldTrans = this.ItemWorldTrans;
			FTransform ftransform = this.RootItem.K2_GetComponentToWorld();
			itemWorldTrans.FromUeTransform(ftransform);
			this.OriginalOffset = this.RootItem.GetAnchorOffsetY();
			this.TotalWidth = this.Layout.RootUIComp.Get().GetWidth();
			this.TotalHeight = this.Layout.RootUIComp.Get().GetHeight();
		}

		// Token: 0x0602B271 RID: 176753 RVA: 0x00C2102A File Offset: 0x00C1F22A
		protected override void OnBeforeDestroy()
		{
			this.Sequence.Clear();
		}

		// Token: 0x0602B272 RID: 176754 RVA: 0x00C21038 File Offset: 0x00C1F238
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		private UniTask<PhantomArenaHandAreaItem> CreateAreaItem()
		{
			PhantomArenaHandArea.<CreateAreaItem>d__17 <CreateAreaItem>d__;
			<CreateAreaItem>d__.<>t__builder = AsyncUniTaskMethodBuilder<PhantomArenaHandAreaItem>.Create();
			<CreateAreaItem>d__.<>4__this = this;
			<CreateAreaItem>d__.<>1__state = -1;
			<CreateAreaItem>d__.<>t__builder.Start<PhantomArenaHandArea.<CreateAreaItem>d__17>(ref <CreateAreaItem>d__);
			return <CreateAreaItem>d__.<>t__builder.Task;
		}

		// Token: 0x0602B273 RID: 176755 RVA: 0x00C2107C File Offset: 0x00C1F27C
		private void CalculateLayoutSpace()
		{
			float num = this.OriginalSpace;
			float num2 = 6f * this.GridWidth + 5f * this.OriginalSpace;
			if (this.CardMap.Count > 6)
			{
				num = (num2 - (float)this.CardMap.Count * this.GridWidth) / (float)(this.CardMap.Count - 1);
			}
			this.Layout.SetSpacing(num);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.PhantomArena;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "[CalculateLayoutSpace]";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Space", num);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x0602B274 RID: 176756 RVA: 0x00C21118 File Offset: 0x00C1F318
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		private UniTask<PhantomArenaCard> AddCardById(int cardId)
		{
			PhantomArenaHandArea.<AddCardById>d__19 <AddCardById>d__;
			<AddCardById>d__.<>t__builder = AsyncUniTaskMethodBuilder<PhantomArenaCard>.Create();
			<AddCardById>d__.<>4__this = this;
			<AddCardById>d__.cardId = cardId;
			<AddCardById>d__.<>1__state = -1;
			<AddCardById>d__.<>t__builder.Start<PhantomArenaHandArea.<AddCardById>d__19>(ref <AddCardById>d__);
			return <AddCardById>d__.<>t__builder.Task;
		}

		// Token: 0x0602B275 RID: 176757 RVA: 0x00C21164 File Offset: 0x00C1F364
		private UniTask AddCardByCard(PhantomArenaCard card)
		{
			PhantomArenaHandArea.<AddCardByCard>d__20 <AddCardByCard>d__;
			<AddCardByCard>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<AddCardByCard>d__.<>4__this = this;
			<AddCardByCard>d__.card = card;
			<AddCardByCard>d__.<>1__state = -1;
			<AddCardByCard>d__.<>t__builder.Start<PhantomArenaHandArea.<AddCardByCard>d__20>(ref <AddCardByCard>d__);
			return <AddCardByCard>d__.<>t__builder.Task;
		}

		// Token: 0x0602B276 RID: 176758 RVA: 0x00C211B0 File Offset: 0x00C1F3B0
		private UniTask InitCardList()
		{
			PhantomArenaHandArea.<InitCardList>d__21 <InitCardList>d__;
			<InitCardList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitCardList>d__.<>4__this = this;
			<InitCardList>d__.<>1__state = -1;
			<InitCardList>d__.<>t__builder.Start<PhantomArenaHandArea.<InitCardList>d__21>(ref <InitCardList>d__);
			return <InitCardList>d__.<>t__builder.Task;
		}

		// Token: 0x0602B277 RID: 176759 RVA: 0x00C211F4 File Offset: 0x00C1F3F4
		private UniTask AddCardList(List<int> cardIdList)
		{
			PhantomArenaHandArea.<AddCardList>d__22 <AddCardList>d__;
			<AddCardList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<AddCardList>d__.<>4__this = this;
			<AddCardList>d__.cardIdList = cardIdList;
			<AddCardList>d__.<>1__state = -1;
			<AddCardList>d__.<>t__builder.Start<PhantomArenaHandArea.<AddCardList>d__22>(ref <AddCardList>d__);
			return <AddCardList>d__.<>t__builder.Task;
		}

		// Token: 0x0602B278 RID: 176760 RVA: 0x00C21240 File Offset: 0x00C1F440
		private UniTask PlayFirstTimeDrawCardTween(UUIItem fromItem)
		{
			PhantomArenaHandArea.<PlayFirstTimeDrawCardTween>d__23 <PlayFirstTimeDrawCardTween>d__;
			<PlayFirstTimeDrawCardTween>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayFirstTimeDrawCardTween>d__.<>4__this = this;
			<PlayFirstTimeDrawCardTween>d__.fromItem = fromItem;
			<PlayFirstTimeDrawCardTween>d__.<>1__state = -1;
			<PlayFirstTimeDrawCardTween>d__.<>t__builder.Start<PhantomArenaHandArea.<PlayFirstTimeDrawCardTween>d__23>(ref <PlayFirstTimeDrawCardTween>d__);
			return <PlayFirstTimeDrawCardTween>d__.<>t__builder.Task;
		}

		// Token: 0x0602B279 RID: 176761 RVA: 0x00C2128C File Offset: 0x00C1F48C
		private UniTask PlayOtherTimeDrawCardTween(UUIItem fromItem)
		{
			PhantomArenaHandArea.<PlayOtherTimeDrawCardTween>d__24 <PlayOtherTimeDrawCardTween>d__;
			<PlayOtherTimeDrawCardTween>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayOtherTimeDrawCardTween>d__.<>4__this = this;
			<PlayOtherTimeDrawCardTween>d__.fromItem = fromItem;
			<PlayOtherTimeDrawCardTween>d__.<>1__state = -1;
			<PlayOtherTimeDrawCardTween>d__.<>t__builder.Start<PhantomArenaHandArea.<PlayOtherTimeDrawCardTween>d__24>(ref <PlayOtherTimeDrawCardTween>d__);
			return <PlayOtherTimeDrawCardTween>d__.<>t__builder.Task;
		}

		// Token: 0x0602B27A RID: 176762 RVA: 0x00C212D8 File Offset: 0x00C1F4D8
		private UniTask PlayStartTimeDrawCardTween(UUIItem fromItem)
		{
			PhantomArenaHandArea.<PlayStartTimeDrawCardTween>d__25 <PlayStartTimeDrawCardTween>d__;
			<PlayStartTimeDrawCardTween>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayStartTimeDrawCardTween>d__.<>4__this = this;
			<PlayStartTimeDrawCardTween>d__.fromItem = fromItem;
			<PlayStartTimeDrawCardTween>d__.<>1__state = -1;
			<PlayStartTimeDrawCardTween>d__.<>t__builder.Start<PhantomArenaHandArea.<PlayStartTimeDrawCardTween>d__25>(ref <PlayStartTimeDrawCardTween>d__);
			return <PlayStartTimeDrawCardTween>d__.<>t__builder.Task;
		}

		// Token: 0x0602B27B RID: 176763 RVA: 0x00C21324 File Offset: 0x00C1F524
		private UniTask PlayEndTimeDiscardCardTween(UUIItem toItem)
		{
			PhantomArenaHandArea.<PlayEndTimeDiscardCardTween>d__26 <PlayEndTimeDiscardCardTween>d__;
			<PlayEndTimeDiscardCardTween>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayEndTimeDiscardCardTween>d__.<>4__this = this;
			<PlayEndTimeDiscardCardTween>d__.toItem = toItem;
			<PlayEndTimeDiscardCardTween>d__.<>1__state = -1;
			<PlayEndTimeDiscardCardTween>d__.<>t__builder.Start<PhantomArenaHandArea.<PlayEndTimeDiscardCardTween>d__26>(ref <PlayEndTimeDiscardCardTween>d__);
			return <PlayEndTimeDiscardCardTween>d__.<>t__builder.Task;
		}

		// Token: 0x0602B27C RID: 176764 RVA: 0x00C21370 File Offset: 0x00C1F570
		private UniTask PlayDiscardCardTween(UUIItem toItem, List<int> discardIdList)
		{
			PhantomArenaHandArea.<PlayDiscardCardTween>d__27 <PlayDiscardCardTween>d__;
			<PlayDiscardCardTween>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayDiscardCardTween>d__.<>4__this = this;
			<PlayDiscardCardTween>d__.toItem = toItem;
			<PlayDiscardCardTween>d__.discardIdList = discardIdList;
			<PlayDiscardCardTween>d__.<>1__state = -1;
			<PlayDiscardCardTween>d__.<>t__builder.Start<PhantomArenaHandArea.<PlayDiscardCardTween>d__27>(ref <PlayDiscardCardTween>d__);
			return <PlayDiscardCardTween>d__.<>t__builder.Task;
		}

		// Token: 0x0602B27D RID: 176765 RVA: 0x00C213C4 File Offset: 0x00C1F5C4
		private UniTask PlayAddCardTween(UUIItem fromItem, List<int> cardIdList)
		{
			PhantomArenaHandArea.<PlayAddCardTween>d__28 <PlayAddCardTween>d__;
			<PlayAddCardTween>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayAddCardTween>d__.<>4__this = this;
			<PlayAddCardTween>d__.fromItem = fromItem;
			<PlayAddCardTween>d__.cardIdList = cardIdList;
			<PlayAddCardTween>d__.<>1__state = -1;
			<PlayAddCardTween>d__.<>t__builder.Start<PhantomArenaHandArea.<PlayAddCardTween>d__28>(ref <PlayAddCardTween>d__);
			return <PlayAddCardTween>d__.<>t__builder.Task;
		}

		// Token: 0x0602B27E RID: 176766 RVA: 0x00C21418 File Offset: 0x00C1F618
		private UniTask PlayRecycleCardTween(List<int> cardIdList)
		{
			PhantomArenaHandArea.<PlayRecycleCardTween>d__29 <PlayRecycleCardTween>d__;
			<PlayRecycleCardTween>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayRecycleCardTween>d__.<>4__this = this;
			<PlayRecycleCardTween>d__.cardIdList = cardIdList;
			<PlayRecycleCardTween>d__.<>1__state = -1;
			<PlayRecycleCardTween>d__.<>t__builder.Start<PhantomArenaHandArea.<PlayRecycleCardTween>d__29>(ref <PlayRecycleCardTween>d__);
			return <PlayRecycleCardTween>d__.<>t__builder.Task;
		}

		// Token: 0x0602B27F RID: 176767 RVA: 0x00C21464 File Offset: 0x00C1F664
		private UniTask PlayResetCardTween(int cardId)
		{
			PhantomArenaHandArea.<PlayResetCardTween>d__30 <PlayResetCardTween>d__;
			<PlayResetCardTween>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayResetCardTween>d__.<>4__this = this;
			<PlayResetCardTween>d__.cardId = cardId;
			<PlayResetCardTween>d__.<>1__state = -1;
			<PlayResetCardTween>d__.<>t__builder.Start<PhantomArenaHandArea.<PlayResetCardTween>d__30>(ref <PlayResetCardTween>d__);
			return <PlayResetCardTween>d__.<>t__builder.Task;
		}

		// Token: 0x0602B280 RID: 176768 RVA: 0x00C214B0 File Offset: 0x00C1F6B0
		private UniTask PlayHandCardToFunctionalTopTween(int cardId, UUIItem toItem, bool needDragUpTween)
		{
			PhantomArenaHandArea.<PlayHandCardToFunctionalTopTween>d__31 <PlayHandCardToFunctionalTopTween>d__;
			<PlayHandCardToFunctionalTopTween>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayHandCardToFunctionalTopTween>d__.<>4__this = this;
			<PlayHandCardToFunctionalTopTween>d__.cardId = cardId;
			<PlayHandCardToFunctionalTopTween>d__.toItem = toItem;
			<PlayHandCardToFunctionalTopTween>d__.needDragUpTween = needDragUpTween;
			<PlayHandCardToFunctionalTopTween>d__.<>1__state = -1;
			<PlayHandCardToFunctionalTopTween>d__.<>t__builder.Start<PhantomArenaHandArea.<PlayHandCardToFunctionalTopTween>d__31>(ref <PlayHandCardToFunctionalTopTween>d__);
			return <PlayHandCardToFunctionalTopTween>d__.<>t__builder.Task;
		}

		// Token: 0x0602B281 RID: 176769 RVA: 0x00C2150C File Offset: 0x00C1F70C
		public bool CheckCardOutHandArea(PhantomArenaCard card)
		{
			this.TempCardPos.FromUeVector(card.GetWorldLocation());
			this.ItemWorldTrans.InverseTransformPosition(this.TempCardPos, this.TempCardPos);
			return this.TempCardPos.Y - (double)card.HalfHeight > (double)this.TotalHeight || this.TempCardPos.Y + (double)card.HalfHeight < 0.0 || this.TempCardPos.X + (double)card.HalfWidth < (double)(-(double)this.TotalWidth / 2f) || this.TempCardPos.X - (double)card.HalfWidth > (double)(this.TotalWidth / 2f);
		}

		// Token: 0x0602B282 RID: 176770 RVA: 0x00C215C9 File Offset: 0x00C1F7C9
		public void RegisterBattleArea(PhantomArenaOwnArea area)
		{
			this.Area = area;
		}

		// Token: 0x0602B283 RID: 176771 RVA: 0x00C215D4 File Offset: 0x00C1F7D4
		public UniTask DestroyCardByLibrary(int cardId)
		{
			PhantomArenaHandArea.<DestroyCardByLibrary>d__34 <DestroyCardByLibrary>d__;
			<DestroyCardByLibrary>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<DestroyCardByLibrary>d__.<>4__this = this;
			<DestroyCardByLibrary>d__.cardId = cardId;
			<DestroyCardByLibrary>d__.<>1__state = -1;
			<DestroyCardByLibrary>d__.<>t__builder.Start<PhantomArenaHandArea.<DestroyCardByLibrary>d__34>(ref <DestroyCardByLibrary>d__);
			return <DestroyCardByLibrary>d__.<>t__builder.Task;
		}

		// Token: 0x0602B284 RID: 176772 RVA: 0x00C21620 File Offset: 0x00C1F820
		public void HoistLayout()
		{
			if (this.IsLayoutHoist)
			{
				return;
			}
			this.IsLayoutHoist = true;
			this.Sequence.StopPrevSequence(false, true);
			this.Sequence.PlaySequencePurely("Up", false, false);
			EventSystem.Instance.Emit<bool>(EEventName.OnPhantomArenaHandCardsShowHideChange, true);
		}

		// Token: 0x0602B285 RID: 176773 RVA: 0x00C21670 File Offset: 0x00C1F870
		public void LowerLayout()
		{
			if (!this.IsLayoutHoist)
			{
				return;
			}
			this.IsLayoutHoist = false;
			this.Sequence.StopPrevSequence(false, true);
			this.Sequence.PlaySequencePurely("Down", false, false);
			EventSystem.Instance.Emit<bool>(EEventName.OnPhantomArenaHandCardsShowHideChange, false);
		}

		// Token: 0x0602B286 RID: 176774 RVA: 0x00C216BD File Offset: 0x00C1F8BD
		public void SwitchLayoutHoist()
		{
			if (this.IsLayoutHoist)
			{
				this.LowerLayout();
				return;
			}
			this.HoistLayout();
		}

		// Token: 0x0602B287 RID: 176775 RVA: 0x00C216D4 File Offset: 0x00C1F8D4
		public PhantomArenaHandCardProxy GetCardProxy(int cardId)
		{
			if (!this.CardMap.ContainsKey(cardId))
			{
				return null;
			}
			return this.CardMap[cardId];
		}

		// Token: 0x0602B288 RID: 176776 RVA: 0x00C216F4 File Offset: 0x00C1F8F4
		public PhantomArenaHandCardProxy GetCardProxyByIndex(int index)
		{
			if (index < 0 || index >= this.CardMap.Count)
			{
				return null;
			}
			int num = 0;
			foreach (PhantomArenaHandCardProxy result in this.CardMap.Values)
			{
				if (num == index)
				{
					return result;
				}
				num++;
			}
			return null;
		}

		// Token: 0x0602B289 RID: 176777 RVA: 0x00C2176C File Offset: 0x00C1F96C
		public void RefreshHandCardSequence()
		{
			foreach (PhantomArenaHandCardProxy phantomArenaHandCardProxy in this.CardMap.Values)
			{
				if (phantomArenaHandCardProxy.IsInit && !phantomArenaHandCardProxy.CheckCardOutHandArea())
				{
					phantomArenaHandCardProxy.PlayInHandSequence();
				}
			}
		}

		// Token: 0x0602B28A RID: 176778 RVA: 0x00C217D4 File Offset: 0x00C1F9D4
		public UniTask StartTimeDrawCard(UUIItem fromItem)
		{
			PhantomArenaHandArea.<StartTimeDrawCard>d__41 <StartTimeDrawCard>d__;
			<StartTimeDrawCard>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<StartTimeDrawCard>d__.<>4__this = this;
			<StartTimeDrawCard>d__.fromItem = fromItem;
			<StartTimeDrawCard>d__.<>1__state = -1;
			<StartTimeDrawCard>d__.<>t__builder.Start<PhantomArenaHandArea.<StartTimeDrawCard>d__41>(ref <StartTimeDrawCard>d__);
			return <StartTimeDrawCard>d__.<>t__builder.Task;
		}

		// Token: 0x0602B28B RID: 176779 RVA: 0x00C21820 File Offset: 0x00C1FA20
		public UniTask EndTimeDiscardCard(UUIItem toItem)
		{
			PhantomArenaHandArea.<EndTimeDiscardCard>d__42 <EndTimeDiscardCard>d__;
			<EndTimeDiscardCard>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<EndTimeDiscardCard>d__.<>4__this = this;
			<EndTimeDiscardCard>d__.toItem = toItem;
			<EndTimeDiscardCard>d__.<>1__state = -1;
			<EndTimeDiscardCard>d__.<>t__builder.Start<PhantomArenaHandArea.<EndTimeDiscardCard>d__42>(ref <EndTimeDiscardCard>d__);
			return <EndTimeDiscardCard>d__.<>t__builder.Task;
		}

		// Token: 0x0602B28C RID: 176780 RVA: 0x00C2186C File Offset: 0x00C1FA6C
		public UniTask DiscardCard(UUIItem toItem, List<int> discardIdList)
		{
			PhantomArenaHandArea.<DiscardCard>d__43 <DiscardCard>d__;
			<DiscardCard>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<DiscardCard>d__.<>4__this = this;
			<DiscardCard>d__.toItem = toItem;
			<DiscardCard>d__.discardIdList = discardIdList;
			<DiscardCard>d__.<>1__state = -1;
			<DiscardCard>d__.<>t__builder.Start<PhantomArenaHandArea.<DiscardCard>d__43>(ref <DiscardCard>d__);
			return <DiscardCard>d__.<>t__builder.Task;
		}

		// Token: 0x0602B28D RID: 176781 RVA: 0x00C218C0 File Offset: 0x00C1FAC0
		public UniTask AddCard(List<int> cardIdList)
		{
			PhantomArenaHandArea.<AddCard>d__44 <AddCard>d__;
			<AddCard>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<AddCard>d__.<>4__this = this;
			<AddCard>d__.cardIdList = cardIdList;
			<AddCard>d__.<>1__state = -1;
			<AddCard>d__.<>t__builder.Start<PhantomArenaHandArea.<AddCard>d__44>(ref <AddCard>d__);
			return <AddCard>d__.<>t__builder.Task;
		}

		// Token: 0x0602B28E RID: 176782 RVA: 0x00C2190C File Offset: 0x00C1FB0C
		public UniTask RecycleCard(List<int> cardIdList)
		{
			PhantomArenaHandArea.<RecycleCard>d__45 <RecycleCard>d__;
			<RecycleCard>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RecycleCard>d__.<>4__this = this;
			<RecycleCard>d__.cardIdList = cardIdList;
			<RecycleCard>d__.<>1__state = -1;
			<RecycleCard>d__.<>t__builder.Start<PhantomArenaHandArea.<RecycleCard>d__45>(ref <RecycleCard>d__);
			return <RecycleCard>d__.<>t__builder.Task;
		}

		// Token: 0x0602B28F RID: 176783 RVA: 0x00C21958 File Offset: 0x00C1FB58
		public UniTask ResetCardPosition(PhantomArenaCard card)
		{
			PhantomArenaHandArea.<ResetCardPosition>d__46 <ResetCardPosition>d__;
			<ResetCardPosition>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ResetCardPosition>d__.<>4__this = this;
			<ResetCardPosition>d__.card = card;
			<ResetCardPosition>d__.<>1__state = -1;
			<ResetCardPosition>d__.<>t__builder.Start<PhantomArenaHandArea.<ResetCardPosition>d__46>(ref <ResetCardPosition>d__);
			return <ResetCardPosition>d__.<>t__builder.Task;
		}

		// Token: 0x0602B290 RID: 176784 RVA: 0x00C219A4 File Offset: 0x00C1FBA4
		public UniTask RemoveCard(PhantomArenaCard card)
		{
			PhantomArenaHandArea.<RemoveCard>d__47 <RemoveCard>d__;
			<RemoveCard>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RemoveCard>d__.<>4__this = this;
			<RemoveCard>d__.card = card;
			<RemoveCard>d__.<>1__state = -1;
			<RemoveCard>d__.<>t__builder.Start<PhantomArenaHandArea.<RemoveCard>d__47>(ref <RemoveCard>d__);
			return <RemoveCard>d__.<>t__builder.Task;
		}

		// Token: 0x0602B291 RID: 176785 RVA: 0x00C219F0 File Offset: 0x00C1FBF0
		public UniTask FunctionalToHand(PhantomArenaCard card)
		{
			PhantomArenaHandArea.<FunctionalToHand>d__48 <FunctionalToHand>d__;
			<FunctionalToHand>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<FunctionalToHand>d__.<>4__this = this;
			<FunctionalToHand>d__.card = card;
			<FunctionalToHand>d__.<>1__state = -1;
			<FunctionalToHand>d__.<>t__builder.Start<PhantomArenaHandArea.<FunctionalToHand>d__48>(ref <FunctionalToHand>d__);
			return <FunctionalToHand>d__.<>t__builder.Task;
		}

		// Token: 0x0602B292 RID: 176786 RVA: 0x00C21A3C File Offset: 0x00C1FC3C
		public UniTask HandToRecycle(PhantomArenaCard card)
		{
			PhantomArenaHandArea.<HandToRecycle>d__49 <HandToRecycle>d__;
			<HandToRecycle>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<HandToRecycle>d__.<>4__this = this;
			<HandToRecycle>d__.card = card;
			<HandToRecycle>d__.<>1__state = -1;
			<HandToRecycle>d__.<>t__builder.Start<PhantomArenaHandArea.<HandToRecycle>d__49>(ref <HandToRecycle>d__);
			return <HandToRecycle>d__.<>t__builder.Task;
		}

		// Token: 0x0602B293 RID: 176787 RVA: 0x00C21A88 File Offset: 0x00C1FC88
		public UniTask HandCardToFunctionalTop(PhantomArenaCard card, UUIItem toItem, bool needDragUpTween)
		{
			PhantomArenaHandArea.<HandCardToFunctionalTop>d__50 <HandCardToFunctionalTop>d__;
			<HandCardToFunctionalTop>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<HandCardToFunctionalTop>d__.<>4__this = this;
			<HandCardToFunctionalTop>d__.card = card;
			<HandCardToFunctionalTop>d__.toItem = toItem;
			<HandCardToFunctionalTop>d__.needDragUpTween = needDragUpTween;
			<HandCardToFunctionalTop>d__.<>1__state = -1;
			<HandCardToFunctionalTop>d__.<>t__builder.Start<PhantomArenaHandArea.<HandCardToFunctionalTop>d__50>(ref <HandCardToFunctionalTop>d__);
			return <HandCardToFunctionalTop>d__.<>t__builder.Task;
		}

		// Token: 0x0602B294 RID: 176788 RVA: 0x00C21AE4 File Offset: 0x00C1FCE4
		public UniTask ReconstructHandCardToRecycle(List<int> cardIdList)
		{
			PhantomArenaHandArea.<ReconstructHandCardToRecycle>d__51 <ReconstructHandCardToRecycle>d__;
			<ReconstructHandCardToRecycle>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ReconstructHandCardToRecycle>d__.<>4__this = this;
			<ReconstructHandCardToRecycle>d__.cardIdList = cardIdList;
			<ReconstructHandCardToRecycle>d__.<>1__state = -1;
			<ReconstructHandCardToRecycle>d__.<>t__builder.Start<PhantomArenaHandArea.<ReconstructHandCardToRecycle>d__51>(ref <ReconstructHandCardToRecycle>d__);
			return <ReconstructHandCardToRecycle>d__.<>t__builder.Task;
		}

		// Token: 0x0602B295 RID: 176789 RVA: 0x00C21B30 File Offset: 0x00C1FD30
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams == null || configParams.Length < 1)
			{
				return null;
			}
			string a = configParams[0];
			if (a == "HandCard")
			{
				if (configParams.Length < 2)
				{
					return null;
				}
				string a2 = configParams[1];
				List<PhantomArenaHandCardProxy> list = new List<PhantomArenaHandCardProxy>(this.CardMap.Values);
				if (a2 == "ConfigId")
				{
					int num = int.Parse(configParams[2]);
					foreach (PhantomArenaHandCardProxy phantomArenaHandCardProxy in list)
					{
						if (phantomArenaHandCardProxy.GetCard().Data.ConfigId == num)
						{
							return phantomArenaHandCardProxy.GetGuideUiItemAndUiItemForShowEx(configParams);
						}
					}
					return null;
				}
				int num2 = int.Parse(configParams[1]);
				if (num2 < 0 || num2 >= list.Count)
				{
					return null;
				}
				PhantomArenaHandCardProxy phantomArenaHandCardProxy2 = list[num2];
				if (phantomArenaHandCardProxy2 == null)
				{
					return null;
				}
				return phantomArenaHandCardProxy2.GetGuideUiItemAndUiItemForShowEx(configParams);
			}
			else
			{
				if (!(a == "HandArea"))
				{
					return null;
				}
				List<PhantomArenaHandCardProxy> list2 = new List<PhantomArenaHandCardProxy>(this.CardMap.Values);
				if (list2.Count <= 0)
				{
					return null;
				}
				PhantomArenaHandCardProxy phantomArenaHandCardProxy3 = list2[0];
				if (phantomArenaHandCardProxy3 == null)
				{
					return null;
				}
				return phantomArenaHandCardProxy3.GetGuideUiItemAndUiItemForShowEx(configParams);
			}
		}

		// Token: 0x040174F1 RID: 95473
		protected OrderedDictionary<int, PhantomArenaHandCardProxy> CardMap = new OrderedDictionary<int, PhantomArenaHandCardProxy>();

		// Token: 0x040174F2 RID: 95474
		protected PhantomArenaOwnArea Area;

		// Token: 0x040174F3 RID: 95475
		protected UUIHorizontalLayout Layout;

		// Token: 0x040174F4 RID: 95476
		protected readonly Transform ItemWorldTrans = Transform.Create();

		// Token: 0x040174F5 RID: 95477
		protected readonly Vector TempCardPos = Vector.Create();

		// Token: 0x040174F6 RID: 95478
		protected float TotalWidth;

		// Token: 0x040174F7 RID: 95479
		protected float TotalHeight;

		// Token: 0x040174F8 RID: 95480
		protected float GridWidth;

		// Token: 0x040174F9 RID: 95481
		protected float OriginalSpace;

		// Token: 0x040174FA RID: 95482
		protected float OriginalOffset;

		// Token: 0x040174FB RID: 95483
		protected UiSequencePlayer Sequence;

		// Token: 0x040174FC RID: 95484
		public bool IsLayoutHoist;

		// Token: 0x040174FD RID: 95485
		protected bool IsFirstTimeDrawCard = true;

		// Token: 0x02009F58 RID: 40792
		[NullableContext(0)]
		private static class EComponentDefine
		{
			// Token: 0x04031864 RID: 202852
			public const int Layout = 0;
		}
	}
}
