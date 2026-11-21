using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Level.Vehicle;
using UnrealEngine;

// Token: 0x0200285B RID: 10331
[NullableContext(1)]
[Nullable(0)]
public class GongduolaConfig : VehicleConfig
{
	// Token: 0x0601A25C RID: 107100 RVA: 0x00814788 File Offset: 0x00812988
	public GongduolaConfig(Entity entity, [Nullable(2)] BP_GongduolaConfig_C asset) : base(entity, asset)
	{
		if (asset == null || !asset.IsValid())
		{
			return;
		}
		this.RotaryIntertia = asset.转动惯量;
		this.SpeedImpactFactor = asset.速度冲击力系数;
		this.RotationImpactFactor = asset.旋转冲击力系数;
		this.TurnForwardInputMinX = asset.前向转弯最小X输入;
		this.TurnBackwardInputMaxX = asset.后向转向最大X输入;
		this.MaxFloatingSpeed = asset.最大上浮速度;
		this.FloatingFrictionFactor = asset.漂浮阻力系数;
		this.BuoyancyBalanceRatio = asset.浮力平衡位置;
		this.StrandedWaterDepthThreshold = asset.搁浅位置;
		this.BaseMaxSpeed = asset.前进最大移动速度;
		this.BaseMaxAcceleration = asset.常态前进加速度;
		this.BaseMinAcceleration = asset.常态最小加速度;
		this.BaseMaxRotYawAcc = asset.常态最大转向加速度;
		this.BaseMinRotYawAcc = asset.常态最小转向加速度;
		this.BaseMaxBackwardSpeed = asset.常态后退最大移动速度;
		this.BaseBackwardAcceleration = asset.常态后退加速度;
		this.BaseBrakeAcceleration = asset.常态刹车加速度;
		this.BaseTurningForceForwardFactor = asset.常态转向强制前向输入系数;
		this.BaseMaxForwardThreshold = asset.常态最大前后输入阈值;
		this.BaseMaxRightThreshold = asset.常态最大左右输入阈值;
		this.BaseRotAngleCoef = asset.常态转向公式角度修正系数;
		this.BaseRotSpeedCoef = asset.常态转向公式速度修正系数;
		this.BaseRotConstCoef = asset.常态转向公式最终修正系数;
		this.BaseMinFriction = asset.常态径向运动摩擦力;
		this.BaseMaxFriction = asset.常态横向运动摩擦力;
		this.BaseMaxRotationSpeed = asset.常态最大转向速度;
		this.BaseRotFrictionFactor = asset.常态转向摩擦力系数;
		this.BaseStaticRotFriction = asset.常态转向静止摩擦力;
		this.SprintExceedLimitSpeed = asset.冲刺超限移动速度;
		this.SprintExceedLimitDuration = asset.冲刺超限持续时间;
		this.SprintMaxSpeed = asset.冲刺最大移动速度;
		this.SprintMaxAcceleration = asset.冲刺前进加速度;
		this.SprintMinAcceleration = asset.冲刺最小加速度;
		this.SprintMaxRotYawAcc = asset.冲刺最大转向加速度;
		this.SprintMinRotYawAcc = asset.冲刺最小转向加速度;
		this.SprintMaxBackwardSpeed = asset.冲刺后退最大移动速度;
		this.SprintBackwardAcceleration = asset.冲刺后退加速度;
		this.SprintBrakeAcceleration = asset.冲刺刹车加速度;
		this.SprintDuration = asset.冲刺持续时间;
		this.SprintExtraFriction = asset.超出最大速度时的额外摩擦力;
		this.SprintTurningForceForwardFactor = asset.冲刺转向强制前向输入系数;
		this.SprintMaxForwardThreshold = asset.冲刺最大前后输入阈值;
		this.SprintMaxRightThreshold = asset.冲刺最大左右输入阈值;
		this.SprintStopSpeed = asset.冲刺停止速度;
		this.SprintCoolDown = asset.冲刺冷却时间;
		this.SprintMaxUsableCount = asset.冲刺最大使用次数;
		this.SprintRotAngleCoef = asset.冲刺转向公式角度修正系数;
		this.SprintRotSpeedCoef = asset.冲刺转向公式速度修正系数;
		this.SprintRotConstCoef = asset.冲刺转向公式最终修正系数;
		this.SprintMinFriction = asset.冲刺径向运动摩擦力;
		this.SprintMaxFriction = asset.冲刺横向运动摩擦力;
		this.SprintMaxRotationSpeed = asset.冲刺最大转向速度;
		this.SprintRotFrictionFactor = asset.冲刺转向摩擦力系数;
		this.SprintStaticRotFriction = asset.冲刺转向静止摩擦力;
		this.SprintForceInputDuration = asset.冲刺固定前向输入时间;
	}

