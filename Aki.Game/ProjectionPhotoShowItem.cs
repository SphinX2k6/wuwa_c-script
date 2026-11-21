using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;
using UnrealEngine.Extension;

// Token: 0x0200039F RID: 927
[NullableContext(2)]
[Nullable(0)]
public class ProjectionPhotoShowItem : UiPanelBase
{
	// Token: 0x06003344 RID: 13124 RVA: 0x00126658 File Offset: 0x00124858
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUISprite)),
			new ValueTuple<int, Type>(3, typeof(UUISprite)),
			new ValueTuple<int, Type>(4, typeof(UUISprite))
		};
	}

	// Token: 0x06003345 RID: 13125 RVA: 0x001266E0 File Offset: 0x001248E0
	protected override UniTask OnBeforeStartAsync()
	{
		this.ButtonRoot = base.GetButton(0);
		this.NormalSprite = base.GetSprite(2);
		this.DragInSprite = base.GetSprite(3);
		this.PutSprite = base.GetSprite(4);
		(this.ButtonRoot.GetOwner().GetComponentByClass(UUIItem.StaticClass()) as UUIItem).SetRaycastTarget(true);
		this.SetHidden(false);
		return base.OnBeforeStartAsync();
	}

	// Token: 0x06003346 RID: 13126 RVA: 0x00126754 File Offset: 0x00124954
	protected override void OnStart()
	{
		base.OnStart();
		this.ButtonRoot.OnPointEnterCallBack.Bind(new Action(this.OnPointEnter));
		this.ButtonRoot.OnPointExitCallBack.Bind(new Action(this.OnPointExit));
		EventSystem.Instance.Add(EEventName.OnProjectionPhotoItemStartDrag, new Action(this.OnProjectionPhotoItemStartDrag));
		EventSystem.Instance.Add(EEventName.OnProjectionPhotoItemEndDrag, new Action(this.OnProjectionPhotoItemEndDrag));
		EventSystem.Instance.Add(EEventName.OnProjectionPhotoItemDragCancel, new Action(this.OnPointExit));
		this.UpdateRootScaleToMatch3D();
		EventSystem.Instance.Add(EEventName.UIViewPortSizeChanged, new Action(this.OnViewPortSizeChanged));
	}

	// Token: 0x06003347 RID: 13127 RVA: 0x00126814 File Offset: 0x00124A14
	protected override void OnBeforeDestroy()
	{
		base.OnBeforeDestroy();
		this.ButtonRoot.OnPointEnterCallBack.Unbind();
		this.ButtonRoot.OnPointExitCallBack.Unbind();
		EventSystem.Instance.Remove(EEventName.OnProjectionPhotoItemStartDrag, new Action(this.OnProjectionPhotoItemStartDrag));
		EventSystem.Instance.Remove(EEventName.OnProjectionPhotoItemEndDrag, new Action(this.OnProjectionPhotoItemEndDrag));
		EventSystem.Instance.Remove(EEventName.OnProjectionPhotoItemDragCancel, new Action(this.OnPointExit));
		EventSystem.Instance.Remove(EEventName.UIViewPortSizeChanged, new Action(this.OnViewPortSizeChanged));
	}

	// Token: 0x06003348 RID: 13128 RVA: 0x001268B4 File Offset: 0x00124AB4
	protected override void OnAfterShow()
	{
		base.OnAfterShow();
		this.SetHidden(this.IsHidden);
	}

	// Token: 0x06003349 RID: 13129 RVA: 0x001268C8 File Offset: 0x00124AC8
	private void OnFinishDrag(bool inRange)
	{
		if (inRange)
		{
			this.SetState(ProjectionPhotoShowItem.State.Put);
			EventSystem.Instance.Emit(EEventName.OnProjectionPhotoFinishDrag);
			return;
		}
		this.SetState(ProjectionPhotoShowItem.State.Normal);
	}

	// Token: 0x0600334A RID: 13130 RVA: 0x001268EC File Offset: 0x00124AEC
	private void OnPointEnter()
	{
		if (!this.IsDragging)
		{
			return;
		}
		this.SetState(ProjectionPhotoShowItem.State.DragIn);
		this.InRange = true;
		Log.Instance.Info(ELogModule.LevelPlay, ELogAuthor.CH, "[ProjectionPhotoShowItem] OnPointEnter", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x0600334B RID: 13131 RVA: 0x0012692C File Offset: 0x00124B2C
	private void OnPointExit()
	{
		if (!this.IsDragging)
		{
			return;
		}
		this.SetState(ProjectionPhotoShowItem.State.Normal);
		this.InRange = false;
		Log.Instance.Info(ELogModule.LevelPlay, ELogAuthor.CH, "[ProjectionPhotoShowItem] OnPointExit", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x0600334C RID: 13132 RVA: 0x0012696C File Offset: 0x00124B6C
	public void SetHidden(bool isHidden)
	{
		this.IsHidden = isHidden;
		(this.ButtonRoot.GetOwner().GetComponentByClass(UUIItem.StaticClass()) as UUIItem).SetUIActive(!this.IsHidden);
	}

	// Token: 0x0600334D RID: 13133 RVA: 0x001269A2 File Offset: 0x00124BA2
	private void OnProjectionPhotoItemStartDrag()
	{
		this.IsDragging = true;
	}

	// Token: 0x0600334E RID: 13134 RVA: 0x001269AB File Offset: 0x00124BAB
	private void OnProjectionPhotoItemEndDrag()
	{
		this.OnFinishDrag(this.InRange);
		this.InRange = false;
		this.IsDragging = false;
	}

	// Token: 0x0600334F RID: 13135 RVA: 0x001269C8 File Offset: 0x00124BC8
	private void SetState(ProjectionPhotoShowItem.State state)
	{
		switch (state)
		{
		case ProjectionPhotoShowItem.State.Normal:
			this.NormalSprite.SetUIActive(true);
			this.DragInSprite.SetUIActive(false);
			this.PutSprite.SetUIActive(false);
			return;
		case ProjectionPhotoShowItem.State.DragIn:
			this.NormalSprite.SetUIActive(false);
			this.DragInSprite.SetUIActive(true);
			this.PutSprite.SetUIActive(false);
			return;
		case ProjectionPhotoShowItem.State.Put:
			this.NormalSprite.SetUIActive(false);
			this.DragInSprite.SetUIActive(false);
			this.PutSprite.SetUIActive(true);
			return;
		default:
			return;
		}
	}

	// Token: 0x06003350 RID: 13136 RVA: 0x00126A56 File Offset: 0x00124C56
	private void OnViewPortSizeChanged()
	{
		this.UpdateRootScaleToMatch3D();
	}

	// Token: 0x06003351 RID: 13137 RVA: 0x00126A60 File Offset: 0x00124C60
	private unsafe void UpdateRootScaleToMatch3D()
	{
		if (this.RootItem == null)
		{
			return;
		}
		UWorld world = GlobalData.World;
		if (world == null)
		{
			return;
		}
		Vector2D viewportSize = LGuiExtension.GetViewportSize();
		if (viewportSize.X <= 0.0 || viewportSize.Y <= 0.0)
		{
			return;
		}
		float num = 1.7777778f;
		double num2 = viewportSize.X / viewportSize.Y;
		double num3 = (double)num / Math.Min(num2, (double)num);
		this.RootItem.SetUIItemScale(new FVector((float)num3, (float)num3, 1f));
		Log instance = Log.Instance;
		ELogModule module = ELogModule.LevelPlay;
		ELogAuthor author = ELogAuthor.CH;
		string message = "[ProjectionPhotoShowItem] UpdateRootScaleToMatch3D";
		<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
		ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
		string item = "viewport";
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
		defaultInterpolatedStringHandler.AppendFormatted<double>(viewportSize.X);
		defaultInterpolatedStringHandler.AppendLiteral("x");
		defaultInterpolatedStringHandler.AppendFormatted<double>(viewportSize.Y);
		ptr = new ValueTuple<string, object>(item, defaultInterpolatedStringHandler.ToStringAndClear());
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("currentAspect", num2);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("baselineAspect", num);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("correction", num3);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
		string value = num2.ToString("F3");
		string value2 = num3.ToString("F3");
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
		defaultInterpolatedStringHandler.AppendFormatted<double>(viewportSize.X);
		defaultInterpolatedStringHandler.AppendLiteral("x");
		defaultInterpolatedStringHandler.AppendFormatted<double>(viewportSize.Y);
		string value3 = defaultInterpolatedStringHandler.ToStringAndClear();
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(33, 3);
		defaultInterpolatedStringHandler.AppendLiteral("[Viewport] ");
		defaultInterpolatedStringHandler.AppendFormatted(value3);
		defaultInterpolatedStringHandler.AppendLiteral("  aspect=");
		defaultInterpolatedStringHandler.AppendFormatted(value);
		defaultInterpolatedStringHandler.AppendLiteral("  correction=");
		defaultInterpolatedStringHandler.AppendFormatted(value2);
		string inString = defaultInterpolatedStringHandler.ToStringAndClear();
		UKismetSystemLibrary.PrintString(world, inString, true, false, new FLinearColor?(new FLinearColor(1f, 1f, 0f, 1f)), 5f);
	}

	// Token: 0x04002BF0 RID: 11248
	private const float BaselineWidth = 1920f;

	// Token: 0x04002BF1 RID: 11249
	private const float BaselineHeight = 1080f;

	// Token: 0x04002BF2 RID: 11250
	private const float DebugPrintDurationSec = 5f;

	// Token: 0x04002BF3 RID: 11251
	[Nullable(1)]
	private const string DebugPrintDecimals = "F3";

	// Token: 0x04002BF4 RID: 11252
	private UUIButtonComponent ButtonRoot;

	// Token: 0x04002BF5 RID: 11253
	private UUISprite NormalSprite;

	// Token: 0x04002BF6 RID: 11254
	private UUISprite DragInSprite;

	// Token: 0x04002BF7 RID: 11255
	private UUISprite PutSprite;

	// Token: 0x04002BF8 RID: 11256
	private bool IsHidden = true;

	// Token: 0x04002BF9 RID: 11257
	private bool InRange;

	// Token: 0x04002BFA RID: 11258
	private bool IsDragging;

	// Token: 0x020066DF RID: 26335
	[NullableContext(0)]
	private enum EViewComponent
	{
		// Token: 0x04021FD8 RID: 139224
		Root,
		// Token: 0x04021FD9 RID: 139225
		TexPhoto,
		// Token: 0x04021FDA RID: 139226
		SprNormal,
		// Token: 0x04021FDB RID: 139227
		SprDragIn,
		// Token: 0x04021FDC RID: 139228
		SprPut
	}

	// Token: 0x020066E0 RID: 26336
	[NullableContext(0)]
	private enum State
	{
		// Token: 0x04021FDE RID: 139230
		Normal,
		// Token: 0x04021FDF RID: 139231
		DragIn,
		// Token: 0x04021FE0 RID: 139232
		Put
	}
}
