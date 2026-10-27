using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002C89 RID: 11401
[NullableContext(2)]
[Nullable(0)]
public class UiModelFadeComponent : UiModelComponentBase
{
	// Token: 0x06017D22 RID: 97570 RVA: 0x0060F69F File Offset: 0x0060D89F
	protected override void OnCreate()
	{
		this.Destroyed = false;
	}

	// Token: 0x06017D23 RID: 97571 RVA: 0x0060F6A8 File Offset: 0x0060D8A8
	protected override void OnInit()
	{
		this.ModelDataComponent = base.Owner.CheckGetComponent<UiModelDataComponent>();
	}

	// Token: 0x06017D24 RID: 97572 RVA: 0x0060F6BB File Offset: 0x0060D8BB
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

	// Token: 0x06017D25 RID: 97573 RVA: 0x0060F6EC File Offset: 0x0060D8EC
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

	// Token: 0x06017D26 RID: 97574 RVA: 0x0060F764 File Offset: 0x0060D964
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

	// Token: 0x06017D27 RID: 97575 RVA: 0x0060F7C4 File Offset: 0x0060D9C4
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

	// Token: 0x06017D28 RID: 97576 RVA: 0x0060F852 File Offset: 0x0060DA52
	public void StopFade()
	{
		this.Reset();
	}

	// Token: 0x06017D29 RID: 97577 RVA: 0x0060F85A File Offset: 0x0060DA5A
	private void CancelLoad()
	{
		if (this.HandleId != -1)
		{
			ResourceSystem.Instance.CancelAsyncLoad(this.HandleId);
		}
		this.HandleId = -1;
	}

	// Token: 0x06017D2A RID: 97578 RVA: 0x0060F87C File Offset: 0x0060DA7C
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

	// Token: 0x0400B1A3 RID: 45475
	private UiModelDataComponent ModelDataComponent;

	// Token: 0x0400B1A4 RID: 45476
	private float StartValue;

	// Token: 0x0400B1A5 RID: 45477
	private float EndValue;

	// Token: 0x0400B1A6 RID: 45478
	private float ElapseTime;

	// Token: 0x0400B1A7 RID: 45479
	private float Duration;

	// Token: 0x0400B1A8 RID: 45480
	private UCurveFloat Curve;

	// Token: 0x0400B1A9 RID: 45481
	private bool Destroyed;

	// Token: 0x0400B1AA RID: 45482
	private int HandleId = -1;

	// Token: 0x0400B1AB RID: 45483
	protected Action FadeFinishCallBack;
}
