using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelFlow.Action
{
	// Token: 0x0200611B RID: 24859
	public class LevelFlowResetMotorSpeed : LevelFlowActionBase
	{
		// Token: 0x0603B90F RID: 243983 RVA: 0x010E466B File Offset: 0x010E286B
		[NullableContext(1)]
		public LevelFlowResetMotorSpeed Init(float speed)
		{
			this.Speed = speed;
			return this;
		}

		// Token: 0x0603B910 RID: 243984 RVA: 0x010E4678 File Offset: 0x010E2878
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

		// Token: 0x0401F69D RID: 128669
		private float Speed;
	}
}
