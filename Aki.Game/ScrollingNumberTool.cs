using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002B7D RID: 11133
[NullableContext(1)]
[Nullable(0)]
public class ScrollingNumberTool
{
	// Token: 0x060170F9 RID: 94457 RVA: 0x005DAEB0 File Offset: 0x005D90B0
	public UniTask InitCurve(string curveResId = "UiCurve_ScrollingTime")
	{
		ScrollingNumberTool.<InitCurve>d__9 <InitCurve>d__;
		<InitCurve>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitCurve>d__.<>4__this = this;
		<InitCurve>d__.curveResId = curveResId;
		<InitCurve>d__.<>1__state = -1;
		<InitCurve>d__.<>t__builder.Start<ScrollingNumberTool.<InitCurve>d__9>(ref <InitCurve>d__);
		return <InitCurve>d__.<>t__builder.Task;
	}

	// Token: 0x060170FA RID: 94458 RVA: 0x005DAEFB File Offset: 0x005D90FB
	public void Init(int startValue, int endValue, Action<float> onUpdateCallback, int duration = 1000)
	{
		this.RemoveTimer();
		this.OnUpdateCallback = onUpdateCallback;
		this.StartValue = (float)startValue;
		this.EndValue = (float)endValue;
		this.Duration = (float)duration;
		this.CurrentValue = (float)startValue;
		this.UpdateDisplay();
	}

	// Token: 0x060170FB RID: 94459 RVA: 0x005DAF34 File Offset: 0x005D9134
	public void StartScrolling()
	{
		this.IsScrolling = true;
		this.ElapsedTime = 0f;
		this.StartValue = this.CurrentValue;
		this.RemoveTimer();
		this.ScrollingPlayerTimer = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.Update), 20f, 1f, null, null, true);
	}

	// Token: 0x060170FC RID: 94460 RVA: 0x005DAF8E File Offset: 0x005D918E
	public void Clear()
	{
		this.UiCurveNumber = null;
		this.OnUpdateCallback = null;
		this.RemoveTimer();
	}

	// Token: 0x060170FD RID: 94461 RVA: 0x005DAFA4 File Offset: 0x005D91A4
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	private UniTask<UCurveFloat> LoadCurveFloat(string resId)
	{
		ScrollingNumberTool.<LoadCurveFloat>d__13 <LoadCurveFloat>d__;
		<LoadCurveFloat>d__.<>t__builder = AsyncUniTaskMethodBuilder<UCurveFloat>.Create();
		<LoadCurveFloat>d__.resId = resId;
		<LoadCurveFloat>d__.<>1__state = -1;
		<LoadCurveFloat>d__.<>t__builder.Start<ScrollingNumberTool.<LoadCurveFloat>d__13>(ref <LoadCurveFloat>d__);
		return <LoadCurveFloat>d__.<>t__builder.Task;
	}

	// Token: 0x060170FE RID: 94462 RVA: 0x005DAFE7 File Offset: 0x005D91E7
	private void RemoveTimer()
	{
		if (this.ScrollingPlayerTimer != null && TimerSystem.GameplayTimeInstance.Has(this.ScrollingPlayerTimer))
		{
			TimerSystem.GameplayTimeInstance.Remove(this.ScrollingPlayerTimer);
		}
		this.ScrollingPlayerTimer = null;
	}

	// Token: 0x060170FF RID: 94463 RVA: 0x005DB01C File Offset: 0x005D921C
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
		}
	}

	// Token: 0x06017100 RID: 94464 RVA: 0x005DB0C0 File Offset: 0x005D92C0
	private void UpdateDisplay()
	{
		Action<float> onUpdateCallback = this.OnUpdateCallback;
		if (onUpdateCallback == null)
		{
			return;
		}
		onUpdateCallback(this.CurrentValue);
	}

	// Token: 0x06017101 RID: 94465 RVA: 0x005DB0D8 File Offset: 0x005D92D8
	private float EaseOutQuad(float t)
	{
		return t * (2f - t);
	}

	// Token: 0x06017102 RID: 94466 RVA: 0x005DB0E3 File Offset: 0x005D92E3
	public void SetTargetNumber(int targetNumber, int? duration = null)
	{
		this.EndValue = (float)targetNumber;
		if (duration != null)
		{
			this.Duration = (float)duration.Value;
		}
		this.StartScrolling();
	}

	// Token: 0x06017103 RID: 94467 RVA: 0x005DB10A File Offset: 0x005D930A
	public float GetCurrentValue()
	{
		return this.CurrentValue;
	}

	// Token: 0x0400ACA0 RID: 44192
	[Nullable(2)]
	private UCurveFloat UiCurveNumber;

	// Token: 0x0400ACA1 RID: 44193
	[Nullable(2)]
	private TimerHandle ScrollingPlayerTimer;

	// Token: 0x0400ACA2 RID: 44194
	[Nullable(2)]
	private Action<float> OnUpdateCallback;

	// Token: 0x0400ACA3 RID: 44195
	private float StartValue;

	// Token: 0x0400ACA4 RID: 44196
	private float EndValue;

	// Token: 0x0400ACA5 RID: 44197
	private float CurrentValue;

	// Token: 0x0400ACA6 RID: 44198
	private float Duration;

	// Token: 0x0400ACA7 RID: 44199
	private float ElapsedTime;

	// Token: 0x0400ACA8 RID: 44200
	private bool IsScrolling;
}
