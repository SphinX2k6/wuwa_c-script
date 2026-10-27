using System;

// Token: 0x02002D9C RID: 11676
public class BulletActionUpdateKfc : BulletActionBase
{
	// Token: 0x0601885C RID: 100444 RVA: 0x00643AA1 File Offset: 0x00641CA1
	public BulletActionUpdateKfc(EBulletAction type) : base(type)
	{
	}

	// Token: 0x0601885D RID: 100445 RVA: 0x00643AAA File Offset: 0x00641CAA
	protected override void OnExecute()
	{
		BulletKuroFastCollisionInfo kuroFastCollisionInfo = this.BulletInfo.KuroFastCollisionInfo;
		if (kuroFastCollisionInfo == null)
		{
			return;
		}
		kuroFastCollisionInfo.SetWorldBulletComponentEnable(this.CheckBulletNeedHitCurFrame());
	}

	// Token: 0x0601885E RID: 100446 RVA: 0x00643AC7 File Offset: 0x00641CC7
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

	// Token: 0x0601885F RID: 100447 RVA: 0x00643AEC File Offset: 0x00641CEC
	private bool CheckBulletNeedHitCurFrame()
	{
		BulletInfo bulletInfo = this.BulletInfo;
		BulletCollisionInfo collisionInfo = bulletInfo.CollisionInfo;
		return collisionInfo.IsProcessOpen && (collisionInfo.ActiveLengthMs <= 0f || bulletInfo.LiveTime - collisionInfo.ActiveDelayMs <= collisionInfo.ActiveLengthMs);
	}
}
