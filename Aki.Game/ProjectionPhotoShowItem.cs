using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;
using UnrealEngine.Extension;

// Token: 0x02000EEA RID: 3818
[NullableContext(2)]
[Nullable(0)]
public class ProjectionPhotoShowItem : UiPanelBase
{
	// Token: 0x06005FAE RID: 24494 RVA: 0x0011E800 File Offset: 0x0011CA00
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

	// Token: 0x06005FAF RID: 24495 RVA: 0x0011E888 File Offset: 0x0011CA88
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

	// Token: 0x06005FB0 RID: 24496 RVA: 0x0011E8FC File Offset: 0x0011CAFC
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

	// Token: 0x06005FB1 RID: 24497 RVA: 0x0011E9BC File Offset: 0x0011CBBC
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

	// Token: 0x06005FB2 RID: 24498 RVA: 0x0011EA5C File Offset: 0x0011CC5C
	protected override void OnAfterShow()
	{
		base.OnAfterShow();
		this.SetHidden(this.IsHidden);
	}

	// Token: 0x06005FB3 RID: 24499 RVA: 0x0011EA70 File Offset: 0x0011CC70
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

	// Token: 0x06005FB4 RID: 24500 RVA: 0x0011EA94 File Offset: 0x0011CC94
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

	// Token: 0x06005FB5 RID: 24501 RVA: 0x0011EAD4 File Offset: 0x0011CCD4
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

	// Token: 0x06005FB6 RID: 24502 RVA: 0x0011EB14 File Offset: 0x0011CD14
	public void SetHidden(bool isHidden)
	{
		this.IsHidden = isHidden;
		(this.ButtonRoot.GetOwner().GetComponentByClass(UUIItem.StaticClass()) as UUIItem).SetUIActive(!this.IsHidden);
	}

	// Token: 0x06005FB7 RID: 24503 RVA: 0x0011EB4A File Offset: 0x0011CD4A
	private void OnProjectionPhotoItemStartDrag()
	{
		this.IsDragging = true;
	}

	// Token: 0x06005FB8 RID: 24504 RVA: 0x0011EB53 File Offset: 0x0011CD53
	private void OnProjectionPhotoItemEndDrag()
	{
		this.OnFinishDrag(this.InRange);
		this.InRange = false;
		this.IsDragging = false;
	}

	// Token: 0x06005FB9 RID: 24505 RVA: 0x0011EB70 File Offset: 0x0011CD70
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

	// Token: 0x06005FBA RID: 24506 RVA: 0x0011EBFE File Offset: 0x0011CDFE
	private void OnViewPortSizeChanged()
	{
		this.UpdateRootScaleToMatch3D();
	}

	// Token: 0x06005FBB RID: 24507 RVA: 0x0011EC08 File Offset: 0x0011CE08
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

	// Token: 0x04002B57 RID: 11095
	private const float BaselineWidth = 1920f;

	// Token: 0x04002B58 RID: 11096
	private const float BaselineHeight = 1080f;

	// Token: 0x04002B59 RID: 11097
	private const float DebugPrintDurationSec = 5f;

	// Token: 0x04002B5A RID: 11098
	[Nullable(1)]
	private const string DebugPrintDecimals = "F3";

	// Token: 0x04002B5B RID: 11099
	private UUIButtonComponent ButtonRoot;

	// Token: 0x04002B5C RID: 11100
	private UUISprite NormalSprite;

	// Token: 0x04002B5D RID: 11101
	private UUISprite DragInSprite;

	// Token: 0x04002B5E RID: 11102
	private UUISprite PutSprite;

	// Token: 0x04002B5F RID: 11103
	private bool IsHidden = true;

	// Token: 0x04002B60 RID: 11104
	private bool InRange;

	// Token: 0x04002B61 RID: 11105
	private bool IsDragging;

	// Token: 0x0200754B RID: 30027
	[NullableContext(0)]
	private enum EViewComponent
	{
		// Token: 0x04026C8D RID: 158861
		Root,
		// Token: 0x04026C8E RID: 158862
		TexPhoto,
		// Token: 0x04026C8F RID: 158863
		SprNormal,
		// Token: 0x04026C90 RID: 158864
		SprDragIn,
		// Token: 0x04026C91 RID: 158865
		SprPut
	}

	// Token: 0x0200754C RID: 30028
	[NullableContext(0)]
	private enum State
	{
		// Token: 0x04026C93 RID: 158867
		Normal,
		// Token: 0x04026C94 RID: 158868
		DragIn,
		// Token: 0x04026C95 RID: 158869
		Put
	}
}
