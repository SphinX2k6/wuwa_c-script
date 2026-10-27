using System;
using UnrealEngine;

// Token: 0x02002D86 RID: 11654
public class BulletActionDelayDestroyBullet : BulletActionBase
{
	// Token: 0x060187E2 RID: 100322 RVA: 0x0063C137 File Offset: 0x0063A337
	public BulletActionDelayDestroyBullet(EBulletAction type) : base(type)
	{
	}

	// Token: 0x060187E3 RID: 100323 RVA: 0x0063C140 File Offset: 0x0063A340
	protected override void OnExecute()
	{
		BulletActionInfoDelayDestroyBullet bulletActionInfoDelayDestroyBullet = (BulletActionInfoDelayDestroyBullet)this.ActionInfo;
		if (bulletActionInfoDelayDestroyBullet.DelayTime <= 0f)
		{
			this.DestroyBullet();
			return;
		}
		this.RemainingTime = bulletActionInfoDelayDestroyBullet.DelayTime;
	}

	// Token: 0x060187E4 RID: 100324 RVA: 0x0063C17C File Offset: 0x0063A37C
	protected override void OnTick(float delta)
	{
		BulletInfo bulletInfo = this.BulletInfo;
		if (this.BulletInfo.NeedDestroy)
		{
			return;
		}
		BulletActionInfoDelayDestroyBullet bulletActionInfoDelayDestroyBullet = (BulletActionInfoDelayDestroyBullet)this.ActionInfo;
		float timeDilation = bulletInfo.Entity.TimeDilation;
		if (bulletActionInfoDelayDestroyBullet.IgnoreBulletActorTimeScale)
		{
			this.RemainingTime -= delta * timeDilation;
		}
		else
		{
			AActor actor = bulletInfo.Actor;
			if (actor == null || !actor.IsValid())
			{
				this.RemainingTime -= delta * timeDilation;
			}
			else
			{
				this.RemainingTime -= delta * actor.CustomTimeDilation * timeDilation;
			}
		}
		if (this.RemainingTime <= 0f)
		{
			this.DestroyBullet();
		}
	}

	// Token: 0x060187E5 RID: 100325 RVA: 0x0063C224 File Offset: 0x0063A424
	private void DestroyBullet()
	{
		BulletActionInfoDelayDestroyBullet bulletActionInfoDelayDestroyBullet = (BulletActionInfoDelayDestroyBullet)this.ActionInfo;
		BulletController.Instance.DestroyBullet(this.BulletInfo.BulletEntityId, bulletActionInfoDelayDestroyBullet.SummonChild, EBulletDestroyReason.Normal, false);
		this.IsFinish = true;
	}

	// Token: 0x060187E6 RID: 100326 RVA: 0x0063C261 File Offset: 0x0063A461
	public override void Clear()
	{
		base.Clear();
		this.RemainingTime = 0f;
	}

	// Token: 0x0400B588 RID: 46472
	private float RemainingTime;
}
