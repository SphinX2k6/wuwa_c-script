using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Input;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D9E RID: 23966
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorcycleJoystick : UiPanelBase
	{
		// Token: 0x0603CD77 RID: 249207 RVA: 0x00E9CDC4 File Offset: 0x00E9AFC4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 10;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603CD78 RID: 249208 RVA: 0x00E9CF38 File Offset: 0x00E9B138
		protected override void OnStart()
		{
			base.OnStart();
			this.ParentUiItem = (this.OpenParam as UUIItem);
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.TweenAnimPlayer.InitTweenAnim(5, base.GetItem(5), false);
			this.TweenAnimPlayer.InitTweenAnim(6, base.GetItem(6), false);
			this.TweenAnimPlayer.InitTweenAnim(7, base.GetItem(7), false);
			this.TweenAnimPlayer.InitTweenAnim(8, base.GetItem(8), false);
			this.TweenAnimPlayer.InitTweenAnim(9, base.GetItem(9), false);
			this.TweenAnimPlayer.InitTweenAnim(10, base.GetItem(10), false);
			this.DraggableComponent = (base.GetRootActor().GetComponentByClass(UUIDraggableComponent.StaticClass()) as UUIDraggableComponent);
			this.AddEvents();
			this.ContextArea = base.GetItem(2);
			this.MaskArea = base.GetItem(4);
			this.PlayerController = Global.CharacterController;
			this.IsDynamicJoystick = BattleUiModel.Instance.MotorcycleData.GetIsDynamicJoystick();
			this.MaskAreaEnableRootX = ConfigCommonParamById.GetFloatConfig("MaskAreaEnableRootX").Value;
			this.MidRate = ConfigCommonParamById.GetFloatConfig("MotorcycleJoystickMidRate").Value;
			this.JoystickRadius = ConfigCommonParamById.GetFloatConfig("MotorcycleJoystickRadius").Value;
			this.UpdateJoystickVisible();
			this.RefreshJoystickAlpha();
		}

		// Token: 0x0603CD79 RID: 249209 RVA: 0x00E9D0A0 File Offset: 0x00E9B2A0
		protected override void OnAfterShow()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
			}
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

		// Token: 0x0603CD7A RID: 249210 RVA: 0x00E9D144 File Offset: 0x00E9B344
		protected override void OnBeforeHide()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlayLevelSequenceByName("Close", false, null, false);
		}

		// Token: 0x0603CD7B RID: 249211 RVA: 0x00E9D171 File Offset: 0x00E9B371
		protected override void OnBeforeDestroy()
		{
			this.PlayerController = null;
			this.IsJoystickPressed = false;
			BattleUiModel.Instance.MotorcycleData.IsPressJoyStick = false;
			this.RemoveEvents();
		}

		// Token: 0x0603CD7C RID: 249212 RVA: 0x00E9D198 File Offset: 0x00E9B398
		private void AddEvents()
		{
			UUIDraggableComponent draggableComponent = this.DraggableComponent;
			draggableComponent.OnPointerDownCallBack.Bind(delegate(ULGUIPointerEventData eventData)
			{
				this.OnJoystickButtonPressed(eventData);
			});
			draggableComponent.OnPointerBeginDragCallBack.Bind(delegate(ULGUIPointerEventData eventData)
			{
				this.OnBgPointerBeginDragCallBack(eventData);
			});
			draggableComponent.OnPointerDragCallBack.Bind(delegate(ULGUIPointerEventData eventData)
			{
				this.OnBgPointerDragCallBack(eventData);
			});
			draggableComponent.OnPointerEndDragCallBack.Bind(delegate(ULGUIPointerEventData _)
			{
				this.OnJoystickButtonReleased();
			});
			draggableComponent.OnPointerUpCallBack.Bind(delegate(ULGUIPointerEventData _)
			{
				this.OnJoystickButtonReleased();
			});
			EventSystem.Instance.Add(EEventName.OnSetMotorcycleJoystickMode, new Action<bool>(this.OnDynamicChanged));
			BattleUiModel.Instance.ChildViewData.AddCallback(EBattleUiChild.MotorcycleMobileJoystick, new Action(this.OnJoystickVisibleChanged));
		}

		// Token: 0x0603CD7D RID: 249213 RVA: 0x00E9D258 File Offset: 0x00E9B458
		private void RemoveEvents()
		{
			UUIDraggableComponent draggableComponent = this.DraggableComponent;
			draggableComponent.OnPointerDownCallBack.Unbind();
			draggableComponent.OnPointerBeginDragCallBack.Unbind();
			draggableComponent.OnPointerDragCallBack.Unbind();
			draggableComponent.OnPointerEndDragCallBack.Unbind();
			draggableComponent.OnPointerUpCallBack.Unbind();
			EventSystem.Instance.Remove(EEventName.OnSetMotorcycleJoystickMode, new Action<bool>(this.OnDynamicChanged));
			BattleUiModel.Instance.ChildViewData.RemoveCallback(EBattleUiChild.MotorcycleMobileJoystick, new Action(this.OnJoystickVisibleChanged));
		}

		// Token: 0x0603CD7E RID: 249214 RVA: 0x00E9D2DC File Offset: 0x00E9B4DC
		public void Tick(double delta)
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
			if (!BattleUiModel.Instance.MotorcycleData.IsDriving)
			{
				this.EndDragJoystick();
			}
			if (!this.IsJoystickPressed)
			{
				return;
			}
			if (InputDistributeController.Instance.IsAllowFightMoveInput())
			{
				this.MoveJoysticksHandle(this.PointerPosition, true);
				return;
			}
			this.MoveJoysticksHandle(this.CenterPosition, true);
		}

		// Token: 0x0603CD7F RID: 249215 RVA: 0x00E9D350 File Offset: 0x00E9B550
		private void CheckInTouch()
		{
			if (Time.Instance.Now < this.NextCheckInTouchTime)
			{
				return;
			}
			this.NextCheckInTouchTime = Time.Instance.Now + 500.0;
			this.IsInTouch = this.PlayerController.IsInTouch((float)this.JoystickTouchId);
		}

		// Token: 0x0603CD80 RID: 249216 RVA: 0x00E9D3A4 File Offset: 0x00E9B5A4
		private void OnBgPointerBeginDragCallBack(ULGUIPointerEventData eventData)
		{
			if (this.UpdatePointerPosition(eventData) && this.IsDynamicJoystick && this.IsJoystickPressed && InputDistributeController.Instance.IsAllowFightMoveInput())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Battle;
				ELogAuthor author = ELogAuthor.CFT;
				string message = "[摩托车]动态摇杆开始拖动立即响应输入";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Position", this.PointerPosition);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				this.MoveJoysticksHandle(this.PointerPosition, true);
			}
		}

		// Token: 0x0603CD81 RID: 249217 RVA: 0x00E9D40F File Offset: 0x00E9B60F
		private void OnBgPointerDragCallBack(ULGUIPointerEventData eventData)
		{
			this.UpdatePointerPosition(eventData);
		}

		// Token: 0x0603CD82 RID: 249218 RVA: 0x00E9D41C File Offset: 0x00E9B61C
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
					ELogAuthor author = ELogAuthor.CFT;
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
				ELogAuthor author2 = ELogAuthor.CFT;
				string message2 = "JoystickDrag";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("", this.JoystickTouchId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("", this.PointerPosition);
				instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			return true;
		}

		// Token: 0x0603CD83 RID: 249219 RVA: 0x00E9D520 File Offset: 0x00E9B720
		private unsafe void OnJoystickButtonPressed(ULGUIPointerEventData eventData)
		{
			this.JoystickTouchId = eventData.pointerID;
			FVector localPointInPlane = eventData.GetLocalPointInPlane();
			this.PointerPosition.X = (double)localPointInPlane.X;
			this.PointerPosition.Y = (double)localPointInPlane.Y;
			this.IsJoystickPressed = true;
			this.RefreshJoystickAlpha();
			BattleUiModel.Instance.MotorcycleData.IsPressJoyStick = true;
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
				this.ContextArea.SetAnchorOffset(new FVector2D((float)this.CenterPosition.X, (float)this.CenterPosition.Y));
			}
			this.TweenAnimPlayer.PlayTweenAnim(9);
			if (BattleUiModel.Instance.IsOpenJoystickLog)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Battle;
				ELogAuthor author = ELogAuthor.CFT;
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

		// Token: 0x0603CD84 RID: 249220 RVA: 0x00E9D69A File Offset: 0x00E9B89A
		private void OnJoystickButtonReleased()
		{
			this.EndDragJoystick();
			this.TweenAnimPlayer.PlayTweenAnim(10);
		}

		// Token: 0x0603CD85 RID: 249221 RVA: 0x00E9D6B0 File Offset: 0x00E9B8B0
		private void MoveJoysticksHandle(global::Vector touchPosition, bool inTouch = true)
		{
			touchPosition.Subtraction(this.CenterPosition, this.TargetVector);
			if (this.TargetVector.IsNearlyZero(0.001))
			{
				this.TargetVector.Reset();
			}
			this.SetInputAxis(this.TargetVector, inTouch);
		}

		// Token: 0x0603CD86 RID: 249222 RVA: 0x00E9D700 File Offset: 0x00E9B900
		private void UpdateMaskItemPosition()
		{
			if (!this.EnableMaskArea)
			{
				return;
			}
			this.MaskArea.SetAnchorOffset(new FVector2D(Math.Min((float)this.PointerPosition.X, 400f), Math.Min((float)this.PointerPosition.Y, 400f)));
		}

		// Token: 0x0603CD87 RID: 249223 RVA: 0x00E9D754 File Offset: 0x00E9B954
		private void EndDragJoystick()
		{
			this.MoveJoysticksHandle(this.CenterPosition, false);
			this.JoystickTouchId = -1;
			this.IsInTouch = false;
			this.IsJoystickPressed = false;
			this.RefreshJoystickAlpha();
			BattleUiModel.Instance.MotorcycleData.IsPressJoyStick = false;
			UUIItem maskArea = this.MaskArea;
			if (maskArea == null)
			{
				return;
			}
			maskArea.SetUIActive(false);
		}

		// Token: 0x0603CD88 RID: 249224 RVA: 0x00E9D7AC File Offset: 0x00E9B9AC
		protected void SetInputAxis(global::Vector targetVector, bool inTouch)
		{
			FRotator frotator;
			if (!this.JoystickVisible || !inTouch || targetVector.Equality(global::Vector.ZeroVectorProxy))
			{
				this.SetJoystickType(MotorcycleJoystick.EJoystickType.Mid);
				UUIItem item = base.GetItem(0);
				frotator = new FRotator();
				item.SetUIRelativeRotation(frotator);
				InputController.Instance.InputAxis(EInputAxis.MoveRight, 0f, true);
				return;
			}
			float num = (float)targetVector.X / this.JoystickRadius;
			if (num > 1f)
			{
				num = 1f;
			}
			else if (num < -1f)
			{
				num = -1f;
			}
			float yaw;
			if (num >= this.MidRate)
			{
				this.SetJoystickType(MotorcycleJoystick.EJoystickType.Right);
				yaw = (num - this.MidRate) * -30f;
			}
			else if (num <= -this.MidRate)
			{
				this.SetJoystickType(MotorcycleJoystick.EJoystickType.Left);
				yaw = (-this.MidRate - num) * 30f;
			}
			else
			{
				this.SetJoystickType(MotorcycleJoystick.EJoystickType.Mid);
				yaw = 0f;
			}
			UUIItem item2 = base.GetItem(0);
			frotator = new FRotator();
			frotator.Yaw = yaw;
			item2.SetUIRelativeRotation(frotator);
			InputController.Instance.InputAxis(EInputAxis.MoveRight, num, true);
		}

		// Token: 0x0603CD89 RID: 249225 RVA: 0x00E9D8B0 File Offset: 0x00E9BAB0
		private void SetJoystickType(MotorcycleJoystick.EJoystickType type)
		{
			if (this.CurrentJoystickType == type)
			{
				return;
			}
			MotorcycleJoystick.EJoystickType currentJoystickType = this.CurrentJoystickType;
			this.CurrentJoystickType = type;
			if (this.CurrentJoystickType == MotorcycleJoystick.EJoystickType.Left)
			{
				this.PlayTweenAnimAndStopPre(7);
				return;
			}
			if (this.CurrentJoystickType == MotorcycleJoystick.EJoystickType.Right)
			{
				this.PlayTweenAnimAndStopPre(5);
				return;
			}
			if (currentJoystickType == MotorcycleJoystick.EJoystickType.Left)
			{
				this.PlayTweenAnimAndStopPre(8);
				return;
			}
			if (currentJoystickType == MotorcycleJoystick.EJoystickType.Right)
			{
				this.PlayTweenAnimAndStopPre(6);
			}
		}

		// Token: 0x0603CD8A RID: 249226 RVA: 0x00E9D90E File Offset: 0x00E9BB0E
		private void PlayTweenAnimAndStopPre(int componentType)
		{
			if (this.LastTweenAnim > 0)
			{
				this.TweenAnimPlayer.StopTweenAnim(this.LastTweenAnim);
			}
			this.LastTweenAnim = componentType;
			this.TweenAnimPlayer.PlayTweenAnim(componentType);
		}

		// Token: 0x0603CD8B RID: 249227 RVA: 0x00E9D93D File Offset: 0x00E9BB3D
		public void OnDynamicChanged(bool isDynamic)
		{
			this.IsDynamicJoystick = isDynamic;
			if (!this.IsDynamicJoystick)
			{
				this.CenterPosition.Set(0.0, 0.0, 0.0);
			}
			this.RefreshJoystickAlpha();
		}

		// Token: 0x0603CD8C RID: 249228 RVA: 0x00E9D97C File Offset: 0x00E9BB7C
		private void RefreshJoystickAlpha()
		{
			if (this.IsJoystickPressed)
			{
				this.RootItem.SetAlpha(1f);
				return;
			}
			if (this.IsDynamicJoystick)
			{
				this.RootItem.SetAlpha(0f);
				return;
			}
			this.RootItem.SetAlpha(0.5f);
		}

		// Token: 0x0603CD8D RID: 249229 RVA: 0x00E9D9CB File Offset: 0x00E9BBCB
		private void OnJoystickVisibleChanged()
		{
			this.UpdateJoystickVisible();
		}

		// Token: 0x0603CD8E RID: 249230 RVA: 0x00E9D9D3 File Offset: 0x00E9BBD3
		protected void UpdateJoystickVisible()
		{
			BattleUiChildViewData childViewData = BattleUiModel.Instance.ChildViewData;
			this.JoystickVisible = (childViewData != null && childViewData.GetChildVisible(EBattleUiChild.MotorcycleMobileJoystick));
			UUIItem contextArea = this.ContextArea;
			if (contextArea == null)
			{
				return;
			}
			contextArea.SetUIActive(this.JoystickVisible);
		}

		// Token: 0x0603CD8F RID: 249231 RVA: 0x00E9DA09 File Offset: 0x00E9BC09
		public void SetEnable(bool bEnable)
		{
			this.SetActive(bEnable);
		}

		// Token: 0x0401FB17 RID: 129815
		private const double CHECK_IN_TOUCH_INTERVAL = 500.0;

		// Token: 0x0401FB18 RID: 129816
		private const int MASK_AREA_MAX_X = 400;

		// Token: 0x0401FB19 RID: 129817
		private const int MASK_AREA_MAX_Y = 400;

		// Token: 0x0401FB1A RID: 129818
		private const int YAW_MAX = 30;

		// Token: 0x0401FB1B RID: 129819
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401FB1C RID: 129820
		private readonly BattleUiTweenAnimPlayer TweenAnimPlayer = new BattleUiTweenAnimPlayer();

		// Token: 0x0401FB1D RID: 129821
		[Nullable(2)]
		private UUIDraggableComponent DraggableComponent;

		// Token: 0x0401FB1E RID: 129822
		[Nullable(2)]
		private UUIItem ContextArea;

		// Token: 0x0401FB1F RID: 129823
		[Nullable(2)]
		private UUIItem MaskArea;

		// Token: 0x0401FB20 RID: 129824
		private MotorcycleJoystick.EJoystickType CurrentJoystickType;

		// Token: 0x0401FB21 RID: 129825
		private readonly global::Vector PointerPosition = global::Vector.Create();

		// Token: 0x0401FB22 RID: 129826
		private readonly global::Vector CenterPosition = global::Vector.Create(0.0, 0.0, 0.0);

		// Token: 0x0401FB23 RID: 129827
		protected readonly global::Vector TargetVector = global::Vector.Create(0.0, 0.0, 0.0);

		// Token: 0x0401FB24 RID: 129828
		protected bool IsDynamicJoystick;

		// Token: 0x0401FB25 RID: 129829
		private float MaskAreaEnableRootX;

		// Token: 0x0401FB26 RID: 129830
		private float MidRate = 0.5f;

		// Token: 0x0401FB27 RID: 129831
		private float JoystickRadius = 200f;

		// Token: 0x0401FB28 RID: 129832
		public int JoystickTouchId = -1;

		// Token: 0x0401FB29 RID: 129833
		private bool IsInTouch;

		// Token: 0x0401FB2A RID: 129834
		[Nullable(2)]
		private TsBasePlayerController PlayerController;

		// Token: 0x0401FB2B RID: 129835
		private bool IsJoystickPressed;

		// Token: 0x0401FB2C RID: 129836
		private double NextCheckInTouchTime;

		// Token: 0x0401FB2D RID: 129837
		private bool EnableMaskArea;

		// Token: 0x0401FB2E RID: 129838
		protected bool JoystickVisible;

		// Token: 0x0401FB2F RID: 129839
		private int LastTweenAnim;

		// Token: 0x0200C077 RID: 49271
		[NullableContext(0)]
		public enum EJoystickType
		{
			// Token: 0x0403A13E RID: 237886
			Mid,
			// Token: 0x0403A13F RID: 237887
			Left,
			// Token: 0x0403A140 RID: 237888
			Right
		}

		// Token: 0x0200C078 RID: 49272
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x0403A142 RID: 237890
			ArrowItem,
			// Token: 0x0403A143 RID: 237891
			ArrowBgItem,
			// Token: 0x0403A144 RID: 237892
			ContextArea,
			// Token: 0x0403A145 RID: 237893
			ClickArea,
			// Token: 0x0403A146 RID: 237894
			MaskArea,
			// Token: 0x0403A147 RID: 237895
			AniTurnRight,
			// Token: 0x0403A148 RID: 237896
			AniRightBack,
			// Token: 0x0403A149 RID: 237897
			AniTurnLeft,
			// Token: 0x0403A14A RID: 237898
			AniLeftBack,
			// Token: 0x0403A14B RID: 237899
			AniNormalToPress,
			// Token: 0x0403A14C RID: 237900
			AniPressToNormal
		}
	}
}
