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
	// Token: 0x02004D80 RID: 19840
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorcycleJoystick : UiPanelBase
	{
		// Token: 0x06031CD4 RID: 203988 RVA: 0x00DED67C File Offset: 0x00DEB87C
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

		// Token: 0x06031CD5 RID: 203989 RVA: 0x00DED7F0 File Offset: 0x00DEB9F0
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

		// Token: 0x06031CD6 RID: 203990 RVA: 0x00DED958 File Offset: 0x00DEBB58
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

		// Token: 0x06031CD7 RID: 203991 RVA: 0x00DED9FC File Offset: 0x00DEBBFC
		protected override void OnBeforeHide()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlayLevelSequenceByName("Close", false, null, false);
		}

		// Token: 0x06031CD8 RID: 203992 RVA: 0x00DEDA29 File Offset: 0x00DEBC29
		protected override void OnBeforeDestroy()
		{
			this.PlayerController = null;
			this.IsJoystickPressed = false;
			BattleUiModel.Instance.MotorcycleData.IsPressJoyStick = false;
			this.RemoveEvents();
		}

		// Token: 0x06031CD9 RID: 203993 RVA: 0x00DEDA50 File Offset: 0x00DEBC50
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

		// Token: 0x06031CDA RID: 203994 RVA: 0x00DEDB10 File Offset: 0x00DEBD10
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

		// Token: 0x06031CDB RID: 203995 RVA: 0x00DEDB94 File Offset: 0x00DEBD94
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

		// Token: 0x06031CDC RID: 203996 RVA: 0x00DEDC08 File Offset: 0x00DEBE08
		private void CheckInTouch()
		{
			if (Time.Instance.Now < this.NextCheckInTouchTime)
			{
				return;
			}
			this.NextCheckInTouchTime = Time.Instance.Now + 500.0;
			this.IsInTouch = this.PlayerController.IsInTouch((float)this.JoystickTouchId);
		}

		// Token: 0x06031CDD RID: 203997 RVA: 0x00DEDC5C File Offset: 0x00DEBE5C
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

		// Token: 0x06031CDE RID: 203998 RVA: 0x00DEDCC7 File Offset: 0x00DEBEC7
		private void OnBgPointerDragCallBack(ULGUIPointerEventData eventData)
		{
			this.UpdatePointerPosition(eventData);
		}

		// Token: 0x06031CDF RID: 203999 RVA: 0x00DEDCD4 File Offset: 0x00DEBED4
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

		// Token: 0x06031CE0 RID: 204000 RVA: 0x00DEDDD8 File Offset: 0x00DEBFD8
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

		// Token: 0x06031CE1 RID: 204001 RVA: 0x00DEDF52 File Offset: 0x00DEC152
		private void OnJoystickButtonReleased()
		{
			this.EndDragJoystick();
			this.TweenAnimPlayer.PlayTweenAnim(10);
		}

		// Token: 0x06031CE2 RID: 204002 RVA: 0x00DEDF68 File Offset: 0x00DEC168
		private void MoveJoysticksHandle(global::Vector touchPosition, bool inTouch = true)
		{
			touchPosition.Subtraction(this.CenterPosition, this.TargetVector);
			if (this.TargetVector.IsNearlyZero(0.001))
			{
				this.TargetVector.Reset();
			}
			this.SetInputAxis(this.TargetVector, inTouch);
		}

		// Token: 0x06031CE3 RID: 204003 RVA: 0x00DEDFB8 File Offset: 0x00DEC1B8
		private void UpdateMaskItemPosition()
		{
			if (!this.EnableMaskArea)
			{
				return;
			}
			this.MaskArea.SetAnchorOffset(new FVector2D(Math.Min((float)this.PointerPosition.X, 400f), Math.Min((float)this.PointerPosition.Y, 400f)));
		}

		// Token: 0x06031CE4 RID: 204004 RVA: 0x00DEE00C File Offset: 0x00DEC20C
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

		// Token: 0x06031CE5 RID: 204005 RVA: 0x00DEE064 File Offset: 0x00DEC264
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

		// Token: 0x06031CE6 RID: 204006 RVA: 0x00DEE168 File Offset: 0x00DEC368
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

		// Token: 0x06031CE7 RID: 204007 RVA: 0x00DEE1C6 File Offset: 0x00DEC3C6
		private void PlayTweenAnimAndStopPre(int componentType)
		{
			if (this.LastTweenAnim > 0)
			{
				this.TweenAnimPlayer.StopTweenAnim(this.LastTweenAnim);
			}
			this.LastTweenAnim = componentType;
			this.TweenAnimPlayer.PlayTweenAnim(componentType);
		}

		// Token: 0x06031CE8 RID: 204008 RVA: 0x00DEE1F5 File Offset: 0x00DEC3F5
		public void OnDynamicChanged(bool isDynamic)
		{
			this.IsDynamicJoystick = isDynamic;
			if (!this.IsDynamicJoystick)
			{
				this.CenterPosition.Set(0.0, 0.0, 0.0);
			}
			this.RefreshJoystickAlpha();
		}

		// Token: 0x06031CE9 RID: 204009 RVA: 0x00DEE234 File Offset: 0x00DEC434
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

		// Token: 0x06031CEA RID: 204010 RVA: 0x00DEE283 File Offset: 0x00DEC483
		private void OnJoystickVisibleChanged()
		{
			this.UpdateJoystickVisible();
		}

		// Token: 0x06031CEB RID: 204011 RVA: 0x00DEE28B File Offset: 0x00DEC48B
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

		// Token: 0x06031CEC RID: 204012 RVA: 0x00DEE2C1 File Offset: 0x00DEC4C1
		public void SetEnable(bool bEnable)
		{
			this.SetActive(bEnable);
		}

		// Token: 0x0401A5CF RID: 107983
		private const double CHECK_IN_TOUCH_INTERVAL = 500.0;

		// Token: 0x0401A5D0 RID: 107984
		private const int MASK_AREA_MAX_X = 400;

		// Token: 0x0401A5D1 RID: 107985
		private const int MASK_AREA_MAX_Y = 400;

		// Token: 0x0401A5D2 RID: 107986
		private const int YAW_MAX = 30;

		// Token: 0x0401A5D3 RID: 107987
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401A5D4 RID: 107988
		private readonly BattleUiTweenAnimPlayer TweenAnimPlayer = new BattleUiTweenAnimPlayer();

		// Token: 0x0401A5D5 RID: 107989
		[Nullable(2)]
		private UUIDraggableComponent DraggableComponent;

		// Token: 0x0401A5D6 RID: 107990
		[Nullable(2)]
		private UUIItem ContextArea;

		// Token: 0x0401A5D7 RID: 107991
		[Nullable(2)]
		private UUIItem MaskArea;

		// Token: 0x0401A5D8 RID: 107992
		private MotorcycleJoystick.EJoystickType CurrentJoystickType;

		// Token: 0x0401A5D9 RID: 107993
		private readonly global::Vector PointerPosition = global::Vector.Create();

		// Token: 0x0401A5DA RID: 107994
		private readonly global::Vector CenterPosition = global::Vector.Create(0.0, 0.0, 0.0);

		// Token: 0x0401A5DB RID: 107995
		protected readonly global::Vector TargetVector = global::Vector.Create(0.0, 0.0, 0.0);

		// Token: 0x0401A5DC RID: 107996
		protected bool IsDynamicJoystick;

		// Token: 0x0401A5DD RID: 107997
		private float MaskAreaEnableRootX;

		// Token: 0x0401A5DE RID: 107998
		private float MidRate = 0.5f;

		// Token: 0x0401A5DF RID: 107999
		private float JoystickRadius = 200f;

		// Token: 0x0401A5E0 RID: 108000
		public int JoystickTouchId = -1;

		// Token: 0x0401A5E1 RID: 108001
		private bool IsInTouch;

		// Token: 0x0401A5E2 RID: 108002
		[Nullable(2)]
		private TsBasePlayerController PlayerController;

		// Token: 0x0401A5E3 RID: 108003
		private bool IsJoystickPressed;

		// Token: 0x0401A5E4 RID: 108004
		private double NextCheckInTouchTime;

		// Token: 0x0401A5E5 RID: 108005
		private bool EnableMaskArea;

		// Token: 0x0401A5E6 RID: 108006
		protected bool JoystickVisible;

		// Token: 0x0401A5E7 RID: 108007
		private int LastTweenAnim;

		// Token: 0x0200AA7D RID: 43645
		[NullableContext(0)]
		public enum EJoystickType
		{
			// Token: 0x04034B01 RID: 215809
			Mid,
			// Token: 0x04034B02 RID: 215810
			Left,
			// Token: 0x04034B03 RID: 215811
			Right
		}

		// Token: 0x0200AA7E RID: 43646
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04034B05 RID: 215813
			ArrowItem,
			// Token: 0x04034B06 RID: 215814
			ArrowBgItem,
			// Token: 0x04034B07 RID: 215815
			ContextArea,
			// Token: 0x04034B08 RID: 215816
			ClickArea,
			// Token: 0x04034B09 RID: 215817
			MaskArea,
			// Token: 0x04034B0A RID: 215818
			AniTurnRight,
			// Token: 0x04034B0B RID: 215819
			AniRightBack,
			// Token: 0x04034B0C RID: 215820
			AniTurnLeft,
			// Token: 0x04034B0D RID: 215821
			AniLeftBack,
			// Token: 0x04034B0E RID: 215822
			AniNormalToPress,
			// Token: 0x04034B0F RID: 215823
			AniPressToNormal
		}
	}
}
