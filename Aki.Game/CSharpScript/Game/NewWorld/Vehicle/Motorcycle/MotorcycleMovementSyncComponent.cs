using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Vehicle.Motorcycle
{
	// Token: 0x02007025 RID: 28709
	public class MotorcycleMovementSyncComponent : VehicleMovementSyncComponent
	{
		// Token: 0x06045E28 RID: 286248 RVA: 0x01162BD4 File Offset: 0x01160DD4
		private void MotorSubStateChanged(EMotorSubState newState, EMotorSubState oldState)
		{
			if (!this.ActorComp.IsMoveAutonomousProxy)
			{
				return;
			}
			MotorPositionStatePush motorPositionStatePush = MotorPositionStatePush.Create();
			motorPositionStatePush.PositionState = (int)newState;
			motorPositionStatePush.EntityId = MathUtils.Instance.NumberToLong(this.ActorComp.CreatureData.GetCreatureDataId());
			Net.Instance.Send(EPushMessageId.MotorPositionStatePush, motorPositionStatePush);
		}

		// Token: 0x06045E29 RID: 286249 RVA: 0x01162C2C File Offset: 0x01160E2C
		protected override void OnPostActivate()
		{
			base.OnPostActivate();
			EventSystem.Instance.AddWithTarget<EMotorSubState, EMotorSubState>(base.Entity, EEventName.MotorSubStateModeChange, new Action<EMotorSubState, EMotorSubState>(this.MotorSubStateChanged));
		}

		// Token: 0x06045E2A RID: 286250 RVA: 0x01162C56 File Offset: 0x01160E56
		protected override bool OnEnd()
		{
			EventSystem.Instance.RemoveWithTarget<EMotorSubState, EMotorSubState>(base.Entity, EEventName.MotorSubStateModeChange, new Action<EMotorSubState, EMotorSubState>(this.MotorSubStateChanged));
			return base.OnEnd();
		}

		// Token: 0x06045E2B RID: 286251 RVA: 0x01162C80 File Offset: 0x01160E80
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			MotorcycleMovementSyncComponent motorcycleMovementSyncComponent = (MotorcycleMovementSyncComponent)componentTemplate;
			return true;
		}
	}
}
