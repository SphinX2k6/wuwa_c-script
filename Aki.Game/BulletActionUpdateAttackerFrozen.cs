using System;

// Token: 0x020022F4 RID: 8948
public class BulletActionUpdateAttackerFrozen : BulletActionBase
{
	// Token: 0x060160FA RID: 90362 RVA: 0x006690E4 File Offset: 0x006672E4
	public BulletActionUpdateAttackerFrozen(EBulletAction type) : base(type)
	{
	}

	// Token: 0x060160FB RID: 90363 RVA: 0x006690F0 File Offset: 0x006672F0
	protected override void OnTick(float delta)
	{
		BulletInfo bulletInfo = this.BulletInfo;
		Entity attacker = bulletInfo.Attacker;
		BaseFrozenComponent baseFrozenComponent = (attacker != null) ? attacker.GetComponent<BaseFrozenComponent>() : null;
		if (baseFrozenComponent != null && baseFrozenComponent.IsFrozen())
		{
			BulletController.Instance.DestroyBullet(bulletInfo.BulletEntityId, false, EBulletDestroyReason.Normal, false);
		}
	}
}
