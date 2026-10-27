using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Pawn.Component;
using UnrealEngine;

// Token: 0x020032CC RID: 13004
[NullableContext(2)]
[Nullable(0)]
public class VehicleHitComponent : BaseHitComponent
{
	// Token: 0x0601C40F RID: 115727 RVA: 0x007E06C0 File Offset: 0x007DE8C0
	protected override bool OnStart()
	{
		this.ActorComp = base.Entity.GetComponent<VehicleActorComponent>();
		this.DamageComp = base.Entity.GetComponent<BaseDamageComponent>();
		this.PerformComp = base.Entity.GetComponent<VehiclePerformComponent>();
		this.TimeScaleComp = base.Entity.GetComponent<PawnTimeScaleComponent>();
		VehicleActorComponent actorComp = this.ActorComp;
		CharRenderingComponent charRenderingComponent = (actorComp != null) ? actorComp.Actor.CharRenderingComponent : null;
		if (charRenderingComponent != null)
		{
			this.OnHitMaterialAction = new OnHitMaterialAction(charRenderingComponent, this.TimeScaleComp);
		}
		return true;
	}

	// Token: 0x0601C410 RID: 115728 RVA: 0x007E073F File Offset: 0x007DE93F
	protected override bool OnEnd()
	{
		if (this.OnHitMaterialAction != null)
		{
			this.OnHitMaterialAction.Dispose();
			this.OnHitMaterialAction = null;
		}
		return true;
	}

	// Token: 0x0601C411 RID: 115729 RVA: 0x007E075C File Offset: 0x007DE95C
	[NullableContext(1)]
	public void OnHit(HitInformation hitData, BulletInfo bulletInfo)
	{
		long damageId = hitData.DamageId;
		if (damageId >= 1L)
		{
			long? contextId = bulletInfo.ContextId;
			BaseDamageComponent damageComp = this.DamageComp;
			if (damageComp != null)
			{
				damageComp.ExecuteBulletDamage(hitData.BulletEntityId, new BulletDamageParams
				{
					DamageDataId = damageId,
					SkillLevel = hitData.SkillLevel,
					Attacker = hitData.Attacker,
					DirectTarget = (hitData.DirectTarget ?? base.Entity),
					HitPosition = hitData.HitPosition.ToUeVector(false),
					IsAddEnergy = false,
					IsCounterAttack = false,
					ForceCritical = false,
					IsBlocked = false,
					PartId = -1,
					ExtraRate = 1f,
					BulletId = new long?(hitData.BulletId)
				}, contextId.Value);
			}
		}
		VehiclePerformComponent performComp = this.PerformComp;
		if (performComp == null || performComp.CheckCanPerformHit())
		{
			VehiclePerformComponent performComp2 = this.PerformComp;
			if (performComp2 != null)
			{
				performComp2.OnBulletHit(hitData, bulletInfo);
			}
			this.ProcessOnHitMaterial(hitData);
		}
		CreatureDataComponent attackerCreatureDataComp = bulletInfo.AttackerCreatureDataComp;
		long attackerCreatureDataId = (attackerCreatureDataComp != null) ? attackerCreatureDataComp.GetCreatureDataId() : 0L;
		base.HitRequest(bulletInfo.Entity, attackerCreatureDataId, hitData, 0, false, false, ECounterAttackType.None, null, false, null, null);
	}

	// Token: 0x0601C412 RID: 115730 RVA: 0x007E0898 File Offset: 0x007DEA98
	[NullableContext(1)]
	public void ProcessOnHitMaterial(HitInformation hitData)
	{
		if (!BulletModel.Instance.OpenHitMaterial || this.OnHitMaterialAction == null)
		{
			return;
		}
		FName onHitMaterialEffect = hitData.ReBulletData.Render.OnHitMaterialEffect;
		if (FNameUtil.IsNothing(onHitMaterialEffect))
		{
			return;
		}
		Entity attacker = hitData.Attacker;
		int bulletEntityId = hitData.BulletEntityId;
		int id = attacker.Id;
		if (this.OnHitMaterialAction.ComparePriority((long)bulletEntityId, id))
		{
			this.OnHitMaterialAction.Stop(true);
			string text = null;
			BaseActorComponent baseActorComponent = (attacker != null) ? attacker.GetComponent<BaseActorComponent>() : null;
			if (baseActorComponent != null)
			{
				text = ((baseActorComponent != null) ? baseActorComponent.GetReplaceEffect(onHitMaterialEffect.ToString()) : null);
			}
			this.OnHitMaterialAction.Start(text ?? onHitMaterialEffect.ToString(), BulletModel.Instance.OnHitMaterialMsDelay, (long)bulletEntityId, id, null);
		}
	}

	// Token: 0x0601C413 RID: 115731 RVA: 0x007E0964 File Offset: 0x007DEB64
	[NullableContext(1)]
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		VehicleHitComponent vehicleHitComponent = (VehicleHitComponent)componentTemplate;
		if (base.CanResetComponentProperty("ActorComp"))
		{
			if (vehicleHitComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<VehicleActorComponent>(this.ActorComp), "ActorComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("DamageComp"))
		{
			if (vehicleHitComponent.DamageComp == null)
			{
				this.DamageComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseDamageComponent>(this.DamageComp), "DamageComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("PerformComp"))
		{
			if (vehicleHitComponent.PerformComp == null)
			{
				this.PerformComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<VehiclePerformComponent>(this.PerformComp), "PerformComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TimeScaleComp"))
		{
			if (vehicleHitComponent.TimeScaleComp == null)
			{
				this.TimeScaleComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<PawnTimeScaleComponent>(this.TimeScaleComp), "TimeScaleComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("OnHitMaterialAction"))
		{
			if (vehicleHitComponent.OnHitMaterialAction == null)
			{
				this.OnHitMaterialAction = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<OnHitMaterialAction>(this.OnHitMaterialAction), "OnHitMaterialAction"))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0400DF99 RID: 57241
	private VehicleActorComponent ActorComp;

	// Token: 0x0400DF9A RID: 57242
	private BaseDamageComponent DamageComp;

	// Token: 0x0400DF9B RID: 57243
	private VehiclePerformComponent PerformComp;

	// Token: 0x0400DF9C RID: 57244
	private PawnTimeScaleComponent TimeScaleComp;

	// Token: 0x0400DF9D RID: 57245
	private OnHitMaterialAction OnHitMaterialAction;
}
