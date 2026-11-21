using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Data.Level.Vehicle;
using UnrealEngine;

// Token: 0x02002856 RID: 10326
[NullableContext(1)]
[Nullable(0)]
public class FishingBoatConfig : GongduolaConfig
{
	// Token: 0x0601A226 RID: 107046 RVA: 0x00813CCD File Offset: 0x00811ECD
	public FishingBoatConfig(Entity entity, [Nullable(2)] BP_GongduolaConfig_C asset) : base(entity, asset)
	{
	}

	// Token: 0x0601A227 RID: 107047 RVA: 0x00813CD8 File Offset: 0x00811ED8
	public override VehicleConfig DeepCopy()
	{
		FishingBoatConfig fishingBoatConfig = new FishingBoatConfig(this.VehicleEntity, null);
		this.DeepCopyInternal(fishingBoatConfig);
		return fishingBoatConfig;
	}

	// Token: 0x0601A228 RID: 107048 RVA: 0x00813CFC File Offset: 0x00811EFC
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

	// Token: 0x0601A229 RID: 107049 RVA: 0x00813E40 File Offset: 0x00812040
	public void RefreshSprintConfig(float sprintMaxSpeedRatio, float sprintExceedLimitDuration, float sprintDuration)
	{
		float num = this.RealMaxSpeed * sprintMaxSpeedRatio;
		this.SprintMaxSpeed = ((num <= this.SprintExceedLimitSpeed) ? num : this.SprintExceedLimitSpeed);
		this.SprintExceedLimitDuration = ((sprintExceedLimitDuration <= sprintDuration) ? sprintExceedLimitDuration : sprintDuration);
		this.SprintDuration = sprintDuration;
		this.SprintBrakeAcceleration = 3000f;
	}

	// Token: 0x0601A22A RID: 107050 RVA: 0x00813E8E File Offset: 0x0081208E
	protected override void DeepCopyInternal(VehicleConfig inOut)
	{
		base.DeepCopyInternal(inOut);
		((FishingBoatConfig)inOut).RealMaxSpeed = this.RealMaxSpeed;
	}

	// Token: 0x0400E54A RID: 58698
	private float RealMaxSpeed;
}
