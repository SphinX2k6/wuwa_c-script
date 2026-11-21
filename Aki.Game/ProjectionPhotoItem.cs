using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200039D RID: 925
[NullableContext(2)]
[Nullable(0)]
public class ProjectionPhotoItem : UiPanelBase
{
	// Token: 0x06003331 RID: 13105 RVA: 0x00126276 File Offset: 0x00124476
	public ProjectionPhotoItem(string photoPath)
	{
	}

	// Token: 0x06003332 RID: 13106 RVA: 0x0012628C File Offset: 0x0012448C
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

	// Token: 0x06003333 RID: 13107 RVA: 0x001262FC File Offset: 0x001244FC
	protected override UniTask OnBeforeStartAsync()
	{
		ProjectionPhotoItem.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ProjectionPhotoItem.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06003334 RID: 13108 RVA: 0x00126340 File Offset: 0x00124540
	protected override void OnStart()
	{
		this.ButtonRoot.OnPointerBeginDragCallBack.Bind(new Func<ULGUIPointerEventData, bool>(this.OnPointerBeginDrag));
		this.ButtonRoot.OnPointerDragCallBack.Bind(new Func<ULGUIPointerEventData, bool>(this.OnPointerDrag));
		this.ButtonRoot.OnPointerEndDragCallBack.Bind(new Func<ULGUIPointerEventData, bool>(this.OnPointerEndDrag));
		this.ButtonRoot.OnPointDownCallBack.Bind(new Action(this.OnPointDown));
		this.ButtonRoot.OnPointUpCallBack.Bind(new Action(this.OnPointUp));
	}

	// Token: 0x06003335 RID: 13109 RVA: 0x001263DC File Offset: 0x001245DC
	protected override void OnBeforeDestroy()
	{
		this.ButtonRoot.OnPointerBeginDragCallBack.Unbind();
		this.ButtonRoot.OnPointerDragCallBack.Unbind();
		this.ButtonRoot.OnPointerEndDragCallBack.Unbind();
		this.ButtonRoot.OnPointDownCallBack.Unbind();
		this.ButtonRoot.OnPointUpCallBack.Unbind();
	}

	// Token: 0x06003336 RID: 13110 RVA: 0x0012643C File Offset: 0x0012463C
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

	// Token: 0x06003337 RID: 13111 RVA: 0x0012648C File Offset: 0x0012468C
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

	// Token: 0x06003338 RID: 13112 RVA: 0x001264DD File Offset: 0x001246DD
	public void SetHidden(bool isHidden)
	{
		this.IsHidden = isHidden;
		this.RootItem.SetUIActive(!isHidden);
	}

	// Token: 0x06003339 RID: 13113 RVA: 0x001264F8 File Offset: 0x001246F8
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

	// Token: 0x0600333A RID: 13114 RVA: 0x00126543 File Offset: 0x00124743
	private bool OnPointerBeginDrag(ULGUIPointerEventData eventData)
	{
		if (this.IsDisable || this.DragItem == null || eventData == null)
		{
			return false;
		}
		this.DragItem.StartDrag(this, this.PhotoTexture.GetTexture());
		return true;
	}

	// Token: 0x0600333B RID: 13115 RVA: 0x00126572 File Offset: 0x00124772
	private bool OnPointerDrag(ULGUIPointerEventData eventData)
	{
		if (this.IsDisable || this.DragItem == null || eventData == null)
		{
			return false;
		}
		this.DragItem.UpdateDrag();
		return true;
	}

	// Token: 0x0600333C RID: 13116 RVA: 0x00126595 File Offset: 0x00124795
	private bool OnPointerEndDrag(ULGUIPointerEventData eventData)
	{
		if (this.IsDisable || this.DragItem == null)
		{
			return false;
		}
		this.DragItem.StopDrag();
		return true;
	}

	// Token: 0x0600333D RID: 13117 RVA: 0x001265B5 File Offset: 0x001247B5
	[NullableContext(1)]
	public void SetDragItem(ProjectionPhotoDragItem dragItem)
	{
		this.DragItem = dragItem;
	}

	// Token: 0x0600333E RID: 13118 RVA: 0x001265BE File Offset: 0x001247BE
	private void OnPointDown()
	{
		EventSystem.Instance.Emit(EEventName.OnProjectionPhotoItemPointDown);
	}

	// Token: 0x0600333F RID: 13119 RVA: 0x001265D0 File Offset: 0x001247D0
	private void OnPointUp()
	{
		EventSystem.Instance.Emit(EEventName.OnProjectionPhotoItemPointUp);
	}

	// Token: 0x04002BE8 RID: 11240
	[CompilerGenerated]
	private string <photoPath>P = photoPath;

	// Token: 0x04002BE9 RID: 11241
	private UUIButtonComponent ButtonRoot;

	// Token: 0x04002BEA RID: 11242
	protected UUITexture PhotoTexture;

	// Token: 0x04002BEB RID: 11243
	private UUIItem DisableItem;

	// Token: 0x04002BEC RID: 11244
	private UUIItem GrayItem;

	// Token: 0x04002BED RID: 11245
	private ProjectionPhotoDragItem DragItem;

	// Token: 0x04002BEE RID: 11246
	private bool IsDisable;

	// Token: 0x04002BEF RID: 11247
	private bool IsHidden = true;

	// Token: 0x020066DB RID: 26331
	[NullableContext(0)]
	private enum EViewComponent
	{
		// Token: 0x04021FC9 RID: 139209
		Root,
		// Token: 0x04021FCA RID: 139210
		TexPhoto,
		// Token: 0x04021FCB RID: 139211
		PnlDisable,
		// Token: 0x04021FCC RID: 139212
		PnlGrayState
	}
}
