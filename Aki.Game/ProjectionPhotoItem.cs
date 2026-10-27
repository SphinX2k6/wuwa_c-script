using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000EE8 RID: 3816
[NullableContext(2)]
[Nullable(0)]
public class ProjectionPhotoItem : UiPanelBase
{
	// Token: 0x06005F9B RID: 24475 RVA: 0x0011E41E File Offset: 0x0011C61E
	public ProjectionPhotoItem(string photoPath)
	{
	}

	// Token: 0x06005F9C RID: 24476 RVA: 0x0011E434 File Offset: 0x0011C634
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem))
		};
	}

	// Token: 0x06005F9D RID: 24477 RVA: 0x0011E4A4 File Offset: 0x0011C6A4
	protected override UniTask OnBeforeStartAsync()
	{
		ProjectionPhotoItem.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ProjectionPhotoItem.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06005F9E RID: 24478 RVA: 0x0011E4E8 File Offset: 0x0011C6E8
	protected override void OnStart()
	{
		this.ButtonRoot.OnPointerBeginDragCallBack.Bind(new Func<ULGUIPointerEventData, bool>(this.OnPointerBeginDrag));
		this.ButtonRoot.OnPointerDragCallBack.Bind(new Func<ULGUIPointerEventData, bool>(this.OnPointerDrag));
		this.ButtonRoot.OnPointerEndDragCallBack.Bind(new Func<ULGUIPointerEventData, bool>(this.OnPointerEndDrag));
		this.ButtonRoot.OnPointDownCallBack.Bind(new Action(this.OnPointDown));
		this.ButtonRoot.OnPointUpCallBack.Bind(new Action(this.OnPointUp));
	}

	// Token: 0x06005F9F RID: 24479 RVA: 0x0011E584 File Offset: 0x0011C784
	protected override void OnBeforeDestroy()
	{
		this.ButtonRoot.OnPointerBeginDragCallBack.Unbind();
		this.ButtonRoot.OnPointerDragCallBack.Unbind();
		this.ButtonRoot.OnPointerEndDragCallBack.Unbind();
		this.ButtonRoot.OnPointDownCallBack.Unbind();
		this.ButtonRoot.OnPointUpCallBack.Unbind();
	}

	// Token: 0x06005FA0 RID: 24480 RVA: 0x0011E5E4 File Offset: 0x0011C7E4
	protected override void OnAfterShow()
	{
		base.OnAfterShow();
		this.SetHidden(this.IsHidden);
		UUIButtonComponent buttonRoot = this.ButtonRoot;
		if (buttonRoot != null)
		{
			buttonRoot.SetSelfInteractive(!this.IsDisable);
		}
		UUIItem grayItem = this.GrayItem;
		if (grayItem == null)
		{
			return;
		}
		grayItem.SetUIActive(this.IsDisable);
	}

	// Token: 0x06005FA1 RID: 24481 RVA: 0x0011E634 File Offset: 0x0011C834
	public void SetDisable(bool isDisable)
	{
		this.IsDisable = isDisable;
		UUIItem grayItem = this.GrayItem;
		if (grayItem != null)
		{
			grayItem.SetUIActive(isDisable);
		}
		UUIItem disableItem = this.DisableItem;
		if (disableItem != null)
		{
			disableItem.SetUIActive(this.IsDisable);
		}
		UUIButtonComponent buttonRoot = this.ButtonRoot;
		if (buttonRoot == null)
		{
			return;
		}
		buttonRoot.SetSelfInteractive(!isDisable);
	}

	// Token: 0x06005FA2 RID: 24482 RVA: 0x0011E685 File Offset: 0x0011C885
	public void SetHidden(bool isHidden)
	{
		this.IsHidden = isHidden;
		this.RootItem.SetUIActive(!isHidden);
	}

	// Token: 0x06005FA3 RID: 24483 RVA: 0x0011E6A0 File Offset: 0x0011C8A0
	public UniTask SetPhoto(string photoPath)
	{
		ProjectionPhotoItem.<SetPhoto>d__17 <SetPhoto>d__;
		<SetPhoto>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SetPhoto>d__.<>4__this = this;
		<SetPhoto>d__.photoPath = photoPath;
		<SetPhoto>d__.<>1__state = -1;
		<SetPhoto>d__.<>t__builder.Start<ProjectionPhotoItem.<SetPhoto>d__17>(ref <SetPhoto>d__);
		return <SetPhoto>d__.<>t__builder.Task;
	}

	// Token: 0x06005FA4 RID: 24484 RVA: 0x0011E6EB File Offset: 0x0011C8EB
	private bool OnPointerBeginDrag(ULGUIPointerEventData eventData)
	{
		if (this.IsDisable || this.DragItem == null || eventData == null)
		{
			return false;
		}
		this.DragItem.StartDrag(this, this.PhotoTexture.GetTexture());
		return true;
	}

	// Token: 0x06005FA5 RID: 24485 RVA: 0x0011E71A File Offset: 0x0011C91A
	private bool OnPointerDrag(ULGUIPointerEventData eventData)
	{
		if (this.IsDisable || this.DragItem == null || eventData == null)
		{
			return false;
		}
		this.DragItem.UpdateDrag();
		return true;
	}

	// Token: 0x06005FA6 RID: 24486 RVA: 0x0011E73D File Offset: 0x0011C93D
	private bool OnPointerEndDrag(ULGUIPointerEventData eventData)
	{
		if (this.IsDisable || this.DragItem == null)
		{
			return false;
		}
		this.DragItem.StopDrag();
		return true;
	}

	// Token: 0x06005FA7 RID: 24487 RVA: 0x0011E75D File Offset: 0x0011C95D
	[NullableContext(1)]
	public void SetDragItem(ProjectionPhotoDragItem dragItem)
	{
		this.DragItem = dragItem;
	}

	// Token: 0x06005FA8 RID: 24488 RVA: 0x0011E766 File Offset: 0x0011C966
	private void OnPointDown()
	{
		EventSystem.Instance.Emit(EEventName.OnProjectionPhotoItemPointDown);
	}

	// Token: 0x06005FA9 RID: 24489 RVA: 0x0011E778 File Offset: 0x0011C978
	private void OnPointUp()
	{
		EventSystem.Instance.Emit(EEventName.OnProjectionPhotoItemPointUp);
	}

	// Token: 0x04002B4F RID: 11087
	[CompilerGenerated]
	private string <photoPath>P = photoPath;

	// Token: 0x04002B50 RID: 11088
	private UUIButtonComponent ButtonRoot;

	// Token: 0x04002B51 RID: 11089
	protected UUITexture PhotoTexture;

	// Token: 0x04002B52 RID: 11090
	private UUIItem DisableItem;

	// Token: 0x04002B53 RID: 11091
	private UUIItem GrayItem;

	// Token: 0x04002B54 RID: 11092
	private ProjectionPhotoDragItem DragItem;

	// Token: 0x04002B55 RID: 11093
	private bool IsDisable;

	// Token: 0x04002B56 RID: 11094
	private bool IsHidden = true;

	// Token: 0x02007547 RID: 30023
	[NullableContext(0)]
	private enum EViewComponent
	{
		// Token: 0x04026C7E RID: 158846
		Root,
		// Token: 0x04026C7F RID: 158847
		TexPhoto,
		// Token: 0x04026C80 RID: 158848
		PnlDisable,
		// Token: 0x04026C81 RID: 158849
		PnlGrayState
	}
}
