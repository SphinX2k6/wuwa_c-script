using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Views
{
	// Token: 0x0200564A RID: 22090
	[NullableContext(1)]
	[Nullable(0)]
	public class DropCatchGameplayJoystickView : UiPanelBase
	{
		// Token: 0x0603691C RID: 223516 RVA: 0x00F3A38A File Offset: 0x00F3858A
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIDraggableComponent))
			};
		}

		// Token: 0x0603691D RID: 223517 RVA: 0x00F3A3AD File Offset: 0x00F385AD
		protected override void OnStart()
		{
			this.Proxy = (this.OpenParam as DropCatchGameplayProxy);
			this.DraggableComponent = base.GetDraggable(0);
			this.AddEvents();
		}

		// Token: 0x0603691E RID: 223518 RVA: 0x00F3A3D4 File Offset: 0x00F385D4
		private void AddEvents()
		{
			UUIDraggableComponent draggableComponent = this.DraggableComponent;
			if (draggableComponent != null)
			{
				draggableComponent.OnPointerDownCallBack.Bind(delegate(ULGUIPointerEventData eventData)
				{
					this.OnJoystickButtonPressed(eventData);
				});
			}
			UUIDraggableComponent draggableComponent2 = this.DraggableComponent;
			if (draggableComponent2 != null)
			{
				draggableComponent2.OnPointerDragCallBack.Bind(delegate(ULGUIPointerEventData eventData)
				{
					this.OnBgPointerDragCallBack(eventData);
				});
			}
			UUIDraggableComponent draggableComponent3 = this.DraggableComponent;
			if (draggableComponent3 != null)
			{
				draggableComponent3.OnPointerEndDragCallBack.Bind(delegate(ULGUIPointerEventData eventData)
				{
					this.OnJoystickButtonReleased(eventData);
				});
			}
			UUIDraggableComponent draggableComponent4 = this.DraggableComponent;
			if (draggableComponent4 != null)
			{
				draggableComponent4.OnPointerUpCallBack.Bind(delegate(ULGUIPointerEventData eventData)
				{
					this.OnJoystickButtonReleased(eventData);
				});
			}
			UUIDraggableComponent draggableComponent5 = this.DraggableComponent;
			if (draggableComponent5 == null)
			{
				return;
			}
			draggableComponent5.OnPointerCancelCallBack.Bind(delegate(ULGUIPointerEventData eventData)
			{
				this.OnJoystickButtonReleased(eventData);
			});
		}

		// Token: 0x0603691F RID: 223519 RVA: 0x00F3A48A File Offset: 0x00F3868A
		private void OnBgPointerDragCallBack(ULGUIPointerEventData eventData)
		{
			this.UpdatePointerPosition(eventData);
		}

		// Token: 0x06036920 RID: 223520 RVA: 0x00F3A494 File Offset: 0x00F38694
		private void UpdatePointerPosition(ULGUIPointerEventData eventData)
		{
			FVector localPointInPlane = eventData.GetLocalPointInPlane();
			this.PointerPosition.X = (double)localPointInPlane.X;
			this.PointerPosition.Y = (double)localPointInPlane.Y;
			this.MoveJoysticksHandle(this.PointerPosition);
		}

		// Token: 0x06036921 RID: 223521 RVA: 0x00F3A4D8 File Offset: 0x00F386D8
		private void OnJoystickButtonPressed(ULGUIPointerEventData eventData)
		{
			this.EventDataList.Add(eventData);
			FVector localPointInPlane = eventData.GetLocalPointInPlane();
			this.PointerPosition.X = (double)localPointInPlane.X;
			this.PointerPosition.Y = (double)localPointInPlane.Y;
			if (this.PointerPosition.IsZero())
			{
				return;
			}
			this.MoveJoysticksHandle(this.PointerPosition);
		}

		// Token: 0x06036922 RID: 223522 RVA: 0x00F3A538 File Offset: 0x00F38738
		private void OnJoystickButtonReleased(ULGUIPointerEventData eventData)
		{
			int num = this.EventDataList.IndexOf(eventData);
			if (num < 0)
			{
				return;
			}
			this.EventDataList.RemoveAt(num);
			if (this.EventDataList.Count > 0)
			{
				FVector localPointInPlane = this.EventDataList[this.EventDataList.Count - 1].GetLocalPointInPlane();
				this.PointerPosition.X = (double)localPointInPlane.X;
				this.PointerPosition.Y = (double)localPointInPlane.Y;
				this.MoveJoysticksHandle(this.PointerPosition);
				return;
			}
			this.EndDragJoystick();
		}

		// Token: 0x06036923 RID: 223523 RVA: 0x00F3A5C6 File Offset: 0x00F387C6
		private void EndDragJoystick()
		{
			this.MoveJoysticksHandle(this.CenterPosition);
		}

		// Token: 0x06036924 RID: 223524 RVA: 0x00F3A5D4 File Offset: 0x00F387D4
		private void MoveJoysticksHandle(Vector touchPosition)
		{
			double num = touchPosition.X - this.CenterPosition.X;
			this.SetHandleOffset((float)num);
			this.SetInputAxis((float)num);
		}

		// Token: 0x06036925 RID: 223525 RVA: 0x00F3A604 File Offset: 0x00F38804
		protected void SetHandleOffset(float targetX)
		{
			UUIDraggableComponent draggableComponent = this.DraggableComponent;
			if (draggableComponent == null)
			{
				return;
			}
			draggableComponent.RootUIComp.Get().SetAnchorOffsetX(MathUtils.Instance.Clamp(targetX, (float)(-(float)DropCatchGameplayJoystickView.MAX_OFFSET_X), (float)DropCatchGameplayJoystickView.MAX_OFFSET_X));
		}

		// Token: 0x06036926 RID: 223526 RVA: 0x00F3A648 File Offset: 0x00F38848
		public void SetHandleByDirection(EDropCatchRoleDirection direction)
		{
			UUIDraggableComponent draggableComponent = this.DraggableComponent;
			if (draggableComponent == null)
			{
				return;
			}
			draggableComponent.RootUIComp.Get().SetAnchorOffsetX((float)((direction == EDropCatchRoleDirection.None) ? 0 : ((direction == EDropCatchRoleDirection.Right) ? DropCatchGameplayJoystickView.MAX_OFFSET_X : (-(float)DropCatchGameplayJoystickView.MAX_OFFSET_X))));
		}

		// Token: 0x06036927 RID: 223527 RVA: 0x00F3A68C File Offset: 0x00F3888C
		protected void SetInputAxis(float targetX)
		{
			if (MathUtils.Instance.IsNearlyZero((double)targetX, null) || (targetX < (float)(DropCatchGameplayJoystickView.MAX_OFFSET_X / 2) && targetX > (float)(-(float)DropCatchGameplayJoystickView.MAX_OFFSET_X / 2)))
			{
				DropCatchGameplayProxy proxy = this.Proxy;
				if (proxy == null)
				{
					return;
				}
				DropCatchGameplayLogic gameplayLogic = proxy.GetGameplayLogic();
				if (gameplayLogic == null)
				{
					return;
				}
				DropCatchGameplayInputMgr gameplayInputMgr = gameplayLogic.GetGameplayInputMgr();
				if (gameplayInputMgr == null)
				{
					return;
				}
				gameplayInputMgr.Delete(EDropCatchGameplayInputChannel.MoveDirection, EDropCatchGameplayInputSource.Joystick);
				return;
			}
			else
			{
				DropCatchGameplayProxy proxy2 = this.Proxy;
				if (proxy2 == null)
				{
					return;
				}
				DropCatchGameplayLogic gameplayLogic2 = proxy2.GetGameplayLogic();
				if (gameplayLogic2 == null)
				{
					return;
				}
				DropCatchGameplayInputMgr gameplayInputMgr2 = gameplayLogic2.GetGameplayInputMgr();
				if (gameplayInputMgr2 == null)
				{
					return;
				}
				gameplayInputMgr2.Set(EDropCatchGameplayInputChannel.MoveDirection, EDropCatchGameplayInputSource.Joystick, (targetX > 0f) ? EDropCatchRoleDirection.Right : EDropCatchRoleDirection.Left);
				return;
			}
		}

		// Token: 0x06036928 RID: 223528 RVA: 0x00F3A720 File Offset: 0x00F38920
		private void RemoveEvents()
		{
			UUIDraggableComponent draggableComponent = this.DraggableComponent;
			if (draggableComponent != null)
			{
				draggableComponent.OnPointerDownCallBack.Unbind();
			}
			UUIDraggableComponent draggableComponent2 = this.DraggableComponent;
			if (draggableComponent2 != null)
			{
				draggableComponent2.OnPointerDragCallBack.Unbind();
			}
			UUIDraggableComponent draggableComponent3 = this.DraggableComponent;
			if (draggableComponent3 != null)
			{
				draggableComponent3.OnPointerEndDragCallBack.Unbind();
			}
			UUIDraggableComponent draggableComponent4 = this.DraggableComponent;
			if (draggableComponent4 != null)
			{
				draggableComponent4.OnPointerUpCallBack.Unbind();
			}
			UUIDraggableComponent draggableComponent5 = this.DraggableComponent;
			if (draggableComponent5 == null)
			{
				return;
			}
			draggableComponent5.OnPointerCancelCallBack.Unbind();
		}

		// Token: 0x06036929 RID: 223529 RVA: 0x00F3A79C File Offset: 0x00F3899C
		public void SetInputEnabled(bool enabled)
		{
			UUIDraggableComponent draggableComponent = this.DraggableComponent;
			if (draggableComponent == null)
			{
				return;
			}
			draggableComponent.RootUIComp.Get().SetRaycastTarget(enabled);
		}

		// Token: 0x0603692A RID: 223530 RVA: 0x00F3A7C7 File Offset: 0x00F389C7
		public void Reset()
		{
			this.SetInputEnabled(true);
		}

		// Token: 0x0603692B RID: 223531 RVA: 0x00F3A7D0 File Offset: 0x00F389D0
		protected override void OnBeforeDestroy()
		{
			this.RemoveEvents();
		}

		// Token: 0x0401CD48 RID: 118088
		private static readonly int MAX_OFFSET_X = 40;

		// Token: 0x0401CD49 RID: 118089
		private DropCatchGameplayProxy Proxy;

		// Token: 0x0401CD4A RID: 118090
		private readonly Vector PointerPosition = Vector.Create();

		// Token: 0x0401CD4B RID: 118091
		private readonly Vector CenterPosition = Vector.Create(0.0, 0.0, 0.0);

		// Token: 0x0401CD4C RID: 118092
		[Nullable(2)]
		private UUIDraggableComponent DraggableComponent;

		// Token: 0x0401CD4D RID: 118093
		protected List<ULGUIPointerEventData> EventDataList = new List<ULGUIPointerEventData>();
	}
}
