using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Core.Fight;

// Token: 0x02002328 RID: 9000
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class BulletLogicDestroyBulletController : BulletLogicController<LogicDataDestroyBullet, object>
{
	// Token: 0x060162BA RID: 90810 RVA: 0x006727D4 File Offset: 0x006709D4
	public BulletLogicDestroyBulletController(LogicDataDestroyBullet bulletLogicBase, Entity bullet) : base(bulletLogicBase, bullet)
	{
		this.Parameter = bulletLogicBase;
	}

	// Token: 0x060162BB RID: 90811 RVA: 0x006727E8 File Offset: 0x006709E8
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

	// Token: 0x060162BC RID: 90812 RVA: 0x006728BC File Offset: 0x00670ABC
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

	// Token: 0x0400BAD6 RID: 47830
	private const string NONE_STRING = "None";

	// Token: 0x0400BAD7 RID: 47831
	private readonly LogicDataDestroyBullet Parameter;
}
