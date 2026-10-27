using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Data.Level.Vehicle;
using UnrealEngine;

// Token: 0x020032E4 RID: 13028
[NullableContext(1)]
[Nullable(0)]
public class FishingBoatConfig : GongduolaConfig
{
	// Token: 0x0601C580 RID: 116096 RVA: 0x007ED545 File Offset: 0x007EB745
	public FishingBoatConfig(Entity entity, [Nullable(2)] BP_GongduolaConfig_C asset) : base(entity, asset)
	{
	}

	// Token: 0x0601C581 RID: 116097 RVA: 0x007ED550 File Offset: 0x007EB750
	public override VehicleConfig DeepCopy()
	{
		FishingBoatConfig fishingBoatConfig = new FishingBoatConfig(this.VehicleEntity, null);
		this.DeepCopyInternal(fishingBoatConfig);
		return fishingBoatConfig;
	}

	// Token: 0x0601C582 RID: 116098 RVA: 0x007ED574 File Offset: 0x007EB774
	public override void SetBaseStateMoveConfig(UKuroVehicleMovementComponent movement)
	{
		Entity vehicleEntity = this.VehicleEntity;
		GongduolaInputComponent gongduolaInputComponent = (vehicleEntity != null) ? vehicleEntity.GetComponent<GongduolaInputComponent>() : null;
		if (gongduolaInputComponent != null)
		{
			gongduolaInputComponent.TurningForceInputFactor = this.BaseTurningForceForwardFactor;
			gongduolaInputComponent.MaxForwardThreshold = this.BaseMaxForwardThreshold;
			gongduolaInputComponent.MaxRightThreshold = this.BaseMaxRightThreshold;
		}
		float num = 1f;
		Entity vehicleEntity2 = this.VehicleEntity;
		BaseAttributeComponent baseAttributeComponent = (vehicleEntity2 != null) ? vehicleEntity2.GetComponent<BaseAttributeComponent>() : null;
		if (baseAttributeComponent != null)
		{
			num = baseAttributeComponent.GetCurrentValue(EAttributeType.SpeedRatio);
			num /= 10000f;
		}
		this.RealMaxSpeed = this.BaseMaxSpeed * num;
		movement.MaxSpeed = this.RealMaxSpeed;
		movement.MaxAcceleration = this.BaseMaxAcceleration;
		movement.MinAcceleration = this.BaseMinAcceleration;
		movement.MaxBackwardSpeed = this.BaseMaxBackwardSpeed * num;
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

	// Token: 0x0601C583 RID: 116099 RVA: 0x007ED6B8 File Offset: 0x007EB8B8
	public void RefreshSprintConfig(float sprintMaxSpeedRatio, float sprintExceedLimitDuration, float sprintDuration)
	{
		float num = this.RealMaxSpeed * sprintMaxSpeedRatio;
		this.SprintMaxSpeed = ((num <= this.SprintExceedLimitSpeed) ? num : this.SprintExceedLimitSpeed);
		this.SprintExceedLimitDuration = ((sprintExceedLimitDuration <= sprintDuration) ? sprintExceedLimitDuration : sprintDuration);
		this.SprintDuration = sprintDuration;
		this.SprintBrakeAcceleration = 3000f;
	}

	// Token: 0x0601C584 RID: 116100 RVA: 0x007ED706 File Offset: 0x007EB906
	protected override void DeepCopyInternal(VehicleConfig inOut)
	{
		base.DeepCopyInternal(inOut);
		((FishingBoatConfig)inOut).RealMaxSpeed = this.RealMaxSpeed;
	}

	// Token: 0x0400E09F RID: 57503
	private float RealMaxSpeed;
}
