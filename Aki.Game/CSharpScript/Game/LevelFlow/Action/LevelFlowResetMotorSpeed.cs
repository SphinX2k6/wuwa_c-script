using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelFlow.Action
{
	// Token: 0x02006F9A RID: 28570
	public class LevelFlowResetMotorSpeed : LevelFlowActionBase
	{
		// Token: 0x06045761 RID: 284513 RVA: 0x0113A867 File Offset: 0x01138A67
		[NullableContext(1)]
		public LevelFlowResetMotorSpeed Init(float speed)
		{
			this.Speed = speed;
			return this;
		}

		// Token: 0x06045762 RID: 284514 RVA: 0x0113A874 File Offset: 0x01138A74
		protected override void OnExecute()
		{
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			CharacterActorComponent characterActorComponent = (baseCharacter != null) ? baseCharacter.CharacterActorComponent : null;
			if (characterActorComponent == null)
			{
				base.FinishExecute(false);
				return;
			}
			Entity entity = characterActorComponent.Entity;
			CharacterDriveVehicleComponent characterDriveVehicleComponent = (entity != null) ? entity.CheckGetComponent<CharacterDriveVehicleComponent>() : null;
			if (characterDriveVehicleComponent != null)
			{
				Entity vehicleEntity = characterDriveVehicleComponent.VehicleEntity;
				if (vehicleEntity != null && vehicleEntity.Valid)
				{
					VehicleActorComponent vehicleActorComponent = characterDriveVehicleComponent.VehicleEntity.CheckGetComponent<VehicleActorComponent>();
					if (vehicleActorComponent == null)
					{
						base.FinishExecute(false);
						return;
					}
					Vector vector = Vector.Create(vehicleActorComponent.ActorForwardProxy);
					vector.Multiply((double)this.Speed, vector);
					vehicleActorComponent.SetActorVelocity(vector);
					base.FinishExecute(true);
					return;
				}
			}
			base.FinishExecute(false);
		}

		// Token: 0x040243E8 RID: 148456
		private float Speed;
	}
}
