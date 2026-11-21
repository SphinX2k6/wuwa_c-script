using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine.View
{
	// Token: 0x0200607A RID: 24698
	[NullableContext(1)]
	[Nullable(0)]
	public class DollGrabMachineJoystick : UiPanelBase
	{
		// Token: 0x0603B44E RID: 242766 RVA: 0x010C51FA File Offset: 0x010C33FA
		public void RegisterOnAxisInput(Action<string, float> onAxisInput)
		{
			this.OnAxisInput = onAxisInput;
		}

		// Token: 0x0603B44F RID: 242767 RVA: 0x010C5204 File Offset: 0x010C3404
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

		// Token: 0x0603B450 RID: 242768 RVA: 0x010C5274 File Offset: 0x010C3474
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

		// Token: 0x0603B451 RID: 242769 RVA: 0x010C530D File Offset: 0x010C350D
		public void HideBattleVisibleChildView()
		{
			UUIItem rootItem = this.RootItem;
			if (rootItem != null)
			{
				rootItem.SetUIActive(false);
			}
			this.SetActive(false);
		}

		// Token: 0x0603B452 RID: 242770 RVA: 0x010C5328 File Offset: 0x010C3528
		public void Reset()
		{
			this.PlayerController = null;
			this.IsJoystickPressed = false;
			this.RemoveEvents();
		}

		// Token: 0x0603B453 RID: 242771 RVA: 0x010C5340 File Offset: 0x010C3540
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

		// Token: 0x0603B454 RID: 242772 RVA: 0x010C5430 File Offset: 0x010C3630
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

		// Token: 0x0603B455 RID: 242773 RVA: 0x010C54A0 File Offset: 0x010C36A0
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

		// Token: 0x0603B456 RID: 242774 RVA: 0x010C54E4 File Offset: 0x010C36E4
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

		// Token: 0x0603B457 RID: 242775 RVA: 0x010C55A8 File Offset: 0x010C37A8
		private void CheckInTouch()
		{
			if (Time.Instance.Now < this.NextCheckInTouchTime)
			{
				return;
			}
			this.NextCheckInTouchTime = Time.Instance.Now + 500.0;
			this.IsInTouch = this.PlayerController.IsInTouch((float)this.JoystickTouchId);
		}

		// Token: 0x0603B458 RID: 242776 RVA: 0x010C55FC File Offset: 0x010C37FC
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

		// Token: 0x0603B459 RID: 242777 RVA: 0x010C56FA File Offset: 0x010C38FA
		private void OnBgPointerDragCallBack(ULGUIPointerEventData eventData)
		{
			this.UpdatePointerPosition(eventData);
		}

		// Token: 0x0603B45A RID: 242778 RVA: 0x010C5704 File Offset: 0x010C3904
		private void OnJoystickButtonReleased()
		{
			this.EndDragJoystick();
		}

		// Token: 0x0603B45B RID: 242779 RVA: 0x010C570C File Offset: 0x010C390C
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

		// Token: 0x0603B45C RID: 242780 RVA: 0x010C5818 File Offset: 0x010C3A18
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

		// Token: 0x0603B45D RID: 242781 RVA: 0x010C5874 File Offset: 0x010C3A74
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

		// Token: 0x0603B45E RID: 242782 RVA: 0x010C58E0 File Offset: 0x010C3AE0
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

		// Token: 0x0603B45F RID: 242783 RVA: 0x010C5918 File Offset: 0x010C3B18
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

		// Token: 0x0603B460 RID: 242784 RVA: 0x010C5BC0 File Offset: 0x010C3DC0
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

		// Token: 0x0603B461 RID: 242785 RVA: 0x010C5BF4 File Offset: 0x010C3DF4
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

		// Token: 0x0603B462 RID: 242786 RVA: 0x010C5C5C File Offset: 0x010C3E5C
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

		// Token: 0x0401F334 RID: 127796
		private const float JOYSTICK_RADIU = 200f;

		// Token: 0x0401F335 RID: 127797
		private const float JOYSTICK_RADIU_SQUARED = 40000f;

		// Token: 0x0401F336 RID: 127798
		private const double CHECK_IN_TOUCH_INTERVAL = 500.0;

		// Token: 0x0401F337 RID: 127799
		private const float MASK_AREA_MAX_X = 400f;

		// Token: 0x0401F338 RID: 127800
		private const float MASK_AREA_MAX_Y = 400f;

		// Token: 0x0401F339 RID: 127801
		[Nullable(2)]
		private UUIDraggableComponent DraggableComponent;

		// Token: 0x0401F33A RID: 127802
		[Nullable(2)]
		protected UUISprite RunBgItem;

		// Token: 0x0401F33B RID: 127803
		[Nullable(2)]
		private UUIItem MaskArea;

		// Token: 0x0401F33C RID: 127804
		private readonly Vector2D TempVector2D = Vector2D.Create(0.0, 0.0);

		// Token: 0x0401F33D RID: 127805
		private readonly Vector NormalTargetVector = Vector.Create();

		// Token: 0x0401F33E RID: 127806
		private readonly Vector PointerPosition = Vector.Create();

		// Token: 0x0401F33F RID: 127807
		private readonly Vector CenterPosition = Vector.Create(0.0, 0.0, 0.0);

		// Token: 0x0401F340 RID: 127808
		protected readonly Vector TargetVector = Vector.Create(0.0, 0.0, 0.0);

		// Token: 0x0401F341 RID: 127809
		private readonly Rotator BgRotator = Rotator.Create();

		// Token: 0x0401F342 RID: 127810
		private readonly float MaskAreaEnableRootX;

		// Token: 0x0401F343 RID: 127811
		public int JoystickTouchId = -1;

		// Token: 0x0401F344 RID: 127812
		private bool IsInTouch;

		// Token: 0x0401F345 RID: 127813
		[Nullable(2)]
		private TsBasePlayerController PlayerController;

		// Token: 0x0401F346 RID: 127814
		private bool IsJoystickPressed;

		// Token: 0x0401F347 RID: 127815
		private double NextCheckInTouchTime;

		// Token: 0x0401F348 RID: 127816
		private bool EnableMaskArea;

		// Token: 0x0401F349 RID: 127817
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<string, float> OnAxisInput;

		// Token: 0x0200B956 RID: 47446
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04039294 RID: 234132
			WalkBgItem,
			// Token: 0x04039295 RID: 234133
			RunBgItem,
			// Token: 0x04039296 RID: 234134
			HandleItem,
			// Token: 0x04039297 RID: 234135
			ContextArea,
			// Token: 0x04039298 RID: 234136
			ClickArea,
			// Token: 0x04039299 RID: 234137
			MaskArea
		}
	}
}
