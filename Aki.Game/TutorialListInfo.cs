using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Guide.StepInfo;

// Token: 0x02001284 RID: 4740
public class TutorialListInfo
{
	// Token: 0x0600BB9F RID: 48031 RVA: 0x00374DDA File Offset: 0x00372FDA
	[NullableContext(1)]
	public TutorialListInfo(GuideStepInfo stepInfo)
	{
		this.OwnerStep = stepInfo;
	}

	// Token: 0x0600BBA0 RID: 48032 RVA: 0x00374DEC File Offset: 0x00372FEC
	public void Init()
	{
		this.GuideId = this.OwnerStep.Id;
		GuideTutorial? guideTutorial = GuideConfig.Instance.GetGuideTutorial(this.OwnerStep.Id);
		if (guideTutorial != null && guideTutorial.GetValueOrDefault().TutorialTip)
		{
			this.TipState = ETutorialListType.Tip;
			this.TutorialTip = true;
			this.Duration = (float)this.OwnerStep.Config.Duration;
			return;
		}
		this.TipState = ETutorialListType.Pop;
		this.TutorialTip = false;
	}

	// Token: 0x0600BBA1 RID: 48033 RVA: 0x00374E74 File Offset: 0x00373074
	public void StopGuide()
	{
		if (this.OwnerStep != null)
		{
			this.OwnerStep.SwitchState(EGuideStepState.Finish);
			this.OwnerStep = null;
		}
	}

	// Token: 0x0600BBA2 RID: 48034 RVA: 0x00374E91 File Offset: 0x00373091
	public bool Tick(float delta)
	{
		if (this.TipState == ETutorialListType.Timing)
		{
			this.Duration -= delta;
			if (this.Duration <= 0f)
			{
				this.StopGuide();
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600BBA3 RID: 48035 RVA: 0x00374EC0 File Offset: 0x003730C0
	public void ClickToPopState()
	{
		if (this.TipState != ETutorialListType.Pop && this.Duration > 0f)
		{
			this.TipState = ETutorialListType.Pop;
			this.StopGuide();
			GuideModel.Instance.TryPauseTimer();
		}
	}

	// Token: 0x04006BF3 RID: 27635
	[Nullable(2)]
	public GuideStepInfo OwnerStep;

	// Token: 0x04006BF4 RID: 27636
	public int GuideId;

	// Token: 0x04006BF5 RID: 27637
	public ETutorialListType TipState;

	// Token: 0x04006BF6 RID: 27638
	public float Duration;

	// Token: 0x04006BF7 RID: 27639
	public bool TutorialTip;

	// Token: 0x04006BF8 RID: 27640
	public readonly bool IsOverrideGuideTutorialView;
}
