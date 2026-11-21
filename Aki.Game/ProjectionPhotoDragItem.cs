using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200039C RID: 924
[NullableContext(1)]
[Nullable(0)]
public class ProjectionPhotoDragItem : ProjectionPhotoItem
{
	// Token: 0x0600332C RID: 13100 RVA: 0x00126122 File Offset: 0x00124322
	[NullableContext(2)]
	public ProjectionPhotoDragItem(string photoPath) : base(photoPath)
	{
	}

	// Token: 0x0600332D RID: 13101 RVA: 0x0012612B File Offset: 0x0012432B
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

	// Token: 0x0600332E RID: 13102 RVA: 0x00126144 File Offset: 0x00124344
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

	// Token: 0x0600332F RID: 13103 RVA: 0x001261C0 File Offset: 0x001243C0
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

	// Token: 0x06003330 RID: 13104 RVA: 0x00126246 File Offset: 0x00124446
	public void StopDrag()
	{
		this._ownerItem = null;
		base.SetHidden(true);
		AudioSystem.Instance.PostEvent("play_interact_Camera_ui_photo_putdown");
		EventSystem.Instance.Emit(EEventName.OnProjectionPhotoItemEndDrag);
	}

	// Token: 0x04002BE5 RID: 11237
	private const string START_DRAG_EVENT = "play_interact_Camera_ui_photo_pickup";

	// Token: 0x04002BE6 RID: 11238
	private const string STOP_DRAG_EVENT = "play_interact_Camera_ui_photo_putdown";

	// Token: 0x04002BE7 RID: 11239
	[Nullable(2)]
	private ProjectionPhotoItem _ownerItem;
}
