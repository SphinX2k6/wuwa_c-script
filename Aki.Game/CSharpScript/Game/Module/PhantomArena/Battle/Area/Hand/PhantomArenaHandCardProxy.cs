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
	// Token: 0x0200429B RID: 17051
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaHandCardProxy : IPhantomCardDragProxy, IPhantomCardProxyBase, IPhantomCardProxy
	{
		// Token: 0x0602B29C RID: 176796 RVA: 0x00C21D3F File Offset: 0x00C1FF3F
		public void Init(PhantomArenaCard card, PhantomArenaHandAreaItem areaItem, PhantomArenaOwnArea area)
		{
			this.Card = card;
			this.AreaItem = areaItem;
			this.Card.SetCardProxy(this);
			this.Area = area;
			this.IsInit = true;
		}

		// Token: 0x0602B29D RID: 176797 RVA: 0x00C21D6C File Offset: 0x00C1FF6C
		public void PointerClickCard(int id, EToggleState state)
		{
			Log.Instance.Info(ELogModule.PhantomArena, ELogAuthor.XXJ, "点击手牌", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.Area.CardClick(id);
		}

		// Token: 0x0602B29E RID: 176798 RVA: 0x00C21DA4 File Offset: 0x00C1FFA4
		public void PointerEnterCard(int id)
		{
		}

		// Token: 0x0602B29F RID: 176799 RVA: 0x00C21DA8 File Offset: 0x00C1FFA8
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

		// Token: 0x0602B2A0 RID: 176800 RVA: 0x00C21DFC File Offset: 0x00C1FFFC
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

		// Token: 0x0602B2A1 RID: 176801 RVA: 0x00C21E54 File Offset: 0x00C20054
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

		// Token: 0x0602B2A2 RID: 176802 RVA: 0x00C21EB4 File Offset: 0x00C200B4
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

		// Token: 0x0602B2A3 RID: 176803 RVA: 0x00C21EF0 File Offset: 0x00C200F0
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

		// Token: 0x0602B2A4 RID: 176804 RVA: 0x00C21F50 File Offset: 0x00C20150
		public UniTask Remove()
		{
			PhantomArenaHandCardProxy.<Remove>d__15 <Remove>d__;
			<Remove>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Remove>d__.<>4__this = this;
			<Remove>d__.<>1__state = -1;
			<Remove>d__.<>t__builder.Start<PhantomArenaHandCardProxy.<Remove>d__15>(ref <Remove>d__);
			return <Remove>d__.<>t__builder.Task;
		}

		// Token: 0x0602B2A5 RID: 176805 RVA: 0x00C21F94 File Offset: 0x00C20194
		public UniTask Clear()
		{
			PhantomArenaHandCardProxy.<Clear>d__16 <Clear>d__;
			<Clear>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Clear>d__.<>4__this = this;
			<Clear>d__.<>1__state = -1;
			<Clear>d__.<>t__builder.Start<PhantomArenaHandCardProxy.<Clear>d__16>(ref <Clear>d__);
			return <Clear>d__.<>t__builder.Task;
		}

		// Token: 0x0602B2A6 RID: 176806 RVA: 0x00C21FD8 File Offset: 0x00C201D8
		public UniTask RemoveBySequence()
		{
			PhantomArenaHandCardProxy.<RemoveBySequence>d__17 <RemoveBySequence>d__;
			<RemoveBySequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RemoveBySequence>d__.<>4__this = this;
			<RemoveBySequence>d__.<>1__state = -1;
			<RemoveBySequence>d__.<>t__builder.Start<PhantomArenaHandCardProxy.<RemoveBySequence>d__17>(ref <RemoveBySequence>d__);
			return <RemoveBySequence>d__.<>t__builder.Task;
		}

		// Token: 0x0602B2A7 RID: 176807 RVA: 0x00C2201C File Offset: 0x00C2021C
		public UniTask DissolveByLibrary()
		{
			PhantomArenaHandCardProxy.<DissolveByLibrary>d__18 <DissolveByLibrary>d__;
			<DissolveByLibrary>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<DissolveByLibrary>d__.<>4__this = this;
			<DissolveByLibrary>d__.<>1__state = -1;
			<DissolveByLibrary>d__.<>t__builder.Start<PhantomArenaHandCardProxy.<DissolveByLibrary>d__18>(ref <DissolveByLibrary>d__);
			return <DissolveByLibrary>d__.<>t__builder.Task;
		}

		// Token: 0x0602B2A8 RID: 176808 RVA: 0x00C2205F File Offset: 0x00C2025F
		public void PlayInHandSequence()
		{
			if (this.Area.FunctionalArea.CheckSettingCardPosition(this.Card))
			{
				this.Card.PlayStateSequence("UseStart");
				return;
			}
			this.Card.PlayStateSequence("UseClose");
		}

		// Token: 0x0602B2A9 RID: 176809 RVA: 0x00C2209A File Offset: 0x00C2029A
		private void PlayOutToInHandSequence()
		{
			if (this.Area.FunctionalArea.CheckSettingCardPosition(this.Card))
			{
				this.Card.PlayStateSequence("SeleToUse");
				return;
			}
			this.Card.PlayStateSequence("SeleClose");
		}

		// Token: 0x0602B2AA RID: 176810 RVA: 0x00C220D5 File Offset: 0x00C202D5
		private void PlayInToOutHandSequence()
		{
			if (this.Area.FunctionalArea.CheckSettingCardPosition(this.Card))
			{
				this.Card.PlayStateSequence("UseToSele");
			}
		}

		// Token: 0x0602B2AB RID: 176811 RVA: 0x00C220FF File Offset: 0x00C202FF
		private void PlayUseCloseSequence()
		{
			this.Card.PlayStateSequence("UseClose");
		}

		// Token: 0x0602B2AC RID: 176812 RVA: 0x00C22111 File Offset: 0x00C20311
		public bool CheckCardOutHandArea()
		{
			return this.Area.FunctionalArea.GetNearlyAreaItemProxyByCard(this.Card) != null || this.Area.ViewProxy.CardRecycle.CheckCardInRecycleArea(this.Card);
		}

		// Token: 0x0602B2AD RID: 176813 RVA: 0x00C22150 File Offset: 0x00C20350
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

		// Token: 0x0602B2AE RID: 176814 RVA: 0x00C221A4 File Offset: 0x00C203A4
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

		// Token: 0x0602B2AF RID: 176815 RVA: 0x00C221F8 File Offset: 0x00C203F8
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

		// Token: 0x0602B2B0 RID: 176816 RVA: 0x00C2224C File Offset: 0x00C2044C
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

		// Token: 0x0602B2B1 RID: 176817 RVA: 0x00C22298 File Offset: 0x00C20498
		public UniTask PlayResetPositionTween()
		{
			PhantomArenaHandCardProxy.<PlayResetPositionTween>d__28 <PlayResetPositionTween>d__;
			<PlayResetPositionTween>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayResetPositionTween>d__.<>4__this = this;
			<PlayResetPositionTween>d__.<>1__state = -1;
			<PlayResetPositionTween>d__.<>t__builder.Start<PhantomArenaHandCardProxy.<PlayResetPositionTween>d__28>(ref <PlayResetPositionTween>d__);
			return <PlayResetPositionTween>d__.<>t__builder.Task;
		}

		// Token: 0x0602B2B2 RID: 176818 RVA: 0x00C222DC File Offset: 0x00C204DC
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

		// Token: 0x0602B2B3 RID: 176819 RVA: 0x00C22330 File Offset: 0x00C20530
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

		// Token: 0x0602B2B4 RID: 176820 RVA: 0x00C2237C File Offset: 0x00C2057C
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

		// Token: 0x0602B2B5 RID: 176821 RVA: 0x00C223F1 File Offset: 0x00C205F1
		public bool IsNoAllowDiscard()
		{
			return this.Card.Data.IsNoAllowDiscard;
		}

		// Token: 0x0602B2B6 RID: 176822 RVA: 0x00C22403 File Offset: 0x00C20603
		public PhantomArenaCard GetCard()
		{
			return this.Card;
		}

		// Token: 0x0602B2B7 RID: 176823 RVA: 0x00C2240C File Offset: 0x00C2060C
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

		// Token: 0x0602B2B8 RID: 176824 RVA: 0x00C22457 File Offset: 0x00C20657
		public void SetHierarchyIndex(int index)
		{
			UUIItem originalItem = this.AreaItem.GetOriginalItem();
			if (originalItem == null)
			{
				return;
			}
			originalItem.SetHierarchyIndex(index);
		}

		// Token: 0x0602B2B9 RID: 176825 RVA: 0x00C22470 File Offset: 0x00C20670
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

		// Token: 0x040174FF RID: 95487
		private PhantomArenaCard Card;

		// Token: 0x04017500 RID: 95488
		protected PhantomArenaHandAreaItem AreaItem;

		// Token: 0x04017501 RID: 95489
		protected PhantomArenaOwnArea Area;

		// Token: 0x04017502 RID: 95490
		private bool IsCanDrag;

		// Token: 0x04017503 RID: 95491
		private int LayoutIndex = -1;

		// Token: 0x04017504 RID: 95492
		public bool IsInit;

		// Token: 0x04017505 RID: 95493
		protected bool IsInCardTween;
	}
}
