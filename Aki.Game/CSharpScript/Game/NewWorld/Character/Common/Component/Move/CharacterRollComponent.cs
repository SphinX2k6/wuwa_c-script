using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move
{
	// Token: 0x020070FB RID: 28923
	[NullableContext(1)]
	[Nullable(0)]
	public class CharacterRollComponent : EntityComponent, IComponentDependency
	{
		// Token: 0x17009D08 RID: 40200
		// (get) Token: 0x060469DB RID: 289243 RVA: 0x011C42BC File Offset: 0x011C24BC
		public static Type[] Dependencies
		{
			get
			{
				return new Type[]
				{
					typeof(CharacterMoveComponent)
				};
			}
		}

		// Token: 0x060469DC RID: 289244 RVA: 0x011C42D4 File Offset: 0x011C24D4
		private void OnMoveRoll(float deltaSeconds)
		{
			UKuroMovementBPLibrary.KuroRoll(deltaSeconds, this.MoveComp.CharacterMovement, this.TargetSpeed, this.Friction, this.AccelOnGround, ref this.RefFloorNormal, this.Gravity, this.StepUpHeight, this.MaxSpeed);
		}

		// Token: 0x060469DD RID: 289245 RVA: 0x011C431D File Offset: 0x011C251D
		protected override bool OnInit()
		{
			return true;
		}

		// Token: 0x060469DE RID: 289246 RVA: 0x011C4320 File Offset: 0x011C2520
		protected override bool OnStart()
		{
			this.MoveComp = base.Entity.GetComponent<CharacterMoveComponent>();
			EventSystem.Instance.AddWithTarget<float>(base.Entity, EEventName.CustomMoveRoll, new Action<float>(this.OnMoveRoll));
			return true;
		}

		// Token: 0x060469DF RID: 289247 RVA: 0x011C4353 File Offset: 0x011C2553
		protected override bool OnEnd()
		{
			EventSystem.Instance.RemoveWithTarget<float>(base.Entity, EEventName.CustomMoveRoll, new Action<float>(this.OnMoveRoll));
			return true;
		}

		// Token: 0x060469E0 RID: 289248 RVA: 0x011C4378 File Offset: 0x011C2578
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

		// Token: 0x060469E1 RID: 289249 RVA: 0x011C43F0 File Offset: 0x011C25F0
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

		// Token: 0x060469E2 RID: 289250 RVA: 0x011C4428 File Offset: 0x011C2628
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			CharacterRollComponent characterRollComponent = (CharacterRollComponent)componentTemplate;
			if (base.CanResetComponentProperty("MoveComp"))
			{
				if (characterRollComponent.MoveComp == null)
				{
					this.MoveComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterMoveComponent>(this.MoveComp), "MoveComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("RefFloorNormal"))
			{
				this.RefFloorNormal = characterRollComponent.RefFloorNormal;
			}
			if (base.CanResetComponentProperty("TargetSpeed"))
			{
				this.TargetSpeed = characterRollComponent.TargetSpeed;
			}
			if (base.CanResetComponentProperty("Friction"))
			{
				this.Friction = characterRollComponent.Friction;
			}
			if (base.CanResetComponentProperty("AccelOnGround"))
			{
				this.AccelOnGround = characterRollComponent.AccelOnGround;
			}
			if (base.CanResetComponentProperty("Gravity"))
			{
				this.Gravity = characterRollComponent.Gravity;
			}
			if (base.CanResetComponentProperty("StepUpHeight"))
			{
				this.StepUpHeight = characterRollComponent.StepUpHeight;
			}
			if (base.CanResetComponentProperty("MaxSpeed"))
			{
				this.MaxSpeed = characterRollComponent.MaxSpeed;
			}
			return true;
		}

		// Token: 0x040250D8 RID: 151768
		[Nullable(2)]
		private CharacterMoveComponent MoveComp;

		// Token: 0x040250D9 RID: 151769
		private FVector RefFloorNormal = new FVector();

		// Token: 0x040250DA RID: 151770
		private float TargetSpeed = 1200f;

		// Token: 0x040250DB RID: 151771
		private float Friction = 0.1f;

		// Token: 0x040250DC RID: 151772
		private float AccelOnGround = 1000f;

		// Token: 0x040250DD RID: 151773
		private float Gravity = 1960f;

		// Token: 0x040250DE RID: 151774
		private float StepUpHeight = 100f;

		// Token: 0x040250DF RID: 151775
		private float MaxSpeed = 4000f;
	}
}
