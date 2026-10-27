using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.Input.Enum;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Input;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D5E RID: 23902
	[NullableContext(1)]
	[Nullable(0)]
	public class Joystick : BattleChildView
	{
		// Token: 0x0603CACA RID: 248522 RVA: 0x00E90B6C File Offset: 0x00E8ED6C
		[NullableContext(2)]
		public override void Initialize(object param = null)
		{
			base.Initialize(param);
			this.ParentUiItem = (param as UUIItem);
			this.DraggableComponent = (base.GetRootActor().GetComponentByClass(UUIDraggableComponent.StaticClass()) as UUIDraggableComponent);
			this.AddEvents();
			this.WalkBgItem = base.GetSprite(0);
			this.RunBgItem = base.GetSprite(1);
			this.HandleItem = base.GetSprite(2);
			this.ContextArea = base.GetItem(3);
			this.MaskArea = base.GetItem(5);
			this.PlayerController = Global.CharacterController;
			this.DodgeMinLength = ConfigCommonParamById.GetIntConfig("DodgeMinLength").Value;
			this.DodgeJoystickSlideMinTime = ConfigCommonParamById.GetIntConfig("DodgeJoystickSlideMinTime").Value;
			this.RefreshIsDynamicJoystick(false);
			this.MaskAreaEnableRootX = ConfigCommonParamById.GetFloatConfig("MaskAreaEnableRootX").Value;
		}

		// Token: 0x0603CACB RID: 248523 RVA: 0x00E90C50 File Offset: 0x00E8EE50
		public void ShowBattleVisibleChildView()
		{
			this.SetVisible(EBattleUiVisibleReason.Default, true);
			this.SetActive(true);
			if (this.RootItem != null && this.ParentUiItem != null && this.MaskAreaEnableRootX > 0f)
			{
				float width = this.ParentUiItem.GetWidth();
				float anchorOffsetX = this.RootItem.GetAnchorOffsetX();
				this.EnableMaskArea = (width > 0f && anchorOffsetX / width < this.MaskAreaEnableRootX);
			}
			else
			{
				this.EnableMaskArea = false;
			}
			if (!this.EnableMaskArea)
			{
				UUIItem maskArea = this.MaskArea;
				if (maskArea != null)
				{
					maskArea.SetUIActive(false);
				}
			}
			this.WalkRunRate = GameSettingsManager.Instance.GetCurrentValueFloat(EFunction.WalkOrRunRate, true, true).GetValueOrDefault(0.3f);
		}

		// Token: 0x0603CACC RID: 248524 RVA: 0x00E90D01 File Offset: 0x00E8EF01
		public void HideBattleVisibleChildView()
		{
			this.SetVisible(EBattleUiVisibleReason.Default, false);
			this.SetActive(false);
		}

		// Token: 0x0603CACD RID: 248525 RVA: 0x00E90D14 File Offset: 0x00E8EF14
		public override void Reset()
		{
			this.PlayerController = null;
			this.HandleItem = null;
			this.IsJoystickPressed = false;
			BattleUiModel.Instance.IsPressJoyStick = false;
			if (this.DodgeTimerId != null && TimerSystem.Instance.Has(this.DodgeTimerId))
			{
				TimerSystem.Instance.Remove(this.DodgeTimerId);
				this.DodgeTimerId = null;
			}
			this.RemoveEvents();
			base.Reset();
		}

		// Token: 0x0603CACE RID: 248526 RVA: 0x00E90D80 File Offset: 0x00E8EF80
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603CACF RID: 248527 RVA: 0x00E90E70 File Offset: 0x00E8F070
		private void AddEvents()
		{
			UUIDraggableComponent draggableComponent = this.DraggableComponent;
			draggableComponent.OnPointerDownCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnJoystickButtonPressed));
			draggableComponent.OnPointerBeginDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnBgPointerBeginDragCallBack));
			draggableComponent.OnPointerDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnBgPointerDragCallBack));
			draggableComponent.OnPointerEndDragCallBack.Bind(delegate(ULGUIPointerEventData _)
			{
				this.OnJoystickButtonReleased();
			});
			draggableComponent.OnPointerUpCallBack.Bind(delegate(ULGUIPointerEventData _)
			{
				this.OnJoystickButtonReleased();
			});
			EventSystem.Instance.Add(EEventName.OnSetJoystickMode, new Action<bool>(this.OnDynamicChanged));
			EventSystem.Instance.Add(EEventName.OnSetMotorcycleJoystickMode, new Action<bool>(this.OnDynamicChanged));
			BattleUiModel.Instance.ChildViewData.AddCallback(EBattleUiChild.Joystick, new Action(this.OnJoystickVisibleChanged));
		}

		// Token: 0x0603CAD0 RID: 248528 RVA: 0x00E90F4C File Offset: 0x00E8F14C
		private void RemoveEvents()
		{
			UUIDraggableComponent draggableComponent = this.DraggableComponent;
			draggableComponent.OnPointerDownCallBack.Unbind();
			draggableComponent.OnPointerBeginDragCallBack.Unbind();
			draggableComponent.OnPointerDragCallBack.Unbind();
			draggableComponent.OnPointerEndDragCallBack.Unbind();
			draggableComponent.OnPointerUpCallBack.Unbind();
			EventSystem.Instance.Remove(EEventName.OnSetJoystickMode, new Action<bool>(this.OnDynamicChanged));
			EventSystem.Instance.Remove(EEventName.OnSetMotorcycleJoystickMode, new Action<bool>(this.OnDynamicChanged));
			BattleUiModel.Instance.ChildViewData.RemoveCallback(EBattleUiChild.Joystick, new Action(this.OnJoystickVisibleChanged));
		}

		// Token: 0x0603CAD1 RID: 248529 RVA: 0x00E90FEC File Offset: 0x00E8F1EC
		public void Tick(float delta)
		{
			if (this.JoystickTouchId < 0)
			{
				return;
			}
			this.CheckInTouch();
			if (!this.IsInTouch)
			{
				this.EndDragJoystick();
				return;
			}
			if (!this.IsJoystickPressed)
			{
				return;
			}
			if (InputDistributeController.Instance.IsAllowFightMoveInput())
			{
				if (BattleUiModel.Instance.IsOpenJoystickLog)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Battle;
					ELogAuthor author = ELogAuthor.XXJ;
					string message = "手指滑动摇杆";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Position", this.PointerPosition);
					instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				this.MoveJoysticksHandle(this.PointerPosition, true);
				return;
			}
			if (BattleUiModel.Instance.IsOpenJoystickLog)
			{
				Log.Instance.Info(ELogModule.Battle, ELogAuthor.XXJ, "手指滑动摇杆时不允许战斗输入,摇杆置回原点", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			this.MoveJoysticksHandle(this.CenterPosition, true);
		}

		// Token: 0x0603CAD2 RID: 248530 RVA: 0x00E910A8 File Offset: 0x00E8F2A8
		private void CheckInTouch()
		{
			if (Time.Instance.Now < this.NextCheckInTouchTime)
			{
				return;
			}
			this.NextCheckInTouchTime = Time.Instance.Now + 500.0;
			this.IsInTouch = this.PlayerController.IsInTouch((float)this.JoystickTouchId);
		}

		// Token: 0x0603CAD3 RID: 248531 RVA: 0x00E910FC File Offset: 0x00E8F2FC
		private void OnBgPointerBeginDragCallBack(ULGUIPointerEventData eventData)
		{
			if (this.UpdatePointerPosition(eventData) && this.IsDynamicJoystick && this.IsJoystickPressed && InputDistributeController.Instance.IsAllowFightMoveInput())
			{
				if (BattleUiModel.Instance.IsOpenJoystickLog)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Battle;
					ELogAuthor author = ELogAuthor.XXJ;
					string message = "动态摇杆开始拖动立即响应输入";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Position", this.PointerPosition);
					instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				this.MoveJoysticksHandle(this.PointerPosition, true);
			}
		}

		// Token: 0x0603CAD4 RID: 248532 RVA: 0x00E91173 File Offset: 0x00E8F373
		private void OnBgPointerDragCallBack(ULGUIPointerEventData eventData)
		{
			this.UpdatePointerPosition(eventData);
		}

		// Token: 0x0603CAD5 RID: 248533 RVA: 0x00E91180 File Offset: 0x00E8F380
		private unsafe bool UpdatePointerPosition(ULGUIPointerEventData eventData)
		{
			if (!this.IsInTouch)
			{
				return false;
			}
			if (eventData.pointerID != this.JoystickTouchId)
			{
				if (BattleUiModel.Instance.IsOpenJoystickLog)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Battle;
					ELogAuthor author = ELogAuthor.XXJ;
					string message = "JoystickDrag No CurTouchId";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("", this.JoystickTouchId);
					instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				return false;
			}
			FVector localPointInPlane = eventData.GetLocalPointInPlane();
			this.PointerPosition.X = (double)localPointInPlane.X;
			this.PointerPosition.Y = (double)localPointInPlane.Y;
			this.UpdateMaskItemPosition();
			if (BattleUiModel.Instance.IsOpenJoystickLog)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Battle;
				ELogAuthor author2 = ELogAuthor.XXJ;
				string message2 = "JoystickDrag";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("", this.JoystickTouchId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("", this.PointerPosition);
				instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			return true;
		}

		// Token: 0x0603CAD6 RID: 248534 RVA: 0x00E91284 File Offset: 0x00E8F484
		private unsafe void OnJoystickButtonPressed(ULGUIPointerEventData eventData)
		{
			this.JoystickTouchId = eventData.pointerID;
			FVector localPointInPlane = eventData.GetLocalPointInPlane();
			this.PointerPosition.X = (double)localPointInPlane.X;
			this.PointerPosition.Y = (double)localPointInPlane.Y;
			this.IsJoystickPressed = true;
			BattleUiModel.Instance.IsPressJoyStick = true;
			this.IsInTouch = true;
			if (this.EnableMaskArea)
			{
				this.UpdateMaskItemPosition();
				UUIItem maskArea = this.MaskArea;
				if (maskArea != null)
				{
					maskArea.SetUIActive(true);
				}
			}
			if (this.IsDynamicJoystick)
			{
				this.CenterPosition.X = this.PointerPosition.X;
				this.CenterPosition.Y = this.PointerPosition.Y;
				this.TempVector2D.Set(this.CenterPosition.X, this.CenterPosition.Y);
				FVector2D anchorOffset = this.TempVector2D.ToUeVector2D(false);
				this.WalkBgItem.SetAnchorOffset(anchorOffset);
				this.RunBgItem.SetAnchorOffset(anchorOffset);
				this.HandleItem.SetAnchorOffset(anchorOffset);
			}
			if (BattleUiModel.Instance.IsOpenJoystickLog)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Battle;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "JoystickPress";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("", this.JoystickTouchId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("", this.PointerPosition);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			if (this.PointerPosition.IsZero())
			{
				return;
			}
			this.MoveJoysticksHandle(this.PointerPosition, true);
			this.SaveDodgeStartInfo(this.PointerPosition);
		}

		// Token: 0x0603CAD7 RID: 248535 RVA: 0x00E9141C File Offset: 0x00E8F61C
		private void OnJoystickButtonReleased()
		{
			this.EndDragJoystick();
		}

		// Token: 0x0603CAD8 RID: 248536 RVA: 0x00E91424 File Offset: 0x00E8F624
		private void MoveJoysticksHandle(global::Vector touchPosition, bool inTouch = true)
		{
			touchPosition.Subtraction(this.CenterPosition, this.TargetVector);
			if (this.TargetVector.IsNearlyZero(0.0010000000474974513))
			{
				this.TargetVector.Reset();
			}
			this.SetHandleOffset(this.TargetVector);
			this.SetInputAxis(this.TargetVector, inTouch);
		}

		// Token: 0x0603CAD9 RID: 248537 RVA: 0x00E91480 File Offset: 0x00E8F680
		private void UpdateMaskItemPosition()
		{
			if (!this.EnableMaskArea)
			{
				return;
			}
			this.TempVector2D.Set(Math.Min(this.PointerPosition.X, 400.0), Math.Min(this.PointerPosition.Y, 400.0));
			FVector2D anchorOffset = this.TempVector2D.ToUeVector2D(false);
			this.MaskArea.SetAnchorOffset(anchorOffset);
		}

		// Token: 0x0603CADA RID: 248538 RVA: 0x00E914EC File Offset: 0x00E8F6EC
		protected void SaveDodgeStartInfo(global::Vector touchPosition)
		{
			this.PressTime = TimeUtil.Instance.GetServerTimeStamp();
			this.PressPosition = touchPosition;
		}

		// Token: 0x0603CADB RID: 248539 RVA: 0x00E91508 File Offset: 0x00E8F708
		protected void TryDodge(global::Vector touchPosition)
		{
			double serverTimeStamp = TimeUtil.Instance.GetServerTimeStamp();
			if (serverTimeStamp - this.PressTime > (double)this.DodgeJoystickSlideMinTime)
			{
				this.PressTime = serverTimeStamp;
				return;
			}
			this.PressTime = serverTimeStamp;
			this.PressPosition.Subtraction(touchPosition, this.TargetVector);
			this.PressPosition = touchPosition;
			if (this.TargetVector.Size() < (double)this.DodgeMinLength)
			{
				return;
			}
			this.SetInputAxis(this.TargetVector, true);
			InputController.Instance.InputAction(CSharpScript.Game.Input.EInputAction.闪避, EInputState.Press);
			InputController.Instance.InputAction(CSharpScript.Game.Input.EInputAction.闪避, EInputState.Release);
		}

		// Token: 0x0603CADC RID: 248540 RVA: 0x00E9159C File Offset: 0x00E8F79C
		private void EndDragJoystick()
		{
			this.MoveJoysticksHandle(this.CenterPosition, false);
			this.JoystickTouchId = -1;
			this.IsInTouch = false;
			this.IsJoystickPressed = false;
			BattleUiModel.Instance.IsPressJoyStick = false;
			UUIItem maskArea = this.MaskArea;
			if (maskArea == null)
			{
				return;
			}
			maskArea.SetUIActive(false);
		}

		// Token: 0x0603CADD RID: 248541 RVA: 0x00E915DC File Offset: 0x00E8F7DC
		protected unsafe FRotator? GetRotatorMoveArrow(global::Vector targetVector)
		{
			double num = targetVector.SizeSquared();
			if (num <= 0.0)
			{
				if (BattleUiModel.Instance.IsOpenJoystickLog)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Battle;
					ELogAuthor author = ELogAuthor.XXJ;
					string message = "设置摇杆偏移时，方向向量为0，不会设置角色移动";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("targetVector", targetVector);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("distanceSquared2D", num);
					instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
				return null;
			}
			this.NormalTargetVector.DeepCopy(targetVector);
			this.NormalTargetVector.Normalize(9.99999993922529E-09);
			double num2 = this.NormalTargetVector.X * 200.0;
			double num3 = this.NormalTargetVector.Y * 200.0;
			if (num < 40000.0)
			{
				num2 = targetVector.X;
				num3 = targetVector.Y;
			}
			num2 += this.CenterPosition.X;
			num3 += this.CenterPosition.Y;
			this.TempVector2D.Set(num2, num3);
			if (this.IsDynamicJoystick)
			{
				this.HandleItem.SetAnchorOffset(this.TempVector2D.ToUeVector2D(false));
			}
			if (this.NormalTargetVector.Y > 0.0)
			{
				this.BgRotator.Yaw = (float)Math.Atan(-this.NormalTargetVector.X / this.NormalTargetVector.Y) * 57.29578f;
			}
			else if (this.NormalTargetVector.Y < 0.0)
			{
				this.BgRotator.Yaw = (float)Math.Atan(-this.NormalTargetVector.X / this.NormalTargetVector.Y) * 57.29578f + 180f;
			}
			else if (this.NormalTargetVector.X > 0.0)
			{
				this.BgRotator.Yaw = -90f;
			}
			else
			{
				this.BgRotator.Yaw = 90f;
			}
			if (BattleUiModel.Instance.IsOpenJoystickLog)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Battle;
				ELogAuthor author2 = ELogAuthor.XXJ;
				string message2 = "设置摇杆偏移";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("targetVector", targetVector);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("normalTargetVector", this.NormalTargetVector);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("resultOffsetX", num2);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("resultOffsetY", num3);
				instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 4));
			}
			return new FRotator?(this.BgRotator.ToUeRotator());
		}

		// Token: 0x0603CADE RID: 248542 RVA: 0x00E9189C File Offset: 0x00E8FA9C
		protected virtual void SetHandleOffset(global::Vector targetVector)
		{
			FRotator? rotatorMoveArrow = this.GetRotatorMoveArrow(targetVector);
			if (rotatorMoveArrow == null)
			{
				return;
			}
			UUIItem walkBgItem = this.WalkBgItem;
			FRotator value = rotatorMoveArrow.Value;
			walkBgItem.SetUIRelativeRotation(value);
			UUIItem runBgItem = this.RunBgItem;
			value = rotatorMoveArrow.Value;
			runBgItem.SetUIRelativeRotation(value);
		}

		// Token: 0x0603CADF RID: 248543 RVA: 0x00E918E8 File Offset: 0x00E8FAE8
		protected void SetInputAxis(global::Vector targetVector, bool inTouch)
		{
			if (!this.JoystickVisible || !inTouch || targetVector.Equality(global::Vector.ZeroVectorProxy))
			{
				if (inTouch)
				{
					this.OnStandInTouch();
				}
				else
				{
					this.OnStand();
				}
				if (BattleUiModel.Instance.IsOpenJoystickLog)
				{
					Log.Instance.Info(ELogModule.Battle, ELogAuthor.XXJ, "[CharacterInput]摇杆移回原位，开始进行调用InputController输入逻辑", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
				InputController.Instance.InputAxis(EInputAxis.MoveRight, 0f, true);
				InputController.Instance.InputAxis(EInputAxis.MoveForward, 0f, true);
				return;
			}
			this.SetNormalInputAxis(targetVector);
		}

		// Token: 0x0603CAE0 RID: 248544 RVA: 0x00E91978 File Offset: 0x00E8FB78
		protected unsafe void SetNormalInputAxis(global::Vector targetVector)
		{
			this.TempVector2D.X = targetVector.X / 200.0;
			this.TempVector2D.Y = targetVector.Y / 200.0;
			if (this.TempVector2D.SizeSquared() > 1.0)
			{
				this.TempVector2D.Normalize(9.99999993922529E-09);
			}
			double x = this.TempVector2D.X;
			double y = this.TempVector2D.Y;
			if (Math.Max(Math.Abs(x), Math.Abs(y)) > (double)this.WalkRunRate)
			{
				this.OnRun();
			}
			else
			{
				this.OnWalk();
			}
			if (BattleUiModel.Instance.IsOpenJoystickLog)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Battle;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "[CharacterInput]开始进行调用InputController输入逻辑";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("resultX", x);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("resultY", y);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			InputController.Instance.InputAxis(EInputAxis.MoveRight, (float)x, true);
			InputController.Instance.InputAxis(EInputAxis.MoveForward, (float)y, true);
		}

		// Token: 0x0603CAE1 RID: 248545 RVA: 0x00E91AB4 File Offset: 0x00E8FCB4
		protected virtual void OnWalk()
		{
			if (this.CurrentJoystickType == EJoystickType.Walk)
			{
				return;
			}
			if (BattleUiModel.Instance.IsOpenJoystickLog)
			{
				Log.Instance.Info(ELogModule.Battle, ELogAuthor.XXJ, "控制角色行走", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			this.WalkBgItem.SetUIActive(true);
			this.RunBgItem.SetUIActive(false);
			this.CurrentJoystickType = EJoystickType.Walk;
		}

		// Token: 0x0603CAE2 RID: 248546 RVA: 0x00E91B14 File Offset: 0x00E8FD14
		protected virtual void OnRun()
		{
			if (this.CurrentJoystickType == EJoystickType.Run)
			{
				return;
			}
			if (BattleUiModel.Instance.IsOpenJoystickLog)
			{
				Log.Instance.Info(ELogModule.Battle, ELogAuthor.XXJ, "控制角色奔跑", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			this.WalkBgItem.SetUIActive(false);
			this.RunBgItem.SetUIActive(true);
			this.CurrentJoystickType = EJoystickType.Run;
		}

		// Token: 0x0603CAE3 RID: 248547 RVA: 0x00E91B74 File Offset: 0x00E8FD74
		protected virtual void OnStand()
		{
			if (this.CurrentJoystickType != EJoystickType.Stand)
			{
				if (BattleUiModel.Instance.IsOpenJoystickLog)
				{
					Log.Instance.Info(ELogModule.Battle, ELogAuthor.XXJ, "松开摇杆时控制角色站立", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
				this.HandleItem.SetUIActive(!this.IsDynamicJoystick);
				if (this.CurrentJoystickType != EJoystickType.StandInTouch)
				{
					this.WalkBgItem.SetUIActive(false);
					this.RunBgItem.SetUIActive(false);
				}
				this.CurrentJoystickType = EJoystickType.Stand;
			}
		}

		// Token: 0x0603CAE4 RID: 248548 RVA: 0x00E91BF0 File Offset: 0x00E8FDF0
		protected virtual void OnStandInTouch()
		{
			if (this.CurrentJoystickType != EJoystickType.StandInTouch)
			{
				if (BattleUiModel.Instance.IsOpenJoystickLog)
				{
					Log.Instance.Info(ELogModule.Battle, ELogAuthor.XXJ, "按下摇杆时控制角色站立", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
				this.HandleItem.SetUIActive(true);
				if (this.CurrentJoystickType != EJoystickType.Stand)
				{
					this.WalkBgItem.SetUIActive(false);
					this.RunBgItem.SetUIActive(false);
				}
				this.CurrentJoystickType = EJoystickType.StandInTouch;
			}
		}

		// Token: 0x0603CAE5 RID: 248549 RVA: 0x00E91C61 File Offset: 0x00E8FE61
		public virtual void OnDynamicChanged(bool isDynamic)
		{
			this.RefreshIsDynamicJoystick(true);
		}

		// Token: 0x0603CAE6 RID: 248550 RVA: 0x00E91C6C File Offset: 0x00E8FE6C
		private void RefreshIsDynamicJoystick(bool bResetStaticJoystick = false)
		{
			BattleUiMotorcycleData motorcycleData = BattleUiModel.Instance.MotorcycleData;
			bool isDynamicJoystick;
			if (motorcycleData.IsDriving && motorcycleData.GetIsRoundJoystick())
			{
				isDynamicJoystick = motorcycleData.GetIsDynamicJoystick();
			}
			else
			{
				isDynamicJoystick = BattleUiModel.Instance.GetIsDynamicJoystick();
			}
			if (this.IsDynamicJoystick == isDynamicJoystick)
			{
				return;
			}
			this.IsDynamicJoystick = isDynamicJoystick;
			if (this.JoystickTouchId >= 0)
			{
				this.EndDragJoystick();
			}
			if (bResetStaticJoystick && !this.IsDynamicJoystick)
			{
				this.CenterPosition.Set(0.0, 0.0, 0.0);
				this.TempVector2D.Set(this.CenterPosition.X, this.CenterPosition.Y);
				FVector2D anchorOffset = this.TempVector2D.ToUeVector2D(false);
				this.WalkBgItem.SetAnchorOffset(anchorOffset);
				this.RunBgItem.SetAnchorOffset(anchorOffset);
				this.HandleItem.SetAnchorOffset(anchorOffset);
			}
		}

		// Token: 0x0603CAE7 RID: 248551 RVA: 0x00E91D50 File Offset: 0x00E8FF50
		private void OnJoystickVisibleChanged()
		{
			this.UpdateJoystickVisible();
		}

		// Token: 0x0603CAE8 RID: 248552 RVA: 0x00E91D58 File Offset: 0x00E8FF58
		protected virtual void UpdateJoystickVisible()
		{
			BattleUiChildViewData childViewData = BattleUiModel.Instance.ChildViewData;
			this.JoystickVisible = (childViewData != null && childViewData.GetChildVisible(EBattleUiChild.Joystick));
			UUIItem contextArea = this.ContextArea;
			if (contextArea == null)
			{
				return;
			}
			contextArea.SetUIActive(this.JoystickVisible);
		}

		// Token: 0x0603CAE9 RID: 248553 RVA: 0x00E91D8E File Offset: 0x00E8FF8E
		public virtual void SetVisible(EBattleUiVisibleReason visibleReason, bool bVisible)
		{
			BattleUiModel.Instance.ChildViewData.SetChildVisible(visibleReason, EBattleUiChild.Joystick, bVisible, true, 0);
		}

		// Token: 0x0603CAEA RID: 248554 RVA: 0x00E91DA6 File Offset: 0x00E8FFA6
		public void SetEnable(bool bEnable)
		{
			this.SetActive(bEnable);
			if (bEnable)
			{
				this.RefreshIsDynamicJoystick(true);
			}
		}

		// Token: 0x0603CAEB RID: 248555 RVA: 0x00E91DB9 File Offset: 0x00E8FFB9
		public void SetForbidMove(bool isForbidMove)
		{
		}

		// Token: 0x0401F9B6 RID: 129462
		private const float WALK_TO_RUN_RATE = 0.3f;

		// Token: 0x0401F9B7 RID: 129463
		private const float JOYSTICK_RADIU = 200f;

		// Token: 0x0401F9B8 RID: 129464
		private const float JOYSTICK_RADIU_SQUARED = 40000f;

		// Token: 0x0401F9B9 RID: 129465
		private const double CHECK_IN_TOUCH_INTERVAL = 500.0;

		// Token: 0x0401F9BA RID: 129466
		private const float MASK_AREA_MAX_X = 400f;

		// Token: 0x0401F9BB RID: 129467
		private const float MASK_AREA_MAX_Y = 400f;

		// Token: 0x0401F9BC RID: 129468
		[Nullable(2)]
		private UUIDraggableComponent DraggableComponent;

		// Token: 0x0401F9BD RID: 129469
		[Nullable(2)]
		protected UUISprite WalkBgItem;

		// Token: 0x0401F9BE RID: 129470
		[Nullable(2)]
		protected UUISprite RunBgItem;

		// Token: 0x0401F9BF RID: 129471
		[Nullable(2)]
		private UUISprite HandleItem;

		// Token: 0x0401F9C0 RID: 129472
		[Nullable(2)]
		private UUIItem ContextArea;

		// Token: 0x0401F9C1 RID: 129473
		[Nullable(2)]
		private UUIItem MaskArea;

		// Token: 0x0401F9C2 RID: 129474
		private readonly Vector2D TempVector2D = Vector2D.Create(0.0, 0.0);

		// Token: 0x0401F9C3 RID: 129475
		protected EJoystickType CurrentJoystickType;

		// Token: 0x0401F9C4 RID: 129476
		private readonly global::Vector NormalTargetVector = global::Vector.Create();

		// Token: 0x0401F9C5 RID: 129477
		private readonly global::Vector PointerPosition = global::Vector.Create();

		// Token: 0x0401F9C6 RID: 129478
		private readonly global::Vector CenterPosition = global::Vector.Create(0.0, 0.0, 0.0);

		// Token: 0x0401F9C7 RID: 129479
		protected readonly global::Vector TargetVector = global::Vector.Create(0.0, 0.0, 0.0);

		// Token: 0x0401F9C8 RID: 129480
		private readonly Rotator BgRotator = Rotator.Create();

		// Token: 0x0401F9C9 RID: 129481
		protected bool IsDynamicJoystick;

		// Token: 0x0401F9CA RID: 129482
		private float MaskAreaEnableRootX;

		// Token: 0x0401F9CB RID: 129483
		public int JoystickTouchId = -1;

		// Token: 0x0401F9CC RID: 129484
		private bool IsInTouch;

		// Token: 0x0401F9CD RID: 129485
		private TsBasePlayerController PlayerController;

		// Token: 0x0401F9CE RID: 129486
		private bool IsJoystickPressed;

		// Token: 0x0401F9CF RID: 129487
		private int DodgeMinLength = 500;

		// Token: 0x0401F9D0 RID: 129488
		private int DodgeJoystickSlideMinTime = 1000;

		// Token: 0x0401F9D1 RID: 129489
		private double PressTime;

		// Token: 0x0401F9D2 RID: 129490
		private global::Vector PressPosition = global::Vector.Create();

		// Token: 0x0401F9D3 RID: 129491
		[Nullable(2)]
		private TimerHandle DodgeTimerId;

		// Token: 0x0401F9D4 RID: 129492
		private double NextCheckInTouchTime;

		// Token: 0x0401F9D5 RID: 129493
		private bool EnableMaskArea;

		// Token: 0x0401F9D6 RID: 129494
		protected bool JoystickVisible;

		// Token: 0x0401F9D7 RID: 129495
		private float WalkRunRate = 0.3f;

		// Token: 0x0200C00D RID: 49165
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04039F44 RID: 237380
			WalkBgItem,
			// Token: 0x04039F45 RID: 237381
			RunBgItem,
			// Token: 0x04039F46 RID: 237382
			HandleItem,
			// Token: 0x04039F47 RID: 237383
			ContextArea,
			// Token: 0x04039F48 RID: 237384
			ClickArea,
			// Token: 0x04039F49 RID: 237385
			MaskArea
		}
	}
}
