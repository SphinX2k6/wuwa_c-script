using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000EE7 RID: 3815
[NullableContext(1)]
[Nullable(0)]
public class ProjectionPhotoDragItem : ProjectionPhotoItem
{
	// Token: 0x06005F96 RID: 24470 RVA: 0x0011E2CA File Offset: 0x0011C4CA
	[NullableContext(2)]
	public ProjectionPhotoDragItem(string photoPath) : base(photoPath)
	{
	}

	// Token: 0x06005F97 RID: 24471 RVA: 0x0011E2D3 File Offset: 0x0011C4D3
	protected override void OnAfterShow()
	{
		base.OnAfterShow();
		UUIItem rootItem = this.RootItem;
		if (rootItem == null)
		{
			return;
		}
		rootItem.SetRaycastTarget(false);
	}

	// Token: 0x06005F98 RID: 24472 RVA: 0x0011E2EC File Offset: 0x0011C4EC
	public void StartDrag(ProjectionPhotoItem projectionPhotoItem, UTexture texture)
	{
		if (this._ownerItem != projectionPhotoItem && this._ownerItem != null)
		{
			Log.Instance.Error(ELogModule.SceneGameplay, ELogAuthor.CH, "[ProjectionPhotoDragItem.StartDrag]开始拖拽失败，当前已经在拖拽中", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this._ownerItem = projectionPhotoItem;
		this.PhotoTexture.SetTexture(texture);
		this.UpdateDrag();
		base.SetHidden(false);
		AudioSystem.Instance.PostEvent("play_interact_Camera_ui_photo_pickup");
		EventSystem.Instance.Emit(EEventName.OnProjectionPhotoItemStartDrag);
	}

	// Token: 0x06005F99 RID: 24473 RVA: 0x0011E368 File Offset: 0x0011C568
	public void UpdateDrag()
	{
		if (this._ownerItem == null)
		{
			return;
		}
		FVector? pointerEventDataPosition = LguiEventSystemManager.Instance.GetPointerEventDataPosition(0);
		if (pointerEventDataPosition == null)
		{
			return;
		}
		FVector2D fvector2D = new FVector2D(pointerEventDataPosition.Value.X, pointerEventDataPosition.Value.Y);
		FVector2D fvector2D2 = UiLayer.Instance.UiRootItem.GetCanvasScaler().ConvertPositionFromViewportToLGUICanvas(fvector2D);
		UUIItem rootItem = this.RootItem;
		FVector fvector = new FVector(fvector2D2.X, fvector2D2.Y, 0f);
		rootItem.SetLGUISpaceAbsolutePosition(fvector);
	}

	// Token: 0x06005F9A RID: 24474 RVA: 0x0011E3EE File Offset: 0x0011C5EE
	public void StopDrag()
	{
		this._ownerItem = null;
		base.SetHidden(true);
		AudioSystem.Instance.PostEvent("play_interact_Camera_ui_photo_putdown");
		EventSystem.Instance.Emit(EEventName.OnProjectionPhotoItemEndDrag);
	}

	// Token: 0x04002B4C RID: 11084
	private const string START_DRAG_EVENT = "play_interact_Camera_ui_photo_pickup";

	// Token: 0x04002B4D RID: 11085
	private const string STOP_DRAG_EVENT = "play_interact_Camera_ui_photo_putdown";

	// Token: 0x04002B4E RID: 11086
	[Nullable(2)]
	private ProjectionPhotoItem _ownerItem;
}
