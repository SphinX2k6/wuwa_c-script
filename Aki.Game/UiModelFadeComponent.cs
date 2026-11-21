using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020021E2 RID: 8674
[NullableContext(2)]
[Nullable(0)]
public class UiModelFadeComponent : UiModelComponentBase
{
	// Token: 0x06015595 RID: 87445 RVA: 0x0063516F File Offset: 0x0063336F
	protected override void OnCreate()
	{
		this.Destroyed = false;
	}

	// Token: 0x06015596 RID: 87446 RVA: 0x00635178 File Offset: 0x00633378
	protected override void OnInit()
	{
		this.ModelDataComponent = base.Owner.CheckGetComponent<UiModelDataComponent>();
	}

	// Token: 0x06015597 RID: 87447 RVA: 0x0063518B File Offset: 0x0063338B
	protected override void OnEnd()
	{
		if (this.NeedTick)
		{
			UiModelDataComponent modelDataComponent = this.ModelDataComponent;
			if (modelDataComponent != null)
			{
				modelDataComponent.SetDitherEffect(this.EndValue);
			}
		}
		this.Destroyed = true;
		this.Reset();
	}

	// Token: 0x06015598 RID: 87448 RVA: 0x006351BC File Offset: 0x006333BC
	[NullableContext(1)]
	public void Fade(float startValue, float endValue, float duration, string curveId, [Nullable(2)] Action finishCallback = null)
	{
		if (this.Destroyed)
		{
			return;
		}
		this.Reset();
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(curveId);
		this.HandleId = ResourceSystem.Instance.LoadAsync<UCurveFloat>(resourcePath, delegate([Nullable(2)] UCurveFloat curve, string path)
		{
			if (curve != null)
			{
				this.FadeInternal(startValue, endValue, duration, curve, finishCallback);
			}
		}, 100, "Ui.UiSceneModel");
	}

	// Token: 0x06015599 RID: 87449 RVA: 0x00635234 File Offset: 0x00633434
	[NullableContext(1)]
	private void FadeInternal(float startValue, float endValue, float duration, UCurveFloat curve, [Nullable(2)] Action finishCallback = null)
	{
		if (this.Destroyed)
		{
			return;
		}
		this.StartValue = startValue;
		this.EndValue = endValue;
		this.Duration = duration;
		this.Curve = curve;
		this.ElapseTime = 0f;
		this.NeedTick = true;
		this.FadeFinishCallBack = finishCallback;
		UiModelDataComponent modelDataComponent = this.ModelDataComponent;
		if (modelDataComponent == null)
		{
			return;
		}
		modelDataComponent.SetDitherEffect(startValue);
	}

	// Token: 0x0601559A RID: 87450 RVA: 0x00635294 File Offset: 0x00633494
	public override void Tick(float deltaTime)
	{
		this.ElapseTime += deltaTime * 1000f;
		if (this.Curve != null)
		{
			float ditherEffect = this.Curve.GetFloatValue(this.ElapseTime / this.Duration) * (this.EndValue - this.StartValue) + this.StartValue;
			UiModelDataComponent modelDataComponent = this.ModelDataComponent;
			if (modelDataComponent != null)
			{
				modelDataComponent.SetDitherEffect(ditherEffect);
			}
		}
		if (this.ElapseTime >= this.Duration)
		{
			Action fadeFinishCallBack = this.FadeFinishCallBack;
			if (fadeFinishCallBack != null)
			{
				fadeFinishCallBack();
			}
			this.Reset();
		}
	}

	// Token: 0x0601559B RID: 87451 RVA: 0x00635322 File Offset: 0x00633522
	public void StopFade()
	{
		this.Reset();
	}

	// Token: 0x0601559C RID: 87452 RVA: 0x0063532A File Offset: 0x0063352A
	private void CancelLoad()
	{
		if (this.HandleId != -1)
		{
			ResourceSystem.Instance.CancelAsyncLoad(this.HandleId);
		}
		this.HandleId = -1;
	}

	// Token: 0x0601559D RID: 87453 RVA: 0x0063534C File Offset: 0x0063354C
	private void Reset()
	{
		this.StartValue = 0f;
		this.EndValue = 0f;
		this.Duration = 0f;
		this.Curve = null;
		this.ElapseTime = 0f;
		this.NeedTick = false;
		this.FadeFinishCallBack = null;
		this.CancelLoad();
	}

	// Token: 0x0400B50E RID: 46350
	private UiModelDataComponent ModelDataComponent;

	// Token: 0x0400B50F RID: 46351
	private float StartValue;

	// Token: 0x0400B510 RID: 46352
	private float EndValue;

	// Token: 0x0400B511 RID: 46353
	private float ElapseTime;

	// Token: 0x0400B512 RID: 46354
	private float Duration;

	// Token: 0x0400B513 RID: 46355
	private UCurveFloat Curve;

	// Token: 0x0400B514 RID: 46356
	private bool Destroyed;

	// Token: 0x0400B515 RID: 46357
	private int HandleId = -1;

	// Token: 0x0400B516 RID: 46358
	protected Action FadeFinishCallBack;
}