	// Token: 0x0601A25D RID: 107101 RVA: 0x00814A44 File Offset: 0x00812C44
	public override VehicleConfig DeepCopy()
	{
		GongduolaConfig gongduolaConfig = new GongduolaConfig(this.VehicleEntity, null);
		this.DeepCopyInternal(gongduolaConfig);
		return gongduolaConfig;
	}

	// Token: 0x0601A25E RID: 107102 RVA: 0x00814A68 File Offset: 0x00812C68
	public override bool Init()
	{
		if (!base.Init())
		{
			return false;
		}
		Entity vehicleEntity = this.VehicleEntity;
		VehicleActorComponent vehicleActorComponent = (vehicleEntity != null) ? vehicleEntity.GetComponent<VehicleActorComponent>() : null;
		if (vehicleActorComponent == null)
		{
			return false;
		}
		this.InitGongduolaMovement(vehicleActorComponent.Actor.VehicleMovementComponent);
		this.InitGongduolaBaseInfo();
		return true;
	}

	// Token: 0x0601A25F RID: 107103 RVA: 0x00814AB0 File Offset: 0x00812CB0
	protected void InitGongduolaBaseInfo()
	{
		Entity vehicleEntity = this.VehicleEntity;
		GongduolaPerformComponent gongduolaPerformComponent = (vehicleEntity != null) ? vehicleEntity.GetComponent<GongduolaPerformComponent>() : null;
		if (gongduolaPerformComponent == null)
		{
			return;
		}
		gongduolaPerformComponent.SprintStopSpeedSquared = this.SprintStopSpeed * this.SprintStopSpeed;
		gongduolaPerformComponent.SprintCd = this.SprintCoolDown;
		gongduolaPerformComponent.SprintUsableCount = this.SprintMaxUsableCount;
	}

	// Token: 0x0601A260 RID: 107104 RVA: 0x00814B00 File Offset: 0x00812D00
	protected void InitGongduolaMovement(UKuroVehicleMovementComponent movement)
	{
		movement.RotaryInertia = this.RotaryIntertia;
		movement.SpeedImpactFactor = this.SpeedImpactFactor;
		movement.RotationImpactFactor = this.RotationImpactFactor;
		movement.ExtraFrictionWhenExceedMaxSpeed = this.SprintExtraFriction;
		this.SetBaseStateMoveConfig(movement);
		this.SetBuoyancyRelatedConfig(movement);
		Entity vehicleEntity = this.VehicleEntity;
		GongduolaInputComponent gongduolaInputComponent = (vehicleEntity != null) ? vehicleEntity.GetComponent<GongduolaInputComponent>() : null;
		if (gongduolaInputComponent != null)
		{
			gongduolaInputComponent.TurnForwardInputMinX = this.TurnForwardInputMinX;
			gongduolaInputComponent.TurnBackwardInputMaxX = this.TurnBackwardInputMaxX;
		}
	}

	// Token: 0x0601A261 RID: 107105 RVA: 0x00814B7C File Offset: 0x00812D7C
	public virtual void SetBaseStateMoveConfig(UKuroVehicleMovementComponent movement)
	{
		Entity vehicleEntity = this.VehicleEntity;
		GongduolaInputComponent gongduolaInputComponent = (vehicleEntity != null) ? vehicleEntity.GetComponent<GongduolaInputComponent>() : null;
		if (gongduolaInputComponent != null)
		{
			gongduolaInputComponent.TurningForceInputFactor = this.BaseTurningForceForwardFactor;
			gongduolaInputComponent.MaxForwardThreshold = this.BaseMaxForwardThreshold;
			gongduolaInputComponent.MaxRightThreshold = this.BaseMaxRightThreshold;
		}
		movement.MaxSpeed = this.BaseMaxSpeed;
		movement.MaxAcceleration = this.BaseMaxAcceleration;
		movement.MinAcceleration = this.BaseMinAcceleration;
		movement.MaxBackwardSpeed = this.BaseMaxBackwardSpeed;
		movement.MaxBackwardAcceleration = this.BaseBackwardAcceleration;
		movement.MaxBrakeAcceleration = this.BaseBrakeAcceleration;
		movement.MaxRotationYawAcceleration = this.BaseMaxRotYawAcc;
		movement.MinRotationYawAcceleration = this.BaseMinRotYawAcc;
		movement.RotAngleCoef = this.BaseRotAngleCoef;
		movement.RotSpeedCoef = this.BaseRotSpeedCoef;
		movement.RotConstCoef = this.BaseRotConstCoef;
		movement.MinFriction = this.BaseMinFriction;
		movement.MaxFriction = this.BaseMaxFriction;
		movement.MaxRotationSpeed = this.BaseMaxRotationSpeed;
		movement.RotFrictionFactor = this.BaseRotFrictionFactor;
		movement.StaticRotFriction = this.BaseStaticRotFriction;
	}

