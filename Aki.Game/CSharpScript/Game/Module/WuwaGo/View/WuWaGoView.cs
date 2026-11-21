using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.WuwaGo.Controller;
using CSharpScript.Game.Module.WuwaGo.Model;
using CSharpScript.Game.Module.WuwaGo.Model.Role;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WuwaGo.View
{
	// Token: 0x02003655 RID: 13909
	[NullableContext(1)]
	[Nullable(0)]
	public class WuWaGoView : UiTickViewBase
	{
		// Token: 0x06024137 RID: 147767 RVA: 0x00A35AA2 File Offset: 0x00A33CA2
		public WuWaGoView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06024138 RID: 147768 RVA: 0x00A35AE0 File Offset: 0x00A33CE0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 16;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 4;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnPlayTipsButtonClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(10, new Action(this.OnRollbackButtonClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(12, new Action(this.OnInteractionButtonClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(15, new Action(this.OnSkipCinematicButtonClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06024139 RID: 147769 RVA: 0x00A35DC8 File Offset: 0x00A33FC8
		protected override UniTask OnBeforeStartAsync()
		{
			WuWaGoView.<OnBeforeStartAsync>d__27 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<WuWaGoView.<OnBeforeStartAsync>d__27>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602413A RID: 147770 RVA: 0x00A35E0B File Offset: 0x00A3400B
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.OnWuWaGoUserRequestRollbackToSavePoint, new Action(this.OnUserRequestRollbackToSavePoint));
			base.OnBeforeDestroy();
		}

		// Token: 0x0602413B RID: 147771 RVA: 0x00A35E30 File Offset: 0x00A34030
		private UniTask InitCaptionItem()
		{
			WuWaGoView.<InitCaptionItem>d__29 <InitCaptionItem>d__;
			<InitCaptionItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitCaptionItem>d__.<>4__this = this;
			<InitCaptionItem>d__.<>1__state = -1;
			<InitCaptionItem>d__.<>t__builder.Start<WuWaGoView.<InitCaptionItem>d__29>(ref <InitCaptionItem>d__);
			return <InitCaptionItem>d__.<>t__builder.Task;
		}

		// Token: 0x0602413C RID: 147772 RVA: 0x00A35E73 File Offset: 0x00A34073
		protected override void OnAfterShow()
		{
			BattleUiModel.Instance.ChildViewData.AddBattleUiCommonChildVisibleReason(EBattleUiCommonChildVisibleReason.SurvivorsRogue);
			BattleUiModel.Instance.ChildViewData.SetChildVisible(EBattleUiVisibleReason.Custom, EBattleUiChild.InteractionHint, false, true, 1);
			EventSystem.Instance.Emit(EEventName.ActiveBattleView);
		}

		// Token: 0x0602413D RID: 147773 RVA: 0x00A35EAB File Offset: 0x00A340AB
		protected override void OnAfterHide()
		{
			BattleUiModel.Instance.ChildViewData.RemoveBattleUiCommonChildVisibleReason(EBattleUiCommonChildVisibleReason.SurvivorsRogue);
			BattleUiModel.Instance.ChildViewData.SetChildVisible(EBattleUiVisibleReason.Custom, EBattleUiChild.InteractionHint, true, true, 1);
		}

		// Token: 0x0602413E RID: 147774 RVA: 0x00A35ED4 File Offset: 0x00A340D4
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
			EventSystem.Instance.Add<bool>(EEventName.OnWuWaGoInteractionAvailable, new Action<bool>(this.OnInteractionAvailableChanged));
			EventSystem.Instance.Add<bool>(EEventName.OnWuWaGoPlayTipAvailable, new Action<bool>(this.OnPlayTipAvailableChanged));
			EventSystem.Instance.Add<bool>(EEventName.OnWuWaGoMainControlInputAcceptingChanged, new Action<bool>(this.OnMainControlInputAcceptingChanged));
			EventSystem.Instance.Add<int, int>(EEventName.OnWuWaGoProgressUpdate, new Action<int, int>(this.OnProgressUpdate));
			EventSystem.Instance.Add<bool>(EEventName.OnWuWaGoRollbackAvailable, new Action<bool>(this.OnRollbackAvailableChanged));
			EventSystem.Instance.Add<bool>(EEventName.OnWuWaGoCinematicPlayingChanged, new Action<bool>(this.OnCinematicPlayingChanged));
			EventSystem.Instance.Add<bool, string>(EEventName.OnWuWaGoDamageBatchStateChanged, new Action<bool, string>(this.OnDamageBatchStateChanged));
			this.RefreshInputBinding();
			this.RefreshRollbackButton();
			this.RefreshCaptionButtons();
		}

		// Token: 0x0602413F RID: 147775 RVA: 0x00A35FD4 File Offset: 0x00A341D4
		protected override void OnRemoveEventListener()
		{
			this.UnbindAllInput();
			EventSystem.Instance.Remove<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
			EventSystem.Instance.Remove<bool>(EEventName.OnWuWaGoInteractionAvailable, new Action<bool>(this.OnInteractionAvailableChanged));
			EventSystem.Instance.Remove<bool>(EEventName.OnWuWaGoPlayTipAvailable, new Action<bool>(this.OnPlayTipAvailableChanged));
			EventSystem.Instance.Remove<bool>(EEventName.OnWuWaGoMainControlInputAcceptingChanged, new Action<bool>(this.OnMainControlInputAcceptingChanged));
			EventSystem.Instance.Remove<int, int>(EEventName.OnWuWaGoProgressUpdate, new Action<int, int>(this.OnProgressUpdate));
			EventSystem.Instance.Remove<bool>(EEventName.OnWuWaGoRollbackAvailable, new Action<bool>(this.OnRollbackAvailableChanged));
			EventSystem.Instance.Remove<bool>(EEventName.OnWuWaGoCinematicPlayingChanged, new Action<bool>(this.OnCinematicPlayingChanged));
			EventSystem.Instance.Remove<bool, string>(EEventName.OnWuWaGoDamageBatchStateChanged, new Action<bool, string>(this.OnDamageBatchStateChanged));
		}

		// Token: 0x06024140 RID: 147776 RVA: 0x00A360C7 File Offset: 0x00A342C7
		private void OnInputControllerChange(EInputControllerType last, EInputControllerType now)
		{
			this.RefreshInputBinding();
		}

		// Token: 0x06024141 RID: 147777 RVA: 0x00A360D0 File Offset: 0x00A342D0
		private void OnInteractionAvailableChanged(bool available)
		{
			this.SetInteractionButtonActive(available);
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence == null)
			{
				return;
			}
			uiViewSequence.PlaySequence(available ? "Icon_In_1" : "Icon_Out_1", true, null);
		}

		// Token: 0x06024142 RID: 147778 RVA: 0x00A36110 File Offset: 0x00A34310
		private void SetInteractionButtonActive(bool visible)
		{
			UUIButtonComponent button = base.GetButton(12);
			if (button == null)
			{
				return;
			}
			UUIItem uuiitem = button.RootUIComp.Get();
			if (uuiitem == null)
			{
				return;
			}
			uuiitem.SetUIActive(visible);
		}

		// Token: 0x06024143 RID: 147779 RVA: 0x00A36142 File Offset: 0x00A34342
		private void OnPlayTipAvailableChanged(bool available)
		{
			this.PlayTipAvailable = available;
			this.RefreshPlayTipButton();
			this.RefreshDialogueBubblePanel();
		}

		// Token: 0x06024144 RID: 147780 RVA: 0x00A36157 File Offset: 0x00A34357
		private void RefreshPlayTipButton()
		{
			UUIButtonComponent button = base.GetButton(6);
			if (button == null)
			{
				return;
			}
			button.SetSelfInteractive(this.PlayTipAvailable && WuWaGoController.Instance.CanUsePlayTip());
		}

		// Token: 0x06024145 RID: 147781 RVA: 0x00A3617F File Offset: 0x00A3437F
		private void OnMainControlInputAcceptingChanged(bool accepting)
		{
			this.RefreshPlayTipButton();
		}

		// Token: 0x06024146 RID: 147782 RVA: 0x00A36187 File Offset: 0x00A34387
		private void OnRollbackAvailableChanged(bool available)
		{
			this.RollbackAvailable = available;
			this.RefreshRollbackButton();
		}

		// Token: 0x06024147 RID: 147783 RVA: 0x00A36196 File Offset: 0x00A34396
		private void RefreshRollbackButton()
		{
			UUIButtonComponent button = base.GetButton(10);
			if (button == null)
			{
				return;
			}
			button.SetSelfInteractive(!this.CinematicPlaying && !this.IsDamageBatchActive() && this.RollbackAvailable);
		}

		// Token: 0x06024148 RID: 147784 RVA: 0x00A361C3 File Offset: 0x00A343C3
		private void OnCinematicPlayingChanged(bool playing)
		{
			this.CinematicPlaying = playing;
			this.RefreshPlayTipButton();
			this.RefreshRollbackButton();
			this.RefreshSkipCinematicButton();
			this.RefreshCaptionButtons();
			this.RefreshDialogueBubblePanel();
		}

		// Token: 0x06024149 RID: 147785 RVA: 0x00A361EA File Offset: 0x00A343EA
		private void OnDamageBatchStateChanged(bool isActive, string reason)
		{
			this.RefreshRollbackButton();
			this.RefreshCaptionButtons();
			this.RefreshPlayTipButton();
		}

		// Token: 0x0602414A RID: 147786 RVA: 0x00A361FE File Offset: 0x00A343FE
		private bool IsDamageBatchActive()
		{
			return WuWaGoController.Instance.IsDamageBatchActive();
		}

		// Token: 0x0602414B RID: 147787 RVA: 0x00A3620A File Offset: 0x00A3440A
		private void RefreshCaptionButtons()
		{
			CaptionItem captionItem = this.CaptionItem;
			if (captionItem != null)
			{
				captionItem.SetCloseButtonInteractive(!this.CinematicPlaying && !this.IsDamageBatchActive());
			}
			CaptionItem captionItem2 = this.CaptionItem;
			if (captionItem2 == null)
			{
				return;
			}
			captionItem2.SetRightTopButtonsVisible(!this.CinematicPlaying);
		}

		// Token: 0x0602414C RID: 147788 RVA: 0x00A3624C File Offset: 0x00A3444C
		private void RefreshSkipCinematicButton()
		{
			UUIButtonComponent button = base.GetButton(15);
			if (button == null)
			{
				return;
			}
			UUIItem uuiitem = button.RootUIComp.Get();
			if (uuiitem == null)
			{
				return;
			}
			uuiitem.SetUIActive(this.CinematicPlaying);
		}

		// Token: 0x0602414D RID: 147789 RVA: 0x00A36283 File Offset: 0x00A34483
		private void OnSkipCinematicButtonClick()
		{
			WuWaGoController.Instance.RequestInterruptPlayTipCinematic();
		}

		// Token: 0x0602414E RID: 147790 RVA: 0x00A36290 File Offset: 0x00A34490
		private void RefreshInitialProgress()
		{
			int progressTotalGridCount = WuWaGoModel.Instance.GameData.ProgressTotalGridCount;
			this.OnProgressUpdate(0, progressTotalGridCount);
		}

		// Token: 0x0602414F RID: 147791 RVA: 0x00A362B5 File Offset: 0x00A344B5
		private void OnProgressUpdate(int reached, int total)
		{
			this.RefreshProgressView(reached, total);
		}

		// Token: 0x06024150 RID: 147792 RVA: 0x00A362C0 File Offset: 0x00A344C0
		private UniTask RefreshProgressView(int reached, int total)
		{
			WuWaGoView.<RefreshProgressView>d__50 <RefreshProgressView>d__;
			<RefreshProgressView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshProgressView>d__.<>4__this = this;
			<RefreshProgressView>d__.reached = reached;
			<RefreshProgressView>d__.total = total;
			<RefreshProgressView>d__.<>1__state = -1;
			<RefreshProgressView>d__.<>t__builder.Start<WuWaGoView.<RefreshProgressView>d__50>(ref <RefreshProgressView>d__);
			return <RefreshProgressView>d__.<>t__builder.Task;
		}

		// Token: 0x06024151 RID: 147793 RVA: 0x00A36314 File Offset: 0x00A34514
		private UniTask EnsureProgressItems(int total)
		{
			WuWaGoView.<EnsureProgressItems>d__51 <EnsureProgressItems>d__;
			<EnsureProgressItems>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<EnsureProgressItems>d__.<>4__this = this;
			<EnsureProgressItems>d__.total = total;
			<EnsureProgressItems>d__.<>1__state = -1;
			<EnsureProgressItems>d__.<>t__builder.Start<WuWaGoView.<EnsureProgressItems>d__51>(ref <EnsureProgressItems>d__);
			return <EnsureProgressItems>d__.<>t__builder.Task;
		}

		// Token: 0x06024152 RID: 147794 RVA: 0x00A36360 File Offset: 0x00A34560
		private void RefreshInputBinding()
		{
			WuWaGoView.EBoundInputMode eboundInputMode = WuWaGoView.EBoundInputMode.None;
			if (Info.Instance.IsInTouch())
			{
				eboundInputMode = WuWaGoView.EBoundInputMode.Touch;
			}
			else if (Info.Instance.IsInGamepad())
			{
				eboundInputMode = WuWaGoView.EBoundInputMode.Gamepad;
			}
			else if (Info.Instance.IsInKeyBoard())
			{
				eboundInputMode = WuWaGoView.EBoundInputMode.MouseKeyboard;
			}
			if (eboundInputMode == this.CurrentInputMode)
			{
				return;
			}
			this.UnbindAllInput();
			this.CurrentInputMode = eboundInputMode;
			switch (eboundInputMode)
			{
			case WuWaGoView.EBoundInputMode.MouseKeyboard:
				this.BindMouseInput();
				return;
			case WuWaGoView.EBoundInputMode.Touch:
				this.BindTouchInput();
				return;
			case WuWaGoView.EBoundInputMode.Gamepad:
				this.BindGamepadInput();
				return;
			default:
				return;
			}
		}

		// Token: 0x06024153 RID: 147795 RVA: 0x00A363E0 File Offset: 0x00A345E0
		private void UnbindAllInput()
		{
			switch (this.CurrentInputMode)
			{
			case WuWaGoView.EBoundInputMode.MouseKeyboard:
				this.UnbindMouseInput();
				break;
			case WuWaGoView.EBoundInputMode.Touch:
				this.UnbindTouchInput();
				break;
			case WuWaGoView.EBoundInputMode.Gamepad:
				this.UnbindGamepadInput();
				break;
			}
			this.CurrentInputMode = WuWaGoView.EBoundInputMode.None;
			this.TouchTrackingId = null;
			this.HasMouseDown = false;
			this.HasLastPreview = false;
			this.LastPreviewX = 0.0;
			this.LastPreviewY = 0.0;
		}

		// Token: 0x06024154 RID: 147796 RVA: 0x00A3645F File Offset: 0x00A3465F
		private void BindMouseInput()
		{
			InputDistributeController.Instance.BindAction("UI左键点击", new TInputHandle<InputDistributeDefine.EActionType>(this.OnMouseClick));
		}

		// Token: 0x06024155 RID: 147797 RVA: 0x00A3647C File Offset: 0x00A3467C
		private void UnbindMouseInput()
		{
			InputDistributeController.Instance.UnBindAction("UI左键点击", new TInputHandle<InputDistributeDefine.EActionType>(this.OnMouseClick));
		}

		// Token: 0x06024156 RID: 147798 RVA: 0x00A36499 File Offset: 0x00A34699
		private void BindTouchInput()
		{
			InputDistributeController.Instance.BindTouches(new int[1], new TInputHandle<InputDistributeDefine.ITouchData>(this.OnTouch));
		}

		// Token: 0x06024157 RID: 147799 RVA: 0x00A364B7 File Offset: 0x00A346B7
		private void UnbindTouchInput()
		{
			InputDistributeController.Instance.UnBindTouches(new <>z__ReadOnlySingleElementList<int>(0), new TInputHandle<InputDistributeDefine.ITouchData>(this.OnTouch));
		}

		// Token: 0x06024158 RID: 147800 RVA: 0x00A364D5 File Offset: 0x00A346D5
		private void BindGamepadInput()
		{
			InputDistributeController.Instance.BindAxis("UiMoveForward", new TInputHandle<float>(this.OnGamepadAxis));
			InputDistributeController.Instance.BindAxis("UiMoveRight", new TInputHandle<float>(this.OnGamepadAxis));
		}

		// Token: 0x06024159 RID: 147801 RVA: 0x00A36510 File Offset: 0x00A34710
		private void UnbindGamepadInput()
		{
			InputDistributeController.Instance.UnBindAxis("UiMoveForward", new TInputHandle<float>(this.OnGamepadAxis));
			InputDistributeController.Instance.UnBindAxis("UiMoveRight", new TInputHandle<float>(this.OnGamepadAxis));
			this.GamepadAxisForward = 0.0;
			this.GamepadAxisRight = 0.0;
			this.GamepadDirectionLatched = false;
		}

		// Token: 0x0602415A RID: 147802 RVA: 0x00A36578 File Offset: 0x00A34778
		protected override void OnTick(float delta)
		{
			if (this.CurrentInputMode != WuWaGoView.EBoundInputMode.MouseKeyboard)
			{
				return;
			}
			WuWaGoMainControlRole mainControlRole = WuWaGoModel.Instance.GameData.MainControlRole;
			if (mainControlRole == null || !mainControlRole.IsAcceptingInput)
			{
				return;
			}
			TsCharacterController characterController = Global.CharacterController;
			if (characterController == null)
			{
				return;
			}
			Vector2D cursorPosition = characterController.GetCursorPosition();
			if (cursorPosition == null)
			{
				return;
			}
			if (this.HasLastPreview && Math.Abs(cursorPosition.X - this.LastPreviewX) + Math.Abs(cursorPosition.Y - this.LastPreviewY) < (double)this.HoverMinPixel)
			{
				return;
			}
			this.HasLastPreview = true;
			this.LastPreviewX = cursorPosition.X;
			this.LastPreviewY = cursorPosition.Y;
			EventSystem.Instance.Emit<int, int>(EEventName.OnWuWaGoUserPreviewScreen, (int)cursorPosition.X, (int)cursorPosition.Y);
		}

		// Token: 0x0602415B RID: 147803 RVA: 0x00A3663C File Offset: 0x00A3483C
		private void OnMouseClick(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification ii)
		{
			TsCharacterController characterController = Global.CharacterController;
			if (characterController == null)
			{
				return;
			}
			Vector2D cursorPosition = characterController.GetCursorPosition();
			if (cursorPosition == null)
			{
				return;
			}
			if (actionType == InputDistributeDefine.EActionType.Press)
			{
				this.HasMouseDown = true;
				this.MouseDownPosition.Set(cursorPosition.X, cursorPosition.Y);
				return;
			}
			if (!this.HasMouseDown)
			{
				return;
			}
			this.HasMouseDown = false;
			this.HandleMouseRelease(cursorPosition);
		}

		// Token: 0x0602415C RID: 147804 RVA: 0x00A36698 File Offset: 0x00A34898
		private void HandleMouseRelease(Vector2D endPosition)
		{
			double num = endPosition.X - this.MouseDownPosition.X;
			double num2 = endPosition.Y - this.MouseDownPosition.Y;
			if (Math.Sqrt(num * num + num2 * num2) >= (double)this.SwipeMinPixelDistance)
			{
				EventSystem.Instance.Emit<double, double>(EEventName.OnWuWaGoUserPickDirection, num, num2);
				return;
			}
			EventSystem.Instance.Emit<int, int>(EEventName.OnWuWaGoUserPickScreen, (int)endPosition.X, (int)endPosition.Y);
		}

		// Token: 0x0602415D RID: 147805 RVA: 0x00A36714 File Offset: 0x00A34914
		private void OnTouch(string touchIdName, InputDistributeDefine.ITouchData touchData, InputIdentification ii)
		{
			switch (touchData.TouchType)
			{
			case InputDistributeDefine.ETouchType.TouchBegin:
				this.TouchTrackingId = new int?(touchData.TouchId);
				this.TouchStartPosition.Set(touchData.TouchPosition.X, touchData.TouchPosition.Y, 0.0);
				return;
			case InputDistributeDefine.ETouchType.TouchEnd:
			{
				int? touchTrackingId = this.TouchTrackingId;
				int touchId = touchData.TouchId;
				if (!(touchTrackingId.GetValueOrDefault() == touchId & touchTrackingId != null))
				{
					return;
				}
				this.HandleTouchEnd(touchData.TouchPosition);
				this.TouchTrackingId = null;
				break;
			}
			case InputDistributeDefine.ETouchType.TouchMove:
				break;
			default:
				return;
			}
		}

		// Token: 0x0602415E RID: 147806 RVA: 0x00A367B4 File Offset: 0x00A349B4
		private void HandleTouchEnd(Vector endPosition)
		{
			double num = endPosition.X - this.TouchStartPosition.X;
			double num2 = endPosition.Y - this.TouchStartPosition.Y;
			if (Math.Sqrt(num * num + num2 * num2) >= (double)this.SwipeMinPixelDistance)
			{
				EventSystem.Instance.Emit<double, double>(EEventName.OnWuWaGoUserPickDirection, num, num2);
				return;
			}
			EventSystem.Instance.Emit<int, int>(EEventName.OnWuWaGoUserPickScreen, (int)endPosition.X, (int)endPosition.Y);
		}

		// Token: 0x0602415F RID: 147807 RVA: 0x00A3682D File Offset: 0x00A34A2D
		private void OnGamepadAxis(string axisName, float value, InputIdentification ii)
		{
			if (axisName == "UiMoveForward")
			{
				this.GamepadAxisForward = (double)value;
			}
			else
			{
				if (!(axisName == "UiMoveRight"))
				{
					return;
				}
				this.GamepadAxisRight = (double)value;
			}
			this.UpdateGamepadDirection();
		}

		// Token: 0x06024160 RID: 147808 RVA: 0x00A36864 File Offset: 0x00A34A64
		private void UpdateGamepadDirection()
		{
			double gamepadAxisForward = this.GamepadAxisForward;
			double gamepadAxisRight = this.GamepadAxisRight;
			double num = Math.Sqrt(gamepadAxisForward * gamepadAxisForward + gamepadAxisRight * gamepadAxisRight);
			if (this.GamepadDirectionLatched)
			{
				if (num < 0.15000000596046448)
				{
					this.GamepadDirectionLatched = false;
				}
				return;
			}
			if (num < 0.30000001192092896)
			{
				return;
			}
			EventSystem.Instance.Emit<double, double>(EEventName.OnWuWaGoUserPickDirection, gamepadAxisRight, -gamepadAxisForward);
			this.GamepadDirectionLatched = true;
		}

		// Token: 0x06024161 RID: 147809 RVA: 0x00A368CF File Offset: 0x00A34ACF
		private void OnPlayTipsButtonClick()
		{
			this.PlayTipsButtonClickImp();
		}

		// Token: 0x06024162 RID: 147810 RVA: 0x00A368D8 File Offset: 0x00A34AD8
		private UniTask PlayTipsButtonClickImp()
		{
			WuWaGoView.<PlayTipsButtonClickImp>d__68 <PlayTipsButtonClickImp>d__;
			<PlayTipsButtonClickImp>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayTipsButtonClickImp>d__.<>4__this = this;
			<PlayTipsButtonClickImp>d__.<>1__state = -1;
			<PlayTipsButtonClickImp>d__.<>t__builder.Start<WuWaGoView.<PlayTipsButtonClickImp>d__68>(ref <PlayTipsButtonClickImp>d__);
			return <PlayTipsButtonClickImp>d__.<>t__builder.Task;
		}

		// Token: 0x06024163 RID: 147811 RVA: 0x00A3691B File Offset: 0x00A34B1B
		private void OnStartSequenceEvent(string sequenceName)
		{
			UUIItem item = base.GetItem(13);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(true);
		}

		// Token: 0x06024164 RID: 147812 RVA: 0x00A36930 File Offset: 0x00A34B30
		private void RefreshDialogueBubblePanel()
		{
			bool uiactive = this.CinematicPlaying || this.PlayTipAvailable;
			UUIItem item = base.GetItem(5);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(uiactive);
		}

		// Token: 0x06024165 RID: 147813 RVA: 0x00A36964 File Offset: 0x00A34B64
		private void RefreshTipsIconSprite()
		{
			UUISprite sprite = base.GetSprite(7);
			if (sprite == null)
			{
				return;
			}
			string resourceId = (PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Female) ? "SP_LaHaiLuoCubeMoveTipIconF" : "SP_LaHaiLuoCubeMoveTipIconM";
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			this.SetSpriteByPath(resourcePath, sprite, false, null, null);
		}

		// Token: 0x06024166 RID: 147814 RVA: 0x00A369B8 File Offset: 0x00A34BB8
		private void OnRollbackButtonClick()
		{
			this.RunWithFilterMaskAsync(() => WuWaGoController.Instance.RollbackToLastStepAsync()).Forget();
		}

		// Token: 0x06024167 RID: 147815 RVA: 0x00A369E4 File Offset: 0x00A34BE4
		private void OnUserRequestRollbackToSavePoint()
		{
			this.RunWithFilterMaskAsync(() => WuWaGoController.Instance.RollbackToSavePointAsync()).Forget();
		}

		// Token: 0x06024168 RID: 147816 RVA: 0x00A36A10 File Offset: 0x00A34C10
		private UniTask RunWithFilterMaskAsync(Func<UniTask> action)
		{
			WuWaGoView.<RunWithFilterMaskAsync>d__74 <RunWithFilterMaskAsync>d__;
			<RunWithFilterMaskAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RunWithFilterMaskAsync>d__.<>4__this = this;
			<RunWithFilterMaskAsync>d__.action = action;
			<RunWithFilterMaskAsync>d__.<>1__state = -1;
			<RunWithFilterMaskAsync>d__.<>t__builder.Start<WuWaGoView.<RunWithFilterMaskAsync>d__74>(ref <RunWithFilterMaskAsync>d__);
			return <RunWithFilterMaskAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06024169 RID: 147817 RVA: 0x00A36A5B File Offset: 0x00A34C5B
		private void OnInteractionButtonClick()
		{
			EventSystem.Instance.Emit(EEventName.OnWuWaGoUserUseInteraction);
		}

		// Token: 0x040141D4 RID: 82388
		[Nullable(2)]
		private CaptionItem CaptionItem;

		// Token: 0x040141D5 RID: 82389
		private readonly List<ProgressItem> ProgressItems = new List<ProgressItem>();

		// Token: 0x040141D6 RID: 82390
		private const int MaskMinDurationMs = 500;

		// Token: 0x040141D7 RID: 82391
		private const int InteractionHintCustomSubReason = 1;

		// Token: 0x040141D8 RID: 82392
		private WuWaGoView.EBoundInputMode CurrentInputMode;

		// Token: 0x040141D9 RID: 82393
		private int? TouchTrackingId;

		// Token: 0x040141DA RID: 82394
		private readonly Vector TouchStartPosition = Vector.Create();

		// Token: 0x040141DB RID: 82395
		private bool HasMouseDown;

		// Token: 0x040141DC RID: 82396
		private readonly Vector2D MouseDownPosition = Vector2D.Create(0.0, 0.0);

		// Token: 0x040141DD RID: 82397
		private bool HasLastPreview;

		// Token: 0x040141DE RID: 82398
		private double LastPreviewX;

		// Token: 0x040141DF RID: 82399
		private double LastPreviewY;

		// Token: 0x040141E0 RID: 82400
		private float HoverMinPixel;

		// Token: 0x040141E1 RID: 82401
		private float SwipeMinPixelDistance;

		// Token: 0x040141E2 RID: 82402
		private bool CinematicPlaying;

		// Token: 0x040141E3 RID: 82403
		private bool PlayTipAvailable;

		// Token: 0x040141E4 RID: 82404
		private bool RollbackAvailable;

		// Token: 0x040141E5 RID: 82405
		private bool IsPlayingTip;

		// Token: 0x040141E6 RID: 82406
		private const double GamepadTriggerThreshold = 0.30000001192092896;

		// Token: 0x040141E7 RID: 82407
		private const double GamepadReleaseThreshold = 0.15000000596046448;

		// Token: 0x040141E8 RID: 82408
		private double GamepadAxisForward;

		// Token: 0x040141E9 RID: 82409
		private double GamepadAxisRight;

		// Token: 0x040141EA RID: 82410
		private bool GamepadDirectionLatched;

		// Token: 0x0200932E RID: 37678
		[NullableContext(0)]
		private enum EViewComponent
		{
			// Token: 0x0402E0CF RID: 188623
			CaptionItem,
			// Token: 0x0402E0D0 RID: 188624
			ProgressPanelItem,
			// Token: 0x0402E0D1 RID: 188625
			ProgressText,
			// Token: 0x0402E0D2 RID: 188626
			ProgressHorizontalLayout,
			// Token: 0x0402E0D3 RID: 188627
			ProgressItem,
			// Token: 0x0402E0D4 RID: 188628
			DialogueBubblePanel,
			// Token: 0x0402E0D5 RID: 188629
			PlayTipBtn,
			// Token: 0x0402E0D6 RID: 188630
			TipsIconSprite,
			// Token: 0x0402E0D7 RID: 188631
			TipText,
			// Token: 0x0402E0D8 RID: 188632
			GameplayTipsText,
			// Token: 0x0402E0D9 RID: 188633
			RollbackBtn,
			// Token: 0x0402E0DA RID: 188634
			RollbackBtnNumText,
			// Token: 0x0402E0DB RID: 188635
			InteractionBtn,
			// Token: 0x0402E0DC RID: 188636
			PanelBubble,
			// Token: 0x0402E0DD RID: 188637
			PanelFilter,
			// Token: 0x0402E0DE RID: 188638
			SkipCinematicBtn
		}

		// Token: 0x0200932F RID: 37679
		[NullableContext(0)]
		private enum EBoundInputMode
		{
			// Token: 0x0402E0E0 RID: 188640
			None,
			// Token: 0x0402E0E1 RID: 188641
			MouseKeyboard,
			// Token: 0x0402E0E2 RID: 188642
			Touch,
			// Token: 0x0402E0E3 RID: 188643
			Gamepad
		}
	}
}
