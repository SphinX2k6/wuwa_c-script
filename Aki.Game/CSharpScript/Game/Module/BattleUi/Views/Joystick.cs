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
	// Token: 0x02004D40 RID: 19776
	[NullableContext(1)]
	[Nullable(0)]
	public class Joystick : BattleChildView
	{
		// Token: 0x06031A23 RID: 203299 RVA: 0x00DE1320 File Offset: 0x00DDF520
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

		// Token: 0x06031A24 RID: 203300 RVA: 0x00DE1404 File Offset: 0x00DDF604
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
			this.RefreshWalkRunRate();
		}

		// Token: 0x06031A25 RID: 203301 RVA: 0x00DE149A File Offset: 0x00DDF69A
		public void HideBattleVisibleChildView()
		{
			this.SetVisible(EBattleUiVisibleReason.Default, false);
			this.SetActive(false);
		}

		// Token: 0x06031A26 RID: 203302 RVA: 0x00DE14AC File Offset: 0x00DDF6AC
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

		// Token: 0x06031A27 RID: 203303 RVA: 0x00DE1518 File Offset: 0x00DDF718
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

		// Token: 0x06031A28 RID: 203304 RVA: 0x00DE1608 File Offset: 0x00DDF808
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
			EventSystem.Instance.Add(EEventName.OnJoystickWalkRunRateChanged, new Action(this.OnWalkRunRateChanged));
			BattleUiModel.Instance.ChildViewData.AddCallback(EBattleUiChild.Joystick, new Action(this.OnJoystickVisibleChanged));
		}

		// Token: 0x06031A29 RID: 203305 RVA: 0x00DE1704 File Offset: 0x00DDF904
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
			EventSystem.Instance.Remove(EEventName.OnJoystickWalkRunRateChanged, new Action(this.OnWalkRunRateChanged));
			BattleUiModel.Instance.ChildViewData.RemoveCallback(EBattleUiChild.Joystick, new Action(this.OnJoystickVisibleChanged));
		}

		// Token: 0x06031A2A RID: 203306 RVA: 0x00DE17C4 File Offset: 0x00DDF9C4
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

		// Token: 0x06031A2B RID: 203307 RVA: 0x00DE1880 File Offset: 0x00DDFA80
		private void CheckInTouch()
		{
			if (Time.Instance.Now < this.NextCheckInTouchTime)
			{
				return;
			}
			this.NextCheckInTouchTime = Time.Instance.Now + 500.0;
			this.IsInTouch = this.PlayerController.IsInTouch((float)this.JoystickTouchId);
		}

		// Token: 0x06031A2C RID: 203308 RVA: 0x00DE18D4 File Offset: 0x00DDFAD4
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

		// Token: 0x06031A2D RID: 203309 RVA: 0x00DE194B File Offset: 0x00DDFB4B
		private void OnBgPointerDragCallBack(ULGUIPointerEventData eventData)
		{
			this.UpdatePointerPosition(eventData);
		}

		// Token: 0x06031A2E RID: 203310 RVA: 0x00DE1958 File Offset: 0x00DDFB58
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

		// Token: 0x06031A2F RID: 203311 RVA: 0x00DE1A5C File Offset: 0x00DDFC5C
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

		// Token: 0x06031A30 RID: 203312 RVA: 0x00DE1BF4 File Offset: 0x00DDFDF4
		private void OnJoystickButtonReleased()
		{
			this.EndDragJoystick();
		}

		// Token: 0x06031A31 RID: 203313 RVA: 0x00DE1BFC File Offset: 0x00DDFDFC
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

		// Token: 0x06031A32 RID: 203314 RVA: 0x00DE1C58 File Offset: 0x00DDFE58
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

		// Token: 0x06031A33 RID: 203315 RVA: 0x00DE1CC4 File Offset: 0x00DDFEC4
		protected void SaveDodgeStartInfo(global::Vector touchPosition)
		{
			this.PressTime = TimeUtil.Instance.GetServerTimeStamp();
			this.PressPosition = touchPosition;
		}

		// Token: 0x06031A34 RID: 203316 RVA: 0x00DE1CE0 File Offset: 0x00DDFEE0
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

		// Token: 0x06031A35 RID: 203317 RVA: 0x00DE1D74 File Offset: 0x00DDFF74
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

		// Token: 0x06031A36 RID: 203318 RVA: 0x00DE1DB4 File Offset: 0x00DDFFB4
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

		// Token: 0x06031A37 RID: 203319 RVA: 0x00DE2074 File Offset: 0x00DE0274
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

		// Token: 0x06031A38 RID: 203320 RVA: 0x00DE20C0 File Offset: 0x00DE02C0
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

		// Token: 0x06031A39 RID: 203321 RVA: 0x00DE2150 File Offset: 0x00DE0350
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

		// Token: 0x06031A3A RID: 203322 RVA: 0x00DE228C File Offset: 0x00DE048C
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

		// Token: 0x06031A3B RID: 203323 RVA: 0x00DE22EC File Offset: 0x00DE04EC
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

		// Token: 0x06031A3C RID: 203324 RVA: 0x00DE234C File Offset: 0x00DE054C
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

		// Token: 0x06031A3D RID: 203325 RVA: 0x00DE23C8 File Offset: 0x00DE05C8
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

		// Token: 0x06031A3E RID: 203326 RVA: 0x00DE2439 File Offset: 0x00DE0639
		public virtual void OnDynamicChanged(bool isDynamic)
		{
			this.RefreshIsDynamicJoystick(true);
		}

		// Token: 0x06031A3F RID: 203327 RVA: 0x00DE2444 File Offset: 0x00DE0644
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

		// Token: 0x06031A40 RID: 203328 RVA: 0x00DE2528 File Offset: 0x00DE0728
		protected virtual void OnWalkRunRateChanged()
		{
			this.RefreshWalkRunRate();
		}

		// Token: 0x06031A41 RID: 203329 RVA: 0x00DE2530 File Offset: 0x00DE0730
		private void RefreshWalkRunRate()
		{
			this.WalkRunRate = BattleUiModel.Instance.JoystickData.GetWalkRunRate();
		}

		// Token: 0x06031A42 RID: 203330 RVA: 0x00DE2547 File Offset: 0x00DE0747
		private void OnJoystickVisibleChanged()
		{
			this.UpdateJoystickVisible();
		}

		// Token: 0x06031A43 RID: 203331 RVA: 0x00DE254F File Offset: 0x00DE074F
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

		// Token: 0x06031A44 RID: 203332 RVA: 0x00DE2585 File Offset: 0x00DE0785
		public virtual void SetVisible(EBattleUiVisibleReason visibleReason, bool bVisible)
		{
			BattleUiModel.Instance.ChildViewData.SetChildVisible(visibleReason, EBattleUiChild.Joystick, bVisible, true, 0);
		}

		// Token: 0x06031A45 RID: 203333 RVA: 0x00DE259D File Offset: 0x00DE079D
		public void SetEnable(bool bEnable)
		{
			this.SetActive(bEnable);
			if (bEnable)
			{
				this.RefreshIsDynamicJoystick(true);
			}
		}

		// Token: 0x06031A46 RID: 203334 RVA: 0x00DE25B0 File Offset: 0x00DE07B0
		public void SetForbidMove(bool isForbidMove)
		{
		}

		// Token: 0x0401A46F RID: 107631
		private const float JOYSTICK_RADIU = 200f;

		// Token: 0x0401A470 RID: 107632
		private const float JOYSTICK_RADIU_SQUARED = 40000f;

		// Token: 0x0401A471 RID: 107633
		private const double CHECK_IN_TOUCH_INTERVAL = 500.0;

		// Token: 0x0401A472 RID: 107634
		private const float MASK_AREA_MAX_X = 400f;

		// Token: 0x0401A473 RID: 107635
		private const float MASK_AREA_MAX_Y = 400f;

		// Token: 0x0401A474 RID: 107636
		[Nullable(2)]
		private UUIDraggableComponent DraggableComponent;

		// Token: 0x0401A475 RID: 107637
		[Nullable(2)]
		protected UUISprite WalkBgItem;

		// Token: 0x0401A476 RID: 107638
		[Nullable(2)]
		protected UUISprite RunBgItem;

		// Token: 0x0401A477 RID: 107639
		[Nullable(2)]
		private UUISprite HandleItem;

		// Token: 0x0401A478 RID: 107640
		[Nullable(2)]
		private UUIItem ContextArea;

		// Token: 0x0401A479 RID: 107641
		[Nullable(2)]
		private UUIItem MaskArea;

		// Token: 0x0401A47A RID: 107642
		private readonly Vector2D TempVector2D = Vector2D.Create(0.0, 0.0);

		// Token: 0x0401A47B RID: 107643
		protected EJoystickType CurrentJoystickType;

		// Token: 0x0401A47C RID: 107644
		private readonly global::Vector NormalTargetVector = global::Vector.Create();

		// Token: 0x0401A47D RID: 107645
		private readonly global::Vector PointerPosition = global::Vector.Create();

		// Token: 0x0401A47E RID: 107646
		private readonly global::Vector CenterPosition = global::Vector.Create(0.0, 0.0, 0.0);

		// Token: 0x0401A47F RID: 107647
		protected readonly global::Vector TargetVector = global::Vector.Create(0.0, 0.0, 0.0);

		// Token: 0x0401A480 RID: 107648
		private readonly Rotator BgRotator = Rotator.Create();

		// Token: 0x0401A481 RID: 107649
		protected bool IsDynamicJoystick;

		// Token: 0x0401A482 RID: 107650
		private float MaskAreaEnableRootX;

		// Token: 0x0401A483 RID: 107651
		public int JoystickTouchId = -1;

		// Token: 0x0401A484 RID: 107652
		private bool IsInTouch;

		// Token: 0x0401A485 RID: 107653
		private TsBasePlayerController PlayerController;

		// Token: 0x0401A486 RID: 107654
		private bool IsJoystickPressed;

		// Token: 0x0401A487 RID: 107655
		private int DodgeMinLength = 500;

		// Token: 0x0401A488 RID: 107656
		private int DodgeJoystickSlideMinTime = 1000;

		// Token: 0x0401A489 RID: 107657
		private double PressTime;

		// Token: 0x0401A48A RID: 107658
		private global::Vector PressPosition = global::Vector.Create();

		// Token: 0x0401A48B RID: 107659
		[Nullable(2)]
		private TimerHandle DodgeTimerId;

		// Token: 0x0401A48C RID: 107660
		private double NextCheckInTouchTime;

		// Token: 0x0401A48D RID: 107661
		private bool EnableMaskArea;

		// Token: 0x0401A48E RID: 107662
		protected bool JoystickVisible;

		// Token: 0x0401A48F RID: 107663
		private float WalkRunRate;

		// Token: 0x0200AA13 RID: 43539
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04034906 RID: 215302
			WalkBgItem,
			// Token: 0x04034907 RID: 215303
			RunBgItem,
			// Token: 0x04034908 RID: 215304
			HandleItem,
			// Token: 0x04034909 RID: 215305
			ContextArea,
			// Token: 0x0403490A RID: 215306
			ClickArea,
			// Token: 0x0403490B RID: 215307
			MaskArea
		}
	}
}
