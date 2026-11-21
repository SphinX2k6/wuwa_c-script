using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020020F9 RID: 8441
[NullableContext(2)]
[Nullable(0)]
public class ScrollingNumberTool
{
	// Token: 0x06014B2A RID: 84778 RVA: 0x00607A20 File Offset: 0x00605C20
	[NullableContext(1)]
	public UniTask InitCurve(string curveResId = "UiCurve_ScrollingTime")
	{
		ScrollingNumberTool.<InitCurve>d__10 <InitCurve>d__;
		<InitCurve>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitCurve>d__.<>4__this = this;
		<InitCurve>d__.curveResId = curveResId;
		<InitCurve>d__.<>1__state = -1;
		<InitCurve>d__.<>t__builder.Start<ScrollingNumberTool.<InitCurve>d__10>(ref <InitCurve>d__);
		return <InitCurve>d__.<>t__builder.Task;
	}

	// Token: 0x06014B2B RID: 84779 RVA: 0x00607A6B File Offset: 0x00605C6B
	[NullableContext(1)]
	public void Init(float startValue, float endValue, Action<float> onUpdateCallback, int duration = 1000, [Nullable(2)] Action onCompleteCallback = null)
	{
		this.RemoveTimer();
		this.OnUpdateCallback = onUpdateCallback;
		this.OnCompleteCallback = onCompleteCallback;
		this.StartValue = startValue;
		this.EndValue = endValue;
		this.Duration = (float)duration;
		this.CurrentValue = startValue;
		this.UpdateDisplay();
	}

	// Token: 0x06014B2C RID: 84780 RVA: 0x00607AA8 File Offset: 0x00605CA8
	public void StartScrolling()
	{
		this.IsScrolling = true;
		this.ElapsedTime = 0f;
		this.StartValue = this.CurrentValue;
		this.RemoveTimer();
		this.ScrollingPlayerTimer = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.Update), 20f, 1f, null, null, true);
	}

	// Token: 0x06014B2D RID: 84781 RVA: 0x00607B02 File Offset: 0x00605D02
	public void Clear()
	{
		this.UiCurveNumber = null;
		this.OnUpdateCallback = null;
		this.OnCompleteCallback = null;
		this.RemoveTimer();
	}

	// Token: 0x06014B2E RID: 84782 RVA: 0x00607B20 File Offset: 0x00605D20
	[NullableContext(1)]
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	private UniTask<UCurveFloat> LoadCurveFloat(string resId)
	{
		ScrollingNumberTool.<LoadCurveFloat>d__14 <LoadCurveFloat>d__;
		<LoadCurveFloat>d__.<>t__builder = AsyncUniTaskMethodBuilder<UCurveFloat>.Create();
		<LoadCurveFloat>d__.resId = resId;
		<LoadCurveFloat>d__.<>1__state = -1;
		<LoadCurveFloat>d__.<>t__builder.Start<ScrollingNumberTool.<LoadCurveFloat>d__14>(ref <LoadCurveFloat>d__);
		return <LoadCurveFloat>d__.<>t__builder.Task;
	}

	// Token: 0x06014B2F RID: 84783 RVA: 0x00607B63 File Offset: 0x00605D63
	private void RemoveTimer()
	{
		if (this.ScrollingPlayerTimer != null && TimerSystem.GameplayTimeInstance.Has(this.ScrollingPlayerTimer))
		{
			TimerSystem.GameplayTimeInstance.Remove(this.ScrollingPlayerTimer);
		}
		this.ScrollingPlayerTimer = null;
	}

	// Token: 0x06014B30 RID: 84784 RVA: 0x00607B98 File Offset: 0x00605D98
	private void Update(float deltaTime)
	{
		if (!this.IsScrolling)
		{
			return;
		}
		this.ElapsedTime += deltaTime;
		float num = Math.Min(this.ElapsedTime / this.Duration, 1f);
		float num2;
		if (this.UiCurveNumber != null)
		{
			num2 = this.UiCurveNumber.GetFloatValue(num);
		}
		else
		{
			num2 = this.EaseOutQuad(num);
		}
		this.CurrentValue = this.StartValue + (this.EndValue - this.StartValue) * num2;
		this.UpdateDisplay();
		if (num >= 1f)
		{
			this.RemoveTimer();
			this.IsScrolling = false;
			this.CurrentValue = this.EndValue;
			this.UpdateDisplay();
			Action onCompleteCallback = this.OnCompleteCallback;
			this.OnCompleteCallback = null;
			if (onCompleteCallback == null)
			{
				return;
			}
			onCompleteCallback();
		}
	}

	// Token: 0x06014B31 RID: 84785 RVA: 0x00607C53 File Offset: 0x00605E53
	private void UpdateDisplay()
	{
		Action<float> onUpdateCallback = this.OnUpdateCallback;
		if (onUpdateCallback == null)
		{
			return;
		}
		onUpdateCallback(this.CurrentValue);
	}

	// Token: 0x06014B32 RID: 84786 RVA: 0x00607C6B File Offset: 0x00605E6B
	private float EaseOutQuad(float t)
	{
		return t * (2f - t);
	}

	// Token: 0x06014B33 RID: 84787 RVA: 0x00607C76 File Offset: 0x00605E76
	public void SetTargetNumber(int targetNumber, int? duration = null)
	{
		this.EndValue = (float)targetNumber;
		if (duration != null)
		{
			this.Duration = (float)duration.Value;
		}
		this.StartScrolling();
	}

	// Token: 0x06014B34 RID: 84788 RVA: 0x00607C9D File Offset: 0x00605E9D
	public float GetCurrentValue()
	{
		return this.CurrentValue;
	}

	// Token: 0x0400B0A6 RID: 45222
	private UCurveFloat UiCurveNumber;

	// Token: 0x0400B0A7 RID: 45223
	private TimerHandle ScrollingPlayerTimer;

	// Token: 0x0400B0A8 RID: 45224
	private Action<float> OnUpdateCallback;

	// Token: 0x0400B0A9 RID: 45225
	private Action OnCompleteCallback;

	// Token: 0x0400B0AA RID: 45226
	private float StartValue;

	// Token: 0x0400B0AB RID: 45227
	private float EndValue;

	// Token: 0x0400B0AC RID: 45228
	private float CurrentValue;

	// Token: 0x0400B0AD RID: 45229
	private float Duration;

	// Token: 0x0400B0AE RID: 45230
	private float ElapsedTime;

	// Token: 0x0400B0AF RID: 45231
	private bool IsScrolling;
}