	// Token: 0x0601A262 RID: 107106 RVA: 0x00814C84 File Offset: 0x00812E84
	public void SetSprintStateMoveConfig(UKuroVehicleMovementComponent movement)
	{
		Entity vehicleEntity = this.VehicleEntity;
		GongduolaInputComponent gongduolaInputComponent = (vehicleEntity != null) ? vehicleEntity.GetComponent<GongduolaInputComponent>() : null;
		if (gongduolaInputComponent != null)
		{
			gongduolaInputComponent.TurningForceInputFactor = this.SprintTurningForceForwardFactor;
			gongduolaInputComponent.MaxForwardThreshold = this.SprintMaxForwardThreshold;
			gongduolaInputComponent.MaxRightThreshold = this.SprintMaxRightThreshold;
		}
		movement.MaxSpeed = this.SprintMaxSpeed;
		movement.MaxAcceleration = this.SprintMaxAcceleration;
		movement.MinAcceleration = this.SprintMinAcceleration;
		movement.MaxBackwardSpeed = this.SprintMaxBackwardSpeed;
		movement.MaxBackwardAcceleration = this.SprintBackwardAcceleration;
		movement.MaxBrakeAcceleration = this.SprintBrakeAcceleration;
		movement.MaxRotationYawAcceleration = this.SprintMaxRotYawAcc;
		movement.MinRotationYawAcceleration = this.SprintMinRotYawAcc;
		movement.RotAngleCoef = this.SprintRotAngleCoef;
		movement.RotSpeedCoef = this.SprintRotSpeedCoef;
		movement.RotConstCoef = this.SprintRotConstCoef;
		movement.MinFriction = this.SprintMinFriction;
		movement.MaxFriction = this.SprintMaxFriction;
		movement.MaxRotationSpeed = this.SprintMaxRotationSpeed;
		movement.RotFrictionFactor = this.SprintRotFrictionFactor;
		movement.StaticRotFriction = this.SprintStaticRotFriction;
	}

	// Token: 0x0601A263 RID: 107107 RVA: 0x00814D8B File Offset: 0x00812F8B
	public void SetBuoyancyRelatedConfig(UKuroVehicleMovementComponent movement)
	{
		movement.MaxFloatingSpeed = this.MaxFloatingSpeed;
		movement.FloatingFrictionFactor = this.FloatingFrictionFactor;
		movement.BuoyancyBalanceRatio = this.BuoyancyBalanceRatio;
		movement.StrandedWaterDepthThreshold = this.StrandedWaterDepthThreshold;
	}

