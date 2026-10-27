using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;

// Token: 0x02002DD2 RID: 11730
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class BulletLogicFreezeController : BulletLogicController<LogicDataFreeze, object>
{
	// Token: 0x06018A27 RID: 100903 RVA: 0x0064D60E File Offset: 0x0064B80E
	public BulletLogicFreezeController(LogicDataFreeze bulletLogicBase, Entity bullet) : base(bulletLogicBase, bullet)
	{
		this.BulletInfo = this.Bullet.GetBulletInfo();
		this.Parameter = bulletLogicBase;
	}

	// Token: 0x06018A28 RID: 100904 RVA: 0x0064D630 File Offset: 0x0064B830
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

	// Token: 0x06018A29 RID: 100905 RVA: 0x0064D6D8 File Offset: 0x0064B8D8
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

	// Token: 0x0400B773 RID: 46963
	private readonly LogicDataFreeze Parameter;

	// Token: 0x0400B774 RID: 46964
	private readonly BulletInfo BulletInfo;
}
