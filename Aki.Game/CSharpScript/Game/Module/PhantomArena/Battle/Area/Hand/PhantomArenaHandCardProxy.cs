using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.PhantomArena.Battle.Card;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Area.Hand
{
	// Token: 0x020052CB RID: 21195
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaHandCardProxy : IPhantomCardDragProxy, IPhantomCardProxyBase, IPhantomCardProxy
	{
		// Token: 0x060363A1 RID: 222113 RVA: 0x00CD4617 File Offset: 0x00CD2817
		public void Init(PhantomArenaCard card, PhantomArenaHandAreaItem areaItem, PhantomArenaOwnArea area)
		{
			this.Card = card;
			this.AreaItem = areaItem;
			this.Card.SetCardProxy(this);
			this.Area = area;
			this.IsInit = true;
		}

		// Token: 0x060363A2 RID: 222114 RVA: 0x00CD4644 File Offset: 0x00CD2844
		public void PointerClickCard(int id, EToggleState state)
		{
			Log.Instance.Info(ELogModule.PhantomArena, ELogAuthor.XXJ, "点击手牌", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.Area.CardClick(id);
		}

		// Token: 0x060363A3 RID: 222115 RVA: 0x00CD467C File Offset: 0x00CD287C
		public void PointerEnterCard(int id)
		{
		}

		// Token: 0x060363A4 RID: 222116 RVA: 0x00CD4680 File Offset: 0x00CD2880
		public void PointerDownCard(int id, ULGUIPointerEventData eventData)
		{
			this.IsCanDrag = this.IsCanDragCard(id);
			if (!this.IsCanDrag)
			{
				return;
			}
			Log.Instance.Info(ELogModule.PhantomArena, ELogAuthor.XXJ, "按下手牌", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.Card.RecordLastDragPos(eventData.pointerPosition);
		}

		// Token: 0x060363A5 RID: 222117 RVA: 0x00CD46D4 File Offset: 0x00CD28D4
		private bool IsCanDragCard(int id)
		{
			if (this.IsInCardTween)
			{
				return false;
			}
			if (PhantomArenaBattleModel.Instance.OwnData.HasBattleCardByCardId(id))
			{
				Log.Instance.Info(ELogModule.PhantomArena, ELogAuthor.XXJ, "场上存在相同卡牌id时不允许操作", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			return this.Area.IsCanDragCard(id);
		}

		// Token: 0x060363A6 RID: 222118 RVA: 0x00CD472C File Offset: 0x00CD292C
		public void PointerBeginDrag(int id, ULGUIPointerEventData eventData)
		{
			if (!this.IsCanDrag)
			{
				return;
			}
			Log.Instance.Info(ELogModule.PhantomArena, ELogAuthor.XXJ, "开始拖动手牌", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.Area.CardBeginDragByHand(this.Card);
			this.Card.PlaySequence("DragUpHandtoTable", false);
			this.PlayInToOutHandSequence();
		}

		// Token: 0x060363A7 RID: 222119 RVA: 0x00CD478C File Offset: 0x00CD298C
		public void PointerDragCard(int id, ULGUIPointerEventData eventData)
		{
			if (!this.IsCanDrag)
			{
				return;
			}
			FVector pointerPosition = eventData.pointerPosition;
			this.Card.MoveCard(pointerPosition);
			this.Area.CardDraggingByHand(this.Card);
		}

		// Token: 0x060363A8 RID: 222120 RVA: 0x00CD47C8 File Offset: 0x00CD29C8
		public void PointerEndDrag(int id, ULGUIPointerEventData eventData)
		{
			if (!this.IsCanDrag)
			{
				return;
			}
			Log.Instance.Info(ELogModule.PhantomArena, ELogAuthor.XXJ, "结束拖动手牌", default(ReadOnlySpan<ValueTuple<string, object>>));
			FVector pointerPosition = eventData.pointerPosition;
			this.Card.RecordLastDragPos(pointerPosition);
			this.Area.CardEndDragByHand(this.Card).Forget<bool>();
		}

		// Token: 0x060363A9 RID: 222121 RVA: 0x00CD4828 File Offset: 0x00CD2A28
		public UniTask Remove()
		{
			PhantomArenaHandCardProxy.<Remove>d__15 <Remove>d__;
			<Remove>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Remove>d__.<>4__this = this;
			<Remove>d__.<>1__state = -1;
			<Remove>d__.<>t__builder.Start<PhantomArenaHandCardProxy.<Remove>d__15>(ref <Remove>d__);
			return <Remove>d__.<>t__builder.Task;
		}

		// Token: 0x060363AA RID: 222122 RVA: 0x00CD486C File Offset: 0x00CD2A6C
		public UniTask Clear()
		{
			PhantomArenaHandCardProxy.<Clear>d__16 <Clear>d__;
			<Clear>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Clear>d__.<>4__this = this;
			<Clear>d__.<>1__state = -1;
			<Clear>d__.<>t__builder.Start<PhantomArenaHandCardProxy.<Clear>d__16>(ref <Clear>d__);
			return <Clear>d__.<>t__builder.Task;
		}

		// Token: 0x060363AB RID: 222123 RVA: 0x00CD48B0 File Offset: 0x00CD2AB0
		public UniTask RemoveBySequence()
		{
			PhantomArenaHandCardProxy.<RemoveBySequence>d__17 <RemoveBySequence>d__;
			<RemoveBySequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RemoveBySequence>d__.<>4__this = this;
			<RemoveBySequence>d__.<>1__state = -1;
			<RemoveBySequence>d__.<>t__builder.Start<PhantomArenaHandCardProxy.<RemoveBySequence>d__17>(ref <RemoveBySequence>d__);
			return <RemoveBySequence>d__.<>t__builder.Task;
		}

		// Token: 0x060363AC RID: 222124 RVA: 0x00CD48F4 File Offset: 0x00CD2AF4
		public UniTask DissolveByLibrary()
		{
			PhantomArenaHandCardProxy.<DissolveByLibrary>d__18 <DissolveByLibrary>d__;
			<DissolveByLibrary>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<DissolveByLibrary>d__.<>4__this = this;
			<DissolveByLibrary>d__.<>1__state = -1;
			<DissolveByLibrary>d__.<>t__builder.Start<PhantomArenaHandCardProxy.<DissolveByLibrary>d__18>(ref <DissolveByLibrary>d__);
			return <DissolveByLibrary>d__.<>t__builder.Task;
		}

		// Token: 0x060363AD RID: 222125 RVA: 0x00CD4937 File Offset: 0x00CD2B37
		public void PlayInHandSequence()
		{
			if (this.Area.FunctionalArea.CheckSettingCardPosition(this.Card))
			{
				this.Card.PlayStateSequence("UseStart");
				return;
			}
			this.Card.PlayStateSequence("UseClose");
		}

		// Token: 0x060363AE RID: 222126 RVA: 0x00CD4972 File Offset: 0x00CD2B72
		private void PlayOutToInHandSequence()
		{
			if (this.Area.FunctionalArea.CheckSettingCardPosition(this.Card))
			{
				this.Card.PlayStateSequence("SeleToUse");
				return;
			}
			this.Card.PlayStateSequence("SeleClose");
		}

		// Token: 0x060363AF RID: 222127 RVA: 0x00CD49AD File Offset: 0x00CD2BAD
		private void PlayInToOutHandSequence()
		{
			if (this.Area.FunctionalArea.CheckSettingCardPosition(this.Card))
			{
				this.Card.PlayStateSequence("UseToSele");
			}
		}

		// Token: 0x060363B0 RID: 222128 RVA: 0x00CD49D7 File Offset: 0x00CD2BD7
		private void PlayUseCloseSequence()
		{
			this.Card.PlayStateSequence("UseClose");
		}

		// Token: 0x060363B1 RID: 222129 RVA: 0x00CD49E9 File Offset: 0x00CD2BE9
		public bool CheckCardOutHandArea()
		{
			return this.Area.FunctionalArea.GetNearlyAreaItemProxyByCard(this.Card) != null || this.Area.ViewProxy.CardRecycle.CheckCardInRecycleArea(this.Card);
		}

		// Token: 0x060363B2 RID: 222130 RVA: 0x00CD4A28 File Offset: 0x00CD2C28
		public UniTask PlayStartTimeLocationTween(UUIItem fromItem, int delayTime)
		{
			PhantomArenaHandCardProxy.<PlayStartTimeLocationTween>d__24 <PlayStartTimeLocationTween>d__;
			<PlayStartTimeLocationTween>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayStartTimeLocationTween>d__.<>4__this = this;
			<PlayStartTimeLocationTween>d__.fromItem = fromItem;
			<PlayStartTimeLocationTween>d__.delayTime = delayTime;
			<PlayStartTimeLocationTween>d__.<>1__state = -1;
			<PlayStartTimeLocationTween>d__.<>t__builder.Start<PhantomArenaHandCardProxy.<PlayStartTimeLocationTween>d__24>(ref <PlayStartTimeLocationTween>d__);
			return <PlayStartTimeLocationTween>d__.<>t__builder.Task;
		}

		// Token: 0x060363B3 RID: 222131 RVA: 0x00CD4A7C File Offset: 0x00CD2C7C
		public UniTask PlayEndTimeLocationTween(UUIItem toItem, int delayTime)
		{
			PhantomArenaHandCardProxy.<PlayEndTimeLocationTween>d__25 <PlayEndTimeLocationTween>d__;
			<PlayEndTimeLocationTween>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayEndTimeLocationTween>d__.<>4__this = this;
			<PlayEndTimeLocationTween>d__.toItem = toItem;
			<PlayEndTimeLocationTween>d__.delayTime = delayTime;
			<PlayEndTimeLocationTween>d__.<>1__state = -1;
			<PlayEndTimeLocationTween>d__.<>t__builder.Start<PhantomArenaHandCardProxy.<PlayEndTimeLocationTween>d__25>(ref <PlayEndTimeLocationTween>d__);
			return <PlayEndTimeLocationTween>d__.<>t__builder.Task;
		}

		// Token: 0x060363B4 RID: 222132 RVA: 0x00CD4AD0 File Offset: 0x00CD2CD0
		public UniTask PlayDiscardCardTween(UUIItem toItem, int delayTime)
		{
			PhantomArenaHandCardProxy.<PlayDiscardCardTween>d__26 <PlayDiscardCardTween>d__;
			<PlayDiscardCardTween>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayDiscardCardTween>d__.<>4__this = this;
			<PlayDiscardCardTween>d__.toItem = toItem;
			<PlayDiscardCardTween>d__.delayTime = delayTime;
			<PlayDiscardCardTween>d__.<>1__state = -1;
			<PlayDiscardCardTween>d__.<>t__builder.Start<PhantomArenaHandCardProxy.<PlayDiscardCardTween>d__26>(ref <PlayDiscardCardTween>d__);
			return <PlayDiscardCardTween>d__.<>t__builder.Task;
		}

		// Token: 0x060363B5 RID: 222133 RVA: 0x00CD4B24 File Offset: 0x00CD2D24
		public UniTask PlayHandRecycleCardTween(int delayTime)
		{
			PhantomArenaHandCardProxy.<PlayHandRecycleCardTween>d__27 <PlayHandRecycleCardTween>d__;
			<PlayHandRecycleCardTween>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayHandRecycleCardTween>d__.<>4__this = this;
			<PlayHandRecycleCardTween>d__.delayTime = delayTime;
			<PlayHandRecycleCardTween>d__.<>1__state = -1;
			<PlayHandRecycleCardTween>d__.<>t__builder.Start<PhantomArenaHandCardProxy.<PlayHandRecycleCardTween>d__27>(ref <PlayHandRecycleCardTween>d__);
			return <PlayHandRecycleCardTween>d__.<>t__builder.Task;
		}

		// Token: 0x060363B6 RID: 222134 RVA: 0x00CD4B70 File Offset: 0x00CD2D70
		public UniTask PlayResetPositionTween()
		{
			PhantomArenaHandCardProxy.<PlayResetPositionTween>d__28 <PlayResetPositionTween>d__;
			<PlayResetPositionTween>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayResetPositionTween>d__.<>4__this = this;
			<PlayResetPositionTween>d__.<>1__state = -1;
			<PlayResetPositionTween>d__.<>t__builder.Start<PhantomArenaHandCardProxy.<PlayResetPositionTween>d__28>(ref <PlayResetPositionTween>d__);
			return <PlayResetPositionTween>d__.<>t__builder.Task;
		}

		// Token: 0x060363B7 RID: 222135 RVA: 0x00CD4BB4 File Offset: 0x00CD2DB4
		public UniTask PlayHandToFunctionalTopTween(UUIItem toItem, bool needDragUpTween)
		{
			PhantomArenaHandCardProxy.<PlayHandToFunctionalTopTween>d__29 <PlayHandToFunctionalTopTween>d__;
			<PlayHandToFunctionalTopTween>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayHandToFunctionalTopTween>d__.<>4__this = this;
			<PlayHandToFunctionalTopTween>d__.toItem = toItem;
			<PlayHandToFunctionalTopTween>d__.needDragUpTween = needDragUpTween;
			<PlayHandToFunctionalTopTween>d__.<>1__state = -1;
			<PlayHandToFunctionalTopTween>d__.<>t__builder.Start<PhantomArenaHandCardProxy.<PlayHandToFunctionalTopTween>d__29>(ref <PlayHandToFunctionalTopTween>d__);
			return <PlayHandToFunctionalTopTween>d__.<>t__builder.Task;
		}

		// Token: 0x060363B8 RID: 222136 RVA: 0x00CD4C08 File Offset: 0x00CD2E08
		public UniTask CallHandCardToFight(UUIItem toItem)
		{
			PhantomArenaHandCardProxy.<CallHandCardToFight>d__30 <CallHandCardToFight>d__;
			<CallHandCardToFight>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CallHandCardToFight>d__.<>4__this = this;
			<CallHandCardToFight>d__.toItem = toItem;
			<CallHandCardToFight>d__.<>1__state = -1;
			<CallHandCardToFight>d__.<>t__builder.Start<PhantomArenaHandCardProxy.<CallHandCardToFight>d__30>(ref <CallHandCardToFight>d__);
			return <CallHandCardToFight>d__.<>t__builder.Task;
		}

		// Token: 0x060363B9 RID: 222137 RVA: 0x00CD4C54 File Offset: 0x00CD2E54
		public void SetCardSelectedState(bool value)
		{
			if (value)
			{
				this.LayoutIndex = this.AreaItem.GetOriginalItem().GetHierarchyIndex();
				this.AreaItem.GetOriginalItem().SetAsLastHierarchy();
				this.Card.SetSelectedState(true);
				return;
			}
			if (this.LayoutIndex != -1)
			{
				this.AreaItem.GetOriginalItem().SetHierarchyIndex(this.LayoutIndex);
				this.LayoutIndex = -1;
			}
			this.Card.SetSelectedState(false);
		}

		// Token: 0x060363BA RID: 222138 RVA: 0x00CD4CC9 File Offset: 0x00CD2EC9
		public bool IsNoAllowDiscard()
		{
			return this.Card.Data.IsNoAllowDiscard;
		}

		// Token: 0x060363BB RID: 222139 RVA: 0x00CD4CDB File Offset: 0x00CD2EDB
		public PhantomArenaCard GetCard()
		{
			return this.Card;
		}

		// Token: 0x060363BC RID: 222140 RVA: 0x00CD4CE4 File Offset: 0x00CD2EE4
		public UniTask RefreshCardData(PhantomCardData data)
		{
			PhantomArenaHandCardProxy.<RefreshCardData>d__34 <RefreshCardData>d__;
			<RefreshCardData>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshCardData>d__.<>4__this = this;
			<RefreshCardData>d__.data = data;
			<RefreshCardData>d__.<>1__state = -1;
			<RefreshCardData>d__.<>t__builder.Start<PhantomArenaHandCardProxy.<RefreshCardData>d__34>(ref <RefreshCardData>d__);
			return <RefreshCardData>d__.<>t__builder.Task;
		}

		// Token: 0x060363BD RID: 222141 RVA: 0x00CD4D2F File Offset: 0x00CD2F2F
		public void SetHierarchyIndex(int index)
		{
			UUIItem originalItem = this.AreaItem.GetOriginalItem();
			if (originalItem == null)
			{
				return;
			}
			originalItem.SetHierarchyIndex(index);
		}

		// Token: 0x060363BE RID: 222142 RVA: 0x00CD4D48 File Offset: 0x00CD2F48
		public UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams == null || configParams.Length == 0)
			{
				return null;
			}
			string a = configParams[0];
			if (!(a == "HandCard") && !(a == "HandArea"))
			{
				return null;
			}
			if (!Info.Instance.IsInGamepad())
			{
				return this.Card.GetGuideUiItemAndUiItemForShowEx(configParams);
			}
			UUIItem guideUiItem = this.AreaItem.GetGuideUiItem("0");
			if (guideUiItem != null)
			{
				return new UUIItem[]
				{
					guideUiItem,
					guideUiItem
				};
			}
			return null;
		}

		// Token: 0x0401CACA RID: 117450
		private PhantomArenaCard Card;

		// Token: 0x0401CACB RID: 117451
		protected PhantomArenaHandAreaItem AreaItem;

		// Token: 0x0401CACC RID: 117452
		protected PhantomArenaOwnArea Area;

		// Token: 0x0401CACD RID: 117453
		private bool IsCanDrag;

		// Token: 0x0401CACE RID: 117454
		private int LayoutIndex = -1;

		// Token: 0x0401CACF RID: 117455
		public bool IsInit;

		// Token: 0x0401CAD0 RID: 117456
		protected bool IsInCardTween;
	}
}
