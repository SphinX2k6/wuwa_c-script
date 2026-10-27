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
	// Token: 0x02004724 RID: 18212
	[NullableContext(1)]
	[Nullable(0)]
	public class WuWaGoView : UiTickViewBase
	{
		// Token: 0x0602F96D RID: 194925 RVA: 0x00B05C16 File Offset: 0x00B03E16
		public WuWaGoView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602F96E RID: 194926 RVA: 0x00B05C54 File Offset: 0x00B03E54
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

		// Token: 0x0602F96F RID: 194927 RVA: 0x00B05F3C File Offset: 0x00B0413C
		protected override UniTask OnBeforeStartAsync()
		{
			WuWaGoView.<OnBeforeStartAsync>d__27 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<WuWaGoView.<OnBeforeStartAsync>d__27>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602F970 RID: 194928 RVA: 0x00B05F7F File Offset: 0x00B0417F
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.OnWuWaGoUserRequestRollbackToSavePoint, new Action(this.OnUserRequestRollbackToSavePoint));
			base.OnBeforeDestroy();
		}

		// Token: 0x0602F971 RID: 194929 RVA: 0x00B05FA4 File Offset: 0x00B041A4
		private UniTask InitCaptionItem()
		{
			WuWaGoView.<InitCaptionItem>d__29 <InitCaptionItem>d__;
			<InitCaptionItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitCaptionItem>d__.<>4__this = this;
			<InitCaptionItem>d__.<>1__state = -1;
			<InitCaptionItem>d__.<>t__builder.Start<WuWaGoView.<InitCaptionItem>d__29>(ref <InitCaptionItem>d__);
			return <InitCaptionItem>d__.<>t__builder.Task;
		}

		// Token: 0x0602F972 RID: 194930 RVA: 0x00B05FE7 File Offset: 0x00B041E7
		protected override void OnAfterShow()
		{
			BattleUiModel.Instance.ChildViewData.AddBattleUiCommonChildVisibleReason(EBattleUiCommonChildVisibleReason.SurvivorsRogue);
			BattleUiModel.Instance.ChildViewData.SetChildVisible(EBattleUiVisibleReason.Custom, EBattleUiChild.InteractionHint, false, true, 1);
			EventSystem.Instance.Emit(EEventName.ActiveBattleView);
		}

		// Token: 0x0602F973 RID: 194931 RVA: 0x00B0601F File Offset: 0x00B0421F
		protected override void OnAfterHide()
		{
			BattleUiModel.Instance.ChildViewData.RemoveBattleUiCommonChildVisibleReason(EBattleUiCommonChildVisibleReason.SurvivorsRogue);
			BattleUiModel.Instance.ChildViewData.SetChildVisible(EBattleUiVisibleReason.Custom, EBattleUiChild.InteractionHint, true, true, 1);
		}

		// Token: 0x0602F974 RID: 194932 RVA: 0x00B06048 File Offset: 0x00B04248
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

		// Token: 0x0602F975 RID: 194933 RVA: 0x00B06148 File Offset: 0x00B04348
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

		// Token: 0x0602F976 RID: 194934 RVA: 0x00B0623B File Offset: 0x00B0443B
		private void OnInputControllerChange(EInputControllerType last, EInputControllerType now)
		{
			this.RefreshInputBinding();
		}

		// Token: 0x0602F977 RID: 194935 RVA: 0x00B06244 File Offset: 0x00B04444
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

		// Token: 0x0602F978 RID: 194936 RVA: 0x00B06284 File Offset: 0x00B04484
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

		// Token: 0x0602F979 RID: 194937 RVA: 0x00B062B6 File Offset: 0x00B044B6
		private void OnPlayTipAvailableChanged(bool available)
		{
			this.PlayTipAvailable = available;
			this.RefreshPlayTipButton();
			this.RefreshDialogueBubblePanel();
		}

		// Token: 0x0602F97A RID: 194938 RVA: 0x00B062CB File Offset: 0x00B044CB
		private void RefreshPlayTipButton()
		{
			UUIButtonComponent button = base.GetButton(6);
			if (button == null)
			{
				return;
			}
			button.SetSelfInteractive(this.PlayTipAvailable && WuWaGoController.Instance.CanUsePlayTip());
		}

		// Token: 0x0602F97B RID: 194939 RVA: 0x00B062F3 File Offset: 0x00B044F3
		private void OnMainControlInputAcceptingChanged(bool accepting)
		{
			this.RefreshPlayTipButton();
		}

		// Token: 0x0602F97C RID: 194940 RVA: 0x00B062FB File Offset: 0x00B044FB
		private void OnRollbackAvailableChanged(bool available)
		{
			this.RollbackAvailable = available;
			this.RefreshRollbackButton();
		}

		// Token: 0x0602F97D RID: 194941 RVA: 0x00B0630A File Offset: 0x00B0450A
		private void RefreshRollbackButton()
		{
			UUIButtonComponent button = base.GetButton(10);
			if (button == null)
			{
				return;
			}
			button.SetSelfInteractive(!this.CinematicPlaying && !this.IsDamageBatchActive() && this.RollbackAvailable);
		}

		// Token: 0x0602F97E RID: 194942 RVA: 0x00B06337 File Offset: 0x00B04537
		private void OnCinematicPlayingChanged(bool playing)
		{
			this.CinematicPlaying = playing;
			this.RefreshPlayTipButton();
			this.RefreshRollbackButton();
			this.RefreshSkipCinematicButton();
			this.RefreshCaptionButtons();
			this.RefreshDialogueBubblePanel();
		}

		// Token: 0x0602F97F RID: 194943 RVA: 0x00B0635E File Offset: 0x00B0455E
		private void OnDamageBatchStateChanged(bool isActive, string reason)
		{
			this.RefreshRollbackButton();
			this.RefreshCaptionButtons();
			this.RefreshPlayTipButton();
		}

		// Token: 0x0602F980 RID: 194944 RVA: 0x00B06372 File Offset: 0x00B04572
		private bool IsDamageBatchActive()
		{
			return WuWaGoController.Instance.IsDamageBatchActive();
		}

		// Token: 0x0602F981 RID: 194945 RVA: 0x00B0637E File Offset: 0x00B0457E
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

		// Token: 0x0602F982 RID: 194946 RVA: 0x00B063C0 File Offset: 0x00B045C0
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

		// Token: 0x0602F983 RID: 194947 RVA: 0x00B063F7 File Offset: 0x00B045F7
		private void OnSkipCinematicButtonClick()
		{
			WuWaGoController.Instance.RequestInterruptPlayTipCinematic();
		}

		// Token: 0x0602F984 RID: 194948 RVA: 0x00B06404 File Offset: 0x00B04604
		private void RefreshInitialProgress()
		{
			int progressTotalGridCount = WuWaGoModel.Instance.GameData.ProgressTotalGridCount;
			this.OnProgressUpdate(0, progressTotalGridCount);
		}

		// Token: 0x0602F985 RID: 194949 RVA: 0x00B06429 File Offset: 0x00B04629
		private void OnProgressUpdate(int reached, int total)
		{
			this.RefreshProgressView(reached, total);
		}

		// Token: 0x0602F986 RID: 194950 RVA: 0x00B06434 File Offset: 0x00B04634
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

		// Token: 0x0602F987 RID: 194951 RVA: 0x00B06488 File Offset: 0x00B04688
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

		// Token: 0x0602F988 RID: 194952 RVA: 0x00B064D4 File Offset: 0x00B046D4
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

		// Token: 0x0602F989 RID: 194953 RVA: 0x00B06554 File Offset: 0x00B04754
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

		// Token: 0x0602F98A RID: 194954 RVA: 0x00B065D3 File Offset: 0x00B047D3
		private void BindMouseInput()
		{
			InputDistributeController.Instance.BindAction("UI左键点击", new TInputHandle<InputDistributeDefine.EActionType>(this.OnMouseClick));
		}

		// Token: 0x0602F98B RID: 194955 RVA: 0x00B065F0 File Offset: 0x00B047F0
		private void UnbindMouseInput()
		{
			InputDistributeController.Instance.UnBindAction("UI左键点击", new TInputHandle<InputDistributeDefine.EActionType>(this.OnMouseClick));
		}

		// Token: 0x0602F98C RID: 194956 RVA: 0x00B0660D File Offset: 0x00B0480D
		private void BindTouchInput()
		{
			InputDistributeController.Instance.BindTouches(new int[1], new TInputHandle<InputDistributeDefine.ITouchData>(this.OnTouch));
		}

		// Token: 0x0602F98D RID: 194957 RVA: 0x00B0662B File Offset: 0x00B0482B
		private void UnbindTouchInput()
		{
			InputDistributeController.Instance.UnBindTouches(new <>z__ReadOnlySingleElementList<int>(0), new TInputHandle<InputDistributeDefine.ITouchData>(this.OnTouch));
		}

		// Token: 0x0602F98E RID: 194958 RVA: 0x00B06649 File Offset: 0x00B04849
		private void BindGamepadInput()
		{
			InputDistributeController.Instance.BindAxis("UiMoveForward", new TInputHandle<float>(this.OnGamepadAxis));
			InputDistributeController.Instance.BindAxis("UiMoveRight", new TInputHandle<float>(this.OnGamepadAxis));
		}

		// Token: 0x0602F98F RID: 194959 RVA: 0x00B06684 File Offset: 0x00B04884
		private void UnbindGamepadInput()
		{
			InputDistributeController.Instance.UnBindAxis("UiMoveForward", new TInputHandle<float>(this.OnGamepadAxis));
			InputDistributeController.Instance.UnBindAxis("UiMoveRight", new TInputHandle<float>(this.OnGamepadAxis));
			this.GamepadAxisForward = 0.0;
			this.GamepadAxisRight = 0.0;
			this.GamepadDirectionLatched = false;
		}

		// Token: 0x0602F990 RID: 194960 RVA: 0x00B066EC File Offset: 0x00B048EC
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

		// Token: 0x0602F991 RID: 194961 RVA: 0x00B067B0 File Offset: 0x00B049B0
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

		// Token: 0x0602F992 RID: 194962 RVA: 0x00B0680C File Offset: 0x00B04A0C
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

		// Token: 0x0602F993 RID: 194963 RVA: 0x00B06888 File Offset: 0x00B04A88
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

		// Token: 0x0602F994 RID: 194964 RVA: 0x00B06928 File Offset: 0x00B04B28
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

		// Token: 0x0602F995 RID: 194965 RVA: 0x00B069A1 File Offset: 0x00B04BA1
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

		// Token: 0x0602F996 RID: 194966 RVA: 0x00B069D8 File Offset: 0x00B04BD8
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

		// Token: 0x0602F997 RID: 194967 RVA: 0x00B06A43 File Offset: 0x00B04C43
		private void OnPlayTipsButtonClick()
		{
			this.PlayTipsButtonClickImp();
		}

		// Token: 0x0602F998 RID: 194968 RVA: 0x00B06A4C File Offset: 0x00B04C4C
		private UniTask PlayTipsButtonClickImp()
		{
			WuWaGoView.<PlayTipsButtonClickImp>d__68 <PlayTipsButtonClickImp>d__;
			<PlayTipsButtonClickImp>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayTipsButtonClickImp>d__.<>4__this = this;
			<PlayTipsButtonClickImp>d__.<>1__state = -1;
			<PlayTipsButtonClickImp>d__.<>t__builder.Start<WuWaGoView.<PlayTipsButtonClickImp>d__68>(ref <PlayTipsButtonClickImp>d__);
			return <PlayTipsButtonClickImp>d__.<>t__builder.Task;
		}

		// Token: 0x0602F999 RID: 194969 RVA: 0x00B06A8F File Offset: 0x00B04C8F
		private void OnStartSequenceEvent(string sequenceName)
		{
			UUIItem item = base.GetItem(13);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(true);
		}

		// Token: 0x0602F99A RID: 194970 RVA: 0x00B06AA4 File Offset: 0x00B04CA4
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

		// Token: 0x0602F99B RID: 194971 RVA: 0x00B06AD8 File Offset: 0x00B04CD8
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

		// Token: 0x0602F99C RID: 194972 RVA: 0x00B06B2C File Offset: 0x00B04D2C
		private void OnRollbackButtonClick()
		{
			this.RunWithFilterMaskAsync(() => WuWaGoController.Instance.RollbackToLastStepAsync()).Forget();
		}

		// Token: 0x0602F99D RID: 194973 RVA: 0x00B06B58 File Offset: 0x00B04D58
		private void OnUserRequestRollbackToSavePoint()
		{
			this.RunWithFilterMaskAsync(() => WuWaGoController.Instance.RollbackToSavePointAsync()).Forget();
		}

		// Token: 0x0602F99E RID: 194974 RVA: 0x00B06B84 File Offset: 0x00B04D84
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

		// Token: 0x0602F99F RID: 194975 RVA: 0x00B06BCF File Offset: 0x00B04DCF
		private void OnInteractionButtonClick()
		{
			EventSystem.Instance.Emit(EEventName.OnWuWaGoUserUseInteraction);
		}

		// Token: 0x04019B24 RID: 105252
		[Nullable(2)]
		private CaptionItem CaptionItem;

		// Token: 0x04019B25 RID: 105253
		private readonly List<ProgressItem> ProgressItems = new List<ProgressItem>();

		// Token: 0x04019B26 RID: 105254
		private const int MaskMinDurationMs = 500;

		// Token: 0x04019B27 RID: 105255
		private const int InteractionHintCustomSubReason = 1;

		// Token: 0x04019B28 RID: 105256
		private WuWaGoView.EBoundInputMode CurrentInputMode;

		// Token: 0x04019B29 RID: 105257
		private int? TouchTrackingId;

		// Token: 0x04019B2A RID: 105258
		private readonly Vector TouchStartPosition = Vector.Create();

		// Token: 0x04019B2B RID: 105259
		private bool HasMouseDown;

		// Token: 0x04019B2C RID: 105260
		private readonly Vector2D MouseDownPosition = Vector2D.Create(0.0, 0.0);

		// Token: 0x04019B2D RID: 105261
		private bool HasLastPreview;

		// Token: 0x04019B2E RID: 105262
		private double LastPreviewX;

		// Token: 0x04019B2F RID: 105263
		private double LastPreviewY;

		// Token: 0x04019B30 RID: 105264
		private float HoverMinPixel;

		// Token: 0x04019B31 RID: 105265
		private float SwipeMinPixelDistance;

		// Token: 0x04019B32 RID: 105266
		private bool CinematicPlaying;

		// Token: 0x04019B33 RID: 105267
		private bool PlayTipAvailable;

		// Token: 0x04019B34 RID: 105268
		private bool RollbackAvailable;

		// Token: 0x04019B35 RID: 105269
		private bool IsPlayingTip;

		// Token: 0x04019B36 RID: 105270
		private const double GamepadTriggerThreshold = 0.30000001192092896;

		// Token: 0x04019B37 RID: 105271
		private const double GamepadReleaseThreshold = 0.15000000596046448;

		// Token: 0x04019B38 RID: 105272
		private double GamepadAxisForward;

		// Token: 0x04019B39 RID: 105273
		private double GamepadAxisRight;

		// Token: 0x04019B3A RID: 105274
		private bool GamepadDirectionLatched;

		// Token: 0x0200A973 RID: 43379
		[NullableContext(0)]
		private enum EViewComponent
		{
			// Token: 0x04033935 RID: 211253
			CaptionItem,
			// Token: 0x04033936 RID: 211254
			ProgressPanelItem,
			// Token: 0x04033937 RID: 211255
			ProgressText,
			// Token: 0x04033938 RID: 211256
			ProgressHorizontalLayout,
			// Token: 0x04033939 RID: 211257
			ProgressItem,
			// Token: 0x0403393A RID: 211258
			DialogueBubblePanel,
			// Token: 0x0403393B RID: 211259
			PlayTipBtn,
			// Token: 0x0403393C RID: 211260
			TipsIconSprite,
			// Token: 0x0403393D RID: 211261
			TipText,
			// Token: 0x0403393E RID: 211262
			GameplayTipsText,
			// Token: 0x0403393F RID: 211263
			RollbackBtn,
			// Token: 0x04033940 RID: 211264
			RollbackBtnNumText,
			// Token: 0x04033941 RID: 211265
			InteractionBtn,
			// Token: 0x04033942 RID: 211266
			PanelBubble,
			// Token: 0x04033943 RID: 211267
			PanelFilter,
			// Token: 0x04033944 RID: 211268
			SkipCinematicBtn
		}

		// Token: 0x0200A974 RID: 43380
		[NullableContext(0)]
		private enum EBoundInputMode
		{
			// Token: 0x04033946 RID: 211270
			None,
			// Token: 0x04033947 RID: 211271
			MouseKeyboard,
			// Token: 0x04033948 RID: 211272
			Touch,
			// Token: 0x04033949 RID: 211273
			Gamepad
		}
	}
}
