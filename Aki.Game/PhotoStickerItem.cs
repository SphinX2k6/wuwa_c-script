using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001A67 RID: 6759
[NullableContext(1)]
[Nullable(0)]
public class PhotoStickerItem : UiPanelBase
{
	// Token: 0x06010B2E RID: 68398 RVA: 0x004E28BC File Offset: 0x004E0ABC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIDraggableComponent)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(5, typeof(UUILangTexture)),
			new ValueTuple<int, Type>(6, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(3, new Action(this.OnCloseClick))
		};
	}

	// Token: 0x06010B2F RID: 68399 RVA: 0x004E2994 File Offset: 0x004E0B94
	protected override void OnStart()
	{
		UUIDraggableComponent draggable = base.GetDraggable(0);
		if (draggable != null && this.BoundActor != null)
		{
			this.DragController.Init(draggable, this.BoundActor);
			this.DragController.SetScaleItem(base.GetTexture(1));
			this.DragController.EnableDrag();
			this.DragController.BindTransformButton(base.GetButton(4), false);
			draggable.OnPointerDownCallBack.Bind(delegate(ULGUIPointerEventData _)
			{
				if (!this.DragController.IsEnabled)
				{
					return;
				}
				this.OnSelectMe(this);
			});
		}
	}

	// Token: 0x06010B30 RID: 68400 RVA: 0x004E2A10 File Offset: 0x004E0C10
	public void SetData(PhotoSticker cfg)
	{
		this.DragController.SetScaleRange(cfg.MinScale, cfg.MaxScale);
		UUITexture texture = base.GetTexture(1);
		UUILangTexture langTexture = base.GetLangTexture(5);
		this.CancelLangTextureLoad();
		if (!cfg.IsMultilingual)
		{
			UUILangTexture langTexture2 = langTexture;
			if (langTexture2 != null)
			{
				langTexture2.SetLangTextureData(null);
			}
			base.SetTextureByPath(cfg.PicturePath, texture, null, delegate(bool _)
			{
				UUITexture texture = texture;
				if (texture != null)
				{
					texture.SetSizeFromTexture();
				}
				this.DragController.RefreshScaleBaseSize();
			});
			return;
		}
		this.LangTextureHandleId = ResourceSystem.Instance.LoadAsync<ULGUILangTextureData>(cfg.LangPicturePath, delegate([Nullable(2)] ULGUILangTextureData langData, string path)
		{
			this.LangTextureHandleId = -1;
			if (!langTexture.IsValid())
			{
				return;
			}
			if (langData == null || !langData.IsValid())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.PhotoCamera;
				ELogAuthor author = ELogAuthor.CXJ;
				string message = "贴纸多语言图片数据加载失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("路径", path);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			langTexture.SetLangTextureData(langData);
			UUITexture texture = texture;
			if (texture != null)
			{
				texture.SetSizeFromTexture();
			}
			this.DragController.RefreshScaleBaseSize();
		}, ResourceSystem.EResourceLoadPriority.Ui, "js_undefined");
	}

	// Token: 0x06010B31 RID: 68401 RVA: 0x004E2AD1 File Offset: 0x004E0CD1
	private void CancelLangTextureLoad()
	{
		if (this.LangTextureHandleId != -1)
		{
			ResourceSystem.Instance.CancelAsyncLoad(this.LangTextureHandleId);
			this.LangTextureHandleId = -1;
		}
	}

	// Token: 0x06010B32 RID: 68402 RVA: 0x004E2AF3 File Offset: 0x004E0CF3
	public void SetSelected(bool selected)
	{
		UUIItem item = base.GetItem(2);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(selected);
	}

	// Token: 0x06010B33 RID: 68403 RVA: 0x004E2B07 File Offset: 0x004E0D07
	public void ChangeScaleByDelta(float delta)
	{
		this.DragController.ChangeScaleByDelta(delta);
	}

	// Token: 0x06010B34 RID: 68404 RVA: 0x004E2B15 File Offset: 0x004E0D15
	public void MoveByDelta(float deltaX, float deltaY)
	{
		this.DragController.MoveByDelta(deltaX, deltaY);
	}

	// Token: 0x06010B35 RID: 68405 RVA: 0x004E2B24 File Offset: 0x004E0D24
	public void SetHotKeyVisible(bool visible)
	{
		UUIItem item = base.GetItem(6);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(visible);
	}

	// Token: 0x06010B36 RID: 68406 RVA: 0x004E2B38 File Offset: 0x004E0D38
	public void SetEditable(bool editable)
	{
		this.DragController.SetEnabled(editable);
		UUIButtonComponent button = base.GetButton(3);
		if (button != null)
		{
			button.SetSelfInteractive(editable);
		}
		if (!editable)
		{
			this.SetSelected(false);
		}
	}

	// Token: 0x06010B37 RID: 68407 RVA: 0x004E2B63 File Offset: 0x004E0D63
	protected override void OnBeforeDestroy()
	{
		this.CancelLangTextureLoad();
		this.DragController.Dispose();
		this.BoundActor = null;
	}

	// Token: 0x06010B38 RID: 68408 RVA: 0x004E2B7D File Offset: 0x004E0D7D
	private void OnCloseClick()
	{
		this.OnDeleteMe(this);
	}

	// Token: 0x06010B39 RID: 68409 RVA: 0x004E2B8B File Offset: 0x004E0D8B
	public void SetBoundActor(AUIBaseActor boundActor)
	{
		this.BoundActor = boundActor;
	}

	// Token: 0x0400934F RID: 37711
	private readonly UiTransformDragController DragController = new UiTransformDragController();

	// Token: 0x04009350 RID: 37712
	public Action<PhotoStickerItem> OnSelectMe = delegate(PhotoStickerItem _)
	{
	};

	// Token: 0x04009351 RID: 37713
	public Action<PhotoStickerItem> OnDeleteMe = delegate(PhotoStickerItem _)
	{
	};

	// Token: 0x04009352 RID: 37714
	[Nullable(2)]
	private AUIBaseActor BoundActor;

	// Token: 0x04009353 RID: 37715
	private int LangTextureHandleId = -1;

	// Token: 0x02007CFE RID: 31998
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x040287B2 RID: 165810
		DraggableRoot,
		// Token: 0x040287B3 RID: 165811
		TextureIcon,
		// Token: 0x040287B4 RID: 165812
		ItemEditState,
		// Token: 0x040287B5 RID: 165813
		ButtonClose,
		// Token: 0x040287B6 RID: 165814
		ButtonSizeCtrl,
		// Token: 0x040287B7 RID: 165815
		LangTextureIcon,
		// Token: 0x040287B8 RID: 165816
		ItemHotKey
	}
}
