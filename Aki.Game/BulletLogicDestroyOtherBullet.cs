using System;
using System.Runtime.CompilerServices;

// Token: 0x02002DCF RID: 11727
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class BulletLogicDestroyOtherBullet : BulletLogicController<LogicDataDestroyOtherBullet, Entity>
{
	// Token: 0x06018A15 RID: 100885 RVA: 0x0064CB23 File Offset: 0x0064AD23
	public BulletLogicDestroyOtherBullet(LogicDataDestroyOtherBullet data, Entity bullet) : base(data, bullet)
	{
	}

	// Token: 0x06018A16 RID: 100886 RVA: 0x0064CB2D File Offset: 0x0064AD2D
	public override void OnInit()
	{
		this.Bullet.GetBulletInfo().BulletDataMain.Execution.SupportCamp.Add(this.LogicController.Camp);
	}

	// Token: 0x06018A17 RID: 100887 RVA: 0x0064CB5C File Offset: 0x0064AD5C
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
