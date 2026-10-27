using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002CDC RID: 11484
[NullableContext(1)]
[Nullable(0)]
public abstract class LguiTweenBase<[Nullable(2)] T>
{
	// Token: 0x06018189 RID: 98697 RVA: 0x00620ED5 File Offset: 0x0061F0D5
	protected void PlayFillAmount(T value)
	{
		Action<T> updateTween = this.UpdateTween;
		if (updateTween == null)
		{
			return;
		}
		updateTween(value);
	}

	// Token: 0x0601818A RID: 98698 RVA: 0x00620EE8 File Offset: 0x0061F0E8
	private void PlayTweenStart()
	{
		Action startTween = this.StartTween;
		if (startTween == null)
		{
			return;
		}
		startTween();
	}

	// Token: 0x0601818B RID: 98699 RVA: 0x00620EFA File Offset: 0x0061F0FA
	private void PlayTweenComplete()
	{
		this.IsFinished = true;
		this.KillTween();
		Action completeTween = this.CompleteTween;
		if (completeTween == null)
		{
			return;
		}
		completeTween();
	}

	// Token: 0x0601818C RID: 98700 RVA: 0x00620F1C File Offset: 0x0061F11C
	public void PlayTween(T start, T end, float time, [Nullable(2)] UCurveFloat curve = null)
	{
		this.IsFinished = false;
		this.KillTween();
		this.Tweener = this.CreateTween(start, end, time);
		if (this.Tweener != null)
		{
			if (curve != null)
			{
				this.Tweener.SetEase(LTweenEase.CurveFloat);
				this.Tweener.SetCurveFloat(curve);
			}
			this.Tweener.OnStartCallBack.Bind(new Action(this.PlayTweenStart));
			this.Tweener.OnCompleteCallBack.Bind(new Action(this.PlayTweenComplete));
		}
	}

	// Token: 0x0601818D RID: 98701 RVA: 0x00620FA5 File Offset: 0x0061F1A5
	public void SetCurrentEase(LTweenEase ease)
	{
		if (this.Tweener != null)
		{
			this.Tweener.SetEase(ease);
		}
	}

	// Token: 0x0601818E RID: 98702 RVA: 0x00620FBC File Offset: 0x0061F1BC
	public void KillTween()
	{
		if (this.Tweener != null)
		{
			this.Tweener.Kill(false);
			this.Tweener.OnStartCallBack.Unbind();
			this.Tweener.OnCompleteCallBack.Unbind();
			this.Tweener = null;
		}
	}

	// Token: 0x0601818F RID: 98703 RVA: 0x00620FF9 File Offset: 0x0061F1F9
	public void BindStartTween(Action startTween)
	{
		this.StartTween = startTween;
	}

	// Token: 0x06018190 RID: 98704 RVA: 0x00621002 File Offset: 0x0061F202
	public void BindUpdateTween(Action<T> updateTween)
	{
		this.UpdateTween = updateTween;
	}

	// Token: 0x06018191 RID: 98705 RVA: 0x0062100B File Offset: 0x0061F20B
	public void BindCompleteTween(Action completeTween)
	{
		this.CompleteTween = completeTween;
	}

	// Token: 0x06018192 RID: 98706 RVA: 0x00621014 File Offset: 0x0061F214
	public void Destroy()
	{
		this.KillTween();
		this.OnDestroy();
	}

	// Token: 0x06018193 RID: 98707 RVA: 0x00621022 File Offset: 0x0061F222
	protected virtual void OnDestroy()
	{
	}

	// Token: 0x06018194 RID: 98708
	[return: Nullable(2)]
	protected abstract ULTweener CreateTween(T start, T end, float time);

	// Token: 0x0400B344 RID: 45892
	public bool IsFinished;

	// Token: 0x0400B345 RID: 45893
	[Nullable(2)]
	protected ULTweener Tweener;

	// Token: 0x0400B346 RID: 45894
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<T> UpdateTween;

	// Token: 0x0400B347 RID: 45895
	[Nullable(2)]
	public Action StartTween;

	// Token: 0x0400B348 RID: 45896
	[Nullable(2)]
	public Action CompleteTween;
}
