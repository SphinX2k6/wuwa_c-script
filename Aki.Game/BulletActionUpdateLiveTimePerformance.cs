using System;
using System.Collections.Generic;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x02002D9E RID: 11678
public class BulletActionUpdateLiveTimePerformance : BulletActionUpdateLiveTime
{
	// Token: 0x06018864 RID: 100452 RVA: 0x00643CD9 File Offset: 0x00641ED9
	public BulletActionUpdateLiveTimePerformance(EBulletAction type) : base(type)
	{
	}

	// Token: 0x06018865 RID: 100453 RVA: 0x00643CE4 File Offset: 0x00641EE4
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

	// Token: 0x06018866 RID: 100454 RVA: 0x00643D21 File Offset: 0x00641F21
	public override void AfterTick(float delta)
	{
		base.AfterTick(delta);
		if (this.BulletInfo.NeedDestroy)
		{
			return;
		}
		this.CheckPerformanceCollision();
	}

	// Token: 0x06018867 RID: 100455 RVA: 0x00643D40 File Offset: 0x00641F40
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

	// Token: 0x06018868 RID: 100456 RVA: 0x00643D90 File Offset: 0x00641F90
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

	// Token: 0x06018869 RID: 100457 RVA: 0x00643E20 File Offset: 0x00642020
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
