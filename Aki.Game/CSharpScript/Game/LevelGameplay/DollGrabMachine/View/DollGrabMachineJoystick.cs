using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine.View
{
	// Token: 0x02006EFA RID: 28410
	[NullableContext(1)]
	[Nullable(0)]
	public class DollGrabMachineJoystick : UiPanelBase
	{
		// Token: 0x060452A5 RID: 283301 RVA: 0x0111B46A File Offset: 0x0111966A
		public void RegisterOnAxisInput(Action<string, float> onAxisInput)
		{
			this.OnAxisInput = onAxisInput;
		}

		// Token: 0x060452A6 RID: 283302 RVA: 0x0111B474 File Offset: 0x01119674
		protected override void OnBeforeShow()
		{
			UiPanelBase parent = this.Parent;
			this.ParentUiItem = ((parent != null) ? parent.GetRootItem() : null);
			this.DraggableComponent = (base.GetRootActor().GetComponentByClass(UUIDraggableComponent.StaticClass()) as UUIDraggableComponent);
			this.AddEvents();
			this.RunBgItem = base.GetSprite(1);
			this.MaskArea = base.GetItem(5);
			this.PlayerController = Global.CharacterController;
		}

		// Token: 0x060452A7 RID: 283303 RVA: 0x0111B4E4 File Offset: 0x011196E4
		public void ShowBattleVisibleChildView()
		{
			UUIItem rootItem = this.RootItem;
			if (rootItem != null)
			{
				rootItem.SetUIActive(true);
			}
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
				if (maskArea == null)
				{
					return;
				}
				maskArea.SetUIActive(false);
			}
		}

		// Token: 0x060452A8 RID: 283304 RVA: 0x0111B57D File Offset: 0x0111977D
		public void HideBattleVisibleChildView()
		{
			UUIItem rootItem = this.RootItem;
			if (rootItem != null)
			{
				rootItem.SetUIActive(false);
			}
			this.SetActive(false);
		}

		// Token: 0x060452A9 RID: 283305 RVA: 0x0111B598 File Offset: 0x01119798
		public void Reset()
		{
			this.PlayerController = null;
			this.IsJoystickPressed = false;
			this.RemoveEvents();
		}

		// Token: 0x060452AA RID: 283306 RVA: 0x0111B5B0 File Offset: 0x011197B0
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

		// Token: 0x060452AB RID: 283307 RVA: 0x0111B6A0 File Offset: 0x011198A0
		private void AddEvents()
		{
			UUIDraggableComponent draggableComponent = this.DraggableComponent;
			draggableComponent.OnPointerDownCallBack.Bind(delegate(ULGUIPointerEventData eventData)
			{
				this.OnJoystickButtonPressed(eventData);
			});
			draggableComponent.OnPointerDragCallBack.Bind(delegate(ULGUIPointerEventData eventData)
			{
				this.OnBgPointerDragCallBack(eventData);
			});
			draggableComponent.OnPointerEndDragCallBack.Bind(delegate(ULGUIPointerEventData eventData)
			{
				this.OnJoystickButtonReleased();
			});
			draggableComponent.OnPointerUpCallBack.Bind(delegate(ULGUIPointerEventData eventData)
			{
				this.OnJoystickButtonReleased();
			});
		}

		// Token: 0x060452AC RID: 283308 RVA: 0x0111B710 File Offset: 0x01119910
		private void RemoveEvents()
		{
			UUIDraggableComponent draggableComponent = this.DraggableComponent;
			if (draggableComponent != null)
			{
				draggableComponent.OnPointerDownCallBack.Unbind();
				draggableComponent.OnPointerDragCallBack.Unbind();
				draggableComponent.OnPointerEndDragCallBack.Unbind();
				draggableComponent.OnPointerUpCallBack.Unbind();
			}
		}

		// Token: 0x060452AD RID: 283309 RVA: 0x0111B754 File Offset: 0x01119954
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
			if (DollGrabMachineController.Instance.IsAllowMoveInput())
			{
				if (BattleUiModel.Instance.IsOpenJoystickLog)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.DollGrabMachine;
					ELogAuthor author = ELogAuthor.FJH;
					string message = "手指滑动摇杆";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Position", this.PointerPosition);
					instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				this.MoveJoysticksHandle(this.PointerPosition, true);
				return;
			}
			if (BattleUiModel.Instance.IsOpenJoystickLog)
			{
				Log.Instance.Info(ELogModule.DollGrabMachine, ELogAuthor.FJH, "手指滑动摇杆时不允许输入,摇杆置回原点", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			this.MoveJoysticksHandle(this.CenterPosition, true);
		}

		// Token: 0x060452AE RID: 283310 RVA: 0x0111B818 File Offset: 0x01119A18
		private void CheckInTouch()
		{
			if (Time.Instance.Now < this.NextCheckInTouchTime)
			{
				return;
			}
			this.NextCheckInTouchTime = Time.Instance.Now + 500.0;
			this.IsInTouch = this.PlayerController.IsInTouch((float)this.JoystickTouchId);
		}

		// Token: 0x060452AF RID: 283311 RVA: 0x0111B86C File Offset: 0x01119A6C
		private unsafe void OnJoystickButtonPressed(ULGUIPointerEventData eventData)
		{
			this.JoystickTouchId = eventData.pointerID;
			FVector localPointInPlane = eventData.GetLocalPointInPlane();
			this.PointerPosition.X = (double)localPointInPlane.X;
			this.PointerPosition.Y = (double)localPointInPlane.Y;
			this.IsJoystickPressed = true;
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
			if (BattleUiModel.Instance.IsOpenJoystickLog)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.DollGrabMachine;
				ELogAuthor author = ELogAuthor.FJH;
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
		}

		// Token: 0x060452B0 RID: 283312 RVA: 0x0111B96A File Offset: 0x01119B6A
		private void OnBgPointerDragCallBack(ULGUIPointerEventData eventData)
		{
			this.UpdatePointerPosition(eventData);
		}

		// Token: 0x060452B1 RID: 283313 RVA: 0x0111B974 File Offset: 0x01119B74
		private void OnJoystickButtonReleased()
		{
			this.EndDragJoystick();
		}

		// Token: 0x060452B2 RID: 283314 RVA: 0x0111B97C File Offset: 0x01119B7C
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
					ELogModule module = ELogModule.DollGrabMachine;
					ELogAuthor author = ELogAuthor.FJH;
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
				ELogModule module2 = ELogModule.DollGrabMachine;
				ELogAuthor author2 = ELogAuthor.FJH;
				string message2 = "JoystickDrag";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("", this.JoystickTouchId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("", this.PointerPosition);
				instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			return true;
		}

		// Token: 0x060452B3 RID: 283315 RVA: 0x0111BA88 File Offset: 0x01119C88
		private void MoveJoysticksHandle(Vector touchPosition, bool inTouch = true)
		{
			touchPosition.Subtraction(this.CenterPosition, this.TargetVector);
			if (this.TargetVector.IsNearlyZero(0.001))
			{
				this.TargetVector.Reset();
			}
			this.SetHandleOffset(this.TargetVector);
			this.SetInputAxis(this.TargetVector, inTouch);
		}

		// Token: 0x060452B4 RID: 283316 RVA: 0x0111BAE4 File Offset: 0x01119CE4
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

		// Token: 0x060452B5 RID: 283317 RVA: 0x0111BB50 File Offset: 0x01119D50
		private void EndDragJoystick()
		{
			this.MoveJoysticksHandle(this.CenterPosition, false);
			this.JoystickTouchId = -1;
			this.IsInTouch = false;
			this.IsJoystickPressed = false;
			UUIItem maskArea = this.MaskArea;
			if (maskArea == null)
			{
				return;
			}
			maskArea.SetUIActive(false);
		}

		// Token: 0x060452B6 RID: 283318 RVA: 0x0111BB88 File Offset: 0x01119D88
		protected unsafe FRotator? GetRotatorMoveArrow(Vector targetVector)
		{
			double num = targetVector.SizeSquared();
			if (num <= 0.0)
			{
				if (BattleUiModel.Instance.IsOpenJoystickLog)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.DollGrabMachine;
					ELogAuthor author = ELogAuthor.FJH;
					string message = "设置摇杆偏移时，方向向量为0，不会设置移动";
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
				ELogModule module2 = ELogModule.DollGrabMachine;
				ELogAuthor author2 = ELogAuthor.FJH;
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

		// Token: 0x060452B7 RID: 283319 RVA: 0x0111BE30 File Offset: 0x0111A030
		protected void SetHandleOffset(Vector targetVector)
		{
			FRotator? rotatorMoveArrow = this.GetRotatorMoveArrow(targetVector);
			if (rotatorMoveArrow == null)
			{
				return;
			}
			UUIItem runBgItem = this.RunBgItem;
			FRotator value = rotatorMoveArrow.Value;
			runBgItem.SetUIRelativeRotation(value);
		}

		// Token: 0x060452B8 RID: 283320 RVA: 0x0111BE64 File Offset: 0x0111A064
		protected void SetInputAxis(Vector targetVector, bool inTouch)
		{
			if (!inTouch || targetVector.Equality(Vector.ZeroVectorProxy))
			{
				Action<string, float> onAxisInput = this.OnAxisInput;
				if (onAxisInput != null)
				{
					onAxisInput("UiMoveForward", 0f);
				}
				Action<string, float> onAxisInput2 = this.OnAxisInput;
				if (onAxisInput2 != null)
				{
					onAxisInput2("UiMoveRight", 0f);
				}
				this.RunBgItem.SetUIActive(false);
				return;
			}
			this.SetNormalInputAxis(targetVector);
		}

		// Token: 0x060452B9 RID: 283321 RVA: 0x0111BECC File Offset: 0x0111A0CC
		protected unsafe void SetNormalInputAxis(Vector targetVector)
		{
			this.TempVector2D.X = targetVector.X / 200.0;
			this.TempVector2D.Y = targetVector.Y / 200.0;
			if (this.TempVector2D.SizeSquared() > 1.0)
			{
				this.TempVector2D.Normalize(9.99999993922529E-09);
			}
			double x = this.TempVector2D.X;
			double y = this.TempVector2D.Y;
			this.RunBgItem.SetUIActive(true);
			if (BattleUiModel.Instance.IsOpenJoystickLog)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.DollGrabMachine;
				ELogAuthor author = ELogAuthor.FJH;
				string message = "[CharacterInput]开始进行调用InputController输入逻辑";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("resultX", x);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("resultY", y);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			Action<string, float> onAxisInput = this.OnAxisInput;
			if (onAxisInput != null)
			{
				onAxisInput("UiMoveRight", (float)x);
			}
			Action<string, float> onAxisInput2 = this.OnAxisInput;
			if (onAxisInput2 == null)
			{
				return;
			}
			onAxisInput2("UiMoveForward", (float)y);
		}

		// Token: 0x04024081 RID: 147585
		private const float JOYSTICK_RADIU = 200f;

		// Token: 0x04024082 RID: 147586
		private const float JOYSTICK_RADIU_SQUARED = 40000f;

		// Token: 0x04024083 RID: 147587
		private const double CHECK_IN_TOUCH_INTERVAL = 500.0;

		// Token: 0x04024084 RID: 147588
		private const float MASK_AREA_MAX_X = 400f;

		// Token: 0x04024085 RID: 147589
		private const float MASK_AREA_MAX_Y = 400f;

		// Token: 0x04024086 RID: 147590
		[Nullable(2)]
		private UUIDraggableComponent DraggableComponent;

		// Token: 0x04024087 RID: 147591
		[Nullable(2)]
		protected UUISprite RunBgItem;

		// Token: 0x04024088 RID: 147592
		[Nullable(2)]
		private UUIItem MaskArea;

		// Token: 0x04024089 RID: 147593
		private readonly Vector2D TempVector2D = Vector2D.Create(0.0, 0.0);

		// Token: 0x0402408A RID: 147594
		private readonly Vector NormalTargetVector = Vector.Create();

		// Token: 0x0402408B RID: 147595
		private readonly Vector PointerPosition = Vector.Create();

		// Token: 0x0402408C RID: 147596
		private readonly Vector CenterPosition = Vector.Create(0.0, 0.0, 0.0);

		// Token: 0x0402408D RID: 147597
		protected readonly Vector TargetVector = Vector.Create(0.0, 0.0, 0.0);

		// Token: 0x0402408E RID: 147598
		private readonly Rotator BgRotator = Rotator.Create();

		// Token: 0x0402408F RID: 147599
		private readonly float MaskAreaEnableRootX;

		// Token: 0x04024090 RID: 147600
		public int JoystickTouchId = -1;

		// Token: 0x04024091 RID: 147601
		private bool IsInTouch;

		// Token: 0x04024092 RID: 147602
		[Nullable(2)]
		private TsBasePlayerController PlayerController;

		// Token: 0x04024093 RID: 147603
		private bool IsJoystickPressed;

		// Token: 0x04024094 RID: 147604
		private double NextCheckInTouchTime;

		// Token: 0x04024095 RID: 147605
		private bool EnableMaskArea;

		// Token: 0x04024096 RID: 147606
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<string, float> OnAxisInput;

		// Token: 0x0200CD66 RID: 52582
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x0403DE72 RID: 253554
			WalkBgItem,
			// Token: 0x0403DE73 RID: 253555
			RunBgItem,
			// Token: 0x0403DE74 RID: 253556
			HandleItem,
			// Token: 0x0403DE75 RID: 253557
			ContextArea,
			// Token: 0x0403DE76 RID: 253558
			ClickArea,
			// Token: 0x0403DE77 RID: 253559
			MaskArea
		}
	}
}
