using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001823 RID: 6179
[NullableContext(2)]
[Nullable(0)]
public class ExpTweenComponent
{
	// Token: 0x0600B559 RID: 46425 RVA: 0x0028F444 File Offset: 0x0028D644
	[NullableContext(1)]
	public ExpTweenComponent(UUISprite currentSprite, UUISprite addSprite, UUISprite nextSprite, [Nullable(2)] UUIItem parent, [Nullable(2)] Action tweenFinishFunction = null)
	{
		this.AddSprite = addSprite;
		this.CurrentSprite = currentSprite;
		this.NextSprite = nextSprite;
		this.TweenFinishFunction = tweenFinishFunction;
		this.Delegate = DelegateUtils.ToManualReleaseDelegate<FLTweenFloatSetterDynamic>(new Action<float>(this.PlayFillAmount));
		this.PreviewDelegate = DelegateUtils.ToManualReleaseDelegate<FLTweenFloatSetterDynamic>(new Action<float>(this.PlayPreviewFillAmount));
	}

	// Token: 0x0600B55A RID: 46426 RVA: 0x0028F4C0 File Offset: 0x0028D6C0
	protected void PlayTween(int currentCount, int targetCount, float time, float delay = 0f, LTweenEase ease = LTweenEase.Linear)
	{
		float startValue = (currentCount == 1) ? this.CurrentSprite.GetFillAmount() : 0f;
		float num = (currentCount == targetCount) ? this.FinalFillAmount : 1f;
		if (currentCount == targetCount)
		{
			this.AddSprite.SetFillAmount(num);
		}
		UiLayer.Instance.SetShowMaskLayer("ExpTweenComponent", true);
		this.ExpTweener = ULTweenBPLibrary.FloatTo(GlobalData.World, this.Delegate, startValue, num, time, delay, ease);
		this.ExpTweener.OnCompleteCallBack.Bind(delegate()
		{
			this.TweenCompleteCallBack(currentCount, targetCount, time, delay, ease);
		});
	}

	// Token: 0x0600B55B RID: 46427 RVA: 0x0028F5A8 File Offset: 0x0028D7A8
	protected void TweenCompleteCallBack(int currentCount, int targetCount, float time, float delay = 0f, LTweenEase ease = LTweenEase.Linear)
	{
		this.KillExpTweener();
		if (this.PlayCompleteCallBack != null)
		{
			this.PlayCompleteCallBack(currentCount == targetCount);
		}
		if (currentCount < targetCount)
		{
			this.PlayTween(currentCount + 1, targetCount, time, delay, ease);
			return;
		}
		UiLayer.Instance.SetShowMaskLayer("ExpTweenComponent", false);
		if (this.TweenFinishFunction != null)
		{
			this.TweenFinishFunction();
		}
	}

	// Token: 0x0600B55C RID: 46428 RVA: 0x0028F609 File Offset: 0x0028D809
	protected void PlayFillAmount(float value)
	{
		this.SetCurrentFillAmount(value);
	}

	// Token: 0x0600B55D RID: 46429 RVA: 0x0028F612 File Offset: 0x0028D812
	protected void KillExpTweener()
	{
		if (this.ExpTweener != null)
		{
			this.ExpTweener.Kill(false);
			this.ExpTweener = null;
		}
	}

	// Token: 0x0600B55E RID: 46430 RVA: 0x0028F630 File Offset: 0x0028D830
	protected void PlayPreviewTween(float start, float end, float time, bool needAgain)
	{
		this.PreviewExpTweener = ULTweenBPLibrary.FloatTo(GlobalData.World, this.PreviewDelegate, start, end, time, 0f, LTweenEase.OutCubic);
		this.PreviewExpTweener.OnCompleteCallBack.Bind(delegate()
		{
			this.PreviewTweenCompleteCallBack(time, needAgain);
		});
	}

	// Token: 0x0600B55F RID: 46431 RVA: 0x0028F699 File Offset: 0x0028D899
	protected void PreviewTweenCompleteCallBack(float playTime, bool needAgain)
	{
		this.KillPreviewExpTweener(false);
		if (needAgain)
		{
			this.PreviewTweenPlayAgainState(playTime);
			return;
		}
		this.PreviewTweenStopState();
	}

