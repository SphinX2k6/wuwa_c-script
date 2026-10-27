using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;

// Token: 0x02002DCC RID: 11724
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class BulletLogicCreateBulletController : BulletLogicController<LogicDataCreateBullet, object>
{
	// Token: 0x06018A06 RID: 100870 RVA: 0x0064BF7A File Offset: 0x0064A17A
	public BulletLogicCreateBulletController(LogicDataCreateBullet bulletLogicBase, Entity bullet) : base(bulletLogicBase, bullet)
	{
		this.Parameter = bulletLogicBase;
	}

	// Token: 0x06018A07 RID: 100871 RVA: 0x0064BF8C File Offset: 0x0064A18C
	[NullableContext(2)]
	public override void BulletLogicAction(object param = null)
	{
		LogicDataCreateBullet parameter = this.Parameter;
		string createBulletRowName = parameter.CreateBulletRowName;
		if (createBulletRowName == "None")
		{
			return;
		}
		BulletInfo bulletInfo = this.Bullet.GetBulletInfo();
		Entity entity = null;
		BulletHitActorData bulletHitActorData = param as BulletHitActorData;
		if (bulletHitActorData != null)
		{
			entity = bulletHitActorData.Entity;
		}
		string flashBulletRowName = parameter.FlashBulletRowName;
		if (flashBulletRowName != "None")
		{
			IReadOnlyCollection<BulletEntity> bulletSetByAttacker = BulletModel.Instance.GetBulletSetByAttacker(bulletInfo.Attacker.Id);
			bool flag = false;
			BaseActorComponent component = entity.GetComponent<BaseActorComponent>();
			if (bulletSetByAttacker != null && component is CharacterActorComponent)
			{
				TsBaseCharacter actor = (component as CharacterActorComponent).Actor;
				if (actor != null)
				{
					foreach (BulletEntity bulletEntity in bulletSetByAttacker)
					{
						BulletInfo bulletInfo2 = bulletEntity.GetBulletInfo();
						BaseActorComponent component2 = bulletEntity.GetComponent<BaseActorComponent>();
						AActor aactor;
						if (component2 == null)
						{
							aactor = null;
						}
						else
						{
							AActor owner = component2.Owner;
							aactor = ((owner != null) ? owner.GetAttachParentActor() : null);
						}
						AActor aactor2 = aactor;
						if (bulletInfo2.BulletRowName == flashBulletRowName && aactor2 == actor)
						{
							bulletInfo2.GenerateTime = (float)Time.Instance.WorldTime;
							flag = true;
						}
					}
				}
			}
			if (flag)
			{
				return;
			}
		}
		long? contextId = this.Bullet.GetBulletInfo().ContextId;
		BaseActorComponent bulletCharacterActor = this.GetBulletCharacterActor(parameter.BulletTransform, entity);
		HashSet<string> parentIds = BulletUtil.CollectParentsId(bulletInfo);
		BulletController instance = BulletController.Instance;
		BaseActorComponent bulletCharacterActor2 = this.GetBulletCharacterActor(parameter.BulletOwner, entity);
		Entity owner2 = (bulletCharacterActor2 != null) ? bulletCharacterActor2.Entity : null;
		string bulletRowName = createBulletRowName;
		FTransformDouble? initialTransform = new FTransformDouble?((bulletCharacterActor != null) ? bulletCharacterActor.ActorTransform : MathUtils.Instance.DefaultTransformDouble);
		BulletController.BulletCreateParams bulletCreateParams = new BulletController.BulletCreateParams();
		bulletCreateParams.SkillId = bulletInfo.BulletInitParams.SkillId;
		bulletCreateParams.SkillContextId = bulletInfo.BulletInitParams.SkillContextId;
		bulletCreateParams.ParentVictimId = ((entity != null) ? new int?(entity.Id) : null);
		Entity target = bulletInfo.Target;
		bulletCreateParams.ParentTargetId = ((target != null) ? new int?(target.Id) : null);
		bulletCreateParams.ParentId = this.Bullet.Id;
		bulletCreateParams.BattleContext = bulletInfo.BulletInitParams.BattleContext;
		bulletCreateParams.ParentIds = parentIds;
		BulletEntity bulletEntity2 = instance.CreateBulletCustomTarget(owner2, bulletRowName, initialTransform, bulletCreateParams, contextId, EBulletCreateSource.Others);
		if (bulletEntity2 == null)
		{
			return;
		}
		BulletInfo bulletInfo3 = bulletEntity2.GetBulletInfo();
		if (bulletInfo3.BulletDataMain.Render.HandOverParentEffect)
		{
			BulletStaticFunction.HandOverEffects(bulletInfo, bulletInfo3);
			return;
		}
		string attachToBoneName = parameter.AttachToBoneName;
		BaseActorComponent bulletCharacterActor3 = this.GetBulletCharacterActor(parameter.AttachToActor, entity);
		if (bulletCharacterActor3 == null || attachToBoneName == "None")
		{
			return;
		}
		FName? dynamicFName = FNameUtil.GetDynamicFName(attachToBoneName);
		BulletActorComponent component3 = bulletEntity2.GetComponent<BulletActorComponent>();
		component3.SetActorLocation(bulletCharacterActor3.GetSocketLocation(dynamicFName.Value), "unknown", true);
		USkeletalMeshComponent mesh = (bulletCharacterActor3.Owner as ABaseCharacter).Mesh;
		component3.SetAttachToComponent(mesh, dynamicFName.Value, EAttachmentRule.KeepWorld, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, false);
		component3.NeedDetach = true;
	}

	// Token: 0x06018A08 RID: 100872 RVA: 0x0064C278 File Offset: 0x0064A478
	[return: Nullable(2)]
	private BaseActorComponent GetBulletCharacterActor(EBulletObject bulletObject, Entity victim)
	{
		if (bulletObject == EBulletObject.攻击者)
		{
			return this.Bullet.GetBulletInfo().AttackerActorComp;
		}
		if (bulletObject != EBulletObject.受击者)
		{
			return this.Bullet.GetBulletInfo().AttackerActorComp;
		}
		BaseActorComponent component = victim.GetComponent<BaseActorComponent>();
		if (component != null && component.Valid)
		{
			return component;
		}
		return this.Bullet.GetBulletInfo().AttackerActorComp;
	}

	// Token: 0x0400B750 RID: 46928
	[Nullable(2)]
	private readonly LogicDataCreateBullet Parameter;
}
