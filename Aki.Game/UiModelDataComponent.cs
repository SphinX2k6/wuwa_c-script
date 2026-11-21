using System;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x020021DF RID: 8671
public class UiModelDataComponent : UiModelComponentBase
{
	// Token: 0x06015566 RID: 87398 RVA: 0x00634112 File Offset: 0x00632312
	public EUiModelLoadState GetModelLoadState()
	{
		return this.ModelLoadStateInternal;
	}

	// Token: 0x06015567 RID: 87399 RVA: 0x0063411A File Offset: 0x0063231A
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

	// Token: 0x06015568 RID: 87400 RVA: 0x00634158 File Offset: 0x00632358
	public bool GetVisible()
	{
		return this.Visible;
	}

	// Token: 0x06015569 RID: 87401 RVA: 0x00634160 File Offset: 0x00632360
	public bool? GetLoadingVisible()
	{
		return this.LoadingVisible;
	}

	// Token: 0x0601556A RID: 87402 RVA: 0x00634168 File Offset: 0x00632368
	public void ClearLoadingVisible()
	{
		this.LoadingVisible = null;
	}

	// Token: 0x0601556B RID: 87403 RVA: 0x00634178 File Offset: 0x00632378
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

	// Token: 0x0601556C RID: 87404 RVA: 0x00634222 File Offset: 0x00632422
	public float GetDitherEffectValue()
	{
		return this.DitherEffectValue;
	}

	// Token: 0x0601556D RID: 87405 RVA: 0x0063422A File Offset: 0x0063242A
	public void SetDitherEffect(float value)
	{
		this.DitherEffectValue = value;
		base.Owner.OnSetDitherEffect(value);
	}

	// Token: 0x0601556E RID: 87406 RVA: 0x0063423F File Offset: 0x0063243F
	public bool? GetPlanarReflectionRenderOffsetEnabled()
	{
		return this.PlanarReflectionRenderOffsetEnabled;
	}

	// Token: 0x0601556F RID: 87407 RVA: 0x00634247 File Offset: 0x00632447
	public FVector? GetPlanarReflectionRenderOffset()
	{
		return this.PlanarReflectionRenderOffset;
	}

	// Token: 0x06015570 RID: 87408 RVA: 0x0063424F File Offset: 0x0063244F
	public void SetPlanarReflectionRenderOffset(bool enable, FVector? offset)
	{
		this.PlanarReflectionRenderOffsetEnabled = new bool?(enable);
		this.PlanarReflectionRenderOffset = offset;
		base.Owner.OnPlanarReflectionRenderOffsetChange(enable, offset);
	}

	// Token: 0x06015571 RID: 87409 RVA: 0x00634271 File Offset: 0x00632471
	public bool GetLoadingIconFollowState()
	{
		return this.LoadingIconFollowActor;
	}

	// Token: 0x06015572 RID: 87410 RVA: 0x00634279 File Offset: 0x00632479
	public void SetLoadingIconFollowState(bool state)
	{
		this.LoadingIconFollowActor = state;
	}

	// Token: 0x0400B4E8 RID: 46312
	public int ModelConfigId;

	// Token: 0x0400B4E9 RID: 46313
	public EUiModelActorType? ModelActorType;

	// Token: 0x0400B4EA RID: 46314
	public EUiModelUseWay? ModelUseWay;

	// Token: 0x0400B4EB RID: 46315
	public EUiModelType? ModelType;

	// Token: 0x0400B4EC RID: 46316
	private EUiModelLoadState ModelLoadStateInternal;

	// Token: 0x0400B4ED RID: 46317
	private bool Visible;

	// Token: 0x0400B4EE RID: 46318
	private bool? LoadingVisible;

	// Token: 0x0400B4EF RID: 46319
	private float DitherEffectValue = 1f;

	// Token: 0x0400B4F0 RID: 46320
	private bool? PlanarReflectionRenderOffsetEnabled;

	// Token: 0x0400B4F1 RID: 46321
	private FVector? PlanarReflectionRenderOffset;

	// Token: 0x0400B4F2 RID: 46322
	private bool LoadingIconFollowActor;
}
