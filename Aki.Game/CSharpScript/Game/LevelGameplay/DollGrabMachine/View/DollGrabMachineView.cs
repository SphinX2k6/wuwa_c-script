using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.GamePlay.DollGrab;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Interaction;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine.View
{
	// Token: 0x02006EDE RID: 28382
	[NullableContext(2)]
	[Nullable(0)]
	public class DollGrabMachineView : UiTickViewBase
	{
		// Token: 0x06045218 RID: 283160 RVA: 0x01118808 File Offset: 0x01116A08
		[NullableContext(1)]
		public DollGrabMachineView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06045219 RID: 283161 RVA: 0x01118828 File Offset: 0x01116A28
		protected unsafe override void OnRegisterComponent()
		{
			int num = 19;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUISliderComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUISliderComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIArtText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIArtText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIArtText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClawButtonClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0604521A RID: 283162 RVA: 0x01118B0C File Offset: 0x01116D0C
		protected override UniTask OnBeforeStartAsync()
		{
			DollGrabMachineView.<OnBeforeStartAsync>d__28 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DollGrabMachineView.<OnBeforeStartAsync>d__28>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0604521B RID: 283163 RVA: 0x01118B50 File Offset: 0x01116D50
		protected override UniTask OnBeforeShowAsyncImplementImplement()
		{
			DollGrabMachineView.<OnBeforeShowAsyncImplementImplement>d__29 <OnBeforeShowAsyncImplementImplement>d__;
			<OnBeforeShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeShowAsyncImplementImplement>d__.<>4__this = this;
			<OnBeforeShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Start<DollGrabMachineView.<OnBeforeShowAsyncImplementImplement>d__29>(ref <OnBeforeShowAsyncImplementImplement>d__);
			return <OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0604521C RID: 283164 RVA: 0x01118B94 File Offset: 0x01116D94
		private void InitTimeBar()
		{
			this.SldBar = base.GetSlider(7);
			this.SldBarAdd = base.GetSlider(8);
			UUISliderComponent sldBar = this.SldBar;
			if (sldBar != null)
			{
				sldBar.SetValue(1f, true);
			}
			UUISliderComponent sldBarAdd = this.SldBarAdd;
			if (sldBarAdd != null)
			{
				sldBarAdd.SetValue(0f, true);
			}
			this.PnlBar = base.GetItem(14);
			UUIItem pnlBar = this.PnlBar;
			if (pnlBar != null)
			{
				pnlBar.SetUIActive(false);
			}
			UUIItem pnlAddTimeTxt = this.PnlAddTimeTxt;
			if (pnlAddTimeTxt != null)
			{
				pnlAddTimeTxt.SetUIActive(false);
			}
			this.SprPoint = base.GetSprite(17);
			this.SprFill = base.GetSprite(16);
			this.SprPointOriginalColor = new FColor?(this.SprPoint.Color);
			this.SprPointChangeColor = new FColor?(this.SprPoint.changeColor);
		}

		// Token: 0x0604521D RID: 283165 RVA: 0x01118C64 File Offset: 0x01116E64
		protected override void OnBeforeHide()
		{
			this.RemoveEventListener();
			if (UiManager.Instance.IsViewOpen(EUiViewName.DollGrabFloatCountDownView))
			{
				UiManager.Instance.CloseView(EUiViewName.DollGrabFloatCountDownView, null);
			}
			if (UiManager.Instance.IsViewOpen(EUiViewName.DollGrabMachineSeltView))
			{
				UiManager.Instance.CloseView(EUiViewName.DollGrabMachineSeltView, null);
			}
			this.UnbindAllInput();
			if (this.MobileJoystick != null)
			{
				this.MobileJoystick.Reset();
				this.MobileJoystick.HideBattleVisibleChildView();
				this.MobileJoystick = null;
			}
		}

		// Token: 0x0604521E RID: 283166 RVA: 0x01118CE4 File Offset: 0x01116EE4
		[NullableContext(1)]
		private void OpenViewCamera(Action finishCallback)
		{
			Vector commonTempVector = MathUtils.Instance.CommonTempVector;
			FVector 相机位置 = DollGrabModel.Instance.DollGrabMachineGlobalConfig.相机位置;
			commonTempVector.FromUeVector(相机位置);
			Rotator commonTempRotator = MathUtils.Instance.CommonTempRotator;
			FRotator 相机旋转 = DollGrabModel.Instance.DollGrabMachineGlobalConfig.相机旋转;
			commonTempRotator.FromUeRotator(相机旋转);
			DollGrabCameraConfig cameraInfo = new DollGrabCameraConfig(MathUtils.Instance.CommonTempVector, MathUtils.Instance.CommonTempRotator, DollGrabModel.Instance.DollGrabMachineGlobalConfig.淡入时间, DollGrabModel.Instance.DollGrabMachineGlobalConfig.淡出时间, DollGrabModel.Instance.DollGrabMachineGlobalConfig.关闭镜头碰撞, DollGrabModel.Instance.DollGrabMachineGlobalConfig.关闭镜头虚化, DollGrabModel.Instance.DollGrabMachineGlobalConfig.Fov);
			SceneItemActorComponent component = DollGrabMachineController.Instance.CurrentDollGrabMachineComponent.Entity.GetComponent<SceneItemActorComponent>();
			DollGrabModel.Instance.ExecuteAdjustPlayerCamera(component, cameraInfo, "DollGrabMachineFixCamera", delegate(ELevelEventState result)
			{
				if (result == ELevelEventState.Success)
				{
					finishCallback();
				}
			});
		}

		// Token: 0x0604521F RID: 283167 RVA: 0x01118DD8 File Offset: 0x01116FD8
		private UniTask InitMobileJoystick()
		{
			DollGrabMachineView.<InitMobileJoystick>d__33 <InitMobileJoystick>d__;
			<InitMobileJoystick>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitMobileJoystick>d__.<>4__this = this;
			<InitMobileJoystick>d__.<>1__state = -1;
			<InitMobileJoystick>d__.<>t__builder.Start<DollGrabMachineView.<InitMobileJoystick>d__33>(ref <InitMobileJoystick>d__);
			return <InitMobileJoystick>d__.<>t__builder.Task;
		}

		// Token: 0x06045220 RID: 283168 RVA: 0x01118E1B File Offset: 0x0111701B
		private void OnShowTypeChange(EOperationType last, EOperationType now)
		{
			if (now == EOperationType.Pad)
			{
				this.BindTouchInput();
				return;
			}
			this.UnbindTouchInput();
		}

		// Token: 0x06045221 RID: 283169 RVA: 0x01118E30 File Offset: 0x01117030
		private void OnInputControllerChange(EInputControllerType last, EInputControllerType now)
		{
			EBoundInputMode eboundInputMode = EBoundInputMode.None;
			if (Info.Instance.IsInTouch())
			{
				eboundInputMode = EBoundInputMode.Touch;
			}
			else if (Info.Instance.IsInGamepad())
			{
				eboundInputMode = EBoundInputMode.Gamepad;
			}
			else if (Info.Instance.IsInKeyBoard())
			{
				eboundInputMode = EBoundInputMode.MouseKeyboard;
			}
			if (eboundInputMode == this.CurrentInputMode)
			{
				return;
			}
			this.UnbindAllInput();
			this.CurrentInputMode = eboundInputMode;
			switch (eboundInputMode)
			{
			case EBoundInputMode.MouseKeyboard:
				this.BindKeyBoardInput();
				return;
			case EBoundInputMode.Touch:
				this.BindTouchInput();
				return;
			case EBoundInputMode.Gamepad:
				this.BindGamepadInput();
				return;
			default:
				return;
			}
		}

		// Token: 0x06045222 RID: 283170 RVA: 0x01118EB0 File Offset: 0x011170B0
		private void BindKeyBoardInput()
		{
			InputDistributeController.Instance.BindAction("UI方向上", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInput));
			InputDistributeController.Instance.BindAction("UI方向下", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInput));
			InputDistributeController.Instance.BindAction("UI方向左", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInput));
			InputDistributeController.Instance.BindAction("UI方向右", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInput));
		}

		// Token: 0x06045223 RID: 283171 RVA: 0x01118F2C File Offset: 0x0111712C
		private void UnbindKeyBoardInput()
		{
			InputDistributeController.Instance.UnBindAction("UI方向上", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInput));
			InputDistributeController.Instance.UnBindAction("UI方向下", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInput));
			InputDistributeController.Instance.UnBindAction("UI方向左", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInput));
			InputDistributeController.Instance.UnBindAction("UI方向右", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInput));
		}

		// Token: 0x06045224 RID: 283172 RVA: 0x01118FA5 File Offset: 0x011171A5
		private void BindTouchInput()
		{
			if (this.MobileJoystick == null)
			{
				this.InitMobileJoystick();
				return;
			}
			this.MobileJoystick.ShowBattleVisibleChildView();
		}

		// Token: 0x06045225 RID: 283173 RVA: 0x01118FC2 File Offset: 0x011171C2
		private void UnbindTouchInput()
		{
			if (this.MobileJoystick != null)
			{
				this.MobileJoystick.HideBattleVisibleChildView();
				return;
			}
			UUIItem item = base.GetItem(6);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
		}

		// Token: 0x06045226 RID: 283174 RVA: 0x01118FEA File Offset: 0x011171EA
		private void BindGamepadInput()
		{
			InputDistributeController.Instance.BindAxis("NavigationTopDown", new TInputHandle<float>(this.OnAxis));
			InputDistributeController.Instance.BindAxis("NavigationLeftRight", new TInputHandle<float>(this.OnAxis));
		}

		// Token: 0x06045227 RID: 283175 RVA: 0x01119022 File Offset: 0x01117222
		private void UnbindGamepadInput()
		{
			InputDistributeController.Instance.UnBindAxis("NavigationTopDown", new TInputHandle<float>(this.OnAxis));
			InputDistributeController.Instance.UnBindAxis("NavigationLeftRight", new TInputHandle<float>(this.OnAxis));
		}

		// Token: 0x06045228 RID: 283176 RVA: 0x0111905C File Offset: 0x0111725C
		private void UnbindAllInput()
		{
			switch (this.CurrentInputMode)
			{
			case EBoundInputMode.MouseKeyboard:
				this.UnbindKeyBoardInput();
				return;
			case EBoundInputMode.Touch:
				this.UnbindTouchInput();
				return;
			case EBoundInputMode.Gamepad:
				this.UnbindGamepadInput();
				return;
			default:
				return;
			}
		}

		// Token: 0x06045229 RID: 283177 RVA: 0x0111909C File Offset: 0x0111729C
		protected override void OnTick(float delta)
		{
			if (TickSystem.Instance.IsPaused || this.SldBar == null || this.SldBarAdd == null || !DollGrabMachineController.Instance.IsGameplayReady)
			{
				return;
			}
			DollGrabMachineJoystick mobileJoystick = this.MobileJoystick;
			if (mobileJoystick != null)
			{
				mobileJoystick.Tick(delta);
			}
			float num = DollGrabMachineController.Instance.RemainingTime / DollGrabMachineController.Instance.RemainingTimeLimit;
			UUISliderComponent sldBar = this.SldBar;
			if (sldBar != null)
			{
				sldBar.SetValue(num, true);
			}
			UUISliderComponent sldBarAdd = this.SldBarAdd;
			if (sldBarAdd == null)
			{
				return;
			}
			sldBarAdd.SetValue(num - DollGrabMachineController.Instance.AddRemainingTime / DollGrabMachineController.Instance.RemainingTimeLimit, true);
		}

		// Token: 0x0604522A RID: 283178 RVA: 0x01119138 File Offset: 0x01117338
		protected void AddEventListener()
		{
			EventSystem.Instance.Add<Action>(EEventName.OnDollGrabMachineStartCoolDown, new Action<Action>(this.OnDollGrabMachineStartCoolDown));
			EventSystem.Instance.Add<EDollGrabMachineEndReason>(EEventName.OnDollGrabMachineEnd, new Action<EDollGrabMachineEndReason>(this.OnDollGrabMachineEnd));
			EventSystem.Instance.Add(EEventName.OnDollGrabMachineRestart, new Action(this.OnDollGrabMachineRestart));
			EventSystem.Instance.Add<EDollGrabMachineClawState>(EEventName.OnDollGrabMachineClawStateStart, new Action<EDollGrabMachineClawState>(this.OnDollGrabMachineClawStateStart));
			EventSystem.Instance.Add<bool>(EEventName.OnDollGrabMachineGrabbingActorChanged, new Action<bool>(this.OnDollGrabMachineGrabbingActorChanged));
			EventSystem.Instance.Add<float>(EEventName.OnDollGrabMachineRemainingTimeAdd, new Action<float>(this.OnDollGrabMachineRemainingTimeAdd));
			EventSystem.Instance.Add<bool>(EEventName.OnDollGrabMachineDangerousCountdown, new Action<bool>(this.OnDollGrabMachineDangerousCountdown));
			EventSystem.Instance.Add<EOperationType, EOperationType>(EEventName.ShowTypeChange, new Action<EOperationType, EOperationType>(this.OnShowTypeChange));
			EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
			if (DollGrabMachineController.Instance.IsEndlessMode)
			{
				EventSystem.Instance.Add<int, int>(EEventName.OnDollGrabMachineEndlessScoreChanged, new Action<int, int>(this.OnDollGrabMachineEndlessScoreChanged));
				return;
			}
			EventSystem.Instance.Add<int, List<IGrabItemData>>(EEventName.OnDollGrabMachineGrabDoll, new Action<int, List<IGrabItemData>>(this.OnDollGrabMachineGrabDoll));
		}

		// Token: 0x0604522B RID: 283179 RVA: 0x01119288 File Offset: 0x01117488
		protected void RemoveEventListener()
		{
			EventSystem.Instance.Remove<Action>(EEventName.OnDollGrabMachineStartCoolDown, new Action<Action>(this.OnDollGrabMachineStartCoolDown));
			EventSystem.Instance.Remove<EDollGrabMachineEndReason>(EEventName.OnDollGrabMachineEnd, new Action<EDollGrabMachineEndReason>(this.OnDollGrabMachineEnd));
			EventSystem.Instance.Remove(EEventName.OnDollGrabMachineRestart, new Action(this.OnDollGrabMachineRestart));
			EventSystem.Instance.Remove<bool>(EEventName.OnDollGrabMachineGrabbingActorChanged, new Action<bool>(this.OnDollGrabMachineGrabbingActorChanged));
			EventSystem.Instance.Remove<float>(EEventName.OnDollGrabMachineRemainingTimeAdd, new Action<float>(this.OnDollGrabMachineRemainingTimeAdd));
			EventSystem.Instance.Remove<bool>(EEventName.OnDollGrabMachineDangerousCountdown, new Action<bool>(this.OnDollGrabMachineDangerousCountdown));
			EventSystem.Instance.Remove<EOperationType, EOperationType>(EEventName.ShowTypeChange, new Action<EOperationType, EOperationType>(this.OnShowTypeChange));
			EventSystem.Instance.Remove<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
			if (DollGrabMachineController.Instance.IsEndlessMode)
			{
				EventSystem.Instance.Remove<int, int>(EEventName.OnDollGrabMachineEndlessScoreChanged, new Action<int, int>(this.OnDollGrabMachineEndlessScoreChanged));
			}
			else
			{
				EventSystem.Instance.Remove<int, List<IGrabItemData>>(EEventName.OnDollGrabMachineGrabDoll, new Action<int, List<IGrabItemData>>(this.OnDollGrabMachineGrabDoll));
			}
			if (EventSystem.Instance.Has<EDollGrabMachineClawState>(EEventName.OnDollGrabMachineClawStateStart, new Action<EDollGrabMachineClawState>(this.OnDollGrabMachineClawStateStart)))
			{
				EventSystem.Instance.Remove<EDollGrabMachineClawState>(EEventName.OnDollGrabMachineClawStateStart, new Action<EDollGrabMachineClawState>(this.OnDollGrabMachineClawStateStart));
			}
			if (EventSystem.Instance.Has(EEventName.OnDollGrabMachineEndCoolDown, new Action(this.OnDollGrabMachineCountDownEnd)))
			{
				EventSystem.Instance.Remove(EEventName.OnDollGrabMachineEndCoolDown, new Action(this.OnDollGrabMachineCountDownEnd));
			}
		}

		// Token: 0x0604522C RID: 283180 RVA: 0x01119430 File Offset: 0x01117630
		private void OnDollGrabMachineStartCoolDown(Action callback)
		{
			if (UiManager.Instance.IsViewOpen(EUiViewName.DollGrabMachineSeltView))
			{
				UiManager.Instance.CloseView(EUiViewName.DollGrabMachineSeltView, null);
			}
			string multiTextByKey = TextConfig.Instance.GetMultiTextByKey("Btn_GrabDoll_Text");
			UUIText clawBtnText = this.ClawBtnText;
			if (clawBtnText != null)
			{
				clawBtnText.SetText(multiTextByKey ?? "抓取", true);
			}
			UUIText clawBtnText2 = this.ClawBtnText;
			if (clawBtnText2 != null)
			{
				clawBtnText2.SetUIActive(true);
			}
			this.SwitchClawButtonState(EClawButtonState.Grab);
			UUIButtonComponent clawBtn = this.ClawBtn;
			if (clawBtn != null)
			{
				clawBtn.SetSelfInteractive(false);
			}
			UUIItem pnlCost = this.PnlCost;
			if (pnlCost != null)
			{
				pnlCost.SetUIActive(false);
			}
			TsInteractionUtils.RegisterOpenViewName(EUiViewName.DollGrabMachineCountDownView);
			UiManager.Instance.OpenView(EUiViewName.DollGrabMachineCountDownView, null, null);
			this.CountDownCallback = callback;
			EventSystem.Instance.Once(EEventName.OnDollGrabMachineEndCoolDown, new Action(this.OnDollGrabMachineCountDownEnd));
		}

		// Token: 0x0604522D RID: 283181 RVA: 0x01119508 File Offset: 0x01117708
		private void OnDollGrabMachineCountDownEnd()
		{
			Action countDownCallback = this.CountDownCallback;
			if (countDownCallback != null)
			{
				countDownCallback();
			}
			this.CountDownCallback = null;
			UUIButtonComponent clawBtn = this.ClawBtn;
			if (clawBtn != null)
			{
				clawBtn.SetSelfInteractive(true);
			}
			UUISliderComponent sldBar = this.SldBar;
			if (sldBar != null)
			{
				sldBar.SetValue(1f, true);
			}
			UUISliderComponent sldBarAdd = this.SldBarAdd;
			if (sldBarAdd != null)
			{
				sldBarAdd.SetValue(0f, true);
			}
			UUIItem pnlBar = this.PnlBar;
			if (pnlBar != null)
			{
				pnlBar.SetUIActive(true);
			}
			if (!EventSystem.Instance.Has<EDollGrabMachineClawState>(EEventName.OnDollGrabMachineClawStateStart, new Action<EDollGrabMachineClawState>(this.OnDollGrabMachineClawStateStart)))
			{
				EventSystem.Instance.Add<EDollGrabMachineClawState>(EEventName.OnDollGrabMachineClawStateStart, new Action<EDollGrabMachineClawState>(this.OnDollGrabMachineClawStateStart));
			}
			if (this.CurrentInputMode == EBoundInputMode.Touch)
			{
				DollGrabMachineJoystick mobileJoystick = this.MobileJoystick;
				if (mobileJoystick == null)
				{
					return;
				}
				mobileJoystick.ShowBattleVisibleChildView();
			}
		}

		// Token: 0x0604522E RID: 283182 RVA: 0x011195D1 File Offset: 0x011177D1
		[NullableContext(1)]
		private void OnAxis(string axisName, float value)
		{
			DollGrabMachineController.Instance.OnAxisMoveInput(axisName, value);
		}

		// Token: 0x0604522F RID: 283183 RVA: 0x011195DF File Offset: 0x011177DF
		[NullableContext(1)]
		private void OnAxis(string axisName, float value, InputIdentification inputIdentification)
		{
			this.OnAxis(axisName, value);
		}

		// Token: 0x06045230 RID: 283184 RVA: 0x011195EC File Offset: 0x011177EC
		[NullableContext(1)]
		private unsafe void OnInput(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification inputIdentification)
		{
			if (actionName == "UI方向上")
			{
				DollGrabMachineController.Instance.OnClickMoveInput("向前移动", actionType);
			}
			else if (actionName == "UI方向下")
			{
				DollGrabMachineController.Instance.OnClickMoveInput("向后移动", actionType);
			}
			else if (actionName == "UI方向左")
			{
				DollGrabMachineController.Instance.OnClickMoveInput("向左移动", actionType);
			}
			else if (actionName == "UI方向右")
			{
				DollGrabMachineController.Instance.OnClickMoveInput("向右移动", actionType);
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.DollGrabMachine;
			ELogAuthor author = ELogAuthor.FJH;
			string message = "[input] OnInput";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ActionName", actionName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ActionType", actionType.ToString());
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}

		// Token: 0x06045231 RID: 283185 RVA: 0x011196D5 File Offset: 0x011178D5
		private void OnClawButtonClick()
		{
			if (!DollGrabMachineController.Instance.IsGameplayReady)
			{
				DollGrabMachineController.Instance.OnClickStart();
				return;
			}
			DollGrabMachineController.Instance.OnClickGrab();
		}

		// Token: 0x06045232 RID: 283186 RVA: 0x011196F8 File Offset: 0x011178F8
		private void OnDollGrabMachineEnd(EDollGrabMachineEndReason endReason)
		{
			switch (endReason)
			{
			case EDollGrabMachineEndReason.TimeUp:
				UiManager.Instance.OpenView(EUiViewName.DollGrabMachineTimeUpView, null, null);
				break;
			case EDollGrabMachineEndReason.GetAll:
				UiManager.Instance.OpenView(EUiViewName.DollGrabMachineGetAllView, null, null);
				break;
			case EDollGrabMachineEndReason.Exit:
				UiManager.Instance.OpenView(EUiViewName.DollGrabMachineSeltView, null, null);
				break;
			}
			if (UiManager.Instance.IsViewOpen(EUiViewName.DollGrabFloatCountDownView))
			{
				UiManager.Instance.CloseView(EUiViewName.DollGrabFloatCountDownView, null);
			}
			UUIItem pnlBar = this.PnlBar;
			if (pnlBar != null)
			{
				pnlBar.SetUIActive(false);
			}
			UUIButtonComponent clawBtn = this.ClawBtn;
			if (clawBtn != null)
			{
				clawBtn.SetSelfInteractive(false);
			}
			if (this.CurrentInputMode == EBoundInputMode.Touch)
			{
				DollGrabMachineJoystick mobileJoystick = this.MobileJoystick;
				if (mobileJoystick != null)
				{
					mobileJoystick.HideBattleVisibleChildView();
				}
			}
			if (DollGrabMachineController.Instance.IsEndlessMode)
			{
				this.RefreshEndlessView();
			}
		}

		// Token: 0x06045233 RID: 283187 RVA: 0x011197C4 File Offset: 0x011179C4
		private void OnDollGrabMachineRestart()
		{
			if (UiManager.Instance.IsViewOpen(EUiViewName.DollGrabMachineSeltView))
			{
				UiManager.Instance.CloseView(EUiViewName.DollGrabMachineSeltView, null);
			}
			if (DollGrabMachineController.Instance.IsEndlessMode)
			{
				LguiUtil.Instance.SetLocalTextNew(this.ClawBtnText, "Btn_GrabDoll_Text", Array.Empty<object>());
				UUIText clawBtnText = this.ClawBtnText;
				if (clawBtnText != null)
				{
					clawBtnText.SetUIActive(true);
				}
				this.SwitchClawButtonState(EClawButtonState.Grab);
				UUIButtonComponent clawBtn = this.ClawBtn;
				if (clawBtn != null)
				{
					clawBtn.SetSelfInteractive(false);
				}
				UiManager.Instance.OpenView(EUiViewName.DollGrabEndlessStartView, null, null);
			}
			else
			{
				UUIText clawBtnText2 = this.ClawBtnText;
				if (clawBtnText2 != null)
				{
					clawBtnText2.SetUIActive(false);
				}
				this.SwitchClawButtonState(EClawButtonState.InsertCoin);
				UUIItem pnlCost = this.PnlCost;
				if (pnlCost != null)
				{
					pnlCost.SetUIActive(true);
				}
				UUIButtonComponent clawBtn2 = this.ClawBtn;
				if (clawBtn2 != null)
				{
					clawBtn2.SetSelfInteractive(true);
				}
			}
			this.OnDollGrabMachineDangerousCountdown(false);
		}

		// Token: 0x06045234 RID: 283188 RVA: 0x0111989C File Offset: 0x01117A9C
		private void OnDollGrabMachineClawStateStart(EDollGrabMachineClawState state)
		{
			if (!DollGrabMachineController.Instance.IsGameplayReady)
			{
				return;
			}
			switch (state)
			{
			case EDollGrabMachineClawState.Idle:
			{
				UUIButtonComponent clawBtn = this.ClawBtn;
				if (clawBtn != null)
				{
					clawBtn.SetSelfInteractive(true);
				}
				if (DollGrabMachineController.Instance.HasGrabbingActor)
				{
					string multiTextByKey = TextConfig.Instance.GetMultiTextByKey("Btn_ReleaseClaw_Text");
					UUIText clawBtnText = this.ClawBtnText;
					if (clawBtnText != null)
					{
						clawBtnText.SetText(multiTextByKey ?? "松开", true);
					}
					this.SwitchClawButtonState(EClawButtonState.Release);
					return;
				}
				string multiTextByKey2 = TextConfig.Instance.GetMultiTextByKey("Btn_GrabDoll_Text");
				UUIText clawBtnText2 = this.ClawBtnText;
				if (clawBtnText2 != null)
				{
					clawBtnText2.SetText(multiTextByKey2 ?? "抓取", true);
				}
				this.SwitchClawButtonState(EClawButtonState.Grab);
				break;
			}
			case EDollGrabMachineClawState.MovingDown:
			case EDollGrabMachineClawState.Release:
			{
				UUIButtonComponent clawBtn2 = this.ClawBtn;
				if (clawBtn2 == null)
				{
					return;
				}
				clawBtn2.SetSelfInteractive(false);
				return;
			}
			case EDollGrabMachineClawState.MovingUp:
			case EDollGrabMachineClawState.Grabbing:
				break;
			default:
				return;
			}
		}

		// Token: 0x06045235 RID: 283189 RVA: 0x01119968 File Offset: 0x01117B68
		private void OnDollGrabMachineGrabbingActorChanged(bool hasGrabbingActor)
		{
			if (hasGrabbingActor)
			{
				EDollGrabMachineClawState? clawState = DollGrabMachineController.Instance.ClawState;
				EDollGrabMachineClawState edollGrabMachineClawState = EDollGrabMachineClawState.Idle;
				if (clawState.GetValueOrDefault() == edollGrabMachineClawState & clawState != null)
				{
					string multiTextByKey = TextConfig.Instance.GetMultiTextByKey("Btn_ReleaseClaw_Text");
					UUIText clawBtnText = this.ClawBtnText;
					if (clawBtnText != null)
					{
						clawBtnText.SetText(multiTextByKey ?? "松开", true);
					}
					this.SwitchClawButtonState(EClawButtonState.Release);
					return;
				}
			}
			if (!hasGrabbingActor)
			{
				EDollGrabMachineClawState? clawState = DollGrabMachineController.Instance.ClawState;
				EDollGrabMachineClawState edollGrabMachineClawState = EDollGrabMachineClawState.Idle;
				if (clawState.GetValueOrDefault() == edollGrabMachineClawState & clawState != null)
				{
					string multiTextByKey2 = TextConfig.Instance.GetMultiTextByKey("Btn_GrabDoll_Text");
					UUIText clawBtnText2 = this.ClawBtnText;
					if (clawBtnText2 != null)
					{
						clawBtnText2.SetText(multiTextByKey2 ?? "抓取", true);
					}
					this.SwitchClawButtonState(EClawButtonState.Grab);
				}
			}
		}

		// Token: 0x06045236 RID: 283190 RVA: 0x01119A24 File Offset: 0x01117C24
		private void OnDollGrabMachineRemainingTimeAdd(float remainingTime)
		{
			UUIItem pnlAddTimeTxt = this.PnlAddTimeTxt;
			if (pnlAddTimeTxt != null)
			{
				pnlAddTimeTxt.SetUIActive(true);
			}
			UUIArtText addTimeTxt = this.AddTimeTxt;
			if (addTimeTxt != null)
			{
				addTimeTxt.SetText("+" + (remainingTime / 1000f).ToString() + "s");
			}
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlayLevelSequenceByName("Time_Up", false, null, false);
		}

		// Token: 0x06045237 RID: 283191 RVA: 0x01119A94 File Offset: 0x01117C94
		[NullableContext(1)]
		private void OnDollGrabMachineGrabDoll(int leaveDollCount, List<IGrabItemData> grabItemDataList)
		{
			ItemHintViewNewData itemHintViewNewData = new ItemHintViewNewData();
			this.ReceiveItemList.AddRange(grabItemDataList);
			if (UiManager.Instance.IsViewOpen(EUiViewName.ItemHintViewNew))
			{
				return;
			}
			itemHintViewNewData.CheckPriorNext = (() => this.ReceiveItemList.Count > 0);
			itemHintViewNewData.ShiftPriorItem = delegate()
			{
				IGrabItemData grabItemData = this.ReceiveItemList[0];
				this.ReceiveItemList.RemoveAt(0);
				ItemRewardInfo itemRewardInfo = new ItemRewardInfo();
				itemRewardInfo.ItemId = new int?(grabItemData.ItemId);
				itemRewardInfo.ItemCount = new int?(grabItemData.Count);
				ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(grabItemData.ItemId);
				itemRewardInfo.Quality = itemConfigData.QualityId;
				return itemRewardInfo;
			};
			UiManager.Instance.OpenViewAsync(EUiViewName.ItemHintViewNew, itemHintViewNewData, null).ContinueWith(delegate(int? viewId)
			{
				bool flag = viewId != null;
			}).Forget();
		}

		// Token: 0x06045238 RID: 283192 RVA: 0x01119B2C File Offset: 0x01117D2C
		private void OnDollGrabMachineEndlessScoreChanged(int newScore, int addScore)
		{
			UUIArtText endlessScoreText = this.EndlessScoreText;
			if (endlessScoreText != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
				defaultInterpolatedStringHandler.AppendFormatted<int>(newScore);
				endlessScoreText.SetText(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			UUIArtText endlessScoreAddText = this.EndlessScoreAddText;
			if (endlessScoreAddText != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
				defaultInterpolatedStringHandler.AppendLiteral("+");
				defaultInterpolatedStringHandler.AppendFormatted<int>(addScore);
				endlessScoreAddText.SetText(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			UUIItem endlessScoreAddItem = this.EndlessScoreAddItem;
			if (endlessScoreAddItem != null)
			{
				endlessScoreAddItem.SetUIActive(true);
			}
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlayLevelSequenceByName("Score_Up", false, null, false);
		}

		// Token: 0x06045239 RID: 283193 RVA: 0x01119BC9 File Offset: 0x01117DC9
		private void RefreshEndlessView()
		{
			UUIArtText endlessScoreText = this.EndlessScoreText;
			if (endlessScoreText != null)
			{
				endlessScoreText.SetText("0");
			}
			UUIItem endlessScoreAddItem = this.EndlessScoreAddItem;
			if (endlessScoreAddItem == null)
			{
				return;
			}
			endlessScoreAddItem.SetUIActive(false);
		}

		// Token: 0x0604523A RID: 283194 RVA: 0x01119BF4 File Offset: 0x01117DF4
		private void SwitchClawButtonState(EClawButtonState state)
		{
			if (this.TexClaw == null)
			{
				return;
			}
			if (!this.ClawIconTextureMap.ContainsKey(state))
			{
				return;
			}
			UTexture utexture = this.ClawIconTextureMap[state];
			this.TexClaw.SetTexture(utexture);
			this.ClawTextureTransitionComp.SetAllStateTexture(utexture);
		}

		// Token: 0x0604523B RID: 283195 RVA: 0x01119C40 File Offset: 0x01117E40
		[NullableContext(1)]
		private UniTask LoadTexture([Nullable(2)] string path, Dictionary<EClawButtonState, UTexture> container, EClawButtonState key)
		{
			DollGrabMachineView.<LoadTexture>d__61 <LoadTexture>d__;
			<LoadTexture>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadTexture>d__.<>4__this = this;
			<LoadTexture>d__.path = path;
			<LoadTexture>d__.container = container;
			<LoadTexture>d__.key = key;
			<LoadTexture>d__.<>1__state = -1;
			<LoadTexture>d__.<>t__builder.Start<DollGrabMachineView.<LoadTexture>d__61>(ref <LoadTexture>d__);
			return <LoadTexture>d__.<>t__builder.Task;
		}

		// Token: 0x0604523C RID: 283196 RVA: 0x01119C9C File Offset: 0x01117E9C
		private void OnDollGrabMachineDangerousCountdown(bool isEnterDangerous)
		{
			if (isEnterDangerous)
			{
				this.SprPoint.SetColor(this.SprPointChangeColor.Value);
				BP_DollGrabMachineGlobalConfig_C dollGrabMachineGlobalConfig = DollGrabModel.Instance.DollGrabMachineGlobalConfig;
				this.SetSpriteByPath(((dollGrabMachineGlobalConfig != null) ? dollGrabMachineGlobalConfig.进度条危险.ToAssetPathName() : null) ?? "", this.SprFill, false, null, null);
				return;
			}
			this.SprPoint.SetColor(this.SprPointOriginalColor.Value);
			BP_DollGrabMachineGlobalConfig_C dollGrabMachineGlobalConfig2 = DollGrabModel.Instance.DollGrabMachineGlobalConfig;
			this.SetSpriteByPath(((dollGrabMachineGlobalConfig2 != null) ? dollGrabMachineGlobalConfig2.进度条安全.ToAssetPathName() : null) ?? "", this.SprFill, false, null, null);
		}

		// Token: 0x0604523D RID: 283197 RVA: 0x01119D4F File Offset: 0x01117F4F
		[NullableContext(1)]
		private void OnSequenceClose(string sequenceName)
		{
			if (sequenceName == "Score_Up")
			{
				UUIItem endlessScoreAddItem = this.EndlessScoreAddItem;
				if (endlessScoreAddItem != null)
				{
					endlessScoreAddItem.SetUIActive(false);
				}
			}
			if (sequenceName == "Time_Up")
			{
				UUIItem pnlAddTimeTxt = this.PnlAddTimeTxt;
				if (pnlAddTimeTxt == null)
				{
					return;
				}
				pnlAddTimeTxt.SetUIActive(false);
			}
		}

		// Token: 0x04024011 RID: 147473
		private UUIButtonComponent ClawBtn;

		// Token: 0x04024012 RID: 147474
		private UUIText ClawBtnText;

		// Token: 0x04024013 RID: 147475
		private DollGrabMachineCaptionPanel CaptionPanel;

		// Token: 0x04024014 RID: 147476
		private DollGrabMachineMissionPanel MissionPanel;

		// Token: 0x04024015 RID: 147477
		private UUIArtText EndlessScoreText;

		// Token: 0x04024016 RID: 147478
		private UUIArtText EndlessScoreAddText;

		// Token: 0x04024017 RID: 147479
		private UUIItem EndlessScoreAddItem;

		// Token: 0x04024018 RID: 147480
		private UUISliderComponent SldBar;

		// Token: 0x04024019 RID: 147481
		private UUISliderComponent SldBarAdd;

		// Token: 0x0402401A RID: 147482
		private UUIItem PnlBar;

		// Token: 0x0402401B RID: 147483
		private UUIText CostText;

		// Token: 0x0402401C RID: 147484
		private UUIItem PnlCost;

		// Token: 0x0402401D RID: 147485
		private UUIItem PnlAddTimeTxt;

		// Token: 0x0402401E RID: 147486
		private UUIArtText AddTimeTxt;

		// Token: 0x0402401F RID: 147487
		private UUITexture TexClaw;

		// Token: 0x04024020 RID: 147488
		private Action CountDownCallback;

		// Token: 0x04024021 RID: 147489
		[Nullable(1)]
		private readonly List<IGrabItemData> ReceiveItemList = new List<IGrabItemData>();

		// Token: 0x04024022 RID: 147490
		[Nullable(1)]
		private readonly Dictionary<EClawButtonState, UTexture> ClawIconTextureMap = new Dictionary<EClawButtonState, UTexture>();

		// Token: 0x04024023 RID: 147491
		private UUISprite SprPoint;

		// Token: 0x04024024 RID: 147492
		private UUISprite SprFill;

		// Token: 0x04024025 RID: 147493
		private UUITextureTransitionComponent ClawTextureTransitionComp;

		// Token: 0x04024026 RID: 147494
		private FColor? SprPointOriginalColor;

		// Token: 0x04024027 RID: 147495
		private FColor? SprPointChangeColor;

		// Token: 0x04024028 RID: 147496
		private DollGrabMachineJoystick MobileJoystick;

		// Token: 0x04024029 RID: 147497
		private EBoundInputMode CurrentInputMode;

		// Token: 0x0402402A RID: 147498
		private LevelSequencePlayer SequencePlayer;
	}
}
