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
	// Token: 0x020067F9 RID: 26617
	[NullableContext(2)]
	[Nullable(0)]
	public abstract class DangoBrawlViewItemBase : DangoBrawlItemViewBase, IDangoBrawlDraggableView
	{
		// Token: 0x17009726 RID: 38694
		// (get) Token: 0x06042605 RID: 271877 RVA: 0x0101E586 File Offset: 0x0101C786
		protected DangoBrawlTouchController Touch
		{
			get
			{
				return DangoBrawlModel.Instance.GetTouchController();
			}
		}

		// Token: 0x17009727 RID: 38695
		// (get) Token: 0x06042606 RID: 271878 RVA: 0x0101E592 File Offset: 0x0101C792
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

		// Token: 0x17009728 RID: 38696
		// (get) Token: 0x06042607 RID: 271879 RVA: 0x0101E5A9 File Offset: 0x0101C7A9
		protected DangoBrawlOperationDispatcher Operations
		{
			get
			{
				return DangoBrawlModel.Instance.GetOperationDispatcher();
			}
		}

		// Token: 0x17009729 RID: 38697
		// (get) Token: 0x06042608 RID: 271880 RVA: 0x0101E5B5 File Offset: 0x0101C7B5
		protected DangoBrawlItemViewRegistry Registry
		{
			get
			{
				return DangoBrawlModel.Instance.GetViewRegistry();
			}
		}

		// Token: 0x06042609 RID: 271881 RVA: 0x0101E5C4 File Offset: 0x0101C7C4
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlViewItemBase.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlViewItemBase.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0604260A RID: 271882 RVA: 0x0101E608 File Offset: 0x0101C808
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

		// Token: 0x0604260B RID: 271883 RVA: 0x0101E674 File Offset: 0x0101C874
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

		// Token: 0x0604260C RID: 271884 RVA: 0x0101E728 File Offset: 0x0101C928
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

		// Token: 0x0604260D RID: 271885 RVA: 0x0101E7A8 File Offset: 0x0101C9A8
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

		// Token: 0x0604260E RID: 271886 RVA: 0x0101E873 File Offset: 0x0101CA73
		public void SetSourceKind(EDragSourceKind kind)
		{
			this.SourceKind = kind;
		}

		// Token: 0x0604260F RID: 271887 RVA: 0x0101E87C File Offset: 0x0101CA7C
		public EDragSourceKind GetDragSourceKind()
		{
			return this.SourceKind;
		}

		// Token: 0x06042610 RID: 271888 RVA: 0x0101E884 File Offset: 0x0101CA84
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

		// Token: 0x06042611 RID: 271889 RVA: 0x0101E8D5 File Offset: 0x0101CAD5
		public virtual void SetDragOtherVisualState(bool val)
		{
			this.SetVisual(EItemVisualState.DragOther, val, true);
		}

		// Token: 0x06042612 RID: 271890 RVA: 0x0101E8E0 File Offset: 0x0101CAE0
		public virtual void SetDraggingVisualState(bool val)
		{
			this.SetVisual(EItemVisualState.Dragging, val, false);
		}

		// Token: 0x06042613 RID: 271891 RVA: 0x0101E8EC File Offset: 0x0101CAEC
		public virtual void SetFloatingVisualState(bool val)
		{
			this.SetVisual(EItemVisualState.Floating, val, false);
		}

		// Token: 0x06042614 RID: 271892 RVA: 0x0101E8F7 File Offset: 0x0101CAF7
		public virtual void SetInLayerModeVisualState(bool val)
		{
			this.SetVisual(EItemVisualState.InLayerMode, val, false);
		}

		// Token: 0x06042615 RID: 271893 RVA: 0x0101E902 File Offset: 0x0101CB02
		public virtual void SetHoveredVisualState(bool val)
		{
			this.SetVisual(EItemVisualState.Hovered, val, false);
		}

		// Token: 0x06042616 RID: 271894 RVA: 0x0101E90E File Offset: 0x0101CB0E
		public virtual void SetSelectedVisualState(bool val)
		{
			this.SetVisual(EItemVisualState.Selected, val, true);
			this.IsSelected = val;
		}

		// Token: 0x06042617 RID: 271895 RVA: 0x0101E920 File Offset: 0x0101CB20
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

		// Token: 0x06042618 RID: 271896 RVA: 0x0101E966 File Offset: 0x0101CB66
		protected bool HasVisual(EItemVisualState flag)
		{
			return (this.VisualState & flag) > EItemVisualState.None;
		}

		// Token: 0x06042619 RID: 271897 RVA: 0x0101E974 File Offset: 0x0101CB74
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

		// Token: 0x0604261A RID: 271898 RVA: 0x0101EAFC File Offset: 0x0101CCFC
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

		// Token: 0x0604261B RID: 271899 RVA: 0x0101EB5C File Offset: 0x0101CD5C
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

		// Token: 0x0604261C RID: 271900 RVA: 0x0101EBBC File Offset: 0x0101CDBC
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

		// Token: 0x0604261D RID: 271901 RVA: 0x0101EBF0 File Offset: 0x0101CDF0
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

		// Token: 0x0604261E RID: 271902 RVA: 0x0101EC44 File Offset: 0x0101CE44
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

		// Token: 0x0604261F RID: 271903 RVA: 0x0101EC98 File Offset: 0x0101CE98
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

		// Token: 0x06042620 RID: 271904 RVA: 0x0101ECE3 File Offset: 0x0101CEE3
		protected bool ShouldLayoutInGrid()
		{
			return !this.HasVisual(EItemVisualState.Floating) && this.SourceKind == EDragSourceKind.Bag;
		}

		// Token: 0x06042621 RID: 271905 RVA: 0x0101ECF9 File Offset: 0x0101CEF9
		protected virtual void RefreshPosFromRotate(EDangoBrawlRotate val)
		{
			base.ApplyRotationToPnlRotate(val);
		}

		// Token: 0x06042622 RID: 271906 RVA: 0x0101ED02 File Offset: 0x0101CF02
		protected virtual EDangoBrawlRotate GetBoundRotate()
		{
			return EDangoBrawlRotate.Direction0;
		}

		// Token: 0x06042623 RID: 271907 RVA: 0x0101ED05 File Offset: 0x0101CF05
		protected virtual void RefreshRotation(EDangoBrawlRotate val)
		{
		}

		// Token: 0x06042624 RID: 271908 RVA: 0x0101ED08 File Offset: 0x0101CF08
		protected virtual void OnDangoBrawlLayerModeChanged(bool isLayerMode)
		{
			bool inLayerModeVisualState = isLayerMode && (this.SourceKind == EDragSourceKind.Bag || this.SourceKind == EDragSourceKind.Bench);
			this.SetInLayerModeVisualState(inLayerModeVisualState);
		}

		// Token: 0x06042625 RID: 271909 RVA: 0x0101ED38 File Offset: 0x0101CF38
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

		// Token: 0x06042626 RID: 271910 RVA: 0x0101ED70 File Offset: 0x0101CF70
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

		// Token: 0x06042627 RID: 271911 RVA: 0x0101EDBC File Offset: 0x0101CFBC
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

		// Token: 0x06042628 RID: 271912 RVA: 0x0101EDEA File Offset: 0x0101CFEA
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

		// Token: 0x06042629 RID: 271913 RVA: 0x0101EE1B File Offset: 0x0101D01B
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

		// Token: 0x0604262A RID: 271914 RVA: 0x0101EE45 File Offset: 0x0101D045
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

		// Token: 0x0604262B RID: 271915 RVA: 0x0101EE70 File Offset: 0x0101D070
		private void OnDangoBrawlRoundStartEffectsReady()
		{
			int num = this.ActData.ConsumeRoundGiveCoinDelta(this.MyUid);
			if (num <= 0)
			{
				return;
			}
			this.PlayGiveCoinFxAndFinish(num).Forget();
		}

		// Token: 0x0604262C RID: 271916 RVA: 0x0101EEA0 File Offset: 0x0101D0A0
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

		// Token: 0x1700972A RID: 38698
		// (get) Token: 0x0604262D RID: 271917 RVA: 0x0101EFBB File Offset: 0x0101D1BB
		public int MyUid
		{
			get
			{
				return base.Uid;
			}
		}

		// Token: 0x1700972B RID: 38699
		// (get) Token: 0x0604262E RID: 271918 RVA: 0x0101EFC3 File Offset: 0x0101D1C3
		public int MyConfigId
		{
			get
			{
				return base.ConfigId;
			}
		}

		// Token: 0x1700972C RID: 38700
		// (get) Token: 0x0604262F RID: 271919 RVA: 0x0101EFCB File Offset: 0x0101D1CB
		public EDangoBrawlTemplateType MyType
		{
			get
			{
				return this.ItemData.MyTemplateType;
			}
		}

		// Token: 0x1700972D RID: 38701
		// (get) Token: 0x06042630 RID: 271920 RVA: 0x0101EFD8 File Offset: 0x0101D1D8
		public DangoBrawlItemBase MyItemData
		{
			get
			{
				return this.ItemData;
			}
		}

		// Token: 0x06042631 RID: 271921 RVA: 0x0101EFE0 File Offset: 0x0101D1E0
		[NullableContext(1)]
		public UUIItem GetDraggableRootItem()
		{
			return this.RootItem;
		}

		// Token: 0x06042632 RID: 271922 RVA: 0x0101EFE8 File Offset: 0x0101D1E8
		public void SetDraggableActive(bool val)
		{
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetUIActive(val);
		}

		// Token: 0x06042633 RID: 271923 RVA: 0x0101EFFB File Offset: 0x0101D1FB
		public void SetDraggableRotation(EDangoBrawlRotate rotate)
		{
			base.RefreshBoundSize(rotate);
			this.RefreshRotation(rotate);
			base.RefreshShadow(rotate);
		}

		// Token: 0x06042634 RID: 271924 RVA: 0x0101F012 File Offset: 0x0101D212
		public virtual void OnMoving()
		{
		}

		// Token: 0x06042635 RID: 271925 RVA: 0x0101F014 File Offset: 0x0101D214
		public virtual void OnDragSourceBegin()
		{
			this.SetDraggingVisualState(true);
		}

		// Token: 0x06042636 RID: 271926 RVA: 0x0101F01D File Offset: 0x0101D21D
		public virtual void OnDragSourceEnd()
		{
			this.SetDraggingVisualState(false);
		}

		// Token: 0x040229B0 RID: 141744
		protected bool IsSelected;

		// Token: 0x040229B1 RID: 141745
		protected bool IsDragging;

		// Token: 0x040229B2 RID: 141746
		protected EDragSourceKind SourceKind;

		// Token: 0x040229B3 RID: 141747
		protected EItemVisualState VisualState;

		// Token: 0x040229B4 RID: 141748
		protected LguiFloatTween FlyToGoldTween;

		// Token: 0x040229B5 RID: 141749
		private UniTaskCompletionSource FlyToGoldTcs;
	}
}
