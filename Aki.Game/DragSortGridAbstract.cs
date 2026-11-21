using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020017A3 RID: 6051
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public abstract class DragSortGridAbstract<TData> : GridProxyAbstract<TData>
{
	// Token: 0x0600EBE5 RID: 60389
	protected abstract UUIDraggableComponent GetDraggableComp();

	// Token: 0x0600EBE6 RID: 60390 RVA: 0x00453F48 File Offset: 0x00452148
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

	// Token: 0x0600EBE7 RID: 60391 RVA: 0x00453FF2 File Offset: 0x004521F2
	private void OnDragBegin(ULGUIPointerEventData data)
	{
		Action<DragSortGridAbstract<TData>> onDragBeginCallback = this.OnDragBeginCallback;
		if (onDragBeginCallback == null)
		{
			return;
		}
		onDragBeginCallback(this);
	}

	// Token: 0x0600EBE8 RID: 60392 RVA: 0x00454005 File Offset: 0x00452205
	private void OnDragEnd(ULGUIPointerEventData data)
	{
		Action<DragSortGridAbstract<TData>> onDragEndCallback = this.OnDragEndCallback;
		if (onDragEndCallback == null)
		{
			return;
		}
		onDragEndCallback(this);
	}

	// Token: 0x0600EBE9 RID: 60393 RVA: 0x00454018 File Offset: 0x00452218
	private void OnDrag(ULGUIPointerEventData eventData)
	{
		Action<DragSortGridAbstract<TData>> onDragCallback = this.OnDragCallback;
		if (onDragCallback == null)
		{
			return;
		}
		onDragCallback(this);
	}

	// Token: 0x0600EBEA RID: 60394 RVA: 0x0045402B File Offset: 0x0045222B
	private void OnPointerDown(ULGUIPointerEventData data)
	{
		Action<DragSortGridAbstract<TData>> onPointerDownCallback = this.OnPointerDownCallback;
		if (onPointerDownCallback == null)
		{
			return;
		}
		onPointerDownCallback(this);
	}

	// Token: 0x0600EBEB RID: 60395 RVA: 0x0045403E File Offset: 0x0045223E
	private void OnPointerUp(ULGUIPointerEventData data)
	{
		Action<DragSortGridAbstract<TData>> onPointerUpCallback = this.OnPointerUpCallback;
		if (onPointerUpCallback == null)
		{
			return;
		}
		onPointerUpCallback(this);
	}

	// Token: 0x0600EBEC RID: 60396 RVA: 0x00454051 File Offset: 0x00452251
	private void OnPointerCancel(ULGUIPointerEventData data)
	{
		Action<DragSortGridAbstract<TData>> onPointerUpCallback = this.OnPointerUpCallback;
		if (onPointerUpCallback == null)
		{
			return;
		}
		onPointerUpCallback(this);
	}

	// Token: 0x0600EBED RID: 60397 RVA: 0x00454064 File Offset: 0x00452264
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

	// Token: 0x040085D2 RID: 34258
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public Action<DragSortGridAbstract<TData>> OnDragCallback;

	// Token: 0x040085D3 RID: 34259
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public Action<DragSortGridAbstract<TData>> OnDragBeginCallback;

	// Token: 0x040085D4 RID: 34260
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public Action<DragSortGridAbstract<TData>> OnDragEndCallback;

	// Token: 0x040085D5 RID: 34261
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public Action<DragSortGridAbstract<TData>> OnPointerDownCallback;

	// Token: 0x040085D6 RID: 34262
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public Action<DragSortGridAbstract<TData>> OnPointerUpCallback;

	// Token: 0x040085D7 RID: 34263
	public DragSortGridData DragData;
}
