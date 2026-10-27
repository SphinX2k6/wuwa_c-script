using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Guide.StepInfo;

// Token: 0x02001DC2 RID: 7618
public class TutorialListInfo
{
	// Token: 0x0600E781 RID: 59265 RVA: 0x00369162 File Offset: 0x00367362
	[NullableContext(1)]
	public TutorialListInfo(GuideStepInfo stepInfo)
	{
		this.OwnerStep = stepInfo;
	}

	// Token: 0x0600E782 RID: 59266 RVA: 0x00369174 File Offset: 0x00367374
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

	// Token: 0x0600E783 RID: 59267 RVA: 0x003691FC File Offset: 0x003673FC
	public void StopGuide()
	{
		if (this.OwnerStep != null)
		{
			this.OwnerStep.SwitchState(EGuideStepState.Finish);
			this.OwnerStep = null;
		}
	}

	// Token: 0x0600E784 RID: 59268 RVA: 0x00369219 File Offset: 0x00367419
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

	// Token: 0x0600E785 RID: 59269 RVA: 0x00369248 File Offset: 0x00367448
	public void ClickToPopState()
	{
		if (this.TipState != ETutorialListType.Pop && this.Duration > 0f)
		{
			this.TipState = ETutorialListType.Pop;
			this.StopGuide();
			GuideModel.Instance.TryPauseTimer();
		}
	}

	// Token: 0x04006B12 RID: 27410
	[Nullable(2)]
	public GuideStepInfo OwnerStep;

	// Token: 0x04006B13 RID: 27411
	public int GuideId;

	// Token: 0x04006B14 RID: 27412
	public ETutorialListType TipState;

	// Token: 0x04006B15 RID: 27413
	public float Duration;

	// Token: 0x04006B16 RID: 27414
	public bool TutorialTip;

	// Token: 0x04006B17 RID: 27415
	public readonly bool IsOverrideGuideTutorialView;
}
