using System;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Vehicle.Motorcycle
{
	// Token: 0x020061A6 RID: 24998
	public class MotorcycleMovementSyncComponent : VehicleMovementSyncComponent
	{
		// Token: 0x0603BFF0 RID: 245744 RVA: 0x0110CD08 File Offset: 0x0110AF08
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

		// Token: 0x0603BFF1 RID: 245745 RVA: 0x0110CD60 File Offset: 0x0110AF60
		protected override void OnPostActivate()
		{
			base.OnPostActivate();
			EventSystem.Instance.AddWithTarget<EMotorSubState, EMotorSubState>(base.Entity, EEventName.MotorSubStateModeChange, new Action<EMotorSubState, EMotorSubState>(this.MotorSubStateChanged));
		}

		// Token: 0x0603BFF2 RID: 245746 RVA: 0x0110CD8A File Offset: 0x0110AF8A
		protected override bool OnEnd()
		{
			EventSystem.Instance.RemoveWithTarget<EMotorSubState, EMotorSubState>(base.Entity, EEventName.MotorSubStateModeChange, new Action<EMotorSubState, EMotorSubState>(this.MotorSubStateChanged));
			return base.OnEnd();
		}

		// Token: 0x17007116 RID: 28950
		// (get) Token: 0x0603BFF3 RID: 245747 RVA: 0x0110CDB4 File Offset: 0x0110AFB4
		public override bool NeedInitInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007117 RID: 28951
		// (get) Token: 0x0603BFF4 RID: 245748 RVA: 0x0110CDB7 File Offset: 0x0110AFB7
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007118 RID: 28952
		// (get) Token: 0x0603BFF5 RID: 245749 RVA: 0x0110CDBA File Offset: 0x0110AFBA
		public override bool NeedActivateInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007119 RID: 28953
		// (get) Token: 0x0603BFF6 RID: 245750 RVA: 0x0110CDBD File Offset: 0x0110AFBD
		public override bool NeedPostActivateInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700711A RID: 28954
		// (get) Token: 0x0603BFF7 RID: 245751 RVA: 0x0110CDC0 File Offset: 0x0110AFC0
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700711B RID: 28955
		// (get) Token: 0x0603BFF8 RID: 245752 RVA: 0x0110CDC3 File Offset: 0x0110AFC3
		public override bool NeedTickInternal
		{
			get
			{
				return true;
			}
		}
	}
}
