using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;

// Token: 0x02002DC5 RID: 11717
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class BulletLogicAdditiveAccelerateController : BulletLogicController<LogicDataAdditiveAccelerate, object>
{
	// Token: 0x060189EF RID: 100847 RVA: 0x0064B4DF File Offset: 0x006496DF
	[NullableContext(1)]
	public BulletLogicAdditiveAccelerateController(LogicDataAdditiveAccelerate bulletLogicBase, Entity bullet) : base(bulletLogicBase, bullet)
	{
		this.BulletInfo = (bullet as BulletEntity).GetBulletInfo();
	}

	// Token: 0x060189F0 RID: 100848 RVA: 0x0064B4FC File Offset: 0x006496FC
	public override void BulletLogicAction(object param = null)
	{
		LogicDataAdditiveAccelerate logicController = this.LogicController;
		if (this.BulletInfo.BulletDataMain.Move.Trajectory == EMoveTrajectory.限时命中子弹)
		{
			return;
		}
		BulletMoveInfo moveInfo = this.BulletInfo.MoveInfo;
		CharacterMoveComponent attackerMoveComp = this.BulletInfo.AttackerMoveComp;
		FVector acceleration;
		if (attackerMoveComp != null && attackerMoveComp.IsStandardGravity)
		{
			moveInfo.AdditiveAccelerateCurve = logicController.AccelerationCurve;
			Vector baseAdditiveAccelerate = moveInfo.BaseAdditiveAccelerate;
			acceleration = logicController.Acceleration;
			baseAdditiveAccelerate.FromUeVector(acceleration);
			Vector additiveAccelerate = moveInfo.AdditiveAccelerate;
			acceleration = logicController.Acceleration;
			additiveAccelerate.FromUeVector(acceleration);
			return;
		}
		Quat quat = Quat.Create(0.0, 0.0, 0.0, 1.0);
		GravityUtils.Instance.GetBaseQuatInGravityForActor(this.BulletInfo.AttackerActorComp, quat);
		Vector vector = BulletPool.CreateVector(false);
		Vector vector2 = vector;
		acceleration = logicController.Acceleration;
		vector2.FromUeVector(acceleration);
		quat.RotateVector(vector, moveInfo.BaseAdditiveAccelerate);
		BulletPool.RecycleVector(vector);
		moveInfo.AdditiveAccelerate.FromUeVector(moveInfo.BaseAdditiveAccelerate);
	}

	// Token: 0x0400B73E RID: 46910
	private readonly BulletInfo BulletInfo;
}
