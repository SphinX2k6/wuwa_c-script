using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200240D RID: 9229
[NullableContext(2)]
[Nullable(0)]
public class CustomWaitMontageEnd : CustomActionBase
{
	// Token: 0x0601717E RID: 94590 RVA: 0x006C03C2 File Offset: 0x006BE5C2
	public CustomWaitMontageEnd(BasePerformComponent performComp, [Nullable(1)] CharacterAnimationComponent animComp, bool waitForMontage = false, bool waitForMontageLoop = false, Action callback = null)
	{
		this.PerformComp = performComp;
		this.AnimComp = animComp;
		this.WaitForMontage = waitForMontage;
		this.WaitForMontageLoop = waitForMontageLoop;
		this.Callback = callback;
	}

	// Token: 0x0601717F RID: 94591 RVA: 0x006C03F0 File Offset: 0x006BE5F0
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

	// Token: 0x06017180 RID: 94592 RVA: 0x006C047E File Offset: 0x006BE67E
	protected override void OnCheckFinish(float deltaTime)
	{
		if (this.IsFinish)
		{
			return;
		}
		this.CheckLoopSection();
	}

	// Token: 0x06017181 RID: 94593 RVA: 0x006C048F File Offset: 0x006BE68F
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

	// Token: 0x06017182 RID: 94594 RVA: 0x006C04B8 File Offset: 0x006BE6B8
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

	// Token: 0x06017183 RID: 94595 RVA: 0x006C0520 File Offset: 0x006BE720
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

	// Token: 0x06017184 RID: 94596 RVA: 0x006C0585 File Offset: 0x006BE785
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

	// Token: 0x06017185 RID: 94597 RVA: 0x006C05BC File Offset: 0x006BE7BC
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

	// Token: 0x06017186 RID: 94598 RVA: 0x006C0640 File Offset: 0x006BE840
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

	// Token: 0x0400C263 RID: 49763
	private bool WaitLoopSectionFinish;

	// Token: 0x0400C264 RID: 49764
	private readonly BasePerformComponent PerformComp;

	// Token: 0x0400C265 RID: 49765
	[Nullable(1)]
	private readonly CharacterAnimationComponent AnimComp;

	// Token: 0x0400C266 RID: 49766
	private readonly bool WaitForMontage;

	// Token: 0x0400C267 RID: 49767
	private readonly bool WaitForMontageLoop;
}
