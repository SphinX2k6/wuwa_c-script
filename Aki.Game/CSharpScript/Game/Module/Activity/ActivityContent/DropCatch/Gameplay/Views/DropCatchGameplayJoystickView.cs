using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Views
{
	// Token: 0x020066FA RID: 26362
	[NullableContext(1)]
	[Nullable(0)]
	public class DropCatchGameplayJoystickView : UiPanelBase
	{
		// Token: 0x06041DD0 RID: 269776 RVA: 0x00FF8F96 File Offset: 0x00FF7196
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIDraggableComponent))
			};
		}

		// Token: 0x06041DD1 RID: 269777 RVA: 0x00FF8FB9 File Offset: 0x00FF71B9
		protected override void OnStart()
		{
			this.Proxy = (this.OpenParam as DropCatchGameplayProxy);
			this.DraggableComponent = base.GetDraggable(0);
			this.AddEvents();
		}

		// Token: 0x06041DD2 RID: 269778 RVA: 0x00FF8FE0 File Offset: 0x00FF71E0
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

		// Token: 0x06041DD3 RID: 269779 RVA: 0x00FF9096 File Offset: 0x00FF7296
		private void OnBgPointerDragCallBack(ULGUIPointerEventData eventData)
		{
			this.UpdatePointerPosition(eventData);
		}

		// Token: 0x06041DD4 RID: 269780 RVA: 0x00FF90A0 File Offset: 0x00FF72A0
		private void UpdatePointerPosition(ULGUIPointerEventData eventData)
		{
			FVector localPointInPlane = eventData.GetLocalPointInPlane();
			this.PointerPosition.X = (double)localPointInPlane.X;
			this.PointerPosition.Y = (double)localPointInPlane.Y;
			this.MoveJoysticksHandle(this.PointerPosition);
		}

		// Token: 0x06041DD5 RID: 269781 RVA: 0x00FF90E4 File Offset: 0x00FF72E4
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

		// Token: 0x06041DD6 RID: 269782 RVA: 0x00FF9144 File Offset: 0x00FF7344
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

		// Token: 0x06041DD7 RID: 269783 RVA: 0x00FF91D2 File Offset: 0x00FF73D2
		private void EndDragJoystick()
		{
			this.MoveJoysticksHandle(this.CenterPosition);
		}

		// Token: 0x06041DD8 RID: 269784 RVA: 0x00FF91E0 File Offset: 0x00FF73E0
		private void MoveJoysticksHandle(Vector touchPosition)
		{
			double num = touchPosition.X - this.CenterPosition.X;
			this.SetHandleOffset((float)num);
			this.SetInputAxis((float)num);
		}

		// Token: 0x06041DD9 RID: 269785 RVA: 0x00FF9210 File Offset: 0x00FF7410
		protected void SetHandleOffset(float targetX)
		{
			UUIDraggableComponent draggableComponent = this.DraggableComponent;
			if (draggableComponent == null)
			{
				return;
			}
			draggableComponent.RootUIComp.Get().SetAnchorOffsetX(MathUtils.Instance.Clamp(targetX, (float)(-(float)DropCatchGameplayJoystickView.MAX_OFFSET_X), (float)DropCatchGameplayJoystickView.MAX_OFFSET_X));
		}

		// Token: 0x06041DDA RID: 269786 RVA: 0x00FF9254 File Offset: 0x00FF7454
		public void SetHandleByDirection(EDropCatchRoleDirection direction)
		{
			UUIDraggableComponent draggableComponent = this.DraggableComponent;
			if (draggableComponent == null)
			{
				return;
			}
			draggableComponent.RootUIComp.Get().SetAnchorOffsetX((float)((direction == EDropCatchRoleDirection.None) ? 0 : ((direction == EDropCatchRoleDirection.Right) ? DropCatchGameplayJoystickView.MAX_OFFSET_X : (-(float)DropCatchGameplayJoystickView.MAX_OFFSET_X))));
		}

		// Token: 0x06041DDB RID: 269787 RVA: 0x00FF9298 File Offset: 0x00FF7498
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

		// Token: 0x06041DDC RID: 269788 RVA: 0x00FF932C File Offset: 0x00FF752C
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

		// Token: 0x06041DDD RID: 269789 RVA: 0x00FF93A8 File Offset: 0x00FF75A8
		public void SetInputEnabled(bool enabled)
		{
			UUIDraggableComponent draggableComponent = this.DraggableComponent;
			if (draggableComponent == null)
			{
				return;
			}
			draggableComponent.RootUIComp.Get().SetRaycastTarget(enabled);
		}

		// Token: 0x06041DDE RID: 269790 RVA: 0x00FF93D3 File Offset: 0x00FF75D3
		public void Reset()
		{
			this.SetInputEnabled(true);
		}

		// Token: 0x06041DDF RID: 269791 RVA: 0x00FF93DC File Offset: 0x00FF75DC
		protected override void OnBeforeDestroy()
		{
			this.RemoveEvents();
		}

		// Token: 0x040224EF RID: 140527
		private static readonly int MAX_OFFSET_X = 40;

		// Token: 0x040224F0 RID: 140528
		private DropCatchGameplayProxy Proxy;

		// Token: 0x040224F1 RID: 140529
		private readonly Vector PointerPosition = Vector.Create();

		// Token: 0x040224F2 RID: 140530
		private readonly Vector CenterPosition = Vector.Create(0.0, 0.0, 0.0);

		// Token: 0x040224F3 RID: 140531
		[Nullable(2)]
		private UUIDraggableComponent DraggableComponent;

		// Token: 0x040224F4 RID: 140532
		protected List<ULGUIPointerEventData> EventDataList = new List<ULGUIPointerEventData>();
	}
}
