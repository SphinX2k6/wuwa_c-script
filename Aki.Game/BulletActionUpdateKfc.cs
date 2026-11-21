using System;

// Token: 0x020022F6 RID: 8950
public class BulletActionUpdateKfc : BulletActionBase
{
	// Token: 0x06016101 RID: 90369 RVA: 0x006698DD File Offset: 0x00667ADD
	public BulletActionUpdateKfc(EBulletAction type) : base(type)
	{
	}

	// Token: 0x06016102 RID: 90370 RVA: 0x006698E6 File Offset: 0x00667AE6
	protected override void OnExecute()
	{
		BulletKuroFastCollisionInfo kuroFastCollisionInfo = this.BulletInfo.KuroFastCollisionInfo;
		if (kuroFastCollisionInfo == null)
		{
			return;
		}
		kuroFastCollisionInfo.SetWorldBulletComponentEnable(this.CheckBulletNeedHitCurFrame());
	}

	// Token: 0x06016103 RID: 90371 RVA: 0x00669903 File Offset: 0x00667B03
	protected override void OnTick(float delta)
	{
		BulletInfo bulletInfo = this.BulletInfo;
		if (bulletInfo == null)
		{
			return;
		}
		BulletKuroFastCollisionInfo kuroFastCollisionInfo = bulletInfo.KuroFastCollisionInfo;
		if (kuroFastCollisionInfo == null)
		{
			return;
		}
		kuroFastCollisionInfo.SetWorldBulletComponentEnable(this.CheckBulletNeedHitCurFrame());
	}

	// Token: 0x06016104 RID: 90372 RVA: 0x00669928 File Offset: 0x00667B28
	private bool CheckBulletNeedHitCurFrame()
	{
		BulletInfo bulletInfo = this.BulletInfo;
		BulletCollisionInfo collisionInfo = bulletInfo.CollisionInfo;
		return collisionInfo.IsProcessOpen && (collisionInfo.ActiveLengthMs <= 0f || bulletInfo.LiveTime - collisionInfo.ActiveDelayMs <= collisionInfo.ActiveLengthMs);
	}
}
