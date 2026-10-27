using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.Vehicle
{
	// Token: 0x02006BB9 RID: 27577
	public class LevelEventVehicleSetSpeedImmediately : LevelEventBase
	{
		// Token: 0x06044341 RID: 279361 RVA: 0x010CFF57 File Offset: 0x010CE157
		public LevelEventVehicleSetSpeedImmediately(int id) : base(id)
		{
		}

		// Token: 0x06044342 RID: 279362 RVA: 0x010CFF60 File Offset: 0x010CE160
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			ISetVehicleSpeedImmediatelyType setSpeedConfig = (inParams as VehicleSetSpeedImmediately).SetSpeedConfig;
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			CharacterActorComponent characterActorComponent = (baseCharacter != null) ? baseCharacter.CharacterActorComponent : null;
			if (characterActorComponent == null || !characterActorComponent.Valid)
			{
				return;
			}
			CharacterDriveVehicleComponent characterDriveVehicleComponent = characterActorComponent.Entity.CheckGetComponent<CharacterDriveVehicleComponent>();
			Entity entity = (characterDriveVehicleComponent != null) ? characterDriveVehicleComponent.VehicleEntity : null;
			if (entity == null || !entity.Valid)
			{
				return;
			}
			VehicleMoveComponent vehicleMoveComponent = entity.CheckGetComponent<VehicleMoveComponent>();
			VehicleActorComponent vehicleActorComponent = entity.CheckGetComponent<VehicleActorComponent>();
			if (vehicleMoveComponent == null || !vehicleMoveComponent.Valid || (vehicleActorComponent == null || !vehicleActorComponent.Valid))
			{
				return;
			}
			ESetVehicleSpeedImmediatelyType type = setSpeedConfig.Type;
			if (type == ESetVehicleSpeedImmediatelyType.TotalSpeed)
			{
				double inB = LevelGamePlayController.Instance.ConstraintProcessedValue((setSpeedConfig as ISetTotalVehicleSpeedImmediately).Speed, vehicleActorComponent.ActorVelocityProxy.Size());
				vehicleActorComponent.ActorVelocityProxy.GetSafeNormal(MathUtils.Instance.CommonTempVector, 9.99999993922529E-09);
				vehicleMoveComponent.SetForceSpeed(MathUtils.Instance.CommonTempVector.MultiplyEqual(inB));
				return;
			}
			if (type != ESetVehicleSpeedImmediatelyType.HorizontalVerticalSpeed)
			{
				return;
			}
			ISetHorizontalVerticalSpeedImmediately setHorizontalVerticalSpeedImmediately = setSpeedConfig as ISetHorizontalVerticalSpeedImmediately;
			MathUtils.Instance.CommonTempVector2.DeepCopy(vehicleActorComponent.ActorVelocityProxy);
			double num = GravityUtils.Instance.GetZnInGravityForActor(vehicleActorComponent, vehicleActorComponent.ActorVelocityProxy);
			if (setHorizontalVerticalSpeedImmediately.VerticalSpeed != null)
			{
				num = LevelGamePlayController.Instance.ConstraintProcessedValue(setHorizontalVerticalSpeedImmediately.VerticalSpeed, num);
			}
			if (setHorizontalVerticalSpeedImmediately.HorizontalSpeed != null)
			{
				MathUtils.Instance.CommonTempVector.DeepCopy(vehicleActorComponent.ActorVelocityProxy);
				GravityUtils.Instance.ConvertToPlanarVectorForActor(vehicleActorComponent, MathUtils.Instance.CommonTempVector);
				double inB2 = LevelGamePlayController.Instance.ConstraintProcessedValue(setHorizontalVerticalSpeedImmediately.HorizontalSpeed, MathUtils.Instance.CommonTempVector.Size());
				MathUtils.Instance.CommonTempVector.GetSafeNormal(MathUtils.Instance.CommonTempVector2, 9.99999993922529E-09);
				MathUtils.Instance.CommonTempVector2.MultiplyEqual(inB2);
			}
			GravityUtils.Instance.SetZnInGravityForActor(vehicleActorComponent, MathUtils.Instance.CommonTempVector2, num);
			vehicleMoveComponent.SetForceSpeed(MathUtils.Instance.CommonTempVector2);
		}
	}
}