	// Token: 0x0600B560 RID: 46432 RVA: 0x0028F6B4 File Offset: 0x0028D8B4
	protected void PreviewTweenStopState()
	{
		if (this.PreviewFinalFillAmount == 1f)
		{
			this.SetCurrentSpriteActive(false);
			this.SetNextSpriteActive(true);
			this.SetNextFillAmount(this.PreviewFinalFillAmount);
			return;
		}
		if (this.TargetLevel == this.CurrentLevel)
		{
			this.SetCurrentSpriteActive(true);
			this.SetAddFillAmount(this.PreviewFinalFillAmount);
			this.SetNextSpriteActive(false);
		}
	}

	// Token: 0x0600B561 RID: 46433 RVA: 0x0028F714 File Offset: 0x0028D914
	protected void PreviewTweenPlayAgainState(float playTime)
	{
		if (this.ArrivedLevel > this.TargetLevel)
		{
			this.InCurrent = (this.TargetLevel == this.CurrentLevel);
			if (this.InCurrent)
			{
				this.SetCurrentSpriteActive(true);
				this.SetNextSpriteActive(false);
			}
			this.PlayPreviewTween(1f, this.PreviewFinalFillAmount, playTime, false);
			return;
		}
		if (this.ArrivedLevel < this.TargetLevel)
		{
			this.InCurrent = false;
			this.SetCurrentSpriteActive(false);
			this.SetNextSpriteActive(true);
			this.PlayPreviewTween(0f, this.PreviewFinalFillAmount, playTime, false);
		}
	}

	// Token: 0x0600B562 RID: 46434 RVA: 0x0028F7A3 File Offset: 0x0028D9A3
	protected void PlayPreviewFillAmount(float value)
	{
		if (this.InCurrent)
		{
			this.SetAddFillAmount(value);
			return;
		}
		this.SetNextFillAmount(value);
		if (this.AddSprite.GetFillAmount() != 1f)
		{
			this.SetAddFillAmount(1f);
		}
	}

	// Token: 0x0600B563 RID: 46435 RVA: 0x0028F7D9 File Offset: 0x0028D9D9
	protected void KillPreviewExpTweener(bool callComplete = false)
	{
		ULTweener previewExpTweener = this.PreviewExpTweener;
		if (previewExpTweener != null)
		{
			previewExpTweener.Kill(false);
		}
		this.PreviewExpTweener = null;
		if (callComplete)
		{
			this.PreviewTweenStopState();
		}
	}

	// Token: 0x0600B564 RID: 46436 RVA: 0x0028F7FD File Offset: 0x0028D9FD
	[NullableContext(1)]
	public void BindPlayCompleteCallBack(Action<bool> callback)
	{
		this.PlayCompleteCallBack = callback;
	}

	// Token: 0x0600B565 RID: 46437 RVA: 0x0028F806 File Offset: 0x0028DA06
	[NullableContext(1)]
	public void BindPlayCurrentFillAmountCallback(Action<float> callback)
	{
		this.PlayCurrentFillAmountCallback = callback;
	}

	// Token: 0x0600B566 RID: 46438 RVA: 0x0028F80F File Offset: 0x0028DA0F
	public void SetCurrentFillAmount(float fillAmount)
	{
		this.CurrentSprite.SetFillAmount(fillAmount);
		if (this.PlayCurrentFillAmountCallback != null)
		{
			this.PlayCurrentFillAmountCallback(fillAmount);
		}
	}

	// Token: 0x0600B567 RID: 46439 RVA: 0x0028F831 File Offset: 0x0028DA31
	public void SetNextFillAmount(float fillAmount)
	{
		this.NextSprite.SetFillAmount(fillAmount);
	}

	// Token: 0x0600B568 RID: 46440 RVA: 0x0028F83F File Offset: 0x0028DA3F
	public void SetAddFillAmount(float fillAmount)
	{
		this.AddSprite.SetFillAmount(fillAmount);
	}

	// Token: 0x0600B569 RID: 46441 RVA: 0x0028F84D File Offset: 0x0028DA4D
	public void SetCurrentSpriteActive(bool bActive)
	{
		this.CurrentSprite.SetUIActive(bActive);
	}

	// Token: 0x0600B56A RID: 46442 RVA: 0x0028F85B File Offset: 0x0028DA5B
	public void SetNextSpriteActive(bool bActive)
	{
		this.NextSprite.SetUIActive(bActive);
	}