	// Token: 0x0601A264 RID: 107108 RVA: 0x00814DC0 File Offset: 0x00812FC0
	protected override void DeepCopyInternal(VehicleConfig inOut)
	{
		base.DeepCopyInternal(inOut);
		GongduolaConfig gongduolaConfig = (GongduolaConfig)inOut;
		gongduolaConfig.RotaryIntertia = this.RotaryIntertia;
		gongduolaConfig.SpeedImpactFactor = this.SpeedImpactFactor;
		gongduolaConfig.RotationImpactFactor = this.RotationImpactFactor;
		gongduolaConfig.TurnForwardInputMinX = this.TurnForwardInputMinX;
		gongduolaConfig.TurnBackwardInputMaxX = this.TurnBackwardInputMaxX;
		gongduolaConfig.MaxFloatingSpeed = this.MaxFloatingSpeed;
		gongduolaConfig.FloatingFrictionFactor = this.FloatingFrictionFactor;
		gongduolaConfig.BuoyancyBalanceRatio = this.BuoyancyBalanceRatio;
		gongduolaConfig.StrandedWaterDepthThreshold = this.StrandedWaterDepthThreshold;
		gongduolaConfig.BaseMaxSpeed = this.BaseMaxSpeed;
		gongduolaConfig.BaseMaxAcceleration = this.BaseMaxAcceleration;
		gongduolaConfig.BaseMinAcceleration = this.BaseMinAcceleration;
		gongduolaConfig.BaseMaxRotYawAcc = this.BaseMaxRotYawAcc;
		gongduolaConfig.BaseMinRotYawAcc = this.BaseMinRotYawAcc;
		gongduolaConfig.BaseMaxBackwardSpeed = this.BaseMaxBackwardSpeed;
		gongduolaConfig.BaseBackwardAcceleration = this.BaseBackwardAcceleration;
		gongduolaConfig.BaseBrakeAcceleration = this.BaseBrakeAcceleration;
		gongduolaConfig.BaseTurningForceForwardFactor = this.BaseTurningForceForwardFactor;
		gongduolaConfig.BaseMaxForwardThreshold = this.BaseMaxForwardThreshold;
		gongduolaConfig.BaseMaxRightThreshold = this.BaseMaxRightThreshold;
		gongduolaConfig.BaseRotAngleCoef = this.BaseRotAngleCoef;
		gongduolaConfig.BaseRotSpeedCoef = this.BaseRotSpeedCoef;
		gongduolaConfig.BaseRotConstCoef = this.BaseRotConstCoef;
		gongduolaConfig.BaseMinFriction = this.BaseMinFriction;
		gongduolaConfig.BaseMaxFriction = this.BaseMaxFriction;
		gongduolaConfig.BaseMaxRotationSpeed = this.BaseMaxRotationSpeed;
		gongduolaConfig.BaseRotFrictionFactor = this.BaseRotFrictionFactor;
		gongduolaConfig.BaseStaticRotFriction = this.BaseStaticRotFriction;
		gongduolaConfig.SprintExceedLimitSpeed = this.SprintExceedLimitSpeed;
		gongduolaConfig.SprintMaxSpeed = this.SprintMaxSpeed;
		gongduolaConfig.SprintMaxAcceleration = this.SprintMaxAcceleration;
		gongduolaConfig.SprintMinAcceleration = this.SprintMinAcceleration;
		gongduolaConfig.SprintMaxRotYawAcc = this.SprintMaxRotYawAcc;
		gongduolaConfig.SprintMinRotYawAcc = this.SprintMinRotYawAcc;
		gongduolaConfig.SprintMaxBackwardSpeed = this.SprintMaxBackwardSpeed;
		gongduolaConfig.SprintBackwardAcceleration = this.SprintBackwardAcceleration;
		gongduolaConfig.SprintBrakeAcceleration = this.SprintBrakeAcceleration;
		gongduolaConfig.SprintDuration = this.SprintDuration;
		gongduolaConfig.SprintExtraFriction = this.SprintExtraFriction;
		gongduolaConfig.SprintTurningForceForwardFactor = this.SprintTurningForceForwardFactor;
		gongduolaConfig.SprintMaxForwardThreshold = this.SprintMaxForwardThreshold;
		gongduolaConfig.SprintMaxRightThreshold = this.SprintMaxRightThreshold;
		gongduolaConfig.SprintStopSpeed = this.SprintStopSpeed;
		gongduolaConfig.SprintCoolDown = this.SprintCoolDown;
		gongduolaConfig.SprintMaxUsableCount = this.SprintMaxUsableCount;
		gongduolaConfig.SprintRotAngleCoef = this.SprintRotAngleCoef;
		gongduolaConfig.SprintRotSpeedCoef = this.SprintRotSpeedCoef;
		gongduolaConfig.SprintRotConstCoef = this.SprintRotConstCoef;
		gongduolaConfig.SprintMinFriction = this.SprintMinFriction;
		gongduolaConfig.SprintMaxFriction = this.SprintMaxFriction;
		gongduolaConfig.SprintMaxRotationSpeed = this.SprintMaxRotationSpeed;
		gongduolaConfig.SprintRotFrictionFactor = this.SprintRotFrictionFactor;
		gongduolaConfig.SprintStaticRotFriction = this.SprintStaticRotFriction;
		gongduolaConfig.SprintForceInputDuration = this.SprintForceInputDuration;
	}

	// Token: 0x0400E558 RID: 58712
	public float RotaryIntertia;

	// Token: 0x0400E559 RID: 58713
	public float SpeedImpactFactor;

	// Token: 0x0400E55A RID: 58714
	public float RotationImpactFactor;

	// Token: 0x0400E55B RID: 58715
	public float TurnForwardInputMinX;

	// Token: 0x0400E55C RID: 58716
	public float TurnBackwardInputMaxX;

	// Token: 0x0400E55D RID: 58717
	public float MaxFloatingSpeed;

