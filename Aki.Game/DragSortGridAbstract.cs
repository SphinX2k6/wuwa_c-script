using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020022BF RID: 8895
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public abstract class DragSortGridAbstract<TData> : GridProxyAbstract<TData>
{
	// Token: 0x0601174D RID: 71501
	protected abstract UUIDraggableComponent GetDraggableComp();

	// Token: 0x0601174E RID: 71502 RVA: 0x004472F0 File Offset: 0x004454F0
	protected override void OnStart()
	{
		UUIDraggableComponent draggableComp = this.GetDraggableComp();
		if (draggableComp != null)
		{
			draggableComp.OnPointerDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnDrag));
			draggableComp.OnPointerBeginDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnDragBegin));
			draggableComp.OnPointerEndDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnDragEnd));
			draggableComp.OnPointerDownCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerDown));
			draggableComp.OnPointerUpCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerUp));
			draggableComp.OnPointerCancelCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerCancel));
		}
		this.OnStartImplement();
	}

	// Token: 0x0601174F RID: 71503 RVA: 0x0044739A File Offset: 0x0044559A
	private void OnDragBegin(ULGUIPointerEventData data)
	{
		Action<DragSortGridAbstract<TData>> onDragBeginCallback = this.OnDragBeginCallback;
		if (onDragBeginCallback == null)
		{
			return;
		}
		onDragBeginCallback(this);
	}

	// Token: 0x06011750 RID: 71504 RVA: 0x004473AD File Offset: 0x004455AD
	private void OnDragEnd(ULGUIPointerEventData data)
	{
		Action<DragSortGridAbstract<TData>> onDragEndCallback = this.OnDragEndCallback;
		if (onDragEndCallback == null)
		{
			return;
		}
		onDragEndCallback(this);
	}

	// Token: 0x06011751 RID: 71505 RVA: 0x004473C0 File Offset: 0x004455C0
	private void OnDrag(ULGUIPointerEventData eventData)
	{
		Action<DragSortGridAbstract<TData>> onDragCallback = this.OnDragCallback;
		if (onDragCallback == null)
		{
			return;
		}
		onDragCallback(this);
	}

	// Token: 0x06011752 RID: 71506 RVA: 0x004473D3 File Offset: 0x004455D3
	private void OnPointerDown(ULGUIPointerEventData data)
	{
		Action<DragSortGridAbstract<TData>> onPointerDownCallback = this.OnPointerDownCallback;
		if (onPointerDownCallback == null)
		{
			return;
		}
		onPointerDownCallback(this);
	}

	// Token: 0x06011753 RID: 71507 RVA: 0x004473E6 File Offset: 0x004455E6
	private void OnPointerUp(ULGUIPointerEventData data)
	{
		Action<DragSortGridAbstract<TData>> onPointerUpCallback = this.OnPointerUpCallback;
		if (onPointerUpCallback == null)
		{
			return;
		}
		onPointerUpCallback(this);
	}

	// Token: 0x06011754 RID: 71508 RVA: 0x004473F9 File Offset: 0x004455F9
	private void OnPointerCancel(ULGUIPointerEventData data)
	{
		Action<DragSortGridAbstract<TData>> onPointerUpCallback = this.OnPointerUpCallback;
		if (onPointerUpCallback == null)
		{
			return;
		}
		onPointerUpCallback(this);
	}

	// Token: 0x06011755 RID: 71509 RVA: 0x0044740C File Offset: 0x0044560C
	public void RefreshDragPosition()
	{
		FVector? pointerEventDataPosition = LguiEventSystemManager.Instance.GetPointerEventDataPosition(0);
		Vector2D vector2D = Vector2D.Create((double)((pointerEventDataPosition != null) ? pointerEventDataPosition.GetValueOrDefault().X : 0f), (double)((pointerEventDataPosition != null) ? pointerEventDataPosition.GetValueOrDefault().Y : 0f));
		if (UiLayer.Instance.UiRootItem != null && UiLayer.Instance.UiRootItem.GetRootCanvas() != null)
		{
			Vector2D vector2D2 = vector2D;
			ULGUICanvasScaler canvasScaler = UiLayer.Instance.UiRootItem.GetCanvasScaler();
			FVector2D fvector2D = vector2D.ToUeVector2D(false);
			vector2D2.FromUeVector2D(canvasScaler.ConvertPositionFromViewportToLGUICanvas(fvector2D));
		}
		float inY = (float)vector2D.Y;
		UUIItem rootItem = this.RootItem;
		if (rootItem == null)
		{
			return;
		}
		FVector fvector = new FVector(this.RootItem.GetLGUISpaceAbsolutePosition().X, inY, 0f);
		rootItem.SetLGUISpaceAbsolutePosition(fvector);
	}

	// Token: 0x04008494 RID: 33940
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public Action<DragSortGridAbstract<TData>> OnDragCallback;

	// Token: 0x04008495 RID: 33941
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public Action<DragSortGridAbstract<TData>> OnDragBeginCallback;

	// Token: 0x04008496 RID: 33942
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public Action<DragSortGridAbstract<TData>> OnDragEndCallback;

	// Token: 0x04008497 RID: 33943
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public Action<DragSortGridAbstract<TData>> OnPointerDownCallback;

	// Token: 0x04008498 RID: 33944
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public Action<DragSortGridAbstract<TData>> OnPointerUpCallback;

	// Token: 0x04008499 RID: 33945
	public DragSortGridData DragData;
}
