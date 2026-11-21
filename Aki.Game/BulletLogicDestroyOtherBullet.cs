using System;
using System.Runtime.CompilerServices;

// Token: 0x02002329 RID: 9001
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class BulletLogicDestroyOtherBullet : BulletLogicController<LogicDataDestroyOtherBullet, Entity>
{
	// Token: 0x060162BD RID: 90813 RVA: 0x00672907 File Offset: 0x00670B07
	public BulletLogicDestroyOtherBullet(LogicDataDestroyOtherBullet data, Entity bullet) : base(data, bullet)
	{
	}

	// Token: 0x060162BE RID: 90814 RVA: 0x00672911 File Offset: 0x00670B11
	public override void OnInit()
	{
		this.Bullet.GetBulletInfo().BulletDataMain.Execution.SupportCamp.Add(this.LogicController.Camp);
	}

	// Token: 0x060162BF RID: 90815 RVA: 0x00672940 File Offset: 0x00670B40
	[NullableContext(2)]
	public override void BulletLogicAction(Entity otherBullet)
	{
		BulletInfo bulletInfo = (otherBullet as BulletEntity).GetBulletInfo();
		string bulletId = this.LogicController.BulletId;
		if (!StringUtils.IsEmpty(bulletId) && bulletId != bulletInfo.BulletRowName)
		{
			return;
		}
		BulletController.Instance.DestroyBullet(otherBullet.Id, this.LogicController.SummonChildBullet, EBulletDestroyReason.Normal, false);
	}
}
