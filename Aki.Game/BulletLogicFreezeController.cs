using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;

// Token: 0x0200232C RID: 9004
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class BulletLogicFreezeController : BulletLogicController<LogicDataFreeze, object>
{
	// Token: 0x060162CF RID: 90831 RVA: 0x006733F2 File Offset: 0x006715F2
	public BulletLogicFreezeController(LogicDataFreeze bulletLogicBase, Entity bullet) : base(bulletLogicBase, bullet)
	{
		this.BulletInfo = this.Bullet.GetBulletInfo();
		this.Parameter = bulletLogicBase;
	}

	// Token: 0x060162D0 RID: 90832 RVA: 0x00673414 File Offset: 0x00671614
	[NullableContext(2)]
	public override void BulletLogicAction(object param = null)
	{
		Entity victim = null;
		BulletHitActorData bulletHitActorData = param as BulletHitActorData;
		if (bulletHitActorData != null)
		{
			victim = bulletHitActorData.Entity;
		}
		Entity bulletCharacterEntity = this.GetBulletCharacterEntity(new EBulletObject?(this.Parameter.Target), victim);
		int num = this.Parameter.Tags.GameplayTags.Num();
		if (bulletCharacterEntity == null && num > 0)
		{
			return;
		}
		for (int i = 0; i < num; i++)
		{
			if (!bulletCharacterEntity.GetComponent<BaseTagComponent>().HasTag(this.Parameter.Tags.GameplayTags.Get(i).TagId()))
			{
				return;
			}
		}
		BulletUtil.FrozenBulletTime(this.BulletInfo, this.Parameter.FreezeTime);
	}

	// Token: 0x060162D1 RID: 90833 RVA: 0x006734BC File Offset: 0x006716BC
	private Entity GetBulletCharacterEntity(EBulletObject? bulletObject, Entity victim)
	{
		if (bulletObject != null)
		{
			EBulletObject valueOrDefault = bulletObject.GetValueOrDefault();
			if (valueOrDefault == EBulletObject.攻击者)
			{
				return this.BulletInfo.Attacker;
			}
			if (valueOrDefault == EBulletObject.受击者)
			{
				return victim;
			}
		}
		return this.BulletInfo.Attacker;
	}

	// Token: 0x0400BAEE RID: 47854
	private readonly LogicDataFreeze Parameter;

	// Token: 0x0400BAEF RID: 47855
	private readonly BulletInfo BulletInfo;
}
