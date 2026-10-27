using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Level.Vehicle;
using UnrealEngine;

// Token: 0x020032E9 RID: 13033
[NullableContext(1)]
[Nullable(0)]
public class GongduolaConfig : VehicleConfig
{
	// Token: 0x0601C5A5 RID: 116133 RVA: 0x007EE054 File Offset: 0x007EC254
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

	// Token: 0x0601C5A6 RID: 116134 RVA: 0x007EE310 File Offset: 0x007EC510
	public override VehicleConfig DeepCopy()
	{
		GongduolaConfig gongduolaConfig = new GongduolaConfig(this.VehicleEntity, null);
		this.DeepCopyInternal(gongduolaConfig);
		return gongduolaConfig;
	}

	// Token: 0x0601C5A7 RID: 116135 RVA: 0x007EE334 File Offset: 0x007EC534
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

	// Token: 0x0601C5A8 RID: 116136 RVA: 0x007EE37C File Offset: 0x007EC57C
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

	// Token: 0x0601C5A9 RID: 116137 RVA: 0x007EE3CC File Offset: 0x007EC5CC
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

	// Token: 0x0601C5AA RID: 116138 RVA: 0x007EE448 File Offset: 0x007EC648
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

	// Token: 0x0601C5AB RID: 116139 RVA: 0x007EE550 File Offset: 0x007EC750
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

	// Token: 0x0601C5AC RID: 116140 RVA: 0x007EE657 File Offset: 0x007EC857
	public void SetBuoyancyRelatedConfig(UKuroVehicleMovementComponent movement)
	{
		movement.MaxFloatingSpeed = this.MaxFloatingSpeed;
		movement.FloatingFrictionFactor = this.FloatingFrictionFactor;
		movement.BuoyancyBalanceRatio = this.BuoyancyBalanceRatio;
		movement.StrandedWaterDepthThreshold = this.StrandedWaterDepthThreshold;
	}

	// Token: 0x0601C5AD RID: 116141 RVA: 0x007EE68C File Offset: 0x007EC88C
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

	// Token: 0x0400E0AD RID: 57517
	public float RotaryIntertia;

	// Token: 0x0400E0AE RID: 57518
	public float SpeedImpactFactor;

	// Token: 0x0400E0AF RID: 57519
	public float RotationImpactFactor;

	// Token: 0x0400E0B0 RID: 57520
	public float TurnForwardInputMinX;

	// Token: 0x0400E0B1 RID: 57521
	public float TurnBackwardInputMaxX;

	// Token: 0x0400E0B2 RID: 57522
	public float MaxFloatingSpeed;

	// Token: 0x0400E0B3 RID: 57523
	public float FloatingFrictionFactor;

	// Token: 0x0400E0B4 RID: 57524
	public float BuoyancyBalanceRatio;

	// Token: 0x0400E0B5 RID: 57525
	public float StrandedWaterDepthThreshold;

	// Token: 0x0400E0B6 RID: 57526
	public float BaseMaxSpeed;

	// Token: 0x0400E0B7 RID: 57527
	public float BaseMaxAcceleration;

	// Token: 0x0400E0B8 RID: 57528
	public float BaseMinAcceleration;

	// Token: 0x0400E0B9 RID: 57529
	public float BaseBrakeAcceleration;

	// Token: 0x0400E0BA RID: 57530
	public float BaseMaxBackwardSpeed;

	// Token: 0x0400E0BB RID: 57531
	public float BaseBackwardAcceleration;

	// Token: 0x0400E0BC RID: 57532
	public float BaseMaxRotYawAcc;

	// Token: 0x0400E0BD RID: 57533
	public float BaseMinRotYawAcc;

	// Token: 0x0400E0BE RID: 57534
	public float BaseRotAngleCoef;

	// Token: 0x0400E0BF RID: 57535
	public float BaseRotSpeedCoef;

	// Token: 0x0400E0C0 RID: 57536
	public float BaseRotConstCoef;

	// Token: 0x0400E0C1 RID: 57537
	public float BaseMinFriction;

	// Token: 0x0400E0C2 RID: 57538
	public float BaseMaxFriction;

	// Token: 0x0400E0C3 RID: 57539
	public float BaseMaxRotationSpeed;

	// Token: 0x0400E0C4 RID: 57540
	public float BaseRotFrictionFactor;

	// Token: 0x0400E0C5 RID: 57541
	public float BaseStaticRotFriction;

	// Token: 0x0400E0C6 RID: 57542
	public float BaseTurningForceForwardFactor;

	// Token: 0x0400E0C7 RID: 57543
	public float BaseMaxForwardThreshold;

	// Token: 0x0400E0C8 RID: 57544
	public float BaseMaxRightThreshold;

	// Token: 0x0400E0C9 RID: 57545
	public float SprintExceedLimitSpeed;

	// Token: 0x0400E0CA RID: 57546
	public float SprintExceedLimitDuration;

	// Token: 0x0400E0CB RID: 57547
	public float SprintMaxSpeed;

	// Token: 0x0400E0CC RID: 57548
	public float SprintMaxAcceleration;

	// Token: 0x0400E0CD RID: 57549
	public float SprintMinAcceleration;

	// Token: 0x0400E0CE RID: 57550
	public float SprintBrakeAcceleration;

	// Token: 0x0400E0CF RID: 57551
	public float SprintMaxBackwardSpeed;

	// Token: 0x0400E0D0 RID: 57552
	public float SprintBackwardAcceleration;

	// Token: 0x0400E0D1 RID: 57553
	public float SprintMaxRotYawAcc;

	// Token: 0x0400E0D2 RID: 57554
	public float SprintMinRotYawAcc;

	// Token: 0x0400E0D3 RID: 57555
	public float SprintDuration;

	// Token: 0x0400E0D4 RID: 57556
	public float SprintStopSpeed;

	// Token: 0x0400E0D5 RID: 57557
	public float SprintExtraFriction;

	// Token: 0x0400E0D6 RID: 57558
	public float SprintRotAngleCoef;

	// Token: 0x0400E0D7 RID: 57559
	public float SprintRotSpeedCoef;

	// Token: 0x0400E0D8 RID: 57560
	public float SprintRotConstCoef;

	// Token: 0x0400E0D9 RID: 57561
	public float SprintMinFriction;

	// Token: 0x0400E0DA RID: 57562
	public float SprintMaxFriction;

	// Token: 0x0400E0DB RID: 57563
	public float SprintMaxRotationSpeed;

	// Token: 0x0400E0DC RID: 57564
	public float SprintRotFrictionFactor;

	// Token: 0x0400E0DD RID: 57565
	public float SprintStaticRotFriction;

	// Token: 0x0400E0DE RID: 57566
	public float SprintForceInputDuration;

	// Token: 0x0400E0DF RID: 57567
	public float SprintTurningForceForwardFactor;

	// Token: 0x0400E0E0 RID: 57568
	public float SprintMaxForwardThreshold;

	// Token: 0x0400E0E1 RID: 57569
	public float SprintMaxRightThreshold;

	// Token: 0x0400E0E2 RID: 57570
	public float SprintCoolDown;

	// Token: 0x0400E0E3 RID: 57571
	public int SprintMaxUsableCount;
}
