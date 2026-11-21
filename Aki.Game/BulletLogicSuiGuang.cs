using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002336 RID: 9014
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class BulletLogicSuiGuang : BulletLogicController<LogicDataSuiGuang, object>
{
	// Token: 0x060162FA RID: 90874 RVA: 0x00675350 File Offset: 0x00673550
	public BulletLogicSuiGuang(LogicDataSuiGuang bulletLogicBase, Entity bullet) : base(bulletLogicBase, bullet)
	{
		this.BulletInfo = this.Bullet.GetBulletInfo();
		this.Parameter = bulletLogicBase;
	}

	// Token: 0x060162FB RID: 90875 RVA: 0x00675374 File Offset: 0x00673574
	[NullableContext(2)]
	public override void BulletLogicAction(object param = null)
	{
		BulletHitActorData bulletHitActorData = param as BulletHitActorData;
		if (bulletHitActorData != null)
		{
			if (this.Parameter.IncludeBullet)
			{
				BulletEntity bulletEntity = bulletHitActorData.Entity as BulletEntity;
				if (bulletEntity != null && bulletEntity.GetBulletInfo().HasTag(this.Parameter.NeedTag))
				{
					this.BuildBullet(this.Parameter.NewBulletId, bulletEntity.Id);
					return;
				}
			}
			else
			{
				Entity entity = bulletHitActorData.Entity;
				bool flag;
				if (entity == null)
				{
					flag = false;
				}
				else
				{
					CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
					flag = ((component != null) ? new bool?(component.IsRole()) : null).GetValueOrDefault();
				}
				if (flag)
				{
					BaseTagComponent component2 = bulletHitActorData.Entity.GetComponent<BaseTagComponent>();
					if (component2 != null && component2.HasTag(this.Parameter.NeedTag.TagId()))
					{
						this.BuildBullet(this.Parameter.NewBulletId, bulletHitActorData.Entity.Id);
					}
				}
			}
		}
	}

	// Token: 0x060162FC RID: 90876 RVA: 0x0067545C File Offset: 0x0067365C
	private void BuildBullet(string bulletId, int victimId)
	{
		FTransformDouble actorTransform = this.Bullet.GetComponent<BulletActorComponent>().ActorTransform;
		HashSet<string> parentIds = BulletUtil.CollectParentsId(this.BulletInfo);
		BulletController instance = BulletController.Instance;
		Entity owner = this.Bullet.GetBulletInfo().BulletInitParams.Owner;
		FTransformDouble? initialTransform = new FTransformDouble?(actorTransform);
		BulletController.BulletCreateParams bulletCreateParams = new BulletController.BulletCreateParams();
		bulletCreateParams.SkillId = this.BulletInfo.BulletInitParams.SkillId;
		bulletCreateParams.SkillContextId = this.BulletInfo.BulletInitParams.SkillContextId;
		bulletCreateParams.ParentVictimId = new int?(victimId);
		Entity target = this.BulletInfo.Target;
		bulletCreateParams.ParentTargetId = ((target != null) ? new int?(target.Id) : null);
		bulletCreateParams.ParentId = this.Bullet.Id;
		bulletCreateParams.BattleContext = this.BulletInfo.BulletInitParams.BattleContext;
		bulletCreateParams.ParentIds = parentIds;
		instance.CreateBulletCustomTarget(owner, bulletId, initialTransform, bulletCreateParams, this.BulletInfo.ContextId, EBulletCreateSource.Others);
		BulletController.Instance.DestroyBullet(this.Bullet.Id, false, EBulletDestroyReason.Normal, false);
	}

	// Token: 0x0400BB1B RID: 47899
	private readonly LogicDataSuiGuang Parameter;

	// Token: 0x0400BB1C RID: 47900
	private readonly BulletInfo BulletInfo;
}
