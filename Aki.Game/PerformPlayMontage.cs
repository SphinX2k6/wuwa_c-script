using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x0200311C RID: 12572
[NullableContext(2)]
[Nullable(0)]
public class PerformPlayMontage : PerformActionBase
{
	// Token: 0x0601B04A RID: 110666 RVA: 0x00755053 File Offset: 0x00753253
	public PerformPlayMontage() : base(EPerformAction.PlayMontage)
	{
	}

	// Token: 0x0601B04B RID: 110667 RVA: 0x0075505C File Offset: 0x0075325C
	protected override void OnExecute()
	{
		BaseAnimationComponent component = this.PerformComp.Entity.GetComponent<BaseAnimationComponent>();
		if (component == null)
		{
			base.FinishExecute();
			return;
		}
		IPlayMontageParam playMontageParam = this.Param as IPlayMontageParam;
		if (playMontageParam.EndActionOnBlendOut.GetValueOrDefault())
		{
			this.OriginOnBlendOut = playMontageParam.OnBlendOutCallback;
			playMontageParam.OnBlendOutCallback = new Action<UAnimMontage, bool>(this.OnBlendOutForFinish);
		}
		this.MontageId = component.GetMontageManager(base.Group).PlayMontage(playMontageParam);
		if (this.MontageId > 0)
		{
			this.EntityHandle = CreatureModel.Instance.GetEntityById(this.PerformComp.Entity.Id);
			if (this.EntityHandle != null)
			{
				EventSystem.Instance.AddWithTarget(this.EntityHandle, EEventName.PerformMontageStop, new Action<int>(this.OnMontageStop));
				return;
			}
		}
		else
		{
			base.FinishExecute();
		}
	}

	// Token: 0x0601B04C RID: 110668 RVA: 0x00755130 File Offset: 0x00753330
	private void OnBlendOutForFinish(UAnimMontage montage, bool bInterrupted)
	{
		Action<UAnimMontage, bool> originOnBlendOut = this.OriginOnBlendOut;
		if (originOnBlendOut != null)
		{
			originOnBlendOut(montage, bInterrupted);
		}
		BasePerformComponent performComp = this.PerformComp;
		BaseAnimationComponent baseAnimationComponent = (performComp != null) ? performComp.Entity.GetComponent<BaseAnimationComponent>() : null;
		if (baseAnimationComponent == null)
		{
			return;
		}
		baseAnimationComponent.GetMontageManager(base.Group).DetachWithoutStop(bInterrupted);
	}

	// Token: 0x0601B04D RID: 110669 RVA: 0x00755180 File Offset: 0x00753380
	private void OnMontageStop(int id)
	{
		if (this.EntityHandle != null && EventSystem.Instance.HasWithTarget(this.EntityHandle, EEventName.PerformMontageStop, new Action<int>(this.OnMontageStop)))
		{
			EventSystem.Instance.RemoveWithTarget(this.EntityHandle, EEventName.PerformMontageStop, new Action<int>(this.OnMontageStop));
		}
		if (this.MontageId == id)
		{
			base.FinishExecute();
		}
	}

	// Token: 0x0601B04E RID: 110670 RVA: 0x007551EC File Offset: 0x007533EC
	protected override void OnInterrupt()
	{
		float remainDuration = this.PerformComp.Entity.GetComponent<BaseAnimationComponent>().GetMontageManager(base.Group).GetRemainDuration(this.MontageId);
		((IPlayMontageParam)this.Param).Duration = new float?(remainDuration);
		this.MontageId = 0;
		if (EventSystem.Instance.HasWithTarget(this.EntityHandle, EEventName.PerformMontageStop, new Action<int>(this.OnMontageStop)))
		{
			EventSystem.Instance.RemoveWithTarget(this.EntityHandle, EEventName.PerformMontageStop, new Action<int>(this.OnMontageStop));
		}
	}

	// Token: 0x0601B04F RID: 110671 RVA: 0x00755284 File Offset: 0x00753484
	protected override void OnReset()
	{
		if (this.EntityHandle != null && EventSystem.Instance.HasWithTarget(this.EntityHandle, EEventName.PerformMontageStop, new Action<int>(this.OnMontageStop)))
		{
			EventSystem.Instance.RemoveWithTarget(this.EntityHandle, EEventName.PerformMontageStop, new Action<int>(this.OnMontageStop));
		}
		this.MontageId = 0;
		this.EntityHandle = null;
		this.OriginOnBlendOut = null;
	}

	// Token: 0x0400D218 RID: 53784
	private int MontageId;

	// Token: 0x0400D219 RID: 53785
	private EntityHandle EntityHandle;

	// Token: 0x0400D21A RID: 53786
	private Action<UAnimMontage, bool> OriginOnBlendOut;
}
