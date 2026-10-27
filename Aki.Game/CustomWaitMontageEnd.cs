using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002EBA RID: 11962
[NullableContext(2)]
[Nullable(0)]
public class CustomWaitMontageEnd : CustomActionBase
{
	// Token: 0x06019898 RID: 104600 RVA: 0x0069A102 File Offset: 0x00698302
	public CustomWaitMontageEnd(BasePerformComponent performComp, [Nullable(1)] CharacterAnimationComponent animComp, bool waitForMontage = false, bool waitForMontageLoop = false, Action callback = null)
	{
		this.PerformComp = performComp;
		this.AnimComp = animComp;
		this.WaitForMontage = waitForMontage;
		this.WaitForMontageLoop = waitForMontageLoop;
		this.Callback = callback;
	}

	// Token: 0x06019899 RID: 104601 RVA: 0x0069A130 File Offset: 0x00698330
	protected override void OnRunAction()
	{
		if (this.AnimComp == null || this.PerformComp == null)
		{
			base.Finish(false);
			return;
		}
		if (!this.WaitForMontageLoop && !this.WaitForMontage)
		{
			base.Finish(true);
			return;
		}
		if (this.CheckInSection(CharacterNameDefines.Instance.LOOP_SECTION))
		{
			if (this.WaitForMontage)
			{
				if (!this.WaitMontageEnd())
				{
					base.Finish(true);
				}
				return;
			}
			if (this.WaitForMontageLoop)
			{
				if (!this.WaitMontageLoopFinish())
				{
					base.Finish(true);
				}
				return;
			}
		}
		if (!this.WaitDefaultMontageEnd())
		{
			base.Finish(true);
		}
	}

	// Token: 0x0601989A RID: 104602 RVA: 0x0069A1BE File Offset: 0x006983BE
	protected override void OnCheckFinish(float deltaTime)
	{
		if (this.IsFinish)
		{
			return;
		}
		this.CheckLoopSection();
	}

	// Token: 0x0601989B RID: 104603 RVA: 0x0069A1CF File Offset: 0x006983CF
	protected override void OnFinish(bool success)
	{
		this.WaitLoopSectionFinish = false;
		CharacterAnimationComponent animComp = this.AnimComp;
		if (animComp == null)
		{
			return;
		}
		UAnimInstance mainAnimInstance = animComp.MainAnimInstance;
		if (mainAnimInstance == null)
		{
			return;
		}
		mainAnimInstance.OnMontageEnded.Clear();
	}

	// Token: 0x0601989C RID: 104604 RVA: 0x0069A1F8 File Offset: 0x006983F8
	private bool WaitDefaultMontageEnd()
	{
		Action<UAnimMontage, bool> callback = delegate(UAnimMontage montage, bool bInterrupt)
		{
			base.Finish(true);
		};
		CharacterAnimationComponent animComp = this.AnimComp;
		if (animComp != null)
		{
			UAnimInstance mainAnimInstance = animComp.MainAnimInstance;
			if (mainAnimInstance != null)
			{
				mainAnimInstance.OnMontageEnded.Add(callback);
			}
		}
		BasePerformComponent performComp = this.PerformComp;
		return ((performComp != null) ? performComp.StopPerformMontage(EPerformMode.Action, new IStopMontageParam
		{
			Method = new EStopMethod?(EStopMethod.WaitNextEndSection)
		}, null, null) : 0) > 0;
	}

	// Token: 0x0601989D RID: 104605 RVA: 0x0069A260 File Offset: 0x00698460
	private bool WaitMontageEnd()
	{
		Action<UAnimMontage, bool> callback = delegate(UAnimMontage montage, bool bInterrupt)
		{
			base.Finish(true);
		};
		CharacterAnimationComponent animComp = this.AnimComp;
		if (animComp != null)
		{
			UAnimInstance mainAnimInstance = animComp.MainAnimInstance;
			if (mainAnimInstance != null)
			{
				mainAnimInstance.OnMontageEnded.Add(callback);
			}
		}
		BasePerformComponent performComp = this.PerformComp;
		return ((performComp != null) ? performComp.StopPerformMontage(EPerformMode.Action, new IStopMontageParam
		{
			Method = new EStopMethod?(EStopMethod.WaitLoopToEnd)
		}, null, null) : 0) > 0;
	}

	// Token: 0x0601989E RID: 104606 RVA: 0x0069A2C5 File Offset: 0x006984C5
	private bool WaitMontageLoopFinish()
	{
		BasePerformComponent performComp = this.PerformComp;
		if (((performComp != null) ? performComp.StopPerformMontage(EPerformMode.Action, new IStopMontageParam
		{
			Method = new EStopMethod?(EStopMethod.WaitLoopToEnd)
		}, null, null) : 0) <= 0)
		{
			return false;
		}
		this.WaitLoopSectionFinish = true;
		return true;
	}

	// Token: 0x0601989F RID: 104607 RVA: 0x0069A2FC File Offset: 0x006984FC
	private void CheckLoopSection()
	{
		if (!this.WaitLoopSectionFinish)
		{
			return;
		}
		CharacterAnimationComponent animComp = this.AnimComp;
		UAnimInstance uanimInstance = (animComp != null) ? animComp.MainAnimInstance : null;
		if (uanimInstance == null)
		{
			base.Finish(true);
			return;
		}
		UAnimMontage currentActiveMontage = uanimInstance.GetCurrentActiveMontage();
		if (currentActiveMontage == null || !uanimInstance.Montage_IsPlaying(currentActiveMontage))
		{
			base.Finish(true);
			return;
		}
		FName a = uanimInstance.Montage_GetCurrentSection(currentActiveMontage);
		if (!(a != null) || !a.Equals(CharacterNameDefines.Instance.LOOP_SECTION))
		{
			base.Finish(true);
		}
	}

	// Token: 0x060198A0 RID: 104608 RVA: 0x0069A380 File Offset: 0x00698580
	private bool CheckInSection(FName name)
	{
		CharacterAnimationComponent animComp = this.AnimComp;
		UAnimInstance uanimInstance = (animComp != null) ? animComp.MainAnimInstance : null;
		if (uanimInstance == null)
		{
			return false;
		}
		UAnimMontage currentActiveMontage = uanimInstance.GetCurrentActiveMontage();
		if (currentActiveMontage == null)
		{
			return false;
		}
		FName a = uanimInstance.Montage_GetCurrentSection(currentActiveMontage);
		return a != null && a.Equals(name);
	}

	// Token: 0x0400BEC8 RID: 48840
	private bool WaitLoopSectionFinish;

	// Token: 0x0400BEC9 RID: 48841
	private readonly BasePerformComponent PerformComp;

	// Token: 0x0400BECA RID: 48842
	[Nullable(1)]
	private readonly CharacterAnimationComponent AnimComp;

	// Token: 0x0400BECB RID: 48843
	private readonly bool WaitForMontage;

	// Token: 0x0400BECC RID: 48844
	private readonly bool WaitForMontageLoop;
}
