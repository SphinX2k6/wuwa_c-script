using System;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x02002C86 RID: 11398
public class UiModelDataComponent : UiModelComponentBase
{
	// Token: 0x06017CF3 RID: 97523 RVA: 0x0060E64A File Offset: 0x0060C84A
	public EUiModelLoadState GetModelLoadState()
	{
		return this.ModelLoadStateInternal;
	}

	// Token: 0x06017CF4 RID: 97524 RVA: 0x0060E652 File Offset: 0x0060C852
	public void SetModelLoadState(EUiModelLoadState state)
	{
		this.ModelLoadStateInternal = state;
		if (state == EUiModelLoadState.IsLoading)
		{
			EventSystem.Instance.EmitWithTarget(base.Owner, EEventName.BeforeUiModelLoadStart);
			return;
		}
		if (state == EUiModelLoadState.LoadComplete)
		{
			EventSystem.Instance.EmitWithTarget(base.Owner, EEventName.OnUiModelLoadComplete);
		}
	}

	// Token: 0x06017CF5 RID: 97525 RVA: 0x0060E690 File Offset: 0x0060C890
	public bool GetVisible()
	{
		return this.Visible;
	}

	// Token: 0x06017CF6 RID: 97526 RVA: 0x0060E698 File Offset: 0x0060C898
	public bool? GetLoadingVisible()
	{
		return this.LoadingVisible;
	}

	// Token: 0x06017CF7 RID: 97527 RVA: 0x0060E6A0 File Offset: 0x0060C8A0
	public void ClearLoadingVisible()
	{
		this.LoadingVisible = null;
	}

	// Token: 0x06017CF8 RID: 97528 RVA: 0x0060E6B0 File Offset: 0x0060C8B0
	public unsafe bool SetVisible(bool visible)
	{
		if (this.ModelLoadStateInternal == EUiModelLoadState.IsLoading)
		{
			this.LoadingVisible = new bool?(visible);
			return true;
		}
		if (this.Visible == visible)
		{
			return false;
		}
		this.Visible = visible;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.UiComponent;
		ELogAuthor author = ELogAuthor.BB;
		string message = "设置Ui模型显隐";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ModelUseWay", base.Owner.UseWay);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Visible", visible);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		base.Owner.OnVisibleChange(visible);
		return true;
	}

	// Token: 0x06017CF9 RID: 97529 RVA: 0x0060E75A File Offset: 0x0060C95A
	public float GetDitherEffectValue()
	{
		return this.DitherEffectValue;
	}

	// Token: 0x06017CFA RID: 97530 RVA: 0x0060E762 File Offset: 0x0060C962
	public void SetDitherEffect(float value)
	{
		this.DitherEffectValue = value;
		base.Owner.OnSetDitherEffect(value);
	}

	// Token: 0x06017CFB RID: 97531 RVA: 0x0060E777 File Offset: 0x0060C977
	public bool? GetPlanarReflectionRenderOffsetEnabled()
	{
		return this.PlanarReflectionRenderOffsetEnabled;
	}

	// Token: 0x06017CFC RID: 97532 RVA: 0x0060E77F File Offset: 0x0060C97F
	public FVector? GetPlanarReflectionRenderOffset()
	{
		return this.PlanarReflectionRenderOffset;
	}

	// Token: 0x06017CFD RID: 97533 RVA: 0x0060E787 File Offset: 0x0060C987
	public void SetPlanarReflectionRenderOffset(bool enable, FVector? offset)
	{
		this.PlanarReflectionRenderOffsetEnabled = new bool?(enable);
		this.PlanarReflectionRenderOffset = offset;
		base.Owner.OnPlanarReflectionRenderOffsetChange(enable, offset);
	}

	// Token: 0x06017CFE RID: 97534 RVA: 0x0060E7A9 File Offset: 0x0060C9A9
	public bool GetLoadingIconFollowState()
	{
		return this.LoadingIconFollowActor;
	}

	// Token: 0x06017CFF RID: 97535 RVA: 0x0060E7B1 File Offset: 0x0060C9B1
	public void SetLoadingIconFollowState(bool state)
	{
		this.LoadingIconFollowActor = state;
	}

	// Token: 0x0400B17D RID: 45437
	public int ModelConfigId;

	// Token: 0x0400B17E RID: 45438
	public EUiModelActorType? ModelActorType;

	// Token: 0x0400B17F RID: 45439
	public EUiModelUseWay? ModelUseWay;

	// Token: 0x0400B180 RID: 45440
	public EUiModelType? ModelType;

	// Token: 0x0400B181 RID: 45441
	private EUiModelLoadState ModelLoadStateInternal;

	// Token: 0x0400B182 RID: 45442
	private bool Visible;

	// Token: 0x0400B183 RID: 45443
	private bool? LoadingVisible;

	// Token: 0x0400B184 RID: 45444
	private float DitherEffectValue = 1f;

	// Token: 0x0400B185 RID: 45445
	private bool? PlanarReflectionRenderOffsetEnabled;

	// Token: 0x0400B186 RID: 45446
	private FVector? PlanarReflectionRenderOffset;

	// Token: 0x0400B187 RID: 45447
	private bool LoadingIconFollowActor;
}
