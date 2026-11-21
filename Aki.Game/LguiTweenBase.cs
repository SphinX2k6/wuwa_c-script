using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002235 RID: 8757
[NullableContext(1)]
[Nullable(0)]
public abstract class LguiTweenBase<[Nullable(2)] T>
{
	// Token: 0x06015A07 RID: 88583 RVA: 0x00646B41 File Offset: 0x00644D41
	protected void PlayFillAmount(T value)
	{
		Action<T> updateTween = this.UpdateTween;
		if (updateTween == null)
		{
			return;
		}
		updateTween(value);
	}

	// Token: 0x06015A08 RID: 88584 RVA: 0x00646B54 File Offset: 0x00644D54
	private void PlayTweenStart()
	{
		Action startTween = this.StartTween;
		if (startTween == null)
		{
			return;
		}
		startTween();
	}

	// Token: 0x06015A09 RID: 88585 RVA: 0x00646B66 File Offset: 0x00644D66
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

	// Token: 0x06015A0A RID: 88586 RVA: 0x00646B88 File Offset: 0x00644D88
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

	// Token: 0x06015A0B RID: 88587 RVA: 0x00646C11 File Offset: 0x00644E11
	public void SetCurrentEase(LTweenEase ease)
	{
		if (this.Tweener != null)
		{
			this.Tweener.SetEase(ease);
		}
	}

	// Token: 0x06015A0C RID: 88588 RVA: 0x00646C28 File Offset: 0x00644E28
	[NullableContext(2)]
	public ULTweener GetTweener()
	{
		return this.Tweener;
	}

	// Token: 0x06015A0D RID: 88589 RVA: 0x00646C30 File Offset: 0x00644E30
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

	// Token: 0x06015A0E RID: 88590 RVA: 0x00646C6D File Offset: 0x00644E6D
	public void BindStartTween(Action startTween)
	{
		this.StartTween = startTween;
	}

	// Token: 0x06015A0F RID: 88591 RVA: 0x00646C76 File Offset: 0x00644E76
	public void BindUpdateTween(Action<T> updateTween)
	{
		this.UpdateTween = updateTween;
	}

	// Token: 0x06015A10 RID: 88592 RVA: 0x00646C7F File Offset: 0x00644E7F
	public void BindCompleteTween(Action completeTween)
	{
		this.CompleteTween = completeTween;
	}

	// Token: 0x06015A11 RID: 88593 RVA: 0x00646C88 File Offset: 0x00644E88
	public void Destroy()
	{
		this.KillTween();
		this.OnDestroy();
	}

	// Token: 0x06015A12 RID: 88594 RVA: 0x00646C96 File Offset: 0x00644E96
	protected virtual void OnDestroy()
	{
	}

	// Token: 0x06015A13 RID: 88595
	[return: Nullable(2)]
	protected abstract ULTweener CreateTween(T start, T end, float time);

	// Token: 0x0400B6B0 RID: 46768
	public bool IsFinished;

	// Token: 0x0400B6B1 RID: 46769
	[Nullable(2)]
	protected ULTweener Tweener;

	// Token: 0x0400B6B2 RID: 46770
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<T> UpdateTween;

	// Token: 0x0400B6B3 RID: 46771
	[Nullable(2)]
	public Action StartTween;

	// Token: 0x0400B6B4 RID: 46772
	[Nullable(2)]
	public Action CompleteTween;
}
