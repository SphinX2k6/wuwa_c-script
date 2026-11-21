using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Operation;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Views;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02005749 RID: 22345
	[NullableContext(2)]
	[Nullable(0)]
	public abstract class DangoBrawlViewItemBase : DangoBrawlItemViewBase, IDangoBrawlDraggableView
	{
		// Token: 0x17006A67 RID: 27239
		// (get) Token: 0x0603715A RID: 225626 RVA: 0x00F5FACA File Offset: 0x00F5DCCA
		protected DangoBrawlTouchController Touch
		{
			get
			{
				return DangoBrawlModel.Instance.GetTouchController();
			}
		}

		// Token: 0x17006A68 RID: 27240
		// (get) Token: 0x0603715B RID: 225627 RVA: 0x00F5FAD6 File Offset: 0x00F5DCD6
		protected InteractionStateMachine Fsm
		{
			get
			{
				DangoBrawlTouchController touchController = DangoBrawlModel.Instance.GetTouchController();
				if (touchController == null)
				{
					return null;
				}
				return touchController.GetInteractionFsm();
			}
		}

		// Token: 0x17006A69 RID: 27241
		// (get) Token: 0x0603715C RID: 225628 RVA: 0x00F5FAED File Offset: 0x00F5DCED
		protected DangoBrawlOperationDispatcher Operations
		{
			get
			{
				return DangoBrawlModel.Instance.GetOperationDispatcher();
			}
		}

		// Token: 0x17006A6A RID: 27242
		// (get) Token: 0x0603715D RID: 225629 RVA: 0x00F5FAF9 File Offset: 0x00F5DCF9
		protected DangoBrawlItemViewRegistry Registry
		{
			get
			{
				return DangoBrawlModel.Instance.GetViewRegistry();
			}
		}

		// Token: 0x0603715E RID: 225630 RVA: 0x00F5FB08 File Offset: 0x00F5DD08
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlViewItemBase.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlViewItemBase.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603715F RID: 225631 RVA: 0x00F5FB4C File Offset: 0x00F5DD4C
		protected override void OnBeforeDestroy()
		{
			base.OnBeforeDestroy();
			DangoBrawlTouchController touch = this.Touch;
			if (touch != null)
			{
				touch.GetContext().ClearHoveredItemIfMatch(this.SourceKind, base.Uid);
			}
			UniTaskCompletionSource flyToGoldTcs = this.FlyToGoldTcs;
			if (flyToGoldTcs != null)
			{
				flyToGoldTcs.TrySetResult();
			}
			LguiFloatTween flyToGoldTween = this.FlyToGoldTween;
			if (flyToGoldTween != null)
			{
				flyToGoldTween.Destroy();
			}
			this.FlyToGoldTween = null;
			this.FlyToGoldTcs = null;
			this.UnbindEventListeners();
		}

		// Token: 0x06037160 RID: 225632 RVA: 0x00F5FBB8 File Offset: 0x00F5DDB8
		private void BindEventListeners()
		{
			EventSystem.Instance.Add(EEventName.OnDangoBrawlLayerModeChanged, new Action<bool>(this.OnDangoBrawlLayerModeChanged));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlRoundStartEffectsReady, new Action(this.OnDangoBrawlRoundStartEffectsReady));
			UUIDraggableComponent draggable = base.GetDraggable(1);
			if (draggable != null)
			{
				draggable.OnPointerUpCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerUp));
				draggable.OnPointerBeginDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnBeginDrag));
				draggable.OnPointerDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnDrag));
				draggable.OnPointerEndDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnEndDrag));
			}
		}

		// Token: 0x06037161 RID: 225633 RVA: 0x00F5FC6C File Offset: 0x00F5DE6C
		private void UnbindEventListeners()
		{
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlLayerModeChanged, new Action<bool>(this.OnDangoBrawlLayerModeChanged));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlRoundStartEffectsReady, new Action(this.OnDangoBrawlRoundStartEffectsReady));
			UUIDraggableComponent draggable = base.GetDraggable(1);
			if (draggable != null)
			{
				draggable.OnPointerUpCallBack.Unbind();
				draggable.OnPointerBeginDragCallBack.Unbind();
				draggable.OnPointerDragCallBack.Unbind();
				draggable.OnPointerEndDragCallBack.Unbind();
			}
		}

		// Token: 0x06037162 RID: 225634 RVA: 0x00F5FCEC File Offset: 0x00F5DEEC
		public virtual void RefreshView()
		{
			EDangoBrawlRotate boundRotate = this.GetBoundRotate();
			this.RefreshIcon();
			base.RefreshBoundSize(boundRotate);
			base.RefreshShadow(boundRotate);
			DangoBrawlTouchController touch = this.Touch;
			bool selectedVisualState = touch != null && touch.GetContext().IsSelected(this.SourceKind, base.Uid);
			this.SetSelectedVisualState(selectedVisualState);
			DangoBrawlTouchController touch2 = this.Touch;
			int? num = (touch2 != null) ? touch2.DraggingUid : null;
			int uid = base.Uid;
			bool flag;
			if (!(num.GetValueOrDefault() == uid & num != null))
			{
				InteractionStateMachine fsm = this.Fsm;
				if (fsm == null || !fsm.CheckIsInState(base.Uid, EInteractionState.Sticky))
				{
					InteractionStateMachine fsm2 = this.Fsm;
					flag = (fsm2 != null && fsm2.CheckIsInState(base.Uid, EInteractionState.Holding));
					goto IL_B6;
				}
			}
			flag = true;
			IL_B6:
			bool draggingVisualState = flag;
			this.SetDraggingVisualState(draggingVisualState);
		}

		// Token: 0x06037163 RID: 225635 RVA: 0x00F5FDB7 File Offset: 0x00F5DFB7
		public void SetSourceKind(EDragSourceKind kind)
		{
			this.SourceKind = kind;
		}

		// Token: 0x06037164 RID: 225636 RVA: 0x00F5FDC0 File Offset: 0x00F5DFC0
		public EDragSourceKind GetDragSourceKind()
		{
			return this.SourceKind;
		}

		// Token: 0x06037165 RID: 225637 RVA: 0x00F5FDC8 File Offset: 0x00F5DFC8
		[NullableContext(1)]
		public void Migrate(UUIItem newContainer, EDragSourceKind newSourceKind, DangoBrawlItemBase newItemData, int newGridSize)
		{
			if (this.RootItem != null && this.RootItem.IsValid())
			{
				DangoBrawlUtil.ReparentMoveKeepWorld(this.RootItem, newContainer);
			}
			this.SetSourceKind(newSourceKind);
			this.SetFloatingVisualState(false);
			this.ItemData = newItemData;
			this.GridSize = newGridSize;
			this.RefreshView();
		}

		// Token: 0x06037166 RID: 225638 RVA: 0x00F5FE19 File Offset: 0x00F5E019
		public virtual void SetDragOtherVisualState(bool val)
		{
			this.SetVisual(EItemVisualState.DragOther, val, true);
		}

		// Token: 0x06037167 RID: 225639 RVA: 0x00F5FE24 File Offset: 0x00F5E024
		public virtual void SetDraggingVisualState(bool val)
		{
			this.SetVisual(EItemVisualState.Dragging, val, false);
		}

		// Token: 0x06037168 RID: 225640 RVA: 0x00F5FE30 File Offset: 0x00F5E030
		public virtual void SetFloatingVisualState(bool val)
		{
			this.SetVisual(EItemVisualState.Floating, val, false);
		}

		// Token: 0x06037169 RID: 225641 RVA: 0x00F5FE3B File Offset: 0x00F5E03B
		public virtual void SetInLayerModeVisualState(bool val)
		{
			this.SetVisual(EItemVisualState.InLayerMode, val, false);
		}

		// Token: 0x0603716A RID: 225642 RVA: 0x00F5FE46 File Offset: 0x00F5E046
		public virtual void SetHoveredVisualState(bool val)
		{
			this.SetVisual(EItemVisualState.Hovered, val, false);
		}

		// Token: 0x0603716B RID: 225643 RVA: 0x00F5FE52 File Offset: 0x00F5E052
		public virtual void SetSelectedVisualState(bool val)
		{
			this.SetVisual(EItemVisualState.Selected, val, true);
			this.IsSelected = val;
		}

		// Token: 0x0603716C RID: 225644 RVA: 0x00F5FE64 File Offset: 0x00F5E064
		protected void SetVisual(EItemVisualState flag, bool on, bool forceUpdate = false)
		{
			EItemVisualState eitemVisualState = on ? (this.VisualState | flag) : (this.VisualState & ~flag);
			if (eitemVisualState == this.VisualState && !forceUpdate)
			{
				return;
			}
			EItemVisualState visualState = this.VisualState;
			this.VisualState = eitemVisualState;
			this.PresentVisual(visualState);
		}

		// Token: 0x0603716D RID: 225645 RVA: 0x00F5FEAA File Offset: 0x00F5E0AA
		protected bool HasVisual(EItemVisualState flag)
		{
			return (this.VisualState & flag) > EItemVisualState.None;
		}

		// Token: 0x0603716E RID: 225646 RVA: 0x00F5FEB8 File Offset: 0x00F5E0B8
		private void PresentVisual(EItemVisualState prev = EItemVisualState.None)
		{
			bool flag = (prev & EItemVisualState.InLayerMode) > EItemVisualState.None;
			bool flag2 = this.HasVisual(EItemVisualState.InLayerMode);
			if (!flag && flag2)
			{
				this.PlayLayerModeSequence(true);
			}
			else if (flag && !flag2)
			{
				this.PlayLayerModeSequence(false);
			}
			bool flag3 = (prev & EItemVisualState.Selected) > EItemVisualState.None;
			if (this.HasVisual(EItemVisualState.Selected))
			{
				if (!flag3)
				{
					UiSequencePlayer sequencePlayer = this.SequencePlayer;
					if (sequencePlayer != null)
					{
						sequencePlayer.PlaySequencePurely("Drop", false, false);
					}
				}
				if (this.ItemData.MyTemplateType != EDangoBrawlTemplateType.Bag)
				{
					UUIItem rootItem = this.RootItem;
					if (rootItem != null)
					{
						rootItem.SetAsLastHierarchy();
					}
				}
			}
			else if (this.IsSelected && !this.IsDragging)
			{
				UiSequencePlayer sequencePlayer2 = this.SequencePlayer;
				if (sequencePlayer2 != null)
				{
					sequencePlayer2.PlaySequencePurely("Unselected", false, false);
				}
			}
			bool flag4 = (prev & EItemVisualState.DragOther) > EItemVisualState.None;
			bool flag5 = this.HasVisual(EItemVisualState.DragOther);
			if (!flag4 && flag5)
			{
				this.PlayDragOtherSequence(true);
			}
			else if (flag4 && !flag5)
			{
				this.PlayDragOtherSequence(false);
			}
			bool flag6 = (prev & EItemVisualState.Dragging) > EItemVisualState.None;
			bool flag7 = this.HasVisual(EItemVisualState.Dragging);
			if (!flag6 && flag7)
			{
				UiSequencePlayer sequencePlayer3 = this.SequencePlayer;
				if (sequencePlayer3 != null)
				{
					sequencePlayer3.PlaySequencePurely("Grab", false, false);
				}
			}
			else if (flag6 && !flag7)
			{
				UiSequencePlayer sequencePlayer4 = this.SequencePlayer;
				if (sequencePlayer4 != null)
				{
					sequencePlayer4.PlaySequencePurely("PutIn", false, false);
				}
			}
			bool flag8 = (prev & EItemVisualState.Hovered) > EItemVisualState.None;
			bool flag9 = this.HasVisual(EItemVisualState.Hovered);
			if (flag8 || !flag9)
			{
				if (flag8 && !flag9)
				{
					UiSequencePlayer sequencePlayer5 = this.SequencePlayer;
					if (sequencePlayer5 == null)
					{
						return;
					}
					sequencePlayer5.PlaySequencePurely("FloatOut", false, false);
				}
				return;
			}
			UiSequencePlayer sequencePlayer6 = this.SequencePlayer;
			if (sequencePlayer6 == null)
			{
				return;
			}
			sequencePlayer6.PlaySequencePurely("FloatIn", false, false);
		}

		// Token: 0x0603716F RID: 225647 RVA: 0x00F60040 File Offset: 0x00F5E240
		protected virtual void PlayLayerModeSequence(bool isIn)
		{
			EDragSourceKind sourceKind = this.SourceKind;
			string text;
			if (sourceKind != EDragSourceKind.Bag)
			{
				if (sourceKind != EDragSourceKind.Bench)
				{
					text = null;
				}
				else
				{
					text = (isIn ? "BLayerIn02" : "BLayerOut02");
				}
			}
			else
			{
				text = (isIn ? "BLayerIn" : "BLayerOut");
			}
			string text2 = text;
			if (text2 == null)
			{
				return;
			}
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlaySequencePurely(text2, false, false);
		}

		// Token: 0x06037170 RID: 225648 RVA: 0x00F600A0 File Offset: 0x00F5E2A0
		protected virtual void PlayDragOtherSequence(bool isIn)
		{
			EDragSourceKind sourceKind = this.SourceKind;
			string text;
			if (sourceKind != EDragSourceKind.Bag)
			{
				if (sourceKind != EDragSourceKind.Bench)
				{
					text = null;
				}
				else
				{
					text = (isIn ? "BLayerIn02" : "BLayerOut02");
				}
			}
			else
			{
				text = (isIn ? "ALayerIn" : "ALayerOut");
			}
			string text2 = text;
			if (text2 == null)
			{
				return;
			}
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlaySequencePurely(text2, false, false);
		}

		// Token: 0x06037171 RID: 225649 RVA: 0x00F60100 File Offset: 0x00F5E300
		[NullableContext(1)]
		public void PlayEnterSequence(string seqKey)
		{
			if (string.IsNullOrEmpty(seqKey))
			{
				return;
			}
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlaySequence(seqKey, false, null);
		}

		// Token: 0x06037172 RID: 225650 RVA: 0x00F60134 File Offset: 0x00F5E334
		[NullableContext(1)]
		public UniTask PlayFlyToGoldAsync(float duration, string seqKey)
		{
			DangoBrawlViewItemBase.<PlayFlyToGoldAsync>d__34 <PlayFlyToGoldAsync>d__;
			<PlayFlyToGoldAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayFlyToGoldAsync>d__.<>4__this = this;
			<PlayFlyToGoldAsync>d__.duration = duration;
			<PlayFlyToGoldAsync>d__.seqKey = seqKey;
			<PlayFlyToGoldAsync>d__.<>1__state = -1;
			<PlayFlyToGoldAsync>d__.<>t__builder.Start<DangoBrawlViewItemBase.<PlayFlyToGoldAsync>d__34>(ref <PlayFlyToGoldAsync>d__);
			return <PlayFlyToGoldAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037173 RID: 225651 RVA: 0x00F60188 File Offset: 0x00F5E388
		[NullableContext(1)]
		public UniTask PlaySellFlyAsync(float during, string seqKey)
		{
			DangoBrawlViewItemBase.<PlaySellFlyAsync>d__35 <PlaySellFlyAsync>d__;
			<PlaySellFlyAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlaySellFlyAsync>d__.<>4__this = this;
			<PlaySellFlyAsync>d__.during = during;
			<PlaySellFlyAsync>d__.seqKey = seqKey;
			<PlaySellFlyAsync>d__.<>1__state = -1;
			<PlaySellFlyAsync>d__.<>t__builder.Start<DangoBrawlViewItemBase.<PlaySellFlyAsync>d__35>(ref <PlaySellFlyAsync>d__);
			return <PlaySellFlyAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037174 RID: 225652 RVA: 0x00F601DC File Offset: 0x00F5E3DC
		private UniTask PlayGiveCoinFxAndFinish(int coinDelta)
		{
			DangoBrawlViewItemBase.<PlayGiveCoinFxAndFinish>d__36 <PlayGiveCoinFxAndFinish>d__;
			<PlayGiveCoinFxAndFinish>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayGiveCoinFxAndFinish>d__.<>4__this = this;
			<PlayGiveCoinFxAndFinish>d__.coinDelta = coinDelta;
			<PlayGiveCoinFxAndFinish>d__.<>1__state = -1;
			<PlayGiveCoinFxAndFinish>d__.<>t__builder.Start<DangoBrawlViewItemBase.<PlayGiveCoinFxAndFinish>d__36>(ref <PlayGiveCoinFxAndFinish>d__);
			return <PlayGiveCoinFxAndFinish>d__.<>t__builder.Task;
		}

		// Token: 0x06037175 RID: 225653 RVA: 0x00F60227 File Offset: 0x00F5E427
		protected bool ShouldLayoutInGrid()
		{
			return !this.HasVisual(EItemVisualState.Floating) && this.SourceKind == EDragSourceKind.Bag;
		}

		// Token: 0x06037176 RID: 225654 RVA: 0x00F6023D File Offset: 0x00F5E43D
		protected virtual void RefreshPosFromRotate(EDangoBrawlRotate val)
		{
			base.ApplyRotationToPnlRotate(val);
		}

		// Token: 0x06037177 RID: 225655 RVA: 0x00F60246 File Offset: 0x00F5E446
		protected virtual EDangoBrawlRotate GetBoundRotate()
		{
			return EDangoBrawlRotate.Direction0;
		}

		// Token: 0x06037178 RID: 225656 RVA: 0x00F60249 File Offset: 0x00F5E449
		protected virtual void RefreshRotation(EDangoBrawlRotate val)
		{
		}

		// Token: 0x06037179 RID: 225657 RVA: 0x00F6024C File Offset: 0x00F5E44C
		protected virtual void OnDangoBrawlLayerModeChanged(bool isLayerMode)
		{
			bool inLayerModeVisualState = isLayerMode && (this.SourceKind == EDragSourceKind.Bag || this.SourceKind == EDragSourceKind.Bench);
			this.SetInLayerModeVisualState(inLayerModeVisualState);
		}

		// Token: 0x0603717A RID: 225658 RVA: 0x00F6027C File Offset: 0x00F5E47C
		protected virtual void OnPointerUp(ULGUIPointerEventData eventData)
		{
			if (eventData == null)
			{
				return;
			}
			if (this.IsDragging)
			{
				return;
			}
			this.OnLeftClick(eventData);
			DangoBrawlTouchController touch = this.Touch;
			if (touch == null)
			{
				return;
			}
			touch.OnPointerClick(this.SourceKind, this, eventData.pointerPosition).Forget();
		}

		// Token: 0x0603717B RID: 225659 RVA: 0x00F602B4 File Offset: 0x00F5E4B4
		protected virtual void OnBeginDrag(ULGUIPointerEventData eventData)
		{
			if (eventData == null)
			{
				return;
			}
			if (!DangoBrawlUtil.IsValidDragInput(eventData))
			{
				return;
			}
			if (DangoBrawlViewManager.TryBlockIfThreeChoose(true))
			{
				return;
			}
			this.IsDragging = true;
			DangoBrawlTouchController touch = this.Touch;
			if (touch == null)
			{
				return;
			}
			touch.OnPointerBeginDrag(this.SourceKind, this, eventData.pointerPosition).Forget();
		}

		// Token: 0x0603717C RID: 225660 RVA: 0x00F60300 File Offset: 0x00F5E500
		protected virtual void OnDrag(ULGUIPointerEventData eventData)
		{
			if (eventData == null)
			{
				return;
			}
			if (!DangoBrawlUtil.IsValidDragInput(eventData))
			{
				return;
			}
			if (!this.IsDragging)
			{
				return;
			}
			DangoBrawlTouchController touch = this.Touch;
			if (touch == null)
			{
				return;
			}
			touch.OnPointerDrag(eventData.pointerPosition);
		}

		// Token: 0x0603717D RID: 225661 RVA: 0x00F6032E File Offset: 0x00F5E52E
		protected virtual void OnEndDrag(ULGUIPointerEventData eventData)
		{
			this.IsDragging = false;
			if (eventData == null)
			{
				return;
			}
			if (!DangoBrawlUtil.IsValidDragInput(eventData))
			{
				return;
			}
			DangoBrawlTouchController touch = this.Touch;
			if (touch == null)
			{
				return;
			}
			touch.OnPointerEndDrag(eventData.pointerPosition).Forget();
		}

		// Token: 0x0603717E RID: 225662 RVA: 0x00F6035F File Offset: 0x00F5E55F
		protected override void OnPointerEnter(EToggleState _)
		{
			this.SetHoveredVisualState(true);
			DangoBrawlTouchController touch = this.Touch;
			if (touch == null)
			{
				return;
			}
			touch.GetContext().SetHoveredItem(this.SourceKind, base.Uid);
		}

		// Token: 0x0603717F RID: 225663 RVA: 0x00F60389 File Offset: 0x00F5E589
		protected override void OnPointerExit(EToggleState _)
		{
			this.SetHoveredVisualState(false);
			DangoBrawlTouchController touch = this.Touch;
			if (touch == null)
			{
				return;
			}
			touch.GetContext().ClearHoveredItemIfMatch(this.SourceKind, base.Uid);
		}

		// Token: 0x06037180 RID: 225664 RVA: 0x00F603B4 File Offset: 0x00F5E5B4
		private void OnDangoBrawlRoundStartEffectsReady()
		{
			int num = this.ActData.ConsumeRoundGiveCoinDelta(this.MyUid);
			if (num <= 0)
			{
				return;
			}
			this.PlayGiveCoinFxAndFinish(num).Forget();
		}

		// Token: 0x06037181 RID: 225665 RVA: 0x00F603E4 File Offset: 0x00F5E5E4
		protected void OnLeftClick(ULGUIPointerEventData eventData)
		{
			DangoBrawlTouchController touch = this.Touch;
			if (touch != null && !touch.CurrentMode.AllowInteract(this.ItemData.MyConfigId))
			{
				return;
			}
			bool flag = false;
			DangoBrawlTouchController touch2 = this.Touch;
			EInputPlatform? einputPlatform = (touch2 != null) ? new EInputPlatform?(touch2.GetInputPlatform()) : null;
			if (einputPlatform != null)
			{
				EInputPlatform valueOrDefault = einputPlatform.GetValueOrDefault();
				if (valueOrDefault != EInputPlatform.Mobile)
				{
					if (valueOrDefault == EInputPlatform.Pc)
					{
						flag = (eventData != null && eventData.mouseButtonType == EMouseButtonType.Left);
					}
				}
				else
				{
					flag = (eventData != null && eventData.pointerID == 0);
				}
			}
			if (!flag)
			{
				return;
			}
			InteractionStateMachine fsm = this.Fsm;
			if (fsm == null || !fsm.IsHolding())
			{
				InteractionStateMachine fsm2 = this.Fsm;
				if (fsm2 != null && fsm2.IsIdle())
				{
					DangoBrawlTouchController touch3 = this.Touch;
					if (touch3 == null)
					{
						return;
					}
					touch3.GetContext().ToggleSelection(this.SourceKind, base.Uid);
				}
				return;
			}
			if (DangoBrawlViewManager.TryBlockIfHolding(new int?(base.Uid)))
			{
				return;
			}
			DangoBrawlOperationDispatcher operationDispatcher = DangoBrawlModel.Instance.GetOperationDispatcher();
			if (operationDispatcher != null && operationDispatcher.CanExecute(EDangoBrawlOptionType.Confim, -1))
			{
				operationDispatcher.Execute(EDangoBrawlOptionType.Confim, -1).Forget<bool>();
			}
		}

		// Token: 0x17006A6B RID: 27243
		// (get) Token: 0x06037182 RID: 225666 RVA: 0x00F604FF File Offset: 0x00F5E6FF
		public int MyUid
		{
			get
			{
				return base.Uid;
			}
		}

		// Token: 0x17006A6C RID: 27244
		// (get) Token: 0x06037183 RID: 225667 RVA: 0x00F60507 File Offset: 0x00F5E707
		public int MyConfigId
		{
			get
			{
				return base.ConfigId;
			}
		}

		// Token: 0x17006A6D RID: 27245
		// (get) Token: 0x06037184 RID: 225668 RVA: 0x00F6050F File Offset: 0x00F5E70F
		public EDangoBrawlTemplateType MyType
		{
			get
			{
				return this.ItemData.MyTemplateType;
			}
		}

		// Token: 0x17006A6E RID: 27246
		// (get) Token: 0x06037185 RID: 225669 RVA: 0x00F6051C File Offset: 0x00F5E71C
		public DangoBrawlItemBase MyItemData
		{
			get
			{
				return this.ItemData;
			}
		}

		// Token: 0x06037186 RID: 225670 RVA: 0x00F60524 File Offset: 0x00F5E724
		[NullableContext(1)]
		public UUIItem GetDraggableRootItem()
		{
			return this.RootItem;
		}

		// Token: 0x06037187 RID: 225671 RVA: 0x00F6052C File Offset: 0x00F5E72C
		public void SetDraggableActive(bool val)
		{
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetUIActive(val);
		}

		// Token: 0x06037188 RID: 225672 RVA: 0x00F6053F File Offset: 0x00F5E73F
		public void SetDraggableRotation(EDangoBrawlRotate rotate)
		{
			base.RefreshBoundSize(rotate);
			this.RefreshRotation(rotate);
			base.RefreshShadow(rotate);
		}

		// Token: 0x06037189 RID: 225673 RVA: 0x00F60556 File Offset: 0x00F5E756
		public virtual void OnMoving()
		{
		}

		// Token: 0x0603718A RID: 225674 RVA: 0x00F60558 File Offset: 0x00F5E758
		public virtual void OnDragSourceBegin()
		{
			this.SetDraggingVisualState(true);
		}

		// Token: 0x0603718B RID: 225675 RVA: 0x00F60561 File Offset: 0x00F5E761
		public virtual void OnDragSourceEnd()
		{
			this.SetDraggingVisualState(false);
		}

		// Token: 0x0401D20D RID: 119309
		protected bool IsSelected;

		// Token: 0x0401D20E RID: 119310
		protected bool IsDragging;

		// Token: 0x0401D20F RID: 119311
		protected EDragSourceKind SourceKind;

		// Token: 0x0401D210 RID: 119312
		protected EItemVisualState VisualState;

		// Token: 0x0401D211 RID: 119313
		protected LguiFloatTween FlyToGoldTween;

		// Token: 0x0401D212 RID: 119314
		private UniTaskCompletionSource FlyToGoldTcs;
	}
}
