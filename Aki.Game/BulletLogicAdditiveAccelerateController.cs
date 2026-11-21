using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;

// Token: 0x0200231F RID: 8991
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class BulletLogicAdditiveAccelerateController : BulletLogicController<LogicDataAdditiveAccelerate, object>
{
	// Token: 0x06016297 RID: 90775 RVA: 0x006712C3 File Offset: 0x0066F4C3
	[NullableContext(1)]
	public BulletLogicAdditiveAccelerateController(LogicDataAdditiveAccelerate bulletLogicBase, Entity bullet) : base(bulletLogicBase, bullet)
	{
		this.BulletInfo = (bullet as BulletEntity).GetBulletInfo();
	}

	// Token: 0x06016298 RID: 90776 RVA: 0x006712E0 File Offset: 0x0066F4E0
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

	// Token: 0x0400BAB9 RID: 47801
	private readonly BulletInfo BulletInfo;
}
