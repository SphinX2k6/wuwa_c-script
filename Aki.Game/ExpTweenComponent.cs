using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000CDC RID: 3292
[NullableContext(2)]
[Nullable(0)]
public class ExpTweenComponent
{
	// Token: 0x06008944 RID: 35140 RVA: 0x00299B64 File Offset: 0x00297D64
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

	// Token: 0x06008945 RID: 35141 RVA: 0x00299BE0 File Offset: 0x00297DE0
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

	// Token: 0x06008946 RID: 35142 RVA: 0x00299CC8 File Offset: 0x00297EC8
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

	// Token: 0x06008947 RID: 35143 RVA: 0x00299D29 File Offset: 0x00297F29
	protected void PlayFillAmount(float value)
	{
		this.SetCurrentFillAmount(value);
	}

	// Token: 0x06008948 RID: 35144 RVA: 0x00299D32 File Offset: 0x00297F32
	protected void KillExpTweener()
	{
		if (this.ExpTweener != null)
		{
			this.ExpTweener.Kill(false);
			this.ExpTweener = null;
		}
	}

	// Token: 0x06008949 RID: 35145 RVA: 0x00299D50 File Offset: 0x00297F50
	protected void PlayPreviewTween(float start, float end, float time, bool needAgain)
	{
		this.PreviewExpTweener = ULTweenBPLibrary.FloatTo(GlobalData.World, this.PreviewDelegate, start, end, time, 0f, LTweenEase.OutCubic);
		this.PreviewExpTweener.OnCompleteCallBack.Bind(delegate()
		{
			this.PreviewTweenCompleteCallBack(time, needAgain);
		});
	}

	// Token: 0x0600894A RID: 35146 RVA: 0x00299DB9 File Offset: 0x00297FB9
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

	// Token: 0x0600894B RID: 35147 RVA: 0x00299DD4 File Offset: 0x00297FD4
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

	// Token: 0x0600894C RID: 35148 RVA: 0x00299E34 File Offset: 0x00298034
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

	// Token: 0x0600894D RID: 35149 RVA: 0x00299EC3 File Offset: 0x002980C3
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

	// Token: 0x0600894E RID: 35150 RVA: 0x00299EF9 File Offset: 0x002980F9
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

	// Token: 0x0600894F RID: 35151 RVA: 0x00299F1D File Offset: 0x0029811D
	[NullableContext(1)]
	public void BindPlayCompleteCallBack(Action<bool> callback)
	{
		this.PlayCompleteCallBack = callback;
	}

	// Token: 0x06008950 RID: 35152 RVA: 0x00299F26 File Offset: 0x00298126
	[NullableContext(1)]
	public void BindPlayCurrentFillAmountCallback(Action<float> callback)
	{
		this.PlayCurrentFillAmountCallback = callback;
	}

	// Token: 0x06008951 RID: 35153 RVA: 0x00299F2F File Offset: 0x0029812F
	public void SetCurrentFillAmount(float fillAmount)
	{
		this.CurrentSprite.SetFillAmount(fillAmount);
		if (this.PlayCurrentFillAmountCallback != null)
		{
			this.PlayCurrentFillAmountCallback(fillAmount);
		}
	}

	// Token: 0x06008952 RID: 35154 RVA: 0x00299F51 File Offset: 0x00298151
	public void SetNextFillAmount(float fillAmount)
	{
		this.NextSprite.SetFillAmount(fillAmount);
	}

	// Token: 0x06008953 RID: 35155 RVA: 0x00299F5F File Offset: 0x0029815F
	public void SetAddFillAmount(float fillAmount)
	{
		this.AddSprite.SetFillAmount(fillAmount);
	}

	// Token: 0x06008954 RID: 35156 RVA: 0x00299F6D File Offset: 0x0029816D
	public void SetCurrentSpriteActive(bool bActive)
	{
		this.CurrentSprite.SetUIActive(bActive);
	}

	// Token: 0x06008955 RID: 35157 RVA: 0x00299F7B File Offset: 0x0029817B
	public void SetNextSpriteActive(bool bActive)
	{
		this.NextSprite.SetUIActive(bActive);
	}

	// Token: 0x06008956 RID: 35158 RVA: 0x00299F8C File Offset: 0x0029818C
	public void PlayExpTween(int targetCount, float finalFillAmount, float delay = 0f, LTweenEase ease = LTweenEase.Linear)
	{
		this.SetCurrentSpriteActive(true);
		this.SetNextSpriteActive(false);
		this.AddSprite.SetFillAmount(0f);
		this.FinalFillAmount = finalFillAmount;
		float time = this.TweenTime / (float)targetCount;
		this.PlayTween(this.StartCount, targetCount, time, delay, ease);
	}

	// Token: 0x06008957 RID: 35159 RVA: 0x00299FDC File Offset: 0x002981DC
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

	// Token: 0x06008958 RID: 35160 RVA: 0x0029A0C4 File Offset: 0x002982C4
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

	// Token: 0x04005288 RID: 21128
	protected UUISprite AddSprite;

	// Token: 0x04005289 RID: 21129
	protected UUISprite CurrentSprite;

	// Token: 0x0400528A RID: 21130
	protected UUISprite NextSprite;

	// Token: 0x0400528B RID: 21131
	protected ULTweener ExpTweener;

	// Token: 0x0400528C RID: 21132
	protected float TweenTime = 1f;

	// Token: 0x0400528D RID: 21133
	protected int StartCount = 1;

	// Token: 0x0400528E RID: 21134
	protected float FinalFillAmount;

	// Token: 0x0400528F RID: 21135
	protected FLTweenFloatSetterDynamic Delegate;

	// Token: 0x04005290 RID: 21136
	protected ULTweener PreviewExpTweener;

	// Token: 0x04005291 RID: 21137
	protected float PreviewTweenTime = 0.5f;

	// Token: 0x04005292 RID: 21138
	protected float PreviewFinalFillAmount;

	// Token: 0x04005293 RID: 21139
	protected FLTweenFloatSetterDynamic PreviewDelegate;

	// Token: 0x04005294 RID: 21140
	protected int CurrentLevel;

	// Token: 0x04005295 RID: 21141
	protected int ArrivedLevel;

	// Token: 0x04005296 RID: 21142
	protected int TargetLevel;

	// Token: 0x04005297 RID: 21143
	protected bool InCurrent;

	// Token: 0x04005298 RID: 21144
	private Action<float> PlayCurrentFillAmountCallback;

	// Token: 0x04005299 RID: 21145
	private Action<bool> PlayCompleteCallBack;

	// Token: 0x0400529A RID: 21146
	protected Action TweenFinishFunction;
}
