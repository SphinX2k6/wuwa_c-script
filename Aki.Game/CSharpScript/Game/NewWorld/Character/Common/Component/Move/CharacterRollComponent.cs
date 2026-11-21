using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move
{
	// Token: 0x020063AB RID: 25515
	[NullableContext(1)]
	[Nullable(0)]
	public class CharacterRollComponent : EntityComponent
	{
		// Token: 0x17007591 RID: 30097
		// (get) Token: 0x0603DDD4 RID: 253396 RVA: 0x011F3470 File Offset: 0x011F1670
		public override Type[] Dependencies
		{
			get
			{
				return new Type[]
				{
					typeof(CharacterMoveComponent)
				};
			}
		}

		// Token: 0x0603DDD5 RID: 253397 RVA: 0x011F3488 File Offset: 0x011F1688
		private void OnMoveRoll(float deltaSeconds)
		{
			UKuroMovementBPLibrary.KuroRoll(deltaSeconds, this.MoveComp.CharacterMovement, this.TargetSpeed, this.Friction, this.AccelOnGround, ref this.RefFloorNormal, this.Gravity, this.StepUpHeight, this.MaxSpeed);
		}

		// Token: 0x0603DDD6 RID: 253398 RVA: 0x011F34D1 File Offset: 0x011F16D1
		protected override bool OnInit()
		{
			return true;
		}

		// Token: 0x0603DDD7 RID: 253399 RVA: 0x011F34D4 File Offset: 0x011F16D4
		protected override bool OnStart()
		{
			this.MoveComp = base.Entity.GetComponent<CharacterMoveComponent>();
			EventSystem.Instance.AddWithTarget<float>(base.Entity, EEventName.CustomMoveRoll, new Action<float>(this.OnMoveRoll));
			return true;
		}

		// Token: 0x0603DDD8 RID: 253400 RVA: 0x011F350A File Offset: 0x011F170A
		protected override bool OnEnd()
		{
			EventSystem.Instance.RemoveWithTarget<float>(base.Entity, EEventName.CustomMoveRoll, new Action<float>(this.OnMoveRoll));
			return true;
		}

		// Token: 0x0603DDD9 RID: 253401 RVA: 0x011F3530 File Offset: 0x011F1730
		public void EnterRoll(float targetSpeed, float friction, float accelOnGround, float gravity, float stepUpHeight, float maxSpeed)
		{
			this.TargetSpeed = targetSpeed;
			this.Friction = friction;
			this.AccelOnGround = accelOnGround;
			this.Gravity = gravity;
			this.StepUpHeight = stepUpHeight;
			this.MaxSpeed = maxSpeed;
			CharacterMoveComponent moveComp = this.MoveComp;
			if (moveComp == null)
			{
				return;
			}
			CharacterActorComponent actorComp = moveComp.ActorComp;
			if (actorComp == null)
			{
				return;
			}
			actorComp.Actor.KuroSetMovementMode(new SetMovementModeInfo
			{
				Mode = EMovementMode.MOVE_Custom,
				CustomMode = 9,
				Context = "[CharacterRollComponent.EnterRoll]"
			});
		}

		// Token: 0x0603DDDA RID: 253402 RVA: 0x011F35A8 File Offset: 0x011F17A8
		public void LeaveRoll()
		{
			CharacterMoveComponent moveComp = this.MoveComp;
			if (moveComp == null)
			{
				return;
			}
			CharacterActorComponent actorComp = moveComp.ActorComp;
			if (actorComp == null)
			{
				return;
			}
			actorComp.Actor.KuroSetMovementMode(new SetMovementModeInfo
			{
				Mode = EMovementMode.MOVE_Falling,
				Context = "[CharacterRollComponent.LeaveRoll]"
			});
		}

		// Token: 0x0603DDDB RID: 253403 RVA: 0x011F35E0 File Offset: 0x011F17E0
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			CharacterRollComponent characterRollComponent = (CharacterRollComponent)componentTemplate;
			if (characterRollComponent.MoveComp == null)
			{
				this.MoveComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MoveComp), "MoveComp"))
			{
				return false;
			}
			this.RefFloorNormal = characterRollComponent.RefFloorNormal;
			this.TargetSpeed = characterRollComponent.TargetSpeed;
			this.Friction = characterRollComponent.Friction;
			this.AccelOnGround = characterRollComponent.AccelOnGround;
			this.Gravity = characterRollComponent.Gravity;
			this.StepUpHeight = characterRollComponent.StepUpHeight;
			this.MaxSpeed = characterRollComponent.MaxSpeed;
			return true;
		}

		// Token: 0x17007592 RID: 30098
		// (get) Token: 0x0603DDDC RID: 253404 RVA: 0x011F367F File Offset: 0x011F187F
		public override bool NeedInitInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007593 RID: 30099
		// (get) Token: 0x0603DDDD RID: 253405 RVA: 0x011F3682 File Offset: 0x011F1882
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007594 RID: 30100
		// (get) Token: 0x0603DDDE RID: 253406 RVA: 0x011F3685 File Offset: 0x011F1885
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x04020D6D RID: 134509
		[Nullable(2)]
		private CharacterMoveComponent MoveComp;

		// Token: 0x04020D6E RID: 134510
		private FVector RefFloorNormal = new FVector();

		// Token: 0x04020D6F RID: 134511
		private float TargetSpeed = 1200f;

		// Token: 0x04020D70 RID: 134512
		private float Friction = 0.1f;

		// Token: 0x04020D71 RID: 134513
		private float AccelOnGround = 1000f;

		// Token: 0x04020D72 RID: 134514
		private float Gravity = 1960f;

		// Token: 0x04020D73 RID: 134515
		private float StepUpHeight = 100f;

		// Token: 0x04020D74 RID: 134516
		private float MaxSpeed = 4000f;
	}
}
