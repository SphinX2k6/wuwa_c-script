using System;
using UnrealEngine;

// Token: 0x020022E0 RID: 8928
public class BulletActionDelayDestroyBullet : BulletActionBase
{
	// Token: 0x06016084 RID: 90244 RVA: 0x00661E6F File Offset: 0x0066006F
	public BulletActionDelayDestroyBullet(EBulletAction type) : base(type)
	{
	}

	// Token: 0x06016085 RID: 90245 RVA: 0x00661E78 File Offset: 0x00660078
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

	// Token: 0x06016086 RID: 90246 RVA: 0x00661EB4 File Offset: 0x006600B4
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

	// Token: 0x06016087 RID: 90247 RVA: 0x00661F5C File Offset: 0x0066015C
	private void DestroyBullet()
	{
		BulletActionInfoDelayDestroyBullet bulletActionInfoDelayDestroyBullet = (BulletActionInfoDelayDestroyBullet)this.ActionInfo;
		BulletController.Instance.DestroyBullet(this.BulletInfo.BulletEntityId, bulletActionInfoDelayDestroyBullet.SummonChild, EBulletDestroyReason.Normal, false);
		this.IsFinish = true;
	}

	// Token: 0x06016088 RID: 90248 RVA: 0x00661F99 File Offset: 0x00660199
	public override void Clear()
	{
		base.Clear();
		this.RemainingTime = 0f;
	}

	// Token: 0x0400B8FD RID: 47357
	private float RemainingTime;
}
