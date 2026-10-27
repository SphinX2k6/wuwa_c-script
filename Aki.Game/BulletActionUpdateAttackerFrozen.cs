using System;

// Token: 0x02002D9A RID: 11674
public class BulletActionUpdateAttackerFrozen : BulletActionBase
{
	// Token: 0x06018856 RID: 100438 RVA: 0x00643328 File Offset: 0x00641528
	public BulletActionUpdateAttackerFrozen(EBulletAction type) : base(type)
	{
	}

	// Token: 0x06018857 RID: 100439 RVA: 0x00643334 File Offset: 0x00641534
	protected override void OnTick(float delta)
	{
		BulletInfo bulletInfo = this.BulletInfo;
		Entity attacker = bulletInfo.Attacker;
		if (((attacker != null) ? attacker.GetComponent<BaseFrozenComponent>() : null).IsFrozen())
		{
			BulletController.Instance.DestroyBullet(bulletInfo.BulletEntityId, false, EBulletDestroyReason.Normal, false);
		}
	}
}
