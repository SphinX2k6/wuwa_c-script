using System;
using System.Collections.Generic;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x020022F8 RID: 8952
public class BulletActionUpdateLiveTimePerformance : BulletActionUpdateLiveTime
{
	// Token: 0x06016109 RID: 90377 RVA: 0x00669B15 File Offset: 0x00667D15
	public BulletActionUpdateLiveTimePerformance(EBulletAction type) : base(type)
	{
	}

	// Token: 0x0601610A RID: 90378 RVA: 0x00669B20 File Offset: 0x00667D20
	protected override void OnExecute()
	{
		base.OnExecute();
		AActor actor = this.BulletInfo.Actor;
		if (actor != null && actor.IsValid())
		{
			actor.K2_SetDeferedConcurrentUpdateTransform(true);
			this.BulletInfo.DeferredConcurrentUpdateTransform = true;
		}
	}

	// Token: 0x0601610B RID: 90379 RVA: 0x00669B5D File Offset: 0x00667D5D
	public override void AfterTick(float delta)
	{
		base.AfterTick(delta);
		if (this.BulletInfo.NeedDestroy)
		{
			return;
		}
		this.CheckPerformanceCollision();
	}

	// Token: 0x0601610C RID: 90380 RVA: 0x00669B7C File Offset: 0x00667D7C
	private void CheckPerformanceCollision()
	{
		BulletDataMain bulletDataMain = this.BulletInfo.BulletDataMain;
		if (bulletDataMain.Logic.DestroyOnHitObstacle && BulletCollisionSystem.CheckHitGround(this.BulletInfo, false))
		{
			this.ProcessHitGround();
			return;
		}
		if (bulletDataMain.Execution.ReboundBitMask > 0)
		{
			this.CheckRebound();
		}
	}

	// Token: 0x0601610D RID: 90381 RVA: 0x00669BCC File Offset: 0x00667DCC
	private void ProcessHitGround()
	{
		BulletInfo bulletInfo = this.BulletInfo;
		bool openDestroyLog = BulletConstant.Instance.OpenDestroyLog;
		BulletHitActorData bulletHitActorData = BulletPool.CreateBulletHitActorData();
		bulletHitActorData.Type = EBulletHitActorType.Obstacles;
		Vector vector = BulletPool.CreateVector(false);
		vector.FromUeVector(bulletInfo.ActorComponent.ActorLocationProxy);
		BulletUtil.SummonBullet(bulletInfo, EBulletChildrenType.OnHitObstacle, null, false, null, null, true);
		BulletActionLogicComponent actionLogicComponent = bulletInfo.ActionLogicComponent;
		if (actionLogicComponent != null)
		{
			actionLogicComponent.ActionHitObstacles(bulletHitActorData);
		}
		BulletStaticFunction.BulletHitEffect(bulletInfo, vector.ToUeVector(false));
		BulletPool.RecycleVector(vector);
		BulletPool.RecycleBulletHitActorData(bulletHitActorData);
		BulletController.Instance.DestroyBullet(bulletInfo.BulletEntityId, false, EBulletDestroyReason.Normal, false);
	}

	// Token: 0x0601610E RID: 90382 RVA: 0x00669C5C File Offset: 0x00667E5C
	private void CheckRebound()
	{
		BulletInfo bulletInfo = this.BulletInfo;
		BulletDataMain bulletDataMain = bulletInfo.BulletDataMain;
		foreach (int num in BulletModel.Instance.GetAttackers())
		{
			if (bulletInfo.AttackerId != num)
			{
				IReadOnlyCollection<BulletEntity> bulletSetByAttacker = BulletModel.Instance.GetBulletSetByAttacker(num);
				if (bulletSetByAttacker != null)
				{
					foreach (BulletEntity bulletEntity in bulletSetByAttacker)
					{
						BulletInfo bulletInfo2 = bulletEntity.GetBulletInfo();
						if ((bulletDataMain.Execution.ReboundBitMask & bulletInfo2.BulletDataMain.Logic.ReboundChannel) > 0)
						{
							bool openDestroyLog = BulletConstant.Instance.OpenDestroyLog;
							BulletActionLogicComponent actionLogicComponent = bulletInfo.ActionLogicComponent;
							if (actionLogicComponent != null)
							{
								actionLogicComponent.ActionRebound(bulletInfo2);
							}
							BulletController.Instance.DestroyBullet(bulletInfo.BulletEntityId, false, EBulletDestroyReason.Normal, false);
							EventSystem.Instance.EmitWithTarget<Entity, int>(bulletInfo2.Attacker, EEventName.BulletRebound, bulletInfo.Attacker, bulletInfo.BulletInitParams.SkillId);
							return;
						}
					}
				}
			}
		}
	}
}