	// Token: 0x0400E55E RID: 58718
	public float FloatingFrictionFactor;

	// Token: 0x0400E55F RID: 58719
	public float BuoyancyBalanceRatio;

	// Token: 0x0400E560 RID: 58720
	public float StrandedWaterDepthThreshold;

	// Token: 0x0400E561 RID: 58721
	public float BaseMaxSpeed;

	// Token: 0x0400E562 RID: 58722
	public float BaseMaxAcceleration;

	// Token: 0x0400E563 RID: 58723
	public float BaseMinAcceleration;

	// Token: 0x0400E564 RID: 58724
	public float BaseBrakeAcceleration;

	// Token: 0x0400E565 RID: 58725
	public float BaseMaxBackwardSpeed;

	// Token: 0x0400E566 RID: 58726
	public float BaseBackwardAcceleration;

	// Token: 0x0400E567 RID: 58727
	public float BaseMaxRotYawAcc;

	// Token: 0x0400E568 RID: 58728
	public float BaseMinRotYawAcc;

	// Token: 0x0400E569 RID: 58729
	public float BaseRotAngleCoef;

	// Token: 0x0400E56A RID: 58730
	public float BaseRotSpeedCoef;

	// Token: 0x0400E56B RID: 58731
	public float BaseRotConstCoef;

	// Token: 0x0400E56C RID: 58732
	public float BaseMinFriction;

	// Token: 0x0400E56D RID: 58733
	public float BaseMaxFriction;

	// Token: 0x0400E56E RID: 58734
	public float BaseMaxRotationSpeed;

	// Token: 0x0400E56F RID: 58735
	public float BaseRotFrictionFactor;

	// Token: 0x0400E570 RID: 58736
	public float BaseStaticRotFriction;

	// Token: 0x0400E571 RID: 58737
	public float BaseTurningForceForwardFactor;

	// Token: 0x0400E572 RID: 58738
	public float BaseMaxForwardThreshold;

	// Token: 0x0400E573 RID: 58739
	public float BaseMaxRightThreshold;

	// Token: 0x0400E574 RID: 58740
	public float SprintExceedLimitSpeed;

	// Token: 0x0400E575 RID: 58741
	public float SprintExceedLimitDuration;

	// Token: 0x0400E576 RID: 58742
	public float SprintMaxSpeed;

	// Token: 0x0400E577 RID: 58743
	public float SprintMaxAcceleration;

	// Token: 0x0400E578 RID: 58744
	public float SprintMinAcceleration;

	// Token: 0x0400E579 RID: 58745
	public float SprintBrakeAcceleration;

	// Token: 0x0400E57A RID: 58746
	public float SprintMaxBackwardSpeed;

	// Token: 0x0400E57B RID: 58747
	public float SprintBackwardAcceleration;

	// Token: 0x0400E57C RID: 58748
	public float SprintMaxRotYawAcc;

	// Token: 0x0400E57D RID: 58749
	public float SprintMinRotYawAcc;

	// Token: 0x0400E57E RID: 58750
	public float SprintDuration;

	// Token: 0x0400E57F RID: 58751
	public float SprintStopSpeed;

	// Token: 0x0400E580 RID: 58752
	public float SprintExtraFriction;

	// Token: 0x0400E581 RID: 58753
	public float SprintRotAngleCoef;

	// Token: 0x0400E582 RID: 58754
	public float SprintRotSpeedCoef;

	// Token: 0x0400E583 RID: 58755
	public float SprintRotConstCoef;

	// Token: 0x0400E584 RID: 58756
	public float SprintMinFriction;

	// Token: 0x0400E585 RID: 58757
	public float SprintMaxFriction;

	// Token: 0x0400E586 RID: 58758
	public float SprintMaxRotationSpeed;

	// Token: 0x0400E587 RID: 58759
	public float SprintRotFrictionFactor;

	// Token: 0x0400E588 RID: 58760
	public float SprintStaticRotFriction;

	// Token: 0x0400E589 RID: 58761
	public float SprintForceInputDuration;

	// Token: 0x0400E58A RID: 58762
	public float SprintTurningForceForwardFactor;

	// Token: 0x0400E58B RID: 58763
	public float SprintMaxForwardThreshold;

	// Token: 0x0400E58C RID: 58764
	public float SprintMaxRightThreshold;

	// Token: 0x0400E58D RID: 58765
	public float SprintCoolDown;

	// Token: 0x0400E58E RID: 58766
	public int SprintMaxUsableCount;
}
