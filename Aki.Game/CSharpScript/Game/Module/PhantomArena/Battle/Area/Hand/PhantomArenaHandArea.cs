using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PhantomArena.Battle.Card;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Area.Hand
{
	// Token: 0x020052C9 RID: 21193
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaHandArea : UiPanelBase
	{
		// Token: 0x06036374 RID: 222068 RVA: 0x00CD382E File Offset: 0x00CD1A2E
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout))
			};
		}

		// Token: 0x06036375 RID: 222069 RVA: 0x00CD3854 File Offset: 0x00CD1A54
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

		// Token: 0x06036376 RID: 222070 RVA: 0x00CD3902 File Offset: 0x00CD1B02
		protected override void OnBeforeDestroy()
		{
			this.Sequence.Clear();
		}

		// Token: 0x06036377 RID: 222071 RVA: 0x00CD3910 File Offset: 0x00CD1B10
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

		// Token: 0x06036378 RID: 222072 RVA: 0x00CD3954 File Offset: 0x00CD1B54
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

		// Token: 0x06036379 RID: 222073 RVA: 0x00CD39F0 File Offset: 0x00CD1BF0
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

		// Token: 0x0603637A RID: 222074 RVA: 0x00CD3A3C File Offset: 0x00CD1C3C
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

		// Token: 0x0603637B RID: 222075 RVA: 0x00CD3A88 File Offset: 0x00CD1C88
		private UniTask InitCardList()
		{
			PhantomArenaHandArea.<InitCardList>d__21 <InitCardList>d__;
			<InitCardList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitCardList>d__.<>4__this = this;
			<InitCardList>d__.<>1__state = -1;
			<InitCardList>d__.<>t__builder.Start<PhantomArenaHandArea.<InitCardList>d__21>(ref <InitCardList>d__);
			return <InitCardList>d__.<>t__builder.Task;
		}

		// Token: 0x0603637C RID: 222076 RVA: 0x00CD3ACC File Offset: 0x00CD1CCC
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

		// Token: 0x0603637D RID: 222077 RVA: 0x00CD3B18 File Offset: 0x00CD1D18
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

		// Token: 0x0603637E RID: 222078 RVA: 0x00CD3B64 File Offset: 0x00CD1D64
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

		// Token: 0x0603637F RID: 222079 RVA: 0x00CD3BB0 File Offset: 0x00CD1DB0
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

		// Token: 0x06036380 RID: 222080 RVA: 0x00CD3BFC File Offset: 0x00CD1DFC
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

		// Token: 0x06036381 RID: 222081 RVA: 0x00CD3C48 File Offset: 0x00CD1E48
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

		// Token: 0x06036382 RID: 222082 RVA: 0x00CD3C9C File Offset: 0x00CD1E9C
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

		// Token: 0x06036383 RID: 222083 RVA: 0x00CD3CF0 File Offset: 0x00CD1EF0
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

		// Token: 0x06036384 RID: 222084 RVA: 0x00CD3D3C File Offset: 0x00CD1F3C
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

		// Token: 0x06036385 RID: 222085 RVA: 0x00CD3D88 File Offset: 0x00CD1F88
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

		// Token: 0x06036386 RID: 222086 RVA: 0x00CD3DE4 File Offset: 0x00CD1FE4
		public bool CheckCardOutHandArea(PhantomArenaCard card)
		{
			this.TempCardPos.FromUeVector(card.GetWorldLocation());
			this.ItemWorldTrans.InverseTransformPosition(this.TempCardPos, this.TempCardPos);
			return this.TempCardPos.Y - (double)card.HalfHeight > (double)this.TotalHeight || this.TempCardPos.Y + (double)card.HalfHeight < 0.0 || this.TempCardPos.X + (double)card.HalfWidth < (double)(-(double)this.TotalWidth / 2f) || this.TempCardPos.X - (double)card.HalfWidth > (double)(this.TotalWidth / 2f);
		}

		// Token: 0x06036387 RID: 222087 RVA: 0x00CD3EA1 File Offset: 0x00CD20A1
		public void RegisterBattleArea(PhantomArenaOwnArea area)
		{
			this.Area = area;
		}

		// Token: 0x06036388 RID: 222088 RVA: 0x00CD3EAC File Offset: 0x00CD20AC
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

		// Token: 0x06036389 RID: 222089 RVA: 0x00CD3EF8 File Offset: 0x00CD20F8
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

		// Token: 0x0603638A RID: 222090 RVA: 0x00CD3F48 File Offset: 0x00CD2148
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

		// Token: 0x0603638B RID: 222091 RVA: 0x00CD3F95 File Offset: 0x00CD2195
		public void SwitchLayoutHoist()
		{
			if (this.IsLayoutHoist)
			{
				this.LowerLayout();
				return;
			}
			this.HoistLayout();
		}

		// Token: 0x0603638C RID: 222092 RVA: 0x00CD3FAC File Offset: 0x00CD21AC
		public PhantomArenaHandCardProxy GetCardProxy(int cardId)
		{
			if (!this.CardMap.ContainsKey(cardId))
			{
				return null;
			}
			return this.CardMap[cardId];
		}

		// Token: 0x0603638D RID: 222093 RVA: 0x00CD3FCC File Offset: 0x00CD21CC
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

		// Token: 0x0603638E RID: 222094 RVA: 0x00CD4044 File Offset: 0x00CD2244
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

		// Token: 0x0603638F RID: 222095 RVA: 0x00CD40AC File Offset: 0x00CD22AC
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

		// Token: 0x06036390 RID: 222096 RVA: 0x00CD40F8 File Offset: 0x00CD22F8
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

		// Token: 0x06036391 RID: 222097 RVA: 0x00CD4144 File Offset: 0x00CD2344
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

		// Token: 0x06036392 RID: 222098 RVA: 0x00CD4198 File Offset: 0x00CD2398
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

		// Token: 0x06036393 RID: 222099 RVA: 0x00CD41E4 File Offset: 0x00CD23E4
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

		// Token: 0x06036394 RID: 222100 RVA: 0x00CD4230 File Offset: 0x00CD2430
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

		// Token: 0x06036395 RID: 222101 RVA: 0x00CD427C File Offset: 0x00CD247C
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

		// Token: 0x06036396 RID: 222102 RVA: 0x00CD42C8 File Offset: 0x00CD24C8
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

		// Token: 0x06036397 RID: 222103 RVA: 0x00CD4314 File Offset: 0x00CD2514
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

		// Token: 0x06036398 RID: 222104 RVA: 0x00CD4360 File Offset: 0x00CD2560
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

		// Token: 0x06036399 RID: 222105 RVA: 0x00CD43BC File Offset: 0x00CD25BC
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

		// Token: 0x0603639A RID: 222106 RVA: 0x00CD4408 File Offset: 0x00CD2608
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
				List<PhantomArenaHandCardProxy> list = this.CardMap.Values.ToList<PhantomArenaHandCardProxy>();
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
				List<PhantomArenaHandCardProxy> list2 = this.CardMap.Values.ToList<PhantomArenaHandCardProxy>();
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

		// Token: 0x0401CABC RID: 117436
		protected OrderedDictionary<int, PhantomArenaHandCardProxy> CardMap = new OrderedDictionary<int, PhantomArenaHandCardProxy>();

		// Token: 0x0401CABD RID: 117437
		protected PhantomArenaOwnArea Area;

		// Token: 0x0401CABE RID: 117438
		protected UUIHorizontalLayout Layout;

		// Token: 0x0401CABF RID: 117439
		protected readonly Transform ItemWorldTrans = Transform.Create();

		// Token: 0x0401CAC0 RID: 117440
		protected readonly Vector TempCardPos = Vector.Create();

		// Token: 0x0401CAC1 RID: 117441
		protected float TotalWidth;

		// Token: 0x0401CAC2 RID: 117442
		protected float TotalHeight;

		// Token: 0x0401CAC3 RID: 117443
		protected float GridWidth;

		// Token: 0x0401CAC4 RID: 117444
		protected float OriginalSpace;

		// Token: 0x0401CAC5 RID: 117445
		protected float OriginalOffset;

		// Token: 0x0401CAC6 RID: 117446
		protected UiSequencePlayer Sequence;

		// Token: 0x0401CAC7 RID: 117447
		public bool IsLayoutHoist;

		// Token: 0x0401CAC8 RID: 117448
		protected bool IsFirstTimeDrawCard = true;

		// Token: 0x0200B520 RID: 46368
		[NullableContext(0)]
		private static class EComponentDefine
		{
			// Token: 0x04036E11 RID: 224785
			public const int Layout = 0;
		}
	}
}
