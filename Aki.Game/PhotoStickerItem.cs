using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200257C RID: 9596
[NullableContext(1)]
[Nullable(0)]
public class PhotoStickerItem : UiPanelBase
{
	// Token: 0x0601364D RID: 79437 RVA: 0x004D3EEC File Offset: 0x004D20EC
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

	// Token: 0x0601364E RID: 79438 RVA: 0x004D3FC4 File Offset: 0x004D21C4
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

	// Token: 0x0601364F RID: 79439 RVA: 0x004D4040 File Offset: 0x004D2240
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

	// Token: 0x06013650 RID: 79440 RVA: 0x004D4101 File Offset: 0x004D2301
	private void CancelLangTextureLoad()
	{
		if (this.LangTextureHandleId != -1)
		{
			ResourceSystem.Instance.CancelAsyncLoad(this.LangTextureHandleId);
			this.LangTextureHandleId = -1;
		}
	}

	// Token: 0x06013651 RID: 79441 RVA: 0x004D4123 File Offset: 0x004D2323
	public void SetSelected(bool selected)
	{
		UUIItem item = base.GetItem(2);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(selected);
	}

	// Token: 0x06013652 RID: 79442 RVA: 0x004D4137 File Offset: 0x004D2337
	public void ChangeScaleByDelta(float delta)
	{
		this.DragController.ChangeScaleByDelta(delta);
	}

	// Token: 0x06013653 RID: 79443 RVA: 0x004D4145 File Offset: 0x004D2345
	public void MoveByDelta(float deltaX, float deltaY)
	{
		this.DragController.MoveByDelta(deltaX, deltaY);
	}

	// Token: 0x06013654 RID: 79444 RVA: 0x004D4154 File Offset: 0x004D2354
	public void SetHotKeyVisible(bool visible)
	{
		UUIItem item = base.GetItem(6);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(visible);
	}

	// Token: 0x06013655 RID: 79445 RVA: 0x004D4168 File Offset: 0x004D2368
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

	// Token: 0x06013656 RID: 79446 RVA: 0x004D4193 File Offset: 0x004D2393
	protected override void OnBeforeDestroy()
	{
		this.CancelLangTextureLoad();
		this.DragController.Dispose();
		this.BoundActor = null;
	}

	// Token: 0x06013657 RID: 79447 RVA: 0x004D41AD File Offset: 0x004D23AD
	private void OnCloseClick()
	{
		this.OnDeleteMe(this);
	}

	// Token: 0x06013658 RID: 79448 RVA: 0x004D41BB File Offset: 0x004D23BB
	public void SetBoundActor(AUIBaseActor boundActor)
	{
		this.BoundActor = boundActor;
	}

	// Token: 0x040091F7 RID: 37367
	private readonly UiTransformDragController DragController = new UiTransformDragController();

	// Token: 0x040091F8 RID: 37368
	public Action<PhotoStickerItem> OnSelectMe = delegate(PhotoStickerItem _)
	{
	};

	// Token: 0x040091F9 RID: 37369
	public Action<PhotoStickerItem> OnDeleteMe = delegate(PhotoStickerItem _)
	{
	};

	// Token: 0x040091FA RID: 37370
	[Nullable(2)]
	private AUIBaseActor BoundActor;

	// Token: 0x040091FB RID: 37371
	private int LangTextureHandleId = -1;

	// Token: 0x02008B78 RID: 35704
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x0402D4A5 RID: 185509
		DraggableRoot,
		// Token: 0x0402D4A6 RID: 185510
		TextureIcon,
		// Token: 0x0402D4A7 RID: 185511
		ItemEditState,
		// Token: 0x0402D4A8 RID: 185512
		ButtonClose,
		// Token: 0x0402D4A9 RID: 185513
		ButtonSizeCtrl,
		// Token: 0x0402D4AA RID: 185514
		LangTextureIcon,
		// Token: 0x0402D4AB RID: 185515
		ItemHotKey
	}
}
