using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x02002677 RID: 9847
[NullableContext(2)]
[Nullable(0)]
public class PerformPlayMontage : PerformActionBase
{
	// Token: 0x06018AA5 RID: 101029 RVA: 0x0077B0BF File Offset: 0x007792BF
	public PerformPlayMontage() : base(EPerformAction.PlayMontage)
	{
	}

	// Token: 0x06018AA6 RID: 101030 RVA: 0x0077B0C8 File Offset: 0x007792C8
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

	// Token: 0x06018AA7 RID: 101031 RVA: 0x0077B19C File Offset: 0x0077939C
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

	// Token: 0x06018AA8 RID: 101032 RVA: 0x0077B1EC File Offset: 0x007793EC
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

	// Token: 0x06018AA9 RID: 101033 RVA: 0x0077B258 File Offset: 0x00779458
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

	// Token: 0x06018AAA RID: 101034 RVA: 0x0077B2F0 File Offset: 0x007794F0
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

	// Token: 0x0400D63A RID: 54842
	private int MontageId;

	// Token: 0x0400D63B RID: 54843
	private EntityHandle EntityHandle;

	// Token: 0x0400D63C RID: 54844
	private Action<UAnimMontage, bool> OriginOnBlendOut;
}
