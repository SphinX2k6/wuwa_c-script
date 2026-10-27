using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Core.Fight;

// Token: 0x02002DCE RID: 11726
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class BulletLogicDestroyBulletController : BulletLogicController<LogicDataDestroyBullet, object>
{
	// Token: 0x06018A12 RID: 100882 RVA: 0x0064C9F0 File Offset: 0x0064ABF0
	public BulletLogicDestroyBulletController(LogicDataDestroyBullet bulletLogicBase, Entity bullet) : base(bulletLogicBase, bullet)
	{
		this.Parameter = bulletLogicBase;
	}

	// Token: 0x06018A13 RID: 100883 RVA: 0x0064CA04 File Offset: 0x0064AC04
	[NullableContext(2)]
	public override void BulletLogicAction(object param = null)
	{
		if (this.Parameter.DestroyBulletRowName == "None")
		{
			return;
		}
		Entity victim = null;
		BulletHitActorData bulletHitActorData = param as BulletHitActorData;
		if (bulletHitActorData != null)
		{
			victim = bulletHitActorData.Entity;
		}
		IReadOnlyCollection<BulletEntity> bulletSetByAttacker = BulletModel.Instance.GetBulletSetByAttacker(this.GetBulletCharacterEntity(new EBulletObject?(this.Parameter.BulletOwner), victim).Id);
		if (bulletSetByAttacker == null)
		{
			return;
		}
		foreach (BulletEntity bulletEntity in bulletSetByAttacker)
		{
			BulletInfo bulletInfo = bulletEntity.GetBulletInfo();
			if (bulletInfo.BulletRowName == this.Parameter.DestroyBulletRowName)
			{
				BulletController.Instance.DestroyBullet(bulletInfo.BulletEntityId, this.Parameter.SummonChildBullet, EBulletDestroyReason.Normal, false);
			}
		}
	}

	// Token: 0x06018A14 RID: 100884 RVA: 0x0064CAD8 File Offset: 0x0064ACD8
	private Entity GetBulletCharacterEntity(EBulletObject? bulletObject, Entity victim)
	{
		if (bulletObject != null)
		{
			EBulletObject valueOrDefault = bulletObject.GetValueOrDefault();
			if (valueOrDefault == EBulletObject.攻击者)
			{
				return this.Bullet.GetBulletInfo().Attacker;
			}
			if (valueOrDefault == EBulletObject.受击者)
			{
				return victim;
			}
		}
		return this.Bullet.GetBulletInfo().Attacker;
	}

	// Token: 0x0400B75B RID: 46939
	private const string NONE_STRING = "None";

	// Token: 0x0400B75C RID: 46940
	private readonly LogicDataDestroyBullet Parameter;
}