	// Token: 0x0600B56B RID: 46443 RVA: 0x0028F86C File Offset: 0x0028DA6C
	public void PlayExpTween(int targetCount, float finalFillAmount, float delay = 0f, LTweenEase ease = LTweenEase.Linear)
	{
		this.SetCurrentSpriteActive(true);
		this.SetNextSpriteActive(false);
		this.AddSprite.SetFillAmount(0f);
		this.FinalFillAmount = finalFillAmount;
		float time = this.TweenTime / (float)targetCount;
		this.PlayTween(this.StartCount, targetCount, time, delay, ease);
	}

	// Token: 0x0600B56C RID: 46444 RVA: 0x0028F8BC File Offset: 0x0028DABC
	public void PlayPreviewExpTween(int currentLevel, int lastTimeArrivedLevel, int targetLevel, int currentMaxLevel, float targetFillAmount)
	{
		this.KillPreviewExpTweener(true);
		this.PreviewFinalFillAmount = targetFillAmount;
		float start = (lastTimeArrivedLevel != currentLevel) ? this.NextSprite.GetFillAmount() : this.AddSprite.GetFillAmount();
		float? num = null;
		if (lastTimeArrivedLevel > targetLevel && lastTimeArrivedLevel != currentMaxLevel)
		{
			num = new float?(0f);
		}
		else if (lastTimeArrivedLevel < targetLevel || targetLevel == currentMaxLevel)
		{
			num = new float?((float)1);
		}
		else
		{
			num = new float?(targetFillAmount);
		}
		this.InCurrent = (lastTimeArrivedLevel == currentLevel);
		this.CurrentLevel = currentLevel;
		this.ArrivedLevel = lastTimeArrivedLevel;
		this.TargetLevel = targetLevel;
		bool flag = this.ArrivedLevel != this.TargetLevel && this.ArrivedLevel != currentMaxLevel && this.TargetLevel != currentMaxLevel;
		float time = flag ? (this.PreviewTweenTime / 2f) : this.PreviewTweenTime;
		this.PlayPreviewTween(start, num.Value, time, flag);
	}

	// Token: 0x0600B56D RID: 46445 RVA: 0x0028F9A4 File Offset: 0x0028DBA4
	public void Destroy()
	{
		UiLayer.Instance.SetShowMaskLayer("ExpTweenComponent", false);
		DelegateUtils.ReleaseManualReleaseDelegate(new Action<float>(this.PlayFillAmount));
		DelegateUtils.ReleaseManualReleaseDelegate(new Action<float>(this.PlayPreviewFillAmount));
		this.Delegate = null;
		this.PreviewDelegate = null;
		this.KillExpTweener();
		this.KillPreviewExpTweener(false);
		this.CurrentSprite = null;
		this.AddSprite = null;
		this.NextSprite = null;
	}

	// Token: 0x040051DD RID: 20957
	protected UUISprite AddSprite;

	// Token: 0x040051DE RID: 20958
	protected UUISprite CurrentSprite;

	// Token: 0x040051DF RID: 20959
	protected UUISprite NextSprite;

	// Token: 0x040051E0 RID: 20960
	protected ULTweener ExpTweener;

	// Token: 0x040051E1 RID: 20961
	protected float TweenTime = 1f;

	// Token: 0x040051E2 RID: 20962
	protected int StartCount = 1;

	// Token: 0x040051E3 RID: 20963
	protected float FinalFillAmount;

	// Token: 0x040051E4 RID: 20964
	protected FLTweenFloatSetterDynamic Delegate;

	// Token: 0x040051E5 RID: 20965
	protected ULTweener PreviewExpTweener;

	// Token: 0x040051E6 RID: 20966
	protected float PreviewTweenTime = 0.5f;

	// Token: 0x040051E7 RID: 20967
	protected float PreviewFinalFillAmount;

	// Token: 0x040051E8 RID: 20968
	protected FLTweenFloatSetterDynamic PreviewDelegate;

	// Token: 0x040051E9 RID: 20969
	protected int CurrentLevel;

	// Token: 0x040051EA RID: 20970
	protected int ArrivedLevel;

	// Token: 0x040051EB RID: 20971
	protected int TargetLevel;

	// Token: 0x040051EC RID: 20972
	protected bool InCurrent;

	// Token: 0x040051ED RID: 20973
	private Action<float> PlayCurrentFillAmountCallback;

	// Token: 0x040051EE RID: 20974
	private Action<bool> PlayCompleteCallBack;

	// Token: 0x040051EF RID: 20975
	protected Action TweenFinishFunction;
}
